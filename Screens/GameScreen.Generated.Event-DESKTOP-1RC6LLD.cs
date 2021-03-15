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
namespace NES_1942.Screens
{
    public partial class GameScreen
    {
        void OnBulletListVsenemy_planesListCollisionOccurredTunnel (Entities.Bullet first, Entities.enemy_planes second) 
        {
            if (this.BulletListVsenemy_planesListCollisionOccurred != null)
            {
                BulletListVsenemy_planesListCollisionOccurred(first, second);
            }
        }
        void OnPlayerPlaneInstanceVsenemy_planesListCollisionOccurredTunnel (NES_1942.Entities.PlayerPlane first, Entities.enemy_planes second) 
        {
            if (this.PlayerPlaneInstanceVsenemy_planesListCollisionOccurred != null)
            {
                PlayerPlaneInstanceVsenemy_planesListCollisionOccurred(first, second);
            }
        }
        void Onbullet_catchersListVsBulletListCollisionOccurredTunnel (Entities.bullet_catchers first, Entities.Bullet second) 
        {
            if (this.bullet_catchersListVsBulletListCollisionOccurred != null)
            {
                bullet_catchersListVsBulletListCollisionOccurred(first, second);
            }
        }
        void Onbullet_catchers2Vsenemy_planesListCollisionOccurredTunnel (NES_1942.Entities.bullet_catchers first, Entities.enemy_planes second) 
        {
            if (this.bullet_catchers2Vsenemy_planesListCollisionOccurred != null)
            {
                bullet_catchers2Vsenemy_planesListCollisionOccurred(first, second);
            }
        }
    }
}
