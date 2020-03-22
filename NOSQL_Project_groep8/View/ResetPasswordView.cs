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

        /// <summary>
        /// hide the panels that do not need to be seen
        /// </summary>
        /// <param name="panelName"></param>
        public void HidePanels(string panelName)
        {
            //hide all panels
            pCheckKey.Hide();
            pResetKey.Hide();
            //unhide the panel dat needs to be visable
            switch (panelName)
            {
                case "pResetKey": pResetKey.Visible = true; break;
                case "pCheckKey": pCheckKey.Visible = true; break;
            }
        }

        /// <summary>
        /// return to login
        /// </summary>
        public void GoToLogin()
        {
            var index = (Index)this.Parent;
            index.HideViews("UCloginView");
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            //checks user info and send mail if the info is correct
            resetPasswordController.CheckUserinfo(txtEmail.Text, txtFavColor.Text);
            HidePanels("pCheckKey");
            txtResetKey.Text = string.Empty;
        }

        private void btnCheckKey_Click(object sender, EventArgs e)
        {
            //checks if the key ande the email equal the ones in the db
            resetPasswordController.CheckKey(txtResetKey.Text, txtKeyEmail.Text);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            // changes the password to the new given password
            resetPasswordController.ChangePassword(txtPassword.Text, txtReEnterPassword.Text, txtKeyEmail.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtKeyEmail.Text = txtEmail.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // go back to login
            GoToLogin();
        }
    }
}
