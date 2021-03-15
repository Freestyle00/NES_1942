#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace NES_1942.Screens
{
    public partial class GameScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static Microsoft.Xna.Framework.Audio.SoundEffect BBOOMM;
        
        protected FlatRedBall.TileGraphics.LayeredTileMap Map;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Bullet> BulletList;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.enemy_planes> enemy_planesList;
        private NES_1942.Entities.PlayerPlane PlayerPlaneInstance;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Borders_left_right> BordersList;
        private NES_1942.Entities.Borders_left_right Borders_left_right1;
        private NES_1942.Entities.Borders_left_right Borders_left_right2;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Border_Down> Border_DownList;
        private NES_1942.Entities.Border_Down Border_Down1;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<NES_1942.Entities.PlayerPlane, Entities.enemy_planes> PlayerPlaneInstanceVsenemy_planesList;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<NES_1942.Entities.PlayerPlane, Entities.Borders_left_right> PlayerPlaneInstanceVsBordersList;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<NES_1942.Entities.PlayerPlane, Entities.Border_Down> PlayerPlaneInstanceVsBorder_DownList;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Border_up> Border_upList;
        private NES_1942.Entities.Border_up Border_up1;
        private FlatRedBall.Math.Collision.CollisionRelationship<NES_1942.Entities.Border_up, NES_1942.Entities.PlayerPlane> Border_up1VsPlayerPlaneInstance;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.BOOOM> BOOOMList;
        private FlatRedBall.Math.Collision.ListVsListRelationship<Entities.Bullet, Entities.enemy_planes> BulletListVsenemy_planesList;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.bullet_catchers> bullet_catchersList;
        private NES_1942.Entities.bullet_catchers bullet_catchers1;
        private NES_1942.Entities.bullet_catchers bullet_catchers2;
        private FlatRedBall.Math.Collision.ListVsListRelationship<Entities.bullet_catchers, Entities.Bullet> bullet_catchersListVsBulletList;
        private FlatRedBall.Math.Collision.PositionedObjectVsListRelationship<NES_1942.Entities.bullet_catchers, Entities.enemy_planes> bullet_catchers2Vsenemy_planesList;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.enemy_bullet> enemy_bulletList;
        private FlatRedBall.Math.Collision.ListVsListRelationship<Entities.bullet_catchers, Entities.enemy_bullet> bullet_catchersListVsenemy_bulletList;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.More_Bullet_catchers> More_Bullet_catchersList;
        private NES_1942.Entities.More_Bullet_catchers More_Bullet_catchers1;
        private NES_1942.Entities.More_Bullet_catchers More_Bullet_catchers2;
        private FlatRedBall.Math.Collision.ListVsListRelationship<Entities.More_Bullet_catchers, Entities.enemy_bullet> More_Bullet_catchersListVsenemy_bulletList;
        private FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Scores> ScoresList;
        public event System.Action<Entities.Bullet, Entities.enemy_planes> BulletListVsenemy_planesListCollisionOccurred;
        public event System.Action<NES_1942.Entities.PlayerPlane, Entities.enemy_planes> PlayerPlaneInstanceVsenemy_planesListCollisionOccurred;
        public event System.Action<Entities.bullet_catchers, Entities.Bullet> bullet_catchersListVsBulletListCollisionOccurred;
        public event System.Action<NES_1942.Entities.bullet_catchers, Entities.enemy_planes> bullet_catchers2Vsenemy_planesListCollisionOccurred;
        public event System.Action<Entities.bullet_catchers, Entities.enemy_bullet> bullet_catchersListVsenemy_bulletListCollisionOccurred;
        public event System.Action<Entities.More_Bullet_catchers, Entities.enemy_bullet> More_Bullet_catchersListVsenemy_bulletListCollisionOccurred;
        public GameScreen () 
        	: base ("GameScreen")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            BulletList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Bullet>();
            BulletList.Name = "BulletList";
            enemy_planesList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.enemy_planes>();
            enemy_planesList.Name = "enemy_planesList";
            PlayerPlaneInstance = new NES_1942.Entities.PlayerPlane(ContentManagerName, false);
            PlayerPlaneInstance.Name = "PlayerPlaneInstance";
            BordersList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Borders_left_right>();
            BordersList.Name = "BordersList";
            Borders_left_right1 = new NES_1942.Entities.Borders_left_right(ContentManagerName, false);
            Borders_left_right1.Name = "Borders_left_right1";
            Borders_left_right2 = new NES_1942.Entities.Borders_left_right(ContentManagerName, false);
            Borders_left_right2.Name = "Borders_left_right2";
            Border_DownList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Border_Down>();
            Border_DownList.Name = "Border_DownList";
            Border_Down1 = new NES_1942.Entities.Border_Down(ContentManagerName, false);
            Border_Down1.Name = "Border_Down1";
            Border_upList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Border_up>();
            Border_upList.Name = "Border_upList";
            Border_up1 = new NES_1942.Entities.Border_up(ContentManagerName, false);
            Border_up1.Name = "Border_up1";
            BOOOMList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.BOOOM>();
            BOOOMList.Name = "BOOOMList";
            bullet_catchersList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.bullet_catchers>();
            bullet_catchersList.Name = "bullet_catchersList";
            bullet_catchers1 = new NES_1942.Entities.bullet_catchers(ContentManagerName, false);
            bullet_catchers1.Name = "bullet_catchers1";
            bullet_catchers2 = new NES_1942.Entities.bullet_catchers(ContentManagerName, false);
            bullet_catchers2.Name = "bullet_catchers2";
            enemy_bulletList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.enemy_bullet>();
            enemy_bulletList.Name = "enemy_bulletList";
            More_Bullet_catchersList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.More_Bullet_catchers>();
            More_Bullet_catchersList.Name = "More_Bullet_catchersList";
            More_Bullet_catchers1 = new NES_1942.Entities.More_Bullet_catchers(ContentManagerName, false);
            More_Bullet_catchers1.Name = "More_Bullet_catchers1";
            More_Bullet_catchers2 = new NES_1942.Entities.More_Bullet_catchers(ContentManagerName, false);
            More_Bullet_catchers2.Name = "More_Bullet_catchers2";
            ScoresList = new FlatRedBall.Math.PositionedObjectList<NES_1942.Entities.Scores>();
            ScoresList.Name = "ScoresList";
                PlayerPlaneInstanceVsenemy_planesList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(PlayerPlaneInstance, enemy_planesList);
    PlayerPlaneInstanceVsenemy_planesList.Name = "PlayerPlaneInstanceVsenemy_planesList";
    PlayerPlaneInstanceVsenemy_planesList.SetMoveCollision(1f, 1f);

                PlayerPlaneInstanceVsBordersList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(PlayerPlaneInstance, BordersList);
    PlayerPlaneInstanceVsBordersList.Name = "PlayerPlaneInstanceVsBordersList";
    PlayerPlaneInstanceVsBordersList.SetMoveCollision(0f, 1f);

                PlayerPlaneInstanceVsBorder_DownList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(PlayerPlaneInstance, Border_DownList);
    PlayerPlaneInstanceVsBorder_DownList.Name = "PlayerPlaneInstanceVsBorder_DownList";
    PlayerPlaneInstanceVsBorder_DownList.SetMoveCollision(0f, 1f);

                Border_up1VsPlayerPlaneInstance = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(Border_up1, PlayerPlaneInstance);
    Border_up1VsPlayerPlaneInstance.Name = "Border_up1VsPlayerPlaneInstance";
    Border_up1VsPlayerPlaneInstance.SetMoveCollision(1f, 0f);

                BulletListVsenemy_planesList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(BulletList, enemy_planesList);
    BulletListVsenemy_planesList.CollisionLimit = FlatRedBall.Math.Collision.CollisionLimit.All;
    BulletListVsenemy_planesList.ListVsListLoopingMode = FlatRedBall.Math.Collision.ListVsListLoopingMode.PreventDoubleChecksPerFrame;
    BulletListVsenemy_planesList.Name = "BulletListVsenemy_planesList";

                bullet_catchersListVsBulletList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(bullet_catchersList, BulletList);
    bullet_catchersListVsBulletList.CollisionLimit = FlatRedBall.Math.Collision.CollisionLimit.All;
    bullet_catchersListVsBulletList.ListVsListLoopingMode = FlatRedBall.Math.Collision.ListVsListLoopingMode.PreventDoubleChecksPerFrame;
    bullet_catchersListVsBulletList.Name = "bullet_catchersListVsBulletList";

                bullet_catchers2Vsenemy_planesList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(bullet_catchers2, enemy_planesList);
    bullet_catchers2Vsenemy_planesList.Name = "bullet_catchers2Vsenemy_planesList";

                bullet_catchersListVsenemy_bulletList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(bullet_catchersList, enemy_bulletList);
    bullet_catchersListVsenemy_bulletList.CollisionLimit = FlatRedBall.Math.Collision.CollisionLimit.All;
    bullet_catchersListVsenemy_bulletList.ListVsListLoopingMode = FlatRedBall.Math.Collision.ListVsListLoopingMode.PreventDoubleChecksPerFrame;
    bullet_catchersListVsenemy_bulletList.Name = "bullet_catchersListVsenemy_bulletList";

                More_Bullet_catchersListVsenemy_bulletList = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(More_Bullet_catchersList, enemy_bulletList);
    More_Bullet_catchersListVsenemy_bulletList.CollisionLimit = FlatRedBall.Math.Collision.CollisionLimit.All;
    More_Bullet_catchersListVsenemy_bulletList.ListVsListLoopingMode = FlatRedBall.Math.Collision.ListVsListLoopingMode.PreventDoubleChecksPerFrame;
    More_Bullet_catchersListVsenemy_bulletList.Name = "More_Bullet_catchersListVsenemy_bulletList";

            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            Factories.BulletFactory.Initialize(ContentManagerName);
            Factories.enemy_planesFactory.Initialize(ContentManagerName);
            Factories.Borders_left_rightFactory.Initialize(ContentManagerName);
            Factories.Border_DownFactory.Initialize(ContentManagerName);
            Factories.Border_upFactory.Initialize(ContentManagerName);
            Factories.BOOOMFactory.Initialize(ContentManagerName);
            Factories.bullet_catchersFactory.Initialize(ContentManagerName);
            Factories.enemy_bulletFactory.Initialize(ContentManagerName);
            Factories.More_Bullet_catchersFactory.Initialize(ContentManagerName);
            Factories.ScoresFactory.Initialize(ContentManagerName);
            Factories.BulletFactory.AddList(BulletList);
            Factories.enemy_planesFactory.AddList(enemy_planesList);
            Factories.Borders_left_rightFactory.AddList(BordersList);
            Factories.Border_DownFactory.AddList(Border_DownList);
            Factories.Border_upFactory.AddList(Border_upList);
            Factories.BOOOMFactory.AddList(BOOOMList);
            Factories.bullet_catchersFactory.AddList(bullet_catchersList);
            Factories.enemy_bulletFactory.AddList(enemy_bulletList);
            Factories.More_Bullet_catchersFactory.AddList(More_Bullet_catchersList);
            Factories.ScoresFactory.AddList(ScoresList);
            PlayerPlaneInstance.AddToManagers(mLayer);
            Borders_left_right1.AddToManagers(mLayer);
            Borders_left_right2.AddToManagers(mLayer);
            Border_Down1.AddToManagers(mLayer);
            Border_up1.AddToManagers(mLayer);
            bullet_catchers1.AddToManagers(mLayer);
            bullet_catchers2.AddToManagers(mLayer);
            More_Bullet_catchers1.AddToManagers(mLayer);
            More_Bullet_catchers2.AddToManagers(mLayer);
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                for (int i = BulletList.Count - 1; i > -1; i--)
                {
                    if (i < BulletList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        BulletList[i].Activity();
                    }
                }
                for (int i = enemy_planesList.Count - 1; i > -1; i--)
                {
                    if (i < enemy_planesList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        enemy_planesList[i].Activity();
                    }
                }
                PlayerPlaneInstance.Activity();
                for (int i = BordersList.Count - 1; i > -1; i--)
                {
                    if (i < BordersList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        BordersList[i].Activity();
                    }
                }
                for (int i = Border_DownList.Count - 1; i > -1; i--)
                {
                    if (i < Border_DownList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        Border_DownList[i].Activity();
                    }
                }
                for (int i = Border_upList.Count - 1; i > -1; i--)
                {
                    if (i < Border_upList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        Border_upList[i].Activity();
                    }
                }
                for (int i = BOOOMList.Count - 1; i > -1; i--)
                {
                    if (i < BOOOMList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        BOOOMList[i].Activity();
                    }
                }
                for (int i = bullet_catchersList.Count - 1; i > -1; i--)
                {
                    if (i < bullet_catchersList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        bullet_catchersList[i].Activity();
                    }
                }
                for (int i = enemy_bulletList.Count - 1; i > -1; i--)
                {
                    if (i < enemy_bulletList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        enemy_bulletList[i].Activity();
                    }
                }
                for (int i = More_Bullet_catchersList.Count - 1; i > -1; i--)
                {
                    if (i < More_Bullet_catchersList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        More_Bullet_catchersList[i].Activity();
                    }
                }
                for (int i = ScoresList.Count - 1; i > -1; i--)
                {
                    if (i < ScoresList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        ScoresList[i].Activity();
                    }
                }
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Factories.BulletFactory.Destroy();
            Factories.enemy_planesFactory.Destroy();
            Factories.Borders_left_rightFactory.Destroy();
            Factories.Border_DownFactory.Destroy();
            Factories.Border_upFactory.Destroy();
            Factories.BOOOMFactory.Destroy();
            Factories.bullet_catchersFactory.Destroy();
            Factories.enemy_bulletFactory.Destroy();
            Factories.More_Bullet_catchersFactory.Destroy();
            Factories.ScoresFactory.Destroy();
            BBOOMM = null;
            
            BulletList.MakeOneWay();
            enemy_planesList.MakeOneWay();
            BordersList.MakeOneWay();
            Border_DownList.MakeOneWay();
            Border_upList.MakeOneWay();
            BOOOMList.MakeOneWay();
            bullet_catchersList.MakeOneWay();
            enemy_bulletList.MakeOneWay();
            More_Bullet_catchersList.MakeOneWay();
            ScoresList.MakeOneWay();
            for (int i = BulletList.Count - 1; i > -1; i--)
            {
                BulletList[i].Destroy();
            }
            for (int i = enemy_planesList.Count - 1; i > -1; i--)
            {
                enemy_planesList[i].Destroy();
            }
            if (PlayerPlaneInstance != null)
            {
                PlayerPlaneInstance.Destroy();
                PlayerPlaneInstance.Detach();
            }
            for (int i = BordersList.Count - 1; i > -1; i--)
            {
                BordersList[i].Destroy();
            }
            for (int i = Border_DownList.Count - 1; i > -1; i--)
            {
                Border_DownList[i].Destroy();
            }
            for (int i = Border_upList.Count - 1; i > -1; i--)
            {
                Border_upList[i].Destroy();
            }
            for (int i = BOOOMList.Count - 1; i > -1; i--)
            {
                BOOOMList[i].Destroy();
            }
            for (int i = bullet_catchersList.Count - 1; i > -1; i--)
            {
                bullet_catchersList[i].Destroy();
            }
            for (int i = enemy_bulletList.Count - 1; i > -1; i--)
            {
                enemy_bulletList[i].Destroy();
            }
            for (int i = More_Bullet_catchersList.Count - 1; i > -1; i--)
            {
                More_Bullet_catchersList[i].Destroy();
            }
            for (int i = ScoresList.Count - 1; i > -1; i--)
            {
                ScoresList[i].Destroy();
            }
            BulletList.MakeTwoWay();
            enemy_planesList.MakeTwoWay();
            BordersList.MakeTwoWay();
            Border_DownList.MakeTwoWay();
            Border_upList.MakeTwoWay();
            BOOOMList.MakeTwoWay();
            bullet_catchersList.MakeTwoWay();
            enemy_bulletList.MakeTwoWay();
            More_Bullet_catchersList.MakeTwoWay();
            ScoresList.MakeTwoWay();
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            BulletListVsenemy_planesList.CollisionOccurred += OnBulletListVsenemy_planesListCollisionOccurred;
            BulletListVsenemy_planesList.CollisionOccurred += OnBulletListVsenemy_planesListCollisionOccurredTunnel;
            PlayerPlaneInstanceVsenemy_planesList.CollisionOccurred += OnPlayerPlaneInstanceVsenemy_planesListCollisionOccurred;
            PlayerPlaneInstanceVsenemy_planesList.CollisionOccurred += OnPlayerPlaneInstanceVsenemy_planesListCollisionOccurredTunnel;
            bullet_catchersListVsBulletList.CollisionOccurred += Onbullet_catchersListVsBulletListCollisionOccurred;
            bullet_catchersListVsBulletList.CollisionOccurred += Onbullet_catchersListVsBulletListCollisionOccurredTunnel;
            bullet_catchers2Vsenemy_planesList.CollisionOccurred += Onbullet_catchers2Vsenemy_planesListCollisionOccurred;
            bullet_catchers2Vsenemy_planesList.CollisionOccurred += Onbullet_catchers2Vsenemy_planesListCollisionOccurredTunnel;
            bullet_catchersListVsenemy_bulletList.CollisionOccurred += Onbullet_catchersListVsenemy_bulletListCollisionOccurred;
            bullet_catchersListVsenemy_bulletList.CollisionOccurred += Onbullet_catchersListVsenemy_bulletListCollisionOccurredTunnel;
            More_Bullet_catchersListVsenemy_bulletList.CollisionOccurred += OnMore_Bullet_catchersListVsenemy_bulletListCollisionOccurred;
            More_Bullet_catchersListVsenemy_bulletList.CollisionOccurred += OnMore_Bullet_catchersListVsenemy_bulletListCollisionOccurredTunnel;
            if (Map!= null)
            {
            }
            if (PlayerPlaneInstance.Parent == null)
            {
                PlayerPlaneInstance.Z = 1f;
            }
            else
            {
                PlayerPlaneInstance.RelativeZ = 1f;
            }
            BordersList.Add(Borders_left_right1);
            if (Borders_left_right1.Parent == null)
            {
                Borders_left_right1.X = -180f;
            }
            else
            {
                Borders_left_right1.RelativeX = -180f;
            }
            BordersList.Add(Borders_left_right2);
            if (Borders_left_right2.Parent == null)
            {
                Borders_left_right2.X = 180f;
            }
            else
            {
                Borders_left_right2.RelativeX = 180f;
            }
            Border_DownList.Add(Border_Down1);
            if (Border_Down1.Parent == null)
            {
                Border_Down1.Y = -180f;
            }
            else
            {
                Border_Down1.RelativeY = -180f;
            }
            Border_upList.Add(Border_up1);
            if (Border_up1.Parent == null)
            {
                Border_up1.Y = 170f;
            }
            else
            {
                Border_up1.RelativeY = 170f;
            }
            bullet_catchersList.Add(bullet_catchers1);
            if (bullet_catchers1.Parent == null)
            {
                bullet_catchers1.Y = 200f;
            }
            else
            {
                bullet_catchers1.RelativeY = 200f;
            }
            bullet_catchersList.Add(bullet_catchers2);
            if (bullet_catchers2.Parent == null)
            {
                bullet_catchers2.Y = -200f;
            }
            else
            {
                bullet_catchers2.RelativeY = -200f;
            }
            More_Bullet_catchersList.Add(More_Bullet_catchers1);
            if (More_Bullet_catchers1.Parent == null)
            {
                More_Bullet_catchers1.X = 200f;
            }
            else
            {
                More_Bullet_catchers1.RelativeX = 200f;
            }
            More_Bullet_catchersList.Add(More_Bullet_catchers2);
            if (More_Bullet_catchers2.Parent == null)
            {
                More_Bullet_catchers2.X = -200f;
            }
            else
            {
                More_Bullet_catchers2.RelativeX = -200f;
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            for (int i = BulletList.Count - 1; i > -1; i--)
            {
                BulletList[i].Destroy();
            }
            for (int i = enemy_planesList.Count - 1; i > -1; i--)
            {
                enemy_planesList[i].Destroy();
            }
            PlayerPlaneInstance.RemoveFromManagers();
            for (int i = BordersList.Count - 1; i > -1; i--)
            {
                BordersList[i].Destroy();
            }
            for (int i = Border_DownList.Count - 1; i > -1; i--)
            {
                Border_DownList[i].Destroy();
            }
            for (int i = Border_upList.Count - 1; i > -1; i--)
            {
                Border_upList[i].Destroy();
            }
            for (int i = BOOOMList.Count - 1; i > -1; i--)
            {
                BOOOMList[i].Destroy();
            }
            for (int i = bullet_catchersList.Count - 1; i > -1; i--)
            {
                bullet_catchersList[i].Destroy();
            }
            for (int i = enemy_bulletList.Count - 1; i > -1; i--)
            {
                enemy_bulletList[i].Destroy();
            }
            for (int i = More_Bullet_catchersList.Count - 1; i > -1; i--)
            {
                More_Bullet_catchersList[i].Destroy();
            }
            for (int i = ScoresList.Count - 1; i > -1; i--)
            {
                ScoresList[i].Destroy();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                PlayerPlaneInstance.AssignCustomVariables(true);
                Borders_left_right1.AssignCustomVariables(true);
                Borders_left_right2.AssignCustomVariables(true);
                Border_Down1.AssignCustomVariables(true);
                Border_up1.AssignCustomVariables(true);
                bullet_catchers1.AssignCustomVariables(true);
                bullet_catchers2.AssignCustomVariables(true);
                More_Bullet_catchers1.AssignCustomVariables(true);
                More_Bullet_catchers2.AssignCustomVariables(true);
            }
            if (Map != null)
            {
            }
            if (PlayerPlaneInstance.Parent == null)
            {
                PlayerPlaneInstance.Z = 1f;
            }
            else
            {
                PlayerPlaneInstance.RelativeZ = 1f;
            }
            if (Borders_left_right1.Parent == null)
            {
                Borders_left_right1.X = -180f;
            }
            else
            {
                Borders_left_right1.RelativeX = -180f;
            }
            if (Borders_left_right2.Parent == null)
            {
                Borders_left_right2.X = 180f;
            }
            else
            {
                Borders_left_right2.RelativeX = 180f;
            }
            if (Border_Down1.Parent == null)
            {
                Border_Down1.Y = -180f;
            }
            else
            {
                Border_Down1.RelativeY = -180f;
            }
            if (Border_up1.Parent == null)
            {
                Border_up1.Y = 170f;
            }
            else
            {
                Border_up1.RelativeY = 170f;
            }
            if (bullet_catchers1.Parent == null)
            {
                bullet_catchers1.Y = 200f;
            }
            else
            {
                bullet_catchers1.RelativeY = 200f;
            }
            if (bullet_catchers2.Parent == null)
            {
                bullet_catchers2.Y = -200f;
            }
            else
            {
                bullet_catchers2.RelativeY = -200f;
            }
            if (More_Bullet_catchers1.Parent == null)
            {
                More_Bullet_catchers1.X = 200f;
            }
            else
            {
                More_Bullet_catchers1.RelativeX = 200f;
            }
            if (More_Bullet_catchers2.Parent == null)
            {
                More_Bullet_catchers2.X = -200f;
            }
            else
            {
                More_Bullet_catchers2.RelativeX = -200f;
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            if (Map != null)
            {
            }
            for (int i = 0; i < BulletList.Count; i++)
            {
                BulletList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < enemy_planesList.Count; i++)
            {
                enemy_planesList[i].ConvertToManuallyUpdated();
            }
            PlayerPlaneInstance.ConvertToManuallyUpdated();
            for (int i = 0; i < BordersList.Count; i++)
            {
                BordersList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < Border_DownList.Count; i++)
            {
                Border_DownList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < Border_upList.Count; i++)
            {
                Border_upList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < BOOOMList.Count; i++)
            {
                BOOOMList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < bullet_catchersList.Count; i++)
            {
                bullet_catchersList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < enemy_bulletList.Count; i++)
            {
                enemy_bulletList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < More_Bullet_catchersList.Count; i++)
            {
                More_Bullet_catchersList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < ScoresList.Count; i++)
            {
                ScoresList[i].ConvertToManuallyUpdated();
            }
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            BBOOMM = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gamescreen/bboomm", contentManagerName);
            NES_1942.Entities.PlayerPlane.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "BBOOMM":
                    return BBOOMM;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "BBOOMM":
                    return BBOOMM;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "BBOOMM":
                    return BBOOMM;
            }
            return null;
        }
    }
}
