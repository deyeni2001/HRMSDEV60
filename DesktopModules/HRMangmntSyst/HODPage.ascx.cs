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
    public partial class HODPage : PortalModuleBase, IActionable
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
                MViewHOD.ActiveViewIndex = 0;



                // Loading Department
                #region
                ArrayList objEmpDept = new ArrayList();
                objEmpDept = (new EmployeeDepartmentTableController()).List();

                if (objEmpDept.Count > 0)
                {

                    trainingDeptList.DataSource = objEmpDept;
                    trainingDeptList.DataTextField = "DeptName";
                    trainingDeptList.DataValueField = "DeptID";
                    trainingDeptList.DataBind();

                }
                trainingDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                //   TrainingPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));
                TrainingEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                ArrayList objEmpDept2 = new ArrayList();
                objEmpDept2 = (new EmployeeDepartmentTableController()).List();


                if (objEmpDept2.Count > 0)
                {
                    assignSupDeptList.DataSource = objEmpDept2;
                    assignSupDeptList.DataTextField = "DeptName";
                    assignSupDeptList.DataValueField = "DeptID";
                    assignSupDeptList.DataBind();

                }
                assignSupDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));


                #endregion

                ArrayList objEmpWorkLocation = new ArrayList();
                objEmpWorkLocation = (new EmployeeWorkLocationsController()).List();

                if (objEmpWorkLocation.Count > 0)
                {
                    assignSupLocationList.DataSource = objEmpWorkLocation;
                    assignSupLocationList.DataTextField = "LocationName";
                    assignSupLocationList.DataValueField = "WorkLocationID";
                    assignSupLocationList.DataBind();
                }
                assignSupLocationList.Items.Insert(0, new ListItem("***Please select***", "-1"));


            }

          
            //Loading Years and Days

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

                trainingStartDayList.DataSource = days;
                trainingStartDayList.DataBind();

                trainingEndDayList.DataSource = days;
                trainingEndDayList.DataBind();
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

                trainingStartYearList.DataSource = yrs;
                trainingStartYearList.DataBind();

                trainingEndYearList.DataSource = yrs;
                trainingEndYearList.DataBind();
            }

            #endregion


        }

        protected void hodTrainBtn_Click(object sender, EventArgs e)
        {
            MViewHOD.ActiveViewIndex = 1;
        }
        protected void trainingHomeBtn_Click(object sender, EventArgs e)
        {
            MViewHOD.ActiveViewIndex = 0;

        }
        protected void hodAssignSupervisor_Click(object sender, EventArgs e)
        {

            MViewHOD.ActiveViewIndex = 2;

        }
        protected void welHometBtn_Click(object sender, EventArgs e)
        {
            MViewHOD.ActiveViewIndex = 0;


        }
        protected void trainingDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   GViewTrainingEmpList.Visible = true;
        }
        protected void trainingDeptList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ArrayList objEmpNum = new ArrayList();
            int DeptID = Convert.ToInt32(trainingDeptList.SelectedValue);
            objEmpNum = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(DeptID);

            if (objEmpNum.Count > 0)
            {
                TrainingEmployeeList.DataSource = objEmpNum;
                TrainingEmployeeList.DataTextField = "EmployeeNum";
                TrainingEmployeeList.DataValueField = "EmployeeID";
                TrainingEmployeeList.DataBind();
                TrainingEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));
            }


            //UserInfo objTrainingUser = new UserInfo();
            //objTrainingUser = (new UserController()).GetUser(0, UserId);

            //EmployeeDetailsInfo objEmpTraining = new EmployeeDetailsInfo();
            //int empTrainingID = Convert.ToInt32(TrainingEmployeeList.SelectedValue);
            //objEmpTraining = (new EmployeeDetailsController()).Get(empTrainingID);

            // EmployeePositionTableInfo objEmpTrainingPosition = new EmployeePositionTableInfo();
            //int empTrainingPositionID = objEmpTraining.PositionHeld_FK;
            //objEmpTrainingPosition = (new EmployeePositionTableController()).Get(empTrainingPositionID);


            //LbTrainingEmpPosition.Text = objEmpTrainingPosition.PositionName;
            //LbTrainingEmpPosition.Visible = true;
            //LbTrainingSentBy.Text = objTrainingUser.DisplayName;
            //LbTrainingSentBy.Visible = true;


            //   ArrayList objEmpPosition = new ArrayList(); 
            //int DeptID = Convert.ToInt32(trainingDeptList.SelectedValue);
        }

        protected void TrainingEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {


            UserInfo objTrainingUser = new UserInfo();
            objTrainingUser = (new UserController()).GetUser(0, UserId);

            EmployeeDetailsInfo objEmpTraining = new EmployeeDetailsInfo();
            int empTrainingID = Convert.ToInt32(TrainingEmployeeList.SelectedValue);
            objEmpTraining = (new EmployeeDetailsController()).Get(empTrainingID);

            EmployeePositionTableInfo objEmpTrainingPosition = new EmployeePositionTableInfo();
            int empTrainingPositionID = objEmpTraining.PositionHeld_FK;
            objEmpTrainingPosition = (new EmployeePositionTableController()).Get(empTrainingPositionID);


            LbTrainingEmpPosition.Text = objEmpTrainingPosition.PositionName;
            LbTrainingEmpPosition.Visible = true;
            LbTrainingSentBy.Text = objTrainingUser.DisplayName;
            LbTrainingSentBy.Visible = true;

            //EmployeeDetailsInfo objEmpInfo = new EmployeeDetailsInfo();
            //int emp = Convert.ToInt32(TrainingEmployeeList.SelectedValue);
            // objEmpInfo = (new EmployeeDetailsController()).Get(emp);
            // int empPos = objEmpInfo.PositionHeld_FK;

            //EmployeePositionTableInfo objPositionInfo = new EmployeePositionTableInfo();
            //int empPosition = empPos;
            //objPositionInfo = (new EmployeePositionTableController()).Get(empPosition);

            //objEmpInfo.EmployeeID = emp;
            //objEmpInfo.PositionHeld_FK = empPos;

            //LbTrainingEmpPosition.Text = objPositionInfo.PositionName;
            //LbTrainingEmpPosition.Visible = true;

            //LbTrainingEmpPosition0.Text = objEmpInfo.PositionName;
            //LbTrainingEmpPosition0.Visible = true;
        }
        protected void trainingSendBtn_Click(object sender, EventArgs e)
        {
            try
            {


                UserInfo objTrainingUser = new UserInfo();
                objTrainingUser = (new UserController()).GetUser(0, UserId);

                EmployeeDetailsInfo objEmpTraining = new EmployeeDetailsInfo();
                int empTrainingID = Convert.ToInt32(TrainingEmployeeList.SelectedValue);
                objEmpTraining = (new EmployeeDetailsController()).Get(empTrainingID);

                EmployeePositionTableInfo objEmpTrainingPosition = new EmployeePositionTableInfo();
                int empTrainingPositionID = objEmpTraining.PositionHeld_FK;
                objEmpTrainingPosition = (new EmployeePositionTableController()).Get(empTrainingPositionID);


                //EmployeeDetailsInfo objEmpInfo = new EmployeeDetailsInfo();
                //int emp = Convert.ToInt32(TrainingEmployeeList.SelectedValue);
                //objEmpInfo = (new EmployeeDetailsController()).Get(emp);
                //int empPos = objEmpInfo.PositionHeld_FK;


                //EmployeePositionTableInfo objPositionInfo = new EmployeePositionTableInfo();
                //int empPosition = empPos;
                //objPositionInfo = (new EmployeePositionTableController()).Get(empPosition);


                EmployeeTrainingTableInfo objTrainingInfo = new EmployeeTrainingTableInfo();
                int empID = Convert.ToInt32(TrainingEmployeeList.SelectedValue);

                objTrainingInfo.EmployeeID_FK = empTrainingID;
                objTrainingInfo.DepartmentID_FK = Convert.ToInt32(this.trainingDeptList.SelectedValue);
                objTrainingInfo.PositionID_FK = empTrainingPositionID;
                objTrainingInfo.TrainingName = this.trainingNameList.SelectedItem.Text.Trim();
                objTrainingInfo.TrainingLocation = this.txtTrainingLocation.Text.Trim();
                objTrainingInfo.StartDate = this.trainingStartDayList.SelectedItem.Text.Trim() + "-" + trainingStartMonthList.SelectedItem.Text.Trim() + "-" + trainingStartYearList.SelectedItem.Text.Trim();
                objTrainingInfo.EndDate = this.trainingEndDayList.SelectedItem.Text.Trim() + "-" + trainingEndMonthList.SelectedItem.Text.Trim() + "-" + trainingEndYearList.SelectedItem.Text.Trim();
                objTrainingInfo.TrainingSentBy = objTrainingUser.UserID;
                    //this.LbTrainingSentBy.Text.Trim();

                int TrainingID = (new EmployeeTrainingTableController()).Add(objTrainingInfo);

                if (TrainingID > 0)
                {
                    LbTrainingRequestSentBy.Visible = true;
                    LbTrainingRequestSentBy.Text = "Training request successfully sent, you can now wait for HR Approval";
                }

                else
                {
                    LbTrainingRequestSentBy.Visible = true;
                    LbTrainingRequestSentBy.Text = "Training request NOT successfully sent, Please Re-Try";
                }
            }

            catch { }
        }


        //Assigning HOD of Deparment

        #region

        protected void assignSupDeptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ArrayList objDeptPost = new ArrayList();
            //int dept = Convert.ToInt32(assignSupDeptList.SelectedValue);
            //objDeptPost = (new EmployeePositionTableController()).GetByEmployeeDepartmentTable(dept);
            //if (objDeptPost.Count > 0)
            //{
            //    assignSupPositionList.DataSource = objDeptPost;
            //    assignSupPositionList.DataTextField = "PositionName";
            //    assignSupPositionList.DataValueField = "PositionID";
            //    assignSupPositionList.DataBind();
            //    assignSupPositionList.Visible = true;


            //    assignSupPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));

            //}



            ArrayList objHodEmp = new ArrayList();
            int dept = Convert.ToInt32(assignSupDeptList.SelectedValue);
            int work = Convert.ToInt32(assignSupLocationList.SelectedValue);
            objHodEmp = (new EmployeeDetailsController()).ListByDeptAndLocation(dept, work);

            ViewState.Add("dept", dept);
            ViewState.Add("work", work);

            if (objHodEmp.Count > 0)
            {
                assignSupEmpList.DataSource = objHodEmp;
                assignSupEmpList.DataTextField = "EmployeeNum";
                assignSupEmpList.DataValueField = "EmployeeID";
                assignSupEmpList.DataBind();
                assignSupEmpList.Visible = true;

                assignSupEmpList.Items.Insert(0, new ListItem("***Please select***", "-1"));

            }

        }

        protected void assignSupEmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int empID = Convert.ToInt32(ViewState["empID"]);

            int work = Convert.ToInt32(ViewState["work"]);
            int dept = Convert.ToInt32(ViewState["dept"]);

            ArrayList objAssing = new ArrayList();

            objAssing = (new EmployeeDetailsController()).GetByEmpDeptAndLocation(dept, work);

            if (objAssing.Count > 0)
            {
                GViewAssignSupervisor.DataSource = objAssing;
                GViewAssignSupervisor.DataBind();
                GViewAssignSupervisor.Visible = true;
            }

        }

        protected void assignSupBtn_Click(object sender, EventArgs e)
        {

        
            int work = Convert.ToInt32(ViewState["work"]);
            int dept = Convert.ToInt32(ViewState["dept"]);



            foreach (GridViewRow x in GViewAssignSupervisor.Rows)
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
                        EmployeeDetailsInfo objSupAssign = new EmployeeDetailsInfo();
                        objSupAssign.EmployeeID = Convert.ToInt32(empid);
                        objSupAssign.SupervisorID = Convert.ToInt32(assignSupEmpList.SelectedValue);

                        (new EmployeeDetailsController()).UpdateEmpSupervisor(objSupAssign);

                        EmployeeDetailsInfo objGetEmp1 = new EmployeeDetailsInfo();
                        objGetEmp1 = (new EmployeeDetailsController()).Get(Convert.ToInt32(empid));

                        if (objGetEmp1.SupervisorID == Convert.ToInt32(assignSupEmpList.SelectedValue))
                        {
                            LbHODUpdateSuccessful1.Text = "Emp Supervisor Updated Successfull";
                            LbHODUpdateSuccessful1.Visible = true;

                        }

                        else
                        {
                            LbHODUpdateSuccessful1.Text = "Emp Supervisor Not Updated  Successfull";
                            LbHODUpdateSuccessful1.Visible = true;
                        }
                    }

                    catch
                    {

                    }
                }
            }

            // Update Employee HOD New Position with HOD positionID

            //int HODNEwPost = Convert.ToInt32(assignHODPositionList.SelectedValue);
            //int Hod = Convert.ToInt32(assignHODEmpList.SelectedValue);

            //EmployeeDetailsInfo objHODNewPostion = new EmployeeDetailsInfo();
            //objHODNewPostion.EmployeeID = Convert.ToInt32(assignHODEmpList.SelectedValue);
            //objHODNewPostion.PositionHeld_FK = HODNEwPost;
            //objHODNewPostion.HODID = Hod;
            //(new EmployeeDetailsController()).UpdateHODNewPositionAsHOD(objHODNewPostion);

            //EmployeeDetailsInfo objGetEmp = new EmployeeDetailsInfo();
            //objGetEmp = (new EmployeeDetailsController()).Get(Convert.ToInt32(assignSupEmpList.SelectedValue));

            //if (objGetEmp.PositionHeld_FK == HODNEwPost)
            //{
            //    LbHODUpdateSuccessful.Text = "HOD Position Successfull Modified";
            //    LbHODUpdateSuccessful.Visible = true;

            //}

            //else
            //{
            //    LbHODUpdateSuccessful.Text = "HOD Position Successfull Modified";
            //    LbHODUpdateSuccessful.Visible = true;
            //}
        }


        #endregion










        protected void TrainingFinishBtn_Click(object sender, EventArgs e)
        {

        }

        protected void MViewHOD_ActiveViewChanged(object sender, EventArgs e)
        {

        }
    }
}




