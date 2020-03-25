namespace cuatroformas
{
    partial class aroowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aroowForm));
            this.FormasUnocheckBox = new System.Windows.Forms.CheckBox();
            this.FormasDoscheckBo = new System.Windows.Forms.CheckBox();
            this.FormasTrescheckBo = new System.Windows.Forms.CheckBox();
            this.FormasCuatrocheckBox = new System.Windows.Forms.CheckBox();
            this.Activebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormasUnocheckBox
            // 
            this.FormasUnocheckBox.AutoSize = true;
            this.FormasUnocheckBox.BackColor = System.Drawing.Color.Silver;
            this.FormasUnocheckBox.ForeColor = System.Drawing.Color.Blue;
            this.FormasUnocheckBox.Location = new System.Drawing.Point(110, 54);
            this.FormasUnocheckBox.Name = "FormasUnocheckBox";
            this.FormasUnocheckBox.Size = new System.Drawing.Size(70, 17);
            this.FormasUnocheckBox.TabIndex = 0;
            this.FormasUnocheckBox.Text = "formauno";
            this.FormasUnocheckBox.UseVisualStyleBackColor = false;
            this.FormasUnocheckBox.CheckedChanged += new System.EventHandler(this.FormasUnocheckBox_CheckedChanged);
            // 
            // FormasDoscheckBo
            // 
            this.FormasDoscheckBo.AutoSize = true;
            this.FormasDoscheckBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormasDoscheckBo.ForeColor = System.Drawing.Color.Red;
            this.FormasDoscheckBo.Location = new System.Drawing.Point(110, 88);
            this.FormasDoscheckBo.Name = "FormasDoscheckBo";
            this.FormasDoscheckBo.Size = new System.Drawing.Size(69, 17);
            this.FormasDoscheckBo.TabIndex = 2;
            this.FormasDoscheckBo.Text = "formados";
            this.FormasDoscheckBo.UseVisualStyleBackColor = false;
            // 
            // FormasTrescheckBo
            // 
            this.FormasTrescheckBo.AutoSize = true;
            this.FormasTrescheckBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormasTrescheckBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormasTrescheckBo.Location = new System.Drawing.Point(110, 123);
            this.FormasTrescheckBo.Name = "FormasTrescheckBo";
            this.FormasTrescheckBo.Size = new System.Drawing.Size(69, 17);
            this.FormasTrescheckBo.TabIndex = 3;
            this.FormasTrescheckBo.Text = "formatres";
            this.FormasTrescheckBo.UseVisualStyleBackColor = false;
            // 
            // FormasCuatrocheckBox
            // 
            this.FormasCuatrocheckBox.AutoSize = true;
            this.FormasCuatrocheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormasCuatrocheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormasCuatrocheckBox.Location = new System.Drawing.Point(110, 157);
            this.FormasCuatrocheckBox.Name = "FormasCuatrocheckBox";
            this.FormasCuatrocheckBox.Size = new System.Drawing.Size(82, 17);
            this.FormasCuatrocheckBox.TabIndex = 4;
            this.FormasCuatrocheckBox.Text = "formacuatro";
            this.FormasCuatrocheckBox.UseVisualStyleBackColor = false;
            // 
            // Activebutton
            // 
            this.Activebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Activebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Activebutton.Location = new System.Drawing.Point(110, 216);
            this.Activebutton.Name = "Activebutton";
            this.Activebutton.Size = new System.Drawing.Size(75, 23);
            this.Activebutton.TabIndex = 5;
            this.Activebutton.Text = "active";
            this.Activebutton.UseVisualStyleBackColor = false;
            this.Activebutton.Click += new System.EventHandler(this.Activebutton_Click);
            // 
            // aroowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 346);
            this.Controls.Add(this.Activebutton);
            this.Controls.Add(this.FormasCuatrocheckBox);
            this.Controls.Add(this.FormasTrescheckBo);
            this.Controls.Add(this.FormasDoscheckBo);
            this.Controls.Add(this.FormasUnocheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aroowForm";
            this.Text = "Formularios";
            this.Load += new System.EventHandler(this.aroowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox FormasUnocheckBox;
        private System.Windows.Forms.CheckBox FormasDoscheckBo;
        private System.Windows.Forms.CheckBox FormasTrescheckBo;
        private System.Windows.Forms.CheckBox FormasCuatrocheckBox;
        private System.Windows.Forms.Button Activebutton;
    }
}

