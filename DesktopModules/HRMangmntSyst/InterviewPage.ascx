<%@ Control Language="C#" AutoEventWireup="true" CodeFile="InterviewPage.ascx.cs" Inherits="ola.HRMangmntSyst.InterviewPage" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    .auto-style18 {
        width: 919px;
        margin-left: 80px;
    }
    .auto-style33 {
        height: 23px;
        width: 123px;
    }
    .auto-style37 {
    }
    .auto-style44 {
        width: 601px;
    }
    .auto-style45 {
        height: 23px;
        width: 352px;
    }
    .auto-style46 {
    }
    .auto-style47 {
        width: 352px;
    }
    .auto-style48 {
        height: 177px;
    }
    .auto-style50 {
        color: #006699;
    }
    .auto-style51 {
        color: #333333;
    }
    .auto-style52 {
        list-style-type: square;
    }
    .auto-style53 {
        color: #CC3300;
    }
    .auto-style54 {
        color: #CC3300;
        font-size: medium;
    }
    .auto-style55 {
        height: 23px;
        color: #CC3300;
    }
    .auto-style56 {
    }
    .auto-style58 {
        width: 185px;
    }
    .auto-style59 {
    }
    .auto-style61 {
        height: 23px;
        }
    .auto-style62 {
        width: 919px;
        margin-left: 80px;
        height: 23px;
    }
    .auto-style63 {
        width: 445px;
    }
    .auto-style64 {
        height: 23px;
    }
    .auto-style65 {
    }
    .auto-style66 {
        width: 20%;
    }
    .auto-style67 {
        width: 27%;
    }
    .auto-style68 {
        width: 30%;
    }
    .auto-style69 {
    }
    .auto-style70 {
        height: 23px;
    }
    .auto-style71 {
        height: 99px;
    }
    .auto-style72 {
    }
    .auto-style73 {
        width: 196px;
        height: 23px;
    }
    .auto-style74 {
        height: 26px;
    }
    .auto-style82 {
        width: 173px;
    }
    .auto-style83 {
    }
    .auto-style84 {
        width: 76px;
    }
    .auto-style85 {
        width: 376px;
    }
    .auto-style86 {
    }
    .auto-style87 {
        width: 207px;
    }
    .auto-style88 {
        width: 257px;
    }
    .auto-style89 {
        height: 26px;
        width: 257px;
    }
    .auto-style90 {
        height: 23px;
        width: 257px;
    }
</style>



