using System;

namespace Znn_CLicker.ZHotkeys
{
    class toggleUseMiddleMouseButton : ZHotkey
    {
        public toggleUseMiddleMouseButton(int keycode, String settingName)
        {
            this.name = "Use Middle Mouse Button";
            this.settingName = settingName;
            this.help = "Enable this to multiply the clicks for the middle mouse button.";
            this.keycode = keycode;
            this.requiresAlt = true;
        }

        public override void run(int keycode, bool altPressed, bool ctrlPressed)
        {
            StatusManager.useMiddleMouseButton = !StatusManager.useMiddleMouseButton;
        }
    }
}
