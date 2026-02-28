<%@ Page Title="" Language="C#" MasterPageFile="~/VDoctor/DoctorMP.Master" AutoEventWireup="true" CodeBehind="Queries.aspx.cs" Inherits="patternPrediction.VDoctor.Queries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">

   <div class="article">
          <h2><span>Farmer</span> Queries</h2>
          
          <p class="infopost"></p>

        

       
			<br />
    <!-- Start contact Area -->  
   
              <br />
              <asp:Label ID="lblCount" runat="server"></asp:Label>
         <br />


            <table align="center" style="width: 77%;">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:ImageButton ID="ImageButton1_Pending" runat="server" 
                                    ImageUrl="~/images/folder-down-icon.jpg" 
                                    onclick="ImageButton1_Pending_Click" />
                            </td>
                            <td>
                                &nbsp;</td>
                            <td align="center">
                                <asp:ImageButton ID="ImageButton2_Answered" runat="server" 
                                    ImageUrl="~/images/folder-edit-icon.jpg" 
                                    onclick="ImageButton2_Answered_Click" />
                            </td>
                        </tr>
                        <tr style="font-size: small">
                            <td align="center">
                                <b>Pending</b></td>
                            <td>
                                <b></b>
                            </td>
                            <td align="center">
                                <b>Answered</b></td>
                        </tr>
                        <tr style="font-size: small">
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>

                    <br />
             
                        <asp:Table ID="Table3" runat="server"  HorizontalAlign="Center">
                        </asp:Table>

<br />


              

    </div>
  <!-- End Contact Area -->


    </asp:Panel>

</asp:Content>
