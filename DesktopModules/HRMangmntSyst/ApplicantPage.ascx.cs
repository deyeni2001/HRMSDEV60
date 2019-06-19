
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
//using System.
using ola.HRMangmntSyst;


namespace ola.HRMangmntSyst
{

    public partial class ApplicantPage : PortalModuleBase, IActionable
    {
      //  ApplicantPersonalDetailsController objApplicantPersonalDetailsController;
        string passport;
        string filepath2;
        int applicantID;
        int employeeID;
        DataTable dt1 = new DataTable();
        bool flag = false;

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

            try
            {
                if (!IsPostBack)
                {
                    MViewApplicant.ActiveViewIndex = 0;
                    // day dropdownlist
                    var day = new ArrayList();
                    day.Add("Day");
                    for (var i = 1; i <= 31; i++)
                    {
                        day.Add(i);
                    }

                    ddlDay.DataSource = day;
                    ddlDay.DataBind();

                    ddlWorkStartDay.DataSource = day;
                    ddlWorkStartDay.DataBind();

                    ddlWorkEndDay.DataSource = day;
                    ddlWorkEndDay.DataBind();

                    // year dropdownlist
                    var al = new ArrayList();
                    al.Add("Year");
                    for (var i = 2018; i >= 1900; i--)
                    {
                        al.Add(i);
                    }

                    ddlYear.DataSource = al;
                    ddlYear.DataBind();
                    //ddlYear2.DataSource = al;
                    //ddlYear2.DataBind();

                    ddlWorkStartYear.DataSource = al;
                    ddlWorkStartYear.DataBind();

                    ddlWorkEndYear.DataSource = al;
                    ddlWorkEndYear.DataBind();


                    ddlCertYear.DataSource = al;
                    ddlCertYear.DataBind();

                    qualifEndYearList.DataSource = al;
                    qualifEndYearList.DataBind();

                    //loading conutry list

                    ArrayList objCountry = new ArrayList();
                    objCountry = (new CountryTableController()).List();
                    if (objCountry.Count > 0)
                    {
                        ddlCountry.DataSource = objCountry;
                        ddlCountry.DataTextField = "countryName";
                        ddlCountry.DataValueField = "countryID";
                        ddlCountry.DataBind();
                        ddlCountry.Items.Insert(0, new ListItem("---Please select---", "-1"));
                    }
                    ddlState.Items.Insert(0, new ListItem("---Please select---", "-1"));
                    ddlLga.Items.Insert(0, new ListItem("---Please select---", "-1"));

                    ////loading Qualifiactions list
                    ArrayList objQualifications = new ArrayList();

                    objQualifications = (new QualificationsController()).List();
                    if (objQualifications.Count > 0)
                    {
                        qualifList.DataSource = objQualifications;
                        qualifList.DataTextField = "qualifName";
                        qualifList.DataValueField = "qualifID";
                        qualifList.DataBind();

                        qualifList.Items.Insert(0, new ListItem("---Please Select---", "-1"));

                    }

                   // Loading Department
                    ArrayList objDept = new ArrayList();
                    objDept = (new ApplicantDepartmentTableController()).List();
                    if (objDept.Count > 0)
                    {
                        ddlApplicantDept.DataSource = objDept;
                        ddlApplicantDept.DataTextField = "DeptName";
                        ddlApplicantDept.DataValueField = "DeptID";
                        ddlApplicantDept.DataBind();
                    }
                    ddlApplicantDept.Items.Insert(0, new ListItem("***Please select***", "-1"));
                    ddlAvailablePosition.Items.Insert(0, new ListItem("***Please select***", "-1"));


                }
            }
            catch (Exception  ex)
            {
                
                throw ex;
            }
        }
       



        //protected void applyBtn_Click(object sender, EventArgs e)
        //{
        //    MViewApplicant.ActiveViewIndex = 1;
        //}
        protected void applicantNextBtn_Click(object sender, EventArgs e)
        {
           
            MViewApplicant.ActiveViewIndex = 2;
            PanelAppQualification.Visible = true;
            lblqualif1.Visible = false;
            lblQualificationMessage.Visible = false;
            qualifNextBtn1.Visible = false;
            qualifTryAgainBtn.Visible = false;


        }

