<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Organogram.ascx.cs" Inherits="DesktopModules_HRMS_Organogram" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 25px;
    }
</style>


<asp:Panel ID="panelMenu" runat="server">
    <asp:Label ID="Label1" runat="server" Text="ORGANISATION CHART BUILDER" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
</asp:Panel>


<style type="text/css">

.vertical
{   position:relative;
    width: 2px;
    height: 25px;
    left:50%; 
    background-color: #000000;
}


table 
{
   vertical-align:top;
   text-align:center;
    border-collapse: collapse;
}
table td { border:0;   vertical-align:top;   text-align:center; word-wrap: break-word;
}

    .auto-style3 {
        height: 23px;
    }

</style>

<asp:Panel ID="Panel1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Panel ID="PanelOptions" runat="server" Width="500px">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="Label206" runat="server" Text="Department" Width="200px"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlDept" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="ddlDept_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label207" runat="server" Text="Levels Down" Width="200px"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlLevelsDown" runat="server" Width="200px">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem Value="0">All the way down</asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label208" runat="server" Text="Show Images" Width="200px"></asp:Label>
                            </td>
                            <td class="auto-style3">
                                <asp:CheckBox ID="cb_Images" runat="server" Width="200px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label209" runat="server" Text="Show Employee Names" Width="200px"></asp:Label>
                            </td>
                            <td>
                                <asp:CheckBox ID="cb_names" runat="server" Width="200px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label210" runat="server" Text="Show Unit Description" Width="200px"></asp:Label>
                            </td>
                            <td>
                                <asp:CheckBox ID="cb_Desc" runat="server" Width="200px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="Label211" runat="server" Text="Show Job Description" Width="200px"></asp:Label>
                            </td>
                            <td class="auto-style2">
                                <asp:CheckBox ID="cb_JobDesc" runat="server" Width="200px" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Generate Organogram" OnClick="Button1_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="PanelResults" runat="server" Height="600px" Width="800px" Visible="False">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Button ID="bttnPdf" runat="server" Text="Print to PDF" Width="200px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="bbtnWord" runat="server" Text="Print To Microsoft Word" Width="200px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" Width="200px" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="abc" runat="server"></div>

                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Panel>

