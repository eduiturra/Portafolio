<%@ Page Title="" Language="C#" MasterPageFile="~/3-Administrador/Site3.Master" AutoEventWireup="true" CodeBehind="crearUsuario.aspx.cs" Inherits="WebApplication1.crearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    
    <div class="col-md-4">
   
    
    
    <h3 style="margin-bottom:20px;margin-top:20px;">Crear Usuario
    </h3>
     
      
        <div class="form-group">
        <asp:Label ID="Label1" runat="server">Rut</asp:Label>
            <asp:TextBox runat="server" ID="txtRut" CssClass="form-control" placeholder="Rut"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label3" runat="server">Nombre</asp:Label>
            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" placeholder="Nombre"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label4" runat="server">Apellido</asp:Label>
            <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" placeholder="Apellido"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label5" runat="server">Telefono</asp:Label>
            <asp:TextBox runat="server" ID="txtFono" CssClass="form-control" placeholder="Telefono/Celular"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label6" runat="server">Email</asp:Label>
            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" placeholder="Email"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label2" runat="server">Contraseña</asp:Label>
            <asp:TextBox runat="server" ID="txtPass" CssClass="form-control" placeholder="Contraseña"
                required autofocus TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button class="btn btn-lg btn-primary btn-block btn-signin" ID="btnNuevoUsuario" runat="server"
                Text="Aceptar" OnClick="Button1_Click1" />
        </div>
       
    
     </div>
    <div class="col-md-8">
    </div>
    
   
</asp:Content>
