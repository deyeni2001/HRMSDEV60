<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SetUpDepartment.ascx.cs" Inherits="DesktopModules_HRMS_SetUpDepartment" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style3 {
        width: 411px;
    }
    .auto-style4 {
        width: 144px;
    }
    .auto-style5 {
        width: 144px;
        height: 30px;
    }
    .auto-style6 {
        height: 30px;
    }
</style>

<asp:Panel ID="panelMenu" runat="server" BackColor="#FFFF99" Height="51px" Width="932px">
    <asp:Label ID="Label5" runat="server" Text="SETUP DEPARTMENTS" Font-Bold="True" Font-Size="XX-Large" Width="650px"></asp:Label>
    <asp:Button ID="bttnBack" runat="server" Height="50px" Text="Back to Master Dashboard" Width="200px" BackColor="#FF99FF" OnClick="bttnBack_Click" />
</asp:Panel>

<asp:Panel ID="Panel1" runat="server" Height="544px" Width="931px">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Button ID="bttnNew" runat="server" OnClick="bttnNew_Click" Text="Create New Department" Width="200px" BackColor="#99CCFF" Height="30px" />
                        </td>
                        <td>
                            <asp:Button ID="bttnEdit" runat="server" OnClick="bttnEdit_Click" Text="Edit Department" Visible="False" Width="200px" BackColor="#99CCFF" Height="30px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Panel ID="panelTree" runat="server" Width="400px" BorderColor="#663300" BorderWidth="1px" ScrollBars="Horizontal" BackColor="White">
                    <asp:TreeView ID="TreeView1" runat="server" Height="500px" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" Width="350px" BackColor="White" Font-Bold="True" ShowLines="True">
                        <NodeStyle Font-Size="Medium" />
                        <RootNodeStyle Font-Bold="True" Font-Size="X-Large" />
                        <SelectedNodeStyle Font-Bold="True" Font-Size="X-Large" />
                    </asp:TreeView>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="panelEdit" runat="server" Height="500px" Width="500px" BorderColor="#663300" BorderWidth="2px">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label1" runat="server" Text="Department Name" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDeptName" runat="server" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label2" runat="server" Text="Department / Charge Code" Width="200px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDeptCode" runat="server" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label3" runat="server" Text="Supervising Department" Width="200px"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlSuperDept" runat="server" Width="250px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label4" runat="server" Text="Role in Organization" Width="200px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDeptRole" runat="server" Height="212px" Width="250px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5"></td>
                            <td class="auto-style6">
                                <asp:Button ID="bttnDelete" runat="server" Text="Cancel" Width="100px" OnClick="bttnDelete_Click" Height="30px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;</td>
                            <td>
                                <asp:Button ID="bttnSave" runat="server" OnClick="bttnSave_Click" Text="Save Record" Width="100px" Height="30px" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Panel>

<asp:Label ID="CHECK_isNew" runat="server" Visible="False"></asp:Label>






