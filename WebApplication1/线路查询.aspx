<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="线路查询.aspx.cs" Inherits="WebApplication1.Search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>风云车次网-线路查询</title>
    <style type="text/css">
        .style1
        {
            height: 58px;
            width: 234px;
        }
        .style2
        {
            height: 224px;
            width: 632px;
        }
        .style3
        {
            height: 43px;
            width: 613px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <div align ="center"><img alt="" class="style1" src="img/火车.jpg" />
    <h1 align ="center">
        风云车次网</h1>
    </div>
    <div align ="center">
    <a href="http://localhost:1353/首页.aspx">首页<a/>
    <a href="http://localhost:1353/添加路线.aspx">添加路线<a/>
    <a href="http://localhost:1353/数据维护.aspx">数据维护<a/>
    <a href="http://localhost:1353/线路查询.aspx">线路查询<a/>   
    </div>&nbsp; 
   <div align ="center">
   
    <asp:CheckBox ID="CheckBox1" runat="server" Text="起始站" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:CheckBox ID="CheckBox2" runat="server" Text="终点站" />
    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Button ID="ImageButton1" runat="server" Text="提交" 
           onclick="ImageButton1_Click1"  />
    <div>
    </div>&nbsp;&nbsp;
    <asp:GridView ID="gvBus" runat="server" 
           onpageindexchanging="gvBus_PageIndexChanging" AutoGenerateColumns="False">
    <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" 
                Visible="False" />
            <asp:BoundField DataField="BusID" HeaderText="车次" SortExpression="BusID"  />
            <asp:BoundField DataField="BeginStation" HeaderText="起始站" SortExpression="BeginStation" 
                 />
            <asp:BoundField DataField="EndStation" HeaderText="终点站" SortExpression="EndStstion" 
                 />
            <asp:BoundField DataField="ServiceTime" HeaderText="发车时间" SortExpression="ServiceTime" 
                 />
            <asp:BoundField DataField="Description" HeaderText="描述" SortExpression="Description" 
                 />
            
           
            
        </Columns>
    </asp:GridView>
     </div><br />
      <div align ="center"><img alt="" class="style2" src="img/广告.JPG" /></div>
     <div align ="center"><img alt=""  class="style3" src="img/链接.JPG" /></div>
     </form>
</body>
</html>
