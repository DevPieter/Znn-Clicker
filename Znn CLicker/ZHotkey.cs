using System;

namespace Znn_CLicker
{
    public abstract class ZHotkey
    {
        protected String name = "null";
        protected String help = "No help provided.";
        protected String settingName = "";
        protected int keycode = 0;
        protected bool requiresAlt = false;
        protected bool requiresCtrl = false;

        public abstract void run(int keycode, bool altPressed, bool ctrlPressed);

        public String getKey()
        {
            String key = "";

            if (requiresCtrl)
                key += "Ctrl + ";

            if (requiresAlt)
                key += "Alt + ";

            return key += KeycodeToChar.convert(this.keycode);
        }

        public String getKeyWithName()
        {
            return $"{this.name}: {getKey()}";
        }

        public int getKkeycode()
        {
            return keycode;
        }

        public void setKkeycode(int keycode)
        {
            this.keycode = keycode;
        }

        public String getName()
        {
            return name;
        }

        public String getHelp()
        {
            return help;
        }

        public String getFullHelp()
        {
            return $"{help}\n\nKeybinding: {getKey()}";
        }

        public String getSettingName()
        {
            return settingName;
        }

        public bool isAltRequired()
        {
            return requiresAlt;
        }

        public bool isCtrlRequired()
        {
            return requiresCtrl;
        }
    }
}
