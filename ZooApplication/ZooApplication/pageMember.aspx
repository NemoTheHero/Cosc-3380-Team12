<%@ Page Title="Member Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pageMember.aspx.cs" Inherits="ZooApplication.Member" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Zoo Members</h1>
    </div>
    <div class ="col-md-5">
        <h2>Please Log In To View Membership Details</h2>
    </div>
    <div class="row">
        <asp:Label ID="MemberLbl" runat="server" Text="Member ID"></asp:Label>
        <asp:TextBox ID="MemberBox" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Label ID="PasswordLbl" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="PasswordBox" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
    </div>
    <div class="row">
        <asp:Label ID="DialogLbl" runat="server" Text="Membership Not Found!"></asp:Label>
    </div>
    <div class="row">
        <asp:GridView ID="RecordGrid" runat="server" EmptyDataText="Error: Please enter a valid member ID."></asp:GridView>
    </div>
</asp:Content>