        protected void qualifNextBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
            PanelAppCertification.Visible = true;
            lblprof1.Visible = false;
            certNextBtn1.Visible = false;
            certTryAgainBtn.Visible = false;
        }
        protected void qualifBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
        }
        protected void certNextBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
            PanelAppWorkingExper.Visible = true;
            lblworkExp1.Visible = false;
            workNextBtn1.Visible = false;
            workTryAgain.Visible = false;
        }
        protected void certBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 2;
        }
        protected void workNextBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 5;
            PanelAppDocument.Visible = true;
            DocumentNextBtn1.Visible = false;
            DocTryAgain.Visible = false;
            lblDoc1.Visible = false;
        }
        protected void workBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
        }
        protected void docBackBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 0;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 2;
            PanelAppQualification.Visible = true;
            lblqualif1.Visible = false;
            lblQualificationMessage.Visible = false;

            qualifNextBtn1.Visible = false;
            qualifTryAgainBtn.Visible = false;

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
            PanelAppCertification.Visible = true;
            lblprof1.Visible = false;
            certNextBtn1.Visible = false;
            certTryAgainBtn.Visible = false;
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
            PanelAppWorkingExper.Visible = true;
            lblworkExp1.Visible = false;
            workNextBtn1.Visible = false;
            workTryAgain.Visible = false;
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 5;
            PanelAppDocument.Visible = true;
            DocumentNextBtn1.Visible = false;
            DocTryAgain.Visible = false;
            lblDoc1.Visible = false;

        }
            //Viewing Application Summary

        #region
        protected void Button9_Click(object sender, EventArgs e)
        {
          
            MViewApplicant.ActiveViewIndex = 6;
            //int applicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            ArrayList ObjArr = new ArrayList();


            ApplicantPersonalDetailsInfo objPersonalDetailInfo = new ApplicantPersonalDetailsInfo();
            objPersonalDetailInfo = (new ApplicantPersonalDetailsController()).Get(applicantID);

            CountryTableInfo objCountry = new CountryTableInfo();
            int countryID = objPersonalDetailInfo.Nationality_FK;
            objCountry = (new CountryTableController()).Get(countryID);

            StateTableInfo objState = new StateTableInfo();
            int stateID = objPersonalDetailInfo.StateOfOrigin_FK;
            objState = (new StateTableController()).Get(stateID);

            LGATableInfo objLga = new LGATableInfo();
            int lgaID = objPersonalDetailInfo.LGA_FK;
            objLga = (new LGATableController()).Get(lgaID);


            lblDeptAppliedTo.Text = objPersonalDetailInfo.PositionAppliedFor;
            lbAppTitle.Text = objPersonalDetailInfo.Title;
            lbAppNum.Text = objPersonalDetailInfo.ApplicantNum;
            lblFirstName.Text = objPersonalDetailInfo.FirstName;
            lblLastName.Text = objPersonalDetailInfo.LastName;
            lblMiddleName.Text = objPersonalDetailInfo.MiiddleName;
            lblGender.Text = objPersonalDetailInfo.Gender;
            lblMaritalStatus.Text = objPersonalDetailInfo.MaritalStatus;
            lblDOB.Text = objPersonalDetailInfo.DateOfBirth;
            lblAge.Text = objPersonalDetailInfo.Age.ToString();
            lblNationality.Text = objCountry.CountryName;
            lblStateofOrigin.Text = objState.StateName;
            lblLGA.Text = objLga.LgaName;
            lblHomeTown.Text = objPersonalDetailInfo.HomeTown;
            lblEmail.Text = objPersonalDetailInfo.Email;
            lblPhoneNo.Text = objPersonalDetailInfo.PhoneNo;
            lblContactAddress.Text = objPersonalDetailInfo.ContactAddress;
            ImagePassport.ImageUrl = "~/images/" + objPersonalDetailInfo.Passport.Substring(objPersonalDetailInfo.Passport.LastIndexOf('\\') + 1);


            // Qualification summary
            ArrayList ObjArrQualification = new ArrayList();
            ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
            foreach (var item in ObjArrQualification)
            {
                GViewQualifSummary.DataSource = (ObjArrQualification);
                GViewQualifSummary.DataBind();
                GViewQualifSummary.Visible = true;
            }

            //  professional Qualification summary
            ArrayList ObjArrProfQualification = new ArrayList();
            ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
            // ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
            foreach (var item in ObjArrProfQualification)
            {
                GViewProfQualifSummary.DataSource = (ObjArrProfQualification);
                GViewProfQualifSummary.DataBind();
                GViewProfQualifSummary.Visible = true;
            }
            //  Wwork Experience summary
            ArrayList ObjArrWorkExp = new ArrayList();
            ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
            foreach (var item in ObjArrWorkExp)
            {
                GViewWorkExpSummary.DataSource = (ObjArrWorkExp);
                GViewWorkExpSummary.DataBind();
                GViewWorkExpSummary.Visible = true;
            }

            //  Document summary
            ArrayList ObjArrDoc = new ArrayList();
            ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
            foreach (var item in ObjArrDoc)
            {
                GViewDocSummary.DataSource = (ObjArrDoc);
                GViewDocSummary.DataBind();
                GViewDocSummary.Visible = true;
            }
        }

        #endregion


        protected void ddlYear2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 5;
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 0;
        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 2;
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
        }
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
        }
        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 6;
        }
       
     
      //here
        protected void Button10_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 1;
            ApplicantNextBtn1.Visible = false;
            PanelApplicantDetails.Visible = true;
            LbDetailsAdded1.Visible = false;
            ApplicantTryAgain.Visible = false;
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 7;
            PanelApplicantDetails.Visible = true;
        }


        //Loading Index tables

        #region

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objCountry = new ArrayList();
            int countryID = Convert.ToInt32(ddlCountry.SelectedValue);
            objCountry = (new StateTableController()).GetByCountryTable(countryID);
            if (objCountry.Count > 0)
            {
                ddlState.DataSource = objCountry;
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateID";
                ddlState.DataBind();

                ddlState.Items.Insert(0, new ListItem("---Please selct---", "-1"));
            }
        }
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objState = new ArrayList();
            int stateID = Convert.ToInt32(ddlState.SelectedValue);
            objState = (new LGATableController()).GetByStateTable(stateID);
            if (objState.Count > 0)
            {
                ddlLga.DataSource = objState;
                ddlLga.DataTextField = "LgaName";
                ddlLga.DataValueField = "LgaID";
                ddlLga.DataBind();

                ddlLga.Items.Insert(0, new ListItem("---Please select---", "-1"));
            }

           ArrayList objGetState = new ArrayList();
           int stateID2 = Convert.ToInt32(ddlState.SelectedValue);
           objGetState = (new SenatorialTableController()).GetByStateTable(stateID2);
           if (objGetState.Count > 0)
            {

                ddlSenatorial.DataSource = objGetState;
                ddlSenatorial.DataTextField = "senName";
                ddlSenatorial.DataValueField = "senID";
                ddlSenatorial.DataBind();

                ddlSenatorial.Items.Insert(0, new ListItem("---Please select---", "-1"));
            }
        }
        protected void qualifList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objQualifications = new ArrayList();
            int qualifID = Convert.ToInt32(qualifList.SelectedValue);
            objQualifications = (new GradeTableController()).GetByQualifications(qualifID);

            if (objQualifications.Count > 0)
            {
                gradeList.DataSource = objQualifications;
                gradeList.DataTextField = "gradeName";
                gradeList.DataValueField = "gradeID";
                gradeList.DataBind();

                gradeList.Items.Insert(0, new ListItem("---Grades---", "-1"));
            }
        }


        protected void qualifAddBtn_Click(object sender, EventArgs e)
        {
            //int applicantID = Convert.ToInt32(Session["applID"]);
            //ArrayList objQualifAdd = new ArrayList();

            //if (GViewQualif.Rows.Count >0)
            //{
            //    for (int i = 0; i < GViewQualif.Rows.Count; i++)
            //    {
            //        ApplicantQualificationInfo objQualification = new ApplicantQualificationInfo();
            //        objQualification.ApplicantID_FK = Convert.ToInt32(GViewQualif.Rows[i].Cells[0].Text);
            //        objQualification.InstitutionName = GViewQualif.Rows[i].Cells[1].Text;
            //        objQualification.QualificationType = GViewQualif.Rows[i].Cells[2].Text;
            //        objQualification.Course = GViewQualif.Rows[i].Cells[3].Text;
            //        objQualification.Grade = GViewQualif.Rows[i].Cells[4].Text;
            //        objQualification.StartYear = GViewQualif.Rows[i].Cells[5].Text;
            //        objQualification.EndYear = GViewQualif.Rows[i].Cells[6].Text;

            //        objQualifAdd.Add(objQualification);
            //    }
            //}

            //ApplicantQualificationInfo objQaulificationInfo = new ApplicantQualificationInfo();
            //objQaulificationInfo.ApplicantID_FK = applicantID;
            //objQaulificationInfo.InstitutionName = this.txtQualifSchName.Text;
            //objQaulificationInfo.QualificationType = Convert.ToString(this.qualifList.SelectedItem);
            //objQaulificationInfo.Course = this.courseList.SelectedValue;
            //objQaulificationInfo.Grade = Convert.ToString(this.gradeList.SelectedItem);
            //objQaulificationInfo.StartYear = this.qualifStartYearList.SelectedValue;
            //objQaulificationInfo.EndYear = this.qualifEndYearList.SelectedValue;


            //objQualifAdd.Add(objQaulificationInfo);
            //GViewQualif.DataSource = objQualifAdd;
            //GViewQualif.DataBind();
            //GViewQualif.Visible = true;


        }

        protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today; //get today's date
            int age = now.Year - Convert.ToInt32(ddlYear.SelectedValue);
            txtAge.Text = Convert.ToString(age);
        }

        #endregion



        //Applicantion Module

        #region

        //Personal Details

        #region

        //Uploading Passport

        #region
        protected void passportUploadBtn_Click(object sender, EventArgs e)
        {
            if (UploadPassport.HasFile)
            {

                HttpPostedFile file = UploadPassport.PostedFile;
                int filesize = file.ContentLength; // get file size
                string filename = UploadPassport.FileName.ToString();// get file  full name  including extension

                // upload the file

                string uploadfolderpath = "~/images/";
                filepath2 = HttpContext.Current.Server.MapPath(uploadfolderpath).ToString();
                UploadPassport.SaveAs(filepath2 + "\\" + filename);
                Image1.ImageUrl = "~/images/" + "/" + UploadPassport.FileName.ToString();
                lblPassportName.Text = filename;
                Session["passportPath"] = filepath2;
                ViewState.Add("var", filename);

                var fileExtension = filename.Substring(filename.LastIndexOf("."));// file extension


            }

            else
            {
                // LbUploadSuccessful.Visible = true;
                // LbUploadSuccessful.Text = "Plz try uploading again";
            }
        }

        #endregion


        //Application Try again

        #region
        protected void ApplicantTryAgain_Click(object sender, EventArgs e)
        {
            ApplicantNextBtn1.Visible = false;
            PanelApplicantDetails.Visible = true;
            LbDetailsAdded1.Visible = false;
            ApplicantTryAgain.Visible = false;
        }
        #endregion

        //Svaing Personal details

        #region

        #region "LoadingPositionAppliedfor
        protected void ddlApplicantDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList objGetAvalPostByDept = new ArrayList();
            int dept = Convert.ToInt32(ddlApplicantDept.SelectedValue);          
            objGetAvalPostByDept = (new ApplicantAvailablePositiontableController()).GetByApplicantDepartmentTable(dept);
            if (objGetAvalPostByDept.Count > 0)
            {
                ddlAvailablePosition.DataSource = objGetAvalPostByDept;
                ddlAvailablePosition.DataTextField = "PositionAppliedForName";
                ddlAvailablePosition.DataValueField = "PositionAppliedForName";
                ddlAvailablePosition.DataBind();

                ddlAvailablePosition.Items.Insert(0, new ListItem("***Please select***", "-1"));
            }

        }

        #endregion

        protected void appSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                ApplicantPersonalDetailsInfo objApplicant = new ApplicantPersonalDetailsInfo();

                //Collecting applicant personal details
                objApplicant.DeptAppliedTo = this.ddlApplicantDept.SelectedItem.Text.Trim();
                objApplicant.PositionAppliedFor = this.ddlAvailablePosition.SelectedValue.Trim();
                objApplicant.Title = this.titleList.SelectedValue.Trim();
                objApplicant.FirstName = this.txtFName.Text.Trim();
                objApplicant.MiiddleName = this.txtMName.Text.Trim();
                objApplicant.LastName = this.txtLName.Text.Trim();
                objApplicant.MaritalStatus = this.ddlMaritalStatus.SelectedValue.Trim();
                objApplicant.Email = this.txtEmail.Text.Trim();
                objApplicant.PhoneNo = this.txtPhnNum.Text.Trim();
                objApplicant.Gender = this.rbtnGender.SelectedValue.Trim();
                objApplicant.ContactAddress = this.txtContAddr.Text.Trim();
                objApplicant.Religion = this.religionList.SelectedValue.Trim();
                objApplicant.DateOfBirth = ddlDay.SelectedItem + "-" + ddlMonth.SelectedItem + "-" + ddlYear.SelectedItem;

                objApplicant.Age = txtAge.Text;
                objApplicant.Nationality_FK = Convert.ToInt32(this.ddlCountry.SelectedItem.Value);
                objApplicant.StateOfOrigin_FK = Convert.ToInt32(this.ddlState.SelectedItem.Value);
                objApplicant.senID_FK = Convert.ToInt32(this.ddlSenatorial.SelectedValue);
                objApplicant.LGA_FK = Convert.ToInt32(this.ddlLga.SelectedItem.Value);
                objApplicant.HomeTown = txtHometown.Text.Trim();


                string var2 = ViewState["var"].ToString();
                string path2 = Session["passportPath"].ToString();
                objApplicant.Passport = path2 + var2;

                applicantID = (new ApplicantPersonalDetailsController()).Add(objApplicant);

                string applicantNum2;
                if (txtApplicationNum.Text != "")
                {
                    applicantNum2 = txtApplicationNum.Text;
                }
                else
                {
                    applicantNum2 = lblNotVisibleApplicantNum.Text;
                    lblNotVisibleApplicantNum.Visible = false;
                }

                if (applicantNum2 == "")
                {
                    applicantID = (new ApplicantPersonalDetailsController()).Add(objApplicant);



                    if (applicantID > 0)
                    {

                        string appplicantid = applicantID.ToString();


                        string applicantNum = "NTL" + "/" + objApplicant.LastName + "/ " + DateTime.Now.ToString("yyyy") + "/" + appplicantid;
                        ViewState.Add("applicantID", applicantID);
                        ViewState.Add("applicantNum", applicantNum);

                        ApplicantPersonalDetailsInfo objApplicant2 = new ApplicantPersonalDetailsInfo();
                        objApplicant2.ApplicantID = applicantID;
                        objApplicant2.ApplicantNum = applicantNum;
                        (new ApplicantPersonalDetailsController()).UpdateApplicantNum(objApplicant2);


                        LbDetailsAdded.Visible = true;
                        LbDetailsAdded.Text = "Detial Successfully Added,Your application number is:  " + applicantNum;

                        Utility.Alert("Detail added successfully.  Your application number is: " + applicantNum + "   Click next to continue");

                        PanelApplicantDetails.Visible = false;
                        LbDetailsAdded1.Visible = true;
                        LbDetailsAdded1.Text = "Detial Successfully Added,Your application number is:  " + applicantNum;
                        ApplicantNextBtn1.Visible = true;
                        ApplicantTryAgain.Visible = false;
                        //  refereshPage();
                    }
                    else
                    {
                        LbDetailsAdded.Text = "Error! Details not added.";
                        LbDetailsAdded.Visible = true;
                        PanelApplicantDetails.Visible = false;
                        LbDetailsAdded1.Text = "Error! Details not added.";
                        LbDetailsAdded1.Visible = true;
                        ApplicantNextBtn1.Visible = false;
                        ApplicantTryAgain.Visible = true;
                        //  refereshPage();

                    }
                }

                else
                {
                    objApplicant.ApplicantNum = applicantNum2;
                    objApplicant.ApplicantID = Convert.ToInt32(applicantNum2.Substring(applicantNum2.LastIndexOf('/') + 1));
                    (new ApplicantPersonalDetailsController()).UpdateUsingApplicantNum(objApplicant);
                    string applicantNum = applicantNum2;

                    ViewState.Add("applicantNum", applicantNum);
                    qualifSaveBtn.Visible = true;
                    LbDetailsAdded.Text = "Detial Successfully Updated, Click next to continue";
                    ApplicantNextBtn.Visible = true;
                    ApplicantNextBtn.Enabled = true;
                    Utility.Alert("Detial Successfully Updated, Click next to continue");

                    PanelApplicantDetails.Visible = false;
                    LbDetailsAdded1.Visible = true;
                    LbDetailsAdded1.Text = "Detial Successfully Updated, Click next to continue";
                    ApplicantTryAgain.Visible = false;

                }



            }

            catch
            {

            }

            //Session["applicantnumber"] = applicantID;
        }

        #endregion


        //Continueing application

        #region
        protected void continueAppBtn_Click(object sender, EventArgs e)
        {
            string applicantNum = txtApplicationNum.Text;
            ViewState.Add("applicantNum", applicantNum);
            //int applicantID= Convert.ToInt32( applicantNum.Substring(applicantNum.LastIndexOf("\\")));

            ApplicantPersonalDetailsInfo objPersonalDetail = new ApplicantPersonalDetailsInfo();

            objPersonalDetail = new ApplicantPersonalDetailsController().GetByApplicantNum(applicantNum);
            ddlApplicantDept.ClearSelection();
            ddlApplicantDept.Items.FindByText(objPersonalDetail.DeptAppliedTo).Selected = true;
            ddlAvailablePosition.ClearSelection();
            ddlAvailablePosition.Items.FindByText(objPersonalDetail.PositionAppliedFor).Selected = true;
            txtFName.Text = objPersonalDetail.FirstName;
            txtMName.Text = objPersonalDetail.MiiddleName;
            txtLName.Text = objPersonalDetail.LastName;
            ddlMaritalStatus.ClearSelection();
            ddlMaritalStatus.Items.FindByText(objPersonalDetail.MaritalStatus).Selected = true;
            txtEmail.Text = objPersonalDetail.Email;
            txtContAddr.Text = objPersonalDetail.ContactAddress;
            txtPhnNum.Text = objPersonalDetail.PhoneNo;
            if (objPersonalDetail.Gender == "Male")
            {
                rbtnGender.SelectedIndex = 0;
            }
            else
            {
                rbtnGender.SelectedIndex = 1;
            }
            ddlDay.ClearSelection();
            ddlDay.Items.FindByText(objPersonalDetail.DateOfBirth.Substring(0, 2)).Selected = true;
            ddlMonth.ClearSelection();
            ddlMonth.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(3, objPersonalDetail.DateOfBirth.LastIndexOf('-') - 3);
            ddlYear.ClearSelection();
            ddlYear.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(objPersonalDetail.DateOfBirth.LastIndexOf('-') + 1);


            txtAge.Text = objPersonalDetail.Age;
            ddlCountry.ClearSelection();
            ddlCountry.Items.FindByText(objPersonalDetail.Nationality).Selected = true;

            // reload state drop downlist
            ddlState.ClearSelection();
            ddlState.DataSource = (new StateTableController()).List();
            ddlState.DataValueField = "StateID";
            ddlState.DataTextField = "StateName";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem((new StateTableController()).Get(objPersonalDetail.StateOfOrigin_FK).StateName, objPersonalDetail.StateOfOrigin_FK.ToString()));

            // reload lga drop downlist
            ddlLga.ClearSelection();
            ddlLga.DataSource = (new LGATableController()).List();
            ddlLga.DataValueField = "LgaID";
            ddlLga.DataTextField = "LgaName";
            ddlLga.DataBind();
            ddlLga.Items.Insert(0, new ListItem((new LGATableController()).Get(objPersonalDetail.LGA_FK).LgaName, objPersonalDetail.LGA_FK.ToString()));


            txtHometown.Text = objPersonalDetail.HomeTown;
            ImagePassport.ImageUrl = "~/images/" + objPersonalDetail.Passport.Substring(objPersonalDetail.Passport.LastIndexOf('\\') + 1);

            // Image1.ImageUrl = "~/Image/" + objPersonalDetail.Passport.Substring(objPersonalDetail.Passport.LastIndexOf('\\') + 1);
            // UploadPassport.DataBind = objPersonalDetail.Passport;
            ImagePassport.Visible = true;
            // UploadPassport.

            MViewApplicant.ActiveViewIndex = 1;
            PanelApplicantDetails.Visible = true;
            ApplicantNextBtn.Enabled = true;

            // ApplicantNextBtn.Visible = false;

        }
        #endregion


        //Editing Personal details

        #region

        protected void btnEditPersonalDetails_Click(object sender, EventArgs e)
        {

            MViewApplicant.ActiveViewIndex = 1;
            string applicantNum = lbAppNum.Text;

            ApplicantPersonalDetailsInfo objPersonalDetail = new ApplicantPersonalDetailsInfo();
            objPersonalDetail = new ApplicantPersonalDetailsController().GetByApplicantNum(applicantNum);

            ddlApplicantDept.ClearSelection();
            ddlApplicantDept.Items.FindByText(objPersonalDetail.DeptAppliedTo).Selected = true;

            ddlAvailablePosition.ClearSelection();
            ddlAvailablePosition.Items.FindByText(objPersonalDetail.PositionAppliedFor).Selected = true;

            titleList.ClearSelection();
            titleList.Items.FindByText(objPersonalDetail.Title).Selected = true;
            txtFName.Text = objPersonalDetail.FirstName;
            txtMName.Text = objPersonalDetail.MiiddleName;
            txtLName.Text = objPersonalDetail.LastName;
            ddlMaritalStatus.ClearSelection();
            ddlMaritalStatus.Items.FindByText(objPersonalDetail.MaritalStatus).Selected = true;
            religionList.ClearSelection();
            religionList.Items.FindByText(objPersonalDetail.Religion).Selected = true;
            txtEmail.Text = objPersonalDetail.Email;
            txtContAddr.Text = objPersonalDetail.ContactAddress;
            txtPhnNum.Text = objPersonalDetail.PhoneNo;
            if (objPersonalDetail.Gender == "Male")
            {
                rbtnGender.SelectedIndex = 0;
            }
            else
            {
                rbtnGender.SelectedIndex = 1;
            }
            ddlDay.ClearSelection();
            ddlDay.Items.FindByText(objPersonalDetail.DateOfBirth.Substring(0, 2)).Selected = true;
            ddlMonth.ClearSelection();
            ddlMonth.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(3, objPersonalDetail.DateOfBirth.LastIndexOf('-') - 3);
            ddlYear.ClearSelection();
            ddlYear.SelectedItem.Text = objPersonalDetail.DateOfBirth.Substring(objPersonalDetail.DateOfBirth.LastIndexOf('-') + 1);


            txtAge.Text = objPersonalDetail.Age;
            ddlCountry.ClearSelection();
            ddlCountry.Items.FindByText(objPersonalDetail.Nationality).Selected = true;

            // reload state drop downlist
            ddlState.ClearSelection();
            ddlState.DataSource = (new StateTableController()).List();
            ddlState.DataValueField = "StateID";
            ddlState.DataTextField = "StateName";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem((new StateTableController()).Get(objPersonalDetail.StateOfOrigin_FK).StateName, objPersonalDetail.StateOfOrigin_FK.ToString()));

            // reload lga drop downlist
            ddlLga.ClearSelection();
            ddlLga.DataSource = (new LGATableController()).List();
            ddlLga.DataValueField = "LgaID";
            ddlLga.DataTextField = "LgaName";
            ddlLga.DataBind();
            ddlLga.Items.Insert(0, new ListItem((new LGATableController()).Get(objPersonalDetail.LGA_FK).LgaName, objPersonalDetail.LGA_FK.ToString()));

            txtHometown.Text = objPersonalDetail.HomeTown;
            Image1.ImageUrl = "~/Image/" + objPersonalDetail.Passport.Substring(objPersonalDetail.Passport.LastIndexOf('\\') + 1);
           
            ImagePassport.Visible = true;
            lblNotVisibleApplicantNum.Text = objPersonalDetail.ApplicantNum;

        }
        #endregion

        #endregion

        //Qualifications Module

        #region

        //Saving Qualification

        #region
        protected void qualiSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewQualif.Rows)
                {
                    ApplicantQualificationInfo objQualificationInfo = new ApplicantQualificationInfo();

                    //objQualificationInfo.QualificationID= Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    objQualificationInfo.InstitutionName = g1.Cells[0].Text;
                    objQualificationInfo.QualificationType = g1.Cells[1].Text;
                    objQualificationInfo.Course = g1.Cells[2].Text;
                    objQualificationInfo.Grade = g1.Cells[3].Text;
                    objQualificationInfo.StartYear = g1.Cells[4].Text;
                    objQualificationInfo.EndYear = g1.Cells[5].Text;
                    objQualificationInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[6].Text);
                    //objQualificationInfo.EmployeeID_FK = Convert.ToInt32(g1.Cells[7].Text);
                    ObjArr.Add(objQualificationInfo);
                    int qualiicationID = (new ApplicantQualificationController()).Add(objQualificationInfo);
                    if (qualiicationID > 0)
                    {
                        //lblQualificationMessage.Visible = true;
                        lblqualif.Text = "Qualifications Added Successfully, Click next to provide your professional qualification";
                        lblqualif.Visible = true;
                        PanelAppQualification.Visible = false;
                        lblqualif1.Text = "Qualifications Added Successfully, Click next to provide your professional qualification";
                        lblqualif1.Visible = true;
                        qualifNextBtn1.Visible = true;
                        qualifTryAgainBtn.Visible = false;


                    }
                    else
                    {
                        lblqualif.Text = " Error! Qualification not added.";
                        lblqualif.Visible = true;
                        PanelAppQualification.Visible = false;
                        lblqualif1.Text = " Error! Qualification not added.";
                        lblqualif1.Visible = true;
                        qualifTryAgainBtn.Visible = true;
                        qualifNextBtn1.Visible = false;

                    }
                }
            }
            catch { }


        }


        #endregion

        //Qualif Try Again

        #region
        protected void qualifTryAgainBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 2;
            PanelAppQualification.Visible = true;
            qualifTryAgainBtn.Visible = false;
            qualifNextBtn1.Visible = false;
            lblqualif1.Visible = false;
            lblQualificationMessage.Visible = false;

        }

        #endregion

        //Deleting Qualification

        #region
        protected void GViewQualif_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                //find your textbox
                GridViewRow gvr = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
                TextBox txtQualifSchName = (TextBox)gvr.FindControl("txtQualifSchName");
                string name = txtQualifSchName.Text;
            }

            if (e.CommandName == "Delete")
            {

                new ApplicantQualificationController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];

                ArrayList ObjArrQualification = new ArrayList();
                ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrQualification.Count != 0)
                {

                    GViewQualif.DataSource = (ObjArrQualification);
                    GViewQualif.DataBind();

                }

            }

        }

        #endregion
        //Editing Qualification

        #region
        protected void GViewQualif_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GViewQualif.EditIndex = e.NewEditIndex;

            txtQualifSchName.Text = GViewQualif.Rows[e.NewEditIndex].Cells[0].Text;
            courseList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[1].Text;
            qualifList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[2].Text;
            gradeList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[3].Text;
            qualifStartYearList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[4].Text;
            qualifEndYearList.SelectedItem.Text = GViewQualif.Rows[e.NewEditIndex].Cells[5].Text;

        }

        #endregion

        //Updating Qualification

        #region
        //protected void GViewQualif_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    GridViewRow gvr = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
        //    TextBox txtQualifSchName = (TextBox)gvr.FindControl("txtQualifSchName");
        //    string name = txtQualifSchName.Text;

        //    if (e.CommandName == "Update")
        //    {
        //        //find your textbox
        //        GridViewRow gvr = (GridViewRow)((LinkButton)e.CommandSource).NamingContainer;
        //        TextBox txtQualifSchName = (TextBox)gvr.FindControl("txtQualifSchName");
        //        string name = txtQualifSchName.Text;
        //    }

        //}

        #endregion

        //Adding Quailifications

        #region
        protected void qualifAddBtn_Click1(object sender, EventArgs e)
        {
            //int appicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            lblMoreQualification.Visible = true;
            //GViewQualif.Visible = true;
            qualifSaveBtn.Visible = true;
            qualifSaveBtn.Enabled = true;

            ArrayList ObjArr = new ArrayList();

            if (GViewQualif.Rows.Count > 0)
            {
                for (int i = 0; i < GViewQualif.Rows.Count; i++)
                {
                    ApplicantQualificationInfo ObjApplicantQualification = new ApplicantQualificationInfo();
                    ObjApplicantQualification.InstitutionName = GViewQualif.Rows[i].Cells[0].Text.ToString();
                    ObjApplicantQualification.QualificationType = GViewQualif.Rows[i].Cells[1].Text.ToString();
                    ObjApplicantQualification.Course = GViewQualif.Rows[i].Cells[2].Text.ToString();
                    ObjApplicantQualification.Grade = GViewQualif.Rows[i].Cells[3].Text.ToString();
                    ObjApplicantQualification.StartYear = GViewQualif.Rows[i].Cells[4].Text.ToString();
                    ObjApplicantQualification.EndYear = GViewQualif.Rows[i].Cells[5].Text.ToString();
                    ObjApplicantQualification.ApplicantID_FK = Convert.ToInt32(GViewQualif.Rows[i].Cells[6].Text);
                    //ObjApplicantQualification.EmployeeID_FK = Convert.ToInt32(GViewQualif.Rows[i].Cells[7].Text);
                    ObjArr.Add(ObjApplicantQualification);

                }


            }

            ApplicantQualificationInfo ObjApplicantQualification2 = new ApplicantQualificationInfo();
            ObjApplicantQualification2.InstitutionName = this.txtQualifSchName.Text.Trim();
            ObjApplicantQualification2.QualificationType = this.qualifList.SelectedItem.Text;
            ObjApplicantQualification2.Course = this.courseList.SelectedItem.Text.Trim();

            ObjApplicantQualification2.Grade = this.gradeList.SelectedItem.Text;
            ObjApplicantQualification2.StartYear = this.qualifStartYearList.SelectedItem.Text;
            ObjApplicantQualification2.EndYear = this.qualifEndYearList.SelectedItem.Text;
            ObjApplicantQualification2.ApplicantID_FK = applicantID;
            // ObjApplicantQualification2.EmployeeID_FK = employeeID;
            ObjArr.Add(ObjApplicantQualification2);
            GViewQualif.DataSource = ObjArr;
            GViewQualif.DataBind();
            GViewQualif.Visible = true;
            txtQualifSchName.Text = "";
            courseList.ClearSelection();
            qualifList.ClearSelection();
            gradeList.ClearSelection();
            qualifStartYearList.ClearSelection();
            qualifEndYearList.ClearSelection();


        }


        private void refereshPage()
        {
            ddlAvailablePosition.ClearSelection();
            this.txtFName.Text = "";
            this.txtMName.Text = "";
            this.txtLName.Text = "";
            this.txtLName.Text = "";
            this.txtEmail.Text = "";
            this.txtContAddr.Text = "";
            this.txtAge.Text = "";
            rbtnGender.ClearSelection();
            ddlCountry.ClearSelection();
            ddlState.ClearSelection();
            ddlLga.ClearSelection();
            this.txtHometown.Text = "";


        }
        #endregion

        #endregion

        //Certification module]

        #region

        //Adding certifications

        #region
        protected void certAddBtn_Click(object sender, EventArgs e)
        {
            //int applicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);

            GViewCert.Visible = true;
            certSaveBtn.Visible = true;
            ArrayList ObjArr = new ArrayList();

            if (GViewCert.Rows.Count > 0)
            {
                for (int i = 0; i < GViewCert.Rows.Count; i++)
                {
                    ApplicantProfQualificationInfo objProfQualification2 = new ApplicantProfQualificationInfo();
                    objProfQualification2.CertificationName = GViewCert.Rows[i].Cells[0].Text.ToString();
                    objProfQualification2.CertificateNo = GViewCert.Rows[i].Cells[1].Text.ToString();
                    objProfQualification2.Stage = GViewCert.Rows[i].Cells[2].Text.ToString();
                    objProfQualification2.CertYear = GViewCert.Rows[i].Cells[3].Text.ToString();

                    objProfQualification2.ApplicantID_FK = Convert.ToInt32(GViewCert.Rows[i].Cells[4].Text);
                    //  objProfQualification2.employeeID_FK = Convert.ToInt32(GViewCert.Rows[i].Cells[5].Text);
                    ObjArr.Add(objProfQualification2);

                }


            }

            ApplicantProfQualificationInfo objProfQualification = new ApplicantProfQualificationInfo();
            objProfQualification.CertificationName = txtCertName.Text.Trim();
            objProfQualification.CertificateNo = txtCertNum.Text.Trim();
            objProfQualification.Stage = certStageList.SelectedItem.Text.Trim();
            objProfQualification.CertYear = ddlCertYear.SelectedItem.Text.Trim();

            objProfQualification.ApplicantID_FK = applicantID;
            //   objProfQualification.employeeID_FK = employeeID;
            ObjArr.Add(objProfQualification);
            GViewCert.DataSource = ObjArr;
            GViewCert.DataBind();
            GViewCert.Visible = true;
            txtCertName.Text = " ";
            certStageList.ClearSelection();
            txtCertNum.Text = " ";
            ddlCertYear.ClearSelection();

        }

        #endregion

        //Saving Certifications

        #region
        protected void certSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewCert.Rows)
                {
                    ApplicantProfQualificationInfo objProfQualificationInfo = new ApplicantProfQualificationInfo();

                    //objQualificationInfo.QualificationID= Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    objProfQualificationInfo.CertificationName = g1.Cells[0].Text;
                    objProfQualificationInfo.Stage = g1.Cells[1].Text;
                    objProfQualificationInfo.CertificateNo = g1.Cells[2].Text;
                    objProfQualificationInfo.CertYear = g1.Cells[3].Text;
                    objProfQualificationInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[4].Text);
                    //objProfQualificationInfo.employeeID_FK = Convert.ToInt32(g1.Cells[5].Text);
                    ObjArr.Add(objProfQualificationInfo);
                    int ProfqualiicationID = (new ApplicantProfQualificationController()).Add(objProfQualificationInfo);
                    if (ProfqualiicationID > 0)
                    {
                        //lblQualificationMessage.Visible = true;

                        lblprof.Text = "Professional Qualifications Added Successfully, Click next to enter your Working Experience";
                        PanelAppCertification.Visible = false;
                        lblprof1.Text = "Professional Qualifications Added Successfully, Click next to enter your Working Experience";
                        lblprof1.Visible = true;
                        certNextBtn1.Visible = true;
                        certTryAgainBtn.Visible = false;
                    }
                    else
                    {
                        lblprof.Text = "Error! Professional Qualifications  not Added ";
                        PanelAppCertification.Visible = false;
                        lblprof1.Text = "Error! Professional Qualifications  not Added";
                        lblprof1.Visible = true;
                        certNextBtn1.Visible = false;
                        certTryAgainBtn.Visible = true;
                    }
                }
            }
            catch { }
        }

        #endregion

        //Cert TryAgain

        #region
        protected void certTryAgainBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 3;
            PanelAppCertification.Visible = true;
            lblprof1.Visible = false;
            certNextBtn1.Visible = false;
            certTryAgainBtn.Visible = false;
        }
        #endregion


        //Deletion Certification

        #region

        protected void GViewCert_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                //ApplicantQualificationController objAPcon = new ApplicantQualificationController();
                //objAPcon.Delete(Convert.ToInt32(e.CommandArgument));

                new ApplicantProfQualificationController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];
                ArrayList ObjArrProfQualification = new ArrayList();
                ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrProfQualification.Count != 0)
                {

                    GViewCert.DataSource = (ObjArrProfQualification);
                    GViewCert.DataBind();

                }

            }
        }
        protected void GViewCert_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        #endregion



        #endregion
        
        //Working Experience Module

        #region

        //Adding Working Experience

        #region
        protected void workAddBtn_Click(object sender, EventArgs e)
        {
            //int applicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            GViewWorkExp.Visible = true;
            workSaveBtn.Visible = true;


            ArrayList objArr = new ArrayList();
            if (GViewWorkExp.Rows.Count > 0)
            {
                for (int i = 0; i < GViewWorkExp.Rows.Count; i++)
                {
                    ApplicantWorkExperienceInfo objworkExp = new ApplicantWorkExperienceInfo();
                    objworkExp.CompanyName = GViewWorkExp.Rows[i].Cells[0].Text.ToString();
                    objworkExp.PositionHeld = GViewWorkExp.Rows[i].Cells[1].Text.ToString();
                    objworkExp.JobDescriprtion = GViewWorkExp.Rows[i].Cells[2].Text.ToString();
                    objworkExp.SalaryReceived = GViewWorkExp.Rows[i].Cells[3].Text.ToString();
                    objworkExp.StartYear = GViewWorkExp.Rows[i].Cells[4].Text.ToString();
                    objworkExp.EndYear = GViewWorkExp.Rows[i].Cells[5].Text.ToString();
                    objworkExp.ApplicantID_FK = Convert.ToInt32(GViewWorkExp.Rows[i].Cells[6].Text);
                    objArr.Add(objworkExp);
                }
            }
            ApplicantWorkExperienceInfo objworkExp2 = new ApplicantWorkExperienceInfo();
            objworkExp2.CompanyName = txtCompanyName.Text.Trim();
            objworkExp2.PositionHeld = txtPositionHeld.Text.Trim();
            objworkExp2.JobDescriprtion = txtWorkJobDesc.Text.Trim();
            objworkExp2.SalaryReceived = txtWorkSalary.Text.Trim();
            objworkExp2.StartYear = this.ddlWorkStartDay.SelectedItem + "-" + this.ddlWorkStartMonth.SelectedItem + "-" + this.ddlWorkStartYear.SelectedItem;
            objworkExp2.EndYear = this.ddlWorkEndDay.SelectedItem + "-" + this.ddlWorkEndMonth.SelectedItem + "-" + this.ddlWorkEndYear.SelectedItem;
            objworkExp2.ApplicantID_FK = applicantID;
            objArr.Add(objworkExp2);
            GViewWorkExp.DataSource = objArr;
            GViewWorkExp.DataBind();
            GViewWorkExp.Visible = true;
            txtCompanyName.Text = "";
            txtPositionHeld.Text = "";
            txtWorkJobDesc.Text = "";
            txtWorkSalary.Text = "";
            ddlWorkStartDay.ClearSelection();
            ddlWorkStartMonth.ClearSelection();
            ddlWorkStartYear.ClearSelection();
            ddlWorkEndDay.ClearSelection();
            ddlWorkEndMonth.ClearSelection();
            ddlWorkEndYear.ClearSelection();

        }

        #endregion


        //Saving Working Exper

        #region
        protected void workSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewWorkExp.Rows)
                {
                    ApplicantWorkExperienceInfo objWorkExpInfo = new ApplicantWorkExperienceInfo();

                    //objQualificationInfo.QualificationID= Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    objWorkExpInfo.CompanyName = g1.Cells[0].Text;
                    objWorkExpInfo.PositionHeld = g1.Cells[1].Text;
                    objWorkExpInfo.JobDescriprtion = g1.Cells[2].Text;
                    objWorkExpInfo.SalaryReceived = g1.Cells[3].Text;
                    objWorkExpInfo.StartYear = g1.Cells[4].Text;
                    objWorkExpInfo.EndYear = g1.Cells[5].Text;
                    objWorkExpInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[6].Text);
                    ObjArr.Add(objWorkExpInfo);
                    int workExpID = (new ApplicantWorkExperienceController()).Add(objWorkExpInfo);
                    if (workExpID > 0)
                    {
                        //lblQualificationMessage.Visible = true;
                        lblworkExp.Text = "Working Experience added successfully, click next to upload document";
                        PanelAppWorkingExper.Visible = false;
                        lblworkExp1.Text = "Working Experience added successfully, click next to upload document";
                        lblworkExp1.Visible = true;
                        workTryAgain.Visible = false;
                        workNextBtn1.Visible = true;
                    }
                    else
                    {
                        lblworkExp.Text = "Error! Working Experience  not added";
                        PanelAppWorkingExper.Visible = false;
                        lblworkExp1.Text = "Working Experience added successfully, click next to upload document";
                        lblworkExp1.Visible = true;
                        workTryAgain.Visible = true;
                        workNextBtn1.Visible = false;
                    }
                }
            }
            catch { }
        }

        #endregion


        //Deleting Working Experience

        #region
        protected void GViewWorkExp_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Delete")
            {

                new ApplicantWorkExperienceController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];
                ArrayList ObjArrWrkExp = new ArrayList();
                ObjArrWrkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrWrkExp.Count != 0)
                {

                    GViewWorkExp.DataSource = (ObjArrWrkExp);
                    GViewWorkExp.DataBind();

                }

            }
        }
        protected void GViewWorkExp_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        #endregion

        //Work Try Again

        #region
        protected void workTryAgain_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 4;
            PanelAppWorkingExper.Visible = true;
            lblworkExp.Visible = false;
            lblworkExp1.Visible = false;
            workNextBtn1.Visible = false;
            workTryAgain.Visible = false;
        }
        #endregion

        #endregion


        //Document Module

        #region

        //Adding Documents

        #region

        protected void docAddBtn_Click(object sender, EventArgs e)
        {
            // int applicantID = Convert.ToInt32(Session["applicantnumber"]);
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            docSaveBtn.Visible = true;

            ArrayList objArr = new ArrayList();


            if (UploadDocument.HasFile)
            {



                string DocName = UploadDocument.FileName.ToString();
                string folder = "~/documents/";
                string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();
                UploadDocument.SaveAs(DocPath + "\\" + DocName);
                //UploadPassport.SaveAs(DocPath + "\\" + DocName);
                //lblPassportName.Text = DocName;
                //Session["DocPath"] = DocPath;
                //ViewState.Add("DocName", DocName);


                if (GViewDoc.Rows.Count > 0)
                {
                    for (int i = 0; i < GViewDoc.Rows.Count; i++)
                    {
                        ApplicantDocumentInfo objDoc2 = new ApplicantDocumentInfo();
                        objDoc2.DocumentType = GViewDoc.Rows[i].Cells[0].Text.ToString();
                        objDoc2.DocumentPath = GViewDoc.Rows[i].Cells[1].Text.ToString();
                        objDoc2.ApplicantID_FK = Convert.ToInt32(GViewDoc.Rows[i].Cells[2].Text);

                        objArr.Add(objDoc2);
                    }
                }
                ApplicantDocumentInfo objDoc = new ApplicantDocumentInfo();
                objDoc.DocumentType = ddlDocumentTpe.SelectedItem.Text;
                objDoc.DocumentPath = (DocPath + "\\" + DocName);
                objDoc.ApplicantID_FK = applicantID;
                //  objDoc.EmployeeID_Fk = employeeID;
                objArr.Add(objDoc);
                GViewDoc.DataSource = objArr;
                GViewDoc.DataBind();
                GViewDoc.Visible = true;
                ddlDocumentTpe.ClearSelection();
            }


        }


        #endregion

        //Uploading document

        #region
        protected void docUploadBtn_Click(object sender, EventArgs e)
        {
            if (UploadDocument.HasFile)
            {



                string DocName = UploadDocument.FileName.ToString();
                string folder = "~/document/";
                string DocPath = HttpContext.Current.Server.MapPath(folder).ToString();

                //lblPassportName.Text = DocName;
                Session["DocPath"] = DocPath;
                ViewState.Add("DocName", DocName);
            }
        }

        #endregion

        //Saving Documents

        #region
        protected void docSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList ObjArr = new ArrayList();
                foreach (GridViewRow g1 in GViewDoc.Rows)
                {
                    ApplicantDocumentInfo objDocInfo = new ApplicantDocumentInfo();


                    objDocInfo.DocumentType = g1.Cells[0].Text;
                    objDocInfo.DocumentPath = g1.Cells[1].Text;
                    objDocInfo.ApplicantID_FK = Convert.ToInt32(g1.Cells[2].Text);
                    //objDocInfo.EmployeeID_Fk = Convert.ToInt32(g1.Cells[3].Text);
                    ObjArr.Add(objDocInfo);
                    int DocID = (new ApplicantDocumentController()).Add(objDocInfo);
                    if (DocID > 0)
                    {
                        //lblQualificationMessage.Visible = true;
                        lblDoc.Text = "Document uploaded  successfully, click Summary to continue";
                        MViewApplicant.ActiveViewIndex = 5;
                        PanelAppDocument.Visible = false;
                        DocumentNextBtn1.Visible = true;
                        DocTryAgain.Visible = false;
                        lblDoc1.Text = "Document uploaded  successfully, click Summary to continue";
                        lblDoc1.Visible = true;

                    }
                    else
                    {
                        lblDoc.Text = "Error! Documents not uploaded";
                        PanelAppDocument.Visible = false;
                        DocumentNextBtn1.Visible = false;
                        DocTryAgain.Visible = true;
                        lblDoc1.Text = " Error! Documents not uploaded, click Try Again to retry";
                        lblDoc1.Visible = true;
                    }
                }
            }
            catch { }
        }

        #endregion


        //Deleting document

        #region
        protected void GViewDoc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {

                new ApplicantDocumentController().Delete(Convert.ToInt32(e.CommandArgument));
                int applicantID = (int)ViewState["applicantID"];
                ArrayList ObjArrDoc = new ArrayList();
                ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
                if (ObjArrDoc.Count != 0)
                {

                    GViewDoc.DataSource = (ObjArrDoc);
                    GViewDoc.DataBind();

                }

            }
        }
        protected void GViewDoc_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        #endregion


        //Doc try again

        #region
        protected void DocTryAgain_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 5;
            PanelAppDocument.Visible = true;
            DocumentNextBtn1.Visible = false;
            DocTryAgain.Visible = false;
            lblDoc1.Visible = false;
        }
        #endregion


        #endregion

        //Submit final application

        #region

        //Viewing Application Summary

        #region
        protected void DocumentNextBtn_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 6;
            int applicantID = Convert.ToInt32(ViewState["applicantID"]);
            ArrayList ObjArr = new ArrayList();


            ApplicantPersonalDetailsInfo objPersonalDetailInfo = new ApplicantPersonalDetailsInfo();
            objPersonalDetailInfo = (new ApplicantPersonalDetailsController()).Get(applicantID);

            CountryTableInfo objCountry = new CountryTableInfo();
            int countryID = objPersonalDetailInfo.Nationality_FK;
            objCountry = (new CountryTableController()).Get(countryID);

            StateTableInfo objState = new StateTableInfo();
            int stateID = objPersonalDetailInfo.StateOfOrigin_FK;
            objState = (new StateTableController()).Get(stateID);

            SenatorialTableInfo objSen = new SenatorialTableInfo();
            int sen = objPersonalDetailInfo.senID_FK;
            objSen = (new SenatorialTableController()).Get(sen);

            LGATableInfo objLga = new LGATableInfo();
            int lgaID = objPersonalDetailInfo.LGA_FK;
            objLga = (new LGATableController()).Get(lgaID);

            lblDeptAppliedTo.Text = objPersonalDetailInfo.DeptAppliedTo;
            lblDeptAppliedTo.Text = objPersonalDetailInfo.PositionAppliedFor;
            lbAppTitle.Text = objPersonalDetailInfo.Title;
            lbAppNum.Text = objPersonalDetailInfo.ApplicantNum;
            lblFirstName.Text = objPersonalDetailInfo.FirstName;
            lblLastName.Text = objPersonalDetailInfo.LastName;
            lblMiddleName.Text = objPersonalDetailInfo.MiiddleName;
            lblGender.Text = objPersonalDetailInfo.Gender;
            lblMaritalStatus.Text = objPersonalDetailInfo.MaritalStatus;
            lblDOB.Text = objPersonalDetailInfo.DateOfBirth;
            lblAge.Text = objPersonalDetailInfo.Age.ToString();
            lblNationality.Text = objCountry.CountryName;
            lblStateofOrigin.Text = objState.StateName;
            lblSenDist.Text = objSen.senName;
            lblReligion.Text = objPersonalDetailInfo.Religion;
            lblLGA.Text = objLga.LgaName;
            lblHomeTown.Text = objPersonalDetailInfo.HomeTown;
            lblEmail.Text = objPersonalDetailInfo.Email;
            lblPhoneNo.Text = objPersonalDetailInfo.PhoneNo;
            lblContactAddress.Text = objPersonalDetailInfo.ContactAddress;
            ImagePassport.ImageUrl = "~/images/" + objPersonalDetailInfo.Passport.Substring(objPersonalDetailInfo.Passport.LastIndexOf('\\') + 1);


            // Qualification summary
            ArrayList ObjArrQualification = new ArrayList();
            ObjArrQualification = (new ApplicantQualificationController()).GetByApplicantPersonalDetails(applicantID);
            foreach (var item in ObjArrQualification)
            {
                GViewQualifSummary.DataSource = (ObjArrQualification);
                GViewQualifSummary.DataBind();
                GViewQualifSummary.Visible = true;
            }

            //  professional Qualification summary
            ArrayList ObjArrProfQualification = new ArrayList();
            ObjArrProfQualification = (new ApplicantProfQualificationController()).GetByApplicantPersonalDetails(applicantID);
                 foreach (var item in ObjArrProfQualification)
            {
                GViewProfQualifSummary.DataSource = (ObjArrProfQualification);
                GViewProfQualifSummary.DataBind();
                GViewProfQualifSummary.Visible = true;
            }
            //  Wwork Experience summary
            ArrayList ObjArrWorkExp = new ArrayList();
            ObjArrWorkExp = (new ApplicantWorkExperienceController()).GetByApplicantPersonalDetails(applicantID);
            foreach (var item in ObjArrWorkExp)
            {
                GViewWorkExpSummary.DataSource = (ObjArrWorkExp);
                GViewWorkExpSummary.DataBind();
                GViewWorkExpSummary.Visible = true;
            }

            //  Document summary
            ArrayList ObjArrDoc = new ArrayList();
            ObjArrDoc = (new ApplicantDocumentController()).GetByApplicantPersonalDetails(applicantID);
            foreach (var item in ObjArrDoc)
            {
                GViewDocSummary.DataSource = (ObjArrDoc);
                GViewDocSummary.DataBind();
                GViewDocSummary.Visible = true;
            }
        }

        #endregion

        protected void submitAppBtn_Click(object sender, EventArgs e)
        {
            Utility.Alert("You save successfully applied for the post of " + lblDeptAppliedTo.Text + " your application number is: " + lbAppNum.Text);
            MViewApplicant.ActiveViewIndex = 8;
            lblFinalSumit.Text = "Thank you! Here is you application details:" + "Positio applied for:" + lblDeptAppliedTo.Text + " Application number: " + lbAppNum.Text;
            lblFinalSumit.Visible = true;

        }

        protected void btnFinalSubmit_Click(object sender, EventArgs e)
        {
            MViewApplicant.ActiveViewIndex = 0;
        }

        #endregion

        #endregion


     
}
}