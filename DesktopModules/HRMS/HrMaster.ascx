<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HrMaster.ascx.cs" Inherits="DesktopModules_HRMS_HrMaster" %>


<asp:Panel ID="panelMain" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="HR MASTER" BackColor="#99FF66" BorderStyle="Groove" Width="700px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="panelMenu" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Button ID="Button6" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Departments" Width="180px" OnClick="Button6_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Company" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Job" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Employee Grade" Width="180px" OnClick="Button3_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Leave" Width="180px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Job Competencies" Width="180px" />
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
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/hrms/settings.png" Width="700px" />
            </td>
        </tr>
    </table>
</asp:Panel>

