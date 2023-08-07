<%@ Page Title="Araç Yönetimi" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="AracYonetimi.aspx.cs" Inherits="OtoServisWepUI.AracYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvAraclar" runat="server" CellPadding="5" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvAraclar_SelectedIndexChanged" AutoGenerateSelectButton="True">
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

    <hr />
    <h1>Araç Bilgileri </h1>
    <table class="auto-style1">
        <tr> 
            <td>Marka:</td>
            <td>
                <asp:DropDownList ID="ddlMarkalar" runat="server" DataTextField="Adi" DataValueField="Id">
                </asp:DropDownList>
            </td>
            <td>Model Yılı:</td>
            <td>
                <asp:TextBox ID="TxtModelYili" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtModelYili" ErrorMessage="Model Yılı Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Renk:</td>
            <td>
                <asp:TextBox ID="TxtRenk" runat="server"></asp:TextBox>
            </td>
            <td>Notlar:</td>
            <td>
                <asp:TextBox ID="TxtNotlar" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fiyatı:</td>
            <td>
                <asp:TextBox ID="TxtFiyat" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtFiyat" ErrorMessage="Fiyat Boş Geçilemez!" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>Satış Durumu:</td>
            <td>
                <asp:CheckBox ID="cbSatisDurum" runat="server" Text="(Aktif-Pasif)" />
            </td>
        </tr>
        <tr>
            <td>Modeli:</td>
            <td>
                <asp:TextBox ID="TxtModel" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Kasa Tipi:</td>
            <td>
                <asp:TextBox ID="TxtKasa" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
            </td>
            <td>
                <asp:Button ID="BtnEkle" runat="server" OnClick="BtnEkle_Click" Text="EKLE" />
                <asp:Button ID="BtnGuncelle" runat="server" OnClick="BtnGuncelle_Click" Text="GÜNCELLE" />
                <asp:Button ID="BtnSil" runat="server" OnClick="BtnSil_Click" Text="SİL" ValidationGroup="sil" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
 