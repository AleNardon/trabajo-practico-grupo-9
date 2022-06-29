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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 113);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(82, 147);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Location = new System.Drawing.Point(12, 116);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(47, 13);
            this.nombrelbl.TabIndex = 2;
            this.nombrelbl.Text = "Nombre:";
            // 
            // apellidolbl
            // 
            this.apellidolbl.AutoSize = true;
            this.apellidolbl.Location = new System.Drawing.Point(12, 149);
            this.apellidolbl.Name = "apellidolbl";
            this.apellidolbl.Size = new System.Drawing.Size(47, 13);
            this.apellidolbl.TabIndex = 3;
            this.apellidolbl.Text = "Apellido:";
            // 
            // registrolb
            // 
            this.registrolb.AutoSize = true;
            this.registrolb.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrolb.Location = new System.Drawing.Point(51, 28);
            this.registrolb.Name = "registrolb";
            this.registrolb.Size = new System.Drawing.Size(186, 39);
            this.registrolb.TabIndex = 4;
            this.registrolb.Text = "Registrarse";
            // 
            // dnilbl
            // 
            this.dnilbl.AutoSize = true;
            this.dnilbl.Location = new System.Drawing.Point(12, 253);
            this.dnilbl.Name = "dnilbl";
            this.dnilbl.Size = new System.Drawing.Size(29, 13);
            this.dnilbl.TabIndex = 5;
            this.dnilbl.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(82, 246);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(155, 20);
            this.txtDNI.TabIndex = 6;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Location = new System.Drawing.Point(12, 186);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(35, 13);
            this.maillbl.TabIndex = 7;
            this.maillbl.Text = "Email:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(82, 183);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(155, 20);
            this.txtMail.TabIndex = 8;
            // 
            // tellbl
            // 
            this.tellbl.AutoSize = true;
            this.tellbl.Location = new System.Drawing.Point(12, 286);
            this.tellbl.Name = "tellbl";
            this.tellbl.Size = new System.Drawing.Size(52, 13);
            this.tellbl.TabIndex = 9;
            this.tellbl.Text = "Télefono:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(82, 279);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(155, 20);
            this.txtTel.TabIndex = 10;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(18, 325);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 43);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(309, 144);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(173, 23);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Iniciar Sesión";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Si ya tiene una cuenta, inicie sesión";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(82, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(155, 23);
            this.txtPassword.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnRegister);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
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
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
    }
}