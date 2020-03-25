namespace Ventanas
{
    partial class VentanaDos
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
            this.VentanaUnoButton = new System.Windows.Forms.Button();
            this.VentanaTresbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VentanaUnoButton
            // 
            this.VentanaUnoButton.Location = new System.Drawing.Point(62, 135);
            this.VentanaUnoButton.Name = "VentanaUnoButton";
            this.VentanaUnoButton.Size = new System.Drawing.Size(100, 23);
            this.VentanaUnoButton.TabIndex = 0;
            this.VentanaUnoButton.Text = "Ventana Uno";
            this.VentanaUnoButton.UseVisualStyleBackColor = true;
            this.VentanaUnoButton.Click += new System.EventHandler(this.VentanaUnoButton_Click);
            // 
            // VentanaTresbutton
            // 
            this.VentanaTresbutton.Location = new System.Drawing.Point(266, 135);
            this.VentanaTresbutton.Name = "VentanaTresbutton";
            this.VentanaTresbutton.Size = new System.Drawing.Size(75, 23);
            this.VentanaTresbutton.TabIndex = 1;
            this.VentanaTresbutton.Text = "venta Tres";
            this.VentanaTresbutton.UseVisualStyleBackColor = true;
            this.VentanaTresbutton.Click += new System.EventHandler(this.VentanaTresbutton_Click);
            // 
            // VentanaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 179);
            this.Controls.Add(this.VentanaTresbutton);
            this.Controls.Add(this.VentanaUnoButton);
            this.Name = "VentanaDos";
            this.Text = "VentanaDos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VentanaUnoButton;
        private System.Windows.Forms.Button VentanaTresbutton;
    }
}