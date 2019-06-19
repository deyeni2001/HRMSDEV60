<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EssDashboard.ascx.cs" Inherits="DesktopModules_HRMS_EssDashboard" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<asp:Panel ID="panelMain" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="EMPLOYEE SELF SERVICE" BackColor="#99FF66" BorderStyle="Groove" Width="700px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="panelMenu" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button7" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" OnClick="Button6_Click" Text="Organization Directory" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Employee Data Management" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Leave Management" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Appraisals" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button8" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="My Payslips" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Request For Tranfer" Width="180px" />
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
                </asp:Panel>
            </td>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/hrms/ess_main.png" Width="700px" />
            </td>
        </tr>
    </table>
</asp:Panel>

