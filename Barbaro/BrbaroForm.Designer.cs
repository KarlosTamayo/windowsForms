namespace Barbaro
{
    partial class BrbaroForm
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
            this.BarbaroTextBox = new System.Windows.Forms.TextBox();
            this.IntroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarbaroTextBox
            // 
            this.BarbaroTextBox.Location = new System.Drawing.Point(103, 36);
            this.BarbaroTextBox.Name = "BarbaroTextBox";
            this.BarbaroTextBox.Size = new System.Drawing.Size(100, 20);
            this.BarbaroTextBox.TabIndex = 0;
            // 
            // IntroButton
            // 
            this.IntroButton.Location = new System.Drawing.Point(117, 98);
            this.IntroButton.Name = "IntroButton";
            this.IntroButton.Size = new System.Drawing.Size(75, 23);
            this.IntroButton.TabIndex = 1;
            this.IntroButton.Text = "Intro";
            this.IntroButton.UseVisualStyleBackColor = true;
            this.IntroButton.Click += new System.EventHandler(this.IntroButton_Click);
            // 
            // BrbaroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 176);
            this.Controls.Add(this.IntroButton);
            this.Controls.Add(this.BarbaroTextBox);
            this.Name = "BrbaroForm";
            this.Text = "Barbaro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BarbaroTextBox;
        private System.Windows.Forms.Button IntroButton;
    }
}

