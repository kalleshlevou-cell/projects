<%@ Page Title="" Language="C#" MasterPageFile="~/VDoctor/DoctorMP.Master" AutoEventWireup="true" CodeBehind="AddHistory.aspx.cs" Inherits="patternPrediction.VDoctor.AddHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">

     <div class="article">
          <h2><span>Add</span> History </h2>
          
          <p class="infopost"></p>

        
         <br />

            <table style="width: 70%;">
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td align="center" class="style9">
                                                   </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                                <td>
                                                   <fieldset>
                                        <legend>History</legend>
                                        <table align="center" style="width: 100%;">
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                           
                                          <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    <strong>Farmer Id</strong></td>
                                                <td>
                                                    <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                        ControlToValidate="txtName" CssClass="validation" ErrorMessage="*" 
                                                        ToolTip="Enter Name" ValidationGroup="a">Enter Name</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td class="style1">
                                                    </td>
                                                <td class="style1">
                                                    </td>
                                                <td class="style1">
                                                    &nbsp;</td>
                                                <td class="style1">
                                                    </td>
                                            </tr>
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td>
                                                   
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    <strong>Description</strong></td>
                                                <td>
                                                    <asp:TextBox ID="txtDesc" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                        ControlToValidate="txtDesc" CssClass="validation" ErrorMessage="*" 
                                                        ToolTip="Enter Desc" ValidationGroup="a">Enter Desc</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                           
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    <strong>Symptoms</strong></td>
                                                <td>
                                                    <asp:TextBox ID="txtSymptoms" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                        ControlToValidate="txtSymptoms" CssClass="validation" ErrorMessage="*" 
                                                        ToolTip="Enter Symptoms" ValidationGroup="a">Enter Symptoms</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                          
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    <strong>Disease</strong></td>
                                                <td>
                                                    <asp:TextBox ID="txtDisease" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                        ControlToValidate="txtDisease" CssClass="validation" ErrorMessage="*" 
                                                        ToolTip="Enter Disease" ValidationGroup="a">Enter Disease</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td>
                                                    </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    <strong>Treatments</strong></td>
                                                <td>
                                                    <asp:TextBox ID="txtTreatment" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                        ControlToValidate="txtTreatment" CssClass="validation" ErrorMessage="*" 
                                                        ToolTip="Enter Treatment" ValidationGroup="a">Enter Treatment</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                           
                                         
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td>
                                                    <asp:Button ID="btnIC" runat="server" onclick="btnIC_Click" Text="Add" 
                                                        ValidationGroup="a" Width="75px" />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                        </fieldset>  
                                                </td>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                       
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
                                        <br />

    <br />




          </div>


    </asp:Panel>
</asp:Content>
