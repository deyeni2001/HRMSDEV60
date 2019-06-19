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


public partial class DesktopModules_HRMS_Dashboard : PortalModuleBase, IActionable
{

    // USE HRNotification and sendHRNotification

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // display user name
            string currUSER = DotNetNuke.Entities.Users.UserController.GetCurrentUserInfo().Username;
            DepartmentEmployeesInfo doi = (new DepartmentEmployeesController()).GetByUserId(currUSER);
            lblName.Text = doi.Ptitle + " " + hrPublicFunction.formatName(doi.Lastname) + " " + hrPublicFunction.formatName(doi.Fname) + " " + hrPublicFunction.formatName(doi.Middlename) + "::  DASHBOARD" ;
            ArrayList objNotice = new ArrayList();
            objNotice = (new DashBoardNotificationsController()).List(doi.DeptEmpCode);

            if (objNotice.Count > 0)
            {
                gvDashboard.DataSource = objNotice;
                gvDashboard.DataBind();

            }

        }
        catch (Exception ex)
        {

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


}