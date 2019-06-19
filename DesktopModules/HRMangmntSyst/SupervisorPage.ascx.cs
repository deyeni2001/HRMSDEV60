using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.Web.UI.WebControls;

using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Roles;
using DotNetNuke.Security.Membership;
using AspNetSecurity = System.Web.Security;
using System.Web.SessionState;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

 
using ola.HRMangmntSyst;


namespace ola.HRMangmntSyst
{
   // public partial class SupervisorPage : PortalModuleBase, IActionable
    public partial class SupervisorPage : ola.ModuleBase.ModuleBase, IActionable
    {
        #region Optional Interfaces
        public ModuleActionCollection ModuleActions
        {
            get
            {
                ModuleActionCollection Actions = new ModuleActionCollection();
                Actions.Add(this.GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile), ModuleActionType.AddContent, "", "", this.EditUrl(), false, SecurityAccessLevel.Edit, true, false);
                return Actions;
            }
        }
        #endregion

         UserController objUserController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MViewSupervisor.ActiveViewIndex = 0;


                ArrayList objEmpIDList = new ArrayList();
                //int sup =
                objEmpIDList = (new EmployeeDetailsController()).SupAppraisalList();


                if (objEmpIDList.Count > 0)
                {

                    appraisalEmployeeList.DataSource = objEmpIDList;
                    appraisalEmployeeList.DataTextField = "EmployeeNum";
                    appraisalEmployeeList.DataValueField = "EmployeeID";
                    appraisalEmployeeList.DataBind();
                }
                appraisalEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));



                //Loading RatingKeys

                #region

                ArrayList objRatingKey = new ArrayList();
                objRatingKey = (new EmployeeAppraisalTableRatingKeyController()).List();

                if (objRatingKey.Count > 0)
                {
                    QualityRatingKey.DataSource = objRatingKey;
                    QualityRatingKey.DataTextField = "RatingDesc";
                    QualityRatingKey.DataValueField = "RatingKeyID";
                    QualityRatingKey.DataBind();

                }
                QualityRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));

                if (objRatingKey.Count > 0)
                {
                    ProductivityRatingKey.DataSource = objRatingKey;
                    ProductivityRatingKey.DataTextField = "RatingDesc";
                    ProductivityRatingKey.DataValueField = "RatingKeyID";
                    ProductivityRatingKey.DataBind();

                }
                ProductivityRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));

                if (objRatingKey.Count > 0)
                {
                    knowledgeRatingKey.DataSource = objRatingKey;
                    knowledgeRatingKey.DataTextField = "RatingDesc";
                    knowledgeRatingKey.DataValueField = "RatingKeyID";
                    knowledgeRatingKey.DataBind();

                }
                knowledgeRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    AdaptabilityRatingKey.DataSource = objRatingKey;
                    AdaptabilityRatingKey.DataTextField = "RatingDesc";
                    AdaptabilityRatingKey.DataValueField = "RatingKeyID";
                    AdaptabilityRatingKey.DataBind();

                }
                AdaptabilityRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    DependabilityRatingKey.DataSource = objRatingKey;
                    DependabilityRatingKey.DataTextField = "RatingDesc";
                    DependabilityRatingKey.DataValueField = "RatingKeyID";
                    DependabilityRatingKey.DataBind();

                }
                DependabilityRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    InitiativeRatingKey.DataSource = objRatingKey;
                    InitiativeRatingKey.DataTextField = "RatingDesc";
                    InitiativeRatingKey.DataValueField = "RatingKeyID";
                    InitiativeRatingKey.DataBind();

                }
                InitiativeRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    InterpersonalRatingKey.DataSource = objRatingKey;
                    InterpersonalRatingKey.DataTextField = "RatingDesc";
                    InterpersonalRatingKey.DataValueField = "RatingKeyID";
                    InterpersonalRatingKey.DataBind();

                }
                InterpersonalRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));

                if (objRatingKey.Count > 0)
                {
                    AttendanceRatingKey.DataSource = objRatingKey;
                    AttendanceRatingKey.DataTextField = "RatingDesc";
                    AttendanceRatingKey.DataValueField = "RatingKeyID";
                    AttendanceRatingKey.DataBind();

                }
                AttendanceRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    planningRatingKey.DataSource = objRatingKey;
                    planningRatingKey.DataTextField = "RatingDesc";
                    planningRatingKey.DataValueField = "RatingKeyID";
                    planningRatingKey.DataBind();

                }
                planningRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    TeamRatingKey.DataSource = objRatingKey;
                    TeamRatingKey.DataTextField = "RatingDesc";
                    TeamRatingKey.DataValueField = "RatingKeyID";
                    TeamRatingKey.DataBind();

                }
                TeamRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    leadershipRatingKey.DataSource = objRatingKey;
                    leadershipRatingKey.DataTextField = "RatingDesc";
                    leadershipRatingKey.DataValueField = "RatingKeyID";
                    leadershipRatingKey.DataBind();

                }
                leadershipRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    CommSkillRatingKey.DataSource = objRatingKey;
                    CommSkillRatingKey.DataTextField = "RatingDesc";
                    CommSkillRatingKey.DataValueField = "RatingKeyID";
                    CommSkillRatingKey.DataBind();

                }
                CommSkillRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));

                if (objRatingKey.Count > 0)
                {
                    planningRatingKey.DataSource = objRatingKey;
                    planningRatingKey.DataTextField = "RatingDesc";
                    planningRatingKey.DataValueField = "RatingKeyID";
                    planningRatingKey.DataBind();

                }
                planningRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));

                if (objRatingKey.Count > 0)
                {
                    developmentRatingKey.DataSource = objRatingKey;
                    developmentRatingKey.DataTextField = "RatingDesc";
                    developmentRatingKey.DataValueField = "RatingKeyID";
                    developmentRatingKey.DataBind();

                }
                developmentRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));


                if (objRatingKey.Count > 0)
                {
                    JudgementRatingKey.DataSource = objRatingKey;
                    JudgementRatingKey.DataTextField = "RatingDesc";
                    JudgementRatingKey.DataValueField = "RatingKeyID";
                    JudgementRatingKey.DataBind();

                }
                JudgementRatingKey.Items.Insert(0, new ListItem("***RatingKey***", "-1"));

                #endregion


            }

        }
        protected void welEmplomentBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 1;
        }
       
       
        protected void selfAppraisalBtn_Click1(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 2;

        }
        protected void queryHomeBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 0;
        }
      
        protected void supervisorMenuHome_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 0;
        }

        //Query Module

        #region
        protected void queryBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 1;
            PanelViewQuery.Visible = false;
        }

        //Display Query link action details

        #region
        protected void BtnSupQueryFinish_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 0;
        }
        protected void LinkBtnIssueQuery_Click(object sender, EventArgs e)
        {
            PanelQuery.Visible = true;
            PanelViewQuery.Visible = false;
            PanelDiscipline.Visible = false;
            LbQueryIssued.Visible = false;
            BtnSupQueryFinish.Visible = false;
        }
        protected void LinkBtnViewQuery_Click(object sender, EventArgs e)
        {
            PanelViewQuery.Visible = true;
            PanelQuery.Visible = false;
            PanelDiscipline.Visible = false;
            LbQueryIssued.Visible = false;
            BtnSupQueryFinish.Visible = false;

           

            ArrayList objEmployee = new ArrayList();
            int supervisorId = CurrentEmployeeDetail.EmployeeID;
            objEmployee = (new EmployeeDetailsController()).GetBySupervisor(supervisorId);
            if (objEmployee.Count > 0)
            {
                queryEmployeeList.DataSource = objEmployee;
                queryEmployeeList.DataTextField = "EmployeeNum";
                queryEmployeeList.DataValueField = "EmployeeID";
                queryEmployeeList.DataBind();
            }
            queryEmployeeList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

            lblQueryIssueDate.Text = DateTime.Now.ToString();

            lblQueryIssueDate.Visible = true;
            UserInfo objIssuedByUser = new UserInfo();
            objIssuedByUser = (new UserController()).GetUser(0, UserId);

            lblQueryIssuedBy.Text = objIssuedByUser.LastName + " " + objIssuedByUser.FirstName;

            //List queries sent by Supervisor
            int IssuedBy = objIssuedByUser.UserID;
            ArrayList objQuery = new ArrayList();

            objQuery = (new EmployeeQueryTableController()).GetByUsers(IssuedBy);
            if (objQuery.Count > 0)
            {
                GVSupervisorQuery.DataSource = objQuery;
                GVSupervisorQuery.DataBind();
                GVSupervisorQuery.Visible = true;
                // lblListQuery.Visible = true;
            }
            else
            {
                //  lblListQuery.Visible = false;
                GVSupervisorQuery.Visible = false;
            }

        }
