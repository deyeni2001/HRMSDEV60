<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Dashboard.ascx.cs" Inherits="DesktopModules_HRMS_Dashboard" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
<table class="auto-style1">
    <tr>
        <td>


<asp:Panel ID="panelMenu" runat="server" BackColor="#FFFF99">
    <asp:Label ID="lblWelcome" runat="server" Text="EMPLOYEE DASHBOARD" Font-Bold="True" Font-Size="XX-Large" Width="900px"></asp:Label>
</asp:Panel>


        </td>
    </tr>
    <tr>
        <td>


    <asp:Label ID="lblName" runat="server" Font-Bold="False" Font-Size="XX-Large" Width="900px" ForeColor="#0000CC"></asp:Label>


        </td>
    </tr>
    <tr>
        <td>
    <table class="auto-style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Panel ID="PanelRight" runat="server">
                    <asp:Panel ID="panelNotification" runat="server">
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="gvDashboard" runat="server" Width="900px">
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </asp:Panel>
            </td>
        </tr>
    </table>
        </td>
    </tr>
</table>