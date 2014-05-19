<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageManager.ascx.cs" Inherits="LaminhCMS.Web.Admin.Usercontrol.Page.PageManager" %>
<%@ Register src="PageTree.ascx" tagname="PageTree" tagprefix="uc1" %>
<%@ Register src="PageConfig.ascx" tagname="PageConfig" tagprefix="uc2" %>
<div class="full-width">
    <div class="left-col">
        <uc1:PageTree ID="PageTree1" runat="server" />
    </div>
    <div class="right-col">
        <uc2:PageConfig ID="PageConfig1" runat="server" />
    </div>
</div>