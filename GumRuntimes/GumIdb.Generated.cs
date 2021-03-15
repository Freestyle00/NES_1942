    namespace FlatRedBall.Gum
    {
        public  class GumIdbExtensions
        {
            public static void RegisterTypes () 
            {
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Circle", typeof(NES_1942.GumRuntimes.CircleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ColoredRectangle", typeof(NES_1942.GumRuntimes.ColoredRectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container", typeof(NES_1942.GumRuntimes.ContainerRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container<T>", typeof(NES_1942.GumRuntimes.ContainerRuntime<>));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("NineSlice", typeof(NES_1942.GumRuntimes.NineSliceRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Polygon", typeof(NES_1942.GumRuntimes.PolygonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Rectangle", typeof(NES_1942.GumRuntimes.RectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Sprite", typeof(NES_1942.GumRuntimes.SpriteRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Text", typeof(NES_1942.GumRuntimes.TextRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Button", typeof(NES_1942.GumRuntimes.DefaultForms.ButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/CheckBox", typeof(NES_1942.GumRuntimes.DefaultForms.CheckBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ColoredFrame", typeof(NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ComboBox", typeof(NES_1942.GumRuntimes.DefaultForms.ComboBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/DialogBox", typeof(NES_1942.GumRuntimes.DefaultForms.DialogBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Keyboard", typeof(NES_1942.GumRuntimes.DefaultForms.KeyboardRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/KeyboardKey", typeof(NES_1942.GumRuntimes.DefaultForms.KeyboardKeyRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Label", typeof(NES_1942.GumRuntimes.DefaultForms.LabelRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ListBox", typeof(NES_1942.GumRuntimes.DefaultForms.ListBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ListBoxItem", typeof(NES_1942.GumRuntimes.DefaultForms.ListBoxItemRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/PasswordBox", typeof(NES_1942.GumRuntimes.DefaultForms.PasswordBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/RadioButton", typeof(NES_1942.GumRuntimes.DefaultForms.RadioButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollBar", typeof(NES_1942.GumRuntimes.DefaultForms.ScrollBarRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollBarThumb", typeof(NES_1942.GumRuntimes.DefaultForms.ScrollBarThumbRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollViewer", typeof(NES_1942.GumRuntimes.DefaultForms.ScrollViewerRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Slider", typeof(NES_1942.GumRuntimes.DefaultForms.SliderRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TextBox", typeof(NES_1942.GumRuntimes.DefaultForms.TextBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Toast", typeof(NES_1942.GumRuntimes.DefaultForms.ToastRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ToggleButton", typeof(NES_1942.GumRuntimes.DefaultForms.ToggleButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeView", typeof(NES_1942.GumRuntimes.DefaultForms.TreeViewRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeViewItem", typeof(NES_1942.GumRuntimes.DefaultForms.TreeViewItemRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeViewToggleButton", typeof(NES_1942.GumRuntimes.DefaultForms.TreeViewToggleButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/UserControl", typeof(NES_1942.GumRuntimes.DefaultForms.UserControlRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Retrys", typeof(NES_1942.GumRuntimes.RetrysRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ScoreCounter", typeof(NES_1942.GumRuntimes.ScoreCounterRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("GameOverGum", typeof(NES_1942.GumRuntimes.GameOverGumRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("HUD", typeof(NES_1942.GumRuntimes.HUDRuntime));
            }
        }
    }
