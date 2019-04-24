<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pageHome.aspx.cs" Inherits="ZooApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div><h1>University of Houston Zoo</h1></div>
        <div><h3>Interactive Database Portal</h3></div>
    </div>
    <div class="row">
        <asp:Image ID="VisitorImg" ImageUrl="images/visitor.jpg" runat="server" />
        <asp:Image ID="EmployeeImg" ImageUrl="images/employee.jpg" runat="server" />
    </div>
    <div class="row">
    </div>
    <p>&nbsp</p>
    <div class="row">
        <asp:Image ID="MemberImg" ImageUrl="images/member.jpg" runat="server" />
    </div>
    <div class="row">
    </div>
</asp:Content>
