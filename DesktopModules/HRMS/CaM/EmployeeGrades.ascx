<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeeGrades.ascx.cs" Inherits="DesktopModules_HRMS_CaM_EmployeeGrades" %>



<style type="text/css">
    .auto-style1 {
        width: 184px;
    }
    .auto-style2 {
        height: 26px;
    }
    .auto-style3 {
        width: 100%;
    }
    .auto-style4 {
        width: 6px;
    }
    .auto-style5 {
        width: 7px;
    }
    .auto-style6 {
        width: 8px;
    }
    .auto-style7 {
        width: 19px;
    }
    .auto-style9 {
        width: 292px;
    }
    </style>


<asp:Panel ID="panelMenu" runat="server" BackColor="#FFFF99" Height="51px">
    <asp:Label ID="Label1" runat="server" Text="SETUP EMPOYEE GRADES" Font-Bold="True" Font-Size="XX-Large" Width="650px"></asp:Label>
    <asp:Button ID="bttnBack" runat="server" BackColor="#FF99FF" Height="50px"  Text="Back to Master Dashboard" Width="200px" OnClick="bttnBack_Click" />
</asp:Panel>

<asp:Panel ID="PanelMain" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <table class="auto-style3">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="bttnEdit" runat="server"  Text="Edit Record" Visible="False" Width="210px"  BackColor="#99CCFF" Height="30px" OnClick="bttnEdit_Click" />
                        </td>
                        <td>
                            <asp:Button ID="bttnNew" runat="server" Text="New Grade" Visible="False" Width="200px"  BackColor="#99CCFF" Height="30px" OnClick="bttnNew_Click"  />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Panel ID="PanelLeft" runat="server" BorderColor="#663300" BorderWidth="1px" ScrollBars="Horizontal" Width="385px" BackColor="White">
                    <asp:ListBox ID="lbGrades" runat="server" Height="483px" Width="380px"  AutoPostBack="True" OnSelectedIndexChanged="lbGrades_SelectedIndexChanged"></asp:ListBox>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="PanelRight" runat="server" BorderColor="#663300" BorderWidth="2px" Height="500px" Visible="False" Width="500px">
                    <table class="auto-style3">
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>
                                <table class="auto-style1">
                                    <tr>
                                        <td class="auto-style4">
                                            <asp:Label ID="Label2" runat="server" Text="Grade Name" Width="130px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtGradeName" runat="server" Width="300px" Enabled="False"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style2">
                                            <asp:Label ID="Label3" runat="server" Text="Grade Code" Width="130px"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:TextBox ID="txtGradeCode" runat="server" Enabled="False" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4">
                                            <asp:Label ID="Label5" runat="server" Text="Grade Description" Width="130px"></asp:Label>
                                        </td>
                                        <td>&nbsp;<asp:TextBox ID="txtGradeDescription" runat="server" Enabled="False" Height="95px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                                            &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4">
                                            &nbsp;</td>
                                        <td>&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style6">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style6">
                                            <asp:Button ID="bttnCancel" runat="server" Text="Cancel" Visible="False" Width="100px" Height="30px" OnClick="bttnCancel_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4">&nbsp;</td>
                                        <td>
                                            <asp:Button ID="bttnSave" runat="server"  Text="Save Record" Width="100px"  Height="30px" OnClick="bttnSave_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblRecId" runat="server" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Panel>