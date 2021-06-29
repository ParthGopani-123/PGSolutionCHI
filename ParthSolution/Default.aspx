<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ParthSolution._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <h1>
        Pets in the house
    </h1>
    <div>
          <asp:GridView UseAccessibleHeader="true" CssClass="table table-condensed table-hover"  ID="gvDetails" runat="server" AlternatingRowStyle-BackColor="YellowGreen"></asp:GridView>
    
    </div>

    


    
</asp:Content>
