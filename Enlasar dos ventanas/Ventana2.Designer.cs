namespace Enlasar_dos_ventanas
{
    partial class Ventana2
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
            this.CCheckBox = new System.Windows.Forms.CheckBox();
            this.NetCheckBox = new System.Windows.Forms.CheckBox();
            this.CreditoRadioButton = new System.Windows.Forms.RadioButton();
            this.PipalRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CursoVentaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComprarButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CCheckBox
            // 
            this.CCheckBox.AutoSize = true;
            this.CCheckBox.Location = new System.Drawing.Point(93, 230);
            this.CCheckBox.Name = "CCheckBox";
            this.CCheckBox.Size = new System.Drawing.Size(40, 17);
            this.CCheckBox.TabIndex = 1;
            this.CCheckBox.Text = "C#";
            this.CCheckBox.UseVisualStyleBackColor = true;
            // 
            // NetCheckBox
            // 
            this.NetCheckBox.AutoSize = true;
            this.NetCheckBox.Location = new System.Drawing.Point(93, 277);
            this.NetCheckBox.Name = "NetCheckBox";
            this.NetCheckBox.Size = new System.Drawing.Size(89, 17);
            this.NetCheckBox.TabIndex = 2;
            this.NetCheckBox.Text = ".Net Core 2.1";
            this.NetCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreditoRadioButton
            // 
            this.CreditoRadioButton.AutoSize = true;
            this.CreditoRadioButton.Location = new System.Drawing.Point(312, 230);
            this.CreditoRadioButton.Name = "CreditoRadioButton";
            this.CreditoRadioButton.Size = new System.Drawing.Size(58, 17);
            this.CreditoRadioButton.TabIndex = 3;
            this.CreditoRadioButton.TabStop = true;
            this.CreditoRadioButton.Text = "Credito";
            this.CreditoRadioButton.UseVisualStyleBackColor = true;
            // 
            // PipalRadioButton
            // 
            this.PipalRadioButton.AutoSize = true;
            this.PipalRadioButton.Location = new System.Drawing.Point(312, 277);
            this.PipalRadioButton.Name = "PipalRadioButton";
            this.PipalRadioButton.Size = new System.Drawing.Size(48, 17);
            this.PipalRadioButton.TabIndex = 4;
            this.PipalRadioButton.TabStop = true;
            this.PipalRadioButton.Text = "Pipal";
            this.PipalRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enlasar_dos_ventanas.Properties.Resources._73610;
            this.pictureBox1.Location = new System.Drawing.Point(130, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CursoVentaLabel
            // 
            this.CursoVentaLabel.AutoSize = true;
            this.CursoVentaLabel.Location = new System.Drawing.Point(90, 204);
            this.CursoVentaLabel.Name = "CursoVentaLabel";
            this.CursoVentaLabel.Size = new System.Drawing.Size(65, 13);
            this.CursoVentaLabel.TabIndex = 5;
            this.CursoVentaLabel.Text = "Curso Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecto metodo de compra";
            // 
            // ComprarButton
            // 
            this.ComprarButton.Location = new System.Drawing.Point(147, 332);
            this.ComprarButton.Name = "ComprarButton";
            this.ComprarButton.Size = new System.Drawing.Size(75, 23);
            this.ComprarButton.TabIndex = 7;
            this.ComprarButton.Text = "Comprar";
            this.ComprarButton.UseVisualStyleBackColor = true;
            this.ComprarButton.Click += new System.EventHandler(this.ComprarButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(261, 332);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(75, 23);
            this.VolverButton.TabIndex = 8;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.ComprarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CursoVentaLabel);
            this.Controls.Add(this.PipalRadioButton);
            this.Controls.Add(this.CreditoRadioButton);
            this.Controls.Add(this.NetCheckBox);
            this.Controls.Add(this.CCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ventana2";
            this.Text = "Volver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CCheckBox;
        private System.Windows.Forms.CheckBox NetCheckBox;
        private System.Windows.Forms.RadioButton CreditoRadioButton;
        private System.Windows.Forms.RadioButton PipalRadioButton;
        private System.Windows.Forms.Label CursoVentaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComprarButton;
        private System.Windows.Forms.Button VolverButton;
    }
}