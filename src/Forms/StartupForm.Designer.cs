namespace Quad64
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.quad64Label = new System.Windows.Forms.Label();
            this.recentROMsLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.quad64Logo = new System.Windows.Forms.PictureBox();
            this.noROMsOpenedLabel = new System.Windows.Forms.Label();
            this.openROMButton = new System.Windows.Forms.Button();
            this.closeLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.quad64Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // quad64Label
            // 
            this.quad64Label.AutoSize = true;
            this.quad64Label.BackColor = System.Drawing.Color.Transparent;
            this.quad64Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.quad64Label.ForeColor = System.Drawing.Color.Red;
            this.quad64Label.Location = new System.Drawing.Point(63, 17);
            this.quad64Label.Name = "quad64Label";
            this.quad64Label.Size = new System.Drawing.Size(116, 31);
            this.quad64Label.TabIndex = 0;
            this.quad64Label.Text = "Quad64";
            // 
            // recentROMsLabel
            // 
            this.recentROMsLabel.AutoSize = true;
            this.recentROMsLabel.BackColor = System.Drawing.Color.Transparent;
            this.recentROMsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentROMsLabel.ForeColor = System.Drawing.Color.Red;
            this.recentROMsLabel.Location = new System.Drawing.Point(12, 89);
            this.recentROMsLabel.Name = "recentROMsLabel";
            this.recentROMsLabel.Size = new System.Drawing.Size(198, 20);
            this.recentROMsLabel.TabIndex = 1;
            this.recentROMsLabel.Text = "Recently opened ROMs";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(666, 378);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(29, 15);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "v1.0";
            // 
            // quad64Logo
            // 
            this.quad64Logo.BackColor = System.Drawing.Color.Transparent;
            this.quad64Logo.Image = ((System.Drawing.Image)(resources.GetObject("quad64Logo.Image")));
            this.quad64Logo.Location = new System.Drawing.Point(12, 9);
            this.quad64Logo.Name = "quad64Logo";
            this.quad64Logo.Size = new System.Drawing.Size(48, 48);
            this.quad64Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quad64Logo.TabIndex = 4;
            this.quad64Logo.TabStop = false;
            // 
            // noROMsOpenedLabel
            // 
            this.noROMsOpenedLabel.AutoSize = true;
            this.noROMsOpenedLabel.BackColor = System.Drawing.Color.Transparent;
            this.noROMsOpenedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noROMsOpenedLabel.Location = new System.Drawing.Point(12, 118);
            this.noROMsOpenedLabel.Name = "noROMsOpenedLabel";
            this.noROMsOpenedLabel.Size = new System.Drawing.Size(303, 34);
            this.noROMsOpenedLabel.TabIndex = 5;
            this.noROMsOpenedLabel.Text = "You have not opened any ROMs yet. \r\nClick the Open ROM button below to open one!";
            // 
            // openROMButton
            // 
            this.openROMButton.BackColor = System.Drawing.Color.Red;
            this.openROMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openROMButton.ForeColor = System.Drawing.Color.Yellow;
            this.openROMButton.Location = new System.Drawing.Point(12, 365);
            this.openROMButton.Name = "openROMButton";
            this.openROMButton.Size = new System.Drawing.Size(82, 23);
            this.openROMButton.TabIndex = 6;
            this.openROMButton.Text = "Open ROM";
            this.openROMButton.UseVisualStyleBackColor = false;
            this.openROMButton.Click += new System.EventHandler(this.OpenROMButton_Click);
            // 
            // closeLink
            // 
            this.closeLink.AutoSize = true;
            this.closeLink.BackColor = System.Drawing.Color.Transparent;
            this.closeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLink.LinkColor = System.Drawing.Color.Red;
            this.closeLink.Location = new System.Drawing.Point(674, 9);
            this.closeLink.Name = "closeLink";
            this.closeLink.Size = new System.Drawing.Size(18, 17);
            this.closeLink.TabIndex = 7;
            this.closeLink.TabStop = true;
            this.closeLink.Text = "X";
            this.closeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseLink_LinkClicked);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Quad64.Properties.Resources.StartupBG_White;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.closeLink);
            this.Controls.Add(this.openROMButton);
            this.Controls.Add(this.noROMsOpenedLabel);
            this.Controls.Add(this.quad64Logo);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.recentROMsLabel);
            this.Controls.Add(this.quad64Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quad64";
            ((System.ComponentModel.ISupportInitialize)(this.quad64Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quad64Label;
        private System.Windows.Forms.Label recentROMsLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.PictureBox quad64Logo;
        private System.Windows.Forms.Label noROMsOpenedLabel;
        private System.Windows.Forms.Button openROMButton;
        private System.Windows.Forms.LinkLabel closeLink;
    }
}

