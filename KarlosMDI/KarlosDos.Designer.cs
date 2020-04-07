namespace KarlosMDI
{
    partial class KarlosDos
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ElegirButton
            // 
            this.ElegirButton.Location = new System.Drawing.Point(169, 257);
            this.ElegirButton.Name = "ElegirButton";
            this.ElegirButton.Size = new System.Drawing.Size(75, 23);
            this.ElegirButton.TabIndex = 0;
            this.ElegirButton.Text = "Elejir";
            this.ElegirButton.UseVisualStyleBackColor = true;
            this.ElegirButton.Click += new System.EventHandler(this.ElejirButon);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::KarlosMDI.Properties.Resources.jason_voorhees_128;
            this.PictureBox.Location = new System.Drawing.Point(133, 35);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(158, 145);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.ElejirButon);
            this.PictureBox.MouseLeave += new System.EventHandler(this.Leave);
            this.PictureBox.MouseHover += new System.EventHandler(this.Hover);
            // 
            // KarlosDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 313);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ElegirButton);
            this.Name = "KarlosDos";
            this.Text = "KarlosDos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ElegirButton;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}