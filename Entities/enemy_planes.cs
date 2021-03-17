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
        float rads;
        private void CustomInitialize()
        {
            rads = MathHelper.ToRadians(100);
            this.RotationZ = MathHelper.ToRadians(rads);
        }
        private void CustomActivity()
        {
            var cx = (float)Math.Cos(rads);
            var cy = (float)Math.Sin(rads);

            var direction = new Vector3(cx, cy, 0);

            var speed = 100;

            var combined = direction * speed;

            this.Velocity = combined;

            var pixelsPerSecond = this.Velocity.Length();

            string debugginInfo = $"Player Velocity:{this.Velocity}" +

                $"\nPlayer Velocity Pixels/Second:{pixelsPerSecond}" +

                $"\nPlayer Right:{this.RotationMatrix.Right}";

            FlatRedBall.Debugging.Debugger.Write(debugginInfo);
        }
        private void CustomDestroy()
        {

        }
        private static void CustomLoadStaticContent(string contentManagerName)
        {

        }
    }
}