//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Reflection;
//using System.Web.UI.WebControls;

//using DotNetNuke;
//using DotNetNuke.Common.Utilities;
//using DotNetNuke.Entities.Modules;
//using DotNetNuke.Entities.Modules.Actions;
//using DotNetNuke.Security;
//using DotNetNuke.Services.Exceptions;
//using DotNetNuke.Services.Localization;
//using System.Web.SessionState;
//using System.IO;
//using ola.HRMangmntSyst;

//namespace ola.HRMangmntSyst
//{
//    public partial class HODPage : PortalModuleBase, IActionable
//    {


//        #region Optional Interfaces
//        public ModuleActionCollection ModuleActions
//        {
//            get
//            {
//                ModuleActionCollection Actions = new ModuleActionCollection();
//                Actions.Add(this.GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile), ModuleActionType.AddContent, "", "", this.EditUrl(), false, SecurityAccessLevel.Edit, true, false);
//                return Actions;
//            }

//        }
//        #endregion
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                MViewHOD.ActiveViewIndex = 0;



//                // Loading Department
//                #region
//                ArrayList objEmpDept = new ArrayList();
//                objEmpDept = (new EmployeeDepartmentTableController()).List();

//                if (objEmpDept.Count > 0)
//                {

//                    trainingDeptList.DataSource = objEmpDept;
//                    trainingDeptList.DataTextField = "DeptName";
//                    trainingDeptList.DataValueField = "DeptID";
//                    trainingDeptList.DataBind();

