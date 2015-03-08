<%@ Page Title="City College - Upload material" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="CollegeWebsite.AdminOnly.Upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>This is the administration page for uploading files.</p>
<p>Enter a title and brief description for the file, use the &#39;Browse&#39; button to navigate to and select the file 
that you want to upload, and then click the &#39;Upload&#39; button.</p>

    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="TitleLabel" runat="server" Text="Title:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TitleTextBox" runat="server" MaxLength="100"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TitleRequiredFieldValidator" runat="server" 
                    ControlToValidate="TitleTextBox" ErrorMessage="* Enter a title" 
                    ForeColor="Red">* Enter a title</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="DescriptionLabel" runat="server" Text="Description:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="DescriptionTextBox" runat="server" MaxLength="500"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="FileUploadLabel" runat="server" Text="File to upload:"></asp:Label>
            </td>
            <td>
                <asp:FileUpload ID="FileUpload" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="UploadButton" runat="server" Text="Upload" 
                    onclick="UploadButton_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="UploadSuccessfulLabel" runat="server" ForeColor="Red"></asp:Label>                
            </td>
        </tr>
    </table>

</asp:Content>
