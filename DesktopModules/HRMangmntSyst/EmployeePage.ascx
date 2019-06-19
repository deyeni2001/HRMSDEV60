<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeePage.ascx.cs" Inherits="ola.HRMangmntSyst.EmployeePage" %>
<style type="text/css">
    .auto-style3 {
    }
    .auto-style11 {
    }
    .auto-style14 {
        width: 198px;
        height: 23px;
    }
    .auto-style15 {
        height: 23px;
    }
    .auto-style18 {
        width: 320px;
    }
    .auto-style19 {
        width: 135px;
    }
    .auto-style20 {
        width: 305px;
    }
    .auto-style21 {
        width: 243px;
    }
    .auto-style22 {
        width: 337px;
    }
    .auto-style23 {
        height: 26px;
    }
    .auto-style28 {
        height: 23px;
    }
    .auto-style29 {
    }
    .auto-style30 {
        height: 23px;
    }
    .auto-style31 {
    }
    .auto-style33 {
        width: 130px;
    }
    .auto-style35 {
        width: 303px;
    }
    .auto-style36 {
    }
    .auto-style37 {
        width: 244px;
    }
    .auto-style39 {
        width: 233px;
        height: 23px;
    }
    .auto-style40 {
        width: 177px;
        height: 23px;
    }
    .auto-style42 {
        height: 23px;
        width: 209px;
    }
    .auto-style43 {
    }
    .auto-style45 {
        width: 303px;
        height: 23px;
    }
    .auto-style46 {
    }
    .auto-style47 {
        width: 373px;
    }
    .auto-style50 {
    }
    .auto-style51 {
        width: 380px;
    }
    .auto-style53 {
        width: 148px;
    }
    #txtRefContAddr {
        width: 318px;
    }
    .auto-style54 {
    }
    .auto-style56 {
    }
    .auto-style57 {
        height: 23px;
    }
    #txtNxtOfKinContAdd {
        width: 301px;
    }
    #txtSpouseContAddrs {
        width: 311px;
    }
    #TxtContAdd {
        width: 321px;
    }
    .auto-style59 {
        width: 23px;
    }
    .auto-style60 {
        width: 594px;
    }
    .auto-style61 {
        width: 66px;
    }
    .auto-style62 {
    }
    .auto-style63 {
        width: 215px;
    }
    .auto-style64 {
        width: 510px;
    }
    .auto-style65 {
    }
    .auto-style66 {
    }
    .auto-style68 {
        width: 356px;
        height: 23px;
    }
    .auto-style70 {
        width: 375px;
    }
    .auto-style71 {
    }
    .auto-style72 {
        height: 22px;
    }
    .auto-style73 {
        width: 494px;
        height: 22px;
    }
    .auto-style74 {
        width: 66px;
        height: 22px;
    }
    .auto-style75 {
        width: 337px;
        height: 22px;
    }
    .auto-style81 {
        width: 200px;
    }
    .auto-style83 {
        width: 494px;
    }
    .auto-style84 {
        width: 594px;
        height: 23px;
    }
    .auto-style85 {
        width: 66px;
        height: 23px;
    }
    .auto-style86 {
        width: 337px;
        height: 23px;
    }
    .auto-style89 {
    }
    .auto-style90 {
    }
    .auto-style91 {
    }
    .auto-style92 {
        width: 108px;
    }
    .auto-style93 {
        width: 470px;
    }
    .auto-style94 {
        width: 470px;
        height: 23px;
    }
    .auto-style95 {
        width: 390px;
    }
    .auto-style96 {
    }
    #txtNxtYearGoalObjective {
        width: 256px;
        height: 82px;
    }
    #txtNxtYearGoalDesc {
        height: 53px;
        width: 253px;
    }
    .auto-style97 {
        width: 177px;
    }
    .auto-style98 {
        height: 23px;
    }
    .auto-style99 {
        width: 144px;
    }
    .auto-style101 {
        width: 136px;
    }
    .auto-style102 {
        width: 136px;
        height: 22px;
    }
    .auto-style105 {
        width: 312px;
    }
    .auto-style106 {
        width: 361px;
    }
    .auto-style107 {
        width: 288px;
    }
    .auto-style108 {
        width: 65px;
    }
    .auto-style109 {
        width: 383px;
    }
    </style>
<table style="width: 100%;">
    
    <tr>  
        <td valign="top" class="auto-style59">

            <table style="width: 100%;">
                 <tr>
                    <td>

                     <asp:Button ID="homeBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="homeBtn_Click" Text="Home" Width="150px" Height="45px" />
                     </td>
                    
                </tr>

                <tr>
                    <td>

                     <asp:Button ID="EmpInfoBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="welEmplomentBtn_Click" Text="View Profile" Width="150px" Height="45px" />
                     </td>
                    
                </tr>
                <tr>
                    <td>
                     <asp:Button ID="updateMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" Width="150px" OnClick="updateMenuBtn_Click" Text="Update Details" />
                     </td>
                   
                </tr>
                <tr>
                    <td>
                     <asp:Button ID="empQualifBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" Width="150px" OnClick="empQualifBtn_Click" Text="Qualifications" />
                     </td>
                   
                </tr>
                <tr>
                    <td>
                     <asp:Button ID="empCertBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="empCertBtn_Click" Text="Certifications" Width="150px" />
                     
                    </td>
                   
                </tr>
                <tr>
                    <td>
                     
            <asp:Button ID="docBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Height="45px" OnClick="docBtn_Click" Text="Document" Width="150px" />

                    </td>

         
                <tr>
                    <td>

                <asp:Button ID="refreeBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Refree" Width="150px" Height="45px" OnClick="refreeBtn_Click" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="queryBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="respondBtn_Click" Text="Query" Width="150px" Height="45px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="leaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="leaveBtn_Click" Text="Leave" Width="150px" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                <asp:Button ID="selfAppraisalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="selfAppraisalBtn_Click" Text="Appraisal" Width="150px" Height="45px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="tranferMenuBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="tranferMenuBtn_Click" Text="Transfer" Width="150px" Height="41px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>&nbsp;</td>
                   
                </tr>
                <tr>
                    <td>&nbsp;</td>
                   
                </tr>
            </table>

                    </td>
                    <td valign="top">
<asp:MultiView ID="MViewEmployee" runat="server">
    <asp:View ID="View1" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;" valign="top">
        <tr>
            <td class="auto-style50">
                &nbsp;</td>
            <td class="auto-style51">
                <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text=" Welcome! Please Select Module you want to use"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style51">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
             <tr>
                 <td class="auto-style50">&nbsp;</td>
                 <td class="auto-style51">
                     &nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style51">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style51">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style51">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style51">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style51">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </asp:View>
    <asp:View ID="ViewEmployeeBiodata" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="6">
                    <asp:Label ID="LbEmpDetail" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Personal Information"></asp:Label>
                </td>
            </tr>
             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style60">&nbsp;</td>
                 <td class="auto-style61">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Panel ID="PanelEmployeeProfile" runat="server">
                        <table style="width:100%;">
                            
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Image ID="EmpProfilePassport" runat="server" Height="170px" ImageAlign="Left" Width="170px" BorderColor="#CC0066" BorderStyle="Solid" BorderWidth="2px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LBTitle" runat="server" Font-Bold="True" Text="Title" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbempTitle" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LBMidName1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style19">
                    <asp:Label ID="LbempPosition" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label"></asp:Label>
                </td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LBfName" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbempFName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LBMidName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Middle Name"></asp:Label>
                 </td>
                <td>
                    <asp:Label ID="LbempMName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                <td>&nbsp;</td>
            </tr>
    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style83">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LBlName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Last Name"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbempLName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbempMaritalStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style83">
            <asp:Label ID="LbEmail0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Email"></asp:Label>
         </td>
        <td class="auto-style61">
            <asp:Label ID="LbempEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="LBPhnNo0" runat="server" Font-Bold="True" Font-Size="14pt" Text="PhoneNum"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbempPhnNo" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>

     <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style83">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbGender1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Gender"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbempGender" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbContAddr0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Contact Address"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbempContAddres" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style83">
            <asp:Label ID="LbNationality0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Nationality"></asp:Label>
         </td>
        <td class="auto-style61">
            <asp:Label ID="LbempCountry" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td class="auto-style22">
            <asp:Label ID="LbStateOfOri" runat="server" Font-Bold="True" Font-Size="14pt" Text="State of Origin"></asp:Label>
         </td>
        <td>
            <asp:Label ID="LbempState" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
         </td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style83">
            <asp:Label ID="LbLGA" runat="server" Font-Bold="True" Font-Size="14pt" Text="LGA"></asp:Label>
        </td>
        <td class="auto-style61">
            <asp:Label ID="LbempLga" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
        </td>
        <td class="auto-style22">
            <asp:Label ID="LbHome0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Home Town"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LbempHomeTown" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style83">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style83">
                     <asp:Label ID="LbLGA0" runat="server" Font-Bold="True" Text="DOB" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style61">
                     <asp:Label ID="LbempDOB" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                 <td class="auto-style22">
                     <asp:Label ID="LbAge0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Age"></asp:Label>
                 </td>
                 <td>
                     <asp:Label ID="LbempAge" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                 </td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbStartDate" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbempStartDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbWokLoc0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Work Location"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbempWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
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
                <td class="auto-style83">
                    <asp:Label ID="LbDept0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbempDepts" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbPosition0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Religion"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbempReligion" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbLevel" runat="server" Font-Bold="True" Font-Size="14pt" Text="Level"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbempLevel" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Text="Label" Visible="True"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
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
                                  <td class="auto-style83">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style83">
                                      <asp:Label ID="LbEmpStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Employee Status"></asp:Label>
                                  </td>
                                  <td class="auto-style61">
                                      <asp:Label ID="LbEmployeeStatus" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style22">
                                      <asp:Label ID="LbCnfrmDate0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Confirmation Date"></asp:Label>
                                  </td>
                                  <td>
                                      <asp:Label ID="LbEmpConfimedDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style83">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbConfirmBy0" runat="server" Font-Bold="True" Font-Size="14pt" Text="ConfirmedBy"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbEmpConfimedBy" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style83">
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
                                  <td class="auto-style83">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbspouseFNam0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbSpouseNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Phone No"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSpousePhoNo" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbspouseFNam2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Address"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbSpouseAddress" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSpouseEmailAddr" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbspouseFNam4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Occupation"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbSpouseOccupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbspouseFNam5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Spouse Employer"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbSpouseEmployer" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
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
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbnxtOfKinFName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="NOK Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbNextOfKinNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Relationship"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbNextOfKinRelationship" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbnxtOfKinFName2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Phone Num"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbNextOfKinPhnNo" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbNextOfKinEmail" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbnxtOfKinFName4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Address"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbNextOfKinAddress" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbnxtOfKinFName5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Occupation"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbNextOfKinOccupation" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
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
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbBank" runat="server" Font-Bold="True" Font-Size="14pt" Text="Bank Name"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbEmpBankNames" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbAccountName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbAcctNames0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Number"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbAcctNumber" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Guarrantor's Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbGuarrantorName" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Refree Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbAcctNames2" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Names"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbRefNames1" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames3" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Names"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbRefNames2" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbAcctNames4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Phone No"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbRefPhoNo1" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Phone No"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbRefPhoNo2" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbAcctNames6" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Email"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbRefEmailAddr1" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames7" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbRefEmailAddr2" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    <asp:Label ID="LbAcctNames8" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Occupation"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:Label ID="LbRefOccuptn1" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Label ID="LbAcctNames9" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Occupation"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LbRefOccuptn2" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style83">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style72"></td>
                                  <td class="auto-style73">
                                      <asp:Label ID="LbAcctNames10" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Address"></asp:Label>
                                  </td>
                                  <td class="auto-style74">
                                      <asp:Label ID="LbRefContAddrss1" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style75">
                                      <asp:Label ID="LbAcctNames11" runat="server" Font-Bold="True" Font-Size="14pt" Text="Refree Address"></asp:Label>
                                  </td>
                                  <td class="auto-style72">
                                      <asp:Label ID="LbRefContAddrss2" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066">Label</asp:Label>
                                  </td>
                                  <td class="auto-style72"></td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
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
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                <tr>
                    <td class="auto-style56">&nbsp;</td>
                    <td class="auto-style83">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewEmpProfileQualification" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifAppID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifEmpID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
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
                <td class="auto-style83">&nbsp;</td>
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
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                <tr>
                    <td class="auto-style56">&nbsp;</td>
                    <td class="auto-style83">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewEmpProfileCert" runat="server" AutoGenerateColumns="False"  EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                            <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                            <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                            <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifAppID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifEmpID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
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
                <td class="auto-style83">&nbsp;</td>
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
                <td class="auto-style83">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                <tr>
                    <td class="auto-style56">&nbsp;</td>
                    <td class="auto-style83">
                        &nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style56">&nbsp;</td>
                    <td class="auto-style83">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            <tr>
                <td class="auto-style56" colspan="6">
                    <asp:GridView ID="GViewEmpProfileDoc" runat="server" AutoGenerateColumns="False"  EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                            <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQDocAppID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtSDocEmpID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_Fk") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
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
                <td class="auto-style83">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style83">&nbsp;</td>
                <td class="auto-style61">
                    <asp:Button ID="employeeSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Finish" />
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style83">&nbsp;</td>
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
                                  <td class="auto-style56">&nbsp;</td>
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

        <asp:View ID="ViewSpouseInfo" runat="server">
            <table style="border: medium solid #CC0066; width: 100%;">

             <tr>
                 <td class="auto-style56" colspan="4">
                     <asp:LinkButton ID="spouceLinkBtn4" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                     &nbsp;
                     <asp:LinkButton ID="NextofKinLinkBtn4" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                     &nbsp;
                     <asp:LinkButton ID="BankLinkBtn4" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                     &nbsp;
                     <asp:LinkButton ID="guarrantorLinkBtn4" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
                     &nbsp;</td>
            </tr>
                <tr>
                    <td class="auto-style56" colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style56" colspan="4">
                        <asp:Label ID="LbSpouseInfo" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Spouse Infomation (If Married)"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style107">&nbsp;</td>
                    <td class="auto-style64">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style54" colspan="4"> <asp:Label ID="lbEmpSpouseAdded1" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                   </td>
                </tr>
                <tr>
                    <td class="auto-style107">&nbsp;</td>
                    <td class="auto-style64">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                 
                <tr>
                    <td class="auto-style107">&nbsp;</td>
                    <td class="auto-style64">
                        <asp:Button ID="btnSpouseFinish" runat="server" Font-Bold="True" ForeColor="#33CC33" OnClick="btnSpouseFinish_Click" Text="Finish" />
                        <asp:Button ID="btnSpouseTryAgain" runat="server" Font-Bold="True" ForeColor="#33CC33" OnClick="btnSpouseTryAgain_Click" Text="TryAgain" Visible="False" />
                    </td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style107">&nbsp;</td>
                    <td class="auto-style64">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                 
                <tr>
                    <td class="auto-style54" colspan="4">
                        <asp:Panel ID="PanelEmpSpouse" Visible="false" runat="server">
                            <table style="width: 100%;">
                                
            <tr>
                <td class="auto-style54"></td>
                <td class="auto-style64">
                    <asp:Label ID="LbspouseFNam" runat="server" Font-Bold="True" Text="Spouse First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtSpouseFN" runat="server" Width="300px" style="margin-bottom: 0px"></asp:TextBox>
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
        <td class="auto-style54">
            &nbsp;</td>
                 <td class="auto-style64">
                     <asp:Label ID="LbSpouseMN" runat="server" Font-Bold="True" Text="Spouse Middle Name" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style61">
                     <asp:TextBox ID="txtSpouseMN0" runat="server" Width="300px"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
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
            <asp:Label ID="LbSpousLN0" runat="server" Font-Bold="True" Text="Spouse Last Name" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style61">
            <asp:TextBox ID="txtSpouceLN" runat="server" Width="300px"></asp:TextBox>
                 </td>
        <td class="auto-style22">&nbsp;</td>
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
                    <td class="auto-style54">&nbsp;</td>
                    <td class="auto-style64">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style54">&nbsp;</td>
                    <td class="auto-style64">&nbsp;</td>
                    <td class="auto-style61">
                        <asp:Label ID="lbEmpSpouseAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style54">&nbsp;</td>
                    <td class="auto-style64">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
            
              </table>
                        </asp:Panel>
                    </td>
                </tr>
                
            </table>
        </asp:View>

