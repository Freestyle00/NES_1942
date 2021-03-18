using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;

namespace NES_1942.Entities
{
    public partial class enemy_planes
    {
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        private void CustomInitialize()
        {

        }
        private void CustomActivity()
        {
            FlightPatterns();
            string debugginInfo = 
            $"\nPlayer Right:{this.Y}";
            FlatRedBall.Debugging.Debugger.Write(debugginInfo);
        }
        private void CustomDestroy()
        {

        }
        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }

        private void FlightPatterns()
        {
            if (this.Y <= 200 && this.Y >= 190)
            {
                TurnAndGo(45, 150, -45);
            }
            if (this.Y <= 100 && this.Y >= 90)
            {
                TurnAndGo(-45, 150, 225);
            }
            if (this.Y <= 0 && this.Y >= -10)
            {
                TurnAndGo(45, 150, -45);
            }
            if (this.Y <= -100 && this.Y >= -110)
            {
                TurnAndGo(-45, 150, 225);
            }
            //if (this.Y <= -150 && this.Y >= -160)
            //{
            //    TurnAndGo(45, 150, -45);
            //}
            //if (this.Y <= 0 && this.Y >= 0)
            //{

            //}
        }
        public void TurnAndGo(Single angle2, int speed, Single angleofvelocity)
        {
            Single angle = MathHelper.ToRadians(angle2);
            Single angleofvelocity2 = MathHelper.ToRadians(angleofvelocity);
            var cx = (float)Math.Cos(angleofvelocity2);
            var cy = (float)Math.Sin(angleofvelocity2);
            var direction = new Vector3(cx, cy, 0);
            this.RotationZ = angle;
            var combined = direction * speed;
            this.Velocity = combined;
            var pixelsPerSecond = this.Velocity.Length();
            string debugginInfo = $"Player Velocity:{this.Velocity}" +
                $"\nPlayer Velocity Pixels/Second:{pixelsPerSecond}" +
                $"\nPlayer Right:{this.RotationMatrix.Right}";
            FlatRedBall.Debugging.Debugger.Write(debugginInfo);
        }
    }
}
