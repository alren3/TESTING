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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Authentication_V1.Forms
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }
        private int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("ZNotif").Document(data.Details);
            docRef.SetAsync(data);
            i++;
        }
        private Notif GetWriteData()
        {
            string info = textBox1.Text.Trim();
            string details = dateTimePicker1.Text.Trim();
           
            string number = i.ToString();

            return new Notif()
            {
                Number =number,
                Info = info,
                Details = details,
            };
        }
    }
}
