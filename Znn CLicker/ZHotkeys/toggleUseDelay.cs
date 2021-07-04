using System;

namespace Znn_CLicker.ZHotkeys
{
    class toggleUseDelay : ZHotkey
    {
        public toggleUseDelay(int keycode, String settingName)
        {
            this.name = "Use Delay Between Clicks";
            this.settingName = settingName;
            this.help = "Adds a delay between sending clicks.";
            this.keycode = keycode;
            this.requiresAlt = true;
        }

        public override void run(int keycode, bool altPressed, bool ctrlPressed)
        {
            StatusManager.useDelay = !StatusManager.useDelay;
        }
    }
}
