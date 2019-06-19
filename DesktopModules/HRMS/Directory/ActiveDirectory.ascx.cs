using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.SessionState;
using System.IO;
using System.Text.RegularExpressions;

using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;

using Dokun.neetbeet;


public partial class DesktopModules_HRMS_ActiveDirectory : PortalModuleBase, IActionable
{

    string filepath2;

    public ModuleActionCollection ModuleActions
    {
        get
        {
            ModuleActionCollection Actions = new ModuleActionCollection();
            Actions.Add(this.GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile), ModuleActionType.AddContent, "", "", this.EditUrl(), false, SecurityAccessLevel.Edit, true, false);
            return Actions;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                panelActiveDirectory.Visible = false;
                bttnAddPersonnel.Visible = true;

                loadEmployees();
                ArrayList objDepts = new ArrayList();
                objDepts = (new DepartmentTableController()).List();
                if (objDepts.Count > 0)
                {

                    ddlEmpDept.DataSource = objDepts;
                    ddlEmpDept.DataTextField = "DeptName";
                    ddlEmpDept.DataValueField = "DeptID";
                    ddlEmpDept.DataBind();

                }

                DepEmpCode.Text = "";
                SpecialImageName.Text = "";
            }
        }
        catch (Exception ex)
        {

        }

    }

    protected void bttnEdit_Click(object sender, EventArgs e)
    {
        bttnAddPersonnel.Visible = true;
        btnSave.Visible = true;

        panelActiveDirectory.Visible = true;
        ddlStatus.Enabled = true;
        ddlEmpDept.Enabled = true;
        txtJobTitle.Enabled = true;
        ddlTitle.Enabled = true;
        txtFName.Enabled = true;
        txtMName.Enabled = true;
        txtLName.Enabled = true;
        txtEmail.Enabled = true;
        txtPhnExt.Enabled = true;
        txtmobNum.Enabled = true;
        txtOfficeRoom.Enabled = true;
        rbtnEmpType.Enabled = true;
        txtUserName.Enabled = true;
        UploadPassport.Enabled = true;

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            // TODO: create a function to get userid from username in later versions of this app

            //validate record
            if (SpecialImageName.Text == "")
            {
                return;
            }

            //check if record is new record or updating record

            if (DepEmpCode.Text == "")
            {
                //new entry

                try
                {
                    DepartmentEmployeesInfo doi = new DepartmentEmployeesInfo(Convert.ToInt32(ddlStatus.SelectedValue), Convert.ToInt32(ddlEmpDept.SelectedValue), txtJobTitle.Text, ddlTitle.SelectedValue, txtFName.Text, txtMName.Text, txtLName.Text, txtEmail.Text, txtPhnExt.Text, txtmobNum.Text, txtOfficeRoom.Text, rbtnEmpType.SelectedValue, SpecialImageName.Text, txtUserName.Text);
                    int ret = new DepartmentEmployeesController().Add(doi);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                //updating an old entry
                DepartmentEmployeesInfo doi = new DepartmentEmployeesInfo(Convert.ToInt32(DepEmpCode.Text), Convert.ToInt32(ddlStatus.SelectedValue), Convert.ToInt32(ddlEmpDept.SelectedValue), txtJobTitle.Text, ddlTitle.SelectedValue, txtFName.Text, txtMName.Text, txtLName.Text, txtEmail.Text, txtPhnExt.Text, txtmobNum.Text, txtOfficeRoom.Text, rbtnEmpType.SelectedValue, SpecialImageName.Text, txtUserName.Text);
                (new DepartmentEmployeesController()).Update(doi);

            }

            //clean up
            //reload listbox
            tvEmployeeList.Nodes.Clear();
            clearSelection();
            loadEmployees();
            panelActiveDirectory.Visible = false;
            bttnAddPersonnel.Visible = true;
            btnSave.Visible = false;

        }
        catch (Exception ex)
        {
        }
    }

    protected void passportUploadBtn0_Click1(object sender, EventArgs e)
    {
        try
        {
            ////generate unique name from a combination of
            //String specialName = ddlEmpDept.SelectedValue + txtJobTitle.Text + txtFName.Text + txtMName.Text + txtLName.Text + txtmobNum.Text;
            //if (UploadPassport.HasFile)
            //{
            //    string filename = UploadPassport.FileName.ToString();
            //    string fileExtension = filename.Substring(filename.LastIndexOf("."));
            //    string fileName = Path.GetFileName(UploadPassport.PostedFile.FileName);
            //    string fpath = Server.MapPath("/images/ActiveDirectoryPassports/" + specialName + fileExtension);
            //    SpecialImageName.Text = fpath;
            //    UploadPassport.SaveAs(fpath);
            //    imgPassport.ImageUrl = fpath;

            //}


            string folderPath = Server.MapPath("~/Files/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            UploadPassport.SaveAs(folderPath + Path.GetFileName(UploadPassport.FileName));
            //Display the Picture in Image control.
            imgPassport.ImageUrl = "~/Files/" + Path.GetFileName(UploadPassport.FileName);
            SpecialImageName.Text = imgPassport.ImageUrl;
        }
        catch (Exception ex)
        {
        }
    }


    private void loadEmployee(String DeptEmpCode)
    {

        try
        {

            DepartmentEmployeesInfo doi = (new DepartmentEmployeesController()).Get(Convert.ToInt32(DeptEmpCode));

            ddlStatus.SelectedValue = Convert.ToString(doi.EmpStatus);
            ddlEmpDept.SelectedValue = Convert.ToString(doi.DeptId);
            txtJobTitle.Text = doi.JobTitle;
            ddlTitle.SelectedValue = doi.Ptitle;
            txtFName.Text = hrPublicFunction.formatName(doi.Fname);
            txtMName.Text = hrPublicFunction.formatName(doi.Middlename);
            txtLName.Text = hrPublicFunction.formatName(doi.Lastname);
            txtEmail.Text = doi.Email;
            txtPhnExt.Text = doi.PhoneExt;
            txtmobNum.Text = doi.MobileNo;
            txtOfficeRoom.Text = doi.OfficeRoom;
            rbtnEmpType.SelectedValue = doi.EmpType;
            imgPassport.ImageUrl = doi.Passport;
            SpecialImageName.Text = doi.Passport;
            txtUserName.Text = doi.UserId;


        }
        catch (Exception ex)
        {

        }

    }

    private void loadEmployees()
    {
        try
        {
            ArrayList objDeptEmp = new ArrayList();
            objDeptEmp = (new DepartmentEmployeesController()).List();

     
            tvEmployeeList .Nodes.Clear();
            TreeNode compnode = new TreeNode(System.Configuration.ConfigurationManager.AppSettings.Get("CompanyName"));
            compnode.Value = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyCode");
            tvEmployeeList.Nodes.Add(compnode);

            if (objDeptEmp.Count > 0)
            {

                int x = 0;
                while (x < objDeptEmp.Count)
                {
                    DepartmentEmployeesInfo di = (DepartmentEmployeesInfo)objDeptEmp[x];
                    TreeNode t = new TreeNode();
                    t.Text = hrPublicFunction.formatName(di.Lastname) + " " + hrPublicFunction.formatName(di.Fname) + " " + hrPublicFunction.formatName(di.Middlename);
                    t.Value = di.DeptEmpCode.ToString();
                    compnode.ChildNodes.Add(t);

                    x = x + 1;
                }

            }


        }
        catch (Exception ex)
        {

        }

    }


    private void clearSelection()
    {

        ddlStatus.SelectedIndex = -1;
        ddlStatus.Enabled = false;
        ddlEmpDept.SelectedIndex = -1;
        ddlEmpDept.Enabled = false;
        txtJobTitle.Text = "";
        txtJobTitle.Enabled = false;
        ddlTitle.SelectedIndex = -1;
        ddlTitle.Enabled = false;
        txtFName.Text = "";
        txtFName.Enabled = false;
        txtMName.Text = "";
        txtMName.Enabled = false;
        txtLName.Text = "";
        txtLName.Enabled = false;
        txtEmail.Text = "";
        txtEmail.Enabled = false;
        txtPhnExt.Text = "";
        txtPhnExt.Enabled = false;
        txtmobNum.Text = "";
        txtmobNum.Enabled = false;
        txtOfficeRoom.Text = "";
        txtOfficeRoom.Enabled = false;
        rbtnEmpType.SelectedIndex = -1;
        rbtnEmpType.Enabled = false;
        imgPassport.ImageUrl = "";
        UploadPassport.Enabled = false;
        SpecialImageName.Text = "";
        DepEmpCode.Text = "";
        txtUserName.Text = "";
        txtUserName.Enabled = false;
    }

    protected void bttnAddPersonnel_Click(object sender, EventArgs e)
    {
        bttnAddPersonnel.Visible = false;
        btnSave.Visible = true;

        panelActiveDirectory.Visible = true;
        clearSelection();
        ddlStatus.Enabled = true;
        ddlEmpDept.Enabled = true;
        txtJobTitle.Enabled = true;
        ddlTitle.Enabled = true;
        txtFName.Enabled = true;
        txtMName.Enabled = true;
        txtLName.Enabled = true;
        txtEmail.Enabled = true;
        txtPhnExt.Enabled = true;
        txtmobNum.Enabled = true;
        txtOfficeRoom.Enabled = true;
        rbtnEmpType.Enabled = true;
        UploadPassport.Enabled = true;
        txtUserName.Enabled = true;
    }


    protected void bttnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/HR.aspx");

    }



    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        clearSelection();
        if (tvEmployeeList.Nodes.Count < 1)
        {
            return;
        }
        DepEmpCode.Text = tvEmployeeList.SelectedValue;
        loadEmployee(DepEmpCode.Text);
        panelActiveDirectory.Visible = true;
        bttnEdit.Visible = true;
        bttnAddPersonnel.Visible = true;
        btnSave.Visible = false;
    }
}