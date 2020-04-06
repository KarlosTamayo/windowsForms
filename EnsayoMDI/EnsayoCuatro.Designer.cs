namespace EnsayoMDI
{
    partial class EnsayoCuatro
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
            this.ComBoBox = new System.Windows.Forms.ComboBox();
            this.EntrarButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.PictureBoxDos = new System.Windows.Forms.PictureBox();
            this.PictureBoxUno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUno)).BeginInit();
            this.SuspendLayout();
            // 
            // ComBoBox
            // 
            this.ComBoBox.FormattingEnabled = true;
            this.ComBoBox.Items.AddRange(new object[] {
            "werewolf-2-36",
            "witch-2-36"});
            this.ComBoBox.Location = new System.Drawing.Point(145, 74);
            this.ComBoBox.Name = "ComBoBox";
            this.ComBoBox.Size = new System.Drawing.Size(121, 21);
            this.ComBoBox.TabIndex = 0;
            // 
            // EntrarButton
            // 
            this.EntrarButton.Location = new System.Drawing.Point(253, 186);
            this.EntrarButton.Name = "EntrarButton";
            this.EntrarButton.Size = new System.Drawing.Size(75, 23);
            this.EntrarButton.TabIndex = 1;
            this.EntrarButton.Text = "Entrar";
            this.EntrarButton.UseVisualStyleBackColor = true;
            this.EntrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Items.AddRange(new object[] {
            "bat-3-36",
            "zombie-2-36"});
            this.ListBox.Location = new System.Drawing.Point(374, 53);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 69);
            this.ListBox.TabIndex = 4;
            // 
            // PictureBoxDos
            // 
            this.PictureBoxDos.Image = global::EnsayoMDI.Properties.Resources.black_cat_3_36;
            this.PictureBoxDos.InitialImage = null;
            this.PictureBoxDos.Location = new System.Drawing.Point(394, 272);
            this.PictureBoxDos.Name = "PictureBoxDos";
            this.PictureBoxDos.Size = new System.Drawing.Size(100, 50);
            this.PictureBoxDos.TabIndex = 3;
            this.PictureBoxDos.TabStop = false;
            // 
            // PictureBoxUno
            // 
            this.PictureBoxUno.Image = global::EnsayoMDI.Properties.Resources.werewolf_2_36;
            this.PictureBoxUno.Location = new System.Drawing.Point(145, 272);
            this.PictureBoxUno.Name = "PictureBoxUno";
            this.PictureBoxUno.Size = new System.Drawing.Size(100, 50);
            this.PictureBoxUno.TabIndex = 2;
            this.PictureBoxUno.TabStop = false;
            // 
            // EnsayoCuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 380);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.PictureBoxDos);
            this.Controls.Add(this.PictureBoxUno);
            this.Controls.Add(this.EntrarButton);
            this.Controls.Add(this.ComBoBox);
            this.Name = "EnsayoCuatro";
            this.Text = "EnsayoCuatro";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComBoBox;
        private System.Windows.Forms.Button EntrarButton;
        private System.Windows.Forms.PictureBox PictureBoxUno;
        private System.Windows.Forms.PictureBox PictureBoxDos;
        private System.Windows.Forms.ListBox ListBox;
    }
}