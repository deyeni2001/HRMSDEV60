using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;



/// <summary>
/// Summary description for SendHRNotification
/// </summary>
/// 

namespace Dokun.neetbeet
{
    public static class hrPublicFunction
    {


        public static Boolean LogTrail(AuditTrailInfo ati)
        {
            Boolean sent = false;

            try
            {
                int ret = new AuditTrailController().Add(ati);
                sent = true;
                return sent;
            }
            catch (Exception ex)
            {

            }
            return sent;
        }

        public static Boolean SendNotification(DashBoardNotificationsInfo dni)
        {
            Boolean sent = false;

            try
            {
                int ret = new DashBoardNotificationsController().Add(dni);
                sent = true;
                return sent;
            }
            catch (Exception ex)
            {

            }
            return sent;
        }

        public static Boolean ChangeNotificationStatus(DashBoardNotificationsInfo dni, int newStatus)
        {
            Boolean sent = false;

            try
            {
                dni.msgStatus = newStatus;
                new DashBoardNotificationsController().Update(dni);
                sent = true;
                return sent;
            }
            catch (Exception ex)
            {

            }
            return sent;
        }

        public static string formatName(String parName)
        {
            String firtsCap = parName.Substring(0, 1).ToUpper();
            string restName = parName.Substring(1).ToLower();
            String RetName = firtsCap + restName;
            return RetName;
        }


    }
}