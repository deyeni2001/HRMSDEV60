<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRPage.ascx.cs" Inherits="ola.HRMangmntSyst.HRPage" %>

    
<style type="text/css">
    .auto-style1 {
    }
    .auto-style2 {
        width: 496px;
    }
    .auto-style3 {
        height: 23px;
    }
    .auto-style4 {
    }
    .auto-style7 {
        height: 23px;
        width: 238px;
    }
    .auto-style8 {
        width: 136px;
    }
    .auto-style9 {
        height: 23px;
        width: 136px;
    }
    .auto-style11 {
        height: 26px;
    }
    .auto-style18 {
        width: 281px;
    }
    .auto-style19 {
    }
    .auto-style20 {
    }
    .auto-style22 {
        height: 13px;
    }
    .auto-style29 {
        height: 13px;
        width: 177px;
    }
    .auto-style40 {
    }
    .auto-style43 {
    }
    #txtRefContAddr {
        width: 206px;
    }
    #txtRefContAddr0 {
        width: 206px;
    }
    .auto-style54 {
    }
    .auto-style56 {
    }
    .auto-style59 {
    }
    .auto-style61 {
        width: 205px;
    }
    .auto-style65 {
    }
    .auto-style75 {
        height: 23px;
        width: 169px;
    }
    .auto-style79 {
        height: 23px;
        }
    .auto-style80 {
        width: 314px;
    }
    .auto-style86 {
        height: 23px;
        }
    .auto-style87 {
    }
    .auto-style88 {
        height: 23px;
        width: 234px;
    }
    .auto-style89 {
        width: 234px;
    }
    .auto-style90 {
        height: 23px;
        width: 276px;
    }
    .auto-style91 {
        width: 276px;
    }
    .auto-style92 {
        width: 280px;
    }
    .auto-style94 {
    }
    .auto-style96 {
    }
    .auto-style100 {
        width: 307px;
    }
    .auto-style103 {
        width: 220px;
    }
    .auto-style111 {
        height: 23px;
        width: 331px;
    }
    .auto-style112 {
        width: 331px;
    }
    .auto-style117 {
        height: 23px;
    }
    .auto-style119 {
        height: 23px;
        width: 239px;
    }
    .auto-style120 {
        width: 239px;
    }
    .auto-style121 {
        height: 23px;
        width: 226px;
    }
    .auto-style122 {
        width: 226px;
    }
    .auto-style123 {
        width: 172px;
    }
    .auto-style124 {
        height: 23px;
        }
    .auto-style132 {
        width: 16px;
    }
    .auto-style136 {
        width: 185px;
    }
    .auto-style137 {
        height: 23px;
        width: 185px;
    }
    .auto-style142 {
    }
    .auto-style145 {
        height: 13px;
        width: 320px;
    }
    .auto-style146 {
        width: 578px;
    }
    .auto-style149 {
        width: 278px;
    }
    .auto-style154 {
    }
    .auto-style157 {
    }
    .auto-style165 {
    }
    .auto-style167 {
        width: 717px;
    }
    .auto-style168 {
        width: 211px;
    }
    .auto-style173 {
    }
    .auto-style176 {
    }
    .auto-style177 {
        height: 20px;
    }
    .auto-style178 {
        width: 154px;
    }
    .auto-style180 {
    }
    .auto-style182 {
    }
    .auto-style183 {
        height: 23px;
        }
    .auto-style184 {
    }
    .auto-style185 {
        height: 23px;
        width: 278px;
    }
    .auto-style189 {
        height: 25px;
    }
    .auto-style190 {
        height: 25px;
        width: 234px;
    }
    .auto-style191 {
        height: 25px;
        width: 276px;
    }
    .auto-style194 {
        width: 853px;
    }
    .auto-style195 {
        width: 692px;
    }
    .auto-style196 {
        width: 191px;
    }
    .auto-style199 {
        height: 23px;
        width: 245px;
    }
    .auto-style200 {
        width: 245px;
    }
    .auto-style201 {
        height: 23px;
        width: 151px;
    }
    .auto-style202 {
        width: 151px;
    }
    .auto-style203 {
        height: 23px;
        width: 263px;
    }
    .auto-style204 {
        width: 263px;
    }
    .auto-style207 {
        width: 335px;
    }
    .auto-style208 {
        width: 387px;
    }
    .auto-style209 {
        width: 415px;
    }
    .auto-style210 {
        height: 26px;
        width: 415px;
    }
    .auto-style211 {
        width: 431px;
    }
    </style>


<table style="width: 100%;">
    
    <tr>
        <td valign="top">
            <table style="width: 100%;">
                <tr>
                    <td>
             <asp:Button ID="welHometBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Home" Width="150
                 px" OnClick="welHometBtn_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        <%--<asp:Button ID="sendemploy" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Send Offer2" Width="150
                 px" OnClick="sendemploy_Click" Height="45px" />--%>
                         <asp:Button ID="hrEmpAccptMenuBtn" runat="server" Height="45px" Text="Acceptance" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Width="150px" OnClick="hrEmpAccptMenuBtn_Click" />
                    
                       
                    </td>
                   
                </tr>
                <tr>
                    <td>
            <asp:Button ID="hrEmpMenuBtn" runat="server" Height="45px" Text="Employee Profile" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrEmpMenuBtn_Click" Width="150px" />
                    </td>
                    
                </tr>
                
                <tr>
                    <td>
                        <asp:Button ID="welEmplomentBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="welEmplomentBtn_Click" Text="Assign" Width="150
                 px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
            <asp:Button ID="hrApproval" runat="server" Height="45px" Text="Approval" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="Approval_Click" Width="150px" />
                    </td>
                    
                </tr>
                 <tr>
                    <td>
                <asp:Button ID="welConfirmBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Confirmation " Width="150px" OnClick="welConfirmBtn_Click" Height="45px" />
                     </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="trainingMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="trainingMenuBtn_Click" Text="Training" Width="150px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welTransferBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Transfer" Width="150px" OnClick="welTransferBtn_Click" Height="45px" />
                    </td>
                    
                </tr>
                 <tr>
                    <td>
                <asp:Button ID="welLeave" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" Text="Leave" Width="150px" OnClick="welLeave_Click" />
                     </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welQuery" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text=" Query" Width="150px" OnClick="welQuery_Click" Height="45px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welAppraisal" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Appraisal" Width="150px" OnClick="welAppraisal_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welPromotion" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Promotion" Width="150px" OnClick="welPromotion_Click" Height="45px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="welPension" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Retirement" Width="150px" OnClick="welPensionRetirement_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="menuBtnEditEmpDetails" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Edit Details" Width="150px" OnClick="menuBtnEditEmpDetails_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="menuBtnReport" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Report" Width="150px" OnClick="menuBtnReport_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    
                </tr>
                <tr>
                    <td>
        &nbsp;</td>
                    
                </tr>
            </table>
            </td>
        <td valign="top">
          
            <asp:MultiView ID="MViewHRPage" runat="server">
    
