using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace ppcLookupV2
{
    class Request
    {
        // Instance variables
        private string task, state, county, town;
        private int code;

        // Constructor
        public Request()
        {
            task = "";
            state = "";
            county = "";
            town = "";
            code = 0;
        }

        public void sendRequest()
        {
            // Connect to the database with the supplied information
            using (SqlConnection dbConn = new SqlConnection(
                "server = reports.li.wkfc.com;" +
                "Trusted_Connection = yes;" +
                "database = WKFC_ADHOC;" +
                "connection timeout = 30"
                ))
            {
                dbConn.Open();

                // Set up the command for inserting new records
                string cmdString =
                    "INSERT INTO dbo.ppcRequests (RequestType, RequestState, RequestCounty, RequestTown, RequestCode) VALUES (@Type, @State, @County, @Town, @Code)";
                try
                {
                    using (SqlCommand command = new SqlCommand(cmdString, dbConn))
                    {
                        // Pass the command above into an instance of the SqlCommand class,
                        // and hook up the values to the variables
                        command.Parameters.Add(new SqlParameter("@Type", task));
                        command.Parameters.Add(new SqlParameter("@State", state));
                        command.Parameters.Add(new SqlParameter("@County", county));
                        command.Parameters.Add(new SqlParameter("@Town", town));
                        command.Parameters.Add(new SqlParameter("@Code", code));
                        command.CommandType = System.Data.CommandType.Text;

                        // Send the query
                        command.ExecuteNonQuery();
                    }
                }
                // Watch out for people who don't input any information and just hit "send"
                catch (SqlException e)
                {
                    MessageBox.Show(Convert.ToString(e));
                }
            }
        }


        public String Task
        {
            get { return task; }
            set { this.task = value; }
        }

        public String State
        {
            get { return state; }
            set { this.state = value; }
        }

        public String County
        {
            get { return county; }
            set { this.county = value; }
        }

        public String Town
        {
            get { return town; }
            set { this.town = value; }
        }

        public int Code
        {
            get { return code; }
            set { this.code = value; }
        }
    }
}
