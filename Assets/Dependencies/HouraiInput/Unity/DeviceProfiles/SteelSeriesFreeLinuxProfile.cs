namespace HouraiTeahouse.HouraiInput {

    public class SteelSeriesFreeLinuxProfile : UnityInputDeviceProfile {

        public SteelSeriesFreeLinuxProfile() {
            Name = "SteelSeries Free";
            Meta = "SteelSeries Free on Linux";

            SupportedPlatforms = new[] {"Linux",};

            JoystickNames = new[] {"Zeemote: SteelSeries FREE"};

            ButtonMappings = new[] {
                new InputMapping {Handle = "4", Target = InputTarget.Action1, Source = Button0},
                new InputMapping {Handle = "3", Target = InputTarget.Action2, Source = Button1},
                new InputMapping {Handle = "1", Target = InputTarget.Action3, Source = Button3},
                new InputMapping {Handle = "2", Target = InputTarget.Action4, Source = Button4},
                new InputMapping {Handle = "Left Bumper", Target = InputTarget.LeftBumper, Source = Button6},
                new InputMapping {Handle = "Right Bumper", Target = InputTarget.RightBumper, Source = Button7},
                new InputMapping {Handle = "Back", Target = InputTarget.Select, Source = Button12},
                new InputMapping {Handle = "Start", Target = InputTarget.Start, Source = Button11}
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
                    Invert = false
                }
            };
        }

    }

}