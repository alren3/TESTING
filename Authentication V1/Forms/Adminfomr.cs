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
    public partial class Adminfomr : Form
    {
        public Adminfomr()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();
            Close();
        }

        private void OpenRUD_Click(object sender, EventArgs e)
        {
            RUD form = new RUD();
            form.ShowDialog();
            Close();
        }
    }

}
