namespace proyectoPrincipal
{
    partial class ProyectoDos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ElejirButton = new System.Windows.Forms.Button();
            this.ComBoBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 494);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ElejirButton
            // 
            this.ElejirButton.Location = new System.Drawing.Point(342, 386);
            this.ElejirButton.Name = "ElejirButton";
            this.ElejirButton.Size = new System.Drawing.Size(75, 23);
            this.ElejirButton.TabIndex = 1;
            this.ElejirButton.Text = "Elejir";
            this.ElejirButton.UseVisualStyleBackColor = true;
            this.ElejirButton.Click += new System.EventHandler(this.ElejirButton_Click);
            // 
            // ComBoBox
            // 
            this.ComBoBox.FormattingEnabled = true;
            this.ComBoBox.Items.AddRange(new object[] {
            "perro"});
            this.ComBoBox.Location = new System.Drawing.Point(462, 386);
            this.ComBoBox.Name = "ComBoBox";
            this.ComBoBox.Size = new System.Drawing.Size(121, 21);
            this.ComBoBox.TabIndex = 2;
            // 
            // ProyectoDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 494);
            this.Controls.Add(this.ComBoBox);
            this.Controls.Add(this.ElejirButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProyectoDos";
            this.Text = "ProyectoDos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ElejirButton;
        private System.Windows.Forms.ComboBox ComBoBox;
    }
}