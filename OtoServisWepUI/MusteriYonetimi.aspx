<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="MusteriYonetimi.aspx.cs" Inherits="OtoServisWepUI.MusteriYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Müşteri Yönetimi</h1>
    <div> 
     <asp:GridView ID="dgvMusteriler" runat="server" CellPadding="5" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvMusteriler_SelectedIndexChanged">
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
    &nbsp;&nbsp;</div>
    <hr />
    <div>
        <table class="auto-style1">
            <tr>
                <td>Adı:</td>
                <td>
                    <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAd" ErrorMessage="Boş Geçilemez ! " Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Soyadı:</td>
                <td>
                    <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSoyad" ErrorMessage="Boş Geçilemez ! " Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>E-mail:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Telefon:</td>
                <td>
                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTelefon" ErrorMessage="Boş Geçilemez ! " Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Tc No:</td>
                <td>
                    <asp:TextBox ID="TxtTcno" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtTcno" ErrorMessage="Boş Geçilemez ! " Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Adres:</td>
                <td>
                    <asp:TextBox ID="TxtAdres" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Araç:</td>
                <td>
                    <asp:DropDownList ID="cbAracId" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Notlar:</td>
                <td>
                    <asp:TextBox ID="TxtNotlar" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
                </td>
                <td>
        <asp:Button ID="BtnEkle" runat="server" Text="Ekle" OnClick="BtnEkle_Click" />
        <asp:Button ID="BtnSil" runat="server" Text="Sil" OnClick="BtnSil_Click" ValidationGroup="sil" Width="45px" />
        <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" OnClick="BtnGuncelle_Click" />
                </td>
            </tr>
            </table>
        </div>
</asp:Content>
