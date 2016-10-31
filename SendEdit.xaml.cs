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
            requestCbox.Items.Add("Add Town");
            requestCbox.Items.Add("Change Code");
        }

        private void sendRequest_Click(object sender, RoutedEventArgs e)
        {
            // request.Text, stateBox.Text, countyBox.Text, townBox.Text, Convert.ToInt32(codeBox.Text)
            Request edit = new Request();

            if (requestCbox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a request type!");
            }
            else
            {
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
                    MessageBox.Show("Error!");
                }
            }



            

        }
    }
}
