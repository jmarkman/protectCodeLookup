using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using ppcLookupV2;

namespace ppcLookup
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stateBox_Load();
        }

        private void stateBox_Load()
        {
            /*
             * Make two lists: one that stores all of the results of the database query,
             * and another that is associated with the stateBox combobox as its data source.
             */
            List<string> stateTransfer = new List<string>();
            stateBox.ItemsSource = new List<string>();

            // Open the database connection, send the query, and fill stateTransfer with the results
            SqlConnection dbConn;
            dbConn = new SqlConnection("server = reports.li.wkfc.com;" +
                "Trusted_Connection = yes;" +
                "database = WKFC_ADHOC;" +
                "connection timeout = 30"
                );
            dbConn.Open();

            string getState = "select stateid from states";
            SqlCommand searchState = new SqlCommand(getState, dbConn);

            SqlDataReader returnState = searchState.ExecuteReader();
            while (returnState.Read())
            {
                stateTransfer.Add(Convert.ToString(returnState["stateid"]));
            }

            stateBox.ItemsSource = stateTransfer;

            dbConn.Close();
            // We're finished accessing the database, so close the connection
        }

        private void stateBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Need to cast an object to a string so the next query can be sent
            string selectedState = stateBox.SelectedItem.ToString();
            countyBox_Load(selectedState);
        }

        private void countyBox_Load(string state)
        {
            // Same as the state query
            List<string> countyTransfer = new List<string>();
            countyBox.ItemsSource = new List<string>();

            SqlConnection dbConn;
            dbConn = new SqlConnection("server = reports.li.wkfc.com;" +
                "Trusted_Connection = yes;" +
                "database = WKFC_ADHOC;" +
                "connection timeout = 30"
                );
            dbConn.Open();

            string getCounty = $"select name from counties where stateid = '{state}'";
            SqlCommand searchCounty = new SqlCommand(getCounty, dbConn);

            SqlDataReader returnCounty = searchCounty.ExecuteReader();
            while (returnCounty.Read())
            {
                countyTransfer.Add(Convert.ToString(returnCounty["name"]));
            }

            countyBox.ItemsSource = countyTransfer;

            dbConn.Close();
        }

        private void countyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
             * Had a little trouble around here, might want to watch this section.
             * This used to throw a NullRef exception and I couldn't find anything
             * on the internet to solve it. The if statement used to just be 
             * townList_Load(selectedCounty).
             * 
             * A friend of a friend provided the following fix. "When the state selection 
             * attempts to update the county box, it causes the selection to go to null."
             * 
             * He made use of the null-conditional operator: 
             * https://msdn.microsoft.com/en-us/library/dn986595.aspx
             * "... will cause the evaluation of the expression to short circuit and return null 
             * if the left operand is null (SelectedItem) preventing the invoke of a method on a 
             * null object (ToString()).
            */
            string selectedCounty = countyBox.SelectedItem?.ToString();
            string selectedState = stateBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedCounty))
            {
                townList_Load(selectedCounty, selectedState);
            }
        }

        private void townList_Load(string county, string state)
        {
            // Same as the state query for the most part until...
            ObservableCollection<string> townTransfer = new ObservableCollection<string>();
            townList.ItemsSource = new List<string>();

            SqlConnection dbConn;
            dbConn = new SqlConnection("server = reports.li.wkfc.com;" +
                "Trusted_Connection = yes;" +
                "database = WKFC_ADHOC;" +
                "connection timeout = 30"
                );
            dbConn.Open();

            string getTown = $"select town, code from towns where countyid = '{county}' and stateid = '{state}'";
            SqlCommand searchTown = new SqlCommand(getTown, dbConn);

            SqlDataReader returnTown = searchTown.ExecuteReader();
            while (returnTown.Read())
            {
                // This is longer than the other database reads because it's formatting the town results.
                townTransfer.Add($"{returnTown["town"].ToString().PadRight(35)} Protect Code: {returnTown["code"].ToString()}");
            }

            townList.ItemsSource = townTransfer;
            searchTowns = townTransfer;

            dbConn.Close();
        }

        public ObservableCollection<string> searchTowns = new ObservableCollection<string>();

        private void townList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selected = townList.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
            {
                townList.SelectedIndex = -1;
                return;
            }
            string output = Char.ToString(selected[selected.Length - 1]);
            /* We're storing the user's town selection in "selected"
             * and we're trimming everything but the number. This
             * could probably be redone with a DataGrid but all
             * the user wants is the number.
             * 
             * There was a bug where a user, if they selected a town and
             * then went to go change the state or county, would produce
             * a NullReferenceException in the exact manner that the 
             * countyBox_SelectionChanged event did; I repurposed the code
             * there for a fix  here
             */

            if (output == "0")
            {
                string temp1 = Char.ToString(selected[selected.Length - 2]);
                string temp2 = Char.ToString(selected[selected.Length - 1]);
                output = temp1 + temp2;
            }
            /*
             * Since none of the protection codes go above 10 but include 10,
             * if output = 0, make sure that we get the "1" preceeding it
             * so we have the full "10"
             */

            MessageBox.Show("Copied!");
            Clipboard.SetText(output);
        }

        private void townFilter_TextChanged(object sender, EventArgs e)
        {
            ObservableCollection<string> townSearch = new ObservableCollection<string>();

            townSearch.Clear();
            townList.ItemsSource = townSearch;

            foreach (string str in searchTowns)
            {
                if (str.StartsWith(townFilter.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    townSearch.Add(str);
                }
            }
        }

        private void requestEdit_Click(object sender, RoutedEventArgs e)
        {
            SendEdit request = new SendEdit();
            request.Show();
        }
    }
}