<asp:View ID="ViewHRWelcomePage" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;" valign="top">
        <tr>
            <td class="auto-style1" colspan="3">
                <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text=" Welcome to HR Session, Please select the Module you want to use"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>


    <asp:View ID="ViewEmployementAcceptance" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width: 100%;">
              <tr>
                  <td class="auto-style165" colspan="6">
                      <asp:Label ID="Label96" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Employment Acceptance"></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style165">&nbsp;</td>
                  <td class="auto-style178">&nbsp;</td>
                  <td class="auto-style132">&nbsp;</td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>
          <%--    <tr>
                  <td class="auto-style165">&nbsp;</td>
                  <td class="auto-style178">
                      <asp:Label ID="LbAppliNameList5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                  </td>
                  <td class="auto-style132">
                      <asp:DropDownList ID="AcceptanceDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="AcceptanceDept_SelectedIndexChanged" Width="250px">
                      </asp:DropDownList>
                  </td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>
           
              <tr>
                  <td class="auto-style165">&nbsp;</td>
                  <td class="auto-style178">&nbsp;</td>
                  <td class="auto-style132">&nbsp;</td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>--%>
              <tr>
                  <td class="auto-style165">&nbsp;</td>
                  <td class="auto-style178">
                      <asp:Label ID="LbAppliNameList4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Applicant"></asp:Label>
                  </td>
                  <td class="auto-style132">
                      <asp:DropDownList ID="AcceptanceapplicantList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="AcceptanceapplicantList_SelectedIndexChanged"></asp:DropDownList>
                      
                  </td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>
              <tr>
                  
                  <td class="auto-style165">&nbsp;</td>
                  <td class="auto-style178">
                      &nbsp;</td>
                  <td class="auto-style132">
                      &nbsp;</td>
                  <td class="auto-style22">&nbsp;</td>
                  <td class="auto-style19">&nbsp;</td>
                  <td class="auto-style20">&nbsp;</td>
              </tr>

              <tr>
                     <td class="auto-style142" colspan="6">
                         <asp:Label ID="LbEmpDetailsAdded1" runat="server" Visible="false" style="color: #669900; font-weight: 700; font-size: small"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="LbEmpIDgeneratedhere1" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                   
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style142">&nbsp;</td>
                     <td class="auto-style137">&nbsp;</td>
                     <td class="auto-style132">&nbsp;</td>
                     <td class="auto-style22">&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 
              <tr>
                  <td class="auto-style165" colspan="6">
                      <asp:Button ID="btnaccptFinsh" runat="server" Font-Bold="True" ForeColor="#CC0066" OnClick="btnaccptFinsh_Click" Text="Finish" Visible="false" />
                      <asp:Button ID="btnaccptTryAgain" runat="server" Font-Bold="True" ForeColor="#CC0066" OnClick="btnaccptTryAgain_Click" Text="Try Again" Visible="false" />
                  </td>
              </tr>
                 <tr>
                     <td class="auto-style142" colspan="6">
                         <asp:Panel ID="hrEmpProfilePanel" runat="server" Visible="False">
                             <table style="width:100%;">


                                 <tr>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>

                                     <tr>
                <td class="auto-style40" colspan="6">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Employee Personal Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style136">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>


             <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Image ID="AcceptanceImagePassport" runat="server" Height="180px" ImageAlign="Left" Width="190px" BorderColor="#CC0066" BorderStyle="Solid" BorderWidth="2px" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
                                 <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137"><asp:Label ID="Label101" runat="server" Font-Bold="True" Text="Department" Font-Size="14pt"></asp:Label>
               </td>
                <td class="auto-style132"><asp:Label ID="LbempAcceptanceDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                                       <td class="auto-style137">
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Position" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style132">
                    <asp:Label ID="LbempAccpPosition" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
                                 <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
               <td class="auto-style22">
                    <asp:Label ID="Label98" runat="server" Font-Bold="True" Font-Size="14pt" Text="ApplicantNum"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="LbempAccptNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:Label ID="Label158" runat="server" Font-Bold="True" Font-Size="14pt" Text="Title"></asp:Label>
                </td>
              <td class="auto-style19"><asp:Label ID="LbempAccpTitle" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label></td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style132">
                    <asp:Label ID="LbEmpAccpFName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Size="14pt" Text="Middle Name"></asp:Label>
                 </td>
                <td>
                    <asp:Label ID="LbempAccpMName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                 </td>
                <td>&nbsp;</td>
            </tr>
    <tr>
        <td class="auto-style142">&nbsp;</td>
        <td class="auto-style137">&nbsp;</td>
        <td class="auto-style132">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label39" runat="server" Font-Bold="True" Font-Size="14pt" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style132">
                    <asp:Label ID="LbEmpAccpLName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label43" runat="server" Font-Bold="True" Font-Size="14pt" Text="Marital Status"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbempAccpMaritaStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style142">
            &nbsp;</td>
        <td class="auto-style137">
            <asp:Label ID="Label45" runat="server" Font-Bold="True" Font-Size="14pt" Text="Email"></asp:Label>
         </td>
        <td class="auto-style132">
            <asp:Label ID="LbEmpAccpEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="Label65" runat="server" Font-Bold="True" Font-Size="14pt" Text="PhoneNum"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbempAccpPhnNo" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>

     <tr>
        <td class="auto-style142">&nbsp;</td>
        <td class="auto-style137">&nbsp;</td>
        <td class="auto-style132">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label67" runat="server" Font-Bold="True" Font-Size="14pt" Text="Gender"></asp:Label>
                </td>
                <td class="auto-style132">
                    <asp:Label ID="LbEmpAccpGender" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label69" runat="server" Font-Bold="True" Font-Size="14pt" Text="Contact Address"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbEmpAccpContAddr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style142">
            &nbsp;</td>
        <td class="auto-style137">
            <asp:Label ID="Label71" runat="server" Font-Bold="True" Font-Size="14pt" Text="Nationality"></asp:Label>
         </td>
        <td class="auto-style132">
            <asp:Label ID="LbEmpAccpNationality" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="Label73" runat="server" Font-Bold="True" Font-Size="14pt" Text="State of Origin"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbEmpAccptState" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>
   <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137"> <asp:Label ID="Label103" runat="server" Font-Bold="True" Font-Size="14pt" Text="State of Origin"></asp:Label>
      </td>
                <td class="auto-style132"> <asp:Label ID="LbEmpAccptSenatorialDistrict" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
      </td>
                <td class="auto-style22">  <asp:Label ID="Label75" runat="server" Font-Bold="True" Font-Size="14pt" Text="LGA"></asp:Label></td>
                <td><asp:Label ID="LbEmpAccpLGA" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
       </td>
                <td>&nbsp;</td>
            </tr>
                                 
                                    <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

    <tr>
      <td class="auto-style132">
             </td>
        <td class="auto-style22">
            <asp:Label ID="Label77" runat="server" Font-Bold="True" Font-Size="14pt" Text="Home Town"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LbEmpAccpHomeTown" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
        </td>
           <td class="auto-style142">   <asp:Label ID="Label89" runat="server" Font-Bold="True" Font-Size="14pt" Text="Religion"></asp:Label>
         </td>
        <td class="auto-style137"> <asp:Label ID="LbEmpAccptReligion" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
           
          
        </td>
       
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="auto-style142">&nbsp;</td>
        <td class="auto-style137">&nbsp;</td>
        <td class="auto-style132">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
                 <td class="auto-style142">&nbsp;</td>
                 <td class="auto-style137">
                     <asp:Label ID="Label79" runat="server" Font-Bold="True" Text="DOB" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style132">
                     <asp:Label ID="LbEmpAccpDoB" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                 </td>
                 <td class="auto-style22">
                     <asp:Label ID="Label81" runat="server" Font-Bold="True" Font-Size="14pt" Text="Age"></asp:Label>
                 </td>
                 <td>
                     <asp:Label ID="LbEmpAccptAge" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                 </td>
                 <td>&nbsp;</td>
            </tr>
            
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    &nbsp;</td>
                <td class="auto-style132">
                    &nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label91" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level"></asp:Label>
                </td>
                <td class="auto-style132">
                    <asp:Label ID="LbEmpAccptLevel" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label99" runat="server" Font-Bold="True" Font-Size="14pt" Text="Salary"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbAcceptanceSalary2" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style142">&nbsp;</td>
                 <td class="auto-style137">
                     &nbsp;</td>
                 <td class="auto-style132">
                     &nbsp;</td>
                 <td class="auto-style22">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
                 <td>&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">
                    <asp:Label ID="Label83" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style132">
                    <asp:Label ID="LbEmpAccptStartDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label85" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbEmpAccptWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
                                 <tr>
                <td class="auto-style142">&nbsp;</td>
                <td class="auto-style137">&nbsp;</td>
                <td class="auto-style132">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

                                 <tr>
                                     <td class="auto-style142" colspan="6">
                                         &nbsp;</td>
                                 </tr>
                                 <tr>
                                     <td class="auto-style142">&nbsp;</td>
                                     <td class="auto-style137">&nbsp;</td>
                                     <td class="auto-style132">&nbsp;</td>
                                     <td class="auto-style22">&nbsp;</td>
                                     <td>&nbsp;</td>
                                     <td>&nbsp;</td>
                                 </tr>

                                   <tr>
                <td class="auto-style11" colspan="6">
                    <asp:Label ID="Label37" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                 <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29" colspan="6">
                    <asp:GridView ID="GViewQualification" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />

                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifViewAppID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>

                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style15">&nbsp;</td>
              
            </tr>
                                 </tr>
             <tr>
                 <td colspan="5">
                     &nbsp;</td>
                 <tr>
                     <td colspan="6">
                         <asp:Label ID="LbCertifcation" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Professional Certification"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td colspan="6">&nbsp;</td>
                 </tr>
                 <tr>
                     <td colspan="6">
                         <asp:GridView ID="GViewCert" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                             <AlternatingRowStyle BackColor="White" />
                             <Columns>
                                 <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                                 <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                                 <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                                 <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                                 <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertAppID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                 <%-- <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButtonQualifSave" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ProfQualificationID") %>'></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                             </Columns>
                             <EditRowStyle BackColor="#2461BF" />
                             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#EFF3FB" />
                             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                         </asp:GridView>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style15">&nbsp;</td>
                     <td class="auto-style87"></td>
                     <td class="auto-style88"></td>
                     <td class="auto-style15"></td>
                     <td class="auto-style88">&nbsp;</td>
                      <td class="auto-style15">&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style15">&nbsp;</td>
                     <td class="auto-style87">&nbsp;</td>
                     <td class="auto-style88">&nbsp;</td>
                     <td class="auto-style88">&nbsp;</td>
                     <td class="auto-style15">&nbsp;</td>
                      <td class="auto-style15">&nbsp;</td>
                 </tr>
                 <tr>
                     <td colspan="6">
                         <asp:Label ID="LbOtherDocm1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Other Document"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td colspan="6">&nbsp;</td>
                 </tr>
                 <tr>
                     <td colspan="6">
                         <asp:GridView ID="GViewDoc" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                             <AlternatingRowStyle BackColor="White" />
                             <Columns>
                                 <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                                 <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                                 <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtdocAppID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                             </Columns>
                             <EditRowStyle BackColor="#2461BF" />
                             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#EFF3FB" />
                             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                         </asp:GridView>
                     </td>
                 </tr>
                 <tr>
                     <td colspan="6">&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style142">&nbsp;</td>
                     <td class="auto-style137">&nbsp;</td>
                     <td class="auto-style132">
                         <asp:Button ID="AcceptEmploymentBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" OnClick="AcceptEmploymentBtn_Click" Text="Accept" Width="122px" />
                     </td>
                     <td class="auto-style22">&nbsp;</td>
                     <td>
                         &nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style142">&nbsp;</td>
                     <td class="auto-style137">&nbsp;</td>
                     <td class="auto-style132">&nbsp;</td>
                     <td class="auto-style22">&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style142" colspan="6">
                         <asp:Label ID="LbEmpDetailsAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style142">&nbsp;</td>
                     <td class="auto-style137">&nbsp;</td>
                     <td class="auto-style132">&nbsp;</td>
                     <td class="auto-style22">&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     
                     <td class="auto-style22" colspan="6">
                         <asp:Label ID="LbEmpIDgeneratedhere" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                     </td>
                    
                       </tr>
                 <tr>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
             </tr>
                             </table>
                         </asp:Panel>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style165">&nbsp;</td>
                     <td class="auto-style178">&nbsp;</td>
                     <td class="auto-style132">&nbsp;</td>
                     <td class="auto-style22">&nbsp;</td>
                     <td class="auto-style19">&nbsp;</td>
                     <td class="auto-style20">&nbsp;</td>
                 </tr>
        
        </table>
    </asp:View>
    
    <asp:View ID="ViewHrEmpProfile" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
                        <tr>
                <td colspan="6">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#CC99FF" OnClick="BioDataLinkBtn_Click" EnableViewState="False">Biodata</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="qualifLinkBtn_Click">Qualification</asp:LinkButton>
                    &nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="certLinkBtn_Click">Certifications</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="docLinkBtn_Click">Document</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="refreeLinkBtn_Click">Refree</asp:LinkButton>
                </td>
            </tr>
             <tr>
                 <td class="auto-style167">&nbsp;</td>
                 <td class="auto-style146">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style145">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Personal Information"></asp:Label>
                </td>
            </tr>
             <tr>
                 <td class="auto-style167">&nbsp;</td>
                 <td class="auto-style60">&nbsp;</td>
                 <td class="auto-style61">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
            </tr>
                        <tr>
                            <td class="auto-style167">&nbsp;</td>
                            <td class="auto-style60">
                                <asp:DropDownList ID="hrEmpProfileIDList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="hrEmpProfileIDList_SelectedIndexChanged" Width="250px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style61">&nbsp;</td>
                            <td class="auto-style22">&nbsp;</td>
                            <td class="auto-style19">&nbsp;</td>
                            <td class="auto-style20">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style167">&nbsp;</td>
                            <td class="auto-style60">&nbsp;</td>
                            <td class="auto-style61">&nbsp;</td>
                            <td class="auto-style22">&nbsp;</td>
                            <td class="auto-style19">&nbsp;</td>
                            <td class="auto-style20">&nbsp;</td>
                        </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Panel ID="PanelEmployeeProfile" runat="server" Visible="False">
                        <table style="width:100%;">
                            
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Image ID="EmpProfilePassport" runat="server" Height="170px" ImageAlign="Left" Width="170px" BorderColor="#CC0066" BorderStyle="Solid" BorderWidth="2px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LBTitle" runat="server" Font-Bold="True" Text="Title" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpTitle" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LBMidName1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="LbHrEmpPosition" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LBfName" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpFName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label40" runat="server" Font-Bold="True" Font-Size="14pt" Text="Middle Name"></asp:Label>
                 </td>
                <td>
                    <asp:Label ID="LbHrEmpMidName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                <td>&nbsp;</td>
            </tr>
    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label64" runat="server" Font-Bold="True" Font-Size="14pt" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpLName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpMaritalStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style168">
            <asp:Label ID="Label70" runat="server" Font-Bold="True" Font-Size="14pt" Text="Email"></asp:Label>
         </td>
        <td class="auto-style61">
            <asp:Label ID="LbHrEmpEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="Label74" runat="server" Font-Bold="True" Font-Size="14pt" Text="PhoneNum"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbHrEmpPhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>

     <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label78" runat="server" Font-Bold="True" Font-Size="14pt" Text="Gender"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpGender" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label80" runat="server" Font-Bold="True" Font-Size="14pt" Text="Contact Address"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpContAddr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style168">
            <asp:Label ID="Label84" runat="server" Font-Bold="True" Font-Size="14pt" Text="Nationality"></asp:Label>
         </td>
        <td class="auto-style61">
            <asp:Label ID="LbHrEmpCountry" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="LbStateOfOri" runat="server" Font-Bold="True" Font-Size="14pt" Text="State of Origin"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbHrEmpState" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">
            <asp:Label ID="LbLGA" runat="server" Font-Bold="True" Font-Size="14pt" Text="LGA"></asp:Label>
        </td>
        <td class="auto-style61">
            <asp:Label ID="LbHrEmpLGA" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
        </td>
        <td class="auto-style22">
            <asp:Label ID="Label92" runat="server" Font-Bold="True" Font-Size="14pt" Text="Home Town"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LbHrEmpHomeTown" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style168">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style168">
                     <asp:Label ID="LbLGA0" runat="server" Font-Bold="True" Text="DOB" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style61">
                     <asp:Label ID="LbHrEmpDOB" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                 <td class="auto-style22">
                     <asp:Label ID="Label95" runat="server" Font-Bold="True" Font-Size="14pt" Text="Age"></asp:Label>
                 </td>
                 <td>
                     <asp:Label ID="LbHrEmpAge" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbStartDate" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpStartDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label102" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label104" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label106" runat="server" Font-Bold="True" Font-Size="14pt" Text="Religion"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReligion" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label107" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpLevel" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                                  <td class="auto-style56" colspan="6">
                                      <asp:Label ID="LbSpouseInfo1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Employee Status Infomation"></asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">
                                      <asp:Label ID="LbEmpStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Status"></asp:Label>
                                  </td>
                                  <td class="auto-style61">
                                      <asp:Label ID="LbHrEmpStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style22">
                                      <asp:Label ID="LbCnfrmDate0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Confirmation Date"></asp:Label>
                                  </td>
                                  <td>
                                      <asp:Label ID="LbHrEmpConfimedDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbConfirmBy0" runat="server" Font-Bold="True" Font-Size="14pt" Text="ConfirmedBy"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpConfirmedBy" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style168">
                     &nbsp;</td>
                 <td class="auto-style61">
                     &nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style56" colspan="6">
                                      <asp:Label ID="LbSpouseInfo2" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Spouse Infomation (If Married)"></asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbspouseFNam0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbSpouseNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Phone No"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpSpousePhoNo" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbspouseFNam2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Address"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpSpouseAddress" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpSpouseEmailAddr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbspouseFNam4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Occupation"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpSpouseOccupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Employer"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpSpouseEmployer" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbNxtOfKinInfo0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Next of Kin Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbnxtOfKinFName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="NOK Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpNextOfKinNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Relationship"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpNextOfKinRelationship" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbnxtOfKinFName2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Phone Num"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpNextOfKinPhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpNextOfKinEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbnxtOfKinFName4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Address"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpNextOfKinAddrs" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Occupation"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpNextOfKinOccupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbBankInfo0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Bank Information &amp; Gurrantor Info"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbBank" runat="server" Font-Bold="True" Font-Size="14pt" Text="Bank Name"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpBankNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbHrEmpAcctNames" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpAccountName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="LbAcctNames0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Number"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpAcctNumber" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Guarrantor's Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpGuarrantorName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="Label113" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Refree Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label114" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1Names" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label116" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Names"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2Names" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label118" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Phone No"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1PhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label120" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Phone No"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2PhnNum" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label122" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Email"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1Email" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label124" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2Email" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    <asp:Label ID="Label126" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Occupation"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbHrEmpReferee1Occupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="Label128" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Occupation"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbHrEmpReferee2Occupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style168">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style72"></td>
                                  <td class="auto-style168">
                                      <asp:Label ID="Label130" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Address"></asp:Label>
                                  </td>
                                  <td class="auto-style74">
                                      <asp:Label ID="LbHrEmpReferee1Addr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style75">
                                      <asp:Label ID="Label131" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Address"></asp:Label>
                                  </td>
                                  <td class="auto-style72">
                                      <asp:Label ID="LbHrEmpReferee2Addr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style72"></td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbQualifInfo0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewHrEmpProfileQualification" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtProfileQualiAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtProfileQualiEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbQualifInfo1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Professional Certifications Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewHrEmpProfileCert" runat="server" AutoGenerateColumns="False"  EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                            <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                            <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                            <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtProfileProfQualiAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtProfileProfQualiEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.employeeID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="LbQualifInfo2" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Other Document Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewHrEmpProfileDoc" runat="server" AutoGenerateColumns="False"  EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                            <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />                            
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtProfileDocAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtProfileDocEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_Fk")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style168">&nbsp;</td>
                <td class="auto-style61">
                    <asp:Button ID="empFinishBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Finish" OnClick="empFinishBtn_Click" />
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style168">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
                              <tr>
                                  <td class="auto-style167">&nbsp;</td>
                                  <td class="auto-style60">&nbsp;</td>
                                  <td class="auto-style61">
                                      &nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                          </tr>
                      </tr>
    </tr>
                      
        </table>
 </asp:View>
         <asp:View ID="ViewAssignSupervisor" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Assign HOD to Department"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154" colspan="4">
                    <asp:LinkButton ID="LinkBtnAssignHOD" runat="server" Visible="false" Font-Bold="true" ForeColor="BlueViolet" OnClick="LinkBtnAssignHOD_Click">Assign HOD to another Department</asp:LinkButton></td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154" colspan="4">
                    <asp:Label ID="LbHODUpdateSuccessful1" runat="server" Visible="False" Font-Italic="True" ForeColor="YellowGreen" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style154" colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154" >&nbsp;</td>
                <td class="auto-style196">
                    <asp:Button ID="btnAssignHODFinish" runat="server" Visible="false" Font-Bold="True"  ForeColor="#33CC33" OnClick="empFinishBtn_Click" Text="Finish" />
               <asp:Button ID="btnAssignHODTryAgain" runat="server" Visible="false" Font-Bold="True"  ForeColor="#33CC33"  Text="Try Again" OnClick="btnAssignHODTryAgain_Click" />
                                    </td>
                <td class="auto-style195">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154" >&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154" colspan="4" >
                    <asp:Panel ID="PanelAssignHOD1" Visible="false" runat="server">
                        <table style="width: 100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                            </tr>
                           
                           
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="Label140" runat="server" Font-Bold="True" Font-Size="14pt" Text="Location"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignHODLocationList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="14pt" Text="Deparment"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignHODDeptList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="assignHODDeptList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
          
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="14pt" Text="Select HOD New Position"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignHODPositionList" runat="server" Visible="true" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="LbHOD" runat="server" Font-Bold="True" Font-Size="14pt" Text="Select HOD"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignHODEmpList" runat="server" Visible="False" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="assignHODEmpList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157" colspan="4">
                    <asp:GridView ID="GViewAssignHOD" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                            <asp:BoundField DataField="DeptName" HeaderText="Dept" />
                            <asp:BoundField DataField="PositionName" HeaderText="Position" />
                            <asp:BoundField DataField="LocationName" HeaderText="Location" />
                            <asp:BoundField DataField="LevelName" HeaderText="Level" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtAssignEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtAssignDeptID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.Department_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtAssignPostID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.PositionHeld_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtAssignWorkID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.WorkLocation_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField HeaderText="Select"><EditItemTemplate><asp:CheckBox ID="CheckBoxHodAssign" runat="server" /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="CheckBoxHodAssign" runat="server" /></ItemTemplate></asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style157" colspan="4">
                
                    &nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style154" colspan="4">
                    <asp:Label ID="LbHODUpdateSuccessful" runat="server" ForeColor="#990033" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Button ID="assignHODBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Assign" Width="122px" OnClick="assignHODBtn_Click" Visible="False" />
                </td>
                <td class="auto-style195">
                    &nbsp;</td>
            </tr>
                             <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style196">
                    &nbsp;</td>
                <td class="auto-style195">
                    &nbsp;</td>
            </tr>

        </table>
