using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DotNetNuke;
using DotNetNuke.Framework;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Framework.Providers;
using Dokun.neetbeet;

namespace Dokun.neetbeet
{

    public class SqlDataProvider : DataProvider
    {


        #region Private Members

        private const string ProviderType = "data";
        private const string ModuleQualifier = "YourCompany_";

        private ProviderConfiguration _providerConfiguration = ProviderConfiguration.GetProviderConfiguration(ProviderType);
        private string _connectionString;
        private string _providerPath;
        private string _objectQualifier;
        private string _databaseOwner;

        #endregion

        /// <summary>
        /// Summary description for SqlDataProvider
        /// </summary>
        /// 

        #region Constructors

        /// <summary>
        /// Constructs new SqlDataProvider instance
        /// </summary>
        public SqlDataProvider()
        {
            //Read the configuration specific information for this provider
            Provider objProvider = (Provider)_providerConfiguration.Providers[_providerConfiguration.DefaultProvider];

            //Read the attributes for this provider
            if ((objProvider.Attributes["connectionStringName"] != "") && (System.Configuration.ConfigurationManager.AppSettings[objProvider.Attributes["connectionStringName"]] != ""))
            {
                _connectionString = System.Configuration.ConfigurationManager.AppSettings[objProvider.Attributes["connectionStringName"]];
            }
            else
            {
                _connectionString = objProvider.Attributes["connectionString"];
            }

            _providerPath = objProvider.Attributes["providerPath"];

            _objectQualifier = objProvider.Attributes["objectQualifier"];

            if ((_objectQualifier != "") && (_objectQualifier.EndsWith("_") == false))
            {
                _objectQualifier += "_";
            }

            _databaseOwner = objProvider.Attributes["databaseOwner"];
            if ((_databaseOwner != "") && (_databaseOwner.EndsWith(".") == false))
            {
                _databaseOwner += ".";
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets the connection string
        /// </summary>
        public string ConnectionString
        {
            get { return _connectionString; }
        }

        /// <summary>
        /// Gets and sets the Provider path
        /// </summary>
        public string ProviderPath
        {
            get { return _providerPath; }
        }

        /// <summary>
        /// Gets and sets the Object qualifier
        /// </summary>
        public string ObjectQualifier
        {
            get { return _objectQualifier; }
        }

        /// <summary>
        /// Gets and sets the database ownere
        /// </summary>
        public string DatabaseOwner
        {
            get { return _databaseOwner; }
        }

        #endregion

        #region Private Methods

        private string GetFullyQualifiedName(string name)
        {
            return DatabaseOwner + ObjectQualifier + ModuleQualifier + name;
        }

        private Object GetNull(Object Field)
        {
            return Null.GetNull(Field, DBNull.Value);
        }

        #endregion





        #region "AuditTrail Methods"
     


        public override int AuditTrailAdd(int logUserId, string logTable, int logAction, string logDesc, string logOv, string logNv, DateTime logTime)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "AddAuditTrail", logUserId, logTable, logAction, logDesc, logOv, logNv, logTime).ToString());
        }


        #endregion

