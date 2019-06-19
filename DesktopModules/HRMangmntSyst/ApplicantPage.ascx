<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ApplicantPage.ascx.cs" Inherits="ola.HRMangmntSyst.ApplicantPage" %>
<style type="text/css">

    .auto-style26 {
        width: 879px;
    }
    .auto-style18 {
        width: 122px;
    }
    .auto-style21 {
        width: 149px;
    }
    .auto-style24 {
        height: 22px;
        width: 1753px;
    }
    .auto-style4 {
        height: 22px;
        width: 29%;
    }
    .auto-style27 {
        height: 22px;
        width: 879px;
    }
    .auto-style19 {
        height: 22px;
        width: 122px;
    }
    .auto-style16 {
        height: 22px;
        width: 149px;
    }
    .auto-style25 {
        height: 23px;
        width: 1753px;
    }
    .auto-style5 {
        height: 23px;
        width: 29%;
    }
    .auto-style28 {
        height: 23px;
        width: 879px;
    }
    .auto-style20 {
        height: 23px;
        width: 122px;
    }
    .auto-style22 {
        height: 23px;
        width: 149px;
    }
    .auto-style31 {
    }
    .auto-style8 {
    }
    .auto-style12 {
        width: 278px;
    }
    .auto-style11 {
    }
    .auto-style10 {
        width: 345px;
    }
    .auto-style35 {
        width: 357px;
    }
    .auto-style44 {
        width: 145px;
        height: 26px;
    }
    .auto-style45 {
        width: 162px;
        height: 26px;
    }
    .auto-style46 {
        width: 357px;
        height: 26px;
    }
    .auto-style47 {
        height: 26px;
    }
    .auto-style38 {
        width: 162px;
        height: 30px;
    }
    .auto-style39 {
        width: 357px;
        height: 30px;
    }
    .auto-style40 {
        height: 30px;
    }
    .auto-style13 {
    }
    .auto-style14 {
    }
    .auto-style41 {
        width: 151px;
        height: 38px;
    }
    .auto-style42 {
        width: 164px;
        height: 38px;
    }
    .auto-style43 {
        height: 38px;
    }
    .auto-style56 {
        width: 121px;
    }
    .auto-style55 {
        width: 245px;
    }
    .auto-style59 {        margin-left: 40px;
    }
    .auto-style51 {
        width: 173px;
    }
    .auto-style50 {
        width: 102px;
    }
    .auto-style58 {
        height: 23px;
        width: 125px;
    }
    .auto-style53 {
        width: 50px;
        height: 23px;
    }
    .auto-style52 {
        height: 23px;
    }
    .auto-style54 {
        width: 175px;
        height: 23px;
    }
    .auto-style64 {
        font-size: medium;
        color: #CC3300;
    }
    .auto-style65 {
        width: 29%;
        height: 26px;
    }
    .auto-style66 {
        width: 879px;
        height: 26px;
    }
    .auto-style67 {
        width: 122px;
        height: 26px;
    }
    .auto-style68 {
        width: 149px;
        height: 26px;
    }
    .auto-style69 {
        height: 18px;
    }
    .auto-style70 {
        width: 162px;
        height: 18px;
    }
    .auto-style71 {
        width: 345px;
        height: 18px;
    }
    .auto-style72 {
    }
    .auto-style73 {
        height: 59px;
    }
    .auto-style74 {
        width: 29%;
    }
    .auto-style76 {
        width: 145px;
        height: 30px;
    }
    .auto-style77 {
    }
    .auto-style78 {
        width: 145px;
        height: 23px;
    }
    .auto-style79 {
        width: 162px;
        height: 23px;
    }
    .auto-style80 {
        width: 357px;
        height: 23px;
    }
    .auto-style81 {
        height: 33px;
    }
    .auto-style82 {
        width: 162px;
        height: 33px;
    }
    .auto-style83 {
        width: 345px;
        height: 33px;
    }
    .auto-style85 {
        margin-left: 40px;
        }
    .auto-style86 {
        width: 125px;
    }
    .auto-style87 {
        margin-left: 40px;
        height: 22px;
    }
    .auto-style88 {
        width: 50px;
        height: 22px;
    }
    .auto-style89 {
        height: 22px;
    }
    .auto-style90 {
        width: 175px;
        height: 22px;
    }
    .auto-style93 {
        list-style-type: square;
    }
    .auto-style94 {
        width: 50px;
    }
    .auto-style95 {
        width: 175px;
    }
    </style>
