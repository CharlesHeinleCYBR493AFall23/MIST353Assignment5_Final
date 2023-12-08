using CharlesHeinle_Assignment4;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharlesHeinle_Assignment4
{
    public partial class ResearchAreas : System.Web.UI.Page
    {
        public DataTable GetDataFromDatabase()
        {
            DataTable dt = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["CitizenScienceDB"].ToString();
            string idValue = Request.QueryString["InstituitonID"];

            if (!string.IsNullOrEmpty(idValue))
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "EXEC spGetAllResearchAreasByInstitutionID @InstitutionID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("InstitutionID", idValue);
                        cmd.ExecuteNonQuery();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            else 
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "Exec spGetAllResearchAreas";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            return dt;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ResearchArea.DataSource = GetDataFromDatabase();
            ResearchArea.DataBind();
        }
    }
}