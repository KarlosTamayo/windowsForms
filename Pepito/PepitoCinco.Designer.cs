namespace Pepito
{
    partial class PepitoCinco
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
            this.PepitoCutroButton = new System.Windows.Forms.Button();
            this.PepitoButton = new System.Windows.Forms.Button();
            this.PepitoDosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PepitoTresButton
            // 
            this.PepitoTresButton.Location = new System.Drawing.Point(25, 85);
            this.PepitoTresButton.Name = "PepitoTresButton";
            this.PepitoTresButton.Size = new System.Drawing.Size(85, 23);
            this.PepitoTresButton.TabIndex = 0;
            this.PepitoTresButton.Text = "PepitoTres";
            this.PepitoTresButton.UseVisualStyleBackColor = true;
            this.PepitoTresButton.Click += new System.EventHandler(this.PepitoTresButton_Click);
            // 
            // PepitoCutroButton
            // 
            this.PepitoCutroButton.Location = new System.Drawing.Point(25, 33);
            this.PepitoCutroButton.Name = "PepitoCutroButton";
            this.PepitoCutroButton.Size = new System.Drawing.Size(85, 23);
            this.PepitoCutroButton.TabIndex = 1;
            this.PepitoCutroButton.Text = "PepitoCuatro";
            this.PepitoCutroButton.UseVisualStyleBackColor = true;
            this.PepitoCutroButton.Click += new System.EventHandler(this.PepitoCutroButton_Click);
            // 
            // PepitoButton
            // 
            this.PepitoButton.Location = new System.Drawing.Point(217, 85);
            this.PepitoButton.Name = "PepitoButton";
            this.PepitoButton.Size = new System.Drawing.Size(85, 23);
            this.PepitoButton.TabIndex = 2;
            this.PepitoButton.Text = "Pepito";
            this.PepitoButton.UseVisualStyleBackColor = true;
            this.PepitoButton.Click += new System.EventHandler(this.PepitoButton_Click);
            // 
            // PepitoDosButton
            // 
            this.PepitoDosButton.Location = new System.Drawing.Point(217, 33);
            this.PepitoDosButton.Name = "PepitoDosButton";
            this.PepitoDosButton.Size = new System.Drawing.Size(85, 23);
            this.PepitoDosButton.TabIndex = 3;
            this.PepitoDosButton.Text = "PepitoDos";
            this.PepitoDosButton.UseVisualStyleBackColor = true;
            this.PepitoDosButton.Click += new System.EventHandler(this.PepitoDosButton_Click);
            // 
            // PepitoCinco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 159);
            this.Controls.Add(this.PepitoDosButton);
            this.Controls.Add(this.PepitoButton);
            this.Controls.Add(this.PepitoCutroButton);
            this.Controls.Add(this.PepitoTresButton);
            this.Name = "PepitoCinco";
            this.Text = "PepitoCinco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PepitoTresButton;
        private System.Windows.Forms.Button PepitoCutroButton;
        private System.Windows.Forms.Button PepitoButton;
        private System.Windows.Forms.Button PepitoDosButton;
    }
}