#endregion

        //Display Query module details

        #region
        protected void supervisorMenuQueryBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 1;
            LbQueryIssued.Visible = false;
            BtnSupQueryFinish.Visible = false;
            PanelViewQuery.Visible = false;
            PanelQuery.Visible = false;
           
        }

                

        #endregion


        //Issue Query

        #region
        protected void issueQueryBtn_Click(object sender, EventArgs e)
        {
            EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
            objQuery.QueryReceivedBy = Convert.ToInt32(queryEmployeeList.SelectedValue);
            objQuery.QueryTitle = txtQueryTitle.Text;
            objQuery.Description = txtQueryDesc.Text;
            if (QueryFileUpload.HasFile)
            {
                string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();
                QueryFileUpload.SaveAs(filepath + "\\" + QueryFileUpload.FileName.ToString());
                objQuery.QueryLetter = "~/QueryLetters/" + "/" + QueryFileUpload.FileName.ToString();

               
            }
            objQuery.IssueDate = DateTime.Now.ToString();

            // get the  user that login
            UserInfo objIssuedByUser = new UserInfo();
            objIssuedByUser = (new UserController()).GetUser(0, UserId);
            objQuery.QueryIssuedBy = objIssuedByUser.UserID;

            int queryId = (new EmployeeQueryTableController()).AddQuery(objQuery);


            //Saving to log

            EmployeeQueryTableInfo objGetQuery = new EmployeeQueryTableInfo();
            objGetQuery = (new EmployeeQueryTableController()).Get(queryId);

            EmployeeQueryTableLogInfo objQueryLog = new EmployeeQueryTableLogInfo();
            objQueryLog.QueryReceivedBy = Convert.ToInt32(queryEmployeeList.SelectedValue);
            objQueryLog.QueryTitle = txtQueryTitle.Text;
            objQueryLog.Description = txtQueryDesc.Text;
            objQueryLog.QueryLetter = objGetQuery.QueryLetter;
            objQueryLog.QueryIssuedBy = objGetQuery.QueryIssuedBy;
            objQueryLog.IssueDate = objGetQuery.IssueDate;
            objQueryLog.QueryID_FK = objGetQuery.QueryID;

            int queryLogId = (new EmployeeQueryTableLogController()).LogAddQuery(objQueryLog);


            if (queryId > 0 && queryLogId > 0)
            {
                LbQueryIssued.Text = "Query issued succesfully";
                LbQueryIssued.Visible = true;
                BtnSupQueryFinish.Visible = true;
                PanelQuery.Visible = false;
                PanelViewQuery.Visible = false;
            }
            else
            {
                LbQueryIssued.Text = "Query issue failed";
                LbQueryIssued.Visible = true;
                BtnSupQueryFinish.Visible = true;
                PanelQuery.Visible = false;
                PanelViewQuery.Visible = false;
            }
        }
        protected void queryEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(queryEmployeeList.SelectedValue);
            EmployeeDetailsInfo objEmployee = new EmployeeDetailsInfo();
             objEmployee = (new EmployeeDetailsController()).Get(employeeID);

             EmployeeDepartmentTableInfo objGetDept = new EmployeeDepartmentTableInfo();
             int deptid = objEmployee.Department_FK;
             objGetDept = (new EmployeeDepartmentTableController()).Get(deptid);

             EmployeePositionTableInfo objGetPost = new EmployeePositionTableInfo();
             int postid = objEmployee.PositionHeld_FK;
             objGetPost = (new EmployeePositionTableController()).Get(postid);

             EmployeeLevelInfo objGetLevel = new EmployeeLevelInfo();
             int levelid = objEmployee.EmployeeLevel_FK;
             objGetLevel = (new EmployeeLevelController()).Get(levelid);

             UserInfo objGetUser = new UserInfo();
             objGetUser = (new UserController()).GetUser(0, UserId);

            lblEmpName.Text = objEmployee.LastName + " " + objEmployee.FirstName;
            lblEmpName.Visible = true;
            lblEmpDept.Text = objGetDept.DeptName;
            lblEmpDept.Visible = true;
            lblEmpPosition.Text = objGetPost.PositionName;
            lblEmpPosition.Visible = true;
            lblEmpLevel.Text = objGetLevel.LevelName;
            lblEmpLevel.Visible = true;
            string myDate = DateTime.Now.ToLongDateString();
            lblQueryIssueDate.Text = myDate;
            lblQueryIssueDate.Visible = true;
            lblQueryIssuedBy.Visible = true;
            lblQueryIssuedBy.Text = objGetUser.DisplayName;


        }
#endregion

        //Supervisor View Query

        #region
        protected void GVSupervisorQuery_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {

                EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
                objQuery = (new EmployeeQueryTableController()).Get(Convert.ToInt32(e.CommandArgument));
                int queryId = objQuery.QueryID;
                ViewState.Add("queryId", queryId);
                lblDisEmpNum.Text = objQuery.EmployeeNum;
                lblDisQueryTitle.Text = objQuery.QueryTitle;
                lblDisQueryDescription.Text = objQuery.Description;
                lblDisQueryIssueDay.Text = objQuery.IssueDate;
                lblDisQueryResponse.Text = objQuery.EmployeeResponse;
                lblDisResponseDate.Text = objQuery.ResponseDate;
                PanelDiscipline.Visible = true;
                PanelQuery.Visible = false;

                //UserInfo objUser = new UserInfo();
                //objUser = (new UserController()).GetUser(0, UserId);
                //lblDisciplineBy.Text = objUser.LastName + " " + objUser.FirstName;
                //lblDisciplineDate.Text = DateTime.Now.ToString();

                //ArrayList DisciplineType = new ArrayList();
                //DisciplineType = new EmployeeDisciplineTableController().List();
                //if (DisciplineType.Count > 0)
                //{
                //    ddlDisciplineType.DataSource = DisciplineType;
                //    ddlDisciplineType.DataValueField = "DisciplineID";
                //    ddlDisciplineType.DataTextField = "DiscplineDescription";
                //    ddlDisciplineType.DataBind();
                //    ddlDisciplineType.Visible = true;
                //}
                //ddlDisciplineType.Items.Insert(0, new ListItem("***Please select***", "-1"));
                //lblDisciplineDate.Text = DateTime.Now.ToString();
              
                
            }

        }

