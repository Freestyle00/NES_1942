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
    public partial class GameOver : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static NES_1942.GumRuntimes.GameOverGumRuntime GameOverGum;
        protected static Microsoft.Xna.Framework.Audio.SoundEffect gameovermusic;
        
        NES_1942.FormsControls.Screens.GameOverGumForms Forms;
        public GameOver () 
        	: base ("GameOver")
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Forms = new NES_1942.FormsControls.Screens.GameOverGumForms(GameOverGum);
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            GameOverGum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            base.AddToManagers();
            AddToManagersBottomUp();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
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
            GameOverGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            GameOverGum = null;
            gameovermusic = null;
            
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            GameOverGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
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
            if(GameOverGum == null) GameOverGum = (NES_1942.GumRuntimes.GameOverGumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("GameOverGum"), true);
            gameovermusic = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Audio.SoundEffect>(@"content/screens/gameover/gameovermusic", contentManagerName);
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
                case  "GameOverGum":
                    return GameOverGum;
                case  "gameovermusic":
                    return gameovermusic;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GameOverGum":
                    return GameOverGum;
                case  "gameovermusic":
                    return gameovermusic;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameOverGum":
                    return GameOverGum;
                case  "gameovermusic":
                    return gameovermusic;
            }
            return null;
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            GameOverGum.UpdateLayout();
        }
    }
}
