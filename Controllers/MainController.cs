using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using System.Web.Http;
using SOViewer3.Models;
using System.Data.SqlClient;
namespace SOViewer3.Controllers
{
    
    public class MainController : ApiController
    {
        private JobHeaderContext jb = new JobHeaderContext();

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this.jb.Dispose();
            }
            base.Dispose(disposing);
        }
        /* This method retrieves a data information for each sales order to be viewed by User front end
        private async Task<JobHeaderDataModel> SalesOrder(string SalesOrderNumber)
        {
            //DataSet Result = new DataSet();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=PCIDB1;" +
                                    "Initial Catalog=SPECs3DB;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;" +
                                    "Password = S1t2a3r4;" +
                                    "MultipleActiveResultSets = True;" +
                                    "App = EntityFramework & quot;";
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            */
        /****** Script for SelectTopNRows command from SSMS  ******/
        /*
        cmd.CommandText = "SELECT * FROM dbo.JobHeader where ReferenceNo = '" + SalesOrderNumber + "'";
        //cmd.CommandText = "SELECT ReferenceNo,CustomerQuoteNo,SelltoCustomerNo FROM JobHeader where ReferenceNo = '264322'";
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.Connection = connection;
        reader = cmd.ExecuteReader();
        JobHeaderDataModel model = new JobHeaderDataModel();
        while (reader.Read())
        {
            var jobheader = new JobHeaderDataModel();
            jobheader.ReferenceNo = reader["ReferenceNo"].ToString();
            jobheader.CustomerQuoteNo = reader["CustomerQuoteNo"].ToString();
            jobheader.SelltoCustomerNo = reader["SelltoCustomerNo"].ToString();
            model= jobheader;
        }
        connection.Close();
        return model;
    }
    private async Task<IHttpActionResult> Get(string SO)
    {
        JobHeaderDataModel nextJOB = await this.SalesOrder(SO);
        if(nextJOB == null)
        {
            return this.NotFound();
        }
        return this.Ok(nextJOB);
    }
    */
        //private async Task<IHttpActionResult> Post(JobHeaderDataModel thisjob)
        //{
        //    var isFound = await this.
        //    return this.Ok<bool>(isFound);
        //}
    }
}