<table style="width:100%;">
    <tr>
        <td valign="top"  style="width: 150px"><table><tr><td>
            <asp:Button ID="btnSendIniteMenu" runat="server" Height="35px" OnClick="btnSendIniteMenu_Click" style="color: #CC3300; font-size: medium; font-weight: 700" Text=" Send Invite" Width="173px" />
            </td></tr>
            <tr><td>
                <asp:Button ID="btnInterwierDecision" runat="server" Height="35px" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Interviewer Decision" Width="173px" OnClick="btnInterwierDecision_Click" Font-Bold="True" Font-Size="14pt" />
                </td></tr>
            <tr><td>
                <asp:Button ID="btnManagementDecision" runat="server" Height="35px" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Management Decision" Width="176px" OnClick="btnManagementDecision_Click" Font-Bold="True" Font-Size="14pt" />
                </td></tr>
            <tr><td>
                <asp:Button ID="btnSendOfferMenu" runat="server" Height="35px" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Send Offer" Width="173px" OnClick="btnSendOfferMenu_Click" />
                </td></tr>
            <tr><td>
                <asp:Button ID="btnReportMenu" runat="server" Height="35px" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Report" Width="173px" OnClick="btnReportMenu_Click" />
                </td></tr><tr><td></td></tr>
                         </table></td>
        <td valign="top"><asp:MultiView ID="MViewInterview" runat="server">
    <asp:View ID="ViewWelcomePage" runat="server">
        <table style="border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text=" Welcome to Interview Session, Please click the action you want to perform" style="font-size: medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style18">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style62">
                    </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

             <tr>
                <td></td>
                <td class="auto-style18">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>

    <asp:View ID="ViewSendInvite" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="LbWelcom1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="ShortList Applicants"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <ul class="auto-style52">
                        <li>Select position to view all the applicants for that particular position.</li>
                        <li>You&nbsp; can view more details about a particular applicant by&nbsp; clicking on <span class="auto-style53">view</span>.</li>
                        <li>You can shortlist an applicant for interview by&nbsp; checking the check box.</li>
                        <li>You can also send invite for interview</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="auto-style87">&nbsp;</td>
                <td>
                    <asp:Label ID="Label26" runat="server" style="font-weight: 700" Text="Department" Font-Size="14pt"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddShortListAvailDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAvailableDept_SelectedIndexChanged" Width="250px">
                        <asp:ListItem>--Please  Select--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style87">&nbsp;&nbsp; &nbsp;</td>
                <td></td>
                <td></td>
            </tr>
              <tr>
                  <td class="auto-style87">&nbsp;</td>
                  <td>
                      <asp:Label ID="Label75" runat="server" Font-Size="14pt" style="font-weight: 700" Text="Available Positions"></asp:Label>
                  </td>
                  <td>
                      <asp:DropDownList ID="ddShotListAvailPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddShotListAvailPosition_SelectedIndexChanged" Width="250px">
                          <asp:ListItem>--Please  Select--</asp:ListItem>
                      </asp:DropDownList>
                  </td>
            </tr>
              <tr>
                  <td class="auto-style83" colspan="3">
                      <asp:Label ID="lblInviteSend1" runat="server" style="font-style: italic; color: #009900"></asp:Label>
                  </td>
            </tr>
            <tr>
                <td class="auto-style87">&nbsp;</td>
                <td>
                    <asp:Button ID="btnShortListTryAgain" runat="server" Height="35px" OnClick="btnShortListTryAgain_Click" style="color: #CC3300; font-size: medium; font-weight: 700" Text="Try Again" Visible="False" />
                    <asp:Button ID="btnShortListFinish" runat="server" Height="35px" style="color: #CC3300; font-size: medium; font-weight: 700" Text=" Finish" Visible="False" OnClick="btnShortListFinish_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style37" colspan="3">
                    <asp:Panel ID="PanelShortListForInterview" Visible="false" runat="server">
                        <table style="width:100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
              <tr>
                <td class="auto-style37">
                    <asp:Label ID="lblInterMsg0" runat="server" Text="Label" Visible="False"></asp:Label>
                  </td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GViewAllApplicantsList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False" OnRowCommand="GViewAllApplicantsList_RowCommand" >
                       
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ApplicantNum" HeaderText="Applicant No" />
                            <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position AppliedFor" />
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                            <asp:BoundField DataField="MiiddleName" HeaderText="Middle Name" />
                            <asp:BoundField DataField="LastName" HeaderText="LastName" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:BoundField DataField="MaritalStatus" HeaderText="Marital Status" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="View" Text="View" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' ></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Short List">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField >
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBox2" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' runat="server" Visible="false"></asp:TextBox>
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
                <td class="auto-style37">
                    <asp:Label ID="lblShortlist" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblInviteSend" runat="server" style="font-style: italic; color: #009900"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style37" style="width: 120px">
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Panel ID="PanelInterviewParameter" runat="server" Visible="False">
                        <table style="width: 60%; margin-left:100px;">
                            <tr>
                                <td class="auto-style55" colspan="3"><strong>Set interview parameters</strong></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label53" runat="server" style="font-weight: 700" Text="Interview Date:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlInterviewDay" runat="server">
                                    </asp:DropDownList>
                                    &nbsp;
                                    <asp:DropDownList ID="ddlInterviewMonth" runat="server">
                                        <asp:ListItem Value="00">Month</asp:ListItem>
                                        <asp:ListItem Value="01">Jan</asp:ListItem>
                                        <asp:ListItem Value="02">Feb</asp:ListItem>
                                        <asp:ListItem Value="03">Mar</asp:ListItem>
                                        <asp:ListItem Value="04">Apr</asp:ListItem>
                                        <asp:ListItem Value="05">May</asp:ListItem>
                                        <asp:ListItem Value="06">Jun</asp:ListItem>
                                        <asp:ListItem Value="07">Jul</asp:ListItem>
                                        <asp:ListItem Value="08">Aug</asp:ListItem>
                                        <asp:ListItem Value="09">Sep</asp:ListItem>
                                        <asp:ListItem Value="10">Oct</asp:ListItem>
                                        <asp:ListItem Value="11">Nov</asp:ListItem>
                                        <asp:ListItem Value="12">Dec</asp:ListItem>
                                    </asp:DropDownList>
                                    &nbsp;<asp:DropDownList ID="ddlInterviewYear" runat="server">
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
                                    <asp:Label ID="Label54" runat="server" style="font-weight: 700" Text="Time"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtInterviewTime" runat="server" Width="341px"></asp:TextBox>
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
                                    <asp:Label ID="Label55" runat="server" style="font-weight: 700" Text="Venue:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtInterviewVenue" runat="server" Width="363px"></asp:TextBox>
                                </td>
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
                                    <asp:Button ID="btnShotlistAndSendingInvite" runat="server" OnClick="btnShotlistAndSendingInvite_Click" style="color: #CC3300; font-weight: 700; margin-bottom: 0px;" Text="Shorlist and send Invite" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style37" colspan="3">
                    <asp:Panel ID="PanelApplicantDetails" runat="server" Visible="False">
                        <table style="border: 1px solid #990033; width: 80%;  margin-left:75px; ">
                            <tr>
                                <td class="auto-style85" colspan="5"><strong class="auto-style54"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Applicant Information</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style48" colspan="5">
                                    <asp:Image ID="ImagePassport" runat="server" BorderColor="#CC3300" BorderWidth="3px" Height="167px" ImageAlign="Middle" Width="171px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Dept applied to:</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblDeptAppliedTo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Applicant No:</strong></td>
                                <td>
                                    <asp:Label ID="lblApplicantNum" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Position applied for:</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblPositionAppliedFor" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong>Nationality</strong></td>
                                <td>
                                    <asp:Label ID="lblNationality" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>First Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblFirstName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong style="color: #333333">State of Origin</strong></td>
                                <td>
                                    <asp:Label ID="lblStateofOrigin" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Middle Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblMiddleName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">Senatorial District</strong></td>
                                <td>
                                    <asp:Label ID="lblSenDistrict" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Last Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblLastName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>LGA</strong></td>
                                <td>
                                    <asp:Label ID="lblLGA" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Gender</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblGender" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Home Town</strong></td>
                                <td>
                                    <asp:Label ID="lblHomeTown" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Marital Status</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblMaritalStatus" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Email</strong></td>
                                <td>
                                    <asp:Label ID="lblEmail" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>DOB</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblDOB" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">PhoneNo</strong></td>
                                <td>
                                    <asp:Label ID="lblPhoneNo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Age</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblAge" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>ContactAddress</strong></td>
                                <td>
                                    <asp:Label ID="lblContactAddress" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><em><strong>Qualification</strong></em></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="InstitutionName" HeaderText="Institution" />
                                            <asp:BoundField DataField="Course" HeaderText="Course" />
                                            <asp:BoundField DataField="QualificationType" HeaderText="Qualification" />
                                            <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58"></td>
                                <td class="auto-style53"></td>
                                <td class="auto-style52"></td>
                                <td class="auto-style54"></td>
                                <td class="auto-style52"></td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Professional Qualification</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewProfQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CertificationName" HeaderText="Certification" />
                                            <asp:BoundField DataField="Stage" HeaderText="Stage" />
                                            <asp:BoundField DataField="CertYear" HeaderText="Year Obtained" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Work Experience</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewWrkExp" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                                            <asp:BoundField DataField="PositionHeld" HeaderText="Position Held" />
                                            <asp:BoundField DataField="JobDescriprtion" HeaderText="Job Descriprtion" />
                                            <asp:BoundField DataField="SalaryReceived" HeaderText="Salary Received" />
                                            <asp:BoundField DataField="StartYear" HeaderText="Start Year" />
                                            <asp:BoundField DataField="EndYear" HeaderText="End Year" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50"><strong><em>Uploaded Documents</em></strong></td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GViewDocument" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Document Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Document" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnShotListClose" runat="server" OnClick="btnShotListClose_Click" style="font-weight: 700; color: #CC3300" Text="Close" Visible="False" Width="77px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style37">
                    &nbsp;</td>
                        <td>&nbsp;</td>
                <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style37" colspan="3">
                                <asp:Panel ID="Panel1" runat="server" Visible="False">
                                    <table style="width:75%; margin-left:50px">
                                        <tr>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td valign="right">
                                                <asp:Label ID="Label42" runat="server" Text="Neetbeet Technologies Limited"></asp:Label>
                                                <br />
                                                <asp:Label ID="Label43" runat="server" Text="13, Adekunbi Cresent , Off Toyin Street, Ikeja, Lagos."></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46">&nbsp;</td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style33">&nbsp;</td>
                                            <td class="auto-style45"></td>
                                            <td class="auto-style1"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46">Dear
                                                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                                            </td>
                                            <td class="auto-style47">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style46" colspan="3">
                                                <table style="width: 90%;">
                                                    <tr>
                                                        <td>
                                                            <center>
                                                                <b><u>Invitation to Interview&nbsp; </u></b>
                                                            </center>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                <p>
                                                    In response&nbsp; to your application&nbsp;&nbsp; for the post of
                                                    <asp:Label ID="lblPositionApplied" runat="server" style="color: #CC3300; font-weight: 700" Text="Label"></asp:Label>
                                                    &nbsp; at Neetbeet Technogies Limited, we are please to invite you for interview as schedule below:
                                                    <br />
                                                    <ul>
                                                        <li>Date:&nbsp;&nbsp;
                                                            <asp:Label ID="Label47" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                                        </li>
                                                        <li>Time:&nbsp;&nbsp;
                                                            <asp:Label ID="Label48" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                                        </li>
                                                        <li>Venue:&nbsp;
                                                            <asp:Label ID="Label49" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                                        </li>
                                                    </ul>
                                                    <p>
                                                        <asp:Label ID="lblApplicantEmail" runat="server" Text="Label"></asp:Label>
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
                                            <td class="auto-style47">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                    </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style46">&nbsp;</td>
                                        <td class="auto-style44">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                    <tr>
                        <td class="auto-style37">&nbsp;</td>
                        <td>
                            &nbsp;</td>
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
                    </table>
    </asp:View>

   

    <asp:View ID="ViewInterviewerDecision" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
            <tr>
                <td colspan="3" class="auto-style1">
                    <asp:Label ID="LbWelcom2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Interviewer Decision"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style71">
                    <ul class="auto-style52">
                        <li>Select position to view all&nbsp; applicants shortlisted for that particular position.</li>
                        <li>You&nbsp; can view more details about a particular applicant by&nbsp; clicking on view.</li>
                        <li>To hire applicants:</li>
                        <li>&nbsp;Select&nbsp; the check box for the applicant(s)</li>
                        <li>Set the employment parameters</li>
                        <li>click on hire button</li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>
                    <asp:Label ID="Label76" runat="server" Font-Bold="True" Font-Size="14pt" style="font-weight: 700" Text="Dept Applied To:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddInterViewDecisionAvailDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddInterViewDecisionAvailDept_SelectedIndexChanged" Width="215px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>
                    <asp:Label ID="Label56" runat="server" style="font-weight: 700" Text="Positions Applied For" Font-Bold="True" Font-Size="14pt"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddInterviewDecisionAvailPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddInterviewDecisionAvailPosition_SelectedIndexChanged" Width="215px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <asp:Label ID="lblhire1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#669900" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnInterviewerDecisionFinish" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" style="font-size: small; color: #CC3300" Text="Finish" Visible="False" OnClick="btnInterviewerDecisionFinish_Click" />
                    <asp:Button ID="btnInterviewerDecisionTryAgain" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="btnInterviewerDecisionTryAgain_Click" style="font-size: small; color: #CC3300" Text="Try Again" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style86" colspan="3">
                    <asp:Panel ID="PanelHire" runat="server" Visible="False">
                        <table style="width:100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
                            
            <tr>
                <td class="auto-style61" colspan="2">
                    <asp:Label ID="Label57" runat="server" style="font-weight: 700; color: #CC3300" Text="List of shortlisted Applicants" Visible="False"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="lblhire" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style59" colspan="3">
                    <asp:GridView ID="GVShortlistedApplicants" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVShortlistedApplicants_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="ApplicantNum" HeaderText="Applicant No" />
                            <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position Applied For" />
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                            <asp:BoundField DataField="LastName" HeaderText="LastName" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                            <asp:BoundField DataField="ApplicationStatus" HeaderText="Application Status" />
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton" runat="server" CausesValidation="false" CommandName="View" Text="View" CommandArgument='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' ></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Hire">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="TextBoxApplicantID" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.ApplicantID") %>' runat="server"></asp:TextBox>
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
                <td class="auto-style86">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td colspan="2">
                    <asp:Panel ID="PanelEmploymentParameter" runat="server" Visible="False">
                        <table style="border: medium solid #CC3300; width: 65%; margin-left:30px;">
                            <tr>
                                <td class="auto-style55" colspan="3"><strong>Set&nbsp;&nbsp; Employment Parameter</strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Department</strong>:</td>
                                <td>&nbsp;<asp:DropDownList ID="ddlDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDept_SelectedIndexChanged" Width="215px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Approved</strong> <strong>Position:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlApprovePosition" runat="server" Width="215px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Level:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlLevel" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlLevel_SelectedIndexChanged" Width="215px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Salary:</strong></td>
                                <td>
                                    <asp:Label ID="lblSalary" runat="server" style="color: #CC3300; font-weight: 700"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Work</strong> <strong>Location:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlWorkLocation" runat="server" Width="215px">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82"><strong>Resumption Date:</strong></td>
                                <td>
                                    <asp:DropDownList ID="ddlDay" runat="server">
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="ddlMonth" runat="server">
                                        <asp:ListItem Value="00">Month</asp:ListItem>
                                        <asp:ListItem Value="01">Jan</asp:ListItem>
                                        <asp:ListItem Value="02">Feb</asp:ListItem>
                                        <asp:ListItem Value="03">Mar</asp:ListItem>
                                        <asp:ListItem Value="04">Apr</asp:ListItem>
                                        <asp:ListItem Value="05">May</asp:ListItem>
                                        <asp:ListItem Value="06">Jun</asp:ListItem>
                                        <asp:ListItem Value="07">Jul</asp:ListItem>
                                        <asp:ListItem Value="08">Aug</asp:ListItem>
                                        <asp:ListItem Value="09">Sep</asp:ListItem>
                                        <asp:ListItem Value="10">Oct</asp:ListItem>
                                        <asp:ListItem Value="11">Nov</asp:ListItem>
                                        <asp:ListItem Value="12">Dec</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="ddlYear" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style82">&nbsp;</td>
                                <td>
                                    <asp:Button ID="btnHireApplicantSave" runat="server" OnClick="btnHireApplicantSave_Click" style="font-weight: 700" Text="Hire Applicants" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblNoShortlistedApplicant" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="3"><asp:Panel ID="PanelShortListViewAppDetails" runat="server" Visible="False">
                        <table style="border: 1px solid #990033; width: 80%;  margin-left:75px; ">
                            <tr>
                                <td class="auto-style85" colspan="5"><strong class="auto-style54"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Applicant Information</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style48" colspan="5">
                                    <asp:Image ID="Image1" runat="server" BorderColor="#CC3300" BorderWidth="3px" Height="167px" ImageAlign="Middle" Width="171px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Dept applied to:</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LbShortListAvailDept" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Applicant No:</strong></td>
                                <td>
                                    <asp:Label ID="LabelApplicantNo" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Position applied for</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LbShotListAvailPosition" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong>Nationality</strong></td>
                                <td>
                                    <asp:Label ID="LabelNationality" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>First Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelFName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong style="color: #333333">State of Origin</strong></td>
                                <td>
                                    <asp:Label ID="LbState" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Middle Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelMidName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">S</strong>enatorial District</td>
                                <td>
                                    <asp:Label ID="lbSenDist" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Last Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelLName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>LGA</strong></td>
                                <td>
                                    <asp:Label ID="LabelLga" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Gender</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelGender" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Home Town</strong></td>
                                <td>
                                    <asp:Label ID="LabelHomeTown" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Marital Status</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelMaritalStatus" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Email</strong></td>
                                <td>
                                    <asp:Label ID="LabelEmail" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>DOB</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelDob" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">PhoneNo</strong></td>
                                <td>
                                    <asp:Label ID="LabelPhoneNo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Age</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="LabelAge" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>ContactAddress</strong></td>
                                <td>
                                    <asp:Label ID="LabelAddress" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><em><strong>Qualification</strong></em></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="InstitutionName" HeaderText="Institution" />
                                            <asp:BoundField DataField="Course" HeaderText="Course" />
                                            <asp:BoundField DataField="QualificationType" HeaderText="Qualification" />
                                            <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58"></td>
                                <td class="auto-style53"></td>
                                <td class="auto-style52"></td>
                                <td class="auto-style54"></td>
                                <td class="auto-style52"></td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Professional Qualification</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewProfQualification" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CertificationName" HeaderText="Certification" />
                                            <asp:BoundField DataField="Stage" HeaderText="Stage" />
                                            <asp:BoundField DataField="CertYear" HeaderText="Year Obtained" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Work Experience</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewWorkExperience" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                                            <asp:BoundField DataField="PositionHeld" HeaderText="Position Held" />
                                            <asp:BoundField DataField="JobDescriprtion" HeaderText="Job Descriprtion" />
                                            <asp:BoundField DataField="SalaryReceived" HeaderText="Salary Received" />
                                            <asp:BoundField DataField="StartYear" HeaderText="Start Year" />
                                            <asp:BoundField DataField="EndYear" HeaderText="End Year" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50"><strong><em>Uploaded Documents</em></strong></td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GridViewDocument" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Document Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Document" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel></td>
            </tr>
            <tr>
                <td class="auto-style86">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnInterDecClose" runat="server" OnClick="btnInterDecClose_Click" style="font-weight: 700" Text="Close" Visible="False" />
                </td>
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
        </table>
    </asp:View>