</asp:View>
    <asp:View ID="ViewQualification" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">

             
            <tr>
                <td colspan="4">
                    <u>
                    <asp:Label ID="Label35" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Approval Page"></asp:Label>
                    </u></td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
                                 <td class="auto-style176" colspan="4">
                                     <asp:Button ID="hrApproveQualifMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveQualifMenuBtn_Click" Text="Qualification" Width="150px" Height="45px" />
                                     &nbsp;<asp:Button ID="hrApproveCertMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveCertMenuBtn_Click" Text="Certification" Width="150px" Height="45px" />
                                     &nbsp;
                                     <asp:Button ID="hrApproveDocMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveDocMenuBtn_Click" Text="Document" Width="150px" Height="45px" />
                                     </td>
                            </tr>
                            <tr>
                                <td class="auto-style176">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
            <tr>
                <td class="auto-style176" colspan="4">
                    <asp:Label ID="LbHrQaulifHrApproval" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                    <asp:Label ID="LbCertApproved1" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                     <asp:Label ID="LbDocApproved1" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>        
                </td>
            </tr>
            <tr>
                <td class="auto-style177" colspan="4">
                    <asp:Panel ID="PanelApproveQualif1" runat="server" Visible="false">
                        <table style="width: 100%;">
                            
                   
            <tr>
                <td>
                                      <ul>
                        <li>Click on Qualification Menu button to approve employee new added qualification </li><br />
                       
                         <li>Click on Certification Menu button to approve employee new added certification </li><br />

                         <li>Click on Document Menu button to approve employee new uploaded document </li>
                    </ul>

                </td>
            </tr>

            <tr>
                <td>
                    <asp:Panel ID="PanelApproveQualif" runat="server" Visible="False">
                        <table style="width: 100%;">
                            <tr>
                                <td colspan="4">
                                    <asp:Label ID="LbQualifInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details"></asp:Label>
                                </td>
                            </tr>
                             
                            <tr>
                                <td class="auto-style209">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                             <tr>
                                 <td colspan="4">
                                     <ul>
                                         <li>Select the Employee</li>
                                         <li>Check the Certification you want to approve</li>
                                         <li>Click &#39;Approve&#39; button to approve the certification</li>
                                         <li>Click on &#39;Finish&#39; button to go back to main menue</li>
                                     </ul>
                                 </td>
                            </tr>
                            <tr>
                                <td class="auto-style209">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                             <tr>
                <td class="auto-style210">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Label ID="LbSchName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Name"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="hrUnApprovedQualifList" runat="server" AutoPostBack="True" DataTextField="EmployeeID" DataValueField="LastName" OnSelectedIndexChanged="HRQualifEmployeeList_SelectedIndexChanged" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style210">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style11" colspan="4">
                    
                    <asp:GridView ID="GViewHrEmpApproveQualif" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtAppID" runat="server" visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtEmpID" runat="server" visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:BoundField DataField="HrApproval" HeaderText="HrApproval" SortExpression="HrApproval" />
                            <asp:TemplateField HeaderText="Approve"><EditItemTemplate><asp:CheckBox ID="CheckBoxQualf" runat="server" /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="CheckBoxQualif" runat="server" /></ItemTemplate></asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style210">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style210">&nbsp;</td>
                <td class="auto-style54">
                       <asp:Label ID="LbHrQaulifApproved" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                
                </td>
                <td class="auto-style7">
                 </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style210">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Button ID="QualifApproveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifApproveBtn_Click" Text="Approve" Visible="False" />
                 &nbsp;&nbsp;&nbsp;<asp:Button ID="QualifFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" Visible="False" />

                </td>
                <td class="auto-style7">
                 
                                   </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style210">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                                 </table>
                    </asp:Panel>
                </td>

            </tr>
            <tr>
                <td class="auto-style173">
                    <asp:LinkButton ID="BioDataLinkBtn6" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="10pt" ForeColor="#0066FF" OnClick="BioDataLinkBtn_Click">Biodata</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="qualifLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="qualifLinkBtn_Click">Qualification</asp:LinkButton>
                    &nbsp;&nbsp;
                    <asp:LinkButton ID="certLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="certLinkBtn_Click">Certifications</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="docLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="docLinkBtn_Click">Document</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="refreeLinkBtn6" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="refreeLinkBtn_Click">Refree</asp:LinkButton>
                </td>
            </tr>
                        </table>

                    </asp:Panel>

                    &nbsp;</td>
            </tr>
           
            <tr>
                <td></td>
                 <td></td>
                 <td></td>
                 <td></td>

            </tr>

        </table>
    </asp:View>

    <asp:View ID="ViewCertification" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td class="auto-style20" colspan="5">
                    <asp:Button ID="hrApproveQualifMenuBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="hrApproveQualifMenuBtn_Click" Text="Qualification" Width="150px" />
                    &nbsp;<asp:Button ID="hrApproveCertMenuBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="hrApproveCertMenuBtn_Click" Text="Certification" Width="150px" />
                    &nbsp;
                    <asp:Button ID="hrApproveDocMenuBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="hrApproveDocMenuBtn_Click" Text="Document" Width="150px" />
                </td>

            </tr>
             <tr>
                 <td class="auto-style59">&nbsp;</td>
                 <td class="auto-style43">&nbsp;</td>
                 <td class="auto-style18">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <ul>
                         <li>Select the Employee</li>
                         <li>Check the Certification you want to approve</li>
                         <li>Click &#39;Approve&#39; button to approve the certification</li>
                         <li>Click on &#39;Finish&#39; button to go back to main menue</li>
                     </ul>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style20" colspan="5">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style59">&nbsp;</td>
                 <td class="auto-style43">
                     &nbsp;</td>
                 <td class="auto-style18">
                     &nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
           
             <tr>
                 <td class="auto-style59" colspan="5">
                     <asp:Panel ID="PanelHrApproveCert" runat="server" Visible="False">
                         <table style="width: 100%;">
                             <tr>
                                 <td colspan="4">
                                     <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Professional Qualification"></asp:Label>
                                 </td>
                             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">
                                     <asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Name"></asp:Label>
                                 </td>
                                 <td class="auto-style7">
                                     <asp:DropDownList ID="hrUnApprovedCertList" runat="server" AutoPostBack="True" DataTextField="EmployeeID" DataValueField="LastName" OnSelectedIndexChanged="hrUnApprovedCertList_SelectedIndexChanged" Width="250px">
                                     </asp:DropDownList>
                                 </td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style11" colspan="4">
                                     <asp:GridView ID="GViewHrEmpApproveCert" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                         <AlternatingRowStyle BackColor="White" />
                                         <Columns>
                                             <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                                             <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                                             <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                                             <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertAppID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertEmpID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.employeeID_FK")%>' visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                             <asp:BoundField DataField="HrApproval" HeaderText="HrApproval" SortExpression="HrApproval" />
                                             <asp:TemplateField HeaderText="Approve"><EditItemTemplate><asp:CheckBox ID="CheckBoxCert" runat="server" /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="CheckBoxCert" runat="server" /></ItemTemplate></asp:TemplateField>
                                         </Columns>
                                         <EditRowStyle BackColor="#2461BF" />
                                         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                         <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                         <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                         <RowStyle BackColor="#EFF3FB" />
                                         <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                     </asp:GridView>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td ><asp:Label ID="LbCertApproved" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
              </td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style173">&nbsp;</td>
                                 <td class="auto-style54">&nbsp;</td>
                                 <td class="auto-style7">
                                     <asp:Button ID="hrCertApproveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Approve" Visible="False" OnClick="hrCertApproveBtn_Click" />
                                     <asp:Button ID="QualifFinishBtn10" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" Visible="False" />
                                 </td>
                                 <td>
                                     <asp:Button ID="hrCertFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" Visible="False" />
                                 </td>
                             </tr>
                             <tr>
                                 <td colspan="3">
                                     <asp:LinkButton ID="LinkButton6" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="10pt" ForeColor="#0066FF" OnClick="BioDataLinkBtn_Click">Biodata</asp:LinkButton>
                                     &nbsp;
                                     <asp:LinkButton ID="LinkButton7" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="qualifLinkBtn_Click">Qualification</asp:LinkButton>
                                     &nbsp;&nbsp;
                                     <asp:LinkButton ID="LinkButton8" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="certLinkBtn_Click">Certifications</asp:LinkButton>
                                     &nbsp;
                                     <asp:LinkButton ID="LinkButton9" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="docLinkBtn_Click">Document</asp:LinkButton>
                                     &nbsp;
                                     <asp:LinkButton ID="LinkButton10" runat="server" Font-Bold="True" Font-Size="10pt" ForeColor="#990033" OnClick="refreeLinkBtn_Click">Refree</asp:LinkButton>
                                 </td>
                             </tr>
                         </table>
                     </asp:Panel>
                 </td>
             </tr>
        </table>
    </asp:View>

    <asp:View ID="ViewOtherDocuments" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
           <tr>
                <td>
                  <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveQualifMenuBtn_Click" Text="Qualification" Width="150px" Height="45px" />
                                     &nbsp;<asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveCertMenuBtn_Click" Text="Certification" Width="150px" Height="45px" />
                                     &nbsp;
                                     <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hrApproveDocMenuBtn_Click" Text="Document" Width="150px" Height="45px" />
                                  </td>
               
            </tr>
             <tr>
                 <td>
                     &nbsp;</td>
             </tr>
         
             <tr>
                 <td>
                     <asp:Label ID="LbOtherDocm0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Other Document"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
             </tr>
            <tr>
                <td class="auto-style65">
                    <asp:Panel ID="PanelHrApproveDoc" runat="server" Visible="False">
                        <table style="width: 100%;">
                            <tr>
                                <td colspan="4">
                                    <ul>
                                        <li>Select the Employee</li>
                                        <li>Check the document you want to approve</li>
                                        <li>Click 'Approve' button to approve the document</li>
                                        <li>Click on 'Finish' button to go back to main menue</li>
                                    </ul>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style211">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style211">&nbsp;</td>
                                <td>
                                    <asp:Label ID="Label34" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Name"></asp:Label>
                                </td>
                                <td class="auto-style7">
                                    <asp:DropDownList ID="hrUnApprovedDocList" runat="server" AutoPostBack="True" DataTextField="EmployeeID" DataValueField="LastName" OnSelectedIndexChanged="hrUnApprovedDocList_SelectedIndexChanged" Width="250px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style211">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style11" colspan="4">
                                    <asp:GridView ID="GViewHrEmpApproveDoc" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocAppID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocEmpID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>' visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                            <asp:BoundField DataField="HrApproval" HeaderText="HrApproval" SortExpression="HrApproval" />
                                            <asp:TemplateField HeaderText="Approve"><EditItemTemplate><asp:CheckBox ID="CheckBoxDoc" runat="server" /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="CheckBoxDoc" runat="server" /></ItemTemplate></asp:TemplateField>
                                        </Columns>
                                        <EditRowStyle BackColor="#2461BF" />
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#EFF3FB" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style211">&nbsp;</td>
                                <td>
                                    <asp:Button ID="hrDocApproveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="hrDocApproveBtn_Click" Text="Approve" Visible="False" />
                                    <asp:Button ID="hrDocFinshBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" Visible="False" />
                                </td>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
             <tr>
                 <td class="auto-style13">&nbsp;</td>
             </tr>
        </table>
    </asp:View>


<asp:View ID="ViewConfimation" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style4" colspan="4">
                <asp:Label ID="LbConfirmManagement" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Confirmation Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182" colspan="4">
                <asp:LinkButton ID="LinkBtnConfirmEmp" runat="server" OnClick="LinkBtnConfirmEmp_Click">Confirm Emp</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkBtnListConfirmeEmp" runat="server" OnClick="LinkBtnListConfirmeEmp_Click">List Confimed Emp</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkBtnListUnConfirmeEmp" runat="server" OnClick="LinkBtnListUnConfirmeEmp_Click">List UnConfimed Emp</asp:LinkButton>
                &nbsp;
                </td>
        </tr>
         <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182" colspan="4">
                <asp:Label ID="LbConfirmSuccessful" runat="server" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkBtnPrintConfirmLetter" runat="server" Font-Bold="False" OnClick="LinkBtnPrintConfirmLetter_Click" Visible="false">  Print Confirmation Letter</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style182" colspan="4">
                <asp:Panel ID="PanelConfirmation" runat="server" Visible="false">
                    <table style="width: 100%;">
                    
        <tr>
            <td class="auto-style180" colspan="4">
                <p>To confirm an employee he/she MUST reach minimum duration as stated by the management<br />
                    Please follow the instruction below to confirm an employee
                    <ul>
                        <li>Select the employee you want to confirm from the list of Unconfirmed employees</li>
                        <li>Click on 'Confirm' button to confirm</li>
                        <li>Click of 'List' to List out the list of Confirmed Employees</li>
                         <li>Click on 'Finish' button to go to the home page</li>

                    </ul>

            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbEmployeeDetails" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:DropDownList ID="confirmEmployeeList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="confirmEmployeeList_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
             <td>&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbEmployeeDetails0" runat="server" Font-Bold="True" Font-Size="14pt" Text="StartDate"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfirmStartDate" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbConfirmDate1" runat="server" Font-Bold="True" Font-Size="14pt" Text="ConfirmDate"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfrimationDate" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
         <tr>
             <td class="auto-style182">&nbsp;</td>
             <td class="auto-style8">&nbsp;</td>
             <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbConfirmDate2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Duration"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfrimDuration" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style94" colspan="4">
                <asp:Label ID="LbConfirmDuration" runat="server" Font-Bold="True" ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbConfirmBy" runat="server" Font-Bold="True" Text="ConfirmedBy" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style92">
                <asp:Label ID="LbConfirmedBy" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
             <td>&nbsp;</td>
        </tr>
       
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style92">
                <asp:Button ID="confirmBtn" runat="server" Visible="false" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Confirm" OnClick="confirmBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                </td>
             <td>
                 <asp:Button ID="QualifFinishBtn2" runat="server" Visible="false" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182" colspan="4">
                &nbsp;&nbsp;&nbsp;
                 <asp:Label ID="LbCanNotConfirm" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#99CC00" Visible="False"></asp:Label>
            
               
            </td>
        </tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style182" colspan="4">

            
                &nbsp;</td></tr>
        <tr>
            <td class="auto-style182">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style92">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        </table>
   </asp:Panel>
      
</td>
            </tr>
        <tr>
            <td class="auto-style182" colspan="4">
                <asp:Panel ID="PanelConfirmLetter" runat="server" Width="800px" Visible="False">
                                <table style="border: medium solid #C0C0C0; width:75%; margin-left:50px">
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td aria-flowto="right" valign="right">
                                            <asp:Label ID="Label19" runat="server" Text="Neetbeet Technologies Limited"></asp:Label>
                                            <br />
                                            <asp:Label ID="Label20" runat="server" Text="13, Adekunbi Cresent , Off Toyin Street, Ikeja, Lagos."></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>
                                            <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style33">&nbsp;</td>
                                        <td class="auto-style45"></td>
                                        <td class="auto-style1"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">Dear&nbsp;
                                            <asp:Label ID="lbConfirmLName" runat="server"></asp:Label>
                                            ,</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46" colspan="3">
                                            <table style="width: 90%;">
                                                <tr>
                                                    <td>
                                                        <center>
                                                            <b><u>Confirmation Letter </u></b>
                                                        </center>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style48" colspan="3">
                                            <p>
                                                We wish to inform you that you have been confirmed as a full staff of Neetbeet Technologies Limited on this day 
                                                <asp:Label ID="lbConfirmLetterDate" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                                . You will therefore henceforth enjoy all benefits as a staff of Neetbeet. Congratulation.<p>




                                                    The Management.
                                                    <p>
                                                    </p>
                                                  
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td class="auto-style47">&nbsp;</td>
                                        <td>
                                                  </td>
                                    </tr>
                                </table>
                            </asp:Panel>

            </td>
           
        </tr>
    </table>
</asp:View>


    <asp:View ID="ViewTraining" runat="server">

        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Training Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>

        </tr>
            <tr>
            <td class="auto-style3" colspan="4">
                <p>Please follow the instruction below to approve training</p>
             <ul>
                          <li>Select Your Department</li><br />
                          <li>Check Training to approve</li><br />
                          <li>Click "Approve" button to approve selected trainings</li><br />
                 <li>Click "List" button to List all trainings</li><br />
                 <li>Click "Finish" button to go back to HomePage</li>

                      </ul>
                </td>
                </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="Label36" runat="server" Font-Bold="True" Text="Department" Font-Size="16pt"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="trainingHRDeptList" runat="server" AutoPostBack="True" Width="250px" OnSelectedIndexChanged="trainingHRDeptList_SelectedIndexChanged">
                    <asp:ListItem>***Please select***</asp:ListItem>
                    <asp:ListItem>Account</asp:ListItem>
                    <asp:ListItem>Busery</asp:ListItem>
                    <asp:ListItem>Registry</asp:ListItem>
                    <asp:ListItem>Adminstrative</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
        </tr>
      
       
              <tr>
                  <td class="auto-style7">&nbsp;</td>
                  <td class="auto-style8">
                      <asp:Label ID="LbApprove" runat="server" Font-Bold="True" Font-Size="16pt" Text="ApprovedBy" Visible="False"></asp:Label>
                  </td>
                  <td class="auto-style9">
                      <asp:Label ID="LbApprovedBy" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                  </td>
                  <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
      
       
              <tr>
            <td class="auto-style11" colspan="4">
                <asp:GridView ID="GViewTrainingEmpList" runat="server"  AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                    <AlternatingRowStyle BackColor="White" />
                     <Columns>
                          
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTrainingID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.TrainingID") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>

                              <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTrainingEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>

                              <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTrainingDeptID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.DepartmentID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="Employee" InsertVisible="False" ReadOnly="True" SortExpression="Employee" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" SortExpression="PhoneNo" />
                            <asp:BoundField DataField="DeptName" HeaderText="Dept" SortExpression="Department" />
                            <asp:BoundField DataField="PositionName" HeaderText="Position" SortExpression="Position" />
                            <asp:BoundField DataField="TrainingName" HeaderText="Training" />
                            <asp:BoundField DataField="TrainingLocation" HeaderText="TrainingLocation" />
                            <asp:BoundField DataField="StartDate" HeaderText="StartDate" />
                            <asp:BoundField DataField="EndDate" HeaderText="EndDate" />
                            <asp:BoundField DataField="HODName" HeaderText="HOD" />
                            <asp:BoundField DataField="TrainingStatus" HeaderText="Status" />
                            <asp:TemplateField HeaderText="Select To Approve"><EditItemTemplate><asp:CheckBox ID="TrainingHRpprovalCheckBox1" runat="server" /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="TrainingHRpprovalCheckBox1" runat="server" /></ItemTemplate></asp:TemplateField>
                        </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
            </td>

        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style11" colspan="4">
                    <asp:Label ID="LbTrainingApproved" runat="server" Font-Bold="True" Text="Label" Visible="False" Font-Italic="True" ForeColor="#669900"></asp:Label>
                </td>
            </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style13">
                <asp:Button ID="trainingApproveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Approve" OnClick="trainingApproveBtn_Click" Visible="False" />
               
                </td>
            <td class="auto-style14">
                   <asp:Button ID="trainingListBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="List" Visible="False" OnClick="trainingListBtn_Click" />
            
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="trainingFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33"  Text="Finish" Visible="False" />
            </td>
            <td class="auto-style15">
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style11" colspan="4">
                    <asp:GridView ID="GViewTrainingEmpList1" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTrainingID1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TrainingID") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTrainingEmpID1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTrainingDeptID1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DepartmentID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="Employee" InsertVisible="False" ReadOnly="True" SortExpression="Employee" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" SortExpression="PhoneNo" />
                            <asp:BoundField DataField="DeptName" HeaderText="Dept" SortExpression="Department" />
                            <asp:BoundField DataField="PositionName" HeaderText="Position" SortExpression="Position" />
                            <asp:BoundField DataField="TrainingName" HeaderText="Training" />
                            <asp:BoundField DataField="TrainingLocation" HeaderText="TrainingLocation" />
                            <asp:BoundField DataField="StartDate" HeaderText="StartDate" />
                            <asp:BoundField DataField="EndDate" HeaderText="EndDate" />
                            <asp:BoundField DataField="HODName" HeaderText="HOD" />
                            <asp:BoundField DataField="HRName" HeaderText="ApprovedBy" />
                            <asp:BoundField DataField="TrainingStatus" HeaderText="Status" />                            
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>

        <%--<table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbTraining" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Training Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style62"></td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style62">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbtrainindDept" runat="server" Font-Bold="True" Text="Department" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="trainingDeptList" runat="server" Width="250px" DataTextField="DeptID" DataValueField="DeptName">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpID" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="TrainingPositionList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpID0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="TrainingEmployeeList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style61">
                &nbsp;</td>
            <td>
                <asp:Label ID="LbTrainingType" runat="server" Font-Bold="True" Text="Training Type" Font-Size="14pt"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="traininTypeList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style62"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbTrainingLoc" runat="server" Font-Bold="True" Text="Training Location" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="trainingLocationList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style62">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label61" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="trainingStartDayList" runat="server" Width="83px">
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingStartMonthList" runat="server" Width="83px">
                        <asp:ListItem Value="00">*Month*</asp:ListItem>
                        <asp:ListItem Value="01">Jan</asp:ListItem>
                        <asp:ListItem Value="02">Feb</asp:ListItem>
                        <asp:ListItem Value="03">Mar</asp:ListItem>
                        <asp:ListItem Value="04">april</asp:ListItem>
                        <asp:ListItem Value="05">May</asp:ListItem>
                        <asp:ListItem Value="06">Jun</asp:ListItem>
                        <asp:ListItem Value="07">Jul</asp:ListItem>
                        <asp:ListItem Value="08">Aug</asp:ListItem>
                        <asp:ListItem Value="09">Set</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingStartYearList" runat="server" AutoPostBack="True" Width="83px">
                    </asp:DropDownList>
                    <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
       <%-- --%>
        <tr>
            <td class="auto-style61">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
