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
using System.Web.Security;
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

using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Web.Script.Services;




using ola.HRMangmntSyst;


namespace ola.HRMangmntSyst
{
    public partial class HRPage : PortalModuleBase, IActionable
    {
        string passport;
        string filepath2;
        int applicantID;
        int employeeID;
        string employeeNum;
        int employeeUserID;
        string usernameid;
        string empUser;
        DataTable dt1 = new DataTable();
        bool flag = false;

        

        UserController objUserController = new UserController();

        RoleController objRoleController = new RoleController();
         
        

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


        public class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertMessage", "alert('+strMsg')", true);
            }

           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MViewHRPage.ActiveViewIndex = 0;

                this.DataBind();
               // BindTransferGView();
                                

                //loading applicantID
                #region

                ArrayList objApplID = new ArrayList();
                objApplID = (new ApplicantPersonalDetailsController()).AcceptanceAppList();

                if (objApplID.Count > 0)
                {
                    AcceptanceapplicantList.DataSource = objApplID;
                    AcceptanceapplicantList.DataTextField = "ApplicantNum";
                    AcceptanceapplicantList.DataValueField = "ApplicantID";
                    AcceptanceapplicantList.DataBind();
                }
                AcceptanceapplicantList.Items.Insert(0, new ListItem("***Please select", "-1"));

#endregion


            

                //Loading EmployeeID

                #region

                ArrayList objEmpIDList = new ArrayList();
                objEmpIDList = (new EmployeeDetailsController()).List();


                if (objEmpIDList.Count > 0)
                {

                    hrEmpProfileIDList.DataSource = objEmpIDList;
                    hrEmpProfileIDList.DataTextField = "EmployeeNum";
                    hrEmpProfileIDList.DataValueField = "EmployeeID";
                    hrEmpProfileIDList.DataBind();
                }
                hrEmpProfileIDList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                if (objEmpIDList.Count > 0)
                {
                    transferEmployeeList.DataSource = objEmpIDList;
                    transferEmployeeList.DataTextField = "EmployeeNum";
                    transferEmployeeList.DataValueField = "EmployeeID";
                    transferEmployeeList.DataBind();
                }
                transferEmployeeList.Items.Insert(0, new ListItem("***Please select", "-1"));


                ArrayList objEmpUnconfirmedList = new ArrayList();
                objEmpUnconfirmedList = (new EmployeeDetailsController()).UnconfirmedList();
                if (objEmpUnconfirmedList.Count > 0)
                {
                    confirmEmployeeList.DataSource = objEmpUnconfirmedList;
                    confirmEmployeeList.DataTextField = "EmployeeNum";
                    confirmEmployeeList.DataValueField = "EmployeeID";
                    confirmEmployeeList.DataBind();
                }
                confirmEmployeeList.Items.Insert(0, new ListItem("***Please select", "-1"));


                //Qualification

                ArrayList objHrApprove = new ArrayList();
                objHrApprove = (new EmployeeDetailsController()).QualifUnApprovedList();

                if (objHrApprove.Count > 0)
                {
                    hrUnApprovedQualifList.DataSource = objHrApprove;
                    hrUnApprovedQualifList.DataTextField = "EmployeeNum";
                    hrUnApprovedQualifList.DataValueField = "EmployeeID";
                    hrUnApprovedQualifList.DataBind();
                }

                //Certification

                ArrayList objProfQualifHrApprove = new ArrayList();
                objProfQualifHrApprove = (new EmployeeDetailsController()).ProfQualifUnApprovedList();

                if (objProfQualifHrApprove.Count > 0)
                {

                    hrUnApprovedCertList.DataSource = objProfQualifHrApprove;
                    hrUnApprovedCertList.DataTextField = "EmployeeNum";
                    hrUnApprovedCertList.DataValueField = "EmployeeID";
                    hrUnApprovedCertList.DataBind();
                }
                hrUnApprovedCertList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                //Document
                ArrayList objDocHrApprove = new ArrayList();
                objDocHrApprove = (new EmployeeDetailsController()).DocUnApprovedList();


                if (objDocHrApprove.Count > 0)
                {

                    hrUnApprovedDocList.DataSource = objDocHrApprove;
                    hrUnApprovedDocList.DataTextField = "EmployeeNum";
                    hrUnApprovedDocList.DataValueField = "EmployeeID";
                    hrUnApprovedDocList.DataBind();
                }
                hrUnApprovedDocList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                //Loading Employee for Appraisal

                ArrayList objAppraisalEmpIDList = new ArrayList();
                //int sup =
                objAppraisalEmpIDList = (new EmployeeDetailsController()).HRAppraisalList();


                if (objAppraisalEmpIDList.Count > 0)
                {

                    appraisalEmployeeList.DataSource = objAppraisalEmpIDList;
                    appraisalEmployeeList.DataTextField = "EmployeeNum";
                    appraisalEmployeeList.DataValueField = "EmployeeID";
                    appraisalEmployeeList.DataBind();
                }
                appraisalEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                //Employee Promotion list

                //ArrayList objEmpPromo = new ArrayList();
               // objEmpPromo = (new EmployeeDetailsController()).PromotionList();

                //if (objEmpPromo.Count > 0)
                //{

                //    PromoEmployeeList.DataSource = objEmpPromo;
                //    PromoEmployeeList.DataTextField = "EmployeeNum";
                //    PromoEmployeeList.DataValueField = "EmployeeID";
                //    PromoEmployeeList.DataBind();
                //}
                //PromoEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));

               


                #endregion

                // Loading Department

                #region
                //ArrayList objAppDept = new ArrayList();
                //objAppDept = (new ApplicantDepartmentTableController()).List();


                //if (objAppDept.Count > 0)
                //{
                //    AcceptanceDept.DataSource = objAppDept;
                //    AcceptanceDept.DataTextField = "DeptName";
                //    AcceptanceDept.DataValueField = "DeptID";
                //    AcceptanceDept.DataBind();

                //}
                //AcceptanceDept.Items.Insert(0, new ListItem("***Please select***", "-1"));

                ArrayList objEmpDept = new ArrayList();
                objEmpDept = (new EmployeeDepartmentTableController()).List();

                
                if (objEmpDept.Count > 0)
                {
                    assignHODDeptList.DataSource = objEmpDept;
                    assignHODDeptList.DataTextField = "DeptName";
                    assignHODDeptList.DataValueField = "DeptID";
                    assignHODDeptList.DataBind();

                }
                assignHODDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                if (objEmpDept.Count > 0)
                {

                    transferNewDeptList.DataSource = objEmpDept;
                    transferNewDeptList.DataTextField = "DeptName";
                    transferNewDeptList.DataValueField = "DeptID";
                    transferNewDeptList.DataBind();

                }
                transferNewDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                if (objEmpDept.Count > 0)
                {
                    trainingHRDeptList.DataSource = objEmpDept;
                    trainingHRDeptList.DataTextField = "DeptName";
                    trainingHRDeptList.DataValueField = "DeptID";
                    trainingHRDeptList.DataBind();

                }
                trainingHRDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                if (objEmpDept.Count > 0)
                {
                    PromoDepartmentList.DataSource = objEmpDept;
                    PromoDepartmentList.DataTextField = "DeptName";
                    PromoDepartmentList.DataValueField = "DeptID";
                    PromoDepartmentList.DataBind();
                }
                PromoDepartmentList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                PromoEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                if (objEmpDept.Count > 0)
                {
                    PromoNewDeptList.DataSource = objEmpDept;
                    PromoNewDeptList.DataTextField = "DeptName";
                    PromoNewDeptList.DataValueField = "DeptID";
                    PromoNewDeptList.DataBind();
                }
                PromoNewDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                if (objEmpDept.Count > 0)
                {
                    ddPromoHistDept.DataSource = objEmpDept;
                    ddPromoHistDept.DataTextField = "DeptName";
                    ddPromoHistDept.DataValueField = "DeptID";
                    ddPromoHistDept.DataBind();
                }
                ddPromoHistDept.Items.Insert(0, new ListItem("***Please select***", "-1"));
                ddPromoHistEmp.Items.Insert(0, new ListItem("***Please select***", "-1"));


                //Dept for Query

                if (objEmpDept.Count > 0)
                {

                    queryDeptList.DataSource = objEmpDept;
                    queryDeptList.DataTextField = "DeptName";
                    queryDeptList.DataValueField = "DeptID";
                    queryDeptList.DataBind();
                }
                queryDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));

                //Loading dept for Editing
                
                if (objEmpDept.Count > 0)
                {

                    ddEditEmpInfoDept.DataSource = objEmpDept;
                    ddEditEmpInfoDept.DataTextField = "DeptName";
                    ddEditEmpInfoDept.DataValueField = "DeptID";
                    ddEditEmpInfoDept.DataBind();
                }
                ddEditEmpInfoDept.Items.Insert(0, new ListItem("***Please select***", "-1"));

                if (objEmpDept.Count > 0)
                {

                    ddEditEmpInfoDept.DataSource = objEmpDept;
                    ddEditEmpInfoDept.DataTextField = "DeptName";
                    ddEditEmpInfoDept.DataValueField = "DeptID";
                    ddEditEmpInfoDept.DataBind();
                }
                ddEditEmpInfoDept.Items.Insert(0, new ListItem("***Please select***", "-1"));
                
                if (objEmpDept.Count > 0)
                {

                    ddEditSpouseDept.DataSource = objEmpDept;
                    ddEditSpouseDept.DataTextField = "DeptName";
                    ddEditSpouseDept.DataValueField = "DeptID";
                    ddEditSpouseDept.DataBind();
                }
                ddEditSpouseDept.Items.Insert(0, new ListItem("***Please select***", "-1"));

                
                if (objEmpDept.Count > 0)
                {
                    ddEditNOKDept.DataSource = objEmpDept;
                    ddEditNOKDept.DataTextField = "DeptName";
                    ddEditNOKDept.DataValueField = "DeptID";
                    ddEditNOKDept.DataBind();
                }
                ddEditNOKDept.Items.Insert(0, new ListItem("***Please select***", "-1"));


               // AccptPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));
#endregion

                //Load Level
                #region

                //ArrayList objPromoLevel = new ArrayList();
                //objPromoLevel = (new EmployeeLevelController()).List();

                //if (objPromoLevel.Count > 0)
                //{
                //    promoNewLevelList.DataSource = objPromoLevel;
                //    promoNewLevelList.DataTextField = "LevelName";
                //    promoNewLevelList.DataValueField = "LevelID";
                //    promoNewLevelList.DataBind();
                //}
                //promoNewLevelList.Items.Insert(0, new ListItem("***Please select", "-1"));


                //Loading Position

               

//                //if (objEmpLevel.Count > 0)
//                //{

//                //    AcceptanceLevelList.DataSource = objEmpLevel;
//                //    AcceptanceLevelList.DataTextField = "LevelName";
//                //    AcceptanceLevelList.DataValueField = "LevelID";
//                //    AcceptanceLevelList.DataBind();
//                //}
//                //AcceptanceLevelList.Items.Insert(0, new ListItem("***Please select", "-1"));

#endregion


                //Loading Working Location

                #region

                ArrayList objEmpWorkLocation = new ArrayList();
                objEmpWorkLocation = (new EmployeeWorkLocationsController()).List();

                if (objEmpWorkLocation.Count > 0)
                {
                    assignHODLocationList.DataSource = objEmpWorkLocation;
                    assignHODLocationList.DataTextField = "LocationName";
                    assignHODLocationList.DataValueField = "WorkLocationID";
                    assignHODLocationList.DataBind();
                }
                assignHODLocationList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                if (objEmpWorkLocation.Count > 0)
                {

                    transferNewWokLocList.DataSource = objEmpWorkLocation;
                    transferNewWokLocList.DataTextField = "LocationName";
                    transferNewWokLocList.DataValueField = "WorkLocationID";
                    transferNewWokLocList.DataBind();
                }
                transferNewWokLocList.Items.Insert(0, new ListItem("***Please select***", "-1"));




                #endregion


            }

            //Loading days

            #region

            if (IsPostBack) return;

            else
            {
                var days = new ArrayList();
                days.Add("*Day*");
                for (var i = 1; i <= 31; i++)
                {
                    days.Add(i);
                }


                ddSuspStartDay.DataSource = days;
                ddSuspStartDay.DataBind();

                ddSuspEndDay.DataSource = days;
                ddSuspEndDay.DataBind();

                promoDayList.DataSource = days;
                promoDayList.DataBind();


            }

            #endregion

            //Loading years DOB

            #region

            if (IsPostBack) return;
            else
            {
                var yrs = new ArrayList();
                yrs.Add("*Year*");
                for (var i = 2018; i >= 1900; i--)
                {
                    yrs.Add(i);
                }


                ddSuspStartYear.DataSource = yrs;
                ddSuspStartYear.DataBind();

                ddSuspEndYear.DataSource = yrs;
                ddSuspEndYear.DataBind();

                promoYearList.DataSource = yrs;
                promoYearList.DataBind();

                retireStartYearofService.DataSource = yrs;
                retireStartYearofService.DataBind();

                retireEndYearofService.DataSource = yrs;
                retireEndYearofService.DataBind();
            }
#endregion


        

        }
        protected void welHometBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
      
        protected void hrEmpAccptMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 1;
            btnaccptFinsh.Visible = false;
            btnaccptTryAgain.Visible = false;
            hrEmpProfilePanel.Visible = false;
        }

        protected void hrEmpMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 2;
        }
        protected void welEmplomentBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 3;
            refereshPageAssign();
            PanelAssignHOD1.Visible = true;
            GViewAssignHOD.Visible = false;
            btnAssignHODFinish.Visible = false;
            btnAssignHODTryAgain.Visible = false;
            LbHODUpdateSuccessful.Visible = false;
            LbHODUpdateSuccessful1.Visible = false;
            assignHODBtn.Visible = false;
            LbHODUpdateSuccessful1.Visible = false;
                       

        }
        protected void Approval_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 4;
        }

        protected void welConfirmBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 7;
            PanelConfirmation.Visible = false;
        }
        protected void trainingMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 8;
        }
        protected void welTransferBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 23;
        }
        protected void welLeave_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 10;

          //  MViewHRPage.ActiveViewIndex = 11;
            ArrayList objDept = new ArrayList();
            objDept = (new EmployeeDepartmentTableController()).List();
            if (objDept.Count > 0)
            {
                ddlLeaveDeptList.DataSource = objDept;
                ddlLeaveDeptList.DataTextField = "DeptName";
                ddlLeaveDeptList.DataValueField = "DeptID";
                ddlLeaveDeptList.DataBind();
                ddlLeaveDeptList.Items.Insert(0, new ListItem("---Please select", "-1"));

            }
            PanelLeaveRequestDetails.Visible = false;
            PanelLeaveApproval.Visible = false;
        }
        protected void welQuery_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 11;
            PanelQuery.Visible = false;
            lblDisciplineSuccessful.Visible = false;
            lblQueryIssueReport.Visible = false;


        }

        protected void welAppraisal_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 12;
        }
        protected void welPromotion_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 15;
        }
        protected void welPensionRetirement_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 16;
        }
        protected void welPrintAppraisa_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 17;
        }
        protected void appraisalHomeBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        

        protected void hrHomeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        protected void hrEmploymentLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 1;
        }


        protected void hrAcceptanceLinkButton_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 2;
        }
        protected void hrEmployeeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 3;
        }
        protected void hrConfirmationLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 7;
        }


        protected void hrTrainingLinkBtn0_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 8;
        }
        protected void hrTransferLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 9;
        }
        protected void hrLeaveLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 10;
        }
        protected void hrQueryLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 11;
        }

        protected void hrAppraisalLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 12;
        }
        protected void hrPromotionLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 13;
        }
        protected void hrRetirementLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 14;
        }


        protected void BioDataLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 2;
        }
        protected void qualifLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 3;
        }
        protected void certLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 4;
        }
        protected void docLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 5;
        }
        protected void refreeLinkBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 6;
        }

    
        protected void HREmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GViewCert.Visible = true;
        }
        protected void HRDocEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // GViewDoc.Visible = true;
        }
        
        protected void appraisalFinishBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
    
     
        protected void HRBiodataFinishBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        protected void QualifFinishBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }


        //Loading Position 

        #region

        //protected void HrSendOfferDeptList_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    ArrayList objEmpPosition = new ArrayList();
        //    int DeptID = Convert.ToInt32(HrSendOfferDeptList.SelectedValue);
        //    objEmpPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(DeptID);

        //    if (objEmpPosition.Count > 0)
        //    {
        //        approvedPositionList.DataSource = objEmpPosition;
        //        approvedPositionList.DataTextField = "PositionName";
        //        approvedPositionList.DataValueField = "PositionID";
        //        approvedPositionList.DataBind();

        //        approvedPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));

        //    }
           
           // ArrayList objEmpLevel = new ArrayList();
           //// objEmpPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(DeptID);
           // objEmpLevel = (new EmployeeLevelController()).GetByEmployeeDepartmentTable(DeptID);

           // if (objEmpLevel.Count > 0)
           // {
           //     hrSendOfferLevelList.DataSource = objEmpLevel;
           //     hrSendOfferLevelList.DataTextField = "LevelName";
           //     hrSendOfferLevelList.DataValueField = "LevelID";
           //     hrSendOfferLevelList.DataBind();
           // }
           // hrSendOfferLevelList.Items.Insert(0, new ListItem("***Please select", "-1"));

        //}

        //protected void AcceptanceDeptList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ArrayList objAcceptPosition = new ArrayList();
        //    int DeptID = Convert.ToInt32(AcceptanceDeptList.SelectedValue);
        //    objAcceptPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(DeptID);

        //    if (objAcceptPosition.Count > 0)
        //    {
        //        AccptPositionList.DataSource = objAcceptPosition;
        //        AccptPositionList.DataTextField = "PositionName";
        //        AccptPositionList.DataValueField = "PositionID";
        //        AccptPositionList.DataBind();

        //        AccptPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));

        //    }

        //}

        #endregion


        //    EmployeeAcceptance Module

        #region

        //Employment Acceptance Module

        #region
       
             
        protected void AcceptanceapplicantList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnaccptFinsh.Visible = false;
            btnaccptTryAgain.Visible = false;
            hrEmpProfilePanel.Visible = true;
            LbEmpDetailsAdded1.Visible = false;
            LbEmpIDgeneratedhere1.Visible = false;

            ApplicantPersonalDetailsInfo objAppDetailInfo = new ApplicantPersonalDetailsInfo();
            int ApplicantID = Convert.ToInt32(AcceptanceapplicantList.SelectedValue);
            objAppDetailInfo = (new ApplicantPersonalDetailsController()).Get(ApplicantID);

            EmployeeDepartmentTableInfo objEmpDeptInfo = new EmployeeDepartmentTableInfo();
            int DeptID = objAppDetailInfo.DepartmentID_FK;
            objEmpDeptInfo = (new EmployeeDepartmentTableController()).Get(DeptID);

            EmployeePositionTableInfo objEmpPositionInfo = new EmployeePositionTableInfo();
            int PositionID = objAppDetailInfo.PositionApproved_FK;           
            objEmpPositionInfo = (new EmployeePositionTableController()).Get(PositionID);

            EmployeeLevelInfo objEmpLevelInfo = new EmployeeLevelInfo();
            int LevelID = objAppDetailInfo.LevelID_FK;
            objEmpLevelInfo = (new EmployeeLevelController()).Get(LevelID);

            EmployeeWorkLocationsInfo objEmpWorkLocInfo = new EmployeeWorkLocationsInfo();
            int WorkLocationID = objAppDetailInfo.WorkLocationID_FK;
            objEmpWorkLocInfo = (new EmployeeWorkLocationsController()).Get(WorkLocationID);

            CountryTableInfo objAppCountryInfo = new CountryTableInfo();
            int countryID = objAppDetailInfo.Nationality_FK;
            objAppCountryInfo = (new CountryTableController()).Get(countryID);

            StateTableInfo objAppStateInfo = new StateTableInfo();
            int stateID = objAppDetailInfo.StateOfOrigin_FK;
            objAppStateInfo = (new StateTableController()).Get(stateID);

            SenatorialTableInfo objAppSenInfo = new SenatorialTableInfo();
            int senID = objAppDetailInfo.senID_FK;
            objAppSenInfo = (new SenatorialTableController()).Get(senID);

            LGATableInfo objAppLgaInfo = new LGATableInfo();
            int lgaID = objAppDetailInfo.LGA_FK;
            objAppLgaInfo = (new LGATableController()).Get(lgaID);


           LbempAccpTitle.Text = objAppDetailInfo.Title;
            LbEmpAccpFName.Text = objAppDetailInfo.FirstName;
            LbempAccpMName.Text = objAppDetailInfo.MiiddleName;
            LbEmpAccpLName.Text = objAppDetailInfo.LastName;
            LbEmpAccpEmail.Text = objAppDetailInfo.Email;
            LbempAccpPhnNo.Text = objAppDetailInfo.PhoneNo;
            LbEmpAccpHomeTown.Text = objAppDetailInfo.HomeTown;
            LbEmpAccpGender.Text = objAppDetailInfo.Gender;
            LbEmpAccpContAddr.Text = objAppDetailInfo.ContactAddress;
            LbEmpAccptReligion.Text = objAppDetailInfo.Religion;
            LbEmpAccpNationality.Text = objAppCountryInfo.CountryName;
            LbEmpAccptSenatorialDistrict.Text = objAppSenInfo.senName;
            LbEmpAccptState.Text = objAppStateInfo.StateName;
            LbEmpAccpLGA.Text = objAppLgaInfo.LgaName;
            LbEmpAccpDoB.Text = objAppDetailInfo.DateOfBirth;
            LbEmpAccptAge.Text = objAppDetailInfo.Age;
            LbempAccpMaritaStatus.Text = objAppDetailInfo.MaritalStatus;
            LbempAcceptanceDept.Text = objEmpDeptInfo.DeptName;
            LbempAccpPosition.Text = objEmpPositionInfo.PositionName;
            LbEmpAccptLevel.Text = objEmpLevelInfo.LevelName;
            LbAcceptanceSalary2.Text = objEmpLevelInfo.Salary;
            LbEmpAccptWorkLoc.Text = objEmpWorkLocInfo.LocationName;
            string myDate = DateTime.Now.ToShortDateString();  
            LbEmpAccptStartDate.Text = myDate;
            AcceptanceImagePassport.ImageUrl = "~/images/" + objAppDetailInfo.Passport.Substring(objAppDetailInfo.Passport.LastIndexOf('\\') + 1);

            //Qualification

          
            int applicantID_FK = objAppDetailInfo.ApplicantID;
            ArrayList objQaulifList = new ArrayList();
            objQaulifList = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID_FK);

            if (objQaulifList.Count > 0)
            {
                GViewQualification.Visible = true;
                GViewQualification.DataSource = objQaulifList;
                GViewQualification.DataBind();

            }

            //ProfQualification
           

            ArrayList objProfQaulifList = new ArrayList();

            objProfQaulifList = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID_FK);

            if (objProfQaulifList.Count > 0)
            {

                GViewCert.Visible = true;
                GViewCert.DataSource = objProfQaulifList;
                GViewCert.DataBind();
            }

            // Loading documents from applicantDocumentTable

            ArrayList objDocList = new ArrayList();
            objDocList = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID_FK);

            if (objDocList.Count > 0)
            {

                GViewDoc.Visible = true;
                GViewDoc.DataSource = objDocList;
                GViewDoc.DataBind();
                
            }

        }
        #endregion


      //Moving ApplicantDetails into EmployeeDetails
        
