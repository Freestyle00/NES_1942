using NES_1942.Entities;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using NES_1942.Performance;

namespace NES_1942.Factories
{
    public class More_Bullet_catchersFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static More_Bullet_catchers CreateNew (float x = 0, float y = 0) 
        {
            return CreateNew(null, x, y);
        }
        public static More_Bullet_catchers CreateNew (Layer layer, float x = 0, float y = 0) 
        {
            More_Bullet_catchers instance = null;
            instance = new More_Bullet_catchers(mContentManagerName ?? FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, false);
            instance.AddToManagers(layer);
            instance.X = x;
            instance.Y = y;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<More_Bullet_catchers>)
                {
                    var index = (list as PositionedObjectList<More_Bullet_catchers>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<More_Bullet_catchers>)
                {
                    var index = (list as PositionedObjectList<More_Bullet_catchers>).GetFirstAfter(y, Axis.Y, 0, list.Count);
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
                More_Bullet_catchers instance = new More_Bullet_catchers(mContentManagerName, false);
                mPool.AddToPool(instance);
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (More_Bullet_catchers objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (More_Bullet_catchers objectToMakeUnused, bool callDestroy) 
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : More_Bullet_catchers
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> listToRemove) where T : More_Bullet_catchers
        {
            ListsToAddTo.Remove(listToRemove as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
            static string mContentManagerName;
            static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
            static PoolList<More_Bullet_catchers> mPool = new PoolList<More_Bullet_catchers>();
            public static Action<More_Bullet_catchers> EntitySpawned;
            object IEntityFactory.CreateNew (float x = 0, float y = 0) 
            {
                return More_Bullet_catchersFactory.CreateNew(x, y);
            }
            object IEntityFactory.CreateNew (Layer layer) 
            {
                return More_Bullet_catchersFactory.CreateNew(layer);
            }
            void IEntityFactory.Initialize (string contentManagerName) 
            {
                More_Bullet_catchersFactory.Initialize(contentManagerName);
            }
            void IEntityFactory.ClearListsToAddTo () 
            {
                More_Bullet_catchersFactory.ClearListsToAddTo();
            }
            static More_Bullet_catchersFactory mSelf;
            public static More_Bullet_catchersFactory Self
            {
                get
                {
                    if (mSelf == null)
                    {
                        mSelf = new More_Bullet_catchersFactory();
                    }
                    return mSelf;
                }
            }
    }
}
