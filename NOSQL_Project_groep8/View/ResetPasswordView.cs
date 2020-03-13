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
            pResetKey.Hide();
            switch (panelName)
            {
                case "pResetKey": pResetKey.Visible = true; break;
                case "pCheckKey": pCheckKey.Visible = true; break;
            }
        }

        public void GoToLogin()
        {
            var index = (Index)this.Parent;
            index.HideViews("UCloginView");
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            resetPasswordController.CheckUserinfo(txtEmail.Text, txtFavColor.Text);
            HidePanels("pCheckKey");
            txtResetKey.Text = string.Empty;
        }

        private void btnCheckKey_Click(object sender, EventArgs e)
        {
            resetPasswordController.CheckKey(txtResetKey.Text, txtKeyEmail.Text);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            resetPasswordController.ChangePassword(txtPassword.Text, txtReEnterPassword.Text, txtKeyEmail.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtKeyEmail.Text = txtEmail.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }
    }
}
