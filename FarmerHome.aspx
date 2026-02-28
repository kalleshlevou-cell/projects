<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/FarmerMaster.Master" AutoEventWireup="true" CodeBehind="FarmerHome.aspx.cs" Inherits="patternPrediction.Farmer.FarmerHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">

     <div class="article">
          <h2>Farmer Home Page!!</h2>
          
          <p class="infopost"></p>

        
        <br />

          <table style="width: 100%;">
             <tr>
                 <td>
                     &nbsp;
                     <asp:Label ID="lblAdminId" runat="server"></asp:Label>
                 </td>
                 <td>
                     &nbsp;
                 </td>
                 <td>
                     &nbsp;
                 </td>
             </tr>
            
            
         </table>
            <br />

<p>Farmer modules;</p>
<p>Get Register</p>
<p>Login - here farmer gets login to the application by inputting id and password.</p>
<p>Prediction Module</p>
<p>Change Password- here admin can update password.</p>
<p>Logout - logout from the system.</p>
            

            <marquee scrolldelay="150" behavior="alternate">
          <img src="../images/cattle2.png" width="160" height="100" alt="" /> &nbsp
          <img src="../images/cattle5.gif" width="160" height="100" alt="" /> &nbsp
         <img src="../images/cattle4.jpg" width="160" height="100" alt="" /> &nbsp
          <img src="../images/cattle9.jpg" width="160" height="100" alt="" /></marquee>
            <br />
          </div>


    </asp:Panel>
</asp:Content>
