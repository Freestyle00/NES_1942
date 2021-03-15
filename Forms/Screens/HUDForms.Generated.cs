    namespace NES_1942.FormsControls.Screens
    {
        public partial class HUDForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public HUDForms () 
            {
                CustomInitialize();
            }
            public HUDForms (Gum.Wireframe.GraphicalUiElement visual) 
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
