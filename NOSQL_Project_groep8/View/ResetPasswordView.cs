using NOSQL_Project_groep8.Controller;
using System;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.View
{
    public partial class ResetPasswordView : UserControl
    {
        ResetPasswordController resetPasswordController;

        public ResetPasswordView()
        {
            InitializeComponent();
            resetPasswordController = new ResetPasswordController(this);
        }

        public void HidePanels(string panelName)
        {
            pCheckKey.Hide();
            switch (panelName)
            {
                case "pResetKey": pResetKey.Visible = true; break;
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            resetPasswordController.SentMail(txtEmail.Text);
        }

        private void btnCheckKey_Click(object sender, EventArgs e)
        {
            resetPasswordController.CheckKey(txtResetKey.Text);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            resetPasswordController.ChangePassword(txtPassword.Text, txtReEnterPassword.Text);
        }
    }
}
