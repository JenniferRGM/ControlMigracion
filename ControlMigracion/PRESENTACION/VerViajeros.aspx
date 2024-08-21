<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/Site.Master" AutoEventWireup="true" CodeBehind="VerViajeros.aspx.cs" Inherits="ControlMigracion.PRESENTACION.VerViajeros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvViajeros" runat="server" AutoGenerateColumns="False" OnRowEditing="gvViajeros_RowEditing" OnRowDeleting="gvViajeros_RowDeleting" OnRowUpdating="gvViajeros_RowUpdating" OnRowCancelingEdit="gvViajeros_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="IDViajero" HeaderText="ID Viajero" ReadOnly="True" />
            <asp:BoundField DataField="CedulaPasaporte" HeaderText="Cédula/Pasaporte" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="SegundoNombre" HeaderText="Segundo Nombre" />
            <asp:BoundField DataField="Apellido1" HeaderText="Primer Apellido" />
            <asp:BoundField DataField="Apellido2" HeaderText="Segundo Apellido" />
            <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" />
            <asp:BoundField DataField="Nacionalidad" HeaderText="Nacionalidad" />
            <asp:BoundField DataField="Correo" HeaderText="Correo" />
            <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
