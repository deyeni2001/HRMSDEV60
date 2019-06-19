using System.Web;
using System.Text;
using System.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using DotNetNuke;
using DotNetNuke.Framework;
using System.Data;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Configuration;

using System.Web.Security;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.SessionState;
using System.Net.Mail;

using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;




/// <summary>
/// A JavaScript alert
/// </summary>

namespace ola.HRMangmntSyst
{
    public static class Utility
    {

        /// <summary>
        /// Shows a client-side JavaScript alert in the browser.
        /// </summary>
        /// <param name="message">The message to appear in the alert.</param>
        public static void Alert(string message)
        {
            // Cleans http://localhost:1700/App_Code/the message to allow single quotation marks
            string cleanMessage = message.Replace("'", "\\'");
            string script = "<script type=\"text/javascript\">alert('" + cleanMessage + "');</script>";

            // Gets the executing web page
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(Utility), "alert", script);
            }
        }

        public static void SendMail(string mailSubject, string mailBody, string receiverEmail)
        {
            //send an email from a Gmail address using SMTP server.  
            //The Gmail SMTP server name is smtp.gmail.com and
            //the port using send mail is 587 and also using  

            //NetworkCredential for password based authentication;
            MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //mail.IsBodyHtml = true;
            ////mail.From = new MailAddress("your_email_address@gmail.com");
            //mail.From = new MailAddress("olami@neetbeettech@gmail.com");

            //mail.Subject = mailSubject;
            //mail.Body = mailBody;
            //mail.To.Add(receiverEmail);

            //SmtpServer.Port = 587;
            //// SmtpServer.Port = 25;
            //SmtpServer.Credentials = new System.Net.NetworkCredential("olami@neetbeettech@gmail.com", "Adeniyi@2018");

            ////SmtpServer.UseDefaultCredentials = false;
            //SmtpServer.EnableSsl = true;

            //SmtpServer.Send(mail);

            //mail.Dispose();
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


      //// <script language="javascript" type="text/javascript">
      //   //public static void PrintWebControl(Control ctrl, string Script)
      //  public static void  PrintPage(Control ctrl, string Script)
      //  {
      //      var printContent = document.getElementById
      //      ('<%= pnlGridView.ClientID %>');
      //      var printWindow = window.open("All Records", 
      //      "Print Panel", 'left=50000,top=50000,width=0,height=0');
      //      printWindow.document.write(printContent.innerHTML);
      //      printWindow.document.close();
      //      printWindow.focus();
      //      printWindow.print();
      //  }
   // </script>


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

        //Calculating working days

        #region

        // <summary>
        /// Calculates number of business days, taking into account:
        ///  - weekends (Saturdays and Sundays)
        ///  - bank holidays in the middle of the week
        /// </summary>
        /// <param name="firstDay">First day in the time interval</param>
        /// <param name="lastDay">Last day in the time interval</param>
        /// <param name="bankHolidays">List of bank holidays excluding weekends</param>
        /// <returns>Number of business days during the 'span'</returns>
        //public static int WorkingDaysUntil(this DateTime firstDay, DateTime lastDay, params DateTime[] bankHolidays)


        //public static int WorkingDaysUntil(this int workingDays,  DateTime firstDay, DateTime lastDay)
        ////public static int WorkingDaysUntil(this DateTime firstDay, DateTime lastDay)

        ////public static int WorkingDaysUntil(this DateTime firstDay, DateTime lastDay)
        //{
        //    //int workingDays;
        //    firstDay = firstDay.Date;
        //    lastDay = lastDay.Date;
           
        //    if (firstDay > lastDay)
        //    {
        //        throw new ArgumentException("Incorrect last day " + lastDay);
        //    }

        //    else
        //    {

        //        TimeSpan span = lastDay - firstDay;
        //        workingDays = span.Days + 1;
        //        int fullWeekCount = workingDays / 7;

        //        // find out if there are weekends during the time exceedng the full weeks
        //        if (workingDays > fullWeekCount * 7)
        //        {
        //            // we are here to find out if there is a 1-day or 2-days weekend
        //            // in the time interval remaining after subtracting the complete weeks

        //            int firstDayOfWeek = firstDay.DayOfWeek == DayOfWeek.Sunday
        //             ? 7 : (int)firstDay.DayOfWeek;
        //            int lastDayOfWeek = lastDay.DayOfWeek == DayOfWeek.Saturday
        //                ? 7 : (int)lastDay.DayOfWeek;

        //            // int firstDayOfWeek = (int) firstDay.DayOfWeek;
        //            // int lastDayOfWeek = (int) lastDay.DayOfWeek;

        //            if (lastDayOfWeek < firstDayOfWeek)
        //                lastDayOfWeek += 7;
        //            if (firstDayOfWeek <= 6)
        //            {
        //                if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
        //                    workingDays -= 2;
        //                else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
        //                    workingDays -= 1;
        //            }
        //            else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
        //                workingDays -= 1;
        //        }

        //        // subtract the weekends during the full weeks in the interval
        //        workingDays -= fullWeekCount + fullWeekCount;

        //        // subtract the number of bank holidays during the time interval
        //        //foreach (DateTime bankHoliday in bankHolidays)
        //        //{
        //        //    DateTime bh = bankHoliday.Date;
        //        //    if (firstDay <= bh && bh <= lastDay)
        //        //        --workingDays;
        //        //}

        //        return workingDays;
        //    }
        //}

        #endregion

    }

}


