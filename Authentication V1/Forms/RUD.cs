using Authentication_V1.Classes;
using Google.Cloud.Firestore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace Authentication_V1.Forms
{
    public partial class RUD : Form
    {
        private FirestoreDb db;
        private CollectionReference userDataCollection;

        public RUD()
        {
            InitializeComponent();
            LoadUserData();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if there's a selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected user from the selected row
                UserData selectedUser = (UserData)dataGridView1.SelectedRows[0].DataBoundItem;

                // Populate the textboxes with the selected user's data
                idtxtbox.Text = selectedUser.InstitutionalID;
                nametxtbox.Text = selectedUser.Name;
                passtxtbox.Text = selectedUser.Password;
                emailtxtbox.Text = selectedUser.Email;
            }
            else
            {
                // Clear the textboxes if no row is selected
                idtxtbox.Text = "";
                nametxtbox.Text = "";
                passtxtbox.Text = "";
                emailtxtbox.Text = "";
            }
        }
        private async void LoadUserData()
        {
            // Initialize Firestore database reference
            var db = FirestoreHelper.Database;

            // Reference to the "UserData" collection
            CollectionReference userDataCollection = db.Collection("UserData");

            // Create a query to retrieve all users
            QuerySnapshot querySnapshot = await userDataCollection.GetSnapshotAsync();

            // Create a list to store user data
            List<UserData> users = new List<UserData>();

            // Loop through the documents and populate the users list
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                // Convert the document to UserData
                UserData user = documentSnapshot.ConvertTo<UserData>();

                if (user != null)
                {
                    // Decrypt the password before adding it to the list
                    user.Password = Security.Decrypt(user.Password);
                    users.Add(user);
                }
            }

            // Bind the list of users to the DataGridView
            dataGridView1.DataSource = users;

            // Customize the DataGridView columns to display specific properties
            dataGridView1.Columns["Password"].Visible = true; // Make the Password column visible
            dataGridView1.Columns["Email"].DisplayIndex = 0;
            dataGridView1.Columns["InstitutionalID"].DisplayIndex = 1;
            dataGridView1.Columns["Name"].DisplayIndex = 2;
            dataGridView1.Columns["Type"].DisplayIndex = 3;
            dataGridView1.AutoResizeColumns();
        }

        private void Search()
        {
            // Get the search criteria from the textboxes
            string nameToSearch = nametxtbox.Text;
            string idToSearch = idtxtbox.Text;

            // Filter the user data based on the search criteria
            List<UserData> filteredUsers = FilterUsers(nameToSearch, idToSearch);

            dataGridView1.DataSource = filteredUsers;
        }
        private void RUD_Load(object sender, EventArgs e)
        {

        }
        private async void searchbtn_Click(object sender, EventArgs e)
        {
   
            if (checkBox1.Checked)
            {
                Search();
            }
            else
            {
                LoadUserData();
            }
        }
        private List<UserData> FilterUsers(string nameToSearch, string idToSearch)
        {
            // Get the original list of users from the DataGridView's data source
            List<UserData> originalUsers = dataGridView1.DataSource as List<UserData>;

            if (originalUsers == null)
            {
                return new List<UserData>(); // Return an empty list if there's no data source
            }

            // Use LINQ to filter the users based on the search criteria
            var filteredUsers = originalUsers.Where(user =>
                (string.IsNullOrEmpty(nameToSearch) || user.Name.Contains(nameToSearch, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(idToSearch) || user.InstitutionalID.Contains(idToSearch, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            return filteredUsers;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }
        private void nametxtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void nametxtbox_MouseEnter(object sender, EventArgs e)
        {

        }

        private void nametxtbox_MouseHover(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void nametxtbox_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