<asp:View ID="ViewInterviewReport" runat="server">
        <table style="width: 100% ; border: medium solid #CC3300">
            <tr>
                <td colspan="6">
                    <asp:Label ID="Label59" runat="server" style="font-weight: 700; color: #CC3300" Text="Reports"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <ul class="auto-style52">
                        <li>
                            <p>
                                Select the position to view report of applicants for that position.</p>
                        </li>
                        <li>
                            <p>
                                Click on the report you will like to view</p>
                        </li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="auto-style66">&nbsp;</td>
                <td class="auto-style67">
                    <asp:Label ID="Label79" runat="server" style="font-weight: 700" Text="Depatment"></asp:Label>
                </td>
                <td class="auto-style68">
                    <asp:DropDownList ID="ddReportVacantDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddReportVacantDept_SelectedIndexChanged" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style65" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style66">&nbsp;</td>
                <td class="auto-style67">&nbsp;</td>
                <td class="auto-style68">&nbsp;</td>
                <td class="auto-style65" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style66">&nbsp;</td>
                <td class="auto-style67">
                    <asp:Label ID="Label58" runat="server" style="font-weight: 700" Text="Vacant Position"></asp:Label>
                </td>
                <td class="auto-style68">
                    <asp:DropDownList ID="ddReportVacantPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddReportVacantPosition_SelectedIndexChanged" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style65" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblSelect" runat="server" style="font-style: italic; color: #CC3300; font-weight: 700"></asp:Label>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" style="font-weight: 700; color: #000099; background-color: #C0C0C0" Text="All Applicants" Visible="False" />
                    &nbsp;
                    <asp:Button ID="Button13" runat="server" style="font-weight: 700; color: #000099; background-color: #C0C0C0" Text="Shortlisted  applicants" Visible="False" />
                    &nbsp;
                    <asp:Button ID="Button14" runat="server" style="font-weight: 700; color: #000099; background-color: #C0C0C0" Text="Hired applicants" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style64" colspan="4">
                    <asp:LinkButton ID="linkAllapplicants" runat="server" OnClick="LinkButton2_Click" Visible="False">All Applicant</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="linkShortlistedApplicants" runat="server" OnClick="linkShortlistedApplicants_Click" Visible="False">Shortlisted Applicants</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="linkHireApplicants" runat="server" Visible="False" OnClick="linkHireApplicants_Click">Hire Applicants</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkApproveApplicant" runat="server" OnClick="LinkApproveApplicant_Click" Visible="False">Approved Applicants</asp:LinkButton>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style64" colspan="6">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:GridView ID="GVReport" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
                        <Columns>
                            <asp:BoundField DataField="ApplicantNum" HeaderText="ApplicantNum" />
                            <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position AppliedFor" />
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                            <asp:BoundField DataField="LastName" HeaderText="LastName" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" />
                            <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" />
                            <asp:BoundField DataField="ApplicationStatus" HeaderText="Application Status" />
                            <asp:BoundField DataField="InterviwerDecision" HeaderText="Interviewer Decision" />
                            <asp:BoundField DataField="ManagementDecition" HeaderText="Management Decision" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style63" colspan="4">
                    <asp:Label ID="lblReport" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style64" colspan="4"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style63" colspan="4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>
