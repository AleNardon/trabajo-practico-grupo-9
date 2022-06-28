using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            this.Hide();

            logInForm.ShowDialog();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();

            RegisterForm.ShowDialog();
            this.Show();
        }
    }
}
