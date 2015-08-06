<%@ Page Title="" Language="C#" MasterPageFile="~/1-EnfermeraAgenda/Enfermera.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="col-xs-3">
<h2>Buscar</h2>
<div class="form-group">
    <label for="ejemplo_email_1">
        Especialidad</label> 
    <asp:DropDownList ID="cboEspecialista2" runat="server" 
        CssClass="form-control input-sm" 
        onselectedindexchanged="cboEspecialista2_SelectedIndexChanged" 
        AutoPostBack="True">
    
    </asp:DropDownList>
    </div>
    <div class="form-group">
                <label for="ejemplo_email_1">
                    Pabellon</label>&nbsp;<asp:DropDownList ID="cboPabellon2" runat="server" Enabled="False"
                        CssClass="form-control input-sm" 
                    onselectedindexchanged="cboPabellon2_SelectedIndexChanged">
                    </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ejemplo_email_1">
                    Paciente</label>
                <asp:DropDownList ID="cboPaciente2" runat="server" CssClass="form-control input-sm" 
                    onselectedindexchanged="cboPaciente2_SelectedIndexChanged">
                    
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
    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
        Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
    <WeekendDayStyle BackColor="#CCCCFF" />
    </asp:Calendar>      
            <asp:Button ID="btnBuscar" class="btn btn-default" runat="server" 
                Style="height: 26px;margin-top:20px;" Text="Buscar" 
        onclick="btnBuscar_Click" />
       
 </div>

<div style="margin-top:90px;" class="col-xs-7">
 <asp:GridView Style="height: 26px;margin-top:20px;margin-bottom:50px;" ID="GridView1" runat="server" 
    
    onselectedindexchanged="GridView1_SelectedIndexChanged1" 
    AutoGenerateColumns="False" DataKeyNames="id" BackColor="White" 
        BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
>
<RowStyle HorizontalAlign="Center"/>
            <Columns>
                <asp:TemplateField HeaderText="Fecha">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFecha" runat="server" Text='<%# Bind("Fecha") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblFecha" runat="server" Text='<%# Bind("Fecha") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>     
                
                <asp:TemplateField HeaderText="HoraInicio">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTipo" runat="server" Text='<%# Bind("HoraInicio") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblTipo" runat="server" Text='<%# Bind("HoraInicio") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Duracion">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownPaciente" runat="server" Text='<%# Bind("Duracion") %>'>
                        </asp:DropDownList>
               </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPaciente" runat="server" Text='<%# Bind("Duracion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                 <asp:TemplateField HeaderText="Aseo">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownAseo" runat="server" Text='<%# Bind("Aseo") %>'>
                        </asp:DropDownList>
               </EditItemTemplate>
                     <ItemTemplate>
                        <asp:Label ID="lblAseo" runat="server" Text='<%# Bind("Aseo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
               
                <asp:TemplateField HeaderText="Cirujano">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownPaciente" runat="server" Text='<%# Bind("Cirujano") %>'>
                        </asp:DropDownList>
               </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPaciente" runat="server" Text='<%# Bind("Cirujano") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Paciente">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownPaciente" runat="server" Text='<%# Bind("Paciente") %>'>
                        </asp:DropDownList>
               </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPaciente" runat="server" Text='<%# Bind("Paciente") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
             
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" 
                    SelectText="Modificar" />
            </Columns>
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
