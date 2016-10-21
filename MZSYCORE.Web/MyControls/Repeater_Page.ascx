<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Repeater_Page.ascx.cs" Inherits="MZSYCORE.Web.MyControls.Repeater_Page" %>
<link href="../Css/bootstrap.css" rel="stylesheet" />
<div class="inline pull-right page">
    <asp:Label ID="lbl_datacount" runat="server" Text="lable"></asp:Label>条记录&nbsp;&nbsp;
        <asp:Label ID="lbl_Index" runat="server" Text="Label"></asp:Label>/<asp:Label ID="lbl_pageCount" runat="server" Text="Label"></asp:Label>页&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_firstPage" runat="server" OnClick="lbtnPage_Click">首页</asp:LinkButton>
    &nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_prePage" runat="server" OnClick="lbtnPage_Click">上一页</asp:LinkButton>&nbsp;&nbsp;
         <asp:LinkButton ID="lbtn_nextPage" runat="server" OnClick="lbtnPage_Click">下一页</asp:LinkButton>&nbsp;&nbsp;
       <asp:LinkButton ID="lbtn_lastPage" runat="server" OnClick="lbtnPage_Click">末页</asp:LinkButton>
</div>
