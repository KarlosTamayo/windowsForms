namespace EnsayoMDI
{
    partial class EnsayoTres
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
            this.ElegirButton = new System.Windows.Forms.Button();
            this.NumeroParListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ElegirButton
            // 
            this.ElegirButton.Location = new System.Drawing.Point(273, 293);
            this.ElegirButton.Name = "ElegirButton";
            this.ElegirButton.Size = new System.Drawing.Size(75, 23);
            this.ElegirButton.TabIndex = 0;
            this.ElegirButton.Text = "Elegir";
            this.ElegirButton.UseVisualStyleBackColor = true;
            this.ElegirButton.Click += new System.EventHandler(this.ElegirButton_Click);
            // 
            // NumeroParListBox
            // 
            this.NumeroParListBox.FormattingEnabled = true;
            this.NumeroParListBox.Location = new System.Drawing.Point(241, 12);
            this.NumeroParListBox.Name = "NumeroParListBox";
            this.NumeroParListBox.Size = new System.Drawing.Size(120, 95);
            this.NumeroParListBox.TabIndex = 1;
            // 
            // EnsayoTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 360);
            this.Controls.Add(this.NumeroParListBox);
            this.Controls.Add(this.ElegirButton);
            this.Name = "EnsayoTres";
            this.Text = "EnsayoTres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ElegirButton;
        private System.Windows.Forms.ListBox NumeroParListBox;
    }
}