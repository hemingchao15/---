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
    public partial class Search : System.Web.UI.Page
    {

        static string strConn = "Data Source=(local); Initial Catalog=Bus; User ID=sa; pwd =1 ";
        SqlConnection myConn = new SqlConnection(strConn);
        SqlDataAdapter myDataAdapter;
        private void Filldata()
        {
            string strConn = "select * from Bus where";
            if (CheckBox1.Checked && TextBox1.Text.Trim() != string.Empty)
            {
                strConn = strConn + "BeginStation=" + TextBox1.Text.Trim() + "or";
            }
            if (CheckBox2.Checked && TextBox2.Text.Trim() != string.Empty)
            {
                strConn = strConn + "EndStation=" + TextBox2.Text.Trim() + "or";
            }
            strConn= strConn . Substring(0,strConn. Length - 5);
            myDataAdapter = new SqlDataAdapter(strConn, myConn);
            DataSet myDataSet = new DataSet();
            myConn.Open();
            myDataAdapter.Fill(myDataSet, "Bus");
            gvBus.DataSource = myDataSet.Tables["Bus"];
            gvBus.DataBind();
            myConn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
            {
                Filldata();
            }
        }

        protected void gvBus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBus.PageIndex = e.NewPageIndex;
            Filldata();
        }

       
        
        protected void ImageButton1_Click1(object sender, EventArgs e)
        {

            string strConn = "select * from Bus where";
            if (CheckBox1.Checked && TextBox1.Text.Trim() != string.Empty)
            {
                strConn += " BeginStation ='" + TextBox1.Text.Trim() + "' and  ";
            }
            else if (CheckBox2.Checked && TextBox2.Text.Trim() != string.Empty)
            {
                strConn += " EndStation ='" + TextBox2.Text.Trim() + "' and  ";
            }
            strConn = strConn.Substring(0, strConn.Length - 6);
            DataSet ds = new DataSet();
            myDataAdapter = new SqlDataAdapter(strConn, myConn);
            myDataAdapter.Fill(ds, "Bus");
            gvBus.DataSource = ds.Tables["Bus"];
            gvBus.DataBind();
            myConn.Close();
        }

       
    }
}