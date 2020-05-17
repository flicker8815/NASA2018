using System;

namespace Menu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayButton = new System.Windows.Forms.Button();
            this.TutorialButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.zhButton = new System.Windows.Forms.Button();
            this.enButton = new System.Windows.Forms.Button();
            this.esButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(39, 210);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(128, 53);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // TutorialButton
            // 
            this.TutorialButton.BackColor = System.Drawing.Color.Transparent;
            this.TutorialButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.TutorialButton.FlatAppearance.BorderSize = 0;
            this.TutorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TutorialButton.Font = new System.Drawing.Font("", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorialButton.ForeColor = System.Drawing.Color.White;
            this.TutorialButton.Location = new System.Drawing.Point(39, 269);
            this.TutorialButton.Name = "TutorialButton";
            this.TutorialButton.Size = new System.Drawing.Size(190, 44);
            this.TutorialButton.TabIndex = 1;
            this.TutorialButton.Text = "How to play";
            this.TutorialButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TutorialButton.UseVisualStyleBackColor = false;
            this.TutorialButton.Click += new System.EventHandler(this.TutorialButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(39, 319);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(115, 44);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(39, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 44);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unpuzzle the Universe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(778, 432);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // zhButton
            // 
            this.zhButton.BackColor = System.Drawing.Color.Transparent;
            this.zhButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.zhButton.FlatAppearance.BorderSize = 0;
            this.zhButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zhButton.Font = new System.Drawing.Font("", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zhButton.ForeColor = System.Drawing.Color.White;
            this.zhButton.Location = new System.Drawing.Point(322, 204);
            this.zhButton.Name = "zhButton";
            this.zhButton.Size = new System.Drawing.Size(172, 53);
            this.zhButton.TabIndex = 10;
            this.zhButton.Text = "中文";
            this.zhButton.UseVisualStyleBackColor = false;
            this.zhButton.Click += new System.EventHandler(this.zhButton_Click);
            // 
            // enButton
            // 
            this.enButton.BackColor = System.Drawing.Color.Transparent;
            this.enButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.enButton.FlatAppearance.BorderSize = 0;
            this.enButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enButton.Font = new System.Drawing.Font("", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enButton.ForeColor = System.Drawing.Color.White;
            this.enButton.Location = new System.Drawing.Point(322, 145);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(172, 53);
            this.enButton.TabIndex = 11;
            this.enButton.Text = "English";
            this.enButton.UseVisualStyleBackColor = false;
            this.enButton.Click += new System.EventHandler(this.enButton_Click);
            // 
            // esButton
            // 
            this.esButton.BackColor = System.Drawing.Color.Transparent;
            this.esButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.esButton.FlatAppearance.BorderSize = 0;
            this.esButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esButton.Font = new System.Drawing.Font("", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esButton.ForeColor = System.Drawing.Color.White;
            this.esButton.Location = new System.Drawing.Point(322, 263);
            this.esButton.Name = "esButton";
            this.esButton.Size = new System.Drawing.Size(172, 53);
            this.esButton.TabIndex = 12;
            this.esButton.Text = "Español ";
            this.esButton.UseVisualStyleBackColor = false;
            this.esButton.Click += new System.EventHandler(this.esButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Menu.Properties.Resources.wallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.esButton);
            this.Controls.Add(this.enButton);
            this.Controls.Add(this.zhButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.TutorialButton);
            this.Controls.Add(this.PlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button TutorialButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button zhButton;
        private System.Windows.Forms.Button enButton;
        private System.Windows.Forms.Button esButton;
    }
}