<asp:View ID="ViewNOK" runat="server">

    <table style="border: medium solid #CC0066; width: 100%;">
            <tr>
                <td class="auto-style56" colspan="4">
                    <asp:LinkButton ID="spouceLinkBtn5" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="NextofKinLinkBtn5" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="BankLinkBtn5" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="guarrantorLinkBtn7" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style56" colspan="4">
                <asp:Label ID="LbNxtOfKinInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Next of Kin Information"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style70">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style66" colspan="4">
                     <asp:Label ID="lbEmpNxtOfKinAdded1" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
           
                </td>
            </tr>
            <tr>
                <td class="auto-style108">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style108">&nbsp;</td>
                <td class="auto-style70">
                    <asp:Button ID="btnNOKFinish" runat="server" Font-Bold="True" ForeColor="#33CC33" OnClick="btnSpouseFinish_Click" Text="Finish" />
                    <asp:Button ID="btnNOKTryAgain" runat="server" Font-Bold="True" ForeColor="#33CC33" Text="TryAgain" OnClick="btnNOKTryAgain_Click" />
                </td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style108">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style66" colspan="4">
                    <asp:Panel ID="PanelNOK" Visible="false" runat="server">
                        <table style="width: 100%;">
                        
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">
                    <asp:Label ID="LbnxtOfKinFName" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinfName" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">
                    <asp:Label ID="LbnxtOfKinMidName" runat="server" Font-Bold="True" Text="Middle Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinMidName" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">
                    <asp:Label ID="nxtOfKinLNameLabel" runat="server" Font-Bold="True" Text="Last Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinLName" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">
                    <asp:Label ID="LbNxtOfKinrelationship" runat="server" Font-Bold="True" Text="Relationship" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinRelationship" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">
                    <asp:Label ID="nxtOfKinphNoLabel" runat="server" Font-Bold="True" Text="Phone No" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:TextBox ID="txtNxtOfKinPhNo" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                
            </tr>
             <tr>
                 <td class="auto-style68">&nbsp;</td>
                 <td class="auto-style70">
                     <asp:Label ID="LbnxtOfKinEmail" runat="server" Font-Bold="True" Text="Email" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style61">
                     <asp:TextBox ID="txtNxtOfKinEmail" runat="server" Width="300px"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
             <tr>
        <td class="auto-style68">&nbsp;</td>
        <td class="auto-style70">
            <asp:Label ID="Lboccupation" runat="server" Font-Bold="True" Text="Occupation" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style61">
            <asp:TextBox ID="txtNxtOfKinOccupation" runat="server" Width="300px"></asp:TextBox>
                 </td>
        <td class="auto-style22">
            &nbsp;</td>
               
    </tr>
             <tr>
        <td class="auto-style68">&nbsp;</td>
        <td class="auto-style70">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
              
    </tr>
             <tr>
                 <td class="auto-style68">&nbsp;</td>
                 <td class="auto-style70">
                     <asp:Label ID="LbnxtOfKinContAddr" runat="server" Font-Bold="True" Text="Contact Address" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style61">
                     <textarea id="txtNxtOfKinContAdd" runat="server" name="S10" rows="2"></textarea></td>
                 <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            
                
                <tr>
                    <td class="auto-style68">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                    <td class="auto-style61">
                        <asp:Button ID="nextOfKinSaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Save" OnClick="nextOfKinSaveBtn_Click" />
                    </td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style68">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">
                    <asp:Label ID="lbEmpNxtOfKinAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style70">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
                                
                        </table>
                    </asp:Panel>
                </td>
            </tr>
    </table>
</asp:View>
<asp:View ID="View3" runat="server">
    <table style="border: medium solid #CC0066; width: 100%;">
        <tr>
                <td class="auto-style57" colspan="4">
                    <asp:LinkButton ID="spouceLinkBtn6" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="NextofKinLinkBtn6" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="BankLinkBtn6" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="guarrantorLinkBtn6" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
                    &nbsp;</td>
            </tr>
             <tr>
                 <td class="auto-style57" colspan="4">&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style57" colspan="4">
                <asp:Label ID="LbBankInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Bank Information"></asp:Label>
            </td>
             </tr>

        <tr>
        <td class="auto-style65">&nbsp;</td>
        <td class="auto-style60">&nbsp;</td>
        <td class="auto-style61">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
            </tr>
                  <tr>
                      <td class="auto-style65" colspan="4">
                           <asp:Label ID="lbEmpBankInfoAdded1" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                         
                      </td>
                      
                      </tr>
                      <tr>
                          <td class="auto-style65">&nbsp;</td>
                          <td class="auto-style60">&nbsp;</td>
                          <td class="auto-style61">&nbsp;</td>
                          <td class="auto-style22">&nbsp;</td>
                          </tr>
                          <tr>
                              <td class="auto-style65" colspan="4">
                                  <asp:Button ID="btnBankFinish" runat="server" Font-Bold="True" ForeColor="#33CC33" OnClick="btnSpouseFinish_Click" Text="Finish" />
                                  <asp:Button ID="btnBankTryAgain" runat="server" Font-Bold="True" ForeColor="#33CC33" Text="TryAgain" OnClick="btnBankTryAgain_Click" />
                              </td>
                             </tr>
                              <tr>
                                  <td class="auto-style65" colspan="4">&nbsp;</td>
        </tr>
                              <tr>
                                  <td class="auto-style65" colspan="4">
                                      <asp:Panel ID="PanelEmpBank" Visible="false" runat="server">
                                          <table style="width: 100%;">
                                           
                                  <tr>
                                      <td class="auto-style109">&nbsp;</td>
                                      <td class="auto-style60">
                                          <asp:Label ID="LbBankName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Bank Name"></asp:Label>
                                      </td>
                                      <td class="auto-style61">
                                          <asp:TextBox ID="txtBnkName" runat="server" Width="300px"></asp:TextBox>
                                      </td>
                                      <td class="auto-style22">&nbsp;</td>
                                  </tr>
                                  <tr>
                                      <td class="auto-style109">&nbsp;</td>
                                      <td class="auto-style60">&nbsp;</td>
                                      <td class="auto-style61">&nbsp;</td>
                                      <td class="auto-style22">&nbsp;</td>
                                      <tr>
                                          <td class="auto-style109">&nbsp;</td>
                                          <td class="auto-style60">
                                              <asp:Label ID="LbAcctName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Name"></asp:Label>
                                          </td>
                                          <td class="auto-style61">
                                              <asp:TextBox ID="txtAcctName" runat="server" Width="300px"></asp:TextBox>
                                          </td>
                                          <td class="auto-style22">&nbsp;</td>
                                      </tr>
                                      <tr>
                                          <td class="auto-style109">&nbsp;</td>
                                          <td class="auto-style60">&nbsp;</td>
                                          <td class="auto-style61">&nbsp;</td>
                                          <td class="auto-style22">&nbsp;</td>
                                          <tr>
                                              <td class="auto-style109">&nbsp;</td>
                                              <td class="auto-style60">
                                                  <asp:Label ID="LbAcctNum" runat="server" Font-Bold="True" Font-Size="14pt" Text="Account Number"></asp:Label>
                                              </td>
                                              <td class="auto-style61">
                                                  <asp:TextBox ID="txtAcctNum" runat="server" Width="300px"></asp:TextBox>
                                              </td>
                                              <td class="auto-style22">&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style109">&nbsp;</td>
                                              <td class="auto-style60">&nbsp;</td>
                                              <td class="auto-style61">&nbsp;</td>
                                              <td class="auto-style22">&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style109">&nbsp;</td>
                                              <td class="auto-style60">&nbsp;</td>
                                              <td class="auto-style61">
                                                  <asp:Button ID="bankSaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="bankSaveBtn_Click" Text="Save" />
                                              </td>
                                              <td class="auto-style22">&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style109">&nbsp;</td>
                                              <td class="auto-style60">&nbsp;</td>
                                              <td class="auto-style61">&nbsp;</td>
                                              <td class="auto-style22">&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style109">&nbsp;</td>
                                              <td class="auto-style60">&nbsp;</td>
                                              <td class="auto-style61">
                                                  <asp:Label ID="lbEmpBankInfoAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                              </td>
                                              <td class="auto-style22">&nbsp;</td>
                                          </tr>
                                          <tr>
                                              <td class="auto-style109">&nbsp;</td>
                                              <td class="auto-style60">&nbsp;</td>
                                              <td class="auto-style61">&nbsp;</td>
                                              <td class="auto-style22">&nbsp;</td>
                                          </tr>
                                      
                                          </table>
                                      </asp:Panel>
                                  </td>
                                  </tr>
                      </tr>
    </table>
</asp:View>

<asp:View ID="ViewRefree" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
         <tr>
                <td colspan="6">
                    <asp:LinkButton ID="spouceLinkBtn3" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="NextofKinLinkBtn3" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="BankLinkBtn3" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="guarrantorLinkBtn9" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
                    &nbsp;</td>
            </tr>
             <tr>
                 <td colspan="6">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="6">
                     <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Refree Information"></asp:Label>
                 </td>
             </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style47">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                 <td colspan="6">
                      <asp:Label ID="lbEmpRefereeAdded1" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                 </td>
           
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style47">&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">
                     <asp:Button ID="btnRefreeFinish" runat="server" Font-Bold="True" ForeColor="#33CC33" OnClick="btnSpouseFinish_Click" Text="Finish" />
                     <asp:Button ID="btnRefreeTryAgain" runat="server" Font-Bold="True" ForeColor="#33CC33" OnClick="btnRefreeTryAgain_Click" Text="TryAgain" />
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style47">&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style47">&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="6">
                     <asp:Panel ID="PanelRefree" Visible="false" runat="server">
                         <table style="width: 100%;">
                             
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">
                     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Refree I"></asp:Label>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style47">&nbsp;</td>
                 <td>
                     <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Refree II"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style47">&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style21">
                    <asp:Label ID="LbRefFN1" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtRefFName1" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style48">
                    <asp:Label ID="LbRefFN2" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style33">
                    <asp:TextBox ID="txtRefFName2" runat="server" Width="199px"></asp:TextBox>
                </td>
                <td class="auto-style28">&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style48">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
               
            </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">
                     <asp:Label ID="LbRefMN1" runat="server" Font-Bold="True" Text="Middle Name" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:TextBox ID="txtRefMidName1" runat="server" Width="196px"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">
                     <asp:Label ID="LbRefMN2" runat="server" Font-Bold="True" Text="Middle Name" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style33">
                     <asp:TextBox ID="txtRefMidName2" runat="server" Width="189px"></asp:TextBox>
                 </td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style49">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style21">
                    <asp:Label ID="LBRefLN1" runat="server" Font-Bold="True" Text="Last Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtRefLName1" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style48">
                    <asp:Label ID="LBRefLN2" runat="server" Font-Bold="True" Text="Last Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style33">
                    <asp:TextBox ID="txtRefLName2" runat="server" Width="196px"></asp:TextBox>
                </td>
               <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style49">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
               
            </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">
                     <asp:Label ID="LBRefLN6" runat="server" Font-Bold="True" Font-Size="14pt" Text="Occupation"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:TextBox ID="txtRefOccupation1" runat="server" Width="196px" Height="16px"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">
                     <asp:Label ID="LBRefLN3" runat="server" Font-Bold="True" Text="Occupation" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style33">
                     <asp:TextBox ID="txtRefOccupation2" runat="server" Height="16px" Width="196px"></asp:TextBox>
                 </td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style21">
                    <asp:Label ID="LBRefLN5" runat="server" Font-Bold="True" Font-Size="14pt" Text="Phone No"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtRefPhnNo1" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style48">
                    <asp:Label ID="LBRefLN4" runat="server" Font-Bold="True" Font-Size="14pt" Text="Phone No"></asp:Label>
                </td>
                <td class="auto-style33">
                    <asp:TextBox ID="txtRefPhnNo2" runat="server" Width="196px"></asp:TextBox>
                </td>
               <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style48">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                
            </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">
                     <asp:Label ID="LBRefEmail1" runat="server" Font-Bold="True" Text="Email" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:TextBox ID="txtRefEmail1" runat="server" Width="196px"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">
                     <asp:Label ID="LBRefEmail2" runat="server" Font-Bold="True" Text="Email" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style33">
                     <asp:TextBox ID="txtRefEmail2" runat="server" Width="196px"></asp:TextBox>
                 </td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
             <tr>
        <td class="auto-style28">&nbsp;</td>
        <td class="auto-style21">
            <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Contact Address" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style20">
            <textarea id="txtRefContAddr1" runat="server" name="S4" rows="2"></textarea></td>
        <td class="auto-style22">
            &nbsp;</td>
        <td class="auto-style48">
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Contact Address" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style33">
            <textarea id="txtRefContAddr2" runat="server" cols="20" name="S11" rows="2"></textarea></td>
                 <td class="auto-style33">&nbsp;</td>
               
    </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">
                     &nbsp;</td>
                 <td class="auto-style20">
                     &nbsp;</td>
                 <td class="auto-style22">
                     &nbsp;
                     <asp:Button ID="refSaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Save" OnClick="refSaveBtn_Click" />
                     </td>
                 <td class="auto-style48">&nbsp;</td>
                 <td class="auto-style33">
                     &nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">
                     <asp:Label ID="lbEmpRefereeAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style28">&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style48">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
             </tr>
                              </table>
                     </asp:Panel>
                 </td>
             </tr>
    </table>
    </asp:View>