#endregion

       
        //Displine employee

        //#region
        //protected void btnSendDisciplined_Click(object sender, EventArgs e)
        //{
        //    EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
        //    int QueryID = Convert.ToInt32(ViewState["queryId"]);
        //    objQuery.QueryID = QueryID;
        //    objQuery.DisciplineDate = DateTime.Now.ToString();
        //    UserInfo objUser = new UserInfo();
        //    objUser = (new UserController()).GetUser(0, UserId);
        //    objQuery.DisciplinedBy = objUser.UserID;
        //    objQuery.DisciplineDetails = txtDisciplineDescription.Text;
        //    objQuery.DiscipliineType_FK = Convert.ToInt32(ddlDisciplineType.SelectedValue);
        //    if (DisciplinedLetterUpload.HasFile)
        //    {
        //        string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();

        //        // lblDisciplineLetterName.Text = DisciplinedLetterUpload.FileName;
        //        DisciplinedLetterUpload.SaveAs(filepath + "\\" + DisciplinedLetterUpload.FileName.ToString());
        //        objQuery.DisciplineLetter = "~/QueryLetters/" + "/" + DisciplinedLetterUpload.FileName.ToString();
        //    }
        //    (new EmployeeQueryTableController()).UpdateQueryDiscipline(objQuery);

        //}

        //#endregion

     
        #endregion



        protected void supervisorAppraisalBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 2;
        }

        protected void appraisalHomeBtn_Click(object sender, EventArgs e)
        {

            MViewSupervisor.ActiveViewIndex = 0;
        }
       
        protected void conpetencyNextBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 3;
        }

        //Appraisal Module

        #region 

        protected void appraisalEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSelfAssessment.Visible = true;

            EmployeeDetailsInfo objEmpDetails = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(appraisalEmployeeList.SelectedValue);
            objEmpDetails = (new EmployeeDetailsController()).Get(empID);

            EmployeeAppraisalTableInfo objApprais = new EmployeeAppraisalTableInfo();
            objApprais = (new EmployeeAppraisalTableController()).GetByEmpID(empID);

            EmployeeDepartmentTableInfo objDept = new EmployeeDepartmentTableInfo();
            int dept = objEmpDetails.Department_FK;
            objDept = (new EmployeeDepartmentTableController()).Get(dept);

            EmployeePositionTableInfo objPost = new EmployeePositionTableInfo();
            int post = objEmpDetails.PositionHeld_FK;
            objPost = (new EmployeePositionTableController()).Get(post);

            EmployeeDetailsInfo objSup = new EmployeeDetailsInfo();
            int supID = objEmpDetails.SupervisorID;
            objSup = (new EmployeeDetailsController()).Get(supID);
            
            LbEmpDept.Text = objDept.DeptName;
            LbEmpDept.Visible = true;
            LbEmpPosition.Text = objPost.PositionName;
            LbEmpPosition.Visible = true;
            LbEmpSup.Text = objSup.LastName + objSup.FirstName;
            LbEmpSup.Visible = true;
            string mydate = DateTime.Now.ToShortDateString();
            LbSupAppraisalDate.Text = mydate;
            LbSupAppraisalDate.Visible = true;
            LbAppraisalStartYear.Text = objApprais.AprpraisalStartYear;
            LbAppraisalStartYear.Visible = true;
            LbEvalPeriod.Text = objApprais.EvaPeriod;
            LbEvalPeriod.Visible = true;
            LbSelfAppraisalScore.Text = objApprais.AppraisalScore.ToString();
            LbSelfAppraisalScore.Visible = true;

            //Displaying details from Appraisal Table and Conpetency

            EmployeeAppraisalCompetencyTableInfo objDispaly = new EmployeeAppraisalCompetencyTableInfo();
            int empIDFK = Convert.ToInt32(appraisalEmployeeList.SelectedValue);
            objDispaly = (new EmployeeAppraisalCompetencyTableController()).GetByEmpID(empIDFK);

            txtExcelPerformance.Text = objDispaly.ExcelArea;
            txtStepsForImprovement.Text = objDispaly.StepsToTake;
            txtNeedsImprovemen.Text= objDispaly.AreaThatNeedsImprovement;
            txtExctxtNeedsSupervisorAssistance.Text = objDispaly.AreaThatNeedsAssistance;

            EmployeeAppraisalCompetencyTableInfo objCompete = new EmployeeAppraisalCompetencyTableInfo();
            int empID4 = Convert.ToInt32(appraisalEmployeeList.SelectedValue);
            objCompete = (new EmployeeAppraisalCompetencyTableController()).GetByEmpID(empID4);

           
            QualityRatingKey.ClearSelection();
            QualityRatingKey.Items.FindByValue(objCompete.Quality.ToString()).Selected = true;
            txtQualityRatingPoint.Text = objCompete.QuaPoint.ToString();


            knowledgeRatingKey.ClearSelection();
            knowledgeRatingKey.Items.FindByValue(objCompete.Knoweldge.ToString()).Selected = true;
            txtKnowledgeRatingPoint.Text = objCompete.KnowPoint.ToString();

            ProductivityRatingKey.ClearSelection();
            ProductivityRatingKey.Items.FindByValue(objCompete.Productivity.ToString()).Selected = true;
            txtProductivityRatingPoint.Text = objCompete.ProdPoint.ToString();

            AdaptabilityRatingKey.ClearSelection();
            AdaptabilityRatingKey.Items.FindByValue(objCompete.Adaptability.ToString()).Selected = true;
            txtAdaptabilityRatingPoint.Text = objCompete.AdaPoint.ToString();

            DependabilityRatingKey.ClearSelection();
            DependabilityRatingKey.Items.FindByValue(objCompete.Dependability.ToString()).Selected = true;
            txtDependabilityRatingPoint.Text = objCompete.DependPoint.ToString();
            
            InitiativeRatingKey.ClearSelection();
            InitiativeRatingKey.Items.FindByValue(objCompete.Initiative.ToString()).Selected = true;
            txtInitiativeRatingPoint.Text = objCompete.InitPoint.ToString();

            JudgementRatingKey.ClearSelection();
            JudgementRatingKey.Items.FindByValue(objCompete.Judgement.ToString()).Selected = true;
            txtJudgementRatingPoint.Text = objCompete.JudPoint.ToString();

            InterpersonalRatingKey.ClearSelection();
            InterpersonalRatingKey.Items.FindByValue(objCompete.InterterpersonalRelationship.ToString()).Selected = true;
            txtInterpersonalRatingPoint.Text = objCompete.InterPoint.ToString();

            AttendanceRatingKey.ClearSelection();
            AttendanceRatingKey.Items.FindByValue(objCompete.Puntuality.ToString()).Selected = true;
            txtAttendanceratingPoint.Text = objCompete.PuntPoint.ToString();
            
            TeamRatingKey.ClearSelection();
            TeamRatingKey.Items.FindByValue(objCompete.Team.ToString()).Selected = true;
            txtTeamRatingPoint.Text = objCompete.TeamPoint.ToString();

            CommSkillRatingKey.ClearSelection();
            CommSkillRatingKey.Items.FindByValue(objCompete.CommunicationSkills.ToString()).Selected = true;
            txtCommSkillRatingPoint.Text = objCompete.ComPoint.ToString();

            planningRatingKey.ClearSelection();
            planningRatingKey.Items.FindByValue(objCompete.Planning.ToString()).Selected = true;
            txtPlanningPoint.Text = objCompete.PlanPoint.ToString();

            leadershipRatingKey.ClearSelection();
            leadershipRatingKey.Items.FindByValue(objCompete.Leadership.ToString()).Selected = true;
            txtLeadershipPoint.Text = objCompete.LeadPoint.ToString();

            developmentRatingKey.ClearSelection();
            developmentRatingKey.Items.FindByValue(objCompete.Development.ToString()).Selected = true;
            txtDevelopmentRatingPoint.Text = objCompete.DevPoint.ToString();

            txtTotalPoint.Text = objApprais.TotalPoint;
            txtAppraisalpercentage.Text = objApprais.AppraisalScore.ToString() + "%";
            
            
        }

        //Loading ratingpoint

        #region

        // function
        private int summation()
        {

            int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);
            int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            int attend = Convert.ToInt32(txtAttendanceratingPoint.Text);
            int team = Convert.ToInt32(txtTeamRatingPoint.Text);
            int com = Convert.ToInt32(txtCommSkillRatingPoint.Text);
            int plan = Convert.ToInt32(txtPlanningPoint.Text);
            int lead = Convert.ToInt32(txtLeadershipPoint.Text);
            int dev = Convert.ToInt32(txtDevelopmentRatingPoint.Text);

            int TotalPoint = qua + prod + know + adap + depend + init + inter + jud + attend + team + com + plan + lead + dev;
            txtTotalPoint.Text = TotalPoint.ToString();
            return TotalPoint;
        }
        protected void QualityRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objQualityRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating1 = Convert.ToInt32(QualityRatingKey.SelectedValue);
            objQualityRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating1);
            txtQualityRatingPoint.Text = objQualityRatingPoint.RatingPoint.ToString();
          
        }

        protected void ProductivityRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objProductRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating2 = Convert.ToInt32(ProductivityRatingKey.SelectedValue);
            objProductRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating2);
            txtProductivityRatingPoint.Text = objProductRatingPoint.RatingPoint.ToString();
        }
        protected void knowledgeRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objKnowledgeRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating3 = Convert.ToInt32(knowledgeRatingKey.SelectedValue);
            objKnowledgeRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating3);
            txtKnowledgeRatingPoint.Text = objKnowledgeRatingPoint.RatingPoint.ToString();
           
        }
        protected void AdaptabilityRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objAdaptabilityRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating4 = Convert.ToInt32(AdaptabilityRatingKey.SelectedValue);
            objAdaptabilityRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating4);
            txtAdaptabilityRatingPoint.Text = objAdaptabilityRatingPoint.RatingPoint.ToString();
            // int TotalPoint = summation();


            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);

            //int TotalPoint = qua + prod + know + adap;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }
        protected void DependabilityRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objDependabilityRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating5 = Convert.ToInt32(DependabilityRatingKey.SelectedValue);
            objDependabilityRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating5);
            txtDependabilityRatingPoint.Text = objDependabilityRatingPoint.RatingPoint.ToString();
            // int TotalPoint = summation();


            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int TotalPoint = qua + prod + know + adap + depend;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }

        protected void InitiativeRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objInitiativeRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating6 = Convert.ToInt32(InitiativeRatingKey.SelectedValue);
            objInitiativeRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating6);
            txtInitiativeRatingPoint.Text = objInitiativeRatingPoint.RatingPoint.ToString();
            //int TotalPoint = summation();


            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);         

            //int TotalPoint = qua + prod + know + adap + depend + init;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }
        protected void JudgementRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objJudgementRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating = Convert.ToInt32(JudgementRatingKey.SelectedValue);
            objJudgementRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating);
            txtJudgementRatingPoint.Text = objJudgementRatingPoint.RatingPoint.ToString();
            //int TotalPoint = summation();

            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);

            //int TotalPoint = qua + prod + know + adap + depend + init + jud;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";

        }
        protected void InterpersonalRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objInterpersonalRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating6 = Convert.ToInt32(InterpersonalRatingKey.SelectedValue);
            objInterpersonalRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating6);
            txtInterpersonalRatingPoint.Text = objInterpersonalRatingPoint.RatingPoint.ToString();
            // int TotalPoint = summation();


            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            //int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);


            //int TotalPoint = qua + prod + know + adap + depend + init + jud + inter;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }
        protected void AttendanceRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objAttendanceRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating = Convert.ToInt32(AttendanceRatingKey.SelectedValue);
            objAttendanceRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating);
            txtAttendanceratingPoint.Text = objAttendanceRatingPoint.RatingPoint.ToString();
            //int TotalPoint = summation();

            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            //int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);
            //int attend = Convert.ToInt32(txtAttendanceratingPoint.Text);


            //int TotalPoint = qua + prod + know + adap + depend + init + inter + jud + attend;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }

        protected void TeamRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objTeamRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating = Convert.ToInt32(TeamRatingKey.SelectedValue);
            objTeamRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating);
            txtTeamRatingPoint.Text = objTeamRatingPoint.RatingPoint.ToString();
            // int TotalPoint = summation();

            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            //int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);
            //int attend = Convert.ToInt32(txtAttendanceratingPoint.Text);
            //int team = Convert.ToInt32(txtTeamRatingPoint.Text);

            //int TotalPoint = qua + prod + know + adap + depend + init + inter + jud + attend + team;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }
        protected void CommSkillRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objCommSkillRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating = Convert.ToInt32(CommSkillRatingKey.SelectedValue);
            objCommSkillRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating);
            txtCommSkillRatingPoint.Text = objCommSkillRatingPoint.RatingPoint.ToString();
            // int TotalPoint = summation();

            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            //int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);
            //int attend = Convert.ToInt32(txtAttendanceratingPoint.Text);
            //int team = Convert.ToInt32(txtTeamRatingPoint.Text);
            //int com = Convert.ToInt32(txtCommSkillRatingPoint.Text);


            //int TotalPoint = qua + prod + know + adap + depend + init + inter + jud + attend + team + com;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }

        protected void planningRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objPlanningRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating = Convert.ToInt32(planningRatingKey.SelectedValue);
            objPlanningRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating);
            txtPlanningPoint.Text = objPlanningRatingPoint.RatingPoint.ToString();
            //int TotalPoint = summation();

            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            //int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);
            //int attend = Convert.ToInt32(txtAttendanceratingPoint.Text);
            //int team = Convert.ToInt32(txtTeamRatingPoint.Text);
            //int com = Convert.ToInt32(txtCommSkillRatingPoint.Text);
            //int plan = Convert.ToInt32(txtPlanningPoint.Text);

            //int TotalPoint = qua + prod + know + adap + depend + init + inter + jud + attend + team + com + plan;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }
        protected void leadershipRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objLeadershipRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating = Convert.ToInt32(leadershipRatingKey.SelectedValue);
            objLeadershipRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating);
            txtLeadershipPoint.Text = objLeadershipRatingPoint.RatingPoint.ToString();


            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            //int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);
            //int attend = Convert.ToInt32(txtAttendanceratingPoint.Text);
            //int team = Convert.ToInt32(txtTeamRatingPoint.Text);
            //int com = Convert.ToInt32(txtCommSkillRatingPoint.Text);
            //int plan = Convert.ToInt32(txtPlanningPoint.Text);
            //int lead = Convert.ToInt32(txtLeadershipPoint.Text);
            //int dev = Convert.ToInt32(txtDevelopmentRatingPoint.Text);

            //int TotalPoint = qua + prod + know + adap + depend + init + inter + jud + attend + team + com + plan + lead;
            //txtTotalPoint.Text = TotalPoint.ToString();

        }

     
        protected void developmentRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objDevRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating = Convert.ToInt32(developmentRatingKey.SelectedValue);
            objDevRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating);
            txtDevelopmentRatingPoint.Text = objDevRatingPoint.RatingPoint.ToString();
            //  int TotalPoint = summation();


            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);
            //int adap = Convert.ToInt32(txtAdaptabilityRatingPoint.Text);
            //int depend = Convert.ToInt32(txtDependabilityRatingPoint.Text);


            //int init = Convert.ToInt32(txtInitiativeRatingPoint.Text);
            //int inter = Convert.ToInt32(txtInterpersonalRatingPoint.Text);
            //int jud = Convert.ToInt32(txtJudgementRatingPoint.Text);
            //int attend = Convert.ToInt32(txtAttendanceratingPoint.Text);
            //int team = Convert.ToInt32(txtTeamRatingPoint.Text);
            //int com = Convert.ToInt32(txtCommSkillRatingPoint.Text);
            //int plan = Convert.ToInt32(txtPlanningPoint.Text);
            //int lead = Convert.ToInt32(txtLeadershipPoint.Text);
            //int dev = Convert.ToInt32(txtDevelopmentRatingPoint.Text);

            //int TotalPoint = qua + prod + know + adap + depend + init + inter + jud + attend + team + com + plan + lead + dev;
            //txtTotalPoint.Text = TotalPoint.ToString();


            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }

        protected void competencySumBtn_Click(object sender, EventArgs e)
        {

            int TotalPoint = summation();
            txtTotalPoint.Text = TotalPoint.ToString();
            txtTotalPoint.Visible = true;
            txtAppraisalpercentage.Visible = true;
            float percent = TotalPoint * 100 / 140;
            txtAppraisalpercentage.Text = percent.ToString() + "%";
            LbPercent.Visible = true;
            LbSupPromo.Visible = true;
            supPromoRecomList.Visible = true;
            LbComment.Visible = true;
            txtSupComment.Visible = true;


            competencySaveBtn.Visible = true;
            conpetencyNextBtn.Visible = true;
            
        }
        #endregion

        protected void CompetencyShowBtn_Click(object sender, EventArgs e)
        {
            string sh = CompetencyShowBtn.Text.ToLower();

            if (sh == "show")
            {
                PanelCompetentShow.Visible = true;
                CompetencyShowBtn.Text = "Hide";

            }
            else
            {
                PanelCompetentShow.Visible = false;
                CompetencyShowBtn.Text = "Show";

            }
        }

        //Saving Supervisor Appraisal info

        #region
        protected void competencySaveBtn_Click(object sender, EventArgs e)
        {

            try
            {
               // int AppraisalID = Convert.ToInt32(ViewState["AppraisalID"]);

                EmployeeDetailsInfo objEmpDetails = new EmployeeDetailsInfo();
                int empDetails =Convert.ToInt32(appraisalEmployeeList.SelectedValue);
                objEmpDetails = (new EmployeeDetailsController()).Get(empDetails);
                ViewState.Add("empDetails", empDetails);

                EmployeeAppraisalTableInfo objEmpAppraisal = new EmployeeAppraisalTableInfo();
                int AppEmpID = empDetails;
                objEmpAppraisal = (new EmployeeAppraisalTableController()).GetByEmpID(AppEmpID);

                //int EmployeeID_FK = Convert.ToInt32(ViewState("EmployeeID_FK"));



                EmployeeAppraisalTableInfo objAppriasalInfo = new EmployeeAppraisalTableInfo();
                
             
                objAppriasalInfo.TotalPoint = this.txtTotalPoint.Text.Trim();
                objAppriasalInfo.AppraisalStatus = "2";
                objAppriasalInfo.SupAppraisalDate = this.LbSupAppraisalDate.Text.Trim();
                objAppriasalInfo.AppraisalID = objEmpAppraisal.AppraisalID;

               (new EmployeeAppraisalTableController()).SupFirstUpdate(objAppriasalInfo);

              EmployeeAppraisalTableInfo objAppriasalInfo2 = new EmployeeAppraisalTableInfo();
              int appraise = objEmpAppraisal.AppraisalID;
             objAppriasalInfo2 = (new EmployeeAppraisalTableController()).Get(appraise);

                EmployeeAppraisalCompetencyTableInfo objCompetent1= new EmployeeAppraisalCompetencyTableInfo();
                int CompetencyEmpID = empDetails;
                objCompetent1 = (new EmployeeAppraisalCompetencyTableController()).GetByEmpID(CompetencyEmpID);
                int comp = objCompetent1.CompetencyID;
                int appraisa = objCompetent1.AppraisalID_FK;

                
                EmployeeAppraisalCompetencyTableInfo objCompetent = new EmployeeAppraisalCompetencyTableInfo();

                objCompetent.ExcelArea = this.txtExcelPerformance.Text.Trim();
                objCompetent.AreaThatNeedsAssistance = this.txtExctxtNeedsSupervisorAssistance.Text.Trim();
                objCompetent.AreaThatNeedsImprovement = this.txtNeedsImprovemen.Text.Trim();
                objCompetent.StepsToTake = this.txtStepsForImprovement.Text.Trim();


                objCompetent.Quality = Convert.ToInt32(QualityRatingKey.SelectedValue);
                objCompetent.QuaPoint = Convert.ToInt32(this.txtQualityRatingPoint.Text.Trim());
                objCompetent.Knoweldge = Convert.ToInt32(knowledgeRatingKey.SelectedValue);
                objCompetent.KnowPoint = Convert.ToInt32(this.txtKnowledgeRatingPoint.Text.Trim());
                objCompetent.Judgement = Convert.ToInt32(JudgementRatingKey.SelectedValue);
                objCompetent.JudPoint = Convert.ToInt32(this.txtJudgementRatingPoint.Text.Trim());
                objCompetent.Initiative = Convert.ToInt32(InitiativeRatingKey.SelectedValue);
                objCompetent.InitPoint = Convert.ToInt32(this.txtInitiativeRatingPoint.Text.Trim());
                objCompetent.InterterpersonalRelationship = Convert.ToInt32(InterpersonalRatingKey.SelectedValue);
                objCompetent.InterPoint = Convert.ToInt32(this.txtInterpersonalRatingPoint.Text.Trim());
                objCompetent.Leadership = Convert.ToInt32(leadershipRatingKey.SelectedValue);
                objCompetent.LeadPoint = Convert.ToInt32(this.txtInterpersonalRatingPoint.Text.Trim());
                objCompetent.Planning = Convert.ToInt32(planningRatingKey.SelectedValue);
                objCompetent.PlanPoint = Convert.ToInt32(this.txtPlanningPoint.Text.Trim());
                objCompetent.Productivity = Convert.ToInt32(ProductivityRatingKey.SelectedValue);
                objCompetent.ProdPoint = Convert.ToInt32(this.txtProductivityRatingPoint.Text.Trim());
                objCompetent.Puntuality = Convert.ToInt32(AttendanceRatingKey.SelectedValue);
                objCompetent.PuntPoint = Convert.ToInt32(this.txtAttendanceratingPoint.Text.Trim());
                objCompetent.CommunicationSkills = Convert.ToInt32(CommSkillRatingKey.SelectedValue);
                objCompetent.ComPoint = Convert.ToInt32(this.txtCommSkillRatingPoint.Text.Trim());
                objCompetent.Adaptability = Convert.ToInt32(AdaptabilityRatingKey.SelectedValue);
                objCompetent.AdaPoint = Convert.ToInt32(this.txtAdaptabilityRatingPoint.Text.Trim());
                objCompetent.Dependability = Convert.ToInt32(DependabilityRatingKey.SelectedValue);
                objCompetent.DependPoint = Convert.ToInt32(this.txtDependabilityRatingPoint.Text.Trim());
                objCompetent.Development = Convert.ToInt32(developmentRatingKey.SelectedValue);
                objCompetent.DevPoint = Convert.ToInt32(this.txtDevelopmentRatingPoint.Text.Trim());
                objCompetent.Team = Convert.ToInt32(TeamRatingKey.SelectedValue);
                objCompetent.TeamPoint = Convert.ToInt32(this.txtTeamRatingPoint.Text.Trim());
                objCompetent.OverallPoint = Convert.ToInt32(this.txtTotalPoint.Text.Trim());
                objCompetent.AppraisalID_FK = appraisa;
                objCompetent.CompetencyID = comp;
                    //objCompetent1.CompetencyID;

                (new EmployeeAppraisalCompetencyTableController()).SupFirstUpdate(objCompetent);

              EmployeeAppraisalCompetencyTableInfo objCompetent2 = new EmployeeAppraisalCompetencyTableInfo();
              int compt = comp;
                  //objCompetent1.CompetencyID;
             objCompetent2 = (new EmployeeAppraisalCompetencyTableController()).Get(compt);
             

                EmployeeAppraisalTableInfo ObjAppraisal2 = new EmployeeAppraisalTableInfo();
                ObjAppraisal2.AppraisalID = objEmpAppraisal.AppraisalID;
                
                //Calculating Appraisal score
                int point = objCompetent2.OverallPoint;
                float appraisaScore = point * 100 / 140;
                ObjAppraisal2.AppraisalScore = Convert.ToInt32(appraisaScore);
                ObjAppraisal2.SupComment = this.txtSupComment.Text.Trim();
                ObjAppraisal2.PromoRecommendation = this.supPromoRecomList.SelectedItem.Text.Trim();
                ObjAppraisal2.SupervisorID_FK = objEmpDetails.SupervisorID;
                (new EmployeeAppraisalTableController()).SupAppraisalScoreUpdate(ObjAppraisal2);


                EmployeeAppraisalTableInfo ObjAppraisal3 = new EmployeeAppraisalTableInfo();
                int apraise3 = ObjAppraisal2.AppraisalID;
                ObjAppraisal3 = (new EmployeeAppraisalTableController()).Get(apraise3);

                //where i am on 21/09/2018

                //Keeping log
             
                EmployeeAppraisalTableLogInfo objAppriasalLogInfo = new EmployeeAppraisalTableLogInfo();
                
                objAppriasalLogInfo.EmployeeNum = objEmpDetails.EmployeeNum;
                objAppriasalLogInfo.AppraisalScore = Convert.ToInt32(appraisaScore);
                    //ObjAppraisal3.AppraisalScore;
                objAppriasalLogInfo.TotalPoint = this.txtTotalPoint.Text.Trim();
                objAppriasalLogInfo.EvaPeriod = this.LbEvalPeriod.Text.Trim();
                objAppriasalLogInfo.AprpraisalStartYear = this.LbAppraisalStartYear.Text.Trim();
                objAppriasalLogInfo.AppraisalStatus = "2";
                objAppriasalLogInfo.EmpAppraisalDate = ObjAppraisal3.EmpAppraisalDate;
                objAppriasalLogInfo.SupAppraisalDate = LbSupAppraisalDate.Text.Trim();
                objAppriasalLogInfo.SupComment = this.txtSupComment.Text.Trim();
                objAppriasalLogInfo.PromoRecommendation = this.supPromoRecomList.SelectedItem.Text.Trim();
                objAppriasalLogInfo.EmployeeID_FK = empDetails;
                objAppriasalLogInfo.SupervisorID_FK = objEmpDetails.SupervisorID;
              //  objAppriasalLogInfo.HRID_FK = objEmpDetails.HRID;
                objAppriasalLogInfo.AppraisalID_FK = apraise3;
                objAppriasalLogInfo.SentBy = 2; 

                int AppraisalLogID = (new EmployeeAppraisalTableLogController()).LogSupEmpAdd(objAppriasalLogInfo);
                ViewState.Add("AppraisalLogID", AppraisalLogID);

                
                EmployeeAppraisalCompetencyTableLogInfo objCompetentLog = new EmployeeAppraisalCompetencyTableLogInfo();

                objCompetentLog.ExcelArea = this.txtExcelPerformance.Text.Trim();
                objCompetentLog.StepsToTake = this.txtStepsForImprovement.Text.Trim();
                objCompetentLog.AreaThatNeedsAssistance = this.txtExctxtNeedsSupervisorAssistance.Text.Trim();
                objCompetentLog.AreaThatNeedsImprovement = this.txtNeedsImprovemen.Text.Trim();


                objCompetentLog.Quality = Convert.ToInt32(QualityRatingKey.SelectedValue);
                objCompetentLog.QuaPoint = Convert.ToInt32(this.txtQualityRatingPoint.Text.Trim());
                objCompetentLog.Knoweldge = Convert.ToInt32(knowledgeRatingKey.SelectedValue);
                objCompetentLog.KnowPoint = Convert.ToInt32(this.txtKnowledgeRatingPoint.Text.Trim());
                objCompetentLog.Judgement = Convert.ToInt32(JudgementRatingKey.SelectedValue);
                objCompetentLog.JudPoint = Convert.ToInt32(this.txtJudgementRatingPoint.Text.Trim());
                objCompetentLog.Initiative = Convert.ToInt32(InitiativeRatingKey.SelectedValue);
                objCompetentLog.InitPoint = Convert.ToInt32(this.txtInitiativeRatingPoint.Text.Trim());
                objCompetentLog.InterterpersonalRelationship = Convert.ToInt32(InterpersonalRatingKey.SelectedValue);
                objCompetentLog.InterPoint = Convert.ToInt32(this.txtInterpersonalRatingPoint.Text.Trim());
                objCompetentLog.Leadership = Convert.ToInt32(leadershipRatingKey.SelectedValue);
                objCompetentLog.LeadPoint = Convert.ToInt32(this.txtInterpersonalRatingPoint.Text.Trim());
                objCompetentLog.Planning = Convert.ToInt32(planningRatingKey.SelectedValue);
                objCompetentLog.PlanPoint = Convert.ToInt32(this.txtPlanningPoint.Text.Trim());
                objCompetentLog.Productivity = Convert.ToInt32(ProductivityRatingKey.SelectedValue);
                objCompetentLog.ProdPoint = Convert.ToInt32(this.txtProductivityRatingPoint.Text.Trim());
                objCompetentLog.Puntuality = Convert.ToInt32(AttendanceRatingKey.SelectedValue);
                objCompetentLog.PunPoint = Convert.ToInt32(this.txtAttendanceratingPoint.Text.Trim());
                objCompetentLog.CommunicationSkills = Convert.ToInt32(CommSkillRatingKey.SelectedValue);
                objCompetentLog.ComPoint = Convert.ToInt32(this.txtCommSkillRatingPoint.Text.Trim());
                objCompetentLog.Adaptability = Convert.ToInt32(AdaptabilityRatingKey.SelectedValue);
                objCompetentLog.AdaPoint = Convert.ToInt32(this.txtAdaptabilityRatingPoint.Text.Trim());
                objCompetentLog.Dependability = Convert.ToInt32(DependabilityRatingKey.SelectedValue);
                objCompetentLog.DependPoint = Convert.ToInt32(this.txtDependabilityRatingPoint.Text.Trim());
                objCompetentLog.Development = Convert.ToInt32(developmentRatingKey.SelectedValue);
                objCompetentLog.DevPoint = Convert.ToInt32(this.txtDevelopmentRatingPoint.Text.Trim());
                objCompetentLog.Team = Convert.ToInt32(TeamRatingKey.SelectedValue);
                objCompetentLog.TeamPoint = Convert.ToInt32(this.txtTeamRatingPoint.Text.Trim());
                objCompetentLog.OverallPoint = Convert.ToInt32(this.txtTotalPoint.Text.Trim());
                objCompetentLog.EmployeeID_FK = empDetails;

                objCompetentLog.SupervisorID_FK = objEmpDetails.SupervisorID;
                objCompetentLog.HRID_FK = objEmpDetails.HRID;
                objCompetentLog.AppraisalID_FK = appraisa;
                objCompetentLog.CompetencyID_FK = comp;
                    //objCompetent2.CompetencyID;
                objCompetentLog.SentBy = 2; 

                int CompetencyLogID = (new EmployeeAppraisalCompetencyTableLogController()).Add(objCompetentLog);

                if (appraisa > 0 && AppraisalLogID > 0 && comp > 0 && CompetencyLogID > 0)
                {
                    LbSuccess.Text = "Details Successfully Updated, Click 'Next' Nutton to add Next year Goals" ;
                    LbSuccess.Visible = true;

                }
                else
                {
                    LbSuccess.Text = "Details Not Updated";
                    LbSuccess.Visible = true;
                }



            }

            catch
            {

            }
        }

