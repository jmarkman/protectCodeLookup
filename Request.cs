using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ppcLookupV2
{
    class Request
    {
        private string task, state, county, town;
        private int code;

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
            SqlConnection dbConn;
            dbConn = new SqlConnection("server = reports.li.wkfc.com;" +
                "Trusted_Connection = yes;" +
                "database = WKFC_ADHOC;" +
                "connection timeout = 30"
                );
            dbConn.Open();

            SqlCommand addRequest = new SqlCommand("INSERT INTO ppcRequests (RequestType, RequestState, RequestCounty, RequestTown, RequestCode) VALUES (@RequestType, @RequestState, @RequestCounty, @RequestTown, @RequestCode)", dbConn);
            addRequest


            dbConn.Close();
        }
    }
}
