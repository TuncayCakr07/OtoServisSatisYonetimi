<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="OtoServisWepUI.Menu" %>

<ul id="Menu">
    <li>
        <a href="/AnaMenu.aspx">Ana Menü</a>
    </li>
    <li>
        <a href="/AracYonetimi.aspx">Araç Yönetimi</a>
    </li>

    <li>
        <a href="/KullaniciYonetimi.aspx">Kullanıcı Yönetimi</a>
    </li>

    <li>
        <a href="/MarkaYonetimi.aspx">Marka Yönetimi</a>
    </li>

    <li>
        <a href="/MusteriYonetimi.aspx">Müşteri Yönetimi</a>
    </li>

    <li>
        <a href="/RolYonetimi.aspx">Rol Yönetimi</a>
    </li>

    <li>
        <a href="/SatisYonetimi.aspx">Satış Yönetimi</a>
    </li>

    <li>
        <a href="/ServisYonetimi.aspx">Servis Yönetimi</a>
    </li>

    <asp:LinkButton ID="lbCikis" runat="server">Çıkış</asp:LinkButton>

</ul>
