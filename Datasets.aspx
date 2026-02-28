<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMP.Master" AutoEventWireup="true" CodeBehind="Datasets.aspx.cs" Inherits="patternPrediction.Admin.Datasets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">

     <div class="article">
          <h2>Training Datasets!!</h2>
          
          <p class="infopost"></p>

         <br />


			
   <div style="height:550px; width:auto; overflow:auto">
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
           GridLines="None">

    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#7C6F57" />

    <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle ForeColor="White" 
        HorizontalAlign="Center" BackColor="#666666" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" ForeColor="#333333" Font-Bold="True" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />

</asp:GridView>

</div>




     <br />


          </div>


    </asp:Panel>
</asp:Content>
