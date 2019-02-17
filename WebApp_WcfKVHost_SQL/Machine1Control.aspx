<%@ Page Title="Machine 1 Control" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Machine1Control.aspx.vb" Inherits="WebApp_WcfKVHost_SQL.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.<asp:Label ID="Label1" runat="server" Text="Tool Usage = &quot;TOOL1234&quot;"></asp:Label>
        :<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </h2>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input"></asp:TextBox>
        <asp:Button ID="btnRefresh" runat="server" CssClass="btn btn-info" Text="Refresh" />
    </p>
    <p>Production Status</p>
    <p>Use this area to provide additional information.</p>
</asp:Content>
