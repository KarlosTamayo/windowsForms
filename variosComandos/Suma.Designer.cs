namespace variosComandos
{
    partial class Suma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suma));
            this.NumeroUnoTextBox = new System.Windows.Forms.TextBox();
            this.NumeroDosTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RersultadoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeroUnoTextBox
            // 
            this.NumeroUnoTextBox.BackColor = System.Drawing.Color.Lime;
            this.NumeroUnoTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NumeroUnoTextBox.Location = new System.Drawing.Point(190, 71);
            this.NumeroUnoTextBox.Name = "NumeroUnoTextBox";
            this.NumeroUnoTextBox.Size = new System.Drawing.Size(179, 20);
            this.NumeroUnoTextBox.TabIndex = 0;
            // 
            // NumeroDosTextBox
            // 
            this.NumeroDosTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NumeroDosTextBox.Location = new System.Drawing.Point(190, 108);
            this.NumeroDosTextBox.Name = "NumeroDosTextBox";
            this.NumeroDosTextBox.Size = new System.Drawing.Size(179, 20);
            this.NumeroDosTextBox.TabIndex = 1;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ResultadoTextBox.Location = new System.Drawing.Point(190, 145);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(179, 20);
            this.ResultadoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "resutado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "numero 2";
            // 
            // RersultadoButton
            // 
            this.RersultadoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RersultadoButton.Location = new System.Drawing.Point(202, 245);
            this.RersultadoButton.Name = "RersultadoButton";
            this.RersultadoButton.Size = new System.Drawing.Size(75, 23);
            this.RersultadoButton.TabIndex = 4;
            this.RersultadoButton.Text = "Resultado";
            this.RersultadoButton.UseVisualStyleBackColor = true;
            this.RersultadoButton.Click += new System.EventHandler(this.RersultadoButton_Click);
            // 
            // Comandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 323);
            this.Controls.Add(this.RersultadoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.NumeroDosTextBox);
            this.Controls.Add(this.NumeroUnoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comandos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroUnoTextBox;
        private System.Windows.Forms.TextBox NumeroDosTextBox;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RersultadoButton;
    }
}

