<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManpowerRequest.ascx.cs" Inherits="DesktopModules_HRMS_ManpowerRequest" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style3 {
        width: 167px;
    }
    .auto-style4 {
        height: 23px;
    }
    .auto-style5 {
        width: 338px;
    }
    .auto-style6 {
        height: 23px;
        width: 338px;
    }
    .auto-style8 {
        height: 23px;
        width: 201px;
    }
    .auto-style10 {
        width: 201px;
    }
    .auto-style11 {
        width: 229px;
    }
    .auto-style12 {
        width: 1245px;
    }
    .auto-style13 {
        width: 184px;
    }
</style>

<asp:Panel ID="panelMain" runat="server" Width="750px">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Panel ID="panelMenu" runat="server" BackColor="#FFFF99" Height="51px" Width="700px">
                    <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="REQUEST FOR MANPOWER" Width="450px"></asp:Label>
                    <asp:Button ID="bttnBack" runat="server" BackColor="#FF99FF" Height="50px" Text="Back to Line Manager Dashboard" Width="250px" OnClick="bttnBack_Click1" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red" Width="500px"></asp:Label>
            </td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style12">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text="Requesting Supervisor" Width="150px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSuper" runat="server" Enabled="False" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label3" runat="server" Text="Department" Width="150px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDept" runat="server" Enabled="False" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>

            <td class="auto-style12">
                <asp:Panel ID="PanelOldJob" runat="server" Visible="False" Width="700px">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style13">
                                <asp:Label ID="Label22" runat="server" Text="Job Description" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlJobs" runat="server" Width="500px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                <asp:Label ID="Label23" runat="server" Text="Job Role" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtJobRole2" runat="server" Height="200px" TextMode="MultiLine" Width="500px" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                <asp:Label ID="Label24" runat="server" Text="Job Competencies" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:ListView ID="lvJobCompetencies" runat="server">
                                </asp:ListView>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Panel ID="panelRquest" runat="server" Width="700px">
                    <table class="auto-style1">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Number Of Personnel" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlNumber" runat="server" Width="100px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Employment Type" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="rblEmpType" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="1">Full Time</asp:ListItem>
                                    <asp:ListItem Value="0">Contract</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Grade Level" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="Min" Width="50px"></asp:Label>
                                <asp:DropDownList ID="ddlGradeMin" runat="server" Width="200px">
                                </asp:DropDownList>
                                <asp:Label ID="Label12" runat="server" Text="Max" Width="50px"></asp:Label>
                                <asp:DropDownList ID="ddlGradeMax" runat="server" Width="200px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="Minimum Requirement ( Education and Technical)" Width="140px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtJobDesc0" runat="server" Height="52px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="Justification" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Height="200px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Panel ID="panelApproval" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <table class="auto-style1">
                                    <tr>
                                        <td class="auto-style5">
                                            &nbsp;</td>
                                        <td colspan="2">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">
                                            &nbsp;</td>
                                        <td class="auto-style8">
                                            <asp:Button ID="Button1" runat="server" Text="Submit" Width="150px" Height="30px" />
                                        </td>
                                        <td class="auto-style4">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style10">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Panel>

