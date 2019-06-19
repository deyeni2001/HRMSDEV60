using System;
using System.Collections;
using System.Collections.Generic;
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





public partial class DesktopModules_HRMS_Organogram : PortalModuleBase, IActionable
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack )
        {
            PanelResults.Visible = false;

            ArrayList objDepts = new ArrayList();
            objDepts = (new DepartmentTableController()).List();

            if (objDepts.Count > 0)
            {

                ddlDept .DataSource = objDepts;
                ddlDept.DataTextField = "DeptName";
                ddlDept.DataValueField = "DeptID";
                ddlDept.DataBind();

            }


           // OrgTree orgTree = new OrgTree();
            //Assing output of the CreateTreeHtml function to Div
           // abc.InnerHtml = orgTree.CreateTreeHtml();
        }
    }


    public ModuleActionCollection ModuleActions
    {
        get
        {
            ModuleActionCollection Actions = new ModuleActionCollection();
            Actions.Add(this.GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile), ModuleActionType.AddContent, "", "", this.EditUrl(), false, SecurityAccessLevel.Edit, true, false);
            return Actions;
        }
    }


   
    protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception ex)
        {

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PanelResults.Visible = true;
        PanelOptions.Visible = false;

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        PanelOptions.Visible = true;
        PanelResults.Visible = false;
    }
}