using NES_1942.Entities;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using NES_1942.Performance;

namespace NES_1942.Factories
{
    public class PlayerPlaneFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static PlayerPlane CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static PlayerPlane CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            PlayerPlane instance = null;
            instance = new PlayerPlane(mContentManagerName ?? FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, false);
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<PlayerPlane>)
                {
                    var index = (list as PositionedObjectList<PlayerPlane>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<PlayerPlane>)
                {
                    var index = (list as PositionedObjectList<PlayerPlane>).GetFirstAfter(y, Axis.Y, 0, list.Count);
                    list.Insert(index, instance);
                }
                else
                {
                    // Sort Z not supported
                    list.Add(instance);
                }
            }
            if (EntitySpawned != null)
            {
                EntitySpawned(instance);
            }
            return instance;
        }
        
        public static void Initialize (string contentManager) 
        {
            mContentManagerName = contentManager;
        }
        
        public static void Destroy () 
        {
            mContentManagerName = null;
            ListsToAddTo.Clear();
            SortAxis = null;
            mPool.Clear();
            EntitySpawned = null;
        }
        
        private static void FactoryInitialize () 
        {
            const int numberToPreAllocate = 20;
            for (int i = 0; i < numberToPreAllocate; i++)
            {
                PlayerPlane instance = new PlayerPlane(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (PlayerPlane objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (PlayerPlane objectToMakeUnused, bool callDestroy) 
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : PlayerPlane
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> listToRemove) where T : PlayerPlane
        {
            ListsToAddTo.Remove(listToRemove as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<PlayerPlane> mPool = new PoolList<PlayerPlane>();
            public static Action<PlayerPlane> EntitySpawned;
            object IEntityFactory.CreateNew (float x = 0, float y = 0) 
            {
                return PlayerPlaneFactory.CreateNew(x, y);
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return PlayerPlaneFactory.CreateNew(layer);
            }
            void IEntityFactory.Initialize (string contentManagerName) 
            {
                PlayerPlaneFactory.Initialize(contentManagerName);
            }
            void IEntityFactory.ClearListsToAddTo () 
            {
                PlayerPlaneFactory.ClearListsToAddTo();
            }
            static PlayerPlaneFactory mSelf;
            public static PlayerPlaneFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new PlayerPlaneFactory();
                    }
                    return mSelf;
                }
            }
    }
}
