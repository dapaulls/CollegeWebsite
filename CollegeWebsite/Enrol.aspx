<%@ Page Title="City College - Enrol on a course" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Enrol.aspx.cs" Inherits="CollegeWebsite.Enrol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>To register your interest in a course, enter your name, e-mail address and name of the course using the form below. 
    One of our team will contact you within 48 hours.
    </p>
    <table>
        <tr>
            <td>
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="FirstNameTextBox" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="FirstNameRequiredFieldValidator" runat="server" 
                    ControlToValidate="FirstNameTextBox" Display="Dynamic" 
                    ErrorMessage="* Enter your first name." CssClass="message">* Enter your first name.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="LastNameTextBox" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="LastNameRequiredFieldValidator" runat="server" 
                    ControlToValidate="LastNameTextBox" Display="Dynamic" 
                    ErrorMessage="* Enter your last name." CssClass="message">* Enter your last name.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="EmailLabel" runat="server" Text="e-Mail:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server" MaxLength="100"></asp:TextBox>
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" 
                    runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" 
                    ErrorMessage="* Enter a valid e-mail address." 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    CssClass="message">* Enter a valid e-mail address.</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" 
                    ControlToValidate="EmailTextBox" Display="Dynamic" 
                    ErrorMessage="RequiredFieldValidator" CssClass="message">* Enter your e-mail address.</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="CourseNameLabel" runat="server" Text="Course Name:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="CourseListDropDownList" runat="server" 
                    DataSourceID="CourseListSqlDataSource" DataTextField="CourseName" 
                    DataValueField="CourseID">
                </asp:DropDownList>
                <asp:SqlDataSource ID="CourseListSqlDataSource" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT * FROM [CourseList]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" 
                    onclick="SubmitButton_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="EnrolSuccessfulLabel" runat="server" CssClass="message"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
