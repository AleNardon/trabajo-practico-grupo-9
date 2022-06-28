namespace Vista
{
    partial class Register
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
            this.nombretxb = new System.Windows.Forms.TextBox();
            this.apellidotbx = new System.Windows.Forms.TextBox();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.apellidolbl = new System.Windows.Forms.Label();
            this.registrolb = new System.Windows.Forms.Label();
            this.dnilbl = new System.Windows.Forms.Label();
            this.DNItbx = new System.Windows.Forms.TextBox();
            this.maillbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tellbl = new System.Windows.Forms.Label();
            this.teltbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombretxb
            // 
            this.nombretxb.Location = new System.Drawing.Point(62, 50);
            this.nombretxb.Name = "nombretxb";
            this.nombretxb.Size = new System.Drawing.Size(160, 20);
            this.nombretxb.TabIndex = 0;
            // 
            // apellidotbx
            // 
            this.apellidotbx.Location = new System.Drawing.Point(62, 84);
            this.apellidotbx.Name = "apellidotbx";
            this.apellidotbx.Size = new System.Drawing.Size(160, 20);
            this.apellidotbx.TabIndex = 1;
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Location = new System.Drawing.Point(12, 53);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.nombrelbl.TabIndex = 2;
            this.nombrelbl.Text = "Nombre";
            // 
            // apellidolbl
            // 
            this.apellidolbl.AutoSize = true;
            this.apellidolbl.Location = new System.Drawing.Point(9, 87);
            this.apellidolbl.Name = "apellidolbl";
            this.apellidolbl.Size = new System.Drawing.Size(47, 13);
            this.apellidolbl.TabIndex = 3;
            this.apellidolbl.Text = "Apellido ";
            // 
            // registrolb
            // 
            this.registrolb.AutoSize = true;
            this.registrolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrolb.Location = new System.Drawing.Point(101, 9);
            this.registrolb.Name = "registrolb";
            this.registrolb.Size = new System.Drawing.Size(146, 29);
            this.registrolb.TabIndex = 4;
            this.registrolb.Text = "REGISTRO";
            // 
            // dnilbl
            // 
            this.dnilbl.AutoSize = true;
            this.dnilbl.Location = new System.Drawing.Point(12, 157);
            this.dnilbl.Name = "dnilbl";
            this.dnilbl.Size = new System.Drawing.Size(26, 13);
            this.dnilbl.TabIndex = 5;
            this.dnilbl.Text = "DNI";
            // 
            // DNItbx
            // 
            this.DNItbx.Location = new System.Drawing.Point(62, 150);
            this.DNItbx.Name = "DNItbx";
            this.DNItbx.Size = new System.Drawing.Size(160, 20);
            this.DNItbx.TabIndex = 6;
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Location = new System.Drawing.Point(12, 123);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(26, 13);
            this.maillbl.TabIndex = 7;
            this.maillbl.Text = "Mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 8;
            // 
            // tellbl
            // 
            this.tellbl.AutoSize = true;
            this.tellbl.Location = new System.Drawing.Point(9, 194);
            this.tellbl.Name = "tellbl";
            this.tellbl.Size = new System.Drawing.Size(100, 13);
            this.tellbl.TabIndex = 9;
            this.tellbl.Text = "Nùmero de teléfono";
            // 
            // teltbx
            // 
            this.teltbx.Location = new System.Drawing.Point(115, 187);
            this.teltbx.Name = "teltbx";
            this.teltbx.Size = new System.Drawing.Size(107, 20);
            this.teltbx.TabIndex = 10;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 292);
            this.Controls.Add(this.teltbx);
            this.Controls.Add(this.tellbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maillbl);
            this.Controls.Add(this.DNItbx);
            this.Controls.Add(this.dnilbl);
            this.Controls.Add(this.registrolb);
            this.Controls.Add(this.apellidolbl);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.apellidotbx);
            this.Controls.Add(this.nombretxb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombretxb;
        private System.Windows.Forms.TextBox apellidotbx;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label apellidolbl;
        private System.Windows.Forms.Label registrolb;
        private System.Windows.Forms.Label dnilbl;
        private System.Windows.Forms.TextBox DNItbx;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tellbl;
        private System.Windows.Forms.TextBox teltbx;
    }
}