#region
        protected void AcceptEmploymentBtn_Click(object sender, EventArgs e)
        
        {

        
            try
            {
                ApplicantPersonalDetailsInfo objAcceptAppDetailInfo = new ApplicantPersonalDetailsInfo();
                int ApplicantID = Convert.ToInt32(AcceptanceapplicantList.SelectedValue);
                objAcceptAppDetailInfo = (new ApplicantPersonalDetailsController()).Get(ApplicantID);

                EmployeeDepartmentTableInfo objAccptDeptInfo = new EmployeeDepartmentTableInfo();
                int DeptID = objAcceptAppDetailInfo.DepartmentID_FK;
                objAccptDeptInfo = (new EmployeeDepartmentTableController()).Get(DeptID);
                
                EmployeePositionTableInfo objAccptPositionInfo = new EmployeePositionTableInfo();
                int PositionID = objAcceptAppDetailInfo.PositionApproved_FK;
                objAccptPositionInfo = (new EmployeePositionTableController()).Get(PositionID);
                
                EmployeeLevelInfo objAccptLevelInfo = new EmployeeLevelInfo();
                int LevelID = objAcceptAppDetailInfo.LevelID_FK;
                objAccptLevelInfo = (new EmployeeLevelController()).Get(LevelID);

                EmployeeWorkLocationsInfo objAccptWorkLocInfo = new EmployeeWorkLocationsInfo();
                int WorkLocationID = objAcceptAppDetailInfo.WorkLocationID_FK;
                objAccptWorkLocInfo = (new EmployeeWorkLocationsController()).Get(WorkLocationID);


                CountryTableInfo objEmpCountryInfo = new CountryTableInfo();
                int countryID = objAcceptAppDetailInfo.Nationality_FK;
                objEmpCountryInfo = (new CountryTableController()).Get(countryID);

                StateTableInfo objEmpStateInfo = new StateTableInfo();
                int stateID = objAcceptAppDetailInfo.StateOfOrigin_FK;
                objEmpStateInfo = (new StateTableController()).Get(stateID);
                
                SenatorialTableInfo objEmpSenInfo = new SenatorialTableInfo();
                int senID = objAcceptAppDetailInfo.senID_FK;
                objEmpSenInfo = (new SenatorialTableController()).Get(senID);

                LGATableInfo objEmpLgaInfo = new LGATableInfo();
                int lgaID = objAcceptAppDetailInfo.LGA_FK;
                objEmpLgaInfo = (new LGATableController()).Get(lgaID);

                UserInfo objEmpHR = new UserInfo();
                objEmpHR = (new UserController()).GetUser(0, UserId);
                int HR = objEmpHR.UserID;

               // LbempAccpPosition.Text = objAccptPositionInfo.PositionName;
                LbempAccpTitle.Text = objAcceptAppDetailInfo.Title;
                LbEmpAccpFName.Text = objAcceptAppDetailInfo.FirstName;
                LbempAccpMName.Text = objAcceptAppDetailInfo.MiiddleName;
                LbEmpAccpLName.Text = objAcceptAppDetailInfo.LastName;
                LbEmpAccpEmail.Text = objAcceptAppDetailInfo.Email;
                LbempAccpPhnNo.Text = objAcceptAppDetailInfo.PhoneNo;
                LbEmpAccpHomeTown.Text = objAcceptAppDetailInfo.HomeTown;
                LbEmpAccpGender.Text = objAcceptAppDetailInfo.Gender;
                LbEmpAccpContAddr.Text = objAcceptAppDetailInfo.ContactAddress;
                LbEmpAccptReligion.Text = objAcceptAppDetailInfo.Religion;
                LbEmpAccpNationality.Text = objEmpCountryInfo.CountryName;
                LbEmpAccptState.Text = objEmpStateInfo.StateName;
                LbEmpAccptSenatorialDistrict.Text = objEmpSenInfo.senName;
                LbEmpAccpLGA.Text = objEmpLgaInfo.LgaName;
                LbEmpAccpDoB.Text = objAcceptAppDetailInfo.DateOfBirth;
                LbEmpAccptAge.Text = objAcceptAppDetailInfo.Age;
                LbempAccpMaritaStatus.Text = objAcceptAppDetailInfo.MaritalStatus;
                LbempAcceptanceDept.Text = objAccptDeptInfo.DeptName;
                LbempAccpPosition.Text = objAccptPositionInfo.PositionName; 
                LbEmpAccptLevel.Text = objAccptLevelInfo.LevelName;
                LbEmpAccptWorkLoc.Text = objAccptWorkLocInfo.LocationName;
                string myDate = DateTime.Now.ToShortDateString();
                //int date1 =Convert.ToInt32(DateTime.Now.ToShortDateString());
                //int myDay = Convert.ToInt32(date1.Day);
                //in
                //LbSysDate.Text = myDate;    
                LbEmpAccptStartDate.Text = myDate;
                //.Text = DateTime.Now.ToString("DD-MM-YYYY");
                AcceptanceImagePassport.ImageUrl = "~/images/" + objAcceptAppDetailInfo.Passport.Substring(objAcceptAppDetailInfo.Passport.LastIndexOf('\\') + 1);


                //Saving into EmployeeDetails

                EmployeeDetailsInfo objEmpDetailsInfo = new EmployeeDetailsInfo();

                objEmpDetailsInfo.Title = this.LbempAccpTitle.Text.Trim();
                objEmpDetailsInfo.FirstName = this.LbEmpAccpFName.Text.Trim();
                objEmpDetailsInfo.MiiddleName = this.LbempAccpMName.Text.Trim();
                objEmpDetailsInfo.LastName = this.LbEmpAccpLName.Text.Trim();
                objEmpDetailsInfo.Email = this.LbEmpAccpEmail.Text.Trim();
                objEmpDetailsInfo.PhoneNo = this.LbempAccpPhnNo.Text.Trim();
                objEmpDetailsInfo.HomeTown = this.LbEmpAccpHomeTown.Text.Trim();
                objEmpDetailsInfo.Gender = this.LbEmpAccpGender.Text.Trim();
                objEmpDetailsInfo.MaritalStatus = this.LbempAccpMaritaStatus.Text.Trim();
                objEmpDetailsInfo.ContactAddress = this.LbEmpAccpContAddr.Text.Trim();
                objEmpDetailsInfo.Religion = this.LbEmpAccptReligion.Text.Trim();
                objEmpDetailsInfo.Nationality_FK = objAcceptAppDetailInfo.Nationality_FK;
                objEmpDetailsInfo.StateOfOrigin_FK = objAcceptAppDetailInfo.StateOfOrigin_FK;
                objEmpDetailsInfo.senID_FK = objAcceptAppDetailInfo.senID_FK;
                objEmpDetailsInfo.LGA_FK = objAcceptAppDetailInfo.LGA_FK;
                objEmpDetailsInfo.DateOfBirth = this.LbEmpAccpDoB.Text.Trim();
                objEmpDetailsInfo.Age = this.LbEmpAccptAge.Text.Trim();
                objEmpDetailsInfo.Department_FK = objAcceptAppDetailInfo.DepartmentID_FK;
                objEmpDetailsInfo.PositionHeld_FK = objAcceptAppDetailInfo.PositionApproved_FK;
                objEmpDetailsInfo.EmployeeLevel_FK = objAcceptAppDetailInfo.LevelID_FK;
                objEmpDetailsInfo.WorkLocation_FK = objAcceptAppDetailInfo.WorkLocationID_FK;
                objEmpDetailsInfo.StartDate = myDate;
                LbEmpAccptStartDate.Text = myDate;
                objEmpDetailsInfo.Passport = this.AcceptanceImagePassport.ImageUrl;
                objEmpDetailsInfo.ApplicantID_FK = Convert.ToInt32(this.AcceptanceapplicantList.SelectedValue);
                objEmpDetailsInfo.HRID = HR;
             
                employeeID = (new EmployeeDetailsController()).Add(objEmpDetailsInfo);
                
                string employeeid = employeeID.ToString();

                //Generating EmployeeNum
                string employeeNum = "NTL" + "/" + objEmpDetailsInfo.LastName + "/ " + DateTime.Now.ToString("yyyy") + "/" + employeeid;
               
                ViewState.Add("employeeID", employeeID);
                ViewState.Add("employeeNum", employeeNum);
                EmployeeDetailsInfo objEmpDetailsInfo2 = new EmployeeDetailsInfo();
                objEmpDetailsInfo2.EmployeeID = employeeID;
                objEmpDetailsInfo2.EmployeeNum = employeeNum;
                (new EmployeeDetailsController()).UpdateEmployeeNum(objEmpDetailsInfo2);

                //Calling CreateUser class
                int uid = CreateUser(employeeID, objEmpDetailsInfo.LastName, objEmpDetailsInfo.Email);
                
                if (uid > 0)
                {
                    UserInfo objuser = new UserInfo();
                    objuser=(new UserController()).GetUser(0, uid);

                    usernameid = objuser.Username;
                   
                }

                LbEmpIDgeneratedhere.Visible = true;
                LbEmpIDgeneratedhere.Text = "Your Login details are" + " " + "UserName= "+ usernameid + "," + " " + "Password= " + "password";
                 

                ViewState.Add("employeeID", employeeID);
                ViewState.Add("employeeUserID", employeeUserID);
                ViewState.Add("uid", uid);
                EmployeeDetailsInfo objEmpDetailsInfo3 = new EmployeeDetailsInfo();
                objEmpDetailsInfo3.EmployeeID = employeeID;
                objEmpDetailsInfo3.EmployeeUserID_FK = uid;

                (new EmployeeDetailsController()).UpdateEmployeeUserID(objEmpDetailsInfo3);

                EmployeeDetailsInfo objGetForLog = new EmployeeDetailsInfo();
                objGetForLog = (new EmployeeDetailsController()).Get(employeeID);

                //Saving EmployeeDetailsLog

                EmployeeDetailsLogInfo objEmpDetailsLogInfo = new EmployeeDetailsLogInfo();

                objEmpDetailsLogInfo.Title = this.LbempAccpTitle.Text.Trim();
                objEmpDetailsLogInfo.FirstName = this.LbEmpAccpFName.Text.Trim();
                objEmpDetailsLogInfo.MiiddleName = this.LbempAccpMName.Text.Trim();
                objEmpDetailsLogInfo.LastName = this.LbEmpAccpLName.Text.Trim();
                objEmpDetailsLogInfo.Email = this.LbEmpAccpEmail.Text.Trim();
                objEmpDetailsLogInfo.PhoneNo = this.LbempAccpPhnNo.Text.Trim();
                objEmpDetailsLogInfo.HomeTown = this.LbEmpAccpHomeTown.Text.Trim();
                objEmpDetailsLogInfo.Gender = this.LbEmpAccpGender.Text.Trim();
                objEmpDetailsLogInfo.MaritalStatus = this.LbempAccpMaritaStatus.Text.Trim();
                objEmpDetailsLogInfo.ContactAddress = this.LbEmpAccpContAddr.Text.Trim();
                objEmpDetailsLogInfo.Religion = this.LbEmpAccptReligion.Text.Trim();
                objEmpDetailsLogInfo.Nationality_FK = objAcceptAppDetailInfo.Nationality_FK;
                objEmpDetailsLogInfo.StateOfOrigin_FK = objAcceptAppDetailInfo.StateOfOrigin_FK;
                objEmpDetailsLogInfo.senID_FK = objAcceptAppDetailInfo.senID_FK;
                objEmpDetailsLogInfo.LGA_FK = objAcceptAppDetailInfo.LGA_FK;
                objEmpDetailsLogInfo.DateOfBirth = this.LbEmpAccpDoB.Text.Trim();
                objEmpDetailsLogInfo.Age = this.LbEmpAccptAge.Text.Trim();
                objEmpDetailsLogInfo.Department_FK = objAcceptAppDetailInfo.DepartmentID_FK;
                objEmpDetailsLogInfo.PositionHeld_FK = objAcceptAppDetailInfo.PositionApproved_FK;
                objEmpDetailsLogInfo.EmployeeLevel_FK = objAcceptAppDetailInfo.LevelID_FK;
                objEmpDetailsLogInfo.WorkLocation_FK = objAcceptAppDetailInfo.WorkLocationID_FK;
                objEmpDetailsLogInfo.StartDate = myDate;
                objEmpDetailsLogInfo.Passport = this.AcceptanceImagePassport.ImageUrl;
                objEmpDetailsLogInfo.ApplicantID_FK = Convert.ToInt32(this.AcceptanceapplicantList.SelectedValue);
                objEmpDetailsLogInfo.EmployeeNum = objGetForLog.EmployeeNum;
                objEmpDetailsLogInfo.EmployeeUserID_FK = objGetForLog.EmployeeUserID_FK;
                objEmpDetailsLogInfo.EmployeeID_FK = objGetForLog.EmployeeID;
                objEmpDetailsLogInfo.HRID = HR;

                int employeeLogID = (new EmployeeDetailsLogController()).LogAdd(objEmpDetailsLogInfo);
                ViewState.Add("employeeLogID", employeeLogID);

                EmployeeDetailsLogInfo objGetLog = new EmployeeDetailsLogInfo();
                objGetLog = (new EmployeeDetailsLogController()).LogGet(employeeLogID);

                //Saving Qualification
                EmployeeDetailsInfo objEmpDetailsInfo4 = new EmployeeDetailsInfo();
                int empi1 = employeeID;
               objEmpDetailsInfo4 = (new EmployeeDetailsController()).Get(empi1);
               int empi2 = employeeID;
               int appi2 = objEmpDetailsInfo4.ApplicantID_FK;
              
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewQualification.Rows)
                {

                    TextBox b = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    b = (TextBox)g1.FindControl("txtQualifViewAppID");
                    string appid = b.Text;


                    EmployeeQualificationTableInfo objEmpQualif = new EmployeeQualificationTableInfo();

                    objEmpQualif.InstitutionName = g1.Cells[0].Text;
                    objEmpQualif.QualificationType = g1.Cells[1].Text;
                    objEmpQualif.Course = g1.Cells[2].Text;
                    objEmpQualif.Grade = g1.Cells[3].Text;
                    objEmpQualif.StartYear = g1.Cells[4].Text;
                    objEmpQualif.EndYear = g1.Cells[5].Text;
                    objEmpQualif.ApplicantID_FK = Convert.ToInt32(appid);
                    int empQualificationID = (new EmployeeQualificationTableController()).Add(objEmpQualif);

                   
                    EmployeeQualificationTableInfo objQualifEmpID = new EmployeeQualificationTableInfo();

                    int empLogID = Convert.ToInt32(ViewState["employeeLogID"]);

                    objQualifEmpID.HrApproval = "Approved";
                    objQualifEmpID.ApplicantID_FK = appi2;
                    objQualifEmpID.EmployeeID_FK = empi2;
                    objQualifEmpID.EmployeeLogID_FK = empLogID;
                    (new EmployeeQualificationTableController()).QualificationTableEmpIDUpdate(objQualifEmpID);

                                     
                }

                //Saving ProfQualification

                ArrayList ObjProQArr = new ArrayList();
                foreach (GridViewRow x in GViewCert.Rows)
                {

                    // declare a variable as textbox
                    TextBox b = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    b = (TextBox)x.FindControl("txtCertAppID");
                    string appid = b.Text;

                    EmployeeProfQualificationTableInfo objEmpProfQualif = new EmployeeProfQualificationTableInfo();

                    objEmpProfQualif.CertificationName = x.Cells[0].Text;
                    objEmpProfQualif.CertificateNo = x.Cells[1].Text;
                    objEmpProfQualif.Stage = x.Cells[2].Text;
                    objEmpProfQualif.CertYear = x.Cells[3].Text;
                    objEmpProfQualif.ApplicantID_FK = Convert.ToInt32(appid);
                    //string appid= x.Cells[4].Text;

                    int empProQualifID = (new EmployeeProfQualificationTableController()).Add(objEmpProfQualif);

                    EmployeeProfQualificationTableInfo objProfQualifEmpID = new EmployeeProfQualificationTableInfo();
                    int empLogID = Convert.ToInt32(ViewState["employeeLogID"]);
                    objProfQualifEmpID.HrApproval = "Approved";
                    objProfQualifEmpID.ApplicantID_FK = appi2;
                    objProfQualifEmpID.employeeID_FK = empi2;
                    objProfQualifEmpID.EmployeeLogID_FK = empLogID;

                    (new EmployeeProfQualificationTableController()).ProfQualificationTableEmpIDUpdate(objProfQualifEmpID);

                }

                //Document

                foreach (GridViewRow g1 in GViewDoc.Rows)
                {
                    
                    // declare a variable as textbox
                    TextBox b = new TextBox();
                    // find the textbox containing the applicantID on the gridview 
                    b = (TextBox)g1.FindControl("txtdocAppID");
                    string appid = b.Text;


                    EmployeeDocumentTableInfo objEmpDoc = new EmployeeDocumentTableInfo();
                    objEmpDoc.DocumentType = g1.Cells[0].Text;
                    objEmpDoc.DocumentPath = g1.Cells[1].Text;
                    objEmpDoc.ApplicantID_FK = Convert.ToInt32(appid);
                    int empDocID = (new EmployeeDocumentTableController()).Add(objEmpDoc);

                    EmployeeDocumentTableInfo objDocEmpID = new EmployeeDocumentTableInfo();
                    int empLogID = Convert.ToInt32(ViewState["employeeLogID"]);
                    objDocEmpID.HrApproval = "Approved";
                    objDocEmpID.ApplicantID_FK = appi2;
                    objDocEmpID.EmployeeID_Fk = empi2;
                    objDocEmpID.EmployeeLogID_FK = empLogID;
                   
                   (new EmployeeDocumentTableController()).DocumentTableEmpIDUpdate(objDocEmpID);

                                  }

              
                if ((employeeID > 0) && (employeeLogID > 0))
                {
                    LbEmpDetailsAdded.Visible = true;
                    LbEmpDetailsAdded.Text = "Detial Successfully Added";
                    btnaccptFinsh.Visible = true;
                    btnaccptTryAgain.Visible = false;
                    hrEmpProfilePanel.Visible = false;
                    LbEmpDetailsAdded1.Visible = true;
                    LbEmpDetailsAdded1.Text = "Detial Successfully Added";                  
                    LbEmpIDgeneratedhere1.Visible = true;
                    LbEmpIDgeneratedhere1.Text = "Your Login details are" + " " + "UserName= " + usernameid + "," + " " + "Password= " + "password";
                  

                }
                else
                {
                    LbEmpDetailsAdded.Text = " Error! Details not added.";
                    btnaccptFinsh.Visible = false;
                    btnaccptTryAgain.Visible = true;
                    hrEmpProfilePanel.Visible = false;
                    LbEmpDetailsAdded1.Visible = true;
                    LbEmpDetailsAdded1.Text = "Error! Details not added.";
                    LbEmpIDgeneratedhere1.Visible = false;
                    LbEmpIDgeneratedhere1.Text = "Your Login details are" + " " + "UserName= " + usernameid + "," + " " + "Password= " + "password";
                  
                }

            }
        
        
        
            catch
            {

            }
        }

#endregion

      /// <summary>
      /// ////////////////////////
      /// </summary>
      /// <param name="Customerid"></param>
      /// <param name="uname"></param>
      /// <returns></returns>
        //Creating Users/////////////////////////////

        #region

        private int CreateUser(int EmployeeID, string LastName, string Email)
        {
            int uId = 0;
            try
            {

                PortalSecurity objSecurity = new PortalSecurity();
                ModuleController objModules = new ModuleController();

                EmployeeDetailsInfo objEmployeeInfo = new EmployeeDetailsInfo();
                EmployeeDetailsController objEmployeeController = new EmployeeDetailsController();

                objEmployeeInfo = (new EmployeeDetailsController()).Get(EmployeeID);
                string EmployeePassword = "password";
                string username = Email;// objCustomerInfo.EMAIL;

                //UserInfo objUserInfo = new UserInfo();
                //UserController objUserController = new UserController();

                UserInfo objUserInfo = this.objUserController.GetUserByUsername(PortalId, username);

                //erInfo objUserInfo = objUserController.GetUserByUsername(PortalId, username);
                //UserInfo objUserInfo = this.objUserController.GetUserByUsername(PortalId, username);
                if (objUserInfo != null)
                    return -1;

                objUserInfo = new UserInfo();
                objUserInfo.PortalID = PortalId;
                objUserInfo.Profile.FirstName = objEmployeeInfo.FirstName;
                objUserInfo.Profile.LastName = objEmployeeInfo.LastName;
                
                //objUserInfo.Membership.Email = objCustomerInfo.EMAIL;
                //objUserInfo.Membership.Username = username;
                objUserInfo.Email = objEmployeeInfo.Email;
                objUserInfo.Username = username;
                objUserInfo.Membership.Password = EmployeePassword;

                objUserInfo.Membership.Approved = true;

                DotNetNuke.Security.Membership.UserCreateStatus bol;
                bol = UserController.CreateUser(ref objUserInfo);
                if (objUserInfo.UserID > 0)
                {
                    uId = objUserInfo.UserID;
                    objEmployeeInfo.EmployeeUserID_FK = objUserInfo.UserID;
                    (new EmployeeDetailsController()).Update(objEmployeeInfo);//////////////problem////////////////////////////
                    DotNetNuke.Services.Log.EventLog.EventLogController
        objEventLog = new DotNetNuke.Services.Log.EventLog.EventLogController();
                    objEventLog.AddLog(objUserInfo, PortalSettings, UserId,
        username,
        DotNetNuke.Services.Log.EventLog.EventLogController.EventLogType.USER_CREATED);

                    //send notification to portal administrator of new user  registration//
                    //(PortalSettings.DefaultLanguage, PortalSettings,  "EMAIL_USER_REGISTRATION_ADMINISTRATOR_SUBJECT", objNewUser),  
                    //DotNetNuke.Services.Localization.Localization.GetSystemMessage(PortalSettings.DefaultLanguage, PortalSettings, 
                    //  "EMAIL_USER_REGISTRATION_ADMINISTRATOR_BODY", objNewUser), "", "", "", "", "",  "");

                    //complete registration
                    string strMessage = "";
                    switch (PortalSettings.UserRegistration)
                    {
                        case
        (int)DotNetNuke.Common.Globals.PortalRegistrationType.PrivateRegistration:
                            strMessage =
        string.Format(DotNetNuke.Services.Localization.Localization.GetString("PrivateConfirmationMessage", this.LocalResourceFile),
        objEmployeeInfo.Email);
                            break;
                        case
        (int)DotNetNuke.Common.Globals.PortalRegistrationType.PublicRegistration:
                            objSecurity.UserLogin(username, EmployeePassword, PortalSettings.PortalId, PortalSettings.PortalName, "", false);
                            //objSecurity.UserLogin(username, "xportal",  
                            //rtalSettings.PortalId, PortalSettings.PortalName, "", false);

                            break;
                        case
        (int)DotNetNuke.Common.Globals.PortalRegistrationType.VerifiedRegistration:
                            strMessage =
        string.Format(DotNetNuke.Services.Localization.Localization.GetString("VerifiedConfirmationMessage", this.LocalResourceFile),
        objEmployeeInfo.Email);
                            break;
                    }


                    // int id = (objRoleController.GetRoleByName(PortalId, "Employee").RoleID);
                    int id = this.objRoleController.GetRoleByName(PortalId, "Employee").RoleID;
                    objRoleController.AddUserRole(PortalId, objUserInfo.UserID, id, Null.NullDate);

                    //objRoleController.AddUserRole(PortalId, objUserInfo.UserID, id, Null.NullDate);
                    //objStudentInfo.USER_ID = objUserInfo.UserID;
                    //objStudentController.Update(objStudentInfo);
                }
                else
                {
                    AspNetSecurity.MembershipCreateStatus UserRegistrationStatus;
                    UserRegistrationStatus =
        ((AspNetSecurity.MembershipCreateStatus)(objUserInfo.UserID * -1));
                    // UserController objUserController = new UserController();
                }
            }
            catch (Exception ex)
            {
                //XP.Logger.WriteLog(ex.Message + " ---> " + ex.StackTrace);
            }
            return uId;

        }

        #endregion

