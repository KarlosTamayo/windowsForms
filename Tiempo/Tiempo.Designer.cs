namespace Tiempo
{
    partial class Tiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiempo));
            this.VelosidadTextBox = new System.Windows.Forms.TextBox();
            this.DistanciaTextBox = new System.Windows.Forms.TextBox();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.Velosidad = new System.Windows.Forms.Label();
            this.Distancia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VelosidadTextBox
            // 
            this.VelosidadTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.VelosidadTextBox.Location = new System.Drawing.Point(12, 62);
            this.VelosidadTextBox.Name = "VelosidadTextBox";
            this.VelosidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.VelosidadTextBox.TabIndex = 0;
            // 
            // DistanciaTextBox
            // 
            this.DistanciaTextBox.BackColor = System.Drawing.Color.Aqua;
            this.DistanciaTextBox.Location = new System.Drawing.Point(185, 43);
            this.DistanciaTextBox.Name = "DistanciaTextBox";
            this.DistanciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.DistanciaTextBox.TabIndex = 1;
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TiempoTextBox.Location = new System.Drawing.Point(185, 92);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(100, 20);
            this.TiempoTextBox.TabIndex = 2;
            // 
            // CalcularButton
            // 
            this.CalcularButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CalcularButton.Location = new System.Drawing.Point(88, 133);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = false;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Velosidad
            // 
            this.Velosidad.AutoSize = true;
            this.Velosidad.Location = new System.Drawing.Point(31, 46);
            this.Velosidad.Name = "Velosidad";
            this.Velosidad.Size = new System.Drawing.Size(53, 13);
            this.Velosidad.TabIndex = 4;
            this.Velosidad.Text = "Velosidad";
            // 
            // Distancia
            // 
            this.Distancia.AutoSize = true;
            this.Distancia.Location = new System.Drawing.Point(185, 27);
            this.Distancia.Name = "Distancia";
            this.Distancia.Size = new System.Drawing.Size(51, 13);
            this.Distancia.TabIndex = 5;
            this.Distancia.Text = "Distancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(185, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // Tiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(346, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Distancia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Velosidad);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.TiempoTextBox);
            this.Controls.Add(this.DistanciaTextBox);
            this.Controls.Add(this.VelosidadTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tiempo";
            this.Text = "Tiempo";
            this.Load += new System.EventHandler(this.Tiempo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VelosidadTextBox;
        private System.Windows.Forms.TextBox DistanciaTextBox;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label Velosidad;
        private System.Windows.Forms.Label Distancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

