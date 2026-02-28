<%@ Page Title="" Language="C#" MasterPageFile="~/Farmer/FarmerMaster.Master" AutoEventWireup="true" CodeBehind="_ViewHistory.aspx.cs" Inherits="patternPrediction.Farmer._ViewHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">

     <div class="article">
          <h2><span>View</span> History</h2>
          
          <p class="infopost"></p>

        
         <br />


<table style="width: 100%;">
                                            <tr>
                                                <td class="style9">
                                                     <h2 class="title"><span>View History </span></h2></td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div style="height:400px; width:auto; overflow:auto">
                                                    <asp:Table ID="tblHistory" runat="server">
                                                    </asp:Table>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>

                                        </div>

                                        </asp:Panel>

</asp:Content>
