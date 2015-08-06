<%@ Page Title="" Language="C#" MasterPageFile="~/1-EnfermeraAgenda/Enfermera.Master" AutoEventWireup="true" CodeBehind="Modificar2.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
      <div  class="col-md-6">
         <h2>Modificar Cirugía</h2><a style="margin-left:50px;" href="Modificar.aspx">Volver</a>
         
            <div style="margin-top: 10px;" class="form-group">
                <label for="ejemplo_email_1">
                    Especialidad</label>
                <asp:DropDownList ID="cboEspecialista" runat="server" AutoPostBack="True" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="ComboBoxEspecialista_SelectedIndexChanged">
                    
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Pabellon</label>&nbsp;<asp:DropDownList ID="cboPabellon" runat="server" Enabled="False"
                        CssClass="form-control input-sm" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                    </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Paciente</label>
                <asp:DropDownList ID="cboPaciente" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="DropDownList10_SelectedIndexChanged" Enabled="False">
                    
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Cirujano</label>
                <asp:DropDownList ID="cboCirujano" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Enabled="False">
                    
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Anestesista</label>
                <asp:DropDownList ID="cboAnestesista" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Enabled="False">
                    
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Arsenalero</label>
                <asp:DropDownList ID="cboArsenalero" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Enabled="False">
                    
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Técnico Anestesista</label>
                <asp:DropDownList ID="cboTarnestesia" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Enabled="False">
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Enfermero</label>
                <asp:DropDownList ID="cboEnfermero" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Enabled="False">
                  </asp:DropDownList>
            </div>
        </div>
        <div style="margin-top: 50px;" class="col-md-6">
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Calendario</label>
                <asp:Calendar ID="Calendar1" runat="server" Enabled="False" BackColor="White" 
                    BorderColor="#3366CC" Font-Names="Verdana" 
                    Font-Size="8pt" ForeColor="#003399" Height="200px" 
                    Width="220px" SelectedDate="05/21/2015 11:21:24" BorderWidth="1px" 
                    CellPadding="1" DayNameFormat="Shortest">
                    <DayHeaderStyle ForeColor="#336666" 
                        Height="1px" BackColor="#99CCCC" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" ForeColor="#CCFF99" Font-Bold="True" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" Font-Bold="True" 
                        Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" BorderColor="#3366CC" 
                        BorderWidth="1px" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                </asp:Calendar>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Hora Inicio</label>
                <asp:DropDownList ID="cboHora" runat="server" CssClass="form-control input-sm" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
                    Enabled="False">
                    <asp:ListItem>[Seleccione]</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>21:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>23:00</asp:ListItem>
                    <asp:ListItem>00:00</asp:ListItem>
                    <asp:ListItem>01:00</asp:ListItem>
                    <asp:ListItem>02:00</asp:ListItem>
                    <asp:ListItem>03:00</asp:ListItem>
                    <asp:ListItem>04:00</asp:ListItem>
                    <asp:ListItem>05:00</asp:ListItem>
                    <asp:ListItem>06:00</asp:ListItem>
                    <asp:ListItem>07:00</asp:ListItem>
                    </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Duración(Hrs)</label>
                <asp:DropDownList ID="cboDuracion" runat="server" CssClass="form-control input-sm"
                    OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged" Enabled="False">
                    <asp:ListItem>[Seleccione]</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:Button ID="btnGuardar" class="btn btn-default" runat="server" OnClick="btnGuardar_Click"
                Style="height: 26px" Text="Guardar" Enabled="False" />
        </div>
   
</asp:Content>
