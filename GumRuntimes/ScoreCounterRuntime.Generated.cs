    using System.Linq;
    namespace NES_1942.GumRuntimes
    {
        public partial class ScoreCounterRuntime : NES_1942.GumRuntimes.ContainerRuntime
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
                            X = 1f;
                            Y = -1f;
                            ScorePoints.Alpha = 255;
                            ScorePoints.Blue = 0;
                            ScorePoints.Font = "Arial";
                            ScorePoints.Green = 0;
                            ScorePoints.Height = 16f;
                            ScorePoints.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ScorePoints.Red = 176;
                            ScorePoints.Text = "000000000\n\n\n";
                            ScorePoints.UseFontSmoothing = false;
                            ScorePoints.Width = 150f;
                            ScorePoints.X = 46f;
                            ScorePoints.Y = 42f;
                            RetrysInstance.TextInstanceText = "3\n";
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
                bool setScorePointsAlphaFirstValue = false;
                bool setScorePointsAlphaSecondValue = false;
                int ScorePointsAlphaFirstValue= 0;
                int ScorePointsAlphaSecondValue= 0;
                bool setScorePointsBlueFirstValue = false;
                bool setScorePointsBlueSecondValue = false;
                int ScorePointsBlueFirstValue= 0;
                int ScorePointsBlueSecondValue= 0;
                bool setScorePointsGreenFirstValue = false;
                bool setScorePointsGreenSecondValue = false;
                int ScorePointsGreenFirstValue= 0;
                int ScorePointsGreenSecondValue= 0;
                bool setScorePointsHeightFirstValue = false;
                bool setScorePointsHeightSecondValue = false;
                float ScorePointsHeightFirstValue= 0;
                float ScorePointsHeightSecondValue= 0;
                bool setScorePointsRedFirstValue = false;
                bool setScorePointsRedSecondValue = false;
                int ScorePointsRedFirstValue= 0;
                int ScorePointsRedSecondValue= 0;
                bool setScorePointsWidthFirstValue = false;
                bool setScorePointsWidthSecondValue = false;
                float ScorePointsWidthFirstValue= 0;
                float ScorePointsWidthSecondValue= 0;
                bool setScorePointsXFirstValue = false;
                bool setScorePointsXSecondValue = false;
                float ScorePointsXFirstValue= 0;
                float ScorePointsXSecondValue= 0;
                bool setScorePointsYFirstValue = false;
                bool setScorePointsYSecondValue = false;
                float ScorePointsYFirstValue= 0;
                float ScorePointsYSecondValue= 0;
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
                        HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RetrysInstance.TextInstanceText = "3\n";
                        }
                        setScorePointsAlphaFirstValue = true;
                        ScorePointsAlphaFirstValue = 255;
                        setScorePointsBlueFirstValue = true;
                        ScorePointsBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ScorePoints.Font = "Arial";
                        }
                        setScorePointsGreenFirstValue = true;
                        ScorePointsGreenFirstValue = 0;
                        setScorePointsHeightFirstValue = true;
                        ScorePointsHeightFirstValue = 16f;
                        if (interpolationValue < 1)
                        {
                            this.ScorePoints.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setScorePointsRedFirstValue = true;
                        ScorePointsRedFirstValue = 176;
                        if (interpolationValue < 1)
                        {
                            this.ScorePoints.Text = "000000000\n\n\n";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScorePoints.UseFontSmoothing = false;
                        }
                        setScorePointsWidthFirstValue = true;
                        ScorePointsWidthFirstValue = 150f;
                        setScorePointsXFirstValue = true;
                        ScorePointsXFirstValue = 46f;
                        setScorePointsYFirstValue = true;
                        ScorePointsYFirstValue = 42f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setXFirstValue = true;
                        XFirstValue = 1f;
                        setYFirstValue = true;
                        YFirstValue = -1f;
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
                        if (interpolationValue >= 1)
                        {
                            this.RetrysInstance.TextInstanceText = "3\n";
                        }
                        setScorePointsAlphaSecondValue = true;
                        ScorePointsAlphaSecondValue = 255;
                        setScorePointsBlueSecondValue = true;
                        ScorePointsBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ScorePoints.Font = "Arial";
                        }
                        setScorePointsGreenSecondValue = true;
                        ScorePointsGreenSecondValue = 0;
                        setScorePointsHeightSecondValue = true;
                        ScorePointsHeightSecondValue = 16f;
                        if (interpolationValue >= 1)
                        {
                            this.ScorePoints.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setScorePointsRedSecondValue = true;
                        ScorePointsRedSecondValue = 176;
                        if (interpolationValue >= 1)
                        {
                            this.ScorePoints.Text = "000000000\n\n\n";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScorePoints.UseFontSmoothing = false;
                        }
                        setScorePointsWidthSecondValue = true;
                        ScorePointsWidthSecondValue = 150f;
                        setScorePointsXSecondValue = true;
                        ScorePointsXSecondValue = 46f;
                        setScorePointsYSecondValue = true;
                        ScorePointsYSecondValue = 42f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setXSecondValue = true;
                        XSecondValue = 1f;
                        setYSecondValue = true;
                        YSecondValue = -1f;
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
                if (setScorePointsAlphaFirstValue && setScorePointsAlphaSecondValue)
                {
                    ScorePoints.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ScorePointsAlphaFirstValue* (1 - interpolationValue) + ScorePointsAlphaSecondValue * interpolationValue);
                }
                if (setScorePointsBlueFirstValue && setScorePointsBlueSecondValue)
                {
                    ScorePoints.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ScorePointsBlueFirstValue* (1 - interpolationValue) + ScorePointsBlueSecondValue * interpolationValue);
                }
                if (setScorePointsGreenFirstValue && setScorePointsGreenSecondValue)
                {
                    ScorePoints.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ScorePointsGreenFirstValue* (1 - interpolationValue) + ScorePointsGreenSecondValue * interpolationValue);
                }
                if (setScorePointsHeightFirstValue && setScorePointsHeightSecondValue)
                {
                    ScorePoints.Height = ScorePointsHeightFirstValue * (1 - interpolationValue) + ScorePointsHeightSecondValue * interpolationValue;
                }
                if (setScorePointsRedFirstValue && setScorePointsRedSecondValue)
                {
                    ScorePoints.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ScorePointsRedFirstValue* (1 - interpolationValue) + ScorePointsRedSecondValue * interpolationValue);
                }
                if (setScorePointsWidthFirstValue && setScorePointsWidthSecondValue)
                {
                    ScorePoints.Width = ScorePointsWidthFirstValue * (1 - interpolationValue) + ScorePointsWidthSecondValue * interpolationValue;
                }
                if (setScorePointsXFirstValue && setScorePointsXSecondValue)
                {
                    ScorePoints.X = ScorePointsXFirstValue * (1 - interpolationValue) + ScorePointsXSecondValue * interpolationValue;
                }
                if (setScorePointsYFirstValue && setScorePointsYSecondValue)
                {
                    ScorePoints.Y = ScorePointsYFirstValue * (1 - interpolationValue) + ScorePointsYSecondValue * interpolationValue;
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
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (NES_1942.GumRuntimes.ScoreCounterRuntime.VariableState fromState,NES_1942.GumRuntimes.ScoreCounterRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                RetrysInstance.StopAnimations();
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
                            Name = "ScorePoints.Alpha",
                            Type = "int",
                            Value = ScorePoints.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Blue",
                            Type = "int",
                            Value = ScorePoints.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Font",
                            Type = "string",
                            Value = ScorePoints.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Green",
                            Type = "int",
                            Value = ScorePoints.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Height",
                            Type = "float",
                            Value = ScorePoints.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ScorePoints.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Red",
                            Type = "int",
                            Value = ScorePoints.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Text",
                            Type = "string",
                            Value = ScorePoints.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.UseFontSmoothing",
                            Type = "bool",
                            Value = ScorePoints.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Width",
                            Type = "float",
                            Value = ScorePoints.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.X",
                            Type = "float",
                            Value = ScorePoints.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Y",
                            Type = "float",
                            Value = ScorePoints.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetrysInstance.TextInstanceText",
                            Type = "string",
                            Value = RetrysInstance.TextInstanceText
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
                            Name = "X",
                            Type = "float",
                            Value = X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + -1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Alpha",
                            Type = "int",
                            Value = ScorePoints.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Blue",
                            Type = "int",
                            Value = ScorePoints.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Font",
                            Type = "string",
                            Value = ScorePoints.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Green",
                            Type = "int",
                            Value = ScorePoints.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Height",
                            Type = "float",
                            Value = ScorePoints.Height + 16f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ScorePoints.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Red",
                            Type = "int",
                            Value = ScorePoints.Red + 176
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Text",
                            Type = "string",
                            Value = ScorePoints.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.UseFontSmoothing",
                            Type = "bool",
                            Value = ScorePoints.UseFontSmoothing
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Width",
                            Type = "float",
                            Value = ScorePoints.Width + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.X",
                            Type = "float",
                            Value = ScorePoints.X + 46f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScorePoints.Y",
                            Type = "float",
                            Value = ScorePoints.Y + 42f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RetrysInstance.TextInstanceText",
                            Type = "string",
                            Value = RetrysInstance.TextInstanceText
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
            public NES_1942.GumRuntimes.TextRuntime ScorePoints { get; set; }
            public NES_1942.GumRuntimes.RetrysRuntime RetrysInstance { get; set; }
            public string RetrysInstanceTextInstanceText
            {
                get
                {
                    return RetrysInstance.TextInstanceText;
                }
                set
                {
                    if (RetrysInstance.TextInstanceText != value)
                    {
                        RetrysInstance.TextInstanceText = value;
                        RetrysInstanceTextInstanceTextChanged?.Invoke(this, null);
                    }
                }
            }
            public string ScorePointsText
            {
                get
                {
                    return ScorePoints.Text;
                }
                set
                {
                    if (ScorePoints.Text != value)
                    {
                        ScorePoints.Text = value;
                        ScorePointsTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent RetrysInstanceClick;
            public event System.EventHandler RetrysInstanceTextInstanceTextChanged;
            public event System.EventHandler ScorePointsTextChanged;
            public ScoreCounterRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "ScoreCounter");
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
                ScorePoints = this.GetGraphicalUiElementByName("ScorePoints") as NES_1942.GumRuntimes.TextRuntime;
                RetrysInstance = this.GetGraphicalUiElementByName("RetrysInstance") as NES_1942.GumRuntimes.RetrysRuntime;
                RetrysInstance.Click += (unused) => RetrysInstanceClick?.Invoke(this);
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
