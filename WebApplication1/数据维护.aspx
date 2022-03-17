<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="数据维护.aspx.cs" Inherits="WebApplication1.Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 
    <title>风云车次网-数据维护</title>
    <style type="text/css">
        .style1
        {
            height: 56px;
            width: 235px;
        }
        .style2
        {
            height: 228px;
            width: 607px;
        }
        .style3
        {
            height: 37px;
            width: 602px;
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
    
    <asp:GridView ID="gvBus" runat="server" AllowPaging="True" CssClass="tableinitial" PageSize="5"
        onpageindexchanging="gvBus_PageIndexChanging" 
        onrowcancelingedit="gvBus_RowCancelingEdit" onrowdeleting="gvBus_RowDeleting" 
        onrowediting="gvBus_RowEditing" onrowupdating="gvBus_RowUpdating" 
    AutoGenerateColumns="False" DataKeyNames="ID" style="top: 0px; left: 0px" >
    <Columns>
           
            <asp:BoundField DataField="BusID" HeaderText="车次"  />
            <asp:BoundField DataField="BeginStation" HeaderText="起始站" />  
            <asp:BoundField DataField="EndStation" HeaderText="终点站"  />  
            <asp:BoundField DataField="ServiceTime" HeaderText="发车时间"  /> 
            <asp:BoundField DataField="Description" HeaderText="描述" />      
            <asp:CommandField ShowEditButton="True" ControlStyle-Width="50" ></asp:CommandField>

            <asp:CommandField ShowDeleteButton="True" ControlStyle-Width="50" ></asp:CommandField>
            
        </Columns>
    </asp:GridView>
        
    </div><br />
     <div align ="center"><img alt="" class="style2" src="img/广告.JPG" /></div>
     <div align ="center"><img alt=""  class="style3" src="img/链接.JPG" /></div>
    </form>
</body>
</html>
