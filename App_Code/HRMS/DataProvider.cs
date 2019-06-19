using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DotNetNuke;
using DotNetNuke.Framework;
using Dokun.neetbeet;


namespace Dokun.neetbeet
{

    /// <summary>
    /// Summary description for DataProvider
    /// </summary>
    public abstract class DataProvider
    {
        #region Shared/Static Methods

        // singleton reference to the instantiated object 
        static DataProvider objProvider = null;

        // constructor
        static DataProvider()
        {
            CreateProvider();
        }

        // dynamically create provider
        private static void CreateProvider()
        {
            objProvider = (DataProvider)Reflection.CreateObject("data", "Dokun.neetbeet", "");
        }

        // return the provider
        public static DataProvider Instance()
        {
            return objProvider;
        }

        #endregion

        public DataProvider()
        {
            //
            // TODO: Add constructor logic here
            //
        }




        #region "AuditTrail Abstract Methods"
        //public abstract IDataReader AuditTrailGet(int logId);

        //public abstract IDataReader AuditTrailList(DateTime startTime, DateTime  EndTime);
        //public abstract IDataReader AuditTrailList(int logUserId);

        public abstract int AuditTrailAdd(int logUserId, string logTable, int logAction, string logDesc, string logOv, string  logNv, DateTime logTime);
        #endregion



        #region "DashBoardNotifications Abstract Methods"
        public abstract IDataReader DashBoardNotificationsGet(int msgId);

        public abstract IDataReader DashBoardNotificationsList();
        public abstract IDataReader DashBoardNotificationsList(int msgTo);


        public abstract int DashBoardNotificationsAdd(int msgTo, string msgFrom, string msgLink, string msgText, int msgStatus, DateTime msgTime);
        public abstract void DashBoardNotificationsUpdate(int msgId, int msgTo, string msgFrom, string msgLink, string msgText, int msgStatus, DateTime msgTime);
        public abstract void DashBoardNotificationsDelete(int msgId);
        #endregion


        #region "EmployeeGrades Abstract Methods"
        public abstract IDataReader EmployeeGradesGet(int GradeId);
        public abstract IDataReader EmployeeGradesGetByGradeName(String GradeName);

        public abstract IDataReader EmployeeGradesList();

        public abstract int EmployeeGradesAdd(String GradeName, String GradeCode, String GradeDescription);
        public abstract void EmployeeGradesUpdate(int GradeId, String GradeName, String GradeCode, String GradeDescription);
        public abstract void EmployeeGradesDelete(int GradeId);
        #endregion


        #region "DepartmentHeads Abstract Methods"
        public abstract IDataReader DepartmentHeadsGet(int RecId);
        public abstract IDataReader DepartmentHeadsList();

        public abstract int DepartmentHeadsAdd(int DeptId, int DeptHead, DateTime StartDate, DateTime EndDate);
        public abstract void DepartmentHeadsUpdate(int RecId, int DeptId, int DeptHaed, DateTime StartDate, DateTime EndDate);
        public abstract void DepartmentHeadsDelete(int RecId);
        #endregion


        #region "DepartmentEmployees Abstract Methods"
        public abstract IDataReader DepartmentEmployeesGet(int DeptEmpCode);
        public abstract IDataReader DepartmentEmployeesGetByUserId(string  UserId);

        public abstract IDataReader DepartmentEmployeesList();
        public abstract IDataReader DepartmentEmployeesListSearch(String searchString);
 

        public abstract int DepartmentEmployeesAdd(int EmpStatus, int DeptId, string JobTitle, string Ptitle, string Fname, string Middlename, string Lastname, string Email, string PhoneExt, string MobileNo, string OfficeRoom, string EmpType, string Passport, string UserId);
        public abstract void DepartmentEmployeesUpdate(int DeptEmpCode, int EmpStatus, int DeptId, string JobTitle, string Ptitle, string Fname, string Middlename, string Lastname, string Email, string PhoneExt, string MobileNo, string OfficeRoom, string EmpType, string Passport, string UserId);
        public abstract void DepartmentEmployeesDelete(int DeptEmpCode);
        #endregion


        #region "DepartmentTable Abstract Methods"
        public abstract IDataReader DepartmentTableGet(int DeptId);
        public abstract IDataReader DepartmentTableList();
        public abstract int DepartmentTableAdd(string DeptName, String DeptCode, int SuperDept, string DeptRole);
        public abstract void DepartmentTableUpdate(int DeptId, string DeptName, String DeptCode, int SuperDept, string DeptRole);
        public abstract void DepartmentTableDelete(int DeptId);
        #endregion


       
    }
}