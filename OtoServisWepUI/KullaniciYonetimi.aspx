<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="KullaniciYonetimi.aspx.cs" Inherits="OtoServisWepUI.KullaniciYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Kullanıcı Yonetimi</h1>
    <div>
    <asp:GridView ID="dgvKullanicilar" runat="server" CellPadding="5" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvKullanicilar_SelectedIndexChanged">
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

    &nbsp;
        <br />
        <table class="auto-style1">
            <tr>
                <td>Adı:</td>
                <td>
                    <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Soyadı:</td>
                <td>
                    <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>E-Mail:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Telefon:</td>
                <td>
                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kullanıcı Adı:</td>
                <td>
                    <asp:TextBox ID="TxtKullaniciAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Şifre:</td>
                <td>
                    <asp:TextBox ID="TxtSifre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Durum(Aktif-Pasif)</td>
                <td>
                    <asp:CheckBox ID="cbDurum" runat="server" Text="Aktif - Pasif" />
                </td>
            </tr>
            <tr>
                <td>Kullanıcı Rolü:</td>
                <td>
                    <asp:DropDownList ID="cbKullaniciRol" runat="server" DataTextField="Adi" DataValueField="Id">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Kayıt Tarihi:</td>
                <td>
                    <asp:Label ID="lblKayitTarihi" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="EKLE" />
                    <asp:Button ID="BtnGuncelle" runat="server" OnClick="BtnGuncelle_Click" Text="GÜNCELLE" />
                    <asp:Button ID="BtnSil" runat="server" OnClick="BtnSil_Click" Text="SİL" />
                </td>
            </tr>
        </table>

    &nbsp;<br />

    </div>
</asp:Content>
