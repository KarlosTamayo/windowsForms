namespace Ventanas
{
    partial class VentaUno
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
            this.VentanaTresbutton = new System.Windows.Forms.Button();
            this.VentanaDosbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VentanaTresbutton
            // 
            this.VentanaTresbutton.Location = new System.Drawing.Point(53, 114);
            this.VentanaTresbutton.Name = "VentanaTresbutton";
            this.VentanaTresbutton.Size = new System.Drawing.Size(75, 23);
            this.VentanaTresbutton.TabIndex = 0;
            this.VentanaTresbutton.Text = "VentanaTres";
            this.VentanaTresbutton.UseVisualStyleBackColor = true;
            this.VentanaTresbutton.Click += new System.EventHandler(this.VentanaTresbutton_Click);
            // 
            // VentanaDosbutton
            // 
            this.VentanaDosbutton.Location = new System.Drawing.Point(263, 114);
            this.VentanaDosbutton.Name = "VentanaDosbutton";
            this.VentanaDosbutton.Size = new System.Drawing.Size(75, 23);
            this.VentanaDosbutton.TabIndex = 1;
            this.VentanaDosbutton.Text = "VentanaDos";
            this.VentanaDosbutton.UseVisualStyleBackColor = true;
            this.VentanaDosbutton.Click += new System.EventHandler(this.VentanaDosbutton_Click);
            // 
            // VentaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 185);
            this.Controls.Add(this.VentanaDosbutton);
            this.Controls.Add(this.VentanaTresbutton);
            this.Name = "VentaUno";
            this.Text = "VentanaUno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VentanaTresbutton;
        private System.Windows.Forms.Button VentanaDosbutton;
    }
}

