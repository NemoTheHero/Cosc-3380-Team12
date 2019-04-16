<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ZooApplication.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!----- PAGE HEADER ----->
    <div class="jumbotron">
        <h1>Administrator Portal</h1>
    </div>

    <!----- PAGE BODY ----->
    <div class="row">

        <!----- LEFT PANEL ----->
        <div class ="col-md-5">
            <div class="form-horizontal">
                <h2>Create or Update Record</h2>

                <!----- TABLE SELECTION DROPDOWN ----->
                <div class="form-group">
                    <asp:Label ID="TransactionLabel" runat="server" CssClass="control-label col-md-3">Record Type</asp:Label>
                    <div class="col-md-5">                    
                        <asp:DropDownList ID="TransactionDropDown" AutoPostback="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="TransactionDropDown_SelectedIndexChanged">
                        <asp:ListItem>Select</asp:ListItem>                            
                        <asp:ListItem>Animal</asp:ListItem>
                        <asp:ListItem>Contact</asp:ListItem>
                        <asp:ListItem>Diet</asp:ListItem>
                        <asp:ListItem>Employee</asp:ListItem>
                        <asp:ListItem>Exhibit</asp:ListItem>
                        <asp:ListItem>Facility</asp:ListItem>
                        <asp:ListItem>Handler</asp:ListItem>
                        <asp:ListItem>Job Position</asp:ListItem>
                        <asp:ListItem>Membership</asp:ListItem>
                        <asp:ListItem>User Login</asp:ListItem>
                        <asp:ListItem>Work Order</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <!----- RECORD CREATION TEXTBOXES ----->
                <div class="form-group">
                    <asp:Label ID="TransLbl1" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TransTb1" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="TransLbl2" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TransTb2" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="TransLbl3" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TransTb3" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="TransLbl4" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TransTb4" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="TransLbl5" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TransTb5" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="TransLbl6" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TransTb6" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="TransLbl7" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="TransTb7" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <!----- TRANSACTION BUTTONS ----->
                <div class="form-group">
                    <asp:Button ID="CreateBtn" runat="server" Text="Create Record" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="CreateBtn_Click"/>
                    <asp:Button ID="UpdateBtn" runat="server" Text="Update Record" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="UpdateBtn_Click"/>
                </div>
            </div>
        </div>

        <!----- RIGHT PANEL ----->
        <div class ="col-md-5">
            <div class="form-horizontal">
                <h2>View Existing Record(s)</h2>

                <!----- TABLE SELECTION DROPDOWN ----->
                <div class="form-group">
                    <asp:Label ID="QueryLabel" runat="server" CssClass="control-label col-md-3">Record Type</asp:Label>
                    <div class="col-md-5">                    
                        <asp:DropDownList ID="QueryDropDown" AutoPostback="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="QueryDropDown_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>                            
                            <asp:ListItem>Animal</asp:ListItem>
                            <asp:ListItem>Contact</asp:ListItem>
                            <asp:ListItem>Diet</asp:ListItem>
                            <asp:ListItem>Employee</asp:ListItem>
                            <asp:ListItem>Exhibit</asp:ListItem>
                            <asp:ListItem>Facility</asp:ListItem>
                            <asp:ListItem>Handler</asp:ListItem>
                            <asp:ListItem>Job Position</asp:ListItem>
                            <asp:ListItem>Membership</asp:ListItem>
                            <asp:ListItem>User Login</asp:ListItem>
                            <asp:ListItem>Work Order</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <!----- PRIMARY KEY ENTRY ----->
                <div class="form-group">
                    <asp:Label ID="KeyLabel" runat="server" CssClass="control-label col-md-3" Text="Record ID"></asp:Label>
                    <asp:TextBox ID="KeyTextBox" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <!----- PRIMARY KEY ENTRY ----->
                <div class="form-group">
                    <asp:Button ID="SearchRecordBtn" runat="server" Text="Find Record" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="SearchRecordBtn_Click"/>
                    <asp:Button ID="ViewTableBtn" runat="server" Text="View Table" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="ViewTableBtn_Click"/>
                </div>

                <!----- QUERY RESULTS GRID ----->
                <div class="form-group">
                    <asp:GridView ID="SearchOutput" runat="server" EmptyDataText="Oops! Please enter a valid member ID."></asp:GridView>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
