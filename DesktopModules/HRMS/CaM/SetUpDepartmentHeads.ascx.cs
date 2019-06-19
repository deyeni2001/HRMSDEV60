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
using Dokun.neetbeet;



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


public partial class DesktopModules_HRMS_SetUpDepartmentHeads :  PortalModuleBase, IActionable
{

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
                PanelRight .Visible = false;
                bttnNew.Visible = true;


                ddlDepartment.Items.Add(new ListItem("--- Select Department ----", "0"));
                ArrayList objDepts = new ArrayList();
                objDepts = (new DepartmentTableController()).List();

                if (objDepts.Count > 0)
                {

                    ddlDepartment.DataSource = objDepts;
                    ddlDepartment.DataTextField = "DeptName";
                    ddlDepartment.DataValueField = "DeptID";
                    ddlDepartment.DataBind();

                }
                // day dropdownlists
                ddlsDay.Items.Add(new ListItem("Day", "0"));
                ddleDay.Items.Add(new ListItem("Day", "0"));

                for (var i = 1; i <= 31; i++)
                {
                    ddlsDay.Items.Add(new ListItem(i.ToString() , i.ToString()));
                    ddleDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                // year dropdownlists
                for (var i = (DateTime.Now.Year + 10); i >= 1920; i--)
                {
                    ddlsYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
                    ddleYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                ddlDepartment_SelectedIndexChanged(this, new EventArgs());

            }
        }
        catch (Exception ex)
        {

        }
    }


    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {
            bttnCancel_Click(this, new EventArgs());
            ddlEmp.Items.Clear();
            lbHeads.Items.Clear();
            lblRecId.Text = "";
            // load all the historical heads for that department
            loadHeads(Convert.ToInt32(ddlDepartment.SelectedValue));


            ////load supervising department employees
            // loadEmployeesbyDept(getSupervisingDept(Convert.ToInt32(ddlDepartment.SelectedValue)));
            //// load all employees in that department to combo box


            // loadEmployeesbyDept(Convert.ToInt32(ddlDepartment.SelectedValue));
            //txtDeptName.Text = ddlDepartment.SelectedItem.Text;


            if (lbHeads.Items.Count < 1)
            {
                PanelRight.Visible = false;
                bttnEdit.Visible = false;
            }
            else
            {
                lbHeads.SelectedIndex = 0;
                lbHeads_SelectedIndexChanged(this, new EventArgs());
            }



        }
        catch (Exception ex)
        {
        }
    }

    private int getSupervisingDept(int DeptId)
    {

        DepartmentTableInfo obj = (new DepartmentTableController()).Get(DeptId);
        return obj.SuperDept;

    }


    private void loadEmployeesbyDept(int DeptId)
    {
        ArrayList objDeptEmp = new ArrayList();
        objDeptEmp = (new DepartmentEmployeesController()).List();

        if (objDeptEmp.Count > 0)
        {
            int x = 0;
            while (x < objDeptEmp.Count)
            {
                DepartmentEmployeesInfo di = (DepartmentEmployeesInfo)objDeptEmp[x];
                if (di.DeptId == DeptId)
                {
                    ddlEmp.Items.Add(new ListItem(di.Ptitle  + " "  + hrPublicFunction.formatName(di.Lastname) + " " + hrPublicFunction.formatName(di.Fname) + " " + hrPublicFunction.formatName(di.Middlename), di.DeptEmpCode.ToString()));
                }
                x = x + 1;
            }

        }
    }

    private void loadHeads(int DeptId)
    {
        try
        {
            ArrayList obj = new ArrayList();
            obj = (new DepartmentHeadsController()).List();

            if (obj.Count > 0)
            {

                int x = 0;
                while (x < obj.Count)
                {
                    DepartmentHeadInfo di = (DepartmentHeadInfo)obj[x];
                    if (di.DeptId == Convert.ToInt32(ddlDepartment.SelectedValue))
                    {
                        DepartmentEmployeesInfo doi = (new DepartmentEmployeesController()).Get(Convert.ToInt32(di.DeptHead));
                        lbHeads.Items.Add(new ListItem(doi.Ptitle + " " + hrPublicFunction.formatName(doi.Lastname) + " " + hrPublicFunction.formatName(doi.Fname) + " " + hrPublicFunction.formatName(doi.Middlename), di.RecId.ToString()));
                    }
                    x = x + 1;
                }

            }

        }
        catch (Exception ex)
        {

        }

    }

    private void ClearScreen()
    {
        //try
        ddlsDay.SelectedIndex = -1;
        ddlsMonth.SelectedIndex = -1;
        ddlsYear.SelectedIndex = -1;

        ddleDay.SelectedIndex = -1;
        ddleMonth.SelectedIndex = -1;
        ddleYear.SelectedIndex = -1;

        ddlEmp.SelectedIndex = -1;
    }

    private void LockScreen()
    {
        
        ddlsDay.Enabled = false ;
        ddlsMonth.Enabled = false ;
        ddlsYear.Enabled = false ;
        ddleDay.Enabled = false;
        ddleMonth.Enabled = false;
        ddleYear.Enabled = false;
        ddlEmp.Enabled =false ;
    }

    private void loadRecord()
    {

        try
        {

            DepartmentHeadInfo doi = (new DepartmentHeadsController()).Get(Convert.ToInt32(lbHeads.SelectedValue));
            txtDeptName.Text = ddlDepartment.SelectedItem.Text;
            ListItem li = ddlEmp.Items.FindByText("lbHeads.SelectedItem.Text");
            if (ddlEmp.Items.Contains(li))
            {
                ddlEmp.SelectedValue = Convert.ToString(doi.DeptHead);
            }
            else
            {

                // employee or past head no longer in the department
                ListItem lit = new ListItem(lbHeads.SelectedItem.Text,Convert.ToString(doi.DeptHead) );
                ddlEmp.Items.Add(lit);
                ddlEmp.SelectedValue = lit.Value;
            }

            ddlsDay.SelectedValue = doi.StartDate.Day.ToString();
            ddlsMonth.SelectedValue = doi.StartDate.Month.ToString(); ;
            ddlsYear.SelectedValue = doi.StartDate.Year.ToString(); ;

            ddleDay.SelectedValue = doi.EndDate.Day.ToString();
            ddleMonth.SelectedValue = doi.EndDate.Month.ToString();
            ddleYear.SelectedValue = doi.EndDate.Year.ToString();

        }
        catch (Exception ex)
        {

        }

    }

    protected void bttnNew_Click(object sender, EventArgs e)
    {
        ddlsDay.Enabled = true;
        ddlsMonth.Enabled = true;
        ddlsYear.Enabled = true;

        ddleDay.Enabled = true;
        ddleMonth.Enabled = true;
        ddleYear.Enabled = true;
        ddlEmp.Enabled = true;
        bttnCancel.Visible = true;

        bttnCancel.Visible = true;
        lblRecId.Text = "";
        PanelRight.Visible = true;
        ClearScreen();
        bttnNew.Visible = false;
        bttnSave.Visible = true;
        ddlEmp.Items.Clear();
        ddlEmp.Items.Add(new ListItem("  ", "-1"));
        bttnEdit.Visible = false;

        //load supervising department employees
        loadEmployeesbyDept(getSupervisingDept(Convert.ToInt32(ddlDepartment.SelectedValue)));
        // load all employees in that department to combo box
        loadEmployeesbyDept(Convert.ToInt32(ddlDepartment.SelectedValue));
        txtDeptName.Text = ddlDepartment.SelectedItem.Text;
        ddlEmp.SelectedIndex = -1;

    }

    protected void bttnSave_Click(object sender, EventArgs e)
    {
        try
        {
            // save item

            // validate if start date is greater than end date.
            DateTime startTime = new DateTime(Convert.ToInt32(ddlsYear.SelectedValue), Convert.ToInt32(ddlsMonth.SelectedValue), Convert.ToInt32(ddlsDay.SelectedValue));
            DateTime endTime = new DateTime(Convert.ToInt32(ddleYear.SelectedValue), Convert.ToInt32(ddleMonth.SelectedValue), Convert.ToInt32(ddleDay.SelectedValue));

            if (startTime < endTime)
            {

                //check if we are updating an old record or inserting a new one
                if (lblRecId.Text.Trim() == "")
                {
                    try
                    {
                        DepartmentHeadInfo doi = new DepartmentHeadInfo(Convert.ToInt32(ddlDepartment.SelectedValue), Convert.ToInt32(ddlEmp.SelectedValue), startTime, endTime);
                        int ret = new DepartmentHeadsController().Add(doi);

                    }
                    catch (Exception Ex)
                    {

                    }

                }
                else
                {
                    DepartmentHeadInfo doi = new DepartmentHeadInfo(Convert.ToInt32(lblRecId.Text), Convert.ToInt32(ddlDepartment.SelectedValue), Convert.ToInt32(ddlEmp.SelectedValue), startTime, endTime);
                    (new DepartmentHeadsController()).Update(doi);
                }

            }

            // clear screen
            ClearScreen();
            bttnNew.Visible = true;
            bttnCancel.Visible = false;
            bttnSave.Visible = false;
            PanelRight.Visible = false;

            // Reload listbox
            ddlDepartment_SelectedIndexChanged(this, new EventArgs());

        }
        catch (Exception ex)
        {

        }
    }

    protected void bttnEdit_Click(object sender, EventArgs e)
    {

        PanelRight.Visible = true;
        bttnSave.Visible = true;

        // ClearScreen();

        ddlsDay.Enabled = true;
        ddlsMonth.Enabled = true;
        ddlsYear.Enabled = true;

        ddleDay.Enabled = true;
        ddleMonth.Enabled = true;
        ddleYear.Enabled = true;
        ddlEmp.Enabled = true;
        bttnCancel.Visible = true;

    }

    protected void bttnCancel_Click(object sender, EventArgs e)
    {

        PanelRight.Visible = false;
        ClearScreen();
        bttnCancel.Visible = false;
        bttnNew.Visible = true;

    }

    protected void lbHeads_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lblRecId.Text = "";
            ClearScreen();
            LockScreen();
            if (lbHeads.SelectedIndex == -1)
            {
                return;
            }
            lblRecId.Text = lbHeads.SelectedValue;
            loadRecord();
            PanelRight.Visible = true;
            bttnEdit.Visible = true;
            bttnNew.Visible = true;
            bttnSave.Visible = false;
            bttnCancel.Visible = false;
        }
        catch (Exception ex)
        {

        }
    }

    protected void bttnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Master.aspx");

    }
}