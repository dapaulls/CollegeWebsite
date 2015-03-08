<%@ Page Title="City College - Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="CollegeWebsite._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to City College.
    </h2>
    <p>
        <asp:LoginView ID="HomePageLoginView" runat="server">
            <AnonymousTemplate>
                <p>
                    City College is the World's leading fictional teaching establishment.</p>
                <p>
                    Browse our courses to see what we offer. If you are interested in taking a course, submit your details
                    and one of our team will contact you.</p>
                <p>
                    Current students at City College can use their username and password to log into the site and download teaching material.</p>
                <hr />
                <p>
                    For demonstration purposes:<br /> 
                    Students can use the username: <em>student</em> and password: <em>password#1</em>.<br /> 
                    Teachers can use the username: <em>admin</em> and password: <em>password#2</em>.</p>
            </AnonymousTemplate>
            <RoleGroups>
                <asp:RoleGroup Roles="Student">
                    <ContentTemplate>
                        You are logged in as a Student. You can now 
                        <asp:HyperLink ID="DownloadHyperLink" runat="server" Text="download" NavigateUrl="~/StudentsOnly/Download.aspx">download</asp:HyperLink> 
                        teaching material.
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup Roles="Administrator">
                    <ContentTemplate>
                        You are logged in as the Administrator. You can now
                        <asp:HyperLink ID="UploadHyperLink" runat="server" Text="upload" NavigateUrl="~/AdminOnly/Upload.aspx">upload</asp:HyperLink>
                        files. 
                    </ContentTemplate>
                </asp:RoleGroup>
            </RoleGroups>
        </asp:LoginView>
    </p>
</asp:Content>
