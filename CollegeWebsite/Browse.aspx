<%@ Page Title="City College - Browse our courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Browse.aspx.cs" Inherits="CollegeWebsite.Browse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        These are our current courses. 
        <asp:HyperLink ID="EnrolHyperLink" runat="server" Text="Submit" NavigateUrl="~/Enrol.aspx">Submit</asp:HyperLink> your details if you would like more
        information about a course.
    </p>
        <asp:SqlDataSource ID="BrowseCoursesSqlDataSource" 
        runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [CourseList]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" 
        DataKeyNames="CourseID" DataSourceID="BrowseCoursesSqlDataSource">
        <Columns>
            <asp:BoundField DataField="CourseStartDate" DataFormatString="{0:d}" 
                HeaderText="Start Date" SortExpression="CourseStartDate" />
            <asp:BoundField DataField="CourseName" HeaderText="Course Name" 
                SortExpression="CourseName" />
            <asp:BoundField DataField="CourseDescription" HeaderText="Description" 
                SortExpression="CourseDescription" />
            <asp:BoundField DataField="CourseEndDate" DataFormatString="{0:d}" 
                HeaderText="End Date" SortExpression="CourseEndDate" />
        </Columns>
    </asp:GridView>
&nbsp;
</asp:Content>
