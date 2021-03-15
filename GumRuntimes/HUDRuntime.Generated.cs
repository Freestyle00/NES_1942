    using System.Linq;
    namespace NES_1942.GumRuntimes
    {
        public partial class HUDRuntime : Gum.Wireframe.GraphicalUiElement
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
                            TextInstance.CurrentColorCategoryState = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                            TextInstance.CurrentVariableState = NES_1942.GumRuntimes.TextRuntime.VariableState.Default;
                            ScoreCounterInstance.Height = 0f;
                            ScoreCounterInstance.RetrysInstanceTextInstanceText = "3\n";
                            ScoreCounterInstance.ScorePointsText = "0000000\n";
                            ScoreCounterInstance.Width = 0f;
                            ScoreCounterInstance.WrapsChildren = true;
                            ScoreCounterInstance.X = 0f;
                            ScoreCounterInstance.Y = 0f;
                            TextInstance.Blue = 140;
                            TextInstance.Font = "Arial";
                            TextInstance.FontSize = 40;
                            TextInstance.Green = 230;
                            TextInstance.Height = 0f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.OutlineThickness = 2;
                            TextInstance.Red = 240;
                            TextInstance.Text = "PAUSE\n";
                            TextInstance.UseFontSmoothing = false;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 34f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setScoreCounterInstanceHeightFirstValue = false;
                bool setScoreCounterInstanceHeightSecondValue = false;
                float ScoreCounterInstanceHeightFirstValue= 0;
                float ScoreCounterInstanceHeightSecondValue= 0;
                bool setScoreCounterInstanceWidthFirstValue = false;
                bool setScoreCounterInstanceWidthSecondValue = false;
                float ScoreCounterInstanceWidthFirstValue= 0;
                float ScoreCounterInstanceWidthSecondValue= 0;
                bool setScoreCounterInstanceXFirstValue = false;
                bool setScoreCounterInstanceXSecondValue = false;
                float ScoreCounterInstanceXFirstValue= 0;
                float ScoreCounterInstanceXSecondValue= 0;
                bool setScoreCounterInstanceYFirstValue = false;
                bool setScoreCounterInstanceYSecondValue = false;
                float ScoreCounterInstanceYFirstValue= 0;
                float ScoreCounterInstanceYSecondValue= 0;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
                bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
                NES_1942.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= NES_1942.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
                bool setTextInstanceOutlineThicknessFirstValue = false;
                bool setTextInstanceOutlineThicknessSecondValue = false;
                int TextInstanceOutlineThicknessFirstValue= 0;
                int TextInstanceOutlineThicknessSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                bool setTextInstanceCurrentVariableStateFirstValue = false;
                bool setTextInstanceCurrentVariableStateSecondValue = false;
                NES_1942.GumRuntimes.TextRuntime.VariableState TextInstanceCurrentVariableStateFirstValue= NES_1942.GumRuntimes.TextRuntime.VariableState.Default;
                NES_1942.GumRuntimes.TextRuntime.VariableState TextInstanceCurrentVariableStateSecondValue= NES_1942.GumRuntimes.TextRuntime.VariableState.Default;
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
                switch(firstState)
                {
                    case  VariableState.Default:
                        setScoreCounterInstanceHeightFirstValue = true;
                        ScoreCounterInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ScoreCounterInstance.RetrysInstanceTextInstanceText = "3\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScoreCounterInstance.ScorePointsText = "0000000\n";
                        }
                        setScoreCounterInstanceWidthFirstValue = true;
                        ScoreCounterInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ScoreCounterInstance.WrapsChildren = true;
                        }
                        setScoreCounterInstanceXFirstValue = true;
                        ScoreCounterInstanceXFirstValue = 0f;
                        setScoreCounterInstanceYFirstValue = true;
                        ScoreCounterInstanceYFirstValue = 0f;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 140;
                        setTextInstanceCurrentColorCategoryStateFirstValue = true;
                        TextInstanceCurrentColorCategoryStateFirstValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Font = "Arial";
                        }
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 40;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 230;
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
                        setTextInstanceOutlineThicknessFirstValue = true;
                        TextInstanceOutlineThicknessFirstValue = 2;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 240;
                        setTextInstanceCurrentVariableStateFirstValue = true;
                        TextInstanceCurrentVariableStateFirstValue = NES_1942.GumRuntimes.TextRuntime.VariableState.Default;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "PAUSE\n";
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
                        TextInstanceYFirstValue = 34f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setScoreCounterInstanceHeightSecondValue = true;
                        ScoreCounterInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ScoreCounterInstance.RetrysInstanceTextInstanceText = "3\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScoreCounterInstance.ScorePointsText = "0000000\n";
                        }
                        setScoreCounterInstanceWidthSecondValue = true;
                        ScoreCounterInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ScoreCounterInstance.WrapsChildren = true;
                        }
                        setScoreCounterInstanceXSecondValue = true;
                        ScoreCounterInstanceXSecondValue = 0f;
                        setScoreCounterInstanceYSecondValue = true;
                        ScoreCounterInstanceYSecondValue = 0f;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 140;
                        setTextInstanceCurrentColorCategoryStateSecondValue = true;
                        TextInstanceCurrentColorCategoryStateSecondValue = NES_1942.GumRuntimes.TextRuntime.ColorCategory.Black;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Font = "Arial";
                        }
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 40;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 230;
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
                        setTextInstanceOutlineThicknessSecondValue = true;
                        TextInstanceOutlineThicknessSecondValue = 2;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 240;
                        setTextInstanceCurrentVariableStateSecondValue = true;
                        TextInstanceCurrentVariableStateSecondValue = NES_1942.GumRuntimes.TextRuntime.VariableState.Default;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "PAUSE\n";
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
                        TextInstanceYSecondValue = 34f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setScoreCounterInstanceHeightFirstValue && setScoreCounterInstanceHeightSecondValue)
                {
                    ScoreCounterInstance.Height = ScoreCounterInstanceHeightFirstValue * (1 - interpolationValue) + ScoreCounterInstanceHeightSecondValue * interpolationValue;
                }
                if (setScoreCounterInstanceWidthFirstValue && setScoreCounterInstanceWidthSecondValue)
                {
                    ScoreCounterInstance.Width = ScoreCounterInstanceWidthFirstValue * (1 - interpolationValue) + ScoreCounterInstanceWidthSecondValue * interpolationValue;
                }
                if (setScoreCounterInstanceXFirstValue && setScoreCounterInstanceXSecondValue)
                {
                    ScoreCounterInstance.X = ScoreCounterInstanceXFirstValue * (1 - interpolationValue) + ScoreCounterInstanceXSecondValue * interpolationValue;
                }
                if (setScoreCounterInstanceYFirstValue && setScoreCounterInstanceYSecondValue)
                {
                    ScoreCounterInstance.Y = ScoreCounterInstanceYFirstValue * (1 - interpolationValue) + ScoreCounterInstanceYSecondValue * interpolationValue;
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
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
                if (setTextInstanceOutlineThicknessFirstValue && setTextInstanceOutlineThicknessSecondValue)
                {
                    TextInstance.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceOutlineThicknessFirstValue* (1 - interpolationValue) + TextInstanceOutlineThicknessSecondValue * interpolationValue);
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (setTextInstanceCurrentVariableStateFirstValue && setTextInstanceCurrentVariableStateSecondValue)
                {
                    TextInstance.InterpolateBetween(TextInstanceCurrentVariableStateFirstValue, TextInstanceCurrentVariableStateSecondValue, interpolationValue);
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (NES_1942.GumRuntimes.HUDRuntime.VariableState fromState,NES_1942.GumRuntimes.HUDRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                ScoreCounterInstance.StopAnimations();
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
                            Name = "ScoreCounterInstance.Height",
                            Type = "float",
                            Value = ScoreCounterInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.RetrysInstanceTextInstanceText",
                            Type = "string",
                            Value = ScoreCounterInstance.RetrysInstanceTextInstanceText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.ScorePointsText",
                            Type = "string",
                            Value = ScoreCounterInstance.ScorePointsText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.Width",
                            Type = "float",
                            Value = ScoreCounterInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.Wraps Children",
                            Type = "bool",
                            Value = ScoreCounterInstance.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.X",
                            Type = "float",
                            Value = ScoreCounterInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.Y",
                            Type = "float",
                            Value = ScoreCounterInstance.Y
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
                            Name = "TextInstance.OutlineThickness",
                            Type = "int",
                            Value = TextInstance.OutlineThickness
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
                            Name = "TextInstance.State",
                            Type = "State",
                            Value = TextInstance.CurrentVariableState
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
                            Name = "ScoreCounterInstance.Height",
                            Type = "float",
                            Value = ScoreCounterInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.RetrysInstanceTextInstanceText",
                            Type = "string",
                            Value = ScoreCounterInstance.RetrysInstanceTextInstanceText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.ScorePointsText",
                            Type = "string",
                            Value = ScoreCounterInstance.ScorePointsText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.Width",
                            Type = "float",
                            Value = ScoreCounterInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.Wraps Children",
                            Type = "bool",
                            Value = ScoreCounterInstance.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.X",
                            Type = "float",
                            Value = ScoreCounterInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScoreCounterInstance.Y",
                            Type = "float",
                            Value = ScoreCounterInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 140
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
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize + 40
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 230
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
                            Name = "TextInstance.OutlineThickness",
                            Type = "int",
                            Value = TextInstance.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 240
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.State",
                            Type = "State",
                            Value = TextInstance.CurrentVariableState
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
                            Value = TextInstance.Y + 34f
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
            public NES_1942.GumRuntimes.ScoreCounterRuntime ScoreCounterInstance { get; set; }
            public NES_1942.GumRuntimes.TextRuntime TextInstance { get; set; }
            public string LIFESOMETHING
            {
                get
                {
                    return ScoreCounterInstance.RetrysInstanceTextInstanceText;
                }
                set
                {
                    if (ScoreCounterInstance.RetrysInstanceTextInstanceText != value)
                    {
                        ScoreCounterInstance.RetrysInstanceTextInstanceText = value;
                        LIFESOMETHINGChanged?.Invoke(this, null);
                    }
                }
            }
            public string ScoreCounterInstanceScorePointsText
            {
                get
                {
                    return ScoreCounterInstance.ScorePointsText;
                }
                set
                {
                    if (ScoreCounterInstance.ScorePointsText != value)
                    {
                        ScoreCounterInstance.ScorePointsText = value;
                        ScoreCounterInstanceScorePointsTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler LIFESOMETHINGChanged;
            public event System.EventHandler ScoreCounterInstanceScorePointsTextChanged;
            public HUDRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "HUD");
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
                ScoreCounterInstance = this.GetGraphicalUiElementByName("ScoreCounterInstance") as NES_1942.GumRuntimes.ScoreCounterRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as NES_1942.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControlAsObject = new NES_1942.FormsControls.Screens.HUDForms(this);
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
            public NES_1942.FormsControls.Screens.HUDForms FormsControl {get => (NES_1942.FormsControls.Screens.HUDForms) FormsControlAsObject;}
        }
    }