<asp:View ID="ViewGuarrator" runat="server">
    <table style="border: medium solid #CC0066; width: 100%;">
    <tr>
                                  <td class="auto-style71" colspan="4">
                                      <asp:LinkButton ID="spouceLinkBtn2" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                                      &nbsp;
                                      <asp:LinkButton ID="NextofKinLinkBtn2" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                                      &nbsp;
                                      <asp:LinkButton ID="BankLinkBtn2" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                                      &nbsp;
                                      <asp:LinkButton ID="guarrantorLinkBtn10" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style71">&nbsp;</td>
                                  <td class="auto-style60">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style71">&nbsp;</td>
            <td class="auto-style60">
                <asp:Label ID="LbSpouseInfo0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Guarrantor Infomation"></asp:Label>
            </td>
            <td class="auto-style61">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
                               <tr>
                <td class="auto-style71">&nbsp;</td>
                <td class="auto-style60">
                    &nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
                <td class="auto-style22">
                    &nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style71" colspan="4">
                                       <asp:Label ID="lbEmpGuarrantorAdded1" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
          
                                  </td>
        </tr>
        <tr>
            <td class="auto-style71">&nbsp;</td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style71">&nbsp;</td>
            <td class="auto-style60">
                <asp:Button ID="btnGuarrantorTFinish" runat="server" Font-Bold="True" ForeColor="#33CC33" OnClick="btnSpouseFinish_Click" Text="Finish" />
                <asp:Button ID="btnGuarrantorTryAgain" runat="server" Font-Bold="True" ForeColor="#33CC33" Text="TryAgain" OnClick="btnGuarrantorTryAgain_Click" />
            </td>
            <td class="auto-style61">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style71">&nbsp;</td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style71" colspan="4">
                <asp:Panel ID="PanelGuarrantor" Visible="false" runat="server">
                    <table style="width: 100%;">
                     
                              <tr>
                                  <td class="auto-style71">&nbsp;</td>
                                  <td class="auto-style60">
                                      <asp:Label ID="LbGuarName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Guarrantor's Name"></asp:Label>
                                  </td>
                                  <td class="auto-style61">
                                      <asp:TextBox ID="txtGuarName" runat="server" Width="300px"></asp:TextBox>
                                  </td>
                                  <td class="auto-style22">&nbsp;</td>
                              </tr>
            <tr>
                <td class="auto-style71">&nbsp;</td>
                <td class="auto-style60">
                    &nbsp;</td>
                <td class="auto-style61">
                    &nbsp;</td>
                <td class="auto-style22">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style71">&nbsp;</td>
                <td class="auto-style60">
                    <asp:Label ID="LbGuarName0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Guarrantor Form"></asp:Label>
                </td>
                <td class="auto-style61">
                    <asp:FileUpload ID="GuarrantorFileUpload" runat="server" Width="300px" />
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style71">&nbsp;</td>
                 <td class="auto-style60">
                     &nbsp;</td>
                 <td class="auto-style61">
                     &nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style71">&nbsp;</td>
                                  <td class="auto-style60">&nbsp;</td>
                                  <td class="auto-style61">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style71">&nbsp;</td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style61">
                <asp:Button ID="guarantorSaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Save" OnClick="guarantorSaveBtn_Click" />
            </td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style84"></td>
            <td class="auto-style85"></td>
            <td class="auto-style86"></td>
        </tr>
                  
        <tr>
            <td class="auto-style71">&nbsp;</td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style61">
                <asp:Label ID="lbEmpGuarrantorAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
            </td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style71">&nbsp;</td>
            <td class="auto-style60">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
                    
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:View>

    <%--<asp:View ID="ViewEmployeeBiodata" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="6">
                    <asp:Label ID="LbEmpDetail" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Employee Personal Information"></asp:Label>
                </td>
            </tr>
             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style19">&nbsp;</td>
                 <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LBTitle" runat="server" Font-Bold="True" Text="Title" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:DropDownList ID="titleList" runat="server" Height="16px" Width="268px" Enabled="False">
                        <asp:ListItem>Please select</asp:ListItem>
                        <asp:ListItem>MR.</asp:ListItem>
                        <asp:ListItem>MRS.</asp:ListItem>
                        <asp:ListItem>MISS</asp:ListItem>
                        <asp:ListItem>DR.</asp:ListItem>
                        <asp:ListItem>PROF.</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LBfName" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpFName" runat="server" Width="264px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LBMidName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Middle Name"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpMName" runat="server" Width="298px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style58">
            &nbsp;<asp:Label ID="LBlName" runat="server" Font-Bold="True" Text="Last Name" Font-Size="14pt"></asp:Label>
         </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtEmpLName" runat="server" Width="310px" Enabled="False"></asp:TextBox>
         </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

     <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbStatus" runat="server" Font-Bold="True" Text="Status" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpMaritalStatus" runat="server" Width="310px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style58">
            &nbsp;<asp:Label ID="LbEmail" runat="server" Font-Bold="True" Text="Email" Font-Size="14pt"></asp:Label>
         </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtEmail0" runat="server" Width="295px" Enabled="False" EnableViewState="False"></asp:TextBox>
         </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

     <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LBPhnNo" runat="server" Font-Bold="True" Text="PhoneNum" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtPhnNum" runat="server" Width="273px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

     <tr>
        <td class="auto-style56">
            &nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="LbGender0" runat="server" Font-Bold="True" Text="Gender" Font-Size="14pt"></asp:Label>
         </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtEmpGender" runat="server" Width="310px" Enabled="False"></asp:TextBox>
         </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbContAddr" runat="server" Font-Bold="True" Text="Contact Address" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <textarea id="TxtContAdd" name="S1" rows="2"></textarea></td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="LbNationality" runat="server" Font-Bold="True" Text="Nationality" Font-Size="14pt"></asp:Label>
        </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtEmpNationality" runat="server" Width="310px" Enabled="False"></asp:TextBox>
        </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbStateOfOri" runat="server" Font-Bold="True" Text="State of Origin" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:TextBox ID="txtEmpState" runat="server" Enabled="False" Width="310px"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="LbLGA" runat="server" Font-Bold="True" Text="LGA" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtEmpLga" runat="server" Width="310px" Enabled="False"></asp:TextBox>
                 </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbHome" runat="server" Font-Bold="True" Text="Home Town" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:TextBox ID="txtEmpHometown" runat="server" Width="271px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbDOB" runat="server" Font-Bold="True" Text="DOB"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpDOB" runat="server" Width="277px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">
                     &nbsp;</td>
                 <td class="auto-style20">
                     &nbsp;</td>
                 <td class="auto-style22">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbAge" runat="server" Font-Bold="True" Font-Size="14pt" Text="Age"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtAge0" runat="server" Height="16px" Width="267px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    &nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbStartDate" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpStartDate" runat="server" Width="254px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbWokLoc" runat="server" Font-Bold="True" Text="Work Location" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpWorkLocation" runat="server" Width="254px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbDept" runat="server" Font-Bold="True" Text="Department" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpDept" runat="server" Width="254px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbPosition" runat="server" Font-Bold="True" Text="Position" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpPosition" runat="server" Width="254px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbLevel" runat="server" Font-Bold="True" Text="Level" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtEmpLevel" runat="server" Width="254px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbEmpStatus" runat="server" Font-Bold="True" Text="Employee Status" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:Label ID="LbEmployeeStatus" runat="server" Font-Bold="True" ForeColor="#FF3300" Enabled="False"></asp:Label>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbCnfrmDate" runat="server" Font-Bold="True" Text="Confirmation Date" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:Label ID="LbConfimedDate" runat="server" Font-Bold="True" ForeColor="#FF3300" Enabled="False"></asp:Label>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbConfirmBy" runat="server" Font-Bold="True" Text="ConfirmedBy" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:Label ID="LbConfimedBy" runat="server" Font-Bold="True" ForeColor="#FF3300" Enabled="False"></asp:Label>
                 </td>
                 <td class="auto-style22">
                     &nbsp;</td>
                 <td>
                     &nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    &nbsp;</td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Label ID="LbSpouseInfo" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Spouse Infomation (If Married)"></asp:Label>
                </td>
            </tr>

             <tr>
                 <td class="auto-style56">&nbsp;</td>
                 <td class="auto-style58">
                     &nbsp;</td>
                 <td class="auto-style20">
                     &nbsp;</td>
                 <td class="auto-style22">
                     &nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56"></td>
                <td class="auto-style58">
                    <asp:Label ID="LbspouseFNam" runat="server" Font-Bold="True" Text="Spouse First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtSpouseFN0" runat="server" Width="325px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
        <td class="auto-style56">
            &nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbSpouseMN" runat="server" Font-Bold="True" Text="Spouse Middle Name" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:TextBox ID="txtSpouseMN0" runat="server" Width="328px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
    </tr>

             <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            &nbsp;</td>
        <td class="auto-style20">
            &nbsp;</td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="LbSpousLN0" runat="server" Font-Bold="True" Text="Spouse Last Name" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtSpouceLN" runat="server" Width="318px" Enabled="False"></asp:TextBox>
                 </td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            &nbsp;</td>
        <td class="auto-style20">
            &nbsp;</td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

             <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="LbSpousePhn0" runat="server" Font-Bold="True" Text="Spouse PhoneNum" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtSpoucePhnNum0" runat="server" Width="310px" Enabled="False"></asp:TextBox>
                 </td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

                 <tr>
                     <td class="auto-style56">&nbsp;</td>
                     <td class="auto-style58">&nbsp;</td>
                     <td class="auto-style20">&nbsp;</td>
                     <td class="auto-style22">&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
            </tr>

                 <tr>
        <td class="auto-style56"></td>
        <td class="auto-style58">
            <asp:Label ID="LbSpouseEmail" runat="server" Font-Bold="True" Text="Spouse Email" Font-Size="14pt"></asp:Label>
                     </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtSpouceEmail" runat="server" Width="313px" Enabled="False"></asp:TextBox>
                     </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style2"></td>
    </tr>

                 <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

                 <tr>
                     <td class="auto-style56">&nbsp;</td>
                     <td class="auto-style58">
                         <asp:Label ID="LbSpouseAddrs" runat="server" Font-Bold="True" Text="Spouse Address" Font-Size="14pt"></asp:Label>
                     </td>
                     <td class="auto-style20">
                         <textarea id="txtSpouseContAddrs" name="S9" rows="2"></textarea></td>
                     <td class="auto-style22">&nbsp;</td>
                     <td>&nbsp;</td>
                     <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

                 <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="LbSpouseOccup" runat="server" Font-Bold="True" Text="Occupation" Font-Size="14pt"></asp:Label>
                     </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtSpouceOccup" runat="server" Width="294px" Enabled="False"></asp:TextBox>
                     </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>

                 <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbSpouseEmplo" runat="server" Font-Bold="True" Text="Spouse Employer" Font-Size="14pt" ForeColor="#00000E"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtSpouseEmployer" runat="server" Width="298px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Label ID="LbNxtOfKinInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Next of Kin Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbnxtOfKinFName" runat="server" Font-Bold="True" Text="First Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtNxtOfKinfName" runat="server" Width="304px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbnxtOfKinMidName" runat="server" Font-Bold="True" Text="Middle Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtNxtOfKinMidName" runat="server" Width="308px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="nxtOfKinLNameLabel" runat="server" Font-Bold="True" Text="Last Name" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtNxtOfKinLName" runat="server" Width="307px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="LbNxtOfKinrelationship" runat="server" Font-Bold="True" Text="Relationship" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtNxtOfKinRelationship" runat="server" Width="301px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">
                    <asp:Label ID="nxtOfKinphNoLabel" runat="server" Font-Bold="True" Text="Phone No" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="txtNxtOfKinPhNo" runat="server" Width="298px" Enabled="False"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
                <td class="auto-style33">
                    &nbsp;</td>
               
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                
            </tr>
             <tr>
                 <td class="auto-style57">&nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbnxtOfKinEmail" runat="server" Font-Bold="True" Text="Email" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <asp:TextBox ID="txtNxtOfKinEmail" runat="server" Width="306px" Enabled="False"></asp:TextBox>
                 </td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
             <tr>
        <td class="auto-style57">&nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="Lboccupation" runat="server" Font-Bold="True" Text="Occupation" Font-Size="14pt"></asp:Label>
                 </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtNxtOfKinOccupation" runat="server" Width="309px" Enabled="False"></asp:TextBox>
                 </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td class="auto-style33">
            &nbsp;</td>
        <td class="auto-style33">&nbsp;</td>
               
    </tr>
             <tr>
        <td class="auto-style57">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td class="auto-style33">&nbsp;</td>
        <td class="auto-style33">&nbsp;</td>
              
    </tr>
             <tr>
                 <td class="auto-style57">&nbsp;</td>
                 <td class="auto-style58">
                     <asp:Label ID="LbnxtOfKinContAddr" runat="server" Font-Bold="True" Text="Contact Address" Font-Size="14pt"></asp:Label>
                 </td>
                 <td class="auto-style20">
                     <textarea id="txtNxtOfKinContAdd" runat="server" name="S10" rows="2"></textarea></td>
                 <td class="auto-style22">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
                 <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style57">&nbsp;</td>
                <td class="auto-style58">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
             <tr>
        <td colspan="6">
            <asp:Label ID="LbBankInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Employee Bank Information"></asp:Label>
                 </td>
    </tr>
             <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
                  <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">
            <asp:Label ID="LbBankName" runat="server" Font-Bold="True" Text="Bank Name" Font-Size="14pt"></asp:Label>
                      </td>
        <td class="auto-style20">
            <asp:TextBox ID="txtBnkName" runat="server" Width="300px" Enabled="False"></asp:TextBox>
                      </td>
        <td class="auto-style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
                  <tr>
        <td class="auto-style56">&nbsp;</td>
        <td class="auto-style58">&nbsp;</td>
        <td class="auto-style20">&nbsp;</td>
        <td class="auto-style22">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
                      <tr>
                          <td class="auto-style56">&nbsp;</td>
                          <td class="auto-style58">
                              <asp:Label ID="LbAcctName" runat="server" Font-Bold="True" Text="Account Name" Font-Size="14pt"></asp:Label>
                          </td>
                          <td class="auto-style20">
                              <asp:TextBox ID="txtAcctName" runat="server" Width="299px" Enabled="False"></asp:TextBox>
                          </td>
                          <td class="auto-style22">
                              &nbsp;</td>
                          <td>&nbsp;</td>
                          <td>&nbsp;</td>
                          <tr>
                              <td class="auto-style56">&nbsp;</td>
                              <td class="auto-style58">&nbsp;</td>
                              <td class="auto-style20">&nbsp;</td>
                              <td class="auto-style22">&nbsp;</td>
                              <td>&nbsp;</td>
                              <td>&nbsp;</td>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style58">
                                      <asp:Label ID="LbAcctNum" runat="server" Font-Bold="True" Text="Account Number" Font-Size="14pt"></asp:Label>
                                  </td>
                                  <td class="auto-style20">
                                      <asp:TextBox ID="txtAcctNum" runat="server" Width="302px" Enabled="False"></asp:TextBox>
                                  </td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style58">&nbsp;</td>
                                  <td class="auto-style20">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style58">&nbsp;</td>
                                  <td class="auto-style20">
                                      <asp:Button ID="employeeNextBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="employeeNextBtn_Click" Text="Next" />
                                  </td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style58">&nbsp;</td>
                                  <td class="auto-style20">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style56">&nbsp;</td>
                                  <td class="auto-style58">&nbsp;</td>
                                  <td class="auto-style20">&nbsp;</td>
                                  <td class="auto-style22">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                          </tr>
                      </tr>
    </tr>
                      
        </table>
    </asp:View>--%>






    <asp:View ID="ViewQualification" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
             
            <tr>
                <td colspan="4">
                    <asp:LinkButton ID="spouceLinkBtn1" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="NextofKinLinkBtn1" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="BankLinkBtn1" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="guarrantorLinkBtn11" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11" colspan="4">
                    <asp:Label ID="LbQualifInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details"></asp:Label>
                </td>
            </tr>
            <%--<tr>
                <td class="auto-style30" colspan="4">
                    <asp:Label ID="LbQualifInfo3" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="Click &quot;View and Save&quot; Button to view and save your qualifications for the first time "></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Button ID="qulifViewBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qulifViewBtn_Click" Text="View" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29" colspan="4">
                    <asp:GridView ID="GViewQualification" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />

                            <asp:TemplateField>
                                <ItemTemplate>
                                   <asp:TextBox ID="txtQualifViewAppID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>'></asp:TextBox>
                                    
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
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Label ID="lbEmpQualifAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Button ID="qulifVSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qulifVSaveBtn_Click" Text="Save" Visible="False" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>--%>

            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29" colspan="4">
                    <asp:Label ID="LbQualifInfo14" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="These are your qualifications "></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29" colspan="4">
                    <asp:GridView ID="GViewQaulification" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCommand="GViewAddQualification_RowCommand" Visible="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifAppID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifEmpID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                         <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifSaveEmpLogID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeLogID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                         
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
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style54">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Label ID="lbEmpQualificationAdded1" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29" colspan="4">
                    <asp:Label ID="LbQualifInfo4" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="Click &quot;Add More&quot; Button to add more qualifications "></asp:Label>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">
                    <asp:Button ID="qulifAddMoreBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qulifAddMoreBtn_Click" Text="Add More" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style29" colspan="4">
                    <asp:Panel ID="PanelAddQualif" runat="server" Visible="False">
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29" colspan="4">
                                    <asp:Label ID="LbQualifInfo6" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Add more Qualification and wait for HR approval"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">
                                    <asp:Label ID="LbSchName" runat="server" Font-Bold="True" Font-Size="14pt" Text="School Name"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtQualifSchName" runat="server" Width="210px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">
                                    <asp:Label ID="LbCourse" runat="server" Font-Bold="True" Font-Size="14pt" Text="Course"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="courseList" runat="server" Height="16px" Width="210px">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem>Accounting</asp:ListItem>
                                        <asp:ListItem>Agriculture</asp:ListItem>
                                        <asp:ListItem>BioChemistry</asp:ListItem>
                                        <asp:ListItem>Biolagy</asp:ListItem>
                                        <asp:ListItem>Business Administration</asp:ListItem>
                                        <asp:ListItem>Computer Science</asp:ListItem>
                                        <asp:ListItem>Education</asp:ListItem>
                                        <asp:ListItem>Ecology</asp:ListItem>
                                        <asp:ListItem>Economics</asp:ListItem>
                                        <asp:ListItem>Fishery</asp:ListItem>
                                        <asp:ListItem>Networking</asp:ListItem>
                                        <asp:ListItem>Security</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">
                                    <asp:Label ID="LbQaulif" runat="server" Font-Bold="True" Font-Size="14pt" Text="Qualification"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="qualifList" runat="server" AutoPostBack="True" DataTextField="qualifName" DataValueField="qualifName" Height="16px" OnSelectedIndexChanged="qualifList_SelectedIndexChanged" Width="210px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">
                                    <asp:Label ID="LbGrade" runat="server" Font-Bold="True" Font-Size="14pt" Text="Grade"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="gradeList" runat="server" AutoPostBack="True" DataTextField="gradeName" DataValueField="gradeName" Height="16px" Width="210px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">
                                    <asp:Label ID="LbQualifStartYear" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Year"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="qualifStartYearList" runat="server" Height="16px" Width="210px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;<asp:Label ID="LbQualifEndDate" runat="server" Font-Bold="True" Font-Size="14pt" Text="End Year"></asp:Label>
                                    &nbsp; </td>
                                <td>
                                    <asp:DropDownList ID="qualifEndYearList" runat="server" Height="16px" Width="210px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>
                                    <asp:Button ID="empQulifAddBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="empQulifAddBtn_Click" Text="Add " />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29" colspan="4">
                                    <asp:GridView ID="GViewAddQualification" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCommand="GViewAddQualification_RowCommand" Visible="False">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" SortExpression="InstitutionName" />
                                            <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" SortExpression="QualificationType" />
                                            <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                                            <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" SortExpression="StartYear" />
                                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" SortExpression="EndYear" />
                                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifSaveAppID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifSaveEmpID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtQualifSaveEmpLogID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeLogID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                                         
                                            <asp:TemplateField ShowHeader="False"><ItemTemplate><asp:LinkButton ID="LinkButtonQualifSave" runat="server" CausesValidation="False" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.QualificationID") %>' CommandName="Delete" Text="Delete"></asp:LinkButton></ItemTemplate></asp:TemplateField>
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
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">
                                    <asp:Label ID="lbEmpQualifiDeleted" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>
                                    <asp:Button ID="qulifSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qulifSaveBtn_Click" Text="Save" UseSubmitBehavior="False" Visible="False" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style29" colspan="4">
                                    <asp:Label ID="lbEmpQualificationAdded" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style29">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
        </table>
    </asp:View>
    <asp:View ID="ViewCertification" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="4">
                    &nbsp;<asp:LinkButton ID="spouceLinkBtn0" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="NextofKinLinkBtn0" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="BankLinkBtn0" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="guarrantorLinkBtn12" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
                    &nbsp;</td>
            </tr>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Label ID="LbCertifcation" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Professional Certification"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Label ID="LbQualifInfo15" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="These are your professional qualifications "></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:GridView ID="GViewEmpCert1" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCommand="GViewEmpCert_RowCommand" Visible="False">
                         <AlternatingRowStyle BackColor="White" />
                         <Columns>
                             <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                             <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                             <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                             <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertSaveAppID0" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertSaveEmpID0" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.employeeID_FK")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertSaveEmpLogID0" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeLogID_FK")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                           
                              <asp:TemplateField ShowHeader="False"><ItemTemplate><asp:LinkButton ID="LinkButtonQualifSave0" runat="server" CausesValidation="False" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ProfQualificationID") %>' CommandName="Delete" Text="Delete"></asp:LinkButton></ItemTemplate></asp:TemplateField>
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
                 <td colspan="4">&nbsp;</td>
             </tr>
           
             <tr>
                 <td colspan="4">
                     <asp:Label ID="LbProfQualifSave1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#99CC00" Visible="False"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style54" colspan="4">
                     <asp:Label ID="LbQualifInfo8" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="Click &quot;Add More&quot; Button to add more professional qualifications "></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style54" colspan="4">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style54" colspan="4">
                     <asp:Button ID="certAddMoreBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="certAddMoreBtn_Click" Text="Add More" />
                 </td>
             </tr>
             <tr>
                 <td class="auto-style54">&nbsp;</td>
                 <td class="auto-style53">&nbsp;</td>
                 <td class="auto-style18">&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style54" colspan="4">
                     <asp:Panel ID="PanelAddProfqualif" runat="server" Visible="False">
                         <table style="width:100%;">
                             <tr>
                                 <td colspan="4">
                                     <asp:Label ID="LbQualifInfo9" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Add more Professional Qualification and wait for HR approval"></asp:Label>
                                 </td>
                             </tr>
                              <tr>
                                 <td class="auto-style92">&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                 <td class="auto-style92">&nbsp;</td>
                 <td class="auto-style53">
                     <asp:Label ID="LbCertName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Name"></asp:Label>
                 </td>
                 <td class="auto-style18">
                     <asp:TextBox ID="txtCertName" runat="server" style="margin-left: 0px" Width="300px"></asp:TextBox>
                 </td>
                 <td>&nbsp;</td>
             </tr>
            <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">
                    <asp:Label ID="LbStage" runat="server" Font-Bold="True" Text="Stage" Font-Size="14pt"></asp:Label>
                 </td>
                <td class="auto-style18">
                    <asp:DropDownList ID="certStageList" runat="server" Height="16px" Width="300px">
                        <asp:ListItem>---Please Select---</asp:ListItem>
                        <asp:ListItem>Intermediate</asp:ListItem>
                        <asp:ListItem>Advance</asp:ListItem>
                        <asp:ListItem>Professional</asp:ListItem>
                    </asp:DropDownList>
                 </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                 <td>&nbsp;</td>

            </tr>
            <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">
                    <asp:Label ID="LbCertNo" runat="server" Font-Bold="True" Text="Certificate Num" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtCertNum" runat="server" Width="300px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">
                    <asp:Label ID="LbCertYear" runat="server" Font-Bold="True" Text="Year" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:DropDownList ID="certYearList" runat="server" Height="16px" Width="300px">
                    </asp:DropDownList>
                </td>
                 <td>&nbsp;</td>

            </tr>
            <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style92">
                    &nbsp;</td>
                <td class="auto-style53">
                    &nbsp;</td>
                <td class="auto-style18">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="certAddBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="certAddBtn_Click" Text="Add" />
                    &nbsp;&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style92">&nbsp;</td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="GViewEmpCert" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GViewEmpCert_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" SortExpression="CertificationName" />
                            <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" SortExpression="CertificateNo" />
                            <asp:BoundField DataField="Stage" HeaderText="Stage" SortExpression="Stage" />
                            <asp:BoundField DataField="CertYear" HeaderText="Year" SortExpression="Year" />
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertSaveAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertSaveEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.employeeID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtCertSaveEmpLogID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeLogID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>           
                            <asp:TemplateField ShowHeader="False"><ItemTemplate><asp:LinkButton ID="LinkButtonQualifSave" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ProfQualificationID") %>'></asp:LinkButton></ItemTemplate></asp:TemplateField>
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
                <td class="auto-style92">
                    &nbsp;</td>
                <td class="auto-style53">&nbsp;</td>
                <td class="auto-style18">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                             <tr>
                                 <td class="auto-style90" colspan="4">
                                     <asp:Label ID="lbEmpProfQualifiDeleted" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="auto-style92">
                                     <asp:Button ID="certSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Save" Visible="False" OnClick="certSaveBtn_Click" />
                                 </td>
                                 <td class="auto-style53">&nbsp;</td>
                                 <td class="auto-style18">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style92">&nbsp;</td>
                                 <td class="auto-style53">&nbsp;</td>
                                 <td class="auto-style18">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style92">
                                     <asp:Label ID="LbProfQualifSave" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#669900" Visible="False"></asp:Label>
                                 </td>
                                 <td class="auto-style53">&nbsp;</td>
                                 <td class="auto-style18">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td class="auto-style92">&nbsp;</td>
                                 <td class="auto-style53">&nbsp;</td>
                                 <td class="auto-style18">&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                         </table>
                     </asp:Panel>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style54">&nbsp;</td>
                 <td class="auto-style53">&nbsp;</td>
                 <td class="auto-style18">&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             
        </table>
    </asp:View>
    <asp:View ID="ViewOtherDocuments" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="4">
                    <asp:LinkButton ID="spouceLinkBtn" runat="server" OnClick="spouceLinkBtn_Click">Spouce</asp:LinkButton>
                    &nbsp;&nbsp;<asp:LinkButton ID="NextofKinLinkBtn" runat="server" OnClick="NextofKinLinkBtn_Click">NOK</asp:LinkButton>
                    &nbsp;&nbsp;<asp:LinkButton ID="BankLinkBtn" runat="server" OnClick="BankLinkBtn_Click">Bank</asp:LinkButton>
                    &nbsp;&nbsp;<asp:LinkButton ID="guarrantorLinkBtn14" runat="server" OnClick="guarrantorLinkBtn_Click">Guarrantor</asp:LinkButton>
