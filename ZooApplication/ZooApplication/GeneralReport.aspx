<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GeneralReport.aspx.cs" Inherits="ZooApplication.GeneralReport" %><%@ Register assembly="DevExpress.XtraReports.v18.2.Web.WebForms, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" ReportSourceId="GeneralReport">
</dx:ASPxWebDocumentViewer>
</asp:Content>
