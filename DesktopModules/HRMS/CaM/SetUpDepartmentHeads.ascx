<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SetUpDepartmentHeads.ascx.cs" Inherits="DesktopModules_HRMS_SetUpDepartmentHeads" %>



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
    <asp:Label ID="Label1" runat="server" Text="SETUP DEPARTMENTAL HEAD" Font-Bold="True" Font-Size="XX-Large" Width="650px"></asp:Label>
    <asp:Button ID="bttnBack" runat="server" BackColor="#FF99FF" Height="50px" OnClick="bttnBack_Click" Text="Back to Master Dashboard" Width="200px" />
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
                            <asp:Label ID="Label6" runat="server" Text="Department"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDepartment" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartment_SelectedIndexChanged" Width="300px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="bttnEdit" runat="server"  Text="Edit Record" Visible="False" Width="210px" OnClick="bttnEdit_Click" BackColor="#99CCFF" Height="30px" />
                        </td>
                        <td>
                            <asp:Button ID="bttnNew" runat="server" Text="New Department Head" Visible="False" Width="200px" OnClick="bttnNew_Click" BackColor="#99CCFF" Height="30px"  />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Panel ID="PanelLeft" runat="server" BorderColor="#663300" BorderWidth="1px" ScrollBars="Horizontal" Width="400px" BackColor="White">
                    <asp:ListBox ID="lbHeads" runat="server" Height="483px" Width="380px" OnSelectedIndexChanged="lbHeads_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
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
                                            <asp:Label ID="Label2" runat="server" Text="Department Name" Width="130px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtDeptName" runat="server" Width="300px" Enabled="False"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style2">
                                            <asp:Label ID="Label3" runat="server" Text="Department Head" Width="130px"></asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:DropDownList ID="ddlEmp" runat="server" Width="305px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4">
                                            <asp:Label ID="Label5" runat="server" Text="Head Start Date" Width="130px"></asp:Label>
                                        </td>
                                        <td>&nbsp;<asp:DropDownList ID="ddlsDay" runat="server">
                                            </asp:DropDownList>
                                            &nbsp; &nbsp;
                                            <asp:DropDownList ID="ddlsMonth" runat="server">
                                                <asp:ListItem Value="00">Month</asp:ListItem>
                                                <asp:ListItem Value="1">Jan</asp:ListItem>
                                                <asp:ListItem Value="2">Feb</asp:ListItem>
                                                <asp:ListItem Value="3">Mar</asp:ListItem>
                                                <asp:ListItem Value="4">Apr</asp:ListItem>
                                                <asp:ListItem Value="5">May</asp:ListItem>
                                                <asp:ListItem Value="6">Jun</asp:ListItem>
                                                <asp:ListItem Value="7">Jul</asp:ListItem>
                                                <asp:ListItem Value="8">Aug</asp:ListItem>
                                                <asp:ListItem Value="9">Sep</asp:ListItem>
                                                <asp:ListItem Value="10">Oct</asp:ListItem>
                                                <asp:ListItem Value="11">Nov</asp:ListItem>
                                                <asp:ListItem Value="12">Dec</asp:ListItem>
                                            </asp:DropDownList>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:DropDownList ID="ddlsYear" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4">
                                            <asp:Label ID="Label4" runat="server" Text="Head End  Date" Width="130px"></asp:Label>
                                        </td>
                                        <td>&nbsp;<asp:DropDownList ID="ddleDay" runat="server">
                                            </asp:DropDownList>
                                            &nbsp; &nbsp;
                                            <asp:DropDownList ID="ddleMonth" runat="server">
                                                <asp:ListItem Value="00">Month</asp:ListItem>
                                                <asp:ListItem Value="1">Jan</asp:ListItem>
                                                <asp:ListItem Value="2">Feb</asp:ListItem>
                                                <asp:ListItem Value="3">Mar</asp:ListItem>
                                                <asp:ListItem Value="4">Apr</asp:ListItem>
                                                <asp:ListItem Value="5">May</asp:ListItem>
                                                <asp:ListItem Value="6">Jun</asp:ListItem>
                                                <asp:ListItem Value="7">Jul</asp:ListItem>
                                                <asp:ListItem Value="8">Aug</asp:ListItem>
                                                <asp:ListItem Value="9">Sep</asp:ListItem>
                                                <asp:ListItem Value="10">Oct</asp:ListItem>
                                                <asp:ListItem Value="11">Nov</asp:ListItem>
                                                <asp:ListItem Value="12">Dec</asp:ListItem>
                                            </asp:DropDownList>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:DropDownList ID="ddleYear" runat="server">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style6">&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">&nbsp;</td>
                                        <td class="auto-style6">
                                            <asp:Button ID="bttnCancel" runat="server" Text="Cancel" Visible="False" Width="100px" OnClick="bttnCancel_Click" Height="30px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style4">&nbsp;</td>
                                        <td>
                                            <asp:Button ID="bttnSave" runat="server"  Text="Save Record" Width="100px" OnClick="bttnSave_Click" Height="30px" />
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