#endregion


        //Employee Profile

        #region

        protected void hrEmpProfileIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelEmployeeProfile.Visible = true;

            EmployeeDetailsInfo objEmpProfile = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(hrEmpProfileIDList.SelectedValue);
            objEmpProfile = (new EmployeeDetailsController()).Get(empID);

            EmployeeDepartmentTableInfo objEmpDept = new EmployeeDepartmentTableInfo();
            int DeptID = objEmpProfile.Department_FK;
            objEmpDept = (new EmployeeDepartmentTableController()).Get(DeptID);


            EmployeePositionTableInfo objEmpPosition = new EmployeePositionTableInfo();
            int PositionID = objEmpProfile.PositionHeld_FK;
            objEmpPosition = (new EmployeePositionTableController()).Get(PositionID);


            EmployeeLevelInfo objEMpLevel = new EmployeeLevelInfo();
            int LevelID = objEmpProfile.EmployeeLevel_FK;
            objEMpLevel = (new EmployeeLevelController()).Get(LevelID);

            EmployeeWorkLocationsInfo objEmpWorkLoc = new EmployeeWorkLocationsInfo();
            int WorkLocationID = objEmpProfile.WorkLocation_FK;
            objEmpWorkLoc = (new EmployeeWorkLocationsController()).Get(WorkLocationID);

            CountryTableInfo objEmpCountry = new CountryTableInfo();
            int CountryID = objEmpProfile.Nationality_FK;
            objEmpCountry = (new CountryTableController()).Get(CountryID);

            StateTableInfo objEmpState = new StateTableInfo();
            int StateID = objEmpProfile.StateOfOrigin_FK;
            objEmpState = (new StateTableController()).Get(StateID);

            LGATableInfo objEmpLGA = new LGATableInfo();
            int LgaID = objEmpProfile.LGA_FK;
            objEmpLGA = (new LGATableController()).Get(LgaID);

            UserInfo objEmpConfirmUser = new UserInfo();
            int confirmUserId = objEmpProfile.ConfirmedBy;
            objEmpConfirmUser = (new UserController()).GetUser(0, confirmUserId);
 



            LbHrEmpTitle.Text = objEmpProfile.Title;
            LbHrEmpFName.Text = objEmpProfile.FirstName;
            LbHrEmpMidName.Text = objEmpProfile.MiiddleName;
            LbHrEmpLName.Text = objEmpProfile.LastName;
            LbHrEmpMaritalStatus.Text = objEmpProfile.MaritalStatus;
            LbHrEmpGender.Text = objEmpProfile.Gender;
            LbHrEmpPhnNum.Text = objEmpProfile.PhoneNo;
            LbHrEmpEmail.Text = objEmpProfile.Email;
            LbHrEmpContAddr.Text = objEmpProfile.ContactAddress;
            LbHrEmpDOB.Text = objEmpProfile.DateOfBirth;
            LbHrEmpAge.Text = objEmpProfile.Age;
            //LbHrEmpGender.Text = CurrentEmployeeDetail.Gender;
            LbHrEmpReligion.Text = objEmpProfile.Religion;
            LbHrEmpStartDate.Text = objEmpProfile.StartDate;
            EmpProfilePassport.ImageUrl = "~/images/" + objEmpProfile.Passport.Substring(objEmpProfile.Passport.LastIndexOf('/') + 1);



            LbHrEmpCountry.Text = objEmpCountry.CountryName;
            LbHrEmpState.Text = objEmpState.StateName;
            LbHrEmpLGA.Text = objEmpLGA.LgaName;

            LbHrEmpDept.Text = objEmpDept.DeptName;
            LbHrEmpPosition.Text = objEmpPosition.PositionName;
            LbHrEmpLevel.Text = objEMpLevel.LevelName;
            LbHrEmpWorkLoc.Text = objEmpWorkLoc.LocationName + "," + " " + objEmpWorkLoc.LocationAddress;


            // Collecting Employee spouse details

            LbSpouseNames.Text = objEmpProfile.SpouseNames;
            LbHrEmpSpousePhoNo.Text = objEmpProfile.SpousePhoneNo;
            LbHrEmpSpouseAddress.Text = objEmpProfile.SpouseAddress;
            LbHrEmpSpouseEmailAddr.Text = objEmpProfile.SpouseEmail;
            LbHrEmpSpouseOccupation.Text = objEmpProfile.SpouseOccupation;
            LbHrEmpSpouseEmployer.Text = objEmpProfile.SpouseEmployerNames;

            //Collecting Employee NextOfKin details

            LbHrEmpNextOfKinNames.Text = objEmpProfile.NxtOfKinLName + " " + objEmpProfile.NxtOfKinMidName + " " + objEmpProfile.NxtOfKinFName;
            LbHrEmpNextOfKinRelationship.Text = objEmpProfile.NxtOfKinRelationship;
            LbHrEmpNextOfKinEmail.Text = objEmpProfile.NxtOfKinEmail;
            LbHrEmpNextOfKinAddrs.Text = objEmpProfile.NxtOfKinAddress;
            LbHrEmpNextOfKinOccupation.Text = objEmpProfile.NxtOfKinOccupation;
            LbHrEmpNextOfKinPhnNum.Text = objEmpProfile.NxtOfKinPhoneNo;

            //Collecting Employee status Info

            LbHrEmpStatus.Text = objEmpProfile.EmployeeStatus;
            LbHrEmpConfimedDate.Text = objEmpProfile.ConfirmationDate;
            if (objEmpProfile.ConfirmedBy <= 0)
            {
                LbHrEmpConfirmedBy.Text = "Not yet Confirmed";
            }
            else
            {
                LbHrEmpConfirmedBy.Text = objEmpConfirmUser.DisplayName;
            }


            //Collecting Employee Bank Info

            LbHrEmpBankNames.Text = objEmpProfile.BankName;
            LbHrEmpAccountName.Text = objEmpProfile.AccountName;
            LbHrEmpAcctNumber.Text = objEmpProfile.AccountNo;
            LbHrEmpGuarrantorName.Text = objEmpProfile.GuarrantorNames;

            //Collecting Employee Referee Info

            LbHrEmpReferee1Names.Text = objEmpProfile.Refree1Names;
            LbHrEmpReferee1Occupation.Text = objEmpProfile.Refree1Occupation;
            LbHrEmpReferee1Email.Text = objEmpProfile.Refree1Email;
            LbHrEmpReferee1PhnNum.Text = objEmpProfile.Refree1PhoneNum;
            LbHrEmpReferee1Addr.Text = objEmpProfile.Refree1ContactAddr;



            LbHrEmpReferee2Names.Text = objEmpProfile.Refree2Names;
            LbHrEmpReferee2Occupation.Text = objEmpProfile.Refree2Occupation;
            LbHrEmpReferee2PhnNum.Text = objEmpProfile.Refree2PhoneNum;
            LbHrEmpReferee2Email.Text = objEmpProfile.Refree2Email;
            LbHrEmpReferee2Addr.Text = objEmpProfile.Refree2ContactAddr;


            int empID_FK = empID;
            int applicantID = objEmpProfile.ApplicantID_FK;

            ArrayList objProfileQaulifList = new ArrayList();
            objProfileQaulifList = (new EmployeeQualificationTableController()).ApprovedQualifGetByEmployeeDetails(empID_FK);

            if (objProfileQaulifList.Count > 0)
            {

                GViewHrEmpProfileQualification.Visible = true;
                GViewHrEmpProfileQualification.DataSource = objProfileQaulifList;
                GViewHrEmpProfileQualification.DataBind();

            }
            ArrayList objProfileProfQaulifList = new ArrayList();
            objProfileProfQaulifList = (new EmployeeProfQualificationTableController()).ApprovedProfQualifGetByEmployeeDetails(empID_FK);

            if (objProfileProfQaulifList.Count > 0)
            {

                GViewHrEmpProfileCert.Visible = true;
                GViewHrEmpProfileCert.DataSource = objProfileProfQaulifList;
                GViewHrEmpProfileCert.DataBind();

            }


            ArrayList objProfileDocList = new ArrayList();
            objProfileDocList = (new EmployeeDocumentTableController()).ApprovedDocGetByEmployeeDetails(empID_FK);

            if (objProfileDocList.Count > 0)
            {

                GViewHrEmpProfileDoc.Visible = true;
                GViewHrEmpProfileDoc.DataSource = objProfileDocList;
                GViewHrEmpProfileDoc.DataBind();

            }



        }
        #endregion


        //Assigning HOD of Deparment

        #region

         protected void assignHODDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objDeptPost = new ArrayList();
            int dept = Convert.ToInt32(assignHODDeptList.SelectedValue);
             objDeptPost = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(dept);
             if(objDeptPost.Count >0)
             {
                 assignHODPositionList.DataSource = objDeptPost;
                 assignHODPositionList.DataTextField = "PositionName";
                 assignHODPositionList.DataValueField = "PositionID";
                 assignHODPositionList.DataBind();
                 assignHODPositionList.Visible = true;


                 assignHODPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));

             }

             

            ArrayList objHodEmp = new ArrayList();
            //int dept = Convert.ToInt32(assignHODDeptList.SelectedValue);
             int work = Convert.ToInt32(assignHODLocationList.SelectedValue);
             objHodEmp = (new EmployeeDetailsController()).ListByDeptAndLocation(dept, work);

             ViewState.Add("dept", dept);
             ViewState.Add("work", work);

             if (objHodEmp.Count > 0)
             {
                 assignHODEmpList.DataSource = objHodEmp;
                 assignHODEmpList.DataTextField = "EmployeeNum";
                 assignHODEmpList.DataValueField = "EmployeeID";
                 assignHODEmpList.DataBind();
                 assignHODEmpList.Visible = true;

                 assignHODEmpList.Items.Insert(0, new ListItem("***Please select***", "-1"));

             }

        }

         protected void assignHODEmpList_SelectedIndexChanged(object sender, EventArgs e)
         {
             //int empID = Convert.ToInt32(ViewState["empID"]);
             
             int work = Convert.ToInt32(ViewState["work"]);
             int dept = Convert.ToInt32(ViewState["dept"]);

             ArrayList objAssing = new ArrayList();

             objAssing = (new EmployeeDetailsController()).GetByEmpDeptAndLocation(dept, work);

             if (objAssing.Count > 0)
             {
                 GViewAssignHOD.DataSource = objAssing;
                 GViewAssignHOD.DataBind();
                 GViewAssignHOD.Visible = true;
                 assignHODBtn.Visible = true;
             }

         }

         protected void assignHODBtn_Click(object sender, EventArgs e)
         {


             int work = Convert.ToInt32(ViewState["work"]);
             int dept = Convert.ToInt32(ViewState["dept"]);

             foreach (GridViewRow x in GViewAssignHOD.Rows)
             {
                 // declare a variable as textbox

                 TextBox D = new TextBox();
                 TextBox P = new TextBox();
                 TextBox W = new TextBox();
                 TextBox E = new TextBox();

                 // find the textbox containing the applicantID on the gridview 

                 D = (TextBox)x.FindControl("txtAssignDeptID");
                 // P = (TextBox)x.FindControl("txtPostID");
                 W = (TextBox)x.FindControl("txtWorkID");
                 E = (TextBox)x.FindControl("txtAssignEmpID");

                 string deptID = D.Text;
                 // string postID = P.Text;
                 // string workID = W.Text;
                 string empid = E.Text;


                 CheckBox c = new CheckBox();
                 c = (CheckBox)x.FindControl("CheckBoxHodAssign");
                 if (c.Checked == true)
                 {
                     // lblInterMsg.Text = id;
                     try
                     {
                         // Update Employee HOD with HOID
                         EmployeeDetailsInfo objHODAssign = new EmployeeDetailsInfo();
                         objHODAssign.EmployeeID = Convert.ToInt32(empid);
                         objHODAssign.HODID = Convert.ToInt32(assignHODEmpList.SelectedValue);

                         (new EmployeeDetailsController()).UpdateEmpHOD(objHODAssign);

                         EmployeeDetailsLogInfo objHODAssignLogGet = new EmployeeDetailsLogInfo();
                         objHODAssignLogGet = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(Convert.ToInt32(empid));

                         EmployeeDetailsInfo objHODAssigGetForLog = new EmployeeDetailsInfo();
                         objHODAssigGetForLog = (new EmployeeDetailsController()).Get(Convert.ToInt32(empid));

                         EmployeeDetailsLogInfo objHODAssignLog = new EmployeeDetailsLogInfo();
                         objHODAssignLog.EmployeeLogID = objHODAssignLogGet.EmployeeLogID;
                         objHODAssignLog.HODID = objHODAssigGetForLog.HODID;
                         //Convert.ToInt32(assignHODEmpList.SelectedValue);
                         objHODAssignLog.EmployeeID_FK = objHODAssigGetForLog.EmployeeID;
                             //Convert.ToInt32(empid);

                         (new EmployeeDetailsLogController()).LogUpdateEmpHOD(objHODAssignLog);

                       
                     }

                     catch
                     {

                     }
                 }
             }

         
             // Update Employee HOD New Position with HOD positionID
             try
             {
                 int HODNEwPost = Convert.ToInt32(assignHODPositionList.SelectedValue);
                 int Hod = Convert.ToInt32(assignHODEmpList.SelectedValue);

                 EmployeeDetailsInfo objHODNewPostion = new EmployeeDetailsInfo();
                 objHODNewPostion.EmployeeID = Convert.ToInt32(assignHODEmpList.SelectedValue);
                 objHODNewPostion.PositionHeld_FK = HODNEwPost;
                 objHODNewPostion.HODID = Hod;
                 (new EmployeeDetailsController()).UpdateHODNewPositionAsHOD(objHODNewPostion);

                 EmployeeDetailsInfo objHODNewPostionGetForLog = new EmployeeDetailsInfo();
                 objHODNewPostionGetForLog = (new EmployeeDetailsController()).Get(Convert.ToInt32(assignHODEmpList.SelectedValue));

                 EmployeeDetailsLogInfo objHODNewPostLogGet = new EmployeeDetailsLogInfo();
                 objHODNewPostLogGet = (new EmployeeDetailsLogController()).LogGetByEmployeeDetails(Convert.ToInt32(assignHODEmpList.SelectedValue));

                 EmployeeDetailsLogInfo objHODNewPostionLog = new EmployeeDetailsLogInfo();
                 objHODNewPostionLog.EmployeeLogID = objHODNewPostLogGet.EmployeeLogID;
                 objHODNewPostionLog.PositionHeld_FK = HODNEwPost;                  
                 objHODNewPostionLog.HODID = Hod;
               objHODNewPostionLog.EmployeeID_FK = Convert.ToInt32(assignHODEmpList.SelectedValue);
                     
                 (new EmployeeDetailsLogController()).LogUpdateHODNewPositionAsHOD(objHODNewPostionLog);



                 EmployeeDetailsInfo objGetEmp = new EmployeeDetailsInfo();
                 objGetEmp = (new EmployeeDetailsController()).Get(Convert.ToInt32(assignHODEmpList.SelectedValue));

                 EmployeeDetailsLogInfo objHODNewPostLogGet2 = new EmployeeDetailsLogInfo();
                 objHODNewPostLogGet2 = (new EmployeeDetailsLogController()).LogGet(objHODNewPostLogGet.EmployeeLogID);


                 if (
                     (objGetEmp.HODID == Convert.ToInt32(assignHODEmpList.SelectedValue)) && (objHODNewPostLogGet2.HODID == Convert.ToInt32(assignHODEmpList.SelectedValue)) &&

                     (objGetEmp.PositionHeld_FK == HODNEwPost) && (objHODNewPostLogGet2.PositionHeld_FK == HODNEwPost)
                     )
                 {
                     PanelAssignHOD1.Visible = false;
                     LinkBtnAssignHOD.Visible = true;
                     LbHODUpdateSuccessful1.Text = "Emp HOD Updated Successfull and HOD Position Modified";
                     LbHODUpdateSuccessful1.Visible = true;
                     GViewAssignHOD.Visible = false;
                     btnAssignHODFinish.Visible = true;
                     btnAssignHODTryAgain.Visible = false;
                     refereshPageAssign();


                 }

                 else
                 {
                     PanelAssignHOD1.Visible = false;
                     LbHODUpdateSuccessful1.Text = "Emp HOD NOT Updated and HOD Position Not Modified";
                     LbHODUpdateSuccessful1.Visible = true;
                     LinkBtnAssignHOD.Visible = false;
                     GViewAssignHOD.Visible = false;
                     btnAssignHODFinish.Visible = false;
                     btnAssignHODTryAgain.Visible = true;
                 }
             }
             catch
             {

             }
         }
         private void refereshPageAssign()
        {
            this.assignHODEmpList.ClearSelection();
            this.assignHODLocationList.ClearSelection();
            this.assignHODPositionList.ClearSelection();
            this.assignHODDeptList.ClearSelection();          
             }
         protected void LinkBtnAssignHOD_Click(object sender, EventArgs e)
         {
             LbHODUpdateSuccessful1.Visible = false;
             PanelAssignHOD1.Visible = true;
             refereshPageAssign();

         }
       
        #endregion


        //Employee Confirmation

        #region

         protected void LinkBtnConfirmEmp_Click(object sender, EventArgs e)
         {
             LbConfirmSuccessful.Visible = false;
             PanelConfirmation.Visible = true;
             
         }
        protected void confirmEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbConfirmSuccessful.Visible = false;
            LbCanNotConfirm.Visible = false;
            LbConfirmDuration.Visible = false;
            
            EmployeeDetailsInfo objEmpDetail1 = new EmployeeDetailsInfo();
            int confirmEmpID = Convert.ToInt32(confirmEmployeeList.SelectedValue);
            objEmpDetail1 = (new EmployeeDetailsController()).Get(confirmEmpID);

            UserInfo objConfirmByUser = new UserInfo();
            objConfirmByUser = (new UserController()).GetUser(0, UserId);
 
         
            LbConfirmStartDate.Text = objEmpDetail1.StartDate;
            LbConfirmStartDate.Visible = true;
            string curDate = DateTime.Now.ToShortDateString();
            LbConfrimationDate.Text = curDate;
            LbConfrimationDate.Visible = true;
            LbConfirmedBy.Text = objConfirmByUser.DisplayName;
            LbConfirmedBy.Visible = true;
            confirmBtn.Visible = true;

            DateTime sDate = DateTime.Parse(LbConfirmStartDate.Text);
            DateTime cDate = DateTime.Parse(LbConfrimationDate.Text);

            int numOfdays = (cDate - sDate).Days;
            LbConfrimDuration.Text = numOfdays.ToString();
            LbConfrimDuration.Visible = true;


           int  minDur = 7;
            if(numOfdays >= minDur)
            {
                LbConfirmDuration.Text = "Minimum Duration for Confirmation reached, you can now confirm this employee";
                LbConfirmDuration.Visible = true;

            }
             else
            {
                LbConfirmDuration.Text = "Minimum Duration Not reached, you can not confirm this employee";
                LbConfirmDuration.Visible = true;
            }

     
        }
        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            EmployeeDetailsInfo objEmpConfirm = new EmployeeDetailsInfo();
            int empID4 = Convert.ToInt32(confirmEmployeeList.SelectedValue);
            objEmpConfirm = (new EmployeeDetailsController()).Get(empID4);
            ViewState.Add("empID4", empID4);

            UserInfo objConfirmByUser = new UserInfo();
            objConfirmByUser = (new UserController()).GetUser(0, UserId);
 
            DateTime sDate = DateTime.Parse(LbConfirmStartDate.Text);
            DateTime cDate = DateTime.Parse(LbConfrimationDate.Text);

            int numOfdays = (cDate - sDate).Days;
          

            int minDuration = 7;
       
            if (numOfdays <= minDuration)
            {
                LbCanNotConfirm.Text = "Sorry! this employee cannot be confirmed now, he/she does not meet confirmation requirement";
                LbCanNotConfirm.Visible = true;
            }
            
            else

            {
                LbCanNotConfirm.Visible = false;         
                objEmpConfirm.EmployeeID = empID4;
                objEmpConfirm.ConfirmedBy = UserId;
                objEmpConfirm.ConfirmationDate = LbConfrimationDate.Text;
                  
                (new EmployeeDetailsController()).UpdateConfirmation(objEmpConfirm);

                //Composing Confirmation mail content

                EmployeeDetailsInfo objGetConfirmEmp = new EmployeeDetailsInfo();
                objGetConfirmEmp = (new EmployeeDetailsController()).Get(empID4);
                lbConfirmLetterDate.Text = objGetConfirmEmp.ConfirmationDate;
                PanelConfirmLetter.Visible = true;


                //string salutaion = ("dear" + objPersonalInfo.LastName + ",");
                string subjectEmail = "Employment Offer";
                string bodyEmail = ("Dear " + objGetConfirmEmp.LastName + ", " + objGetConfirmEmp.FirstName + "   We wish to inform you that you have been confirmed as a full staff of Neetbeet Technologies Limited on this day  "
                    + objGetConfirmEmp.ConfirmationDate);

                string offerDetails = ("You will therefore henceforth enjoy all benefits as a staff of Neetbeet. Congratulations! " +

                    "The Management");

                bodyEmail += offerDetails;
                string receiverEmail = objGetConfirmEmp.Email;

                Utility.SendMail(subjectEmail, bodyEmail, receiverEmail);

               

                if (objGetConfirmEmp.ConfirmedBy > 0)
                {
                    PanelConfirmation.Visible = false;
                    LbConfirmSuccessful.Visible = true;
                    LbConfirmSuccessful.Text = "Confirmation Successful! Confirmation letter sent to the employee";
                    LinkBtnPrintConfirmLetter.Visible = true;
                }

                else
                {
                    PanelConfirmation.Visible = false;
                    LbConfirmSuccessful.Visible = true;
                    LbConfirmSuccessful.Text = "Confirmation Not Successfully";
                }
            }
           
              }


        protected void LinkBtnPrintConfirmLetter_Click(object sender, EventArgs e)
        {

            int empID4 = Convert.ToInt32(ViewState["empID4"]);
            EmployeeDetailsInfo objGetConfirmEmp = new EmployeeDetailsInfo();
            objGetConfirmEmp = (new EmployeeDetailsController()).Get(empID4);
            lbConfirmLName.Text = objGetConfirmEmp.LastName;
            lbConfirmLName.Visible = true;
            lbConfirmLetterDate.Text = objGetConfirmEmp.ConfirmationDate;

            PanelConfirmLetter.Visible = true;

            Utility.PrintHelper.PrintWebControl(PanelConfirmLetter);
        }
        protected void LinkBtnListConfirmeEmp_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 25;
            PanelConfirmedList.Visible = true;
            PanelUnConfirmedList.Visible = false;
            ArrayList objListConfiredEmployee = new ArrayList();
            objListConfiredEmployee = (new EmployeeDetailsController()).ConfirmedEmployeeList();

            if (objListConfiredEmployee.Count > 0)
            {
                GViewConfirmedList.DataSource = objListConfiredEmployee;
                GViewConfirmedList.DataBind();
                GViewConfirmedList.Visible = true;
            }
        }


        protected void LinkBtnListUnConfirmeEmp_Click(object sender, EventArgs e)
        {

            MViewHRPage.ActiveViewIndex = 25;
            PanelConfirmedList.Visible =false;
            PanelUnConfirmedList.Visible = true;
            ArrayList objListUnConfiredEmployee = new ArrayList();
            objListUnConfiredEmployee = (new EmployeeDetailsController()).UnconfirmedList();

            if (objListUnConfiredEmployee.Count > 0)
            {
                GViewUnConfirmedList.DataSource = objListUnConfiredEmployee;
                GViewUnConfirmedList.DataBind();
                GViewUnConfirmedList.Visible = true;
            }
        }

        protected void btnConfirmedFinish_Click(object sender, EventArgs e)
        {
            PanelConfirmation.Visible = false;
            MViewHRPage.ActiveViewIndex = 7;

        }
        protected void btnUnConfirmedFinish_Click(object sender, EventArgs e)
        {
            PanelConfirmation.Visible = false;
            MViewHRPage.ActiveViewIndex = 7;
        }

        #endregion

        // HR Approval Module


        #region
        protected void hrApproveQualifMenuBtn_Click(object sender, EventArgs e)
        {
            PanelApproveQualif1.Visible = true;
            PanelApproveQualif.Visible = true;
            LbHrQaulifHrApproval.Visible = false;
            LbCertApproved1.Visible = false;
        }
        protected void HRQualifEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
             ArrayList objApproveQualif = new ArrayList();
            int empID = Convert.ToInt32(hrUnApprovedQualifList.SelectedValue);
            objApproveQualif = (new EmployeeQualificationTableController()).QualificationUnApprovedGetByEmployeeDetails(empID);

            if (objApproveQualif.Count > 0)
            {
                GViewHrEmpApproveQualif.DataSource = objApproveQualif;
                GViewHrEmpApproveQualif.DataBind();
                GViewHrEmpApproveQualif.Visible = true;
                QualifApproveBtn.Visible = true;
                QualifFinishBtn.Visible = true;
            }
            
                
        }


        protected void QualifApproveBtn_Click(object sender, EventArgs e)
        {
            
              foreach (GridViewRow x in GViewHrEmpApproveQualif.Rows)
            {
                // declare a variable as textbox

                TextBox aid = new TextBox();
                TextBox eid = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                aid = (TextBox)x.FindControl("txtAppID");
                eid = (TextBox)x.FindControl("txtEmpID");
                string appid = aid.Text;
                string empid = eid.Text;
             

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBoxQualif");
                if (c.Checked == true)
                {
                       try
                    {
                        // Update HrApproval Statuson the EmployeeQualificationTable

                        EmployeeQualificationTableInfo objQualifInfo = new EmployeeQualificationTableInfo();
                        objQualifInfo.EmployeeID_FK = Convert.ToInt32(empid);
                        objQualifInfo.ApplicantID_FK = Convert.ToInt32(appid);
                        objQualifInfo.HrApproval = "Approved";
                        new EmployeeQualificationTableController().HrApprovalUpdate(objQualifInfo);
                        
                         EmployeeQualificationTableInfo objQualifInfos = new EmployeeQualificationTableInfo();
                        int ee = Convert.ToInt32(empid);
                         objQualifInfos = (new EmployeeQualificationTableController()).Get(ee);
                        // LbHrQaulifHrApproval.Text = objQualifInfos.HrApproval;
                        // LbHrQaulifHrApproval.Visible = true;

                        if (objQualifInfo.HrApproval != null )
                        {
                            ///Alhaja lo so be ooooooo

                            ArrayList objApproveQualif = new ArrayList();
                            objApproveQualif = (new EmployeeQualificationTableController()).QualificationUnApprovedGetByEmployeeDetails(ee);

                            if (objApproveQualif.Count > 0)
                            {
                                GViewHrEmpApproveQualif.DataSource = objApproveQualif;
                                GViewHrEmpApproveQualif.DataBind();
                                GViewHrEmpApproveQualif.Visible = true;
                                QualifApproveBtn.Visible = true;
                                QualifFinishBtn.Visible = true;
                            }

                           
                            LbHrQaulifHrApproval.Visible = false;
                            LbCertApproved1.Visible = false;
                            LbDocApproved1.Visible = false;
                            LbHrQaulifApproved.Visible = true;
                            LbHrQaulifApproved.Text = "Qualification Approved Successfully";

                        }

                        else
                        {

                            LbHrQaulifApproved.Visible = true;
                            LbHrQaulifApproved.Text = "Qualification Not Approved";
                        }

                    }

                    catch
                    {

                    }

                }

                }
        }

        //Certification

        protected void hrApproveCertMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 5;
            
            PanelApproveQualif1.Visible = false;
            PanelHrApproveCert.Visible = false;           
            PanelApproveQualif.Visible = false;
            LbHrQaulifHrApproval.Visible = false;
            LbCertApproved1.Visible = false;
        }
        protected void hrUnApprovedCertList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objApproveCert = new ArrayList();
            int empID = Convert.ToInt32(hrUnApprovedCertList.SelectedValue);
            objApproveCert = (new EmployeeProfQualificationTableController()).ProfQualificationUnApprovedGetByEmployeeDetails(empID);

            if (objApproveCert.Count > 0)
            {

                GViewHrEmpApproveCert.DataSource = objApproveCert;
                GViewHrEmpApproveCert.DataBind();
                GViewHrEmpApproveCert.Visible = true;
                hrCertApproveBtn.Visible = true;
                hrCertFinishBtn.Visible = true;
            }
        }
        protected void hrCertApproveBtn_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow x in GViewHrEmpApproveCert.Rows)
            {
                
                // declare a variable as textbox

                TextBox aid = new TextBox();
                TextBox eid = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                aid = (TextBox)x.FindControl("txtCertAppID");
                eid = (TextBox)x.FindControl("txtCertEmpID");
                string appid = aid.Text;
                string empid = eid.Text;
             

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBoxCert");
                if (c.Checked == true)
                {

                    try
                    {
                        // Update HrApproval Statuson the EmployeeQualificationTable
                        EmployeeProfQualificationTableInfo objCertInfo = new EmployeeProfQualificationTableInfo();
                        objCertInfo.employeeID_FK = Convert.ToInt32(empid);
                        objCertInfo.ApplicantID_FK = Convert.ToInt32(appid);
                        objCertInfo.HrApproval = "Approved";
                        new EmployeeProfQualificationTableController().HrApprovalUpdate(objCertInfo);

                        EmployeeProfQualificationTableInfo objProfQualifInfos = new EmployeeProfQualificationTableInfo();
                        int ee = Convert.ToInt32(empid);
                        objProfQualifInfos = (new EmployeeProfQualificationTableController()).Get(ee);

                        if (objCertInfo.employeeID_FK== Convert.ToInt32(empid))
                        {
                            ArrayList objApproveProQualif = new ArrayList();
                            objApproveProQualif = (new EmployeeProfQualificationTableController()).ProfQualificationUnApprovedGetByEmployeeDetails(ee);
                               
                            if (objApproveProQualif.Count > 0)
                            {
                                GViewHrEmpApproveCert.DataSource = objApproveProQualif;
                                GViewHrEmpApproveCert.DataBind();
                                GViewHrEmpApproveCert.Visible = true;
                                hrCertApproveBtn.Visible = true;
                                hrCertFinishBtn.Visible = true;
                                LbCertApproved.Visible = true;
                                LbCertApproved.Text = "Professional Qualification Approved Successfully";

                            }
                           
                        }

                        else
                        {

                            LbCertApproved.Visible = true;
                            LbCertApproved.Text = " Professional Qualification Not Approved";
                        }

                    }

                    catch
                    {

                    }

                }

            }
        }

            //Document
            
        protected void hrApproveDocMenuBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 6;
            PanelHrApproveDoc.Visible = true;
            PanelApproveQualif1.Visible = false;
            PanelHrApproveCert.Visible = false;
            PanelApproveQualif.Visible = false;
            LbHrQaulifHrApproval.Visible = false;
            LbCertApproved1.Visible = false;
            LbDocApproved1.Visible = false;
        }


        protected void hrUnApprovedDocList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objApproveDoc = new ArrayList();
            int empID = Convert.ToInt32(hrUnApprovedDocList.SelectedValue);
            objApproveDoc = (new EmployeeDocumentTableController()).DocumentUnApprovedGetByEmployeeDetails(empID);

            if (objApproveDoc.Count > 0)
            {

                GViewHrEmpApproveDoc.DataSource = objApproveDoc;
                GViewHrEmpApproveDoc.DataBind();
                GViewHrEmpApproveDoc.Visible = true;
                hrDocApproveBtn.Visible = true;
                hrDocFinshBtn.Visible = true;
                


            }
        }

        protected void hrDocApproveBtn_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow x in GViewHrEmpApproveDoc.Rows)
            {
                //  
                // declare a variable as textbox

                TextBox aid = new TextBox();
                TextBox eid = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                aid = (TextBox)x.FindControl("txtDocAppID");
                eid = (TextBox)x.FindControl("txtDocEmpID");
                string appid = aid.Text;
                string empid = eid.Text;
             

                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBoxDoc");
                if (c.Checked == true)
                {
                    // lblInterMsg.Text = id;
                    try
                    {
                        // Update HrApproval Statuson the EmployeeQualificationTable
                        EmployeeDocumentTableInfo objDocInfo = new EmployeeDocumentTableInfo();
                        objDocInfo.EmployeeID_Fk = Convert.ToInt32(empid);
                        objDocInfo.ApplicantID_FK = Convert.ToInt32(appid);
                        objDocInfo.HrApproval = "Approved";
                        new EmployeeDocumentTableController().HrApprovalUpdate(objDocInfo);

                        EmployeeDocumentTableInfo objDocInfos = new EmployeeDocumentTableInfo();
                        int ee = Convert.ToInt32(empid);
                        objDocInfos =(new EmployeeDocumentTableController()).Get(ee);
                       
                        if (objDocInfo.EmployeeID_Fk == Convert.ToInt32(empid))
                        {
                            ArrayList objDocs = new ArrayList();
                            objDocs = (new EmployeeDocumentTableController()).DocumentUnApprovedGetByEmployeeDetails(ee);

                            if (objDocs.Count > 0)
                            {
                                GViewHrEmpApproveDoc.DataSource = objDocs;
                                GViewHrEmpApproveDoc.DataBind();
                                GViewHrEmpApproveDoc.Visible = true;
                                hrCertApproveBtn.Visible = true;
                                hrCertFinishBtn.Visible = true;
                                hrDocApproveBtn.Visible = true;
                                hrDocApproveBtn.Text = "Document Approved Successfully";

                            }
                           

                        }

                        else
                        {

                            hrDocApproveBtn.Visible = true;
                            hrDocApproveBtn.Text = "Document Not Approved";
                        }

                    }

                    catch
                    {

                    }

                }

            }
        }

        
        #endregion


        //Training Module

        #region

        protected void trainingHRDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            UserInfo objTrainUser = new UserInfo();
            objTrainUser = (new UserController()).GetUser(0, UserId);


            ArrayList objApproveTraining = new ArrayList();
            int dept = Convert.ToInt32(trainingHRDeptList.SelectedValue);
            objApproveTraining = (new EmployeeTrainingTableController()).HRAprovalGetByEmployeeDeptTable(dept);

            if (objApproveTraining.Count > 0)
            {
                GViewTrainingEmpList.DataSource = objApproveTraining;
                GViewTrainingEmpList.DataBind();
                GViewTrainingEmpList.Visible = true;

                LbApprovedBy.Text = objTrainUser.DisplayName;
                LbApprovedBy.Visible = true;
                LbApprove.Visible = true;
                trainingApproveBtn.Visible = true;
                trainingListBtn.Visible = true;
                trainingFinishBtn.Visible = true;

            }

        }


        protected void trainingApproveBtn_Click(object sender, EventArgs e)
        {

            foreach (GridViewRow x in GViewTrainingEmpList.Rows)
            {
                //declare texbox variables
                TextBox trainID = new TextBox();
                TextBox empID = new TextBox();
                TextBox deptID = new TextBox();


                //find the textboxes
                trainID = (TextBox)x.FindControl("txtTrainingID");
                empID = (TextBox)x.FindControl("txtTrainingEmpID");
                deptID = (TextBox)x.FindControl("txtTrainingDeptID");

                string Training = trainID.Text;
                string Employee = empID.Text;
                string dept = deptID.Text;

                //declare checkbox
                CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("TrainingHRpprovalCheckBox1");
                if (c.Checked == true)
                {
                    try
                    {
                        UserInfo objTrainUser = new UserInfo();
                        objTrainUser = (new UserController()).GetUser(0, UserId);


                        EmployeeTrainingTableInfo objTrainInfo = new EmployeeTrainingTableInfo();
                        objTrainInfo.EmployeeID_FK = Convert.ToInt32(Employee);
                        objTrainInfo.TrainingID = Convert.ToInt32(Training);
                        objTrainInfo.TrainingStatus = "Approve";
                        objTrainInfo.TrainingApprovedBy = objTrainUser.UserID;

                        new EmployeeTrainingTableController().HRApprovalUpdate(objTrainInfo);

                        EmployeeTrainingTableInfo objTrainInfo2 = new EmployeeTrainingTableInfo();
                        int tID = Convert.ToInt32(Training);
                        objTrainInfo2 = (new EmployeeTrainingTableController()).Get(tID);

                        if (objTrainInfo2.TrainingApprovedBy != null)
                        {
                            LbTrainingApproved.Text = "Training(s) Approved Successfully";
                            LbTrainingApproved.Visible = true;
                        }

                        else
                        {

                            LbTrainingApproved.Text = "Training(s) Not Approve";
                            LbTrainingApproved.Visible = true;
                        }

                    }

                    catch { }
                }

            }
        }

        protected void trainingListBtn_Click(object sender, EventArgs e)
        {

            UserInfo objTrainUser = new UserInfo();
            objTrainUser = (new UserController()).GetUser(0, UserId);

            ArrayList objApproveTraining1 = new ArrayList();
           // int dept = Convert.ToInt32(trainingHRDeptList.SelectedValue);
            objApproveTraining1 = (new EmployeeTrainingTableController()).List();

            if (objApproveTraining1.Count > 0)
            {
                GViewTrainingEmpList1.DataSource = objApproveTraining1;
                GViewTrainingEmpList1.DataBind();
                GViewTrainingEmpList1.Visible = true;

                    }

        }
        #endregion


        //Tranfer Module

        #region

        #region "SelectTransferTypeIndex
        protected void transferTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = transferTypeList.SelectedItem.Text;
            //.ToLower();


            if (select == "Organization")
            {
                MViewHRPage.ActiveViewIndex = 9;
                PanelTransfer.Visible = true;
                GViewTransferApproval.Visible = false;
                
            }
            else if (select == "Job Nature")
            {
                PanelTransfer.Visible = true;
                MViewHRPage.ActiveViewIndex = 9;
                PanelTransfer.Visible = true;
                GViewTransferApproval.Visible = false;

            }
            else if (select == "Self Request")
            {
                MViewHRPage.ActiveViewIndex = 22;
                GViewTransferApproval.Visible = true;
                PanelTransfer.Visible = false;
                BindTransferGView();
            }

        }

        #endregion

        #region "OrganizationTransfer

        protected void transferEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {

            EmployeeDetailsInfo objTransferEmpDetails1 = new EmployeeDetailsInfo();
            int transferEmpID = Convert.ToInt32(transferEmployeeList.SelectedValue);
            objTransferEmpDetails1 = (new EmployeeDetailsController()).Get(transferEmpID);

            EmployeeDepartmentTableInfo objTransferEmpDept = new EmployeeDepartmentTableInfo();
            int empDept = objTransferEmpDetails1.Department_FK;
            objTransferEmpDept = (new EmployeeDepartmentTableController()).Get(empDept);

            EmployeeWorkLocationsInfo objTransferEmpWorkLoc = new EmployeeWorkLocationsInfo();
            int empWorkLoc = objTransferEmpDetails1.Department_FK;
            objTransferEmpWorkLoc = (new EmployeeWorkLocationsController()).Get(empWorkLoc);

            UserInfo objTransferUser = new UserInfo();
            // int transferUser = objTransferEmpDetails1.EmployeeUserID_FK;
            objTransferUser = (new UserController()).GetUser(0, UserId);


            LbTransferPreDept.Text = objTransferEmpDept.DeptName;
            LbTransferPreDept.Visible = true;
            LbTransferPreWorkLoc.Text = objTransferEmpWorkLoc.LocationName + ", " + objTransferEmpWorkLoc.LocationAddress;
            LbTransferPreWorkLoc.Visible = true;
            string myDate = DateTime.Now.ToShortDateString();
            LbTransferDate.Text = myDate;
            LbTransferDate.Visible = true;
            LbTransferedBy.Text = objTransferUser.DisplayName;
            LbTransferedBy.Visible = true;

        }

        protected void TransferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsInfo objTransferEmpDetails1 = new EmployeeDetailsInfo();
                int transferEmpID1 = Convert.ToInt32(transferEmployeeList.SelectedValue);
                objTransferEmpDetails1 = (new EmployeeDetailsController()).Get(transferEmpID1);

                EmployeeDepartmentTableInfo objTransferEmpDept = new EmployeeDepartmentTableInfo();
                int empDept1 = objTransferEmpDetails1.Department_FK;
                objTransferEmpDept = (new EmployeeDepartmentTableController()).Get(empDept1);

                EmployeeWorkLocationsInfo objTransferEmpWorkLoc = new EmployeeWorkLocationsInfo();
                int empWorkLoc1 = objTransferEmpDetails1.WorkLocation_FK;
                objTransferEmpWorkLoc = (new EmployeeWorkLocationsController()).Get(empWorkLoc1);

                UserInfo objTransferUser = new UserInfo();
                objTransferUser = (new UserController()).GetUser(0, UserId);

                
                EmployeeTransferTableInfo objTransferInfo = new EmployeeTransferTableInfo();

                objTransferInfo.PreviousDept = empDept1;
                objTransferInfo.NewDept = Convert.ToInt32(this.transferNewDeptList.SelectedValue);
                objTransferInfo.PrevWorkLocation = empWorkLoc1;
                objTransferInfo.DesireLocation = Convert.ToInt32(this.transferNewWokLocList.SelectedValue);
                objTransferInfo.NewWorkLcation = Convert.ToInt32(this.transferNewWokLocList.SelectedValue);
                objTransferInfo.TransferType =this.transferTypeList.SelectedItem.Text.Trim();
                objTransferInfo.TransferReason =this. txtTransferReason.Text.Trim();
                objTransferInfo.EmployeeID_FK = transferEmpID1;
                string myDate = DateTime.Now.ToShortDateString();
                objTransferInfo.TransferDate = myDate;
                objTransferInfo.ApprovalStatus = "Approved";
                objTransferInfo.ApproveDate = myDate;
                objTransferInfo.TransferedBy = objTransferUser.UserID;


                int TransferID = (new EmployeeTransferTableController()).Add(objTransferInfo);
                ViewState.Add("TransferID", TransferID);

                EmployeeTransferTableInfo objGetTrans = new EmployeeTransferTableInfo();
                objGetTrans = (new EmployeeTransferTableController()).Get(TransferID);
                int TraID = objGetTrans.TransferID;

                //Keeping TransferLog

                if (TraID > 0)
                {

                    EmployeeTransferTableLogInfo objTransLogInfo = new EmployeeTransferTableLogInfo();
                    objTransLogInfo.PreviousDept = empDept1;
                    objTransLogInfo.NewDept = Convert.ToInt32(this.transferNewDeptList.SelectedValue);
                    objTransLogInfo.PrevWorkLocation = empWorkLoc1;
                    objTransLogInfo.DesireLocation = Convert.ToInt32(this.transferNewWokLocList.SelectedValue);
                    objTransLogInfo.NewWorkLcation = Convert.ToInt32(this.transferNewWokLocList.SelectedValue);
                    objTransLogInfo.TransferType = this.transferTypeList.SelectedItem.Text.Trim();
                    objTransLogInfo.TransferReason = this.txtTransferReason.Text.Trim();
                    objTransLogInfo.EmployeeID_FK = transferEmpID1;
                    objTransLogInfo.TransferDate = myDate;
                    objTransLogInfo.ApprovalStatus = "Approved";
                    objTransLogInfo.ApproveDate = myDate;
                    objTransLogInfo.TransferedBy = objTransferUser.UserID;
                    objTransLogInfo.TransferID_FK = TraID;

                    int TransferLogID = (new EmployeeTransferTableLogController()).Add(objTransLogInfo);

                    string preDept = LbTransferPreDept.Text;
                    string newDept = transferNewDeptList.SelectedItem.ToString();
                    string preLoc = LbTransferPreWorkLoc.Text;
                    string newLoc = transferNewWokLocList.SelectedItem.ToString();

                    //Updating EmployeeTable with Transfer details

                    if (TransferID > 0 && TransferLogID > 0)
                    {
                        //EmployeeTransferTableInfo objTransferInfo2 = new EmployeeTransferTableInfo();
                        //int tranEmpID = TransferID;
                        //objTransferInfo2 = (new EmployeeTransferTableController()).Get(tranEmpID);

                        EmployeeWorkLocationsInfo objTransferEmpWorkLoc2 = new EmployeeWorkLocationsInfo();
                        int empWorkLoc2 = objGetTrans.NewWorkLcation;
                        objTransferEmpWorkLoc2 = (new EmployeeWorkLocationsController()).Get(empWorkLoc2);


                        //int newWokLoc = objTransferInfo2.NewWorkLcation;
                        //int newDept2 = objTransferInfo2.NewDept;

                        EmployeeDetailsInfo objemployee2 = new EmployeeDetailsInfo();
                        objemployee2.EmployeeID = objGetTrans.EmployeeID_FK;
                        //transferEmpID1;
                        objemployee2.Department_FK = objGetTrans.NewDept;
                        //newDept2;
                        objemployee2.WorkLocation_FK = objGetTrans.NewWorkLcation;
                        //newWokLoc;
                        (new EmployeeDetailsController()).TransferUpdate(objemployee2);


                        LbTransferSuccessful.Text = "Employee " + objTransferEmpDetails1.LastName + " " + "has been moved from " + preLoc + " " + "to " + newLoc + ", " + objTransferEmpWorkLoc2.LocationAddress;
                        LbTransferSuccessful.Visible = true;
                    }

                    else
                    {
                        LbTransferSuccessful.Text = " Transfer Not Successful";
                        LbTransferSuccessful.Visible = true;
                    }
                }

                else
                {
                    LbTransferSuccessful.Text = " Transfer Not Successful";
                    LbTransferSuccessful.Visible = true;
                }
            }

            catch { }

        }
        #endregion


        #region "SelfReaquestTransfer

        protected void BindTransferGView()
        {

            ArrayList objArrTransferApproval = new ArrayList();

            ArrayList objTransferApproval = new ArrayList();

            objTransferApproval = (new EmployeeTransferTableController()).NewList();

            //Where i stopped on 22nd of Nov.
            //Error with List, NewList and ApprovalList
            //Yet to be resolved


            if (objTransferApproval.Count > 0)
            {
                foreach (EmployeeTransferTableInfo objTransfer in objTransferApproval)
                {

                    EmployeeTransferTableInfo objMoveInfo = new EmployeeTransferTableInfo();

                    objMoveInfo.EmployeeNum = objTransfer.EmployeeNum;
                    objMoveInfo.PreviousDept = objTransfer.PreviousDept;
                    objMoveInfo.PrevWorkLocation = objTransfer.PrevWorkLocation;
                    objMoveInfo.DesireLocation = objTransfer.DesireLocation;
                    //objMoveInfo.NewWorkLcation = objTransfer.NewWorkLcation;
                    objMoveInfo.PreviousDept = objTransfer.PreviousDept;
                    //objMoveInfo.NewDept = objTransfer.NewDept;
                    objMoveInfo.TransferType = objTransfer.TransferType;
                    objMoveInfo.TransferReason = objTransfer.TransferReason;
                    objMoveInfo.RequestDate = objTransfer.RequestDate;
                    objMoveInfo.ApprovalStatus = objTransfer.ApprovalStatus;
                    objMoveInfo.ApproveDate = objTransfer.ApproveDate;
                    objMoveInfo.EmployeeID_FK = objTransfer.EmployeeID_FK;
                    objMoveInfo.TransferID = objTransfer.TransferID;
                    // objMoveInfo.TransferID_FK = objTransfer.TransferID_FK;
                    // objMoveInfo.TransferLogID = objTransfer.TransferLogID;
                    // objMoveInfo.TransferedBy = objTransfer.TransferedBy;
                    objMoveInfo.TransferDate = objTransfer.TransferDate;

                    EmployeeTransferTableInfo objNewMoveInfo = new EmployeeTransferTableInfo();
                    objNewMoveInfo = (new EmployeeTransferTableController()).ApprovalNameNewList(objMoveInfo);
                    if (objNewMoveInfo != null)

                        objArrTransferApproval.Add(objNewMoveInfo);

                }
                GViewTransferApproval.DataSource = objArrTransferApproval;
                GViewTransferApproval.DataBind();
                GViewTransferApproval.Visible = true;
                //}


            }
        }
        protected void GViewTransferApproval_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                DropDownList transferNewDept = e.Row.FindControl("transferNewDept") as DropDownList;
                DropDownList transferNewWorkLoc = e.Row.FindControl("transferNewWorkLoc") as DropDownList;
                DropDownList transferApprovalStatus = e.Row.FindControl("transferApprovalStatus") as DropDownList;

                ArrayList objTransDept = new ArrayList();
                objTransDept = (new EmployeeDepartmentTableController()).List();

                if (transferNewDept != null)

                    transferNewDept.DataSource = objTransDept;
                transferNewDept.DataTextField = "DeptName";
                transferNewDept.DataValueField = "DeptID";
                transferNewDept.DataBind();

                transferNewDept.Items.Insert(0, new ListItem("***Please select***", "-1"));

                ArrayList objTransLoc = new ArrayList();
                objTransLoc = (new EmployeeWorkLocationsController()).List();

                if (transferNewWorkLoc != null)

                    transferNewWorkLoc.DataSource = objTransLoc;
                transferNewWorkLoc.DataTextField = "LocationName";
                transferNewWorkLoc.DataValueField = "WorkLocationID";
                transferNewWorkLoc.DataBind();

                transferNewWorkLoc.Items.Insert(0, new ListItem("***Please select***", "-1"));

                UserInfo objTransferUser = new UserInfo();
                objTransferUser = (new UserController()).GetUser(0, UserId);


                //Declaring textbox

                TextBox AD = new TextBox();
                TextBox TD = new TextBox();
                TextBox Eid = new TextBox();
                TextBox TBy = new TextBox();
                TextBox Tid = new TextBox();
                // TextBox TFK = new TextBox();
                //TextBox Tlog = new TextBox();

                // find the textbox containing the applicantID on the gridview 
                AD = (TextBox)e.Row.FindControl("txtApprovedate");
                TD = (TextBox)e.Row.FindControl("txtTransferdate");
                Eid = (TextBox)e.Row.FindControl("txtTransferEmpID");
                TBy = (TextBox)e.Row.FindControl("txtTranferedBy");
                Tid = (TextBox)e.Row.FindControl("txtTranferID");
                // TFK = (TextBox)e.Row.FindControl("txtTranferID_FK");
                // Tlog = (TextBox)e.Row.FindControl("txtTranferLogID");

                string date2 = DateTime.Now.ToShortDateString();
                AD.Text = date2;
                TD.Text = date2;
                TBy.Text = objTransferUser.UserID.ToString();
                string ApprovalDate = AD.Text;
                string EmplID = Eid.Text;
                string TransferDate = TD.Text;
                string TransferedBy = TBy.Text;
                string Trans = Tid.Text;
                //  string TransferID_FK = TFK.Text;
                //  string TransLogID = Tlog.Text;
                ApprovalDate = date2;
                TransferDate = date2;
                TransferedBy = objTransferUser.UserID.ToString();
                int TransferID = Convert.ToInt32(Trans);
                // int TransferLogID = Convert.ToInt32(TransLogID);
                int EmployeeID = Convert.ToInt32(EmplID);
                ViewState.Add("TransferID", TransferID);
                // ViewState.Add("TransferLogID", TransferLogID);
                ViewState.Add("EmployeeID", EmployeeID);
                ViewState.Add("date2", date2);
                // BindTransferGView();
            }
        }
        protected void GViewTransferApproval_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GViewTransferApproval.EditIndex = e.NewEditIndex;
            BindTransferGView();

        }
        protected void GViewTransferApproval_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GViewTransferApproval.EditIndex = -1;
            BindTransferGView();
        }

        protected void GViewTransferApproval_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // DropDownList transferNewDept = e.Row.FindControl("transferNewDept") as DropDownList;
            //        DropDownList transferNewWorkLoc = e.Row.FindControl("transferNewWorkLoc") as DropDownList;
            //        DropDownList transferApprovalStatus = e.Row.FindControl("transferApprovalStatus") as DropDownList;

            //foreach (GridViewRow x in GViewTransferApproval.Rows)
            // GridViewRow x in GViewTransferApproval.Rows;
            //{

            int TransferID = Convert.ToInt32(ViewState["TransferID"]);

            int TEid = Convert.ToInt32(ViewState["EmployeeID"]);
            string dat = ViewState["date2"].ToString();

            EmployeeTransferTableInfo objTransferUpdate = new EmployeeTransferTableInfo();

            objTransferUpdate.ApproveDate = ((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[7].FindControl("txtApprovedate"))).Text;
            objTransferUpdate.TransferDate = ((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[8].FindControl("txtTransferdate"))).Text;
            objTransferUpdate.NewDept = Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[9].FindControl("transferNewDept"))).SelectedValue);
            objTransferUpdate.NewWorkLcation = Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[10].FindControl("transferNewWorkLoc"))).SelectedValue);
            objTransferUpdate.ApprovalStatus = ((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[11].FindControl("transferApprovalStatus"))).SelectedItem.Text.Trim();
            objTransferUpdate.TransferedBy = Convert.ToInt32(((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[13].FindControl("txtTranferedBy"))).Text);
            objTransferUpdate.TransferID = Convert.ToInt32(((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[14].FindControl("txtTranferID"))).Text);

            (new EmployeeTransferTableController()).ApprovalUpdate(objTransferUpdate);
            // BindTransferGView();
            // }
            int TransferLogID2 = Convert.ToInt32(ViewState["TransferLogID"]);
            // int TEid2 = Convert.ToInt32(ViewState["EmployeeID"]);
            EmployeeTransferTableInfo objGetTDetails = new EmployeeTransferTableInfo();
            objGetTDetails = (new EmployeeTransferTableController()).GetByEmployeeDetailsForInfo(TEid);
            //objGetDetails = (new EmployeeTransferTableController()).Get(TransferID);

            EmployeeTransferTableLogInfo objGetTLog = new EmployeeTransferTableLogInfo();
            int TID = objGetTDetails.TransferID;
            objGetTLog = (new EmployeeTransferTableLogController()).GetByEmployeeTransferTableForInfo(TID);
            int TLogID = objGetTLog.TransferLogID;
            int TFK = objGetTLog.TransferID_FK;

            if ((objGetTDetails.NewDept > 0) && (objGetTDetails.NewWorkLcation > 0))
            {
                //Keeping log
                EmployeeTransferTableLogInfo objTransferLogUpdate = new EmployeeTransferTableLogInfo();
                objTransferLogUpdate.ApproveDate = objGetTDetails.ApproveDate;
                //((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[6].FindControl("txtApprovedate"))).Text;
                objTransferLogUpdate.TransferDate = objGetTDetails.TransferDate;
                //((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[7].FindControl("txtTransferdate"))).Text;
                objTransferLogUpdate.NewDept = objGetTDetails.NewDept;
                //Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[8].FindControl("transferNewDept"))).SelectedValue);
                objTransferLogUpdate.NewWorkLcation = objGetTDetails.NewWorkLcation;
                //Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[9].FindControl("transferNewWorkLoc"))).SelectedValue);
                objTransferLogUpdate.ApprovalStatus = objGetTDetails.ApprovalStatus;
                //((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[10].FindControl("transferApprovalStatus"))).SelectedItem.Text.Trim();
                objTransferLogUpdate.TransferedBy = objGetTDetails.TransferedBy;
                //Convert.ToInt32(((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[12].FindControl("txtTranferedBy"))).Text);

                objTransferLogUpdate.TransferID_FK = TFK;
                //objGetTDetails.TransferID;
                // Convert.ToInt32(((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[15].FindControl("txtTranferID_FK"))).Text);
                objTransferLogUpdate.TransferLogID = TLogID;
                //TLogIDConvert.ToInt32(((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[16].FindControl("txtTranferLogID"))).Text);

                (new EmployeeTransferTableLogController()).LogApprovalUpdate(objTransferLogUpdate);
                //BindTransferGView();



                EmployeeDetailsInfo objemployee2 = new EmployeeDetailsInfo();
                objemployee2.EmployeeID = TEid;
                objemployee2.Department_FK = objGetTDetails.NewDept;
                //Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[8].FindControl("transferNewDept"))).SelectedValue);
                objemployee2.WorkLocation_FK = objGetTDetails.NewWorkLcation;
                //Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[9].FindControl("transferNewWorkLoc"))).SelectedValue);
                objemployee2.TransferedBy = objGetTDetails.TransferedBy;
                //Convert.ToInt32(((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[12].FindControl("txtTranferedBy"))).Text);
                objemployee2.TransferDate = objGetTDetails.TransferDate;
                //((TextBox)(GViewTransferApproval.Rows[e.RowIndex].Cells[7].FindControl("txtTransferdate"))).Text;

                (new EmployeeDetailsController()).TransferUpdate(objemployee2);

                //Checking for update


                EmployeeTransferTableInfo objTransferCheck = new EmployeeTransferTableInfo();
                objTransferCheck = (new EmployeeTransferTableController()).GetByEmployeeDetailsForInfo(TEid);

                EmployeeTransferTableLogInfo objTransferLogCheck = new EmployeeTransferTableLogInfo();
                objTransferLogCheck = (new EmployeeTransferTableLogController()).Get(TLogID);

                EmployeeDetailsInfo objTransEmp = new EmployeeDetailsInfo();
                objTransEmp = (new EmployeeDetailsController()).Get(TEid);

                if ((objTransferCheck.ApproveDate != null) && (objTransferLogCheck.ApproveDate != null) &&
                    (objTransferCheck.NewWorkLcation == Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[9].FindControl("transferNewWorkLoc"))).SelectedValue))
                    && (objTransferLogCheck.NewWorkLcation == objTransferCheck.NewWorkLcation) &&
                    (objTransferCheck.NewDept == Convert.ToInt32(((DropDownList)(GViewTransferApproval.Rows[e.RowIndex].Cells[8].FindControl("transferNewDept"))).SelectedValue))
                    && (objTransferLogCheck.NewDept == objTransferCheck.NewDept) &&
                    (objTransEmp.Department_FK == objTransferCheck.NewDept) && (objTransEmp.WorkLocation_FK == objTransferCheck.NewWorkLcation))
                {
                    LbTransferUpdateSuccessful.Text = "Transfer Update Successful";
                    LbTransferUpdateSuccessful.Visible = true;
                }
                else
                {
                    LbTransferUpdateSuccessful.Text = "Transfer Update Not Successful";
                    LbTransferUpdateSuccessful.Visible = true;
                }

            }


            else
            {
                LbTransferUpdateSuccessful.Text = "Transfer Update Not Successful";
                LbTransferUpdateSuccessful.Visible = true;
            }
            //}
        }

        #endregion 

        #region "TransferHistory"

        protected void LinkBtnTransferEmployee_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 9;
            PanelTransfer.Visible = false;

        }
        protected void LinkBtnViewTransferHistory_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 24;

            ArrayList objGetTDept = new ArrayList();
            objGetTDept = (new EmployeeDepartmentTableController()).List();

            if (objGetTDept.Count > 0)
            {
                ddTranHistoryDept.DataSource = objGetTDept;
                ddTranHistoryDept.DataTextField = "DeptName";
                ddTranHistoryDept.DataValueField = "DeptID";
                ddTranHistoryDept.DataBind();
            }
            ddTranHistoryDept.Items.Insert(0, new ListItem("***Please select***", "-1"));
        }
        protected void ddTranHistoryDept_SelectedIndexChanged(object sender, EventArgs e)
        {

            ArrayList objTHDeptEmp = new ArrayList();
            int tHDept = Convert.ToInt32(ddTranHistoryDept.SelectedValue);
            objTHDeptEmp = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(tHDept);
            if (objTHDeptEmp.Count > 0)
            {
                ddTranHistoryEmp.DataSource = objTHDeptEmp;
                ddTranHistoryEmp.DataTextField = "EmployeeNum";
                ddTranHistoryEmp.DataValueField = "EmployeeID";
                ddTranHistoryEmp.DataBind();
                ddTranHistoryEmp.Items.Insert(0, new ListItem("***Please select***", "-1"));
                ddTranHistoryEmp.Visible = true;
                LbTHEmp.Visible = true;

            }

        }
        protected void ddTranHistoryEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ArrayList objArrTransferHistory = new ArrayList();

            ArrayList objTransferID = new ArrayList();
          int empids = Convert.ToInt32(ddTranHistoryEmp.SelectedValue);
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
                        //(new EmployeeTransferTableLogController()).LogListEmployeeTransferRecords(objTranInfo);
                    if (objNewTransInfo != null)
                        objArrTransferHistory.Add(objNewTransInfo);

                }
                GViewTransHistory.DataSource = objArrTransferHistory;
                GViewTransHistory.DataBind();
                GViewTransHistory.Visible = true;
            }
        }
        

        #endregion

        #endregion



        //New Appraisal Module

        #region
      protected void RecommendBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 14;
        }

        #region
        protected void ManagementBtn_Click(object sender, EventArgs e)
              {

            MViewHRPage.ActiveViewIndex = 13;

            //List all Recommended and Approved Employee for Promotion

            ArrayList objManagement = new ArrayList();
            objManagement = (new EmployeeAppraisalTableController()).ManagementApprovalList();

            if (objManagement != null)
            {
                GViewAppraisalManagementDecision.DataSource = objManagement;
                GViewAppraisalManagementDecision.DataBind();
                GViewAppraisalManagementDecision.Visible = true;
            }
             string date4 = DateTime.Now.ToShortDateString();
             LbManagementDate.Text = date4;
            LbManagementDate.Visible=true;

        }

