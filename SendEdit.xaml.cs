using System;
using System.Collections.Generic;
using System.Windows;


namespace ppcLookupV2
{
    public partial class SendEdit : Window
    {
        public SendEdit()
        {
            InitializeComponent();
            // Add user choices to Task Combobox 
            requestCbox.Items.Add("Add New Listing");
            requestCbox.Items.Add("Add Town to Existing County");
            requestCbox.Items.Add("Change Code for Existing Listing");
        }

        private void sendRequest_Click(object sender, RoutedEventArgs e)
        {
            int n; // Declare var "n" for usage in protectCode TryParse statement
            Request edit = new Request(); // Instantiate new Request object

            edit.Task = requestCbox.Text; // get Task
            edit.State = stateBox.Text; // get State
            edit.County = countyBox.Text; // get County
            edit.Town = townBox.Text; // get Town
            // get Code and perform exception handling
            bool protectCode = int.TryParse(codeBox.Text, out n);
            if (protectCode)
            {
                edit.Code = Convert.ToInt32(codeBox.Text);
            }
            else
            {
                validateInput();
            }
            // If green light to proceed
            if (validateInput() == true)
            {
                edit.sendRequest(); // use sendRequest method from Request class
                this.Close(); // close the window
                MessageBox.Show("Request sent successfully!");
            }
            else
            {
                // Throw error in form of message box to end user
                MessageBox.Show(@"Check your inputs! All fields must be filled!
                  - Task type
                  - State
                  - County
                  - Town
                  - Code (between 1 and 10)", "Error");
            }
        }

        // Error checking: this thing needs to be airtight and scream at the slightest
        // incorrect input aka if anything doesn't fit, throw up a message box
        private bool validateInput()
        {
            int n; // var for TryParse
            bool checkTask = requestCbox.SelectedIndex == -1; // Check if Task Combobox has a selection
            bool checkState = string.IsNullOrEmpty(stateBox.Text); // Check if State Textbox is null/empty
            bool checkCounty = string.IsNullOrEmpty(countyBox.Text); // Check if County Textbox is null/empty
            bool checkTown = string.IsNullOrEmpty(townBox.Text); // Check if Town Textbox is null/empty
            bool checkCodeEmpty = string.IsNullOrEmpty(codeBox.Text); // Check if Code Textbox is null/empty
            bool codeIsNumeric = int.TryParse(codeBox.Text, out n); // Check if code in box can be parsed to int
            bool codeInRange = false; // var for valid range of codes

            // Populate a list of "numbers" 
            List<string> validCodes = new List<string>();
            for (int i = 1; i < 11; i++)
            {
                validCodes.Add($"{i}");
            }

            // Check if everything jives in the codeBox and the list of allowed codes
            foreach (string code in validCodes)
            {
                if (code == codeBox.Text)
                {
                    codeInRange = true;
                }
            }
            // Check booleans and return based on conditions
            if (checkTask == true)
                return false;
            else if (checkState == true)
                return false;
            else if (checkCounty == true)
                return false;
            else if (checkTown == true)
                return false;
            else if (checkCodeEmpty == true)
                return false;
            else if (codeIsNumeric == false)
                return false;
            else if (codeInRange == false)
                return false;
            else
                return true;
        }

        // Clicking cancel should just halt the whole shebang
        private void cancelRequest_Click(object sender, RoutedEventArgs e)
        {
            requestCbox.SelectedIndex = -1;
            stateBox.Clear();
            countyBox.Clear();
            townBox.Clear();
            codeBox.Clear();
            this.Close();
        }
    }
}
