<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ZooApplication._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Page Title -->
    <h1> UH ZOO </h1>

    <body style="background-image: url('Content/Homepage2.jpeg');">
    </body>

    <!-- User Input -->
    <div class="form-horizontal">
        
        <!-- Enter Username -->
        <div class="form-group">
            <asp:Label runat="server" CssClass="control-label col-md-2"><strong>Username</strong></asp:Label>
            <asp:TextBox ID="inUsername" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
        </div>

        <!-- Enter Password -->
        <div class="form-group">
            <asp:Label runat="server" CssClass="control-label col-md-2"><strong>Password</strong></asp:Label>
            <asp:TextBox ID="inPassword" runat="server" CssClass="form-control col-md-10"></asp:TextBox>
        </div>

        <!-- Login Button -->
        <div class="form-group">
            <asp:Button runat="server" CssClass="btn btn-default col-md-offset-2 col-md-2" Text="Login" OnClick="Login" />
        </div>
    </div>
</asp:Content>
