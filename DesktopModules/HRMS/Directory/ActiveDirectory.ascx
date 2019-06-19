<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ActiveDirectory.ascx.cs" Inherits="DesktopModules_HRMS_ActiveDirectory" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 23px;
    }
    .auto-style3 {
        height: 26px;
    }
    </style>

<table class="auto-style1">
    <tr>
        <td>

<asp:Panel ID="panelMenu" runat="server" BackColor="#FFFF99" Height="51px" Width="932px">
    <asp:Label ID="Label5" runat="server" Text="MANAGE EMPLOYEES IN DIRECTORY" Font-Bold="True" Font-Size="XX-Large" Width="650px"></asp:Label>
    <asp:Button ID="bttnBack" runat="server" Height="50px" Text="Back to HR Dashboard" Width="200px" BackColor="#FF99FF" OnClick="bttnBack_Click" />
</asp:Panel>

        </td>
    </tr>
    <tr>
        <td>
            <table class="auto-style1">
                <tr>
                    <td>
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Width="300px"></asp:Label>
                    </td>
                    <td>

            <asp:Button ID="bttnAddPersonnel" runat="server" Text="Add New Personnel" OnClick="bttnAddPersonnel_Click" Width="200px" BackColor="#99CCFF" Height="30px" />
                    </td>
                    <td>

            <asp:Button ID="bttnEdit" runat="server" Text="Edit Personnel Details" OnClick="bttnEdit_Click" Visible="False" Width="200px" BackColor="#99CCFF" Height="30px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table class="auto-style1">
                <tr>
                    <td>
            <asp:Panel ID="Panel1" runat="server" Direction="LeftToRight" HorizontalAlign="Left" Width="400px" BorderColor="#663300" BorderWidth="1px" BackColor="White">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:TreeView ID="tvEmployeeList" runat="server" BackColor="White" Font-Bold="True" Height="600px" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" ShowLines="True" Width="380px">
                                <NodeStyle Font-Size="Medium" />
                                <RootNodeStyle Font-Bold="True" Font-Size="Large" />
                                <SelectedNodeStyle Font-Bold="True" Font-Size="Large" ForeColor="Red" />
                            </asp:TreeView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
                    </td>
                    <td>

            <asp:Panel ID="panelActiveDirectory" runat="server" Width="500px" BorderColor="#663300" BorderWidth="2px">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style2"></td>
                        <td class="auto-style2">
                            <asp:Label ID="LbAvailablePosition2" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Personnel Status"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="True" Width="305px">
                                <asp:ListItem Selected="True" Value="1">Active</asp:ListItem>
                                <asp:ListItem Value="2">Inactive</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="LbAvailablePosition0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Department / Unit"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlEmpDept" runat="server" Width="305px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td class="auto-style3">
                            <asp:Label ID="LbAvailablePosition1" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Job Title"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtJobTitle" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style3"></td>
                        <td class="auto-style3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LBTitle" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Title"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:DropDownList ID="ddlTitle" runat="server" Height="17px" Width="305px">
                                <asp:ListItem Selected="True" Value="***Please Select***">***Select Title***</asp:ListItem>
                                <asp:ListItem>Dr</asp:ListItem>
                                <asp:ListItem>Miss</asp:ListItem>
                                <asp:ListItem>Mr</asp:ListItem>
                                <asp:ListItem>Mrs</asp:ListItem>
                                <asp:ListItem>Prof</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style18">
                     <%--<asp:RequiredFieldValidator ID="fNameReqFieldVal0" runat="server" ControlToValidate="txtFName" Display="Dynamic" ErrorMessage="FirstNameRequired" SetFocusOnError="True">FirstName Required</asp:RequiredFieldValidator>
              --%>  &nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LBfName" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="First Name"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtFName" runat="server" Width="300px"></asp:TextBox>
                            &nbsp;</td>
                        <td class="auto-style18"></td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LBMidName" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Middle Name"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtMName" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style47"></td>
                        <td class="auto-style65">
                            <asp:Label ID="LBlName" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Last Name"></asp:Label>
                        </td>
                        <td class="auto-style66">
                            <asp:TextBox ID="txtLName" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style67">
           <%-- <asp:RequiredFieldValidator ID="lNameReqFieldVal" runat="server" ControlToValidate="txtLName" Display="Dynamic" ErrorMessage="LastNameRequired" SetFocusOnError="True">LastNameRequired</asp:RequiredFieldValidator>
       --%>  </td>
                        <td class="auto-style68"></td>
                    </tr>
                    <tr>
                        <td class="auto-style47">&nbsp;</td>
                        <td class="auto-style65">
                            <asp:Label ID="LBlName0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="UserName"></asp:Label>
                        </td>
                        <td class="auto-style66">
                            <asp:TextBox ID="txtUserName" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style67">
              <%--  <asp:RequiredFieldValidator ID="emailReqFieldVal" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="EmailAddress Required" SetFocusOnError="True">EmailAddress Required</asp:RequiredFieldValidator>
               <br />
               <asp:RegularExpressionValidator ID="emailRegularExpressionVal" runat="server" Display="Dynamic" ErrorMessage="Invalid Email Address" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Invalid Email Address</asp:RegularExpressionValidator>
        --%> &nbsp;</td>
                        <td class="auto-style68">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LbEmail" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Email"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td><%--  <asp:RequiredFieldValidator ID="emailReqFieldVal" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="EmailAddress Required" SetFocusOnError="True">EmailAddress Required</asp:RequiredFieldValidator>
               <br />
               <asp:RegularExpressionValidator ID="emailRegularExpressionVal" runat="server" Display="Dynamic" ErrorMessage="Invalid Email Address" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Invalid Email Address</asp:RegularExpressionValidator>
        --%></td>
                        <td class="auto-style18">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LBPhnNo0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Phone Extension"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtPhnExt" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LBPhnNo" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Mobile Number"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtmobNum" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LbContAddr" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Office Room"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:TextBox ID="txtOfficeRoom" runat="server" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LbGender0" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Type"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:RadioButtonList ID="rbtnEmpType" runat="server" Font-Bold="True" Font-Size="12pt" Height="35px" RepeatDirection="Horizontal">
                                <asp:ListItem Selected="True" Value="1">Employee</asp:ListItem>
                                <asp:ListItem Value="2">Contractor</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style30">&nbsp;</td>
                        <td class="auto-style74">
                            <asp:Label ID="LbPaasport" runat="server" Font-Bold="True" Font-Size="14pt" style="font-size: medium" Text="Upload Passport"></asp:Label>
                        </td>
                        <td class="auto-style26">
                            <asp:FileUpload ID="UploadPassport" runat="server" Width="300px" />
                        </td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style25"></td>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style28">
                            <asp:Image ID="imgPassport" runat="server" BorderColor="#000066" BorderWidth="1px" Height="179px" Width="170px" />
                            &nbsp;<asp:Label ID="lblPassportName" runat="server"></asp:Label>
                            &nbsp;&nbsp;&nbsp;<asp:Button ID="passportUploadBtn" runat="server" Font-Bold="True" ForeColor="#33CC33" style="color: #CC3300" Text="Upload" OnClick="passportUploadBtn0_Click1" />
                        </td>
                        <td class="auto-style20">&nbsp;</td>
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
                            <asp:Button ID="btnSave" runat="server" Text="Save" Width="100px" OnClick="btnSave_Click" Height="30px" />
                        </td>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style21">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style52"></td>
                        <td class="auto-style5"></td>
                        <td class="auto-style28">
                            <asp:Label ID="LbDetailsAdded" runat="server" Font-Italic="True" ForeColor="#CC0066"></asp:Label>
                            <asp:Label ID="SpecialImageName" runat="server" Font-Italic="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                            <asp:Label ID="DepEmpCode" runat="server" Font-Italic="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                        </td>
                        <td class="auto-style20"></td>
                        <td class="auto-style22"></td>
                    </tr>
                </table>
            </asp:Panel>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>



