﻿namespace Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblArroba = new System.Windows.Forms.Label();
            this.lblPunto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(18, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(315, 26);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(18, 159);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(315, 26);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrelbl.Location = new System.Drawing.Point(15, 86);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(62, 17);
            this.nombrelbl.TabIndex = 2;
            this.nombrelbl.Text = "Nombre:";
            // 
            // apellidolbl
            // 
            this.apellidolbl.AutoSize = true;
            this.apellidolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidolbl.Location = new System.Drawing.Point(15, 138);
            this.apellidolbl.Name = "apellidolbl";
            this.apellidolbl.Size = new System.Drawing.Size(62, 17);
            this.apellidolbl.TabIndex = 3;
            this.apellidolbl.Text = "Apellido:";
            // 
            // registrolb
            // 
            this.registrolb.AutoSize = true;
            this.registrolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrolb.Location = new System.Drawing.Point(83, 25);
            this.registrolb.Name = "registrolb";
            this.registrolb.Size = new System.Drawing.Size(231, 36);
            this.registrolb.TabIndex = 4;
            this.registrolb.Text = "REGISTRARSE";
            // 
            // dnilbl
            // 
            this.dnilbl.AutoSize = true;
            this.dnilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnilbl.Location = new System.Drawing.Point(18, 351);
            this.dnilbl.Name = "dnilbl";
            this.dnilbl.Size = new System.Drawing.Size(35, 17);
            this.dnilbl.TabIndex = 5;
            this.dnilbl.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.White;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(21, 371);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(315, 26);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maillbl.Location = new System.Drawing.Point(15, 191);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(46, 17);
            this.maillbl.TabIndex = 7;
            this.maillbl.Text = "Email:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(18, 213);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(315, 26);
            this.txtMail.TabIndex = 2;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // tellbl
            // 
            this.tellbl.AutoSize = true;
            this.tellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellbl.Location = new System.Drawing.Point(18, 404);
            this.tellbl.Name = "tellbl";
            this.tellbl.Size = new System.Drawing.Size(68, 17);
            this.tellbl.TabIndex = 9;
            this.tellbl.Text = "Télefono:";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(21, 425);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(315, 26);
            this.txtTel.TabIndex = 5;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Navy;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(12, 556);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 33);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Navy;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(18, 495);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(121, 23);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Iniciar Sesión";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Si ya tiene una cuenta, inicie sesión";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(21, 322);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(315, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(175, 558);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblArroba
            // 
            this.lblArroba.AutoSize = true;
            this.lblArroba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArroba.ForeColor = System.Drawing.Color.Red;
            this.lblArroba.Location = new System.Drawing.Point(18, 255);
            this.lblArroba.Name = "lblArroba";
            this.lblArroba.Size = new System.Drawing.Size(102, 17);
            this.lblArroba.TabIndex = 16;
            this.lblArroba.Text = "No contiene @";
            // 
            // lblPunto
            // 
            this.lblPunto.AutoSize = true;
            this.lblPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunto.ForeColor = System.Drawing.Color.Red;
            this.lblPunto.Location = new System.Drawing.Point(128, 255);
            this.lblPunto.Name = "lblPunto";
            this.lblPunto.Size = new System.Drawing.Size(124, 17);
            this.lblPunto.TabIndex = 17;
            this.lblPunto.Text = "No contiene punto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "* Ejemplo de mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ejemplo@ejemplohost.com";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(447, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPunto);
            this.Controls.Add(this.lblArroba);
            this.Controls.Add(this.btnCancelar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblArroba;
        private System.Windows.Forms.Label lblPunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}