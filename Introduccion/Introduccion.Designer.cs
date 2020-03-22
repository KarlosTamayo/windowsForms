namespace Introduccion
{
    partial class Introduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduccion));
            this.TitruloLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.IntroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitruloLabel
            // 
            this.TitruloLabel.AutoSize = true;
            this.TitruloLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitruloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TitruloLabel.Location = new System.Drawing.Point(47, 32);
            this.TitruloLabel.Name = "TitruloLabel";
            this.TitruloLabel.Size = new System.Drawing.Size(215, 50);
            this.TitruloLabel.TabIndex = 0;
            this.TitruloLabel.Text = "Login 1.0";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(124, 120);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(116, 20);
            this.IdTextBox.TabIndex = 0;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.Blue;
            this.IdLabel.Location = new System.Drawing.Point(6, 119);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(34, 21);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(124, 185);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(116, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Blue;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 185);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(90, 21);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(166, 232);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IntroButton
            // 
            this.IntroButton.Location = new System.Drawing.Point(70, 232);
            this.IntroButton.Name = "IntroButton";
            this.IntroButton.Size = new System.Drawing.Size(75, 23);
            this.IntroButton.TabIndex = 4;
            this.IntroButton.Text = "Intro";
            this.IntroButton.UseVisualStyleBackColor = true;
            this.IntroButton.Click += new System.EventHandler(this.IntroButton_Click);
            // 
            // Introduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 287);
            this.Controls.Add(this.IntroButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.TitruloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Introduccion";
            this.Text = "My form";
            this.Load += new System.EventHandler(this.Introduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitruloLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button IntroButton;
    }
}

