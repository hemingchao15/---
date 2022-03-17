<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="添加路线.aspx.cs" Inherits="WebApplication1.Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>风云车次网-添加路线</title>
    <style type="text/css">
        .style1
        {
            height: 54px;
            width: 232px;
        }
        .style2
        {
            height: 209px;
            width: 624px;
        }
        .style3
        {
            width: 627px;
            height: 40px;
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
    </div>
    <div></div>&nbsp;
    <div align ="center">
    车次：&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="BusID" runat="server" CssClass="txtCss" />
    <p>
        起始点：&nbsp; 
       <asp:TextBox ID="BeginStation" runat="server" CssClass="txtCss"/>
    </p>
    <p>
        终点站：&nbsp; 
        <asp:TextBox ID="EndStation" runat="server" CssClass="txtCss"/>
    </p>
    <p>
        发车时间：<asp:TextBox ID="ServiceTime" runat="server" CssClass="txtCss"/>
    </p>
    <p>
        车次描述：<asp:TextBox ID="Description" runat="server" CssClass="txtCss"/>
    </p>
    <asp:Button ID="btnPost" runat="server" Text="提交" onclick="btnPost_Click" CssClass="buttoncss"/>
    <asp:Button ID="btnCancel" runat="server" Text="取消" style="margin-left:100px;" 
        onclick="btnCancel_Click" CssClass="buttoncss"/>
    </div><br />
     <div align ="center"><img alt="" class="style2" src="img/广告.JPG" /></div>
     <div align ="center"><img alt=""  class="style3" src="img/链接.JPG" /></div>
    </form>
</body>
</html>
