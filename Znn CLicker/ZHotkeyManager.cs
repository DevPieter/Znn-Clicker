using System;
using System.Collections.Generic;

namespace Znn_CLicker
{
    class ZHotkeyManager
    {
        private List<ZHotkey> hotkeys = new List<ZHotkey>();

        public void addHotkey(ZHotkey hotkey)
        {
            if (hotkeys.Contains(hotkey))
                return;
            hotkeys.Add(hotkey);
        }

        public ZHotkey getHotkey(String name)
        {
            foreach (ZHotkey hotkey in hotkeys)
                if (hotkey.getName().ToLower().Equals(name.ToLower()))
                    return hotkey;
            return null;
        }

        public ZHotkey getHotkey(int keycode)
        {
            foreach (ZHotkey hotkey in hotkeys)
                if (hotkey.getKkeycode().Equals(keycode))
                    return hotkey;
            return null;
        }

        public void reloadAllHotkeysKeycodes()
        {
            foreach (ZHotkey hotkey in hotkeys)
                hotkey.setKkeycode(int.Parse(HotkeySettings.Default.Properties[hotkey.getSettingName()].DefaultValue.ToString()));
        }

        public List<ZHotkey> getHotkeyList()
        {
            return hotkeys;
        }

        public bool handle(int keycode, bool altPressed, bool ctrlPressed)
        {
            ZHotkey hotkey = this.getHotkey(keycode);
            if (hotkey == null)
                return false;

            if (hotkey.isAltRequired() && !altPressed)
                return false;

            if (hotkey.isCtrlRequired() && !ctrlPressed)
                return false;

            hotkey.run(keycode, altPressed, ctrlPressed);
            return true;
        }
    }
}
