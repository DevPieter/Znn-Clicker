using System;

namespace Znn_CLicker.ZHotkeys
{
    class Toggle : ZHotkey
    {

        public Toggle(int keycode, String settingName)
        {
            this.name = $"Enable/Disable {Home.NAME}";
            this.settingName = settingName;
            this.help = $"Turn {Home.NAME} on and off.";
            this.keycode = keycode;
            this.requiresAlt = true;
        }

        public override void run(int keycode, bool altPressed, bool ctrlPressed)
        {
            StatusManager.isActive = !StatusManager.isActive;
        }
    }
}
