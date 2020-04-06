namespace EnsayoMDI
{
    partial class EnsayoCinco
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
            this.EntrarButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EntrarButton
            // 
            this.EntrarButton.Location = new System.Drawing.Point(266, 257);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(75, 23);
            this.EntrarButton.TabIndex = 1;
            this.EntrarButton.Text = "Entar";
            this.EntrarButton.UseVisualStyleBackColor = true;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::EnsayoMDI.Properties.Resources.spider_2_100;
            this.PictureBox.Location = new System.Drawing.Point(266, 49);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(103, 100);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // EnsayoCinco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 337);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.EntrarButton);
            this.Name = "EnsayoCinco";
            this.Text = "EnsayoCinco";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EntrarButton;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}