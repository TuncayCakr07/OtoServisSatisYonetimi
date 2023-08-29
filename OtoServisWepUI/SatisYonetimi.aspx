<%@ Page Title="" Language="C#" MasterPageFile="~/OtoServisSablon.Master" AutoEventWireup="true" CodeBehind="SatisYonetimi.aspx.cs" Inherits="OtoServisWepUI.SatisYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 217px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <h1>Satış Yönetimi</h1>
   <div> 
    <asp:GridView ID="dgvSatislar" runat="server" CellPadding="5" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvSatislar_SelectedIndexChanged">
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
                <td>Araç:</td>
                <td>
                    <asp:DropDownList ID="cbArac" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Müşteri:</td>
                <td>
                    <asp:DropDownList ID="cbMusteri" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Satış Fiyatı:</td>
                <td>
                    <asp:TextBox ID="TxtSatisFiyati" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Satış Tarihi:</td>
                <td class="auto-style2">
                    <asp:Calendar ID="dtSatisTarihi" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblId" runat="server" Text="0"></asp:Label>
                </td>
                <td>
        <asp:Button ID="BtnEkle" runat="server" Text="Ekle" OnClick="BtnEkle_Click" Width="54px" />
        <asp:Button ID="BtnSil" runat="server" Text="Sil" OnClick="BtnSil_Click" ValidationGroup="sil" Width="61px" />
        <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" OnClick="BtnGuncelle_Click" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
