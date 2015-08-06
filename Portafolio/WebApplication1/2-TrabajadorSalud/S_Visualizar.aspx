<%@ Page Title="" Language="C#" MasterPageFile="~/2-TrabajadorSalud/Salud.Master"
    AutoEventWireup="true" CodeBehind="S_Visualizar.aspx.cs" Inherits="WebApplication1.S_Visualizar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-xs-3">
        <h2>
            Ver Cirugias</h2>
        <div class="form-group">
            <label for="ejemplo_email_1">
                Especialidad</label>
            <asp:DropDownList ID="cboEspecialista" runat="server" CssClass="form-control input-sm"
                OnSelectedIndexChanged="cboPersonal_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="ejemplo_email_1">
                Pebllon</label>&nbsp;<asp:DropDownList ID="cboPabellon" runat="server" Enabled="False"
                    CssClass="form-control input-sm" OnSelectedIndexChanged="cboNombre_SelectedIndexChanged">
                </asp:DropDownList>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
            BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
            Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
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
    
    <div style="margin-top:80px; top: 0px; left: 0px;" class="col-xs-9">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" Font-Size="Small" 
            onpageindexchanging="GridView1_PageIndexChanging1" PageSize="5">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerSettings Mode="NextPrevious" NextPageText="Siguiente" 
                PreviousPageText="Atras" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#003399" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </div>
    <script>
        $(document).ready(function () {
            setInterval(function () {
                $.ajax({
                    url: "S_Visualizar.aspx/HolaMundo",
                    data: "{}",
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    success: function (response) {
                        var ret = response.d;
                        alert(ret);
                    },
                    error: function (response) {
                        alert("ERROR " + response.status + ' ' + response.statusText);
                    }

                });
            }, 10000);
        });






        

    </script>
</asp:Content>