</asp:View>

    <asp:View ID="ViewTransfer" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbTransferManagement" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Transfer Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style86"></td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbPreDept1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Transfer Type"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:DropDownList ID="transferTypeList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="transferTypeList_SelectedIndexChanged">
                    <asp:ListItem>***Please select***</asp:ListItem>
                    <asp:ListItem>Self Request</asp:ListItem>
                    <asp:ListItem>Job Nature</asp:ListItem>
                    <asp:ListItem>Organization</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style189">&nbsp;</td>
            <td class="auto-style190">&nbsp;</td>
            <td class="auto-style191">&nbsp;</td>
            <td class="auto-style189">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86" colspan="4">
                <asp:Panel ID="PanelTransfer" runat="server" Visible="False">
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="4">
                                <p>
                                    This is Transfer Module, please follow the instruction below to transfer employee</p>
                                <ul>
                                    <li>Select the employee you want to transfer</li>
                                    <li>Select select new location he/she will be going to </li>
                                    <li>Select select the department</li>
                                </ul>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">
                                <asp:Label ID="LbEmployeeID0" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
                            </td>
                            <td class="auto-style90">
                                <asp:DropDownList ID="transferEmployeeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="transferEmployeeList_SelectedIndexChanged" Width="250px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">
                                <asp:Label ID="LbPreWokLoc" runat="server" Font-Bold="True" Font-Size="14pt" Text="Previous Work Location"></asp:Label>
                            </td>
                            <td class="auto-style90">
                                <asp:Label ID="LbTransferPreWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style87">&nbsp;</td>
                            <td class="auto-style89">
                                <asp:Label ID="LbNewWokLoc0" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Work Location"></asp:Label>
                            </td>
                            <td class="auto-style91">
                                <asp:DropDownList ID="transferNewWokLocList" runat="server" Width="250px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86"></td>
                            <td class="auto-style88"></td>
                            <td class="auto-style90"></td>
                            <td class="auto-style3"></td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">
                                <asp:Label ID="LbPreDept" runat="server" Font-Bold="True" Font-Size="14pt" Text="Previous Dept"></asp:Label>
                            </td>
                            <td class="auto-style90">
                                <asp:Label ID="LbTransferPreDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style87">&nbsp;</td>
                            <td class="auto-style89">&nbsp;</td>
                            <td class="auto-style91">&nbsp;</td>
                            <td class="auto-style3"></td>
                        </tr>
                        <tr>
                            <td class="auto-style87">&nbsp;</td>
                            <td class="auto-style89">
                                <asp:Label ID="LbNewDept" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Dept"></asp:Label>
                            </td>
                            <td class="auto-style91">
                                <asp:DropDownList ID="transferNewDeptList" runat="server" Width="250px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <%--<tr>
            <td class="auto-style86">
                &nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbPrePosition" runat="server" Font-Bold="True" Text="Previous Position" Font-Size="14pt"></asp:Label>
             </td>
            <td class="auto-style90">
                <asp:DropDownList ID="prePositionList" runat="server" Width="250px">
                </asp:DropDownList>
             </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style86"></td>
            <td class="auto-style88"></td>
            <td class="auto-style90"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style86">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbNewPosition" runat="server" Font-Bold="True" Text="New Position" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:DropDownList ID="newPositionList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>--%>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">
                                <asp:Label ID="LbDateTransfered" runat="server" Font-Bold="True" Font-Size="14pt" Text="Transfer Date"></asp:Label>
                            </td>
                            <td class="auto-style90">
                                <asp:Label ID="LbTransferDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                         <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88"><asp:Label ID="Label86" runat="server" Font-Bold="True" Font-Size="14pt" Text="Transfer Date"></asp:Label>
                         </td>
                            <td class="auto-style90">
                                <asp:TextBox ID="txtTransferReason" Width="250px" runat="server"></asp:TextBox></td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                         <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86">&nbsp;</td>
                            <td class="auto-style88">&nbsp;</td>
                            <td class="auto-style90">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style87">&nbsp;</td>
                            <td class="auto-style89">
                                <asp:Label ID="LbTransferBy" runat="server" Font-Bold="True" Font-Size="14pt" Text="TransferedBy"></asp:Label>
                            </td>
                            <td class="auto-style91">
                                <asp:Label ID="LbTransferedBy" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style87">&nbsp;</td>
                            <td class="auto-style89">&nbsp;</td>
                            <td class="auto-style91">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style87" colspan="4">
                                <asp:Label ID="LbTransferSuccessful" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style87">&nbsp;</td>
                            <td class="auto-style89">&nbsp;</td>
                            <td class="auto-style91">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style86"></td>
                            <td class="auto-style88"></td>
                            <td class="auto-style90">
                                <asp:Button ID="TransferBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="TransferBtn_Click" Text="Transfer" />
                                &nbsp; &nbsp; </td>
                            <td class="auto-style3">
                                <asp:Button ID="QualifFinishBtn4" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:View>

<asp:View ID="ViewLeave" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style54">
                <asp:Label ID="LbLeaveManagement" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Leave Management"></asp:Label>
            </td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54" colspan="4">
                <ul>
                    <li><p>Select the Department to view all Leave application for the department</p></li>
                    <li><p>Click on view to see full details of an application</p></li>
                    <li><p>Approve or Reject leave Application</p></li>


                </ul>
            </td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="Label144" runat="server" Text="Department"></asp:Label>
            </td>
            <td class="auto-style80">
                <asp:DropDownList ID="ddlLeaveDeptList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLeaveDeptList_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54" colspan="4">
                <asp:Panel ID="Panel4" runat="server">
                    <asp:GridView ID="GVLeave" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVLeave_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="Employee Num" />
                            <asp:BoundField DataField="EmployeeName" HeaderText="Name" />
                            <asp:BoundField DataField="LeaveTypeName" HeaderText="Leave Type" />
                            <asp:BoundField DataField="Duration" HeaderText="Duration" />
                            <asp:BoundField DataField="DateApplied" HeaderText="DateApplied" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtLeaveEmpID" Visible="false" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox>
                                                                      </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtLeaveID" Visible="false" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.LeaveID") %>'></asp:TextBox>
                                                                      </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtLeaveLogID" Visible="false" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.LeaveLogID") %>'></asp:TextBox>
                                                                      </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtLeaveThresholdB4App" Visible="false" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.LeaveThresholdBeforeApplication") %>'></asp:TextBox>
                                                                      </ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtLeaveThreshold" Visible="false" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.LeaveThreshold") %>'></asp:TextBox>
                                                                      </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton23"  CommandArgument='<%#DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'  CommandName="View" runat="server">View</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style80">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style54" colspan="4">
                <asp:Panel ID="PanelLeaveRequestDetails" runat="server" Visible="False">
                    <table style="width:80%; margin-left:50px;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label145" runat="server" style="font-weight: 700" Text="Name"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpName" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label146" runat="server" style="font-weight: 700" Text="Leave Type"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblLeaveType" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label147" runat="server" style="font-weight: 700" Text="Description"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblLeaveDescription" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label148" runat="server" style="font-weight: 700" Text="Start Date"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="llblLeaveStartDate" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label149" runat="server" style="font-weight: 700" Text="End Date"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblLeaveEndDate" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label150" runat="server" style="font-weight: 700" Text="Duration"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblLeaveDuration" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label ID="Label156" runat="server" style="font-weight: 700" Text="Leave Threshold"></asp:Label>
                             </td>
                            <td> <asp:Label ID="lblLeaveThresholdB4App" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                         </td>
                            <td>&nbsp;</td>
                        </tr>
                         <tr>
                            <td>
                                &nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                         <tr>
                            <td>
                                &nbsp;</td>
                            <td> <asp:Label ID="lblLeaveThreshold" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                         </td>
                            <td>&nbsp;</td>
                        </tr>
                         <tr>
                            <td>
                                &nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:LinkButton ID="linkToLeave" runat="server" OnClick="linkToLeave_Click" style="font-weight: 700">Click here to approve or reject leave request</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:Panel ID="PanelLeaveApproval" runat="server" Visible="False">
                                    <table style="width:100%; margin-left:40px;">
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label153" runat="server" style="font-weight: 700" Text="Approve/Disapprove"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddApproveOrDisapprove" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="ddApproveOrDisapprove_SelectedIndexChanged">

                                                    <asp:ListItem>***Please select***</asp:ListItem>
                                                    <asp:ListItem>Approved</asp:ListItem>
                                                    <asp:ListItem>Disapproved</asp:ListItem>

                                                </asp:DropDownList>
                                                  </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="LbReason" runat="server" Visible="false" style="font-weight: 700" Text="Reason for Disapproval"></asp:Label>
                                            </td>
                                            <td>
                                                  <asp:TextBox ID="txtReason" runat="server" Visible="false" Height="47px" TextMode="MultiLine" Width="214px"></asp:TextBox>
                                        
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label154" runat="server" Text="Date" style="font-weight: 700"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblLeaveApprovedDate" runat="server" style="font-weight: 700"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label155" runat="server" style="font-weight: 700" Text="Approved/RejectedBy"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblLeaveApprovedBy" runat="server" style="font-weight: 700"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">

                                                <asp:Label ID="LbLeaveUpdated" runat="server" style="font-weight: 700" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Visible="False"></asp:Label>
                                            </td>
                                            
                                        </tr>
                                         <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;&nbsp;<asp:Button ID="btnUpdateLeave" runat="server" OnClick="btnUpdateLeave_Click" style="font-weight: 700; color: #CC3300" Text="Save" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                         <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>

         <tr>
             <td class="auto-style54">&nbsp;</td>
             <td class="auto-style19">&nbsp;</td>
             <td class="auto-style80">&nbsp;</td>
             <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>


<asp:View ID="ViewQuery" runat="server">
    <table style="border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style96" colspan="4">
                <asp:Label ID="LbQuery0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Query Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style96" colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style96" colspan="4">
                <asp:LinkButton ID="LinkQuery" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkQuery_Click" style="font-weight: 700">Issue Query</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkDiscipline" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkDiscipline_Click" style="font-weight: 700">Discipline Employee</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style96" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="lblQueryIssueReport" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#669900"></asp:Label>
                <b>
                <asp:Label ID="lblDisciplineSuccessful" runat="server" Font-Italic="True" ForeColor="#669900"></asp:Label>
                </b></td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Panel ID="PanelQuryList" runat="server" Visible="false">

                    <table style="width: 100%;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="lblListQuery" runat="server" Font-Bold="True" Font-Size="14pt" style="font-weight: 700; font-style: italic; color: #CC3300" Text="List of Query Issued"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:GridView ID="GVHRQuery" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVHRQuery_RowCommand" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="EmployeeNum" HeaderText="Employee Num" />
                        <asp:BoundField DataField="QueryReceivedByName" HeaderText="Employee Name" />
                        <asp:BoundField DataField="QueryTitle" HeaderText="Query Title" />
                        <asp:BoundField DataField="IssueDate" HeaderText="Issue Date" />
                        <asp:BoundField DataField="ResponseDate" HeaderText="Response Date" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton22" runat="server"  CommandArgument='<%#DataBinder.Eval(Container,"DataItem.QueryID")%>' CommandName="View" >View</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                            
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style96" colspan="4">
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Panel ID="PanelQuery" runat="server" Width="80%">
                                <table style="width: 80%;  margin-left:75px; ">
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="LbDiscipline1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" style="color: #CC3300; font-size: small; font-style: italic;" Text="Select the employee you want to query "></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Department"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="queryDeptList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="queryDeptList_SelectedIndexChanged" Width="250px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeNum" style="font-size: medium"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="queryEmployeeList" runat="server" Width="250px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="QueryTitle0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Query Title"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtQueryTitle" runat="server" Width="250px"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="LbQueryDesc" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Query Description"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtQueryDesc" runat="server" Height="108px" Width="250px" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="Label135" runat="server" style="font-weight: 700" Text="Select Query Letter"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:FileUpload ID="QueryFileUpload" runat="server" />
                                            &nbsp;&nbsp;&nbsp;
                                            <asp:LinkButton ID="LinkButton21" runat="server">Upload Letter</asp:LinkButton>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="LbIssueDate1" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Issue Date"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="LbHrQueryIssueDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">
                                            <asp:Label ID="LbIssueBy0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="IssueBy"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="LbIssuedBy" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style149">&nbsp;</td>
                                        <td>
                                            <asp:Button ID="btnSendQuery" runat="server" Text="Send Query" OnClick="btnSendQuery_Click" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        
                    </tr>
                    
                </table>
            </td>
        </tr>
       <%-- <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">
                <asp:Label ID="LbIssueDate" runat="server" Font-Bold="True" Text="Issue Date" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style100">
                <asp:TextBox ID="txtQueryIssuedDate" runat="server" Width="225px"></asp:TextBox>
                <asp:ImageButton ID="queryIssuedDateCalenderImageBtn" runat="server" Height="25px" ImageUrl="~/images/calendar.png" Width="25px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">&nbsp;</td>
            <td class="auto-style100">
                <asp:Calendar ID="IssueDateCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" Visible="False">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>&nbsp;</td>
        </tr>--%>

        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">&nbsp;</td>
            <td class="auto-style100">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style96" colspan="4"><asp:Panel ID="PanelDiscipline" runat="server" Width="80%" Visible="False">
                                <table style="width: 80%;  margin-left:75px; ">
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="LbDiscipline0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" style="color: #CC3300; font-size: small; font-style: italic;"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style183"><strong>EmployeeNum</strong></td>
                                        <td>
                                            <asp:Label ID="lblDisEmpNum" runat="server" style="color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Query Title</b></td>
                                        <td>
                                            <asp:Label ID="lblDisQueryTitle" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Query Description</b></td>
                                        <td colspan="2">
                                            <asp:Label ID="lblDisQueryDescription" runat="server" style="color: #CC3300; font-style: italic;" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Issued Day</b></td>
                                        <td>
                                            <asp:Label ID="lblDisQueryIssueDay" runat="server" CssClass="auto-style183" style="color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Employee Response</b></td>
                                        <td colspan="2">
                                            <asp:Label ID="lblDisQueryResponse" runat="server" CssClass="auto-style183" style="color: #CC3300; font-style: italic;" Text="Label"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Date Responded</b></td>
                                        <td>
                                            <asp:Label ID="lblDisResponseDate" runat="server" CssClass="auto-style183" style="color: #CC3300" Text="Label"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="Label143" runat="server" style="font-weight: 700; font-style: italic; color: #CC3300" Text="Specify the following if there is need to discipline the employee"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline Type</b></td>
                                        <td>
                                            <asp:DropDownList ID="ddlDisciplineType" runat="server" CssClass="auto-style183" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="ddlDisciplineType_SelectedIndexChanged">
                                                <asp:ListItem>---Please Select----</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline Description</b></td>
                                        <td>
                                            <asp:TextBox ID="txtDisciplineDescription" runat="server" Height="88px" Width="241px" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="LbSuspentiodSDate" visible="False" runat="server" Text="Suspention Start Date" Font-Bold="True"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddSuspStartDay" Visible="false" runat="server"></asp:DropDownList>  <asp:DropDownList ID="ddSuspStartMonth" Visible="false" runat="server">
                                            <asp:ListItem>***Month**</asp:ListItem>
                                            <asp:ListItem>Jan</asp:ListItem>
                                            <asp:ListItem>Feb</asp:ListItem>
                                            <asp:ListItem>Mar</asp:ListItem>
                                            <asp:ListItem>Apr</asp:ListItem>
                                            <asp:ListItem>May</asp:ListItem>
                                            <asp:ListItem>Jun</asp:ListItem>
                                            <asp:ListItem>Jul</asp:ListItem>
                                            <asp:ListItem>Aug</asp:ListItem>
                                            <asp:ListItem>Sep</asp:ListItem>
                                            <asp:ListItem>Oct</asp:ListItem>
                                            <asp:ListItem>Nov</asp:ListItem>
                                            <asp:ListItem>Dec</asp:ListItem>
                                            </asp:DropDownList>  <asp:DropDownList ID="ddSuspStartYear" Visible="false" runat="server"></asp:DropDownList>
                                            <asp:Label ID="LbSuspStartDate" runat="server" Text="Label" Visible="False"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                     <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td> <asp:Label ID="LbSuspentionEDate" visible="False" runat="server" Text="Suspention End Date" Font-Bold="True"></asp:Label>
                                       </td>
                                        <td> <asp:DropDownList ID="ddSuspEndDay" Visible="false" runat="server"></asp:DropDownList>  <asp:DropDownList ID="ddSuspEndMonth" Visible="false" runat="server">
                                              <asp:ListItem>***Month**</asp:ListItem>
                                            <asp:ListItem>Jan</asp:ListItem>
                                            <asp:ListItem>Feb</asp:ListItem>
                                            <asp:ListItem>Mar</asp:ListItem>
                                            <asp:ListItem>Apr</asp:ListItem>
                                            <asp:ListItem>May</asp:ListItem>
                                            <asp:ListItem>Jun</asp:ListItem>
                                            <asp:ListItem>Jul</asp:ListItem>
                                            <asp:ListItem>Aug</asp:ListItem>
                                            <asp:ListItem>Sep</asp:ListItem>
                                            <asp:ListItem>Oct</asp:ListItem>
                                            <asp:ListItem>Nov</asp:ListItem>
                                            <asp:ListItem>Dec</asp:ListItem>
                                           </asp:DropDownList>  <asp:DropDownList ID="ddSuspEndYear" Visible="false" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddSuspEndYear_SelectedIndexChanged"></asp:DropDownList>
                                            <asp:Label ID="LbSuspEndDate" runat="server" Text="Label" Visible="False"></asp:Label>
                                        </td>
                                    </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td> <asp:Label ID="LbSuspentionDuration" visible="False" runat="server" Text="Suspention Duration" Font-Bold="True"></asp:Label>
                                       </td>
                                        <td>
                                            <asp:TextBox ID="txtSuspDuration" Visible="false" width="250px" runat="server"></asp:TextBox></td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline Date</b></td>
                                        <td>
                                            <asp:Label ID="lblDisciplineDate" runat="server"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Disciplined By:</b></td>
                                        <td><b></b>
                                            <asp:Label ID="lblDisciplineBy" runat="server"></asp:Label>
                                        </td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td><b>Discipline letter</b></td>
                                        <td>
                                            <asp:FileUpload ID="DisciplinedLetterUpload" runat="server" CssClass="auto-style183" />
                                            <b>&nbsp;
                                            <asp:Label ID="lblDisciplineLetterName" runat="server"></asp:Label>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></td>
                                        <td><b></b></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Button ID="btnSendDisciplined" runat="server" style="font-weight: 700" Text="Send" OnClick="btnSendDisciplined_Click" />
                                            &nbsp;
                                        </td>
                                        <td>
                                            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" style="font-weight: 700" Text="Close" />
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel></td>
        </tr>
        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td class="auto-style103">&nbsp;</td>
            <td class="auto-style100">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>

