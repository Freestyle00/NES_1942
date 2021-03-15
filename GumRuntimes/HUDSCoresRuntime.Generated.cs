    using System.Linq;
    namespace NES_1942.GumRuntimes
    {
        public partial class HUDSCoresRuntime : NES_1942.GumRuntimes.ContainerRuntime
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
                            Height = 0f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Width = 0f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Textnumbers.Blue = 0;
                            Textnumbers.Font = "Bahnschrift SemiBold SemiConden";
                            Textnumbers.FontScale = 1f;
                            Textnumbers.FontSize = 23;
                            Textnumbers.Green = 87;
                            Textnumbers.Height = 31f;
                            Textnumbers.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Textnumbers.Red = 97;
                            Textnumbers.Text = "0000000000\n";
                            Textnumbers.UseFontSmoothing = false;
                            Textnumbers.Width = 146f;
                            Textnumbers.X = 38f;
                            Textnumbers.Y = 80f;
                            TEXTSCORE.Font = "Microsoft Himalaya";
                            TEXTSCORE.Height = 31f;
                            TEXTSCORE.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TEXTSCORE.Text = "SCORE\n";
                            TEXTSCORE.UseFontSmoothing = false;
                            TEXTSCORE.X = 60f;
                            TEXTSCORE.Y = 67f;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setTextnumbersBlueFirstValue = false;
                bool setTextnumbersBlueSecondValue = false;
                int TextnumbersBlueFirstValue= 0;
                int TextnumbersBlueSecondValue= 0;
                bool setTextnumbersFontScaleFirstValue = false;
                bool setTextnumbersFontScaleSecondValue = false;
                float TextnumbersFontScaleFirstValue= 0;
                float TextnumbersFontScaleSecondValue= 0;
                bool setTextnumbersFontSizeFirstValue = false;
                bool setTextnumbersFontSizeSecondValue = false;
                int TextnumbersFontSizeFirstValue= 0;
                int TextnumbersFontSizeSecondValue= 0;
                bool setTextnumbersGreenFirstValue = false;
                bool setTextnumbersGreenSecondValue = false;
                int TextnumbersGreenFirstValue= 0;
                int TextnumbersGreenSecondValue= 0;
                bool setTextnumbersHeightFirstValue = false;
                bool setTextnumbersHeightSecondValue = false;
                float TextnumbersHeightFirstValue= 0;
                float TextnumbersHeightSecondValue= 0;
                bool setTextnumbersRedFirstValue = false;
                bool setTextnumbersRedSecondValue = false;
                int TextnumbersRedFirstValue= 0;
                int TextnumbersRedSecondValue= 0;
                bool setTextnumbersWidthFirstValue = false;
                bool setTextnumbersWidthSecondValue = false;
                float TextnumbersWidthFirstValue= 0;
                float TextnumbersWidthSecondValue= 0;
                bool setTextnumbersXFirstValue = false;
                bool setTextnumbersXSecondValue = false;
                float TextnumbersXFirstValue= 0;
                float TextnumbersXSecondValue= 0;
                bool setTextnumbersYFirstValue = false;
                bool setTextnumbersYSecondValue = false;
                float TextnumbersYFirstValue= 0;
                float TextnumbersYSecondValue= 0;
                bool setTEXTSCOREHeightFirstValue = false;
                bool setTEXTSCOREHeightSecondValue = false;
                float TEXTSCOREHeightFirstValue= 0;
                float TEXTSCOREHeightSecondValue= 0;
                bool setTEXTSCOREXFirstValue = false;
                bool setTEXTSCOREXSecondValue = false;
                float TEXTSCOREXFirstValue= 0;
                float TEXTSCOREXSecondValue= 0;
                bool setTEXTSCOREYFirstValue = false;
                bool setTEXTSCOREYSecondValue = false;
                float TEXTSCOREYFirstValue= 0;
                float TEXTSCOREYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHeightFirstValue = true;
                        HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextnumbersBlueFirstValue = true;
                        TextnumbersBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.Textnumbers.Font = "Bahnschrift SemiBold SemiConden";
                        }
                        setTextnumbersFontScaleFirstValue = true;
                        TextnumbersFontScaleFirstValue = 1f;
                        setTextnumbersFontSizeFirstValue = true;
                        TextnumbersFontSizeFirstValue = 23;
                        setTextnumbersGreenFirstValue = true;
                        TextnumbersGreenFirstValue = 87;
                        setTextnumbersHeightFirstValue = true;
                        TextnumbersHeightFirstValue = 31f;
                        if (interpolationValue < 1)
                        {
                            this.Textnumbers.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setTextnumbersRedFirstValue = true;
                        TextnumbersRedFirstValue = 97;
                        if (interpolationValue < 1)
                        {
                            this.Textnumbers.Text = "0000000000\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.Textnumbers.UseFontSmoothing = false;
                        }
                        setTextnumbersWidthFirstValue = true;
                        TextnumbersWidthFirstValue = 146f;
                        setTextnumbersXFirstValue = true;
                        TextnumbersXFirstValue = 38f;
                        setTextnumbersYFirstValue = true;
                        TextnumbersYFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.TEXTSCORE.Font = "Microsoft Himalaya";
                        }
                        setTEXTSCOREHeightFirstValue = true;
                        TEXTSCOREHeightFirstValue = 31f;
                        if (interpolationValue < 1)
                        {
                            this.TEXTSCORE.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TEXTSCORE.Text = "SCORE\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TEXTSCORE.UseFontSmoothing = false;
                        }
                        setTEXTSCOREXFirstValue = true;
                        TEXTSCOREXFirstValue = 60f;
                        setTEXTSCOREYFirstValue = true;
                        TEXTSCOREYFirstValue = 67f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextnumbersBlueSecondValue = true;
                        TextnumbersBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.Textnumbers.Font = "Bahnschrift SemiBold SemiConden";
                        }
                        setTextnumbersFontScaleSecondValue = true;
                        TextnumbersFontScaleSecondValue = 1f;
                        setTextnumbersFontSizeSecondValue = true;
                        TextnumbersFontSizeSecondValue = 23;
                        setTextnumbersGreenSecondValue = true;
                        TextnumbersGreenSecondValue = 87;
                        setTextnumbersHeightSecondValue = true;
                        TextnumbersHeightSecondValue = 31f;
                        if (interpolationValue >= 1)
                        {
                            this.Textnumbers.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setTextnumbersRedSecondValue = true;
                        TextnumbersRedSecondValue = 97;
                        if (interpolationValue >= 1)
                        {
                            this.Textnumbers.Text = "0000000000\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Textnumbers.UseFontSmoothing = false;
                        }
                        setTextnumbersWidthSecondValue = true;
                        TextnumbersWidthSecondValue = 146f;
                        setTextnumbersXSecondValue = true;
                        TextnumbersXSecondValue = 38f;
                        setTextnumbersYSecondValue = true;
                        TextnumbersYSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.TEXTSCORE.Font = "Microsoft Himalaya";
                        }
                        setTEXTSCOREHeightSecondValue = true;
                        TEXTSCOREHeightSecondValue = 31f;
                        if (interpolationValue >= 1)
                        {
                            this.TEXTSCORE.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TEXTSCORE.Text = "SCORE\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TEXTSCORE.UseFontSmoothing = false;
                        }
                        setTEXTSCOREXSecondValue = true;
                        TEXTSCOREXSecondValue = 60f;
                        setTEXTSCOREYSecondValue = true;
                        TEXTSCOREYSecondValue = 67f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
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
                if (setTextnumbersBlueFirstValue && setTextnumbersBlueSecondValue)
                {
                    Textnumbers.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextnumbersBlueFirstValue* (1 - interpolationValue) + TextnumbersBlueSecondValue * interpolationValue);
                }
                if (setTextnumbersFontScaleFirstValue && setTextnumbersFontScaleSecondValue)
                {
                    Textnumbers.FontScale = TextnumbersFontScaleFirstValue * (1 - interpolationValue) + TextnumbersFontScaleSecondValue * interpolationValue;
                }
                if (setTextnumbersFontSizeFirstValue && setTextnumbersFontSizeSecondValue)
                {
                    Textnumbers.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TextnumbersFontSizeFirstValue* (1 - interpolationValue) + TextnumbersFontSizeSecondValue * interpolationValue);
                }
                if (setTextnumbersGreenFirstValue && setTextnumbersGreenSecondValue)
                {
                    Textnumbers.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextnumbersGreenFirstValue* (1 - interpolationValue) + TextnumbersGreenSecondValue * interpolationValue);
                }
                if (setTextnumbersHeightFirstValue && setTextnumbersHeightSecondValue)
                {
                    Textnumbers.Height = TextnumbersHeightFirstValue * (1 - interpolationValue) + TextnumbersHeightSecondValue * interpolationValue;
                }
                if (setTextnumbersRedFirstValue && setTextnumbersRedSecondValue)
                {
                    Textnumbers.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextnumbersRedFirstValue* (1 - interpolationValue) + TextnumbersRedSecondValue * interpolationValue);
                }
                if (setTextnumbersWidthFirstValue && setTextnumbersWidthSecondValue)
                {
                    Textnumbers.Width = TextnumbersWidthFirstValue * (1 - interpolationValue) + TextnumbersWidthSecondValue * interpolationValue;
                }
                if (setTextnumbersXFirstValue && setTextnumbersXSecondValue)
                {
                    Textnumbers.X = TextnumbersXFirstValue * (1 - interpolationValue) + TextnumbersXSecondValue * interpolationValue;
                }
                if (setTextnumbersYFirstValue && setTextnumbersYSecondValue)
                {
                    Textnumbers.Y = TextnumbersYFirstValue * (1 - interpolationValue) + TextnumbersYSecondValue * interpolationValue;
                }
                if (setTEXTSCOREHeightFirstValue && setTEXTSCOREHeightSecondValue)
                {
                    TEXTSCORE.Height = TEXTSCOREHeightFirstValue * (1 - interpolationValue) + TEXTSCOREHeightSecondValue * interpolationValue;
                }
                if (setTEXTSCOREXFirstValue && setTEXTSCOREXSecondValue)
                {
                    TEXTSCORE.X = TEXTSCOREXFirstValue * (1 - interpolationValue) + TEXTSCOREXSecondValue * interpolationValue;
                }
                if (setTEXTSCOREYFirstValue && setTEXTSCOREYSecondValue)
                {
                    TEXTSCORE.Y = TEXTSCOREYFirstValue * (1 - interpolationValue) + TEXTSCOREYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (NES_1942.GumRuntimes.HUDSCoresRuntime.VariableState fromState,NES_1942.GumRuntimes.HUDSCoresRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
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
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Blue",
                            Type = "int",
                            Value = Textnumbers.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Font",
                            Type = "string",
                            Value = Textnumbers.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Font Scale",
                            Type = "float",
                            Value = Textnumbers.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.FontSize",
                            Type = "int",
                            Value = Textnumbers.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Green",
                            Type = "int",
                            Value = Textnumbers.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Height",
                            Type = "float",
                            Value = Textnumbers.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Textnumbers.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Red",
                            Type = "int",
                            Value = Textnumbers.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Text",
                            Type = "string",
                            Value = Textnumbers.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.UseFontSmoothing",
                            Type = "bool",
                            Value = Textnumbers.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Width",
                            Type = "float",
                            Value = Textnumbers.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.X",
                            Type = "float",
                            Value = Textnumbers.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Y",
                            Type = "float",
                            Value = Textnumbers.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Font",
                            Type = "string",
                            Value = TEXTSCORE.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Height",
                            Type = "float",
                            Value = TEXTSCORE.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TEXTSCORE.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Text",
                            Type = "string",
                            Value = TEXTSCORE.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.UseFontSmoothing",
                            Type = "bool",
                            Value = TEXTSCORE.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.X",
                            Type = "float",
                            Value = TEXTSCORE.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Y",
                            Type = "float",
                            Value = TEXTSCORE.Y
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
                            Value = Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Blue",
                            Type = "int",
                            Value = Textnumbers.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Font",
                            Type = "string",
                            Value = Textnumbers.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Font Scale",
                            Type = "float",
                            Value = Textnumbers.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.FontSize",
                            Type = "int",
                            Value = Textnumbers.FontSize + 23
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Green",
                            Type = "int",
                            Value = Textnumbers.Green + 87
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Height",
                            Type = "float",
                            Value = Textnumbers.Height + 31f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Textnumbers.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Red",
                            Type = "int",
                            Value = Textnumbers.Red + 97
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Text",
                            Type = "string",
                            Value = Textnumbers.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.UseFontSmoothing",
                            Type = "bool",
                            Value = Textnumbers.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Width",
                            Type = "float",
                            Value = Textnumbers.Width + 146f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.X",
                            Type = "float",
                            Value = Textnumbers.X + 38f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Textnumbers.Y",
                            Type = "float",
                            Value = Textnumbers.Y + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Font",
                            Type = "string",
                            Value = TEXTSCORE.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Height",
                            Type = "float",
                            Value = TEXTSCORE.Height + 31f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TEXTSCORE.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Text",
                            Type = "string",
                            Value = TEXTSCORE.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.UseFontSmoothing",
                            Type = "bool",
                            Value = TEXTSCORE.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.X",
                            Type = "float",
                            Value = TEXTSCORE.X + 60f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TEXTSCORE.Y",
                            Type = "float",
                            Value = TEXTSCORE.Y + 67f
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
            private NES_1942.GumRuntimes.TextRuntime Textnumbers { get; set; }
            private NES_1942.GumRuntimes.TextRuntime TEXTSCORE { get; set; }
            public string TextnumbersTextText
            {
                get
                {
                    return Textnumbers.Text;
                }
                set
                {
                    if (Textnumbers.Text != value)
                    {
                        Textnumbers.Text = value;
                        TextnumbersTextTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler TextnumbersTextTextChanged;
            public HUDSCoresRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "HUDSCores");
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
                Textnumbers = this.GetGraphicalUiElementByName("Textnumbers") as NES_1942.GumRuntimes.TextRuntime;
                TEXTSCORE = this.GetGraphicalUiElementByName("TEXTSCORE") as NES_1942.GumRuntimes.TextRuntime;
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
