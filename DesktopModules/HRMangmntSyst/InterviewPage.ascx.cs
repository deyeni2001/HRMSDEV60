using System;
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
using System.Web.SessionState;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;
using ola.HRMangmntSyst;


// copied namepace
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System.Web.SessionState;



namespace ola.HRMangmntSyst
{
    public partial class InterviewPage : PortalModuleBase, IActionable
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MViewInterview.ActiveViewIndex = 0;

                // day dropdownlist

                #region 
                
                var day = new ArrayList();
                day.Add("Day");
                for (var i = 1; i <= 31; i++)
                {
                    day.Add(i);
                }
               // interviewDayList.DataSource = day;
               // interviewDayList.DataBind();
                ddlInterviewDay.DataSource = day;
                ddlInterviewDay.DataBind();
                ddlDay.DataSource = day;
                ddlDay.DataBind();

                #endregion


                // year dropdownlist

                #region

                var al = new ArrayList();
                al.Add("Year");
                for (var i = 2018; i >= 1900; i--)
                {
                    al.Add(i);
                }

                //interviewYearList.DataSource = al;
                //interviewYearList.DataBind();
                ddlInterviewYear.DataSource = al;
                ddlInterviewYear.DataBind();
                ddlYear.DataSource = al;
                ddlYear.DataBind();

                ddlYear.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                #endregion

        

                #region
                //Loading Applicant Depatartment