<table style="width:100%;">
    <tr>
        <td style="width: 150px" valign="top"> <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Home" Width="150px" Font-Size="14pt" OnClick="Button3_Click" style="font-size: medium" />
                    </td>
                    
                </tr>
             <tr>
                    <td>
                        <asp:Button ID="Button10" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Start Application" Width="150px"  style="font-size: medium" OnClick="Button10_Click" />
                    </td>
                    
                </tr>
             <tr>
                    <td>
                        <asp:Button ID="Button11" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Continue Application" Width="150px" Font-Size="11pt" OnClick="Button11_Click" />
                    </td>
                    
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="Button5" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Qualification" Width="150px" OnClick="Button5_Click" style="font-size: medium" />
                    </td>
                    
                </tr>
             <tr>
                    <td>
                        <asp:Button ID="Button6" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Professional Cert" Width="150px" OnClick="Button6_Click" style="font-size: medium" />
                    </td>
                    
                </tr>
             <tr>
                    <td>
                        <asp:Button ID="Button7" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Work Experience" Width="150px" OnClick="Button7_Click" style="font-size: medium" />
                    </td>
                    
                </tr>
             <tr>
                    <td>
                        <asp:Button ID="Button8" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Document" Width="150px" OnClick="Button8_Click" style="font-size: medium" />
                    </td>
                    
                </tr>
             <tr>
                    <td>
                        <asp:Button ID="Button9" runat="server" Font-Bold="True" ForeColor="#CC3300" Height="35px" Text="Summary" Width="150px" OnClick="Button9_Click" style="font-size: medium" Visible="False" />
                    </td>
                    
                </tr>
             <tr>
                    <td>&nbsp;</td>
                    
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
<asp:MultiView ID="MViewApplicant" runat="server">
    <asp:View ID="homepage" runat="server">
        <table style="border-style: solid; border-color: #CC3300; width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label17" runat="server" style="font-weight: 700; color: #CC3300; text-align: center; font-size: medium;" Text="Welcome to our site. Make sure you fill in the information correctly"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style73">
                    <p>
                        You are expected to provide the following details when applying for any of the position&nbsp;
                    </p>
                    <ul class="auto-style93">
                        <li>
                            <p>
                                Personal Details.</p>
                        </li>
                        <li>
                            <p>
                                Academic qualifications.</p>
                        </li>
                        <li>
                            <p>
                                Professional qualification if applicable.</p>
                        </li>
                        <li>
                            <p>
                                Working Experience if any.</p>
                        </li>
                        <li>
                            <p>
                                Upload passport and all necessary documents such degree cert., nysc/exemption&nbsp; letter etc.</p>
                        </li>
                    </ul>
                    <p>
                        Click on start application to apply or continue application to complete your application process if already started an applying.</p>
                </td>
                <td class="auto-style73"></td>
                <td class="auto-style73"></td>
            </tr>
        </table>
    </asp:View>

    <asp:View ID="ViewPersonalInfom" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
    <tr>
        <td class="auto-style30" colspan="5">
            &nbsp;<asp:Label ID="LbAppInfo" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Applicant Personal Infomation " style="color: #CC3300; font-style: italic"></asp:Label>
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
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style52"></td>
                <td class="auto-style5"></td>
                <td class="auto-style28">
                    <asp:Label ID="LbDetailsAdded1" runat="server" Font-Italic="True" Visible="false" ForeColor="#CC0066"></asp:Label>
                </td>
                <td class="auto-style20"></td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                     <td class="auto-style30">&nbsp;</td>
                     <td class="auto-style74">&nbsp;</td>
                     <td class="auto-style26">
                         &nbsp;&nbsp;
                         </td>
                     <td class="auto-style18">&nbsp;</td>
                     <td class="auto-style21">&nbsp;</td>
            </tr>

                
               <tr>
                     <td class="auto-style30">&nbsp;</td>
                     <td class="auto-style74">&nbsp;</td>
                     <td class="auto-style26">  <asp:Button ID="ApplicantNextBtn1" Visible="false" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="applicantNextBtn_Click" style="font-size: medium; color: #CC3300;" Text="Next" />
                   
                                  <asp:Button ID="ApplicantTryAgain" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="ApplicantTryAgain_Click" style="font-size: medium; color: #CC3300;" Text="Try Again" Visible="false" />
                   
                                  </td>
                     <td class="auto-style18">
                         &nbsp;</td>
                     <td class="auto-style21">
                         </td>
            </tr>
                 <tr>
                     <td class="auto-style30">&nbsp;</td>
                     <td class="auto-style74">&nbsp;</td>
                     <td class="auto-style26">
                         &nbsp;&nbsp;
                         </td>
                     <td class="auto-style18">&nbsp;</td>
                     <td class="auto-style21">&nbsp;</td>
            </tr>
        
             <tr>
                <td class="auto-style30" colspan="5">
                    <asp:Panel ID="PanelApplicantDetails" Visible="false" runat="server">
                        <table style="width: 100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Label ID="LbAvailablePosition0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Department"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlApplicantDept" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlApplicantDept_SelectedIndexChanged" Width="343px">
                                    </asp:DropDownList>
                                </td>
                                <caption>
                                    <tr>
                                        <td>&nbsp;</td>
                                    </tr>
                                </caption>
                            </tr>
                     
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    <asp:Label ID="LbAvailablePosition" runat="server" Font-Bold="True" Font-Size="14pt" Text="Available Position" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                   <%-- <asp:DropDownList ID="ddlAvailablePosition" runat="server" AutoPostBack="True" Width="330px"></asp:DropDownList>
                 --%>   
                    <asp:DropDownList ID="ddlAvailablePosition" runat="server" AutoPostBack="True" Height="16px" Width="343px">
                        
                    </asp:DropDownList>
                    &nbsp; </td>
                <td class="auto-style18"><%--    <asp:RequiredFieldValidator ID="availPositionReqFieldVal" runat="server" ControlToValidate="availablePositionList" Display="Dynamic" ErrorMessage="You must select a position" SetFocusOnError="True">You must select a position</asp:RequiredFieldValidator>
        --%></td>
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
                    <asp:Label ID="LBTitle" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Title"></asp:Label>
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
                <td class="auto-style18">
                     <%--<asp:RequiredFieldValidator ID="fNameReqFieldVal0" runat="server" ControlToValidate="txtFName" Display="Dynamic" ErrorMessage="FirstNameRequired" SetFocusOnError="True">FirstName Required</asp:RequiredFieldValidator>
              --%>  &nbsp;</td>
                <td class="auto-style21">
                    &nbsp;</td>
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
                    <asp:Label ID="LBfName" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="First Name"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtFName" runat="server" Width="338px"></asp:TextBox>
                    &nbsp;</td>
                <td class="auto-style18"><%--<asp:RequiredFieldValidator ID="fNameReqFieldVal0" runat="server" ControlToValidate="txtFName" Display="Dynamic" ErrorMessage="FirstNameRequired" SetFocusOnError="True">FirstName Required</asp:RequiredFieldValidator>
              --%></td>
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
        <td class="auto-style67">
           <%-- <asp:RequiredFieldValidator ID="lNameReqFieldVal" runat="server" ControlToValidate="txtLName" Display="Dynamic" ErrorMessage="LastNameRequired" SetFocusOnError="True">LastNameRequired</asp:RequiredFieldValidator>
       --%>  </td>
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
                    <asp:Label ID="LbStatus" runat="server" Font-Bold="True" Font-Size="14pt" Text="Marital Status" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">
                    <asp:DropDownList ID="ddlMaritalStatus" runat="server" Height="16px" Width="351px">
                        <asp:ListItem>---Please select---</asp:ListItem>
                        <asp:ListItem>Single</asp:ListItem>
                        <asp:ListItem Value="Married"></asp:ListItem>
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
           <td>
              <%--  <asp:RequiredFieldValidator ID="emailReqFieldVal" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="EmailAddress Required" SetFocusOnError="True">EmailAddress Required</asp:RequiredFieldValidator>
               <br />
               <asp:RegularExpressionValidator ID="emailRegularExpressionVal" runat="server" Display="Dynamic" ErrorMessage="Invalid Email Address" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Invalid Email Address</asp:RegularExpressionValidator>
        --%> </td>
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
        <td class="auto-style30">
            &nbsp;</td>
        <td class="auto-style74">
            <asp:Label ID="LbGender0" runat="server" Font-Bold="True" Text="Gender" Font-Size="14pt" style="font-size: medium"></asp:Label>
         </td>
        <td class="auto-style26">
            <asp:RadioButtonList ID="rbtnGender" runat="server" Font-Bold="True" Font-Size="12pt">
                <asp:ListItem Selected="True">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
         </td>
        <td class="auto-style18">
            &nbsp;</td>
        <td class="auto-style21">
            &nbsp;</td>
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
                    <asp:Label ID="LbDOB0" runat="server" Font-Bold="True" Font-Size="14pt" Text="DOB" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style26">&nbsp;<asp:DropDownList ID="ddlDay" runat="server">
                    </asp:DropDownList>
                    &nbsp; &nbsp;
                    <asp:DropDownList ID="ddlMonth" runat="server">
                        <asp:ListItem Value="00">Month</asp:ListItem>
                        <asp:ListItem Value="1">Jan</asp:ListItem>
                        <asp:ListItem Value="2">Feb</asp:ListItem>
                        <asp:ListItem Value="3">Mar</asp:ListItem>
                        <asp:ListItem Value="4">Apr</asp:ListItem>
                        <asp:ListItem Value="5">May</asp:ListItem>
                        <asp:ListItem Value="6">Jun</asp:ListItem>
                        <asp:ListItem Value="7">Jul</asp:ListItem>
                        <asp:ListItem Value="8">Aug</asp:ListItem>
                        <asp:ListItem Value="9">Sep</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlYear_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">
                    &nbsp;</td>
                <td class="auto-style26">
                    &nbsp;&nbsp;
                    </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24"></td>
                <td class="auto-style4">
                    <asp:Label ID="LbAge" runat="server" Font-Bold="True" Font-Size="14pt" Text="Age" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style27">
                    <asp:TextBox ID="txtAge" runat="server" Width="342px"></asp:TextBox>
                </td>
                <td class="auto-style19"><%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%></td>
                <td class="auto-style16">&nbsp;</td>
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
            <asp:Label ID="LbNationality" runat="server" Font-Bold="True" Text="Nationality" Font-Size="14pt" style="font-size: medium"></asp:Label>
        </td>
        <td class="auto-style26">
            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" Height="17px" Width="351px">
            </asp:DropDownList>
             <%--&nbsp;<asp:RequiredFieldValidator ID="countryReqFieldVal" runat="server" ControlToValidate="countryList" Display="Dynamic" ErrorMessage="CountryRequired" SetFocusOnError="True">CountryRequired</asp:RequiredFieldValidator>
        --%> </td>
        <td class="auto-style18">
            &nbsp;</td>
        <td class="auto-style21">
            &nbsp;</td>
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
                     <asp:Label ID="LbStateOfOri" runat="server" Font-Bold="True" Font-Size="14pt" Text="State of Origin" style="font-size: medium"></asp:Label>
                 </td>
                 <td class="auto-style26">
                     <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" Width="353px">
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
            <asp:Label ID="LbLGA" runat="server" Font-Bold="True" Text="LGA" Font-Size="14pt" style="font-size: medium"></asp:Label>
                 </td>
        <td class="auto-style26">
            <asp:DropDownList ID="ddlLga" runat="server" AutoPostBack="True" Height="16px" Width="352px">
            </asp:DropDownList>
                <%--  &nbsp;<asp:RequiredFieldValidator ID="LGAReqFieldVal" runat="server" ControlToValidate="lgaList" Display="Dynamic" ErrorMessage="LGARequired" SetFocusOnError="True">LGARequired</asp:RequiredFieldValidator>
                 --%></td>
        <td class="auto-style18">
            &nbsp;</td>
        <td class="auto-style21">
            &nbsp;</td>
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
                                    <asp:Label ID="LbLGA0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Sen. District"></asp:Label>
                                </td>
                                <td class="auto-style26">
                                    <asp:DropDownList ID="ddlSenatorial" runat="server" AutoPostBack="True" Height="16px" Width="352px">
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
                     <asp:Label ID="LbHome" runat="server" Font-Bold="True" Font-Size="14pt" Text="Home Town" style="font-size: medium"></asp:Label>
                 </td>
                 <td class="auto-style26">
                     <asp:TextBox ID="txtHometown" runat="server" Width="322px"></asp:TextBox>
                 </td>
                 <td class="auto-style18">&nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">
                    &nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>

             <tr>
                 <td class="auto-style30">&nbsp;</td>
                 <td class="auto-style74">
                     <asp:Label ID="LbPaasport" runat="server" Font-Bold="True" Text="Upload Passport" Font-Size="14pt" style="font-size: medium"></asp:Label>
                 </td>
                 <td class="auto-style26">
                     <asp:FileUpload ID="UploadPassport" runat="server" />
                 </td>
                 <td class="auto-style18">
                     &nbsp;</td>
                 <td class="auto-style21">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25"></td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style28">
                    <asp:Image ID="Image1" runat="server" Height="179px" Width="170px" BorderColor="#CC3300" BorderWidth="3px" />
                    &nbsp;<asp:Label ID="lblPassportName" runat="server"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:Button ID="passportUploadBtn0" runat="server" Font-Bold="True" ForeColor="#33CC33" style="color: #CC3300" Text="Upload" />
                </td>
                <td class="auto-style20">
                    &nbsp;</td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style74">&nbsp;</td>
                <td class="auto-style26">
                    <asp:Label ID="Label23" runat="server" style="font-style: italic; color: #CC6600" Text="Picture size should not be more that 13kb"></asp:Label>
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
                         <asp:Button ID="ApplicantSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="appSaveBtn_Click" style="font-size: medium; color: #CC3300;" Text="Save" />
                     </td>
                     <td class="auto-style18">
                         &nbsp;</td>
                     <td class="auto-style21">
                         <asp:Button ID="ApplicantNextBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="applicantNextBtn_Click" style="font-size: medium; color: #CC3300;" Text="Next" />
                     </td>
            </tr>
            <tr>
                <td class="auto-style52"></td>
                <td class="auto-style5"></td>
                <td class="auto-style28">
                    <asp:Label ID="LbDetailsAdded" runat="server" Font-Italic="True" ForeColor="#CC0066"></asp:Label>
                </td>
                <td class="auto-style20"></td>
                <td class="auto-style22"></td>
            </tr>

                
                 <tr>
                     <td class="auto-style30">&nbsp;</td>
                     <td class="auto-style74">&nbsp;</td>
                     <td class="auto-style26">
                         &nbsp;&nbsp;
                         </td>
                     <td class="auto-style18">&nbsp;</td>
                     <td class="auto-style21">&nbsp;</td>
            </tr>

                
                 <tr>
        <td class="auto-style30" colspan="5">
            <asp:Label ID="lblNotVisibleApplicantNum" runat="server" Font-Italic="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                     </td>
    </tr>

                  
                        </table>
                    </asp:Panel>
                </td>
            </tr>
                 <tr>
        <td class="auto-style30">&nbsp;</td>
        <td class="auto-style74">&nbsp;</td>
        <td class="auto-style26">
            &nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style21">&nbsp;</td>
    </tr>
