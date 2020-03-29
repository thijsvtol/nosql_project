using System;
using System.Windows.Forms;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8.View
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                cbRememberMe.Checked = true;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();

            String username = txtUsername.Text;
            string password = txtPassword.Text;

            if (cbRememberMe.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            var index = (Index)this.Parent;
            loginController.CheckLogin(index, index.GetDashboard(), username, password);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var index = (Index)this.Parent;
            index.HideViews("UCResetPasswordView");
        }
    }
}