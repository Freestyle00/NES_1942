    using System.Linq;
    namespace NES_1942.GumRuntimes
    {
        public partial class GameOverGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
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
                            TextInstance1.Parent = this.GetGraphicalUiElementByName("TextInstance");
                            scoreshowerscoretext.Parent = this.GetGraphicalUiElementByName("scoreshower");
                            ColoredRectangleInstance.CurrentVariableState = NES_1942.GumRuntimes.ColoredRectangleRuntime.VariableState.Default;
                            TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                            ColoredRectangleInstance.Alpha = 255;
                            ColoredRectangleInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Height = 0f;
                            ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredRectangleInstance.Red = 0;
                            ColoredRectangleInstance.Width = 0f;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredRectangleInstance.X = 6f;
                            ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ColoredRectangleInstance.Y = 2f;
                            ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Blue = 255;
                            TextInstance.Font = "Sitka Text";
                            TextInstance.FontScale = 1f;
                            TextInstance.FontSize = 90;
                            TextInstance.Green = 255;
                            TextInstance.Height = 0f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Red = 255;
                            TextInstance.Rotation = 0f;
                            TextInstance.Text = "GAME OVER\n";
                            TextInstance.UseFontSmoothing = false;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = -253f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance1.Height = 0f;
                            TextInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance1.Text = "PRESS \"R\" TO RESTART\n";
                            TextInstance1.UseFontSmoothing = false;
                            TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance1.Width = 0f;
                            TextInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance1.X = 0f;
                            TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance1.Y = 180f;
                            TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            scoreshower.FontSize = 15;
                            scoreshower.Height = 20f;
                            scoreshower.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            scoreshower.Text = "00000000000\n";
                            scoreshower.UseFontSmoothing = false;
                            scoreshower.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            scoreshower.Width = 41f;
                            scoreshower.X = 202f;
                            scoreshower.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            scoreshower.Y = 278f;
                            scoreshower.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            scoreshowerscoretext.Text = "Score:";
                            scoreshowerscoretext.UseFontSmoothing = false;
                            scoreshowerscoretext.X = -3f;
                            scoreshowerscoretext.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            scoreshowerscoretext.Y = 21f;
                            scoreshowerscoretext.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            break;
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
                bool setColoredRectangleInstanceAlphaFirstValue = false;
                bool setColoredRectangleInstanceAlphaSecondValue = false;
                int ColoredRectangleInstanceAlphaFirstValue= 0;
                int ColoredRectangleInstanceAlphaSecondValue= 0;
                bool setColoredRectangleInstanceBlueFirstValue = false;
                bool setColoredRectangleInstanceBlueSecondValue = false;
                int ColoredRectangleInstanceBlueFirstValue= 0;
                int ColoredRectangleInstanceBlueSecondValue= 0;
                bool setColoredRectangleInstanceGreenFirstValue = false;
                bool setColoredRectangleInstanceGreenSecondValue = false;
                int ColoredRectangleInstanceGreenFirstValue= 0;
                int ColoredRectangleInstanceGreenSecondValue= 0;
                bool setColoredRectangleInstanceHeightFirstValue = false;
                bool setColoredRectangleInstanceHeightSecondValue = false;
                float ColoredRectangleInstanceHeightFirstValue= 0;
                float ColoredRectangleInstanceHeightSecondValue= 0;
                bool setColoredRectangleInstanceRedFirstValue = false;
                bool setColoredRectangleInstanceRedSecondValue = false;
                int ColoredRectangleInstanceRedFirstValue= 0;
                int ColoredRectangleInstanceRedSecondValue= 0;
                bool setColoredRectangleInstanceCurrentVariableStateFirstValue = false;
                bool setColoredRectangleInstanceCurrentVariableStateSecondValue = false;
                NES_1942.GumRuntimes.ColoredRectangleRuntime.VariableState ColoredRectangleInstanceCurrentVariableStateFirstValue= NES_1942.GumRuntimes.ColoredRectangleRuntime.VariableState.Default;
                NES_1942.GumRuntimes.ColoredRectangleRuntime.VariableState ColoredRectangleInstanceCurrentVariableStateSecondValue= NES_1942.GumRuntimes.ColoredRectangleRuntime.VariableState.Default;
                bool setColoredRectangleInstanceWidthFirstValue = false;
                bool setColoredRectangleInstanceWidthSecondValue = false;
                float ColoredRectangleInstanceWidthFirstValue= 0;
                float ColoredRectangleInstanceWidthSecondValue= 0;
                bool setColoredRectangleInstanceXFirstValue = false;
                bool setColoredRectangleInstanceXSecondValue = false;
                float ColoredRectangleInstanceXFirstValue= 0;
                float ColoredRectangleInstanceXSecondValue= 0;
                bool setColoredRectangleInstanceYFirstValue = false;
                bool setColoredRectangleInstanceYSecondValue = false;
                float ColoredRectangleInstanceYFirstValue= 0;
                float ColoredRectangleInstanceYSecondValue= 0;
                bool setscoreshowerFontSizeFirstValue = false;
                bool setscoreshowerFontSizeSecondValue = false;
                int scoreshowerFontSizeFirstValue= 0;
                int scoreshowerFontSizeSecondValue= 0;
                bool setscoreshowerHeightFirstValue = false;
                bool setscoreshowerHeightSecondValue = false;
                float scoreshowerHeightFirstValue= 0;
                float scoreshowerHeightSecondValue= 0;
                bool setscoreshowerWidthFirstValue = false;
                bool setscoreshowerWidthSecondValue = false;
                float scoreshowerWidthFirstValue= 0;
                float scoreshowerWidthSecondValue= 0;
                bool setscoreshowerXFirstValue = false;
                bool setscoreshowerXSecondValue = false;
                float scoreshowerXFirstValue= 0;
                float scoreshowerXSecondValue= 0;
                bool setscoreshowerYFirstValue = false;
                bool setscoreshowerYSecondValue = false;
                float scoreshowerYFirstValue= 0;
                float scoreshowerYSecondValue= 0;
                bool setscoreshowerscoretextXFirstValue = false;
                bool setscoreshowerscoretextXSecondValue = false;
                float scoreshowerscoretextXFirstValue= 0;
                float scoreshowerscoretextXSecondValue= 0;
                bool setscoreshowerscoretextYFirstValue = false;
                bool setscoreshowerscoretextYSecondValue = false;
                float scoreshowerscoretextYFirstValue= 0;
                float scoreshowerscoretextYSecondValue= 0;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                bool setTextInstanceFontScaleFirstValue = false;
                bool setTextInstanceFontScaleSecondValue = false;
                float TextInstanceFontScaleFirstValue= 0;
                float TextInstanceFontScaleSecondValue= 0;
                bool setTextInstanceFontSizeFirstValue = false;
                bool setTextInstanceFontSizeSecondValue = false;
                int TextInstanceFontSizeFirstValue= 0;
                int TextInstanceFontSizeSecondValue= 0;
                bool setTextInstanceGreenFirstValue = false;
                bool setTextInstanceGreenSecondValue = false;
                int TextInstanceGreenFirstValue= 0;
                int TextInstanceGreenSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                bool setTextInstanceRotationFirstValue = false;
                bool setTextInstanceRotationSecondValue = false;
                float TextInstanceRotationFirstValue= 0;
                float TextInstanceRotationSecondValue= 0;
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
                bool setTextInstance1HeightFirstValue = false;
                bool setTextInstance1HeightSecondValue = false;
                float TextInstance1HeightFirstValue= 0;
                float TextInstance1HeightSecondValue= 0;
                bool setTextInstance1WidthFirstValue = false;
                bool setTextInstance1WidthSecondValue = false;
                float TextInstance1WidthFirstValue= 0;
                float TextInstance1WidthSecondValue= 0;
                bool setTextInstance1XFirstValue = false;
                bool setTextInstance1XSecondValue = false;
                float TextInstance1XFirstValue= 0;
                float TextInstance1XSecondValue= 0;
                bool setTextInstance1YFirstValue = false;
                bool setTextInstance1YSecondValue = false;
                float TextInstance1YFirstValue= 0;
                float TextInstance1YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstanceCurrentVariableStateFirstValue = true;
                        ColoredRectangleInstanceCurrentVariableStateFirstValue = NES_1942.GumRuntimes.ColoredRectangleRuntime.VariableState.Default;
                        setColoredRectangleInstanceWidthFirstValue = true;
                        ColoredRectangleInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceXFirstValue = true;
                        ColoredRectangleInstanceXFirstValue = 6f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setColoredRectangleInstanceYFirstValue = true;
                        ColoredRectangleInstanceYFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setscoreshowerFontSizeFirstValue = true;
                        scoreshowerFontSizeFirstValue = 15;
                        setscoreshowerHeightFirstValue = true;
                        scoreshowerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.scoreshower.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.scoreshower.Text = "00000000000\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.scoreshower.UseFontSmoothing = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.scoreshower.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setscoreshowerWidthFirstValue = true;
                        scoreshowerWidthFirstValue = 41f;
                        setscoreshowerXFirstValue = true;
                        scoreshowerXFirstValue = 202f;
                        if (interpolationValue < 1)
                        {
                            this.scoreshower.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setscoreshowerYFirstValue = true;
                        scoreshowerYFirstValue = 278f;
                        if (interpolationValue < 1)
                        {
                            this.scoreshower.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.scoreshowerscoretext.Parent = this.GetGraphicalUiElementByName("scoreshower");
                        }
                        if (interpolationValue < 1)
                        {
                            this.scoreshowerscoretext.Text = "Score:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.scoreshowerscoretext.UseFontSmoothing = false;
                        }
                        setscoreshowerscoretextXFirstValue = true;
                        scoreshowerscoretextXFirstValue = -3f;
                        if (interpolationValue < 1)
                        {
                            this.scoreshowerscoretext.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setscoreshowerscoretextYFirstValue = true;
                        scoreshowerscoretextYFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.scoreshowerscoretext.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Font = "Sitka Text";
                        }
                        setTextInstanceFontScaleFirstValue = true;
                        TextInstanceFontScaleFirstValue = 1f;
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 90;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
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
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        setTextInstanceRotationFirstValue = true;
                        TextInstanceRotationFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "GAME OVER\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.UseFontSmoothing = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = -253f;
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
                        setTextInstance1HeightFirstValue = true;
                        TextInstance1HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Parent = this.GetGraphicalUiElementByName("TextInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.Text = "PRESS \"R\" TO RESTART\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.UseFontSmoothing = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstance1WidthFirstValue = true;
                        TextInstance1WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstance1XFirstValue = true;
                        TextInstance1XFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstance1YFirstValue = true;
                        TextInstance1YFirstValue = 180f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Blend = Gum.RenderingLibrary.Blend.Normal;
                        }
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstanceCurrentVariableStateSecondValue = true;
                        ColoredRectangleInstanceCurrentVariableStateSecondValue = NES_1942.GumRuntimes.ColoredRectangleRuntime.VariableState.Default;
                        setColoredRectangleInstanceWidthSecondValue = true;
                        ColoredRectangleInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceXSecondValue = true;
                        ColoredRectangleInstanceXSecondValue = 6f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setColoredRectangleInstanceYSecondValue = true;
                        ColoredRectangleInstanceYSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setscoreshowerFontSizeSecondValue = true;
                        scoreshowerFontSizeSecondValue = 15;
                        setscoreshowerHeightSecondValue = true;
                        scoreshowerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.scoreshower.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.scoreshower.Text = "00000000000\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.scoreshower.UseFontSmoothing = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.scoreshower.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setscoreshowerWidthSecondValue = true;
                        scoreshowerWidthSecondValue = 41f;
                        setscoreshowerXSecondValue = true;
                        scoreshowerXSecondValue = 202f;
                        if (interpolationValue >= 1)
                        {
                            this.scoreshower.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setscoreshowerYSecondValue = true;
                        scoreshowerYSecondValue = 278f;
                        if (interpolationValue >= 1)
                        {
                            this.scoreshower.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.scoreshowerscoretext.Parent = this.GetGraphicalUiElementByName("scoreshower");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.scoreshowerscoretext.Text = "Score:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.scoreshowerscoretext.UseFontSmoothing = false;
                        }
                        setscoreshowerscoretextXSecondValue = true;
                        scoreshowerscoretextXSecondValue = -3f;
                        if (interpolationValue >= 1)
                        {
                            this.scoreshowerscoretext.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setscoreshowerscoretextYSecondValue = true;
                        scoreshowerscoretextYSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.scoreshowerscoretext.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Font = "Sitka Text";
                        }
                        setTextInstanceFontScaleSecondValue = true;
                        TextInstanceFontScaleSecondValue = 1f;
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 90;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
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
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        setTextInstanceRotationSecondValue = true;
                        TextInstanceRotationSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "GAME OVER\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.UseFontSmoothing = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = -253f;
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
                        setTextInstance1HeightSecondValue = true;
                        TextInstance1HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Parent = this.GetGraphicalUiElementByName("TextInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.Text = "PRESS \"R\" TO RESTART\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.UseFontSmoothing = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstance1WidthSecondValue = true;
                        TextInstance1WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstance1XSecondValue = true;
                        TextInstance1XSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstance1YSecondValue = true;
                        TextInstance1YSecondValue = 180f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance1.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setColoredRectangleInstanceAlphaFirstValue && setColoredRectangleInstanceAlphaSecondValue)
                {
                    ColoredRectangleInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceAlphaFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceAlphaSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceBlueFirstValue && setColoredRectangleInstanceBlueSecondValue)
                {
                    ColoredRectangleInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceBlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceBlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceGreenFirstValue && setColoredRectangleInstanceGreenSecondValue)
                {
                    ColoredRectangleInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceGreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceGreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceHeightFirstValue && setColoredRectangleInstanceHeightSecondValue)
                {
                    ColoredRectangleInstance.Height = ColoredRectangleInstanceHeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceRedFirstValue && setColoredRectangleInstanceRedSecondValue)
                {
                    ColoredRectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceRedFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceCurrentVariableStateFirstValue && setColoredRectangleInstanceCurrentVariableStateSecondValue)
                {
                    ColoredRectangleInstance.InterpolateBetween(ColoredRectangleInstanceCurrentVariableStateFirstValue, ColoredRectangleInstanceCurrentVariableStateSecondValue, interpolationValue);
                }
                if (setColoredRectangleInstanceWidthFirstValue && setColoredRectangleInstanceWidthSecondValue)
                {
                    ColoredRectangleInstance.Width = ColoredRectangleInstanceWidthFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceWidthSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceXFirstValue && setColoredRectangleInstanceXSecondValue)
                {
                    ColoredRectangleInstance.X = ColoredRectangleInstanceXFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceXSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceYFirstValue && setColoredRectangleInstanceYSecondValue)
                {
                    ColoredRectangleInstance.Y = ColoredRectangleInstanceYFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceYSecondValue * interpolationValue;
                }
                if (setscoreshowerFontSizeFirstValue && setscoreshowerFontSizeSecondValue)
                {
                    scoreshower.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(scoreshowerFontSizeFirstValue* (1 - interpolationValue) + scoreshowerFontSizeSecondValue * interpolationValue);
                }
                if (setscoreshowerHeightFirstValue && setscoreshowerHeightSecondValue)
                {
                    scoreshower.Height = scoreshowerHeightFirstValue * (1 - interpolationValue) + scoreshowerHeightSecondValue * interpolationValue;
                }
                if (setscoreshowerWidthFirstValue && setscoreshowerWidthSecondValue)
                {
                    scoreshower.Width = scoreshowerWidthFirstValue * (1 - interpolationValue) + scoreshowerWidthSecondValue * interpolationValue;
                }
                if (setscoreshowerXFirstValue && setscoreshowerXSecondValue)
                {
                    scoreshower.X = scoreshowerXFirstValue * (1 - interpolationValue) + scoreshowerXSecondValue * interpolationValue;
                }
                if (setscoreshowerYFirstValue && setscoreshowerYSecondValue)
                {
                    scoreshower.Y = scoreshowerYFirstValue * (1 - interpolationValue) + scoreshowerYSecondValue * interpolationValue;
                }
                if (setscoreshowerscoretextXFirstValue && setscoreshowerscoretextXSecondValue)
                {
                    scoreshowerscoretext.X = scoreshowerscoretextXFirstValue * (1 - interpolationValue) + scoreshowerscoretextXSecondValue * interpolationValue;
                }
                if (setscoreshowerscoretextYFirstValue && setscoreshowerscoretextYSecondValue)
                {
                    scoreshowerscoretext.Y = scoreshowerscoretextYFirstValue * (1 - interpolationValue) + scoreshowerscoretextYSecondValue * interpolationValue;
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
                }
                if (setTextInstanceFontScaleFirstValue && setTextInstanceFontScaleSecondValue)
                {
                    TextInstance.FontScale = TextInstanceFontScaleFirstValue * (1 - interpolationValue) + TextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setTextInstanceFontSizeFirstValue && setTextInstanceFontSizeSecondValue)
                {
                    TextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceFontSizeFirstValue* (1 - interpolationValue) + TextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setTextInstanceGreenFirstValue && setTextInstanceGreenSecondValue)
                {
                    TextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceGreenFirstValue* (1 - interpolationValue) + TextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (setTextInstanceRotationFirstValue && setTextInstanceRotationSecondValue)
                {
                    TextInstance.Rotation = TextInstanceRotationFirstValue * (1 - interpolationValue) + TextInstanceRotationSecondValue * interpolationValue;
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
                if (setTextInstance1HeightFirstValue && setTextInstance1HeightSecondValue)
                {
                    TextInstance1.Height = TextInstance1HeightFirstValue * (1 - interpolationValue) + TextInstance1HeightSecondValue * interpolationValue;
                }
                if (setTextInstance1WidthFirstValue && setTextInstance1WidthSecondValue)
                {
                    TextInstance1.Width = TextInstance1WidthFirstValue * (1 - interpolationValue) + TextInstance1WidthSecondValue * interpolationValue;
                }
                if (setTextInstance1XFirstValue && setTextInstance1XSecondValue)
                {
                    TextInstance1.X = TextInstance1XFirstValue * (1 - interpolationValue) + TextInstance1XSecondValue * interpolationValue;
                }
                if (setTextInstance1YFirstValue && setTextInstance1YSecondValue)
                {
                    TextInstance1.Y = TextInstance1YFirstValue * (1 - interpolationValue) + TextInstance1YSecondValue * interpolationValue;
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
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (NES_1942.GumRuntimes.GameOverGumRuntime.VariableState fromState,NES_1942.GumRuntimes.GameOverGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
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
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blend",
                            Type = "Blend",
                            Value = ColoredRectangleInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.State",
                            Type = "State",
                            Value = ColoredRectangleInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredRectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredRectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
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
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font Scale",
                            Type = "float",
                            Value = TextInstance.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Rotation",
                            Type = "float",
                            Value = TextInstance.Rotation
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
                            Name = "TextInstance.UseFontSmoothing",
                            Type = "bool",
                            Value = TextInstance.UseFontSmoothing
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height",
                            Type = "float",
                            Value = TextInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Parent",
                            Type = "string",
                            Value = TextInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.UseFontSmoothing",
                            Type = "bool",
                            Value = TextInstance1.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.FontSize",
                            Type = "int",
                            Value = scoreshower.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Height",
                            Type = "float",
                            Value = scoreshower.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = scoreshower.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Text",
                            Type = "string",
                            Value = scoreshower.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.UseFontSmoothing",
                            Type = "bool",
                            Value = scoreshower.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = scoreshower.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Width",
                            Type = "float",
                            Value = scoreshower.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.X",
                            Type = "float",
                            Value = scoreshower.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.X Origin",
                            Type = "HorizontalAlignment",
                            Value = scoreshower.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Y",
                            Type = "float",
                            Value = scoreshower.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Y Origin",
                            Type = "VerticalAlignment",
                            Value = scoreshower.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Parent",
                            Type = "string",
                            Value = scoreshowerscoretext.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Text",
                            Type = "string",
                            Value = scoreshowerscoretext.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.UseFontSmoothing",
                            Type = "bool",
                            Value = scoreshowerscoretext.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.X",
                            Type = "float",
                            Value = scoreshowerscoretext.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.X Origin",
                            Type = "HorizontalAlignment",
                            Value = scoreshowerscoretext.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Y",
                            Type = "float",
                            Value = scoreshowerscoretext.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Y Origin",
                            Type = "VerticalAlignment",
                            Value = scoreshowerscoretext.YOrigin
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
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blend",
                            Type = "Blend",
                            Value = ColoredRectangleInstance.Blend
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.State",
                            Type = "State",
                            Value = ColoredRectangleInstance.CurrentVariableState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X + 6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredRectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredRectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 255
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
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font Scale",
                            Type = "float",
                            Value = TextInstance.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize + 90
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Rotation",
                            Type = "float",
                            Value = TextInstance.Rotation + 0f
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
                            Name = "TextInstance.UseFontSmoothing",
                            Type = "bool",
                            Value = TextInstance.UseFontSmoothing
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
                            Value = TextInstance.Width + -253f
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height",
                            Type = "float",
                            Value = TextInstance1.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Parent",
                            Type = "string",
                            Value = TextInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Text",
                            Type = "string",
                            Value = TextInstance1.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.UseFontSmoothing",
                            Type = "bool",
                            Value = TextInstance1.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width",
                            Type = "float",
                            Value = TextInstance1.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X",
                            Type = "float",
                            Value = TextInstance1.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y",
                            Type = "float",
                            Value = TextInstance1.Y + 180f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance1.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.FontSize",
                            Type = "int",
                            Value = scoreshower.FontSize + 15
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Height",
                            Type = "float",
                            Value = scoreshower.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = scoreshower.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Text",
                            Type = "string",
                            Value = scoreshower.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.UseFontSmoothing",
                            Type = "bool",
                            Value = scoreshower.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = scoreshower.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Width",
                            Type = "float",
                            Value = scoreshower.Width + 41f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.X",
                            Type = "float",
                            Value = scoreshower.X + 202f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.X Origin",
                            Type = "HorizontalAlignment",
                            Value = scoreshower.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Y",
                            Type = "float",
                            Value = scoreshower.Y + 278f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshower.Y Origin",
                            Type = "VerticalAlignment",
                            Value = scoreshower.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Parent",
                            Type = "string",
                            Value = scoreshowerscoretext.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Text",
                            Type = "string",
                            Value = scoreshowerscoretext.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.UseFontSmoothing",
                            Type = "bool",
                            Value = scoreshowerscoretext.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.X",
                            Type = "float",
                            Value = scoreshowerscoretext.X + -3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.X Origin",
                            Type = "HorizontalAlignment",
                            Value = scoreshowerscoretext.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Y",
                            Type = "float",
                            Value = scoreshowerscoretext.Y + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "scoreshowerscoretext.Y Origin",
                            Type = "VerticalAlignment",
                            Value = scoreshowerscoretext.YOrigin
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
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            public NES_1942.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            public NES_1942.GumRuntimes.TextRuntime TextInstance { get; set; }
            public NES_1942.GumRuntimes.TextRuntime TextInstance1 { get; set; }
            public NES_1942.GumRuntimes.TextRuntime scoreshower { get; set; }
            public NES_1942.GumRuntimes.TextRuntime scoreshowerscoretext { get; set; }
            public string TextInstance2Text
            {
                get
                {
                    return scoreshower.Text;
                }
                set
                {
                    if (scoreshower.Text != value)
                    {
                        scoreshower.Text = value;
                        TextInstance2TextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler TextInstance2TextChanged;
            public GameOverGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameOverGum");
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
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as NES_1942.GumRuntimes.ColoredRectangleRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as NES_1942.GumRuntimes.TextRuntime;
                TextInstance1 = this.GetGraphicalUiElementByName("TextInstance1") as NES_1942.GumRuntimes.TextRuntime;
                scoreshower = this.GetGraphicalUiElementByName("scoreshower") as NES_1942.GumRuntimes.TextRuntime;
                scoreshowerscoretext = this.GetGraphicalUiElementByName("scoreshowerscoretext") as NES_1942.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new NES_1942.FormsControls.Screens.GameOverGumForms(this);
                }
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
            public NES_1942.FormsControls.Screens.GameOverGumForms FormsControl {get => (NES_1942.FormsControls.Screens.GameOverGumForms) FormsControlAsObject;}
        }
    }
