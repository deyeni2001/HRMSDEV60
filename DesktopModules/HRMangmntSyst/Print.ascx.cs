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
using System.Web.Security;
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

using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ola.HRMangmntSyst;


namespace ola.HRMangmntSyst
{
    public partial class Print : PortalModuleBase, IActionable
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

       // public class PrintHelper
       // {
            //public PrintHelper()
            //{
            //}
       // }
        #endregion


        public partial class DesktopModules_HRMangmntSyst_Print : System.Web.UI.UserControl
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                Control ctrl = (Control)Session["ctrl"];
                
                PrintHelper.PrintWebControl(ctrl);


            }
       
      }

        public class PrintHelper
        {
            public PrintHelper()
            {
            }

            public static void PrintWebControl(Control ctrl)
            {
                PrintWebControl(ctrl, string.Empty);
            }

            public static void PrintWebControl(Control ctrl, string Script)
            {
                StringWriter stringWrite = new StringWriter();
                System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
                if (ctrl is WebControl)
                {
                    Unit w = new Unit(100, UnitType.Percentage); ((WebControl)ctrl).Width = w;
                }
                Page pg = new Page();
                pg.EnableEventValidation = false;
                if (Script != string.Empty)
                {
                    pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", Script);
                }
                HtmlForm frm = new HtmlForm();
                pg.Controls.Add(frm);
                frm.Attributes.Add("runat", "server");
                frm.Controls.Add(ctrl);
                pg.DesignerInitialize();
                pg.RenderControl(htmlWrite);
                string strHTML = stringWrite.ToString();
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.Write(strHTML);
                HttpContext.Current.Response.Write("<script>window.print();</script>");
                HttpContext.Current.Response.End();
            }
        }

    }
}