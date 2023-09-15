using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSVFileEditor {
    public partial class Form1 : Form {
        private string filePath = @"..\..\people.csv";
        public Form1() {
            InitializeComponent();
        }


        private void btn_read_file_Click(object sender, EventArgs e) {
            lbx_people.Items.Clear();
            lbx_people.Items.Add("Reading data from csv file...");

            UpdateListBox();
            ClearAndFocusFields();
        }

        private void btn_save_file_Click(object sender, EventArgs e) {

            string name = tbx_name.Text;
            string email = tbx_email.Text;

            if (!IsValidInput(name, email)) {
                return;
            }

            using (StreamWriter sw = new StreamWriter(filePath, true)) {
                sw.WriteLine($"{name};{email}");
            }

            // Update the ListBox with the data from the CSV file
            UpdateListBox();

            MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the text boxes and set the focus back to the tbx_name text box
            ClearAndFocusFields();
        }

        private void UpdateListBox() {
            bool FileExists = File.Exists(filePath);
            // Clear the ListBox
            lbx_people.Items.Clear();

            // Check if the file exists before trying to read from it
            if (FileExists) {
                using (StreamReader sr = new StreamReader(filePath)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        lbx_people.Items.Add(line);
                    }
                }
            }
        }

        private void ClearAndFocusFields() {
            tbx_name.Text = string.Empty;
            tbx_email.Text = string.Empty;
            tbx_name.Focus();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Update the ListBox with the data from the CSV file
            UpdateListBox();

            // Clear the text boxes and set the focus back to the tbx_name text box
            ClearAndFocusFields();
        }

        private bool IsValidEmail(string email) {
            try {
                if (string.IsNullOrWhiteSpace(email))
                    return false;
                string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch {
                return false;
            }
        }


        private bool IsValidInput(string name, string email) {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email)) {
                MessageBox.Show("Name and Email cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate the email format
            if (!IsValidEmail(email)) {
                MessageBox.Show("Invalid email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
