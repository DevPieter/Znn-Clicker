using Gma.System.MouseKeyHook;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Znn_CLicker.ZHotkeys;

namespace Znn_CLicker
{
    public partial class Home : MaterialForm
    {
        public static String NAME = "Znn Clicker";

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        private Dictionary<MaterialTextBox, ZHotkey> HotkeyTextBoxList = new Dictionary<MaterialTextBox, ZHotkey>();
        private List<int> disallowedKeys = new List<int> { 27, 20, 18, 17, 16, 8, 91 };

        private Random _Random = new Random();
        private MaterialSkin.MaterialSkinManager _MaterialSkinManager;

        private ZHotkeyManager hotkeyManager = new ZHotkeyManager();
        private IKeyboardMouseEvents _GlobalHook;

        public Home()
        {
            InitializeComponent();
            _MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            _MaterialSkinManager.EnforceBackcolorOnAllComponents = true;
            _MaterialSkinManager.AddFormToManage(this);
            _MaterialSkinManager.Theme = ThemeSettings.Default.useDarkMode ? MaterialSkin.MaterialSkinManager.Themes.DARK : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        // ===== Keyboard Hook ===== \\
        public void Subscribe()
        {
            _GlobalHook = Hook.GlobalEvents();
            _GlobalHook.KeyDown += GlobalHook_KeyDown;
        }

        public void Unsubscribe()
        {
            _GlobalHook.KeyDown -= GlobalHook_KeyDown;
            _GlobalHook.Dispose();
        }

        private void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (hotkeyManager.handle(e.KeyValue, e.Alt, e.Control))
                updateStatus();
        }

        // ===== Hotkeys ===== \\
        private void registerHotkeys()
        {
            hotkeyManager.addHotkey(new Toggle(HotkeySettings.Default.toggle, nameof(HotkeySettings.Default.toggle)));
            hotkeyManager.addHotkey(new toggleUseDelay(HotkeySettings.Default.toggleUseDelay, nameof(HotkeySettings.Default.toggleUseDelay)));

            hotkeyManager.addHotkey(new toggleUseRandomMultiplier(HotkeySettings.Default.toggleUseRandomMultiplier, nameof(HotkeySettings.Default.toggleUseRandomMultiplier)));
            hotkeyManager.addHotkey(new toggleUseRandomDelay(HotkeySettings.Default.toggleUseRandomDelay, nameof(HotkeySettings.Default.toggleUseRandomDelay)));

            hotkeyManager.addHotkey(new toggleUseLeftMouseButton(HotkeySettings.Default.toggleUseLeftMouseButton, nameof(HotkeySettings.Default.toggleUseLeftMouseButton)));
            hotkeyManager.addHotkey(new toggleUseRightMouseButton(HotkeySettings.Default.toggleUseRightMouseButton, nameof(HotkeySettings.Default.toggleUseRightMouseButton)));
            hotkeyManager.addHotkey(new toggleUseMiddleMouseButton(HotkeySettings.Default.toggleUseMiddleMouseButton, nameof(HotkeySettings.Default.toggleUseMiddleMouseButton)));
        }

        private void loadHotkeys()
        {
            materialCard_Hotkeys.Controls.Clear();
            int x = 17;
            int y = 14;
            int add = 65;
            Size size = new Size(245, 50);
            foreach (ZHotkey hotkey in hotkeyManager.getHotkeyList())
            {
                MaterialLabel label = new MaterialLabel() { Text = hotkey.getName(), Size = size, Location = new Point(x, y), TextAlign = ContentAlignment.MiddleLeft };
                toolTip.SetToolTip(label, hotkey.getHelp());

                MaterialTextBox textBox = new MaterialTextBox() { Text = hotkey.getKey(), Size = size, Location = new Point((x + 241), y), ReadOnly = true };
                toolTip.SetToolTip(textBox, hotkey.getHelp());
                textBox.Enter += new EventHandler(HotkeyTextBox_Enter);
                textBox.Leave += new EventHandler(HotkeyTextBox_Leave);
                textBox.KeyDown += new KeyEventHandler(HotkeyTextBox_KeyDown);
                HotkeyTextBoxList.Add(textBox, hotkey);

                materialCard_Hotkeys.Controls.Add(label);
                materialCard_Hotkeys.Controls.Add(textBox);
                y += add;
            }
        }

