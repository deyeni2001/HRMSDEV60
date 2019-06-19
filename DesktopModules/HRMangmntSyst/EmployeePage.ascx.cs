
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using System.Web.SessionState;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Roles;
using DotNetNuke.Security.Membership;
using AspNetSecurity = System.Web.Security;
using ola.HRMangmntSyst;

namespace ola.HRMangmntSyst
{
    // public partial class EmployeePage : PortalModuleBase, IActionable
    public partial class EmployeePage : ola.ModuleBase.ModuleBase, IActionable
    {
        string passport;
        string filepath2;
        int applicantID;
        int employeeID;
        int EmployeeUserID_FK;
        // int uid;
        // int UserID;
        int EmployeeID;
        string employeeNum;
        DataTable dt1 = new DataTable();
        bool flag = false;


        UserController objUserController = new UserController();

        RoleController objRoleController = new RoleController();

        public class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('+strMsg')", true);
            }
        }

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
                MViewEmployee.ActiveViewIndex = 0;

                //loading Qualifications

                ArrayList objQualifications = new ArrayList();
                objQualifications = (new QualificationsController()).List();

                if (objQualifications.Count > 0)
                {
                    qualifList.DataSource = objQualifications;
                    qualifList.DataTextField = "qualifName";
                    qualifList.DataValueField = "qualifID";
                    qualifList.DataBind();

                }
                qualifList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                gradeList.Items.Insert(0, new ListItem("***Please select***", "-1"));



            }

            if (IsPostBack) return;
            else
            {
                var days = new ArrayList();
                days.Add("*Day*");
                for (var i = 1; i <= 31; i++)
                {
                    days.Add(i);
                }

                goalNxtYrDayList.DataSource = days;
                goalNxtYrDayList.DataBind();

                leaveStartDayList.DataSource = days;
                leaveStartDayList.DataBind();

                LeaveEndDayList.DataSource = days;
                LeaveEndDayList.DataBind();

            }

            if (IsPostBack) return;
            else
            {
                var yrs = new ArrayList();
                yrs.Add("*Year*");
                for (var i = 2018; i >= 1900; i--)
                {
                    yrs.Add(i);
                }
                qualifStartYearList.DataSource = yrs;
                qualifStartYearList.DataBind();

                qualifEndYearList.DataSource = yrs;
                qualifEndYearList.DataBind();

                certYearList.DataSource = yrs;
                certYearList.DataBind();

                appraisalYearList.DataSource = yrs;
                appraisalYearList.DataBind();

                goalNxtYrYearList.DataSource = yrs;
                goalNxtYrYearList.DataBind();

                leaveStartYearList.DataSource = yrs;
                leaveStartYearList.DataBind();

                LeaveEndYearList.DataSource = yrs;
                LeaveEndYearList.DataBind();

            }

            //WorkLocation

#region

            ArrayList objEmpWorkLocation = new ArrayList();
            objEmpWorkLocation = (new EmployeeWorkLocationsController()).List();

            if (objEmpWorkLocation.Count > 0)
            {
                transferNewWokLocList.DataSource = objEmpWorkLocation;
                transferNewWokLocList.DataTextField = "LocationName";
                transferNewWokLocList.DataValueField = "WorkLocationID";
                transferNewWokLocList.DataBind();
            }
            transferNewWokLocList.Items.Insert(0, new ListItem("***Please select***", "-1"));