&nbsp;</td>
               
            </tr>
             <tr>
                 <td colspan="4">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Label ID="LbOtherDocm1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Other Document"></asp:Label>
                 </td>
             </tr>
            <%-- <tr>
                 <td colspan="4">
                     <asp:Label ID="LbQualifInfo10" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="Click &quot;View&quot; and &quot;Save&quot; Button to view and save your Document for the first time "></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Button ID="docViewSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="docViewSaveBtn_Click" Text="View" />
                 </td>
             </tr>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:GridView ID="GViewDoc" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                         <AlternatingRowStyle BackColor="White" />
                         <Columns>
                             <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                             <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtdocAppID" runat="server"  Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.ApplicantID_FK")%>'></asp:TextBox>
                                    
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
                 <td colspan="4">
                     <asp:Label ID="LbDocSave" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#99CC00" Visible="False"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Button ID="docVSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="docVSaveBtn_Click" Text="Save" Visible="False" />
                 </td>
             </tr>--%>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Label ID="LbQualifInfo16" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="These are your Documents"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:GridView ID="GViewEmpDoc1" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCommand="GViewEmpDoc_RowCommand" Visible="False">
                         <AlternatingRowStyle BackColor="White" />
                         <Columns>
                             <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                             <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocuAppID1" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocuEmpID1" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_Fk")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocuEmpLogID1" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeLogID_Fk")%>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                       
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
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                      <asp:Label ID="LbDocumentSave1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#669900" Visible="False"></asp:Label>
                  </td>
             </tr>
             <tr>
                 <td colspan="4">&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Label ID="LbQualifInfo13" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#3399FF" Text="Click &quot;Add More&quot; Button to  add more document"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="4">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">
                     <asp:Button ID="docAddMoreBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Add More" OnClick="docAddMoreBtn_Click" />
                 </td>
             </tr>
             <tr>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                 <td colspan="4">
                     <asp:Panel ID="PanelAddMoreDocument" runat="server" Visible="False">
                         <table style="width:100%;">
                              <tr>
                <td class="auto-style13" colspan="4">
                    <asp:Label ID="LbQualifInfo12" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Upload more documents and wait for HR approval"></asp:Label>
                                  </td>
            </tr>
                              <tr>
                                  <td class="auto-style91">&nbsp;</td>
                                  <td class="auto-style14">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="auto-style91">&nbsp;</td>
                                  <td class="auto-style14">
                                      <asp:Label ID="LbDocName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Document Name"></asp:Label>
                                  </td>
                                  <td>
                                      <asp:DropDownList ID="ddlDocumentTpe" runat="server" Height="16px" Width="250px">
                                          <asp:ListItem>***Please select***</asp:ListItem>
                                          <asp:ListItem>Degree</asp:ListItem>
                                          <asp:ListItem>NYSC</asp:ListItem>
                                          <asp:ListItem>Certification</asp:ListItem>
                                          <asp:ListItem>Birth Cert</asp:ListItem>
                                      </asp:DropDownList>
                                  </td>
                                  <td>&nbsp;</td>
                              </tr>
            <tr>
                <td class="auto-style91">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style91">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="LbDocFile0" runat="server" Font-Bold="True" Text="File" Font-Size="14pt"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="docFileUpload" runat="server" Height="20px" Width="250px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style91">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style91">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style91">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Button ID="docAddBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Add" OnClick="docAddBtn_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style91">&nbsp;</td>
                                  <td class="auto-style14">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
            <tr>
                <td class="auto-style13" colspan="4">
                    <asp:GridView ID="GViewEmpDoc" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GViewEmpDoc_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="DocumentType" HeaderText="Type" SortExpression="Type" />
                            <asp:BoundField DataField="DocumentPath" HeaderText="Path" SortExpression="Path" />
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocuAppID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID_FK")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocuEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID_Fk")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtDocuEmpLogID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeLogID_Fk")%>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                            <asp:TemplateField ShowHeader="False"><ItemTemplate><asp:LinkButton ID="LinkButtonQualifSave" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.DocumentID") %>'></asp:LinkButton></ItemTemplate></asp:TemplateField>
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
                <td class="auto-style91">
                    &nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style91" colspan="4">
                                      <asp:Label ID="lbEmpDocDeleted" runat="server" style="color: #669900; font-weight: 700; font-size: small" Visible="False"></asp:Label>
                                  </td>
                              </tr>
            <tr>
                <td class="auto-style91">
                    &nbsp;</td>
                <td class="auto-style14">
                    <asp:Button ID="docSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Save" OnClick="docSaveBtn_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                              <tr>
                                  <td class="auto-style89" colspan="4">
                                      <asp:Label ID="LbDocumentSave" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#669900" Visible="False"></asp:Label>
                                  </td>
                              </tr>
                              <tr>
                                  <td class="auto-style91">&nbsp;</td>
                                  <td class="auto-style14">&nbsp;</td>
                                  <td>&nbsp;</td>
                                  <td>&nbsp;</td>
                              </tr>
                         </table>
                     </asp:Panel>
                 </td>
             </tr>
           
             <tr>
                 <td class="auto-style13" colspan="4">
                     &nbsp;</td>
             </tr>
        </table>
    </asp:View>


    <%--<asp:View ID="ViewOtherDocuments" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="4">
                    <asp:Label ID="LbOtherDocm" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Other Document"></asp:Label>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="LbDocName" runat="server" Font-Bold="True" Text="Document Name"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList13" runat="server" Height="16px" Width="341px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="LbDocFile0" runat="server" Font-Bold="True" Text="File"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Height="20px" Width="323px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>
                    <asp:Button ID="docUploadBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Upload" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="docSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Save" />
                    &nbsp;&nbsp;
                    <asp:Button ID="docNextBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="docNextBtn_Click" Text="Next" />
                    &nbsp;
                    <asp:Button ID="docBackBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="docBackBtn_Click" Text="Back" />
                    &nbsp;&nbsp;
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <asp:GridView ID="GViewDoc" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>--%>
    
   

    <%--<asp:View ID="ViewGuarantor" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td colspan="4">
                <asp:Label ID="LBGuarrantor" runat="server" Font-Bold="True" Text="Guarantor Personal Information" Font-Size="14pt" ForeColor="#CC0066"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left" colspan="4">Note: The person filling this form <strong>MUST</strong> be above the age of 18 any of the following:<br />
                <ul>
                    <li>Senior Civil Servant not below grade level 12 in Public Service;</li>
                    <li>A Banker not less than Senior Banking Officer;</li>
                    <li>A practicing professional such as Lawyer, Doctor, Pilot, COREN, registered Engineer, not less than 10years of working experience;</li>
                    <li>A Senior Lecturer in Higher Institution;</li>
                    <li>A well-known religious and community leader acceptable to us</li>   
                </ul>
                <strong>CUATION</strong>: Do NOT stand as a guarantor for somebody you not know 
                 
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
                <asp:Label ID="LBGuarrantDetail" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Guarantor Details"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbGTitle" runat="server" Font-Bold="True" Text="Title"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="GtitleList" runat="server">
                    <asp:ListItem>Please select</asp:ListItem>
                    <asp:ListItem>MR.</asp:ListItem>
                    <asp:ListItem>MRS.</asp:ListItem>
                    <asp:ListItem>MISS</asp:ListItem>
                    <asp:ListItem>DR.</asp:ListItem>
                    <asp:ListItem>PROF.</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="LbGSurName" runat="server" Font-Bold="True" Text="Surname:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGLName" runat="server"></asp:TextBox>
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
                <asp:Label ID="LbGFN" runat="server" Font-Bold="True" Text="First Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGFName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbGMN" runat="server" Font-Bold="True" Text="Other Names:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGMidName" runat="server"></asp:TextBox>
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
                <asp:Label ID="LbGPN" runat="server" Font-Bold="True" Text="Any Previous Name(s) in full:"></asp:Label>
                 </td>
            <td>
                <asp:TextBox ID="txtGPrevNames" runat="server"></asp:TextBox>
                 </td>
            <td>
                <asp:Label ID="LbGCurAddr" runat="server" Font-Bold="True" Text="Current Residential Address:"></asp:Label>
                 </td>
            <td>
                <asp:TextBox ID="txtGCurAddr" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbTimeatCurAdd" runat="server" Font-Bold="True" Text="Time spentat this Address to date:"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGTimeSpent" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbHomeNo" runat="server" Font-Bold="True" Text="Home Tel:"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGHomeTel" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbMobile" runat="server" Font-Bold="True" Text="Mobile:"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGMobile" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbOtherNo" runat="server" Font-Bold="True" Text="Any other Tel:"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGOtherTel" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbGEmail" runat="server" Font-Bold="True" Text="Email:"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGEmail" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbGRel" runat="server" Font-Bold="True" Text="Relationship to Employee"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGRelationship" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbPreAddr" runat="server" Font-Bold="True" Text="Previous Residential Address"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGPreAddrs" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbPreOccup" runat="server" Font-Bold="True" Text="Previous Occupation:"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGPreOccupation" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbPreEmployer" runat="server" Font-Bold="True" Text="Previous Employer"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGPreEmployer" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbPreEmployerAddr" runat="server" Font-Bold="True" Text="Previous Employer Address"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGPreEmpAddr" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style15">
                     <asp:Label ID="LbPreLineMang" runat="server" Font-Bold="True" Text="Previous Line Manager"></asp:Label>
                 </td>
                 <td class="auto-style15">
                     <asp:TextBox ID="txtGPreLineMang" runat="server"></asp:TextBox>
                 </td>
                 <td class="auto-style15">
                     <asp:Label ID="LbPreEmployerPhnNo" runat="server" Font-Bold="True" Text="Previous Employer Phone Num"></asp:Label>
                 </td>
                 <td class="auto-style15">
                     <asp:TextBox ID="txtGPreEmpPhnNo" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbCurOccup" runat="server" Font-Bold="True" Text="Current Occupation:"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGCurOccupation" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbCurEmployer" runat="server" Font-Bold="True" Text="Current Employer"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGCurEmployer" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbCurEmployerAddr" runat="server" Font-Bold="True" Text="Current Employer Address"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGCurEmpAddr" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbCurLineMang" runat="server" Font-Bold="True" Text="Date started"></asp:Label>
                 </td>
                 <td>
                     <asp:Calendar ID="GurantorStartDate" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
                 <td>
                     <asp:Label ID="LbGBankName" runat="server" Font-Bold="True" Text="Bank Name"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGBankName" runat="server"></asp:TextBox>
                 </td>
                 <td>
                     <asp:Label ID="LbGBankAddr" runat="server" Font-Bold="True" Text="Bank Address"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGBankAddr" runat="server"></asp:TextBox>
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
                     <asp:Label ID="LbGCriminal" runat="server" Font-Bold="True" Text="Any Criminal Conviction"></asp:Label>
                 </td>
                 <td>
                     <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                         <asp:ListItem Selected="True">Yes</asp:ListItem>
                         <asp:ListItem>No</asp:ListItem>
                     </asp:RadioButtonList>
                 </td>
                 <td>
                     <asp:Label ID="LbGCourt" runat="server" Font-Bold="True" Text="Court Judgement"></asp:Label>
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
                 <td>
                     <asp:Label ID="LbGAdmin" runat="server" Font-Bold="True" Text="Administrative Incitement"></asp:Label>
                 </td>
                 <td>&nbsp;</td>
                 <td>
                     <asp:Label ID="LbGPassport" runat="server" Font-Bold="True" Text="Upload Passport"></asp:Label>
                 </td>
                 <td>
                     <asp:FileUpload ID="GPassportFileUpload" runat="server" />
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
                 <td class="auto-style23">
                     <asp:Label ID="LbGAttes" runat="server" Font-Bold="True" Text="I am acting as a guarantor for "></asp:Label>
                     &nbsp;<asp:Label ID="LbGAttes1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="9pt" ForeColor="#FF3300" Text="(Emloyee full Names):"></asp:Label>
                 </td>
                 <td class="auto-style23">
                     <asp:TextBox ID="txtGEmp" runat="server"></asp:TextBox>
                 </td>
                 <td class="auto-style23">
                     &nbsp;</td>
                 <td class="auto-style23">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td colspan="4">In respect to the following employee commitment and fidelity.<br /> <p>I believe the information provided here to be true and authorized CompanyName to: Carry out the verification on reference checks from any of the parties mentioned herein.<br /> Use the information obtained with the third parties to asses as guarantor and make decision on candidate employment or confirmation</p>
                     <p>
                         Handle all information in strictest confidence<br /></p>
                     <p> I understand that if I default on my guarantor's obligation, the information provided in this form may be released to law enforcement agencies, law court or CompanyName clients to which the employee is deployed.
                         Completing this form does not commit the propective gurantor to that role unless the Fidelity Guarantee is duly executed.
                     </p>
                     <p>I hereby confirm that i have read the above, that I full understand my responsibility and liabilities as a guarantor.</p>
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
                     <asp:Label ID="LbGfulName" runat="server" Font-Bold="True" Text="Gurantor full Names"></asp:Label>
                     &nbsp;<asp:Label ID="LbGFullNames" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="9pt" ForeColor="#FF3300" Text="(in block leters):"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtGFullNames" runat="server"></asp:TextBox>
                 </td>
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
                <asp:Label ID="LbGDate" runat="server" Font-Bold="True" Text="Date "></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="GurantorDate" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
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
            <td>&nbsp;</td>
        </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>
                     <asp:Button ID="GuarBackBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="GuarBackBtn_Click" Text="Back" />
                 </td>
                 <td>
                     <asp:Button ID="goToAppraisalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="goToAppraisalBtn_Click" Text="Appraisal" />
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
   
    <asp:View ID="ViewQuery" runat="server">
    <table style="border: medium solid #CC0066; width: 100%;">
        <tr>
            <td class="auto-style62" colspan="6">
                <asp:Label ID="LbQuery" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Query Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style63">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style63">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style63">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style62" colspan="6">
                <asp:GridView ID="GVQuery" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="QueryTitle" HeaderText="Query Title" />
                        <asp:BoundField DataField="QueryIssueByName" HeaderText="IssueBy" />
                        <asp:BoundField DataField="IssueDate" HeaderText="IssuedDate" />
                        <asp:BoundField DataField="QueryLetter" HeaderText="Query Letter" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="Blue" CommandArgument='<%#DataBinder.Eval (Container,"DataItem.QueryID")%>' CommandName="Reply">View and Reply</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style63">
                <asp:Label ID="lblQueryReport" runat="server" Font-Italic="True" ForeColor="#669900"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style62" colspan="6">
                <asp:Label ID="LbQueryResponseSent1" runat="server" Font-Italic="True" Font-Size="14pt" ForeColor="#669900" Style="font-weight: 700"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style63">
                <asp:Button ID="btnQueryFinish" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#009900" OnClick="btnQueryFinish_Click" Text="Finish" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style62" colspan="6">
                <asp:Panel ID="PanelQueryDetails" runat="server">
                    <table style="width: 80%; margin-left: 50px;">
                        <tr>
                            <td colspan="3">
                                <strong><em>Please reply to the following query</em></strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style92">&nbsp;</td>
                            <td colspan="2">&nbsp;</td>
                            </tr>
                        <tr>
                            <td class="auto-style92">
                                <asp:Label ID="Label35" runat="server" Style="font-weight: 700" Text="Employee Number:"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQueryEmployeeNum" runat="server" Style="font-weight: 700" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style92">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style92">
                                <asp:Label ID="Label36" runat="server" Style="font-weight: 700" Text="Query Title"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQueryTitle" runat="server" Style="font-weight: 700" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style92">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style92">
                                <asp:Label ID="Label37" runat="server" Style="font-weight: 700" Text="Query Description"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQueryDescription" runat="server" Style="font-weight: 700" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style92">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style92">
                                <asp:Label ID="Label2" runat="server" Style="font-weight: 700" Text="Issued Date"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQueryDate" runat="server" Style="font-weight: 700" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style92">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style92">
                                <asp:Label ID="Label39" runat="server" Style="font-weight: 700" Text="Issued By"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQueryBy" runat="server" Style="font-weight: 700" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style92">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style92">
                                <asp:Label ID="Label40" runat="server" Style="font-weight: 700" Text="Query Letter"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQueryletter" runat="server" Style="font-weight: 700" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style92">
                                &nbsp;</td>
                            <td colspan="2">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style62">
                &nbsp;</td>
            <td class="auto-style63">
                &nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td colspan="6">
                <asp:Panel ID="PanelDiscipline" runat="server">
                    <table style="width:90%; margin-left:50px;">
                        <tr>
                            <td class="auto-style106">
                                &nbsp;</td>
                            <td colspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style106">
                                <asp:Label ID="lblResponseText" runat="server" Font-Size="14pt" style="font-weight: 700" Text="Your Response:"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblResponseDetails" runat="server" ForeColor="#990033" style="font-weight: 700; font-style: italic;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style106">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style106">
                                <asp:Label ID="lblResponseDateText" runat="server" style="font-weight: 700" Text="Date Responded" Font-Size="14pt"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblResponseDate" runat="server" style="font-weight: 700" ForeColor="#990033"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style106">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style106">
                                <asp:Label ID="Label44" runat="server" style="font-weight: 700" Text="Discipline Details" Font-Size="14pt" ForeColor="#00000E"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblDisDetails" runat="server" style="font-style: italic; font-weight: 700" ForeColor="#990033"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style106">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style106">
                                <asp:Label ID="Label45" runat="server" style="font-weight: 700" Text="Date Disciplined" Font-Size="14pt"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblDisDate" runat="server" ForeColor="#990033"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style106">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style106">
                                <asp:Label ID="Label48" runat="server" style="font-weight: 700" Text="Disciplined By" Font-Size="14pt"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblDisBy" runat="server" ForeColor="#990033"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style63">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td colspan="6">
                <asp:Panel ID="PanelResponse" runat="server" Visible="False">
                    <table style="width:90%; margin-left:50px;">
                        <tr>
                            <td class="auto-style15">&nbsp;<asp:Label ID="Label69" runat="server" Font-Size="14pt" ForeColor="#990033" style="font-weight: 700" Text="Please respond to the query above"></asp:Label>
                            </td>
                            <td class="auto-style15"></td>
                            <td class="auto-style15"></td>
                        </tr>
                        <tr>
                            <td class="auto-style15">&nbsp;</td>
                            <td class="auto-style15">&nbsp;</td>
                            <td class="auto-style15">&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label41" runat="server" Style="font-weight: 700" Text="Response to Query" Font-Size="14pt"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="txtQueryResponse" runat="server" Height="152px" TextMode="MultiLine" Width="338px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label42" runat="server" Style="font-weight: 700" Text="Upload Response letter if any" Font-Size="14pt"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:FileUpload ID="QueryResponseUpload1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label43" runat="server" Style="font-weight: 700" Text="Date Responded" Font-Size="14pt"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="lblQueryResponsedate" runat="server" Text="Label" ForeColor="#990033"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="LbQueryResponseSent" runat="server" Font-Italic="True" Font-Size="14pt" ForeColor="#669900" Style="font-weight: 700"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnSendQueryResponse" runat="server" OnClick="btnSendQueryResponse_Click" Style="font-weight: 700; " Text="Respond" Font-Bold="True" Font-Size="14pt" ForeColor="#009900" Width="96px" />
                            </td>
                            <td>
                                x</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>

        <tr>
            <td class="auto-style62">&nbsp;</td>
            <td class="auto-style63">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>

        </tr>
    </table>