<asp:View ID="ViewManagementDecision" runat="server">
    <table style="border: medium solid #CC3300; width: 100%;">
        <tr>
            <td class="auto-style69">
                <asp:Label ID="Label60" runat="server" Text="Management Decision" style="font-weight: 700; color: #CC3300"></asp:Label>
            </td>
            <td class="auto-style88">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td class="auto-style88">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <ul class="auto-style52">
                    <li><p>Select position to view applicant and interviewer decision</p></li>
                    <li><p>Approve the decision by selecting the checkbox and click on the approve button.</p></li>
                </ul>
            </td>
        </tr>
        <tr>
            <td class="auto-style74"></td>
            <td class="auto-style89">
                <asp:Label ID="Label61" runat="server" Text="Dept. Applied to" Font-Bold="True" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style74">
                <asp:DropDownList ID="ddManagDecisionAvailDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddManagDecisionAvailDept_SelectedIndexChanged" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style74">&nbsp;</td>
            <td class="auto-style89">&nbsp;</td>
            <td class="auto-style74">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style74">&nbsp;</td>
            <td class="auto-style89">
                <asp:Label ID="Label77" runat="server" Font-Bold="True" Font-Size="14pt" Text="Available position"></asp:Label>
            </td>
            <td class="auto-style74">
                <asp:DropDownList ID="ddManagDecisionAvailPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddManagDecisionAvailPosition_SelectedIndexChanged" Width="250px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style70"></td>
            <td class="auto-style90"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style70" colspan="3">
                <asp:Label ID="lblHireReport" runat="server" style="font-style: italic; font-weight: 700; color: #CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style70">&nbsp;</td>
            <td class="auto-style90">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style70">&nbsp;</td>
            <td class="auto-style90">
                <asp:Button ID="btnMangDecitionFinish" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#009900" OnClick="btnSendOffer_Click" Text="Finish" Visible="False" />
                <asp:Button ID="btnMangDecTryAgain" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#009900" OnClick="btnMangDecTryAgain_Click" Text="Try Again" Visible="False" />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style70" colspan="3">
                <asp:Panel ID="PanelManagementDecision" runat="server">
                    <table style="width:100%;">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                       
        <tr>
            <td class="auto-style69" colspan="3">
                <asp:GridView ID="GVHireApplicants" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVHireApplicants_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="ApplicantNum" HeaderText="ApplicantNum" />
                        <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position AppliedFor" />
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="Age" HeaderText="Age" />
                        <asp:BoundField DataField="InterviwerDecision" HeaderText="Interviewer Decision" />
                        <asp:BoundField DataField="DeptName" HeaderText="Dept" />
                        <asp:BoundField DataField="ApprovedPositionName" HeaderText="Approved Position" />
                        <asp:BoundField DataField="LevelName" HeaderText="Level" />
                        <asp:BoundField DataField="Salary" HeaderText="Salary" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#DataBinder.Eval (Container,"DataItem.ApplicantID")%>' CommandName="View">View</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Approve">
                            <EditItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField >
                            <ItemTemplate>
                                <asp:TextBox ID="TextBoxID" runat="server" Visible="false" Text='<%#DataBinder.Eval (Container,"DataItem.ApplicantID")%>'></asp:TextBox>
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
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:Button ID="btnSaveManagementApproval" runat="server" OnClick="btnSaveManagementApproval_Click" style="font-weight: 700; color: #CC3300" Text="Approve" Visible="False" />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style69" colspan="3">
                <asp:Panel ID="c" runat="server" Visible="False">
                    <table style="border: 1px solid #990033; width: 80%;  margin-left:75px; ">
                            <tr>
                                <td class="auto-style85" colspan="5"><strong class="auto-style54"><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Applicant Information</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style48" colspan="5">
                                    <asp:Image ID="Image2" runat="server" BorderColor="#CC3300" BorderWidth="3px" Height="167px" ImageAlign="Middle" Width="171px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>&nbsp;Dept applied to:</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lbApproveDept" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Applicant No:</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveAppNum" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Position applied or</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApprovePosition" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong>Nationality</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveNationality" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>First Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApproveName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>State of Origin</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveState" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Middle Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveMName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">Senatorial District</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveSenatorial" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Last Name</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveLName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>LGA</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveLga" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Gender</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApproveGender" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Home Town</strong></td>
                                <td>
                                    <asp:Label ID="lblapproveHTown" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Marital Status</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveMaritalStatus" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>Email</strong></td>
                                <td>
                                    <asp:Label ID="lblApproveEmail" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>DOB</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblapproveDOB" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style50"><strong style="color: #333333">PhoneNo</strong></td>
                                <td>
                                    <asp:Label ID="lblApprovePhoneNo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style85"><strong>Age</strong></td>
                                <td class="auto-style84">
                                    <asp:Label ID="lblApproveAge" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style51"><strong>ContactAddress</strong></td>
                                <td>
                                    <asp:Label ID="lblapproveAddr" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style85">&nbsp;</td>
                                <td class="auto-style84">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style50">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><em><strong>Qualification</strong></em></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVQualif" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="InstitutionName" HeaderText="Institution" />
                                            <asp:BoundField DataField="Course" HeaderText="Course" />
                                            <asp:BoundField DataField="QualificationType" HeaderText="Qualification" />
                                            <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                            <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                            <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58"></td>
                                <td class="auto-style53"></td>
                                <td class="auto-style52"></td>
                                <td class="auto-style54"></td>
                                <td class="auto-style52"></td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Professional Qualification</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVProfQualif" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CertificationName" HeaderText="Certification" />
                                            <asp:BoundField DataField="Stage" HeaderText="Stage" />
                                            <asp:BoundField DataField="CertYear" HeaderText="Year Obtained" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50" colspan="5"><strong><em>Work Experience</em></strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVWrkExp" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                                            <asp:BoundField DataField="PositionHeld" HeaderText="Position Held" />
                                            <asp:BoundField DataField="JobDescriprtion" HeaderText="Job Descriprtion" />
                                            <asp:BoundField DataField="SalaryReceived" HeaderText="Salary Received" />
                                            <asp:BoundField DataField="StartYear" HeaderText="Start Year" />
                                            <asp:BoundField DataField="EndYear" HeaderText="End Year" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style50"><strong><em>Uploaded Documents</em></strong></td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style58" colspan="5">
                                    <asp:GridView ID="GVDoc" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" ForeColor="Black" GridLines="Vertical" Visible="False">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="DocumentType" HeaderText="Document Type" />
                                            <asp:BoundField DataField="DocumentPath" HeaderText="Document" />
                                        </Columns>
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <RowStyle BackColor="#F7F7DE" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style58">&nbsp;</td>
                                <td class="auto-style53">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                                <td class="auto-style54">&nbsp;</td>
                                <td class="auto-style52">&nbsp;</td>
                            </tr>
                        </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnMangDecClose" runat="server" OnClick="btnMangDecClose_Click1" style="font-weight: 700" Text="Close" ForeColor="#009900" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style69">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
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
    </table>
