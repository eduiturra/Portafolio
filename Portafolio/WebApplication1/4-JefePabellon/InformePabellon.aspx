<%@ Page Title="" Language="C#" MasterPageFile="~/4-JefePabellon/JefePabellon.Master"
    AutoEventWireup="true" CodeBehind="InformePabellon.aspx.cs" Inherits="WebApplication1._4_JefePabellon.InformePabellon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="col-xs-3">
        <h2>
            Buscar</h2>
                 
        <div class="form-group">
            <label for="ejemplo_email_1">
                Especialidad</label>
            <asp:DropDownList ID="cboEspecialista" runat="server" CssClass="form-control input-sm"
                OnSelectedIndexChanged="cboEspecialista_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="ejemplo_email_1">
                Periodo</label>&nbsp;<asp:DropDownList ID="cboPeriodo" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="cboPeriodo_SelectedIndexChanged" 
                AutoPostBack="True">
                    <asp:ListItem Selected="True" Value="[Seleccione]">[Seleccione]</asp:ListItem>
                    <asp:ListItem>1 día</asp:ListItem>
                    <asp:ListItem>1 mes</asp:ListItem>
                </asp:DropDownList>
        </div>
         <div id="uno" runat="server" class="form-group">
            <label for="ejemplo_email_1">
                Mes</label>&nbsp;<asp:DropDownList ID="cboMes" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="cboPeriodo_SelectedIndexChanged">
                    <asp:ListItem>ENERO</asp:ListItem>
                    <asp:ListItem>FEBRERO</asp:ListItem>
                    <asp:ListItem>MARZO</asp:ListItem>
                    <asp:ListItem>ABRIL</asp:ListItem>
                    <asp:ListItem>MAYO</asp:ListItem>
                    <asp:ListItem>JUNIO</asp:ListItem>
                    <asp:ListItem>JULIO</asp:ListItem>
                    <asp:ListItem>AGOSTO</asp:ListItem>
                    <asp:ListItem>SEPTIEMBRE</asp:ListItem>
                    <asp:ListItem>OCTUBRE</asp:ListItem>
                    <asp:ListItem>NOVIEMBRE</asp:ListItem>
                    <asp:ListItem>DICIEMBRE</asp:ListItem>
                </asp:DropDownList>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
            BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
            Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" 
            Visible="False">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <asp:Button ID="btnBuscar" class="btn btn-default" runat="server" Style="height: 26px;
            margin-top: 20px;" Text="Buscar" OnClick="btnBuscar_Click" />
      
    </div>
    <div style="margin-top:80px; top: 0px; left: 0px;" runat="server" id="mostrar" 
        class="col-xs-4">
      <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </div>
</asp:Content>