<%--<asp:View ID="ViewDiscipline" runat="server">
    <table style="border: medium solid #CC0066; width:100%;">
        <tr>
            <td>
                <asp:Label ID="LbDiscipline" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Discipline Management"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="disciplineEmployeeList" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style11">
                &nbsp;
                <asp:Label ID="LbOffenceDesc" runat="server" Font-Bold="True" Text="Offence Description"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtDisciplineDesc" runat="server"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbDisciplineSupervisorName" runat="server" Font-Bold="True" Text="Supervisor Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDisciplineSupervisorName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbSanction" runat="server" Font-Bold="True" Text="Sanction(Penalty)"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSanction" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="LbDisciplineBy" runat="server" Font-Bold="True" Text="DisciplinedBy"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LbDisciplined" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LbsanctionDuration" runat="server" Font-Bold="True" Text="Sanction Duration"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSactionDuration" runat="server"></asp:TextBox>
                &nbsp; </td>
        </tr>

         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbDateCommitted" runat="server" Font-Bold="True" Text="Offence Comitted Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="offenceComittedDateCalender" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
            <td>
                <asp:Label ID="LbDisciplineDate" runat="server" Font-Bold="True" Text="Discipline Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="disciplineDateCalender" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="disciplineBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Discipline" />
            </td>
            <td>
                <asp:Button ID="disciplineNextBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Next" OnClick="disciplineNextBtn_Click" />
                &nbsp;
                <asp:Button ID="disciplineBackBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Back" OnClick="disciplineBackBtn_Click" />
            </td>
            <td>
                <asp:Button ID="disciplineHomeBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Home" OnClick="disciplineHomeBtn_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>--%>
<asp:View ID="ViewAppraisal" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="Label49" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Appraisal Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

        </tr>
            <tr>
                <td class="auto-style3" colspan="4">
                    <ul>
                        <li>Click Recommend Button to recomment employee for promotion</li>
                         <li>Click Management Button to enter management decision for employee </li>
                         <li>Click Print Appraisal Button to print employee appraisal details</li>
                    </ul>
                </td>
                
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style3" colspan="4">
                    <asp:Button ID="RecommendBtn" runat="server" Text="Recommend for Promoton" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="RecommendBtn_Click"  />
                    <asp:Button ID="ManagementBtn" runat="server" Text="Management Decision" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="ManagementBtn_Click"  />
                     <asp:Button ID="welPrintAppraisa" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Print Appraisal" Width="150px" OnClick="welPrintAppraisa_Click" Height="45px" />
                    
                </td>
                     </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

        </tr>
            <tr>
                <td class="auto-style3" colspan="4">
                   
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                     </tr>
        </table>

    </asp:View>
<asp:View ID="ViewAppradisalMangementDecision" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="Label50" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Appraisal Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

        </tr>
            <tr>
                <td class="auto-style3" colspan="4">
                    <asp:GridView ID="GViewAppraisalManagementDecision" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">

                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                        <Columns>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                            <asp:BoundField DataField="AppraisalScore" HeaderText="AppraisalScore" />
                            <asp:BoundField DataField="PromoExamScore" HeaderText="ExamScore" />
                            <asp:BoundField DataField="TotalAppraisalScore" HeaderText="TotalScore" />
                            <asp:BoundField DataField="EvaPeriod" HeaderText="EvaPeriod" />
                            <asp:BoundField DataField="SupComment" HeaderText="SupComment" />
                            <asp:BoundField DataField="PromoRecommendation" HeaderText="SupRecommendation" />
                            <asp:BoundField DataField="HRComment" HeaderText="HRComment" />
                            <asp:BoundField DataField="HRPromoRecommendation" HeaderText="HRRecommendation" />
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtManageEmpID_FK" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtManageSupID_FK" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.SupervisorID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtManageApplID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.AppraisalID")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField HeaderText="Select"><EditItemTemplate><asp:CheckBox ID="CheckBoxSelectEmp" runat="server" /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="CheckBoxSelectEmp" runat="server" /></ItemTemplate></asp:TemplateField>
                        </Columns>

                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

                    </asp:GridView>
                </td>
                     </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

        </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label138" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="Black" Text="Management Decision"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="appraisalManagementDecisionList" runat="server" Width="250px">
                        <asp:ListItem Selected="True">***Please select***</asp:ListItem>
                        <asp:ListItem>Promote</asp:ListItem>
                        <asp:ListItem>To be Considered</asp:ListItem>
                        <asp:ListItem>Not Qualify</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label139" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="Black" Text="Date"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbManagementDate" runat="server" Font-Bold="False" ForeColor="#CC0066" Text="Date"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="managementSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="managementSaveBtn_Click" Text="Save" />
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbDecision" runat="server" Font-Bold="False" ForeColor="#33CC33" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        </table>

    </asp:View>

<asp:View ID="ViewRecommend" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbAppraisal" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Appraisal Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

        </tr>
            <tr>
                <td class="auto-style3" colspan="4">
                    <asp:Label ID="lbAppraisalRecomSuccessful" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:LinkButton ID="LinkEmpSelfAppraisal" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkEmpSelfAppraisal_Click" Visible="False">Print Appraisal Details</asp:LinkButton>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="4">
                    <asp:Panel ID="PanelHRAppraisal" runat="server">
                        <table style="width:100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                     </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="appraisalEmployeeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="appraisalEmployeeList_SelectedIndexChanged" Width="200px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisor0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Supervisor Name"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEmpSup" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label68" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpDept" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpPosition" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LbEvaluationPeriod0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Evaluation Period"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEvalPeriod" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label134" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Year of Service"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbAppraisalStartYear" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisal2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Self-Appraisal Score"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisalScore" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisal1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Supervisor Mark"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSupAppraisalScore" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="LbPromo" runat="server" Font-Bold="True" Font-Size="14pt" Text="Promo Exam"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtExamScore" runat="server" OnTextChanged="txtExamScore_TextChanged" AutoPostBack="True"></asp:TextBox>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:Label ID="LbSelfAppraisal6" runat="server" Font-Bold="True" Font-Size="14pt" Text="Total Score"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtTotalExamScore" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="LbSelfAppraisal7" runat="server" Font-Bold="True" Font-Size="14pt" Text="Promo Recomm"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:DropDownList ID="HRPromoRecomList" runat="server" Visible="False">
                                            <asp:ListItem>***Please Select***</asp:ListItem>
                                            <asp:ListItem>Recommend</asp:ListItem>
                                            <asp:ListItem>Not Recommend</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:Label ID="LbSelfAppraisal8" runat="server" Font-Bold="True" Font-Size="14pt" Text="HR Comment"></asp:Label>
                                    </td>
                                    <td class="auto-style3">
                                        <asp:TextBox ID="txtHRComments" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LbEvaluator0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Date"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbHRAppraisalDate" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbSelfAppraisal3" runat="server" Font-Bold="True" Font-Size="14pt" Text="HR Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbHRName" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">
                                        <asp:Button ID="HRSaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="HRSaveBtn_Click" Text="Save" Visible="False" />
                                    </td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
            <tr>
                <td class="auto-style3" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
                                   
                          
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                             <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                          
                        </table>
                    </asp:Panel>
                </td>
            </tr>
                                         <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                          
                            <tr>
                                <td class="auto-style3" colspan="4">
                                    <asp:Panel ID="PanelSelfAppraisalDetails" runat="server" Visible="False">
                                        <table style="border: medium solid #CC0066; width:100%;">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="LbEmpDetails1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Appraisal Details for Management Approval" Visible="False"></asp:Label>
                                                </td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="Label137" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Appraisal Details"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewSelfAppraisalDetails" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmployeeNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="Employee" />
                                                            <asp:BoundField />
                                                            <asp:BoundField DataField="AppraisalScore" HeaderText="AppraisalScore" />
                                                            <asp:BoundField DataField="TotalPoint" HeaderText="TotalPoint" />
                                                            <asp:BoundField DataField="EvaPeriod" HeaderText="Evaluation Period" />
                                                            <asp:BoundField DataField="AprpraisalStartYear" HeaderText="StartYear" />
                                                            <asp:BoundField DataField="ExcelArea" HeaderText="ExcelArea" />
                                                            <asp:BoundField DataField="AreaThatNeedsImprovement" HeaderText="Area That Needs Improvement" />
                                                            <asp:BoundField DataField="StepsToTake" HeaderText="Steps To Take" />
                                                            <asp:BoundField DataField="AreaThatNeedsAssistance" HeaderText="Area That Needs Assistance" />
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Set Goals for Next Year"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewSelfAppraisalGoal" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="EmpName" />
                                                            <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                                            <asp:BoundField DataField="GoalObjectives" HeaderText="Goal Obj" />
                                                            <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                                            <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion Date" />
                                                           
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>

                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="Label46" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Supervisor Appraisal Details"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewSupAppraisalDetails" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmployeeNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="Employee" />                                                            
                                                             <asp:BoundField DataField="DisplayName" HeaderText="Supervisor Name" />                                                           
                                                            <asp:BoundField DataField="ExcelArea" HeaderText="ExcelArea" />
                                                            <asp:BoundField DataField="AreaThatNeedsImprovement" HeaderText="Area That Needs Improvement" />
                                                            <asp:BoundField DataField="StepsToTake" HeaderText="Steps To Take" />
                                                            <asp:BoundField DataField="AreaThatNeedsAssistance" HeaderText="Area That Needs Assistance" />
                                                            <asp:BoundField DataField="AppraisalScore" HeaderText="AppraisalScore" />
                                                            <asp:BoundField DataField="PromoExamScore" HeaderText="ExamScore" />
                                                             <asp:BoundField DataField="TotalAppraisalScore" HeaderText="TotalScore" />
                                                            <asp:BoundField DataField="TotalPoint" HeaderText="TotalPoint" />
                                                            <asp:BoundField DataField="EvaPeriod" HeaderText="Evaluation Period" />
                                                            <asp:BoundField DataField="AprpraisalStartYear" HeaderText="StartYear" />
                                                            <asp:BoundField DataField="SupAppraisalDate" HeaderText="SupAppraisalDate" />
                                                             <asp:BoundField DataField="SupComment" HeaderText="SupComment" />
                                                             <asp:BoundField DataField="HRComment" HeaderText="HRComment" />
                                                             <asp:BoundField DataField="PromoRecommendation" HeaderText="SupRecom" />
                                                              <asp:BoundField DataField="HRPromoRecommendation" HeaderText="SupRecom" />
                                                            
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Supervisor Set Goals for Next Year" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewSupAppraisalGoal" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="EmpName" />
                                                            <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                                            <asp:BoundField DataField="GoalObjectives" HeaderText="Goal Obj" />
                                                            <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                                            <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion Date" />
                                                            
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                              <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button ID="SelfAppraisalPrintBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="SelfAppraisalPrintBtn_Click" Text="Print" Visible="False" />
                                                </td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <%--<input type="button" value="Print"  onclick="CallPrint();" />--%>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                     
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            
    </table>
       </asp:View>
