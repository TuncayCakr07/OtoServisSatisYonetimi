 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OtoServisWepUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Girişi</title>
    <style>
        body{
            background:url(https://png.pngtree.com/background/20211217/original/pngtree-blue-round-technology-dashboard-picture-image_1598386.jpg);
            background-repeat:no-repeat;    
            background-position:center center;
            background-size:cover;
            height:100vh;
            color:white;

        }
       .login{ 
           width:300px; 
           margin:7rem auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
 <div class="login">
       <h1>Kullanıcı Girişi</h1>
     <table>
         <tr> 
             <td>Kullanıcı Adı:</td>
             <td>
                 <asp:TextBox ID="TxtKullaniciAdi" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtKullaniciAdi" ErrorMessage="Boş Geçilemez !" ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
         </tr>
         <tr>
             <td>Şifre:</td>
             <td>
                 <asp:TextBox ID="TxtSifre" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtSifre" ErrorMessage="Boş Geçilemez !" ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
         </tr>
         <tr>
             <td>&nbsp;</td>
             <td>
                 <asp:Button ID="BtnGiris" runat="server" OnClick="BtnGiris_Click" Text="Giriş Yap" />
             </td>
         </tr>
     </table>

 </div>
    </form>
</body>
</html>
