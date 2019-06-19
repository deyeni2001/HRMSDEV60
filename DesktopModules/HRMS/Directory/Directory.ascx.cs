using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Dokun.neetbeet;



// empty shell awaiting population


public partial class DesktopModules_HRMS_Directory : PortalModuleBase, IActionable
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
        if (!Page.IsPostBack )
        {
            try
            {
                panelActiveDirectory.Visible = false;
                ArrayList objDeptEmp = new ArrayList();
                objDeptEmp = (new DepartmentEmployeesController()).List();


                tvEmployeeList.Nodes.Clear();
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
    }

    protected void bttnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            clearSelection();
            tvEmployeeList.Nodes.Clear();
            panelActiveDirectory.Visible = false;

            if (txtSearch.Text.Trim() == "")
            {
                // show all employees

                ArrayList objDeptEmp = new ArrayList();
                objDeptEmp = (new DepartmentEmployeesController()).List();
                if (objDeptEmp.Count > 0)
                {
                    TreeNode compnode = new TreeNode("Contains  ...." + txtSearch.Text);
                    compnode.Value = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyCode");

                    tvEmployeeList.Nodes.Add(compnode);

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
            else
            {
                // search by lastanme 
                ArrayList objDeptEmp = new ArrayList();
                objDeptEmp = (new DepartmentEmployeesController()).ListSearch(txtSearch.Text);
                if (objDeptEmp.Count > 0)
                {

                    TreeNode compnode = new TreeNode("Contains  ...." + txtSearch.Text);
                    compnode.Value = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyCode");
                    tvEmployeeList.Nodes.Add(compnode);

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
            tvEmployeeList.ExpandAll();


        }
        catch (Exception ex)
        {
        }
    }

    private void clearSelection()
    {
        lblEtype.Text = "";
        imgPassport.ImageUrl = "";
        lblName.Text = "";
        lblJob.Text = "";
        lblDepartment.Text = "";
        lblExt.Text = "";
        lblMob.Text = "";
        lblOffice.Text = "";
        hlBoss.Text = "";
        hlBoss.NavigateUrl = "#";
        hlEmail.Text = "";
        hlEmail.NavigateUrl = "#";

    }


    private void loadEmployee(String DeptEmpCode)
    {

        try
        {

            DepartmentEmployeesInfo doi = (new DepartmentEmployeesController()).Get(Convert.ToInt32(DeptEmpCode));

            DepartmentTableInfo dti = (new DepartmentTableController()).Get(Convert.ToInt32(doi.DeptId));
            imgPassport.ImageUrl = doi.Passport;
            if(doi.EmpType == "1")
            {
                lblEtype.Text = "Employee";
            }
            if (doi.EmpType == "2")
            {
                lblEtype.Text = "Contractor";
            }

            lblName.Text = doi.Ptitle + " " + hrPublicFunction.formatName( doi.Lastname) + " " + hrPublicFunction.formatName(doi.Fname) + " " + hrPublicFunction.formatName(doi.Middlename) ;
            lblJob.Text = doi.JobTitle ;
            lblDepartment.Text = dti.DeptName;
            lblExt.Text = doi.PhoneExt ;
            lblMob.Text = doi.MobileNo ;
            lblOffice.Text = doi.OfficeRoom ;
            hlEmail.Text = doi.Email;
            hlEmail.NavigateUrl = "mailto:" + doi.Email;

            int CurrHead = getCurrentHead(doi.DeptId );

            if (CurrHead == doi.DeptEmpCode )
            {
                // if employee is head of department, get super Dept head
                DepartmentTableInfo obj = (new DepartmentTableController()).Get(doi.DeptId );
               int SuperHead =  getCurrentHead( obj.SuperDept);
                DepartmentEmployeesInfo dhi = (new DepartmentEmployeesController()).Get(SuperHead);
                hlBoss.Text = dhi.Ptitle + " " + hrPublicFunction.formatName( dhi.Lastname) + " " + hrPublicFunction.formatName(dhi.Fname) + " " + hrPublicFunction.formatName(dhi.Middlename);
                hlBoss.NavigateUrl = "#";
            }
            else
            {
                DepartmentEmployeesInfo dhi = (new DepartmentEmployeesController()).Get(CurrHead);
                hlBoss.Text = dhi.Ptitle + " " + hrPublicFunction.formatName( dhi.Lastname) + " " + hrPublicFunction.formatName( dhi.Fname) + " " + hrPublicFunction.formatName( dhi.Middlename);
                hlBoss.NavigateUrl = "#";

            }



        }
        catch (Exception ex)
        {

        }

    }

    private int getCurrentHead(int deptid)
    {
        int currHead = 0;

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
                    if (di.DeptId == deptid)
                    {
                        if (di.EndDate > DateTime.Now)
                        {
                            return di.DeptHead;
                        }
                    }
                    x = x + 1;
                }

            }
            return currHead;
        }
        catch (Exception ex)
        {
            return currHead;

        }
    }

    protected void bttnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SelfService.aspx");

    }

    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        try
        {
            clearSelection();
            if (tvEmployeeList.Nodes.Count < 1)
            {
                return;
            }
            loadEmployee(tvEmployeeList.SelectedValue);
            panelActiveDirectory.Visible = true;
        }
        catch (Exception ex)
        {

        }
    }


}