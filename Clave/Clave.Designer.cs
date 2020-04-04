namespace Clave
{
    partial class Clave
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
            this.ClaveCheckBox = new System.Windows.Forms.CheckBox();
            this.ClaveUnoCheckBox = new System.Windows.Forms.CheckBox();
            this.ClaveDosCheCkBox = new System.Windows.Forms.CheckBox();
            this.ClaveTresCheCkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClaveCheckBox
            // 
            this.ClaveCheckBox.AutoSize = true;
            this.ClaveCheckBox.Location = new System.Drawing.Point(271, 86);
            this.ClaveCheckBox.Name = "ClaveCheckBox";
            this.ClaveCheckBox.Size = new System.Drawing.Size(80, 17);
            this.ClaveCheckBox.TabIndex = 0;
            this.ClaveCheckBox.Text = "checkBox1";
            this.ClaveCheckBox.UseVisualStyleBackColor = true;
            this.ClaveCheckBox.CheckedChanged += new System.EventHandler(this.ClaveCheckBox_CheckedChanged);
            // 
            // ClaveUnoCheckBox
            // 
            this.ClaveUnoCheckBox.AutoSize = true;
            this.ClaveUnoCheckBox.Location = new System.Drawing.Point(271, 124);
            this.ClaveUnoCheckBox.Name = "ClaveUnoCheckBox";
            this.ClaveUnoCheckBox.Size = new System.Drawing.Size(73, 17);
            this.ClaveUnoCheckBox.TabIndex = 1;
            this.ClaveUnoCheckBox.Text = "ClaveUno";
            this.ClaveUnoCheckBox.UseVisualStyleBackColor = true;
            this.ClaveUnoCheckBox.CheckedChanged += new System.EventHandler(this.ClaveUnoCheckBox_CheckedChanged);
            // 
            // ClaveDosCheCkBox
            // 
            this.ClaveDosCheCkBox.AutoSize = true;
            this.ClaveDosCheCkBox.Location = new System.Drawing.Point(271, 163);
            this.ClaveDosCheCkBox.Name = "ClaveDosCheCkBox";
            this.ClaveDosCheCkBox.Size = new System.Drawing.Size(72, 17);
            this.ClaveDosCheCkBox.TabIndex = 2;
            this.ClaveDosCheCkBox.Text = "ClaveDos";
            this.ClaveDosCheCkBox.UseVisualStyleBackColor = true;
            this.ClaveDosCheCkBox.CheckedChanged += new System.EventHandler(this.ClaveDosCheCkBox_CheckedChanged);
            // 
            // ClaveTresCheCkBox
            // 
            this.ClaveTresCheCkBox.AutoSize = true;
            this.ClaveTresCheCkBox.Location = new System.Drawing.Point(271, 216);
            this.ClaveTresCheCkBox.Name = "ClaveTresCheCkBox";
            this.ClaveTresCheCkBox.Size = new System.Drawing.Size(74, 17);
            this.ClaveTresCheCkBox.TabIndex = 3;
            this.ClaveTresCheCkBox.Text = "ClaveTres";
            this.ClaveTresCheCkBox.UseVisualStyleBackColor = true;
            this.ClaveTresCheCkBox.CheckedChanged += new System.EventHandler(this.ClaveTresCheCkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loteria si  hacietas te doy un premio";
            // 
            // Clave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClaveTresCheCkBox);
            this.Controls.Add(this.ClaveDosCheCkBox);
            this.Controls.Add(this.ClaveUnoCheckBox);
            this.Controls.Add(this.ClaveCheckBox);
            this.Name = "Clave";
            this.Text = "Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ClaveCheckBox;
        private System.Windows.Forms.CheckBox ClaveUnoCheckBox;
        private System.Windows.Forms.CheckBox ClaveDosCheCkBox;
        private System.Windows.Forms.CheckBox ClaveTresCheCkBox;
        private System.Windows.Forms.Label label1;
    }
}