</asp:View>
      
    <%--<asp:View ID="ViewQuery" runat="server">
    <table style="border: medium solid #CC0066; width:100%;">
        <tr>
            <td>
                <asp:Label ID="LbQuery" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Query Management"></asp:Label>
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
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="EmployeeID"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="queryEmployeeList" runat="server" Enabled="False">
                </asp:DropDownList>
                <asp:Label ID="queryEmployeeID" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:Label ID="LbQueyType" runat="server" Font-Bold="True" Text="Query Type"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="queryTypeList" runat="server" Enabled="False">
                </asp:DropDownList>
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
                <asp:Label ID="LbQueryDesc" runat="server" Font-Bold="True" Text="Query Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQueryDesc" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbReason" runat="server" Font-Bold="True" Text="Reason"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQueryReason" runat="server" Enabled="False"></asp:TextBox>
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
                <asp:Label ID="LbQuerystatus0" runat="server" Font-Bold="True" Text="Query Status"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQueryStatus" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="LbEmpResponse" runat="server" Font-Bold="True" Text="Employee Response"></asp:Label>
            </td>
            <td>
                <textarea id="txtResponse" cols="20" name="S1" rows="2"></textarea></td>
        </tr>

         <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LbIssueBy" runat="server" Font-Bold="True" Text="IssueBy"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LbIssuedBy" runat="server" Font-Bold="True" ForeColor="#FF6666" Enabled="False"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LbIssueDate" runat="server" Font-Bold="True" Text="Issue Date"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="IssueDateCalendar" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" Enabled="False">
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
            <td>
                <asp:Button ID="queryBackBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="queryBackBtn_Click" Text="Back" />
            </td>
            <td>
                <asp:Button ID="respondQueryBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Respond" />
            </td>
            <td>
                &nbsp;
                </td>
            <td>
                <asp:Button ID="queryNextBtn0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="queryNextBtn_Click" Text="Next" />
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
</asp:View>
      --%>

