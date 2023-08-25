<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="MarkaYonetimi.aspx.cs" Inherits="OtoServisWepUI.MarkaYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Marka Yönetimi</h1>
    <div> 
     <asp:GridView ID="dgvMarkalar" runat="server" CellPadding="5" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvMarkalar_SelectedIndexChanged">
     <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
     <EditRowStyle BackColor="#999999" />
     <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
     <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
     <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
     <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
     <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
     <SortedAscendingCellStyle BackColor="#E9E7E2" />
     <SortedAscendingHeaderStyle BackColor="#506C8C" />
     <SortedDescendingCellStyle BackColor="#FFFDF8" />
     <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
 </asp:GridView>
    &nbsp;</div>
    <hr />
    <div>
        Marka Adı:<asp:TextBox ID="TxtMarkaAdi" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtMarkaAdi" ErrorMessage="Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <br />
    <div>
        <asp:Button ID="BtnEkle" runat="server" Text="Ekle" OnClick="BtnEkle_Click" />
        <asp:Button ID="BtnSil" runat="server" Text="Sil" OnClick="BtnSil_Click" ValidationGroup="sil" />
        <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" OnClick="BtnGuncelle_Click" />
    </div>
    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
</asp:Content>
