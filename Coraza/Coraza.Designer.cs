namespace Coraza
{
    partial class Coraza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coraza));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BarrioPopularTextBox = new System.Windows.Forms.TextBox();
            this.LavidaEsBellaTextBox = new System.Windows.Forms.TextBox();
            this.VentadosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LaVidaEsBella";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "CorazonEncantado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(324, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "MiGranLocoYDulseAmor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(324, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "CorazonMagico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(39, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "BarrioPopular";
            // 
            // BarrioPopularTextBox
            // 
            this.BarrioPopularTextBox.Location = new System.Drawing.Point(44, 291);
            this.BarrioPopularTextBox.Name = "BarrioPopularTextBox";
            this.BarrioPopularTextBox.Size = new System.Drawing.Size(100, 20);
            this.BarrioPopularTextBox.TabIndex = 5;
            // 
            // LavidaEsBellaTextBox
            // 
            this.LavidaEsBellaTextBox.Location = new System.Drawing.Point(517, 275);
            this.LavidaEsBellaTextBox.Name = "LavidaEsBellaTextBox";
            this.LavidaEsBellaTextBox.Size = new System.Drawing.Size(100, 20);
            this.LavidaEsBellaTextBox.TabIndex = 6;
            this.LavidaEsBellaTextBox.TextChanged += new System.EventHandler(this.LavidaEsBellaTextBox_TextChanged);
            // 
            // VentadosButton
            // 
            this.VentadosButton.Location = new System.Drawing.Point(307, 322);
            this.VentadosButton.Name = "VentadosButton";
            this.VentadosButton.Size = new System.Drawing.Size(75, 23);
            this.VentadosButton.TabIndex = 7;
            this.VentadosButton.Text = "Intro";
            this.VentadosButton.UseVisualStyleBackColor = true;
            this.VentadosButton.Click += new System.EventHandler(this.VentadosButton_Click);
            // 
            // Coraza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 401);
            this.Controls.Add(this.VentadosButton);
            this.Controls.Add(this.LavidaEsBellaTextBox);
            this.Controls.Add(this.BarrioPopularTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Coraza";
            this.Text = "Coraza";
            this.Load += new System.EventHandler(this.Coraza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BarrioPopularTextBox;
        private System.Windows.Forms.TextBox LavidaEsBellaTextBox;
        private System.Windows.Forms.Button VentadosButton;
    }
}

