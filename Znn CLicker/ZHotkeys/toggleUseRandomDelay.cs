using System;

namespace Znn_CLicker.ZHotkeys
{
    class toggleUseRandomDelay : ZHotkey
    {
        public toggleUseRandomDelay(int keycode, String settingName)
        {
            this.name = "Use Random Delay";
            this.settingName = settingName;
            this.help = "Adds a random delay between sending clicks.\nYou can set the random delay with the min and max delay sliders.";
            this.keycode = keycode;
            this.requiresAlt = true;
        }

        public override void run(int keycode, bool altPressed, bool ctrlPressed)
        {
            StatusManager.useRandomDelay = !StatusManager.useRandomDelay;
        }
    }
}