        private void loadHotkeyData()
        {
            materialCard_Display.Controls.Clear();
            int x = 17;
            int y = 14;
            int add = 38;
            Size size = new Size(290, 23);

            foreach (ZHotkey hotkey in hotkeyManager.getHotkeyList())
            {
                MaterialLabel label = new MaterialLabel() { Text = hotkey.getKeyWithName(), Size = size, Location = new Point(x, y), TextAlign = ContentAlignment.MiddleLeft, Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right) };
                toolTip.SetToolTip(label, hotkey.getHelp());

                materialCard_Display.Controls.Add(label);
                y += add;
            }
        }

        private void HotkeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            MaterialTextBox textBox = (MaterialTextBox)sender;
            ZHotkey hotkey = HotkeyTextBoxList[textBox];

            if (!disallowedKeys.Contains(e.KeyValue))
            {
                hotkey.setKkeycode(e.KeyValue);
                HotkeySettings.Default[hotkey.getSettingName()] = e.KeyValue;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;

            updateTooltip();
            materialCard_Hotkeys.Focus();
        }

        private void HotkeyTextBox_Enter(object sender, EventArgs e)
        {
            MaterialTextBox textBox = (MaterialTextBox)sender;
            textBox.Text = "Press a key... (Esc to cancel)";
        }

        private void HotkeyTextBox_Leave(object sender, EventArgs e)
        {
            MaterialTextBox textBox = (MaterialTextBox)sender;
            ZHotkey hotkey = HotkeyTextBoxList[textBox];
            textBox.Text = hotkey.getKey();
        }

        // ===== Form ===== \\
        private void Home_Load(object sender, EventArgs e)
        {
            box_Primary_1.DataSource = Enum.GetValues(typeof(MaterialSkin.Primary));
            box_Primary_2.DataSource = Enum.GetValues(typeof(MaterialSkin.Primary));
            box_Primary_3.DataSource = Enum.GetValues(typeof(MaterialSkin.Primary));
            box_Accent.DataSource = Enum.GetValues(typeof(MaterialSkin.Accent));

            loadAdvancedThemeSettings();
            loadSettings();

            registerHotkeys();
            loadHotkeys();
            loadHotkeyData();

            updateStatus();
            updateTooltip();

            Subscribe();

            HotkeySettings.Default.PropertyChanged += HotkeySettings_Changed;
            Settings.Default.PropertyChanged += Settings_Changed;
            ThemeSettings.Default.PropertyChanged += ThemeSettings_Changed;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            StatusManager.isActive = false;
            Unsubscribe();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            if (Settings.Default.autoTurnOff)
                StatusManager.isActive = false;
            updateStatus();
        }

        private void materialCard_Hotkeys_Click(object sender, EventArgs e)
        {
            materialCard_Hotkeys.Focus();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            updateStatus();
            if (materialCard_Hotkeys.Visible)
                materialCard_Hotkeys.Focus();
        }

        private void tab_Controls_Click(object sender, EventArgs e)
        {
            if (materialCard_Hotkeys.Visible)
                materialCard_Hotkeys.Focus();
        }

        private void Home_ResizeBegin(object sender, EventArgs e)
        {
            updateStatus();
        }