<asp:View ID="ViewLeave" runat="server">
    <table style="width: 100%; border: medium solid #CC0066; width: 100%;">
        <tr>
            <td class="auto-style54" colspan="4">
                <asp:Label ID="LbLeaveManagement" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Leave Management" style="font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style81" colspan="4">
                <ul>
                    <li>Welcome to Leave&nbsp; management module</li>
                    <li>Please remeber that you are entitle to
                        <asp:Label ID="lblLeave" runat="server" style="font-weight: 700; font-style: italic; color: #CC3300"></asp:Label>
                        &nbsp; working days of Leave in a year</li>
                    <li>You have
                        <asp:Label ID="LbThreshold1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#CC0000"></asp:Label>
                        &nbsp;days&nbsp; left</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblLeaveMessage1" runat="server" style="font-style: italic; font-weight: 700; color: #CC3300"></asp:Label>
                <asp:Label ID="lbNoLeaveRecord" runat="server" style="font-style: italic; font-weight: 700; color: #CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="btnViewLeave" runat="server" Font-Bold="True" ForeColor="#009933" OnClick="btnViewLeave_Click" style="font-weight: 700" Text="View Leave" />
                &nbsp;
                <asp:Button ID="btnMakeRequest" runat="server" Font-Bold="True" ForeColor="#009933" OnClick="btnMakeRequest_Click" style="font-weight: 700" Text="Make Request" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style81" colspan="4">
                <asp:Panel ID="Panel1" runat="server">
                    <asp:GridView ID="GVLeave" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="LeaveTypeName" HeaderText="LeaveType" />
                            <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
                            <asp:BoundField DataField="EndDate" HeaderText="End Date" />
                            <asp:BoundField DataField="LeaveStatus" HeaderText="LeaveStatus" />
                              <asp:BoundField DataField="LeaveThresholdBeforeApplication" HeaderText="No of Leave B4 App" />
                             <asp:BoundField DataField="LeaveThreshold" HeaderText="No of Leave Remaining" />
                            <asp:BoundField DataField="DateApplied" HeaderText="DateApplied" />
                            <asp:BoundField DataField="DateGranted" HeaderText="DateGranted" />
                            <asp:BoundField DataField="DisplayName" HeaderText="ApprovedBy/DisApprovedBY" />
                            <asp:BoundField DataField="ReasonForDisapproval" HeaderText="ReasonForDisapproval" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Panel ID="PanelLeaveDetails" Visible="false" runat="server">
                    <table style="width: 100%;">
                    
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">
                <asp:Label ID="LbLeaveEmployeeID" runat="server" Font-Bold="True" Font-Size="14pt" Text="EmployeeNum" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:Label ID="LbEmpLeaveEmpID" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">
                <asp:Label ID="LbLeaveType" runat="server" Font-Bold="True" Font-Size="14pt" Text="Leave Type" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:DropDownList ID="leaveTypeList" runat="server" Width="250px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">
                <asp:Label ID="LbLeaveDesc0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Leave Description" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:TextBox ID="txtLeaveDesc" runat="server" Width="250px" Height="123px" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">
                <asp:Label ID="LbLeaveStartDate1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:DropDownList ID="leaveStartDayList" runat="server" Width="83px">
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="leaveStartMonthList" runat="server" Width="83px">
                    <asp:ListItem Value="00">*Month*</asp:ListItem>
                    <asp:ListItem Value="01">Jan</asp:ListItem>
                    <asp:ListItem Value="02">Feb</asp:ListItem>
                    <asp:ListItem Value="03">March</asp:ListItem>
                    <asp:ListItem Value="04">april</asp:ListItem>
                    <asp:ListItem Value="05">May</asp:ListItem>
                    <asp:ListItem Value="06">June</asp:ListItem>
                    <asp:ListItem Value="07">July</asp:ListItem>
                    <asp:ListItem Value="08">August</asp:ListItem>
                    <asp:ListItem Value="09">Sept</asp:ListItem>
                    <asp:ListItem Value="10">Oct</asp:ListItem>
                    <asp:ListItem Value="11">Nov</asp:ListItem>
                    <asp:ListItem Value="12">Dec</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="leaveStartYearList" runat="server" Width="83px" AutoPostBack="True" OnSelectedIndexChanged="leaveStartYearList_SelectedIndexChanged">
                </asp:DropDownList>
                <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
                --%>&nbsp; 
                <asp:Label ID="lbLeaveSDate" runat="server" style="font-weight: 700; color: #CC3300" Visible="False">Label</asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">
                <asp:Label ID="LbLeaveStartDate2" runat="server" Font-Bold="True" Font-Size="14pt" Text="End Date" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:DropDownList ID="LeaveEndDayList" runat="server" Width="83px">
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="LeaveEndMonthList" runat="server" Width="83px">
                    <asp:ListItem Value="00">*Month*</asp:ListItem>
                    <asp:ListItem Value="01">Jan</asp:ListItem>
                    <asp:ListItem Value="02">Feb</asp:ListItem>
                    <asp:ListItem Value="03">March</asp:ListItem>
                    <asp:ListItem Value="04">april</asp:ListItem>
                    <asp:ListItem Value="05">May</asp:ListItem>
                    <asp:ListItem Value="06">June</asp:ListItem>
                    <asp:ListItem Value="07">July</asp:ListItem>
                    <asp:ListItem Value="08">August</asp:ListItem>
                    <asp:ListItem Value="09">Sept</asp:ListItem>
                    <asp:ListItem Value="10">Oct</asp:ListItem>
                    <asp:ListItem Value="11">Nov</asp:ListItem>
                    <asp:ListItem Value="12">Dec</asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:DropDownList ID="LeaveEndYearList" runat="server" Width="83px" AutoPostBack="True" OnSelectedIndexChanged="LeaveEndYearList_SelectedIndexChanged">
                </asp:DropDownList>
                <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
                --%>&nbsp; 
                <asp:Label ID="lbLeaveEDate" runat="server" style="font-weight: 700; color: #CC3300" Visible="False">Label</asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">
                <asp:Label ID="LbLeaveDurtion" runat="server" Font-Bold="True" Font-Size="14pt" Text="Duration (Number of Days)" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:TextBox ID="txtLeaveDuration" runat="server" Width="250px" AutoPostBack="True" OnTextChanged="txtLeaveDuration_TextChanged"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td class="auto-style102"></td>
            <td class="auto-style105"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style102">
                <asp:Label ID="LbLeaveStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Leave Threshold" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:Label ID="lblLeaveThreshold" runat="server" style="font-weight: 700; color: #CC3300"></asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style102">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">
                <asp:Label ID="Label51" runat="server" style="font-weight: 700; font-size: medium;" Text="Date Apply"></asp:Label>
            </td>
            <td class="auto-style105">
                <asp:Label ID="lblLeaveApplyDate" runat="server" style="font-weight: 700; color: #CC3300"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblLeaveMessage" runat="server" style="font-style: italic; font-weight: 700; color: #CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">
                <asp:Button ID="grantLeaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Request" OnClick="grantLeaveBtn_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
                            
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style101">&nbsp;</td>
            <td class="auto-style105">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

    </table>
