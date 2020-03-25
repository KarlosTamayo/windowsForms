namespace Modulo
{
    partial class Modulo
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
            this.NumeroUnoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IntroButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ParTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ImparTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumeroUnoTextBox
            // 
            this.NumeroUnoTextBox.Location = new System.Drawing.Point(26, 70);
            this.NumeroUnoTextBox.Name = "NumeroUnoTextBox";
            this.NumeroUnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroUnoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero uno";
            // 
            // IntroButton
            // 
            this.IntroButton.Location = new System.Drawing.Point(88, 132);
            this.IntroButton.Name = "IntroButton";
            this.IntroButton.Size = new System.Drawing.Size(133, 43);
            this.IntroButton.TabIndex = 4;
            this.IntroButton.Text = "Intro";
            this.IntroButton.UseVisualStyleBackColor = true;
            this.IntroButton.Click += new System.EventHandler(this.IntroButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero Par";
            // 
            // ParTextBox
            // 
            this.ParTextBox.Location = new System.Drawing.Point(184, 47);
            this.ParTextBox.Name = "ParTextBox";
            this.ParTextBox.Size = new System.Drawing.Size(100, 20);
            this.ParTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // ImparTextBox
            // 
            this.ImparTextBox.Location = new System.Drawing.Point(184, 93);
            this.ImparTextBox.Name = "ImparTextBox";
            this.ImparTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImparTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero Impar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "=";
            // 
            // Modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 198);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImparTextBox);
            this.Controls.Add(this.ParTextBox);
            this.Controls.Add(this.IntroButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroUnoTextBox);
            this.Name = "Modulo";
            this.Text = "Modulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroUnoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IntroButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ParTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ImparTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

