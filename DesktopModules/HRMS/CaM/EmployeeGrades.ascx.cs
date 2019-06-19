using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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

public partial class DesktopModules_HRMS_CaM_EmployeeGrades : PortalModuleBase, IActionable
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
                PanelRight.Visible = false;
                bttnNew.Visible = true;

                // load existing Grades

                loadGrades();


            }
        }
        catch (Exception ex)
        {

        }
    }

    private void loadGrades()
    {
        try
        {
            ArrayList obj = new ArrayList();
            obj = (new EmployeeGradesController()).List();

            if (obj.Count > 0)
            {
                int x = 0;
                while (x < obj.Count)
                {
                    EmployeeGradeInfo di = (EmployeeGradeInfo)obj[x];
                    lbGrades.Items.Add(new ListItem(di.GradeName, di.GradeId.ToString()));
                    x = x + 1;
                }

            }

        }
        catch (Exception ex)
        {

        }

    }

    protected void bttnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Master.aspx");

    }

    protected void bttnNew_Click(object sender, EventArgs e)
    {
        try
        {

            txtGradeCode.Enabled = true;
            txtGradeCode.Text = "";
            txtGradeDescription.Enabled = true;
            txtGradeDescription.Text = "";
            txtGradeName.Enabled = true;
            txtGradeName.Text = "";
            bttnCancel.Visible = true;

            bttnCancel.Visible = true;
            lblRecId.Text = "";
            PanelRight.Visible = true;
            ClearScreen();
            bttnNew.Visible = false;
            bttnSave.Visible = true;
            bttnEdit.Visible = false;

        }
        catch (Exception ex)
        {

        }
    }


    private void ClearScreen()
    {
        //try
        txtGradeCode.Text = "";
        txtGradeDescription.Text = "";
        txtGradeName.Text = "";

    }


    protected void bttnCancel_Click(object sender, EventArgs e)
    {
        PanelRight.Visible = false;
        ClearScreen();
        bttnCancel.Visible = false;
        bttnNew.Visible = true;

    }

    protected void bttnEdit_Click(object sender, EventArgs e)
    {

        PanelRight.Visible = true;
        bttnSave.Visible = true;

        // ClearScreen();

        txtGradeName.Enabled = true;
        txtGradeDescription.Enabled = true;
        txtGradeCode.Enabled = true;

        bttnCancel.Visible = true;
    }

    private void LockScreen()
    {

        txtGradeName.Enabled = false;
        txtGradeDescription.Enabled = false;
        txtGradeCode.Enabled = false;
    }

    private void loadRecord()
    {

        try
        {

            EmployeeGradeInfo doi = (new EmployeeGradesController()).Get(Convert.ToInt32(lbGrades.SelectedValue));
            txtGradeName.Text = doi.GradeName;
            txtGradeCode.Text = doi.GradeCode;
            txtGradeDescription.Text = doi.GradeDescription;

        }
        catch (Exception ex)
        {

        }

    }

    protected void lbGrades_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {
            lblRecId.Text = "";
            ClearScreen();
            LockScreen();
            if (lbGrades.SelectedIndex == -1)
            {
                return;
            }
            lblRecId.Text = lbGrades.SelectedValue;
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

    protected void bttnSave_Click(object sender, EventArgs e)
    {
        try
        {
            // save item
            //check if we are updating an old record or inserting a new one
            if (lblRecId.Text.Trim() == "")
            {
                try
                {
                    EmployeeGradeInfo doi = new EmployeeGradeInfo(txtGradeName.Text, txtGradeCode.Text, txtGradeDescription.Text);
                    int ret = new EmployeeGradesController().Add(doi);

                }
                catch (Exception Ex)
                {

                }

            }
            else
            {
                EmployeeGradeInfo doi = new EmployeeGradeInfo(Convert.ToInt32(lblRecId.Text), txtGradeName.Text, txtGradeCode.Text, txtGradeDescription.Text);
                (new EmployeeGradesController()).Update(doi);
            }


            // clear screen
            ClearScreen();
            bttnNew.Visible = true;
            bttnCancel.Visible = false;
            bttnSave.Visible = false;
            PanelRight.Visible = false;

            // Reload listbox
            lbGrades.Items.Clear();
            loadGrades();

        }
        catch (Exception ex)
        {

        }
    }

}