</asp:View>

    
    <asp:View ID="ViewSelfAppraisal" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbAppraisal" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Appraisal Management"></asp:Label>
            </td>
        </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96" colspan="4">
                     <asp:Label ID="LbSuccess1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Text="Label" Visible="False"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
                 <td class="auto-style97">&nbsp;<asp:Button ID="conpetencyNextBtn1" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="conpetencyNextBtn_Click" Text="Next" Visible="False" />
                     <asp:Button ID="btnAppraisaTryAgain" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="btnAppraisaTryAgain_Click" Text="TryAgain" Visible="False" />
                 </td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96" colspan="4">
                     <asp:Panel ID="PanelNewAppraisal" runat="server">
                         <table style="width: 100%;">
                        
        <tr>
            <td class="auto-style96">
                <asp:Label ID="LbfstName" runat="server" Font-Bold="True" Text="First Name"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbFirstName" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
            </td>
            <td class="auto-style97">
                <asp:Label ID="LbEmpMidName" runat="server" Font-Bold="True" Text="Middle Name"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbMiddleName" runat="server" Font-Bold="True" ForeColor="#CC0099"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style96"></td>
            <td class="auto-style3"></td>
            <td class="auto-style97"></td>
            <td class="auto-style3"></td>

        </tr>
             <tr>
                 <td class="auto-style96">
                     <asp:Label ID="LbLtName" runat="server" Font-Bold="True" Text="Last Name"></asp:Label>
                 </td>
                 <td class="auto-style3">
                     <asp:Label ID="LbLastName" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
                 </td>
                 <td class="auto-style97">
                     <asp:Label ID="LlbDept" runat="server" Font-Bold="True" Text="Department"></asp:Label>
                 </td>
                 <td class="auto-style3">
                     <asp:Label ID="LbEmpDept" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
        <tr>
            <td class="auto-style96">
                <asp:Label ID="LbPost" runat="server" Font-Bold="True" Text="Position"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEmpPost" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
            </td>
            <td class="auto-style97">
                <asp:Label ID="LbEvaluationPeriod0" runat="server" Font-Bold="True" Text="Evaluation Period"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="evaluationPeriodList" runat="server" Width="200px">
                    <asp:ListItem>***Please Select***</asp:ListItem>
                    <asp:ListItem>2018/2019 Calender Year</asp:ListItem>
                    <asp:ListItem>2017/2018 Calender Year</asp:ListItem>
                    <asp:ListItem>2016/2017 Calender Year</asp:ListItem>
                    <asp:ListItem>2015/2016 Calender Year</asp:ListItem>
                    <asp:ListItem>2014/2015 Calender Year</asp:ListItem>
                    <asp:ListItem>2013/2014 Calender Year</asp:ListItem>
                    <asp:ListItem>2012/2013 Calender Year</asp:ListItem>
                    <asp:ListItem>2011/2012 Calender Year</asp:ListItem>
                    <asp:ListItem>2010/2011 Calender Year</asp:ListItem>
                    <asp:ListItem>2009/2010 Calender Year</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style40"></td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style96">
                <asp:Label ID="Label26" runat="server" Font-Bold="True" Text="Supervisor Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LbEmpSupName" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
            </td>
            <td class="auto-style97">
                <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Start Year of Service"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="appraisalYearList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="appraisalYearList_SelectedIndexChanged" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96">
                     <asp:Label ID="Label68" runat="server" Font-Bold="True" Text="Date"></asp:Label>
                 </td>
                 <td>
                     <asp:Label ID="LbEmpAppraisalDate" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label>
                 </td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style96">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style97">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style43" colspan="4">
                     <asp:Panel ID="PanelSelfAssessment" runat="server" Visible="False">
                         <table style="width:100%;">
                             <tr>
                                 <td>&nbsp;</td>
                                 <td class="auto-style95">&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                          
                              <tr>
                 <td class="auto-style43" colspan="4">
                     <asp:Label ID="LbSelfAppraisal" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Self Assessment"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style95">&nbsp;</td>
                 <td class="auto-style37">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                  <td>&nbsp;</td>
                 <td class="auto-style95">
                     <asp:Label ID="Label28" runat="server" Font-Bold="True" Text="In what areas do I excel in the performance of my duties?"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtExcelPerformance" runat="server" Width="250px"></asp:TextBox>
                  </td>
                
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style95">&nbsp;</td>
                 <td class="auto-style37">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                  <td>&nbsp;</td>

                 <td class="auto-style95">
                     <asp:Label ID="Label29" runat="server" Font-Bold="True" Text="In what areas do I need improvement in the performance of my duties?"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtNeedsImprovemen" runat="server" Width="250px"></asp:TextBox>
                  </td>
                
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style95">&nbsp;</td>
                 <td class="auto-style37">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                  <td>&nbsp;</td>
                 <td class="auto-style95">
                     <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="What steps can I take to improve my work performance?"></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtStepsForImprovement" runat="server" Width="250px"></asp:TextBox>
                  </td>
                
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style95">&nbsp;</td>
                 <td class="auto-style37">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                  <td>&nbsp;</td>
                 <td class="auto-style95">
                     <asp:Label ID="Label31" runat="server" Font-Bold="True" Text="What assistance could my supervisor provide to help me improve my work performance? "></asp:Label>
                 </td>
                 <td>
                     <asp:TextBox ID="txtExctxtNeedsSupervisorAssistance" runat="server" Width="250px"></asp:TextBox>
                  </td>
                
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td class="auto-style95">&nbsp;</td>
                 <td class="auto-style37">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td class="auto-style95">
                                     <asp:Button ID="CompetencyShowBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="CompetencyShowBtn_Click" Text="Show" />
                                 </td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td class="auto-style95">&nbsp;</td>
                                 <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                             </tr>
                             

                             <tr>
                                 <td colspan="4">
                                     <asp:Panel ID="PanelCompetentShow" runat="server" Visible="false">
                                         <table>

                             <tr>
                                 <td class="auto-style36" colspan="4">
                                     <asp:Label ID="LbAppraisal0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Competency Factor Definitions"></asp:Label>
                                 </td>
                             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td class="auto-style95">&nbsp;</td>
                                 <td class="auto-style37">&nbsp;</td>
                                 <td class="auto-style3">&nbsp;</td>
                             </tr>
                             <tr>
                                 <td colspan="4">
                                     <ul>
                                         <li><strong>QUALITY OF WORK:</strong>Work quality refers to effort that consistently achieves desired outcomes with a minimum of avoidable</li>
                                         <li><strong>PRODUCTIVITY:</strong>Consider how the person uses available working time, plans and prioritizes work, sets and accomplishes</li>
                                         <li><strong>KNOWLEDGE OF THE JOB:</strong>Does the employee exhibit job-related knowledge and skill needed to perform the duties and requirements of the position? Does the employee exhibit knowledge of the methods, practices and equipment needed to do the job? Consider knowledge gained through experience, education, and specialized training. Does the employee seek to maintain current knowledge of changes in policies and procedures? Does the employee keep abreast of new developments and major issues in the field? At times, employee may be consulted by others for guidance.</li>
                                         <li><strong>ADAPTABILITY:</strong>How does this employee adjust to changes? Does this employee initiate or recommend beneficial changes in work procedures? Does this employee readily accept new assignments or temporary assignments outside the regular responsibilities? Consider willingness to learn quickly, to adapt to changes in job assignments, methods, personnel, or surroundings.</li>
                                         <li><strong>DEPENDABILITY:</strong>How reliable is the employee in performing work assignments and carrying out instructions? Consider the degree of supervision required and the willingness to take on responsibilities and to be accountable for them.</li>
                                         <li><strong>INITIATIVE AND RESOURCEFULNESS:</strong>Does the employee see things to be done and then take appropriate action without being so directed? Consider ability to contribute, develop and/or carry out new ideas or methods. Consider ability to be a selfstarter, to be creative, to offer suggestions, to anticipate needs and to seek additional tasks and projects to complete as timepermits.</li>
                                         <li><strong>JUDGEMENT AND POLICY COMPLIANCE:</strong>Does employee evaluate situations and make sound decisions, and use reasoning to identify, solve, and prevent problems? Does the employee work in a safe manner, preventing accidents, injuries, andtheft? Does the employee exhibit knowledge of the University’s policies and procedures applicable to his/her assignment? Does the employee exhibit willingness to comply with all reasonable requirements?</li>
                                         <li><strong>INTERPERSONAL RELATIONS AND CUSTOMER SERVICE:</strong>Does the employee exhibit a good level of interpersonal skills and have a good working relationship with most of his/her peers, subordinates, supervisors, customers, and the general public? Consider respect and courtesy the employee shows to others, how the employee’s behavior affects the work area, and the willingness of the employee to accept supervision. Does the employee exhibit appropriate supportive behavior toward the University and its customers? Is the employee unnecessarily involved in trivial disputes and misunderstandings? Does the employee exhibit willingness to work as a team member?</li>
                                         <li><strong>ATTENDANCE AND PUNCTUALITY:</strong>Does the employee report to work on a timely basis and stay on the job? Consider arrival times, observance of time limits for breaks and lunches. Consider patterns of sick leave use, seeking prior approval for vacation, and giving prompt notice to supervisor of absence due to illness or other acceptable reasons.</li>
                                         <li><strong>TEAM WORK:</strong> Does the employee exhibit willingness and ability to work as a team member? Does the employee respond to suggestions and criticism with minimal defensiveness? Consider whether the employee keeps the supervisor and others advised of problems or practical ideas when needed. Consider adherence to the guidelines and regulations that are utilized by the work group, and assisting others on assignments and projects contributing to their success.</li>
                                         <li><strong>COMMUNICATION SKILLS: </strong>To what extent does the employee demonstrate ability to communicate effectively in both oral and written expression with other employees and his/her supervisor? Are issues confronted and resolved constructively? Consider ability to help others with their work problems, and ability to keep others informed of decisions and plans for their own offices as well as policies and procedures of the University.</li>
                                         <li><strong>PLANNING AND ORGANIZATION:</strong>How effective is the employee in setting effective goals, planning ahead and establishing priorities? Consider ability to make the most effective use of time, facilities, material, equipment, skills and other resources. Examine ability to prepare and administer budget effectively.</li>
                                         <li><strong>LEADERSHIP ABILITY:</strong>Is the employee able to get other employees to do willingly and well the duties needed to be accomplished? Consider ability to get the work done while being sensitive to the morale and satisfaction of those doing the work; the ability to function consistently and effectively in an objective and rational manner regardless of pressures.</li>
                                         <li><strong>APPRAISAL AND DEVELOPMENT OF PEOPLE:</strong>Does the supervisor demonstrate ability to select, train and provide opportunities for development of employees by recognizing and facilitating improvement of their abilities? Consider ability to exhibit fairness and impartiality with employees in assigning job duties and objectively appraising work performance.</li>
                                     </ul>
                                 </td>
                             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td class="auto-style95">&nbsp;</td>
                                 <td class="auto-style37">&nbsp;</td>
                                 <td class="auto-style3">&nbsp;</td>
                             </tr>
                                             
                                         </table>
                                     </asp:Panel>
                                 </td>
                             </tr>
                             <tr>
                                 <td colspan="4">
                                     <asp:Label ID="LbConpetency" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Self Appraisal - Competency Rating Key"></asp:Label>
                                 </td>
                             </tr>
                             <tr>
                                 <td>&nbsp;</td>
                                 <td class="auto-style95">&nbsp;</td>
                                 <td class="auto-style37">&nbsp;</td>
                                 <td class="auto-style3">&nbsp;</td>
                             </tr>
                             <tr>
                                 <td colspan="4">
                                     <table style="width:100%;">
                                         <tr>
                                             <td class="auto-style46"></td>
                                             <td class="auto-style47">&nbsp;<asp:Label ID="LbPreformance" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Factors"></asp:Label>
                                             </td>
                                             <td class="auto-style35">&nbsp;<asp:Label ID="LbPreformanceRatingKey" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Rating Key"></asp:Label>
                                             </td>
                                             <td class="auto-style36">
                                                 <asp:Label ID="LbPreformancePoint" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Rating Key"></asp:Label>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbQuality" runat="server" Font-Bold="True" Text="Quality of Work"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="QualityRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="QualityRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtQualityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbProductivity" runat="server" Font-Bold="True" Text="Productivity"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="ProductivityRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ProductivityRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtProductivityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbKnowledge" runat="server" Font-Bold="True" Text="Knowledge of the Job"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="knowledgeRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="knowledgeRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtKnowledgeRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbAdability" runat="server" Font-Bold="True" Text="Adaptability"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="AdaptabilityRatingKey" runat="server" OnSelectedIndexChanged="AdaptabilityRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtAdaptabilityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbDependability" runat="server" Font-Bold="True" Text="Dependability"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="DependabilityRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DependabilityRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtDependabilityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbInitiative" runat="server" Font-Bold="True" Text="Initiative &amp; Resourcefulness"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="InitiativeRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="InitiativeRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtInitiativeRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbPolicyCompliance" runat="server" Font-Bold="True" Text="Judgment &amp; Policy Compliance"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="JudgementRatingKey" runat="server" OnSelectedIndexChanged="JudgementRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtJudgementRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbInterpersonal" runat="server" Font-Bold="True" Text="Interpersonal Relations &amp; Customer Service"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="InterpersonalRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="InterpersonalRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtInterpersonalRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbAttendance" runat="server" Font-Bold="True" Text="Attendance &amp; Punctuality"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="AttendanceRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="AttendanceRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtAttendanceratingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbTeam" runat="server" Font-Bold="True" Text="Team Work"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="TeamRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="TeamRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtTeamRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbCommunication" runat="server" Font-Bold="True" Text="Communication Skills"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="CommSkillRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CommSkillRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtCommSkillRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbPlanning" runat="server" Font-Bold="True" Text="Planning &amp; Organization"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="planningRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="planningRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtPlanningPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbLeadership" runat="server" Font-Bold="True" Text="Leadership Ability"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="leadershipRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="leadershipRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtLeadershipPoint" runat="server" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbDevelopment" runat="server" Font-Bold="True" Text="Appraisal &amp; Development of People"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:DropDownList ID="developmentRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="developmentRatingKey_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtDevelopmentRatingPoint" runat="server" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46" colspan="5">
                                                 <asp:Label ID="LbGoalAdded1" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#FF0066" Text="Click 'Sum' button to see total point before saving"></asp:Label>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">
                                                 <asp:Button ID="competencySumBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="competencySumBtn_Click" Text="Sum" />
                                             </td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">&nbsp;</td>
                                             <td class="auto-style45">&nbsp;</td>
                                             <td class="auto-style39">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style46">&nbsp;</td>
                                             <td class="auto-style47">
                                                 <asp:Label ID="LbPoint" runat="server" Font-Bold="True" Text="Appraisal Percentage/ Total Points" Visible="False"></asp:Label>
                                             </td>
                                             <td class="auto-style45">
                                                 <asp:TextBox ID="txtAppraisalpercentage" runat="server" Visible="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style39">
                                                 <asp:TextBox ID="txtTotalPoint" runat="server" EnableTheming="False" Visible="False"></asp:TextBox>
                                             </td>
                                             <td class="auto-style3"></td>
                                         </tr>
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td>&nbsp;</td>
                                             <td class="auto-style37">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td colspan="5">
                                                 <asp:Label ID="LbSuccess" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Text="Label" Visible="False"></asp:Label>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td>&nbsp;</td>
                                             <td class="auto-style37">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td>
                                                 <asp:Button ID="competencySaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="competencySaveBtn_Click" Text="Save" Visible="False" />
                                             </td>
                                             <td class="auto-style37">
                                                 <asp:Button ID="conpetencyNextBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="conpetencyNextBtn_Click" Text="Next" Visible="False" />
                                             </td>
                                             <td class="auto-style3">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td>&nbsp;</td>
                                             <td>&nbsp;</td>
                                             <td class="auto-style37">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                             <td class="auto-style3">&nbsp;</td>
                                         </tr>
                                     </table>
                                 </td>
                             </tr>
                         </table>
                     </asp:Panel>
                 </td>
             </tr>

        <tr>
            <td class="auto-style96">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style97">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                                 
                         </table>
                     </asp:Panel>
                 </td>
             </tr>
    </table>
    </asp:View>
   
