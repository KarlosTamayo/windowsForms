namespace Ventanas
{
    partial class VentanaTres
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
            this.VentanaDosbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VentanaUnoButton
            // 
            this.VentanaUnoButton.Location = new System.Drawing.Point(72, 167);
            this.VentanaUnoButton.Name = "VentanaUnoButton";
            this.VentanaUnoButton.Size = new System.Drawing.Size(103, 23);
            this.VentanaUnoButton.TabIndex = 0;
            this.VentanaUnoButton.Text = "Ventana uno";
            this.VentanaUnoButton.UseVisualStyleBackColor = true;
            this.VentanaUnoButton.Click += new System.EventHandler(this.VentanaUnoButton_Click);
            // 
            // VentanaDosbutton
            // 
            this.VentanaDosbutton.Location = new System.Drawing.Point(233, 167);
            this.VentanaDosbutton.Name = "VentanaDosbutton";
            this.VentanaDosbutton.Size = new System.Drawing.Size(108, 23);
            this.VentanaDosbutton.TabIndex = 1;
            this.VentanaDosbutton.Text = "Ventana Dos";
            this.VentanaDosbutton.UseVisualStyleBackColor = true;
            this.VentanaDosbutton.Click += new System.EventHandler(this.VentanaDosbutton_Click);
            // 
            // VentanaTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 193);
            this.Controls.Add(this.VentanaDosbutton);
            this.Controls.Add(this.VentanaUnoButton);
            this.Name = "VentanaTres";
            this.Text = "VentanaTres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VentanaUnoButton;
        private System.Windows.Forms.Button VentanaDosbutton;
    }
}