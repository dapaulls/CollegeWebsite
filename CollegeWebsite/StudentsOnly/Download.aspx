<%@ Page Title="City College - Download material" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Download.aspx.cs" Inherits="CollegeWebsite.StudentsOnly.Download" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>List of available files:</p>
<asp:SqlDataSource ID="DownloadSqlDataSource" 
        runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [WebsiteUploads]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="MaterialID" 
        DataSourceID="DownloadSqlDataSource">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="File" HeaderText="File" SortExpression="File" />
        </Columns>
    </asp:GridView>
    <br />
    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="SelectFileLabel" runat="server" Text="Select a file to download:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="FileDropDownList" runat="server" 
                    DataSourceID="DownloadSqlDataSource" DataTextField="File" 
                    DataValueField="MaterialID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="DownloadButton" runat="server" onclick="DownloadButton_Click" 
                    Text="Download" />
            </td>
        </tr>        
    </table>
</asp:Content>
