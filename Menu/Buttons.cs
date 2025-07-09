using StupidTemplate.Classes;
using StupidTemplate.Mods;
using TEST_MENU.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Main", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens my first mods."},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // Main
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Main", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens my first mods."},
                new ButtonInfo { buttonText = "Speed Boost", method =() => SpeedBoost.SpeedBoost1(), toolTip = "Insane SpeedBoost. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Button Fly", method =() => ButtonFly.Buttonfly(), toolTip = "Fly in the direction of your head when A is held. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Platforms", method =() => Platforms.Platforms1(), toolTip = "Platforms. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Monke", method =() => Ghost_Monke.Ghostmonke(), toolTip = "Turns you invisible. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Noclip", method =() => Noclip.Noclip1(), toolTip = "Disable colliders. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Car Monke", method =() => CarMonke.Carmonke(), toolTip = "Go in the direction of your head. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Long Arms", method =() => LongArms.Longarms(), toolTip = "Makes your arms long. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Reset Arms", method =() => ResetArms.Resetarms(), toolTip = "Makes your arms long. UND", isTogglable = true},
            },
        };
    }
}
