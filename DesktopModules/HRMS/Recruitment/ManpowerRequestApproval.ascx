<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManpowerRequestApproval.ascx.cs" Inherits="DesktopModules_HRMS_ManpowerRequestApproval" %>
<asp:Panel ID="panelMain" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Panel ID="panelMenu" runat="server" BackColor="#FFFF99" Height="51px" Width="932px">
                    <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="REQUEST FOR MANPOWER" Width="650px"></asp:Label>
                    <asp:Button ID="bttnBack" runat="server" BackColor="#FF99FF" Height="50px" Text="Back to Line Manager Dashboard" Width="250px" />
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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text="Requesting Supervisor" Width="230px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSuper" runat="server" Enabled="False" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label3" runat="server" Text="Department" Width="230px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDept" runat="server" Enabled="False" Width="350px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="panelRquest" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Job Description" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="500px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Job Role" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" Height="200px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                            </td>
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
                                <asp:DropDownList ID="DropDownList2" runat="server" Width="150px">
                                </asp:DropDownList>
                                <asp:Label ID="Label12" runat="server" Text="Max" Width="50px"></asp:Label>
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="150px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="Minimum Requirement" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList3" runat="server" Width="150px">
                                </asp:DropDownList>
                                <asp:DropDownList ID="DropDownList4" runat="server" Width="150px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="Discipline" Width="150px"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server" Width="500px"></asp:TextBox>
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
            <td>
                <asp:Panel ID="panelApproval" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Large" Text="Approval Chain"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" Width="500px">
                                    <Columns>
                                        <asp:BoundField HeaderText="Name" />
                                        <asp:BoundField HeaderText="Position" />
                                        <asp:BoundField HeaderText="Decision" />
                                        <asp:BoundField HeaderText="Date" />
                                    </Columns>
                                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                    <RowStyle BackColor="White" ForeColor="#003399" />
                                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <table class="auto-style1">
                                    <tr>
                                        <td class="auto-style5">
                                            <asp:Label ID="Label18" runat="server" Text="Justification For Approval / Disapproval" Width="300px"></asp:Label>
                                        </td>
                                        <td colspan="2">
                                            <asp:TextBox ID="TextBox8" runat="server" Height="200px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style6">
                                            <asp:Label ID="Label14" runat="server" Text="Current Approver" Width="300px"></asp:Label>
                                        </td>
                                        <td class="auto-style8">
                                            <asp:Button ID="Button1" runat="server" Text="APPROVE" Width="150px" />
                                        </td>
                                        <td class="auto-style4">
                                            <asp:Button ID="Button2" runat="server" Text="DISAPPROVE" Width="150px" />
                                        </td>
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

