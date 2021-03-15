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
    public partial class Germany_from_above : GameScreen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.TileGraphics.LayeredTileMap Germany_from_above_tiled;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D map_sprites;
        
        FlatRedBall.Gum.GumIdb gumIdb;
        public Germany_from_above () 
        	: base ()
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = Germany_from_above_tiled;
            gumIdb = new FlatRedBall.Gum.GumIdb();
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            Germany_from_above_tiled.AddToManagers(mLayer);
            FlatRedBall.SpriteManager.AddDrawableBatch(gumIdb);
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                Germany_from_above_tiled?.AnimateSelf();;
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
            FlatRedBall.SpriteManager.RemoveDrawableBatch(gumIdb);
            base.Destroy();
            Germany_from_above_tiled.Destroy();
            Germany_from_above_tiled = null;
            map_sprites = null;
            
            if (Map != null)
            {
                Map.Destroy();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (Map.Parent == null)
            {
                base.Map.X = -240f;
            }
            else
            {
                base.Map.RelativeX = -240f;
            }
            if (Map.Parent == null)
            {
                base.Map.Y = 2900f;
            }
            else
            {
                base.Map.RelativeY = 2900f;
            }
            if (Map.Parent == null)
            {
                base.Map.Z = -2f;
            }
            else
            {
                base.Map.RelativeZ = -2f;
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            Germany_from_above_tiled.Destroy();
            if (Map != null)
            {
                Map.Destroy();
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
            if (Map.Parent == null)
            {
                base.Map.X = -240f;
            }
            else
            {
                base.Map.RelativeX = -240f;
            }
            if (Map.Parent == null)
            {
                base.Map.Y = 2900f;
            }
            else
            {
                base.Map.RelativeY = 2900f;
            }
            if (Map.Parent == null)
            {
                base.Map.Z = -2f;
            }
            else
            {
                base.Map.RelativeZ = -2f;
            }
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            NES_1942.Screens.GameScreen.LoadStaticContent(contentManagerName);
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
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
            Germany_from_above_tiled = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/germany_from_above/germany_from_above_tiled.tmx", contentManagerName);
            map_sprites = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/germany_from_above/map_sprites.png", contentManagerName);
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
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Germany_from_above_tiled":
                    return Germany_from_above_tiled;
                case  "map_sprites":
                    return map_sprites;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Germany_from_above_tiled":
                    return Germany_from_above_tiled;
                case  "map_sprites":
                    return map_sprites;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Germany_from_above_tiled":
                    return Germany_from_above_tiled;
                case  "map_sprites":
                    return map_sprites;
            }
            return null;
        }
    }
}
