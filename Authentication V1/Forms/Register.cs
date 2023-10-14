using Authentication_V1.Classes;
using Google.Cloud.Firestore;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Login form = new Login();
            form.ShowDialog();
            Close();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;

            if (CheckifUserAlreadyExist())
            {
                MessageBox.Show("User Already Exist");
                return;
            }

            var data = GetWriteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.InstitutionalID);
            docRef.SetAsync(data);

        }

        //FUNCTIONS:
        private UserData GetWriteData()
        {

            string name = nametxtbox.Text.Trim();
            string institutionalid = idtxtbox.Text.Trim();
            string password = Security.Encrypt(passtxtbox.Text);
            string email = emailtxtbox.Text.Trim();
            string type = usercombobox.Text.Trim();

            return new UserData()
            {
                Name = name,
                InstitutionalID = institutionalid,
                Password = password,
                Email = email,
                Type = type

            };

        }

        private bool CheckifUserAlreadyExist()
        {
            string institutionalid = idtxtbox.Text.Trim();
            string password = passtxtbox.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(institutionalid);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();
            MessageBox.Show("Success");

            if (data != null)
            {
                return true;

            }
            return false;

        }
    }
}