<asp:View ID="ViewPromotion" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style79" colspan="4">
                <asp:Label ID="LbPromotion" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Promotion Management"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>

          <tr>
              <td class="auto-style183" colspan="4">
                  <asp:LinkButton ID="LinkBtnPromote" runat="server" OnClick="LinkBtnPromote_Click">Promote</asp:LinkButton>
                  &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:LinkButton ID="LinkBtnListPromotedEmp" runat="server" OnClick="LinkBtnListPromotedEmp_Click">List Promoted Emp</asp:LinkButton>
                  &nbsp;&nbsp;
                  <asp:LinkButton ID="LinkBtnPromotedHist" runat="server" OnClick="LinkBtnPromotedHist_Click">Promotion History</asp:LinkButton>
              </td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183" colspan="4"><asp:Label ID="LbPromoSuccessful" runat="server" Enabled="False" Font-Bold="True" ForeColor="#33CC33" Text="Label" Visible="False"></asp:Label>
       </td>

        </tr>

          <tr>
            <td class="auto-style183" colspan="4">
                <asp:Panel ID="PanelPromoDisplay" Visible="false" runat="server">
                    <table style="width: 100%;">
                        <tr>
                            <td colspan="4">
                
                <p>Please follow the instruction below to promote an employee</p>
                <ul>
                    <li>Select the employee you want to promote</li>
                    <li>Select the new level</li>
                    <li>select the new position</li>
                    <li>Enter the promotion exam score there is any</li>
                     <li>Click 'Promote" button</li>
                    <li>Click the "List" button to list all employee that have been promoted</li>
                </ul>
            </td>
                            </tr>
        
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">
                &nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="Label160" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="PromoDepartmentList" runat="server" Width="250px" OnSelectedIndexChanged="PromoDepartmentList_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
                        <tr>
                            <td class="auto-style183">&nbsp;</td>
                            <td class="auto-style185">&nbsp;</td>
                            <td class="auto-style111">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style183">&nbsp;</td>
                            <td class="auto-style185">
                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
                            </td>
                            <td class="auto-style111">
                                <asp:DropDownList ID="PromoEmployeeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="PromoEmployeeList_SelectedIndexChanged" Width="250px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="LbPromoAppraisalScore" runat="server" Font-Bold="True" Font-Size="14pt" Text="Appraisal Score"></asp:Label>
            </td>
            <td class="auto-style111">
                &nbsp;<asp:Label ID="LbAppraisalScore" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="LbPromoAppraisalScore0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Promotion Exam Score"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbPromoExamScore" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="LbPromoAppraisalScore1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Total Score"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbTotAppraisalScore" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="preLevel0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Management Decision"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbManagementDecision" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style184">
                &nbsp;</td>
            <td class="auto-style149">
                <asp:Label ID="preLevel" runat="server" Font-Bold="True" Font-Size="14pt" Text="Previous Level"></asp:Label>
            </td>
            <td class="auto-style112">
                <asp:Label ID="LbPreLevel" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style183">&nbsp;</td>
             <td class="auto-style185"></td>
            <td class="auto-style111"></td>
            <td class="auto-style3"></td>
        </tr>
            <tr>      
      
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="Label132" runat="server" Font-Bold="True" Font-Size="14pt" Text="Previous Dept"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbPromoPreDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">
                &nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="14pt" Text="Previous Position"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbPrePosition" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185"></td>
            <td class="auto-style111"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="Label133" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Dept"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="PromoNewDeptList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="PromoNewDeptList_SelectedIndexChanged" Visible="False" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Position"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="PromoNewPositionList" runat="server" Width="250px" Visible="False">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                         <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="promoNewLevel" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Level"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="promoNewLevelList" runat="server" Width="250px" Visible="False" AutoPostBack="True" OnSelectedIndexChanged="promoNewLevelList_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style185">
                <asp:Label ID="promoNewLevel0" runat="server" Font-Bold="True" Font-Size="14pt" Text="New Salary"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbPromoNewSalary" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3"></td>
        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td class="auto-style185">&nbsp;</td>
                            <td class="auto-style111">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="DataPromoted1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Promo Effect Date"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:DropDownList ID="promoDayList" runat="server">
                </asp:DropDownList>
                &nbsp;
                <asp:DropDownList ID="promoMonthList" runat="server">
                    <asp:ListItem>***Month***</asp:ListItem>
                    <asp:ListItem>Jan</asp:ListItem>
                    <asp:ListItem>Feb</asp:ListItem>
                    <asp:ListItem>Mar</asp:ListItem>
                    <asp:ListItem>Apr</asp:ListItem>
                    <asp:ListItem>May</asp:ListItem>
                    <asp:ListItem>Jun</asp:ListItem>
                    <asp:ListItem>Jul</asp:ListItem>
                    <asp:ListItem>Aug</asp:ListItem>
                    <asp:ListItem>Sep</asp:ListItem>
                    <asp:ListItem>Nov</asp:ListItem>
                    <asp:ListItem>Dec</asp:ListItem>
                </asp:DropDownList>
                &nbsp;
                <asp:DropDownList ID="promoYearList" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="Label54" runat="server" Font-Bold="True" Font-Size="14pt" Text="Email"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbEmpEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">
                <asp:Label ID="DataPromoted0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Date Promoted"></asp:Label>
            </td>
            <td class="auto-style111">
                <asp:Label ID="LbPromotedDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style183">&nbsp;</td>
            <td class="auto-style185">&nbsp;</td>
            <td class="auto-style111">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style184">
                &nbsp;</td>
            <td class="auto-style149">
                <asp:Label ID="LbPromoBy" runat="server" Font-Bold="True" Font-Size="14pt" Text="PromotedBy"></asp:Label>
            </td>
            <td class="auto-style112">
                <asp:Label ID="LbPromotedBy" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
      
        <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">
                &nbsp;</td>
            <td class="auto-style112">
                <asp:Button ID="promoteBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Promote" OnClick="promoteBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td>
               <asp:Button ID="QualifFinishBtn8" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
        </tr>
        <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>                  
                    </table>
                </asp:Panel>

            </td>
           
        </tr>

            
  <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style54" colspan="4">
                <asp:Label ID="LbPromosuccess" runat="server" Enabled="False" Font-Bold="True" ForeColor="#33CC33" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style184">&nbsp;</td>
           
            <td class="auto-style112"> <asp:Button ID="printPromoLetterBtn" runat="server" Visible="false" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Print" OnClick="printPromoLetterBtn_Click" />
</td>
             <td class="auto-style149">&nbsp;</td>
            <td class="auto-style149"><asp:Button ID="newPromoFinishBtn" runat="server" Visible="false" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
</td>
            
        </tr>
            <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

    <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style184" colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Panel ID="PanelPromoLetter" runat="server" Visible="false">
        <table style="border: medium solid #C0C0C0; width:75%; margin-left:50px">
            <tr>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style194">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style194">&nbsp;</td>
                <td valign="right">
                    <asp:Label ID="Label72" runat="server" Text="Neetbeet Technologies Limited"></asp:Label>
                    <br />
                    <asp:Label ID="Label52" runat="server" Text="13, Adekunbi Cresent , Off Toyin Street, Ikeja, Lagos."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style194">&nbsp;</td>
                <td>
                    <asp:Label ID="Label53" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style194"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style46" colspan="3">Dear&nbsp;
                    <asp:Label ID="LbPromoLetterName" runat="server"></asp:Label>
                    ,</td>
            </tr>
            <tr>
                <td class="auto-style46" colspan="3">
                    <table style="width: 90%;">
                        <tr>
                            <td>
                                <center>
                                    <b><u>Promotion Letter </u></b>
                                </center>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <p>
                        Following the outcome of your appraisal we are happy to inform you that you have been promoted. 
             
                        Below are your Promotion details:
                        <ul>
                            <%--<li>Previous Department:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterPreDept" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>--%>
                            <li>New Department:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterNewDept" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                                </li>
                           <%-- <li>Previous Position:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterPrePosition" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>--%>
                        
                            <li>New Position:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterNewPosition" runat="server" ForeColor="#990033" Text="Label"></asp:Label>                            
                            </li>
                    
                           <%-- <li>Previous Level:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterPreLevel" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>--%>
                            <li>New Level:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterNewLevel" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                          <%--  <li>Previous Basic Salary:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterPreSalary" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>--%>
                            <li>New Basic Salary:&nbsp;&nbsp;
                                <asp:Label ID="LbLetterNewSalary" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                        </ul>
                        <p>
                            &nbsp;</p>
                        <p>
                            Please note the effect of the promotion will start from  <asp:Label ID="LbPromoEffectDate" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                        <p>
                        </p>
                        <p>
                        </p>
                            <p>
                            </p>
                            <p>
                            </p>
                            <p>
                            </p>
                            <p>
                            </p>
                            <p>
                            </p>
                    </p>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style194">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
            </td>

        </tr>
        <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style149">&nbsp;</td>
            <td class="auto-style112">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>

        
<%--<asp:View ID="ViewPension" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style113" colspan="4">
                <asp:Label ID="LbPension" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Pension Management"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="pensionEmployeeList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbBankAdmin" runat="server" Font-Bold="True" Font-Size="14pt" Text="Bank Administrator"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtBankAdmin" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">
                &nbsp;</td>
            <td>
                <asp:Label ID="LbAcctName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAcctName" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style113">&nbsp;</td>
             <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbAcctNum0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Number"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtAcctNum" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style113">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbEmpMonthlyContr" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Monthly Contribution"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEmployeeMonthContributn" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style113">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style113">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="LbEmployerMonthlyContr0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employer Monthly Contribution"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEmployerMonthContributn0" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>
                <asp:Label ID="LbEmployerMonthlyContr1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Total Monthly Contribution"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTotalMonthContributn" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="pensionBtn1" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Place Employee on Pension" Width="221px" />
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style114">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>--%>
    <asp:View ID="ViewRetirement" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="LbRetirment" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Retirement Management"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeID"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:DropDownList ID="RetirementEmployeeList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="LbRetireLevel" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level as at Retirement"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:TextBox ID="txtRetirementSalary" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">
                <asp:Label ID="LMonthlyPension" runat="server" Font-Bold="True" Font-Size="14pt" Text=" Monthly Pension Allowance"></asp:Label>
            </td>
            <td class="auto-style121">
                <asp:TextBox ID="TextBox6" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119"></td>
            <td class="auto-style121"></td>
            <td class="auto-style3"></td>

        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="LbGratuity" runat="server" Font-Bold="True" Font-Size="14pt" Text="Gratuity/Entitlement"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:TextBox ID="txtGratuity" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">
                <asp:Label ID="LbStartYearofService" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Year of Service"></asp:Label>
            </td>
            <td class="auto-style121">
                <asp:DropDownList ID="retireStartYearofService" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Label ID="LbEndYearofService" runat="server" Font-Bold="True" Font-Size="14pt" Text="End Year of Service"></asp:Label>
                </td>
                <td class="auto-style121">
                    <asp:DropDownList ID="retireEndYearofService" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style123">
                &nbsp;</td>
            <td class="auto-style120">
                <asp:Label ID="LbTotalYearofService" runat="server" Font-Bold="True" Font-Size="14pt" Text="Total Year of Service"></asp:Label>
            </td>
            <td class="auto-style122">
                <asp:TextBox ID="txtTotalYearofService" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">
                &nbsp;</td>
            <td class="auto-style120">
                <asp:Button ID="retirementBackBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Retire" />
            </td>
            <td class="auto-style122">
                <asp:Button ID="QualifFinishBtn9" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="QualifFinishBtn_Click" Text="Finish" />
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>

<asp:View ID="ViewPrintAppraisal" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label41" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Print Self Appraisal"></asp:Label>
            </td>

        </tr>

        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
              <tr>
                  <td class="auto-style124" colspan="4">
                      <asp:LinkButton ID="LinkPrintSelf" runat="server" Font-Bold="True" Font-Size="15pt" OnClick="LinkPrintSelf_Click">Print Emp Self-Appraisal</asp:LinkButton>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:LinkButton ID="LinkPrintSupApp" runat="server" Font-Bold="True" Font-Size="15pt">Print Supervisor Appraisal</asp:LinkButton>
                  </td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
              <tr>
                                <td class="auto-style3" colspan="4">
                                    <asp:Panel ID="PanelNewSelfAppraisal" runat="server" Visible="False">
                                        <table style="width:100%;">
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="LbAppDetails" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Appraisal Details for Management Approval" Visible="true"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>
                                                    <asp:Label ID="LbEmp" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee" Visible="False"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="printAppraisalEmployeeList" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="printAppraisalEmployeeList_SelectedIndexChanged" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="LbEmpDetails" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Appraisal Details" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewNewSelfAppraisal" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmployeeNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="Employee" />
                                                            <asp:BoundField />
                                                            <asp:BoundField DataField="AppraisalScore" HeaderText="AppraisalScore" />
                                                            <asp:BoundField DataField="TotalPoint" HeaderText="TotalPoint" />
                                                            <asp:BoundField DataField="EvaPeriod" HeaderText="Evaluation Period" />
                                                            <asp:BoundField DataField="AprpraisalStartYear" HeaderText="StartYear" />
                                                            <asp:BoundField DataField="ExcelArea" HeaderText="ExcelArea" />
                                                            <asp:BoundField DataField="AreaThatNeedsImprovement" HeaderText="Area That Needs Improvement" />
                                                            <asp:BoundField DataField="StepsToTake" HeaderText="Steps To Take" />
                                                            <asp:BoundField DataField="AreaThatNeedsAssistance" HeaderText="Area That Needs Assistance" />
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                             <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="LbGoalDetails" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Set Goals for Next Year" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewNewSelfAppraisalGoal" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="EmpName" />
                                                            <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                                            <asp:BoundField DataField="GoalObjectives" HeaderText="Goal Obj" />
                                                            <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                                            <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion Date" />
                                                          
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="LbNewSupAppraisalDetails" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Supervisor Appraisal Details" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewNewSupAppraisal" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmployeeNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="Employee" />                                                            
                                                             <asp:BoundField DataField="DisplayName" HeaderText="Supervisor Name" />                                                           
                                                            <asp:BoundField DataField="ExcelArea" HeaderText="ExcelArea" />
                                                            <asp:BoundField DataField="AreaThatNeedsImprovement" HeaderText="Area That Needs Improvement" />
                                                            <asp:BoundField DataField="StepsToTake" HeaderText="Steps To Take" />
                                                            <asp:BoundField DataField="AreaThatNeedsAssistance" HeaderText="Area That Needs Assistance" />
                                                            <asp:BoundField DataField="AppraisalScore" HeaderText="AppraisalScore" />
                                                            <asp:BoundField DataField="PromoExamScore" HeaderText="ExamScore" />
                                                             <asp:BoundField DataField="TotalAppraisalScore" HeaderText="TotalScore" />
                                                            <asp:BoundField DataField="TotalPoint" HeaderText="TotalPoint" />
                                                            <asp:BoundField DataField="EvaPeriod" HeaderText="Evaluation Period" />
                                                            <asp:BoundField DataField="AprpraisalStartYear" HeaderText="StartYear" />
                                                            <asp:BoundField DataField="SupAppraisalDate" HeaderText="SupAppraisalDate" />
                                                             <asp:BoundField DataField="SupComment" HeaderText="SupComment" />
                                                             <asp:BoundField DataField="HRComment" HeaderText="HRComment" />
                                                             <asp:BoundField DataField="PromoRecommendation" HeaderText="SupRecom" />
                                                              <asp:BoundField DataField="HRPromoRecommendation" HeaderText="SupRecom" />
                                                            
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:Label ID="LbNewSupGoalDetails" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Supervisor Set Goals for Next Year" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="4">
                                                    <asp:GridView ID="GViewNewSupAppraisalGoal" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                        <Columns>
                                                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                                                            <asp:BoundField DataField="Employee" HeaderText="EmpName" />
                                                            <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                                            <asp:BoundField DataField="GoalObjectives" HeaderText="Goal Obj" />
                                                            <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                                            <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion Date" />
                                                            
                                                        </Columns>
                                                        <EditRowStyle BackColor="#999999" />
                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button ID="newPrintSelfAppraisal" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="newPrintSelfAppraisal_Click" Text="Print" Visible="False" />
                                                </td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>&nbsp;</td>
                                                 <td>&nbsp;</td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                          
                        <tr>
                            <td class="auto-style3" colspan="4">
                                &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
                          
                        </table>
                    </asp:Panel>
                </td>
            </tr>

            <tr>

                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    &nbsp;</td>
                <td class="auto-style121">
                  
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>

