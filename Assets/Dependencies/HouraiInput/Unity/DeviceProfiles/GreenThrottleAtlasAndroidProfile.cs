namespace HouraiTeahouse.HouraiInput {

    public class GreenThrottleAtlasAndroidProfile : UnityInputDeviceProfile {

        public GreenThrottleAtlasAndroidProfile() {
            Name = "Green Throttle Atlas Controller";
            Meta = "Green Throttle Atlas Controller on Android";

            SupportedPlatforms = new[] {"Android",};

            JoystickNames = new[] {"Green Throttle Atlas",};

            ButtonMappings = new[] {
                new InputMapping {Handle = "A", Target = InputTarget.Action1, Source = Button0},
                new InputMapping {Handle = "B", Target = InputTarget.Action2, Source = Button1},
                new InputMapping {Handle = "X", Target = InputTarget.Action3, Source = Button2},
                new InputMapping {Handle = "Y", Target = InputTarget.Action4, Source = Button3},
                new InputMapping {Handle = "Left Bumper", Target = InputTarget.LeftBumper, Source = Button4},
                new InputMapping {Handle = "Right Bumper", Target = InputTarget.RightBumper, Source = Button5},
                new InputMapping {Handle = "Left Stick Button", Target = InputTarget.LeftStickButton, Source = Button8},
                new InputMapping {
                    Handle = "Right Stick Button",
                    Target = InputTarget.RightStickButton,
                    Source = Button9
                },
                new InputMapping {Handle = "Start", Target = InputTarget.Start, Source = Button10}
            };

            AnalogMappings = new[] {
                new InputMapping {Handle = "Left Stick X", Target = InputTarget.LeftStickX, Source = Analog0},
                new InputMapping {
                    Handle = "Left Stick Y",
                    Target = InputTarget.LeftStickY,
                    Source = Analog1,
                    Invert = true
                },
                new InputMapping {Handle = "Right Stick X", Target = InputTarget.RightStickX, Source = Analog2},
                new InputMapping {
                    Handle = "Right Stick Y",
                    Target = InputTarget.RightStickY,
                    Source = Analog3,
                    Invert = true
                },
                new InputMapping {
                    Handle = "DPad Left",
                    Target = InputTarget.DPadLeft,
                    Source = Analog4,
                    SourceRange = InputMapping.Negative,
                    TargetRange = InputMapping.Negative,
                    Invert = true
                },
                new InputMapping {
                    Handle = "DPad Right",
                    Target = InputTarget.DPadRight,
                    Source = Analog4,
                    SourceRange = InputMapping.Positive,
                    TargetRange = InputMapping.Positive
                },
                new InputMapping {
                    Handle = "DPad Up",
                    Target = InputTarget.DPadUp,
                    Source = Analog5,
                    SourceRange = InputMapping.Negative,
                    TargetRange = InputMapping.Negative,
                    Invert = true
                },
                new InputMapping {
                    Handle = "DPad Down",
                    Target = InputTarget.DPadDown,
                    Source = Analog5,
                    SourceRange = InputMapping.Positive,
                    TargetRange = InputMapping.Positive,
                },
                new InputMapping {Handle = "Left Trigger", Target = InputTarget.LeftTrigger, Source = Analog12,},
                new InputMapping {Handle = "Right Trigger", Target = InputTarget.RightTrigger, Source = Analog11,}
            };
        }

    }

}