//Saving Management Desicision
        protected void managementSaveBtn_Click(object sender, EventArgs e)
        {
            
            foreach (GridViewRow x in GViewAppraisalManagementDecision.Rows)
            {
                // declare a variable as textbox
                TextBox emid = new TextBox();
                TextBox appid = new TextBox();
                TextBox suid = new TextBox();

                // find the textbox containing the applicantID on the gridview 

                emid = (TextBox)x.FindControl("txtManageEmpID_FK");
                suid = (TextBox)x.FindControl("txtManageSupID_FK");
                appid = (TextBox)x.FindControl("txtManageApplID");

                string emp = emid.Text;
                string empid = suid.Text;
                string apprid = appid.Text;
                int appra = Convert.ToInt32(apprid);

                  CheckBox c = new CheckBox();
                c = (CheckBox)x.FindControl("CheckBoxSelectEmp");
                if (c.Checked == true)
                {
                    try
                    {
                        // string date4 = DateTime.Now.ToShortDateString();
                        // LbManagementDate.Text = date4;
                        // Update Management Decision on Appraisal tabel 
                        EmployeeAppraisalTableInfo objManageInfo = new EmployeeAppraisalTableInfo();
                        objManageInfo.AppraisalID = appra;
                        //Convert.ToInt32(apprid);
                        objManageInfo.ManagementDecision = appraisalManagementDecisionList.SelectedItem.Text;
                        objManageInfo.ManagementDecisionDate = this.LbManagementDate.Text.Trim();
                        new EmployeeAppraisalTableController().ManagementDecisionUpdate(objManageInfo);

                        EmployeeAppraisalTableLogInfo objLogManageInfo = new EmployeeAppraisalTableLogInfo();
                        objLogManageInfo.AppraisalID_FK = Convert.ToInt32(apprid);
                        objLogManageInfo.ManagementDecision = appraisalManagementDecisionList.SelectedItem.Text;
                        objLogManageInfo.ManagementDecisionDate = this.LbManagementDate.Text.Trim();
                        new EmployeeAppraisalTableLogController().LogManagementDecisionUpdate(objLogManageInfo);

                        EmployeeAppraisalTableInfo objManageInfoGet = new EmployeeAppraisalTableInfo();
                        objManageInfoGet = (new EmployeeAppraisalTableController()).Get(appra);


                        EmployeeAppraisalTableLogInfo objLogManageInfoGet = new EmployeeAppraisalTableLogInfo();
                        objLogManageInfoGet = (new EmployeeAppraisalTableLogController()).GetByEmployeeAppraisalTable(appra);

                        //if (objQualifInfo.EmployeeID_FK == Convert.ToInt32(empid))
                        if (objManageInfoGet.ManagementDecision != null && objLogManageInfoGet.ManagementDecision != null)
                        {
                            ///Alhaja lo so be ooooooo


                            LbDecision.Visible = true;
                            LbDecision.Text = "Management Decision Info Updated";

                        }

                        else
                        {
                            LbDecision.Visible = true;
                            LbDecision.Text = "Management Decision Info Not Updated";
                        }

                    }


                    catch
                    {

                    }
                }
            }
        }
              
              
              

        #endregion


        //Displaying Details

        #region
        protected void appraisalEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PanelSelfAssessment.Visible = true;

            EmployeeDetailsInfo objEmpDetails = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(appraisalEmployeeList.SelectedValue);
            objEmpDetails = (new EmployeeDetailsController()).Get(empID);

            ViewState.Add("empID", empID);

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

            //Where i am on 27/09/2018
            // i need to a storedprocedure

            EmployeeAppraisalTableLogInfo objEmpEntry = new EmployeeAppraisalTableLogInfo();
            objEmpEntry = (new EmployeeAppraisalTableLogController()).LogGetByEmpID(empID);

            UserInfo objHR = new UserInfo();
            int userHR = objEmpDetails.HRID;
            objHR = (new UserController()).GetUser(0, userHR);

            LbEmpSup.Text = objSup.LastName + " " + objSup.FirstName;
            LbEmpSup.Visible = true;
            LbSelfAppraisalScore.Text = objEmpEntry.AppraisalScore.ToString();
            LbSelfAppraisalScore.Visible = true;
            LbEmpDept.Text = objDept.DeptName;
            LbEmpDept.Visible = true;
            LbEmpPosition.Text = objPost.PositionName;
            LbEmpPosition.Visible = true;
            LbHRName.Text = objHR.DisplayName;
            LbHRName.Visible = true;
            string mydate = DateTime.Now.ToShortDateString();
            LbHRAppraisalDate.Text = mydate;
            LbHRAppraisalDate.Visible = true;
            LbAppraisalStartYear.Text = objApprais.AprpraisalStartYear;
            LbAppraisalStartYear.Visible = true;
            LbEvalPeriod.Text = objApprais.EvaPeriod;
            LbEvalPeriod.Visible = true;
            //  LbSelfAppraisalScore.Visible = true;
            // LbSelfAppraisalScore.Text = objEmpEntry.AppraisalScore.ToString();
            LbSupAppraisalScore.Text = objApprais.AppraisalScore.ToString();
            LbSupAppraisalScore.Visible = true;
            HRPromoRecomList.Visible = true;
            HRSaveBtn.Visible = true;
        }

        #endregion 

        //Calculating TotalAppraisalScore

        #region
        protected void txtExamScore_TextChanged(object sender, EventArgs e)
        {

            int appScore = Convert.ToInt32(LbSupAppraisalScore.Text);
            int exam = Convert.ToInt32(txtExamScore.Text);
            int total = appScore + exam;
            txtTotalExamScore.Text = total.ToString();
            txtTotalExamScore.Visible = true;
        }

        #endregion


        //Saving New HR Appraisal

        #region
        protected void HRSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                EmployeeDetailsInfo objEmpDetails = new EmployeeDetailsInfo();
                int empDetails = Convert.ToInt32(appraisalEmployeeList.SelectedValue);
                objEmpDetails = (new EmployeeDetailsController()).Get(empDetails);
                ViewState.Add("empDetails", empDetails);

                UserInfo objHR = new UserInfo();
                objHR = (new UserController()).GetUser(0, UserId);

                EmployeeAppraisalTableInfo objEmpAppraisal = new EmployeeAppraisalTableInfo();
                int AppEmpID = empDetails;
                objEmpAppraisal = (new EmployeeAppraisalTableController()).GetByEmpID(AppEmpID);


                EmployeeAppraisalTableInfo objAppriasalInfo = new EmployeeAppraisalTableInfo();

                objAppriasalInfo.TotalAppraisalScore = Convert.ToInt32(this.txtTotalExamScore.Text);
                objAppriasalInfo.PromoExamScore = Convert.ToInt32(this.txtExamScore.Text);
                objAppriasalInfo.AppraisalStatus = "3";
                objAppriasalInfo.HrAppraisalDate = this.LbHRAppraisalDate.Text.Trim();
                objAppriasalInfo.HRPromoRecommendation = this.HRPromoRecomList.SelectedItem.Text.Trim();
                objAppriasalInfo.HRComment = this.txtHRComments.Text.Trim();
                objAppriasalInfo.EmployeeID_FK = Convert.ToInt32(appraisalEmployeeList.SelectedValue);
                objAppriasalInfo.HRID_FK = objHR.UserID;
                objAppriasalInfo.AppraisalID = objEmpAppraisal.AppraisalID;

                (new EmployeeAppraisalTableController()).HRAppraisalScoreUpdate(objAppriasalInfo);

                EmployeeAppraisalTableInfo objAppriasalInfo2 = new EmployeeAppraisalTableInfo();
                int appraise = objEmpAppraisal.AppraisalID;
                objAppriasalInfo2 = (new EmployeeAppraisalTableController()).Get(appraise);


                EmployeeAppraisalTableLogInfo objAppriasalLogInfo = new EmployeeAppraisalTableLogInfo();

                objAppriasalLogInfo.EmployeeNum = objEmpDetails.EmployeeNum;
                objAppriasalLogInfo.AppraisalScore = objAppriasalInfo2.AppraisalScore;
                objAppriasalLogInfo.PromoExamScore = Convert.ToInt32(txtExamScore.Text);
                objAppriasalLogInfo.TotalAppraisalScore = Convert.ToInt32(this.txtTotalExamScore.Text);
                objAppriasalLogInfo.TotalPoint = objAppriasalInfo2.TotalPoint;
                objAppriasalLogInfo.EvaPeriod = objAppriasalInfo2.EvaPeriod;
                objAppriasalLogInfo.AprpraisalStartYear = objAppriasalInfo2.AprpraisalStartYear;
                objAppriasalLogInfo.AppraisalStatus = "3";
                objAppriasalLogInfo.SupAppraisalDate = objAppriasalInfo2.SupAppraisalDate;
                objAppriasalLogInfo.EmpAppraisalDate = objAppriasalInfo2.EmpAppraisalDate;
                objAppriasalLogInfo.PromoRecommendation = objAppriasalInfo2.PromoRecommendation;
                objAppriasalLogInfo.SupComment = objAppriasalInfo2.SupComment;
                objAppriasalLogInfo.HrAppraisalDate = LbHRAppraisalDate.Text.Trim();
                objAppriasalLogInfo.HRComment = this.txtHRComments.Text.Trim();
                objAppriasalLogInfo.HRPromoRecommendation = this.HRPromoRecomList.SelectedItem.Text.Trim();
                objAppriasalLogInfo.EmployeeID_FK = empDetails;
                objAppriasalLogInfo.SupervisorID_FK = objAppriasalInfo2.SupervisorID_FK;
                objAppriasalLogInfo.HRID_FK = objHR.UserID;
                objAppriasalLogInfo.AppraisalID_FK = objAppriasalInfo2.AppraisalID;
                objAppriasalLogInfo.SentBy = 3;

                int AppraisalLogID = (new EmployeeAppraisalTableLogController()).LogHREmpAdd(objAppriasalLogInfo);
                ViewState.Add("AppraisalLogID", AppraisalLogID);

                if (objAppriasalInfo2.AppraisalStatus == "3" && AppraisalLogID != null)
                {
                    Utility.Alert("Employee has been successfull recommended for promotion");

                    PanelHRAppraisal.Visible = false;
                    lbAppraisalRecomSuccessful.Visible = true;
                    lbAppraisalRecomSuccessful.Text = "Employee has been successfull recommended for promotion";
                }

            }
            catch (Exception ex)
            {

                string msg = "Detail Not Updated";
                msg += ex.Message;
                Utility.Alert(msg);
                // Alert.Show("You are inserting duplicate values");

            }
        }

        #endregion


        //Printing Self Appraisal Details

        #region

        protected void LinkEmpSelfAppraisal_Click(object sender, EventArgs e)
        {
           
                      PanelSelfAppraisalDetails.Visible = true;
                      PanelHRAppraisal.Visible = false;

                      int empID = Convert.ToInt32(ViewState["empID"]);
                      ArrayList objSelf = new ArrayList();
                      //int empID3 = Convert.ToInt32(printAppraisalEmployeeList.SelectedValue);
                      objSelf = (new EmployeeAppraisalTableLogController()).LogGetEmpAppraisalDetailsByEmpID(empID);
                      ViewState.Add("empID3", empID);

                      if (objSelf != null)
                      {
                          GViewSelfAppraisalDetails.DataSource = objSelf;
                          GViewSelfAppraisalDetails.DataBind();
                          GViewSelfAppraisalDetails.Visible = true;
                         // SelfAppraisalPrintBtn.Visible = true;
                      }

                      ArrayList objEmpGoal = new ArrayList();
                      //int empID3 = Convert.ToInt32(printAppraisalEmployeeList.SelectedValue);
                      objEmpGoal = (new EmployeeApprasalTableGoalLogController()).GoalLogEmpGetByEmpID(empID);

                      if (objEmpGoal != null)
                      {
                          GViewSelfAppraisalGoal.DataSource = objEmpGoal;
                          GViewSelfAppraisalGoal.DataBind();
                          GViewSelfAppraisalGoal.Visible = true;
                         // SelfAppraisalPrintBtn.Visible = true;
                      }

                      ArrayList objSup = new ArrayList();

                      objSup = (new EmployeeAppraisalTableLogController()).LogGetSupAppraisalDetailsByEmpID(empID);
                      ViewState.Add("empID3", empID);

                      if (objSup != null)
                      {
                          GViewSupAppraisalDetails.DataSource = objSup;
                          GViewSupAppraisalDetails.DataBind();
                          GViewSupAppraisalDetails.Visible = true;
                          SelfAppraisalPrintBtn.Visible = true;
                      }


                      ArrayList objSupGoal = new ArrayList();
                      //int empID3 = Convert.ToInt32(printAppraisalEmployeeList.SelectedValue);
                      objSupGoal = (new EmployeeApprasalTableGoalLogController()).GoalLogSupGetByEmpID(empID);

                      if (objSupGoal != null)
                      {
                          GViewSupAppraisalGoal.DataSource = objSupGoal;
                          GViewSupAppraisalGoal.DataBind();
                          GViewSupAppraisalGoal.Visible = true;
                          SelfAppraisalPrintBtn.Visible = true;
                      }


              }
        //protected void printAppraisalEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int empID = Convert.ToInt32(ViewState["empID"]);
        //    ArrayList objSelf = new ArrayList();
        //    //int empID3 = Convert.ToInt32(printAppraisalEmployeeList.SelectedValue);
        //    objSelf = (new EmployeeAppraisalTableLogController()).LogGetEmpAppraisalDetailsByEmpID(empID);
        //   // ViewState.Add("empID", empID);

        //    if (objSelf != null)
        //    {
        //        GViewSelfAppraisalDetails.DataSource = objSelf;
        //        GViewSelfAppraisalDetails.DataBind();
        //        GViewSelfAppraisalDetails.Visible = true;
        //        SelfAppraisalPrintBtn.Visible = true;
        //    }

        


        //}

     

     
        //Print

        #region
     
        protected void SelfAppraisalPrintBtn_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(ViewState["empID"]);

           // printAppraisalEmployeeList.Visible = false;
            //LbEmp.Visible = false;
            SelfAppraisalPrintBtn.Visible = false;
          Utility.PrintHelper.PrintWebControl(PanelSelfAppraisalDetails);
           
        }
        
        #endregion

        #endregion


        //New Print Self Appraisal

          #region
        protected void LinkPrintSelf_Click(object sender, EventArgs e)
        {
            PanelNewSelfAppraisal.Visible = true;
            LbEmp.Visible = true;
            printAppraisalEmployeeList.Visible = true;
            
            ArrayList objSelfApp = new ArrayList();
            objSelfApp = (new EmployeeDetailsController()).SelfAppraisalList();

            if (objSelfApp.Count > 0)
            {

                printAppraisalEmployeeList.DataSource = objSelfApp;
                printAppraisalEmployeeList.DataTextField = "EmployeeNum";
                printAppraisalEmployeeList.DataValueField = "EmployeeID";
                printAppraisalEmployeeList.DataBind();
                
            }
            printAppraisalEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));
        }

        protected void printAppraisalEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objNewSelf = new ArrayList();
            int empID3 = Convert.ToInt32(printAppraisalEmployeeList.SelectedValue);
            objNewSelf = (new EmployeeAppraisalTableLogController()).LogGetEmpAppraisalDetailsByEmpID(empID3);
            ViewState.Add("empID3", empID3);

            if (objNewSelf != null)
            {

                GViewNewSelfAppraisal.DataSource = objNewSelf;
                GViewNewSelfAppraisal.DataBind();
                GViewNewSelfAppraisal.Visible = true;
                LbEmpDetails.Visible = true;
               
                //GViewNewSelfAppraisal.Visible = true;
            }

            ArrayList objEmpGoal = new ArrayList();
            //int empID3 = Convert.ToInt32(printAppraisalEmployeeList.SelectedValue);
            objEmpGoal = (new EmployeeApprasalTableGoalLogController()).GoalLogEmpGetByEmpID(empID3);

            if (objEmpGoal != null)
            {

                GViewNewSelfAppraisalGoal.DataSource = objEmpGoal;
                GViewNewSelfAppraisalGoal.DataBind();
                GViewNewSelfAppraisalGoal.Visible = true;
                SelfAppraisalPrintBtn.Visible = true;
                LbGoalDetails.Visible = true;
                newPrintSelfAppraisal.Visible = true;
            }


            ArrayList objNewSup = new ArrayList();

            objNewSup = (new EmployeeAppraisalTableLogController()).LogGetSupAppraisalDetailsByEmpID(empID3);

            if (objNewSup != null)
            {

                GViewNewSupAppraisal.DataSource = objNewSup;
                GViewNewSupAppraisal.DataBind();
                GViewNewSupAppraisal.Visible = true;
                LbNewSupAppraisalDetails.Visible = true;

                //GViewNewSelfAppraisal.Visible = true;
            }

            ArrayList objNewSupGoal = new ArrayList();
            //int empID3 = Convert.ToInt32(printAppraisalEmployeeList.SelectedValue);
            objNewSupGoal = (new EmployeeApprasalTableGoalLogController()).GoalLogSupGetByEmpID(empID3);

            if (objNewSupGoal != null)
            {

                GViewNewSupAppraisalGoal.DataSource = objNewSupGoal;
                GViewNewSupAppraisalGoal.DataBind();
                GViewNewSupAppraisalGoal.Visible = true;
                SelfAppraisalPrintBtn.Visible = true;
                LbNewSupGoalDetails.Visible = true;
                newPrintSelfAppraisal.Visible = true;
            }

        }


        protected void newPrintSelfAppraisal_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(ViewState["empID"]);

            printAppraisalEmployeeList.Visible = false;
            LbEmp.Visible = false;
            newPrintSelfAppraisal.Visible = false;
            //SelfAppraisalPrintBtn.Visible = false;
            Utility.PrintHelper.PrintWebControl(PanelNewSelfAppraisal);


        }

        #endregion


          #endregion

        //Promotion Module

        #region
        protected void LinkBtnPromote_Click(object sender, EventArgs e)
        {
            PanelPromoDisplay.Visible = true;
            LbPromoSuccessful.Visible = false;
            PanelPromoLetter.Visible = false;

        }

        protected void LinkBtnListPromotedEmp_Click(object sender, EventArgs e)
        {
            PanelPromoDisplay.Visible = false;
            PanelEmpPromoHistory.Visible = false;
            LbPromoSuccessful.Visible = false; 
            PanelPromoLetter.Visible = false;
           
            
            ArrayList objArrPromoHist = new ArrayList();

            ArrayList objPromoID = new ArrayList();
            // int promoEmp = Convert.ToInt32(ddPromoHistEmp.SelectedValue);
            objPromoID = (new EmployeePromotionTableController()).List();

            if (objPromoID.Count > 0)
            {
                foreach (EmployeePromotionTableInfo objPromoHist in objPromoID)
                {
                    EmployeePromotionTableInfo objPromoInfo = new EmployeePromotionTableInfo();
                    objPromoInfo.ApprasialID_FK = objPromoHist.ApprasialID_FK;
                    objPromoInfo.ApprasialScore = objPromoHist.ApprasialScore;
                    objPromoInfo.EmployeeID_FK = objPromoHist.EmployeeID_FK;
                    objPromoInfo.EmployeeNum = objPromoHist.EmployeeNum;
                    objPromoInfo.NewDept = objPromoHist.NewDept;
                    objPromoInfo.NewLevel = objPromoHist.NewLevel;
                    objPromoInfo.NewPosition = objPromoHist.NewPosition;
                    objPromoInfo.PreDept = objPromoHist.PreDept;
                    objPromoInfo.PreviousLevel = objPromoHist.PreviousLevel;
                    objPromoInfo.PreviousPosition = objPromoHist.PreviousPosition;
                    objPromoHist.PromoExamScore = objPromoHist.PromoExamScore;
                    objPromoInfo.PromotedBy = objPromoHist.PromotedBy;
                    objPromoInfo.PromotedDate = objPromoHist.PromotedDate;
                    objPromoInfo.PromotionID = objPromoHist.PromotionID;

                    EmployeePromotionTableInfo objNewPromoInfo = new EmployeePromotionTableInfo();
                    objNewPromoInfo = (new EmployeePromotionTableController()).PromoHistList(objPromoInfo);

                    if (objNewPromoInfo != null)
                        objArrPromoHist.Add(objNewPromoInfo);

                }
                GViewPromoList.DataSource = objArrPromoHist;
                GViewPromoList.DataBind();
                GViewPromoList.Visible = true;
                PanelPromotionList.Visible = true;
                MViewHRPage.ActiveViewIndex = 26;
                btnPromoListFinish.Visible = true;
            }

            //ArrayList objPromoList = new ArrayList();
            //objPromoList = (new EmployeePromotionTableController()).List();

            //if (objPromoList.Count > 0)
            //{

            //    GViewPromoList.DataSource = objPromoList;
            //    GViewPromoList.DataBind();
            //    GViewPromoList.Visible = true;

            //}
            //MViewHRPage.ActiveViewIndex = 26;
        }


        protected void LinkBtnPromotedHist_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 26;
            PanelPromoLetter.Visible = false; 
            PanelPromoDisplay.Visible = false;
            PanelPromotionList.Visible = false;
            PanelEmpPromoHistory.Visible = true;
            LbPromoSuccessful.Visible = false;
          }

        protected void btnPromoListFinish_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 15;
            PanelPromoDisplay.Visible = false;
            LbPromoSuccessful.Visible = false;
            PanelPromoLetter.Visible = false;
        }

        protected void PromoDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objGetPromoEmp = new ArrayList();
            int proDept = Convert.ToInt32(PromoDepartmentList.SelectedValue);
            objGetPromoEmp = (new EmployeeDetailsController()).PromotionList(proDept);
            if (objGetPromoEmp.Count > 0)
            {
                PromoEmployeeList.DataSource = objGetPromoEmp;
                PromoEmployeeList.DataTextField = "EmployeeNum";
                PromoEmployeeList.DataValueField = "EmployeeID";
                PromoEmployeeList.DataBind();
                PromoEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));
            }
        }
        protected void ddPromoHistDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            GViewPromoHistory.Visible = false;
            ArrayList objGetPromoEmp = new ArrayList();
            int deptEmp = Convert.ToInt32(ddPromoHistDept.SelectedValue);
            objGetPromoEmp = (new EmployeeDetailsController()).GetByEmployeeDepartmentTableForPromoHist(deptEmp);
            if (objGetPromoEmp.Count > 0)
            {
                ddPromoHistEmp.DataSource = objGetPromoEmp;
                ddPromoHistEmp.DataTextField = "EmployeeNum";
                ddPromoHistEmp.DataValueField = "EmployeeID";
                ddPromoHistEmp.DataBind();

                ddPromoHistEmp.Items.Insert(0, new ListItem("***Please select***", "-1"));
            }
        }
        protected void ddPromoHistEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

            GViewPromoHistory.Visible = false;
            ArrayList objArrPromoHist = new ArrayList();
            ArrayList objPromoID = new ArrayList();
            int promoEmp = Convert.ToInt32(ddPromoHistEmp.SelectedValue);
            objPromoID = (new EmployeePromotionTableController()).ListByEmployeeDetails(promoEmp);

            if(objPromoID.Count > 0)
            {
                foreach(EmployeePromotionTableInfo objPromoHist in objPromoID)
                {
                    EmployeePromotionTableInfo objPromoInfo = new EmployeePromotionTableInfo();
                    objPromoInfo.ApprasialID_FK = objPromoHist.ApprasialID_FK;
                    objPromoInfo.ApprasialScore = objPromoHist.ApprasialScore;
                    objPromoInfo.EmployeeID_FK = objPromoHist.EmployeeID_FK;
                    objPromoInfo.EmployeeNum = objPromoHist.EmployeeNum;
                    objPromoInfo.NewDept = objPromoHist.NewDept;
                    objPromoInfo.NewLevel = objPromoHist.NewLevel;
                    objPromoInfo.NewPosition = objPromoHist.NewPosition;
                    objPromoInfo.PreDept = objPromoHist.PreDept;
                    objPromoInfo.PreviousLevel = objPromoHist.PreviousLevel;
                    objPromoInfo.PreviousPosition = objPromoHist.PreviousPosition;
                    objPromoHist.PromoExamScore = objPromoHist.PromoExamScore;
                    objPromoInfo.PromotedBy = objPromoHist.PromotedBy;
                    objPromoInfo.PromotedDate = objPromoHist.PromotedDate;
                    objPromoInfo.PromotionID = objPromoHist.PromotionID;
                    
                    EmployeePromotionTableInfo objNewPromoInfo = new EmployeePromotionTableInfo();
                    objNewPromoInfo = (new EmployeePromotionTableController()).PromoHistList(objPromoInfo);

                if(objNewPromoInfo != null)
                    objArrPromoHist.Add(objNewPromoInfo);

                }
                GViewPromoHistory.DataSource = objArrPromoHist;
                GViewPromoHistory.DataBind();
                GViewPromoHistory.Visible = true;
                MViewHRPage.ActiveViewIndex = 26;
                btnPromoHistFinish.Visible = true;
            }

        
        }
        protected void PromoNewDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objPromoNewPosition = new ArrayList();
            int DeptID = Convert.ToInt32(PromoNewDeptList.SelectedValue);
            objPromoNewPosition = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(DeptID);

            if (objPromoNewPosition.Count > 0)
            {
                PromoNewPositionList.DataSource = objPromoNewPosition;
                PromoNewPositionList.DataTextField = "PositionName";
                PromoNewPositionList.DataValueField = "PositionID";
                PromoNewPositionList.DataBind();

                PromoNewPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));

            }


            ArrayList objPromoLevel = new ArrayList();
            objPromoLevel = (new EmployeeLevelController()).GetByEmployeeDepartmentTable(DeptID);

            if (objPromoLevel.Count > 0)
            {
                promoNewLevelList.DataSource = objPromoLevel;
                promoNewLevelList.DataTextField = "LevelName";
                promoNewLevelList.DataValueField = "LevelID";
                promoNewLevelList.DataBind();
            }
            promoNewLevelList.Items.Insert(0, new ListItem("***Please select", "-1"));
                    
        }


        protected void promoNewLevelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeLevelInfo objGetPromoLevel = new EmployeeLevelInfo();
            int lev = Convert.ToInt32(promoNewLevelList.SelectedValue);
            objGetPromoLevel = (new EmployeeLevelController()).Get(lev);

            LbPromoNewSalary.Text = objGetPromoLevel.Salary;
            LbPromoNewSalary.Visible = true;
        }
        protected void PromoEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDetailsInfo objPromoEmp = new EmployeeDetailsInfo();
            int promoEmp = Convert.ToInt32(PromoEmployeeList.SelectedValue);
            objPromoEmp = (new EmployeeDetailsController()).Get(promoEmp);

            EmployeeLevelInfo objPromoPreLevel = new EmployeeLevelInfo();
            int promoPreLevel = objPromoEmp.EmployeeLevel_FK;
            objPromoPreLevel = (new EmployeeLevelController()).Get(promoPreLevel);

            EmployeeDepartmentTableInfo objPromoPreDept = new EmployeeDepartmentTableInfo();
            int promoPreDept = objPromoEmp.Department_FK;
            objPromoPreDept = (new EmployeeDepartmentTableController()).Get(promoPreDept);

            EmployeePositionTableInfo objPromoPrePosition = new EmployeePositionTableInfo();
            int promoPrePost = objPromoEmp.PositionHeld_FK;
            objPromoPrePosition = (new EmployeePositionTableController()).Get(promoPrePost);
            
            UserInfo objPromoUser = new UserInfo();
            objPromoUser = (new UserController()).GetUser(0, UserId);

            EmployeeAppraisalTableInfo objAppraisal = new EmployeeAppraisalTableInfo();
            objAppraisal= (new EmployeeAppraisalTableController()).GetByEmpID(promoEmp);


            LbPreLevel.Text = objPromoPreLevel.LevelName;            
            LbPreLevel.Visible = true;
            LbPromoPreDept.Text = objPromoPreDept.DeptName;
            LbPromoPreDept.Visible = true;
            LbPrePosition.Text = objPromoPrePosition.PositionName;
            LbPrePosition.Visible = true;
            PromoNewDeptList.Visible = true;
            PromoNewPositionList.Visible = true;
            promoNewLevelList.Visible = true; 
            string myDate = DateTime.Now.ToShortDateString();
            LbPromotedDate.Text = myDate;
            LbPromotedDate.Visible = true;
           // txtAppraisalScore.Visible = true;
            LbAppraisalScore.Text = objAppraisal.AppraisalScore.ToString();
            LbManagementDecision.Text = objAppraisal.ManagementDecision;
            LbManagementDecision.Visible = true;
            LbAppraisalScore.Visible = true;
            LbPromoExamScore.Text = objAppraisal.PromoExamScore.ToString();          
            LbPromoExamScore.Visible = true;
            LbTotAppraisalScore.Text = objAppraisal.TotalAppraisalScore.ToString();
            LbTotAppraisalScore.Visible = true;
            LbPromotedBy.Text = objPromoUser.DisplayName;
            LbPromotedBy.Visible = true;
            LbManagementDecision.Text = objAppraisal.PromoRecommendation;
            LbManagementDecision.Visible = true;
            LbEmpEmail.Text = objPromoEmp.Email;
            LbEmpEmail.Visible = true;

        }

       
        protected void promoteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsInfo objPromoEmp = new EmployeeDetailsInfo();
                int promoEmp = Convert.ToInt32(PromoEmployeeList.SelectedValue);
                objPromoEmp = (new EmployeeDetailsController()).Get(promoEmp);

                EmployeeLevelInfo objPromoPreLevel = new EmployeeLevelInfo();
                int promoPreLevel = objPromoEmp.EmployeeLevel_FK;
                objPromoPreLevel = (new EmployeeLevelController()).Get(promoPreLevel);

                EmployeeLevelInfo objPromoNewLevel = new EmployeeLevelInfo();
                int promoNewLevel = Convert.ToInt32(promoNewLevelList.SelectedValue);
                objPromoNewLevel = (new EmployeeLevelController()).Get(promoNewLevel);

                 EmployeeDepartmentTableInfo objPromoPreDept = new EmployeeDepartmentTableInfo();
            int promoPreDept = objPromoEmp.Department_FK;
            objPromoPreDept = (new EmployeeDepartmentTableController()).Get(promoPreDept);

                EmployeePositionTableInfo objPromoPrePosition = new EmployeePositionTableInfo();
                int promoPrePost = objPromoEmp.PositionHeld_FK;
                objPromoPrePosition = (new EmployeePositionTableController()).Get(promoPrePost);

                 EmployeeDepartmentTableInfo objPromoNewDept = new EmployeeDepartmentTableInfo();
            int promoNewDept =Convert.ToInt32(PromoNewDeptList.SelectedValue);
            objPromoNewDept = (new EmployeeDepartmentTableController()).Get(promoPreDept);

                EmployeePositionTableInfo objPromoNewPosition = new EmployeePositionTableInfo();
                int promoNewPost = Convert.ToInt32(PromoNewPositionList.SelectedValue);
                objPromoNewPosition = (new EmployeePositionTableController()).Get(promoNewPost);

                UserInfo objPromoUser = new UserInfo();
                objPromoUser = (new UserController()).GetUser(0, UserId);

                EmployeeAppraisalTableInfo objPromoAppraisa = new EmployeeAppraisalTableInfo();
                objPromoAppraisa = (new EmployeeAppraisalTableController()).GetByEmpID(promoEmp);
                int AppraisalID = objPromoAppraisa.AppraisalID;


                EmployeePromotionTableInfo objPromoInfo = new EmployeePromotionTableInfo();
                objPromoInfo.PreviousLevel = promoPreLevel;
                objPromoInfo.NewLevel = promoNewLevel;
                objPromoInfo.PreDept = promoPreDept;
                objPromoInfo.PreviousPosition = promoPrePost;
                objPromoInfo.NewDept = promoNewDept;
                objPromoInfo.NewPosition = promoNewPost;
                objPromoInfo.EmployeeID_FK = promoEmp;
                objPromoInfo.PromotedBy = UserId;
                objPromoInfo.PromotedDate =  LbPromotedDate.Text;
                objPromoInfo.ApprasialScore = Convert.ToInt32(LbAppraisalScore.Text);
                objPromoInfo.PromoExamScore = Convert.ToInt32(LbPromoExamScore.Text);
                objPromoInfo.TotalAppraisalScore = Convert.ToInt32(LbTotAppraisalScore.Text);
                objPromoInfo.ApprasialID_FK = AppraisalID;

                int PromotionID = (new EmployeePromotionTableController()).Add(objPromoInfo);

                //Keeping log

                EmployeePromotionTableLogInfo objPromoLog = new EmployeePromotionTableLogInfo();

                objPromoLog.PreviousLevel = promoPreLevel;
                objPromoLog.NewLevel = promoNewLevel;
                objPromoLog.PreDept = promoPreDept;
                objPromoLog.PreviousPosition = promoPrePost;
                objPromoLog.NewDept = promoNewDept;
                objPromoLog.NewPosition = promoNewPost;
                objPromoLog.EmployeeID_FK = promoEmp;
                objPromoLog.PromotedBy = UserId;
                objPromoLog.PromotedDate = LbPromotedDate.Text;
                objPromoLog.ApprasialScore = Convert.ToInt32(LbAppraisalScore.Text);
                objPromoLog.PromoExamScore = Convert.ToInt32(LbPromoExamScore.Text);
                objPromoLog.TotalAppraisalScore = Convert.ToInt32(LbTotAppraisalScore.Text);
                objPromoLog.ApprasialID_FK = AppraisalID;
                objPromoLog.PromotionID_FK = PromotionID;

                int PromotionLogID = (new EmployeePromotionTableLogController()).Add(objPromoLog);

              
                 //Composing mail content

                string subjectEmail = "Promotion Letter";
                string bodyEmail = ("Dear " + objPromoEmp.LastName + ", " + objPromoEmp.FirstName + " Following the outcome of your appraisal we are happy to inform you that you have been promoted.");

                string offerDetails = ("Below are your Promotion details: " +
                    "New Position: " + PromoNewPositionList.SelectedItem.Text +
                //objPersonalInfo.ApprovedPositionName +
                    "New Department: "  + PromoNewDeptList.SelectedItem.Text + 
                //objPersonalInfo.DeptName +
                    "New Level: " + promoNewLevelList.SelectedItem +
                    //objPersonalInfo.LevelName +
                    "New Salary: " +  LbPromoNewSalary.Text +
                    //objPersonalInfo.Salary +
                    "Promotion Effect Date:" + promoDayList.SelectedItem + "-" + promoMonthList.SelectedItem + "-" + promoYearList.SelectedItem +
                   "Promotion Date:" + LbPromotedDate.Text +
                     "PromotedBy:" + LbPromotedBy.Text);
                      

                bodyEmail += offerDetails;
                string receiverEmail = objPromoEmp.Email;
                Utility.SendMail(subjectEmail, bodyEmail, receiverEmail);

                if (PromotionID > 0 && PromotionLogID > 0)
                {

                    EmployeePromotionTableInfo objPromoInfos = new EmployeePromotionTableInfo();
                    int PromoEmpID = PromotionID;
                    objPromoInfos = (new EmployeePromotionTableController()).Get(PromoEmpID);

                    EmployeeDetailsInfo objPromoUpdate = new EmployeeDetailsInfo();

                    objPromoUpdate.EmployeeID = promoEmp;
                    objPromoUpdate.EmployeeLevel_FK = promoNewLevel;
                    objPromoUpdate.PositionHeld_FK = promoNewPost;
                    objPromoUpdate.PromotionDate = LbPromotedDate.Text;
                    objPromoUpdate.EmployeeStatus = "Promoted";
                    objPromoUpdate.PromotedBy = objPromoUser.UserID;

                    (new EmployeeDetailsController()).PromoUpdate(objPromoUpdate);

                    PanelPromoDisplay.Visible = false;
                    LbPromosuccess.Text = "Employee has been promoted";
                    LbPromosuccess.Visible = true;
                    newPromoFinishBtn.Visible = true;
                    newPromoFinishBtn.Visible = true;
                    printPromoLetterBtn.Visible = true;

                }
                else
                {
                    LbPromosuccess.Text = "Unable to promote Employee";
                    LbPromosuccess.Visible = true;
                }
                
            }

            catch { }


        }
     
          
        protected void printPromoLetterBtn_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(ViewState["empID"]);
            PanelPromoLetter.Visible = true;
            EmployeeDetailsInfo objPromoEmp3 = new EmployeeDetailsInfo();
            int promoEmp = Convert.ToInt32(PromoEmployeeList.SelectedValue);
            objPromoEmp3 = (new EmployeeDetailsController()).Get(promoEmp);

            LbPromoLetterName.Text = objPromoEmp3.LastName + " " + objPromoEmp3.FirstName;          
            LbLetterNewDept.Text = PromoNewDeptList.SelectedItem.Text;
            LbLetterNewLevel.Text = promoNewLevelList.SelectedItem.Text;
            LbLetterNewPosition.Text = PromoNewPositionList.Text;
            LbLetterNewSalary.Text = LbPromoNewSalary.Text;
            LbPromoEffectDate.Text = promoDayList.SelectedItem + "-" + promoMonthList.SelectedItem + "-" + promoYearList.SelectedItem.Text;

            Utility.PrintHelper.PrintWebControl(PanelPromoLetter);
          
        }
        #endregion

     
      
        //Transfer2

        //#region
        //protected void BindTransferGView2()
        //{

        //    ArrayList objArrTransferApproval = new ArrayList();

        //    ArrayList objTransferApproval = new ArrayList();

        //    objTransferApproval = (new EmployeeTransferTableController()).List();

        //    if (objTransferApproval.Count > 0)
        //    {
        //        foreach (EmployeeTransferTableInfo objTransfer in objTransferApproval)
        //        {
        //            EmployeeTransferTableInfo objMoveInfo = new EmployeeTransferTableInfo();
        //            //objMoveInfo.PreviousDept = objTransfer.PreviousDept;
        //            objMoveInfo.PrevWorkLocation = objTransfer.PrevWorkLocation;
        //            objMoveInfo.DesireLocation = objTransfer.DesireLocation;
        //            objMoveInfo.PreviousDept = objTransfer.PreviousDept;
        //            objMoveInfo.TransferType = objTransfer.TransferType;
        //            objMoveInfo.TransferReason = objTransfer.TransferReason;
        //            objMoveInfo.RequestDate = objTransfer.RequestDate;
        //            objMoveInfo.EmployeeID_FK = objTransfer.EmployeeID_FK;
        //            objMoveInfo.EmployeeNum = objTransfer.EmployeeNum;
        //            //objMoveInfo.

                  
        //            EmployeeTransferTableInfo objNewMoveInfo = new EmployeeTransferTableInfo();
        //            objNewMoveInfo = (new EmployeeTransferTableController()).NewApprovalList(objMoveInfo);
        //            objArrTransferApproval.Add(objNewMoveInfo);

        //     //objTransferApproval = (new EmployeeTransferTableController()).ApprovalList();



        //        }
          
        //    if (objArrTransferApproval.Count > 0)
        //    {

        //        GViewTransferApproval2.DataSource = objArrTransferApproval;
        //        GViewTransferApproval2.DataBind();
        //        GViewTransferApproval2.Visible = true;
        //    }
        //   }
        //}
        //protected void GViewTransferApproval2_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {

        //        DropDownList transferNewDept2 = e.Row.FindControl("transferNewDept2") as DropDownList;
        //        DropDownList transferNewWorkLoc2 = e.Row.FindControl("transferNewWorkLoc2") as DropDownList;
        //        DropDownList transferApprovalStatus2 = e.Row.FindControl("transferApprovalStatus2") as DropDownList;

        //        ArrayList objTransDept = new ArrayList();
        //        objTransDept = (new EmployeeDepartmentTableController()).List();

        //        if (transferNewDept2 != null)

        //            transferNewDept2.DataSource = objTransDept;
        //        transferNewDept2.DataTextField = "DeptName";
        //        transferNewDept2.DataValueField = "DeptID";
        //        transferNewDept2.DataBind();

        //        transferNewDept2.Items.Insert(0, new ListItem("***Please select***", "-1"));

        //        ArrayList objTransLoc = new ArrayList();
        //        objTransLoc = (new EmployeeWorkLocationsController()).List();

        //        if (transferNewWorkLoc2 != null)

        //            transferNewWorkLoc2.DataSource = objTransLoc;
        //        transferNewWorkLoc2.DataTextField = "LocationName";
        //        transferNewWorkLoc2.DataValueField = "WorkLocationID";
        //        transferNewWorkLoc2.DataBind();

        //        transferNewWorkLoc2.Items.Insert(0, new ListItem("***Please select***", "-1"));

        //        UserInfo objTransferUser = new UserInfo();
        //        objTransferUser = (new UserController()).GetUser(0, UserId);


        //        //Declaring textbox

        //        TextBox AD = new TextBox();
        //        TextBox TD = new TextBox();
        //        TextBox Eid = new TextBox();
        //        TextBox TBy = new TextBox();
        //        TextBox Tid = new TextBox();
        //        TextBox TFK = new TextBox();
        //        TextBox Tlog = new TextBox();

        //        // find the textbox containing the applicantID on the gridview 
        //        AD = (TextBox)e.Row.FindControl("txtApprovedate2");
        //        TD = (TextBox)e.Row.FindControl("txtTransferdate2");
        //        Eid = (TextBox)e.Row.FindControl("txtTransferEmpID2");
        //        TBy = (TextBox)e.Row.FindControl("txtTranferedBy2");
        //        Tid = (TextBox)e.Row.FindControl("txtTranferID2");
        //        TFK = (TextBox)e.Row.FindControl("txtTranferID_FK2");
        //        Tlog = (TextBox)e.Row.FindControl("txtTranferLogID2");

        //        string date2 = DateTime.Now.ToShortDateString();
        //        AD.Text = date2;
        //        TD.Text = date2;
        //        TBy.Text = objTransferUser.UserID.ToString();
        //        string ApprovalDate = AD.Text;
        //        string EmplID = Eid.Text;
        //        string TransferDate = TD.Text;
        //        string TransferedBy = TBy.Text;
        //        string Trans = Tid.Text;
        //        string TransferID_FK = TFK.Text;
        //        string TransLogID = Tlog.Text;
        //        ApprovalDate = date2;
        //        TransferDate = date2;
        //        TransferedBy = objTransferUser.UserID.ToString();
        //        int TransferID = Convert.ToInt32(Trans);
        //        int TransferLogID = Convert.ToInt32(TransLogID);
        //        int EmployeeID = Convert.ToInt32(EmplID);
        //        ViewState.Add("TransferID", TransferID);
        //        ViewState.Add("TransferLogID", TransferLogID);
        //        ViewState.Add("EmployeeID", EmployeeID);

        //    }
        //}

        //#endregion


        //Leave Module

        #region
 protected void ddlLeaveDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Deptid = Convert.ToInt32(ddlLeaveDeptList.SelectedValue);
            ArrayList objDept = new ArrayList();
            objDept = (new EmployeeLeaveTableController()).GetByEmployeeDepartmentTable(Deptid);
            if (objDept.Count > 0)
            {
                GVLeave.DataSource = objDept;
                GVLeave.DataBind();
                GVLeave.Visible = true;
            }
        }
        protected void GVLeave_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                EmployeeLeaveTableInfo objLeave= new EmployeeLeaveTableInfo();
                objLeave = (new EmployeeLeaveTableController()).GetForAnEmployee(Convert.ToInt32(e.CommandArgument));
                lblEmpName.Text = objLeave.EmployeeName;
                lblLeaveType.Text = objLeave.LeaveTypeName;
                //lblDescription.text=objeLeave
                lblLeaveDescription.Text = objLeave.LeaveDescription;
                llblLeaveStartDate.Text = objLeave.StartDate;
                lblLeaveEndDate.Text = objLeave.EndDate;
                lblLeaveDuration.Text = objLeave.Duration;
                lblLeaveThresholdB4App.Text = objLeave.LeaveThresholdBeforeApplication;
                lblLeaveThreshold.Text = objLeave.LeaveThreshold;
               // lblLeaveStartDate.Text = objLeave.StartDate;
                PanelLeaveRequestDetails.Visible = true;
                
            }
        }
        protected void ddApproveOrDisapprove_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddApproveOrDisapprove.SelectedItem.Text == "Disapproved")
            {
                LbReason.Visible = true;
                txtReason.Visible = true;
            }
        }
        protected void linkToLeave_Click(object sender, EventArgs e)
        {
            lblLeaveApprovedDate.Text = DateTime.Now.ToString();
            UserInfo objApproveByUser = new UserInfo();
            objApproveByUser = (new UserController()).GetUser(0, UserId);
            
            lblLeaveApprovedBy.Text = objApproveByUser.LastName + " " + objApproveByUser.FirstName;
            PanelLeaveApproval.Visible = true;
        }

        // approveleave

        protected void btnUpdateLeave_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow g1 in GVLeave.Rows)
                {                    
                    TextBox a = new TextBox();
                 TextBox b = new TextBox();
                 TextBox c = new TextBox();
                 TextBox d = new TextBox();
                 TextBox f = new TextBox();
       

                    // find the textbox containing the applicantID on the gridview 
                 a = (TextBox)g1.FindControl("txtLeaveEmpID");
                b = (TextBox)g1.FindControl("txtLeaveID");
                c = (TextBox)g1.FindControl("txtLeaveLogID");
                d = (TextBox)g1.FindControl("txtLeaveThresholdB4App");
                f = (TextBox)g1.FindControl("txtLeaveThreshold");
               

                int Leaveempid = Convert.ToInt32(a.Text);
                int Leaveid = Convert.ToInt32(b.Text);
                int LeaveLogid = Convert.ToInt32(c.Text);
              string thresholdB4app = d.Text;
              string threshold = f.Text;
                ViewState.Add("Leaveempid", Leaveempid);
                ViewState.Add("Leaveid", Leaveid);
                ViewState.Add("LeaveLogid", LeaveLogid);
                ViewState.Add("thresholdB4app", thresholdB4app);
                ViewState.Add("threshold", threshold);
            }
            try
            {
                if (ddApproveOrDisapprove.SelectedItem.Text == "Approved")
                {
                    UserInfo objLeaveUser = new UserInfo();
                    objLeaveUser = (new UserController()).GetUser(0, UserId);

                    int Leaveid = Convert.ToInt32(ViewState["Leaveid"]);
                    int Leaveempid = Convert.ToInt32(ViewState["Leaveempid"]);
                    int LeaveLogid = Convert.ToInt32(ViewState["LeaveLogid"]);
                 string thresholdB4app = (ViewState["thresholdB4app"]).ToString();
                  string  threshold =  (ViewState["threshold"]).ToString();
                    

                    // EmployeeLeaveTableInfo objGetLeaveReq = new EmployeeLeaveTableInfo();
                    //  Leaveempid = Convert.ToInt32(Leaveempid);
                    string date = DateTime.Now.ToShortDateString();


                    EmployeeLeaveTableInfo objHRUpdateLeave = new EmployeeLeaveTableInfo();
                    objHRUpdateLeave.EmployeeID_FK = Leaveempid;
                    objHRUpdateLeave.LeaveID = Leaveid;
                    objHRUpdateLeave.LeaveThresholdBeforeApplication = thresholdB4app;
                    objHRUpdateLeave.LeaveThreshold = threshold;
                    objHRUpdateLeave.LeaveGrantedBy = objLeaveUser.UserID;
                    objHRUpdateLeave.DateGranted = date;
                    objHRUpdateLeave.LeaveStatus = ddApproveOrDisapprove.SelectedItem.Text;

                    (new EmployeeLeaveTableController()).UpdateLeaveApprovalORDisapproval(objHRUpdateLeave);


                    EmployeeLeaveTableLogInfo objHRUpdateLeaveLog = new EmployeeLeaveTableLogInfo();
                    objHRUpdateLeaveLog.EmployeeID_FK = Leaveempid;
                    objHRUpdateLeaveLog.LeaveID_FK = Leaveid;
                    objHRUpdateLeaveLog.LeaveThresholdBeforeApplication = thresholdB4app;
                    objHRUpdateLeaveLog.LeaveThreshold = threshold;
                    objHRUpdateLeaveLog.LeaveGrantedBy = objLeaveUser.UserID;
                    objHRUpdateLeaveLog.DateGranted = date;
                    objHRUpdateLeaveLog.LeaveStatus = ddApproveOrDisapprove.SelectedItem.Text;
                    objHRUpdateLeaveLog.LeaveLogID = LeaveLogid;

                    (new EmployeeLeaveTableLogController()).LogUpdateLeaveApprovalORDisapproval(objHRUpdateLeaveLog);
                    if ((objHRUpdateLeave.LeaveStatus != null) && (objHRUpdateLeaveLog.LeaveStatus != null))
                    {
                        LbLeaveUpdated.Text = "Leave request has been Disapproved";
                        LbLeaveUpdated.Visible = true;
                    }
                    else
                    {
                        LbLeaveUpdated.Text = "Leave Update not successful";
                        LbLeaveUpdated.Visible = true;
                    }

                }
                else if (ddApproveOrDisapprove.SelectedItem.Text == "Disapproved")
                {
                    UserInfo objLeaveUser = new UserInfo();
                    objLeaveUser = (new UserController()).GetUser(0, UserId);

                    int Leaveid = Convert.ToInt32(ViewState["Leaveid"]);
                    int Leaveempid = Convert.ToInt32(ViewState["Leaveempid"]);
                    int LeaveLogid = Convert.ToInt32(ViewState["LeaveLogid"]);
                    string thresholdB4app = (ViewState["thresholdB4app"]).ToString();
                    string threshold = (ViewState["threshold"]).ToString();

                    // EmployeeLeaveTableInfo objGetLeaveReq = new EmployeeLeaveTableInfo();
                    //  Leaveempid = Convert.ToInt32(Leaveempid);
                    string date = DateTime.Now.ToShortDateString();


                    EmployeeLeaveTableInfo objHRUpdateLeave = new EmployeeLeaveTableInfo();
                    objHRUpdateLeave.EmployeeID_FK = Leaveempid;
                    objHRUpdateLeave.LeaveID = Leaveid;
                    objHRUpdateLeave.LeaveGrantedBy = objLeaveUser.UserID;
                    objHRUpdateLeave.LeaveThresholdBeforeApplication = thresholdB4app;
                    objHRUpdateLeave.LeaveThreshold = thresholdB4app;
                    objHRUpdateLeave.DateGranted = date;
                    objHRUpdateLeave.LeaveStatus = ddApproveOrDisapprove.SelectedItem.Text;
                    objHRUpdateLeave.ReasonForDisapproval = txtReason.Text;

                    (new EmployeeLeaveTableController()).UpdateLeaveApprovalORDisapproval(objHRUpdateLeave);


                    EmployeeLeaveTableLogInfo objHRUpdateLeaveLog = new EmployeeLeaveTableLogInfo();
                    objHRUpdateLeaveLog.EmployeeID_FK = Leaveempid;
                    objHRUpdateLeaveLog.LeaveID_FK = Leaveid;
                    objHRUpdateLeaveLog.LeaveGrantedBy = objLeaveUser.UserID;
                    objHRUpdateLeaveLog.LeaveThresholdBeforeApplication = thresholdB4app;
                    objHRUpdateLeaveLog.LeaveThreshold = thresholdB4app;
                    objHRUpdateLeaveLog.DateGranted = date;
                    objHRUpdateLeaveLog.LeaveStatus = ddApproveOrDisapprove.SelectedItem.Text;
                    objHRUpdateLeaveLog.ReasonForDisapproval = txtReason.Text;
                    objHRUpdateLeaveLog.LeaveLogID = LeaveLogid;

                    (new EmployeeLeaveTableLogController()).LogUpdateLeaveApprovalORDisapproval(objHRUpdateLeaveLog);

                     if((objHRUpdateLeave.LeaveStatus != null) && (objHRUpdateLeaveLog.LeaveStatus != null))
                     {
                         LbLeaveUpdated.Text = "Leave request has been Disapproved";
                         LbLeaveUpdated.Visible = true;
                     }
                     else
                     {
                         LbLeaveUpdated.Text = "Leave Update not successful";
                         LbLeaveUpdated.Visible = true;
                     }
                }

               
            }
            catch
            {

            }
        }


        #endregion


        //Query Module

        #region

        //Panel for HR to issue query
        protected void LinkQuery_Click(object sender, EventArgs e)
        {
            PanelQuery.Visible = true;
            PanelDiscipline.Visible = false;
            PanelQuryList.Visible = false;
            GVHRQuery.Visible = false;
            lblListQuery.Visible = false;
            lblDisciplineSuccessful.Visible = false;
            lblQueryIssueReport.Visible = false;

        }

        //Displaying query Gview and  Discipline pannel
        protected void LinkDiscipline_Click(object sender, EventArgs e)
        {

            PanelQuryList.Visible = true;
            PanelQuery.Visible = false;
            LbHrQueryIssueDate.Text = DateTime.Now.ToString();
            LbHrQueryIssueDate.Visible = true;
            UserInfo objIssuedByUser = new UserInfo();
            objIssuedByUser = (new UserController()).GetUser(0, UserId);

            LbIssuedBy.Text = objIssuedByUser.LastName + " " + objIssuedByUser.FirstName;

            //List queries sent by hr
            int IssuedBy = objIssuedByUser.UserID;
            ArrayList objQuery = new ArrayList();
            objQuery = (new EmployeeQueryTableController()).List();
            if (objQuery.Count > 0)
            {
                GVHRQuery.DataSource = objQuery;
                GVHRQuery.DataBind();
                GVHRQuery.Visible = true;
                lblListQuery.Visible = true;
            }
            else
            {
                lblListQuery.Visible = false;
                GVHRQuery.Visible = false;
            }
            
            
            
        }

        //Listing Employees for Query base on department

        #region
        protected void queryDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deptId = Convert.ToInt32(queryDeptList.SelectedValue);
            ArrayList EmpdeptInfo = new ArrayList();
            EmpdeptInfo = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(deptId);
            if (EmpdeptInfo.Count > 0)
            {
                queryEmployeeList.DataSource = EmpdeptInfo;
                queryEmployeeList.DataTextField = "EmployeeNum";
                queryEmployeeList.DataValueField = "EmployeeID";
                queryEmployeeList.DataBind();
                queryEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));


            }
        }

        #endregion

        //Issue query

       #region
        protected void btnSendQuery_Click(object sender, EventArgs e)
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
            objQuery.IssueDate=DateTime.Now.ToString();

            // get the  user that login
             UserInfo objIssuedByUser = new UserInfo();
            objIssuedByUser = (new UserController()).GetUser(0, UserId);
            objQuery.QueryIssuedBy = objIssuedByUser.UserID;

            int queryId = (new EmployeeQueryTableController()).AddQuery(objQuery);
            if (queryId > 0)
            {
                lblQueryIssueReport.Text = "Query sent succesfully";
                lblQueryIssueReport.Visible=true;
                PanelDiscipline.Visible=false;
                PanelQuery.Visible=false;
                PanelQuryList.Visible=false;
                lblDisciplineSuccessful.Visible = false;
            }
            else
            {
                lblQueryIssueReport.Text = "Query Not Send";
                lblQueryIssueReport.Visible = true;
                PanelDiscipline.Visible = false;
                PanelQuery.Visible = false;
                PanelQuryList.Visible = false;
                lblDisciplineSuccessful.Visible = false;
            }

        }