#endregion


        protected void AddNxtYrGoalBtn_Click(object sender, EventArgs e)
        {
            PanelNextYearGoal.Visible = true;
            

           // ViewState.Add("empDetails", empDetails);

            int empDetails = Convert.ToInt32(ViewState["empDetails"]);

            EmployeeAppraisalTableInfo objApp = new EmployeeAppraisalTableInfo();
            objApp = (new EmployeeAppraisalTableController()).GetByEmpID(empDetails);

            ArrayList objEmpGoals = new ArrayList();
            int apraise4 = objApp.AppraisalID;
            objEmpGoals = (new EmployeeApprasalTableGoalController()).GetByEmployeeAppraisalTable(apraise4);
            if (objEmpGoals.Count > 0)
            {
                GViewEmpNextGoal.DataSource = objEmpGoals;
                GViewEmpNextGoal.DataBind();
                GViewEmpNextGoal.Visible = true;
            }
        }
        protected void ShowData()
        {
            int empDetails = Convert.ToInt32(ViewState["empDetails"]);

          
            foreach (GridViewRow x in GViewEmpNextGoal.Rows)
            {

                TextBox a = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                a = (TextBox)x.FindControl("txtNextGoalID");
                string goal = a.Text;

                ArrayList objEmpGoals = new ArrayList();
                int goalID = Convert.ToInt32(goal);

               objEmpGoals = (new EmployeeApprasalTableGoalController()).GoalGetByArray(goalID);
                
                if (objEmpGoals.Count > 0)
                {
                    GViewEmpNextGoal.DataSource = objEmpGoals;
                    GViewEmpNextGoal.DataBind();
                  
                }

               
            }
        }
        protected void GViewEmpNextGoal_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GViewEmpNextGoal.EditIndex = e.NewEditIndex;
            
           ShowData();
        }

        protected void GViewEmpNextGoal_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            foreach (GridViewRow x in GViewEmpNextGoal.Rows)
            {
                int empDetails = Convert.ToInt32(ViewState["empDetails"]);

                EmployeeApprasalTableGoalInfo objgol = new EmployeeApprasalTableGoalInfo();
                objgol = (new EmployeeApprasalTableGoalController()).GetByEmpDetails(empDetails);

                //Finding the controls from Gridview for the row which is going to update 
                 TextBox GoalDesc= GViewEmpNextGoal.Rows[e.RowIndex].FindControl("txtGoalDesc") as TextBox;
                TextBox GoalObjectives = GViewEmpNextGoal.Rows[e.RowIndex].FindControl("txtGoalObjectives") as TextBox;
                TextBox GoalCompletetiondate = GViewEmpNextGoal.Rows[e.RowIndex].FindControl("txtGoalCompletetiondate") as TextBox;
             
                EmployeeApprasalTableGoalInfo objUpdate = new EmployeeApprasalTableGoalInfo();
                objUpdate.GoalDesc = GoalDesc.Text.Trim();
                objUpdate.GoalObjectives = GoalObjectives.Text.Trim();
                 objUpdate.GoalEvaPoint = objgol.GoalEvaPoint;
                 objUpdate.GoalCompletetiondate = GoalCompletetiondate.Text.Trim();
                objUpdate.AppraisalID_FK = objgol.AppraisalID_FK;
                objUpdate.GoalID = objgol.GoalID;
                (new EmployeeApprasalTableGoalController()).GoalSupUpdate(objUpdate);
                ShowData();

                EmployeeApprasalTableGoalInfo objUpdatedGoal = new EmployeeApprasalTableGoalInfo();
                int goalID = objgol.GoalID;
                objUpdatedGoal = (new EmployeeApprasalTableGoalController()).Get(goalID);

                EmployeeApprasalTableGoalLogInfo objGoalLog = new EmployeeApprasalTableGoalLogInfo();

                objGoalLog.GoalDesc = GoalDesc.Text.Trim();
                objGoalLog.GoalObjectives = GoalObjectives.Text.Trim();
                objGoalLog.GoalEvaPoint = objgol.GoalEvaPoint;
                objGoalLog.GoalCompletetiondate = GoalCompletetiondate.Text.Trim();
                objGoalLog.EmployeeID_FK = objUpdatedGoal.EmployeeID_FK;
                objGoalLog.SupervisorID_FK = objUpdatedGoal.SupervisorID_FK;
                objGoalLog.HRID_FK = objUpdatedGoal.HRID_FK;
                objGoalLog.AppraisalID_FK = objUpdatedGoal.AppraisalID_FK;
                objGoalLog.GoalID_FK = objgol.GoalID;
                objGoalLog.SentBy = 2;

                int GoalLogID = (new EmployeeApprasalTableGoalLogController()).Add(objGoalLog);

                if (GoalLogID > 0)
                {
                    LbGoalAdded.Text = "Update Successful";
                    LbGoalAdded.Visible = true;

                }
                else
                {
                    LbGoalAdded.Text = "Update Not Successful";
                    LbGoalAdded.Visible = true;
                }
                ShowData();

            }
        }


       // Cancelling
        protected void GViewEmpNextGoal_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GViewEmpNextGoal.EditIndex = -1;
            ShowData();

        }
        protected void GoalFinishBtn_Click(object sender, EventArgs e)
        {
            MViewSupervisor.ActiveViewIndex = 0;
        }

        //protected void GoalNextBtn_Click(object sender, EventArgs e)
        //{
        //    PanelComment.Visible = true;
        //    int empDetails = Convert.ToInt32(ViewState["empDetails"]);
        //    EmployeeAppraisalTableInfo objCom = new EmployeeAppraisalTableInfo();
        //    objCom = (new EmployeeAppraisalTableController()).GetByEmpID(empDetails);

        //    LbSupAppraisalScore.Text = objCom.AppraisalScore.ToString();
        //}
        
        //   protected void txtPromExam_TextChanged(object sender, EventArgs e)
        //{
        //       //jAppraise.PromoExamScore = Convert.ToInt32(this.txtPromoExamScore.Text.Trim());
        //    int supScore = Convert.ToInt32(LbSupAppraisalScore.Text);
        //    int exam = Convert.ToInt32(this.txtPromoExamScore.Text.Trim());
        //    int total = supScore + exam;
        //}
        //protected void ApraiseBtn_Click(object sender, EventArgs e)
        //{
        //    int empDetails = Convert.ToInt32(ViewState["empDetails"]);
        //    EmployeeAppraisalTableInfo objCom = new EmployeeAppraisalTableInfo();
        //    objCom = (new EmployeeAppraisalTableController()).GetByEmpID(empDetails);

        //    LbSupAppraisalScore.Text = objCom.AppraisalScore.ToString();

        //    EmployeeAppraisalTableInfo ObjAppraise = new EmployeeAppraisalTableInfo();
        //    ObjAppraise.PromoExamScore = Convert.ToInt32(this.txtPromoExamScore.Text.Trim());
        //    int supScore = Convert.ToInt32(LbSupAppraisalScore.Text);
        //    int exam = Convert.ToInt32(this.txtPromoExamScore.Text.Trim());
        //    int total = supScore + exam;
        //    ObjAppraise.TotalAppraisalScore = total;
        //    ObjAppraise.AppraisalID = objCom.AppraisalID;
        //    ObjAppraise.SupComment = this.txtSupcomment.Text.Trim();
        //    ObjAppraise.PromoRecommendation = promoRecomList.SelectedItem.Text.Trim();

        //    (new EmployeeAppraisalTableController()).SupAppraiseUpdate(ObjAppraise);
        //   if (ObjAppraise.TotalAppraisalScore > 0)
        //    {
        //        LbAppraiseSuccess.Text = "Employee successfully Appraised";
        //        LbAppraiseSuccess.Visible = true;

        //    }

        //   else
        //   {
        //       LbAppraiseSuccess.Text = "Employee Not successfully Appraised";
        //       LbAppraiseSuccess.Visible = true;
        //   }

          
        //    //Keeping Log
        //    EmployeeAppraisalTableLogInfo ObjLogAppraise = new EmployeeAppraisalTableLogInfo();
        //    ObjLogAppraise.PromoExamScore = Convert.ToInt32(this.txtPromoExamScore.Text.Trim());
        //    ObjLogAppraise.TotalAppraisalScore = total;
        //    ObjLogAppraise.AppraisalID_FK = objCom.AppraisalID;
        //    ObjLogAppraise.SupComment = this.txtSupComment.Text.Trim();
        //    ObjLogAppraise.PromoRecommendation = promoRecomList.SelectedItem.Text.Trim();
        //    ObjLogAppraise.AppraisalID_FK = objCom.AppraisalID;
        //    (new EmployeeAppraisalTableLogController()).LogSupAppraiseUpdate(ObjLogAppraise);

        //     // (ObjLogAppraise.TotalAppraisalScore > 0 && != null));

        //}

      

        //#region
        //protected void goalAddBtn_Click(object sender, EventArgs e)
        //{
        //    int AppraisalID = Convert.ToInt32(ViewState["AppraisalID"]);
        //    PanelNextYearGoal.Visible = true;

        //    EmployeeDetailsInfo objEmpDetails =new EmployeeDetailsInfo();
        //    int empDetails =Convert.ToInt32(appraisalEmployeeList.SelectedValue);
        //    objEmpDetails = (new EmployeeDetailsController()).Get(empDetails);


        //    int EmpID = objEmpDetails.EmployeeID;
        //    int SupID = objEmpDetails.SupervisorID;
        //    int HRID = objEmpDetails.HRID;
            

        //    ArrayList objArr = new ArrayList();

        //    if (GViewNextYearGoalList.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < GViewNextYearGoalList.Rows.Count; i++)
        //        {
        //            EmployeeApprasalTableGoalInfo objGoal = new EmployeeApprasalTableGoalInfo();
        //            objGoal.GoalDesc = GViewNextYearGoalList.Rows[i].Cells[0].Text.ToString();
        //            objGoal.GoalObjectives = GViewNextYearGoalList.Rows[i].Cells[1].Text.ToString();
        //            objGoal.GoalEvaPoint = Convert.ToInt32(GViewNextYearGoalList.Rows[i].Cells[2].Text.ToString());
        //            objGoal.GoalCompletetiondate = GViewNextYearGoalList.Rows[i].Cells[3].Text.ToString();
        //            objGoal.EmployeeID_FK = EmpID;
        //            objGoal.SupervisorID_FK = SupID;
        //            objGoal.HRID_FK = HRID;
        //            objGoal.AppraisalID_FK = AppraisalID;
        //            //objGoal.GoalID = 

        //            objArr.Add(objGoal);

        //        }
        //    }

        //    EmployeeApprasalTableGoalInfo objGoal2 = new EmployeeApprasalTableGoalInfo();
        //    objGoal2.GoalDesc = this.txtNxtYearGoalDesc.Text.Trim();
        //    objGoal2.GoalObjectives = this.txtNxtYearGoalObjective.Text.Trim();
        //    objGoal2.GoalEvaPoint = Convert.ToInt32(this.txtEvalPoint.Text.Trim());
        //    objGoal2.EmployeeID_FK = EmpID;
        //    objGoal2.SupervisorID_FK = SupID;
        //    objGoal2.HRID_FK = HRID;
        //    objGoal2.AppraisalID_FK = AppraisalID;
        //    objGoal2.GoalCompletetiondate = this.goalNxtYrDayList.SelectedItem.Text.Trim() + "-" + goalNxtYrMonthList.SelectedItem.Text.Trim() + "-" + goalNxtYrYearList.SelectedItem.Text.Trim();

        //    objArr.Add(objGoal2);
        //    GViewNextYearGoalList.DataSource = objArr;
        //    GViewNextYearGoalList.DataBind();
        //    GViewNextYearGoalList.Visible = true;
        //    goalsaveBtn.Visible = true;
        //    goalBackBtn.Visible = true;
        //    goalFinishBtn.Visible = true;
        //    //refereshGoalPage();



        //   // Keeping GoalLog

        //    ArrayList objArr2 = new ArrayList();
        //    int AppraisalLogID = Convert.ToInt32(ViewState["AppraisalLogID"]);
        //    int AppraisalID2 = Convert.ToInt32(ViewState["AppraisalID"]);
            
        //    if (GViewNextGoalLog.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < GViewNextGoalLog.Rows.Count; i++)
        //        {
        //            EmployeeApprasalTableGoalLogInfo objGoalLog = new EmployeeApprasalTableGoalLogInfo();
        //            objGoalLog.GoalDesc = GViewNextGoalLog.Rows[i].Cells[0].Text.ToString();
        //            objGoalLog.GoalObjectives = GViewNextGoalLog.Rows[i].Cells[1].Text.ToString();
        //            objGoalLog.GoalEvaPoint = Convert.ToInt32(GViewNextGoalLog.Rows[i].Cells[2].Text.ToString());
        //            objGoalLog.GoalCompletetiondate = GViewNextGoalLog.Rows[i].Cells[3].Text.ToString();
        //            objGoalLog.SentBy = Convert.ToInt32(GViewNextGoalLog.Rows[i].Cells[4].Text.ToString());
        //            objGoalLog.EmployeeID_FK = EmpID;
        //            objGoalLog.SupervisorID_FK = SupID;
        //            objGoalLog.HRID_FK = HRID;
        //            objGoalLog.AppraisalID_FK = AppraisalID2;

        //            objArr2.Add(objGoalLog);

        //        }
        //    }

        //    EmployeeApprasalTableGoalLogInfo objGoalLog2 = new EmployeeApprasalTableGoalLogInfo();
        //    objGoalLog2.GoalDesc = this.txtNxtYearGoalDesc.Text.Trim();
        //    objGoalLog2.GoalObjectives = this.txtNxtYearGoalObjective.Text.Trim();
        //    objGoalLog2.GoalEvaPoint = Convert.ToInt32(this.txtEvalPoint.Text.Trim());
        //    objGoalLog2.SentBy = 1;
        //    objGoalLog2.EmployeeID_FK = EmpID;
        //    objGoalLog2.SupervisorID_FK = SupID;
        //    objGoalLog2.HRID_FK = HRID;
        //    objGoalLog2.AppraisalID_FK = AppraisalID2;
        //   // objGoalLog2.GoalID_FK = GoalID;
        //    objGoalLog2.GoalCompletetiondate = this.goalNxtYrDayList.SelectedItem.Text.Trim() + "-" + goalNxtYrMonthList.SelectedItem.Text.Trim() + "-" + goalNxtYrYearList.SelectedItem.Text.Trim();

        //    objArr2.Add(objGoalLog2);
        //    GViewNextGoalLog.DataSource = objArr2;
        //    GViewNextGoalLog.DataBind();
        //    GViewNextGoalLog.Visible = true;
        //   refereshGoalPage();


        //}
        //private void refereshGoalPage()
        //{
        //    this.txtNxtYearGoalDesc.Text = "";
        //    this.txtNxtYearGoalObjective.Text = "";
        //    this.txtEvalPoint.Text = "";
        //    goalNxtYrDayList.ClearSelection();
        //    goalNxtYrMonthList.ClearSelection();
        //    goalNxtYrYearList.ClearSelection();

        //}

        ////saving goals
        //protected void goalsaveBtn_Click(object sender, EventArgs e)
        //{
        //    EmployeeDetailsInfo objEmpDetails = new EmployeeDetailsInfo();
        //    int empDetails = Convert.ToInt32(appraisalEmployeeList.SelectedValue);
        //    objEmpDetails = (new EmployeeDetailsController()).Get(empDetails);

        //    try
        //    {
        //        EmployeeAppraisalTableInfo objAppr2 = new EmployeeAppraisalTableInfo();

        //        int AppraisalID = Convert.ToInt32(ViewState["AppraisalID"]);
        //        ArrayList ObjArr = new ArrayList();
        //        foreach (GridViewRow g1 in GViewNextYearGoalList.Rows)
        //        {
        //            EmployeeApprasalTableGoalInfo objGoalInfo = new EmployeeApprasalTableGoalInfo();
        //            objGoalInfo.GoalDesc = g1.Cells[0].Text;
        //            objGoalInfo.GoalObjectives = g1.Cells[1].Text;
        //            objGoalInfo.GoalEvaPoint = Convert.ToInt32(g1.Cells[2].Text);
        //            objGoalInfo.GoalCompletetiondate = g1.Cells[3].Text;
        //            objGoalInfo.EmployeeID_FK = objEmpDetails.EmployeeID;
        //            objGoalInfo.SupervisorID_FK = objEmpDetails.SupervisorID;
        //            objGoalInfo.HRID_FK = objEmpDetails.HRID;
        //            objGoalInfo.AppraisalID_FK = AppraisalID;

        //            int GoalID = (new EmployeeApprasalTableGoalController()).Add(objGoalInfo);
        //            ViewState.Add("GoalID", GoalID);

        //            if (GoalID > 0)
        //            {
        //                LbGoalAdded.Text = "Next year Goals  have been successfully saved ";
        //                LbGoalAdded.Visible = true;
        //            }
        //            else
        //            {
        //                LbGoalAdded.Text = "Next year Goals  Not saved ";
        //                LbGoalAdded.Visible = true;
        //            }

        //        }

        //        ArrayList ObjArr2 = new ArrayList();
        //        int AppraisalLogID = Convert.ToInt32(ViewState["AppraisalLogID"]);
        //        int AppraisalID2 = Convert.ToInt32(ViewState["AppraisalID"]);
        //        foreach (GridViewRow g2 in GViewNextGoalLog.Rows)
        //        {
        //            EmployeeApprasalTableGoalInfo objGoal3 = new EmployeeApprasalTableGoalInfo();
        //            int GoalID = Convert.ToInt32(ViewState["GoalID"]);
        //            objGoal3 = (new EmployeeApprasalTableGoalController()).Get(GoalID);


        //            EmployeeApprasalTableGoalLogInfo objGoalLogInfo = new EmployeeApprasalTableGoalLogInfo();
        //            objGoalLogInfo.GoalDesc = g2.Cells[0].Text;
        //            objGoalLogInfo.GoalObjectives = g2.Cells[1].Text;
        //            objGoalLogInfo.GoalEvaPoint = Convert.ToInt32(g2.Cells[2].Text);
        //            objGoalLogInfo.GoalCompletetiondate = g2.Cells[3].Text;
        //            objGoalLogInfo.SentBy = Convert.ToInt32(g2.Cells[4].Text);
        //            objGoalLogInfo.EmployeeID_FK = objEmpDetails.EmployeeID;
        //            objGoalLogInfo.SupervisorID_FK = objEmpDetails.SupervisorID;
        //            objGoalLogInfo.HRID_FK = objEmpDetails.HRID;
        //            objGoalLogInfo.AppraisalID_FK = AppraisalID2;
        //            // objGoalLogInfo.GoalID_FK = GoalID;

        //            int GoalLogID = (new EmployeeApprasalTableGoalLogController()).Add(objGoalLogInfo);

        //            //Updating GoldID_FK

        //            EmployeeApprasalTableGoalLogInfo objUpdateGoalID = new EmployeeApprasalTableGoalLogInfo();
        //            // int GoldID = Convert.ToInt32(ViewState["GoalLogID"]);
        //            objUpdateGoalID.GoalID_FK = GoalID;
        //            objUpdateGoalID.GoalLogID = GoalLogID;

        //            (new EmployeeApprasalTableGoalLogController()).GoalIDUpdate(objUpdateGoalID);


        //            if (GoalLogID > 0)
        //            {
        //                LbGoalLog.Text = "Next year Goals  have been successfully saved ";
        //                LbGoalLog.Visible = true;
        //            }
        //            else
        //            {
        //                LbGoalLog.Text = "Next year Goals  Not saved ";
        //                LbGoalLog.Visible = true;
        //            }
        //        }



        //    }

        //    catch { }
        //}

        //#endregion


        #endregion



        protected void goalFinishBtn_Click(object sender, EventArgs e)
        {

        }
        protected void appraisalBackBtn_Click(object sender, EventArgs e)
        {

        }
        protected void viewPreYrGoalBtn_Click(object sender, EventArgs e)
        {

        }





        protected void GViewEmpNextYearGoalList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void txtOverallPoint_TextChanged(object sender, EventArgs e)
        {

        }












      
}
}