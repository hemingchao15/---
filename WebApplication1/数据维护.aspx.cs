using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class Edit : System.Web.UI.Page
    {
        static string strConn = "Data Source=(local); Initial Catalog=Bus; User ID=sa; pwd =1 ";
        SqlConnection myConn = new SqlConnection(strConn);
        SqlDataAdapter myDataAdapter;
        private void FillData()
        {
            string selectCommand = "Select * From Bus";
            myDataAdapter = new SqlDataAdapter(selectCommand, strConn);
            DataSet ds = new DataSet();
            myConn.Open();
            myDataAdapter.Fill(ds, "Bus");
            gvBus.DataSource = ds.Tables["Bus"];
            gvBus.DataBind();
            myConn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }

        protected void gvBus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBus.PageIndex = e.NewPageIndex;
            FillData();
        }

        protected void gvBus_RowDeleting(object sender, GridViewDeleteEventArgs e)//点击删除，实现对数据库内容的删除
        {
            int id = Convert.ToInt32(gvBus.DataKeys[e.RowIndex].Value.ToString());
            gvBus.EditIndex = -1;
            myConn.Open();
            string selectcommand = "select * from Bus";//查询数据库
            myDataAdapter = new SqlDataAdapter(selectcommand, myConn);
            DataSet ds = new DataSet();//确定内容，更新数据
            myDataAdapter.Fill(ds, "Bus");
            myConn.Close();
            DataTable dt = ds.Tables["Bus"];//数据集
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };//确定数据库主键
            DataRow dr = dt.Rows.Find(id);
            dr.Delete();
            SqlCommandBuilder myCB = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(ds.Tables["Bus"]);//使用DataAdapter对象的Update（）方法将更新的数据提交到数据库
            FillData();
        }

        protected void gvBus_RowUpdating(object sender, GridViewUpdateEventArgs e)//点击编辑，实现对数据库内容的添加。更新。查询。
        {
            int id = Convert.ToInt32(gvBus.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtBusID = (TextBox)gvBus.Rows[e.RowIndex].Cells[0].Controls[0];//在GV控件中生成TextBox，可向TextBox中的内容进行添加，删除
            TextBox txtBeginStation = (TextBox)gvBus.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txtEndStation = (TextBox)gvBus.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox txtServiceTime = (TextBox)gvBus.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox txtDescription = (TextBox)gvBus.Rows[e.RowIndex].Cells[4].Controls[0];
            string busID = txtBusID.Text;//确定更改内容的名称
            string beginStation = txtBeginStation.Text;
            string endStation = txtEndStation.Text;
            string serviceTime = txtServiceTime.Text;
            string description = txtDescription.Text;
            gvBus.EditIndex = -1;
            myConn.Open();
            string selectcommand = "select * From Bus";//查询数据库
            myDataAdapter = new SqlDataAdapter(selectcommand, myConn);//将更改的内容同步更新到数据库
            DataSet ds = new DataSet();//确定内容，更新数据
            myDataAdapter.Fill(ds, "Bus");
            DataTable dt = ds.Tables["Bus"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };//确定数据库主键
            DataRow dr = dt.Rows.Find(id);
            dr["BusID"] = busID;//将已经更新内容，显示到该名称控件下
            dr["BeginStation"] = beginStation;
            dr["EndStation"] = endStation;
            dr["ServiceTime"] = serviceTime;
            dr["Description"] = description;
            SqlCommandBuilder sqlcb = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(ds.Tables["Bus"]);//使用DataAdapter对象的Update（）方法将更新的数据提交到数据库
            myConn.Close();
            FillData();

        }

        protected void gvBus_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvBus.EditIndex = -1;
            FillData();
        }

        protected void gvBus_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvBus.EditIndex = e.NewEditIndex;
            FillData();
        }
    }
}