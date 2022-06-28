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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.apellidolbl = new System.Windows.Forms.Label();
            this.registrolb = new System.Windows.Forms.Label();
            this.dnilbl = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.maillbl = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.tellbl = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(62, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
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
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(62, 150);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(160, 20);
            this.txtDNI.TabIndex = 6;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
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
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(62, 120);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 20);
            this.txtMail.TabIndex = 8;
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
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(115, 187);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(107, 20);
            this.txtTel.TabIndex = 10;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 292);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.tellbl);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.maillbl);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.dnilbl);
            this.Controls.Add(this.registrolb);
            this.Controls.Add(this.apellidolbl);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label apellidolbl;
        private System.Windows.Forms.Label registrolb;
        private System.Windows.Forms.Label dnilbl;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label tellbl;
        private System.Windows.Forms.TextBox txtTel;
    }
}