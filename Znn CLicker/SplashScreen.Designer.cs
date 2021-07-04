
namespace Znn_CLicker
{
    partial class SplashScreen
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
            this.txt_Name = new MaterialSkin.Controls.MaterialLabel();
            this.progress_Load = new CircularProgressBar.CircularProgressBar();
            this.timer_LoadTime = new System.Windows.Forms.Timer(this.components);
            this.label_Loading = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Depth = 0;
            this.txt_Name.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Name.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(32)))));
            this.txt_Name.Location = new System.Drawing.Point(6, 10);
            this.txt_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(338, 58);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Text = "Clicker";
            this.txt_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress_Load
            // 
            this.progress_Load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progress_Load.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;
            this.progress_Load.AnimationSpeed = 0;
            this.progress_Load.BackColor = System.Drawing.Color.Transparent;
            this.progress_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_Load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.progress_Load.InnerColor = System.Drawing.Color.Transparent;
            this.progress_Load.InnerMargin = 0;
            this.progress_Load.InnerWidth = 0;
            this.progress_Load.Location = new System.Drawing.Point(35, 85);
            this.progress_Load.MarqueeAnimationSpeed = 0;
            this.progress_Load.Name = "progress_Load";
            this.progress_Load.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.progress_Load.OuterMargin = -25;
            this.progress_Load.OuterWidth = 26;
            this.progress_Load.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.progress_Load.ProgressWidth = 15;
            this.progress_Load.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progress_Load.Size = new System.Drawing.Size(270, 270);
            this.progress_Load.StartAngle = 270;
            this.progress_Load.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_Load.SubscriptColor = System.Drawing.Color.Transparent;
            this.progress_Load.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_Load.SubscriptText = "";
            this.progress_Load.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progress_Load.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_Load.SuperscriptText = "";
            this.progress_Load.TabIndex = 2;
            this.progress_Load.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progress_Load.Value = 68;
            // 
            // timer_LoadTime
            // 
            this.timer_LoadTime.Enabled = true;
            this.timer_LoadTime.Interval = 25;
            this.timer_LoadTime.Tick += new System.EventHandler(this.timer_LoadTime_Tick);
            // 
            // label_Loading
            // 
            this.label_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Loading.Depth = 0;
            this.label_Loading.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_Loading.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.label_Loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(32)))));
            this.label_Loading.Location = new System.Drawing.Point(6, 365);
            this.label_Loading.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(338, 58);
            this.label_Loading.TabIndex = 3;
            this.label_Loading.Text = "Loading...";
            this.label_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(32)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 440);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(338, 58);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Made By DevPieter";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(350, 490);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label_Loading);
            this.Controls.Add(this.progress_Load);
            this.Controls.Add(this.txt_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starting Znn Clicker...";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel txt_Name;
        private CircularProgressBar.CircularProgressBar progress_Load;
        private System.Windows.Forms.Timer timer_LoadTime;
        private MaterialSkin.Controls.MaterialLabel label_Loading;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}