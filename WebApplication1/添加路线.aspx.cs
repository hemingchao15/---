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
    public partial class Add : System.Web.UI.Page
    {
        static string strConn = "Data Source=(local); Initial Catalog=Bus; User ID=sa; pwd =1 ";
        SqlConnection myConn = new SqlConnection(strConn);
        SqlCommand myComm;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnPost_Click(object sender, EventArgs e)
        {
            string postCommand = "Insert Into " +//向表格中插入新的行
                 "Bus(BusID,BeginStation,EndStation,ServiceTime,Description)" +
                 "values(@BusID,@BeginStation,@EndStation,@ServiceTime,@Description)";
            myComm = new SqlCommand(postCommand, myConn);
            myConn.Open();
            myComm.Parameters.Add("@BusID", SqlDbType.VarChar, 10);
            myComm.Parameters.Add("@BeginStation", SqlDbType.VarChar, 20);
            myComm.Parameters.Add("@EndStation", SqlDbType.VarChar, 20);
            myComm.Parameters.Add("@ServiceTime", SqlDbType.VarChar, 20);
            myComm.Parameters.Add("@Description", SqlDbType.VarChar, 50);//添加数据
            myComm.Parameters["@BusID"].Value = BusID.Text.Trim();
            myComm.Parameters["@BeginStation"].Value = BeginStation.Text.Trim();
            myComm.Parameters["@EndStation"].Value = EndStation.Text.Trim();
            myComm.Parameters["@ServiceTime"].Value = ServiceTime.Text.Trim();
            myComm.Parameters["@Description"].Value = Description.Text.Trim();
            myComm.ExecuteNonQuery();
            myConn.Close();
            Response.Redirect("首页.aspx");

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("首页.aspx");
        }    
    }
}