namespace Vista
{
    partial class Welcome
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
            this.Iniciobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Iniciobtn
            // 
            this.Iniciobtn.Location = new System.Drawing.Point(106, 327);
            this.Iniciobtn.Name = "Iniciobtn";
            this.Iniciobtn.Size = new System.Drawing.Size(191, 27);
            this.Iniciobtn.TabIndex = 0;
            this.Iniciobtn.Text = "Iniciar Sesion";
            this.Iniciobtn.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Iniciobtn);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciobtn;
    }
}