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
            this.IntroductionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntroductionButton
            // 
            this.IntroductionButton.Location = new System.Drawing.Point(139, 227);
            this.IntroductionButton.Name = "IntroductionButton";
            this.IntroductionButton.Size = new System.Drawing.Size(75, 23);
            this.IntroductionButton.TabIndex = 0;
            this.IntroductionButton.Text = "Exit";
            this.IntroductionButton.UseVisualStyleBackColor = true;
            this.IntroductionButton.Click += new System.EventHandler(this.IntroductionButton_Click);
            // 
            // Introduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 330);
            this.Controls.Add(this.IntroductionButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Introduccion";
            this.Text = "My form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IntroductionButton;
    }
}

