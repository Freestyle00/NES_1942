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



namespace NES_1942.Screens
{
    public partial class GameOver
    {
        int scores = 0;
        void CustomInitialize()
        {
            var scoreshowerofthenoob = GameOverGum.GetGraphicalUiElementByName("scoreshower") as NES_1942.GumRuntimes.TextRuntime;
            scores = NES_1942.variables.scorespublic;
            scoreshowerofthenoob.Text = scores.ToString();
            gameovermusic.Play();
            NES_1942.variables.resetscores();
            NES_1942.variables.resetlifes();
        }

        void CustomActivity(bool firstTimeCalled)
        {
            if (InputManager.Keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.R))
            {
                this.MoveToScreen("NES_1942.Screens.Germany_from_above");
            }
        }

        void CustomDestroy()
        {


        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

    }
}