#endregion



        #region

        protected void GVHRQuery_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                PanelDiscipline.Visible = true;
                PanelQuryList.Visible = true;
                PanelQuery.Visible = false;
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
               
                UserInfo objUser=new UserInfo();
                objUser=(new UserController()).GetUser(0, UserId);
                lblDisciplineBy.Text = objUser.LastName + " " + objUser.FirstName;
                lblDisciplineDate.Text = DateTime.Now.ToString();

                ArrayList DisciplineType = new ArrayList();
                DisciplineType = new EmployeeDisciplineTableController().List();
                if (DisciplineType.Count > 0)
                {
                    ddlDisciplineType.DataSource = DisciplineType;
                    ddlDisciplineType.DataValueField = "DisciplineID";
                    ddlDisciplineType.DataTextField = "DiscplineDescription";
                    ddlDisciplineType.DataBind();
                    ddlDisciplineType.Visible = true;
                }
                ddlDisciplineType.Items.Insert(0, new ListItem("***Please select***", "-1"));
                lblDisciplineDate.Text = DateTime.Now.ToString();
               
            }
        }

        #endregion


        protected void Button9_Click(object sender, EventArgs e)
        {
            PanelDiscipline.Visible = false;
        }

        protected void ddlDisciplineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDisciplineType.SelectedItem.Text == "Suspension")
            {
                LbSuspentiodSDate.Visible = true;
                ddSuspStartDay.Visible =true;
                ddSuspStartMonth.Visible = true;
                ddSuspStartYear.Visible = true;

                LbSuspentionEDate.Visible = true;
                ddSuspEndDay.Visible = true;
                ddSuspEndMonth.Visible =true;
                ddSuspEndYear.Visible = true;

                LbSuspentionDuration.Visible = true;
                txtSuspDuration.Visible = true;
                                
            }
        }

        //Calculating suspention duration

        #region

        protected void ddSuspEndYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            LbSuspStartDate.Text = ddSuspStartDay.SelectedItem + "-" + ddSuspStartMonth.SelectedItem + "-" + ddSuspStartYear.SelectedItem;
            LbSuspEndDate.Text = ddSuspEndDay.SelectedItem + "-" + ddSuspEndMonth.SelectedItem + "-" + ddSuspEndYear.SelectedItem;
            
            DateTime sDate = DateTime.Parse(LbSuspStartDate.Text);
            DateTime eDate = DateTime.Parse(LbSuspEndDate.Text);

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

                txtSuspDuration.Text = workingDays.ToString();

            }

                   }

            #endregion

        protected void btnSendDisciplined_Click(object sender, EventArgs e)
        {
            try { 

            if (ddlDisciplineType.SelectedItem.Text == "Suspension")
            {
                EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
                int QueryID = Convert.ToInt32(ViewState["queryId"]);
                objQuery.QueryID = QueryID;
                objQuery.DisciplineDate = DateTime.Now.ToString();

                UserInfo objUser = new UserInfo();
                 objUser = (new UserController()).GetUser(0, UserId);

                objQuery.DisciplinedBy = objUser.UserID;
                objQuery.DisciplineDetails = txtDisciplineDescription.Text;
                objQuery.SuspentionStartDate = LbSuspStartDate.Text;
                objQuery.SuspentionEndDate = LbSuspEndDate.Text;
                objQuery.SuspentionDuration = txtSuspDuration.Text;
                objQuery.DiscipliineType_FK = Convert.ToInt32(ddlDisciplineType.SelectedValue);
                if (DisciplinedLetterUpload.HasFile)
                {
                    string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();

                    // lblDisciplineLetterName.Text = DisciplinedLetterUpload.FileName;
                    DisciplinedLetterUpload.SaveAs(filepath + "\\" + DisciplinedLetterUpload.FileName.ToString());
                    objQuery.DisciplineLetter = "~/QueryLetters/" + "/" + DisciplinedLetterUpload.FileName.ToString();
                }
                (new EmployeeQueryTableController()).UpdateQueryDisciplineSuspention(objQuery);

                //Updating QueryLog

                EmployeeQueryTableInfo objGetQuery = new EmployeeQueryTableInfo();
                objGetQuery = (new EmployeeQueryTableController()).Get(QueryID);

                EmployeeQueryTableLogInfo objGetQueryLog = new EmployeeQueryTableLogInfo();
                objGetQueryLog = (new EmployeeQueryTableLogController()).LogGetByEmpQuery(QueryID);


                EmployeeQueryTableLogInfo objQueryLog = new EmployeeQueryTableLogInfo();
                objQueryLog.QueryID_FK = objGetQuery.QueryID;
                objQueryLog.DisciplineDate = objGetQuery.DisciplineDate;
                objQueryLog.DisciplinedBy = objGetQuery.DisciplinedBy;
                objQueryLog.DisciplineDetails = objGetQuery.DisciplineDetails;
                objQueryLog.DiscipliineType_FK = objGetQuery.DiscipliineType_FK;
                objQueryLog.SuspentionStartDate = objGetQuery.SuspentionStartDate;
                objQueryLog.SuspentionEndDate = objGetQuery.SuspentionEndDate;
                objQueryLog.SuspentionDuration = objGetQuery.SuspentionDuration;
                objQueryLog.DisciplineLetter = objGetQuery.DisciplineLetter;
                objQueryLog.QueryLogID = objGetQueryLog.QueryLogID;

                (new EmployeeQueryTableLogController()).LogUpdateQueryDisciplineSuspention(objQueryLog);

                EmployeeQueryTableLogInfo objGetQueryLog2 = new EmployeeQueryTableLogInfo();
                objGetQueryLog2 = (new EmployeeQueryTableLogController()).LogGetByEmpQuery(QueryID);



                if ((objGetQuery.DisciplineDate != null) && (objGetQueryLog2.DisciplineDate != null))
                {
                    lblDisciplineSuccessful.Text = "Employee has been disciplined";
                    lblDisciplineSuccessful.Visible = true;
                    PanelDiscipline.Visible = false;
                    PanelQuery.Visible = false;
                    PanelQuryList.Visible = false;
                    lblQueryIssueReport.Visible = false;
                    lblDisciplineSuccessful.Visible = false;
                }

                else
                {
                    lblDisciplineSuccessful.Text = "Employee Not disciplined";
                    lblDisciplineSuccessful.Visible = true;
                    PanelDiscipline.Visible = false;
                    PanelQuery.Visible = false;
                    PanelQuryList.Visible = false;
                    lblQueryIssueReport.Visible = false;
                    lblDisciplineSuccessful.Visible = false;

                }

            }
         
        //When discipline is not Suspention
        
            else
            {
                EmployeeQueryTableInfo objQuery = new EmployeeQueryTableInfo();
                int QueryID = Convert.ToInt32(ViewState["queryId"]);
                objQuery.QueryID = QueryID;
                objQuery.DisciplineDate = DateTime.Now.ToString();
                UserInfo objUser = new UserInfo();
                objUser = (new UserController()).GetUser(0, UserId);
                objQuery.DisciplinedBy = objUser.UserID;
                objQuery.DisciplineDetails = txtDisciplineDescription.Text;
                objQuery.DiscipliineType_FK = Convert.ToInt32(ddlDisciplineType.SelectedValue);
                if (DisciplinedLetterUpload.HasFile)
                {
                    string filepath = HttpContext.Current.Server.MapPath("~/QueryLetters/").ToString();

                    // lblDisciplineLetterName.Text = DisciplinedLetterUpload.FileName;
                    DisciplinedLetterUpload.SaveAs(filepath + "\\" + DisciplinedLetterUpload.FileName.ToString());
                    objQuery.DisciplineLetter = "~/QueryLetters/" + "/" + DisciplinedLetterUpload.FileName.ToString();
                }
                (new EmployeeQueryTableController()).UpdateQueryDiscipline(objQuery);

                //Updating QueryLog

                EmployeeQueryTableInfo objGetQuery = new EmployeeQueryTableInfo();
                objGetQuery = (new EmployeeQueryTableController()).Get(QueryID);

                EmployeeQueryTableLogInfo objGetQueryLog = new EmployeeQueryTableLogInfo();
                objGetQueryLog = (new EmployeeQueryTableLogController()).LogGetByEmpQuery(QueryID);


                EmployeeQueryTableLogInfo objQueryLog = new EmployeeQueryTableLogInfo();
                objQueryLog.QueryID_FK = objGetQuery.QueryID;
                objQueryLog.DisciplineDate = objGetQuery.DisciplineDate;
                objQueryLog.DisciplinedBy = objGetQuery.DisciplinedBy;
                objQueryLog.DisciplineDetails = objGetQuery.DisciplineDetails;
                objQueryLog.DiscipliineType_FK = objGetQuery.DiscipliineType_FK;
                objQueryLog.DisciplineLetter = objGetQuery.DisciplineLetter;
                objQueryLog.QueryLogID = objGetQueryLog.QueryLogID;

                (new EmployeeQueryTableLogController()).LogUpdateQueryDiscipline(objQueryLog);

                EmployeeQueryTableLogInfo objGetQueryLog2 = new EmployeeQueryTableLogInfo();
                objGetQueryLog2 = (new EmployeeQueryTableLogController()).LogGetByEmpQuery(QueryID);



                if ((objGetQuery.DisciplineDate != null) && (objGetQueryLog2.DisciplineDate != null))
                {
                    lblDisciplineSuccessful.Text = "Employee has been disciplined";
                    lblDisciplineSuccessful.Visible = true;
                    PanelDiscipline.Visible = false;
                    PanelQuery.Visible = false;
                    PanelQuryList.Visible = false;
                    lblQueryIssueReport.Visible = false;
                }

                else
                {
                    lblDisciplineSuccessful.Text = "Employee Not disciplined";
                    lblDisciplineSuccessful.Visible = true;
                    PanelDiscipline.Visible = false;
                    PanelQuery.Visible = false;
                    PanelQuryList.Visible = false;
                    lblQueryIssueReport.Visible = false;

                }

            }
                   }
            catch
            {

            }
        }
       

        #endregion



        //Editting Employee Details Module

        #region

        //Displaying Views

        #region
        protected void menuBtnEditEmpDetails_Click(object sender, EventArgs e)
        {

            MViewHRPage.ActiveViewIndex = 18;
        }
        protected void LinkBtnEditBasicInfo_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 19;

        }
        protected void LinkBtnEditSpouseInfo_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 20;
        }
        protected void LinkBtnEditNOKInfo_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 21;
        }

        protected void BtnEditFinish_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        #endregion
    
      

     //Editing Employee basic info

