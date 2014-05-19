<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sub1col1.ascx.cs" Inherits="LaminhCMS.Web.Skin.sub1col1" %>

<!-- Begin Body -->
<div id="Container">
    <!-- Begin Header -->
    <div id="Header">
		<div id="logo">
			<asp:PlaceHolder ID="logoPanel" runat="server"></asp:PlaceHolder>
		</div>
		<div id="head_right">
			<div id="headtool">
				<div class="lang_html"><asp:PlaceHolder ID="LangPanel" runat="server"></asp:PlaceHolder></div>
			</div>
			<div id="mainMenu">
				
			</div>
		</div>
		<div class="clear"></div>
    </div>
    <!-- End Header -->
    <!--BEGIN MAIN-->
    <div id="Main">
		<div id="topcontent">
			<asp:PlaceHolder ID="topcontentPanel" runat="server"></asp:PlaceHolder>
		</div>
        <div id="Content">
			<div class="col_contentLeft">
				<asp:PlaceHolder ID="contentLeftpanel" runat="server"></asp:PlaceHolder>
			</div>
        </div>
		<div id="bottomcontent">
			<asp:PlaceHolder ID="bottomcontentPanel" runat="server"></asp:PlaceHolder>
		</div>
     </div>
     <!--END MAIN-->	
</div>
<!-- END CONTAINER-->
<!-- Begin Footer-->
<div id="Footer">
<div id="wrapFooter">
	<div id="FooterLeftPanel">
	    <asp:PlaceHolder ID="CopyLeftPanel" runat="server"></asp:PlaceHolder>
	</div>
	<div id="FooterRightPanel"><asp:PlaceHolder ID="CopyRightPanel" runat="server"></asp:PlaceHolder></div>      
</div>
</div>
<!-- END Footer-->
