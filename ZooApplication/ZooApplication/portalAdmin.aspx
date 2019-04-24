<%@ Page Title="Administrator Portal" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="portalAdmin.aspx.cs" Inherits="ZooApplication.Admin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!----- PAGE HEADER ----->
    <div class="jumbotron">
        <h1>Administrator Portal</h1>
    </div>
    </div>
        <div class="row">
        <asp:Button ID="ReportsBtn" class="btn btn-primary" Width="120" runat="server" Text="Facility Report" OnClick="ReportsBtn_Click" />
        <asp:Button ID="AnimalReportBtn" class="btn btn-primary" Width="120" runat="server" Text="Animal Report" OnClick="AnimalReportsBtn_Click" />
    </div>
    <!----- PAGE BODY ----->
    <div class="row">

        <!----- LEFT PANEL ----->
        <div class ="col-md-5">
            <div class="form-horizontal">
                <h2>Create New Record</h2>
                <div class="row">
                    <asp:Button ID="CreateBtn" runat="server" Text="Create Record" CssClass="btn btn-default col-md-4" OnClick="CreateBtn_Click"/>
                    <asp:TextBox ID="InsertDialog" runat="server" CssClass="form-control col-md-4"></asp:TextBox>
                </div>
                <p>&nbsp</p>

                <!----- TABLE SELECTION DROPDOWN ----->
                <div class="form-group">
                    <asp:Label ID="InsertLabel" runat="server" CssClass="control-label col-md-3">Record Type</asp:Label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="InsertDropDown" AutoPostback="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="InsertDropDown_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Animal</asp:ListItem>
                            <asp:ListItem>Animal Handler</asp:ListItem>
                            <asp:ListItem>Contact</asp:ListItem>
                            <asp:ListItem>Diet</asp:ListItem>
                            <asp:ListItem>Employee</asp:ListItem>
                            <asp:ListItem>(ENUM) Department</asp:ListItem>
                            <asp:ListItem>(ENUM) Diet Type</asp:ListItem>
                            <asp:ListItem>(ENUM) Ecosytem</asp:ListItem>
                            <asp:ListItem>(ENUM) Facility Status</asp:ListItem>
                            <asp:ListItem>(ENUM) Facility Type</asp:ListItem>
                            <asp:ListItem>(ENUM) Health Condition</asp:ListItem>
                            <asp:ListItem>(ENUM) Job Position</asp:ListItem>
                            <asp:ListItem>(ENUM) Medication</asp:ListItem>
                            <asp:ListItem>(ENUM) Membership Status</asp:ListItem>
                            <asp:ListItem>(ENUM) Membership Type</asp:ListItem>
                            <asp:ListItem>(ENUM) Section</asp:ListItem>
                            <asp:ListItem>(ENUM) Species</asp:ListItem>
                            <asp:ListItem>(ENUM) Work Order Type</asp:ListItem>
                            <asp:ListItem>Exhibit</asp:ListItem>
                            <asp:ListItem>Facility</asp:ListItem>
                            <asp:ListItem>Health Profile</asp:ListItem>
                            <asp:ListItem>Membership</asp:ListItem>
                            <asp:ListItem>User Login</asp:ListItem>
                            <asp:ListItem>Work Order</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <!----- RECORD CREATION TEXTBOXES ----->
                <div class="form-group">
                    <asp:Label ID="InsertLbl1" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox1" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="DietTypeDrop1" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="FactTypeDrop1" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="MemTypeDrop1" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="OrderDrop1" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="EmployeeDrop" runat="server" CssClass="form-control"></asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl2" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox2" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="SpecDrop2" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="FactTypeDrop2" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="FactStatDrop2" runat="server" CssClass="form-control"></asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl3" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox3" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="DietTypeDrop3" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="FacilityDrop" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="SectDrop3" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop3" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl4" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox4" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="EcoDrop4" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="ExhibDrop4" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="EmployeeDrop4" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop4" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl5" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox5" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="EmployeeDrop5" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="SectDrop5" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="StateDrop5" runat="server" CssClass="form-control">
                        <asp:ListItem>AK</asp:ListItem>
                        <asp:ListItem>AL</asp:ListItem>
                        <asp:ListItem>AR</asp:ListItem>
                        <asp:ListItem>AS</asp:ListItem>
                        <asp:ListItem>AZ</asp:ListItem>
                        <asp:ListItem>CA</asp:ListItem>
                        <asp:ListItem>CO</asp:ListItem>
                        <asp:ListItem>CT</asp:ListItem>
                        <asp:ListItem>DC</asp:ListItem>
                        <asp:ListItem>DE</asp:ListItem>
                        <asp:ListItem>FL</asp:ListItem>
                        <asp:ListItem>FM</asp:ListItem>
                        <asp:ListItem>GA</asp:ListItem>
                        <asp:ListItem>GU</asp:ListItem>
                        <asp:ListItem>HI</asp:ListItem>
                        <asp:ListItem>IA</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>IL</asp:ListItem>
                        <asp:ListItem>IN</asp:ListItem>
                        <asp:ListItem>KS</asp:ListItem>
                        <asp:ListItem>KY</asp:ListItem>
                        <asp:ListItem>LA</asp:ListItem>
                        <asp:ListItem>MA</asp:ListItem>
                        <asp:ListItem>MD</asp:ListItem>
                        <asp:ListItem>ME</asp:ListItem>
                        <asp:ListItem>MH</asp:ListItem>
                        <asp:ListItem>MI</asp:ListItem>
                        <asp:ListItem>MN</asp:ListItem>
                        <asp:ListItem>MO</asp:ListItem>
                        <asp:ListItem>MP</asp:ListItem>
                        <asp:ListItem>MS</asp:ListItem>
                        <asp:ListItem>MT</asp:ListItem>
                        <asp:ListItem>NC</asp:ListItem>
                        <asp:ListItem>ND</asp:ListItem>
                        <asp:ListItem>NE</asp:ListItem>
                        <asp:ListItem>NH</asp:ListItem>
                        <asp:ListItem>NJ</asp:ListItem>
                        <asp:ListItem>NM</asp:ListItem>
                        <asp:ListItem>NV</asp:ListItem>
                        <asp:ListItem>NY</asp:ListItem>
                        <asp:ListItem>OH</asp:ListItem>
                        <asp:ListItem>OK</asp:ListItem>
                        <asp:ListItem>OR</asp:ListItem>
                        <asp:ListItem>PA</asp:ListItem>
                        <asp:ListItem>PR</asp:ListItem>
                        <asp:ListItem>PW</asp:ListItem>
                        <asp:ListItem>RI</asp:ListItem>
                        <asp:ListItem>SC</asp:ListItem>
                        <asp:ListItem>SD</asp:ListItem>
                        <asp:ListItem>TN</asp:ListItem>
                        <asp:ListItem>TX</asp:ListItem>
                        <asp:ListItem>UT</asp:ListItem>
                        <asp:ListItem>VA</asp:ListItem>
                        <asp:ListItem>VI</asp:ListItem>
                        <asp:ListItem>VT</asp:ListItem>
                        <asp:ListItem>WA</asp:ListItem>
                        <asp:ListItem>WI</asp:ListItem>
                        <asp:ListItem>WV</asp:ListItem>
                        <asp:ListItem>WY</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl6" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox6" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop6" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl7" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox7" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="HealthCondDrop7" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="StateDrop7" runat="server" CssClass="form-control">
                        <asp:ListItem>AK</asp:ListItem>
                        <asp:ListItem>AL</asp:ListItem>
                        <asp:ListItem>AR</asp:ListItem>
                        <asp:ListItem>AS</asp:ListItem>
                        <asp:ListItem>AZ</asp:ListItem>
                        <asp:ListItem>CA</asp:ListItem>
                        <asp:ListItem>CO</asp:ListItem>
                        <asp:ListItem>CT</asp:ListItem>
                        <asp:ListItem>DC</asp:ListItem>
                        <asp:ListItem>DE</asp:ListItem>
                        <asp:ListItem>FL</asp:ListItem>
                        <asp:ListItem>FM</asp:ListItem>
                        <asp:ListItem>GA</asp:ListItem>
                        <asp:ListItem>GU</asp:ListItem>
                        <asp:ListItem>HI</asp:ListItem>
                        <asp:ListItem>IA</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>IL</asp:ListItem>
                        <asp:ListItem>IN</asp:ListItem>
                        <asp:ListItem>KS</asp:ListItem>
                        <asp:ListItem>KY</asp:ListItem>
                        <asp:ListItem>LA</asp:ListItem>
                        <asp:ListItem>MA</asp:ListItem>
                        <asp:ListItem>MD</asp:ListItem>
                        <asp:ListItem>ME</asp:ListItem>
                        <asp:ListItem>MH</asp:ListItem>
                        <asp:ListItem>MI</asp:ListItem>
                        <asp:ListItem>MN</asp:ListItem>
                        <asp:ListItem>MO</asp:ListItem>
                        <asp:ListItem>MP</asp:ListItem>
                        <asp:ListItem>MS</asp:ListItem>
                        <asp:ListItem>MT</asp:ListItem>
                        <asp:ListItem>NC</asp:ListItem>
                        <asp:ListItem>ND</asp:ListItem>
                        <asp:ListItem>NE</asp:ListItem>
                        <asp:ListItem>NH</asp:ListItem>
                        <asp:ListItem>NJ</asp:ListItem>
                        <asp:ListItem>NM</asp:ListItem>
                        <asp:ListItem>NV</asp:ListItem>
                        <asp:ListItem>NY</asp:ListItem>
                        <asp:ListItem>OH</asp:ListItem>
                        <asp:ListItem>OK</asp:ListItem>
                        <asp:ListItem>OR</asp:ListItem>
                        <asp:ListItem>PA</asp:ListItem>
                        <asp:ListItem>PR</asp:ListItem>
                        <asp:ListItem>PW</asp:ListItem>
                        <asp:ListItem>RI</asp:ListItem>
                        <asp:ListItem>SC</asp:ListItem>
                        <asp:ListItem>SD</asp:ListItem>
                        <asp:ListItem>TN</asp:ListItem>
                        <asp:ListItem>TX</asp:ListItem>
                        <asp:ListItem>UT</asp:ListItem>
                        <asp:ListItem>VA</asp:ListItem>
                        <asp:ListItem>VI</asp:ListItem>
                        <asp:ListItem>VT</asp:ListItem>
                        <asp:ListItem>WA</asp:ListItem>
                        <asp:ListItem>WI</asp:ListItem>
                        <asp:ListItem>WV</asp:ListItem>
                        <asp:ListItem>WY</asp:ListItem>
                    </asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop7" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl8" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox8" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="HealthCondDrop8" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="StateDrop8" runat="server" CssClass="form-control">
                        <asp:ListItem>AK</asp:ListItem>
                        <asp:ListItem>AL</asp:ListItem>
                        <asp:ListItem>AR</asp:ListItem>
                        <asp:ListItem>AS</asp:ListItem>
                        <asp:ListItem>AZ</asp:ListItem>
                        <asp:ListItem>CA</asp:ListItem>
                        <asp:ListItem>CO</asp:ListItem>
                        <asp:ListItem>CT</asp:ListItem>
                        <asp:ListItem>DC</asp:ListItem>
                        <asp:ListItem>DE</asp:ListItem>
                        <asp:ListItem>FL</asp:ListItem>
                        <asp:ListItem>FM</asp:ListItem>
                        <asp:ListItem>GA</asp:ListItem>
                        <asp:ListItem>GU</asp:ListItem>
                        <asp:ListItem>HI</asp:ListItem>
                        <asp:ListItem>IA</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>IL</asp:ListItem>
                        <asp:ListItem>IN</asp:ListItem>
                        <asp:ListItem>KS</asp:ListItem>
                        <asp:ListItem>KY</asp:ListItem>
                        <asp:ListItem>LA</asp:ListItem>
                        <asp:ListItem>MA</asp:ListItem>
                        <asp:ListItem>MD</asp:ListItem>
                        <asp:ListItem>ME</asp:ListItem>
                        <asp:ListItem>MH</asp:ListItem>
                        <asp:ListItem>MI</asp:ListItem>
                        <asp:ListItem>MN</asp:ListItem>
                        <asp:ListItem>MO</asp:ListItem>
                        <asp:ListItem>MP</asp:ListItem>
                        <asp:ListItem>MS</asp:ListItem>
                        <asp:ListItem>MT</asp:ListItem>
                        <asp:ListItem>NC</asp:ListItem>
                        <asp:ListItem>ND</asp:ListItem>
                        <asp:ListItem>NE</asp:ListItem>
                        <asp:ListItem>NH</asp:ListItem>
                        <asp:ListItem>NJ</asp:ListItem>
                        <asp:ListItem>NM</asp:ListItem>
                        <asp:ListItem>NV</asp:ListItem>
                        <asp:ListItem>NY</asp:ListItem>
                        <asp:ListItem>OH</asp:ListItem>
                        <asp:ListItem>OK</asp:ListItem>
                        <asp:ListItem>OR</asp:ListItem>
                        <asp:ListItem>PA</asp:ListItem>
                        <asp:ListItem>PR</asp:ListItem>
                        <asp:ListItem>PW</asp:ListItem>
                        <asp:ListItem>RI</asp:ListItem>
                        <asp:ListItem>SC</asp:ListItem>
                        <asp:ListItem>SD</asp:ListItem>
                        <asp:ListItem>TN</asp:ListItem>
                        <asp:ListItem>TX</asp:ListItem>
                        <asp:ListItem>UT</asp:ListItem>
                        <asp:ListItem>VA</asp:ListItem>
                        <asp:ListItem>VI</asp:ListItem>
                        <asp:ListItem>VT</asp:ListItem>
                        <asp:ListItem>WA</asp:ListItem>
                        <asp:ListItem>WI</asp:ListItem>
                        <asp:ListItem>WV</asp:ListItem>
                        <asp:ListItem>WY</asp:ListItem>
                    </asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop8" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl9" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox9" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="HealthCondDrop9" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="JobPosDrop9" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop9" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl10" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox10" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="DeptDrop10" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="JobPosDrop10" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="MedDrop10" runat="server" CssClass="form-control"></asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl11" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox11" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="DeptDrop11" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="MemStatDrop11" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop11" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
					</asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl12" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox12" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="HealthCondDrop12" runat="server" CssClass="form-control"></asp:DropDownList></div>
                    <div class="col-md-5"><asp:DropDownList ID="UnitDrop12" runat="server" CssClass="form-control">
                        <asp:ListItem>bg</asp:ListItem>
                        <asp:ListItem>c</asp:ListItem>
                        <asp:ListItem>cc</asp:ListItem>
                        <asp:ListItem>cm</asp:ListItem>
                        <asp:ListItem>ft</asp:ListItem>
                        <asp:ListItem>g</asp:ListItem>
                        <asp:ListItem>ga</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>km</asp:ListItem>
                        <asp:ListItem>l</asp:ListItem>
                        <asp:ListItem>lb</asp:ListItem>
                        <asp:ListItem>m</asp:ListItem>
                        <asp:ListItem>mg</asp:ListItem>
                        <asp:ListItem>ml</asp:ListItem>
                        <asp:ListItem>mm</asp:ListItem>
                        <asp:ListItem>oz</asp:ListItem>
                        <asp:ListItem>p</asp:ListItem>
                        <asp:ListItem>pk</asp:ListItem>
                        <asp:ListItem>qt</asp:ListItem>
                        <asp:ListItem>un</asp:ListItem>
                        <asp:ListItem>yd</asp:ListItem>
                    </asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl13" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox13" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="HealthCondDrop13" runat="server" CssClass="form-control"></asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl14" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox14" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl15" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox15" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl16" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox16" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl17" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox17" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl18" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox18" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
				</div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl19" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox19" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="EcoDrop19" runat="server" CssClass="form-control"></asp:DropDownList></div>
                </div>

                <div class="form-group">
                    <asp:Label ID="InsertLbl20" runat="server" CssClass="control-label col-md-3" Text="Default"></asp:Label>
                    <asp:TextBox ID="InsertBox20" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                    <div class="col-md-5"><asp:DropDownList ID="SectDrop20" runat="server" CssClass="form-control"></asp:DropDownList></div>
                </div>
            </div>
        </div>

        <!----- RIGHT PANEL ----->
        <div class ="col-md-5">
            <div class="form-horizontal">
                <h2>View/Update Existing Record</h2>

                <!----- TABLE SELECTION DROPDOWN ----->
                <div class="form-group">
                    <asp:Label ID="QueryLabel" runat="server" CssClass="control-label col-md-3">Record Type</asp:Label>
                    <div class="col-md-5">
                        <asp:DropDownList ID="QueryDropDown" AutoPostback="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="QueryDropDown_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Animal</asp:ListItem>
                            <asp:ListItem>Animal Handler</asp:ListItem>
                            <asp:ListItem>Contact</asp:ListItem>
                            <asp:ListItem>Diet</asp:ListItem>
                            <asp:ListItem>Employee</asp:ListItem>
                            <asp:ListItem>(ENUM) Department</asp:ListItem>
                            <asp:ListItem>(ENUM) Diet Type</asp:ListItem>
                            <asp:ListItem>(ENUM) Ecosytem</asp:ListItem>
                            <asp:ListItem>(ENUM) Facility Status</asp:ListItem>
                            <asp:ListItem>(ENUM) Facility Type</asp:ListItem>
                            <asp:ListItem>(ENUM) Health Condition</asp:ListItem>
                            <asp:ListItem>(ENUM) Job Position</asp:ListItem>
                            <asp:ListItem>(ENUM) Medication</asp:ListItem>
                            <asp:ListItem>(ENUM) Membership Status</asp:ListItem>
                            <asp:ListItem>(ENUM) Membership Type</asp:ListItem>
                            <asp:ListItem>(ENUM) Section</asp:ListItem>
                            <asp:ListItem>(ENUM) Species</asp:ListItem>
                            <asp:ListItem>(ENUM) State</asp:ListItem>
                            <asp:ListItem>(ENUM) Units of Measure</asp:ListItem>
                            <asp:ListItem>(ENUM) Work Order Type</asp:ListItem>
                            <asp:ListItem>Exhibit</asp:ListItem>
                            <asp:ListItem>Facility</asp:ListItem>
                            <asp:ListItem>Health Profile</asp:ListItem>
                            <asp:ListItem>Membership</asp:ListItem>
                            <asp:ListItem>Prescription</asp:ListItem>
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

                <!----- SEARCH BUTTONS ----->
                <div class="form-group">
                    <asp:Button ID="SearchRecordBtn" runat="server" Text="Find Record" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="SearchRecordBtn_Click"/>
                    <asp:Button ID="ViewTableBtn" runat="server" Text="View Table" CssClass="btn btn-default col-md-offset-3 col-md-3" OnClick="ViewTableBtn_Click"/>
                </div>

                <!----- QUERY RESULTS GRIDS ----->
                <div class="form-group">
                    <asp:GridView ID="RecordGrid" runat="server" EmptyDataText="Error: Please enter a valid ID."></asp:GridView>
                </div>

                <div class="form-group">
                    <asp:GridView ID="TableGrid" runat="server" EmptyDataText="Table is Empty"></asp:GridView>
                </div>

                 <!----- UPDATE FORM ----->
                <div class="row">
                    <asp:Button ID="UpdateBtn" runat="server" Text="Update Record" CssClass="btn btn-default col-md-3" OnClick="UpdateBtn_Click"/>
                </div>

                <div class="row">
                    <asp:Label ID="UpdateLbl" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="KeyBox" runat="server" CssClass="form-control col-md-3"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="UpdateBox1" runat="server" CssClass="form-control col-md-1"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="UpdateBox2" runat="server" CssClass="form-control col-md-1"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="UpdateBox3" runat="server" CssClass="form-control col-md-1"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="UpdateBox4" runat="server" CssClass="form-control col-md-1"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="UpdateBox5" runat="server" CssClass="form-control col-md-1"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="UpdateBox6" runat="server" CssClass="form-control col-md-1"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" CssClass="control-label col-md-3" Text="Record to Update"></asp:Label>
                    <asp:TextBox ID="UpdateBox7" runat="server" CssClass="form-control col-md-1"></asp:TextBox>
                </div>
            </div>
        </div>
</asp:Content>
