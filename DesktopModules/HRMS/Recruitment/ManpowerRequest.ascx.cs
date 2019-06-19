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


public partial class DesktopModules_HRMS_ManpowerRequest : PortalModuleBase, IActionable
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack )
        {
            try
            {
                string currUSER = DotNetNuke.Entities.Users.UserController.GetCurrentUserInfo().Username;
                DepartmentEmployeesInfo doi = (new DepartmentEmployeesController()).GetByUserId(currUSER);
                txtSuper.Text = doi.Ptitle + " " + hrPublicFunction.formatName(doi.Lastname) + " " + hrPublicFunction.formatName(doi.Fname) + " " + hrPublicFunction.formatName(doi.Middlename);
                DepartmentTableInfo dti = (new DepartmentTableController()).Get(Convert.ToInt32(doi.DeptId));
                txtDept.Text = dti.DeptName;
                int x = 1;
                while (x < 501)
                {
                    ddlNumber.Items.Add(new ListItem(x.ToString(), x.ToString()));
                    x = x + 1;
                }


                ArrayList objGrades = new ArrayList();
                objGrades = (new EmployeeGradesController()).List();

                if (objGrades.Count > 0)
                {

                    ddlGradeMin .DataSource = objGrades;
                    ddlGradeMax.DataSource = objGrades;

                    ddlGradeMin .DataTextField = "GradeName";
                    ddlGradeMin .DataValueField = "GradeId";
                    ddlGradeMin .DataBind();

                    ddlGradeMax.DataTextField = "GradeName";
                    ddlGradeMax.DataValueField = "GradeId";
                    ddlGradeMax.DataBind();

                }

            }
            catch (Exception ex)
            {

            }
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

    protected void bttnBack_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~/LineManager.aspx");

    }




}