</asp:View>



<asp:View ID="ViewOfferEmployment" runat="server">
    <table style="border: medium solid #CC3300; width: 100%;">
        <tr>
            <td class="auto-style72" colspan="4">
                <asp:Label ID="Label71" runat="server" Text=" List and Send Employment Letter to Approved Applicants" style="font-weight: 700; font-style: italic; color: #CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>
                <asp:Label ID="Label78" runat="server" style="font-weight: 700; color: #CC3300" Text="Dept Applied To"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddSendOfferAvailDept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddSendOfferAvailDept_SelectedIndexChanged" Width="254px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>
                <asp:Label ID="Label62" runat="server" style="font-weight: 700; color: #CC3300" Text="Position Applied For"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddSendOfferAvailPosition" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAvailablePosition_SelectedIndexChanged" Width="254px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72" colspan="4">
                <asp:Label ID="LbOfferLetterSentSuccessfully" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                <asp:Label ID="lblReport2" runat="server" style="color: #FF3300; font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSendOfferFinish" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#009900" OnClick="btnSendOffer_Click" Text="Finish" Visible="False" />
                <asp:Button ID="btnSendOfferTryAgain" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#009900" OnClick="btnSendOfferTryAgain_Click" Text="Try Again" Visible="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72" colspan="4">
                <asp:Panel ID="PanelOfferEmployment" Visible="false" runat="server">
                    <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                  
        <tr>
            <td class="auto-style72" colspan="3">
                <asp:GridView ID="GVSendOffer" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="ApplicantNum" HeaderText="ApplicantNum" />
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="Age" HeaderText="Age" />
                        <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" />
                        <asp:BoundField DataField="PositionAppliedFor" HeaderText="Position Applied for" />
                        <asp:BoundField DataField="ApprovedPositionName" HeaderText="Position Given" />
                        <asp:BoundField DataField="InterviwerDecision" HeaderText="Interviewer Decision" />
                        <asp:BoundField DataField="ManagementDecition" HeaderText="Mgt Decision" />
                        <asp:TemplateField HeaderText="Send Offer">
                            <EditItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:TextBox ID="txtApplicantID" runat="server" Text='<%#DataBinder.Eval(Container, "DataItem.ApplicantID")%>' Visible="false">"></asp:TextBox>
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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style73"></td>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btnSendOfferletter" runat="server" ForeColor="#CC3300" style="font-weight: 700" Text="Send Offer" OnClick="btnSendOfferletter_Click" />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style72">&nbsp;</td>
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
            <td class="auto-style72">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:View>
