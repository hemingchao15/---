using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        static string strConn = "Data Source=(local) ";
        SqlConnection myConn = new SqlConnection(strConn);
        SqlDataAdapter myDataAdapter;
        private void Filldata()
        {
            string strSql = "select * from Bus";
            myDataAdapter = new SqlDataAdapter(strSql, myConn);
            DataSet myDataSet = new DataSet();
            myConn.Open();
            myDataAdapter.Fill(myDataSet, "Bus");
            gvBus.DataSource = myDataSet.Tables["Bus"];
            gvBus.DataBind();
            myConn.Close();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Filldata();
            }
        }
        protected void gvBus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBus.PageIndex = e.NewPageIndex;
            Filldata();

        }

        protected void gvBus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}