#region

        //Loading Employees by department for Editing

        #region
        protected void ddEditEmpInfoDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objEditEmpInfoDept = new ArrayList();
            int dept = Convert.ToInt32(ddEditEmpInfoDept.SelectedValue);
            objEditEmpInfoDept = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(dept);
            if (objEditEmpInfoDept.Count > 0)
            {

                ddEditEmpInfoEmpNum.DataSource = objEditEmpInfoDept;
                ddEditEmpInfoEmpNum.DataTextField = "EmployeeNum";
                ddEditEmpInfoEmpNum.DataValueField = "EmployeeID";
                ddEditEmpInfoEmpNum.DataBind();
                ddEditEmpInfoEmpNum.Items.Insert(0, new ListItem("***Please select***", "-1"));
                ddEditEmpInfoEmpNum.Visible = true;
                LbEditEmp1.Visible = true;

            }
        }

        #endregion


        //Displaying Employee details from for Editing

        #region
               
        protected void ddEditEmpInfoEmpNum_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            PanelEditEmpInfo.Visible = true;

            EmployeeDetailsInfo objDisplayEmp = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(ddEditEmpInfoEmpNum.SelectedValue);
            objDisplayEmp = (new EmployeeDetailsController()).Get(empID);

            titleList.ClearSelection();
            titleList.Items.FindByText(objDisplayEmp.Title.ToString()).Selected = true;

            ddlMaritalStatus.ClearSelection();
            ddlMaritalStatus.Items.FindByText(objDisplayEmp.MaritalStatus.ToString()).Selected = true;

            religionList.ClearSelection();
            religionList.Items.FindByText(objDisplayEmp.Religion.ToString()).Selected = true;

            txtFName.Text = objDisplayEmp.FirstName;
            txtMName.Text = objDisplayEmp.MiiddleName;
            txtLName.Text = objDisplayEmp.LastName;
            txtEmail.Text = objDisplayEmp.Email;
            txtPhnNum.Text = objDisplayEmp.PhoneNo;
            txtContAddr.Text = objDisplayEmp.ContactAddress;
            txtAcctName.Text = objDisplayEmp.AccountName;
            txtAcctNum.Text = objDisplayEmp.AccountNo;
            txtBankName.Text = objDisplayEmp.BankName;
           
        }

