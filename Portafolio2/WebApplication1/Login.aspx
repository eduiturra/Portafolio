<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
<script type="text/javascript" src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clínica Tercer Milenio</title>
   
</head>
<body style="background-image: url('Imagen/fondo.png'); margin: 50px; background-repeat: no-repeat;
    background-size: 100%;">
    <div class="col-md-4">
    </div>
    <div class="col-md-4">
        <form class="form-signin" runat="server">
      
    <center>
    <h2 style="margin-bottom:20px;">Iniciar Sesión
        </h2>
    </center>
      
        <div class="form-group">
        <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="usuario" CssClass="form-control" placeholder="Rut"
                required autofocus></asp:TextBox>
        </div>
        <div class="form-group">
        <asp:Label ID="Label2" runat="server"></asp:Label>
            <asp:TextBox runat="server" ID="contrasenia" CssClass="form-control" placeholder="Contraseña"
                required autofocus TextMode="Password"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button class="btn btn-lg btn-primary btn-block btn-signin" ID="Button1" runat="server"
                Text="Aceptar" OnClick="Button1_Click1" />
        </div>
        </form>
        <!-- /form -->
    </div>
    <div class="col-md-4">
    </div>
</body>
</html>