//                }
//                trainingDeptList.Items.Insert(0, new ListItem("***Please select***", "-1"));
//                //   TrainingPositionList.Items.Insert(0, new ListItem("***Please select***", "-1"));
//                TrainingEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));
//            }
//                #endregion


//            //Loading Years and Days

//            #region

//            if (IsPostBack) return;
//            else
//            {
//                var days = new ArrayList();
//                days.Add("*Day*");
//                for (var i = 1; i <= 31; i++)
//                {
//                    days.Add(i);
//                }

//                trainingStartDayList.DataSource = days;
//                trainingStartDayList.DataBind();

//                trainingEndDayList.DataSource = days;
//                trainingEndDayList.DataBind();
//            }

//            if (IsPostBack) return;
//            else
//            {
//                var yrs = new ArrayList();
//                yrs.Add("*Year*");
//                for (var i = 2018; i >= 1900; i--)
//                {
//                    yrs.Add(i);
//                }

//                trainingStartYearList.DataSource = yrs;
//                trainingStartYearList.DataBind();

//                trainingEndYearList.DataSource = yrs;
//                trainingEndYearList.DataBind();
//            }

//            #endregion


//        }

//        protected void hodTrainBtn_Click(object sender, EventArgs e)
//        {
//            MViewHOD.ActiveViewIndex = 1;
//        }
//        protected void trainingHomeBtn_Click(object sender, EventArgs e)
//        {
//            MViewHOD.ActiveViewIndex = 0;

