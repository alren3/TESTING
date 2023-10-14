using Authentication_V1.Classes;
using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication_V1.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string institutionalid = idtxtbox.Text.Trim();
            string password = passtxtbox.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(institutionalid);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();
            MessageBox.Show("Success");

            if (data != null)
            {
                if (password == Security.Decrypt(data.Password))
                {
                    if (data.Type == "Security")
                    {
                        // Open the SecurityForm for users with a "type" of security.
                        Securityform securityForm = new Securityform();
                        securityForm.Show();
                    }
                    else if (data.Type == "Admin")
                    {
                        Adminfomr adminform = new Adminfomr();
                        adminform.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Logine Failed");
                }
            }
            else
            {
                MessageBox.Show("Login Failed");

            }
        }
    }
}
