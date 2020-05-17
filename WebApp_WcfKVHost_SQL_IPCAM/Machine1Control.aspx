<%@ Page Title="Machine Control Panel" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Machine1Control.aspx.vb" Inherits="WebApp_WcfKVHost_SQL.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
        <ContentTemplate>
            <h2>Machine Control Panel</h2>

                <div class="panel panel-info">
                      <div class="panel-heading">
                          <a> SQL Monitoring </a>
                          <br />
                          <strong style="font-family: Arial; font-size: medium">Tool ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp; </strong>
                          <asp:Label ID="Label1" runat="server" Font-Size="Large" Height="22px" Text="--" Width="181px"></asp:Label>
                          <br />
                          <strong style="font-family: Arial; font-size: medium">Tool Usage&nbsp;&nbsp; &nbsp; :&nbsp; </strong>
                          <asp:Label ID="Label2" runat="server" Font-Size="Large" Height="22px" Text="--" Width="181px"></asp:Label>
                          <asp:Timer ID="Timer1" runat="server" Interval="1000">
                          </asp:Timer>

                      </div>
                    <br />
                    
                     <div class="panel-heading">
                         <a> PLC Monitoring </a>
                         <br />
                         <strong style="font-family: Arial; font-size: medium">DM1000&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; :&nbsp; </strong>
                          <asp:Label ID="Label3" runat="server" Font-Size="Large" Height="22px" Text="--" Width="181px"></asp:Label>
                          
                          <br />                 
                          
                          <asp:RadioButton ID="RadioButton1" runat="server" Height="29px" style="font-size: medium" Text=" MR3000     : " TextAlign="Left" />
                      </div>
                      
                 </div>


        </ContentTemplate>
    </asp:UpdatePanel>

                <h3>SETTING</h3>
                 <div style="background-color: #99FFCC">


        <br />
         <strong style="font-family: Arial; font-size: medium">Tool ID&nbsp;:&nbsp; </strong>
         <span style="text-decoration: underline">
        <asp:TextBox ID="TextBox1" runat="server" Width="132px">TOOL1234</asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Refresh" Width="90px" CssClass="active" />
                          </span>

        <br />
         <br />
             <strong style="font-family: Arial; font-size: medium">DM1000&nbsp;:&nbsp; </strong>
         <span style="text-decoration: underline">
        <asp:TextBox ID="TextBox2" runat="server" Width="123px">8888</asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="WRITE" Width="90px" />
                          <br />
                     <br />
                          </span>
                          <br />
                     <asp:UpdatePanel ID="UpdatePanel2" runat="server" RenderMode="Inline" UpdateMode="Conditional">
                         <ContentTemplate>
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" CssClass="btn-primary" Height="73px" Text="MR3000 = ON" Width="124px" />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="Button3" runat="server" CssClass="btn-primary" Height="73px" Text="MR3000 = OFF" Width="125px" />
                         </ContentTemplate>
                     </asp:UpdatePanel>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <br />
        


    </div>      


    
   



</asp:Content>