#endregion

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
        protected void homeBtn_Click(object sender, EventArgs e)
        {

            MViewEmployee.ActiveViewIndex = 0;

        }
        protected void welEmplomentBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 1;

            PanelEmployeeProfile.Visible = true;

            EmployeeDepartmentTableInfo objEmpDept = new EmployeeDepartmentTableInfo();
            int DeptID = CurrentEmployeeDetail.Department_FK;
            objEmpDept = (new EmployeeDepartmentTableController()).Get(DeptID);


            EmployeePositionTableInfo objEmpPosition = new EmployeePositionTableInfo();
            int PositionID = CurrentEmployeeDetail.PositionHeld_FK;
            objEmpPosition = (new EmployeePositionTableController()).Get(PositionID);


            EmployeeLevelInfo objEMpLevel = new EmployeeLevelInfo();
            int LevelID = CurrentEmployeeDetail.EmployeeLevel_FK;
            objEMpLevel = (new EmployeeLevelController()).Get(LevelID);

            EmployeeWorkLocationsInfo objEmpWorkLoc = new EmployeeWorkLocationsInfo();
            int WorkLocationID = CurrentEmployeeDetail.WorkLocation_FK;
            objEmpWorkLoc = (new EmployeeWorkLocationsController()).Get(WorkLocationID);

            CountryTableInfo objEmpCountry = new CountryTableInfo();
            int CountryID = CurrentEmployeeDetail.Nationality_FK;
            objEmpCountry = (new CountryTableController()).Get(CountryID);

            StateTableInfo objEmpState = new StateTableInfo();
            int StateID = CurrentEmployeeDetail.StateOfOrigin_FK;
            objEmpState = (new StateTableController()).Get(StateID);

            LGATableInfo objEmpLGA = new LGATableInfo();
            int LgaID = CurrentEmployeeDetail.LGA_FK;
            objEmpLGA = (new LGATableController()).Get(LgaID);

            UserInfo objEmpConfirmby = new UserInfo();
            int empConfirmID = CurrentEmployeeDetail.ConfirmedBy;
            objEmpConfirmby = (new UserController()).GetUser(0, empConfirmID);





            LbempTitle.Text = CurrentEmployeeDetail.Title;
            LbempFName.Text = CurrentEmployeeDetail.FirstName;
            LbempMName.Text = CurrentEmployeeDetail.MiiddleName;
            LbempLName.Text = CurrentEmployeeDetail.LastName;
            LbempMaritalStatus.Text = CurrentEmployeeDetail.MaritalStatus;
            LbempGender.Text = CurrentEmployeeDetail.Gender;
            LbempPhnNo.Text = CurrentEmployeeDetail.PhoneNo;
            LbempEmail.Text = CurrentEmployeeDetail.Email;
            LbempContAddres.Text = CurrentEmployeeDetail.ContactAddress;
            LbempDOB.Text = CurrentEmployeeDetail.DateOfBirth;
            LbempAge.Text = CurrentEmployeeDetail.Age;
            LbempGender.Text = CurrentEmployeeDetail.Gender;
            LbempReligion.Text = CurrentEmployeeDetail.Religion;
            LbempStartDate.Text = CurrentEmployeeDetail.StartDate;
            EmpProfilePassport.ImageUrl = "~/images/" + CurrentEmployeeDetail.Passport.Substring(CurrentEmployeeDetail.Passport.LastIndexOf('/') + 1);



            LbempCountry.Text = objEmpCountry.CountryName;
            LbempState.Text = objEmpState.StateName;
            LbempLga.Text = objEmpLGA.LgaName;

            LbempDepts.Text = objEmpDept.DeptName;
            LbempPosition.Text = objEmpPosition.PositionName;
            LbempLevel.Text = objEMpLevel.LevelName;
            LbempWorkLoc.Text = objEmpWorkLoc.LocationName + "," + " " + objEmpWorkLoc.LocationAddress;


            // Collecting Employee spouse details

            LbSpouseNames.Text = CurrentEmployeeDetail.SpouseNames;
            LbSpousePhoNo.Text = CurrentEmployeeDetail.SpousePhoneNo;
            LbSpouseAddress.Text = CurrentEmployeeDetail.SpouseAddress;
            LbSpouseEmailAddr.Text = CurrentEmployeeDetail.SpouseEmail;
            LbSpouseOccupation.Text = CurrentEmployeeDetail.SpouseOccupation;
            LbSpouseEmployer.Text = CurrentEmployeeDetail.SpouseEmployerNames;

            //Collecting Employee NextOfKin details

            LbNextOfKinNames.Text = CurrentEmployeeDetail.NxtOfKinLName + " " + CurrentEmployeeDetail.NxtOfKinMidName + " " + CurrentEmployeeDetail.NxtOfKinFName;
            LbNextOfKinRelationship.Text = CurrentEmployeeDetail.NxtOfKinRelationship;
            LbNextOfKinEmail.Text = CurrentEmployeeDetail.NxtOfKinEmail;
            LbNextOfKinAddress.Text = CurrentEmployeeDetail.NxtOfKinAddress;
            LbNextOfKinOccupation.Text = CurrentEmployeeDetail.NxtOfKinOccupation;
            LbNextOfKinPhnNo.Text = CurrentEmployeeDetail.NxtOfKinPhoneNo;

            //Collecting Employee status Info

            LbEmployeeStatus.Text = CurrentEmployeeDetail.EmployeeStatus;
            LbEmpConfimedDate.Text = CurrentEmployeeDetail.ConfirmationDate;

            if (CurrentEmployeeDetail.ConfirmedBy > 0)
            {
                LbEmpConfimedBy.Text = objEmpConfirmby.DisplayName;
               
            }
            else if (CurrentEmployeeDetail.ConfirmedBy <= 0 )
            {

                LbEmpConfimedBy.Text = "Not yet Confirm";
            }
            else 
            {

                LbEmpConfimedBy.Text = "Not yet Confirm";
            }
            // Convert.ToString(CurrentEmployeeDetail.ConfirmedBy;

            //Collecting Employee Bank Info

            LbEmpBankNames.Text = CurrentEmployeeDetail.BankName;
            LbAccountName.Text = CurrentEmployeeDetail.AccountName;
            LbAcctNumber.Text = CurrentEmployeeDetail.AccountNo;
            LbGuarrantorName.Text = CurrentEmployeeDetail.GuarrantorNames;

            //Collecting Employee Referee Info
            LbRefNames1.Text = CurrentEmployeeDetail.Refree1Names;
            LbRefOccuptn1.Text = CurrentEmployeeDetail.Refree1Occupation;
            LbRefEmailAddr1.Text = CurrentEmployeeDetail.Refree1Email;
            LbRefPhoNo1.Text = CurrentEmployeeDetail.Refree1PhoneNum;
            LbRefContAddrss1.Text = CurrentEmployeeDetail.Refree1ContactAddr;


            LbRefNames2.Text = CurrentEmployeeDetail.Refree2Names;
            LbRefOccuptn2.Text = CurrentEmployeeDetail.Refree2Occupation;
            LbRefPhoNo2.Text = CurrentEmployeeDetail.Refree2PhoneNum;
            LbRefEmailAddr2.Text = CurrentEmployeeDetail.Refree2Email;
            LbRefContAddrss2.Text = CurrentEmployeeDetail.Refree2ContactAddr;

            //EmpProfileQualification

            //int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            //   int empID_FK = CurrentEmployeeDetail.EmployeeID;
            //   int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

            int empID_FK = CurrentEmployeeDetail.EmployeeID;

            ArrayList objProfileQaulifList = new ArrayList();

            objProfileQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID_FK);

            if (objProfileQaulifList.Count > 0)
            {
                GViewEmpProfileQualification.Visible = true;
                GViewEmpProfileQualification.DataSource = objProfileQaulifList;
                GViewEmpProfileQualification.DataBind();

            }



            //int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;

            // int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            ArrayList objProfileProfQaulifList = new ArrayList();
            objProfileProfQaulifList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID_FK);

            if (objProfileProfQaulifList.Count > 0)
            {
                GViewEmpProfileCert.Visible = true;
                GViewEmpProfileCert.DataSource = objProfileProfQaulifList;
                GViewEmpProfileCert.DataBind();

            }


            ////int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            //int empID_FK = CurrentEmployeeDetail.employeeID;
            //int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

            ArrayList objProfileDocList = new ArrayList();
            objProfileDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID_FK);

            if (objProfileDocList.Count > 0)
            {

                GViewEmpProfileDoc.Visible = true;
                GViewEmpProfileDoc.DataSource = objProfileDocList;
                GViewEmpProfileDoc.DataBind();

            }

        }


        //EmpProfileQualification


        //EmployeeProfQualification



        //EmpProfile Documents

        protected void updateMenuBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 2;
            PanelEmpSpouse.Visible = true;
            btnSpouseFinish.Visible = false;
            btnSpouseTryAgain.Visible = false;
            lbEmpSpouseAdded1.Visible = false;
            
        }
        protected void empQualifBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 7;
            lbEmpQualificationAdded1.Visible = false;

            ArrayList objQaulifList = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID);

            if (objQaulifList.Count > 0)
            {
                GViewQaulification.Visible = true;
                GViewQaulification.DataSource = objQaulifList;
                GViewQaulification.DataBind();

            }
        }
        protected void empCertBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 8;
            LbProfQualifSave1.Visible = false;
            ArrayList objProfCertList = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objProfCertList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID);

            if (objProfCertList.Count > 0)
            {
                GViewEmpCert1.Visible = true;
                GViewEmpCert1.DataSource = objProfCertList;
                GViewEmpCert1.DataBind();
                

            }
        }

        protected void docBtn_Click(object sender, EventArgs e)
        {
            LbDocumentSave1.Visible = false;
            MViewEmployee.ActiveViewIndex = 9;

            ArrayList objDocList = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID);

            if (objDocList.Count > 0)
            {
                GViewEmpDoc1.Visible = true;
                GViewEmpDoc1.DataSource = objDocList;
                GViewEmpDoc1.DataBind();

            }
        }

        protected void refreeBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 5;
            PanelRefree.Visible = true;
            lbEmpRefereeAdded.Visible = false;
            lbEmpRefereeAdded1.Visible = false;
            btnRefreeFinish.Visible = false;
            btnRefreeTryAgain.Visible = false;
            refereshPage();
        }

        protected void respondBtn_Click(object sender, EventArgs e)
        {

            MViewEmployee.ActiveViewIndex = 10;
            PanelQueryDetails.Visible = false;
            PanelDiscipline.Visible = false;
            LbQueryResponseSent1.Visible = false;
            btnQueryFinish.Visible = false;
           

            ArrayList objQuery = new ArrayList();
            int empID = CurrentEmployeeDetail.EmployeeID;
            objQuery = (new EmployeeQueryTableController()).GetByEmployeeDetails(empID);
            if (objQuery.Count > 0)
            {
                lblQueryReport.Visible = false;
                GVQuery.DataSource = objQuery;
                GVQuery.DataBind();
                GVQuery.Visible = true;
            }
            else
            {
                GVQuery.Visible = false;
                lblQueryReport.Text = "You don't have any query for now";
                lblQueryReport.Visible = true;

            }
        }

      
        protected void leaveBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 11;

            EmployeeLeaveTableInfo objGetLeave1 = new EmployeeLeaveTableInfo();
            int LeaveEmp = CurrentEmployeeDetail.EmployeeID;
            objGetLeave1 = (new EmployeeLeaveTableController()).GetForAnEmployee(LeaveEmp);

            EmployeeDetailsInfo objGetEmpLevelEntile = new EmployeeDetailsInfo();
            int levelEmp = CurrentEmployeeDetail.EmployeeLevel_FK;
            objGetEmpLevelEntile = (new EmployeeDetailsController()).GetByEmployeeLevelForLeave(levelEmp);

            if ( objGetLeave1 != null)
            {
                lblLeave.Text = objGetLeave1.LeaveEntitle;
                LbThreshold1.Text = objGetLeave1.LeaveThreshold;
            }
            else
            {
                lblLeave.Text = objGetEmpLevelEntile.LeaveEntitle;
                LbThreshold1.Text = objGetEmpLevelEntile.LeaveEntitle;
            }
            //Loading leave types
            ArrayList objLeave = new ArrayList();
            objLeave = (new EmployeeTypeOfLeaveTableController()).List();
            if (objLeave.Count > 0)
            {
                leaveTypeList.DataSource = objLeave;
                leaveTypeList.DataValueField = "LeaveTypeID";
                leaveTypeList.DataTextField = "LeaveTypeName";
                leaveTypeList.DataBind();
               leaveTypeList.Items.Insert(0, new ListItem("---Please Select---", "-1"));
            }


            // number of leave an employee is entitle depend on his level
            // get the levelId of the current employee
            // then use it to get his leave entitle from the level table
            EmployeeLevelInfo objLevel = new EmployeeLevelInfo();
            objLevel = (new EmployeeLevelController()).Get(CurrentEmployeeDetail.EmployeeLevel_FK);
            lblLeave.Text = objLevel.LeaveEntitle;
            lblLeaveApplyDate.Text = DateTime.Now.ToString();
            LbEmpLeaveEmpID.Text = CurrentEmployeeDetail.EmployeeNum;
            LbEmpLeaveEmpID.Visible = true;
        }
        


        protected void selfAppraisalBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 12;
           
            conpetencyNextBtn1.Visible = false;
            LbSuccess1.Visible = false;
            PanelNewAppraisal.Visible = true;

            EmployeeDepartmentTableInfo objDept = new EmployeeDepartmentTableInfo();
            int dept = CurrentEmployeeDetail.Department_FK;
            objDept = (new EmployeeDepartmentTableController()).Get(dept);

            EmployeePositionTableInfo objPost = new EmployeePositionTableInfo();
            int post = CurrentEmployeeDetail.PositionHeld_FK;
            objPost = (new EmployeePositionTableController()).Get(post);

            EmployeeDetailsInfo objSup = new EmployeeDetailsInfo();
            int supID = CurrentEmployeeDetail.SupervisorID;
            objSup = (new EmployeeDetailsController()).Get(supID);


            LbLastName.Text = CurrentEmployeeDetail.LastName;
            LbFirstName.Text = CurrentEmployeeDetail.FirstName;
            LbMiddleName.Text = CurrentEmployeeDetail.MiiddleName;
            LbEmpDept.Text = objDept.DeptName;
            LbEmpPost.Text = objPost.PositionName;
            LbEmpSupName.Text = objSup.LastName + objSup.FirstName;
            string mydate = DateTime.Now.ToShortDateString();
            LbEmpAppraisalDate.Text = mydate;
            LbEmpAppraisalDate.Visible = true;



        }

        protected void appraisalBackBtn_Click(object sender, EventArgs e)
        {
        }
        protected void appraisalHomeBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }
        protected void conpetencyNextBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 13;

        }


        protected void EmpHome_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }
        protected void EmpBioDataLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 1;
        }
        protected void EmpQualifLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 2;
        }
        protected void EmpCertifLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 3;
        }


        protected void docLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 4;
        }
        protected void EmpRefreeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 5;
        }
        protected void EmpQueryLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 6;
        }
        protected void EmpAppraisalLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 7;
        }



        protected void docViewBtn_Click(object sender, EventArgs e)
        {
            GViewEmpDoc.Visible = true;
        }


        protected void spouceLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 2;
            lbEmpSpouseAdded1.Visible = false;
            lbEmpSpouseAdded.Visible = false;
            PanelEmpSpouse.Visible = true;
            refereshPage();
        }
        protected void NextofKinLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 3;
            lbEmpNxtOfKinAdded.Visible = false;
            lbEmpNxtOfKinAdded.Text = "Error! NOK Details not updated.";
            PanelNOK.Visible = true;
            lbEmpNxtOfKinAdded1.Visible = false;
            lbEmpNxtOfKinAdded1.Text = "Error! NOK Details not updated.";
            btnNOKTryAgain.Visible = false;
            btnNOKFinish.Visible = false;
        }
        protected void BankLinkBtn_Click(object sender, EventArgs e)
        {

            MViewEmployee.ActiveViewIndex = 4;
            PanelEmpBank.Visible = true;
            lbEmpBankInfoAdded.Visible = false;
            lbEmpBankInfoAdded1.Text = "Error! Bank Details not updated.";
            lbEmpBankInfoAdded1.Visible = false;
            btnBankFinish.Visible = false;
            btnBankTryAgain.Visible = false;
            refereshPage();
        }
        protected void guarrantorLinkBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 6;
            PanelGuarrantor.Visible = true;
            refereshPage();
            lbEmpGuarrantorAdded.Visible = false;
            lbEmpGuarrantorAdded1.Visible = false;
             btnGuarrantorTFinish.Visible = false;
            btnGuarrantorTryAgain.Visible = false;
        }


        protected void qualifList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loading Grade

            ArrayList objGrade = new ArrayList();
            int qualifid = Convert.ToInt32(qualifList.SelectedValue);
            objGrade = (new GradeTableController()).GetByQualifications(qualifid);

            if (objGrade.Count > 0)
            {
                gradeList.DataSource = objGrade;
                gradeList.DataTextField = "gradeName";
                gradeList.DataValueField = "gradeID";
                gradeList.DataBind();
            }
            // gradeList.Items.Insert(0, new ListItem("***Please select", "-1"));
        }


     

       // Updating Employee Details

        #region

        //Spouce Info
        protected void spouseSaveBtn_Click(object sender, EventArgs e)
        {

            EmployeeDetailsInfo objEmpSpouse = new EmployeeDetailsInfo();

            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpSpouse.EmployeeID = employeeID;
            objEmpSpouse.EmployeeUserID_FK = empUser;
            objEmpSpouse.SpouseNames = this.txtSpouceLN.Text + " " + txtSpouseMN0.Text + " " + txtSpouseFN.Text.Trim();
            objEmpSpouse.SpousePhoneNo = this.txtSpoucePhnNum.Text.Trim();
            objEmpSpouse.SpouseEmail = this.txtSpouceEmail.Text.Trim();
            objEmpSpouse.SpouseAddress = this.txtSpouceContAddress.Text.Trim();
            objEmpSpouse.SpouseOccupation = this.txtSpouceOccupation.Text.Trim();
            objEmpSpouse.SpouseEmployerNames = this.txtSpouceEmployer.Text.Trim();

            CurrentEmployeeDetail2(objEmpSpouse);

            //saving into log

            EmployeeDetailsInfo objEmpSpouseGetForLog = new EmployeeDetailsInfo();
            objEmpSpouseGetForLog = (new EmployeeDetailsController()).Get(employeeID);

            EmployeeDetailsLogInfo objEmpSpouseGetLog = new EmployeeDetailsLogInfo();
            objEmpSpouseGetLog = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

            EmployeeDetailsLogInfo objEmpSpouseLog = new EmployeeDetailsLogInfo();

            objEmpSpouseLog.EmployeeLogID = objEmpSpouseGetLog.EmployeeLogID;
            objEmpSpouseLog.EmployeeID_FK = employeeID;
            objEmpSpouseLog.EmployeeUserID_FK = empUser;
            objEmpSpouseLog.SpouseNames = this.txtSpouceLN.Text + " " + txtSpouseMN0.Text + " " + txtSpouseFN.Text.Trim();
            objEmpSpouseLog.SpousePhoneNo = this.txtSpoucePhnNum.Text.Trim();
            objEmpSpouseLog.SpouseEmail = this.txtSpouceEmail.Text.Trim();
            objEmpSpouseLog.SpouseAddress = this.txtSpouceContAddress.Text.Trim();
            objEmpSpouseLog.SpouseOccupation = this.txtSpouceOccupation.Text.Trim();
            objEmpSpouseLog.SpouseEmployerNames = this.txtSpouceEmployer.Text.Trim();

            (new EmployeeDetailsLogController()).LogSpouseUpdate(objEmpSpouseLog);
            
            EmployeeDetailsLogInfo objEmpSpouseGetLog2 = new EmployeeDetailsLogInfo();
            objEmpSpouseGetLog2 = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

            if (
                (objEmpSpouseGetForLog.SpouseNames == txtSpouceLN.Text + " " + txtSpouseMN0.Text + " " + txtSpouseFN.Text) && (objEmpSpouseGetForLog.SpouseEmail == txtSpouceEmail.Text) &&
                (objEmpSpouseGetLog2.SpouseNames == txtSpouceLN.Text + " " + txtSpouseMN0.Text + " " + txtSpouseFN.Text) && (objEmpSpouseGetLog2.SpouseEmail == txtSpouceEmail.Text)
                )
            {
                lbEmpSpouseAdded.Visible = true;
                lbEmpSpouseAdded.Text = "Spouse Detial Successfully updated";
                PanelEmpSpouse.Visible = false;
                lbEmpSpouseAdded1.Visible = true;
                lbEmpSpouseAdded1.Text = "Spouse Detial Successfully updated";
                refereshPage();
            }
            else
            {
                lbEmpSpouseAdded.Text=" Error! Spouse Details Not updated.";
                lbEmpSpouseAdded.Visible = true;
                PanelEmpSpouse.Visible = false;
                lbEmpSpouseAdded1.Text = " Error! Spouse Details Not updated.";
                lbEmpSpouseAdded1.Visible = true;
            }

        }
        protected void btnSpouseFinish_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }
        protected void btnSpouseTryAgain_Click(object sender, EventArgs e)
        {
            lbEmpSpouseAdded1.Visible = false;
            lbEmpSpouseAdded.Visible = false;
            PanelEmpSpouse.Visible = true;
            //refereshPage();
        }

        #endregion

        //NextoKinInfo

        #region
        protected void nextOfKinSaveBtn_Click(object sender, EventArgs e)
        {

            EmployeeDetailsInfo objEmpNOK = new EmployeeDetailsInfo();

            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpNOK.EmployeeID = employeeID;
            objEmpNOK.EmployeeUserID_FK = empUser;

            objEmpNOK.NxtOfKinFName = this.txtNxtOfKinfName.Text.Trim();
            objEmpNOK.NxtOfKinMidName = this.txtNxtOfKinMidName.Text.Trim();
            objEmpNOK.NxtOfKinLName = this.txtNxtOfKinLName.Text.Trim();
            objEmpNOK.NxtOfKinPhoneNo = this.txtNxtOfKinPhNo.Text.Trim();
            objEmpNOK.NxtOfKinEmail = this.txtNxtOfKinEmail.Text.Trim();
            objEmpNOK.NxtOfKinOccupation = this.txtNxtOfKinOccupation.Text.Trim();
            objEmpNOK.NxtOfKinAddress = this.txtNxtOfKinContAdd.InnerText.Trim();
            objEmpNOK.NxtOfKinRelationship = this.txtNxtOfKinRelationship.Text.Trim();

            CurrentEmployeeDetailNOK(objEmpNOK);

            //saving int log

            EmployeeDetailsInfo objEmpGetNOKForLog = new EmployeeDetailsInfo();
            objEmpGetNOKForLog = (new EmployeeDetailsController()).Get(employeeID);

            EmployeeDetailsLogInfo objEmpGetNOKLog = new EmployeeDetailsLogInfo();
            objEmpGetNOKLog = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

            EmployeeDetailsLogInfo objEmpNOKLog = new EmployeeDetailsLogInfo();
            objEmpNOKLog.EmployeeLogID = objEmpGetNOKLog.EmployeeLogID;
            objEmpNOKLog.EmployeeID_FK = employeeID;
            objEmpNOKLog.EmployeeUserID_FK = empUser;

            objEmpNOKLog.NxtOfKinFName = this.txtNxtOfKinfName.Text.Trim();
            objEmpNOKLog.NxtOfKinMidName = this.txtNxtOfKinMidName.Text.Trim();
            objEmpNOKLog.NxtOfKinLName = this.txtNxtOfKinLName.Text.Trim();
            objEmpNOKLog.NxtOfKinPhoneNo = this.txtNxtOfKinPhNo.Text.Trim();
            objEmpNOKLog.NxtOfKinEmail = this.txtNxtOfKinEmail.Text.Trim();
            objEmpNOKLog.NxtOfKinOccupation = this.txtNxtOfKinOccupation.Text.Trim();
            objEmpNOKLog.NxtOfKinAddress = this.txtNxtOfKinContAdd.InnerText.Trim();
            objEmpNOKLog.NxtOfKinRelationship = this.txtNxtOfKinRelationship.Text.Trim();

            (new EmployeeDetailsLogController()).LogNextOfKinUpdate(objEmpNOKLog);

            EmployeeDetailsLogInfo objEmpGetNOKLog2 = new EmployeeDetailsLogInfo();
            objEmpGetNOKLog2 = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

            if (
                (objEmpGetNOKForLog.NxtOfKinLName == txtNxtOfKinLName.Text)&&(objEmpGetNOKForLog.NxtOfKinEmail == txtNxtOfKinEmail.Text) &&
                (objEmpGetNOKLog2.NxtOfKinLName == txtNxtOfKinLName.Text)&&(objEmpGetNOKLog2.NxtOfKinEmail == txtNxtOfKinEmail.Text) 
                )
            {
                lbEmpNxtOfKinAdded.Visible = true;
                lbEmpNxtOfKinAdded.Text = "NOK Detial Successfully updated";
                PanelNOK.Visible = false;
                lbEmpNxtOfKinAdded1.Visible = true;
                lbEmpNxtOfKinAdded1.Text = "NOK Detial Successfully updated";
                btnNOKTryAgain.Visible = false;
                btnNOKFinish.Visible = true;
                refereshPage();
            }
            else
            {
                lbEmpNxtOfKinAdded.Visible = true;
                lbEmpNxtOfKinAdded.Text = "Error! NOK Details not updated.";
                PanelNOK.Visible = false;
                lbEmpNxtOfKinAdded1.Visible = true;
                lbEmpNxtOfKinAdded1.Text = "Error! NOK Details not updated.";
                btnNOKTryAgain.Visible = true;
                btnNOKFinish.Visible = false;
            }



        }
        protected void btnNOKTryAgain_Click(object sender, EventArgs e)
        {
            PanelNOK.Visible = true;
            lbEmpNxtOfKinAdded1.Visible = false;
            lbEmpNxtOfKinAdded.Visible = false;
        }

        private void refereshPage()
        {
            this.txtSpouseFN.Text = "";
            this.txtSpouceLN.Text = "";
            this.txtSpouseMN0.Text = "";
            this.txtSpouceOccupation.Text = "";
            this.txtSpoucePhnNum.Text = "";
            this.txtSpouceEmployer.Text = "";
            this.txtSpouceContAddress.Text = "";


            this.txtNxtOfKinfName.Text = "";
            this.txtNxtOfKinMidName.Text = "";
            this.txtNxtOfKinLName.Text = "";
            this.txtNxtOfKinOccupation.Text = "";
            this.txtNxtOfKinRelationship.Text = "";
            this.txtNxtOfKinPhNo.Text = "";
            this.txtNxtOfKinEmail.Text = "";
            this.txtNxtOfKinContAdd.InnerText = "";

            this.txtAcctNum.Text = "";
            this.txtBnkName.Text = "";
            this.txtAcctName.Text = "";

            this.txtRefFName1.Text = "";
            this.txtRefMidName1.Text = "";
            this.txtRefLName1.Text = "";
            this.txtRefPhnNo1.Text = "";
            this.txtRefOccupation2.Text = "";
            this.txtRefEmail1.Text = "";
            this.txtRefContAddr1.InnerText = "";

            this.txtRefFName2.Text = "";
            this.txtRefMidName2.Text = "";
            this.txtRefLName2.Text = "";
            this.txtRefPhnNo2.Text = "";
            this.txtRefOccupation2.Text = "";
            this.txtRefEmail2.Text = "";
            this.txtRefContAddr2.InnerText = "";


        }

        #endregion

        //Adding Bank details

        #region
        protected void bankSaveBtn_Click(object sender, EventArgs e)
        {
            EmployeeDetailsInfo objEmpBankInfo = new EmployeeDetailsInfo();

            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpBankInfo.EmployeeID = employeeID;
            objEmpBankInfo.EmployeeUserID_FK = empUser;

            objEmpBankInfo.BankName = this.txtBnkName.Text.Trim();
            objEmpBankInfo.AccountName = this.txtAcctName.Text.Trim();
            objEmpBankInfo.AccountNo = this.txtAcctNum.Text.Trim();

            CurrentEmployeeDetailBankInfo(objEmpBankInfo);

            //saving to log

            EmployeeDetailsInfo objEmpBankInfoGetForLog = new EmployeeDetailsInfo();
            objEmpBankInfoGetForLog = (new EmployeeDetailsController()).Get(employeeID);

             EmployeeDetailsLogInfo objEmpBankInfoGetLog = new EmployeeDetailsLogInfo();
            objEmpBankInfoGetLog = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

            EmployeeDetailsLogInfo objEmpBankInfoLog = new EmployeeDetailsLogInfo();
            objEmpBankInfoLog.EmployeeLogID = objEmpBankInfoGetLog.EmployeeLogID;
            objEmpBankInfoLog.EmployeeID_FK = employeeID;
            objEmpBankInfoLog.EmployeeUserID_FK = empUser;
            objEmpBankInfoLog.BankName = this.txtBnkName.Text.Trim();
            objEmpBankInfoLog.AccountName = this.txtAcctName.Text.Trim();
            objEmpBankInfoLog.AccountNo = this.txtAcctNum.Text.Trim();

            (new EmployeeDetailsLogController()).LogBankInfoUpdate(objEmpBankInfoLog);

            EmployeeDetailsLogInfo objEmpBankInfoLogGet = new EmployeeDetailsLogInfo();
            objEmpBankInfoLogGet = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

            if (
                (objEmpBankInfoGetForLog.BankName == txtBnkName.Text) && (objEmpBankInfoGetForLog.AccountName == txtAcctName.Text) && (objEmpBankInfoGetForLog.AccountNo == txtAcctNum.Text) &&
                (objEmpBankInfoLogGet.BankName == txtBnkName.Text) && (objEmpBankInfoLogGet.AccountName == txtAcctName.Text) && (objEmpBankInfoLogGet.AccountNo == txtAcctNum.Text)
                )
            {
                lbEmpBankInfoAdded.Visible = true;
                lbEmpBankInfoAdded.Text = " Detial Successfully updated";
                PanelEmpBank.Visible = false;
                lbEmpBankInfoAdded1.Text = "Error! Bank Details not updated.";
                lbEmpBankInfoAdded1.Visible = true;
                btnBankFinish.Visible = true;
                btnBankTryAgain.Visible = false;
                refereshPage();
            }
            else
            {
                lbEmpBankInfoAdded.Text = " Error! Bank Details not updated.";

                PanelEmpBank.Visible = false;
                lbEmpBankInfoAdded.Visible = false;
                lbEmpBankInfoAdded1.Text = "Error! Bank Details not updated.";
                lbEmpBankInfoAdded1.Visible = true;
                btnBankFinish.Visible = false;
                btnBankTryAgain.Visible = true;
            }
        }
        protected void btnBankTryAgain_Click(object sender, EventArgs e)
        {
            PanelEmpBank.Visible = true;
            lbEmpBankInfoAdded.Visible=false;
            lbEmpBankInfoAdded1.Visible =false;
            btnBankFinish.Visible=false;
           // refereshPage();
        }

        #endregion

        //Referee

        #region
        protected void refSaveBtn_Click(object sender, EventArgs e)
        {


            EmployeeDetailsInfo objEmpRefree = new EmployeeDetailsInfo();
            int employeeID = CurrentEmployeeDetail.EmployeeID;
            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
            objEmpRefree.EmployeeID = employeeID;
            objEmpRefree.EmployeeUserID_FK = empUser;

            objEmpRefree.Refree1Names = this.txtRefFName1.Text + " " + txtRefMidName1.Text + " " + txtRefLName1.Text.Trim();
            objEmpRefree.Refree1Email = this.txtRefEmail1.Text.Trim();
            objEmpRefree.Refree1Occupation = this.txtRefOccupation1.Text.Trim();
            objEmpRefree.Refree1PhoneNum = this.txtRefPhnNo1.Text.Trim();
            objEmpRefree.Refree1ContactAddr = this.txtRefContAddr1.InnerText.Trim();

            objEmpRefree.Refree2Names = this.txtRefFName2.Text + " " + txtRefMidName2.Text + " " + txtRefLName2.Text.Trim();
            objEmpRefree.Refree2Email = this.txtRefEmail2.Text.Trim();
            objEmpRefree.Refree2Occupation = this.txtRefOccupation2.Text.Trim();
            objEmpRefree.Refree2PhoneNum = this.txtRefPhnNo2.Text.Trim();
            objEmpRefree.Refree2ContactAddr = this.txtRefContAddr2.InnerText.Trim();

            CurrentEmployeeDetailReferee(objEmpRefree);

            //Saving Refree info to log

            EmployeeDetailsInfo objEmpRefreeGetForLog = new EmployeeDetailsInfo();
            objEmpRefreeGetForLog = (new EmployeeDetailsController()).Get(employeeID);

            EmployeeDetailsLogInfo objEmpRefreeGetLog = new EmployeeDetailsLogInfo();
            objEmpRefreeGetLog = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

            EmployeeDetailsLogInfo objEmpRefreeLog = new EmployeeDetailsLogInfo();
            objEmpRefreeLog.EmployeeLogID = objEmpRefreeGetLog.EmployeeLogID;
            objEmpRefreeLog.EmployeeID_FK = employeeID;
            objEmpRefreeLog.EmployeeUserID_FK = empUser;

            objEmpRefreeLog.Refree1Names = this.txtRefFName1.Text + " " + txtRefMidName1.Text + " " + txtRefLName1.Text.Trim();
            objEmpRefreeLog.Refree1Email = this.txtRefEmail1.Text.Trim();
            objEmpRefreeLog.Refree1Occupation = this.txtRefOccupation1.Text.Trim();
            objEmpRefreeLog.Refree1PhoneNum = this.txtRefPhnNo1.Text.Trim();
            objEmpRefreeLog.Refree1ContactAddr = this.txtRefContAddr1.InnerText.Trim();

            objEmpRefreeLog.Refree2Names = this.txtRefFName2.Text + " " + txtRefMidName2.Text + " " + txtRefLName2.Text.Trim();
            objEmpRefreeLog.Refree2Email = this.txtRefEmail2.Text.Trim();
            objEmpRefreeLog.Refree2Occupation = this.txtRefOccupation2.Text.Trim();
            objEmpRefreeLog.Refree2PhoneNum = this.txtRefPhnNo2.Text.Trim();
            objEmpRefreeLog.Refree2ContactAddr = this.txtRefContAddr2.InnerText.Trim();

            (new EmployeeDetailsLogController()).LogRefereeUpdate(objEmpRefreeLog);

            EmployeeDetailsLogInfo objEmpRefreeGetLog2 = new EmployeeDetailsLogInfo();
            objEmpRefreeGetLog2 = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);


            if (
                (objEmpRefreeGetForLog.Refree1Names == txtRefFName1.Text + " " + txtRefMidName1.Text + " " + txtRefLName1.Text)&&
                (objEmpRefreeGetForLog.Refree2Names == txtRefFName2.Text + " " + txtRefMidName2.Text + " " + txtRefLName2.Text)&&
                (objEmpRefreeGetLog2.Refree1Names == txtRefFName1.Text + " " + txtRefMidName1.Text + " " + txtRefLName1.Text) &&
                (objEmpRefreeGetLog2.Refree2Names == txtRefFName2.Text + " " + txtRefMidName2.Text + " " + txtRefLName2.Text)
                )
            {
                lbEmpRefereeAdded.Visible = true;
                lbEmpRefereeAdded.Text = " Detial Successfully updated";
                PanelRefree.Visible = false;
                lbEmpRefereeAdded.Visible = false;
                lbEmpRefereeAdded1.Visible = true;
                lbEmpRefereeAdded1.Text = "Refree Detial Successfully updated";
                btnRefreeFinish.Visible = true;
                btnRefreeTryAgain.Visible = false;
                refereshPage();
            }
            else
            {
                lbEmpRefereeAdded.Text = " Error!Refree Details not updated.";
                PanelRefree.Visible = false;
                lbEmpRefereeAdded.Visible = false;
                lbEmpRefereeAdded1.Visible = true;
                lbEmpRefereeAdded1.Text = " Error! Refree Details not updated.";
                btnRefreeFinish.Visible = false;
                btnRefreeTryAgain.Visible = true;
            }

        }

        protected void btnRefreeTryAgain_Click(object sender, EventArgs e)
        {
            PanelRefree.Visible = true;
            lbEmpRefereeAdded.Visible = false;
            lbEmpRefereeAdded1.Visible = false;
            btnRefreeFinish.Visible = false;
        }

        #endregion

        //Adding Guarrantor details

        #region
        protected void guarantorSaveBtn_Click(object sender, EventArgs e)
        {
            if (GuarrantorFileUpload.HasFile)
            {
                string DocName = GuarrantorFileUpload.FileName.ToString();
                string folder = "~/documents/";
                string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();

                ViewState.Add("DocName", DocName);

                GuarrantorFileUpload.SaveAs(DocPath + "\\" + DocName);

                EmployeeDetailsInfo objEmpGuarrantor = new EmployeeDetailsInfo();

                int employeeID = CurrentEmployeeDetail.EmployeeID;
                int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
                objEmpGuarrantor.EmployeeID = employeeID;
                objEmpGuarrantor.EmployeeUserID_FK = empUser;

                objEmpGuarrantor.GuarrantorNames = txtGuarName.Text.Trim();
                objEmpGuarrantor.GuarrantorFormPath = (DocPath + "\\" + DocName);

                CurrentEmployeeDetailGuarrantor(objEmpGuarrantor);

                 EmployeeDetailsInfo objEmpGetGuarrantor = new EmployeeDetailsInfo();
                 objEmpGetGuarrantor = (new EmployeeDetailsController()).Get(employeeID);

                 EmployeeDetailsLogInfo objEmpGetLog = new EmployeeDetailsLogInfo();
                 objEmpGetLog = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(employeeID);

                //Saving Guarrantor Detail into Log

                 EmployeeDetailsLogInfo objEmpGuarrantorLog = new EmployeeDetailsLogInfo();
               objEmpGuarrantorLog.EmployeeLogID = objEmpGetLog.EmployeeLogID;
                objEmpGuarrantorLog.EmployeeID_FK=   CurrentEmployeeDetail.EmployeeID;               
                objEmpGuarrantorLog.EmployeeUserID_FK = objEmpGetGuarrantor.EmployeeUserID_FK;
                objEmpGuarrantorLog.GuarrantorNames = txtGuarName.Text.Trim();
                objEmpGuarrantorLog.GuarrantorFormPath = (DocPath + "\\" + DocName);
                (new EmployeeDetailsLogController()).LogGuarantorUpdate(objEmpGuarrantorLog);


                EmployeeDetailsLogInfo objEmpGuarrantorLogGet = new EmployeeDetailsLogInfo();
              objEmpGuarrantorLogGet= (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(CurrentEmployeeDetail.EmployeeID);

                if (
                    (objEmpGetGuarrantor.GuarrantorNames == txtGuarName.Text ) && (objEmpGetGuarrantor.GuarrantorFormPath  == (DocPath + "\\" + DocName)) &&
                    (objEmpGuarrantorLogGet.GuarrantorNames == txtGuarName.Text ) && (objEmpGuarrantorLogGet.GuarrantorFormPath  == (DocPath + "\\" + DocName))
                    )
                {
                    lbEmpGuarrantorAdded.Visible = true;
                    lbEmpGuarrantorAdded.Text = " Detial Successfully updated";
                    PanelGuarrantor.Visible = false;
                    lbEmpGuarrantorAdded.Visible = false;
                    lbEmpGuarrantorAdded1.Visible = true;
                    lbEmpGuarrantorAdded1.Text = " Detial Successfully updated";
                    btnGuarrantorTFinish.Visible = true;
                    btnGuarrantorTryAgain.Visible = false;
                    refereshPage();
                }
                else
                {
                    lbEmpGuarrantorAdded.Text = " Error! Details not updated.";
                    PanelGuarrantor.Visible = false;
                    lbEmpGuarrantorAdded.Visible = false;
                    lbEmpGuarrantorAdded1.Visible = true;
                    lbEmpGuarrantorAdded1.Text ="Error! Details not updated.";
                    btnGuarrantorTFinish.Visible = true;
                    btnGuarrantorTryAgain.Visible = false;
                }

            }
        }

        protected void btnGuarrantorTryAgain_Click(object sender, EventArgs e)
        {
            PanelGuarrantor.Visible = true;
            lbEmpGuarrantorAdded.Visible = false;
            lbEmpGuarrantorAdded1.Visible = false;
            btnGuarrantorTFinish.Visible = false;

        }
        #endregion


        #region
        //Employee Qualification
        //protected void qulifViewBtn_Click(object sender, EventArgs e)
        //{
        //    qulifVSaveBtn.Visible = true;
        //    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //    int empID = CurrentEmployeeDetail.EmployeeID;
        //    int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
        //    ArrayList objQaulifList = new ArrayList();
        //    objQaulifList = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);

        //    if (objQaulifList.Count > 0)
        //    {
        //        GViewQualification.Visible = true;
        //        GViewQualification.DataSource = objQaulifList;
        //        GViewQualification.DataBind();

        //    }

        //}

        //Saving qualifications into EmployeeTable

        //protected void qulifVSaveBtn_Click(object sender, EventArgs e)
        //{

        //    ArrayList ObjArr = new ArrayList();
        //    foreach (GridViewRow g1 in GViewQualification.Rows)
        //    {

        //        int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //        int empid = CurrentEmployeeDetail.EmployeeID;
        //        // int appid = CurrentEmployeeDetail.ApplicantID_FK;

        //        TextBox b = new TextBox();
        //        // find the textbox containing the applicantID on the gridview 
        //        b = (TextBox)g1.FindControl("txtQualifViewAppID");
        //        string appid = b.Text;


        //        EmployeeQualificationTableInfo objEmpQualif = new EmployeeQualificationTableInfo();

        //        objEmpQualif.InstitutionName = g1.Cells[0].Text;
        //        objEmpQualif.QualificationType = g1.Cells[1].Text;
        //        objEmpQualif.Course = g1.Cells[2].Text;
        //        objEmpQualif.Grade = g1.Cells[3].Text;
        //        objEmpQualif.StartYear = g1.Cells[4].Text;
        //        objEmpQualif.EndYear = g1.Cells[5].Text;
        //        objEmpQualif.ApplicantID_FK = Convert.ToInt32(appid);
        //        int empQualificationID = (new EmployeeQualificationTableController()).Add(objEmpQualif);


        //        EmployeeQualificationTableInfo objQualifEmpID = new EmployeeQualificationTableInfo();
        //        int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //        objQualifEmpID.ApplicantID_FK = Convert.ToInt32(appid);
        //        objQualifEmpID.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
        //        (new EmployeeQualificationTableController()).QualificationTableEmpIDUpdate(objQualifEmpID);

        //        if (objQualifEmpID.ApplicantID_FK == CurrentEmployeeDetail.ApplicantID_FK)
        //        {

        //            lbEmpQualifAdded.Text = "Qualifications Added Successfully";
        //        }
        //        else
        //        {
        //            lbEmpQualifAdded.Text = " Error! Qualification not added.";
        //        }
        //    }
        //}

        protected void qulifAddMoreBtn_Click(object sender, EventArgs e)
        {
            PanelAddQualif.Visible = true;

        }

        //Addmore qaulification

        protected void empQulifAddBtn_Click(object sender, EventArgs e)
        {
            qulifSaveBtn.Visible = true;
            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            int empID = CurrentEmployeeDetail.EmployeeID;
            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

            EmployeeQualificationTableInfo objGetLog = new EmployeeQualificationTableInfo();
            int emp = CurrentEmployeeDetail.EmployeeID;
            objGetLog = (new EmployeeQualificationTableController()).GetByEmployeeDetailsForInfo(emp);

            int elg = objGetLog.EmployeeLogID_FK;

            //foreach (GridViewRow x in GViewAddQualification.Rows)
            //{
            //    // declare a variable as textbox
            //    TextBox b = new TextBox();
            //    TextBox c = new TextBox();
            //    // find the textbox containing the applicantID on the gridview 
            //    b = (TextBox)x.FindControl("txtQualifSaveAppID");
            //    c = (TextBox)x.FindControl("txtQualifSaveEmpID");
            //    string appid = b.Text;
            //    string empid = c.Text;
            //}

            ArrayList ObjArr = new ArrayList();

            if (GViewAddQualification.Rows.Count > 0)
            {
                for (int i = 0; i < GViewAddQualification.Rows.Count; i++)
                {
                    EmployeeQualificationTableInfo objQualific = new EmployeeQualificationTableInfo();

                    objQualific.InstitutionName = GViewAddQualification.Rows[i].Cells[0].Text.ToString();
                    objQualific.QualificationType = GViewAddQualification.Rows[i].Cells[1].Text.ToString();
                    objQualific.Course = GViewAddQualification.Rows[i].Cells[2].Text.ToString();
                    objQualific.Grade = GViewAddQualification.Rows[i].Cells[3].Text.ToString();
                    objQualific.StartYear = GViewAddQualification.Rows[i].Cells[4].Text.ToString();
                    objQualific.EndYear = GViewAddQualification.Rows[i].Cells[5].Text.ToString();
                    objQualific.ApplicantID_FK = Convert.ToInt32(applicantID);
                    objQualific.EmployeeID_FK = Convert.ToInt32(empID);
                    objQualific.EmployeeID_FK = elg;

                    ObjArr.Add(objQualific);

                    GViewAddQualification.Visible = true;


                }
            }

            EmployeeQualificationTableInfo objQualific2 = new EmployeeQualificationTableInfo();
            objQualific2.InstitutionName = this.txtQualifSchName.Text.Trim();
            objQualific2.QualificationType = this.qualifList.SelectedItem.Text;
            objQualific2.Course = this.courseList.SelectedItem.Text.Trim();
            objQualific2.Grade = this.gradeList.SelectedItem.Text;
            objQualific2.StartYear = this.qualifStartYearList.SelectedItem.Text;
            objQualific2.EndYear = this.qualifEndYearList.SelectedItem.Text;
            objQualific2.ApplicantID_FK = Convert.ToInt32(applicantID);
            objQualific2.EmployeeID_FK = Convert.ToInt32(empID);
            objQualific2.EmployeeID_FK = Convert.ToInt32(elg);
            ObjArr.Add(objQualific2);

            GViewAddQualification.DataSource = ObjArr;
            GViewAddQualification.DataBind();
            GViewAddQualification.Visible = true;

            txtQualifSchName.Text = "";
            courseList.ClearSelection();
            qualifList.ClearSelection();
            gradeList.ClearSelection();
            qualifStartYearList.ClearSelection();
            qualifEndYearList.ClearSelection();
            qulifSaveBtn.Visible = true;

        }


        //Saving new qualifications into EmployeeTable
        protected void qulifSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {


                //ArrayList ObjArrQualific = new ArrayList();
                //ObjArrQualific = (new EmployeeQualificationTableController()).GetByEmployeeDetails(empid);

                //if (ObjArrQualific.Count > 0)
                //    foreach (EmployeeQualificationTableInfo ObjQ in ObjArrQualific)
                //    {
                //        empid = CurrentEmployeeDetail.EmployeeID;
                //        int appid = CurrentEmployeeDetail.ApplicantID_FK;
                //        int qualificationID = ObjQ.QualificationID;
                //        (new EmployeeQualificationTableController()).Delete(qualificationID);
                //    }

                ArrayList ObjArr = new ArrayList();

                int empid = CurrentEmployeeDetail.EmployeeID;

                foreach (GridViewRow g1 in GViewAddQualification.Rows)
                {
                    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
                    int app = CurrentEmployeeDetail.ApplicantID_FK;

                    // declare a variable as textbox

                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    TextBox c = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    a = (TextBox)g1.FindControl("txtQualifSaveAppID");
                    b = (TextBox)g1.FindControl("txtQualifSaveEmpID");
                    c = (TextBox)g1.FindControl("txtQualifSaveEmpLogID");

                    string appid = a.Text;
                    string emd = b.Text;
                    string emLog = b.Text;


                    EmployeeQualificationTableInfo objQualifInfo = new EmployeeQualificationTableInfo();
                    objQualifInfo.InstitutionName = g1.Cells[0].Text;
                    objQualifInfo.QualificationType = g1.Cells[1].Text;
                    objQualifInfo.Course = g1.Cells[2].Text;
                    objQualifInfo.Grade = g1.Cells[3].Text;
                    objQualifInfo.StartYear = g1.Cells[4].Text;
                    objQualifInfo.EndYear = g1.Cells[5].Text;
                    objQualifInfo.ApplicantID_FK = Convert.ToInt32(appid);
                    objQualifInfo.EmployeeID_FK = Convert.ToInt32(emd);
                    objQualifInfo.EmployeeLogID_FK = Convert.ToInt32(emLog);

                    ObjArr.Add(objQualifInfo);
                    int qualiicationID = (new EmployeeQualificationTableController()).NewAdd(objQualifInfo);



                    EmployeeQualificationTableInfo objQualifInfos = new EmployeeQualificationTableInfo();
                    int ee = CurrentEmployeeDetail.EmployeeID;
                    objQualifInfos = (new EmployeeQualificationTableController()).Get(ee);

                    if (qualiicationID > 0)
                    {
                        ArrayList objQaulifList = new ArrayList();
                        int empID = CurrentEmployeeDetail.EmployeeID;
                        objQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID);

                        if (objQaulifList.Count > 0)
                        {
                            PanelAddQualif.Visible = false;
                            GViewQaulification.Visible = true;
                            GViewQaulification.DataSource = objQaulifList;
                            GViewQaulification.DataBind();
                            lbEmpQualificationAdded.Visible = false;
                            lbEmpQualificationAdded1.Visible = true;
                            lbEmpQualificationAdded1.Text = "New Qualifications Added Successfully";

                        }
                        
                    }
                    else
                    {
                        ArrayList objQaulifList = new ArrayList();
                        int empID = CurrentEmployeeDetail.EmployeeID;
                        objQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID);

                        if (objQaulifList.Count > 0)
                        {
                            PanelAddQualif.Visible = false;
                            GViewQaulification.Visible = true;
                            GViewQaulification.DataSource = objQaulifList;
                            GViewQaulification.DataBind(); 
                            lbEmpQualificationAdded.Visible = false;
                            lbEmpQualificationAdded.Text = " Error! New Qualification not added.";
                            lbEmpQualificationAdded1.Visible = true;
                            lbEmpQualificationAdded1.Text = " Error! New Qualification not added.";

                        }
                       
                    }
                }

            }
            catch
            {

            }
        }

        protected void GViewAddQualification_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {

                if (e.CommandName == "Delete")
                {

                    new EmployeeQualificationTableController().Delete(Convert.ToInt32(e.CommandArgument));

                    int Empnum = CurrentEmployeeDetail.EmployeeID;



                    ArrayList ObjArrQualification = new ArrayList();
                    ObjArrQualification = (new EmployeeQualificationTableController()).GetByEmployeeDetails(Empnum);

                    if (ObjArrQualification.Count != 0)
                    {

                        GViewAddQualification.DataSource = (ObjArrQualification);
                        GViewAddQualification.DataBind();
                        int count = 0;
                        count += 1;
                        GViewAddQualification.Visible = true;
                        lbEmpQualifiDeleted.Text = count + " " + "Qualification deleted";

                    }

                }
            }
            catch { }
        }
        #endregion

        // Loading certification from applicantProQualiftable

        #region

        //protected void profCertViewBtn_Click(object sender, EventArgs e)
        //{
        //    //profCertSaveBtn.Visible = true;
        //    //int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //    //int empID = CurrentEmployeeDetail.EmployeeID;
        //    //int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
        //    //ArrayList objProfQaulifList = new ArrayList();
        //    //objProfQaulifList = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);

        //    //if (objProfQaulifList.Count > 0)
        //    //{
        //    //    GViewCert.Visible = true;
        //    //    GViewCert.DataSource = objProfQaulifList;
        //    //    GViewCert.DataBind();
        //    //}


        //    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //    int empID = CurrentEmployeeDetail.EmployeeID;
        //    int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
        //    //profCertSaveBtn.Visible = true;

        //    ArrayList objProfQaulifList = new ArrayList();

        //    objProfQaulifList = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);

        //    if (objProfQaulifList.Count > 0)
        //    {

        //        GViewCert.Visible = true;
        //        GViewCert.DataSource = objProfQaulifList;
        //        GViewCert.DataBind();
        //    }
        //foreach (GridViewRow x in GViewCert.Rows)
        //{
        //    // declare a variable as textbox
        //    TextBox b = new TextBox();
        //    // find the textbox containing the applicantID on the gridview 
        //    b = (TextBox)x.FindControl("txtAppID");
        //    string appid = b.Text;
        //    // appid = x.Cells[4].Text;


        //}
        //  }


        //saving profQualif for the first time
        //protected void profCertSaveBtn_Click(object sender, EventArgs e)
        //{

        //    ArrayList ObjArr = new ArrayList();
        //    foreach (GridViewRow x in GViewCert.Rows)
        //    {

        //        int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //        // int appid = CurrentEmployeeDetail.ApplicantID_FK;


        //        // declare a variable as textbox
        //        TextBox b = new TextBox();
        //        // find the textbox containing the applicantID on the gridview 
        //        b = (TextBox)x.FindControl("txtCertAppID");
        //        string appid = b.Text;

        //        EmployeeProfQualificationTableInfo objEmpProfQualif = new EmployeeProfQualificationTableInfo();

        //        objEmpProfQualif.CertificationName = x.Cells[0].Text;
        //        objEmpProfQualif.CertificateNo = x.Cells[1].Text;
        //        objEmpProfQualif.Stage = x.Cells[2].Text;
        //        objEmpProfQualif.CertYear = x.Cells[3].Text;
        //        objEmpProfQualif.ApplicantID_FK = Convert.ToInt32(appid);
        //        //string appid= x.Cells[4].Text;

        //        int empProQualifID = (new EmployeeProfQualificationTableController()).Add(objEmpProfQualif);

        //        EmployeeProfQualificationTableInfo objProfQualifEmpID = new EmployeeProfQualificationTableInfo();
        //        int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //        //int profQualfID = objProfQualifEmpID.ProfQualificationID;
        //        int empAPPid = CurrentEmployeeDetail.ApplicantID_FK;
        //        objProfQualifEmpID.ApplicantID_FK = Convert.ToInt32(appid);
        //        //Convert.ToInt32(g1.Cells[4].Text);
        //        objProfQualifEmpID.employeeID_FK = CurrentEmployeeDetail.EmployeeID;
        //        (new EmployeeProfQualificationTableController()).ProfQualificationTableEmpIDUpdate(objProfQualifEmpID);

        //        if (objProfQualifEmpID.ApplicantID_FK == empAPPid)
        //        {
        //            //lblQualificationMessage.Visible = true;
        //            LbProfQualifAdded.Visible = true;
        //            LbProfQualifAdded.Text = "Certification Added Successfully";
        //        }
        //        else
        //        {
        //            LbProfQualifAdded.Visible = true;
        //            LbProfQualifAdded.Text = " Error! Certification not added.";
        //        }
        //    }
        //}

        protected void certAddMoreBtn_Click(object sender, EventArgs e)
        {
            PanelAddProfqualif.Visible = true;

        }
        protected void certAddBtn_Click(object sender, EventArgs e)
        {
            certSaveBtn.Visible = true;
            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
            int empID = CurrentEmployeeDetail.EmployeeID;
            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;

            EmployeeProfQualificationTableInfo objGetLog = new EmployeeProfQualificationTableInfo();
            int em = CurrentEmployeeDetail.EmployeeID;
            objGetLog = (new EmployeeProfQualificationTableController()).GetByEmployeeDetailsForInfo(em);
            int emLOG = objGetLog.EmployeeLogID_FK;

            //foreach (GridViewRow x in GViewEmpCert.Rows)
            //{
            //    // declare a variable as textbox
            //    TextBox b = new TextBox();
            //    TextBox c = new TextBox();
            //    // find the textbox containing the applicantID on the gridview 
            //    b = (TextBox)x.FindControl("txtCertSaveAppID");
            //    c = (TextBox)x.FindControl("txtCertSaveEmpID");
            //    string appid = b.Text;
            //    string empid = c.Text;
            //    // string appid = x.Cells[4].Text;
            //    // string empid = x.Cells[5].Text;
            //}

            ArrayList ObjArr = new ArrayList();

            if (GViewEmpCert.Rows.Count > 0)
            {
                for (int i = 0; i < GViewEmpCert.Rows.Count; i++)
                {
                    EmployeeProfQualificationTableInfo objProfQualific = new EmployeeProfQualificationTableInfo();

                    objProfQualific.CertificationName = GViewEmpCert.Rows[i].Cells[0].Text.ToString();
                    objProfQualific.CertificateNo = GViewEmpCert.Rows[i].Cells[1].Text.ToString();
                    objProfQualific.Stage = GViewEmpCert.Rows[i].Cells[2].Text.ToString();
                    objProfQualific.CertYear = GViewEmpCert.Rows[i].Cells[3].Text.ToString();
                    objProfQualific.ApplicantID_FK = Convert.ToInt32(applicantID);
                    objProfQualific.employeeID_FK = Convert.ToInt32(empID);
                    objProfQualific.EmployeeLogID_FK = emLOG;
                    ObjArr.Add(objProfQualific);
                }
            }

            EmployeeProfQualificationTableInfo objProfQualific2 = new EmployeeProfQualificationTableInfo();

            objProfQualific2.CertificationName = this.txtCertName.Text.Trim();
            objProfQualific2.CertificateNo = this.txtCertNum.Text.Trim();
            objProfQualific2.Stage = this.certStageList.SelectedItem.Text;
            objProfQualific2.CertYear = this.certYearList.SelectedItem.Text;
            objProfQualific2.ApplicantID_FK = Convert.ToInt32(applicantID);
            objProfQualific2.employeeID_FK = Convert.ToInt32(empID);
            objProfQualific2.EmployeeLogID_FK = emLOG;
            ObjArr.Add(objProfQualific2);

            GViewEmpCert.DataSource = ObjArr;
            GViewEmpCert.DataBind();
            GViewEmpCert.Visible = true;

            txtCertName.Text = "";
            txtCertNum.Text = "";
            certStageList.ClearSelection();
            certYearList.ClearSelection();
            certSaveBtn.Visible = true;

        }

        protected void certSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {



                //ArrayList ObjArrProfQualific = new ArrayList();
                //ObjArrProfQualific = (new EmployeeProfQualificationTableController()).GetByEmployeeDetails(empid);
                //if (ObjArrProfQualific.Count > 0)
                //    foreach (EmployeeProfQualificationTableInfo ObjQ in ObjArrProfQualific)
                //    {
                //        empid = CurrentEmployeeDetail.EmployeeID;
                //        int appid = CurrentEmployeeDetail.ApplicantID_FK;
                //        int profQualificationID = ObjQ.ProfQualificationID;
                //        (new EmployeeProfQualificationTableController()).Delete(profQualificationID);
                //    }

                int empid = CurrentEmployeeDetail.EmployeeID;
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewEmpCert.Rows)
                {
                    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
                    // int appid = CurrentEmployeeDetail.ApplicantID_FK;

                    // declare a variable as textbox
                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    TextBox c = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    a = (TextBox)g1.FindControl("txtCertSaveAppID");
                    b = (TextBox)g1.FindControl("txtCertSaveEmpID");
                    c = (TextBox)g1.FindControl("txtCertSaveEmpLogID");

                    string appid = a.Text;
                    string emd = b.Text;
                    string empLog = c.Text;
                    empid = CurrentEmployeeDetail.EmployeeID;
                    // int appid = CurrentEmployeeDetail.ApplicantID_FK;

                    EmployeeProfQualificationTableInfo objProQualifInfo = new EmployeeProfQualificationTableInfo();
                    objProQualifInfo.CertificationName = g1.Cells[0].Text;
                    objProQualifInfo.CertificateNo = g1.Cells[1].Text;
                    objProQualifInfo.Stage = g1.Cells[2].Text;
                    objProQualifInfo.CertYear = g1.Cells[3].Text;
                    objProQualifInfo.ApplicantID_FK = Convert.ToInt32(appid);
                    objProQualifInfo.employeeID_FK = Convert.ToInt32(emd);
                    objProQualifInfo.EmployeeLogID_FK = Convert.ToInt32(empLog);

                    ObjArr.Add(objProQualifInfo);
                    int profQualiicationID = (new EmployeeProfQualificationTableController()).NewAdd(objProQualifInfo);


                    EmployeeProfQualificationTableInfo objProQualifInfos = new EmployeeProfQualificationTableInfo();
                    int ee = CurrentEmployeeDetail.EmployeeID;
                    objProQualifInfos = (new EmployeeProfQualificationTableController()).Get(ee);


                    if (profQualiicationID > 0)
                    {
                        LbProfQualifSave.Visible = true;
                        LbProfQualifSave.Text = "New Professional Qualifications Added Successfully";

                        PanelAddProfqualif.Visible = false;
                        ArrayList objProfCertList = new ArrayList();
                        int empID = ee;
                        objProfCertList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID);

                        if (objProfCertList.Count > 0)
                        {
                            GViewEmpCert1.Visible = true;
                            GViewEmpCert1.DataSource = objProfCertList;
                            GViewEmpCert1.DataBind();
                            LbProfQualifSave1.Visible = true;
                            LbProfQualifSave1.Text = "New Professional Qualifications Added Successfully";


                        }
                        
                    }
                    else
                    {
                        LbProfQualifSave.Visible = true;
                        LbProfQualifSave.Text = " Error! Professional Qualification not added.";
                        PanelAddProfqualif.Visible = false;
                        ArrayList objProfCertList = new ArrayList();
                        int empID = ee;
                        objProfCertList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID);

                        if (objProfCertList.Count > 0)
                        {
                            GViewEmpCert1.Visible = true;
                            GViewEmpCert1.DataSource = objProfCertList;
                            GViewEmpCert1.DataBind();
                            LbProfQualifSave1.Visible = true;
                            LbProfQualifSave1.Text = "Error! Professional Qualification not added.";
                        }
                    }
                }

            }
            catch
            {

            }
        }


        protected void GViewEmpCert_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {

                new EmployeeDocumentTableController().Delete(Convert.ToInt32(e.CommandArgument));

                int Empnum = CurrentEmployeeDetail.EmployeeID;


                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new EmployeeProfQualificationTableController()).GetByEmployeeDetails(Empnum);

                if (ObjArrQualification.Count != 0)
                {
                    GViewEmpCert.DataSource = (ObjArrQualification);
                    GViewEmpCert.DataBind();
                    int count = 0;
                    count += 1;

                    lbEmpProfQualifiDeleted.Text = "You have deleted" + count + "ProfQualification(s)";
                    lbEmpProfQualifiDeleted.Visible = true;

                }
            }
        }


        #endregion


        //Employee Document section

        #region

        //protected void docViewSaveBtn_Click(object sender, EventArgs e)
        //{
        //    // Loading documents from applicantDocumentTable

        //    int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //    int empID = CurrentEmployeeDetail.EmployeeID;
        //    int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
        //    ArrayList objDocList = new ArrayList();
        //    objDocList = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);

        //    if (objDocList.Count > 0)
        //    {

        //        GViewDoc.Visible = true;
        //        GViewDoc.DataSource = objDocList;
        //        GViewDoc.DataBind();
        //        docVSaveBtn.Visible = true;
        //    }

        //}
        ////saving document for the first time
        //protected void docVSaveBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //  ArrayList ObjArr = new ArrayList();
        //        foreach (GridViewRow g1 in GViewDoc.Rows)
        //        {

        //            int empuser = CurrentEmployeeDetail.EmployeeUserID_FK;


        //            // declare a variable as textbox
        //            TextBox b = new TextBox();
        //            // find the textbox containing the applicantID on the gridview 
        //            b = (TextBox)g1.FindControl("txtdocAppID");
        //            string appid = b.Text;


        //            EmployeeDocumentTableInfo objEmpDoc = new EmployeeDocumentTableInfo();
        //            objEmpDoc.DocumentType = g1.Cells[0].Text;
        //            objEmpDoc.DocumentPath = g1.Cells[1].Text;
        //            objEmpDoc.ApplicantID_FK = Convert.ToInt32(appid);
        //            int empDocID = (new EmployeeDocumentTableController()).Add(objEmpDoc);

        //            EmployeeDocumentTableInfo objDocEmpID = new EmployeeDocumentTableInfo();
        //            int empUser = CurrentEmployeeDetail.EmployeeUserID_FK;
        //            //int profQualfID = objProfQualifEmpID.ProfQualificationID;
        //            int app = CurrentEmployeeDetail.ApplicantID_FK;
        //            objDocEmpID.ApplicantID_FK = Convert.ToInt32(appid);
        //            objDocEmpID.EmployeeID_Fk = CurrentEmployeeDetail.EmployeeID;
        //            (new EmployeeDocumentTableController()).DocumentTableEmpIDUpdate(objDocEmpID);

        //            if (objDocEmpID.ApplicantID_FK == app)
        //            {

        //                LbProfQualifAdded.Visible = true;
        //                LbProfQualifAdded.Text =  "Documents Added Successfully";
        //            }
        //            else
        //            {
        //                LbProfQualifAdded.Text = " Error! Document not added.";
        //            }

        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        protected void docAddMoreBtn_Click(object sender, EventArgs e)
        {

            PanelAddMoreDocument.Visible = true;
        }

        //Add new document
        protected void docAddBtn_Click(object sender, EventArgs e)
        {
            string DocName = docFileUpload.FileName.ToString();
            string folder = "~/documents/";
            string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();
            docFileUpload.SaveAs(DocPath + "/" + DocName);
            int empID = CurrentEmployeeDetail.EmployeeID;

            int applicantID = CurrentEmployeeDetail.ApplicantID_FK;
            

            EmployeeDocumentTableInfo objGetLog = new EmployeeDocumentTableInfo();
            int emp = CurrentEmployeeDetail.EmployeeID;
            objGetLog = (new EmployeeDocumentTableController()).GetByEmployeeDetailsForInfo(emp);
            int emLg = objGetLog.EmployeeLogID_FK;




            //foreach (GridViewRow x in GViewEmpDoc.Rows)
            //{
            //    // declare a variable as textbox
            //    TextBox b = new TextBox();
            //    TextBox c = new TextBox();
            //    // find the textbox containing the applicantID on the gridview 
            //    b = (TextBox)x.FindControl("txtDocuAppID");
            //    c = (TextBox)x.FindControl("txtDocuEmpID");
            //    string appid = b.Text;
            //    string empid = c.Text;
            // }


            ArrayList objArr = new ArrayList();
            if (GViewEmpDoc.Rows.Count > 0)
            {
                for (int i = 0; i < GViewEmpDoc.Rows.Count; i++)
                {

                    EmployeeDocumentTableInfo objDoc = new EmployeeDocumentTableInfo();
                    objDoc.DocumentType = GViewEmpDoc.Rows[i].Cells[0].Text.ToString();
                    objDoc.DocumentPath = GViewEmpDoc.Rows[i].Cells[1].Text.ToString();
                    objDoc.ApplicantID_FK = Convert.ToInt32(applicantID);
                    objDoc.EmployeeID_Fk = Convert.ToInt32(empID);
                    objDoc.EmployeeLogID_FK = emLg;
                    objArr.Add(objDoc);
                }
            }
            EmployeeDocumentTableInfo objDoc2 = new EmployeeDocumentTableInfo();
            objDoc2.DocumentType = ddlDocumentTpe.SelectedItem.Text;
            objDoc2.DocumentPath = (DocPath + "\\" + DocName);
            objDoc2.ApplicantID_FK = Convert.ToInt32(applicantID);
            objDoc2.EmployeeID_Fk = Convert.ToInt32(empID);
            objDoc2.EmployeeLogID_FK = emLg;
            objArr.Add(objDoc2);
            GViewEmpDoc.DataSource = objArr;
            GViewEmpDoc.DataBind();
            GViewEmpDoc.Visible = true;
            docSaveBtn.Visible = true;

        }

        protected void docSaveBtn_Click(object sender, EventArgs e)
        {

            try
            {


                //ArrayList objDocArr = new ArrayList();
                //objDocArr = (new EmployeeDocumentTableController()).GetByEmployeeDetails(applicantID);

                //if (objDocArr.Count > 0)
                //    foreach (EmployeeDocumentTableInfo Obj in objDocArr)
                //    {

                //        int docID = Obj.DocumentID;
                //        (new EmployeeDocumentTableController()).Delete(docID);
                //    }

                int applicantID = CurrentEmployeeDetail.ApplicantID_FK;


                ArrayList ObjArr = new ArrayList();

                foreach (GridViewRow g1 in GViewEmpDoc.Rows)
                {
                    // declare a variable as textbox
                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    TextBox c = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    a = (TextBox)g1.FindControl("txtDocuAppID");
                    b = (TextBox)g1.FindControl("txtDocuEmpID");
                   c = (TextBox)g1.FindControl("txtDocuEmpLogID");

                    string appid = a.Text;
                    string emd = b.Text;
                    string empLog = c.Text;

                    EmployeeDocumentTableInfo objDocInfo = new EmployeeDocumentTableInfo();
                    objDocInfo.DocumentType = g1.Cells[0].Text;
                    objDocInfo.DocumentPath = g1.Cells[1].Text;
                    objDocInfo.ApplicantID_FK = Convert.ToInt32(appid);
                    objDocInfo.EmployeeID_Fk = Convert.ToInt32(emd);
                    objDocInfo.EmployeeID_Fk = Convert.ToInt32(empLog);
                    // ObjArr.Add(objDocInfo);
                    int DocID = (new EmployeeDocumentTableController()).NewAdd(objDocInfo);

                    EmployeeDocumentTableInfo objDocInfos = new EmployeeDocumentTableInfo();
                    int ee = CurrentEmployeeDetail.EmployeeID;
                    objDocInfos = (new EmployeeDocumentTableController()).Get(ee);

                    if (DocID > 0)
                    {
                        int count = 0;
                        count += 1;
                        LbDocumentSave.Visible = true;
                        LbDocumentSave.Text = count + " " + "Document(s) uploaded  successfully";
                        PanelAddMoreDocument.Visible = false;
                        LbDocumentSave1.Visible = true;
                        LbDocumentSave1.Text = count + " " + "Document(s) uploaded  successfully";

                        ArrayList objDocList = new ArrayList();
                        int empID = CurrentEmployeeDetail.EmployeeID;
                        objDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID);

                        if (objDocList.Count > 0)
                        {
                            GViewEmpDoc1.Visible = true;
                            GViewEmpDoc1.DataSource = objDocList;
                            GViewEmpDoc1.DataBind();

                        }
                    }
                    else
                    {
                        LbDocumentSave.Visible = true;
                        LbDocumentSave.Text = "Error! Documents not uploaded";

                        PanelAddMoreDocument.Visible = false;
                        LbDocumentSave1.Visible = true;
                        LbDocumentSave1.Text = "Error! Documents not uploaded";

                        ArrayList objDocList = new ArrayList();
                        int empID = CurrentEmployeeDetail.EmployeeID;
                        objDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID);

                        if (objDocList.Count > 0)
                        {
                            GViewEmpDoc1.Visible = true;
                            GViewEmpDoc1.DataSource = objDocList;
                            GViewEmpDoc1.DataBind();

                        }
                    }
                }
            }
            catch { }
        }



        //protected void GViewDoc_RowCommand(object sender, GridViewCommandEventArgs e)
        //{

        //    if (e.CommandName == "Delete")
        //    {

        //        new EmployeeDocumentTableController().Delete(Convert.ToInt32(e.CommandArgument));

        //        int Empnum = CurrentEmployeeDetail.EmployeeID;


        //        ArrayList ObjArrQualification = new ArrayList();
        //        ObjArrQualification = (new EmployeeDocumentTableController()).GetByEmployeeDetails(Empnum);
        //        if (ObjArrQualification.Count != 0)
        //        {
        //            GViewDoc.DataSource = (ObjArrQualification);
        //            GViewDoc.DataBind();

        //        }



        //    }
        //}
        protected void GViewEmpDoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                //Alert.Show("You are about deleting a document! Note: This cannot be retrieved after deletion");

                new EmployeeDocumentTableController().Delete(Convert.ToInt32(e.CommandArgument));

                int Empnum = CurrentEmployeeDetail.EmployeeID;


                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new EmployeeDocumentTableController()).GetByEmployeeDetails(Empnum);
                if (ObjArrQualification.Count != 0)
                {
                    GViewEmpDoc.DataSource = (ObjArrQualification);
                    GViewEmpDoc.DataBind();
                    int count = 0;
                    count += 1;

                    lbEmpDocDeleted.Text = "You have deleted" + count + "Document(s)";
                    lbEmpDocDeleted.Visible = true;

                }
                //  Alert.Show("You save successfully Deleted the Document");

                //Alert.Show("You save successfully applied for the post of " + lblPositionAppliedFor.Text + " your application number is: " + lblApplicantNum.Text);

                //string msg = "You are inserting duplicate values  ";
                //msg += ex.Message;
                //Alert.Show(msg);
                //// Alert.Show("You are inserting duplicate values");
            }
        }
        #endregion



        //Transfer Module

        #region
    
        #region "TransferHistory"
        protected void LinkBtnTransferHistory_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 15;

            ArrayList objArrTransferHistory = new ArrayList();

            ArrayList objTransferID = new ArrayList();
            int empids = CurrentEmployeeDetail.EmployeeID;

            objTransferID = (new EmployeeTransferTableLogController()).LogListByEmployeeDetails(empids);

            if (objTransferID.Count > 0)
            {
                foreach (EmployeeTransferTableLogInfo objTransferHist in objTransferID)
                {

                    EmployeeTransferTableLogInfo objTranInfo = new EmployeeTransferTableLogInfo();

                    objTranInfo.EmployeeNum = objTransferHist.EmployeeNum;
                    objTranInfo.PreviousDept = objTransferHist.PreviousDept;
                    objTranInfo.PrevWorkLocation = objTransferHist.PrevWorkLocation;
                    objTranInfo.DesireLocation = objTransferHist.DesireLocation;
                    objTranInfo.NewWorkLcation = objTransferHist.NewWorkLcation;
                    objTranInfo.PreviousDept = objTransferHist.PreviousDept;
                    objTranInfo.NewDept = objTransferHist.NewDept;
                    objTranInfo.TransferType = objTransferHist.TransferType;
                    objTranInfo.TransferReason = objTransferHist.TransferReason;
                    objTranInfo.RequestDate = objTransferHist.RequestDate;
                    objTranInfo.ApprovalStatus = objTransferHist.ApprovalStatus;
                    objTranInfo.ApproveDate = objTransferHist.ApproveDate;
                    objTranInfo.EmployeeID_FK = objTransferHist.EmployeeID_FK;
                    objTranInfo.TransferID_FK = objTransferHist.TransferID_FK;
                    objTranInfo.TransferLogID = objTransferHist.TransferLogID;
                    objTranInfo.TransferedBy = objTransferHist.TransferedBy;
                    objTranInfo.TransferDate = objTransferHist.TransferDate;

                    EmployeeTransferTableLogInfo objNewTransInfo = new EmployeeTransferTableLogInfo();
                    objNewTransInfo = (new EmployeeTransferTableLogController()).LogListEmployeeTransferRecords(objTranInfo);
                    if (objNewTransInfo != null)
                        objArrTransferHistory.Add(objNewTransInfo);

                }
                GViewTransHistory.DataSource = objArrTransferHistory;
                GViewTransHistory.DataBind();
                GViewTransHistory.Visible = true;
            }
        }

        #endregion

        #region "SendTranferRequest"
        protected void RequestBtn_Click(object sender, EventArgs e)
        {

            // first check if the employee has previously been transferred before
            EmployeeTransferTableInfo objGetTransferForCheck = new EmployeeTransferTableInfo();
            int TranEmp = CurrentEmployeeDetail.EmployeeID;
            objGetTransferForCheck = (new EmployeeTransferTableController()).GetByEmployeeDetailsForInfo(TranEmp);

           // if (objGetTransferForCheck == null)
            try
            {
                EmployeeTransferTableInfo objTransferReq = new EmployeeTransferTableInfo();

                objTransferReq.PrevWorkLocation = CurrentEmployeeDetail.WorkLocation_FK;
                objTransferReq.DesireLocation = Convert.ToInt32(transferNewWokLocList.SelectedValue);                
                objTransferReq.PreviousDept = CurrentEmployeeDetail.Department_FK;
                objTransferReq.NewDept = CurrentEmployeeDetail.Department_FK;
                objTransferReq.TransferType = transferTypeList.SelectedItem.Text.Trim();
                objTransferReq.TransferReason = txtTransferReason.Text.Trim();
                objTransferReq.RequestDate = LbRequestDate.Text.Trim();
                objTransferReq.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

                int TransferID = (new EmployeeTransferTableController()).RequestAdd(objTransferReq);

                if (TransferID > 0)
                {

                    //KeepingLog

                    EmployeeTransferTableLogInfo objTransferReqLog = new EmployeeTransferTableLogInfo();

                    objTransferReqLog.PrevWorkLocation = CurrentEmployeeDetail.WorkLocation_FK;
                    objTransferReqLog.DesireLocation = Convert.ToInt32(transferNewWokLocList.SelectedValue);
                    objTransferReqLog.PreviousDept = CurrentEmployeeDetail.Department_FK;
                    objTransferReqLog.NewDept = CurrentEmployeeDetail.Department_FK;
                    objTransferReqLog.TransferType = transferTypeList.SelectedItem.Text.Trim();
                    objTransferReqLog.TransferReason = txtTransferReason.Text.Trim();
                    objTransferReqLog.RequestDate = LbRequestDate.Text.Trim();
                    objTransferReqLog.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
                    objTransferReqLog.TransferID_FK = TransferID;

                    int TransferLogID = (new EmployeeTransferTableLogController()).LogRequestAdd(objTransferReqLog);

                    if (TransferID > 0 && TransferLogID > 0)
                    {
                        LbTransferSuccessful.Text = "Transfer Request Successfull Sent";
                        LbTransferSuccessful.Visible = true;
                        PanelTransfer.Visible = false;
                        btnTransferFinish.Visible = true;
                        btnTransferTryAgain.Visible = false;
                        LbTransferSuccessful1.Text = "Transfer Request Successfull Sent";
                        LbTransferSuccessful1.Visible = true;
                    }

                    else
                    {
                        LbTransferSuccessful.Text = "Transfer Request Not Sent";
                        LbTransferSuccessful.Visible = true;
                        PanelTransfer.Visible = false;
                        btnTransferFinish.Visible = false;
                        btnTransferTryAgain.Visible = true;
                        LbTransferSuccessful1.Text = "Transfer Request Not Sent";
                        LbTransferSuccessful1.Visible = true;
                    }
                }


            }

            catch (Exception ex)

            {
                LbTransferSuccessful.Text = "Transfer Request Not Sent";
                LbTransferSuccessful.Visible = true;
                PanelTransfer.Visible = false;
                btnTransferFinish.Visible = false;
                btnTransferTryAgain.Visible = true;
                LbTransferSuccessful1.Text = "Transfer Request Not Sent";
                LbTransferSuccessful1.Visible = true;

            }

            //#region "Update"
            //else
            //{


            //    try
            //    {
            //        EmployeeTransferTableInfo objGetTransfer = new EmployeeTransferTableInfo();
            //        objGetTransfer = (new EmployeeTransferTableController()).GetByEmployeeDetailsForInfo(CurrentEmployeeDetail.EmployeeID);
            //        string rd = objGetTransfer.RequestDate;

            //        EmployeeTransferTableInfo objTransferReq = new EmployeeTransferTableInfo();

            //        objTransferReq.PrevWorkLocation = CurrentEmployeeDetail.WorkLocation_FK;
            //        objTransferReq.DesireLocation = Convert.ToInt32(transferNewWokLocList.SelectedValue);
            //        objTransferReq.PreviousDept = CurrentEmployeeDetail.Department_FK;
            //        objTransferReq.NewDept = CurrentEmployeeDetail.Department_FK;
            //        objTransferReq.TransferType = transferTypeList.SelectedItem.Text.Trim();
            //        objTransferReq.TransferReason = txtTransferReason.Text.Trim();
            //        objTransferReq.RequestDate = LbRequestDate.Text.Trim();
            //        objTransferReq.TransferID = objGetTransfer.TransferID;
            //        objTransferReq.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

            //        (new EmployeeTransferTableController()).UpdateTransferRequest(objTransferReq);



            //        //KeepingLog
            //        EmployeeTransferTableInfo objGetTransfer2 = new EmployeeTransferTableInfo();
            //        objGetTransfer2 = (new EmployeeTransferTableController()).GetByEmployeeDetailsForInfo(CurrentEmployeeDetail.EmployeeID);

            //        EmployeeTransferTableLogInfo objTransferReqLog = new EmployeeTransferTableLogInfo();

            //        objTransferReqLog.PrevWorkLocation = CurrentEmployeeDetail.WorkLocation_FK;
            //        objTransferReqLog.DesireLocation = Convert.ToInt32(transferNewWokLocList.SelectedValue);
            //        objTransferReqLog.PreviousDept = CurrentEmployeeDetail.Department_FK;
            //        objTransferReqLog.NewDept = CurrentEmployeeDetail.Department_FK;
            //        objTransferReqLog.TransferType = transferTypeList.SelectedItem.Text.Trim();
            //        objTransferReqLog.TransferReason = txtTransferReason.Text.Trim();
            //        objTransferReqLog.RequestDate = LbRequestDate.Text.Trim();
            //        objTransferReqLog.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
            //        objTransferReqLog.TransferID_FK = objGetTransfer2.TransferID;

            //        int TransferLogID = (new EmployeeTransferTableLogController()).LogRequestAdd(objTransferReqLog);

            //        if ((objGetTransfer2.DesireLocation == Convert.ToInt32(transferNewWokLocList.SelectedValue)) && (objGetTransfer.RequestDate == LbRequestDate.Text) && (TransferLogID > 0))
            //        {
            //            LbTransferSuccessful.Text = "Transfer Request Successfull Sent";
            //            LbTransferSuccessful.Visible = true;
            //            PanelTransfer.Visible = false;
            //            btnTransferFinish.Visible = true;
            //            btnTransferTryAgain.Visible = false;
            //            LbTransferSuccessful1.Text = "Transfer Request Successfull Sent";
            //            LbTransferSuccessful1.Visible = true;
            //        }

            //        else
            //        {
            //            LbTransferSuccessful.Text = "Transfer Request Not Sent";
            //            LbTransferSuccessful.Visible = true;
            //            PanelTransfer.Visible = false;
            //            btnTransferFinish.Visible = false;
            //            btnTransferTryAgain.Visible = true;
            //            LbTransferSuccessful1.Text = "Transfer Request Not Sent";
            //            LbTransferSuccessful1.Visible = true;
            //        }



            //    }

            //    catch (Exception ex)
            //    {
            //        LbTransferSuccessful.Text = "Transfer Request Not Sent";
            //        LbTransferSuccessful.Visible = true;
            //        PanelTransfer.Visible = false;
            //        btnTransferFinish.Visible = false;
            //        btnTransferTryAgain.Visible = true;
            //        LbTransferSuccessful1.Text = "Transfer Request Not Sent";
            //        LbTransferSuccessful1.Visible = true;

            //    }
            //}
            //#endregion

        }