                ArrayList objAppDept = new ArrayList();
                objAppDept = (new ApplicantDepartmentTableController()).List();
                if (objAppDept.Count > 0)
                {
                    ddShortListAvailDept.DataSource = objAppDept;
                    ddShortListAvailDept.DataTextField = "DeptName";
                    ddShortListAvailDept.DataValueField = "DeptID";
                    ddShortListAvailDept.DataBind();
                    ddShortListAvailDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));
                    ddShotListAvailPosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    ddInterViewDecisionAvailDept.DataSource = objAppDept;
                    ddInterViewDecisionAvailDept.DataTextField = "DeptName";
                    ddInterViewDecisionAvailDept.DataValueField = "DeptID";
                    ddInterViewDecisionAvailDept.DataBind();

                    ddInterViewDecisionAvailDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));
                    ddInterviewDecisionAvailPosition.Items.Insert(0, new ListItem("---Please select---", "-1"));


                    ddManagDecisionAvailDept.DataSource = objAppDept;
                    ddManagDecisionAvailDept.DataTextField = "DeptName";
                    ddManagDecisionAvailDept.DataValueField = "DeptID";
                    ddManagDecisionAvailDept.DataBind();

                    ddManagDecisionAvailDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));
                    ddManagDecisionAvailPosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    ddSendOfferAvailDept.DataSource = objAppDept;
                    ddSendOfferAvailDept.DataTextField = "DeptName";
                    ddSendOfferAvailDept.DataValueField = "DeptID";
                    ddSendOfferAvailDept.DataBind();
                    ddSendOfferAvailDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));
                    ddSendOfferAvailPosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    ddReportVacantDept.DataSource = objAppDept;
                    ddReportVacantDept.DataTextField = "DeptName";
                    ddReportVacantDept.DataValueField = "DeptID";
                    ddReportVacantDept.DataBind();
                    ddReportVacantDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));
                    ddReportVacantPosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                }

                // loading Employeee DEPARTMENT

                ArrayList objDept= new ArrayList();
                objDept = (new EmployeeDepartmentTableController()).List();
                if (objDept.Count > 0)
                {
                    ddlDept.DataSource = objDept;
                    ddlDept.DataTextField = "DeptName";
                    ddlDept.DataValueField = "DeptID";
                    ddlDept.DataBind();
                    ddlDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                }
                ddlApprovePosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                #endregion


                //loading worklocation on ddlWorkLocation

                #region

                ArrayList objLocation = new ArrayList();
                objLocation = (new EmployeeWorkLocationsController()).List();
                if (objLocation.Count > 0)
                {
                    ddlWorkLocation.DataSource = objLocation;
                    ddlWorkLocation.DataTextField = "LocationName";
                    ddlWorkLocation.DataValueField = "WorkLocationID";
                    ddlWorkLocation.DataBind();
                    ddlWorkLocation.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                }

                #endregion

                // LOAD RATING KEY1 

                #region


                //// LOAD RATING KEY1 
                //ArrayList objRatingKey1 = new ArrayList();


                //objRatingKey1 = (new InterviewRatingKey1Controller()).List();
                //if (objRatingKey1.Count > 0)
                //{

                //    ExperienceKeyList.DataSource = objRatingKey1;
                //    ExperienceKeyList.DataTextField = "ratingDescription";
                //    ExperienceKeyList.DataValueField = "ratingKeyID";
                //    ExperienceKeyList.DataBind();
                //    ExperienceKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    edcationKeyList.DataSource = objRatingKey1;
                //    edcationKeyList.DataTextField = "ratingDescription";
                //    edcationKeyList.DataValueField = "ratingKeyID";
                //    edcationKeyList.DataBind();
                //    edcationKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    communicationKeyList.DataSource = objRatingKey1;
                //    communicationKeyList.DataTextField = "ratingDescription";
                //    communicationKeyList.DataValueField = "ratingKeyID";
                //    communicationKeyList.DataBind();
                //    communicationKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    interestKeyList.DataSource = objRatingKey1;
                //    interestKeyList.DataTextField = "ratingDescription";
                //    interestKeyList.DataValueField = "ratingKeyID";
                //    interestKeyList.DataBind();
                //    interestKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    presentationKeyList.DataSource = objRatingKey1;
                //    presentationKeyList.DataTextField = "ratingDescription";
                //    presentationKeyList.DataValueField = "ratingKeyID";
                //    presentationKeyList.DataBind();
                //    presentationKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    problemKeyList.DataSource = objRatingKey1;
                //    problemKeyList.DataTextField = "ratingDescription";
                //    problemKeyList.DataValueField = "ratingKeyID";
                //    problemKeyList.DataBind();
                //    problemKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));


                //    computerKeyList.DataSource = objRatingKey1;
                //    computerKeyList.DataTextField = "ratingDescription";
                //    computerKeyList.DataValueField = "ratingKeyID";
                //    computerKeyList.DataBind();
                //    computerKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    jobStabilityKeyList.DataSource = objRatingKey1;
                //    jobStabilityKeyList.DataTextField = "ratingDescription";
                //    jobStabilityKeyList.DataValueField = "ratingKeyID";
                //    jobStabilityKeyList.DataBind();
                //    jobStabilityKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    otherKeyList.DataSource = objRatingKey1;
                //    otherKeyList.DataTextField = "ratingDescription";
                //    otherKeyList.DataValueField = "ratingKeyID";
                //    otherKeyList.DataBind();
                //    otherKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));


                //}


                //// LOAD RATING KEY1 
                //ArrayList objRatingKey2 = new ArrayList();


                //objRatingKey2 = (new InterviewRatingKey2Controller()).List();
                //if (objRatingKey2.Count > 0)
                //{

                //    knowledgeRatingKeyList.DataSource = objRatingKey2;
                //    knowledgeRatingKeyList.DataTextField = "ratingKeyDescription";
                //    knowledgeRatingKeyList.DataValueField = "ratingKeyID";
                //    knowledgeRatingKeyList.DataBind();
                //    knowledgeRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    excitmentRatingKeyList.DataSource = objRatingKey2;
                //    excitmentRatingKeyList.DataTextField = "ratingKeyDescription";
                //    excitmentRatingKeyList.DataValueField = "ratingKeyID";
                //    excitmentRatingKeyList.DataBind();
                //    excitmentRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    experienceRatingKeyList.DataSource = objRatingKey2;
                //    experienceRatingKeyList.DataTextField = "ratingKeyDescription";
                //    experienceRatingKeyList.DataValueField = "ratingKeyID";
                //    experienceRatingKeyList.DataBind();
                //    experienceRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    teamRatingKeyList.DataSource = objRatingKey2;
                //    teamRatingKeyList.DataTextField = "ratingKeyDescription";
                //    teamRatingKeyList.DataValueField = "ratingKeyID";
                //    teamRatingKeyList.DataBind();
                //    teamRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    communicationRatingKeyList.DataSource = objRatingKey2;
                //    communicationRatingKeyList.DataTextField = "ratingKeyDescription";
                //    communicationRatingKeyList.DataValueField = "ratingKeyID";
                //    communicationRatingKeyList.DataBind();
                //    communicationRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                //    RecommendtionRatingKeyList.DataSource = objRatingKey2;
                //    RecommendtionRatingKeyList.DataTextField = "ratingKeyDescription";
                //    RecommendtionRatingKeyList.DataValueField = "ratingKeyID";
                //    RecommendtionRatingKeyList.DataBind();
                //    RecommendtionRatingKeyList.Items.Insert(0, new ListItem("---Please Select---", "-1"));



                //}

                #endregion
            }

   
}
        protected void sendInterviewInviteBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 1;
        }
        protected void backToWelcomBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }
        protected void interviewApplicantBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 2;
        }
        protected void interviewNextBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 3;
        }
        protected void evaluationBackBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 1;
        }
        protected void evaluationWelcomPageBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }

        protected void interviewBackBtn_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 2;
        }

        protected void responseWelcomPage_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }

        protected void btnSendIniteMenu_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 1;
            PanelShortListForInterview.Visible = true;
            btnShortListFinish.Visible = false;
            btnShortListTryAgain.Visible = false;

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 2;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 4;
        }

        protected void btnSendOfferMenu_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 5;
            btnMangDecClose.Visible = false;
            btnMangDecitionFinish.Visible = false;
            btnMangDecTryAgain.Visible = false;
        }
        protected void btnInterwierDecision_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 2;
        }
        protected void btnReportMenu_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 3;
        }

        protected void LinkApproveApplicant_Click(object sender, EventArgs e)
        {
            string position = ddReportVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionApprove(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No applicant has been approved for the position of " + ddReportVacantPosition.SelectedItem.Text.Trim();
                lblReport.Visible = true;
            }
        }

        protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deptID = Convert.ToInt32(ddlDept.SelectedItem.Value);
            ArrayList objPosition = new ArrayList();
            objPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(deptID);

            if (objPosition.Count > 0)
            {
                ddlApprovePosition.DataSource = objPosition;
                ddlApprovePosition.DataTextField = "PositionName";
                ddlApprovePosition.DataValueField = "PositionID";
                ddlApprovePosition.DataBind();
                ddlApprovePosition.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }

            //int deptID = Convert.ToInt32(ddlDept.SelectedItem.Value);
            ArrayList objLevel = new ArrayList();
            // int pos = Convert.ToInt32(ddlApprovePosition.SelectedValue);
            objLevel = (new EmployeeLevelController()).GetByEmployeeDepartmentTable(deptID);

            if (objLevel.Count > 0)
            {
                ddlLevel.DataSource = objLevel;
                ddlLevel.DataTextField = "LevelName";
                ddlLevel.DataValueField = "LevelID";
                ddlLevel.DataBind();
                ddlLevel.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }

        }


        protected void ddlLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int levelID = Convert.ToInt32(ddlLevel.SelectedItem.Value);
            EmployeeLevelInfo objLevel = new EmployeeLevelInfo();

            objLevel = new EmployeeLevelController().Get(levelID);
            lblSalary.Text = objLevel.Salary;
        }

        protected void btnMangDecClose_Click1(object sender, System.EventArgs e)
        {
            PanelApplicantDetails.Visible = false;
        }
        protected void btnInterviewerDecisionFinish_Click(object sender, System.EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }
        protected void btnInterDecClose_Click(object sender, EventArgs e)
        {
            PanelShortListViewAppDetails.Visible = false;

        }

        protected void btnMangDecClose_Click(object sender, EventArgs e)
        {
            btnMangDecClose.Visible = false;
            btnMangDecClose.Visible = false;

        }
        protected void btnShotListClose_Click(object sender, System.EventArgs e)
        {
                    PanelApplicantDetails.Visible = false;
        }


        //Listing available position indexChange

        #region

        protected void ddlAvailableDept_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ArrayList objShortListAvailPost = new ArrayList();
            int dept1 = Convert.ToInt32(ddShortListAvailDept.SelectedValue);
            objShortListAvailPost = (new ApplicantAvailablePositiontableController()).GetByApplicantDepartmentTable(dept1);
            if (objShortListAvailPost.Count > 0)
            {
                ddShotListAvailPosition.DataSource = objShortListAvailPost;
                ddShotListAvailPosition.DataTextField = "positionAppliedForName";
                ddShotListAvailPosition.DataValueField = "positionAppliedforID";
                ddShotListAvailPosition.DataBind();
                // ddShortListAvailDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }
        }
        protected void ddShotListAvailPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelShortListForInterview.Visible = true;
            lblInviteSend1.Visible = false;
            lblInviteSend.Visible = false;
            btnShortListTryAgain.Visible = false;
            btnShortListFinish.Visible = false;

            ArrayList objArr = new ArrayList();
            string positionAppliedFor = ddShotListAvailPosition.SelectedItem.Text;
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionNotShortlisted(positionAppliedFor);
            if (objArr.Count > 0)
            {
                GViewAllApplicantsList.DataSource = objArr;
                GViewAllApplicantsList.DataBind();
                GViewAllApplicantsList.Visible = true;
                //sendInterviewInvite1.Visible = true;
                PanelInterviewParameter.Visible = true;
                lblShortlist.Visible = false;
            }
            else
            {
                GViewAllApplicantsList.Visible = false;
                PanelInterviewParameter.Visible = false;
                lblShortlist.Text = "It might be that no one applied for the position of " + ddShotListAvailPosition.SelectedItem.Text + "  or All applicants has been shortlisted";
                lblShortlist.Visible = true;
            }

        }

        #endregion

        //Sending interview invites

        #region
        protected void sendInterviewInvite1_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Visible = true;
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewAllApplicantsList.Rows)
                {
                    lblName.Text = g1.Cells[2].Text + " " + g1.Cells[4].Text; ;
                    lblPositionApplied.Text = g1.Cells[1].Text;
                    lblApplicantEmail.Text = g1.Cells[8].Text;

                }
            }
            catch { }
        }

        #endregion

        //Viewing Applicant details

        #region
        protected void GViewAllApplicantsList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                objPersonalInfo = (new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(e.CommandArgument));

                lblDeptAppliedTo.Text = objPersonalInfo.DeptAppliedTo;
                lblPositionAppliedFor.Text = objPersonalInfo.PositionAppliedFor;
                lblApplicantNum.Text = objPersonalInfo.ApplicantNum;
                lblFirstName.Text = objPersonalInfo.FirstName;
                lblLastName.Text = objPersonalInfo.LastName;
                lblMiddleName.Text = objPersonalInfo.MiiddleName;
                lblGender.Text = objPersonalInfo.Gender;
                lblMaritalStatus.Text = objPersonalInfo.MaritalStatus;
                lblNationality.Text = objPersonalInfo.countryName;
                lblStateofOrigin.Text = objPersonalInfo.stateName;
                lblSenDistrict.Text = objPersonalInfo.senName;
                lblLGA.Text = objPersonalInfo.LgaName;
                lblHomeTown.Text = objPersonalInfo.HomeTown;
                lblEmail.Text = objPersonalInfo.Email;
                lblContactAddress.Text = objPersonalInfo.ContactAddress;
                lblDOB.Text = objPersonalInfo.DateOfBirth;
                lblAge.Text = objPersonalInfo.Age;
                ImagePassport.ImageUrl = "~/Image/" + objPersonalInfo.Passport.Substring(objPersonalInfo.Passport.LastIndexOf('\\') + 1);
                int applicantID = Convert.ToInt32(e.CommandArgument);

                // Qualification summary
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count > 0)
                {

                    GViewQualification.DataSource = ObjArrQualification;
                    GViewQualification.DataBind();
                    GViewQualification.Visible = true;
                }

                //  professional Qualification summary
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count > 0)
                {
                    GViewProfQualification.DataSource = ObjArrProfQualification;
                    GViewProfQualification.DataBind();
                    GViewProfQualification.Visible = true;
                }
                //  Wwork Experience summary
                ArrayList ObjArrWorkExp = new ArrayList();
                ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWorkExp.Count > 0)
                {
                    GViewWrkExp.DataSource = ObjArrWorkExp;
                    GViewWrkExp.DataBind();
                    GViewWrkExp.Visible = true;
                }

                //  Document summary
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count > 0)
                {
                    GViewDocument.DataSource = ObjArrDoc;
                    GViewDocument.DataBind();
                    GViewDocument.Visible = true;
                }

                PanelApplicantDetails.Visible = true;
                btnShotListClose.Visible = true;



                // MViewInterview.ActiveViewIndex = 4;



            }
        }

        #endregion


        //Hire Applicant

        #region
        protected void btnHireApplicantSave_Click(object sender, EventArgs e)
        {
            btnInterviewerDecisionFinish.Visible = false;
            int count = 0;
            foreach (GridViewRow x in GVShortlistedApplicants.Rows)
            {
                TextBox b = new TextBox();
                b = (TextBox)x.FindControl("TextBoxApplicantID");
                int id = Convert.ToInt32(b.Text);
                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox2");

                if (c.Checked == true)
                {
                    try
                    {
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo.ApplicantID = Convert.ToInt32(id);
                        objPersonalInfo.WorkLocationID_FK = Convert.ToInt32(ddlWorkLocation.SelectedValue);
                        objPersonalInfo.DepartmentID_FK = Convert.ToInt32(ddlDept.SelectedValue);
                        objPersonalInfo.PositionApproved_FK = Convert.ToInt32(ddlApprovePosition.SelectedValue);
                        objPersonalInfo.LevelID_FK = Convert.ToInt32(ddlLevel.SelectedValue);
                        objPersonalInfo.ResumptionDate = ddlDay.SelectedValue + "-" + ddlMonth.SelectedValue + "-" + ddlYear.SelectedValue;
                        objPersonalInfo.InterviwerDecision = "Hire";

                        new ApplicantPersonalDetailsController().UpdateInterviewerDecision(objPersonalInfo);
                        count += 1;

                        ApplicantPersonalDetailsInfo objPersonalInfo3 = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo3 = (new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(id));
                        if (objPersonalInfo3.InterviwerDecision == "Hire")
                        {

                            lblhire.Text = "You have successfully hired " + count + " applicants for the position of " + ddlApprovePosition.SelectedItem.Text;
                            lblhire.Visible = true;
                            lblhire1.Text = "You have successfully hired " + count + " applicants for the position of " + ddlApprovePosition.SelectedItem.Text;
                            lblhire1.Visible = true;
                            PanelInterviewParameter.Visible = false;
                            PanelHire.Visible = false;
                            btnInterviewerDecisionFinish.Visible = true;
                            btnInterviewerDecisionTryAgain.Visible = false;
                            

                        }
                        else 
                        {

                            lblhire.Text = "You have NOT hired ";
                            lblhire.Visible = true;
                            lblhire1.Text = "You have NOT hired "; 
                            lblhire1.Visible = true;
                            PanelInterviewParameter.Visible = false;
                            PanelHire.Visible = false;
                            btnInterviewerDecisionFinish.Visible = false;
                            btnInterviewerDecisionTryAgain.Visible = true;


                        }
                    }
                    catch { }


                }


                // reload the gridview
                string position = ddInterViewDecisionAvailDept.SelectedItem.Text;
                ArrayList objArr = new ArrayList();
                objArr = new ApplicantPersonalDetailsController().ListByPositionShortlisted(position);
                if (objArr.Count > 0)
                {
                    GVShortlistedApplicants.DataSource = objArr;
                    GVShortlistedApplicants.DataBind();
                    GVShortlistedApplicants.Visible = true;
                    Label57.Visible = true;
                    lblNoShortlistedApplicant.Visible = false;

                }
            }
        }

        #endregion

        //Shortlisting and sent interview invite

        #region
        protected void btnShotlistAndSendingInvite_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow x in GViewAllApplicantsList.Rows)
            {
                // declare a variable as textbox
                TextBox b = new TextBox();
                // find the textbox containing the applicantID on the gridview 
                b = (TextBox)x.FindControl("TextBox2");
                string id = b.Text;
                string applicantName = x.Cells[2].Text + " " + x.Cells[4].Text; ;
                string PositionAppliedFor = x.Cells[1].Text;
                string applicantEmail = x.Cells[8].Text;
                // ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox1");
                if (c.Checked == true)
                {
                    // lblInterMsg.Text = id;
                    try
                    {
                        // Update application Status of that applicant as shortlisted
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo.ApplicantID = Convert.ToInt32(id);
                        objPersonalInfo.ApplicationStatus = "Shortlisted";
                        new ApplicantPersonalDetailsController().UpdateApplicationStatus(objPersonalInfo);

                        ApplicantPersonalDetailsInfo objPersonalInfo2 = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo2 = (new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(id));

                        if (objPersonalInfo2.ApplicationStatus == "Shortlisted")
                        {

                            lblInviteSend.Text = "Interview Letter SUCCESSFULLY sent";
                            PanelShortListForInterview.Visible = false;
                            lblInviteSend1.Text = "Interview Letter SUCCESSFULLY sent";
                            lblInviteSend1.Visible = true;
                            btnShortListFinish.Visible = true;
                            btnShortListTryAgain.Visible = false;
                            PanelInterviewParameter.Visible = false;
                        }

                        else
                        {
                            lblInviteSend.Text = "Interview Letter NOT sent";
                            PanelShortListForInterview.Visible = false;
                            lblInviteSend1.Text = "Interview Letter NOT sent";
                            lblInviteSend1.Visible = true;
                            btnShortListFinish.Visible = false;
                            btnShortListTryAgain.Visible=true;
                            PanelInterviewParameter.Visible = false;
                        }

                        //send an email from a Gmail address using SMTP server.  
                        //The Gmail SMTP server name is smtp.gmail.com and
                        //the port using send mail is 587 and also using  

                        //NetworkCredential for password based authentication;
                        //string _subjectEmail = "";
                        //MailMessage mail = new MailMessage();
                        //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        // mail.IsBodyHtml = true;
                        //mail.From = new MailAddress("your_email_address@gmail.com");
                        // mail.From = new MailAddress("olami@neetbeettech@gmail.com");


                        //Loading all Mail contents
                        //Composing mail content

                        //string salutaion = ("dear" + applicantName + ",");
                        //string subjectEmail = "Invitation to Interview";
                        //string bodyEmail = ("dear" + applicantName + ","+ "In response to your application for the post of "
                        //    + PositionAppliedFor  +" Neetbeet Technogies Limited, we are please to invite you for interview as scheduled below:");
                        //string InterviewDetails = ("Date: " + ddlInterviewDay.SelectedValue + ddlInterviewMonth.SelectedValue +ddlInterviewYear.SelectedValue
                        //                            + " Time: " + txtInterviewTime.Text + " Venue: " + txtInterviewVenue.Text);

                        //bodyEmail += InterviewDetails;
                        //mail.To.Add(applicantEmail);
                        //mail.Subject = subjectEmail;
                        //mail.Body = bodyEmail;

                        //Adding an attachments
                        //mail.Attachments.Add(new Attachment(MailAttachementPath));
                        //SmtpServer.Port = 587;
                        //// SmtpServer.Port = 25;
                        //SmtpServer.Credentials = new System.Net.NetworkCredential("olami@neetbeettech@gmail.com", "Adeniyi@2018");

                        ////SmtpServer.UseDefaultCredentials = false;
                        //SmtpServer.EnableSsl = true;

                        //SmtpServer.Send(mail);
                        //lblInviteSend.Text = "Interview Letter SUCCESSFULLY sent";
                        //mail.Dispose();
                    }
                    catch (Exception ex)
                    {
                        // lblInviteSend.Text = "Interview Letter NOT sent" ;
                        PanelShortListForInterview.Visible = false;
                        lblInviteSend1.Text = "Interview Letter NOT sent";
                        lblInviteSend1.Visible = true;
                        btnShortListFinish.Visible = false;
                        btnShortListTryAgain.Visible = true;

                    }

                    // reload 
                    ArrayList objArr = new ArrayList();
                    string positionAppliedFor = ddShortListAvailDept.SelectedItem.Text;
                    objArr = (new ApplicantPersonalDetailsController()).ListByPositionNotShortlisted(positionAppliedFor);
                    if (objArr.Count > 0)
                    {
                        GViewAllApplicantsList.DataSource = objArr;
                        GViewAllApplicantsList.DataBind();
                        GViewAllApplicantsList.Visible = true;
                       // sendInterviewInvite1.Visible = true;
                        PanelInterviewParameter.Visible = true;
                        lblShortlist.Visible = false;
                    }



                }

            }
        }

        #endregion


        //Loading shortlisted applicants for Interviewer decision 
        //and setting employment parameters

        #region

        protected void ddInterViewDecisionAvailDept_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ArrayList objInterDecisionAvailPost = new ArrayList();
            int dept2 = Convert.ToInt32(ddInterViewDecisionAvailDept.SelectedValue);
            objInterDecisionAvailPost = (new ApplicantAvailablePositiontableController()).GetByApplicantDepartmentTable(dept2);
            if (objInterDecisionAvailPost.Count > 0)
            {
                ddInterviewDecisionAvailPosition.DataSource = objInterDecisionAvailPost;
                ddInterviewDecisionAvailPosition.DataTextField = "positionAppliedForName";
                ddInterviewDecisionAvailPosition.DataValueField = "positionAppliedforID";
                ddInterviewDecisionAvailPosition.DataBind();
                // ddShortListAvailDept.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }
        }

        protected void ddInterviewDecisionAvailPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelEmploymentParameter.Visible = true;
            PanelHire.Visible = true;
            btnInterviewerDecisionFinish.Visible = false;

            lblhire.Visible = false;
            ArrayList objArr = new ArrayList();
            string position = ddInterviewDecisionAvailPosition.SelectedItem.Text.Trim();
            objArr = new ApplicantPersonalDetailsController().ListByPositionShortlisted(position);
            if (objArr.Count > 0)
            {
                GVShortlistedApplicants.DataSource = objArr;
                GVShortlistedApplicants.DataBind();
                GVShortlistedApplicants.Visible = true;
                Label57.Visible = true;
                lblNoShortlistedApplicant.Visible = false;
                PanelEmploymentParameter.Visible = true;

            }
            else
            {
                GVShortlistedApplicants.Visible = false;
                Label57.Visible = false;
                lblNoShortlistedApplicant.Text = "No applicant has been shorlisted for the position of  " + ddInterviewDecisionAvailPosition.SelectedItem.Text.Trim() + "Or all shortlisted applicants have been hired";
                lblNoShortlistedApplicant.Visible = true;
                PanelEmploymentParameter.Visible = false;
            }
        }

        #endregion

        //Tryagain buttons

        #region

        //btnInterviewerDecisionTryAgain
        protected void btnInterviewerDecisionTryAgain_Click(object sender, System.EventArgs e)
        {
            PanelEmploymentParameter.Visible = true;
            PanelHire.Visible = true;
            btnInterviewerDecisionFinish.Visible = false;
            btnInterviewerDecisionTryAgain.Visible = false;
            lblhire1.Visible=false;
            
        }

        //btnMangDecTryAgain
        protected void btnMangDecTryAgain_Click(object sender, System.EventArgs e)
        {

            PanelManagementDecision.Visible = true;
            lblhire.Visible = false;
            PanelManagementDecision.Visible = false;
            btnSendOfferTryAgain.Visible = false;
            btnSendOfferFinish.Visible = false;
        }

        //btnShortListTryAgain
        protected void btnShortListTryAgain_Click(object sender, System.EventArgs e)
        {
            PanelShortListForInterview.Visible = true;
            btnShortListFinish.Visible = false;
            btnShortListTryAgain.Visible = false;

            lblInviteSend1.Text = "Interview Letter SUCCESSFULLY sent";
            lblInviteSend1.Visible = false;
            btnShortListFinish.Visible = true;
            btnShortListTryAgain.Visible = false;
            PanelInterviewParameter.Visible = false;
        }


        #endregion


        //Finish buttons

        #region

        //btnShortListFinish
        protected void btnShortListFinish_Click(object sender, System.EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;
        }

        //btnSendOfferFinish
        protected void btnSendOffer_Click(object sender, System.EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 0;

        }

        #endregion


        //View shortlisted applicant's profile

        #region
        protected void GVShortlistedApplicants_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                objPersonalInfo=(new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(e.CommandArgument));
                LbShortListAvailDept.Text = objPersonalInfo.DeptAppliedTo;
                LbShotListAvailPosition.Text = objPersonalInfo.PositionAppliedFor;
                LabelApplicantNo.Text = objPersonalInfo.ApplicantNum;
                LabelFName.Text = objPersonalInfo.FirstName;
                LabelMidName.Text = objPersonalInfo.MiiddleName;
                LabelLName.Text = objPersonalInfo.LastName;

                LabelGender.Text = objPersonalInfo.Gender;
                LabelMaritalStatus.Text = objPersonalInfo.MaritalStatus;
                LabelNationality.Text = objPersonalInfo.countryName;
                lbSenDist.Text = objPersonalInfo.senName;
                LbState.Text = objPersonalInfo.stateName;
                LabelLga.Text = objPersonalInfo.LgaName;
                LabelHomeTown.Text = objPersonalInfo.HomeTown;
                LabelEmail.Text = objPersonalInfo.Email;
                LabelAddress.Text = objPersonalInfo.ContactAddress;
                LabelDob.Text = objPersonalInfo.DateOfBirth;
                LabelAge.Text = objPersonalInfo.Age;
                Image1.ImageUrl = "~/Image/" + objPersonalInfo.Passport.Substring(objPersonalInfo.Passport.LastIndexOf('\\') + 1);

               
                int applicantID = Convert.ToInt32(e.CommandArgument);

                
                //label
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count > 0)
                {

                    GridViewQualification.DataSource = ObjArrQualification;
                    GridViewQualification.DataBind();
                    GridViewQualification.Visible = true;
                }

                ////  professional Qualification summary
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count > 0)
                {
                    GridViewProfQualification.DataSource = ObjArrProfQualification;
                    GridViewProfQualification.DataBind();
                    GridViewProfQualification.Visible = true;
                }
                ////  Wwork Experience summary
                ArrayList ObjArrWorkExp = new ArrayList();
                ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWorkExp.Count > 0)
                {
                    GridViewWorkExperience.DataSource = ObjArrWorkExp;
                    GridViewWorkExperience.DataBind();
                    GridViewWorkExperience.Visible = true;
                }

                ////  Document summary
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count > 0)
                {
                    GridViewDocument.DataSource = ObjArrDoc;
                    GridViewDocument.DataBind();
                    GridViewDocument.Visible = true;
                }

                PanelShortListViewAppDetails.Visible = true;
                //Button5.Visible = true;
            }
        }

        #endregion


        protected void Button12_Click(object sender, EventArgs e)
        {
            string position = ddReportVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionAppliedForAll(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;
                              
            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No one apply for this position";
                lblReport.Visible = true;
            }
        }
      

        //Report

        #region

        //Loading vacant position for reporting

        #region
        protected void ddReportVacantDept_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ArrayList objGetReportPost = new ArrayList();
            int dept5 = Convert.ToInt32(ddReportVacantDept.SelectedValue);
            objGetReportPost = (new ApplicantAvailablePositiontableController()).GetByApplicantDepartmentTable(dept5);
            if (objGetReportPost.Count > 0)
            {
                ddReportVacantPosition.DataSource = objGetReportPost;
                ddReportVacantPosition.DataTextField = "positionAppliedForName";
                ddReportVacantPosition.DataValueField = "positionAppliedforID";
                ddReportVacantPosition.DataBind();
            }
        }
        protected void ddReportVacantPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelect.Text = "Select the report you want to view";
            //Button12.Visible = true;
           // Button13.Visible = true;
           // Button14.Visible = true;
            linkAllapplicants.Visible = true;
            linkShortlistedApplicants.Visible = true;
            linkHireApplicants.Visible = true;
            LinkApproveApplicant.Visible = true;
            GVReport.Visible = false;
        }

        #endregion

        //List all applicants that applied for a position

        #region
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string position = ddReportVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionAppliedForAll(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No one apply for this position";
                lblReport.Visible = true;
            }

        }
        #endregion

        //Shortlisted applicants

        #region
        protected void linkShortlistedApplicants_Click(object sender, EventArgs e)
        {
            string position = ddReportVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            // get shortlisted applicants either hire or not
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionHireOrNot(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No applicant has been shortlisted for the position of " + ddReportVacantPosition.SelectedItem.Text.Trim();
                lblReport.Visible = true;
            }
        }


        #endregion

        //Hire applicants

        #region
        protected void linkHireApplicants_Click(object sender, EventArgs e)
        {
            string position = ddReportVacantPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            objArr = (new ApplicantPersonalDetailsController()).ListByPositionHire(position);
            if (objArr.Count > 0)
            {
                GVReport.DataSource = objArr;
                GVReport.DataBind();
                GVReport.Visible = true;
                lblReport.Visible = false;

            }
            else
            {
                GVReport.Visible = false;
                lblReport.Text = "No applicant has been hire for the position of " + ddReportVacantPosition.SelectedItem.Text.Trim();
                lblReport.Visible = true;
            }
        }

        #endregion


        #endregion

        //Loading position for management decision

        #region

        protected void ddManagDecisionAvailDept_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ArrayList objGetMangDecisionPost = new ArrayList();
            int dept3 = Convert.ToInt32(ddManagDecisionAvailDept.SelectedValue);
            objGetMangDecisionPost = (new ApplicantAvailablePositiontableController()).GetByApplicantDepartmentTable(dept3);
            if (objGetMangDecisionPost.Count > 0)
               
            {
                ddManagDecisionAvailPosition.DataSource = objGetMangDecisionPost;
                ddManagDecisionAvailPosition.DataTextField = "positionAppliedForName";
                ddManagDecisionAvailPosition.DataValueField = "positionAppliedforID";
                ddManagDecisionAvailPosition.DataBind();
                //ddManagDecisionAvailPosition.Items.Insert(0, ListItem("--"))
            }
        }
        protected void ddManagDecisionAvailPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMangDecitionFinish.Visible = false;
            btnMangDecTryAgain.Visible = false;
            lblhire1.Visible= false;
            PanelManagementDecision.Visible = true;
            string position = ddManagDecisionAvailPosition.SelectedItem.Text.Trim();
            ArrayList objArr = new ArrayList();
            // get hire applicants
            objArr = new ApplicantPersonalDetailsController().ListByPositionHire(position);
            if (objArr.Count > 0)
            {
                GVHireApplicants.DataSource = objArr;
                GVHireApplicants.DataBind();
                GVHireApplicants.Visible = true;
                lblHireReport.Visible = false;
                btnSaveManagementApproval.Visible = true;
            }
            else
            {
                ArrayList objArr2 = new ArrayList();
                // get shortlisted but not hire
                objArr2 = new ApplicantPersonalDetailsController().ListByPositionShortlisted(position);
                if (objArr2.Count > 0)
                {
                    lblHireReport.Text = "No one has be hired for the position of " + ddManagDecisionAvailPosition.SelectedItem.Text;
                    lblHireReport.Visible = true;
                     GVHireApplicants.Visible = false;
                     btnSaveManagementApproval.Visible = false;
            
                }
                else
                {
                    // get applied but not shortlisted
                    objArr2 = new ApplicantPersonalDetailsController().ListByPositionNotShortlisted(position);
                    if (objArr2.Count > 0)
                    {
                        lblHireReport.Text = "No one has be Shortlisted for the position of " + ddManagDecisionAvailPosition.SelectedItem.Text;
                        lblHireReport.Visible = true;
                        GVHireApplicants.Visible = false;
                        btnSaveManagementApproval.Visible = false;
                    }
                    else
                    {
                        // get applied applicants
                        objArr2 = new ApplicantPersonalDetailsController().ListByPositionAppliedForAll(position);
                        if (objArr2.Count== 0)
                        {
                            lblHireReport.Text = "Nobody apply for the position of " + ddManagDecisionAvailDept.SelectedItem.Text;
                            lblHireReport.Visible = true;
                            GVHireApplicants.Visible = false;
                            btnSaveManagementApproval.Visible = false;
                        }
                    }
                }
                //GVHireApplicants.Visible = false;
                //lblHireReport.Text = "No one has be hired for the position of " + ddlPositionMgt.SelectedItem.Text;
                //lblHireReport.Visible = true;
            }
        }

        #endregion


        //Saving Management Approval

        #region

        protected void btnManagementDecision_Click(object sender, EventArgs e)
        {
            MViewInterview.ActiveViewIndex = 4;

            PanelManagementDecision.Visible = true;
            lblhire.Visible = false;
            PanelManagementDecision.Visible = false;
            btnSendOfferTryAgain.Visible = false;
            btnSendOfferFinish.Visible = false;
        }
      
        protected void btnSaveManagementApproval_Click(object sender, System.EventArgs e)
        {

          int count = 0;
            foreach (GridViewRow x in GVHireApplicants.Rows)
            {
                TextBox b = new TextBox();
                b = (TextBox)x.FindControl("TextBoxID");
                int id = Convert.ToInt32(b.Text);
                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox1");
                
                if (c.Checked == true)
                {
                    try
                    {
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo.ApplicantID = Convert.ToInt32(id);
                        objPersonalInfo.ManagementDecition = "Approve";
                        new ApplicantPersonalDetailsController().UpdateManagementDecision(objPersonalInfo);
                        count += 1;

                        ApplicantPersonalDetailsInfo objPersonalInfo1 = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo1 = (new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(id));

                        if (objPersonalInfo1.ManagementDecition == "Approve")
                        {

                            lblHireReport.Text = "Approve successfull";
                            lblHireReport.Visible = true;
                            PanelManagementDecision.Visible = false;
                            btnSendOfferTryAgain.Visible = false;
                            btnSendOfferFinish.Visible = true;
                        }
                        else
                        {
                            lblHireReport.Text = "Approve NOT successfull";
                            lblHireReport.Visible = true;
                            PanelManagementDecision.Visible = false;
                            btnSendOfferTryAgain.Visible = true;
                            btnSendOfferFinish.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        lblhire.Text = (ex.Message);
                        lblhire.Visible = true;
                    }
                    

                }
            // /reload the gridview
                string position = ddManagDecisionAvailDept.SelectedItem.Text;
                ArrayList objArr = new ArrayList();
                objArr = new ApplicantPersonalDetailsController().ListByPositionHire(position);
                if (objArr.Count > 0)
                {
                    GVHireApplicants.DataSource = objArr;
                    GVHireApplicants.DataBind();
                    GVHireApplicants.Visible = true;
                    Label57.Visible = true;
                    //lblNoShortlistedApplicant.Visible = false;
                }
                }
        }

        #endregion

   
        //Management View shortlisted applicants for approval

        #region
        protected void GVHireApplicants_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                objPersonalInfo = (new ApplicantPersonalDetailsController()).Get(Convert.ToInt32(e.CommandArgument));
                lbApproveDept.Text = objPersonalInfo.DeptAppliedTo;
                lblApprovePosition.Text= objPersonalInfo.PositionAppliedFor;
                lblApproveName.Text = objPersonalInfo.FirstName;
                lblapproveMName.Text = objPersonalInfo.MiiddleName;
                lblapproveLName.Text = objPersonalInfo.LastName;
                lblApproveGender.Text = objPersonalInfo.Gender;
                lblapproveMaritalStatus.Text = objPersonalInfo.MaritalStatus;
                lblApproveNationality.Text = objPersonalInfo.countryName;
                lblApproveState.Text = objPersonalInfo.stateName;
                lblApproveSenatorial.Text = objPersonalInfo.senName;
                lblLGA.Text = objPersonalInfo.LastName;
                lblApproveLga.Text = objPersonalInfo.LGA;
                lblapproveHTown.Text = objPersonalInfo.HomeTown;
                lblApproveEmail.Text = objPersonalInfo.Email;
                lblapproveAddr.Text = objPersonalInfo.ContactAddress;
                lblApproveAge.Text = objPersonalInfo.Age;
                Image2.ImageUrl = "~/Image/" + objPersonalInfo.Passport.Substring(objPersonalInfo.Passport.LastIndexOf('\\') + 1);


                int applicantID = Convert.ToInt32(e.CommandArgument);


                //label
                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count > 0)
                {

                    GVQualif.DataSource = ObjArrQualification;
                    GVQualif.DataBind();
                    GVQualif.Visible = true;
                }

                ////  professional Qualification summary
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count > 0)
                {
                    GVProfQualif.DataSource = ObjArrProfQualification;
                    GVProfQualif.DataBind();
                    GVProfQualif.Visible = true;
                }
                ////  Wwork Experience summary
                ArrayList ObjArrWorkExp = new ArrayList();
                ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWorkExp.Count > 0)
                {
                    GVWrkExp.DataSource = ObjArrWorkExp;
                    GVWrkExp.DataBind();
                    GVWrkExp.Visible = true;
                }

                ////  Document summary
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count > 0)
                {
                    GVDoc.DataSource = ObjArrDoc;
                    GVDoc.DataBind();
                    GVDoc.Visible = true;
                }

                c.Visible = true;

            }
        }

        #endregion

        //List position for sending offer

        #region

        protected void ddSendOfferAvailDept_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ArrayList objGetSendOfferPost = new ArrayList();
            int dept4 = Convert.ToInt32(ddSendOfferAvailDept.SelectedValue);
            objGetSendOfferPost = (new ApplicantAvailablePositiontableController()).GetByApplicantDepartmentTable(dept4);
            if (objGetSendOfferPost.Count > 0)
            {
                ddSendOfferAvailPosition.DataSource = objGetSendOfferPost;
                ddSendOfferAvailPosition.DataTextField = "positionAppliedForName";
                ddSendOfferAvailPosition.DataValueField = "positionAppliedforID";
                ddSendOfferAvailPosition.DataBind();
            }
        }

        protected void ddlAvailablePosition_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            PanelOfferEmployment.Visible = true;
            string position = ddSendOfferAvailPosition.SelectedItem.Text;
            ArrayList objArr = new ArrayList();
            objArr = new ApplicantPersonalDetailsController().ListByPositionApprove(position);
            if (objArr.Count > 0)
            {
                GVSendOffer.DataSource = objArr;
                GVSendOffer.DataBind();
                GVSendOffer.Visible = true;
                lblReport2.Visible = false;
                // Button16.Visible = true;
            }
            else
            {
                GVSendOffer.Visible = false;
                lblReport2.Text = "No applicant has been approved for the position of " + ddSendOfferAvailPosition.SelectedItem.Text;
                lblReport2.Visible = true;
            }
        }

        #endregion


        //Sending Offer letter

        #region

        protected void btnSendOfferletter_Click(object sender, EventArgs e)
        {

            foreach (GridViewRow x in GVSendOffer.Rows)
            {
                // declare a variable as textbox
                TextBox b = new TextBox();
                // find the textbox containing the applicantID on the gridview 
                b = (TextBox)x.FindControl("txtApplicantID");
                string applicantID = b.Text;

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBox1");

                if (c.Checked == true)
                {

                    try
                    {
                        ApplicantPersonalDetailsInfo objPersonalInfo = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo = new ApplicantPersonalDetailsController().GetOfferDetails(Convert.ToInt32(applicantID));
                        lblName2.Text = objPersonalInfo.LastName + " " + objPersonalInfo.FirstName;
                        lblPosition.Text = objPersonalInfo.ApprovedPositionName;
                        lblOfferDept.Text = objPersonalInfo.DeptName;

                        lblOfferPosition.Text = objPersonalInfo.ApprovedPositionName;
                        lblOfferDept2.Text = objPersonalInfo.DeptName;
                        lblOfferLevel.Text = objPersonalInfo.LevelName;
                        lblOfferSalary.Text = objPersonalInfo.Salary;
                        lblOfferWrkLocatn.Text = objPersonalInfo.LocationName;
                        lblOfferRsmptDate.Text = objPersonalInfo.ResumptionDate;


                        //Composing mail content

                        //string salutaion = ("dear" + objPersonalInfo.LastName + ",");
                        string subjectEmail = "Employment Offer";
                        string bodyEmail = ("Dear " + objPersonalInfo.LastName + ", " + objPersonalInfo.FirstName + " Further to your application and subsquent interviewat Neetbeet Technogies Limited, we are please to offer you"
                           + objPersonalInfo.ApprovedPositionName + " under the department of " + objPersonalInfo.DeptName);
                        string offerDetails = ("The following are your appointment detail: " +
                            "Position: " + objPersonalInfo.ApprovedPositionName +
                            "Department: " + objPersonalInfo.DeptName +
                            "Level: " + objPersonalInfo.LevelName +
                            "Salary: " + objPersonalInfo.Salary +
                            "Work Loction: " + objPersonalInfo.LocationName +
                            "Resumption Date:" + objPersonalInfo.ResumptionDate +
                            "The first six months of your employment with us will be regarded as a propationary period, during which , either you o the company could terminate the appointment by giving one (1) month's notice in writing or paying one (1) month's basic salary in lieuof notice. ");

                        bodyEmail += offerDetails;
                        string receiverEmail = objPersonalInfo.Email;

                        Utility.SendMail(subjectEmail, bodyEmail, receiverEmail);

                        string url = "http://" + Request.Url.Authority + "/Print5.aspx?id=" + applicantID.ToString();
                        Response.Write("<script language=javascript> window.open( '" + url + "','_blank');</script>");

                        ApplicantPersonalDetailsInfo objPersonalInfo1 = new ApplicantPersonalDetailsInfo();
                        objPersonalInfo1 = (new ApplicantPersonalDetailsController()).GetOfferDetails(Convert.ToInt32(applicantID));

                        if ((objPersonalInfo1.DepartmentID_FK != null) && (objPersonalInfo1.PositionApproved_FK != null) &&
                            (objPersonalInfo1.LevelID_FK != null) && (objPersonalInfo1.WorkLocationID_FK != null))
                        {


                            PanelOfferEmployment.Visible = false;
                            LbOfferLetterSentSuccessfully.Text = "Employment Letter sent successfully";
                            LbOfferLetterSentSuccessfully.Visible = true;
                            btnSendOfferFinish.Visible = true;
                            btnSendOfferTryAgain.Visible = false;
                            lblReport2.Visible = false;

                        }
                        else
                        {
                            PanelOfferEmployment.Visible = false;
                            LbOfferLetterSentSuccessfully.Text = "Employment Letter NOT sent";
                            LbOfferLetterSentSuccessfully.Visible = true;
                            btnSendOfferFinish.Visible = false;
                            btnSendOfferTryAgain.Visible = true;
                            lblReport2.Visible = false;
                        }
                    }
                    catch { }

                }
                //  MViewInterview.ActiveViewIndex = 9;
            }
        }

       

        protected void btnSendOfferTryAgain_Click(object sender, System.EventArgs e)
        {
            PanelOfferEmployment.Visible = true;
           LbOfferLetterSentSuccessfully.Visible = false;
            btnSendOfferFinish.Visible = false;
            lblReport2.Visible = false;
            btnSendOfferTryAgain.Visible = false;

        }
        #endregion

        //Printing offer letter

        #region
        protected void btnPrint_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Write("<script>Print5.print();</script>");
            btnPrint.Visible = false;
          
        }

        #endregion

    
    
    }
}