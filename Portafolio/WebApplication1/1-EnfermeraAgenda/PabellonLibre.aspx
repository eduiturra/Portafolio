<%@ Page Title="" Language="C#" MasterPageFile="~/1-EnfermeraAgenda/Enfermera.Master" AutoEventWireup="true" CodeBehind="PabellonLibre.aspx.cs" Inherits="WebApplication1.PabellonLibre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-xs-4">
        <h2>
            Ver Personal Disponible</h2>
        <div class="form-group">
            <label for="ejemplo_email_1">
                Personal</label>
            <asp:DropDownList ID="cboPersonal" runat="server" CssClass="form-control input-sm"
                OnSelectedIndexChanged="cboPersonal_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Selected="True" Value="[Seleccione]">[Seleccione]</asp:ListItem>
                <asp:ListItem>Cirujano</asp:ListItem>
                <asp:ListItem>Anestesista</asp:ListItem>
                <asp:ListItem>Enfermera</asp:ListItem>
                <asp:ListItem>Arsernalero/a</asp:ListItem>
                 <asp:ListItem>Técnico Anestesista</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="ejemplo_email_1">
                Nombre</label>&nbsp;<asp:DropDownList ID="cboNombre" runat="server" Enabled="False"
                    CssClass="form-control input-sm" OnSelectedIndexChanged="cboNombre_SelectedIndexChanged">
                </asp:DropDownList>
        </div>
         <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
            BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
            DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
            ForeColor="#003399" Height="200px" Width="220px">
             <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
             <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
             <OtherMonthDayStyle ForeColor="#999999" />
             <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
             <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
             <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                 Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
             <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
             <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <asp:Button ID="btnBuscar" class="btn btn-default" runat="server" Style="height: 26px;
            margin-top: 20px;" Text="Buscar" OnClick="btnBuscar_Click" />
    </div>
    
   
    <div  class="col-xs-6">

    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" 
            BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
   
    </asp:GridView>
    </div>

</asp:Content>

