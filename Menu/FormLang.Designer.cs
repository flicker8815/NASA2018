namespace Menu
{
    partial class FormLang
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
            this.EsButton = new System.Windows.Forms.Button();
            this.EnButton = new System.Windows.Forms.Button();
            this.ZhButton = new System.Windows.Forms.Button();
            this.HTPLable = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EsButton
            // 
            this.EsButton.BackColor = System.Drawing.Color.Transparent;
            this.EsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.EsButton.FlatAppearance.BorderSize = 0;
            this.EsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EsButton.Font = new System.Drawing.Font("", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsButton.ForeColor = System.Drawing.Color.White;
            this.EsButton.Location = new System.Drawing.Point(312, 292);
            this.EsButton.Name = "EsButton";
            this.EsButton.Size = new System.Drawing.Size(173, 53);
            this.EsButton.TabIndex = 15;
            this.EsButton.Text = "Español";
            this.EsButton.UseVisualStyleBackColor = false;
            // 
            // EnButton
            // 
            this.EnButton.BackColor = System.Drawing.Color.Transparent;
            this.EnButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.EnButton.FlatAppearance.BorderSize = 0;
            this.EnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnButton.Font = new System.Drawing.Font("", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnButton.ForeColor = System.Drawing.Color.White;
            this.EnButton.Location = new System.Drawing.Point(312, 233);
            this.EnButton.Name = "EnButton";
            this.EnButton.Size = new System.Drawing.Size(173, 53);
            this.EnButton.TabIndex = 14;
            this.EnButton.Text = "English";
            this.EnButton.UseVisualStyleBackColor = false;
            // 
            // ZhButton
            // 
            this.ZhButton.BackColor = System.Drawing.Color.Transparent;
            this.ZhButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.ZhButton.FlatAppearance.BorderSize = 0;
            this.ZhButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZhButton.Font = new System.Drawing.Font("", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZhButton.ForeColor = System.Drawing.Color.White;
            this.ZhButton.Location = new System.Drawing.Point(312, 174);
            this.ZhButton.Name = "ZhButton";
            this.ZhButton.Size = new System.Drawing.Size(173, 53);
            this.ZhButton.TabIndex = 13;
            this.ZhButton.Text = "中文";
            this.ZhButton.UseVisualStyleBackColor = false;
            this.ZhButton.Click += new System.EventHandler(this.ZhButton_Click);
            // 
            // HTPLable
            // 
            this.HTPLable.AutoSize = true;
            this.HTPLable.BackColor = System.Drawing.Color.Transparent;
            this.HTPLable.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTPLable.ForeColor = System.Drawing.Color.White;
            this.HTPLable.Location = new System.Drawing.Point(290, 43);
            this.HTPLable.Name = "HTPLable";
            this.HTPLable.Size = new System.Drawing.Size(215, 60);
            this.HTPLable.TabIndex = 16;
            this.HTPLable.Text = "Language";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(672, 28);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 44);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FormLang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.potw1817a;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.HTPLable);
            this.Controls.Add(this.EsButton);
            this.Controls.Add(this.EnButton);
            this.Controls.Add(this.ZhButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLang";
            this.Text = "FormLang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EsButton;
        private System.Windows.Forms.Button EnButton;
        private System.Windows.Forms.Button ZhButton;
        private System.Windows.Forms.Label HTPLable;
        private System.Windows.Forms.Button BackButton;
    }
}