<asp:View ID="ViewOfferLetter" runat="server">
    <table style="border: medium solid #CC3300; width: 100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">    <asp:Panel ID="Panel3" runat="server">
        <table style="border: medium solid #C0C0C0; width:75%; margin-left:50px">
            <tr>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style47">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style47">&nbsp;</td>
                <td valign="right">
                    <asp:Label ID="Label72" runat="server" Text="Neetbeet Technologies Limited"></asp:Label>
                    <br />
                    <asp:Label ID="Label73" runat="server" Text="13, Adekunbi Cresent , Off Toyin Street, Ikeja, Lagos."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style46">&nbsp;</td>
                <td class="auto-style47">&nbsp;</td>
                <td>
                    <asp:Label ID="Label74" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style45"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style46">Dear&nbsp;
                    <asp:Label ID="lblName2" runat="server"></asp:Label>
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
                                    <b><u>Appointment Letter </u></b>
                                </center>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <p>
                        Further to your application and subsquent interview at Neetbeet Technogies Limited, we are please to offer you an appointment as
                        <asp:Label ID="lblPosition" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                        &nbsp; under the department of
                        <asp:Label ID="lblOfferDept" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                        . The following are your appointment detail:
                        <ul>
                            <li>Position:&nbsp;&nbsp;
                                <asp:Label ID="lblOfferPosition" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                            <li>Department:&nbsp;&nbsp;
                                <asp:Label ID="lblOfferDept2" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                            <li>Level:&nbsp;&nbsp;
                                <asp:Label ID="lblOfferLevel" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                            <li>Basic Salary:&nbsp;&nbsp;
                                <asp:Label ID="lblOfferSalary" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                            <li>Work Loction:&nbsp;&nbsp;
                                <asp:Label ID="lblOfferWrkLocatn" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                            <li>Resumption Date:&nbsp;&nbsp;
                                <asp:Label ID="lblOfferRsmptDate" runat="server" ForeColor="#990033" Text="Label"></asp:Label>
                            </li>
                        </ul>
                        <p>
                            &nbsp;</p>
                        <p>
                            The first six months of your employment with us will be regarded as a propationary period, during which , either you or the company could terminate the appointment by giving one (1) month&#39;s notice in writing or paying one (1) month&#39;s basic salary in lieu of notice.</p>
                        <p>
                        </p>
                    </p>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style47">&nbsp;</td>
                <td>
                    <asp:Label ID="lblApplicantEmail1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnPrint" runat="server" OnClick="btnPrint_Click" style="font-weight: 700" Text="Print" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
            </asp:View>
</asp:MultiView></td>
    </tr>
    <tr>
        <td class="auto-style1"></td>
        <td class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>




