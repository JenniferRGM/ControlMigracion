<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarViajero.aspx.cs" Inherits="ControlMigracion.RegistrarViajero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2>Registrar Viajero</h2>
    <label for="txtCedulaPasaporte">Cédula/Pasaporte:</label>
    <asp:TextBox ID="txtCedulaPasaporte" runat="server"></asp:TextBox><br />
    <label for="txtNombre">Nombre:</label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
    <label for="txtSegundoNombre">Segundo Nombre (Opcional):</label>
    <asp:TextBox ID="txtSegundoNombre" runat="server"></asp:TextBox><br />
    <label for="txtApellido1">Primer Apellido:</label>
    <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox><br />
    <label for="txtApellido2">Segundo Apellido:</label>
    <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox><br />
    <label for="txtFechaNacimiento">Fecha de Nacimiento:</label>
    <asp:TextBox ID="txtFechaNacimiento" runat="server"></asp:TextBox><br />
    <label for="txtNacionalidad">Nacionalidad:</label>
    <asp:TextBox ID="txtNacionalidad" runat="server"></asp:TextBox><br />
    <label for="txtCorreo">Correo Electrónico:</label>
    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox><br />
    <label for="ddlSexo">Sexo:</label>
    <asp:DropDownList ID="ddlSexo" runat="server">
        <asp:ListItem Value="M">Masculino</asp:ListItem>
        <asp:ListItem Value="F">Femenino</asp:ListItem>
    </asp:DropDownList><br />
    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Viajero" OnClick="btnRegistrar_Click" /><br />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
</asp:Content>