        #region "DashBoardNotifications Methods"
        public override IDataReader DashBoardNotificationsGet(int msgId)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GetDashBoardNotificationsById", msgId);
        }

        public override IDataReader DashBoardNotificationsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "getDashBoardNotifications");
        }

        public override IDataReader DashBoardNotificationsList(int msgTo)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "getDashBoardNotificationsTo", msgTo);
        }


        public override int DashBoardNotificationsAdd(int msgTo, string msgFrom, string msgLink, string msgText, int msgStatus, DateTime msgTime)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "AddDashBoardNotifications", msgTo, msgFrom, msgLink, msgText, msgStatus, msgTime).ToString());
        }

        public override void DashBoardNotificationsUpdate(int msgId, int msgTo, string msgFrom, string msgLink, string msgText, int msgStatus, DateTime msgTime)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "UpdateDashBoardNotifications", msgId, msgTo, msgFrom, msgLink, msgText, msgStatus, msgTime);
        }

        public override void DashBoardNotificationsDelete(int msgId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "deleteDashBoardNotifications", msgId);
        }
        #endregion



        #region "EmployeeGrades Methods"
        public override IDataReader EmployeeGradesGet(int GradeId)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GetEmployeeGradesById", GradeId);
        }
        public override IDataReader EmployeeGradesGetByGradeName(String  GradeName)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GetEmployeeGradesByName", GradeName);
        }

        public override IDataReader EmployeeGradesList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "getEmployeeGrades");
        }

        public override int EmployeeGradesAdd( string  GradeName, String  GradeCode, String  GradeDescription)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "AddEmployeeGrades", GradeName, GradeCode, GradeDescription).ToString());
        }

        public override void EmployeeGradesUpdate( int GradeId, string GradeName, String GradeCode, String GradeDescription)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "UpdateEmployeeGrades", GradeId, GradeName, GradeCode, GradeDescription);
        }

        public override void EmployeeGradesDelete(int GradeId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "deleteEmployeeGrades", GradeId );
        }
        #endregion


        #region "DepartmentHeads Methods"
        public override IDataReader DepartmentHeadsGet(int RecId)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GetDepartmentHeadsById", RecId );
        }


        public override IDataReader DepartmentHeadsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "getDepartmentHeads");
        }

        public override int DepartmentHeadsAdd(int DeptId, int DeptHead, DateTime StartDate, DateTime EndDate)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "AddDepartmentHeads", DeptId, DeptHead, StartDate , EndDate).ToString());
        }

        public override void DepartmentHeadsUpdate(int RecId, int DeptId, int DeptHead, DateTime StartDate, DateTime EndDate)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "UpdateDepartmentHeads", RecId , DeptId , DeptHead , StartDate , EndDate);
        }

        public override void DepartmentHeadsDelete(int RecId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "deleteDepartmentHeads", RecId);
        }
        #endregion


        #region "DepartmentEmployees Methods"
        public override IDataReader DepartmentEmployeesGet(int DeptEmpCode)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GetDepartmentEmployeebyCode", DeptEmpCode);
        }

        public override IDataReader DepartmentEmployeesGetByUserId(String UserId)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GetDepartmentEmployeebyUserId", UserId );
        }
        public override IDataReader DepartmentEmployeesListSearch(String searchString)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "[GetDepartmentEmployeebySearch]", searchString);
        }

        public override IDataReader DepartmentEmployeesList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "getDepartmentEmployees");
        }

        public override int DepartmentEmployeesAdd(int EmpStatus, int DeptId, string JobTitle, string Ptitle, string Fname, string Middlename, string Lastname, string Email, string PhoneExt, string MobileNo, string OfficeRoom, string EmpType, string Passport, string UserId)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "AddDepartmentEmployees", EmpStatus, DeptId, JobTitle, Ptitle, Fname, Middlename, Lastname, Email, PhoneExt, MobileNo, OfficeRoom, EmpType,  Passport, UserId).ToString());
        }

        public override void DepartmentEmployeesUpdate(int DeptEmpCode, int EmpStatus, int DeptId, string JobTitle, string Ptitle, string Fname, string Middlename, string Lastname, string Email, string PhoneExt, string MobileNo, string OfficeRoom, string EmpType, string Passport, string UserId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "UpdateDepartmentEmployees", DeptEmpCode, EmpStatus, DeptId, JobTitle, Ptitle, Fname, Middlename, Lastname, Email, PhoneExt, MobileNo, OfficeRoom, EmpType, Passport, UserId);
        }

        public override void DepartmentEmployeesDelete(int DeptEmpCode)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "deleteDepartmentEmployees", DeptEmpCode);
        }
        #endregion


        #region "DepartmentTable Methods"
        public override IDataReader DepartmentTableGet(int DeptId)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GetDepartmentbyId", DeptId);
        }


      
        public override IDataReader DepartmentTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "getDepartments");
        }

        public override int DepartmentTableAdd(string DeptName, String DeptCode, int SuperDept, string DeptRole)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "AddDepartment", DeptName,DeptCode, SuperDept, DeptRole).ToString ());
        }

        public override void DepartmentTableUpdate(int DeptId, string DeptName, String DeptCode, int SuperDept, string DeptRole)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "updateDepartmentTable", DeptId ,DeptName, DeptCode,SuperDept, DeptRole );
        }

        public override void DepartmentTableDelete(int DeptId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "deleteDepartmentTable", DeptId);
        }
        #endregion


        

    }

}