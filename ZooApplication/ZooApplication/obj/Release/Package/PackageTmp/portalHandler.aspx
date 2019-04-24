<%@ Page Title="Handler Portal" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="portalHandler.aspx.cs" Inherits="ZooApplication.Handler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    



   
    <!----- PAGE TITLE ----->
    <div class="jumbotron">
        <h1>Handler</h1>
    </div>
    <p>

    <asp:TextBox ID="InsertDialog" runat="server" CssClass="form-control col-md-4"></asp:TextBox>
    <br />
    </p>
    <hr />
    <p>
    <br />  
    </p>

     <div class ="col-md-5">
        <div class="form-horizontal">
            <div class="form-group">

    

    <h2>Search Animal :</h2>
    <p>By Animal ID:</p>
    <p>
        <asp:TextBox ID="Animal_ID_Text" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Search!" OnClick="AnimalByID" />
    </p>
    <asp:GridView ID="Grid_Animal_ID" runat="server"> </asp:GridView>
        </div>

    <div class="form-group">

    <p>Search by Species:</p>
    <p>
       
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="List_Species">
        <asp:ListItem Text="Species" Value="1">
        </asp:ListItem>
    </asp:DropDownList>

        
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" Text="Search!" OnClick="List_Species" />
    </p>
    <asp:GridView ID="Grid_Animal_Species" runat="server"> </asp:GridView>

    <p>Show All:</p>
    <p>
        <asp:Button ID="Button3" runat="server" Text="Show All!" OnClick="Show_All_Animals" />
    </p>
    <asp:GridView ID="Grid_All_Animals" runat="server"> </asp:GridView>
    <br />
    </div>
            <h2>View Diets :</h2>
    <p>
        <asp:Button ID="Button4" runat="server" Text="View All Diets!" OnClick="List_Diets" />
    </p>
    <p>&nbsp;</p>
    <br />
    <asp:GridView ID="Grid_Diets" runat="server"> </asp:GridView>
    </div>
    </div>

    <h2>Add Animal :</h2>
    <form id ="animalform" method="get" action="Handler.aspx">
    <p>&nbsp;Name:</p>
    <p>
        <asp:TextBox ID="Add_Name" runat="server"></asp:TextBox>
        </p>
    <p>&nbsp;Species:</p>
    <p>
        <asp:DropDownList ID="DropDownListAddSpecies" runat="server">
        </asp:DropDownList>
        </p>
    <p>Diet:</p>
    <p>
        <asp:DropDownList ID="DropDownListAddDiet" runat="server">
        </asp:DropDownList>
        </p>
    <p>Exhibit:</p>
    <p>
        <asp:DropDownList ID="DropDownListAddExhibit" runat="server">
        </asp:DropDownList>
        </p>
    <p>
        <asp:Button ID="InsertAnimal" runat="server" Text="Add Animal!" OnClick="AddAnimal" />
        </p>
    </form>


    <h2>View Exhibits :</h2>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button5" runat="server" Text="View All Diets!" OnClick="List_Exhibits" />
    </p>
    <asp:GridView ID="Grid_Exhibits" runat="server"> </asp:GridView>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

    <!------------------------------------------------------------------------------------Add to database ----------->

    
   
    
    </asp:Content>