//        }

//        protected void trainingDeptList_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            //   GViewTrainingEmpList.Visible = true;
//        }
//        protected void trainingDeptList_SelectedIndexChanged1(object sender, EventArgs e)
//        {
//            ArrayList objEmpPosition = new ArrayList();
//            int DeptID = Convert.ToInt32(trainingDeptList.SelectedValue);

//            ArrayList objEmpNum = new ArrayList();
//            objEmpNum = (new EmployeeDetailsController()).GetByEmployeeDepartmentTable(DeptID);

//            if (objEmpNum.Count > 0)
//            {
//                TrainingEmployeeList.DataSource = objEmpNum;
//                TrainingEmployeeList.DataTextField = "EmployeeNum";
//                TrainingEmployeeList.DataValueField = "EmployeeID";
//                TrainingEmployeeList.DataBind();
//                TrainingEmployeeList.Items.Insert(0, new ListItem("***Please select***", "-1"));
//            }
//        }

//        protected void TrainingEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            EmployeeDetailsInfo objEmpInfo = new EmployeeDetailsInfo();
//            int emp = Convert.ToInt32(TrainingEmployeeList.SelectedValue);
//            objEmpInfo = (new EmployeeDetailsController()).Get(emp);
//            int empPos = objEmpInfo.PositionHeld_FK;