<asp:View ID="ViewEditEmployeeDetails" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Edit Employee Details"></asp:Label>
            </td>

        </tr>

        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
             
            <tr>
                <td class="auto-style124" colspan="4">
                    <asp:LinkButton ID="LinkBtnEditBasicInfo" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkBtnEditBasicInfo_Click">Edit Basic Info</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkBtnEditSpouseInfo" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkBtnEditSpouseInfo_Click">Edit Spouse Info</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkBtnEditNOKInfo" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkBtnEditNOKInfo_Click">Edit NOK Info </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">&nbsp;</td>
                <td class="auto-style121">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
              
                            <tr>
                                <td class="auto-style3" colspan="4">
                                    <asp:Label ID="lbEmpSpouseAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                  <asp:Label ID="lbEmpInfoEdited" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                 
                                    <asp:Label ID="lbEmpNOKEdited" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                  &nbsp;</td>
                            </tr>
                          
                     
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
                  
            <tr>

                <td class="auto-style124">&nbsp;</td>
                <td class="auto-style119">
                    <asp:Button ID="BtnEditFinish" Visible="false" runat="server" Font-Bold="True" ForeColor="#009900" OnClick="BtnEditFinish_Click" Text="Finsh" />
                </td>
                <td class="auto-style121">
                  
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style124">&nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>
<asp:View ID="ViewEditBasiInfo" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Edit Employee Basic Info"></asp:Label>
            </td>

        </tr>
             <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label55" runat="server" Text="Department" Font-Bold="true" Font-Size="14"></asp:Label></td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddEditEmpInfoDept" runat="server" Width="250px" AutoPostBack="true" OnSelectedIndexChanged="ddEditEmpInfoDept_SelectedIndexChanged"></asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
            
             <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="LbEditEmp1" runat="server" Visible="false" Text="Employee" Font-Bold="true" Font-Size="14"></asp:Label></td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddEditEmpInfoEmpNum" Visible="false" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="ddEditEmpInfoEmpNum_SelectedIndexChanged"></asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style30" colspan="5">
                    <asp:Panel ID="PanelEditEmpInfo" Visible="false" runat="server">

                        <table style="width: 100%;">
                             <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label82" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Basic Info"></asp:Label>
            </td>

        </tr>

        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;
            </td>
        </tr>
                     
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Title"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:DropDownList ID="titleList" runat="server" Width="330px">
                        <asp:ListItem Selected="True" Value="***Please Select***"></asp:ListItem>
                        <asp:ListItem>Dr</asp:ListItem>
                        <asp:ListItem>Elder</asp:ListItem>
                        <asp:ListItem>Miss</asp:ListItem>
                        <asp:ListItem>Mr</asp:ListItem>
                        <asp:ListItem>Mrs</asp:ListItem>
                        <asp:ListItem>Prof</asp:ListItem>
                        <asp:ListItem>Pastor</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtFName" runat="server" Width="338px"></asp:TextBox>
                    &nbsp;</td>
                <td class="auto-style18"></td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
    <tr>
        <td class="auto-style30">&nbsp;</td>
        <td class="auto-style74">&nbsp;</td>
        <td class="auto-style26">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style21">&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="LBMidName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Middle Name" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtMName" runat="server" Width="345px"></asp:TextBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style47">
            </td>
        <td class="auto-style65">
            &nbsp;<asp:Label ID="LBlName" runat="server" Font-Bold="True" Text="Last Name" Font-Size="14pt" style="font-size: medium"></asp:Label>
         </td>
         <td class="auto-style66">
             <asp:TextBox ID="txtLName" runat="server" Width="342px"></asp:TextBox>
         </td>
        <td class="auto-style67"></td>
        <td class="auto-style68">
            </td>
    </tr>

     <tr>
        <td class="auto-style30">&nbsp;</td>
        <td class="auto-style74">&nbsp;</td>
        <td class="auto-style26">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style21">&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label48" runat="server" Font-Bold="True" Font-Size="14pt" Text="Marital Status" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddlMaritalStatus" runat="server" Height="16px" Width="351px">
                        <asp:ListItem>---Please select---</asp:ListItem>
                        <asp:ListItem>Single</asp:ListItem>
                        <asp:ListItem>Married</asp:ListItem>
                        <asp:ListItem>Deforced</asp:ListItem>
                        <asp:ListItem>Widow</asp:ListItem>
                        <asp:ListItem>Widower</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style30">
            &nbsp;</td>
        <td class="auto-style74">
            &nbsp;<asp:Label ID="LbEmail" runat="server" Font-Bold="True" Text="Email" Font-Size="14pt" style="font-size: medium"></asp:Label>
         </td>
        <td class="auto-style26">
            <asp:TextBox ID="txtEmail" runat="server" Width="346px"></asp:TextBox>
         </td>
           <td> </td>
        <td class="auto-style18">
            &nbsp;</td>
           <td>&nbsp;</td>
    </tr>

     <tr>
        <td class="auto-style30">&nbsp;</td>
        <td class="auto-style74">&nbsp;</td>
        <td class="auto-style26">&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style21">&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="LBPhnNo" runat="server" Font-Bold="True" Font-Size="14pt" Text="PhoneNum" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtPhnNum" runat="server" Width="346px"></asp:TextBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="LbContAddr" runat="server" Font-Bold="True" Font-Size="14pt" Text="Contact Address" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtContAddr" runat="server" Width="345px"></asp:TextBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="LbContAddr0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Religion"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:DropDownList ID="religionList" runat="server" Width="330px">
                        <asp:ListItem>***Please Select***</asp:ListItem>
                        <asp:ListItem>Christianity</asp:ListItem>
                        <asp:ListItem>Islam</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
                            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label56" runat="server" Font-Bold="True" Font-Size="14pt" Text="Acct Name" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtAcctName" runat="server" Width="345px"></asp:TextBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
                            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label60" runat="server" Font-Bold="True" Font-Size="14pt" Text="Acct Num" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtAcctNum" runat="server" Width="345px"></asp:TextBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
                            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label62" runat="server" Font-Bold="True" Font-Size="14pt" Text="Bank Name" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtBankName" runat="server" Width="345px"></asp:TextBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
                 <tr>
                     <td class="auto-style30">&nbsp;</td>
                     <td class="auto-style74">&nbsp;</td>
                     <td class="auto-style26">&nbsp;</td>
                     <td class="auto-style18">&nbsp;</td>
                     <td class="auto-style21">&nbsp;</td>
            </tr>

                 <tr>
                     <td class="auto-style30">&nbsp;</td>
                     <td class="auto-style74">&nbsp;</td>
                     <td class="auto-style26">
                         <asp:Button ID="EmpEditSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33"  style="font-size: medium; color: #CC3300;" Text="Save" OnClick="EmpEditSaveBtn_Click" />
                     </td>
                     <td class="auto-style18">
                         &nbsp;</td>
                     <td class="auto-style21">
                       </td>
            </tr>
            <tr>
                <td class="auto-style52"></td>
                <td class="auto-style5"></td>
                <td class="auto-style28">
                    &nbsp;</td>
                <td class="auto-style20"></td>
                <td class="auto-style22"></td>
            </tr>
               </table>
                    </asp:Panel>
                </td>
                
            </tr>
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>
<asp:View ID="ViewEditSpouseInfo" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Edit Employee Spouse Info"></asp:Label>
            </td>

        </tr>
            
                <tr>
                    <td class="auto-style208">&nbsp;</td>
                    <td class="auto-style207">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>

              <tr>
                <td class="auto-style208">&nbsp;</td>
                <td class="auto-style207">
                    <asp:Label ID="Label59" runat="server" Text="Department" Font-Bold="true" Font-Size="14"></asp:Label></td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddEditSpouseDept" runat="server" Width="250px" AutoPostBack="true" OnSelectedIndexChanged="ddEditSpouseDept_SelectedIndexChanged"></asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style208">&nbsp;</td>
                <td class="auto-style207">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
            
             <tr>
                <td class="auto-style208">&nbsp;</td>
                <td class="auto-style207">
                    <asp:Label ID="LbEditEmp2" runat="server" Text="Employee" Font-Bold="True" Font-Size="14pt" Visible="False"></asp:Label></td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddEditSpouseEmpID" AutoPostBack="true" runat="server"  Width="250px" OnSelectedIndexChanged="ddEditSpouseEmpID_SelectedIndexChanged" Visible="False"></asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style208">&nbsp;</td>
                <td class="auto-style207">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>

             <tr>
                <td class="auto-style30" colspan="5">
                    <asp:Panel ID="PanelEditSpouseInfo" runat="server" Visible="false">
                        <table style="width: 100%;">
                           <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label76" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee's Spouse Info"></asp:Label>
            </td>

        </tr>

        <tr>
            <td class="auto-style124">
                &nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;
            </td>
        </tr>
            <tr>
                <td class="auto-style54"></td>
                <td class="auto-style64">
                    <asp:Label ID="LbspouseFNam" runat="server" Font-Bold="True" Text="Spouse Names" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtSpouseNames" runat="server" Width="300px" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
            </tr>
           

            
             <tr>
        <td class="auto-style54">&nbsp;</td>
        <td class="auto-style64">
            &nbsp;</td>
        <td class="auto-style61">
            &nbsp;</td>
        <td class="auto-style22">
            &nbsp;</td>
    </tr>

             <tr>
        <td class="auto-style54">&nbsp;</td>
        <td class="auto-style64">
            <asp:Label ID="LbSpousePhn0" runat="server" Font-Bold="True" Text="Spouse PhoneNum" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style61">
            <asp:TextBox ID="txtSpoucePhnNum" runat="server" Width="300px"></asp:TextBox>
                 </td>
        <td class="auto-style22">&nbsp;</td>
    </tr>

                 <tr>
                     <td class="auto-style54">&nbsp;</td>
                     <td class="auto-style64">&nbsp;</td>
                     <td class="auto-style61">&nbsp;</td>
                     <td class="auto-style22">&nbsp;</td>
            </tr>

                 <tr>
        <td class="auto-style54"></td>
        <td class="auto-style64">
            <asp:Label ID="LbSpouseEmail" runat="server" Font-Bold="True" Text="Spouse Email" Font-Size="14pt"></asp:Label>
                     </td>
        <td class="auto-style61">
            <asp:TextBox ID="txtSpouceEmail" runat="server" Width="300px"></asp:TextBox>
                     </td>
        <td class="auto-style22">
            &nbsp;</td>
    </tr>

                 <tr>
        <td class="auto-style54">&nbsp;</td>
        <td class="auto-style64">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
    </tr>

                 <tr>
                     <td class="auto-style54">&nbsp;</td>
                     <td class="auto-style64">
                         <asp:Label ID="LbSpouseAddrs" runat="server" Font-Bold="True" Text="Spouse Address" Font-Size="14pt"></asp:Label>
                     </td>
                     <td class="auto-style61">
                         <asp:TextBox ID="txtSpouceContAddress" runat="server" Width="300px"></asp:TextBox>
                     </td>
                     <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style64">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>

                 <tr>
        <td class="auto-style54">&nbsp;</td>
        <td class="auto-style64">
            <asp:Label ID="LbSpouseOccup" runat="server" Font-Bold="True" Text="Occupation" Font-Size="14pt"></asp:Label>
                     </td>
        <td class="auto-style61">
            <asp:TextBox ID="txtSpouceOccupation" runat="server" Width="300px"></asp:TextBox>
                     </td>
        <td class="auto-style22">
            &nbsp;</td>
    </tr>

                 <tr>
        <td class="auto-style54">&nbsp;</td>
        <td class="auto-style64">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
    </tr>
            <tr>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style64">
                    <asp:Label ID="LbSpouseEmplo" runat="server" Font-Bold="True" Text="Spouse Employer" Font-Size="14pt" ForeColor="#00000E"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtSpouceEmployer" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style64">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style64">&nbsp;</td>
                <td class="auto-style61">
                    <asp:Button ID="spouseSaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Save" OnClick="spouseSaveBtn_Click" />
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            
            
        <tr>
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                               
                        </table>
                    </asp:Panel>
                </td>
               
            </tr>
    </table>
</asp:View>
<asp:View ID="ViewEditNOK" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Edit Employee NOK Info"></asp:Label>
            </td>

        </tr>

        <tr>
            <td class="auto-style203">
                &nbsp;</td>
            <td class="auto-style119">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;
            </td>
        </tr>
             <tr>
                <td class="auto-style204">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="Label61" runat="server" Text="Department" Font-Bold="true" Font-Size="14"></asp:Label></td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddEditNOKDept" runat="server" Width="250px" AutoPostBack="true" OnSelectedIndexChanged="ddEditNOKDept_SelectedIndexChanged"></asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style204">&nbsp;</td>
                <td class="auto-style74">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
            
             <tr>
                <td class="auto-style204">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="LbEditEmp3" runat="server" Text="Employee" Font-Bold="True" Font-Size="14pt"></asp:Label></td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddEditNOKEmpID" runat="server" AutoPostBack="true" Width="250px" OnSelectedIndexChanged="ddEditNOKEmpID_SelectedIndexChanged" Visible="False"></asp:DropDownList>
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style204">&nbsp;</td>
                <td class="auto-style74">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">
                     &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style30" colspan="5">
                    <asp:Panel ID="PanelEditNOKInfo" Visible="false" runat="server">

                        <table style="width: 100%;">
                           
                       <tr>
            <td class="auto-style117" colspan="4">
                &nbsp;</td>

        </tr>

        <tr>
            <td class="auto-style199">
                &nbsp;</td>
            <td class="auto-style201">&nbsp;</td>
            <td class="auto-style121">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;
            </td>
        </tr>
              <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">
                    <asp:Label ID="LbnxtOfKinFName" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinfName" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">
                    <asp:Label ID="LbnxtOfKinMidName" runat="server" Font-Bold="True" Text="Middle Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinMidName" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">
                    <asp:Label ID="nxtOfKinLNameLabel" runat="server" Font-Bold="True" Text="Last Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinLName" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">
                    <asp:Label ID="LbNxtOfKinrelationship" runat="server" Font-Bold="True" Text="Relationship" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinRelationship" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">
                    <asp:Label ID="nxtOfKinphNoLabel" runat="server" Font-Bold="True" Text="Phone No" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinPhNo" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                
            </tr>
             <tr>
                 <td class="auto-style200">&nbsp;</td>
                 <td class="auto-style202">
                     <asp:Label ID="LbnxtOfKinEmail" runat="server" Font-Bold="True" Text="Email" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style61">
                     <asp:TextBox ID="txtNxtOfKinEmail" runat="server" Width="300px"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
             <tr>
        <td class="auto-style200">&nbsp;</td>
        <td class="auto-style202">
            <asp:Label ID="Lboccupation" runat="server" Font-Bold="True" Text="Occupation" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style61">
            <asp:TextBox ID="txtNxtOfKinOccupation" runat="server" Width="300px"></asp:TextBox>
                 </td>
        <td class="auto-style22">
            &nbsp;</td>
               
    </tr>
             <tr>
        <td class="auto-style200">&nbsp;</td>
        <td class="auto-style202">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
              
    </tr>
             <tr>
                 <td class="auto-style200">&nbsp;</td>
                 <td class="auto-style202">
                     <asp:Label ID="LbnxtOfKinContAddr" runat="server" Font-Bold="True" Text="Contact Address" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style61">
                     <textarea id="txtNxtOfKinContAdd" runat="server" name="S10" rows="2"></textarea></td>
                 <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style200">&nbsp;</td>
                <td class="auto-style202">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            
                
                <tr>
                    <td class="auto-style200">&nbsp;</td>
                    <td class="auto-style202">&nbsp;</td>
                    <td class="auto-style61">
                        <asp:Button ID="nextOfKinSaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Save" OnClick="nextOfKinSaveBtn_Click" />
                    </td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
             
                        </table>
                    </asp:Panel>
                </td>
               
            </tr>
            </tr>
            <tr>
                <td class="auto-style204">&nbsp;</td>
                <td class="auto-style120">&nbsp;</td>
                <td class="auto-style122">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
    </table>

</asp:View>
<asp:View ID="ViewSelfTransferRequest" runat="server">
    <table style="border: medium solid #990033; width: 100%;">
        <tr>
            <td > <asp:Label ID="Label88" runat="server" Font-Bold="True" Text="List of Employees whao have requested to be Transfer" Font-Size="14pt" ForeColor="Maroon"></asp:Label>
                </td></tr>
        <tr>
            <td></td>
            <tr>
                <td>
                    <asp:Label ID="Label157" runat="server" Font-Bold="True" ForeColor="#993333" Text="Please click on Edit to select the new department, location and approve or disapprove request and then update the record"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="PanelSelfTranRequest" runat="server">
                        <table style="width: 100%;">
                            <tr>
                                <td class="auto-style86" colspan="4">
                                    <asp:GridView ID="GViewTransferApproval" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCancelingEdit="GViewTransferApproval_RowCancelingEdit" OnRowDataBound="GViewTransferApproval_RowDataBound" OnRowEditing="GViewTransferApproval_RowEditing" OnRowUpdating="GViewTransferApproval_RowUpdating" Visible="False">
                                        <Columns>
                                            <asp:BoundField DataField="EmployeeNum" HeaderText="Employee" />
                                            <asp:BoundField DataField="PreDept" HeaderText="PreDept" />
                                            <asp:BoundField DataField="CurrentLocation" HeaderText="CurrentLocation" />
                                            <asp:BoundField DataField="DesLocation" HeaderText="DesireLocation" />
                                            <asp:BoundField DataField="TransferType" HeaderText="TransferType" />
                                            <asp:BoundField DataField="TransferReason" HeaderText="TransferReason" />
                                            <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" />
                                            <asp:TemplateField HeaderText="ApprovalDate">
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtApprovedate" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApproveDate")%>' Visible="true"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="TransferDate">
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtTransferdate" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferDate")%>' Visible="true"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="NewDept">
                                                <ItemTemplate>
                                                    <asp:DropDownList ID="transferNewDept" runat="server" DataTextField="DeptName" DataValueField="DeptID">
                                                    </asp:DropDownList>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="NewLocation">
                                                <ItemTemplate>
                                                    <asp:DropDownList ID="transferNewWorkLoc" runat="server" DataTextField="LocationName" DataValueField="WorkLocationID">
                                                    </asp:DropDownList>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Status">
                                                <ItemTemplate>
                                                    <asp:DropDownList ID="transferApprovalStatus" runat="server" AutoPostBack="true">
                                                        <asp:ListItem Value="Approved">Approved</asp:ListItem>
                                                        <asp:ListItem Value="Disapproved">Disapproved</asp:ListItem>
                                                    </asp:DropDownList>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtTransferEmpID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>' Visible="false"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtTranferedBy" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferedBy")%>' Visible="false"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtTranferID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferID")%>' Visible="false"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <%-- <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTranferID_FK" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                         <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtTranferLogID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferLogID")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                        --%>
                                            <asp:TemplateField HeaderText="Edit">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="transferEditBtn" runat="server" CommandName="Edit" text="Edit">Edit</asp:LinkButton>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:LinkButton ID="transferEditBtnUpdate" runat="server" CommandName="Update" Text="Update">Update</asp:LinkButton>
                                                    <asp:LinkButton ID="trancferEditBtnCancel" runat="server" CommandName="Cancel" Text="Cancel">Cancel</asp:LinkButton>
                                                </EditItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style86">&nbsp;</td>
                                <td class="auto-style88">&nbsp;</td>
                                <td class="auto-style90">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style86" colspan="4">
                                    <asp:Label ID="LbTransferUpdateSuccessful" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style86">&nbsp;</td>
                                <td class="auto-style88">&nbsp;</td>
                                <td class="auto-style90">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
             
    </table>
</asp:View>

<asp:View ID="ViewTransferMenu" runat="server">
    <table style="border: medium solid #990033; width: 100%;">
        <tr>
            <td colspan="4"> <asp:Label ID="Label90" runat="server" Font-Bold="True" Font-Size="16" ForeColor="Maroon" Text="Transfer Module"></asp:Label>
       </td>            
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
              <td>&nbsp;</td>
        </tr>
         <tr>
            <td colspan="4"> <asp:Label ID="Label93" runat="server" Font-Bold="True" ForeColor="#993333" Text="Please click the links below for the action you wish to carry out"></asp:Label>
       </td>            
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
              <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:LinkButton ID="LinkBtnViewTransferHistory" runat="server" Font-Bold="true" Font-Size="14" ForeColor="Blue" OnClick="LinkBtnViewTransferHistory_Click">View Transfer History</asp:LinkButton>     
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkBtnTransferEmployee" runat="server" Font-Bold="true" Font-Size="14" ForeColor="Blue" OnClick="LinkBtnTransferEmployee_Click">Transfer Employee</asp:LinkButton>
          
            </td>
            <td>
                 </td>
            <td>&nbsp;</td>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
              <td>&nbsp;</td>
        </tr>
    </table>
   
