    namespace NES_1942.FormsControls.Screens
    {
        public partial class HUD_For_NES_1942Forms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public HUD_For_NES_1942Forms () 
            {
                CustomInitialize();
            }
            public HUD_For_NES_1942Forms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
            }
            partial void CustomInitialize();
        }
    }
