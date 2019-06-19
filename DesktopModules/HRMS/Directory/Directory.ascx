<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Directory.ascx.cs" Inherits="DesktopModules_HRMS_Directory" %>
<style type="text/css">

    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 23px;
    }
    .auto-style9 {
        height: 23px;
        width: 113px;
    }
    .auto-style10 {
        width: 113px;
    }
    .auto-style11 {
        height: 106px;
    }
    .auto-style12 {
        height: 30px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>


<asp:Panel ID="panelMenu" runat="server" BackColor="#FFFF99">
    <asp:Label ID="Label1" runat="server" Text="EMPLOYEE DIRECTORY" Font-Bold="True" Font-Size="XX-Large" Width="650px"></asp:Label>
    <asp:Button ID="bttnBack" runat="server" BackColor="#FF99FF" Height="50px" OnClick="bttnBack_Click" TabIndex="10" Text="Back to Self Service Dashboard" Width="250px" />
</asp:Panel>


        </td>
    </tr>
    <tr>
        <td>
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Panel ID="PanelLeft" runat="server" Width="330px">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="txtSearch" runat="server" ToolTip="Search with Names, Ext ...." Width="240px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Button ID="bttnSearch" runat="server" Text="Search" OnClick="bttnSearch_Click" Height="30px" Width="70px" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TreeView ID="tvEmployeeList" runat="server" BackColor="White" Font-Bold="True" Height="600px" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" ShowLines="True" Width="320px">
                                    <NodeStyle Font-Size="Medium" />
                                    <RootNodeStyle Font-Bold="True" Font-Size="Large" />
                                    <SelectedNodeStyle Font-Bold="True" Font-Size="Large" ForeColor="Red" />
                                </asp:TreeView>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="PanelRight" runat="server">
                    <asp:Panel ID="panelActiveDirectory" runat="server" Width="600px">
                        <table style="width: 100%;">
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td class="auto-style9">
                                    <asp:Image ID="imgPassport" runat="server" Width="200px" BorderStyle="Outset" BorderWidth="1px" BorderColor="#000066" />
                                </td>
                                <td class="auto-style2">
                                    <table class="auto-style1">
                                        <tr>
                                            <td class="auto-style11">
                                                <asp:Label ID="lblName" runat="server" Font-Bold="True" Font-Names="Bell MT" Font-Size="X-Large" ForeColor="#000099"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblJob" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#000099" Font-Names="Bell MT"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style12">
                                                <asp:Label ID="lblDepartment" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#000099" Font-Names="Bell MT"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2"></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label204" runat="server" Font-Size="Medium" Text="Reports To:" Font-Names="Calibri"></asp:Label>
                                                &nbsp;<asp:HyperLink ID="hlBoss" runat="server" Font-Bold="True" Font-Names="Bell MT" Font-Size="Large" ForeColor="#000099">[hlBoss]</asp:HyperLink>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2"></td>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style10">
                                    <asp:Label ID="Label205" runat="server" Font-Size="X-Large" Text="Phone Ext:" Width="180px" Font-Names="Calibri"></asp:Label>
                                </td>
                                <td class="auto-style26">
                                    <asp:Label ID="lblExt" runat="server" Font-Size="X-Large" Font-Bold="True" Font-Names="Bell MT"></asp:Label>
                                </td>
                                <td class="auto-style18">&nbsp;</td>
                                <td class="auto-style21">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style10">
                                    <asp:Label ID="Label206" runat="server" Font-Size="X-Large" Text="Mobile Num:" Width="180px" Font-Names="Calibri"></asp:Label>
                                </td>
                                <td class="auto-style26">
                                    <asp:Label ID="lblMob" runat="server" Font-Bold="True" Font-Names="Bell MT" Font-Size="X-Large"></asp:Label>
                                </td>
                                <td class="auto-style18">&nbsp;</td>
                                <td class="auto-style21">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style10">
                                    <asp:Label ID="Label207" runat="server" Font-Size="X-Large" Text="Office:" Font-Names="Calibri"></asp:Label>
                                </td>
                                <td class="auto-style26">
                                    <asp:Label ID="lblOffice" runat="server" Font-Bold="True" Font-Names="Bell MT" Font-Size="X-Large"></asp:Label>
                                </td>
                                <td class="auto-style18">&nbsp;</td>
                                <td class="auto-style21">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style10">
                                    <asp:Label ID="Label208" runat="server" Font-Size="X-Large" Text="Email:" Font-Names="Calibri"></asp:Label>
                                </td>
                                <td class="auto-style26">
                                    <asp:HyperLink ID="hlEmail" runat="server" Font-Bold="True" Font-Names="Bell MT" Font-Size="X-Large">[hlEmail]</asp:HyperLink>
                                </td>
                                <td class="auto-style18">&nbsp;</td>
                                <td class="auto-style21">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style25">&nbsp;</td>
                                <td class="auto-style10">
                                    <asp:Label ID="Label209" runat="server" Font-Size="X-Large" Text="Category:" Font-Names="Calibri"></asp:Label>
                                </td>
                                <td class="auto-style28">
                                    <asp:Label ID="lblEtype" runat="server" Font-Size="X-Large" Font-Bold="True" Font-Names="Bell MT"></asp:Label>
                                </td>
                                <td class="auto-style20">&nbsp;</td>
                                <td class="auto-style22">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style74" colspan="2">&nbsp;</td>
                                <td class="auto-style18">&nbsp;</td>
                                <td class="auto-style21">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30" colspan="5">&nbsp;</td>
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





