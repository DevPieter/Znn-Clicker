﻿using System;
using System.Windows.Forms;

namespace Znn_CLicker
{
    class KeycodeToChar
    {
        private static KeysConverter kc = new KeysConverter();

        public static String convert(int keycode)
        {
            switch (keycode)
            {
                case 160:
                    return "L Shift";
                case 161:
                    return "R Shift";
                case 162:
                    return "L Ctrl";
                case 163:
                    return "R Ctrl";
                case 164:
                    return "L Alt";
                case 165:
                    return "R Alt";
                case 8:
                    return "Backspace";
                case 9:
                    return "Tab";
                case 13:
                    return "Enter";
                case 16:
                    return "Shift";
                case 17:
                    return "Ctrl";
                case 18:
                    return "Alt";
                case 19:
                    return "Pause";
                case 20:
                    return "Caps Lock";
                case 27:
                    return "Escape";
                case 33:
                    return "Page Up";
                case 34:
                    return "Page Down";
                case 35:
                    return "End";
                case 36:
                    return "Home";
                case 37:
                    return "Left";
                case 38:
                    return "Up";
                case 39:
                    return "Right";
                case 40:
                    return "Down";
                case 45:
                    return "Insert";
                case 46:
                    return "Delete";
                case 48:
                    return "1";
                case 50:
                    return "2";
                case 51:
                    return "3";
                case 52:
                    return "4";
                case 53:
                    return "5";
                case 54:
                    return "6";
                case 55:
                    return "7";
                case 56:
                    return "8";
                case 57:
                    return "9";
                case 65:
                    return "A";
                case 66:
                    return "B";
                case 67:
                    return "C";
                case 68:
                    return "D";
                case 69:
                    return "E";
                case 70:
                    return "F";
                case 71:
                    return "G";
                case 72:
                    return "H";
                case 73:
                    return "I";
                case 74:
                    return "J";
                case 75:
                    return "K";
                case 76:
                    return "L";
                case 77:
                    return "M";
                case 78:
                    return "N";
                case 79:
                    return "O";
                case 80:
                    return "P";
                case 81:
                    return "Q";
                case 82:
                    return "R";
                case 83:
                    return "S";
                case 84:
                    return "T";
                case 85:
                    return "U";
                case 86:
                    return "V";
                case 87:
                    return "W";
                case 88:
                    return "X";
                case 89:
                    return "Y";
                case 90:
                    return "Z";
                case 91:
                    return "L Win";
                case 92:
                    return "R Win";
                case 93:
                    return "Select";
                case 96:
                    return "Num 0";
                case 97:
                    return "Num 1";
                case 98:
                    return "Num 2";
                case 99:
                    return "Num 3";
                case 100:
                    return "Num 4";
                case 101:
                    return "Num 5";
                case 102:
                    return "Num 6";
                case 103:
                    return "Num 7";
                case 104:
                    return "Num 8";
                case 105:
                    return "Num 9";
                case 106:
                    return "Multiply";
                case 107:
                    return "Add";
                case 109:
                    return "Subtract";
                case 110:
                    return "Decimal point";
                case 111:
                    return "Divide";
                case 112:
                    return "F1";
                case 113:
                    return "F2";
                case 114:
                    return "F3";
                case 115:
                    return "F4";
                case 116:
                    return "F5";
                case 117:
                    return "F6";
                case 118:
                    return "F7";
                case 119:
                    return "F8";
                case 120:
                    return "F9";
                case 121:
                    return "F10";
                case 122:
                    return "F11";
                case 123:
                    return "F12";
                case 144:
                    return "Num Lock";
                case 145:
                    return "Scroll Lock";
                case 186:
                    return "Semi-Colon";
                case 187:
                    return "Equals";
                case 188:
                    return "Comma";
                case 189:
                    return "Dash";
                case 190:
                    return "Period";
                case 191:
                    return "Forward Slash";
                case 192:
                    return "Grave Accent";
                case 219:
                    return "Open Bracket";
                case 220:
                    return "Back Slash";
                case 221:
                    return "Close Braket";
                case 222:
                    return "Single Quote";
                case 175:
                    return "Volume Up";
                case 174:
                    return "Volume Down";
                case 179:
                    return "Play/Pause";
                case 176:
                    return "Next Track";
                case 177:
                    return "Previous track";
                default:
                    return kc.ConvertToString(keycode);
            }
        }
    }
}
