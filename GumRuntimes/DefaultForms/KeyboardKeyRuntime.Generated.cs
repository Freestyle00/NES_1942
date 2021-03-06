    using System.Linq;
    namespace NES_1942.GumRuntimes.DefaultForms
    {
        public partial class KeyboardKeyRuntime : NES_1942.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ButtonCategory
            {
                Enabled,
                Disabled,
                Highlighted,
                Pushed,
                Focused,
                HighlightedFocused,
                DisabledFocused
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ButtonCategory? mCurrentButtonCategoryState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                            Height = 38f;
                            Width = 28f;
                            X = 0f;
                            Y = 15f;
                            KeyBackground.Height = -2f;
                            KeyBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyBackground.Width = -2f;
                            KeyBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            KeyBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            KeyBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            KeyBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KeyBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Height = 0f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Text = "A";
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public ButtonCategory? CurrentButtonCategoryState
            {
                get
                {
                    return mCurrentButtonCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentButtonCategoryState = value;
                        switch(mCurrentButtonCategoryState)
                        {
                            case  ButtonCategory.Enabled:
                                KeyBackground.CurrentColorCategoryState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                KeyBackground.CurrentVariableState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                                TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                                break;
                            case  ButtonCategory.Disabled:
                                KeyBackground.CurrentColorCategoryState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                KeyBackground.CurrentVariableState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                                TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                break;
                            case  ButtonCategory.Highlighted:
                                KeyBackground.CurrentColorCategoryState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                KeyBackground.CurrentVariableState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                                TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                                break;
                            case  ButtonCategory.Pushed:
                                KeyBackground.CurrentColorCategoryState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                                KeyBackground.CurrentVariableState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                                TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                                break;
                            case  ButtonCategory.Focused:
                                KeyBackground.CurrentColorCategoryState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                                KeyBackground.CurrentVariableState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                                TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                                break;
                            case  ButtonCategory.HighlightedFocused:
                                KeyBackground.CurrentColorCategoryState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                                TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                                break;
                            case  ButtonCategory.DisabledFocused:
                                KeyBackground.CurrentColorCategoryState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                                KeyBackground.CurrentVariableState = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                                TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                                break;
                        }
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setKeyBackgroundHeightFirstValue = false;
                bool setKeyBackgroundHeightSecondValue = false;
                float KeyBackgroundHeightFirstValue= 0;
                float KeyBackgroundHeightSecondValue= 0;
                bool setKeyBackgroundWidthFirstValue = false;
                bool setKeyBackgroundWidthSecondValue = false;
                float KeyBackgroundWidthFirstValue= 0;
                float KeyBackgroundWidthSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHeightFirstValue = true;
                        HeightFirstValue = 38f;
                        setKeyBackgroundHeightFirstValue = true;
                        KeyBackgroundHeightFirstValue = -2f;
                        if (interpolationValue < 1)
                        {
                            this.KeyBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setKeyBackgroundWidthFirstValue = true;
                        KeyBackgroundWidthFirstValue = -2f;
                        if (interpolationValue < 1)
                        {
                            this.KeyBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KeyBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "A";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 28f;
                        setXFirstValue = true;
                        XFirstValue = 0f;
                        setYFirstValue = true;
                        YFirstValue = 15f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 38f;
                        setKeyBackgroundHeightSecondValue = true;
                        KeyBackgroundHeightSecondValue = -2f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setKeyBackgroundWidthSecondValue = true;
                        KeyBackgroundWidthSecondValue = -2f;
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KeyBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "A";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 28f;
                        setXSecondValue = true;
                        XSecondValue = 0f;
                        setYSecondValue = true;
                        YSecondValue = 15f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setKeyBackgroundHeightFirstValue && setKeyBackgroundHeightSecondValue)
                {
                    KeyBackground.Height = KeyBackgroundHeightFirstValue * (1 - interpolationValue) + KeyBackgroundHeightSecondValue * interpolationValue;
                }
                if (setKeyBackgroundWidthFirstValue && setKeyBackgroundWidthSecondValue)
                {
                    KeyBackground.Width = KeyBackgroundWidthFirstValue * (1 - interpolationValue) + KeyBackgroundWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            public void InterpolateBetween (ButtonCategory firstState, ButtonCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setKeyBackgroundCurrentColorCategoryStateFirstValue = false;
                bool setKeyBackgroundCurrentColorCategoryStateSecondValue = false;
                NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory KeyBackgroundCurrentColorCategoryStateFirstValue= NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory KeyBackgroundCurrentColorCategoryStateSecondValue= NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                bool setKeyBackgroundCurrentVariableStateFirstValue = false;
                bool setKeyBackgroundCurrentVariableStateSecondValue = false;
                NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState KeyBackgroundCurrentVariableStateFirstValue= NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState KeyBackgroundCurrentVariableStateSecondValue= NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                switch(firstState)
                {
                    case  ButtonCategory.Enabled:
                        setKeyBackgroundCurrentColorCategoryStateFirstValue = true;
                        KeyBackgroundCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setKeyBackgroundCurrentVariableStateFirstValue = true;
                        KeyBackgroundCurrentVariableStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.Disabled:
                        setKeyBackgroundCurrentColorCategoryStateFirstValue = true;
                        KeyBackgroundCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setKeyBackgroundCurrentVariableStateFirstValue = true;
                        KeyBackgroundCurrentVariableStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ButtonCategory.Highlighted:
                        setKeyBackgroundCurrentColorCategoryStateFirstValue = true;
                        KeyBackgroundCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setKeyBackgroundCurrentVariableStateFirstValue = true;
                        KeyBackgroundCurrentVariableStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.Pushed:
                        setKeyBackgroundCurrentColorCategoryStateFirstValue = true;
                        KeyBackgroundCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setKeyBackgroundCurrentVariableStateFirstValue = true;
                        KeyBackgroundCurrentVariableStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.Focused:
                        setKeyBackgroundCurrentColorCategoryStateFirstValue = true;
                        KeyBackgroundCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setKeyBackgroundCurrentVariableStateFirstValue = true;
                        KeyBackgroundCurrentVariableStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        setKeyBackgroundCurrentColorCategoryStateFirstValue = true;
                        KeyBackgroundCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.DisabledFocused:
                        setKeyBackgroundCurrentColorCategoryStateFirstValue = true;
                        KeyBackgroundCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setKeyBackgroundCurrentVariableStateFirstValue = true;
                        KeyBackgroundCurrentVariableStateFirstValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                }
                switch(secondState)
                {
                    case  ButtonCategory.Enabled:
                        setKeyBackgroundCurrentColorCategoryStateSecondValue = true;
                        KeyBackgroundCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setKeyBackgroundCurrentVariableStateSecondValue = true;
                        KeyBackgroundCurrentVariableStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.Disabled:
                        setKeyBackgroundCurrentColorCategoryStateSecondValue = true;
                        KeyBackgroundCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setKeyBackgroundCurrentVariableStateSecondValue = true;
                        KeyBackgroundCurrentVariableStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                    case  ButtonCategory.Highlighted:
                        setKeyBackgroundCurrentColorCategoryStateSecondValue = true;
                        KeyBackgroundCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setKeyBackgroundCurrentVariableStateSecondValue = true;
                        KeyBackgroundCurrentVariableStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.Pushed:
                        setKeyBackgroundCurrentColorCategoryStateSecondValue = true;
                        KeyBackgroundCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Green;
                        setKeyBackgroundCurrentVariableStateSecondValue = true;
                        KeyBackgroundCurrentVariableStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.Focused:
                        setKeyBackgroundCurrentColorCategoryStateSecondValue = true;
                        KeyBackgroundCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Gray;
                        setKeyBackgroundCurrentVariableStateSecondValue = true;
                        KeyBackgroundCurrentVariableStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        setKeyBackgroundCurrentColorCategoryStateSecondValue = true;
                        KeyBackgroundCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Yellow;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        break;
                    case  ButtonCategory.DisabledFocused:
                        setKeyBackgroundCurrentColorCategoryStateSecondValue = true;
                        KeyBackgroundCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.ColorCategory.Black;
                        setKeyBackgroundCurrentVariableStateSecondValue = true;
                        KeyBackgroundCurrentVariableStateSecondValue = NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime.VariableState.Default;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setKeyBackgroundCurrentColorCategoryStateFirstValue && setKeyBackgroundCurrentColorCategoryStateSecondValue)
                {
                    KeyBackground.InterpolateBetween(KeyBackgroundCurrentColorCategoryStateFirstValue, KeyBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setKeyBackgroundCurrentVariableStateFirstValue && setKeyBackgroundCurrentVariableStateSecondValue)
                {
                    KeyBackground.InterpolateBetween(KeyBackgroundCurrentVariableStateFirstValue, KeyBackgroundCurrentVariableStateSecondValue, interpolationValue);
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentButtonCategoryState = firstState;
                }
                else
                {
                    mCurrentButtonCategoryState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (NES_1942.GumRuntimes.DefaultForms.KeyboardKeyRuntime.VariableState fromState,NES_1942.GumRuntimes.DefaultForms.KeyboardKeyRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (NES_1942.GumRuntimes.DefaultForms.KeyboardKeyRuntime.ButtonCategory fromState,NES_1942.GumRuntimes.DefaultForms.KeyboardKeyRuntime.ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ButtonCategory").States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentButtonCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                KeyBackground.StopAnimations();
            }
            public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
            {
                return base.GetAnimation(animationName);
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Height",
                            Type = "float",
                            Value = KeyBackground.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackground.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Width",
                            Type = "float",
                            Value = KeyBackground.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.X Units",
                            Type = "PositionUnitType",
                            Value = KeyBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyBackground.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyBackground.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 38f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 28f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Height",
                            Type = "float",
                            Value = KeyBackground.Height + -2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Height Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackground.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Width",
                            Type = "float",
                            Value = KeyBackground.Width + -2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Width Units",
                            Type = "DimensionUnitType",
                            Value = KeyBackground.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KeyBackground.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.X Units",
                            Type = "PositionUnitType",
                            Value = KeyBackground.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KeyBackground.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.Y Units",
                            Type = "PositionUnitType",
                            Value = KeyBackground.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "string",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.DisabledFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ButtonCategory.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "string",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Pushed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.Focused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.HighlightedFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                    case  ButtonCategory.DisabledFocused:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.ColorCategoryState",
                            Type = "ColorCategoryState",
                            Value = KeyBackground.CurrentColorCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KeyBackground.State",
                            Type = "State",
                            Value = KeyBackground.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.ColorCategoryState",
                            Type = "ColorCategory",
                            Value = TextInstance.CurrentColorCategoryState
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                    else if (category.Name == "ButtonCategory")
                    {
                        if(state.Name == "Enabled") this.mCurrentButtonCategoryState = ButtonCategory.Enabled;
                        if(state.Name == "Disabled") this.mCurrentButtonCategoryState = ButtonCategory.Disabled;
                        if(state.Name == "Highlighted") this.mCurrentButtonCategoryState = ButtonCategory.Highlighted;
                        if(state.Name == "Pushed") this.mCurrentButtonCategoryState = ButtonCategory.Pushed;
                        if(state.Name == "Focused") this.mCurrentButtonCategoryState = ButtonCategory.Focused;
                        if(state.Name == "HighlightedFocused") this.mCurrentButtonCategoryState = ButtonCategory.HighlightedFocused;
                        if(state.Name == "DisabledFocused") this.mCurrentButtonCategoryState = ButtonCategory.DisabledFocused;
                    }
                }
                base.ApplyState(state);
            }
            public NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime KeyBackground { get; set; }
            public NES_1942.GumRuntimes.TextRuntime TextInstance { get; set; }
            public string Text
            {
                get
                {
                    return TextInstance.Text;
                }
                set
                {
                    if (TextInstance.Text != value)
                    {
                        TextInstance.Text = value;
                        TextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler TextChanged;
            public KeyboardKeyRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "DefaultForms/KeyboardKey");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState () 
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers) 
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences () 
            {
                KeyBackground = this.GetGraphicalUiElementByName("KeyBackground") as NES_1942.GumRuntimes.DefaultForms.ColoredFrameRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as NES_1942.GumRuntimes.TextRuntime;
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer) 
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize () 
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
        }
    }
