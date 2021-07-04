using System;

namespace Znn_CLicker.ZHotkeys
{
    class toggleUseRightMouseButton : ZHotkey
    {
        public toggleUseRightMouseButton(int keycode, String settingName)
        {
            this.name = "Use Right Mouse Button";
            this.settingName = settingName;
            this.help = "Enable this to multiply the clicks for the right mouse button.";
            this.keycode = keycode;
            this.requiresAlt = true;
        }

        public override void run(int keycode, bool altPressed, bool ctrlPressed)
        {
            StatusManager.useRightMouseButton = !StatusManager.useRightMouseButton;
        }
    }
}
