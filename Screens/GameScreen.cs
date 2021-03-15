using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using NES_1942.Factories;
using NES_1942.Entities;
namespace NES_1942.Screens
{
   public partial class GameScreen
    {
        void CustomInitialize()
        {
           
        }
        void CustomActivity(bool firstTimeCalled)
        {
            
            if (this.IsPaused == false)
            {
                Enemyspawn(); 
                Enemyplanesshootingattheplayer();
                Shooting();
            }
            pausescreen();
            var gumTextObject = HUD.GetGraphicalUiElementByName("ScoreCounterInstance") as NES_1942.GumRuntimes.ScoreCounterRuntime;
            gumTextObject.ScorePointsText = NES_1942.variables.scorespublic.ToString();
            var lifestext = HUD.GetGraphicalUiElementByName("ScoreCounterInstance") as NES_1942.GumRuntimes.ScoreCounterRuntime;
            lifestext.RetrysInstanceTextInstanceText = NES_1942.variables.lifespublic.ToString();
        }
        void CustomDestroy()
        {

        }
        static void CustomLoadStaticContent(string contentManagerName)
        {

        }
        void Shooting()
        {
            PlayerPlaneInstance.MovementInput = InputManager.Keyboard.Get2DInput(
            Microsoft.Xna.Framework.Input.Keys.A,
            Microsoft.Xna.Framework.Input.Keys.D,
            Microsoft.Xna.Framework.Input.Keys.W,
            Microsoft.Xna.Framework.Input.Keys.S);
            if (InputManager.Keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                NES_1942.Entities.Bullet newbullet = BulletFactory.CreateNew();
                newbullet.X = PlayerPlaneInstance.X -5;
                newbullet.Y = PlayerPlaneInstance.Y + 20;
                newbullet.Velocity.Y = 250;
                NES_1942.Entities.Bullet newbullet2 = BulletFactory.CreateNew();
                newbullet2.X = PlayerPlaneInstance.X + 5;
                newbullet2.Y = PlayerPlaneInstance.Y + 20;
                newbullet2.Velocity.Y = 250;
            }
        }
        double reloadingtime = 0.5;
        double timespentreloading = 0; 
        void Enemyplanesshootingattheplayer()
        { 
            timespentreloading -= TimeManager.SecondDifference;
            if (timespentreloading <= 0)
            {
                foreach (var plane in enemy_planesList)
                {
                    NES_1942.Entities.enemy_bullet shootme = Factories.enemy_bulletFactory.CreateNew();
                    shootme.X = plane.X;
                    shootme.Y = plane.Y;
                    double differencetoshoot = PlayerPlaneInstance.X - plane.X;
                    double differencetoshootY = PlayerPlaneInstance.Y - plane.Y;
                    float shootangle = (float)Math.Atan2(differencetoshootY, differencetoshoot);
                    shootme.RotationZ = shootangle;
                    shootme.Velocity.X = (float)Math.Cos(shootangle) * 250;
                    shootme.Velocity.Y = (float)Math.Sin(shootangle) * 250;
                    timespentreloading = reloadingtime;
                }
            }
        }
        void Enemyspawn()
        {
            lastspawn -= TimeManager.SecondDifference;
            if (lastspawn <= 0)
            {
                NES_1942.Entities.enemy_planes newenemy = enemy_planesFactory.CreateNew();
                newenemy.X = 100;
                newenemy.Y = 450;
                newenemy.Velocity.Y = -150;
            }
            if (lastspawn <= 0)
            {
                NES_1942.Entities.enemy_planes newenemy = enemy_planesFactory.CreateNew();
                newenemy.X = -100;
                newenemy.Y = 450;
                newenemy.Velocity.Y = -150;
            }
            if (lastspawn <= 0)
            {
                lastspawn = 3;
            }
        }
        void pausescreen()
        {
            var pausetext = "shutup";
            if (InputManager.Keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.P))
            {
                if (this.IsPaused)
                {
                    UnpauseThisScreen();
                }
                else
                {
                    PauseThisScreen();
                }
            }
            if (this.IsPaused == false)
            {
                
            }
            if (this.IsPaused)
            {

            }
        }
        double lastspawn = 0;
    }
}