#endregion


        //Updating Details

        #region
        protected void EmpEditSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                EmployeeDetailsInfo objEmpEditUpdate = new EmployeeDetailsInfo();
                objEmpEditUpdate.Title = titleList.SelectedItem.ToString();
                objEmpEditUpdate.FirstName = txtFName.Text.Trim();
                objEmpEditUpdate.MiiddleName = txtMName.Text.Trim();
                objEmpEditUpdate.LastName = txtLName.Text.Trim();
                objEmpEditUpdate.Religion = religionList.SelectedItem.ToString();
                objEmpEditUpdate.MaritalStatus = ddlMaritalStatus.SelectedItem.ToString();
                objEmpEditUpdate.ContactAddress = txtContAddr.Text.Trim();
                objEmpEditUpdate.PhoneNo = txtPhnNum.Text.Trim();
                objEmpEditUpdate.Email = txtEmail.Text.Trim();
                objEmpEditUpdate.AccountName = txtAcctName.Text.Trim();
                objEmpEditUpdate.AccountNo = txtAcctNum.Text.Trim();
                objEmpEditUpdate.BankName = txtBankName.Text.Trim();
                objEmpEditUpdate.EmployeeID = Convert.ToInt32(ddEditEmpInfoEmpNum.SelectedValue);

                (new EmployeeDetailsController()).EditBasicInfoUpdate(objEmpEditUpdate);

                EmployeeDetailsInfo objGetEmp = new EmployeeDetailsInfo();
                objGetEmp = (new EmployeeDetailsController()).Get(Convert.ToInt32(ddEditEmpInfoEmpNum.SelectedValue));

                if (
                    (objGetEmp.Title == titleList.SelectedItem.ToString()) && (objGetEmp.Religion == religionList.SelectedItem.ToString()) &&
                   (objGetEmp.EmployeeID == Convert.ToInt32(ddEditEmpInfoEmpNum.SelectedValue)) && (objGetEmp.MaritalStatus == ddlMaritalStatus.SelectedItem.ToString()) &&
                    (objGetEmp.FirstName == txtFName.Text) && (objGetEmp.MiiddleName == txtMName.Text) &&
                    (objGetEmp.LastName == txtLName.Text) && (objGetEmp.PhoneNo == txtPhnNum.Text) &&
                    (objGetEmp.Email == txtEmail.Text) && (objGetEmp.ContactAddress == txtContAddr.Text) &&
                    (objGetEmp.AccountName == txtAcctName.Text) && (objGetEmp.AccountNo == txtAcctNum.Text) &&
                (objGetEmp.BankName == txtBankName.Text))
                {
                    MViewHRPage.ActiveViewIndex = 21;
                    lbEmpInfoEdited.Text = "Employee Details Succesfull Updated. Thank you!";
                    lbEmpInfoEdited.Visible = true;
                    PanelEditEmpInfo.Visible = false;
                    BtnEditFinish.Visible = true;
                    lbEmpSpouseAdded.Visible = false;

                }
                else
                {
                    MViewHRPage.ActiveViewIndex = 21;
                    lbEmpInfoEdited.Text = "Employee Details Not Updated. Thank you!";
                    lbEmpInfoEdited.Visible = true;
                    PanelEditEmpInfo.Visible = false;
                    BtnEditFinish.Visible = true;
                    lbEmpSpouseAdded.Visible = false;
                }
            }
            catch
            {

            }


        }

        #endregion


