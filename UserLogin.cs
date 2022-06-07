using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        
        private void butSignIn_Click(object sender, EventArgs e)
        {

            try
            {
                var password = txtPassword.Text;
                

              
                if(UserSignin.Login(password, txtUsername.Text))
                {
                    ProToolsDashBoard pd = new ProToolsDashBoard();
                        pd.Show();
                    txtPassword.Clear();
                    MessageBox.Show("Welcome to Pro Tools!");
                }
                else
                {
                    MessageBox.Show("Wrong Password...Please re-enter password!");
                }
            }
            catch
            {
                MessageBox.Show("Database erroor please contact Pro Tool IT Administrator!");
            }
            

           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
