<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SupervisorPage.ascx.cs" Inherits="ola.HRMangmntSyst.SupervisorPage" %>
<style type="text/css">
    .auto-style3 {
        width: 455px;
    }
    .auto-style7 {
        width: 264px;
    }
    .auto-style8 {
        width: 552px;
    }
    .auto-style13 {
    }
    .auto-style14 {
    }
    .auto-style21 {
        height: 26px;
        width: 266px;
    }
    .auto-style22 {
        width: 455px;
        height: 26px;
    }
    .auto-style23 {
    }
    #txtPreYearGoalObjective {
        width: 271px;
    }
    #txtPreYearGoalDesc {
        width: 269px;
    }
    #txtNxtYearGoalDesc {
        width: 249px;
    }
    #txtNxtYearGoalObjective {
        width: 258px;
    }
    .auto-style95 {
        width: 390px;
    }
    .auto-style37 {
        width: 244px;
    }
    .auto-style46 {
    }
    .auto-style35 {
        width: 303px;
    }
    .auto-style45 {
        width: 303px;
        height: 23px;
    }
    .auto-style39 {
        width: 233px;
        height: 23px;
    }
    .auto-style96 {
        width: 297px;
    }
    .auto-style97 {
        width: 418px;
    }
    .auto-style98 {
    }
    .auto-style105 {
        height: 26px;
        width: 446px;
    }
    .auto-style107 {
        height: 26px;
        width: 447px;
    }
    .auto-style108 {
        width: 266px;
    }
    .auto-style109 {
        width: 447px;
    }
    .auto-style110 {
        width: 547px;
    }
    .auto-style111 {
        width: 154px;
        height: 23px;
    }
    </style>
<table style="width: 100%;">
    <tr>
        <td valign="top">
            <table style="width: 100%;">
                <tr>
                    <td>
                <asp:Button ID="supervisorMenuHome" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Home" Width="120px" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                <asp:Button ID="supervisorMenuQueryBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Query" Width="120px" OnClick="supervisorMenuQueryBtn_Click" />
                    </td>
                   
                </tr>
                
                <tr>
                    <td>
                <asp:Button ID="supervisorAppraisalBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Appraisal" Width="120px" OnClick="supervisorAppraisalBtn_Click" />
                    </td>
                   
                </tr>
            </table>

        </td>
        <td valign="top">
