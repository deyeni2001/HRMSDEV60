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
using Dokun.neetbeet;




public partial class DesktopModules_HRMS_SetUpDepartment : PortalModuleBase, IActionable
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
        if (!Page.IsPostBack)
        {
            
            loaddept();
            if (TreeView1.Nodes.Count < 1)
            {
                lblMessage.Text = "Please Load organisation Master Settings Settings";
            }

        }
    }


    private void loaddept()
    {
        try
        {

            TreeView1.Nodes.Clear();
            ddlSuperDept.Items.Clear();
            TreeNode compnode = new TreeNode(System.Configuration.ConfigurationManager.AppSettings.Get("CompanyName"));
            compnode.Value = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyCode");
            TreeView1.Nodes.Add(compnode);
            PopulateTreeView(compnode);
            panelEdit.Visible = false;

            ddlSuperDept.Items.Add(new ListItem("---  Select Department ---","0"));
            ddlSuperDept.Items.Add(new ListItem(System.Configuration.ConfigurationManager.AppSettings.Get("CompanyName"), System.Configuration.ConfigurationManager.AppSettings.Get("CompanyCode")));
            ArrayList objDepts = new ArrayList();
            objDepts = (new DepartmentTableController()).List();

            if (objDepts.Count > 0)
            {

                ddlSuperDept.DataSource = objDepts;
                ddlSuperDept.DataTextField = "DeptName";
                ddlSuperDept.DataValueField = "DeptID";
                ddlSuperDept.DataBind();

            }

        }
        catch(Exception ex)
        {

        }
      
    }

    private void PopulateTreeView(TreeNode parentNode)
    {
        ArrayList objDepts = new ArrayList();
        objDepts = (new DepartmentTableController()).List();
        int pvalue = 0;
        pvalue = Convert.ToInt32(parentNode.Value.Trim());
        int x = 0;
        while(x < objDepts.Count )
        {
            DepartmentTableInfo di =(DepartmentTableInfo) objDepts[x];
            if ( pvalue == di.SuperDept )
            {
                TreeNode t = new TreeNode();
                t.Text = di.DeptName ;
                t.Value = di.DeptId.ToString();
                parentNode.ChildNodes.Add(t);
                PopulateTreeView(t);
            }
            x = x + 1;
        }    
    }


    private void ShowNodeData(TreeNode nod)
    {
        //loadDataTable();
        int deptid = Convert.ToInt32(nod.Value);
        DepartmentTableInfo doi = (new DepartmentTableController()).Get(deptid);
        txtDeptName.Text = doi.DeptName;
        txtDeptCode.Text = doi.DeptCode;
        txtDeptRole.Text = doi.DeptRole;
        ddlSuperDept.SelectedValue = doi.SuperDept.ToString() ;

        txtDeptName.Enabled =false;
        txtDeptCode.Enabled =false;
        txtDeptRole.Enabled =false;
        ddlSuperDept.Enabled =false;

    }

    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        try
        {
            CHECK_isNew.Text = "FALSE";
            if (TreeView1.SelectedValue == "0")
            {

            }
            else
            {
                panelEdit.Visible = true;
            }


            if (TreeView1.SelectedNode.Text == System.Configuration.ConfigurationManager.AppSettings.Get("CompanyName"))
            {
                txtDeptName.Text = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyName");
                txtDeptCode.Text = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyChargeCode");
                txtDeptRole.Text = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyDescription");
                ddlSuperDept.SelectedValue = System.Configuration.ConfigurationManager.AppSettings.Get("CompanyCode");
            }
            else
            {
                ShowNodeData(TreeView1.SelectedNode);
            }
            bttnNew.Text = "Create New Department";//+ " under " + TreeView1.SelectedNode.Text;
            bttnNew.Visible = true;
            bttnSave.Visible = true;
            bttnEdit.Visible = true;

            bttnDelete.Visible = false;
            if (TreeView1.SelectedNode.Text == System.Configuration.ConfigurationManager.AppSettings.Get("CompanyName"))
            {
                ddlSuperDept.SelectedIndex = -1;

            }
            else
            {
                ddlSuperDept.SelectedValue = TreeView1.SelectedNode.Parent.Value;
            }

        }
        catch (Exception ex)
        {

        }
     
     
    }

    protected void bttnNew_Click(object sender, EventArgs e)
    {
       
        panelEdit.Visible = true;
        bttnNew.Visible = false;
        bttnDelete.Visible = false;
        bttnSave.Visible = true;
        bttnEdit.Visible = false;

        txtDeptCode.Text = "";
        txtDeptName.Text = ""; 
        txtDeptRole.Text = "";
        CHECK_isNew.Text = "TRUE";

        txtDeptName.Enabled = true;
        txtDeptCode.Enabled = true;
        txtDeptRole.Enabled = true;
        ddlSuperDept.Enabled = true;
        
    }


    protected void bttnEdit_Click(object sender, EventArgs e)
    {

        txtDeptName.Enabled = true;
        txtDeptCode.Enabled = true;
        txtDeptRole.Enabled = true;
        ddlSuperDept.Enabled = true;
        bttnEdit.Visible = true;
        panelEdit.Visible = true;

    }
    protected void bttnSave_Click(object sender, EventArgs e)
    {
        try
        {

            //check if record is new record or updating record


            if (CHECK_isNew.Text == "TRUE")
            {
                //new entry
                // InsertRec(txtDeptName.Text, Convert.ToInt32(ddlSuperDept.SelectedValue), txtDeptCode.Text, txtDeptRole.Text);
                try
                {
                    DepartmentTableInfo doi = new DepartmentTableInfo(txtDeptName.Text, txtDeptCode.Text, Convert.ToInt32(ddlSuperDept.SelectedValue), txtDeptRole.Text);
                    int ret = new DepartmentTableController().Add(doi);
                }
                catch (Exception ex)
                {
                   
                }
            }
            else
            {
                //updating an old entry
                // UpdateRec(Convert.ToInt32(TreeView1.SelectedValue), txtDeptName.Text, Convert.ToInt32(ddlSuperDept.SelectedValue), txtDeptCode.Text, txtDeptRole.Text);
                DepartmentTableInfo doi = new DepartmentTableInfo(Convert.ToInt32(TreeView1.SelectedNode.Value), txtDeptName.Text, txtDeptCode.Text,Convert.ToInt32( ddlSuperDept.SelectedValue), txtDeptRole.Text);
                (new DepartmentTableController()).Update(doi);
            }

          
            TreeView1.Nodes.Clear();
            loaddept();

            txtDeptName.Enabled = false;
            txtDeptCode.Enabled = false;
            txtDeptRole.Enabled = false;
            ddlSuperDept.Enabled = false;
            bttnEdit.Visible = false;
            panelEdit .Visible = false;
        }
        catch (Exception ex)
        {

        }
    }

    protected void bttnDelete_Click(object sender, EventArgs e)
    {
        bttnNew.Text = "Create New Department";//+ " under " + TreeView1.SelectedNode.Text;
        bttnNew.Visible = true;
        bttnDelete.Visible = false;
    }



    protected void bttnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Master.aspx");

    }
}