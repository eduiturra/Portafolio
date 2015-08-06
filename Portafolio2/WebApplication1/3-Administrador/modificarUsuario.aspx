<%@ Page Title="" Language="C#" MasterPageFile="~/3-Administrador/Site3.Master" AutoEventWireup="true" CodeBehind="modificarUsuario.aspx.cs" Inherits="WebApplication1.modificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="col-md-4">
    </div>
<div class="col-md-4">

    <h2>Modificar</h2>

    <div class="form-group">
                <label for="ejemplo_email_1">
                    Rut Usuario</label>
                     <asp:TextBox runat="server" ID="txtNRut" CssClass="form-control" placeholder="Rut"
                required autofocus></asp:TextBox>
                </div>

    <div class="form-group">
        <asp:Label ID="Label3" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="txtNNombre" CssClass="form-control" placeholder="Nombre"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label4" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="txtNApellido" CssClass="form-control" placeholder="Apellido"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label5" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="txtNFono" CssClass="form-control" placeholder="Telefono/Celular"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label6" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="txtNEmail" CssClass="form-control" placeholder="Email"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label2" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="txtNPass" CssClass="form-control" placeholder="Contraseña"
                required autofocus TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button class="btn btn-lg btn-primary btn-block btn-signin" ID="btnModificarUsuario" runat="server"
                Text="Aceptar" OnClick="Button1_Click1" />
        </div>
</div>
<div class="col-md-4">
    </div>


</asp:Content>