<asp:View ID="ViewAppraisalPerformance" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
               <tr>
            <td class="auto-style43" colspan="4">
                <asp:Label ID="Label57" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Goal"></asp:Label>
                   </td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">Employees should develop and suggest goals for the supervisor and employee to discuss. Both the supervisor and employee should agree on the goals. Goals may be work-related or developmental; the goal should be limited to a one-year time frame. Enter the goals in order of importance. The following questions will assist the employee and supervisor:<br /> </td>
        </tr>
        <tr>
            <td class="auto-style43">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">&nbsp;<ol>
                    <li>What specific tasks, projects, or activities need to be accomplished?
                        </li>
                    <li>What changes in work performance are required or desired?</li>
                    <li> What training or work experience would be helpful or developmental?</li>
                </ol>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="viewPreYrGoalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="View Last Year Goals" OnClick="viewPreYrGoalBtn_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style43">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>

              <tr>
                 <td class="auto-style43" colspan="4">
                     <asp:Panel ID="PanelPreYearGoal"  Visible="false" runat="server">

                         <table style="width: 100%;">
                           
                     
             <tr>
                 <td class="auto-style43" colspan="4">
                     <asp:Label ID="Label58" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Previous Year Goal- to be Reviewed for Current Performance Appraisal  "></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style43">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style37">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style43" colspan="4">
                     &nbsp;
                     <asp:GridView ID="GViewPreYearGoalList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                         <Columns>
                             <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                             <asp:BoundField DataField="GoalObjectives" HeaderText="GoalObj" />
                             <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                             <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion date" />
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalEmpID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalSupID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SupervisorID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalHRID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.HRID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
                             <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalAppraisalID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AppraisalID_FK") %>' Visible="false"></asp:TextBox></ItemTemplate></asp:TemplateField>
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
            <td class="auto-style43">
                <%--<table style="width:100%;">
                    <tr>
                        <td class="auto-style23"></td>
                        <td class="auto-style25">
                            <asp:Label ID="Label59" runat="server" Font-Bold="True" Text="Goal Description"></asp:Label>
                        </td>
                        <td class="auto-style29">
                            <textarea id="txtPreYearGoalDesc" cols="20" name="S2" rows="2"></textarea></td>
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31"></td>
                        <td class="auto-style31">
                            <asp:Label ID="Label60" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved"></asp:Label>
                        </td>
                        <td>
                            <textarea id="txtPreYearGoalObjective" cols="20" name="S3" rows="2"></textarea></td>
                        <td></td>
                    </tr>
                     <tr>
                         <td class="auto-style31">&nbsp;</td>
                         <td class="auto-style32">&nbsp;</td>
                         <td class="auto-style30">&nbsp;</td>
                         <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="Label61" runat="server" Font-Bold="True" Text="Evaluation Point"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="Label62" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>--%>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                   
                         </table>
                     </asp:Panel>
                         
                      </td>
             </tr>
                     
                      </td>
             </tr>
               <tr>
                   <td class="auto-style43">&nbsp;</td>
                   <td>&nbsp;</td>
                   <td class="auto-style37">
                       <asp:Button ID="AddNxtYrGoalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Add Next Year Goals" OnClick="AddNxtYrGoalBtn_Click" />
                   </td>
                   <td class="auto-style3">&nbsp;</td>
               </tr>
               <%--<tr>
                   <td colspan="4">
                       <table style="width:100%;">
                    <tr>
                        <td class="auto-style23"></td>
                        <td class="auto-style25">
                            <asp:Label ID="Label59" runat="server" Font-Bold="True" Text="Goal Description"></asp:Label>
                        </td>
                        <td class="auto-style29">
                            <textarea id="txtPreYearGoalDesc" cols="20" name="S2" rows="2"></textarea></td>
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31"></td>
                        <td class="auto-style31">
                            <asp:Label ID="Label60" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved"></asp:Label>
                        </td>
                        <td>
                            <textarea id="txtPreYearGoalObjective" cols="20" name="S3" rows="2"></textarea></td>
                        <td></td>
                    </tr>
                     <tr>
                         <td class="auto-style31">&nbsp;</td>
                         <td class="auto-style32">&nbsp;</td>
                         <td class="auto-style30">&nbsp;</td>
                         <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="Label61" runat="server" Font-Bold="True" Text="Evaluation Point"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="Label62" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>--%>

             <tr>
                   <td colspan="4">
                       <asp:Panel ID="PanelNextYearGoal" Visible="false" runat="server">
                           <table style="width: 100%;">
                               <tr>
                                   <td>&nbsp;</td>
                                   <td>&nbsp;</td>
                                   <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                               </tr>
        <tr>
            <td colspan="4">&nbsp; <table style="width:100%;">
                    <tr>
                        <td class="auto-style23" colspan="4">
                            <asp:Label ID="Label63" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Next Year Goal- to be Reviewed at Next Year's  Performance Appraisal  "></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style93">&nbsp;</td>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style93">&nbsp;</td>
                        <td class="auto-style29">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23"></td>
                        <td class="auto-style93">
                            <asp:Label ID="Label64" runat="server" Font-Bold="True" Font-Size="14pt" Text="Goal Description"></asp:Label>
                        </td>
                        <td class="auto-style29">
                            <asp:TextBox ID="txtNxtYearGoalDesc" Width="250" Height="50" runat="server"></asp:TextBox>
                            
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">
                            <asp:Label ID="Label65" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved"></asp:Label>
                        </td>
                        <td class="auto-style30">
                             <asp:TextBox ID="txtNxtYearGoalObjective" Width="250" Height="50" runat="server"></asp:TextBox>
                            
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">
                            <asp:Label ID="Label66" runat="server" Font-Bold="True" Text="Evaluation Point"></asp:Label>
                        </td>
                        <td class="auto-style30">
                              <asp:TextBox ID="txtEvalPoint" Width="250" Height="50" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">
                            <asp:Label ID="Label67" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style30">
                            <asp:DropDownList ID="goalNxtYrDayList" runat="server">
                            </asp:DropDownList>
                            &nbsp;<asp:DropDownList ID="goalNxtYrMonthList" runat="server">
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
                                <asp:ListItem>Oct</asp:ListItem>
                                <asp:ListItem>Nov</asp:ListItem>
                                <asp:ListItem>Dec</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;
                            <asp:DropDownList ID="goalNxtYrYearList" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:Label ID="LbGoalAdded0" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#FF0066" Text="Click 'Add' button to add more goals before saving"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">
                            <asp:Button ID="goalAddBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Add" OnClick="goalAddBtn_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:GridView ID="GViewNextYearGoalList" runat="server" Visible="False" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                    <asp:BoundField DataField="GoalObjectives" HeaderText="GoalObj" />
                                    <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                    <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion date" />
                                    <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                                     <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalSupID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.SupervisorID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                                        <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalHRID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.HRID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                                     <asp:TemplateField><ItemTemplate><asp:TextBox ID="c" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.AppraisalID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>

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
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:Label ID="LbGoalAdded" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:GridView ID="GViewNextGoalLog" runat="server" Visible="False" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                    <asp:BoundField DataField="GoalObjectives" HeaderText="GoalObj" />
                                    <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                    <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion date" />
                                     <asp:BoundField DataField="SentBy" HeaderText="SentBy" />
                                  
                                    <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                                     <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalSupID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.SupervisorID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                                        <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalHRID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.HRID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                                     <asp:TemplateField><ItemTemplate><asp:TextBox ID="txtNextGoalAppraisalID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.AppraisalID_FK") %>'></asp:TextBox></ItemTemplate></asp:TemplateField>
                                   <%-- <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.GoalID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>

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
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:Label ID="LbGoalLog" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">
                            <asp:Button ID="goalBackBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="appraisalBackBtn_Click" Text="Back" Visible="False" />
                        </td>
                        <td class="auto-style30">
                            <asp:Button ID="goalsaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Save" OnClick="goalsaveBtn_Click" Visible="False" />
                        </td>
                        <td>
                            <asp:Button ID="goalFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Finish" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style94">&nbsp;</td>
                        <td class="auto-style30">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table></td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
                                </table>
                       </asp:Panel>

                   </td>
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
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style98" colspan="4">
                <asp:LinkButton ID="LinkBtnRequestTransfer" runat="server" Font-Bold="True" OnClick="LinkBtnRequestTransfer_Click">Request for Transfer</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkBtnTransferHistory" runat="server" Font-Bold="True" OnClick="LinkBtnTransferHistory_Click">View Your History</asp:LinkButton>
            </td>
        </tr>
         <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style98" colspan="4">
                  <asp:Label ID="LbTransferSuccessful1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Visible="False"></asp:Label>
        
            </td>
            
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98" colspan="4">
                <asp:Button ID="btnTransferFinish" runat="server" Visible="false" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Finish" OnClick="btnTransferFinish_Click" />
                <asp:Button ID="btnTransferTryAgain" runat="server" Visible="false" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="TryAgain" OnClick="btnTransferTryAgain_Click" />
            </td>
           
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98" colspan="4">
                <asp:Panel ID="PanelTransfer" Visible="false" runat="server">
                    <table style="width: 100%;">
                    
        <tr>
            <td class="auto-style86" colspan="4">

                <p> This is Transfer Module, please follow the instruction below to transfer employee</p>
                    <ul>
                        <li>Select the Type of Transfer</li>
                        <li>State the reason for requesting for transfer </li>
                        <li>Select select the location you wish to be transfered to</li>
                    </ul>
                   
            </td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbPreWokLoc" runat="server" Font-Bold="True" Text="Current Location" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:Label ID="LbTransferPreWorkLoc" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">
                &nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbPreDept" runat="server" Font-Bold="True" Text="Dept" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:Label ID="LbTransferPreDept" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">
                &nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3"></td>
        </tr>

         <tr>
             <td class="auto-style99">&nbsp;</td>
             <td class="auto-style89">
                 <asp:Label ID="LbNewWokLoc0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Desire Location"></asp:Label>
             </td>
             <td class="auto-style91">
                 <asp:DropDownList ID="transferNewWokLocList" runat="server" Width="250px">
                 </asp:DropDownList>
             </td>
             <td class="auto-style3">&nbsp;</td>
        </tr>

       
        <tr>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">
                <asp:Label ID="LbPreDept0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Transfer Type"></asp:Label>
            </td>
            <td class="auto-style91">
                <asp:DropDownList ID="transferTypeList" runat="server" Width="250px">
                    <asp:ListItem>***Please select***</asp:ListItem>
                    <asp:ListItem>Self Request</asp:ListItem>
                    <asp:ListItem>Job Nature</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbNewWokLoc1" runat="server" Font-Bold="True" Font-Size="14pt" Text="Transfer Reason"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:TextBox ID="txtTransferReason" runat="server" Height="50px" Width="250px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">
                <asp:Label ID="LbDateTransfered" runat="server" Font-Bold="True" Font-Size="14pt" Text="Request Date"></asp:Label>
            </td>
            <td class="auto-style90">
                <asp:Label ID="LbRequestDate" runat="server" Enabled="False" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td class="auto-style90">
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style99">&nbsp;</td>
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
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">
                <asp:Button ID="RequestBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Request" OnClick="RequestBtn_Click" />
            </td>
            <td class="auto-style91">
                <asp:Button ID="TransferFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Finish" />
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">
                &nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style99">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style91">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98"></td>
            <td class="auto-style88"></td>
            <td class="auto-style90">
                &nbsp; &nbsp;
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
                          
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:View>

<asp:View ID="ViewTransferHistory" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Transfer History"></asp:Label>
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
                    <asp:Label ID="Label38" runat="server" Font-Bold="True" Font-Size="14pt" Text="Your Movement Records"></asp:Label>
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
            <td class="auto-style124" colspan="4">
                <asp:Panel ID="Panel2" runat="server">
                    <table style="width:100%;">
                        <tr>
                            <td colspan="3">
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
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtTranferID_FK" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferID_FK")%>' Visible="false"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtTranferLogID" runat="server" Text='<%# DataBinder.Eval(Container,"DataItem.TransferLogID")%>' Visible="false"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
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
            <td class="auto-style123">&nbsp;</td>
            <td class="auto-style120">&nbsp;</td>
            <td class="auto-style122">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
</asp:View>
<asp:View ID="ViewLandingPage" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style117" colspan="4">
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
                 <asp:Label ID="LbLandingPage" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Thank you!"></asp:Label>
     
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

</asp:MultiView>
                     

           </td>
        
    </tr>
    <tr>
        <td class="auto-style59"></td>
        <td>
            <asp:LinkButton ID="EmpHome" runat="server" Font-Size="13pt" OnClick="EmpHome_Click">Home</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="EmpBioDataLinkBtn" runat="server" Font-Size="13pt" OnClick="EmpBioDataLinkBtn_Click">Profile</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="EmpQualifLinkBtn" runat="server" Font-Size="13pt" OnClick="EmpQualifLinkBtn_Click">Qualifications</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="EmpCertifLinkBtn" runat="server" Font-Size="13pt" OnClick="EmpCertifLinkBtn_Click">Certifications</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="docLinkBtn" runat="server" OnClick="docLinkBtn_Click">Docments </asp:LinkButton>
&nbsp;<asp:LinkButton ID="EmpRefreeLinkBtn" runat="server" Font-Size="13pt" OnClick="EmpRefreeLinkBtn_Click">Refree</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="EmpQueryLinkBtn" runat="server" Font-Size="13pt" OnClick="EmpQueryLinkBtn_Click">Query</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="EmpAppraisalLinkBtn" runat="server" Font-Size="13pt" OnClick="EmpAppraisalLinkBtn_Click">Appraisal</asp:LinkButton>
        </td>
    </tr>
</table>