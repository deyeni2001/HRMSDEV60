<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HODPage.ascx.cs" Inherits="ola.HRMangmntSyst.HODPage" %>
<style type="text/css">
    .auto-style3 {
    }
    .auto-style6 {
        width: 490px;
    }
    .auto-style16 {
    }
    .auto-style17 {
        width: 207px;
    }
    .auto-style18 {
        width: 207px;
        height: 23px;
    }
    .auto-style19 {
        height: 23px;
    }
    .auto-style20 {
        width: 235px;
    }
</style>
<table style="width: 100%;">
    
    <tr>
        <td valign="top">
            <table style="width: 100%;">
                <tr>
                    <td>
             <asp:Button ID="welHometBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Home" Width="150
                 px" OnClick="welHometBtn_Click" Height="45px" />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        <%--<asp:Button ID="sendemploy" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Text="Send Offer2" Width="150
                 px" OnClick="sendemploy_Click" Height="45px" />--%>
                         <asp:Button ID="hodTrainingBtn" runat="server" Height="45px" Text="Training" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Width="150px" OnClick="hodTrainBtn_Click" />
                    
                       
                    </td>
                   
                </tr>
                <tr>
                    <td>
            <asp:Button ID="hodAssignSupervisor" runat="server" Height="45px" Text="Assign Supervisor" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" OnClick="hodAssignSupervisor_Click" Width="150px" />
                    </td>
                    
                </tr>
                </table>
            </td>
        <td>