<asp:MultiView ID="MViewSupervisor" runat="server">
    <asp:View ID="ViewWelcomPage" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;" valign="top">
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Hey Supervisor! Please select the Module you want to use"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </asp:View>
    <asp:View ID="ViewQueryPage" runat="server">
        <table style="border: medium solid #CC3300; width:100%;">
        <tr>
            <td colspan="4">
                <asp:Label ID="LbQuery" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" style="color: #CC3300" Text="Query Management"></asp:Label>
            </td>
        </tr>
            <tr>
                <td> &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:LinkButton ID="LinkBtnIssueQuery" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkBtnIssueQuery_Click">Issue Query</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkBtnViewQuery" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="LinkBtnViewQuery_Click">View Query</asp:LinkButton>
                </td>

            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            

          
            <tr>
                <td class="auto-style14" colspan="4">
               <center>     <asp:Label runat="server" Text="Label" ID="LbQueryIssued" Font-Bold="True" Font-Italic="True" ForeColor="#669900" Visible="False"></asp:Label>
               </center> </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            

          
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">
                    <center>
                        <asp:Button ID="BtnSupQueryFinish" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="12pt" ForeColor="#009900" OnClick="BtnSupQueryFinish_Click" Text="Finish" Visible="False" />
                    </center>
                </td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            

          
            <tr>
                <td class="auto-style14" colspan="4">
                    <asp:Panel ID="PanelViewQuery" runat="server">
                        <table style="width:100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="4">
                    <asp:Label ID="Label145" runat="server" style="font-weight: 700; color: #CC3300" Text="List of Issued Query" Visible="False" Font-Size="14pt"></asp:Label>
                </td></tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                            </tr>
            <tr>         
                                <td colspan="4">
                            <asp:GridView ID="GVSupervisorQuery" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCommand="GVSupervisorQuery_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="EmployeeNum" HeaderText="Employee Num" />
                                <asp:BoundField DataField="QueryReceivedByName" HeaderText="Employee Name" />
                                <asp:BoundField DataField="QueryTitle" HeaderText="Query Title" />
                                <asp:BoundField DataField="IssueDate" HeaderText="Issue Date" />
                                <asp:BoundField DataField="ResponseDate" HeaderText="Response Date" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton22" runat="server" CommandArgument='<%#DataBinder.Eval(Container,"DataItem.QueryID")%>' CommandName="View">View</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                                   </td> 
                            </tr>
                                
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                 <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            

          
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Panel ID="PanelDiscipline" runat="server" Visible="False" Width="100%">
                        <table style="width: 100% ">
                            <tr>
                                <td colspan="4">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style183"><strong>EmployeeNum</strong></td>
                                <td>
                                    <asp:Label ID="lblDisEmpNum" runat="server" style="color: #CC3300" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr><td class="auto-style14">&nbsp;</td>
                                <td><b>Query Title</b></td>
                                <td>
                                    <asp:Label ID="lblDisQueryTitle" runat="server" style="font-weight: 700; color: #CC3300" Text="Label"></asp:Label>
                                </td>
                             
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Query Description</b></td>
                                <td>
                                    <asp:Label ID="lblDisQueryDescription" runat="server" style="color: #CC3300; font-style: italic;" Text="Label"></asp:Label>
                                </td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td class="auto-style14"><b>Issued Day</b></td>
                                <td class="auto-style14">
                                    <asp:Label ID="lblDisQueryIssueDay" runat="server" CssClass="auto-style183" style="color: #CC3300" Text="Label"></asp:Label>
                                </td>
                                <td class="auto-style14"><b></b></td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Employee Response</b></td>
                                <td>
                                    <asp:Label ID="lblDisQueryResponse" runat="server" CssClass="auto-style183" style="color: #CC3300; font-style: italic;" Text="Label"></asp:Label>
                                </td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Date Responded</b></td>
                                <td>
                                    <asp:Label ID="lblDisResponseDate" runat="server" CssClass="auto-style183" style="color: #CC3300" Text="Label"></asp:Label>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <%--<tr>
                                <td colspan="4">
                                    <asp:Label ID="Label143" runat="server" style="font-weight: 700; font-style: italic; color: #CC3300" Text="Specify the following if there is need to discipline the employee"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Discipline Type</b></td>
                                <td>
                                    <asp:DropDownList ID="ddlDisciplineType" runat="server" CssClass="auto-style183" Width="250px">
                                        <asp:ListItem>---Please Select----</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Discipline Description</b></td>
                                <td>
                                    <asp:TextBox ID="txtDisciplineDescription" runat="server" Height="88px" TextMode="MultiLine" Width="241px"></asp:TextBox>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Discipline Date</b></td>
                                <td>
                                    <asp:Label ID="lblDisciplineDate" runat="server"></asp:Label>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Disciplined By:</b></td>
                                <td><b></b>
                                    <asp:Label ID="lblDisciplineBy" runat="server"></asp:Label>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td><b>Discipline letter</b></td>
                                <td>
                                    <asp:FileUpload ID="DisciplinedLetterUpload" runat="server" CssClass="auto-style183" />
                                    <b>&nbsp;
                                    <asp:Label ID="lblDisciplineLetterName" runat="server"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td class="auto-style14">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Button ID="btnSendDisciplined" runat="server" OnClick="btnSendDisciplined_Click" style="font-weight: 700" Text="Send" />
                                    &nbsp; </td>
                                <td>
                                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" style="font-weight: 700" Text="Close" />
                                </td>
                                <td class="auto-style14">&nbsp;</td>
                            </tr>--%>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        <tr>
            <td colspan="4">
                <asp:Panel ID="PanelQuery" runat="server" Visible="False">
                    <table style="width:100%">
                        <tr>
                            <td colspan="4">
                                <asp:Label ID="Label144" runat="server" style="font-weight: 700; font-style: italic; color: #CC3300" Text="Please select the staff you want to query."></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style14">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbSupEmpID" runat="server" Font-Bold="True" Text="EmployeeNum" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="queryEmployeeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="queryEmployeeList_SelectedIndexChanged" Width="250px">
                                    <asp:ListItem>---Please Select---</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style14">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbSupEmpID0" runat="server" Font-Bold="True" Text="Employee Name:" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpName" runat="server" style="font-weight: 700" ForeColor="#990000" Visible="False"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                            
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td class="auto-style14">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbSupEmpID1" runat="server" Font-Bold="True" Text="Department" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpDept" runat="server" style="font-weight: 700" ForeColor="#990000" Visible="False"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Position" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpPosition" runat="server" style="font-weight: 700" ForeColor="#990000" Visible="False"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbSupEmpID2" runat="server" Font-Bold="True" Text="Level" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblEmpLevel" runat="server" style="font-weight: 700" ForeColor="#990000" Visible="False"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbReason" runat="server" Font-Bold="True" Text="Query Title" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtQueryTitle" runat="server"  Width="250px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbQueryDesc" runat="server" Font-Bold="True" Text="Query Description" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtQueryDesc" runat="server" Height="73px" TextMode="MultiLine" Width="250px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Query Letter" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:FileUpload ID="QueryFileUpload" runat="server" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbIssueDate" runat="server" Font-Bold="True" Text="Issue Date" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblQueryIssueDate" runat="server" Font-Bold="True" ForeColor="#990000" Visible="False"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style111"></td>
                            <td class="auto-style111"></td>
                            <td class="auto-style111"></td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>
                                <asp:Label ID="LbIssueBy" runat="server" Font-Bold="True" Text="IssueBy" Font-Size="14pt"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblQueryIssuedBy" runat="server" Font-Bold="True" ForeColor="#990000" Visible="False"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="issueQueryBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="issueQueryBtn_Click" style="color: #CC3300" Text="Issue Query" />
                            </td>
                            <td>
                                <asp:Button ID="Button11" runat="server" Text="Close" />
                            </td>
                            <td class="auto-style14">&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>

        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
    </table>
    </asp:View>
    <asp:View ID="ViewAppraisal" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style3" colspan="4">
                <asp:Label ID="LbAppraisal" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Appraisal Management"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="EmployeeID" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="appraisalEmployeeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="appraisalEmployeeList_SelectedIndexChanged" Width="200px">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisal" runat="server" Font-Bold="True" Text="Self-Appraisal Score" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSelfAppraisalScore" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label68" runat="server" Font-Bold="True" Font-Size="14pt" Text="Department"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpDept" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label69" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpPosition" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LbEvaluator" runat="server" Font-Bold="True" Text="Date" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSupAppraisalDate" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEvaluationPeriod" runat="server" Font-Bold="True" Text="Evaluation Period" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEvalPeriod" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>

        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisor" runat="server" Font-Bold="True" Text="Supervisor Name" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbEmpSup" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Start Year of Service" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbAppraisalStartYear" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False">Label</asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Panel ID="PanelSelfAssessment" runat="server" Visible="False">
                        <table style="width:100%;">
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style43" colspan="4">
                                    <asp:Label ID="LbSelfAppraisal0" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Self Assessment"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">&nbsp;</td>
                                <td class="auto-style37">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">
                                    <asp:Label ID="Label28" runat="server" Font-Bold="True" Text="In what areas do I excel in the performance of my duties?"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtExcelPerformance" runat="server" Width="250px"></asp:TextBox>
                                </td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">&nbsp;</td>
                                <td class="auto-style37">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">
                                    <asp:Label ID="Label29" runat="server" Font-Bold="True" Text="In what areas do I need improvement in the performance of my duties?"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtNeedsImprovemen" runat="server" Width="250px"></asp:TextBox>
                                </td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">&nbsp;</td>
                                <td class="auto-style37">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">
                                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="What steps can I take to improve my work performance?"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtStepsForImprovement" runat="server" Width="250px"></asp:TextBox>
                                </td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">&nbsp;</td>
                                <td class="auto-style37">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">
                                    <asp:Label ID="Label31" runat="server" Font-Bold="True" Text="What assistance could my supervisor provide to help me improve my work performance? "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtExctxtNeedsSupervisorAssistance" runat="server" Width="250px"></asp:TextBox>
                                </td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style95">&nbsp;</td>
                                <td class="auto-style37">&nbsp;</td>
                                <td class="auto-style3">&nbsp;</td>
                            </tr>
                            <caption>
                                <tr>
                                    <td colspan="4">
                                        <asp:Label ID="LbAppraisal2" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Click Show Button to see Competency Definition"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td class="auto-style95">&nbsp;</td>
                                    <td class="auto-style37">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td class="auto-style95">
                                        <asp:Button ID="CompetencyShowBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="CompetencyShowBtn_Click" Text="Show" />
                                    </td>
                                    <td class="auto-style37">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="4">
                                        <asp:Panel ID="PanelCompetentShow" runat="server" Visible="false">
                                            <table style="width: 100%;">
                                                <tr>
                                                    <td class="auto-style36" colspan="4">
                                                        <asp:Label ID="LbAppraisal1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Competency Factor Definitions"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>&nbsp;</td>
                                                    <td class="auto-style95">&nbsp;</td>
                                                    <td class="auto-style37">&nbsp;</td>
                                                    <td class="auto-style3">&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4">
                                                        <ul>
                                                            <li><strong>QUALITY OF WORK:</strong>Work quality refers to effort that consistently achieves desired outcomes with a minimum of avoidable</li>
                                                            <li><strong>PRODUCTIVITY:</strong>Consider how the person uses available working time, plans and prioritizes work, sets and accomplishes</li>
                                                            <li><strong>KNOWLEDGE OF THE JOB:</strong>Does the employee exhibit job-related knowledge and skill needed to perform the duties and requirements of the position? Does the employee exhibit knowledge of the methods, practices and equipment needed to do the job? Consider knowledge gained through experience, education, and specialized training. Does the employee seek to maintain current knowledge of changes in policies and procedures? Does the employee keep abreast of new developments and major issues in the field? At times, employee may be consulted by others for guidance.</li>
                                                            <li><strong>ADAPTABILITY:</strong>How does this employee adjust to changes? Does this employee initiate or recommend beneficial changes in work procedures? Does this employee readily accept new assignments or temporary assignments outside the regular responsibilities? Consider willingness to learn quickly, to adapt to changes in job assignments, methods, personnel, or surroundings.</li>
                                                            <li><strong>DEPENDABILITY:</strong>How reliable is the employee in performing work assignments and carrying out instructions? Consider the degree of supervision required and the willingness to take on responsibilities and to be accountable for them.</li>
                                                            <li><strong>INITIATIVE AND RESOURCEFULNESS:</strong>Does the employee see things to be done and then take appropriate action without being so directed? Consider ability to contribute, develop and/or carry out new ideas or methods. Consider ability to be a selfstarter, to be creative, to offer suggestions, to anticipate needs and to seek additional tasks and projects to complete as timepermits.</li>
                                                            <li><strong>JUDGEMENT AND POLICY COMPLIANCE:</strong>Does employee evaluate situations and make sound decisions, and use reasoning to identify, solve, and prevent problems? Does the employee work in a safe manner, preventing accidents, injuries, andtheft? Does the employee exhibit knowledge of the University’s policies and procedures applicable to his/her assignment? Does the employee exhibit willingness to comply with all reasonable requirements?</li>
                                                            <li><strong>INTERPERSONAL RELATIONS AND CUSTOMER SERVICE:</strong>Does the employee exhibit a good level of interpersonal skills and have a good working relationship with most of his/her peers, subordinates, supervisors, customers, and the general public? Consider respect and courtesy the employee shows to others, how the employee’s behavior affects the work area, and the willingness of the employee to accept supervision. Does the employee exhibit appropriate supportive behavior toward the University and its customers? Is the employee unnecessarily involved in trivial disputes and misunderstandings? Does the employee exhibit willingness to work as a team member?</li>
                                                            <li><strong>ATTENDANCE AND PUNCTUALITY:</strong>Does the employee report to work on a timely basis and stay on the job? Consider arrival times, observance of time limits for breaks and lunches. Consider patterns of sick leave use, seeking prior approval for vacation, and giving prompt notice to supervisor of absence due to illness or other acceptable reasons.</li>
                                                            <li><strong>TEAM WORK:</strong> Does the employee exhibit willingness and ability to work as a team member? Does the employee respond to suggestions and criticism with minimal defensiveness? Consider whether the employee keeps the supervisor and others advised of problems or practical ideas when needed. Consider adherence to the guidelines and regulations that are utilized by the work group, and assisting others on assignments and projects contributing to their success.</li>
                                                            <li><strong>COMMUNICATION SKILLS: </strong>To what extent does the employee demonstrate ability to communicate effectively in both oral and written expression with other employees and his/her supervisor? Are issues confronted and resolved constructively? Consider ability to help others with their work problems, and ability to keep others informed of decisions and plans for their own offices as well as policies and procedures of the University.</li>
                                                            <li><strong>PLANNING AND ORGANIZATION:</strong>How effective is the employee in setting effective goals, planning ahead and establishing priorities? Consider ability to make the most effective use of time, facilities, material, equipment, skills and other resources. Examine ability to prepare and administer budget effectively.</li>
                                                            <li><strong>LEADERSHIP ABILITY:</strong>Is the employee able to get other employees to do willingly and well the duties needed to be accomplished? Consider ability to get the work done while being sensitive to the morale and satisfaction of those doing the work; the ability to function consistently and effectively in an objective and rational manner regardless of pressures.</li>
                                                            <li><strong>APPRAISAL AND DEVELOPMENT OF PEOPLE:</strong>Does the supervisor demonstrate ability to select, train and provide opportunities for development of employees by recognizing and facilitating improvement of their abilities? Consider ability to exhibit fairness and impartiality with employees in assigning job duties and objectively appraising work performance.</li>
                                                        </ul>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>&nbsp;</td>
                                                    <td class="auto-style95">&nbsp;</td>
                                                    <td class="auto-style37">&nbsp;</td>
                                                    <td class="auto-style3">&nbsp;</td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4">
                                        <asp:Label ID="LbConpetency1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Self Appraisal - Competency Rating Key"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td class="auto-style95">&nbsp;</td>
                                    <td class="auto-style37">&nbsp;</td>
                                    <td class="auto-style3">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="4">
                                        <table style="width:100%;">
                                            <tr>
                                                <td class="auto-style46"></td>
                                                <td class="auto-style110">&nbsp;<asp:Label ID="LbPreformance0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Factors"></asp:Label>
                                                </td>
                                                <td class="auto-style35">&nbsp;<asp:Label ID="LbPreformanceRatingKey0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Rating Key"></asp:Label>
                                                </td>
                                                <td class="auto-style36">
                                                    <asp:Label ID="LbPreformancePoint0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Performance Rating Key"></asp:Label>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbQuality0" runat="server" Font-Bold="True" Text="Quality of Work"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="QualityRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="QualityRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtQualityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbProductivity0" runat="server" Font-Bold="True" Text="Productivity"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="ProductivityRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ProductivityRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtProductivityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbKnowledge0" runat="server" Font-Bold="True" Text="Knowledge of the Job"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="knowledgeRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="knowledgeRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtKnowledgeRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbAdability0" runat="server" Font-Bold="True" Text="Adaptability"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="AdaptabilityRatingKey" runat="server" OnSelectedIndexChanged="AdaptabilityRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtAdaptabilityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbDependability0" runat="server" Font-Bold="True" Text="Dependability"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="DependabilityRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DependabilityRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtDependabilityRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbInitiative0" runat="server" Font-Bold="True" Text="Initiative &amp; Resourcefulness"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="InitiativeRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="InitiativeRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtInitiativeRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbPolicyCompliance0" runat="server" Font-Bold="True" Text="Judgment &amp; Policy Compliance"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="JudgementRatingKey" runat="server" OnSelectedIndexChanged="JudgementRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtJudgementRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbInterpersonal0" runat="server" Font-Bold="True" Text="Interpersonal Relations &amp; Customer Service"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="InterpersonalRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="InterpersonalRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtInterpersonalRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbAttendance0" runat="server" Font-Bold="True" Text="Attendance &amp; Punctuality"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="AttendanceRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="AttendanceRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtAttendanceratingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbTeam0" runat="server" Font-Bold="True" Text="Team Work"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="TeamRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="TeamRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtTeamRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbCommunication0" runat="server" Font-Bold="True" Text="Communication Skills"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="CommSkillRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CommSkillRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtCommSkillRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbPlanning0" runat="server" Font-Bold="True" Text="Planning &amp; Organization"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="planningRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="planningRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtPlanningPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbLeadership0" runat="server" Font-Bold="True" Text="Leadership Ability"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="leadershipRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="leadershipRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtLeadershipPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbDevelopment0" runat="server" Font-Bold="True" Text="Appraisal &amp; Development of People"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:DropDownList ID="developmentRatingKey" runat="server" AutoPostBack="True" OnSelectedIndexChanged="developmentRatingKey_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtDevelopmentRatingPoint" runat="server" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46" colspan="5">
                                                    <asp:Label ID="LbGoalAdded1" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#FF0066" Text="Click 'Sum' button to see total point before saving"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">
                                                    <asp:Button ID="competencySumBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="competencySumBtn_Click" Text="Sum" />
                                                </td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style45">&nbsp;</td>
                                                <td class="auto-style39">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbPercent" runat="server" Font-Bold="True" Text="Appraisal Score/ Total Points" Visible="False" Font-Size="14pt"></asp:Label>
                                                </td>
                                                <td class="auto-style45">
                                                    <asp:TextBox ID="txtAppraisalpercentage" runat="server" Visible="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:TextBox ID="txtTotalPoint" runat="server" EnableTheming="False" Visible="False"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3"></td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style37">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbSupPromo" runat="server" Font-Bold="True" Font-Size="14pt" Text="Promo Recom" Visible="False"></asp:Label>
                                                </td>
                                                <td class="auto-style37">
                                                    <asp:DropDownList ID="supPromoRecomList" runat="server" Visible="False">
                                                        <asp:ListItem>***Please Select***</asp:ListItem>
                                                        <asp:ListItem>Recommend</asp:ListItem>
                                                        <asp:ListItem>Not Recommend</asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style37">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Label ID="LbComment" runat="server" Font-Bold="True" Font-Size="14pt" Text="Comment" Visible="False"></asp:Label>
                                                </td>
                                                <td class="auto-style37">
                                                    <asp:TextBox ID="txtSupComment" runat="server" Height="20px" Visible="False" Width="166px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style37">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td colspan="5">
                                                    <asp:Label ID="LbSuccess" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#99CC00" Text="Label" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style37">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">
                                                    <asp:Button ID="competencySaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="competencySaveBtn_Click" Text="Save" Visible="False" />
                                                </td>
                                                <td class="auto-style37">
                                                    <asp:Button ID="conpetencyNextBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="conpetencyNextBtn_Click" Text="Next" Visible="False" />
                                                </td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style110">&nbsp;</td>
                                                <td class="auto-style37">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                                <td class="auto-style3">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </caption>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            
    </table>
       </asp:View>
    <asp:View ID="ViewAppraisalPerformance" runat="server">
         <table style="width: 100%; border: medium solid #CC0066; width:100%;">
               <tr>
            <td class="auto-style43" colspan="4">
                <asp:Label ID="Label57" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Performance Goal"></asp:Label>
                   </td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">Employees should develop and suggest goals for the supervisor and employee to discuss. Both the supervisor and employee should agree on the goals. Goals may be work-related or developmental; the goal should be limited to a one-year time frame. Enter the goals in order of importance. The following questions will assist the employee and supervisor:<br /> </td>
        </tr>
        <tr>
            <td class="auto-style43">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">&nbsp;<ol>
                    <li>What specific tasks, projects, or activities need to be accomplished?
                        </li>
                    <li>What changes in work performance are required or desired?</li>
                    <li> What training or work experience would be helpful or developmental?</li>
                </ol>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Button ID="viewPreYrGoalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="View Last Year Goals" OnClick="viewPreYrGoalBtn_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style43">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>

              <tr>
                 <td class="auto-style43" colspan="4">
                     <asp:Panel ID="PanelPreYearGoal"  Visible="false" runat="server">

                         <table style="width: 100%;">
                           
                     
             <tr>
                 <td class="auto-style43" colspan="4">
                     <asp:Label ID="Label58" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Previous Year Goal- to be Reviewed for Current Performance Appraisal  "></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style43">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style37">&nbsp;</td>
                 <td class="auto-style3">&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style43" colspan="4">
                     &nbsp;
                     <asp:GridView ID="GViewPreYearGoalList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                         <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                         <Columns>
                             <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                             <asp:BoundField DataField="GoalObjectives" HeaderText="GoalObj" />
                             <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                             <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion date" />
                             <asp:TemplateField>
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtNextGoalEmpID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox>
                                 </ItemTemplate>
                             </asp:TemplateField>
                             <asp:TemplateField>
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtNextGoalSupID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SupervisorID_FK") %>' Visible="false"></asp:TextBox>
                                 </ItemTemplate>
                             </asp:TemplateField>
                             <asp:TemplateField>
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtNextGoalHRID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.HRID_FK") %>' Visible="false"></asp:TextBox>
                                 </ItemTemplate>
                             </asp:TemplateField>
                             <asp:TemplateField>
                                 <ItemTemplate>
                                     <asp:TextBox ID="txtNextGoalAppraisalID0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AppraisalID_FK") %>' Visible="false"></asp:TextBox>
                                 </ItemTemplate>
                             </asp:TemplateField>
                         </Columns>
                         <EditRowStyle BackColor="#999999" />
                         <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                         <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                         <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                         <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                         <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                     </asp:GridView>
                 </td>
             </tr>
        <tr>
            <td class="auto-style43">
            
                &nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                   
                         </table>
                     </asp:Panel>
                         
                      </td>
             </tr>
                     
                      </td>
             </tr>
               <tr>
                   <td class="auto-style43">&nbsp;</td>
                   <td>&nbsp;</td>
                   <td class="auto-style37">
                       <asp:Button ID="AddNxtYrGoalBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Add Next Year Goals" OnClick="AddNxtYrGoalBtn_Click" />
                   </td>
                   <td class="auto-style3">&nbsp;</td>
               </tr>
               

             <tr>
                   <td colspan="4">
                       <asp:Panel ID="PanelNextYearGoal" Visible="false" runat="server">
                           <table style="width: 100%;">
                               <tr>
                                   <td>&nbsp;
                                       <table style="width:100%;">
                                                                                 <tr>
                                               <td class="auto-style23" colspan="4">
                                                   <asp:Label ID="Label63" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="#CC0066" Text="Next Year Goal- to be Reviewed at Next Year's  Performance Appraisal  "></asp:Label>
                                               </td>
                                           </tr>
                                           <tr>
                                               <td class="auto-style23">&nbsp;</td>
                                               <td class="auto-style97">&nbsp;</td>
                                               <td class="auto-style96">&nbsp;</td>
                                               <td class="auto-style22">&nbsp;</td>
                                           </tr>
                                           <tr>
                                               <td class="auto-style23" colspan="4">
                                                   <asp:GridView ID="GViewEmpNextGoal" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GViewEmpNextGoal_RowCancelingEdit" OnRowEditing="GViewEmpNextGoal_RowEditing" OnRowUpdating="GViewEmpNextGoal_RowUpdating" Visible="False">
                                                       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                       <Columns>
                                                           <%--<asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                    <asp:BoundField DataField="GoalObjectives" HeaderText="GoalObj" />
                                    <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                    <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion date" />--%>
                                                           <asp:TemplateField HeaderText="GoalDesc">
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtGoalDesc" runat="server" Text='<%#Eval("GoalDesc") %>'></asp:TextBox>
                                                               </ItemTemplate>
                                                               <EditItemTemplate>
                                                                   <asp:TextBox ID="txtGoalDesc" runat="server" Text='<%#Eval("GoalDesc") %>'></asp:TextBox>
                                                               </EditItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="GoalObjectives">
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtGoalObjectives" runat="server" Text='<%#Eval("GoalObjectives") %>'></asp:TextBox>
                                                               </ItemTemplate>
                                                               <EditItemTemplate>
                                                                   <asp:TextBox ID="txtGoalObjectives" runat="server" Text='<%#Eval("GoalObjectives") %>'></asp:TextBox>
                                                               </EditItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="GoalEvaPoint">
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtGoalEvaPoint" runat="server" Text='<%#Eval("GoalEvaPoint") %>'></asp:TextBox>
                                                               </ItemTemplate>
                                                               <EditItemTemplate>
                                                                   <asp:TextBox ID="txtGoalEvaPoint" runat="server" Text='<%#Eval("GoalEvaPoint") %>'></asp:TextBox>
                                                               </EditItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="GoalCompletetiondate">
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtGoalCompletetiondate" runat="server" Text='<%#Eval("GoalCompletetiondate") %>'></asp:TextBox>
                                                               </ItemTemplate>
                                                               <EditItemTemplate>
                                                                   <asp:TextBox ID="txtGoalCompletetiondate" runat="server" Text='<%#Eval("GoalCompletetiondate") %>'></asp:TextBox>
                                                               </EditItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField>
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtNextGoalEmpID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>' Visible="false"></asp:TextBox>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField>
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtNextGoalSupID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SupervisorID_FK") %>' Visible="false"></asp:TextBox>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField>
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtNextGoalHRID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.HRID_FK") %>' Visible="false"></asp:TextBox>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField>
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtNextGoalAppraisalID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.AppraisalID_FK") %>' Visible="false"></asp:TextBox>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField>
                                                               <ItemTemplate>
                                                                   <asp:TextBox ID="txtNextGoalID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GoalID") %>' Visible="false"></asp:TextBox>
                                                               </ItemTemplate>
                                                           </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="Edit">
                                                               <ItemTemplate>
                                                                   <asp:LinkButton ID="nextYearEditBtn" runat="server" CommandName="Edit" Text="Edit">Edit</asp:LinkButton>
                                                               </ItemTemplate>
                                                               <EditItemTemplate>
                                                                   <asp:LinkButton ID="nextYearEditBtnUpdate" runat="server" CommandName="Update" Text="Update">Update</asp:LinkButton>
                                                                   <asp:LinkButton ID="nextYearEditBtnCancel" runat="server" CommandName="Cancel" Text="Cancel">Cancel</asp:LinkButton>
                                                               </EditItemTemplate>
                                                           </asp:TemplateField>
                                                       </Columns>
                                                       <EditRowStyle BackColor="#999999" />
                                                       <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                       <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                       <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                       <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                       <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                   </asp:GridView>
                                               </td>
                                           </tr>
                                           <tr>
                                               <td class="auto-style23">&nbsp;</td>
                                               <td class="auto-style97">&nbsp;</td>
                                               <td class="auto-style96">&nbsp;</td>
                                               <td class="auto-style22">&nbsp;</td>
                                           </tr>
                                           <%-- <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23"></td>
                        <td class="auto-style97">
                            <asp:Label ID="Label64" runat="server" Font-Bold="True" Font-Size="14pt" Text="Goal Description"></asp:Label>
                        </td>
                        <td class="auto-style96">
                            <asp:TextBox ID="txtNxtYearGoalDesc" Width="250" Height="50" runat="server"></asp:TextBox>
                            
                        <td class="auto-style22"></td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">
                            <asp:Label ID="Label65" runat="server" Font-Bold="True" Text="Objective: Describe how the Goal was achieved"></asp:Label>
                        </td>
                        <td class="auto-style96">
                             <asp:TextBox ID="txtNxtYearGoalObjective" Width="250" Height="50" runat="server"></asp:TextBox>
                            
                        <td>&nbsp;</td>
                    </tr>
                     <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">
                            <asp:Label ID="Label66" runat="server" Font-Bold="True" Text="Evaluation Point"></asp:Label>
                        </td>
                        <td class="auto-style96">
                              <asp:TextBox ID="txtEvalPoint" Width="250" Height="50" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">
                            <asp:Label ID="Label67" runat="server" Font-Bold="True" Text="Completion Date"></asp:Label>
                        </td>
                        <td class="auto-style96">
                            <asp:DropDownList ID="goalNxtYrDayList" runat="server">
                            </asp:DropDownList>
                            &nbsp;<asp:DropDownList ID="goalNxtYrMonthList" runat="server">
                                <asp:ListItem>***Month***</asp:ListItem>
                                <asp:ListItem>Jan</asp:ListItem>
                                <asp:ListItem>Feb</asp:ListItem>
                                <asp:ListItem>Mar</asp:ListItem>
                                <asp:ListItem>Apr</asp:ListItem>
                                <asp:ListItem>May</asp:ListItem>
                                <asp:ListItem>Jun</asp:ListItem>
                                <asp:ListItem>Jul</asp:ListItem>
                                <asp:ListItem>Aug</asp:ListItem>
                                <asp:ListItem>Sep</asp:ListItem>
                                <asp:ListItem>Oct</asp:ListItem>
                                <asp:ListItem>Nov</asp:ListItem>
                                <asp:ListItem>Dec</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;
                            <asp:DropDownList ID="goalNxtYrYearList" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:Label ID="LbGoalAdded0" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#FF0066" Text="Click 'Add' button to add more goals before saving"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">
                            <asp:Button ID="goalAddBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Add" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:GridView ID="GViewNextYearGoalList" runat="server" Visible="False" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                    <asp:BoundField DataField="GoalObjectives" HeaderText="GoalObj" />
                                    <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                    <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion date" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalSupID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.SupervisorID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                        <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalHRID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.HRID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="c" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.AppraisalID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>
                        </td>
                    </tr>
                 <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:Label ID="LbGoalAdded" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:GridView ID="GViewNextGoalLog" runat="server" Visible="False" AutoGenerateColumns="False" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="GoalDesc" HeaderText="GoalDesc" />
                                    <asp:BoundField DataField="GoalObjectives" HeaderText="GoalObj" />
                                    <asp:BoundField DataField="GoalEvaPoint" HeaderText="EvaPoint" />
                                    <asp:BoundField DataField="GoalCompletetiondate" HeaderText="Completetion date" />
                                     <asp:BoundField DataField="SentBy" HeaderText="SentBy" />
                                  
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.EmployeeID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalSupID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.SupervisorID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                        <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalHRID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.HRID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalAppraisalID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.AppraisalID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                   <%-- <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtNextGoalID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container, "DataItem.GoalID_FK") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                           <%--                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>
                        </td>
                    </tr>
                        <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31" colspan="4">
                            <asp:Label ID="LbGoalLog" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">&nbsp;</td>
                        <td class="auto-style96">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style31">&nbsp;</td>
                        <td class="auto-style97">
                            <asp:Button ID="goalBackBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="appraisalBackBtn_Click" Text="Back" Visible="False" />
                        </td>
                        <td class="auto-style96">
                            <asp:Button ID="goalsaveBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Save" Visible="False" />
                        </td>
                        <td>
                            <asp:Button ID="goalFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Finish" Visible="False" OnClick="goalFinishBtn_Click" />
                        </td>
                    </tr>--%>
                                           <tr>
                                               <td class="auto-style31" colspan="4">
                                                   <asp:Label ID="LbGoalAdded" runat="server" Font-Italic="True" ForeColor="#669900" Text="Label" Visible="False"></asp:Label>
                                               </td>
                                           </tr>
                                                                                 <tr>
                                                                                     <td class="auto-style31" colspan="4">&nbsp;</td>
                                                                                 </tr>
                                                                                 <tr>
                                                                                     <td class="auto-style31">&nbsp;</td>
                                                                                     <td class="auto-style97">
                                                                                         &nbsp;<asp:Button ID="GoalFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" OnClick="GoalFinishBtn_Click" Text="Finsh" />
                                                                                     </td>
                                                                                     <td class="auto-style96">&nbsp;</td>
                                                                                     <td>&nbsp;</td>
                                                                                 </tr>
                                           <tr>
                                               <td class="auto-style31" colspan="4">&nbsp;
                                                   </td>
                                           </tr>
                                       </table>
                                   </td>
                               </tr>
       
            
       <%-- <tr>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisorName0" runat="server" Font-Bold="True" Text="Reviewer: (Next level of authority above the Direct Supervisor)" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtReviewerName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LbSupervisorComment0" runat="server" Font-Bold="True" Text="Reviewer's Comment" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtReviewerComment" runat="server"></asp:TextBox>
            </td>
        </tr>--%>
        
    </table>
                                
                       </asp:Panel>

                   </td>
               </tr>
    </asp:View>

    <asp:View ID="ViewAppraisalComment" runat="server">
         <tr>
            <td class="auto-style98" colspan="4">
                <asp:Panel ID="Panel1" runat="server" Visible="False">

                    <table style="border: medium solid #CC0066; width: 100%;">
                        <tr>
                            <td colspan="4">
                                <asp:Label ID="Label70" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Comment and Appraise"></asp:Label>
                            </td>
                        </tr>
                                            <tr>
                                                <td>&nbsp;</td>
                                                <td class="auto-style108">&nbsp;</td>
                                                <td class="auto-style109">&nbsp;</td>
                                                <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td class="auto-style108">&nbsp;</td>
                            <td class="auto-style109">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                                            <tr>
            <td class="auto-style98">
                &nbsp;</td>
            <td class="auto-style108">
                &nbsp;</td>
            <td class="auto-style109">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">
                &nbsp;</td>
            <td class="auto-style108">
                &nbsp;</td>
            <td class="auto-style109">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                <tr>
            <td class="auto-style98">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style109">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
                        <tr>
                            <td class="auto-style98">&nbsp;</td>
                            <td class="auto-style108">
                                &nbsp;</td>
                            <td class="auto-style109">
                                &nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style98">&nbsp;</td>
                            <td class="auto-style108">&nbsp;</td>
                            <td class="auto-style109">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style98">&nbsp;</td>
                            <td class="auto-style108">&nbsp;</td>
                            <td class="auto-style109">&nbsp;</td>
                            <td class="auto-style3">&nbsp;</td>
                        </tr>
        <tr>
            <td class="auto-style105">
                &nbsp;</td>
            <td class="auto-style21">
                &nbsp;</td>
            <td class="auto-style107">
                &nbsp;</td>
            <td class="auto-style22">
                &nbsp;</td>
        </tr>       
                    </table>
                </asp:Panel>
            </td>
        </tr>

    </asp:View>
    <asp:View ID="View4" runat="server">
    </asp:View>
    <asp:View ID="View5" runat="server">
    </asp:View>
</asp:MultiView>
            </td>
      
</table>
           