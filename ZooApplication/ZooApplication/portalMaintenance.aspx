<%@ Page Title="Maintenance Portal" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="portalMaintenance.aspx.cs" Inherits="ZooApplication.Maintenance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <!-- Page Title -->
    <h1><%: Title %></h1>

    <div class="row">

        <!-- Report a Problem -->
        <div class="col-md-5">
            <h2>Report a Problem</h2>

            <!-- User Input -->
            <div class="form-horizontal">

                <!-- Select Section -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">Section</asp:Label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="listSection" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="Section_Changed" />
                    </div>
                </div>

                <!-- Select Facility -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">Facility</asp:Label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="listFacility" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="Facility_Changed" />
                    </div>
                </div>

                <!-- Select Order Type -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">Order Type</asp:Label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="listOrderType" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <!-- Enter Date -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">Year</asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="inYear" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">Month</asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="inMonth" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">Day</asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="inDay" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <!-- Enter Employee ID -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">Employee ID</asp:Label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="listMaintenance" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <!-- Report Button -->
                <div class="form-group">
                    <asp:Button runat="server" CssClass="btn btn-default col-md-offset-3 col-md-3" Text="Report" OnClick="Report_Problem" />
                </div>
            </div>
        </div>

        <!-- View Upcoming Scheduled Repairs -->
        <div class="col-md-5">
            <h2>View Upcoming Scheduled Repairs</h2>

            <!-- User Input -->
            <div class="form-horizontal">

                <!-- Select Date -->
                <asp:Calendar ID="calendar" runat="server" OnSelectionChanged="Date_Changed">
                    <SelectedDayStyle BackColor="LightGray" />
                    <OtherMonthDayStyle ForeColor="LightGray" />
                </asp:Calendar>

                <!-- Query Output -->
                <asp:GridView ID="orderInfo" runat="server" EmptyDataText="You have no repairs scheduled for today." />

                <!-- Complete Work Order -->
                <h3>Complete Work Order</h3>

                <!-- Enter Order ID -->
                <div class="form-group">
                    <asp:Label runat="server" CssClass="control-label col-md-3">OrderID</asp:Label>
                    <div class="col-md-4">
                        <asp:TextBox ID="inOrderID" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <!-- Complete Button -->
                <div class="form-group">
                    <asp:Button runat="server" CssClass="btn btn-default col-md-offset-3 col-md-3" Text="Complete" OnClick="Complete_Order" />
                </div>
            </div>
        </div>
    </div>

    <div class="row">

        <!-- View Out of Order Facilities -->
        <div class="col-md-5">
            <h2>View Out of Order Facilities</h2>

            <!-- Query Output -->
                <asp:GridView ID="oooFacilities" runat="server" EmptyDataText="All facilities are in order." />
        </div>
    </div>
</asp:Content>
