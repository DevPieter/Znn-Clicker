using System;

namespace Znn_CLicker.ZHotkeys
{
    class toggleUseLeftMouseButton : ZHotkey
    {
        public toggleUseLeftMouseButton(int keycode, String settingName)
        {
            this.name = "Use Left Mouse Button";
            this.settingName = settingName;
            this.help = "Enable this to multiply the clicks for the left mouse button.";
            this.keycode = keycode;
            this.requiresAlt = true;
        }

        public override void run(int keycode, bool altPressed, bool ctrlPressed)
        {
            StatusManager.useLeftMouseButton = !StatusManager.useLeftMouseButton;
        }
    }
}