//            EmployeePositionTableInfo objPositionInfo = new EmployeePositionTableInfo();
//            int empPosition = empPos;
//            objPositionInfo = (new EmployeePositionTableController()).Get(empPosition);

//            objEmpInfo.EmployeeID = emp;
//            objEmpInfo.PositionHeld_FK = empPos;

//            LbTrainingEmpPosition.Text = objPositionInfo.PositionName;
//            LbTrainingEmpPosition.Visible = true;

//            LbTrainingEmpPosition0.Text = objEmpInfo.PositionName;
//            LbTrainingEmpPosition0.Visible = true;
//        }
//        protected void trainingSendBtn_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                EmployeeDetailsInfo objEmpInfo = new EmployeeDetailsInfo();
//                int emp = Convert.ToInt32(TrainingEmployeeList.SelectedValue);
//                objEmpInfo = (new EmployeeDetailsController()).Get(emp);
//                int empPos = objEmpInfo.PositionHeld_FK;


//                EmployeePositionTableInfo objPositionInfo = new EmployeePositionTableInfo();
//                int empPosition = empPos;
//                objPositionInfo = (new EmployeePositionTableController()).Get(empPosition);


//                EmployeeTrainingTableInfo objTrainingInfo = new EmployeeTrainingTableInfo();
//                int empID = Convert.ToInt32(TrainingEmployeeList.SelectedValue);

//                objTrainingInfo.EmployeeID_FK = empID;
//                objTrainingInfo.DepartmentID_FK = Convert.ToInt32(this.trainingDeptList.SelectedValue);
//                objTrainingInfo.PositionID_FK = empPos;
//                objTrainingInfo.TrainingName = this.trainingNameList.SelectedItem.Text.Trim();
//                objTrainingInfo.TrainingLocation = this.txtTrainingLocation.Text.Trim();
//                objTrainingInfo.StartDate = this.trainingStartDayList.SelectedItem.Text.Trim() + "-" + trainingStartMonthList.SelectedItem.Text.Trim() + "-" + trainingStartYearList.SelectedItem.Text.Trim();
//               // objTrainingInfo.TrainingSentBy = this.LbTrainingSentBy.Text.Trim();

//                int TrainingID = (new EmployeeTrainingTableController()).Add(objTrainingInfo);

//                if (TrainingID > 0)
//                {
//                    LbTrainingRequestSentBy.Visible = true;
//                    LbTrainingRequestSentBy.Text = "Training request successfully sent, you can now wait for HR Approval";
//                }

//                else
//                {
//                    LbTrainingRequestSentBy.Visible = true;
//                    LbTrainingRequestSentBy.Text = "Training request NOT successfully sent, Please Re-Try";
//                }
//            }

//            catch { }
//        }

//    }
//}