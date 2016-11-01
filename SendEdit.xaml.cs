using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace ppcLookupV2
{
    /// <summary>
    /// Interaction logic for SendEdit.xaml
    /// </summary>
    public partial class SendEdit : Window
    {
        public SendEdit()
        {
            InitializeComponent();
            requestCbox.Items.Add("Add New Listing");
            requestCbox.Items.Add("Add Town to Existing County");
            requestCbox.Items.Add("Change Code for Existing Listing");
        }

        private void sendRequest_Click(object sender, RoutedEventArgs e)
        {

            Request edit = new Request();         

            try
            {
                edit.Task = requestCbox.Text;
                edit.State = stateBox.Text;
                edit.County = countyBox.Text;
                edit.Town = townBox.Text;
                edit.Code = Convert.ToInt32(codeBox.Text);
                
                edit.sendRequest();
                this.Close();
                MessageBox.Show("Request sent successfully!");
            }
            catch
            {

                int n;
                bool isNumeric = int.TryParse(codeBox.Text, out n);

                if (requestCbox.SelectedIndex == -1)
                    MessageBox.Show("You must select a request type!", "Error");
                else if (string.IsNullOrEmpty(edit.State))
                    MessageBox.Show("Missing state!", "Error");
                else if (string.IsNullOrEmpty(edit.County))
                    MessageBox.Show("Missing county!", "Error");
                else if (string.IsNullOrEmpty(edit.Town))
                    MessageBox.Show("Missing town!", "Error");
                else if (codeBox.Text == "")
                    MessageBox.Show("No code present!", "Error");
                else if (isNumeric == false)
                    MessageBox.Show("A letter was input!", "Error");
                else if (edit.Code > 10 || edit.Code < 1)
                    MessageBox.Show("Code is not valid!", "Error");
                else
                    MessageBox.Show("Error in sending request."
                               + " Please check that all fields"
                               + " are properly filled out.", "Fatal Input Error");
            }
        }

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
