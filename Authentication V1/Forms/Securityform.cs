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
using System;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Authentication_V1.Classes;
namespace Authentication_V1.Forms
{
    public partial class Securityform : Form
    {
        private FirestoreDb db;
        private DocumentReference mainParkingDocRef;

        public Securityform()
        {
            InitializeComponent();
            InitializeFirestore();
            InitializeMainParkingData();
            InitializeRealtimeListener();
            InitializeTimer();
        }

        private void InitializeFirestore()
        {
            string projectId = "authentication-v1-4e63f";

            FirestoreDbBuilder builder = new FirestoreDbBuilder
            {
                ProjectId = projectId,
            };

            db = builder.Build();
        }

        private async Task InitializeMainParkingData()
        {
            // Reference to the "OverallData" collection
            CollectionReference overallDataCollection = db.Collection("OverallData");

            // Reference to the "MainParking" document
            mainParkingDocRef = overallDataCollection.Document("MainParking");

            // Check if the document already exists
            DocumentSnapshot snapshot = await mainParkingDocRef.GetSnapshotAsync();

            if (!snapshot.Exists)
            {
                // Document doesn't exist, create it with an initial value of 0
                var data = new { value = 0 };

                await mainParkingDocRef.SetAsync(data);
            }
        }
        private async void InitializeRealtimeListener()
        {
            // Initialize the "MainParking" document
            await InitializeMainParkingData();

            // Create a real-time listener for the "MainParking" document
            mainParkingDocRef.Listen(async (snapshot, _) =>
            {
                if (snapshot.Exists)
                {
                    // Get the current value
                    int currentValue = snapshot.GetValue<int>("value");

                    // Update the UI with the current value
                    UpdateTextBoxValue(currentValue);
                }
                else
                {
                    // Handle the case where the document no longer exists
                    // You can set a default value or display an error message
                }
            });
        }
        private void InitializeTimer()
        {
            // Create a timer with a 2-second interval (adjust as needed)
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            // Retrieve the current MainParking value from the database
            DocumentSnapshot snapshot = await mainParkingDocRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                // Get the current value
                int currentValue = snapshot.GetValue<int>("value");

                // Update the UI with the current value
                UpdateTextBoxValue(currentValue);
            }
        }
        private void UpdateTextBoxValue(int currentValue)
        {
            int maximumCapacity = 5; // Change this to your maximum capacity
            string text = $"{currentValue}/{maximumCapacity}";
            textBoxMainParkingValue.Text = text;
        }



        private async void addBtn_Click(object sender, EventArgs e)
        {
            // Initialize the "MainParking" document
            await InitializeMainParkingData();

            // Retrieve the current MainParking value from the database
            DocumentSnapshot snapshot = await mainParkingDocRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                // Get the current value
                int currentValue = snapshot.GetValue<int>("value");

                if (currentValue < 5)
                {
                    // Increment the value by 1, but make sure it doesn't exceed 5
                    int newValue = currentValue + 1;

                    // Update the value in the database
                    await mainParkingDocRef.SetAsync(new { value = newValue });
                    MessageBox.Show("1 vehicle added to the Main Parking Area.");
                }
                else
                {
                    MessageBox.Show("Main Parking area cannot exceed 5 vehicles.");
                }
            }
            else
            {
                MessageBox.Show("Main Parking data not found.");
            }
        }


        private async void removeBtn_Click(object sender, EventArgs e)
        {
            // Initialize the "MainParking" document
            await InitializeMainParkingData();

            // Retrieve the current MainParking value from the database
            DocumentSnapshot snapshot = await mainParkingDocRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                // Get the current value
                int currentValue = snapshot.GetValue<int>("value");

                if (currentValue > 0)
                {
                    // Decrement the value by 1, but make sure it doesn't go below 0
                    int newValue = currentValue - 1;

                    // Update the value in the database
                    await mainParkingDocRef.SetAsync(new { value = newValue });
                    MessageBox.Show("1 deducted from the MainParking value.");
                }
                else
                {
                    MessageBox.Show("MainParking value cannot go below 0.");
                }
            }
            else
            {
                MessageBox.Show("MainParking data not found.");
            }
        }
    }
}
