<%@ Page Title="" Language="C#" MasterPageFile="~/2-TrabajadorSalud/Salud.Master" AutoEventWireup="true" CodeBehind="S_Reportar.aspx.cs" Inherits="WebApplication1.S_Reportar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-6">
    
   
        <h2>Reportar Evento</h2>
            
        <div class="form-group">
            <label for="ejemplo_email_1">
                Asunto</label>
            <asp:DropDownList ID="cboEvento" runat="server"  
                CssClass="form-control input-sm" 
                onselectedindexchanged="cboEvento_SelectedIndexChanged" 
                AutoPostBack="True">
                <asp:ListItem Selected="True" Value="[Seleccione]">[Seleccione]</asp:ListItem>
                <asp:ListItem>Inasistencia del encargado de la salud</asp:ListItem>
                <asp:ListItem>Retraso de personal</asp:ListItem>
                <asp:ListItem>Contingencia de última hora</asp:ListItem>
                <asp:ListItem>Otros</asp:ListItem>
            </asp:DropDownList>
        </div>

         <div class="form-group">
          <label  runat="server" for="ejemplo_email_1" id="lblAsunto">
                Asunto</label>
            <asp:TextBox runat="server" ID="txtAsunto" CssClass="form-control" placeholder="Asunto"
                required autofocus Visible="False" ></asp:TextBox>
        </div>

          <div class="form-group">
            <label for="ejemplo_email_1">
                Descripción</label>
        <textarea runat="server" class="form-control" rows="10" id="txtDescripcion"></textarea>
          </div>

          <div class="form-group">
          <asp:Button ID="btnGuardar" class="btn btn-default" runat="server" OnClick="btnGuardar_Click"
                Style="height: 26px" Text="Enviar" Enabled="True" />
          </div>


       </div>

</asp:Content>
