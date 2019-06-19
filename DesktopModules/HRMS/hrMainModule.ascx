<%@ Control Language="C#" AutoEventWireup="true" CodeFile="hrMainModule.ascx.cs" Inherits="DesktopModules_HRMS_hrMainModule" %>


<asp:Panel ID="panelMain" runat="server" Width="896px">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" BackColor="#99FF66" BorderStyle="Groove" Font-Bold="True" Font-Size="XX-Large" Text="HR MAIN MODULE" Width="650px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="panelMenu" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Button ID="Button13" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Manage Directory" Width="250px" OnClick="Button13_Click" />
                            </td>
                        </tr>
                        
                        <tr>
                            <td>
                                <asp:Button ID="Button6" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Training" Width="250px" />
                            </td>
                        </tr>
                       
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Carrear Management" Width="250px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Recruitment" Width="250px" />
                            </td>
                        </tr>
                       
                        <tr>
                            <td>
                                <asp:Button ID="Button8" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Payroll Management" Width="250px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button9" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Employee Data Management" Width="250px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button10" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Employee Retirement / Termination" Width="250px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button11" runat="server" Font-Bold="True" Font-Names="Corbel" Height="50px" Text="Benefits" Width="250px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td></td>
            <td>
                <asp:Image ID="Image2" runat="server" Height="650px" ImageUrl="~/images/hrms/hrmain.png" Width="650px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Panel>
