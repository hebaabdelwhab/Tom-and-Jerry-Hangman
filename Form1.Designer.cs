namespace HangManGame
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_Splash = new System.Windows.Forms.Panel();
            this.TimerSplash = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pnl_Splash);
            this.panel1.Location = new System.Drawing.Point(246, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 20);
            this.panel1.TabIndex = 0;
            // 
            // Pnl_Splash
            // 
            this.Pnl_Splash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(210)))), ((int)(((byte)(17)))));
            this.Pnl_Splash.Location = new System.Drawing.Point(504, 0);
            this.Pnl_Splash.Name = "Pnl_Splash";
            this.Pnl_Splash.Size = new System.Drawing.Size(173, 20);
            this.Pnl_Splash.TabIndex = 1;
            // 
            // TimerSplash
            // 
            this.TimerSplash.Interval = 10;
            this.TimerSplash.Tick += new System.EventHandler(this.TimerSplash_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::HangManGame.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 701);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_Splash;
        private System.Windows.Forms.Timer TimerSplash;
    }
}

