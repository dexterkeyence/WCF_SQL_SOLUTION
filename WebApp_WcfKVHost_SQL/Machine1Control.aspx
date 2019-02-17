<%@ Page Title="Machine 1 Control" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Machine1Control.aspx.vb" Inherits="WebApp_WcfKVHost_SQL.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>
    </h2>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <h2>.<asp:Label ID="Label1" runat="server" Text="Tool Usage = &quot;TOOL1234&quot;"></asp:Label>
            :<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </h2>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input">TOOL1234</asp:TextBox>
            <asp:Button ID="btnRefresh" runat="server" CssClass="btn btn-info" Text="Refresh" />
        </p>
        <asp:Timer ID="Timer1" runat="server" Interval="10000">
        </asp:Timer>
        <br />
        <br />
        <p>
            <div class="alert alert-success">
  <strong>Success!</strong> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</div>
            
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" Text="Call Service" />
        </p>
    </ContentTemplate>
</asp:UpdatePanel>
<p>
        &nbsp;</p>
    <p>Production Status</p>
    <p>Use this area to provide additional information.</p>
</asp:Content>
