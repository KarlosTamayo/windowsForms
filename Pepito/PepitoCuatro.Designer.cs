namespace Pepito
{
    partial class PepitoCuatro
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
            this.PepitoTresButton = new System.Windows.Forms.Button();
            this.PepitoButton = new System.Windows.Forms.Button();
            this.PepitoDosButton = new System.Windows.Forms.Button();
            this.PepitoCincoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PepitoTresButton
            // 
            this.PepitoTresButton.Location = new System.Drawing.Point(28, 95);
            this.PepitoTresButton.Name = "PepitoTresButton";
            this.PepitoTresButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoTresButton.TabIndex = 0;
            this.PepitoTresButton.Text = "PepitoTres";
            this.PepitoTresButton.UseVisualStyleBackColor = true;
            this.PepitoTresButton.Click += new System.EventHandler(this.PepitoTresButton_Click);
            // 
            // PepitoButton
            // 
            this.PepitoButton.Location = new System.Drawing.Point(253, 95);
            this.PepitoButton.Name = "PepitoButton";
            this.PepitoButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoButton.TabIndex = 1;
            this.PepitoButton.Text = "Pepito";
            this.PepitoButton.UseVisualStyleBackColor = true;
            this.PepitoButton.Click += new System.EventHandler(this.PepitoButton_Click);
            // 
            // PepitoDosButton
            // 
            this.PepitoDosButton.Location = new System.Drawing.Point(28, 27);
            this.PepitoDosButton.Name = "PepitoDosButton";
            this.PepitoDosButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoDosButton.TabIndex = 2;
            this.PepitoDosButton.Text = "PepitoDos";
            this.PepitoDosButton.UseVisualStyleBackColor = true;
            this.PepitoDosButton.Click += new System.EventHandler(this.PepitoDosButton_Click);
            // 
            // PepitoCincoButton
            // 
            this.PepitoCincoButton.Location = new System.Drawing.Point(253, 27);
            this.PepitoCincoButton.Name = "PepitoCincoButton";
            this.PepitoCincoButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoCincoButton.TabIndex = 3;
            this.PepitoCincoButton.Text = "PepitoCinco";
            this.PepitoCincoButton.UseVisualStyleBackColor = true;
            this.PepitoCincoButton.Click += new System.EventHandler(this.PepitoCincoButton_Click);
            // 
            // PepitoCuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 158);
            this.Controls.Add(this.PepitoCincoButton);
            this.Controls.Add(this.PepitoDosButton);
            this.Controls.Add(this.PepitoButton);
            this.Controls.Add(this.PepitoTresButton);
            this.Name = "PepitoCuatro";
            this.Text = "PepitoCuatro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PepitoTresButton;
        private System.Windows.Forms.Button PepitoButton;
        private System.Windows.Forms.Button PepitoDosButton;
        private System.Windows.Forms.Button PepitoCincoButton;
    }
}