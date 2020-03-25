namespace division
{
    partial class Division
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Division));
            this.Valor1textBox = new System.Windows.Forms.TextBox();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.DivisiontextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.Valorlabel1 = new System.Windows.Forms.Label();
            this.Valorlabel2 = new System.Windows.Forms.Label();
            this.Divisionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valor1textBox
            // 
            this.Valor1textBox.Location = new System.Drawing.Point(64, 38);
            this.Valor1textBox.Name = "Valor1textBox";
            this.Valor1textBox.Size = new System.Drawing.Size(100, 20);
            this.Valor1textBox.TabIndex = 0;
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(344, 38);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(100, 20);
            this.ValortextBox.TabIndex = 1;
            // 
            // DivisiontextBox
            // 
            this.DivisiontextBox.Location = new System.Drawing.Point(215, 108);
            this.DivisiontextBox.Name = "DivisiontextBox";
            this.DivisiontextBox.Size = new System.Drawing.Size(100, 20);
            this.DivisiontextBox.TabIndex = 2;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(215, 176);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(89, 31);
            this.Calcularbutton.TabIndex = 3;
            this.Calcularbutton.Text = "calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Valorlabel1
            // 
            this.Valorlabel1.AutoSize = true;
            this.Valorlabel1.Location = new System.Drawing.Point(75, 19);
            this.Valorlabel1.Name = "Valorlabel1";
            this.Valorlabel1.Size = new System.Drawing.Size(36, 13);
            this.Valorlabel1.TabIndex = 4;
            this.Valorlabel1.Text = "valor1";
            // 
            // Valorlabel2
            // 
            this.Valorlabel2.AutoSize = true;
            this.Valorlabel2.Location = new System.Drawing.Point(344, 13);
            this.Valorlabel2.Name = "Valorlabel2";
            this.Valorlabel2.Size = new System.Drawing.Size(36, 13);
            this.Valorlabel2.TabIndex = 5;
            this.Valorlabel2.Text = "valor2";
            // 
            // Divisionlabel
            // 
            this.Divisionlabel.AutoSize = true;
            this.Divisionlabel.Location = new System.Drawing.Point(134, 115);
            this.Divisionlabel.Name = "Divisionlabel";
            this.Divisionlabel.Size = new System.Drawing.Size(42, 13);
            this.Divisionlabel.TabIndex = 6;
            this.Divisionlabel.Text = "division";
            // 
            // Division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(506, 273);
            this.Controls.Add(this.Divisionlabel);
            this.Controls.Add(this.Valorlabel2);
            this.Controls.Add(this.Valorlabel1);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.DivisiontextBox);
            this.Controls.Add(this.ValortextBox);
            this.Controls.Add(this.Valor1textBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Division";
            this.Text = "DivisionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor1textBox;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.TextBox DivisiontextBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label Valorlabel1;
        private System.Windows.Forms.Label Valorlabel2;
        private System.Windows.Forms.Label Divisionlabel;
    }
}

