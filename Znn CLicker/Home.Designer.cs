
namespace Znn_CLicker
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabControl_Main = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.materialCard_Display = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.switch_UseDelay = new MaterialSkin.Controls.MaterialSwitch();
            this.check_UseRandomDelay = new MaterialSkin.Controls.MaterialCheckbox();
            this.slider_MinDelay = new MaterialSkin.Controls.MaterialSlider();
            this.slider_MaxDelay = new MaterialSkin.Controls.MaterialSlider();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.check_UseMiddleMouseButton = new MaterialSkin.Controls.MaterialCheckbox();
            this.check_UseLeftMouseButton = new MaterialSkin.Controls.MaterialCheckbox();
            this.check_UseRightMouseButton = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.switch_Enabled = new MaterialSkin.Controls.MaterialSwitch();
            this.check_UseRandomMultiplier = new MaterialSkin.Controls.MaterialCheckbox();
            this.slider_MinMultiplier = new MaterialSkin.Controls.MaterialSlider();
            this.slider_MaxMultiplier = new MaterialSkin.Controls.MaterialSlider();
            this.tab_Controls = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.btn_SettingsReset = new MaterialSkin.Controls.MaterialButton();
            this.materialCard_Hotkeys = new MaterialSkin.Controls.MaterialCard();
            this.tab_Settings = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.switch_autoTurnOff = new MaterialSkin.Controls.MaterialSwitch();
            this.switch_AdvancedThemeOptions = new MaterialSkin.Controls.MaterialSwitch();
            this.switch_UseDarkMode = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.btn_ResetTheme = new MaterialSkin.Controls.MaterialButton();
            this.btn_DiscardChangesTheme = new MaterialSkin.Controls.MaterialButton();
            this.btn_SaveTheme = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.box_Accent = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.box_Primary_3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.box_Primary_2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.box_Primary_1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList_Main = new System.Windows.Forms.ImageList(this.components);
            this.timer_MouseClick = new System.Windows.Forms.Timer(this.components);
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl_Main.SuspendLayout();
            this.tab_Home.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tab_Controls.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.tab_Settings.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tab_Home);
            this.tabControl_Main.Controls.Add(this.tab_Controls);
            this.tabControl_Main.Controls.Add(this.tab_Settings);
            this.tabControl_Main.Depth = 0;
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.ImageList = this.imageList_Main;
            this.tabControl_Main.Location = new System.Drawing.Point(3, 64);
            this.tabControl_Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl_Main.Multiline = true;
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(894, 433);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tab_Home
            // 
            this.tab_Home.Controls.Add(this.materialCard_Display);
            this.tab_Home.Controls.Add(this.materialCard3);
            this.tab_Home.Controls.Add(this.materialCard2);
            this.tab_Home.Controls.Add(this.materialCard1);
            this.tab_Home.ImageKey = "Home.png";
            this.tab_Home.Location = new System.Drawing.Point(4, 23);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Home.Size = new System.Drawing.Size(886, 406);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Home";
            this.tab_Home.UseVisualStyleBackColor = true;
            // 
            // materialCard_Display
            // 
            this.materialCard_Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard_Display.AutoScroll = true;
            this.materialCard_Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard_Display.Depth = 0;
            this.materialCard_Display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard_Display.Location = new System.Drawing.Point(531, 209);
            this.materialCard_Display.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard_Display.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard_Display.Name = "materialCard_Display";
            this.materialCard_Display.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard_Display.Size = new System.Drawing.Size(338, 180);
            this.materialCard_Display.TabIndex = 7;
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Controls.Add(this.materialLabel5);
            this.materialCard3.Controls.Add(this.switch_UseDelay);
            this.materialCard3.Controls.Add(this.check_UseRandomDelay);
            this.materialCard3.Controls.Add(this.slider_MinDelay);
            this.materialCard3.Controls.Add(this.slider_MaxDelay);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(17, 209);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14, 14, 0, 14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(500, 180);
            this.materialCard3.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(11, 123);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(123, 40);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Min Delay";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(11, 77);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(123, 40);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Max Delay";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switch_UseDelay
            // 
            this.switch_UseDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_UseDelay.Depth = 0;
            this.switch_UseDelay.Location = new System.Drawing.Point(14, 14);
            this.switch_UseDelay.Margin = new System.Windows.Forms.Padding(0);
            this.switch_UseDelay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_UseDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_UseDelay.Name = "switch_UseDelay";
            this.switch_UseDelay.Ripple = true;
            this.switch_UseDelay.Size = new System.Drawing.Size(258, 40);
            this.switch_UseDelay.TabIndex = 3;
            this.switch_UseDelay.TabStop = false;
            this.switch_UseDelay.Text = "Use Delay Between Clicks";
            this.switch_UseDelay.UseVisualStyleBackColor = true;
            this.switch_UseDelay.CheckedChanged += new System.EventHandler(this.switch_UseDelay_CheckedChanged);
            // 
            // check_UseRandomDelay
            // 
            this.check_UseRandomDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_UseRandomDelay.Depth = 0;
            this.check_UseRandomDelay.Enabled = false;
            this.check_UseRandomDelay.Location = new System.Drawing.Point(287, 14);
            this.check_UseRandomDelay.Margin = new System.Windows.Forms.Padding(0);
            this.check_UseRandomDelay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_UseRandomDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_UseRandomDelay.Name = "check_UseRandomDelay";
            this.check_UseRandomDelay.Ripple = true;
            this.check_UseRandomDelay.Size = new System.Drawing.Size(199, 40);
            this.check_UseRandomDelay.TabIndex = 2;
            this.check_UseRandomDelay.TabStop = false;
            this.check_UseRandomDelay.Text = "Use Random Delay";
            this.check_UseRandomDelay.UseVisualStyleBackColor = true;
            this.check_UseRandomDelay.CheckedChanged += new System.EventHandler(this.check_UseRandomDelay_CheckedChanged);
            // 
            // slider_MinDelay
            // 
            this.slider_MinDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_MinDelay.Depth = 0;
            this.slider_MinDelay.Enabled = false;
            this.slider_MinDelay.ForeColor = System.Drawing.Color.White;
            this.slider_MinDelay.Location = new System.Drawing.Point(135, 123);
            this.slider_MinDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.slider_MinDelay.Name = "slider_MinDelay";
            this.slider_MinDelay.RangeMax = 500;
            this.slider_MinDelay.ShowText = false;
            this.slider_MinDelay.Size = new System.Drawing.Size(348, 40);
            this.slider_MinDelay.TabIndex = 1;
            this.slider_MinDelay.TabStop = false;
            this.slider_MinDelay.Text = "Min Multiplier";
            this.toolTip.SetToolTip(this.slider_MinDelay, "The minimum added delay between sending clicks.");
            this.slider_MinDelay.UseAccentColor = true;
            this.slider_MinDelay.Value = 20;
            this.slider_MinDelay.ValueSuffix = "ms";
            this.slider_MinDelay.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.slider_MinDelay_onValueChanged);
            // 
            // slider_MaxDelay
            // 
            this.slider_MaxDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_MaxDelay.Depth = 0;
            this.slider_MaxDelay.Enabled = false;
            this.slider_MaxDelay.ForeColor = System.Drawing.Color.White;
            this.slider_MaxDelay.Location = new System.Drawing.Point(135, 77);
            this.slider_MaxDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.slider_MaxDelay.Name = "slider_MaxDelay";
            this.slider_MaxDelay.RangeMax = 500;
            this.slider_MaxDelay.ShowText = false;
            this.slider_MaxDelay.Size = new System.Drawing.Size(348, 40);
            this.slider_MaxDelay.TabIndex = 0;
            this.slider_MaxDelay.TabStop = false;
            this.slider_MaxDelay.Text = "Max Multiplier";
            this.toolTip.SetToolTip(this.slider_MaxDelay, "The maximum added delay between sending clicks.");
            this.slider_MaxDelay.UseAccentColor = true;
            this.slider_MaxDelay.Value = 20;
            this.slider_MaxDelay.ValueSuffix = "ms";
            this.slider_MaxDelay.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.slider_MaxDelay_onValueChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.check_UseMiddleMouseButton);
            this.materialCard2.Controls.Add(this.check_UseLeftMouseButton);
            this.materialCard2.Controls.Add(this.check_UseRightMouseButton);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(531, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14, 14, 14, 0);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(338, 178);
            this.materialCard2.TabIndex = 2;
            // 
            // check_UseMiddleMouseButton
            // 
            this.check_UseMiddleMouseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_UseMiddleMouseButton.Depth = 0;
            this.check_UseMiddleMouseButton.Location = new System.Drawing.Point(14, 124);
            this.check_UseMiddleMouseButton.Margin = new System.Windows.Forms.Padding(0);
            this.check_UseMiddleMouseButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_UseMiddleMouseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_UseMiddleMouseButton.Name = "check_UseMiddleMouseButton";
            this.check_UseMiddleMouseButton.Ripple = true;
            this.check_UseMiddleMouseButton.Size = new System.Drawing.Size(310, 40);
            this.check_UseMiddleMouseButton.TabIndex = 8;
            this.check_UseMiddleMouseButton.TabStop = false;
            this.check_UseMiddleMouseButton.Text = "Use Middle Mouse Button";
            this.check_UseMiddleMouseButton.UseVisualStyleBackColor = true;
            this.check_UseMiddleMouseButton.CheckedChanged += new System.EventHandler(this.check_UseMiddleMouseButton_CheckedChanged);
            // 
            // check_UseLeftMouseButton
            // 
            this.check_UseLeftMouseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_UseLeftMouseButton.Depth = 0;
            this.check_UseLeftMouseButton.Location = new System.Drawing.Point(14, 14);
            this.check_UseLeftMouseButton.Margin = new System.Windows.Forms.Padding(0);
            this.check_UseLeftMouseButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_UseLeftMouseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_UseLeftMouseButton.Name = "check_UseLeftMouseButton";
            this.check_UseLeftMouseButton.Ripple = true;
            this.check_UseLeftMouseButton.Size = new System.Drawing.Size(310, 40);
            this.check_UseLeftMouseButton.TabIndex = 6;
            this.check_UseLeftMouseButton.TabStop = false;
            this.check_UseLeftMouseButton.Text = "Use Left Mouse Button";
            this.check_UseLeftMouseButton.UseVisualStyleBackColor = true;
            this.check_UseLeftMouseButton.CheckedChanged += new System.EventHandler(this.check_UseLeftMouseButton_CheckedChanged);
            // 
            // check_UseRightMouseButton
            // 
            this.check_UseRightMouseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.check_UseRightMouseButton.Depth = 0;
            this.check_UseRightMouseButton.Location = new System.Drawing.Point(14, 69);
            this.check_UseRightMouseButton.Margin = new System.Windows.Forms.Padding(0);
            this.check_UseRightMouseButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_UseRightMouseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_UseRightMouseButton.Name = "check_UseRightMouseButton";
            this.check_UseRightMouseButton.Ripple = true;
            this.check_UseRightMouseButton.Size = new System.Drawing.Size(310, 40);
            this.check_UseRightMouseButton.TabIndex = 7;
            this.check_UseRightMouseButton.TabStop = false;
            this.check_UseRightMouseButton.Text = "Use Right Mouse Button";
            this.check_UseRightMouseButton.UseVisualStyleBackColor = true;
            this.check_UseRightMouseButton.CheckedChanged += new System.EventHandler(this.check_UseRightMouseButton_CheckedChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.switch_Enabled);
            this.materialCard1.Controls.Add(this.check_UseRandomMultiplier);
            this.materialCard1.Controls.Add(this.slider_MinMultiplier);
            this.materialCard1.Controls.Add(this.slider_MaxMultiplier);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14, 14, 0, 0);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(500, 178);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(11, 121);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(123, 40);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Min Multiplier";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(11, 75);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 40);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Max Multiplier";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switch_Enabled
            // 
            this.switch_Enabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_Enabled.Depth = 0;
            this.switch_Enabled.Location = new System.Drawing.Point(14, 14);
            this.switch_Enabled.Margin = new System.Windows.Forms.Padding(0);
            this.switch_Enabled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_Enabled.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_Enabled.Name = "switch_Enabled";
            this.switch_Enabled.Ripple = true;
            this.switch_Enabled.Size = new System.Drawing.Size(255, 40);
            this.switch_Enabled.TabIndex = 3;
            this.switch_Enabled.TabStop = false;
            this.switch_Enabled.Text = "Enable Znn Clicker";
            this.switch_Enabled.UseVisualStyleBackColor = true;
            this.switch_Enabled.CheckedChanged += new System.EventHandler(this.switch_Enabled_CheckedChanged);
            // 
            // check_UseRandomMultiplier
            // 
            this.check_UseRandomMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_UseRandomMultiplier.Depth = 0;
            this.check_UseRandomMultiplier.Location = new System.Drawing.Point(287, 14);
            this.check_UseRandomMultiplier.Margin = new System.Windows.Forms.Padding(0);
            this.check_UseRandomMultiplier.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_UseRandomMultiplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_UseRandomMultiplier.Name = "check_UseRandomMultiplier";
            this.check_UseRandomMultiplier.Ripple = true;
            this.check_UseRandomMultiplier.Size = new System.Drawing.Size(199, 40);
            this.check_UseRandomMultiplier.TabIndex = 2;
            this.check_UseRandomMultiplier.TabStop = false;
            this.check_UseRandomMultiplier.Text = "Use Random Multiplier";
            this.check_UseRandomMultiplier.UseVisualStyleBackColor = true;
            this.check_UseRandomMultiplier.CheckedChanged += new System.EventHandler(this.check_UseRandomMultiplier_CheckedChanged);
            // 
            // slider_MinMultiplier
            // 
            this.slider_MinMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_MinMultiplier.Depth = 0;
            this.slider_MinMultiplier.Enabled = false;
            this.slider_MinMultiplier.ForeColor = System.Drawing.Color.White;
            this.slider_MinMultiplier.Location = new System.Drawing.Point(135, 121);
            this.slider_MinMultiplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.slider_MinMultiplier.Name = "slider_MinMultiplier";
            this.slider_MinMultiplier.RangeMax = 150;
            this.slider_MinMultiplier.ShowText = false;
            this.slider_MinMultiplier.Size = new System.Drawing.Size(348, 40);
            this.slider_MinMultiplier.TabIndex = 1;
            this.slider_MinMultiplier.TabStop = false;
            this.slider_MinMultiplier.Text = "Min Multiplier";
            this.toolTip.SetToolTip(this.slider_MinMultiplier, "The minimum amount of clicks to add to your clicks.");
            this.slider_MinMultiplier.UseAccentColor = true;
            this.slider_MinMultiplier.Value = 20;
            this.slider_MinMultiplier.ValueSuffix = "x";
            this.slider_MinMultiplier.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.slider_MinMultiplier_onValueChanged);
            // 
            // slider_MaxMultiplier
            // 
            this.slider_MaxMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider_MaxMultiplier.Depth = 0;
            this.slider_MaxMultiplier.ForeColor = System.Drawing.Color.White;
            this.slider_MaxMultiplier.Location = new System.Drawing.Point(135, 75);
            this.slider_MaxMultiplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.slider_MaxMultiplier.Name = "slider_MaxMultiplier";
            this.slider_MaxMultiplier.RangeMax = 150;
            this.slider_MaxMultiplier.ShowText = false;
            this.slider_MaxMultiplier.Size = new System.Drawing.Size(348, 40);
            this.slider_MaxMultiplier.TabIndex = 0;
            this.slider_MaxMultiplier.TabStop = false;
            this.slider_MaxMultiplier.Text = "Max Multiplier";
            this.toolTip.SetToolTip(this.slider_MaxMultiplier, "The maximum amount of clicks to add to your clicks.");
            this.slider_MaxMultiplier.UseAccentColor = true;
            this.slider_MaxMultiplier.Value = 20;
            this.slider_MaxMultiplier.ValueSuffix = "x";
            this.slider_MaxMultiplier.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.slider_MaxMultiplier_onValueChanged);
            // 
            // tab_Controls
            // 
            this.tab_Controls.Controls.Add(this.materialCard7);
            this.tab_Controls.Controls.Add(this.materialCard_Hotkeys);
            this.tab_Controls.ImageKey = "Keyboard.png";
            this.tab_Controls.Location = new System.Drawing.Point(4, 23);
            this.tab_Controls.Name = "tab_Controls";
            this.tab_Controls.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Controls.Size = new System.Drawing.Size(886, 406);
            this.tab_Controls.TabIndex = 2;
            this.tab_Controls.Text = "Keybindings";
            this.tab_Controls.UseVisualStyleBackColor = true;
            this.tab_Controls.Click += new System.EventHandler(this.tab_Controls_Click);
            // 
            // materialCard7
            // 
            this.materialCard7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.btn_SettingsReset);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(17, 339);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14, 0, 14, 14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(852, 54);
            this.materialCard7.TabIndex = 3;
            // 
            // btn_SettingsReset
            // 
            this.btn_SettingsReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SettingsReset.AutoSize = false;
            this.btn_SettingsReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SettingsReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SettingsReset.Depth = 0;
            this.btn_SettingsReset.HighEmphasis = true;
            this.btn_SettingsReset.Icon = null;
            this.btn_SettingsReset.Location = new System.Drawing.Point(18, 9);
            this.btn_SettingsReset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SettingsReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SettingsReset.Name = "btn_SettingsReset";
            this.btn_SettingsReset.Size = new System.Drawing.Size(213, 36);
            this.btn_SettingsReset.TabIndex = 0;
            this.btn_SettingsReset.TabStop = false;
            this.btn_SettingsReset.Text = "Reset";
            this.btn_SettingsReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SettingsReset.UseAccentColor = false;
            this.btn_SettingsReset.UseVisualStyleBackColor = true;
            this.btn_SettingsReset.Click += new System.EventHandler(this.btn_SettingsReset_Click);
            // 
            // materialCard_Hotkeys
            // 
            this.materialCard_Hotkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard_Hotkeys.AutoScroll = true;
            this.materialCard_Hotkeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard_Hotkeys.Depth = 0;
            this.materialCard_Hotkeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard_Hotkeys.Location = new System.Drawing.Point(17, 17);
            this.materialCard_Hotkeys.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard_Hotkeys.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard_Hotkeys.Name = "materialCard_Hotkeys";
            this.materialCard_Hotkeys.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard_Hotkeys.Size = new System.Drawing.Size(852, 308);
            this.materialCard_Hotkeys.TabIndex = 2;
            this.materialCard_Hotkeys.Click += new System.EventHandler(this.materialCard_Hotkeys_Click);
            // 
            // tab_Settings
            // 
            this.tab_Settings.Controls.Add(this.materialCard6);
            this.tab_Settings.Controls.Add(this.materialCard5);
            this.tab_Settings.ImageKey = "Settings.png";
            this.tab_Settings.Location = new System.Drawing.Point(4, 23);
            this.tab_Settings.Name = "tab_Settings";
            this.tab_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Settings.Size = new System.Drawing.Size(886, 406);
            this.tab_Settings.TabIndex = 1;
            this.tab_Settings.Text = "Settings";
            this.tab_Settings.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            this.materialCard6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.switch_autoTurnOff);
            this.materialCard6.Controls.Add(this.switch_AdvancedThemeOptions);
            this.materialCard6.Controls.Add(this.switch_UseDarkMode);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(17, 14);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14, 14, 0, 14);
            this.materialCard6.Size = new System.Drawing.Size(296, 375);
            this.materialCard6.TabIndex = 2;
            // 
            // switch_autoTurnOff
            // 
            this.switch_autoTurnOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_autoTurnOff.Depth = 0;
            this.switch_autoTurnOff.Location = new System.Drawing.Point(14, 57);
            this.switch_autoTurnOff.Margin = new System.Windows.Forms.Padding(0);
            this.switch_autoTurnOff.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_autoTurnOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_autoTurnOff.Name = "switch_autoTurnOff";
            this.switch_autoTurnOff.Ripple = true;
            this.switch_autoTurnOff.Size = new System.Drawing.Size(282, 40);
            this.switch_autoTurnOff.TabIndex = 1;
            this.switch_autoTurnOff.Text = "Automatically turn off";
            this.toolTip.SetToolTip(this.switch_autoTurnOff, "Automatically turn Znn Clicker off when you interact with it.");
            this.switch_autoTurnOff.UseVisualStyleBackColor = true;
            this.switch_autoTurnOff.CheckedChanged += new System.EventHandler(this.switch_autoTurnOff_CheckedChanged);
            // 
            // switch_AdvancedThemeOptions
            // 
            this.switch_AdvancedThemeOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_AdvancedThemeOptions.Depth = 0;
            this.switch_AdvancedThemeOptions.Location = new System.Drawing.Point(14, 315);
            this.switch_AdvancedThemeOptions.Margin = new System.Windows.Forms.Padding(0);
            this.switch_AdvancedThemeOptions.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_AdvancedThemeOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_AdvancedThemeOptions.Name = "switch_AdvancedThemeOptions";
            this.switch_AdvancedThemeOptions.Ripple = true;
            this.switch_AdvancedThemeOptions.Size = new System.Drawing.Size(282, 40);
            this.switch_AdvancedThemeOptions.TabIndex = 10;
            this.switch_AdvancedThemeOptions.Text = "Advanced Theme Options";
            this.toolTip.SetToolTip(this.switch_AdvancedThemeOptions, "Enable/Disable Advanced Theme Options.");
            this.switch_AdvancedThemeOptions.UseVisualStyleBackColor = true;
            this.switch_AdvancedThemeOptions.CheckedChanged += new System.EventHandler(this.switch_AdvancedThemeOptions_CheckedChanged);
            // 
            // switch_UseDarkMode
            // 
            this.switch_UseDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_UseDarkMode.Depth = 0;
            this.switch_UseDarkMode.Location = new System.Drawing.Point(14, 17);
            this.switch_UseDarkMode.Margin = new System.Windows.Forms.Padding(0);
            this.switch_UseDarkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_UseDarkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_UseDarkMode.Name = "switch_UseDarkMode";
            this.switch_UseDarkMode.Ripple = true;
            this.switch_UseDarkMode.Size = new System.Drawing.Size(282, 40);
            this.switch_UseDarkMode.TabIndex = 0;
            this.switch_UseDarkMode.Text = "Dark Mode";
            this.toolTip.SetToolTip(this.switch_UseDarkMode, "Enable/Disable Dark Mode.");
            this.switch_UseDarkMode.UseVisualStyleBackColor = true;
            this.switch_UseDarkMode.CheckedChanged += new System.EventHandler(this.switch_UseDarkMode_CheckedChanged);
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btn_ResetTheme);
            this.materialCard5.Controls.Add(this.btn_DiscardChangesTheme);
            this.materialCard5.Controls.Add(this.btn_SaveTheme);
            this.materialCard5.Controls.Add(this.materialLabel9);
            this.materialCard5.Controls.Add(this.box_Accent);
            this.materialCard5.Controls.Add(this.materialLabel8);
            this.materialCard5.Controls.Add(this.box_Primary_3);
            this.materialCard5.Controls.Add(this.materialLabel7);
            this.materialCard5.Controls.Add(this.box_Primary_2);
            this.materialCard5.Controls.Add(this.materialLabel1);
            this.materialCard5.Controls.Add(this.box_Primary_1);
            this.materialCard5.Controls.Add(this.materialLabel6);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(327, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(542, 375);
            this.materialCard5.TabIndex = 1;
            // 
            // btn_ResetTheme
            // 
            this.btn_ResetTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ResetTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ResetTheme.BackColor = System.Drawing.Color.White;
            this.btn_ResetTheme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ResetTheme.Depth = 0;
            this.btn_ResetTheme.Enabled = false;
            this.btn_ResetTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ResetTheme.HighEmphasis = true;
            this.btn_ResetTheme.Icon = null;
            this.btn_ResetTheme.Location = new System.Drawing.Point(90, 319);
            this.btn_ResetTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ResetTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ResetTheme.Name = "btn_ResetTheme";
            this.btn_ResetTheme.Size = new System.Drawing.Size(65, 36);
            this.btn_ResetTheme.TabIndex = 25;
            this.btn_ResetTheme.Text = "Reset";
            this.btn_ResetTheme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ResetTheme.UseAccentColor = false;
            this.btn_ResetTheme.UseVisualStyleBackColor = false;
            this.btn_ResetTheme.Click += new System.EventHandler(this.btn_ResetTheme_Click);
            // 
            // btn_DiscardChangesTheme
            // 
            this.btn_DiscardChangesTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DiscardChangesTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_DiscardChangesTheme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_DiscardChangesTheme.Depth = 0;
            this.btn_DiscardChangesTheme.Enabled = false;
            this.btn_DiscardChangesTheme.HighEmphasis = true;
            this.btn_DiscardChangesTheme.Icon = null;
            this.btn_DiscardChangesTheme.Location = new System.Drawing.Point(162, 319);
            this.btn_DiscardChangesTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_DiscardChangesTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_DiscardChangesTheme.Name = "btn_DiscardChangesTheme";
            this.btn_DiscardChangesTheme.Size = new System.Drawing.Size(154, 36);
            this.btn_DiscardChangesTheme.TabIndex = 24;
            this.btn_DiscardChangesTheme.Text = "Discard Changes";
            this.btn_DiscardChangesTheme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_DiscardChangesTheme.UseAccentColor = false;
            this.btn_DiscardChangesTheme.UseVisualStyleBackColor = true;
            this.btn_DiscardChangesTheme.Click += new System.EventHandler(this.btn_DiscardChangesTheme_Click);
            // 
            // btn_SaveTheme
            // 
            this.btn_SaveTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SaveTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SaveTheme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_SaveTheme.Depth = 0;
            this.btn_SaveTheme.Enabled = false;
            this.btn_SaveTheme.HighEmphasis = true;
            this.btn_SaveTheme.Icon = null;
            this.btn_SaveTheme.Location = new System.Drawing.Point(18, 319);
            this.btn_SaveTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SaveTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SaveTheme.Name = "btn_SaveTheme";
            this.btn_SaveTheme.Size = new System.Drawing.Size(64, 36);
            this.btn_SaveTheme.TabIndex = 23;
            this.btn_SaveTheme.Text = "Save";
            this.btn_SaveTheme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_SaveTheme.UseAccentColor = false;
            this.btn_SaveTheme.UseVisualStyleBackColor = true;
            this.btn_SaveTheme.Click += new System.EventHandler(this.btn_SaveTheme_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(17, 250);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(150, 49);
            this.materialLabel9.TabIndex = 22;
            this.materialLabel9.Text = "Accent Color";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_Accent
            // 
            this.box_Accent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Accent.AutoResize = false;
            this.box_Accent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_Accent.Depth = 0;
            this.box_Accent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.box_Accent.DropDownHeight = 174;
            this.box_Accent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Accent.DropDownWidth = 121;
            this.box_Accent.Enabled = false;
            this.box_Accent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.box_Accent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_Accent.FormattingEnabled = true;
            this.box_Accent.IntegralHeight = false;
            this.box_Accent.ItemHeight = 43;
            this.box_Accent.Location = new System.Drawing.Point(173, 250);
            this.box_Accent.MaxDropDownItems = 4;
            this.box_Accent.MouseState = MaterialSkin.MouseState.OUT;
            this.box_Accent.Name = "box_Accent";
            this.box_Accent.Size = new System.Drawing.Size(352, 49);
            this.box_Accent.StartIndex = 0;
            this.box_Accent.TabIndex = 21;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(17, 190);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(150, 49);
            this.materialLabel8.TabIndex = 20;
            this.materialLabel8.Text = "Light Primary Color";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_Primary_3
            // 
            this.box_Primary_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Primary_3.AutoResize = false;
            this.box_Primary_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_Primary_3.Depth = 0;
            this.box_Primary_3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.box_Primary_3.DropDownHeight = 174;
            this.box_Primary_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Primary_3.DropDownWidth = 121;
            this.box_Primary_3.Enabled = false;
            this.box_Primary_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.box_Primary_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_Primary_3.FormattingEnabled = true;
            this.box_Primary_3.IntegralHeight = false;
            this.box_Primary_3.ItemHeight = 43;
            this.box_Primary_3.Location = new System.Drawing.Point(173, 190);
            this.box_Primary_3.MaxDropDownItems = 4;
            this.box_Primary_3.MouseState = MaterialSkin.MouseState.OUT;
            this.box_Primary_3.Name = "box_Primary_3";
            this.box_Primary_3.Size = new System.Drawing.Size(352, 49);
            this.box_Primary_3.StartIndex = 0;
            this.box_Primary_3.TabIndex = 19;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 130);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(150, 49);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "Dark Primary Color";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_Primary_2
            // 
            this.box_Primary_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Primary_2.AutoResize = false;
            this.box_Primary_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_Primary_2.Depth = 0;
            this.box_Primary_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.box_Primary_2.DropDownHeight = 174;
            this.box_Primary_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Primary_2.DropDownWidth = 121;
            this.box_Primary_2.Enabled = false;
            this.box_Primary_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.box_Primary_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_Primary_2.FormattingEnabled = true;
            this.box_Primary_2.IntegralHeight = false;
            this.box_Primary_2.ItemHeight = 43;
            this.box_Primary_2.Location = new System.Drawing.Point(173, 130);
            this.box_Primary_2.MaxDropDownItems = 4;
            this.box_Primary_2.MouseState = MaterialSkin.MouseState.OUT;
            this.box_Primary_2.Name = "box_Primary_2";
            this.box_Primary_2.Size = new System.Drawing.Size(352, 49);
            this.box_Primary_2.StartIndex = 0;
            this.box_Primary_2.TabIndex = 17;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 70);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 49);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Primary Color";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // box_Primary_1
            // 
            this.box_Primary_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Primary_1.AutoResize = false;
            this.box_Primary_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_Primary_1.Depth = 0;
            this.box_Primary_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.box_Primary_1.DropDownHeight = 174;
            this.box_Primary_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Primary_1.DropDownWidth = 121;
            this.box_Primary_1.Enabled = false;
            this.box_Primary_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.box_Primary_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.box_Primary_1.FormattingEnabled = true;
            this.box_Primary_1.IntegralHeight = false;
            this.box_Primary_1.ItemHeight = 43;
            this.box_Primary_1.Location = new System.Drawing.Point(173, 70);
            this.box_Primary_1.MaxDropDownItems = 4;
            this.box_Primary_1.MouseState = MaterialSkin.MouseState.OUT;
            this.box_Primary_1.Name = "box_Primary_1";
            this.box_Primary_1.Size = new System.Drawing.Size(352, 49);
            this.box_Primary_1.StartIndex = 0;
            this.box_Primary_1.TabIndex = 12;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(17, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(508, 32);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Advanced Theme Options";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList_Main
            // 
            this.imageList_Main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Main.ImageStream")));
            this.imageList_Main.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Main.Images.SetKeyName(0, "Home.png");
            this.imageList_Main.Images.SetKeyName(1, "Settings.png");
            this.imageList_Main.Images.SetKeyName(2, "Keyboard.png");
            // 
            // timer_MouseClick
            // 
            this.timer_MouseClick.Interval = 1;
            this.timer_MouseClick.Tick += new System.EventHandler(this.timer_MouseClick_Tick);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.InitialDelay = 800;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.tabControl_Main);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerTabControl = this.tabControl_Main;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(875, 485);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Znn Clicker";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResizeBegin += new System.EventHandler(this.Home_ResizeBegin);
            this.Click += new System.EventHandler(this.Home_Click);
            this.tabControl_Main.ResumeLayout(false);
            this.tab_Home.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.tab_Controls.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.tab_Settings.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl_Main;
        private System.Windows.Forms.TabPage tab_Home;
        private System.Windows.Forms.TabPage tab_Settings;
        private System.Windows.Forms.ImageList imageList_Main;
        private MaterialSkin.Controls.MaterialSlider slider_MaxMultiplier;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch switch_Enabled;
        private MaterialSkin.Controls.MaterialCheckbox check_UseRandomMultiplier;
        private MaterialSkin.Controls.MaterialSlider slider_MinMultiplier;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.TabPage tab_Controls;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSwitch switch_UseDelay;
        private MaterialSkin.Controls.MaterialCheckbox check_UseRandomDelay;
        private MaterialSkin.Controls.MaterialSlider slider_MinDelay;
        private MaterialSkin.Controls.MaterialSlider slider_MaxDelay;
        private MaterialSkin.Controls.MaterialCheckbox check_UseRightMouseButton;
        private MaterialSkin.Controls.MaterialCheckbox check_UseLeftMouseButton;
        private MaterialSkin.Controls.MaterialCheckbox check_UseMiddleMouseButton;
        private System.Windows.Forms.Timer timer_MouseClick;
        private MaterialSkin.Controls.MaterialSwitch switch_UseDarkMode;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialSwitch switch_AdvancedThemeOptions;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialComboBox box_Primary_1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox box_Accent;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox box_Primary_3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox box_Primary_2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btn_ResetTheme;
        private MaterialSkin.Controls.MaterialButton btn_DiscardChangesTheme;
        private MaterialSkin.Controls.MaterialButton btn_SaveTheme;
        private System.Windows.Forms.ToolTip toolTip;
        private MaterialSkin.Controls.MaterialCard materialCard_Display;
        private MaterialSkin.Controls.MaterialSwitch switch_autoTurnOff;
        private MaterialSkin.Controls.MaterialCard materialCard_Hotkeys;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton btn_SettingsReset;
    }
}