<asp:MultiView ID="MViewHOD" runat="server" OnActiveViewChanged="MViewHOD_ActiveViewChanged">
    <asp:View ID="ViewHODWelcome" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="LbWelcom0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Hey HOD! Please select the Module you want to use"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </asp:View>
    <asp:View ID="ViewTraining" runat="server">
        
          <table style="width: 100%; border: medium solid #CC0066; width:100%;">
        <tr>
            <td class="auto-style16" colspan="4">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Training Management"></asp:Label>
            </td>

        </tr>
              <tr>
                  <td class="auto-style17">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style3" colspan="4">

                      <ul>
                          <li>Select Your Department</li><br />
                          <li>Select Employee to be sent for training</li><br />
                          <li>Select Employee Position</li><br />
                          <li>Select Training Name, Dates and Locations</li><br />
                          <li>Sent request for training and wait HR approval</li><br />

                      </ul>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style17">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
              </tr>
        <tr>
            <td class="auto-style17">
                &nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Department" Font-Size="14pt"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="trainingDeptList" runat="server" Width="250px" DataTextField="DeptID" DataValueField="DeptName" AutoPostBack="True" OnSelectedIndexChanged="trainingDeptList_SelectedIndexChanged1">
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpID" runat="server" Font-Bold="True" Text="Employee" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="TrainingEmployeeList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="TrainingEmployeeList_SelectedIndexChanged" Width="250px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbEmpID0" runat="server" Font-Bold="True" Font-Size="14pt" Text="Position"></asp:Label>
                </td>
                <td class="auto-style3">
                    &nbsp;<asp:Label ID="LbTrainingEmpPosition" runat="server" Font-Bold="True" ForeColor="#CC0066" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbTrainingEmpPosition0" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0066" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style17">
                &nbsp;</td>
            <td>
                <asp:Label ID="LbTrainingType" runat="server" Font-Bold="True" Text="Training Name" Font-Size="14pt"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="trainingNameList" runat="server" Width="250px">
                    <asp:ListItem>***Please select***</asp:ListItem>
                    <asp:ListItem>Administration Beginners Training</asp:ListItem>
                    <asp:ListItem>SQL Innovation</asp:ListItem>
                    <asp:ListItem>New Accounting Tools</asp:ListItem>
                    <asp:ListItem>Oracle 12C, New Development</asp:ListItem>
                    <asp:ListItem>IoT Training</asp:ListItem>
                    <asp:ListItem>ICT in Primary Schools</asp:ListItem>
                    <asp:ListItem>ICT in Secondary Schools</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style18"></td>
            <td class="auto-style19"></td>
            <td class="auto-style19"></td>
            <td class="auto-style19"></td>
        </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbTrainingLoc" runat="server" Font-Bold="True" Text="Training Location" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtTrainingLocation" runat="server" Width="250px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label61" runat="server" Font-Bold="True" Font-Size="14pt" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="trainingStartDayList" runat="server" Width="83px">
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingStartMonthList" runat="server" Width="83px">
                        <asp:ListItem Value="00">*Month*</asp:ListItem>
                        <asp:ListItem Value="01">Jan</asp:ListItem>
                        <asp:ListItem Value="02">Feb</asp:ListItem>
                        <asp:ListItem Value="03">Mar</asp:ListItem>
                        <asp:ListItem Value="04">Apr</asp:ListItem>
                        <asp:ListItem Value="05">May</asp:ListItem>
                        <asp:ListItem Value="06">Jun</asp:ListItem>
                        <asp:ListItem Value="07">Jul</asp:ListItem>
                        <asp:ListItem Value="08">Aug</asp:ListItem>
                        <asp:ListItem Value="09">Sep</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingStartYearList" runat="server" AutoPostBack="True" Width="83px">
                    </asp:DropDownList>
                    <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; &nbsp; </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label60" runat="server" Font-Bold="True" Text="End Date" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="trainingEndDayList" runat="server" Width="83px">
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingEndMonthList" runat="server" Width="83px">
                        <asp:ListItem Value="00">*Month*</asp:ListItem>
                        <asp:ListItem Value="01">Jan</asp:ListItem>
                        <asp:ListItem Value="02">Feb</asp:ListItem>
                        <asp:ListItem Value="03">March</asp:ListItem>
                        <asp:ListItem Value="04">april</asp:ListItem>
                        <asp:ListItem Value="05">May</asp:ListItem>
                        <asp:ListItem Value="06">June</asp:ListItem>
                        <asp:ListItem Value="07">July</asp:ListItem>
                        <asp:ListItem Value="08">August</asp:ListItem>
                        <asp:ListItem Value="09">Sept</asp:ListItem>
                        <asp:ListItem Value="10">Oct</asp:ListItem>
                        <asp:ListItem Value="11">Nov</asp:ListItem>
                        <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="trainingEndYearList" runat="server" AutoPostBack="True" Width="83px">
                    </asp:DropDownList>
                    <%--   <asp:RequiredFieldValidator ID="DOBReqFieldVal0" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="DOBRequired" SetFocusOnError="True">DOBRequired</asp:RequiredFieldValidator>
        --%>&nbsp; &nbsp; &nbsp; </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="LbAssignBy0" runat="server" Font-Bold="True" Text="SentBy" Font-Size="14pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="LbTrainingSentBy" runat="server" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp; &nbsp;
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
              <tr>
                  <td class="auto-style17">&nbsp;</td>
                  <td>&nbsp;</td>
                  <td>
                      <asp:Label ID="LbTrainingRequestSentBy" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="#99CC00" Visible="False"></asp:Label>
                  </td>
                  <td class="auto-style3">&nbsp;</td>
              </tr>
              <tr>
                  <td class="auto-style17">&nbsp;</td>
                  <td>&nbsp;</td>
                  <td>&nbsp;</td>
                  <td class="auto-style3">&nbsp;</td>
              </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="trainingSendBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Send" OnClick="trainingSendBtn_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="TrainingFinishBtn" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#33CC33" Text="Finish" OnClick="TrainingFinishBtn_Click" />
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
              
    </asp:View>
    <asp:View ID="ViewAssignSupervisor" runat="server">
        <table style="width: 100%; border: medium solid #CC0066; width:100%;">
            <tr>
                <td class="auto-style3" colspan="3">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="#CC0066" Text="Assign HOD to Department"></asp:Label>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="Label140" runat="server" Font-Bold="True" Font-Size="14pt" Text="Location"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignSupLocationList" runat="server" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="14pt" Text="Deparment"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignSupDeptList" runat="server" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="assignSupDeptList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style157">&nbsp;</td>
            </tr>
          
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           <%-- <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="14pt" Text="Select HOD New Position"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignSupPositionList" runat="server" Visible="true" Width="250px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            --%>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Label ID="LbHOD" runat="server" Font-Bold="True" Font-Size="14pt" Text="Select Supervisor"></asp:Label>
                </td>
                <td class="auto-style195">
                    <asp:DropDownList ID="assignSupEmpList" runat="server" Visible="true" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="assignSupEmpList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style157" colspan="4">
                    <asp:GridView ID="GViewAssignSupervisor" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="EmployeeNum" HeaderText="EmpNum" />
                            <asp:BoundField DataField="DeptName" HeaderText="Dept" />
                            <asp:BoundField DataField="PositionName" HeaderText="Position" />
                            <asp:BoundField DataField="LocationName" HeaderText="Location" />
                            <asp:BoundField DataField="LevelName" HeaderText="Level" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtAssignEmpID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.EmployeeID")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtAssignDeptID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.Department_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtAssignPostID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.PositionHeld_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:TextBox ID="txtAssignWorkID" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container,"DataItem.WorkLocation_FK")%>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Select">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBoxHodAssign" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBoxHodAssign" runat="server" />
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
                <td class="auto-style157">&nbsp;</td>
                <td class="auto-style196">&nbsp;</td>
                <td class="auto-style195">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style157" colspan="4">
                       <asp:Label ID="LbHODUpdateSuccessful1" runat="server" ForeColor="#990033" Text="Label" Visible="False"></asp:Label>
                
                    &nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style154" colspan="4">
                    <asp:Label ID="LbHODUpdateSuccessful" runat="server" ForeColor="#990033" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style196">
                    <asp:Button ID="assignHODBtn" runat="server" Font-Bold="True" Font-Size="14pt" ForeColor="#CC0066" Text="Assign" Width="122px" OnClick="assignSupBtn_Click" />
                </td>
                <td class="auto-style195">
                    &nbsp;</td>
                <td class="auto-style195">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style154">&nbsp;</td>
                <td class="auto-style196">
                    &nbsp;</td>
                <td class="auto-style195">
                    &nbsp;</td>
                <td class="auto-style195">
                    &nbsp;</td>
            </tr>
        </table>
</asp:View>

    <asp:View ID="View3" runat="server">
    </asp:View>
    <asp:View ID="View4" runat="server">
    </asp:View>
</asp:MultiView>
            </td>
        </tr>
    </table>