        // ===== Buttons ===== \\
        private void btn_ResetTheme_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the theme to its default value?", NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ThemeSettings.Default.Reset();
                loadAdvancedThemeSettings();
            }
        }

        private void btn_DiscardChangesTheme_Click(object sender, EventArgs e)
        {
            loadAdvancedThemeSettings();
            switch_AdvancedThemeOptions.Checked = false;
        }

        private void btn_SaveTheme_Click(object sender, EventArgs e)
        {
            saveAdvancedThemeSettings();
            loadAdvancedThemeSettings();
        }

        private void btn_SettingsReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset all key bindings to their defaults?", NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HotkeySettings.Default.Reset();
                hotkeyManager.reloadAllHotkeysKeycodes();
                loadHotkeys();
                loadHotkeyData();
                updateTooltip();
            }
        }

        // ===== Switches ===== \\
        private void switch_Enabled_CheckedChanged(object sender, EventArgs e)
        {
            StatusManager.isActive = switch_Enabled.Checked;
            if (switch_Enabled.Checked)
                timer_MouseClick.Start();
            else
                timer_MouseClick.Stop();
        }

        private void switch_UseDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (switch_UseDelay.Checked)
            {
                check_UseRandomDelay.Enabled = true;
                slider_MaxDelay.Enabled = true;

                if (check_UseRandomDelay.Checked)
                    slider_MinDelay.Enabled = true;
            }
            else
            {
                check_UseRandomDelay.Enabled = false;
                slider_MaxDelay.Enabled = false;
                slider_MinDelay.Enabled = false;
            }
            StatusManager.useDelay = switch_UseDelay.Checked;
        }

        private void switch_UseDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (switch_UseDarkMode.Checked)
                _MaterialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            else
                _MaterialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            ThemeSettings.Default.useDarkMode = switch_UseDarkMode.Checked;
        }

        private void switch_AdvancedThemeOptions_CheckedChanged(object sender, EventArgs e)
        {
            if (switch_AdvancedThemeOptions.Checked)
            {
                box_Primary_1.Enabled = true;
                box_Primary_2.Enabled = true;
                box_Primary_3.Enabled = true;
                box_Accent.Enabled = true;
                btn_DiscardChangesTheme.Enabled = true;
                btn_ResetTheme.Enabled = true;
                btn_SaveTheme.Enabled = true;
            }
            else
            {
                box_Primary_1.Enabled = false;
                box_Primary_2.Enabled = false;
                box_Primary_3.Enabled = false;
                box_Accent.Enabled = false;
                btn_DiscardChangesTheme.Enabled = false;
                btn_ResetTheme.Enabled = false;
                btn_SaveTheme.Enabled = false;
            }
        }

        private void switch_autoTurnOff_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.autoTurnOff = switch_autoTurnOff.Checked;
        }

        // ===== Sliders ===== \\
        private void slider_MaxMultiplier_onValueChanged(object sender, int newValue)
        {
            if (slider_MaxMultiplier.Value <= 0)
                slider_MaxMultiplier.Value = 1;

            if (slider_MinMultiplier.Value > slider_MaxMultiplier.Value)
                slider_MinMultiplier.Value = slider_MaxMultiplier.Value;
            StatusManager.maxMultiplier = slider_MaxMultiplier.Value;
            StatusManager.minMultiplier = slider_MinMultiplier.Value;
        }

        private void slider_MinMultiplier_onValueChanged(object sender, int newValue)
        {
            if (slider_MinMultiplier.Value <= 0)
                slider_MinMultiplier.Value = 1;

            if (slider_MinMultiplier.Value > slider_MaxMultiplier.Value)
                slider_MaxMultiplier.Value = slider_MinMultiplier.Value;
            StatusManager.maxMultiplier = slider_MaxMultiplier.Value;
            StatusManager.minMultiplier = slider_MinMultiplier.Value;
        }

        private void slider_MaxDelay_onValueChanged(object sender, int newValue)
        {
            if (slider_MaxDelay.Value <= 4)
                slider_MaxDelay.Value = 5;

            if (slider_MinDelay.Value > slider_MaxDelay.Value)
                slider_MinDelay.Value = slider_MaxDelay.Value;
            StatusManager.maxDelay = slider_MaxDelay.Value;
            StatusManager.minDelay = slider_MinDelay.Value;
        }

        private void slider_MinDelay_onValueChanged(object sender, int newValue)
        {
            if (slider_MinDelay.Value <= 4)
                slider_MinDelay.Value = 5;

            if (slider_MinDelay.Value > slider_MaxDelay.Value)
                slider_MaxDelay.Value = slider_MinDelay.Value;
            StatusManager.maxDelay = slider_MaxDelay.Value;
            StatusManager.minDelay = slider_MinDelay.Value;
        }

        // ===== Checkboxes ===== \\
        private void check_UseRandomMultiplier_CheckedChanged(object sender, EventArgs e)
        {
            if (check_UseRandomMultiplier.Checked)
                slider_MinMultiplier.Enabled = true;
            else
                slider_MinMultiplier.Enabled = false;
            StatusManager.useRandomMultiplier = check_UseRandomMultiplier.Checked;
        }

        private void check_UseRandomDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (switch_UseDelay.Checked && check_UseRandomDelay.Checked)
                slider_MinDelay.Enabled = true;
            else
                slider_MinDelay.Enabled = false;
            StatusManager.useRandomDelay = check_UseRandomDelay.Checked;
        }

        private void check_UseLeftMouseButton_CheckedChanged(object sender, EventArgs e)
        {
            StatusManager.useLeftMouseButton = check_UseLeftMouseButton.Checked;
        }

        private void check_UseRightMouseButton_CheckedChanged(object sender, EventArgs e)
        {
            StatusManager.useRightMouseButton = check_UseRightMouseButton.Checked;
        }

        private void check_UseMiddleMouseButton_CheckedChanged(object sender, EventArgs e)
        {
            StatusManager.useMiddleMouseButton = check_UseMiddleMouseButton.Checked;
        }

        // ===== Tooltip ===== \\
        private void updateTooltip()
        {
            toolTip.SetToolTip(switch_Enabled, hotkeyManager.getHotkey(HotkeySettings.Default.toggle).getFullHelp());
            toolTip.SetToolTip(switch_UseDelay, hotkeyManager.getHotkey(HotkeySettings.Default.toggleUseDelay).getFullHelp());

            toolTip.SetToolTip(check_UseRandomMultiplier, hotkeyManager.getHotkey(HotkeySettings.Default.toggleUseRandomMultiplier).getFullHelp());
            toolTip.SetToolTip(check_UseRandomDelay, hotkeyManager.getHotkey(HotkeySettings.Default.toggleUseRandomDelay).getFullHelp());

            toolTip.SetToolTip(check_UseLeftMouseButton, hotkeyManager.getHotkey(HotkeySettings.Default.toggleUseLeftMouseButton).getFullHelp());
            toolTip.SetToolTip(check_UseRightMouseButton, hotkeyManager.getHotkey(HotkeySettings.Default.toggleUseRightMouseButton).getFullHelp());
            toolTip.SetToolTip(check_UseMiddleMouseButton, hotkeyManager.getHotkey(HotkeySettings.Default.toggleUseMiddleMouseButton).getFullHelp());
        }

        // ===== Timers ===== \\
        private void timer_MouseClick_Tick(object sender, EventArgs e)
        {
            if (StatusManager.isActive)
            {
                int multiplier = StatusManager.maxMultiplier;
                if (StatusManager.useRandomMultiplier)
                    multiplier = _Random.Next(StatusManager.minMultiplier, (StatusManager.maxMultiplier + 1));

                int delay = StatusManager.useDelay ? StatusManager.maxDelay : 1;
                if (StatusManager.useDelay && StatusManager.useRandomDelay)
                    delay = _Random.Next(StatusManager.minDelay, (StatusManager.maxDelay + 1));

                if (StatusManager.useLeftMouseButton && MouseButtons == MouseButtons.Left)
                    leftClick(multiplier, delay);

                if (StatusManager.useRightMouseButton && MouseButtons == MouseButtons.Right)
                    rightClick(multiplier, delay);

                if (StatusManager.isActive && StatusManager.useMiddleMouseButton && MouseButtons == MouseButtons.Middle)
                    middleClick(multiplier, delay);
            }
        }

        // ===== Click ===== \\
        private async void leftClick(int multiplier, int delay)
        {
            for (int l = 0; l < multiplier; l++)
            {
                if (StatusManager.isActive)
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                else
                    break;
                await Task.Delay(delay);
            }
        }

        private async void rightClick(int multiplier, int delay)
        {
            for (int l = 0; l < multiplier; l++)
            {
                if (StatusManager.isActive)
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                else
                    break;
                await Task.Delay(delay);
            }
        }

        private async void middleClick(int multiplier, int delay)
        {
            for (int l = 0; l < multiplier; l++)
            {
                if (StatusManager.isActive)
                    mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                else
                    break;
                await Task.Delay(delay);
            }
        }

        // ===== Theme ===== \\
        private void saveAdvancedThemeSettings()
        {
            MaterialSkin.Primary Primary;
            MaterialSkin.Primary DarkPrimary;
            MaterialSkin.Primary LightPrimary;
            MaterialSkin.Accent Accent;

            Enum.TryParse(box_Primary_1.SelectedValue.ToString(), out Primary);
            Enum.TryParse(box_Primary_2.SelectedValue.ToString(), out DarkPrimary);
            Enum.TryParse(box_Primary_3.SelectedValue.ToString(), out LightPrimary);
            Enum.TryParse(box_Accent.SelectedValue.ToString(), out Accent);

            ThemeSettings.Default.Primary1 = Primary;
            ThemeSettings.Default.Primary2 = DarkPrimary;
            ThemeSettings.Default.Primary3 = LightPrimary;
            ThemeSettings.Default.Accent1 = Accent;
        }

        private void loadAdvancedThemeSettings()
        {
            switch_UseDarkMode.Checked = ThemeSettings.Default.useDarkMode;
            box_Primary_1.SelectedItem = ThemeSettings.Default.Primary1;
            box_Primary_2.SelectedItem = ThemeSettings.Default.Primary2;
            box_Primary_3.SelectedItem = ThemeSettings.Default.Primary3;
            box_Accent.SelectedItem = ThemeSettings.Default.Accent1;

            _MaterialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(ThemeSettings.Default.Primary1, ThemeSettings.Default.Primary2, ThemeSettings.Default.Primary3, ThemeSettings.Default.Accent1, ThemeSettings.Default.TextShade);
        }

        // ===== Settings ===== \\
        private void loadSettings()
        {
            switch_autoTurnOff.Checked = Settings.Default.autoTurnOff;
        }

        // ===== Settings Changed Events ===== \\
        private void ThemeSettings_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ThemeSettings.Default.Save();
            loadAdvancedThemeSettings();
        }

        private void Settings_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Settings.Default.Save();
            loadSettings();
        }

        private void HotkeySettings_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            HotkeySettings.Default.Save();
        }

        // ===== Misc ===== \\
        public void updateStatus()
        {
            switch_Enabled.Checked = StatusManager.isActive;
            check_UseRandomMultiplier.Checked = StatusManager.useRandomMultiplier;
            switch_UseDelay.Checked = StatusManager.useDelay;
            check_UseRandomDelay.Checked = StatusManager.useRandomDelay;

            slider_MaxMultiplier.Value = StatusManager.maxMultiplier;
            slider_MinMultiplier.Value = StatusManager.minMultiplier;

            slider_MaxDelay.Value = StatusManager.maxDelay;
            slider_MinDelay.Value = StatusManager.minDelay;

            check_UseLeftMouseButton.Checked = StatusManager.useLeftMouseButton;
            check_UseRightMouseButton.Checked = StatusManager.useRightMouseButton;
            check_UseMiddleMouseButton.Checked = StatusManager.useMiddleMouseButton;
        }
    }
}

