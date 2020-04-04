namespace Pepito
{
    partial class Pepito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pepito));
            this.PepitoDosButton = new System.Windows.Forms.Button();
            this.PepitoTresButton = new System.Windows.Forms.Button();
            this.peptioCuatroButton = new System.Windows.Forms.Button();
            this.PepitoCincoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PepitoDosButton
            // 
            this.PepitoDosButton.Location = new System.Drawing.Point(25, 35);
            this.PepitoDosButton.Name = "PepitoDosButton";
            this.PepitoDosButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoDosButton.TabIndex = 0;
            this.PepitoDosButton.Text = "PepitoDos";
            this.PepitoDosButton.UseVisualStyleBackColor = true;
            this.PepitoDosButton.Click += new System.EventHandler(this.PepitoDosButton_Click);
            // 
            // PepitoTresButton
            // 
            this.PepitoTresButton.Location = new System.Drawing.Point(25, 73);
            this.PepitoTresButton.Name = "PepitoTresButton";
            this.PepitoTresButton.Size = new System.Drawing.Size(75, 23);
            this.PepitoTresButton.TabIndex = 1;
            this.PepitoTresButton.Text = "PepitoTres";
            this.PepitoTresButton.UseVisualStyleBackColor = true;
            this.PepitoTresButton.Click += new System.EventHandler(this.PepitoTresButton_Click_1);
            // 
            // peptioCuatroButton
            // 
            this.peptioCuatroButton.Location = new System.Drawing.Point(134, 35);
            this.peptioCuatroButton.Name = "peptioCuatroButton";
            this.peptioCuatroButton.Size = new System.Drawing.Size(106, 23);
            this.peptioCuatroButton.TabIndex = 2;
            this.peptioCuatroButton.Text = "Pepito Cuatro";
            this.peptioCuatroButton.UseVisualStyleBackColor = true;
            this.peptioCuatroButton.Click += new System.EventHandler(this.peptioCuatroButton_Click);
            // 
            // PepitoCincoButton
            // 
            this.PepitoCincoButton.Location = new System.Drawing.Point(134, 73);
            this.PepitoCincoButton.Name = "PepitoCincoButton";
            this.PepitoCincoButton.Size = new System.Drawing.Size(106, 23);
            this.PepitoCincoButton.TabIndex = 3;
            this.PepitoCincoButton.Text = "Pepito cinco";
            this.PepitoCincoButton.UseVisualStyleBackColor = true;
            this.PepitoCincoButton.Click += new System.EventHandler(this.PepitoCincoButton_Click);
            // 
            // Pepito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 122);
            this.Controls.Add(this.PepitoCincoButton);
            this.Controls.Add(this.peptioCuatroButton);
            this.Controls.Add(this.PepitoTresButton);
            this.Controls.Add(this.PepitoDosButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pepito";
            this.Text = "Pepito";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PepitoDosButton;
        private System.Windows.Forms.Button PepitoTresButton;
        private System.Windows.Forms.Button peptioCuatroButton;
        private System.Windows.Forms.Button PepitoCincoButton;
    }
}

