using Microsoft.AspNet.Identity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharlesHeinle_Assignment4
{
    public partial class ObservationSumbissions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowObservations();
        }

        protected void ShowObservations()
        {
            if (User.Identity.IsAuthenticated)
            {
                Observations.Visible = true;
            }
            else
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }
        protected void AddObservation()
        {
            string userID = HttpContext.Current.User.Identity.GetUserId();
            if (userID == null)
            {
                string connString = ConfigurationManager.ConnectionStrings["CitizenScienceDB"].ToString();
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string mycommand = "insert into observations"; 
                    using (SqlCommand cmd = new SqlCommand(mycommand, conn))
                    {
                      

                    }
                }
            }
        }


        public void Create_Click(Object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                AddObservation();
                Response.Redirect("Observations.aspx");
            }
        }

        private void AddObservation2()
        {
            throw new NotImplementedException();
        }
    }
}