#endregion



        //Editing Employee Spouse info

        #region

        //Loading Employees by department for Editing

        #region

        protected void ddEditSpouseDept_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
            ArrayList objEditEmpSpouseDept = new ArrayList();
            int dept = Convert.ToInt32(ddEditSpouseDept.SelectedValue);
            objEditEmpSpouseDept = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(dept);
            if (objEditEmpSpouseDept.Count > 0)
            {

                ddEditSpouseEmpID.DataSource = objEditEmpSpouseDept;
                ddEditSpouseEmpID.DataTextField = "EmployeeNum";
                ddEditSpouseEmpID.DataValueField = "EmployeeID";
                ddEditSpouseEmpID.DataBind();
                ddEditSpouseEmpID.Items.Insert(0, new ListItem("***Please select***", "-1"));

                ddEditSpouseEmpID.Visible = true;
                LbEditEmp2.Visible = true;

            }

        }
        #endregion

        //Displaying Employee details from for Editing

        #region

        protected void ddEditSpouseEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MViewHRPage.ActiveViewIndex=23;
            PanelEditSpouseInfo.Visible = true;
            PanelEditEmpInfo.Visible = false;

            EmployeeDetailsInfo objDisplayEmpSpouse = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(ddEditSpouseEmpID.SelectedValue);
            objDisplayEmpSpouse = (new EmployeeDetailsController()).Get(empID);

            txtSpouseNames.Text = objDisplayEmpSpouse.SpouseNames;
            txtSpoucePhnNum.Text = objDisplayEmpSpouse.SpousePhoneNo;
            txtSpouceEmail.Text = objDisplayEmpSpouse.SpouseEmail;
            txtSpouceEmployer.Text = objDisplayEmpSpouse.SpouseEmployerNames;
            txtSpouceContAddress.Text = objDisplayEmpSpouse.SpouseAddress;
            txtSpouceOccupation.Text = objDisplayEmpSpouse.SpouseOccupation;

           }

        #endregion

        //Upadting Employee Spouse Info

        #region

        protected void spouseSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsInfo objUpdateSpouse = new EmployeeDetailsInfo();
                objUpdateSpouse.SpouseNames = txtSpouseNames.Text.Trim();
                objUpdateSpouse.SpousePhoneNo = txtSpoucePhnNum.Text.Trim();
                objUpdateSpouse.SpouseAddress = txtSpouceContAddress.Text.Trim();
                objUpdateSpouse.SpouseEmail = txtSpouceEmail.Text.Trim();
                objUpdateSpouse.SpouseEmployerNames = txtSpouceEmployer.Text.Trim();
                objUpdateSpouse.SpouseOccupation = txtSpouceOccupation.Text.Trim();
                objUpdateSpouse.EmployeeID = Convert.ToInt32(ddEditSpouseEmpID.SelectedValue);

                (new EmployeeDetailsController()).EditSpouseDetailsUpdate(objUpdateSpouse);

                EmployeeDetailsInfo objGetEmp = new EmployeeDetailsInfo();
                objGetEmp = (new EmployeeDetailsController()).Get(Convert.ToInt32(ddEditSpouseEmpID.SelectedValue));

                if (
                    (objGetEmp.SpouseNames == txtSpouseNames.Text) && (objGetEmp.SpousePhoneNo == txtSpoucePhnNum.Text) &&

                    (objGetEmp.SpouseAddress == txtSpouceContAddress.Text) && (objGetEmp.SpouseEmail == txtSpouceEmail.Text) &&
                    (objGetEmp.SpouseEmployerNames == txtSpouceEmployer.Text) && (objGetEmp.SpouseOccupation == txtSpouceOccupation.Text) &&
                    (objGetEmp.EmployeeID == Convert.ToInt32(ddEditSpouseEmpID.SelectedValue)))  
                
                {

                    MViewHRPage.ActiveViewIndex = 21;
                    lbEmpSpouseAdded.Text = "Employee Spouse Info Successfully Updated";
                    lbEmpSpouseAdded.Visible = true;
                    BtnEditFinish.Visible = true;
                    PanelEditEmpInfo.Visible = false;
                }

                else
                {

                    MViewHRPage.ActiveViewIndex = 21;
                    lbEmpSpouseAdded.Text = "Employee Spouse Info Not Updated";
                    lbEmpSpouseAdded.Visible = true;
                    BtnEditFinish.Visible = true;
                    PanelEditEmpInfo.Visible = false;

                }

            }

            catch
            {

            }

        }

        #endregion




        #endregion



        //Editing Employee NOK info

        #region


        //Loading Employees by department for Editing

        #region
        protected void ddEditNOKDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objEditEmpNOKDept = new ArrayList();
            int dept = Convert.ToInt32(ddEditNOKDept.SelectedValue);
            objEditEmpNOKDept = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(dept);
            if (objEditEmpNOKDept.Count > 0)
            {

                ddEditNOKEmpID.DataSource = objEditEmpNOKDept;
                ddEditNOKEmpID.DataTextField = "EmployeeNum";
                ddEditNOKEmpID.DataValueField = "EmployeeID";
                ddEditNOKEmpID.DataBind();
                ddEditNOKEmpID.Items.Insert(0, new ListItem("***Please select***", "-1"));

                ddEditNOKEmpID.Visible = true;
                LbEditEmp3.Visible = true;
            }
        }

#endregion

        //  //Displaying Employee NOK details from for Editing

        
        #region

        protected void ddEditNOKEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelEditNOKInfo.Visible = true;
            PanelEditSpouseInfo.Visible = false;
            PanelEditEmpInfo.Visible = false;

            
            EmployeeDetailsInfo objDisplayEmpNOK = new EmployeeDetailsInfo();
            int empID = Convert.ToInt32(ddEditNOKEmpID.SelectedValue);
            objDisplayEmpNOK = (new EmployeeDetailsController()).Get(empID);

            txtNxtOfKinfName.Text = objDisplayEmpNOK.NxtOfKinFName;
            txtNxtOfKinMidName.Text = objDisplayEmpNOK.NxtOfKinMidName;
            txtNxtOfKinLName.Text = objDisplayEmpNOK.NxtOfKinLName;
            txtNxtOfKinOccupation.Text = objDisplayEmpNOK.NxtOfKinOccupation;
            txtNxtOfKinEmail.Text = objDisplayEmpNOK.NxtOfKinEmail;
            txtNxtOfKinContAdd.InnerText = objDisplayEmpNOK.NxtOfKinAddress;
            txtNxtOfKinPhNo.Text = objDisplayEmpNOK.NxtOfKinPhoneNo;
            txtNxtOfKinRelationship.Text = objDisplayEmpNOK.NxtOfKinRelationship;          


        }


        #endregion


        //Upadting Employee Spouse Info

        #region
        protected void nextOfKinSaveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                EmployeeDetailsInfo objNOKEditUpdate = new EmployeeDetailsInfo();
                objNOKEditUpdate.NxtOfKinFName = txtNxtOfKinfName.Text.Trim();
                objNOKEditUpdate.NxtOfKinMidName = txtNxtOfKinMidName.Text.Trim();
                objNOKEditUpdate.NxtOfKinLName = txtNxtOfKinLName.Text.Trim();
                objNOKEditUpdate.NxtOfKinAddress = txtNxtOfKinContAdd.InnerText.Trim();
                objNOKEditUpdate.NxtOfKinEmail = txtNxtOfKinEmail.Text.Trim();
                objNOKEditUpdate.NxtOfKinOccupation = txtNxtOfKinOccupation.Text.Trim();
                objNOKEditUpdate.NxtOfKinPhoneNo = txtNxtOfKinPhNo.Text.Trim();
                objNOKEditUpdate.NxtOfKinRelationship = txtNxtOfKinRelationship.Text.Trim();
                objNOKEditUpdate.EmployeeID = Convert.ToInt32(ddEditNOKEmpID.SelectedValue);

                (new EmployeeDetailsController()).EditNOKUpdate(objNOKEditUpdate);

                EmployeeDetailsInfo objGetNOK = new EmployeeDetailsInfo();
                objGetNOK = (new EmployeeDetailsController()).Get(Convert.ToInt32(ddEditNOKEmpID.SelectedValue));

                if(
                    (objGetNOK.NxtOfKinAddress == txtNxtOfKinContAdd.InnerText) && (objGetNOK.NxtOfKinEmail == txtNxtOfKinEmail.Text) &&
                    (objGetNOK.NxtOfKinFName == txtNxtOfKinfName.Text) && (objGetNOK.NxtOfKinLName == txtNxtOfKinLName.Text) &&
                    (objGetNOK.NxtOfKinMidName == txtNxtOfKinMidName.Text) && (objGetNOK.NxtOfKinOccupation == txtNxtOfKinOccupation.Text) &&
                    (objGetNOK.NxtOfKinPhoneNo == txtNxtOfKinPhNo.Text) && (objGetNOK.NxtOfKinRelationship == txtNxtOfKinRelationship.Text) &&
                    (objGetNOK.EmployeeID == Convert.ToInt32(ddEditNOKEmpID.SelectedValue)))

                    
                {
                    MViewHRPage.ActiveViewIndex = 21;
                    lbEmpNOKEdited.Visible = true;
                    lbEmpNOKEdited.Text = "Employee NOK Info Successfully Updated. Thank you!";
                    lbEmpSpouseAdded.Visible = false;
                    lbEmpInfoEdited.Visible = false;
                    BtnEditFinish.Visible = true;

                }
                else{
                    MViewHRPage.ActiveViewIndex = 21;
                    lbEmpNOKEdited.Visible = true;
                    lbEmpNOKEdited.Text = "Thank you! Employee NOK Info Not Updated.";
                    lbEmpSpouseAdded.Visible = false;
                    lbEmpInfoEdited.Visible = false;
                    BtnEditFinish.Visible = true;
                }

            }
            catch
            {

            }
        }

        #endregion

        #endregion





        #endregion


        //TryAgain buttons

        #region
        protected void btnaccptTryAgain_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 1;
            btnaccptFinsh.Visible = false;
            btnaccptTryAgain.Visible = false;
            hrEmpProfilePanel.Visible = true;
            LbEmpDetailsAdded1.Visible = false;
            LbEmpIDgeneratedhere1.Visible = false;
        }

        protected void btnAssignHODTryAgain_Click(object sender, EventArgs e)
        {
            PanelAssignHOD1.Visible = true;
            GViewAssignHOD.Visible = false;
            btnAssignHODFinish.Visible = false;
            btnAssignHODTryAgain.Visible = false;
            LbHODUpdateSuccessful.Visible = false;
            LbHODUpdateSuccessful1.Visible = false;
            assignHODBtn.Visible = false;
        }
        #endregion


        protected void btnaccptFinsh_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }
        protected void empFinishBtn_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 0;
        }

        //Report

        #region "Report"

        protected void menuBtnReport_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 27;

        }

        protected void LinkBtnEmpList_Click(object sender, EventArgs e)
        {
            MViewHRPage.ActiveViewIndex = 28;
            //ArrayList objRepEmpList = new ArrayList();
            //objRepEmpList = (new EmployeeDetailsController()).ListOrderByDeptAndLocation();
            //if (objRepEmpList.Count > 0)
            //{
            //    GViewReportEmpList.DataSource = objRepEmpList;
            //    GViewReportEmpList.DataBind();
            //    GViewReportEmpList.Visible = true;
            //    PanelEmpList.Visible = true;
            //}

            //string url = "http://" + Request.Url.Authority + "/Print5.aspx?id=" + applicantID.ToString();
            //Response.Write("<script language=javascript> window.open( '" + url + "','_blank');</script>");

            BindGViewReportEmpList();
           
        }

        private void BindGViewReportEmpList()
        {
            ArrayList objRepEmpList = new ArrayList();
            objRepEmpList = (new EmployeeDetailsController()).ListOrderByDeptAndLocation();
            if (objRepEmpList.Count > 0)
            {
                GViewReportEmpList.DataSource = objRepEmpList;
                GViewReportEmpList.DataBind();
                GViewReportEmpList.Visible = true;
                PanelEmpList.Visible = true;
            }
        }
        #endregion




        protected void btnExportEmpList_Click(object sender, EventArgs e)
        {
           string url = "http://" + Request.Url.Authority + "/PrintEmpList.aspx?";
           //+ applicantID.ToString();
           Response.Write("<script language=javascript> window.open( '" + url + "','_blank');</script>");


            //Response.ClearContent();
            //Response.AppendHeader("content-disposition", "attachment; filename=Employees.xls");
            //Response.ContentType = "application/excel";
            //StringWriter stringWriter = new StringWriter();
            //HtmlTextWriter htw = new HtmlTextWriter(stringWriter);
            //GViewReportEmpList.HeaderRow.Style.Add("background-color", "#FFFFFF");
            //GViewReportEmpList.RenderControl(htw);
            //Response.Write(stringWriter.ToString());
            //Response.End();  
        }
   
       //Google Chart'
      #region 


      //  //Google Chart2

      //  #region

        protected void LinkBtnAppChart_Click(object sender, EventArgs e)
        {
            //     ArrayList objAppChart = new ArrayList();
            //     objAppChart = (new EmployeeAppraisalTableController()).ListForChart();

            //     if (objAppChart.Count > 0)
            //     {
            //         GViewAppChart.DataSource = objAppChart;
            //         GViewAppChart.DataBind();
            //         GViewAppChart.Visible = true;
                   MViewHRPage.ActiveViewIndex = 29;
            //     }
            //  //    ViewState.Add("objAppChart", objAppChart);
            //  //    //EmployeeAppraisalTableInfo chartList1 = new EmployeeAppraisalTableInfo();
            //  //    // List<EmployeeAppraisalTableInfo> chartList = new List<EmployeeAppraisalTableInfo>();

            //  //    // foreach (DataRow dtRow in GViewAppChart.Rows)
            //  //    // {
            //  //    //     EmployeeAppraisalTableInfo AppInfo1 = new EmployeeAppraisalTableInfo();
            //  //    //     AppInfo1.AppraisalID = Convert.ToInt32(dtRow[0]);
            //  //    //     AppInfo1.EmployeeNum = dtRow[1].ToString();
            //  //    //     AppInfo1.AppraisalScore = Convert.ToInt32(dtRow[2]);
            //  //    //     AppInfo1.PromoExamScore = Convert.ToInt32(dtRow[3]);
            //  //    //     AppInfo1.TotalAppraisalScore = Convert.ToInt32(dtRow[4]);

            //  //    //     chartList.Add(AppInfo1);
            //  //    //return;
            //  //    // }
            //  //     ////return 
            //  //     ////return chartList;


            //      //Converting ArrayList to DataTabel

            //      ArrayList objArrayToDataTable = new ArrayList();
            //      objArrayToDataTable.Add("AppraisalID");
            //      objArrayToDataTable.Add("EmployeeNum");
            //      objArrayToDataTable.Add("AppraisalScore");
            //      objArrayToDataTable.Add("PromoExamScore");
            //      objArrayToDataTable.Add("TotalAppraisalScore");

            //      //Create new DataTable

            //      DataTable objNewTable = new DataTable("table");

            //      //Declare and create DataColumn and DataRow variables

            //      DataColumn column = new DataColumn();
            //      column.DataType= Type.GetType("System.String");
            //      column.ColumnName ="Item";
            //      table.Column.Add(column);
            //      DataRow row = new DataRow();

            //      //Add items from ArrayList to DataTable
            //      foreach(string item in objArrayToDataTable)
            //      {
            //          row = table.NewRow();
            //          row["item"] = item;
            //          table.Rows.Add(row);
            //      }
        }

            
          public  List<EmployeeAppraisalTableInfo> GetChartData()
          {

             ArrayList objAppChart = new ArrayList();
              objAppChart = (new EmployeeAppraisalTableController()).ListForChart();

              if (objAppChart.Count > 0)
              {
                  GViewAppChart.DataSource = objAppChart;
                  GViewAppChart.DataBind();
                  GViewAppChart.Visible = true;
                  MViewHRPage.ActiveViewIndex = 29;
              }


              string objA = (ViewState["objAppChart"]).ToString();
              GridView objGrid = new GridView();
              List<EmployeeAppraisalTableInfo> chartList = new List<EmployeeAppraisalTableInfo>();
              ArrayList objTez = new ArrayList();
              objTez = (new EmployeeAppraisalTableController()).ListForChart();
              for (int i = 0; i < GViewAppChart.Rows.Count; i++)
                 {
                      EmployeeAppraisalTableInfo objApp = new EmployeeAppraisalTableInfo();
                   objApp.AppraisalID = Convert.ToInt32(GViewAppChart.Rows[i].Cells[0].Text);
                              objApp.EmployeeNum = GViewAppChart.Rows[i].Cells[1].Text.ToString();
                             objApp.AppraisalScore = Convert.ToInt32(GViewAppChart.Rows[i].Cells[2].Text);
                            objApp.PromoExamScore = Convert.ToInt32(GViewAppChart.Rows[i].Cells[3].Text);
                             objApp.TotalAppraisalScore = Convert.ToInt32(GViewAppChart.Rows[i].Cells[4].Text);

                      ////foreach (GridViewRow row in GViewAppChart.Rows)
              

              }

              return chartList;

          }
          #endregion
        protected void LinkBtnAppChartDisplay_Click(object sender, System.EventArgs e)
        {
            //GetChartData();
           string url = "http://" + Request.Url.Authority + "/AppraisalChart.aspx?";
            Response.Write("<script language=javascript> window.open( '" + url + "','_blank');</script>");
        }

        protected void LinkBtnColumnChart_Click(object sender, System.EventArgs e)
        {
            string url = "http://" + Request.Url.Authority + "/AppraisalColumnChart.aspx?";
            Response.Write("<script language=javascript> window.open( '" + url + "','_blank');</script>");
        }
}
}


       






