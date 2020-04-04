namespace Pepito
{
    partial class PepitoDos
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
            this.PepitoButton = new System.Windows.Forms.Button();
            this.PepitoCuatroButton = new System.Windows.Forms.Button();
            this.PepitoTresButton = new System.Windows.Forms.Button();
            this.PepitoCincoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PepitoButton
            // 
            this.PepitoButton.Location = new System.Drawing.Point(39, 91);
            this.PepitoButton.Name = "PepitoButton";
            this.PepitoButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoButton.TabIndex = 0;
            this.PepitoButton.Text = "Pepito";
            this.PepitoButton.UseVisualStyleBackColor = true;
            this.PepitoButton.Click += new System.EventHandler(this.PepitoButton_Click);
            // 
            // PepitoCuatroButton
            // 
            this.PepitoCuatroButton.Location = new System.Drawing.Point(274, 91);
            this.PepitoCuatroButton.Name = "PepitoCuatroButton";
            this.PepitoCuatroButton.Size = new System.Drawing.Size(82, 23);
            this.PepitoCuatroButton.TabIndex = 1;
            this.PepitoCuatroButton.Text = "PepitoCuatro";
            this.PepitoCuatroButton.UseVisualStyleBackColor = true;
            this.PepitoCuatroButton.Click += new System.EventHandler(this.PepitoCuatroButton_Click);
            // 
            // PepitoTresButton
            // 
            this.PepitoTresButton.Location = new System.Drawing.Point(33, 36);
            this.PepitoTresButton.Name = "PepitoTresButton";
            this.PepitoTresButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoTresButton.TabIndex = 2;
            this.PepitoTresButton.Text = "PepitoTres";
            this.PepitoTresButton.UseVisualStyleBackColor = true;
            // 
            // PepitoCincoButton
            // 
            this.PepitoCincoButton.Location = new System.Drawing.Point(274, 36);
            this.PepitoCincoButton.Name = "PepitoCincoButton";
            this.PepitoCincoButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoCincoButton.TabIndex = 3;
            this.PepitoCincoButton.Text = "PepitoCinco";
            this.PepitoCincoButton.UseVisualStyleBackColor = true;
            this.PepitoCincoButton.Click += new System.EventHandler(this.PepitoCincoButton_Click_1);
            // 
            // PepitoDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 141);
            this.Controls.Add(this.PepitoCincoButton);
            this.Controls.Add(this.PepitoTresButton);
            this.Controls.Add(this.PepitoCuatroButton);
            this.Controls.Add(this.PepitoButton);
            this.Name = "PepitoDos";
            this.Text = "PepitoDos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PepitoButton;
        private System.Windows.Forms.Button PepitoCuatroButton;
        private System.Windows.Forms.Button PepitoTresButton;
        private System.Windows.Forms.Button PepitoCincoButton;
    }
}