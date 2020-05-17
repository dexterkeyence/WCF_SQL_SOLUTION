<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApp_WcfKVHost_SQL._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Machine Web Server Demo</h1>
        <p class="lead">This is a Demo Page showing IoT solution can be integrated into multiple devices</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Production Status</h2>
            <p>
                Monitoring the status of production floor using Multiple Devices</p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Production_Status">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Machine Control</h2>
            <p>
                Demostrating how to remotely control individual Machine
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Machine1Control">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Data List</h2>
            <p>
                How SQL Data can be display on Multiple Devices</p>
            <p>
                <a class="btn btn-default" runat="server" href="~/DataList">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
