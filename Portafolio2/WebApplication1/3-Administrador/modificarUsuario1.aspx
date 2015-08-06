<%@ Page Title="" Language="C#" MasterPageFile="~/3-Administrador/Site3.Master" AutoEventWireup="true" CodeBehind="modificarUsuario1.aspx.cs" Inherits="WebApplication1.modificarUsuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-4">
    </div>
    <div class="col-md-4">
   
    <center>
    <h3 style="margin-bottom:20px;margin-top:50px;">Eliminar y/o Modificar Usuarios
    </h3>
    

        <asp:GridView ID="GVUsuarios" runat="server" 
        onselectedindexchanged="GVUsuarios_SelectedIndexChanged">
    </asp:GridView>
    
     </div>
<div class="col-md-4">
    </div>
    
    </center>
</asp:Content>
