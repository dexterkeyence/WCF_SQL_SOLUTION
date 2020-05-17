<%@ Page Title="IP CAMERA" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ipcam.aspx.vb" Inherits="WebApp_WcfKVHost_SQL.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <style>
        .resp-container {
    position: relative;
    overflow: hidden;
    padding-top: 56.25%;
}
        .resp-iframe {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    border: 0;
}


    </style>
    
    <h2><%: Title %>.</h2>
    <p style="text-decoration: underline"><strong>Stamping Department</strong></p>
        <p style="text-decoration: underline">
            <asp:Button ID="Button1" runat="server" Text="MR3000 = ON" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="MR3000 = OFF" />
        </p>
        <p style="text-decoration: underline">&nbsp;</p>

    
    <div class="resp-container">
     <iframe class="resp-iframe" src="http://192.168.0.88"></iframe>


    </div>

 
</asp:Content>
