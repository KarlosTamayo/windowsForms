namespace Pepito
{
    partial class PepitoTres
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
            this.PepitoCincoButton = new System.Windows.Forms.Button();
            this.PepitoDosButton = new System.Windows.Forms.Button();
            this.PepitoButton = new System.Windows.Forms.Button();
            this.PepitoCuatroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PepitoCincoButton
            // 
            this.PepitoCincoButton.Location = new System.Drawing.Point(13, 84);
            this.PepitoCincoButton.Name = "PepitoCincoButton";
            this.PepitoCincoButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoCincoButton.TabIndex = 0;
            this.PepitoCincoButton.Text = "PepitoCinco";
            this.PepitoCincoButton.UseVisualStyleBackColor = true;
            this.PepitoCincoButton.Click += new System.EventHandler(this.PepitoCincoButton_Click);
            // 
            // PepitoDosButton
            // 
            this.PepitoDosButton.Location = new System.Drawing.Point(236, 84);
            this.PepitoDosButton.Name = "PepitoDosButton";
            this.PepitoDosButton.Size = new System.Drawing.Size(85, 23);
            this.PepitoDosButton.TabIndex = 1;
            this.PepitoDosButton.Text = "PepitoDos";
            this.PepitoDosButton.UseVisualStyleBackColor = true;
            this.PepitoDosButton.Click += new System.EventHandler(this.PepitoDosButton_Click);
            // 
            // PepitoButton
            // 
            this.PepitoButton.Location = new System.Drawing.Point(13, 22);
            this.PepitoButton.Name = "PepitoButton";
            this.PepitoButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoButton.TabIndex = 2;
            this.PepitoButton.Text = "Pepito";
            this.PepitoButton.UseVisualStyleBackColor = true;
            this.PepitoButton.Click += new System.EventHandler(this.PepitoButton_Click);
            // 
            // PepitoCuatroButton
            // 
            this.PepitoCuatroButton.Location = new System.Drawing.Point(236, 22);
            this.PepitoCuatroButton.Name = "PepitoCuatroButton";
            this.PepitoCuatroButton.Size = new System.Drawing.Size(85, 23);
            this.PepitoCuatroButton.TabIndex = 3;
            this.PepitoCuatroButton.Text = "PepitoCuatro";
            this.PepitoCuatroButton.UseVisualStyleBackColor = true;
            this.PepitoCuatroButton.Click += new System.EventHandler(this.PepitoCuatroButton_Click);
            // 
            // PepitoTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 154);
            this.Controls.Add(this.PepitoCuatroButton);
            this.Controls.Add(this.PepitoButton);
            this.Controls.Add(this.PepitoDosButton);
            this.Controls.Add(this.PepitoCincoButton);
            this.Name = "PepitoTres";
            this.Text = "PepitoTres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PepitoCincoButton;
        private System.Windows.Forms.Button PepitoDosButton;
        private System.Windows.Forms.Button PepitoButton;
        private System.Windows.Forms.Button PepitoCuatroButton;
    }
}