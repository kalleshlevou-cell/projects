<%@ Page Title="" Language="C#" MasterPageFile="~/VDoctor/DoctorMP.Master" AutoEventWireup="true" CodeBehind="frmPrediction.aspx.cs" Inherits="patternPrediction.VDoctor.frmPrediction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server">

     <div class="article">
          <h2><span>Cattle Disease</span> Prediction!!</h2>
          
          <p class="infopost"></p>

         <br />
         <asp:Panel ID="Panel2" runat="server" Visible="True">
          <h2><strong>Symptoms:</strong> </h2>
         <p>
             <table style="width:100%;">
                 <tr>
                     <td>
                         <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">frothy-salivation</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">reduced-appetite</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">resistance-oralExamination</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">mouth-ulcer</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">vesicles</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click">gas-bloat</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">ptyyalism</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">nasal-discharge</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">asphyxia</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">bruxism</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click">bloat</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton12" runat="server" onclick="LinkButton12_Click">increased-salivation</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton13" runat="server" onclick="LinkButton13_Click">difficulty-swallowing</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton14" runat="server" onclick="LinkButton14_Click">shallow-breathing</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton15" runat="server" onclick="LinkButton15_Click">coughing</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         <asp:LinkButton ID="LinkButton16" runat="server" onclick="LinkButton16_Click">anorexia</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton17" runat="server" onclick="LinkButton17_Click">recurrent-bloat</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton18" runat="server" onclick="LinkButton18_Click">decreased-milk</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton19" runat="server" onclick="LinkButton19_Click">weight-loss</asp:LinkButton>
                     </td>
                     <td>
                         <asp:LinkButton ID="LinkButton20" runat="server" onclick="LinkButton20_Click">reduced-appetite</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton21" runat="server" onclick="LinkButton21_Click">diarrhea</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton22" runat="server" onclick="LinkButton22_Click">Increased-heart-rate</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton23" runat="server" onclick="LinkButton23_Click">Increased-breathing</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton24" runat="server" onclick="LinkButton24_Click">decreased-rumen-motility</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton25" runat="server" onclick="LinkButton25_Click">fever</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton26" runat="server" onclick="LinkButton26_Click">poorly-digested</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton27" runat="server" onclick="LinkButton27_Click">pain</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton28" runat="server" onclick="LinkButton28_Click">dysentery</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton29" runat="server" onclick="LinkButton29_Click">abdominal-pain</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton30" runat="server" onclick="LinkButton30_Click">mucosal-damage</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton31" runat="server" onclick="LinkButton31_Click">mucosal-petechiation</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton32" runat="server" onclick="LinkButton32_Click">GI-hemorrhage</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton33" runat="server" onclick="LinkButton33_Click">anorexia</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton34" runat="server" onclick="LinkButton34_Click">sunken-eyes</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton35" runat="server" onclick="LinkButton35_Click">twisting-stomach</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton36" runat="server" onclick="LinkButton36_Click">rectal-pain</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton37" runat="server" onclick="LinkButton37_Click">bleeding</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton38" runat="server" onclick="LinkButton38_Click">discharge</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton39" runat="server" onclick="LinkButton39_Click">lameness</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton40" runat="server" onclick="LinkButton40_Click">sever-anemia</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton41" runat="server" onclick="LinkButton41_Click">Anemia</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton42" runat="server" onclick="LinkButton42_Click">colic-diarrhoea</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton43" runat="server" onclick="LinkButton43_Click">respiratory-noise</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton44" runat="server" onclick="LinkButton44_Click">dysphagia</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton45" runat="server" onclick="LinkButton45_Click">Increased-respiratory-rate</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton46" runat="server" onclick="LinkButton46_Click">dyspnea</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton47" runat="server" onclick="LinkButton47_Click">constipation</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton48" runat="server" onclick="LinkButton48_Click">grey/white-skin</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton49" runat="server" onclick="LinkButton49_Click">ash-skin</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton50" runat="server" onclick="LinkButton50_Click">red-patches</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton51" runat="server" onclick="LinkButton51_Click">papules</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton52" runat="server" onclick="LinkButton52_Click">nodules</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton53" runat="server" onclick="LinkButton53_Click">hair-loss</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton54" runat="server" onclick="LinkButton54_Click">thickened-skin</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton55" runat="server" onclick="LinkButton55_Click">lesions</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton56" runat="server" onclick="LinkButton56_Click">itching</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton57" runat="server" onclick="LinkButton57_Click">skin-thicken</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton58" runat="server" onclick="LinkButton58_Click">folds</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton59" runat="server" onclick="LinkButton59_Click">Pruritus</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton60" runat="server" onclick="LinkButton60_Click">vulvar-swelling</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton61" runat="server" onclick="LinkButton61_Click">labia-swelling</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton62" runat="server" onclick="LinkButton62_Click">vulvar-discharge</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton63" runat="server" onclick="LinkButton63_Click">vaginal-mucosa</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton64" runat="server" onclick="LinkButton64_Click">straining-urination</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton65" runat="server" onclick="LinkButton65_Click">grayish-discharge</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton66" runat="server" onclick="LinkButton66_Click">pale-yellow-discharge</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton67" runat="server" onclick="LinkButton67_Click">weakness</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton68" runat="server" onclick="LinkButton68_Click">fowl-smell</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton69" runat="server" onclick="LinkButton69_Click">arch-back</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton70" runat="server" onclick="LinkButton70_Click">deacreased-urination</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton71" runat="server" onclick="LinkButton71_Click">uterus-pus</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton72" runat="server" onclick="LinkButton72_Click">discharge-vulva</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton73" runat="server" onclick="LinkButton73_Click">swelling-abdomen</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton74" runat="server" onclick="LinkButton74_Click">enlarged-uterus</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton75" runat="server" onclick="LinkButton75_Click">red-brown-fluid</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton76" runat="server" onclick="LinkButton76_Click">uterine-discharge</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton77" runat="server" onclick="LinkButton77_Click">foetid-odour</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton78" runat="server" onclick="LinkButton78_Click">laminitis</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton79" runat="server" onclick="LinkButton79_Click">infection-uterus</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton80" runat="server" onclick="LinkButton80_Click">focal-hemorrhages</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton81" runat="server" onclick="LinkButton81_Click">subcutaneous-tissues</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton82" runat="server" onclick="LinkButton82_Click">bleeding-spots</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton83" runat="server" onclick="LinkButton83_Click">blood-from-skin</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton84" runat="server" onclick="LinkButton84_Click">tearing,spasms-lids</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton85" runat="server" onclick="LinkButton85_Click">squinting</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton86" runat="server" onclick="LinkButton86_Click">spilling-tears</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton87" runat="server" onclick="LinkButton87_Click">epiphora</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton88" runat="server" onclick="LinkButton88_Click">avoidance-sunlight</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton89" runat="server" onclick="LinkButton89_Click">photophobia</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton90" runat="server" onclick="LinkButton90_Click">discharge-eye</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton91" runat="server" onclick="LinkButton91_Click">corneal-ulcers</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton92" runat="server" onclick="LinkButton92_Click">weeping</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton93" runat="server" onclick="LinkButton93_Click">closure-pain</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton94" runat="server" onclick="LinkButton94_Click">cornea-cloudy</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton95" runat="server" onclick="LinkButton95_Click">cornea-white</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton96" runat="server" onclick="LinkButton96_Click">eye-pain</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton97" runat="server" onclick="LinkButton97_Click">bleeding-nostril</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton98" runat="server" onclick="LinkButton98_Click">bleeding-eyeball</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton99" runat="server" onclick="LinkButton99_Click">bloody</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton100" runat="server" onclick="LinkButton100_Click">ulcerated</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton101" runat="server" onclick="LinkButton101_Click">friable</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton102" runat="server" onclick="LinkButton102_Click">foul-smelling</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton103" runat="server" onclick="LinkButton103_Click">mass-eye</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton104" runat="server" onclick="LinkButton104_Click">snoring</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton105" runat="server" onclick="LinkButton105_Click">nodules</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton106" runat="server" onclick="LinkButton106_Click">febrile</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton107" runat="server" onclick="LinkButton107_Click">anorectic</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton108" runat="server" onclick="LinkButton108_Click">ear-pain</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton109" runat="server" onclick="LinkButton109_Click">head-shaking</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton110" runat="server" onclick="LinkButton110_Click">facial-nerve-paralysis</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton111" runat="server" onclick="LinkButton111_Click">red-gum</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton112" runat="server" onclick="LinkButton112_Click">salivation</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton113" runat="server" onclick="LinkButton113_Click">difficult-open-mouth</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton114" runat="server" onclick="LinkButton114_Click">staggering</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton115" runat="server" onclick="LinkButton115_Click">trembling</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton116" runat="server" onclick="LinkButton116_Click">breathing-difficulty</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton117" runat="server" onclick="LinkButton117_Click">convulsions</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton118" runat="server" onclick="LinkButton118_Click">bloat</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton119" runat="server" onclick="LinkButton119_Click">swollen-thigh</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton120" runat="server" onclick="LinkButton120_Click">sound-thigh</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton121" runat="server" onclick="LinkButton121_Click">salivation</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton122" runat="server" onclick="LinkButton122_Click">swelling-throat</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton123" runat="server" onclick="LinkButton123_Click">drooling</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton124" runat="server" onclick="LinkButton124_Click">slobbering</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton125" runat="server" onclick="LinkButton125_Click">smacking-lips</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton126" runat="server" onclick="LinkButton126_Click">shivering</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton127" runat="server" onclick="LinkButton127_Click">blisters</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton128" runat="server" onclick="LinkButton128_Click">swollen-udder</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton129" runat="server" onclick="LinkButton129_Click">flabes</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton130" runat="server" onclick="LinkButton130_Click">blood-millshardness</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton131" runat="server" onclick="LinkButton131_Click">reddening</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton132" runat="server" onclick="LinkButton132_Click">fowl-smell</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton133" runat="server" onclick="LinkButton133_Click">high-fever</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton134" runat="server" onclick="LinkButton134_Click">abortion</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton135" runat="server" onclick="LinkButton135_Click">ocular-discharge</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton136" runat="server" onclick="LinkButton136_Click">seizures</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton137" runat="server" onclick="LinkButton137_Click">coffee-colour-urine</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton138" runat="server" onclick="LinkButton138_Click">jaundice</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton139" runat="server" onclick="LinkButton139_Click">brown-urine</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton140" runat="server" onclick="LinkButton140_Click">rapid-pulse</asp:LinkButton>
                     </td>
                 </tr>
                  <tr>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton141" runat="server" onclick="LinkButton141_Click">attacking-animals</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton142" runat="server" onclick="LinkButton142_Click">aggressive-behavior</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton143" runat="server" onclick="LinkButton143_Click">hyper-salivation</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton144" runat="server" onclick="LinkButton144_Click">tachypnoea</asp:LinkButton>
                     </td>
                     <td class="style1">
                         <asp:LinkButton ID="LinkButton145" runat="server" onclick="LinkButton145_Click">hypoglucemia</asp:LinkButton>
                     </td>
                 </tr>
             </table>
                                     </p>
            
         </asp:Panel>

        

                                        <asp:Button ID="Button2" runat="server" 
              Height="60px" onclick="Button2_Click" Text="Get Symptoms" Width="250px" />

        

                                        <br />
      <table style="width: 94%;">
          <tr>
              <td>
                  &nbsp;</td>
              <td>
                  &nbsp;</td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  <b>Enter Symptoms</b></td>
              <td>
                  &nbsp; <span>
                  <asp:TextBox ID="txtSymptoms" runat="server" Height="250px" 
                      TextMode="MultiLine" Width="600px"></asp:TextBox>
                  </span>
              </td>
              <td>
                  &nbsp; <span>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="txtSymptoms" CssClass="validation" 
                      ErrorMessage="Enter Symptoms" ToolTip="Enter Symptoms" ValidationGroup="pwd"></asp:RequiredFieldValidator>
                  </span>
              </td>
          </tr>
          <tr>
              <td>
                  &nbsp;</td>
              <td>
                  &nbsp;</td>
              <td>
                  &nbsp;</td>
          </tr>
          <tr>
              <td>
                  &nbsp;</td>
              <td>
                  <span>
                  <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                      Text="Predict Disease" ValidationGroup="pwd" />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  </span>
                  <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                      Text="Refresh" />
              </td>
              <td>
                  &nbsp;</td>
          </tr>
      </table>


          <br />
          <h2>Disease Name:</h2>
          <asp:LinkButton ID="lbtnDiseaseName" runat="server" 
              onclick="lbtnDiseaseName_Click"></asp:LinkButton>
          <br />
          <br />
          <asp:Label ID="lblTreatment" runat="server"></asp:Label>


    <br />

    <br />
          <br />

         <p></p>
   
      <p></p>
     <br />


          </div>


    </asp:Panel>

</asp:Content>
