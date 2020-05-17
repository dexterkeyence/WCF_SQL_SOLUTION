<%@ Page Title="Data List Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataList.aspx.vb" Inherits="WebApp_WcfKVHost_SQL.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> </h2>
    
    <div style="text-decoration: underline">
        <strong>Data List</strong></div>
    
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" Width="631px" Height="400px">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="ToolBarcode" HeaderText="ToolBarcode" SortExpression="ToolBarcode" />
        <asp:BoundField DataField="ToolUsageCount" HeaderText="ToolUsageCount" SortExpression="ToolUsageCount" />
        <asp:BoundField DataField="LastUpdateTime" HeaderText="LastUpdateTime" SortExpression="LastUpdateTime" />
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StampDeptConnectionString %>" SelectCommand="SELECT * FROM [Toolusage]"></asp:SqlDataSource>
</asp:Content>
