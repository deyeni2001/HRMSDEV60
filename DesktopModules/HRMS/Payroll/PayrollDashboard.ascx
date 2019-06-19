<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PayrollDashboard.ascx.cs" Inherits="DesktopModules_HRMS_Payroll_PayrollDashboard" %>



<asp:Panel ID="panelMain" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="PAYROLL DASHBOARD" BackColor="#99FF66" BorderStyle="Groove" Width="700px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="panelMenu" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Button ID="Button6" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="EARNINGS" Width="180px" OnClick="Button6_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="DEDUCTIONS" Width="180px" OnClick="Button1_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="PAY GENERATION" Width="180px" OnClick="Button2_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button7" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" OnClick="Button6_Click" Text="LOANS" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button8" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="SETTINGS" Width="180px" />
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
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/hrms/payroll.png" Width="700px" />
            </td>
        </tr>
    </table>
</asp:Panel>
