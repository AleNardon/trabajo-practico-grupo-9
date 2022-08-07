namespace Vista
{
    partial class PDF
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
            this.btnGenTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenTicket
            // 
            this.btnGenTicket.Location = new System.Drawing.Point(247, 237);
            this.btnGenTicket.Name = "btnGenTicket";
            this.btnGenTicket.Size = new System.Drawing.Size(231, 45);
            this.btnGenTicket.TabIndex = 0;
            this.btnGenTicket.Text = "Generar ticket";
            this.btnGenTicket.UseVisualStyleBackColor = true;
            this.btnGenTicket.Click += new System.EventHandler(this.btnGenTicket_Click);
            // 
            // PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenTicket);
            this.Name = "PDF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenTicket;
    }
}