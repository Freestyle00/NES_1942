using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using NES_1942.Entities;
using NES_1942.Screens;
using NES_1942.Factories;
using NES_1942.GumRuntimes;

namespace NES_1942.Screens
{
    public partial class GameScreen
    {
        int HP = 3;
        void OnBulletListVsenemy_planesListCollisionOccurred (Entities.Bullet first, Entities.enemy_planes second) 
        {
            BBOOMM.Play();
            Entities.BOOOM newanimation = BOOOMFactory.CreateNew();
            newanimation.X = second.X;
            newanimation.Y = second.Y;
            Entities.Scores newscore500 = ScoresFactory.CreateNew();
            newscore500.X = second.X;
            newscore500.Y = second.Y;
            var gumTextObject = HUD.GetGraphicalUiElementByName("ScoreCounterInstance") as ScoreCounterRuntime;
             NES_1942.variables.scorespublic += 500;
            gumTextObject.ScorePointsText = NES_1942.variables.scorespublic.ToString();           
            first.Destroy();
            second.Destroy();
        }
        void OnPlayerPlaneInstanceVsenemy_planesListCollisionOccurred (NES_1942.Entities.PlayerPlane first, Entities.enemy_planes second) 
        {
            second.Destroy();
            var lifestext = HUD.GetGraphicalUiElementByName("ScoreCounterInstance") as NES_1942.GumRuntimes.ScoreCounterRuntime;
            NES_1942.variables.lifespublic--;
            lifestext.RetrysInstanceTextInstanceText = NES_1942.variables.lifespublic.ToString();
            if (NES_1942.variables.lifespublic <= 0)
            {
                this.MoveToScreen("NES_1942.Screens.GameOver");
            }
            else
            {
                RestartScreen(true, true);
            }
        }        
        void Onbullet_catchersListVsBulletListCollisionOccurred (Entities.bullet_catchers first, Entities.Bullet second) 
        {
            second.Destroy();
        }
        void Onbullet_catchers2Vsenemy_planesListCollisionOccurred (NES_1942.Entities.bullet_catchers first, Entities.enemy_planes second) 
        {
            second.Destroy();
        }
        void Onbullet_catchersListVsenemy_bulletListCollisionOccurred (Entities.bullet_catchers first, Entities.enemy_bullet second) 
        {
            second.Destroy();
        }
        void OnMore_Bullet_catchersListVsenemy_bulletListCollisionOccurred (Entities.More_Bullet_catchers first, Entities.enemy_bullet second) 
        {
            second.Destroy();
        }
        void OnPlayerPlaneInstanceVsenemy_bulletListCollisionOccurred (NES_1942.Entities.PlayerPlane first, Entities.enemy_bullet second) 
        {
            second.Destroy();
            HP--;
            if (HP <= 0)
            {
                var lifestext = HUD.GetGraphicalUiElementByName("ScoreCounterInstance") as NES_1942.GumRuntimes.ScoreCounterRuntime;
                lifestext.RetrysInstanceTextInstanceText = NES_1942.variables.lifespublic.ToString();
                NES_1942.variables.lifespublic--;
                if (NES_1942.variables.lifespublic <= 0)
                {
                    this.MoveToScreen("NES_1942.Screens.GameOver");
                }
                else
                {
                     RestartScreen(true, true);
                }
            }
        }
    }
}
