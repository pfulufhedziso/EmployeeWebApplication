<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmployeeWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Welcome</h1>
        <h3>Employee Management Web-App</h3>
    </div>
    <div style="text-align:center">
           <a runat="server" href="~/AddData"><input id="button1" type="button" value="Continue"  width: 244px; height: 49px;" style="width: 227px; height: 47px ; border-radius:16px; " class="button"/></a>
        </div>
   
   

</asp:Content>
