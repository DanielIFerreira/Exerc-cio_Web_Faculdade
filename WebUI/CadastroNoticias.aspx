<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroNoticias.aspx.cs" Inherits="WebUI.CadastroNoticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastro de Notícias</h2>
    <p>Código:<asp:TextBox ID="txtCodigo" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>Titulo:<asp:TextBox ID="txtTitulo" runat="server" OnTextChanged="TextBox1_TextChanged" Width="292px"></asp:TextBox>
    </p>
    <p>Data Publicação:
        <asp:TextBox ID="txtDataPublicacao" runat="server"></asp:TextBox>
    </p>
    <p>Texto:
        <asp:TextBox ID="txtTexto" runat="server" Height="141px" TextMode="MultiLine" Width="326px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar" Width="64px" />
    </p>
</asp:Content>