#endregion

        #region "Buttons and indexes"
        protected void tranferMenuBtn_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 14;
            PanelTransfer.Visible = false;
            LbTransferSuccessful1.Visible = false;
            LbTransferSuccessful.Visible = false;
        }

      
        protected void btnTransferTryAgain_Click(object sender, EventArgs e)
        {
            PanelTransfer.Visible = true;
            LbTransferSuccessful1.Visible = false;
            LbTransferSuccessful.Visible = false;
        }
        protected void btnTransferFinish_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }
        protected void LinkBtnRequestTransfer_Click(object sender, EventArgs e)
        {
            PanelTransfer.Visible = true;
            LbTransferSuccessful1.Visible = false;
            LbTransferSuccessful.Visible = false;

            EmployeeDepartmentTableInfo objEmpDept = new EmployeeDepartmentTableInfo();
            int depID = CurrentEmployeeDetail.Department_FK;
            objEmpDept = (new EmployeeDepartmentTableController()).Get(depID);

            EmployeeWorkLocationsInfo objEmpWok = new EmployeeWorkLocationsInfo();
            int wokID = CurrentEmployeeDetail.WorkLocation_FK;
            objEmpWok = (new EmployeeWorkLocationsController()).Get(wokID);

            LbTransferPreWorkLoc.Text = objEmpWok.LocationName + ", " + objEmpWok.LocationAddress;
            LbTransferPreWorkLoc.Visible = true;
            LbTransferPreDept.Text = objEmpDept.DeptName;
            LbTransferPreDept.Visible = true;

            string mydate2 = DateTime.Now.ToShortDateString();
            LbRequestDate.Text = mydate2;
            LbRequestDate.Visible = true;
        }

        #endregion

        #endregion


        //AppraisalModule

        #region

        #region "Indexes"
        protected void appraisalYearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSelfAssessment.Visible = true;
        }
        protected void btnAppraisalFinish_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }
        protected void btnAppraisaTryAgain_Click(object sender, EventArgs e)
        {
            conpetencyNextBtn1.Visible = false;
            LbSuccess1.Visible = false;
            PanelNewAppraisal.Visible = true;

        }
        protected void viewPreYrGoalBtn_Click(object sender, EventArgs e)
        {

            PanelPreYearGoal.Visible = true;
            GViewPreYearGoalList.Visible = true;
        }
        protected void AddNxtYrGoalBtn_Click(object sender, EventArgs e)
        {
            PanelNextYearGoal.Visible = true;
        }

        #endregion

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
           // int TotalPoint = summation();


            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int TotalPoint = qua;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
        }

        protected void ProductivityRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objProductRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating2 = Convert.ToInt32(ProductivityRatingKey.SelectedValue);
            objProductRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating2);
            txtProductivityRatingPoint.Text = objProductRatingPoint.RatingPoint.ToString();
          //  int TotalPoint = summation();


           // int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
           // int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
           // int TotalPoint = qua + prod;
          //  txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";


            //txtTotalPoint.Text = txtTotalPoint.Text + txtProductivityRatingPoint.Text;
        }
        protected void knowledgeRatingKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeAppraisalTableRatingKeyInfo objKnowledgeRatingPoint = new EmployeeAppraisalTableRatingKeyInfo();
            int rating3 = Convert.ToInt32(knowledgeRatingKey.SelectedValue);
            objKnowledgeRatingPoint = (new EmployeeAppraisalTableRatingKeyController()).Get(rating3);
            txtKnowledgeRatingPoint.Text = objKnowledgeRatingPoint.RatingPoint.ToString();
           // int TotalPoint = summation();

            //int qua = Convert.ToInt32(txtQualityRatingPoint.Text);
            //int prod = Convert.ToInt32(txtProductivityRatingPoint.Text);
            //int know = Convert.ToInt32(txtKnowledgeRatingPoint.Text);

            //int TotalPoint = qua + prod + know;
            //txtTotalPoint.Text = TotalPoint.ToString();

            //float percent = TotalPoint * 100 / 140;
            //txtAppraisalpercentage.Text = percent.ToString() + "%";
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
            LbPoint.Visible = true;
            txtAppraisalpercentage.Visible = true;
            float percent = TotalPoint * 100 / 140;
            txtAppraisalpercentage.Text = percent.ToString() + "%";

            competencySaveBtn.Visible = true;
            conpetencyNextBtn.Visible = true;
        }
        #endregion

        #region "CompetencyShow"
        protected void CompetencyShowBtn_Click(object sender, EventArgs e)
        {
          
            string sh = CompetencyShowBtn.Text.ToLower();

            if (sh == "show")
            {
                PanelCompetentShow.Visible = true;
                CompetencyShowBtn.Text = "hide";

            }
            else
            {
                PanelCompetentShow.Visible = false;
                CompetencyShowBtn.Text = "show";

            }
        }
        #endregion

        #region "Saving competency"
        protected void competencySaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int AppraisalID = Convert.ToInt32(ViewState["AppraisalID"]);
                //int EmployeeID_FK = Convert.ToInt32(ViewState("EmployeeID_FK"));

                EmployeeAppraisalTableInfo objAppriasalInfo = new EmployeeAppraisalTableInfo();

                objAppriasalInfo.EmployeeNum = CurrentEmployeeDetail.EmployeeNum;
                objAppriasalInfo.TotalPoint = this.txtTotalPoint.Text.Trim();
                objAppriasalInfo.EvaPeriod = this.evaluationPeriodList.SelectedItem.Text.Trim();
                objAppriasalInfo.AprpraisalStartYear = this.appraisalYearList.Text.Trim();
                objAppriasalInfo.AppraisalStatus = "1";
                objAppriasalInfo.EmpAppraisalDate = this.LbEmpAppraisalDate.Text.Trim();
                objAppriasalInfo.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
               // objAppriasalInfo.SupervisorID_FK = CurrentEmployeeDetail.SupervisorID;
               // objAppriasalInfo.HRID_FK = CurrentEmployeeDetail.HRID;

                AppraisalID = (new EmployeeAppraisalTableController()).EmpAdd(objAppriasalInfo);
                ViewState.Add("AppraisalID", AppraisalID);

                EmployeeAppraisalTableInfo objAppriasalInfo2 = new EmployeeAppraisalTableInfo();
                int appraise = AppraisalID;
                objAppriasalInfo2 = (new EmployeeAppraisalTableController()).Get(appraise);



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
                objCompetent.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
                objCompetent.SupervisorID_FK = CurrentEmployeeDetail.SupervisorID;
                objCompetent.HRID_FK = CurrentEmployeeDetail.HRID;
                objCompetent.AppraisalID_FK = appraise;

                int CompetencyID = (new EmployeeAppraisalCompetencyTableController()).Add(objCompetent);

                EmployeeAppraisalCompetencyTableInfo objCompetent2 = new EmployeeAppraisalCompetencyTableInfo();
                int compt = CompetencyID;
                objCompetent2 = (new EmployeeAppraisalCompetencyTableController()).Get(compt);

                EmployeeAppraisalTableInfo ObjAppraisal2 = new EmployeeAppraisalTableInfo();
                ObjAppraisal2.AppraisalID = objCompetent2.AppraisalID_FK;

                //Calculating Appraisal score
                int point = objCompetent2.OverallPoint;
                float appraisa = point * 100 / 140;
                ObjAppraisal2.AppraisalScore = Convert.ToInt32(appraisa);
                (new EmployeeAppraisalTableController()).AppraisalScoreUpdate(ObjAppraisal2);


                EmployeeAppraisalTableInfo ObjAppraisal3 = new EmployeeAppraisalTableInfo();
                int apraise3 = ObjAppraisal2.AppraisalID;
                ObjAppraisal3 = (new EmployeeAppraisalTableController()).Get(apraise3);



                //Keeping log
                EmployeeAppraisalTableLogInfo objAppriasalLogInfo = new EmployeeAppraisalTableLogInfo();

                objAppriasalLogInfo.EmployeeNum = CurrentEmployeeDetail.EmployeeNum;
                objAppriasalLogInfo.AppraisalScore = ObjAppraisal3.AppraisalScore;
                objAppriasalLogInfo.TotalPoint = this.txtTotalPoint.Text.Trim();
                objAppriasalLogInfo.EvaPeriod = this.evaluationPeriodList.SelectedItem.Text.Trim();
                objAppriasalLogInfo.AprpraisalStartYear = this.appraisalYearList.Text.Trim();
                objAppriasalLogInfo.AppraisalStatus = "1";
                objAppriasalLogInfo.EmpAppraisalDate = this.LbEmpAppraisalDate.Text.Trim();
                objAppriasalLogInfo.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
               // objAppriasalLogInfo.SupervisorID_FK = CurrentEmployeeDetail.SupervisorID;
               // objAppriasalLogInfo.HRID_FK = CurrentEmployeeDetail.HRID;
                objAppriasalLogInfo.AppraisalID_FK = appraise;
                objAppriasalLogInfo.SentBy = 1;

                int AppraisalLogID = (new EmployeeAppraisalTableLogController()).LogEmpAdd(objAppriasalLogInfo);
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
                objCompetentLog.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
                objCompetentLog.SupervisorID_FK = CurrentEmployeeDetail.SupervisorID;
                objCompetentLog.HRID_FK = CurrentEmployeeDetail.HRID;
                objCompetentLog.AppraisalID_FK = appraise;
                objCompetentLog.CompetencyID_FK = objCompetent2.CompetencyID;
                objCompetentLog.SentBy = 1;

                int CompetencyLogID = (new EmployeeAppraisalCompetencyTableLogController()).Add(objCompetentLog);

                if (AppraisalID > 0 && AppraisalLogID > 0 && CompetencyID > 0 && CompetencyLogID > 0)
                {
                    LbSuccess.Text = "Details Saved, Click Next button to add your goals for next year";
                    LbSuccess.Visible = true;
                    PanelNewAppraisal.Visible = false;
                    LbSuccess1.Text = "Details Saved, Click Next button to add your goals for next year";
                    LbSuccess1.Visible = true;
                    conpetencyNextBtn1.Visible = true;


                }
                else
                {

                    LbSuccess.Text = "Details Not Saved";
                    LbSuccess.Visible = true;
                    PanelNewAppraisal.Visible = false;
                    LbSuccess1.Text = "Details Not Saved";
                    LbSuccess1.Visible = true;
                    conpetencyNextBtn1.Visible = false;
                }



            }

            catch
            {

            }
        }

        #endregion

        

        #region "AddingGoals"
        protected void goalAddBtn_Click(object sender, EventArgs e)
        {
            int AppraisalID = Convert.ToInt32(ViewState["AppraisalID"]);
            PanelNextYearGoal.Visible = true;

            int EmpID = CurrentEmployeeDetail.EmployeeID;
            int SupID = CurrentEmployeeDetail.SupervisorID;
            int HRID = CurrentEmployeeDetail.HRID;
            ArrayList objArr = new ArrayList();

            if (GViewNextYearGoalList.Rows.Count > 0)
            {
                for (int i = 0; i < GViewNextYearGoalList.Rows.Count; i++)
                {
                    EmployeeApprasalTableGoalInfo objGoal = new EmployeeApprasalTableGoalInfo();
                    objGoal.GoalDesc = GViewNextYearGoalList.Rows[i].Cells[0].Text.ToString();
                    objGoal.GoalObjectives = GViewNextYearGoalList.Rows[i].Cells[1].Text.ToString();
                    objGoal.GoalEvaPoint = Convert.ToInt32(GViewNextYearGoalList.Rows[i].Cells[2].Text.ToString());
                    objGoal.GoalCompletetiondate = GViewNextYearGoalList.Rows[i].Cells[3].Text.ToString();
                    objGoal.EmployeeID_FK = EmpID;
                    objGoal.SupervisorID_FK = SupID;
                    objGoal.HRID_FK = HRID;
                    objGoal.AppraisalID_FK = AppraisalID;

                    objArr.Add(objGoal);

                }
            }

            EmployeeApprasalTableGoalInfo objGoal2 = new EmployeeApprasalTableGoalInfo();
            objGoal2.GoalDesc = this.txtNxtYearGoalDesc.Text.Trim();
            objGoal2.GoalObjectives = this.txtNxtYearGoalObjective.Text.Trim();
            objGoal2.GoalEvaPoint = Convert.ToInt32(this.txtEvalPoint.Text.Trim());
            objGoal2.EmployeeID_FK = EmpID;
            objGoal2.SupervisorID_FK = SupID;
            objGoal2.HRID_FK = HRID;
            objGoal2.AppraisalID_FK = AppraisalID;
            objGoal2.GoalCompletetiondate = this.goalNxtYrDayList.SelectedItem.Text.Trim() + "-" + goalNxtYrMonthList.SelectedItem.Text.Trim() + "-" + goalNxtYrYearList.SelectedItem.Text.Trim();

            objArr.Add(objGoal2);
            GViewNextYearGoalList.DataSource = objArr;
            GViewNextYearGoalList.DataBind();
            GViewNextYearGoalList.Visible = true;
            goalsaveBtn.Visible = true;
            goalBackBtn.Visible = true;
            goalFinishBtn.Visible = true;
            //refereshGoalPage();



           // Keeping GoalLog

            ArrayList objArr2 = new ArrayList();
            int AppraisalLogID = Convert.ToInt32(ViewState["AppraisalLogID"]);
            int AppraisalID2 = Convert.ToInt32(ViewState["AppraisalID"]);
            
            if (GViewNextGoalLog.Rows.Count > 0)
            {
                for (int i = 0; i < GViewNextGoalLog.Rows.Count; i++)
                {
                    EmployeeApprasalTableGoalLogInfo objGoalLog = new EmployeeApprasalTableGoalLogInfo();
                    objGoalLog.GoalDesc = GViewNextGoalLog.Rows[i].Cells[0].Text.ToString();
                    objGoalLog.GoalObjectives = GViewNextGoalLog.Rows[i].Cells[1].Text.ToString();
                    objGoalLog.GoalEvaPoint = Convert.ToInt32(GViewNextGoalLog.Rows[i].Cells[2].Text.ToString());
                    objGoalLog.GoalCompletetiondate = GViewNextGoalLog.Rows[i].Cells[3].Text.ToString();
                    objGoalLog.SentBy = Convert.ToInt32(GViewNextGoalLog.Rows[i].Cells[4].Text.ToString());
                    objGoalLog.EmployeeID_FK = EmpID;
                    objGoalLog.SupervisorID_FK = SupID;
                    objGoalLog.HRID_FK = HRID;
                    objGoalLog.AppraisalID_FK = AppraisalID2;

                    objArr2.Add(objGoalLog);

                }
            }

            EmployeeApprasalTableGoalLogInfo objGoalLog2 = new EmployeeApprasalTableGoalLogInfo();
            objGoalLog2.GoalDesc = this.txtNxtYearGoalDesc.Text.Trim();
            objGoalLog2.GoalObjectives = this.txtNxtYearGoalObjective.Text.Trim();
            objGoalLog2.GoalEvaPoint = Convert.ToInt32(this.txtEvalPoint.Text.Trim());
            objGoalLog2.SentBy = 1;
            objGoalLog2.EmployeeID_FK = EmpID;
            objGoalLog2.SupervisorID_FK = SupID;
            objGoalLog2.HRID_FK = HRID;
            objGoalLog2.AppraisalID_FK = AppraisalID2;
           // objGoalLog2.GoalID_FK = GoalID;
            objGoalLog2.GoalCompletetiondate = this.goalNxtYrDayList.SelectedItem.Text.Trim() + "-" + goalNxtYrMonthList.SelectedItem.Text.Trim() + "-" + goalNxtYrYearList.SelectedItem.Text.Trim();

            objArr2.Add(objGoalLog2);
            GViewNextGoalLog.DataSource = objArr2;
            GViewNextGoalLog.DataBind();
            GViewNextGoalLog.Visible = false;
           refereshGoalPage();


        }


        private void refereshGoalPage()
        {
            this.txtNxtYearGoalDesc.Text = "";
            this.txtNxtYearGoalObjective.Text = "";
            this.txtEvalPoint.Text = "";
            goalNxtYrDayList.ClearSelection();
            goalNxtYrMonthList.ClearSelection();
            goalNxtYrYearList.ClearSelection();

        }

        #endregion


        #region " Saving Goals"
        protected void goalsaveBtn_Click(object sender, EventArgs e)
       {
           try
           {
               EmployeeAppraisalTableInfo objAppr2 = new EmployeeAppraisalTableInfo();

             int AppraisalID = Convert.ToInt32(ViewState["AppraisalID"]);
           ArrayList ObjArr = new ArrayList();
           foreach (GridViewRow g1 in GViewNextYearGoalList.Rows)
           {
               EmployeeApprasalTableGoalInfo objGoalInfo = new EmployeeApprasalTableGoalInfo();
               objGoalInfo.GoalDesc = g1.Cells[0].Text;
               objGoalInfo.GoalObjectives = g1.Cells[1].Text;
               objGoalInfo.GoalEvaPoint = Convert.ToInt32(g1.Cells[2].Text);
               objGoalInfo.GoalCompletetiondate = g1.Cells[3].Text;
               objGoalInfo.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
               objGoalInfo.SupervisorID_FK = CurrentEmployeeDetail.SupervisorID;
               objGoalInfo.HRID_FK = CurrentEmployeeDetail.HRID;
               objGoalInfo.AppraisalID_FK = AppraisalID;

               int GoalID = (new EmployeeApprasalTableGoalController()).Add(objGoalInfo);
               ViewState.Add("GoalID", GoalID);

               if (GoalID > 0 )
               {
                   LbGoalAdded.Text = "Next year Goals  have been successfully saved ";
                   LbGoalAdded.Visible = true;
               }
               else
               {
                   LbGoalAdded.Text = "Next year Goals  Not saved ";
                   LbGoalAdded.Visible = true;
               }

           }
                   
                    ArrayList ObjArr2 = new ArrayList();
                    int AppraisalLogID = Convert.ToInt32(ViewState["AppraisalLogID"]);
                    int AppraisalID2 = Convert.ToInt32(ViewState["AppraisalID"]);
                foreach (GridViewRow g2 in GViewNextGoalLog.Rows)
                {
                   EmployeeApprasalTableGoalInfo objGoal3 = new EmployeeApprasalTableGoalInfo();
                    int GoalID = Convert.ToInt32(ViewState["GoalID"]);
                    objGoal3 = (new EmployeeApprasalTableGoalController()).Get(GoalID);


                    EmployeeApprasalTableGoalLogInfo objGoalLogInfo = new EmployeeApprasalTableGoalLogInfo();
                    objGoalLogInfo.GoalDesc = g2.Cells[0].Text;
                    objGoalLogInfo.GoalObjectives = g2.Cells[1].Text;
                    objGoalLogInfo.GoalEvaPoint = Convert.ToInt32(g2.Cells[2].Text);
                    objGoalLogInfo.GoalCompletetiondate = g2.Cells[3].Text;
                    objGoalLogInfo.SentBy = Convert.ToInt32(g2.Cells[4].Text);
                    objGoalLogInfo.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
                    objGoalLogInfo.SupervisorID_FK = CurrentEmployeeDetail.SupervisorID;
                    objGoalLogInfo.HRID_FK = CurrentEmployeeDetail.HRID;
                    objGoalLogInfo.AppraisalID_FK = AppraisalID2;
                   // objGoalLogInfo.GoalID_FK = GoalID;

                    int GoalLogID = (new EmployeeApprasalTableGoalLogController()).Add(objGoalLogInfo);

                    //Updating GoldID_FK

                   EmployeeApprasalTableGoalLogInfo objUpdateGoalID = new EmployeeApprasalTableGoalLogInfo();
                  // int GoldID = Convert.ToInt32(ViewState["GoalLogID"]);
                   objUpdateGoalID.GoalID_FK = GoalID;
                    objUpdateGoalID.GoalLogID = GoalLogID;

                    (new EmployeeApprasalTableGoalLogController()).GoalIDUpdate(objUpdateGoalID);


                    if (GoalLogID > 0)
                    {
                        LbGoalLog.Text = "Next year Goals  have been successfully saved ";
                        LbGoalLog.Visible = false;
                    }
                    else
                    {
                        LbGoalLog.Text = "Next year Goals  Not saved ";
                        LbGoalLog.Visible = false;
                    }            
       }

                
                     
           }

  catch{}  
}
        #endregion


        #endregion


        // Leave Module


        #region 


        protected void grantLeaveBtn_Click(object sender, EventArgs e)
        {
            int employeeID = CurrentEmployeeDetail.EmployeeID;
            string dept = CurrentEmployeeDetail.DeptName;



            // first check if the employee has previously applied for leave
            EmployeeLeaveTableInfo objEmployeeLeave = new EmployeeLeaveTableInfo();
            objEmployeeLeave = (new EmployeeLeaveTableController()).GetForAnEmployee(employeeID);
            if (objEmployeeLeave == null)
            {
                try
                {
                    // that is has not applied for leave before

                    // number of leave an employee is entitle depend on his level
                    // get the levelId of the current employee
                    // then use it to get his leave entitle from the level table

                    EmployeeLevelInfo objLevel = new EmployeeLevelInfo();
                    objLevel = (new EmployeeLevelController()).Get(CurrentEmployeeDetail.EmployeeLevel_FK);
                    int LeaveEntitle = Convert.ToInt32(objLevel.LeaveEntitle);
                    int leaveDuration = Convert.ToInt32(txtLeaveDuration.Text);

                    // LeaveThreshold is the number of leave left

                    int leaveThreshold = LeaveEntitle - leaveDuration;
                    EmployeeLeaveTableInfo objEmpLeave = new EmployeeLeaveTableInfo();

                    objEmpLeave.Duration = txtLeaveDuration.Text;
                    objEmpLeave.LeaveThresholdBeforeApplication = LeaveEntitle.ToString();
                    objEmpLeave.LeaveThreshold = leaveThreshold.ToString();
                    objEmpLeave.DateApplied = DateTime.Now.ToString();
                    objEmpLeave.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                    objEmpLeave.LeaveDescription = txtLeaveDesc.Text;
                    objEmpLeave.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                    objEmpLeave.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                    objEmpLeave.LevelID_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                    objEmpLeave.Dept_FK = CurrentEmployeeDetail.Department_FK;
                    objEmpLeave.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;
                    // save the info in leave table                                        
                    int leaveID = (new EmployeeLeaveTableController()).AddLeaveApplication(objEmpLeave);

                    if (leaveID > 0)
                    {

                        // also save the info in leave log table

                        EmployeeLeaveTableLogInfo objEmpLeaveLog = new EmployeeLeaveTableLogInfo();
                        objEmpLeaveLog.LeaveID_FK = leaveID;
                        objEmpLeaveLog.Duration = txtLeaveDuration.Text;
                        objEmpLeaveLog.LeaveThresholdBeforeApplication = LeaveEntitle.ToString();
                        objEmpLeaveLog.LeaveThreshold = leaveThreshold.ToString();
                        objEmpLeaveLog.DateApplied = DateTime.Now.ToString();
                        objEmpLeaveLog.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                        objEmpLeaveLog.LeaveDescription = txtLeaveDesc.Text;
                        objEmpLeaveLog.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                        objEmpLeaveLog.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                        objEmpLeaveLog.Level_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                        objEmpLeaveLog.Dept_FK = CurrentEmployeeDetail.Department_FK;
                        objEmpLeaveLog.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

                        int leaveLogID = (new EmployeeLeaveTableLogController()).AddLeaveApplication(objEmpLeaveLog);
                        if (leaveLogID > 0)
                        {
                            PanelLeaveDetails.Visible = false;
                            lblLeaveMessage1.Text = "Leave Request sent successfully";
                            lblLeaveMessage1.Visible = true;
                            
                        }
                        else
                        {
                            PanelLeaveDetails.Visible = false;
                            lblLeaveMessage1.Text = "Leave Request Fail";
                            lblLeaveMessage1.Visible = true;
                            
                        }


                    }
                    else
                    {
                        PanelLeaveDetails.Visible = false;
                        lblLeaveMessage1.Text = "Leave Request Fail";
                        lblLeaveMessage1.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    lblLeaveMessage1.Text = ex.Message;
                }

            }
            else
            {
                try
                { 
                    // has applied before
                    int leavethreshold = Convert.ToInt32(objEmployeeLeave.LeaveThreshold);


                    int leaveDuration = Convert.ToInt32(txtLeaveDuration.Text);
                    int NewleaveThreshold = leavethreshold - leaveDuration;
                    EmployeeLeaveTableInfo objEmpLeave = new EmployeeLeaveTableInfo();

                    objEmpLeave.Duration = txtLeaveDuration.Text;
                    objEmpLeave.LeaveThresholdBeforeApplication = leavethreshold.ToString();
                    objEmpLeave.LeaveThreshold = NewleaveThreshold.ToString();                  
                    objEmpLeave.DateApplied = DateTime.Now.ToString();
                    objEmpLeave.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                    objEmpLeave.LeaveDescription = txtLeaveDesc.Text;
                    objEmpLeave.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                    objEmpLeave.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                    objEmpLeave.LevelID_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                    objEmpLeave.Dept_FK = CurrentEmployeeDetail.Department_FK;
                    objEmpLeave.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

                    // update the leave table

                    new EmployeeLeaveTableController().UpdateLeaveApplication(objEmpLeave);
                    // save in leave log table
                    // first get the leave id from leave table
                    EmployeeLeaveTableInfo objLeave = new EmployeeLeaveTableInfo();
                    objLeave = (new EmployeeLeaveTableController()).GetForAnEmployee(employeeID);

                    EmployeeLeaveTableLogInfo objEmpLeaveLog = new EmployeeLeaveTableLogInfo();
                    objEmpLeaveLog.LeaveID_FK = objLeave.LeaveID;
                    objEmpLeaveLog.Duration = txtLeaveDuration.Text;
                    objEmpLeaveLog.LeaveThresholdBeforeApplication = leavethreshold.ToString();
                    objEmpLeaveLog.LeaveThreshold = NewleaveThreshold.ToString();
                    objEmpLeaveLog.DateApplied = DateTime.Now.ToString();
                    objEmpLeaveLog.LeaveType_FK = Convert.ToInt32(leaveTypeList.SelectedValue);
                    objEmpLeaveLog.LeaveDescription = txtLeaveDesc.Text;
                    objEmpLeaveLog.StartDate = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
                    objEmpLeaveLog.EndDate = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
                    objEmpLeaveLog.Level_FK = CurrentEmployeeDetail.EmployeeLevel_FK;
                    objEmpLeaveLog.Dept_FK = CurrentEmployeeDetail.Department_FK;
                    objEmpLeaveLog.EmployeeID_FK = CurrentEmployeeDetail.EmployeeID;

                    int leaveLogID = (new EmployeeLeaveTableLogController()).AddLeaveApplication(objEmpLeaveLog);
                    if (leaveLogID > 0)
                    {
                        lblLeaveMessage.Text = "Leave Request sent successfully";
                        PanelLeaveDetails.Visible = false;                      
                        lblLeaveMessage1.Visible = true;
                    }
                    else
                    {
                        PanelLeaveDetails.Visible = false;
                        lblLeaveMessage1.Text = "Leave Request Fail";
                        lblLeaveMessage1.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    lblLeaveMessage1.Text = ex.Message;
                }

                // lblLeaveMessage.Text = "has  applied";
            }

        }


        protected void leaveStartYearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLeaveSDate.Text = leaveStartDayList.SelectedItem + "-" + leaveStartMonthList.SelectedItem + "-" + leaveStartYearList.SelectedItem;
       
        }

        protected void LeaveEndYearList_SelectedIndexChanged(object sender, EventArgs e)
        {

             // first check if the employee has previously applied for leave
                int employeeID = CurrentEmployeeDetail.EmployeeID;
                EmployeeLeaveTableInfo objEmployeeLeave = new EmployeeLeaveTableInfo();
                objEmployeeLeave = (new EmployeeLeaveTableController()).GetForAnEmployee(employeeID);

                if (objEmployeeLeave == null)
                {
                    int LeaveEntitle = Convert.ToInt32(lblLeave.Text);

            lbLeaveEDate.Text = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;
            

            DateTime sDate = DateTime.Parse(lbLeaveSDate.Text);
            DateTime eDate = DateTime.Parse(lbLeaveEDate.Text);

            DateTime firstDay = sDate.Date;
            DateTime lastDay = eDate.Date;
            int workingDays;

            if (firstDay > lastDay)
            {
                throw new ArgumentException("Incorrect last day " + lastDay);
            }

            else
            {
              
                TimeSpan span = lastDay - firstDay;
                workingDays = span.Days + 1;
                int fullWeekCount = workingDays / 7;

                // find out if there are weekends during the time exceedng the full weeks
                if (workingDays > fullWeekCount * 7)
                {
                    // we are here to find out if there is a 1-day or 2-days weekend
                    // in the time interval remaining after subtracting the complete weeks

                    int firstDayOfWeek = firstDay.DayOfWeek == DayOfWeek.Sunday
                     ? 7 : (int)firstDay.DayOfWeek;
                    int lastDayOfWeek = lastDay.DayOfWeek == DayOfWeek.Saturday
                        ? 7 : (int)lastDay.DayOfWeek;

                    // int firstDayOfWeek = (int) firstDay.DayOfWeek;
                    // int lastDayOfWeek = (int) lastDay.DayOfWeek;

                    if (lastDayOfWeek < firstDayOfWeek)
                        lastDayOfWeek += 7;
                    if (firstDayOfWeek <= 6)
                    {
                        if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                            workingDays -= 2;
                        else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                            workingDays -= 1;
                    }
                    else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                        workingDays -= 1;
                }

                // subtract the weekends during the full weeks in the interval
                workingDays -= fullWeekCount + fullWeekCount;       
               
                txtLeaveDuration.Text = workingDays.ToString();
              
                int leaveDuration = Convert.ToInt32(txtLeaveDuration.Text);
                int leaveThreshold = LeaveEntitle - leaveDuration;
                lblLeaveThreshold.Text = leaveThreshold.ToString();
                lblLeaveThreshold.Visible = true;
            
            }

                }

                else
                {
                    int LeaveEntitle = Convert.ToInt32(objEmployeeLeave.LeaveThreshold);

                    lbLeaveEDate.Text = LeaveEndDayList.SelectedItem + "-" + LeaveEndMonthList.SelectedItem + "-" + LeaveEndYearList.SelectedItem;


                    DateTime sDate = DateTime.Parse(lbLeaveSDate.Text);
                    DateTime eDate = DateTime.Parse(lbLeaveEDate.Text);

                    DateTime firstDay = sDate.Date;
                    DateTime lastDay = eDate.Date;
                    int workingDays;

                    if (firstDay > lastDay)
                    {
                        throw new ArgumentException("Incorrect last day " + lastDay);
                    }

                    else
                    {

                        TimeSpan span = lastDay - firstDay;
                        workingDays = span.Days + 1;
                        int fullWeekCount = workingDays / 7;

                        // find out if there are weekends during the time exceedng the full weeks
                        if (workingDays > fullWeekCount * 7)
                        {
                            // we are here to find out if there is a 1-day or 2-days weekend
                            // in the time interval remaining after subtracting the complete weeks

                            int firstDayOfWeek = firstDay.DayOfWeek == DayOfWeek.Sunday
                             ? 7 : (int)firstDay.DayOfWeek;
                            int lastDayOfWeek = lastDay.DayOfWeek == DayOfWeek.Saturday
                                ? 7 : (int)lastDay.DayOfWeek;

                            // int firstDayOfWeek = (int) firstDay.DayOfWeek;
                            // int lastDayOfWeek = (int) lastDay.DayOfWeek;

                            if (lastDayOfWeek < firstDayOfWeek)
                                lastDayOfWeek += 7;
                            if (firstDayOfWeek <= 6)
                            {
                                if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                                    workingDays -= 2;
                                else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                                    workingDays -= 1;
                            }
                            else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                                workingDays -= 1;
                        }

                        // subtract the weekends during the full weeks in the interval
                        workingDays -= fullWeekCount + fullWeekCount;

                        txtLeaveDuration.Text = workingDays.ToString();

                        int leaveDuration = Convert.ToInt32(txtLeaveDuration.Text);
                        int leaveThreshold = LeaveEntitle - leaveDuration;
                        lblLeaveThreshold.Text = leaveThreshold.ToString();
                        lblLeaveThreshold.Visible = true;

                    }
                }
                
        }

        protected void txtLeaveDuration_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void btnMakeRequest_Click(object sender, EventArgs e)
        {
            PanelLeaveDetails.Visible = true;
            GVLeave.Visible = false;
            lblLeaveMessage1.Visible = false;
        }
        protected void btnViewLeave_Click(object sender, EventArgs e)
        {
            PanelLeaveDetails.Visible = false;
            lblLeaveMessage1.Visible = false;
              int employeeID = CurrentEmployeeDetail.EmployeeID;
            ArrayList objLeave = new ArrayList();
            objLeave = (new EmployeeLeaveTableController()).GetByEmployeeDetails(employeeID);
            if (objLeave.Count > 0)
            {
                GVLeave.DataSource = objLeave;
                GVLeave.DataBind();
                GVLeave.Visible = true;
            }

            else
            {
                lbNoLeaveRecord.Visible = true;
                lbNoLeaveRecord.Text = "You have not applied for any leave";
            }
        }


        #endregion



        //Query Module

        #region

        protected void btnQueryFinish_Click(object sender, EventArgs e)
        {
            MViewEmployee.ActiveViewIndex = 0;
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Reply")
            {

                EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
                objQuery = (new EmployeeQueryTableController()).Get(Convert.ToInt32(e.CommandArgument));
                lblQueryEmployeeNum.Text = objQuery.EmployeeNum.ToString();
                lblQueryTitle.Text = objQuery.QueryTitle;
                lblQueryDescription.Text = objQuery.Description;
                lblQueryDate.Text = objQuery.IssueDate;
                lblQueryBy.Text = objQuery.QueryIssueByName.ToString();
                lblQueryletter.Text = objQuery.QueryLetter;
                lblQueryResponsedate.Text = DateTime.Now.ToString();
                string res = objQuery.EmployeeResponse;
                string dis = objQuery.DisciplineDetails;
                if (res.Length < 1 && dis.Length < 1)
                {
                    PanelResponse.Visible = true;
                }
                else
                {
                    PanelResponse.Visible = false;
                    lblResponseDetails.Text = objQuery.EmployeeResponse;
                    lblResponseDate.Text = objQuery.ResponseDate;
                    lblDisDetails.Text = objQuery.DisciplineDetails;
                    lblDisDate.Text = objQuery.DisciplineDate;
                    if (dis.Length > 1)
                    {
                        lblDisBy.Text = objQuery.QueryIssueByName.ToString();
                    }

                    PanelDiscipline.Visible = true;
                }
                int queryId = objQuery.QueryID;
                ViewState.Add("queryId", queryId);
                PanelQueryDetails.Visible = true;

            }
        }

        protected void btnSendQueryResponse_Click(object sender, EventArgs e)
        {
            int QueryID = Convert.ToInt32(ViewState["queryId"]);
            EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
            objQuery = (new EmployeeQueryTableController()).Get(QueryID);

            EmployeeQueryTableInfo objQueryResponse = new EmployeeQueryTableInfo();
            objQueryResponse.QueryID = QueryID;
            objQueryResponse.EmployeeResponse = txtQueryResponse.Text;
            objQueryResponse.ResponseDate = lblQueryResponsedate.Text;
            if (QueryResponseUpload1.HasFile)
            {
                string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();
                QueryResponseUpload1.SaveAs(filepath + "\\" + QueryResponseUpload1.FileName.ToString());
                objQueryResponse.EmployeeResponse = "~/QueryLetters/" + "/" + QueryResponseUpload1.FileName.ToString();
                

            }
            //objQueryResponse.ResponseDate = DateTime.Now.ToString();
            (new EmployeeQueryTableController()).UpdateQueryResponse(objQueryResponse);

            //Update QueryLog

            EmployeeQueryTableInfo objGetQuery = new EmployeeQueryTableInfo();
            objGetQuery = (new EmployeeQueryTableController()).Get(QueryID);

            EmployeeQueryTableLogInfo objGetQueryLog = new EmployeeQueryTableLogInfo();
            objGetQueryLog = (new EmployeeQueryTableLogController()).LogGetByEmpQuery(QueryID);

            EmployeeQueryTableLogInfo objQueryResponseLog = new EmployeeQueryTableLogInfo();
            objQueryResponseLog.QueryID_FK = QueryID;
            objQueryResponseLog.EmployeeResponse = txtQueryResponse.Text;
            objQueryResponseLog.ResponseDate = lblQueryResponsedate.Text;
            objQueryResponseLog.EmpResponseLetter = objGetQuery.EmpResponseLetter;
            objQueryResponseLog.QueryLogID = objGetQueryLog.QueryLogID;
            objQueryResponseLog.ResponseDate = objGetQueryLog.ResponseDate;
            (new EmployeeQueryTableLogController()).LogUpdateQueryResponse(objQueryResponseLog);

               EmployeeQueryTableLogInfo objGetQueryLog2 = new EmployeeQueryTableLogInfo();
            objGetQueryLog2 = (new EmployeeQueryTableLogController()).LogGetByEmpQuery(QueryID);

            if ((objGetQuery.ResponseDate != null) && (objGetQueryLog2.ResponseDate != null))
            {

                PanelQueryDetails.Visible = false;
                PanelDiscipline.Visible = false;
                PanelResponse.Visible = false;
                LbQueryResponseSent1.Text = "Your response to  the query title " + objQuery.QueryTitle + " has been sent successfuly";
                LbQueryResponseSent1.Visible = true;
                // string message = "Your response to  the query title " + objQuery.QueryTitle + " has been sent successfuly";
            }
            else
            {
                PanelQueryDetails.Visible = false;
                PanelDiscipline.Visible = false;
                PanelResponse.Visible = false;
                LbQueryResponseSent1.Text = "Your response to  the query title " + objQuery.QueryTitle + " Not sent successfuly";
                LbQueryResponseSent1.Visible = true;
            }
            }
        protected void btnCloseQueryResponse_Click(object sender, EventArgs e)
        {
            PanelQueryDetails.Visible = false;
        }

        #endregion


     
    
}
}


    