</asp:View>
<asp:View ID="ViewTranHistory" runat="server">
    <table style="border: medium solid #990033; width: 100%;">
        <tr>
            <td colspan="4"> <asp:Label ID="Label94" runat="server" Font-Bold="True" Font-Size="16" ForeColor="Maroon" Text="Transfer History"></asp:Label>
       </td>            
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
              <td>&nbsp;</td>
        </tr>
         <tr>
            <td colspan="4"> <asp:Label ID="Label97" runat="server" Font-Bold="True" ForeColor="#993333" Text="Please select the employee you want to view his/her movement records"></asp:Label>
       </td>            
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
              <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>       <asp:Label ID="Label100" runat="server" Font-Bold="True" ForeColor="Maroon" Text="Department"></asp:Label>
                </td>
            <td> <asp:DropDownList ID="ddTranHistoryDept" AutoPostBack="true" Width="250px" runat="server" OnSelectedIndexChanged="ddTranHistoryDept_SelectedIndexChanged"></asp:DropDownList>
           
                 </td>
            <td>&nbsp;</td>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
              <td>&nbsp;</td>
        </tr>
           <tr>
            <td>&nbsp;</td>
              <td>       <asp:Label ID="LbTHEmp" runat="server" Font-Bold="True" ForeColor="Maroon" Text="Employee"></asp:Label>
                </td>
            <td> <asp:DropDownList ID="ddTranHistoryEmp" AutoPostBack="true" Width="250px" runat="server" OnSelectedIndexChanged="ddTranHistoryEmp_SelectedIndexChanged" Visible="False"></asp:DropDownList>
           
                 </td>
              <td>&nbsp;</td>
        </tr>
           <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
              <td>&nbsp;</td>
        </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="GViewTransHistory" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                            <asp:BoundField DataField="PreDept" HeaderText="PreDept" />
                            <asp:BoundField DataField="NewDeptName" HeaderText="NewDept" />
                            <asp:BoundField DataField="CurrentLocation" HeaderText="PreLocation" />
                            <asp:BoundField DataField="DesLocation" HeaderText="DesireLocation" />
                            <asp:BoundField DataField="ApprovedLocation" HeaderText="ApprovedLocation" />
                            <asp:BoundField DataField="TransferType" HeaderText="TransType" />
                            <asp:BoundField DataField="TransferReason" HeaderText="TransReason" />
                            <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" />
                            <asp:BoundField DataField="ApprovalStatus" HeaderText="ApprovalStatus" />
                            <asp:BoundField DataField="ApproveDate" HeaderText="ApproveDate" /> 
                            <asp:BoundField DataField="DisplayName" HeaderText="TransferedBy" />                               
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtTransferEmpID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_FK")%>' Visible="false"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtTranferedBy" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferedBy")%>' Visible="false"></asp:TextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                           <asp:TemplateField>
                                               <ItemTemplate><asp:TextBox ID="txtTranferID_FK" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferID_FK")%>'></asp:TextBox>

                                               </ItemTemplate></asp:TemplateField>
                         <asp:TemplateField>
                             <ItemTemplate><asp:TextBox ID="txtTranferLogID" Visible="false" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferLogID")%>'></asp:TextBox>

                             </ItemTemplate></asp:TemplateField>
                      
                                            
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />

                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
    </table>
   
</asp:View>
<asp:View ID="ViewConfirmationList" runat="server">
    <table style="border: medium solid #990033; width: 100%; font-size: medium;">
        <tr>
            <td>

                <asp:Panel ID="PanelConfirmedList" runat="server" Visible="False">
                    <table style="width:100%;">
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="Label159" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Maroon" Text="Confirmed Employee List"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:GridView ID="GViewConfirmedList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:TextBox ID="TextBox7" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.EmployeeID") %>' Visible="false"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="EmployeeNum" HeaderText="FileNum" />
                                        <asp:BoundField DataField="Email" HeaderText="UserName" />
                                        <asp:BoundField DataField="StartDate" HeaderText="StartDate" />
                                        <asp:BoundField DataField="ConfirmationDate" HeaderText="ConfirmationDate" />
                                        <asp:BoundField DataField="ConfirmedByName" HeaderText="ConfirmBy" />
                                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                        <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                                        <asp:BoundField DataField="DeptName" HeaderText="Dept" />
                                        <asp:BoundField DataField="PositionName" HeaderText="Position" />
                                        <asp:BoundField DataField="LevelName" HeaderText="Level" />
                                        <asp:BoundField DataField="LocationName" HeaderText="Branch" />
                                        <asp:BoundField DataField="LocationAddress" HeaderText="OfficeAddress" />
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                </asp:GridView>
                            </td>
                        </tr>
                         <tr>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnConfirmedFinish" runat="server" OnClick="btnConfirmedFinish_Click" Text="Finish" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="PanelUnConfirmedList" Visible="false" runat="server">
                    <table style="width:100%;">
                        <tr>
                            <td colspan="3"><asp:Label ID="Label87" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Maroon" Text="Unconfirmed Employee List"></asp:Label>
                           </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:GridView ID="GViewUnConfirmedList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:TextBox ID="TextBox8" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.EmployeeID") %>' Visible="false"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="EmployeeNum" HeaderText="FileNum" />
                                        <asp:BoundField DataField="Email" HeaderText="UserName" />
                                        <asp:BoundField DataField="StartDate" HeaderText="StartDate" />                                       
                                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                        <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                                        <asp:BoundField DataField="DeptName" HeaderText="Dept" />
                                        <asp:BoundField DataField="PositionName" HeaderText="Position" />
                                        <asp:BoundField DataField="LevelName" HeaderText="Level" />
                                        <asp:BoundField DataField="LocationName" HeaderText="Branch" />
                                        <asp:BoundField DataField="LocationAddress" HeaderText="OfficeAddress" />
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                </asp:GridView>
                            </td>
                        </tr>
                         <tr>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnUnConfirmedFinish" runat="server" OnClick="btnUnConfirmedFinish_Click" Text="Finish" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
      
    </table>
</asp:View>  

<asp:View ID="ViewPromoList" runat="server">
    <table style="border: medium solid #993333; width: 100%;">
        <tr>
            <td colspan="3">
                <asp:Panel ID="PanelPromotionList" runat="server" Visible="False">
                    <table style="width: 100%;">
                        <tr>
                            <td colspan="3"><asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Maroon" Text="Promoted Employee List"></asp:Label>
           </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:GridView ID="GViewPromoList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                       <asp:BoundField DataField="EmployeeNum" HeaderText="Employee" />
                       <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="EmpNewDept" HeaderText="PreDept" />
                       <asp:BoundField DataField="EmpNewDept" HeaderText="New Dept" />
                        <asp:BoundField DataField="EmpPrePosition" HeaderText="Pre Position" />
                       <asp:BoundField DataField="EmpNewPosition" HeaderText="New Position" />
                       <asp:BoundField DataField="EmpPreLevel" HeaderText="PreLevel" />
                       <asp:BoundField DataField="EmpNewLevel" HeaderText="NewLevel" />
                       <asp:BoundField DataField="ApprasialScore" HeaderText="Appraisal Score" />
                       <asp:BoundField DataField="PromoExamScore" HeaderText="Promo Exam" />
                       <asp:BoundField DataField="PromotedDate" HeaderText="Promo Date" />
                       <asp:BoundField DataField="DisplayName" HeaderText="PromotedBy" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtPromotionID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PromotionID") %>' Visible="false"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtEmployeeID_FK" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtApprasialID_FK" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ApprasialID_FK") %>' Visible="false"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                           
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnPromoListFinish" runat="server" OnClick="btnPromoListFinish_Click" Text="Finish" Visible="False" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                 <asp:Panel ID="PanelEmpPromoHistory" runat="server">
                    <table style="width: 100%;">
                        <tr>
                            <td colspan="4"><asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Maroon" Text="Employee Promotion History" Visible="False"></asp:Label>
           </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                             <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                             <td>&nbsp;</td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Font-Bold="true" Text="Department"></asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddPromoHistDept" AutoPostBack="true" Width="250px" runat="server" OnSelectedIndexChanged="ddPromoHistDept_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                             <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td> <asp:Label ID="Label17" runat="server" Font-Bold="true" Text="Employee"></asp:Label></td>
                            <td>&nbsp;<asp:DropDownList ID="ddPromoHistEmp" AutoPostBack="true" Width="250px" runat="server" OnSelectedIndexChanged="ddPromoHistEmp_SelectedIndexChanged"></asp:DropDownList>
                          </td>
                             <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                         <tr>
           <td colspan="3">
               <asp:GridView ID="GViewPromoHistory" Visible="false" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                   <AlternatingRowStyle BackColor="White" />
                   <Columns>
                       <asp:BoundField DataField="EmployeeNum" HeaderText="Employee" />
                       <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="EmpNewDept" HeaderText="PreDept" />
                       <asp:BoundField DataField="EmpNewDept" HeaderText="New Dept" />
                        <asp:BoundField DataField="EmpPrePosition" HeaderText="Pre Position" />
                       <asp:BoundField DataField="EmpNewPosition" HeaderText="New Position" />
                       <asp:BoundField DataField="EmpPreLevel" HeaderText="PreLevel" />
                       <asp:BoundField DataField="EmpNewLevel" HeaderText="NewLevel" />
                       <asp:BoundField DataField="ApprasialScore" HeaderText="Appraisal Score" />
                       <asp:BoundField DataField="PromoExamScore" HeaderText="Promo Exam" />
                       <asp:BoundField DataField="PromotedDate" HeaderText="Promo Date" />
                       <asp:BoundField DataField="DisplayName" HeaderText="PromotedBy" />
                       <asp:TemplateField>
                           <ItemTemplate>
                               <asp:TextBox ID="txtPromotionID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PromotionID") %>' Visible="false"></asp:TextBox>
                           </ItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField>
                           <ItemTemplate>
                               <asp:TextBox ID="txtEmployeeID_FK0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox>
                           </ItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField>
                           <ItemTemplate>
                               <asp:TextBox ID="txtApprasialID_FK0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ApprasialID_FK") %>' Visible="false"></asp:TextBox>
                           </ItemTemplate>
                       </asp:TemplateField>
                   </Columns>
                   <EditRowStyle BackColor="#2461BF" />
                   <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#EFF3FB" />
                   <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
               </asp:GridView>
                             </td>
        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnPromoHistFinish" runat="server" OnClick="btnPromoListFinish_Click" Text="Finish" Visible="False" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            
        </tr>
       
        <tr>
           <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View> 
<asp:View ID="ViewReport" runat="server">
    <table style="border: medium solid #993333; width: 100%;">
        <tr>
            <td colspan="4">
                <asp:Label ID="Label161" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Maroon" Text="Report" Visible="False"></asp:Label>
            </td>
        
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:LinkButton ID="LinkBtnEmpList" runat="server" OnClick="LinkBtnEmpList_Click" Font-Bold="True" Font-Size="13pt">Employee List</asp:LinkButton>
                &nbsp&nbsp&nbsp <asp:LinkButton ID="LinkBtnAppChart" runat="server" Font-Bold="True" Font-Size="13pt" OnClick="LinkBtnAppChart_Click">Pie Chart</asp:LinkButton>
               &nbsp&nbsp&nbsp;<asp:LinkButton ID="LinkBtnColumnChart" runat="server" Font-Bold="True" Font-Size="13pt" OnClick="LinkBtnColumnChart_Click">Column Chart</asp:LinkButton>
            </td>
          
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>   
<asp:View ID="ViewEmpList" runat="server">
    <table style="border: medium solid #993333; width: 100%;">
        <tr>
            <td colspan="4">
                <asp:Panel ID="PanelEmpList" Visible="false" runat="server">
                    <table style="width: 100%;">
                         <tr>
            <td colspan="4">
                 <asp:Label ID="Label38" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Maroon" Text="Employee List" Visible="False"></asp:Label>
            
                </td>
                             </tr>
                              <tr>
                                      <td ></td>
                                      <td ></td>
                                      <td ></td>
                                      <td ></td>
               
                             </tr>
                 
            <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>

            <td colspan="4">

                <asp:GridView ID="GViewReportEmpList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="True">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="DeptName" HeaderText="Designation" />
                        <asp:BoundField DataField="LocationName" HeaderText="Office" />
                        <asp:BoundField DataField="EmployeeNum" HeaderText="File No" />
                        <asp:BoundField DataField="EmpNames" HeaderText="Names" />
                        <asp:BoundField DataField="PositionName" HeaderText="Duty Post" />
                        <asp:BoundField DataField="StateName" HeaderText="State" />
                        <asp:BoundField DataField="LgaName" HeaderText="LGA" />
                        <asp:BoundField DataField="senName" HeaderText="Senetorial District" />
                        <asp:BoundField DataField="Gender" HeaderText="Sex" />
                        <asp:BoundField DataField="DateOfBirth" HeaderText="DOB" />
                        <asp:BoundField DataField="StartDate" HeaderText="Appointment Date" />
                        <asp:BoundField DataField="PromotionDate" HeaderText="Last Promo. Date" />
                        <asp:BoundField DataField="LevelName" HeaderText="G/L" />
                        <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
                               
                    </table>
                </asp:Panel>
            </td>
           
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnExportEmpList" runat="server" Text="Export" OnClick="btnExportEmpList_Click" /></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>     

<asp:View ID="ViewAppChart" runat="server" >
    <%--<form id="form1" runat="server">--%>
        <table style="width: 100%;">
            <tr>
                <td colspan="4">
                      <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Maroon" Text="Appraisal Chart" Visible="True"></asp:Label>
            
                </td>
               
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkBtnAppChartDisplay" runat="server" Font-Bold="True" Font-Size="13pt" OnClick="LinkBtnAppChartDisplay_Click">Draw</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">

          
         <div id="chartdiv" style="width: 600px; height: 350px;">   
             <script type="text/javascript" src="https://www.google.com/jsapi"></script>  
        <asp:GridView ID="GViewAppChart" runat="server" AutoGenerateColumns="False" EnableModelValidation="True"> 
             
            <Columns>
                <asp:BoundField DataField="AppraisalID" HeaderText="AppraisalID" />
                <asp:BoundField DataField="EmployeeNum" HeaderText="Emp" />
                <asp:BoundField DataField="AppraisalScore" HeaderText="AppraisalScore" />
                <asp:BoundField DataField="PromoExamScore" HeaderText="ExamScore" />
                <asp:BoundField DataField="TotalAppraisalScore" HeaderText="Total" />
            </Columns>
             
        </asp:GridView>  
        <br />  
        <br />  
        <asp:Literal ID="ltScripts" runat="server"></asp:Literal>  
        <div id="chart_div" style="width: 660px; height: 400px;">  
        </div>
        </div>
                    </td>
                  </tr>
                <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
        </table>
  <%--  </form>--%>
    
</asp:View>
</asp:MultiView>


         </td>
        
    </tr>
    
    <tr>
        <td valign="top">
            &nbsp;</td>
        <td valign="top">
          
            &nbsp;</td>
        
    </tr>
    <tr>
        <td></td>
        <td valign="center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                          <asp:LinkButton ID="hrHomeLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrHomeLinkBtn_Click">Home</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrEmploymentLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrEmploymentLinkBtn_Click">Employment</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="hrAcceptanceLinkButton" runat="server" Font-Bold="True" OnClick="hrAcceptanceLinkButton_Click">Acceptance</asp:LinkButton>
&nbsp;&nbsp;<asp:LinkButton ID="hrEmployeeLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrEmployeeLinkBtn_Click">Employee</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrConfirmationLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrConfirmationLinkBtn_Click">Confirmation</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrTrainingLinkBtn0" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrTrainingLinkBtn0_Click">Training</asp:LinkButton>
&nbsp;&nbsp;</td>
        
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:LinkButton ID="hrTransferLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrTransferLinkBtn_Click">Transfer</asp:LinkButton>
&nbsp;
                      <asp:LinkButton ID="hrLeaveLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrLeaveLinkBtn_Click">Leave</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrQueryLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrQueryLinkBtn_Click">Query</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrAppraisalLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrAppraisalLinkBtn_Click">Appraisal</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrPromotionLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrPromotionLinkBtn_Click">Promotion</asp:LinkButton>
&nbsp;<asp:LinkButton ID="hrRetirementLinkBtn" runat="server" Font-Bold="True" Font-Size="12pt" OnClick="hrRetirementLinkBtn_Click">Retirement</asp:LinkButton>
        </td>
        
    </tr>
</table>

