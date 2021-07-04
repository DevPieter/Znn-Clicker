using System;

namespace Znn_CLicker.ZHotkeys
{
    class toggleUseRandomMultiplier : ZHotkey
    {
        public toggleUseRandomMultiplier(int keycode, String settingName)
        {
            this.name = "Use Random Multiplier";
            this.settingName = settingName;
            this.help = "Picks a random multiplier.\nYou can set the random multiplier using the min and max multiplier sliders.";
            this.keycode = keycode;
            this.requiresAlt = true;
        }

        public override void run(int keycode, bool altPressed, bool ctrlPressed)
        {
            StatusManager.useRandomMultiplier = !StatusManager.useRandomMultiplier;
        }
    }
}