</table>
    </asp:View>

    <asp:View ID="ViewQualification" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
            <tr>
                <td colspan="4">
                    <asp:Label ID="LbQualifInfo" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Qualification Details" style="color: #CC3300; font-style: italic"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style31">
                    </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                     <asp:Button ID="qualifNextBtn1" runat="server" Visible="false" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qualifNextBtn_Click" style="font-size: medium; color: #CC3300;" Text="Next" />
                     <asp:Button ID="qualifTryAgainBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33"  style="font-size: medium; color: #CC3300;" Text="Try Again" Visible="false" OnClick="qualifTryAgainBtn_Click" />
                    </td>
                <td>
                       </td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31" colspan="4">
                    <asp:Label ID="lblqualif1" runat="server" style="color: #669900; font-weight: 700; font-size: small"></asp:Label>
                    &nbsp;<asp:Label ID="lblQualificationMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31" colspan="4">
                    <asp:Panel ID="PanelAppQualification" Visible="false" runat="server">
                        <table style="width: 100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                            </tr>
                         
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="LbSchName" runat="server" Font-Bold="True" Font-Size="14pt" Text="School Name" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtQualifSchName" runat="server" Width="306px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="LbCourse" runat="server" Font-Bold="True" Text="Course" Font-Size="14pt" style="font-size: medium"></asp:Label>
                 </td>
                <td class="auto-style12">
                    <asp:DropDownList ID="courseList" runat="server" Height="16px" Width="311px">
                         <asp:ListItem>---Please select---</asp:ListItem>
                         <asp:ListItem>Accounting</asp:ListItem>
                         <asp:ListItem>Agricultural Sciences</asp:ListItem>
                         <asp:ListItem>Agrochemical</asp:ListItem>
                         <asp:ListItem>Biology</asp:ListItem>
                         <asp:ListItem>Botany</asp:ListItem>
                         <asp:ListItem>Business Administration</asp:ListItem>
                         <asp:ListItem>Biochemistry</asp:ListItem>
                         <asp:ListItem>Computer Science</asp:ListItem>
                         <asp:ListItem>Economics</asp:ListItem>
                         <asp:ListItem>Ecology</asp:ListItem>
                         <asp:ListItem>Education</asp:ListItem>
                         <asp:ListItem>Education Technology</asp:ListItem>
                         <asp:ListItem>EDucation ScienceEducation Science</asp:ListItem>
                         <asp:ListItem>Food and Nutrition</asp:ListItem>
                         <asp:ListItem>Info Tech</asp:ListItem>
                         <asp:ListItem>Marketing</asp:ListItem>
                         <asp:ListItem>Medcine</asp:ListItem>
                         <asp:ListItem>Nursing</asp:ListItem>
                         <asp:ListItem>Physics</asp:ListItem>
                         <asp:ListItem>Public Administration</asp:ListItem>
                         <asp:ListItem>Public Health</asp:ListItem>
                         <asp:ListItem>Psychology</asp:ListItem>
                         <asp:ListItem>Zoology</asp:ListItem>
                    </asp:DropDownList>
                 </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="LbQaulif" runat="server" Font-Bold="True" Text="Qualification" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:DropDownList ID="qualifList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="qualifList_SelectedIndexChanged" Height="16px" Width="311px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="LbGrade" runat="server" Font-Bold="True" Text="Grade" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:DropDownList ID="gradeList" runat="server" Height="17px" Width="305px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="LbQualifStartYear" runat="server" Font-Bold="True" Text="Start Year" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:DropDownList ID="qualifStartYearList" runat="server" Height="27px" Width="310px">
                        <asp:ListItem>---Please select---</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                        <asp:ListItem>2003</asp:ListItem>
                        <asp:ListItem>2002</asp:ListItem>
                        <asp:ListItem>2001</asp:ListItem>
                        <asp:ListItem>2000</asp:ListItem>
                        <asp:ListItem>1999</asp:ListItem>
                        <asp:ListItem>1998</asp:ListItem>
                        <asp:ListItem>1990</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;<asp:Label ID="LbQualifEndDate" runat="server" Font-Bold="True" Text="End Year" Font-Size="14pt" style="font-size: medium"></asp:Label>
                    &nbsp; </td>
                <td class="auto-style12">
                    <asp:DropDownList ID="qualifEndYearList" runat="server" Height="16px" Width="309px">
                        <asp:ListItem>---Please select---</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                        <asp:ListItem>2003</asp:ListItem>
                        <asp:ListItem>2002</asp:ListItem>
                        <asp:ListItem>2001</asp:ListItem>
                        <asp:ListItem>2000</asp:ListItem>
                        <asp:ListItem>1999</asp:ListItem>
                        <asp:ListItem>1998</asp:ListItem>
                        <asp:ListItem>1990</asp:ListItem>
                    </asp:DropDownList>
                 </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="qualifAddBtn0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qualifAddBtn_Click1" style="font-size: medium; color: #CC3300;" Text="Add" />
                 </td>
                <td class="auto-style12">
                    &nbsp;<asp:Label ID="lblMoreQualification" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#CC0066" Text="Click add button to add more qualifications" Visible="False"></asp:Label>
                 </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="GViewQualif" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Height="117px" Visible="False" OnRowCommand="GViewQualif_RowCommand" OnRowEditing="GViewQualif_RowEditing" >
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="InstitutionName" HeaderText="SchoolName" />
                            <asp:BoundField DataField="QualificationType" HeaderText="Qualification" />
                            <asp:BoundField DataField="Course" HeaderText="Course" />
                            <asp:BoundField DataField="Grade" HeaderText="Grade" />
                            <asp:BoundField DataField="StartYear" HeaderText="Start Year" />
                            <asp:BoundField DataField="EndYear" HeaderText="End Year" />
                            <asp:BoundField DataField="ApplicantID_FK" HeaderText="ApplicantID" />
                          <%--  <asp:BoundField DataField="EmployeeID_FK" HeaderText="EmpID" />--%>
                           
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
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
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style8" colspan="2">
                    <asp:Label ID="lblqualif" runat="server" style="color: #669900; font-weight: 700; font-size: small"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31">
                    <asp:Button ID="qualifBackBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qualifBackBtn_Click" style="font-size: medium; color: #CC3300;" Text="Back" />
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style12">
                    <asp:Button ID="qualifSaveBtn" runat="server" Enabled="False" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qualiSaveBtn_Click" style="font-size: medium; color: #CC3300;" Text="Save" Visible="False" />
                </td>
                <td>
                    <asp:Button ID="qualifNextBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="qualifNextBtn_Click" style="font-size: medium; color: #CC3300;" Text="Next" />
                </td>
            </tr>
                              
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="ViewProfessionalCert" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
            <tr>
                <td colspan="4">
                    <asp:Label ID="LbCertifcation" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Professional Certification" style="font-style: italic; color: #CC3300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                 <td>&nbsp;</td>

            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="lblprof1" Visible="False" runat="server" Text="Label" Font-Bold="True" Font-Italic="True" ForeColor="#669900"></asp:Label></td>
            </tr>

              <tr>
                <td>&nbsp;</td>
                   <td>&nbsp;</td>
                <td class="auto-style11">
                   
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                 </td>
                <td class="auto-style10">
                     <asp:Button ID="certNextBtn1" runat="server" Visible="false" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="certNextBtn_Click" style="font-size: medium; color: #CC3300;" Text="Next" />
                   </td>
                <td class="auto-style11"> <asp:Button ID="certTryAgainBtn" Visible="false" runat="server" Font-Bold="true" Font-Size="14pt" ForeColor="#33CC33" style="font-size: medium;  color: #CC3300;" Text="Try Again" OnClick="certTryAgainBtn_Click" />
                </td>
                
                <td>
                      </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Panel ID="PanelAppCertification" Visible="false" runat="server">
                        <table style="width:100%;">
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
                            </tr>
                      
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">
                    <asp:Label ID="LbCertName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Name" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtCertName" runat="server" Height="19px" Width="331px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td class="auto-style69"></td>
                <td class="auto-style70">
                    <asp:Label ID="LbStage" runat="server" Font-Bold="True" Text="Stage" Font-Size="14pt" style="font-size: medium"></asp:Label>
                 </td>
                <td class="auto-style71">
                    <asp:DropDownList ID="certStageList" runat="server" Height="16px" Width="336px">
                        <asp:ListItem Selected="True">---Stage---</asp:ListItem>
                        <asp:ListItem>Diploma</asp:ListItem>
                        <asp:ListItem>Intermidiate</asp:ListItem>
                        <asp:ListItem>RQF Level 1</asp:ListItem>
                        <asp:ListItem>RQF Level 2</asp:ListItem>
                        <asp:ListItem>RQF Level 3</asp:ListItem>
                        <asp:ListItem>RQF Level 4</asp:ListItem>
                    </asp:DropDownList>
                 </td>
                <td class="auto-style69"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                 <td>&nbsp;</td>

            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">
                    <asp:Label ID="LbCertNo" runat="server" Font-Bold="True" Text="Certificate Num" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtCertNum" runat="server" Height="16px" Width="329px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">
                    <asp:Label ID="LbCertYear" runat="server" Font-Bold="True" Text="Year" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="ddlCertYear" runat="server" Height="16px" Width="337px">
                        <asp:ListItem>---Year---</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                        <asp:ListItem>2003</asp:ListItem>
                        <asp:ListItem>2002</asp:ListItem>
                        <asp:ListItem>2001</asp:ListItem>
                        <asp:ListItem>2000</asp:ListItem>
                        <asp:ListItem>1999</asp:ListItem>
                        <asp:ListItem>1998</asp:ListItem>
                        <asp:ListItem>1990</asp:ListItem>
                    </asp:DropDownList>
                </td>
                 <td>&nbsp;</td>

            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style81"></td>
                <td class="auto-style82">
                    <asp:Button ID="certAddBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Add" style="font-size: medium; color: #CC3300;" OnClick="certAddBtn_Click" />
                </td>
                <td class="auto-style83">
                    <asp:Label ID="lblMoreQualification0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#CC0066" Text="Click add button to add more  professional qualifications"></asp:Label>
                </td>
                <td class="auto-style81"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="GViewCert" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None"   Visible="False" OnRowCommand="GViewCert_RowCommand" OnRowDeleting="GViewCert_RowDeleting">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <%--//<asp:BoundField DataField="employeeID_FK" HeaderText="EmpID" />--%>
                            <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" />
                            <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" />
                            <asp:BoundField DataField="Stage" HeaderText="Stage" />
                            <asp:BoundField DataField="CertYear" HeaderText="CertYear" />
                            <asp:BoundField DataField="ApplicantID_FK" HeaderText="ApplicantID" />
                          
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkBtnQualifEdit" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
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
                <td>&nbsp;</td>
                <td class="auto-style11" colspan="2">
                    <asp:Label ID="lblprof" runat="server" style="font-weight: 700; color: #669900"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="certBackBtn0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="certBackBtn_Click" style="font-size: medium; color: #CC3300;" Text="Back" />
                </td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="certSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="certSaveBtn_Click" style="font-size: medium; color: #CC3300;" Text="Save" Visible="False" />
                </td>
                <td>
                    <asp:Button ID="certNextBtn0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" OnClick="certNextBtn_Click" style="font-size: medium; color: #CC3300;" Text="Next" />
                </td>
            </tr>
                                
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>
      <asp:View ID="ViewWorkExp" runat="server">
          <table style="border: medium solid #CC3300; width:100%;">
              <tr>
                  <td class="auto-style32" colspan="4">
                      <asp:Label ID="LbWorkExp" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Working Experiences" style="font-style: italic; color: #CC3300;"></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style32" colspan="4">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style77" colspan="4">
                      <asp:Label ID="lblworkExp1" runat="server" style="font-weight: 700; color: #669900" Visible="False"></asp:Label>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style78"></td>
                  <td class="auto-style52"></td>
                  <td class="auto-style80"></td>
                  <td class="auto-style52"></td>
              </tr>
              <tr>
                  <td class="auto-style52"></td>
                  <td class="auto-style52">
                      <asp:Button ID="workNextBtn1" runat="server" CssClass="auto-style64" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" OnClick="workNextBtn_Click" Text="Next" Visible="False" />
                  </td>
                  <td class="auto-style80">
                      <asp:Button ID="workTryAgain" runat="server" CssClass="auto-style64" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" Text="Try Again" Visible="False" OnClick="workTryAgain_Click" />
                  </td>
                  <td class="auto-style52"></td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style77" colspan="4">
                      <asp:Panel ID="PanelAppWorkingExper" Visible="false" runat="server">
                           <table style="width:100%;">
                          <tr>
                              <td colspan="4">     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Working Experiences" style="font-style: italic; color: #CC3300;"></asp:Label>
        </td>
                          
                          </tr>
                          <tr>
                              <td>&nbsp;</td>
                              <td>&nbsp;</td>
                              <td>&nbsp;</td>
                                <td>&nbsp;</td>
                          </tr>
                    
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">
                      <asp:Label ID="LbCompName" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Company Name"></asp:Label>
                  </td>
                  <td class="auto-style35">
                      <asp:TextBox ID="txtCompanyName" runat="server" Width="281px"></asp:TextBox>
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
               <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">
                      <asp:Label ID="LbPositionHeld" runat="server" Font-Bold="True" Text="Position Held" Font-Size="14pt" style="font-size: medium"></asp:Label>
                   </td>
                  <td class="auto-style35">
                      <asp:TextBox ID="txtPositionHeld" runat="server" Width="282px"></asp:TextBox>
                   </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">
                      <asp:Label ID="LbjobDescrp" runat="server" Font-Bold="True" Text="Job Description" Font-Size="14pt" style="font-size: medium"></asp:Label>
                  </td>
                  <td class="auto-style35">
                      <asp:TextBox ID="txtWorkJobDesc" runat="server" Width="283px"></asp:TextBox>
                  </td>
                  <td>&nbsp;</td>
              </tr>
               <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style44"></td>
                  <td class="auto-style45">
                      <asp:Label ID="LbSalary" runat="server" Font-Bold="True" Text="Salary" Font-Size="14pt" style="font-size: medium"></asp:Label>
                  </td>
                  <td class="auto-style46">
                      <asp:TextBox ID="txtWorkSalary" runat="server" Width="280px"></asp:TextBox>
                  </td>
                  <td class="auto-style47"></td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
               <tr>
                  <td class="auto-style76"></td>
                  <td class="auto-style38">
                      <asp:Label ID="LbWkStartDate" runat="server" Font-Bold="True" Text="Start Date" Font-Size="14pt" style="font-size: medium"></asp:Label>
                   </td>
                  <td class="auto-style39">
                      <asp:DropDownList ID="ddlWorkStartDay" runat="server">
                      </asp:DropDownList>
                      &nbsp;
                      <asp:DropDownList ID="ddlWorkStartMonth" runat="server">
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
                      &nbsp;
                      <asp:DropDownList ID="ddlWorkStartYear" runat="server">
                      </asp:DropDownList>
                   </td>
                  <td class="auto-style40"></td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">
                      &nbsp;&nbsp;&nbsp;
                      </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style76"></td>
                  <td class="auto-style38">
                      <asp:Label ID="LbWkEndDate" runat="server" Font-Bold="True" Text="End Date" Font-Size="14pt" style="font-size: medium"></asp:Label>
                  </td>
                  <td class="auto-style39">
                      <asp:DropDownList ID="ddlWorkEndDay" runat="server">
                      </asp:DropDownList>
                      &nbsp;
                      <asp:DropDownList ID="ddlWorkEndMonth" runat="server">
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
                      &nbsp;
                      <asp:DropDownList ID="ddlWorkEndYear" runat="server">
                      </asp:DropDownList>
                  </td>
                  <td class="auto-style40"></td>
              </tr>
              <tr>
                  <td class="auto-style78"></td>
                  <td class="auto-style79"></td>
                  <td class="auto-style80"></td>
                  <td class="auto-style52"></td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">
                      <asp:Button ID="workAddBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#33CC33" Text="Add" style="font-size: medium; color: #CC3300;" OnClick="workAddBtn_Click" />
                  </td>
                  <td class="auto-style35">
                      <asp:Label ID="lblMoreQualification1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="10pt" ForeColor="#CC0066" Text="Click add button to add more working experience"></asp:Label>
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">
                      &nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td colspan="4">
                      <asp:GridView ID="GViewWorkExp" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False" OnRowCommand="GViewWorkExp_RowCommand" OnRowDeleting="GViewWorkExp_RowDeleting" >
                          <AlternatingRowStyle BackColor="White" />
                          <Columns>
                              <asp:BoundField DataField="CompanyName" HeaderText="CompanyName " />
                              <asp:BoundField DataField="PositionHeld" HeaderText="PositionHeld" />
                              <asp:BoundField DataField="JobDescriprtion" HeaderText="JobDescriprtion" />
                              <asp:BoundField DataField="SalaryReceived" HeaderText="SalaryReceived" />
                              <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                              <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                              <asp:BoundField DataField="ApplicantID_FK" HeaderText="ApplicantID" />
                                   <asp:TemplateField ShowHeader="False">
                                  <ItemTemplate>
                                      <asp:LinkButton ID="LinkBtnWorkDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
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
                  <td class="auto-style77">&nbsp;</td>
                  <td class="auto-style11" colspan="2">
                      <asp:Label ID="lblworkExp" runat="server" style="font-weight: 700; color: #669900"></asp:Label>
                  </td>
                  <td>&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style77">
                      <asp:Button ID="workBackBtn0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" OnClick="workBackBtn_Click" style="font-size: medium" Text="Back" />
                  </td>
                  <td class="auto-style11">&nbsp;</td>
                  <td class="auto-style35">
                      <asp:Button ID="workSaveBtn" runat="server" CssClass="auto-style64" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" OnClick="workSaveBtn_Click" Text="Save" Visible="False" />
                  </td>
                  <td>
                      <asp:Button ID="workNextBtn0" runat="server" CssClass="auto-style64" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" OnClick="workNextBtn_Click" Text="Next" />
                  </td>
              </tr>
                                   
                      </table>
                      </asp:Panel>
                     
                  </td>
              </tr>
          </table>
    </asp:View>
    <asp:View ID="ViewDocuments" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
            <tr>
                <td colspan="4">
                    <asp:Label ID="LbOtherDocm" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Upload  Documents" style="font-style: italic; color: #CC3300;"></asp:Label>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72" colspan="4">
                    <asp:Label ID="lblDoc1" runat="server" style="color: #669900; font-weight: 700;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Button ID="DocTryAgain" runat="server" ForeColor="#CC3300" Height="35px" style="font-weight: 700; font-size: medium; color: #CC3300" Text="Try Again" Visible="False" Width="83px" OnClick="DocTryAgain_Click" />
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="DocumentNextBtn1" runat="server" ForeColor="#CC3300" Height="35px" OnClick="DocumentNextBtn_Click" style="font-weight: 700; font-size: medium; color: #CC3300" Text="View Application Summary" Visible="False" Width="219px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style72" colspan="4">
                    <asp:Panel ID="PanelAppDocument" Visible="false" runat="server">
                        <table style="width:100%;">
                            <tr>
                                <td colspan="4">
                                    <asp:Label ID="LbOtherDocm0" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" style="font-style: italic; color: #CC3300;" Text="Upload  Documents"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="LbDocName" runat="server" Font-Bold="True" Font-Size="14pt" Text="Document Type" style="font-size: medium"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDocumentTpe" runat="server" Height="16px" Width="221px">
                        <asp:ListItem>--Please Select--</asp:ListItem>
                        <asp:ListItem>NYSC Cert</asp:ListItem>
                        <asp:ListItem>Degree Cert </asp:ListItem>
                        <asp:ListItem>Birth Cert</asp:ListItem>
                        <asp:ListItem>Other Cert</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">
                    <asp:Label ID="LbDocFile0" runat="server" Font-Bold="True" Text=" Choose File" Font-Size="14pt" style="font-size: medium"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="UploadDocument" runat="server" />
                    &nbsp;
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72">
                    &nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="docAddBtn" runat="server" OnClick="docAddBtn_Click" style="color: #CC3300; font-weight: 700; font-size: medium" Text="Add" />
                    &nbsp; &nbsp;&nbsp;
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13" colspan="4">
                    &nbsp;&nbsp;<asp:GridView ID="GViewDoc" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCommand="GViewDoc_RowCommand" OnRowDeleting="GViewDoc_RowDeleting">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="DocumentType" HeaderText="Document Type" />
                            <asp:BoundField DataField="DocumentPath" HeaderText="Document Path" />
                            <asp:BoundField DataField="ApplicantID_FK" HeaderText="ApplicantID" />
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkBtnDocDelete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" CommandArgument='<%#DataBinder.Eval(Container,"DataItem.DocumentID") %>'></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                           <%-- <asp:BoundField DataField="EmployeeID_FK" HeaderText="EmpID" />--%>
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
                <td class="auto-style72">&nbsp;</td>
                <td class="auto-style14" colspan="2">
                    <asp:Label ID="lblDoc" runat="server" style="color: #669900; font-weight: 700;"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style41">
                    <asp:Button ID="docBackBtn0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" OnClick="docBackBtn_Click" Text="Back" />
                </td>
                <td class="auto-style42"></td>
                <td class="auto-style43">
                    <asp:Button ID="docSaveBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" OnClick="docSaveBtn_Click" Text="Save" Visible="False" />
                </td>
                <td class="auto-style43">
                    <asp:Button ID="DocumentNextBtn0" runat="server" ForeColor="#CC3300" Height="35px" OnClick="DocumentNextBtn_Click" style="font-weight: 700; font-size: medium; color: #CC3300" Text="View Application Summary" Width="219px" />
                </td>
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
    <asp:View ID="SummaryView" runat="server">
        <table style="border-color: #CC3300; border-style: solid; width:100%;">
            <tr>
                <td colspan="4">
                    <asp:Label ID="LbSummary" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Application Summary" style="color: #CC3300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <table style="width: 80%;  margin-left:75px; ">
                        <tr>
                            <td class="auto-style85" colspan="5"><strong style="color: #CC3300; font-size: large">Personal Details</strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style85" colspan="5">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style59" colspan="5" >
                                <asp:Image ID="ImagePassport" runat="server" Height="167px" ImageAlign="Middle" Width="171px" BorderColor="#CC3300" BorderWidth="3px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">
                                &nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>Dept Applied to:</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblDeptAppliedTo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>Position applied for:</strong></td>
                            <td>
                                <asp:Label ID="lblPositionAppliedFor" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>Title</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lbAppTitle" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>Application Num</strong></td>
                            <td>
                                <asp:Label ID="lbAppNum" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>First Name</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblFirstName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>Nationality</strong></td>
                            <td>
                                <asp:Label ID="lblNationality" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>Middle Name</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblMiddleName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>State of Origin</strong></td>
                            <td>
                                <asp:Label ID="lblStateofOrigin" runat="server" Enabled="False" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">
                                &nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>Last Name</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblLastName" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>Sen. District</strong></td>
                            <td>
                                <asp:Label ID="lblSenDist" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style87"><strong>Religion</strong></td>
                            <td class="auto-style88">
                                <asp:Label ID="lblReligion" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td class="auto-style89"></td>
                            <td class="auto-style90"><strong>LGA</strong></td>
                            <td class="auto-style89">
                                <asp:Label ID="lblLGA" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">
                                &nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>Gender</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblGender" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>Home Town</strong></td>
                            <td>
                                <asp:Label ID="lblHomeTown" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">
                                &nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>Marital Status</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblMaritalStatus" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>Email</strong></td>
                            <td>
                                <asp:Label ID="lblEmail" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>DOB</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblDOB" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>PhoneNo</strong></td>
                            <td>
                                <asp:Label ID="lblPhoneNo" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85"><strong>Age</strong></td>
                            <td class="auto-style94">
                                <asp:Label ID="lblAge" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            <td class="auto-style95"><strong>ContactAddress</strong></td>
                            <td>
                                <asp:Label ID="lblContactAddress" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style85">
                                &nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85">
                                <asp:Button ID="btnEditPersonalDetails" runat="server" OnClick="btnEditPersonalDetails_Click" style="font-weight: 700; color: #CC3300; font-size: medium" Text="Click to Edit" />
                            </td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style59" colspan="5"><strong style="color: #CC3300; font-size: large">Qualification</strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style48" colspan="5">
                                <asp:GridView ID="GViewQualifSummary" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Height="117px">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="InstitutionName" HeaderText="InstitutionName" />
                                        <asp:BoundField DataField="Course" HeaderText="Course" />
                                        <asp:BoundField DataField="QualificationType" HeaderText="QualificationType" />
                                        <asp:BoundField DataField="Grade" HeaderText="Grade" />
                                        <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                        <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                        
                                      <%--  <asp:BoundField DataField="EmployeeID_FK" HeaderText="EmpID" />--%>
                                        
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
                            <td class="auto-style58"></td>
                            <td class="auto-style53"></td>
                            <td class="auto-style52"></td>
                            <td class="auto-style54"></td>
                            <td class="auto-style52"></td>
                        </tr>
                        <tr>
                            <td class="auto-style59" colspan="5"><strong style="color: #CC3300; font-size: large">Professional Qualification</strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style48" colspan="5">
                                <asp:GridView ID="GViewProfQualifSummary" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="CertificationName" HeaderText="CertificationName" />
                                        <asp:BoundField DataField="Stage" HeaderText="Stage" />
                                        <asp:BoundField DataField="CertificateNo" HeaderText="CertificateNo" />
                                        <asp:BoundField DataField="CertYear" HeaderText="Obtained Year" />
                                       <%-- <asp:BoundField DataField="employeeID_FK" HeaderText="EmpID" />--%>
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
                            <td class="auto-style86">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style51" colspan="3"><strong style="color: #CC3300; font-size: large">Working&nbsp; Experience</strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style48" colspan="5">
                                <asp:GridView ID="GViewWorkExpSummary" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" />
                                        <asp:BoundField DataField="PositionHeld" HeaderText="PositionHeld" />
                                        <asp:BoundField DataField="JobDescriprtion" HeaderText="JobDescriprtion" />
                                        <asp:BoundField DataField="SalaryReceived" HeaderText="SalaryReceived" />
                                        <asp:BoundField DataField="StartYear" HeaderText="StartYear" />
                                       
                                        <asp:BoundField DataField="EndYear" HeaderText="EndYear" />
                                       
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
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style59" colspan="5"><strong style="color: #CC3300; font-size: large">Uploaded Document</strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style59" colspan="5">
                                <asp:GridView ID="GViewDocSummary" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="DocumentType" HeaderText="DocumentType" />
                                        <asp:BoundField DataField="DocumentPath" HeaderText="DocumentPath" />
                                       <%-- <asp:BoundField DataField="EmployeeID_FK" HeaderText="EmpID" />--%>
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
                            <td class="auto-style85">&nbsp;</td>
                            <td class="auto-style94">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style95">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td>
                    <asp:Button ID="submitAppBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC3300" Text="Submit Application" OnClick="submitAppBtn_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style56">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>

    <asp:View ID="ContinueApplicaltion" runat="server">
        <table style="border-style: solid; border-color: #CC3300; width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <table style="width: 75%; margin-left:90px">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label20" runat="server" style="font-weight: 700; font-style: italic" Text="Please enter your application number"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label18" runat="server" style="font-weight: 700" Text="ApplicationNumber:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtApplicationNum" runat="server" Width="291px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label19" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="continueAppBtn" runat="server" Height="24px" style="font-weight: 700" Text="Continue" OnClick="continueAppBtn_Click" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:View>

    <asp:View ID="ViewLandingPage" runat="server">
        <table style="border-style: solid; border-color: #CC3300; width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td colspan="4">
                    <asp:Label ID="lblFinalSumit" runat="server" style="font-weight: 700; color: #CC3300;" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnFinalSubmit" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#990033" Height="24px" OnClick="btnFinalSubmit_Click" style="font-weight: 700" Text="Finish" />
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
        </table>
    </asp:View>

</asp:MultiView>



        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Home</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Biodata</asp:LinkButton>
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Qualification</asp:LinkButton>
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">Professional Qualification </asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">Work Experience</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click">Documents</asp:LinkButton>
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">Summary</asp:LinkButton>
        </td>
    </tr>
</table>




