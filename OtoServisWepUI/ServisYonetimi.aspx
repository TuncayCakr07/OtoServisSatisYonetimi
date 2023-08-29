<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="ServisYonetimi.aspx.cs" Inherits="OtoServisWepUI.ServisYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <h1>Servis Yönetimi</h1>
   <div> 
    <asp:GridView ID="dgvServisler" runat="server" CellPadding="5" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvServisler_SelectedIndexChanged">
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

        <table class="auto-style1">
            <tr>
                <td>Giriş Tarihi:</td>
                <td>
                    <asp:Calendar ID="dtServiseGelisTarihi" runat="server"></asp:Calendar>
                </td>
                <td>Çıkış Tarihi:</td>
                <td>
                    <asp:Calendar ID="dtCikisTarihi" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>Araç Sorunu:</td>
                <td>
                    <asp:TextBox ID="TxtAracSorunu" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtAracSorunu" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Boş Geçilemez!</asp:RequiredFieldValidator>
                </td>
                <td>Araç Plaka:</td>
                <td>
                    <asp:TextBox ID="TxtAracPlaka" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtAracPlaka" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Boş Geçilemez!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Servis Ücreti:</td>
                <td>
                    <asp:TextBox ID="TxtServisUcreti" runat="server"></asp:TextBox>
                </td>
                <td>Araç Marka:</td>
                <td>
                    <asp:TextBox ID="TxtMArka" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtMArka" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Boş Geçilemez!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBox ID="cbGaranti" runat="server" Text="Araç Garanti Kapsamında Mı?" />
                </td>
                <td>Model:</td>
                <td>
                    <asp:TextBox ID="TxtModel" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtModel" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Boş Geçilemez!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Yapılan İşlemler:</td>
                <td>
                    <asp:TextBox ID="TxtYapilanİslemler" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>Kasa Tipi:</td>
                <td>
                    <asp:TextBox ID="TxtKasaTipi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Notlar:</td>
                <td>
                    <asp:TextBox ID="TxtNotlar" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>Şase No:</td>
                <td>
                    <asp:TextBox ID="TxtSaseNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
                </td>
                <td colspan="2">
        <asp:Button ID="BtnEkle" runat="server" Text="Ekle" OnClick="BtnEkle_Click" />
        <asp:Button ID="BtnSil" runat="server" Text="Sil" OnClick="BtnSil_Click" ValidationGroup="sil" Width="61px" />
        <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" OnClick="BtnGuncelle_Click" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
