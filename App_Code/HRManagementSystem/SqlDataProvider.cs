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
using ola.HRMangmntSyst;

namespace ola.HRMangmntSyst
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



        #region "CountryTable Methods"
        public override IDataReader CountryTableGet(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableGet", countryID);
        }

        public override IDataReader CountryTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableList");
        }

        public override int CountryTableAdd(string countryName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableAdd", GetNull(countryName)).ToString());
        }

        public override void CountryTableUpdate(int countryID, string countryName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableUpdate", countryID, GetNull(countryName));
        }

        public override void CountryTableDelete(int countryID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "CountryTableDelete", countryID);
        }
        #endregion

        #region "StateTable Methods"
        public override IDataReader StateTableGet(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableGet", stateID);
        }

        public override IDataReader StateTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableList");
        }

        public override IDataReader StateTableGetByCountryTable(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableGetByCountryTable", countryID);
        }

        public override int StateTableAdd(string stateName, string stateCode, int countryID)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableAdd", GetNull(stateName), GetNull(stateCode), GetNull(countryID)).ToString());
        }

        public override void StateTableUpdate(int stateID, string stateName, string stateCode, int countryID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableUpdate", stateID, GetNull(stateName), GetNull(stateCode), GetNull(countryID));
        }

        public override void StateTableDelete(int stateID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "StateTableDelete", stateID);
        }
        #endregion

        #region "SenatorialTable Methods"
        public override IDataReader SenatorialTableGet(int senID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "SenatorialTableGet", senID);
        }

        public override IDataReader SenatorialTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "SenatorialTableList");
        }

        public override IDataReader SenatorialTableGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "SenatorialTableGetByStateTable", stateID);
        }

        public override int SenatorialTableAdd(string senCode, string senName, int senStateID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "SenatorialTableAdd", GetNull(senCode), GetNull(senName), GetNull(senStateID_FK)).ToString());
        }

        public override void SenatorialTableUpdate(int senID, string senCode, string senName, int senStateID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "SenatorialTableUpdate", senID, GetNull(senCode), GetNull(senName), GetNull(senStateID_FK));
        }

        public override void SenatorialTableDelete(int senID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "SenatorialTableDelete", senID);
        }
        #endregion


        #region "LGATable Methods"
        public override IDataReader LGATableGet(int lgaID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableGet", lgaID);
        }

        public override IDataReader LGATableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableList");
        }

        public override IDataReader LGATableGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableGetByStateTable", stateID);
        }

        public override int LGATableAdd(string lgaName, int stateID)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableAdd", GetNull(lgaName), GetNull(stateID)).ToString());
        }

        public override void LGATableUpdate(int lgaID, string lgaName, int stateID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableUpdate", lgaID, GetNull(lgaName), GetNull(stateID));
        }

        public override void LGATableDelete(int lgaID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "LGATableDelete", lgaID);
        }
        #endregion

        #region "Qualifications Methods"
        public override IDataReader QualificationsGet(int qualifID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationsGet", qualifID);
        }

        public override IDataReader QualificationsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationsList");
        }

        public override int QualificationsAdd(string qualifName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationsAdd", GetNull(qualifName)).ToString());
        }

        public override void QualificationsUpdate(int qualifID, string qualifName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationsUpdate", qualifID, GetNull(qualifName));
        }

        public override void QualificationsDelete(int qualifID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "QualificationsDelete", qualifID);
        }
        #endregion


        #region "GradeTable Methods"
        public override IDataReader GradeTableGet(int gradeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableGet", gradeID);
        }

        public override IDataReader GradeTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableList");
        }

        public override IDataReader GradeTableGetByQualifications(int qualifID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableGetByQualifications", qualifID);
        }

        public override int GradeTableAdd(string gradeName, int qaulifID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableAdd", GetNull(gradeName), qaulifID_FK).ToString());
        }

        public override void GradeTableUpdate(int gradeID, string gradeName, int qaulifID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableUpdate", gradeID, GetNull(gradeName), qaulifID_FK);
        }

        public override void GradeTableDelete(int gradeID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "GradeTableDelete", gradeID);
        }
        #endregion


        #region "ApplicantDepartmentTable Methods"
        public override IDataReader ApplicantDepartmentTableGet(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDepartmentTableGet", deptID);
        }

        public override IDataReader ApplicantDepartmentTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDepartmentTableList");
        }

        public override int ApplicantDepartmentTableAdd(string deptName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDepartmentTableAdd", GetNull(deptName)).ToString());
        }

        public override void ApplicantDepartmentTableUpdate(int deptID, string deptName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDepartmentTableUpdate", deptID, GetNull(deptName));
        }

        public override void ApplicantDepartmentTableDelete(int deptID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDepartmentTableDelete", deptID);
        }
        #endregion
        

        #region "ApplicantAvailablePositiontable Methods"
        public override IDataReader ApplicantAvailablePositiontableGet(int positionAppliedforID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantAvailablePositiontableGet", positionAppliedforID);
        }

        public override IDataReader ApplicantAvailablePositiontableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantAvailablePositiontableList");
        }

        public override IDataReader ApplicantAvailablePositiontableGetByApplicantDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantAvailablePositiontableGetByApplicantDepartmentTable", deptID);
        }

        public override int ApplicantAvailablePositiontableAdd(string positionAppliedForName, int deptID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantAvailablePositiontableAdd", GetNull(positionAppliedForName), GetNull(deptID_FK)).ToString());
        }

        public override void ApplicantAvailablePositiontableUpdate(int positionAppliedforID, string positionAppliedForName, int deptID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantAvailablePositiontableUpdate", positionAppliedforID, GetNull(positionAppliedForName), GetNull(deptID_FK));
        }

        public override void ApplicantAvailablePositiontableDelete(int positionAppliedforID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantAvailablePositiontableDelete", positionAppliedforID);
        }
        #endregion


        #region "ApplicantPersonalDetails Methods"
        public override IDataReader ApplicantPersonalDetailsGet(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGet", applicantID);
        }
        public override IDataReader ApplicantPersonalDetailsGetByApplicantNum(string applicantNum)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByApplicantNum", applicantNum);
        }

        // get offer details ApplicantPersonalDetailsGetOfferDetails

        public override IDataReader ApplicantPersonalDetailsGetOfferDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetOfferDetails", applicantID);
        }
        
        public override IDataReader ApplicantPersonalDetailsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsList");
        }
        // list by position applied for and application Status is null 
        public override IDataReader ApplicantPersonalDetailsListByPositionNotShortlisted(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionNotShortlisted", positionAppliedFor);
        }
        // list by position applied for and application Status is shortlisted but interviewer decision is null
        public override IDataReader ApplicantPersonalDetailsListByPositionShortlisted(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionShortlisted", positionAppliedFor);
        }
        // list by position applied for both shortlisted and not shortlisted 
        public override IDataReader ApplicantPersonalDetailsListByPositionAppliedForAll(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionAppliedForAll", positionAppliedFor);
        }

        // /list by position applied for, shortlisted and interviewer decision is hire and not hire(is null)
        public override IDataReader ApplicantPersonalDetailsListByPositionHireAndNot(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionHireAndNot", positionAppliedFor);
        }

        // list by position applied for and interviewer decision is hire
        public override IDataReader ApplicantPersonalDetailsListByPositionHire(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionHire", positionAppliedFor);
        }
        // list by position applied for and management approved
        public override IDataReader ApplicantPersonalDetailsListByPositionApprove(string positionAppliedFor)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsListByPositionApprove", positionAppliedFor);
        }
        public override IDataReader ApplicantManagementApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantManagementApprovedList");
        }
        public override IDataReader ApplicantPersonalDetailsAcceptanceAppList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsAcceptanceAppList");
        }

        
        public override IDataReader ApplicantPersonalDetailsGetByCountryTable(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByCountryTable", countryID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeeLevel(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeeLevel", levelID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeePositionTable(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeePositionTable", positionID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByEmployeeWorkLocations(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByEmployeeWorkLocations", workLocationID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByLGATable(int lgaID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByLGATable", lgaID);
        }

        public override IDataReader ApplicantPersonalDetailsGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsGetByStateTable", stateID);
        }

        public override int ApplicantPersonalDetailsAdd(string applicantNum, string DeptAppliedTo, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, string interviwerDecision, string managementDecition, int senID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsAdd", GetNull(applicantNum), GetNull(DeptAppliedTo), GetNull(positionAppliedFor), GetNull(title), GetNull(firstName), GetNull(miiddleName), lastName, GetNull(gender), dateOfBirth, age, GetNull(maritalStatus), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), GetNull(lGA_FK), GetNull(homeTown), GetNull(phoneNo), GetNull(email), GetNull(contactAddress), GetNull(religion), GetNull(passport), GetNull(applicationStatus), GetNull(interviwerDecision), GetNull(managementDecition), GetNull(senID_FK)).ToString());
        }
        //public override int ApplicantPersonalDetailsAdd(string applicantNum, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK, string interviwerDecision, string managementDecition)
        //{
        //    return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsAdd", GetNull(applicantNum), GetNull(positionAppliedFor), GetNull(title), GetNull(firstName), GetNull(miiddleName), lastName, GetNull(gender), dateOfBirth, age, GetNull(maritalStatus), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), GetNull(lGA_FK), GetNull(homeTown), GetNull(phoneNo), GetNull(email), GetNull(contactAddress), GetNull(religion), GetNull(passport), GetNull(applicationStatus), GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(levelID_FK), GetNull(workLocationID_FK), GetNull(interviwerDecision), GetNull(managementDecition)).ToString());
        //}

        public override void ApplicantPersonalDetailsUpdate(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK, string interviwerDecision, string managementDecition)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdate", applicantID, GetNull(applicantNum), GetNull(positionAppliedFor), GetNull(title), GetNull(firstName), GetNull(miiddleName), lastName, GetNull(gender), dateOfBirth, age, GetNull(maritalStatus), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), GetNull(lGA_FK), GetNull(homeTown), GetNull(phoneNo), GetNull(email), GetNull(contactAddress), GetNull(religion), GetNull(passport), GetNull(applicationStatus), GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(levelID_FK), GetNull(workLocationID_FK), GetNull(interviwerDecision), GetNull(managementDecition));
        }        
        public override void ApplicantPersonalDetailsUpdateApplicantNum(int applicantID, string applicantNum)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateApplicantNum", applicantID, GetNull(applicantNum));
        }
        public override void ApplicantPersonalDetailsUpdateUpdateUsingApplicantNum(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK, string resumptionDate, string interviwerDecision, string managementDecition)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateUpdateUsingApplicantNum", applicantID, GetNull(applicantNum), GetNull(positionAppliedFor), GetNull(title), GetNull(firstName), GetNull(miiddleName), lastName, GetNull(gender), dateOfBirth, age, GetNull(maritalStatus), GetNull(nationality_FK), GetNull(stateOfOrigin_FK), GetNull(lGA_FK), GetNull(homeTown), GetNull(phoneNo), GetNull(email), GetNull(contactAddress), GetNull(religion), GetNull(passport), GetNull(applicationStatus), GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(levelID_FK), GetNull(workLocationID_FK), GetNull(resumptionDate), GetNull(interviwerDecision), GetNull(managementDecition));
        }

        // this method update applicationStatus
        public override void ApplicantPersonalDetailsUpdateApplicationStatus(int applicantID, string applicationStatus)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateApplicationStatus", applicantID, GetNull(applicationStatus));
        }

        //this method update interviewer decision

        public override void ApplicantPersonalDetailsUpdateInterviewerDecision(int applicantID, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string resumptionDate, string interviewerDecision)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateInterviewerDecision", applicantID, GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(workLocationID_FK), GetNull(levelID_FK), GetNull(resumptionDate), GetNull(interviewerDecision));
        }

        //this method update Management decision
        public override void ApplicantPersonalDetailsUpdateManagementDecision(int applicantID, string managementDecision)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsUpdateManagementDecision", applicantID, GetNull(managementDecision));
        }
        public override void ApplicantPersonalDetailsSendingOfferUpdate(int applicantID, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsSendingOfferUpdate", applicantID, GetNull(positionApproved_FK), GetNull(departmentID_FK), GetNull(levelID_FK), GetNull(workLocationID_FK));
        }

        public override void ApplicantPersonalDetailsDelete(int applicantID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantPersonalDetailsDelete", applicantID);
        }
        #endregion



        #region "ApplicantQualification Methods"
        public override IDataReader ApplicantQualificationGet(int qualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationGet", qualificationID);
        }

        public override IDataReader ApplicantQualificationList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationList");
        }

        //public override IDataReader EmployeeAppQualificationList()
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppQualificationList");
        //}

        public override IDataReader ApplicantQualificationGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantQualificationAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationAdd", institutionName, qualificationType, course, grade, startYear, endYear, GetNull(applicantID_FK)).ToString());
        }

        public override void ApplicantQualificationUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationUpdate", qualificationID, institutionName, qualificationType, course, grade, startYear, endYear, GetNull(applicantID_FK));
        }

        public override void ApplicantQualificationDelete(int qualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantQualificationDelete", qualificationID);
        }
        #endregion


        #region "ApplicantProfQualification Methods"
        public override IDataReader ApplicantProfQualificationGet(int profQualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationGet", profQualificationID);
        }

        public override IDataReader ApplicantProfQualificationList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationList");
        }

        public override IDataReader ApplicantProfQualificationGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantProfQualificationAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationAdd", certificationName, certificateNo, stage, certYear, GetNull(applicantID_FK)).ToString());
        }

        public override void ApplicantProfQualificationUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationUpdate", profQualificationID, certificationName, certificateNo, stage, certYear, GetNull(applicantID_FK));
        }

        public override void ApplicantProfQualificationDelete(int profQualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantProfQualificationDelete", profQualificationID);
        }
        #endregion



        #region "ApplicantWorkExperience Methods"
        public override IDataReader ApplicantWorkExperienceGet(int workExperienceID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceGet", workExperienceID);
        }

        public override IDataReader ApplicantWorkExperienceList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceList");
        }

        public override IDataReader ApplicantWorkExperienceGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantWorkExperienceAdd(string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceAdd", companyName, positionHeld, jobDescriprtion, salaryReceived, startYear, endYear, GetNull(applicantID_FK)).ToString());
        }

        public override void ApplicantWorkExperienceUpdate(int workExperienceID, string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceUpdate", workExperienceID, companyName, positionHeld, jobDescriprtion, salaryReceived, startYear, endYear, GetNull(applicantID_FK));
        }

        public override void ApplicantWorkExperienceDelete(int workExperienceID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantWorkExperienceDelete", workExperienceID);
        }
        #endregion


        #region "ApplicantDocument Methods"
        public override IDataReader ApplicantDocumentGet(int documentID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentGet", documentID);
        }

        public override IDataReader ApplicantDocumentList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentList");
        }

        public override IDataReader ApplicantDocumentGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentGetByApplicantPersonalDetails", applicantID);
        }

        public override int ApplicantDocumentAdd(string documentType, string documentPath, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentAdd", documentType, documentPath, GetNull(applicantID_FK)).ToString());
        }

        public override void ApplicantDocumentUpdate(int documentID, string documentType, string documentPath, int applicantID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentUpdate", documentID, documentType, documentPath, GetNull(applicantID_FK));
        }

        public override void ApplicantDocumentDelete(int documentID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantDocumentDelete", documentID);
        }
        #endregion


        #region "EmployeeDepartmentTable Methods"
        public override IDataReader EmployeeDepartmentTableGet(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableGet", deptID);
        }
        public override IDataReader EmployeeDepartmentTableGetAll()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableGetAll");
        }
        
        public override IDataReader EmployeeDepartmentTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableList");
        }

        public override int EmployeeDepartmentTableAdd(string deptName)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableAdd", GetNull(deptName)).ToString());
        }

        public override void EmployeeDepartmentTableUpdate(int deptID, string deptName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableUpdate", deptID, GetNull(deptName));
        }

        public override void EmployeeDepartmentTableDelete(int deptID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDepartmentTableDelete", deptID);
        }
        #endregion

        
        //EmployeePositionTable

        #region "EmployeePositionTable Methods"
        public override IDataReader EmployeePositionTableGet(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableGet", positionID);
        }

        public override IDataReader EmployeePositionTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableList");
        }

        public override IDataReader EmployeePositionTableGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableGetByEmployeeDepartmentTable", deptID);
        }

        public override int EmployeePositionTableAdd(string positionName, int deptID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableAdd", GetNull(positionName), deptID_FK).ToString());
        }

        public override void EmployeePositionTableUpdate(int positionID, string positionName, int deptID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableUpdate", positionID, GetNull(positionName), deptID_FK);
        }

        public override void EmployeePositionTableDelete(int positionID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePositionTableDelete", positionID);
        }
        #endregion


        //EmployeeLevel

        #region "EmployeeLevel Methods"
        public override IDataReader EmployeeLevelGet(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelGet", levelID);
        }

        public override IDataReader EmployeeLevelList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelList");
        }

        public override IDataReader EmployeeLevelGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader EmployeeLevelGetByEmployeePositionTable(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelGetByEmployeePositionTable", positionID);
        }

        public override int EmployeeLevelAdd(string levelName, string salary, string salaryDetails, int deptID_FK, int positionID_FK, string leaveEntitle, string employeeCadre)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelAdd", GetNull(levelName), GetNull(salary), GetNull(salaryDetails), GetNull(deptID_FK), GetNull(positionID_FK), GetNull(leaveEntitle), GetNull(employeeCadre)).ToString());
        }

        public override void EmployeeLevelUpdate(int levelID, string levelName, string salary, string salaryDetails, int deptID_FK, int positionID_FK, string leaveEntitle, string employeeCadre)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelUpdate", levelID, GetNull(levelName), GetNull(salary), GetNull(salaryDetails), GetNull(deptID_FK), GetNull(positionID_FK), GetNull(leaveEntitle), GetNull(employeeCadre));
        }

        public override void EmployeeLevelDelete(int levelID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLevelDelete", levelID);
        }
        #endregion


        //EmployeeWorkLocations

        #region "EmployeeWorkLocations Methods"
        public override IDataReader EmployeeWorkLocationsGet(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationsGet", workLocationID);
        }

        public override IDataReader EmployeeWorkLocationsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationsList");
        }

        public override int EmployeeWorkLocationsAdd(string locationName, string locationAddress)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationsAdd", GetNull(locationName), GetNull(locationAddress)).ToString());
        }

        public override void EmployeeWorkLocationsUpdate(int workLocationID, string locationName, string locationAddress)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationsUpdate", workLocationID, GetNull(locationName), GetNull(locationAddress));
        }

        public override void EmployeeWorkLocationsDelete(int workLocationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeWorkLocationsDelete", workLocationID);
        }
        #endregion


        //ApplicantInterview

        #region "ApplicantInterview Methods"
        public override IDataReader ApplicantInterviewGet(int interviewID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantInterviewGet", interviewID);
        }

        public override IDataReader ApplicantInterviewList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantInterviewList");
        }

        public override IDataReader InterviewApprovedApplicantList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "InterviewApprovedApplicantList");
     }
        public override IDataReader ApplicantInterviewGetByApplicantRatingKey(int ratingKeyID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantInterviewGetByApplicantRatingKey", ratingKeyID);
        }

        public override int ApplicantInterviewAdd(string interviewer, string interviewDate, int applicantID_FK, string applicantNum, int experience, int education, int positionInterest, int presentation, int problemSolvingSkill, int computerSkill, int jobStability, int otherCriteria, int knowledgeLevel, int positionExcitement, int experienceLevel, int effectiveParticipation, int communicationLevel, int finalListInclusion, string strength, string weakness, string additionalComment, string recommendation, string hODName, string hODRecommendation, string managementRecommendation, int ratingKeyID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantInterviewAdd", GetNull(interviewer), GetNull(interviewDate), GetNull(applicantID_FK), GetNull(applicantNum), GetNull(experience), GetNull(education), GetNull(positionInterest), GetNull(presentation), GetNull(problemSolvingSkill), GetNull(computerSkill), GetNull(jobStability), GetNull(otherCriteria), GetNull(knowledgeLevel), GetNull(positionExcitement), GetNull(experienceLevel), GetNull(effectiveParticipation), GetNull(communicationLevel), GetNull(finalListInclusion), GetNull(strength), GetNull(weakness), GetNull(additionalComment), GetNull(recommendation), GetNull(hODName), GetNull(hODRecommendation), GetNull(managementRecommendation), GetNull(ratingKeyID_FK)).ToString());
        }

        public override void ApplicantInterviewUpdate(int interviewID, string interviewer, string interviewDate, int applicantID_FK, string applicantNum, int experience, int education, int positionInterest, int presentation, int problemSolvingSkill, int computerSkill, int jobStability, int otherCriteria, int knowledgeLevel, int positionExcitement, int experienceLevel, int effectiveParticipation, int communicationLevel, int finalListInclusion, string strength, string weakness, string additionalComment, string recommendation, string hODName, string hODRecommendation, string managementRecommendation, int ratingKeyID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantInterviewUpdate", interviewID, GetNull(interviewer), GetNull(interviewDate), GetNull(applicantID_FK), GetNull(applicantNum), GetNull(experience), GetNull(education), GetNull(positionInterest), GetNull(presentation), GetNull(problemSolvingSkill), GetNull(computerSkill), GetNull(jobStability), GetNull(otherCriteria), GetNull(knowledgeLevel), GetNull(positionExcitement), GetNull(experienceLevel), GetNull(effectiveParticipation), GetNull(communicationLevel), GetNull(finalListInclusion), GetNull(strength), GetNull(weakness), GetNull(additionalComment), GetNull(recommendation), GetNull(hODName), GetNull(hODRecommendation), GetNull(managementRecommendation), GetNull(ratingKeyID_FK));
        }

        public override void ApplicantInterviewDelete(int interviewID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "ApplicantInterviewDelete", interviewID);
        }
        #endregion

        //EmployeeDetails

        #region "EmployeeDetails Methods"
        public override IDataReader EmployeeDetailsGet(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGet", employeeID);
        }
        public override IDataReader EmployeeDetailsGetByEmployeeLevelForLeave(int employeeLevel_FK)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeLevelForLeave", employeeLevel_FK);
        }

        //Printing Employee List

        public override IDataReader EmployeeDetailsList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsList");
        }
        public override IDataReader EmployeeDetailsListOrderByDeptAndLocation()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsListOrderByDeptAndLocation");
        }
        public override IDataReader EmployeeDetailsListByDeptAndLocation(int deptID, int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsListByDeptAndLocation",  deptID, workLocationID);
        }
       
        public override IDataReader EmployeeDetailsSupAppraisalList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsSupAppraisalList");
        }
        public override IDataReader EmployeeDetailsHRAppraisalList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsHRAppraisalList");
        }
        public override IDataReader EmployeeDetailsHiredList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsHiredList");
        }
        public override IDataReader EmployeeDetailsUnconfirmedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUnconfirmedList");
        }
        public override IDataReader EmployeeDetailsConfirmedEmployeeList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsConfirmedEmployeeList");
        }
        public override IDataReader EmployeeDetailsQualifUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsQualifUnApprovedList");
        }
        public override IDataReader EmployeeDetailsProfQualifUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsProfQualifUnApprovedList");
        }
        public override IDataReader EmployeeDetailsDocUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsDocUnApprovedList");
        }
        public override IDataReader EmployeeDetailsSupEmpList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsSupEmpList");
        }


        public override IDataReader EmployeeDetailsPromotionList(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsPromotionList", deptID);
        }
        public override IDataReader EmployeeDetailsSelfAppraisalList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsSelfAppraisalList");
        }

        public override IDataReader EmployeeDetailsGetBySupervisor(int supervisorID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetBySupervisor", supervisorID);
        }
         public override IDataReader EmployeeDetailsGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByApplicantPersonalDetails", applicantID);
        }


        public override IDataReader EmployeeDetailsGetByCountryTable(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByCountryTable", countryID);
        }

        public override IDataReader EmployeeDetailsGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeDepartmentTable", deptID);
        }
        public override IDataReader EmployeeDetailsGetByEmployeeDepartmentTableForPromoHist(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeDepartmentTableForPromoHist", deptID);
        }
        public override IDataReader EmployeeDetailsGetByEmpDeptAndLocation(int deptID, int workLocation)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmpDeptAndLocation", deptID, workLocation);
        }
        
        public override IDataReader EmployeeDetailsGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeDetails", employeeID);
        }
		
        public override IDataReader EmployeeDetailsGetByEmployeeLevel(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeLevel", levelID);
        }

        public override IDataReader EmployeeDetailsGetByEmployeePositionTable(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeePositionTable", positionID);
        }

        public override IDataReader EmployeeDetailsGetByEmployeeWorkLocations(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeWorkLocations", workLocationID);
        }

        public override IDataReader EmployeeDetailsGetByLGATable(int lgaID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByLGATable", lgaID);
        }

        public override IDataReader EmployeeDetailsGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByStateTable", stateID);
        }
        
        public override IDataReader EmployeeDetailsGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByUsers", userID);
        }

        public override IDataReader EmployeeDetailsGetByUserID(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByUserID", userID);
        }


        public override int EmployeeDetailsAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int hRID, int senID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsAdd", GetNull(employeeNum), GetNull(title), firstName, GetNull(miiddleName), lastName, gender, dateOfBirth, age, GetNull(maritalStatus), nationality_FK, stateOfOrigin_FK, lGA_FK, homeTown, phoneNo, email, contactAddress, GetNull(religion), passport, GetNull(accountName), GetNull(accountNo), GetNull(bankName), GetNull(department_FK), GetNull(positionHeld_FK), GetNull(employeeLevel_FK), GetNull(workLocation_FK), GetNull(confirmationDate), GetNull(confirmedBy), GetNull(employeeStatus), GetNull(startDate), GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship), GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(applicantID_FK), GetNull(hRID), GetNull(senID_FK)).ToString());
        }
        
        public override void EmployeeDetailsUpdate(int employeeID, string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdate", employeeID, GetNull(employeeNum), GetNull(title), firstName, GetNull(miiddleName), lastName, gender, dateOfBirth, age, GetNull(maritalStatus), nationality_FK, stateOfOrigin_FK, lGA_FK, homeTown, phoneNo, email, contactAddress, GetNull(religion), passport, GetNull(accountName), GetNull(accountNo), GetNull(bankName), GetNull(department_FK), GetNull(positionHeld_FK), GetNull(employeeLevel_FK), GetNull(workLocation_FK), GetNull(confirmationDate), GetNull(confirmedBy), GetNull(employeeStatus), GetNull(startDate), GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship), GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(applicantID_FK), GetNull(employeeUserID_FK));
        }
        public override void EmployeeDetailsEditBasicInfoUpdate(int employeeID, string title, string firstName, string miiddleName, string lastName, string maritalStatus, string phoneNo, string email, string contactAddress, string religion,  string accountName, string accountNo, string bankName)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsEditBasicInfoUpdate", employeeID, GetNull(title), firstName, GetNull(miiddleName), lastName, GetNull(maritalStatus), phoneNo, email, contactAddress, GetNull(religion), GetNull(accountName), GetNull(accountNo), GetNull(bankName));
        }
        
        public override void EmployeeDetailsUpdateEmployeeNum(int employeeID, string employeeNum)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateEmployeeNum", employeeID, GetNull(employeeNum));
        }
        public override void EmployeeDetailsUpdateEmployeeUserID(int employeeID, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateEmployeeUserID", employeeID, GetNull(employeeUserID_FK));
        }
        public override void EmployeeDetailsNextOfKinUpdate( int employeeID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsNextOfKinUpdate", employeeID, GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship),  GetNull(employeeUserID_FK));
        }
        public override void EmployeeDetailsEditNOKUpdate(int employeeID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsEditNOKUpdate", employeeID, GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship));
        }
        

        public override void EmployeeDetailsSpouseUpdate(int employeeID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames,int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsSpouseUpdate", employeeID, GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo),  GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames),  GetNull(employeeUserID_FK));
        }
        public override void EmployeeDetailsEditSpouseDetailsUpdate(int employeeID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsEditSpouseDetailsUpdate", employeeID, GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo),  GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames));
        }
        
        public override void EmployeeDetailsRefereeUpdate(int employeeID, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsRefereeUpdate", employeeID, GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsBankInfoUpdate(int employeeID, string bankName, string accountName, string accountNo, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsBankInfoUpdate", employeeID, GetNull(bankName), GetNull(accountName), GetNull(accountNo), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsGuarantorUpdate(int employeeID, string guarrantorNames, string guarrantorFormPath, int employeeUserID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGuarantorUpdate", employeeID, GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(employeeUserID_FK));
        }

        public override void EmployeeDetailsUpdateConfirmation(int employeeID, string confirmationDate, int confirmedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateConfirmation", employeeID, GetNull(confirmationDate), GetNull(confirmedBy));
        }
        public override void EmployeeDetailsTransferUpdate(int employeeID, int department_FK, int workLocation_FK, string transferDate, int transferedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsTransferUpdate", employeeID, GetNull(department_FK), GetNull(workLocation_FK), GetNull(transferDate), GetNull(transferedBy)); 
              
        }
        public override void EmployeeDetailsPromoUpdate(int employeeID, int employeeLevel_FK, int positionHeld_FK, string promotionDate, int promotedBy, string employeeStatus)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsPromoUpdate", employeeID, GetNull(employeeLevel_FK), GetNull(positionHeld_FK), GetNull(promotionDate), GetNull(promotedBy), GetNull(employeeStatus)); 
              
        }
        public override void EmployeeDetailsUpdateEmpHOD(int employeeID, int hODID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateEmpHOD", employeeID, GetNull(hODID)); 
              
        }
          public override void EmployeeDetailsUpdateHODNewPositionAsHOD(int employeeID, int positionHeld_FK, int hODID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateHODNewPositionAsHOD", employeeID, GetNull(positionHeld_FK), GetNull(hODID)); 
              
        }
          public override void EmployeeDetailsUpdateEmpSupervisor(int employeeID, int supervisor)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsUpdateEmpSupervisor", employeeID, GetNull(supervisor)); 
              
        }
        
        public override void EmployeeDetailsDelete(int employeeID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsDelete", employeeID);
        }
        #endregion

        //EmployeeDetailsLog

        #region "EmployeeDetailsLog Methods"
        public override IDataReader EmployeeDetailsLogGet(int employeeLogID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGet", employeeLogID);
        }
        public override IDataReader EmployeeDetailsLogGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByEmployeeDetails", employeeID);
        }
        
        public override IDataReader EmployeeDetailsLogList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogList");
        }
        

        public override IDataReader EmployeeDetailsLogGetBySupervisor(int supervisorID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetBySupervisor", supervisorID);
        }
      


        public override IDataReader EmployeeDetailsLogGetByCountryTable(int countryID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByCountryTable", countryID);
        }

       public override IDataReader EmployeeDetailsLogGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByEmployeeDepartmentTable", deptID);
        }
       

        public override IDataReader EmployeeDetailsLogGetByEmployeeDetailsLog(int employeeLogID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsGetByEmployeeDetails", employeeLogID);
        }

        public override IDataReader EmployeeDetailsLogGetByEmployeeLevel(int levelID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByEmployeeLevel", levelID);
        }

        public override IDataReader EmployeeDetailsLogGetByEmployeePositionTable(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByEmployeePositionTable", positionID);
        }

        public override IDataReader EmployeeDetailsLogGetByEmployeeWorkLocations(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByEmployeeWorkLocations", workLocationID);
        }

        public override IDataReader EmployeeDetailsLogGetByLGATable(int lgaID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByLGATable", lgaID);
        }

        public override IDataReader EmployeeDetailsLogGetByStateTable(int stateID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByStateTable", stateID);
        }

        public override IDataReader EmployeeDetailsLogGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByUsers", userID);
        }

        public override IDataReader EmployeeDetailsLogGetByUserID(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGetByUserID", userID);
        }
        public override int EmployeeDetailsLogAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string startDate, int applicantID_FK, int employeeUserID_FK, int employeeID_FK, int hRID, int senID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogAdd", GetNull(employeeNum), GetNull(title), firstName, GetNull(miiddleName), lastName, gender, dateOfBirth, age, GetNull(maritalStatus), nationality_FK, stateOfOrigin_FK, lGA_FK, homeTown, phoneNo, email, contactAddress, GetNull(religion), passport, GetNull(department_FK), GetNull(positionHeld_FK), GetNull(employeeLevel_FK), GetNull(workLocation_FK),   GetNull(startDate),  GetNull(applicantID_FK), GetNull(employeeUserID_FK), GetNull(employeeID_FK), GetNull(hRID), GetNull(senID_FK)).ToString());
        }
      
        public override void EmployeeDetailsLogUpdate(int employeeLogID, string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogUpdate", employeeLogID, GetNull(employeeNum), GetNull(title), firstName, GetNull(miiddleName), lastName, gender, dateOfBirth, age, GetNull(maritalStatus), nationality_FK, stateOfOrigin_FK, lGA_FK, homeTown, phoneNo, email, contactAddress, GetNull(religion), passport, GetNull(accountName), GetNull(accountNo), GetNull(bankName), GetNull(department_FK), GetNull(positionHeld_FK), GetNull(employeeLevel_FK), GetNull(workLocation_FK), GetNull(confirmationDate), GetNull(confirmedBy), GetNull(employeeStatus), GetNull(startDate), GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship), GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(applicantID_FK), GetNull(employeeUserID_FK), GetNull(employeeID_FK));
        }
        public override void EmployeeDetailsLogEditBasicInfoUpdate(int employeeLogID, string title, string firstName, string miiddleName, string lastName, string maritalStatus, string phoneNo, string email, string contactAddress, string religion, string accountName, string accountNo, string bankName, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogEditBasicInfoUpdate", employeeLogID, GetNull(title), firstName, GetNull(miiddleName), lastName, GetNull(maritalStatus), phoneNo, email, contactAddress, GetNull(religion), GetNull(accountName), GetNull(accountNo), GetNull(bankName), GetNull(employeeID_FK));
        }

        public override void EmployeeDetailsLogUpdateEmployeeNum(int employeeLogID, string employeeNum, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogUpdateEmployeeNum", employeeLogID, GetNull(employeeNum), GetNull(employeeID_FK));
        }
        public override void EmployeeDetailsLogUpdateEmployeeUserID(int employeeLogID, int employeeUserID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogUpdateEmployeeUserID", employeeLogID, GetNull(employeeUserID_FK), GetNull(employeeID_FK));
        }
        public override void EmployeeDetailsLogNextOfKinUpdate(int employeeLogID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeUserID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogNextOfKinUpdate", employeeLogID, GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship), GetNull(employeeUserID_FK), GetNull(employeeID_FK));
        }
        public override void EmployeeDetailsLogEditNOKUpdate(int employeeLogID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogEditNOKUpdate", employeeLogID, GetNull(nxtOfKinFName), GetNull(nxtOfKinMidName), GetNull(nxtOfKinLName), GetNull(nxtOfKinAddress), GetNull(nxtOfKinPhoneNo), GetNull(nxtOfKinEmail), GetNull(nxtOfKinOccupation), GetNull(nxtOfKinRelationship));
        }


        public override void EmployeeDetailsLogSpouseUpdate(int employeeLogID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, int employeeUserID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogSpouseUpdate", employeeLogID, GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(employeeUserID_FK), GetNull(employeeID_FK));
        }
        public override void EmployeeDetailsLogEditSpouseDetailsUpdate(int employeeLogID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogEditSpouseDetailsUpdate", employeeLogID, GetNull(spouseNames), GetNull(spouseAddress), GetNull(spousePhoneNo), GetNull(spouseEmail), GetNull(spouseOccupation), GetNull(spouseEmployerNames), GetNull(employeeID_FK));
        }

        public override void EmployeeDetailsLogRefereeUpdate(int employeeLogID, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, int employeeUserID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogRefereeUpdate", employeeLogID, GetNull(refree1Names), GetNull(refree1Occupation), GetNull(refree1PhoneNum), GetNull(refree1Email), GetNull(refree1ContactAddr), GetNull(refree2Names), GetNull(refree2Occupation), GetNull(refree2PhoneNum), GetNull(refree2Email), GetNull(refree2ContactAddr), GetNull(employeeUserID_FK), GetNull(employeeID_FK));
        }

        public override void EmployeeDetailsLogBankInfoUpdate(int employeeLogID, string bankName, string accountName, string accountNo, int employeeUserID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogBankInfoUpdate", employeeLogID, GetNull(bankName), GetNull(accountName), GetNull(accountNo), GetNull(employeeUserID_FK), GetNull(employeeID_FK));
        }

        public override void EmployeeDetailsLogGuarantorUpdate(int employeeLogID, string guarrantorNames, string guarrantorFormPath, int employeeUserID_FK, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogGuarantorUpdate", employeeLogID, GetNull(guarrantorNames), GetNull(guarrantorFormPath), GetNull(employeeUserID_FK), GetNull(employeeID_FK));
        }

        public override void EmployeeDetailsLogUpdateConfirmation(int employeeLogID, string confirmationDate, int confirmedBy, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogUpdateConfirmation", employeeLogID, GetNull(confirmationDate), GetNull(confirmedBy), GetNull(employeeID_FK));
        }
        public override void EmployeeDetailsLogTransferUpdate(int employeeLogID, int department_FK, int workLocation_FK, string transferDate, int transferedBy, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogTransferUpdate", employeeLogID, GetNull(department_FK), GetNull(workLocation_FK), GetNull(transferDate), GetNull(transferedBy), GetNull(employeeID_FK));

        }
        public override void EmployeeDetailsLogPromoUpdate(int employeeLogID, int employeeLevel_FK, int positionHeld_FK, string promotionDate, int promotedBy, string employeeStatus, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogPromoUpdate", employeeLogID, GetNull(employeeLevel_FK), GetNull(positionHeld_FK), GetNull(promotionDate), GetNull(promotedBy), GetNull(employeeStatus), GetNull(employeeID_FK));

        }
        public override void EmployeeDetailsLogUpdateEmpHOD(int employeeLogID, int hODID, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogUpdateEmpHOD", employeeLogID, GetNull(hODID), GetNull(employeeID_FK));

        }
        public override void EmployeeDetailsLogUpdateHODNewPositionAsHOD(int employeeLogID, int positionHeld_FK, int hODID, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogUpdateHODNewPositionAsHOD", employeeLogID, GetNull(positionHeld_FK), GetNull(hODID), GetNull(employeeID_FK));

        }
        public override void EmployeeDetailsLogUpdateEmpSupervisor(int employeeLogID, int supervisor, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogUpdateEmpSupervisor", employeeLogID, GetNull(supervisor), GetNull(employeeID_FK));

        }

        public override void EmployeeDetailsLogDelete(int employeeLogID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDetailsLogDelete", employeeLogID);
        }
        #endregion


        //EmployeeQualificationTable 

        #region "EmployeeQualificationTable Methods"
        public override IDataReader EmployeeQualificationTableGet(int qualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableGet", qualificationID);
        }
        public override IDataReader EmployeeQualificationTableGetByEmployeeDetailsForInfo(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableGetByEmployeeDetailsForInfo", employeeID);
        }
        
        public override IDataReader EmployeeQualificationTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableList");
        }
        public override IDataReader EmployeeQualificationTableUnApprovedList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableUnApprovedList");
        }
        
        public override IDataReader EmployeeQualificationTableGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableGetByApplicantPersonalDetails", applicantID);
        }

        public override IDataReader EmployeeQualificationTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeQualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationUnApprovedGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeQualificationTableApprovedQualifGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableApprovedQualifGetByEmployeeDetails", employeeID);
        }
        public override int EmployeeQualificationTableAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableAdd", GetNull(institutionName), GetNull(qualificationType), GetNull(course), GetNull(grade), GetNull(startYear), GetNull(endYear), GetNull(applicantID_FK)).ToString());
        }
        public override int EmployeeQualificationTableNewAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableNewAdd", GetNull(institutionName), GetNull(qualificationType), GetNull(course), GetNull(grade), GetNull(startYear), GetNull(endYear), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK)).ToString());
        }

        public override void EmployeeQualificationTableUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableUpdate", qualificationID, GetNull(institutionName), GetNull(qualificationType), GetNull(course), GetNull(grade), GetNull(startYear), GetNull(endYear), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK));
        }
        public override void EmployeeQualificationTableEmpIDUpdate(string hrApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableEmpIDUpdate", GetNull(hrApproval), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK));
        }
        public override void EmployeeQualificationTableHrApprovalUpdate( int employeeID_FK, string hrApproval)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableHrApprovalUpdate", GetNull(employeeID_FK), GetNull(hrApproval));
        }
        public override void EmployeeQualificationTableAcceptanceApprovalUpdate(int qualificationID, string hrApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableAcceptanceApprovalUpdate",qualificationID, GetNull(hrApproval), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK));
        }
        
        public override void EmployeeQualificationTableDelete(int qualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQualificationTableDelete", qualificationID);
        }
        #endregion


        //EmployeeProfQualificationTable

        #region "EmployeeProfQualificationTable Methods"
        public override IDataReader EmployeeProfQualificationTableGet(int profQualificationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGet", profQualificationID);
        }
        public override IDataReader EmployeeProfQualificationTableGetByEmployeeDetailsForInfo(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGetByEmployeeDetailsForInfo", employeeID);
        }
        
        public override IDataReader EmployeeProfQualificationTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableList");
        }
                
        public override IDataReader EmployeeProfQualificationTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails", employeeID);
        }
        
        public override IDataReader EmployeeProfQualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationUnApprovedGetByEmployeeDetails", employeeID);
        }
        
        public override IDataReader EmployeeProfQualificationTableGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableGetByApplicantPersonalDetails", applicantID);
        }

        public override int EmployeeProfQualificationTableAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableAdd", GetNull(certificationName), GetNull(certificateNo), GetNull(stage), GetNull(certYear), GetNull(applicantID_FK)).ToString());
        }
        public override int EmployeeProfQualificationTableNewAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableNewAdd", GetNull(certificationName), GetNull(certificateNo), GetNull(stage), GetNull(certYear), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK)).ToString());
        }

        public override void EmployeeProfQualificationTableUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableUpdate", profQualificationID, GetNull(certificationName), GetNull(certificateNo), GetNull(stage), GetNull(certYear), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK));
        }

        public override void EmployeeProfQualificationTableEmpIDUpdate(string hrApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableEmpIDUpdate", GetNull(hrApproval), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK));
        }
        public override void EmployeeProfQualificationTableHrApprovalUpdate(int employeeID_FK, string hrApproval)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableHrApprovalUpdate",  GetNull(employeeID_FK), GetNull(hrApproval));
        }
        public override void EmployeeProfQualificationTableAcceptanceApprovalUpdate(int profQualificationID, string hrApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableAcceptanceApprovalUpdate", profQualificationID, GetNull(hrApproval), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK));
        }
        
        public override void EmployeeProfQualificationTableDelete(int profQualificationID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeProfQualificationTableDelete", profQualificationID);
        }
        #endregion


        //EmployeeDepartmentTable

        #region "EmployeeDocumentTable Methods"
        public override IDataReader EmployeeDocumentTableGet(int documentID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableGet", documentID);
        }
        public override IDataReader EmployeeDocumentTableGetByEmployeeDetailsForInfo(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableGetByEmployeeDetailsForInfo", employeeID);
        }

        public override IDataReader EmployeeDocumentTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableList");
        }
      
        public override IDataReader EmployeeDocumentTableGetByApplicantPersonalDetails(int applicantID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableGetByApplicantPersonalDetails", applicantID);
        }

        public override IDataReader EmployeeDocumentTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeDocumentTableApprovedDocGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableApprovedDocGetByEmployeeDetails", employeeID);
        }
        
        public override IDataReader EmployeeDocumentUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentUnApprovedGetByEmployeeDetails", employeeID);
        }
        

        public override int EmployeeDocumentTableAdd(string documentType, string documentPath, int applicantID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableAdd", GetNull(documentType), GetNull(documentPath), GetNull(applicantID_FK)).ToString());
        }
        public override int EmployeeDocumentTableNewAdd(string documentType, string documentPath, int applicantID_FK, int employeeID_FK, int employeeLogID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableNewAdd", GetNull(documentType), GetNull(documentPath), GetNull(applicantID_FK), GetNull(employeeID_FK), GetNull(employeeLogID_FK)).ToString());
        }

        public override void EmployeeDocumentTableUpdate(int documentID, string documentType, string documentPath, int applicantID_FK, int employeeID_Fk, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableUpdate", documentID, GetNull(documentType), GetNull(documentPath), GetNull(applicantID_FK), GetNull(employeeID_Fk), GetNull(employeeLogID_FK));
        }
        public override void EmployeeDocumentTableEmpIDUpdate(string hrApproval, int applicantID_FK, int employeeID_Fk, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableEmpIDUpdate", GetNull(hrApproval), GetNull(applicantID_FK), GetNull(employeeID_Fk), GetNull(employeeLogID_FK));
        }
          public override void EmployeeDocumentTableHrApprovalUpdate(int employeeID_Fk, string hrApproval)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableHrApprovalUpdate", GetNull(employeeID_Fk), GetNull(hrApproval));
        }
          public override void EmployeeDocumentTableAcceptanceApprovalUpdate(int documentID, string hRApproval, int applicantID_FK, int employeeID_Fk, int employeeLogID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableAcceptanceApprovalUpdate", documentID, GetNull(hRApproval), GetNull(applicantID_FK), GetNull(employeeID_Fk), GetNull(employeeLogID_FK));
        }
        public override void EmployeeDocumentTableDelete(int documentID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDocumentTableDelete", documentID);
        }
        #endregion


        //EmployeeTrainingTable

        #region "EmployeeTrainingTable Methods"
        public override IDataReader EmployeeTrainingTableGet(int trainingID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableGet", trainingID);
        }

        public override IDataReader EmployeeTrainingTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableList");
        }
        public override IDataReader EmployeeTrainingTableHRAprovalList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableHRAprovalList");
        }
        
        //public override IDataReader EmployeeTrainingTableHRTrainingApprovalList()
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableHRTrainingApprovalList");
        //}
        
        public override IDataReader EmployeeTrainingTableGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableGetByEmployeeDepartmentTable", deptID);
        }
        public override IDataReader EmployeeTrainingTableHRAprovalGetByEmployeeDeptTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableHRAprovalGetByEmployeeDeptTable", deptID);
        }
                
        public override IDataReader EmployeeTrainingTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeTrainingTableGetByEmployeePositionTable(int positionID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableGetByEmployeePositionTable", positionID);
        }

        public override int EmployeeTrainingTableAdd(string trainingName, string trainingLocation, string startDate, string endDate, int departmentID_FK, int positionID_FK, int employeeID_FK, int trainingSentBy, string trainingStatus, int trainingApprovedBy)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableAdd", GetNull(trainingName), GetNull(trainingLocation), GetNull(startDate), GetNull(endDate), GetNull(departmentID_FK), GetNull(positionID_FK), GetNull(employeeID_FK), GetNull(trainingSentBy), GetNull(trainingStatus), GetNull(trainingApprovedBy)).ToString());
        }

        public override void EmployeeTrainingTableUpdate(int trainingID, string trainingName, string trainingLocation, string startDate, string endDate, int departmentID_FK, int positionID_FK, int employeeID_FK, int trainingSentBy, string trainingStatus, int trainingApprovedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableUpdate", trainingID, GetNull(trainingName), GetNull(trainingLocation), GetNull(startDate), GetNull(endDate), GetNull(departmentID_FK), GetNull(positionID_FK), GetNull(employeeID_FK), GetNull(trainingSentBy), GetNull(trainingStatus), GetNull(trainingApprovedBy));
        }
        public override void EmployeeTrainingTableHRApprovalUpdate(int trainingID, string trainingStatus, int trainingApprovedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableHRApprovalUpdate", trainingID, GetNull(trainingStatus), GetNull(trainingApprovedBy));
        }
        
        public override void EmployeeTrainingTableDelete(int trainingID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTrainingTableDelete", trainingID);
        }
        #endregion


        //EmployeeTransferTable

        #region "EmployeeTransferTable Methods"
        public override IDataReader EmployeeTransferTableGet(int transferID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGet", transferID);
        }
        public override IDataReader EmployeeTransferTableGetByEmployeeDetailsForInfo(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByEmployeeDetailsForInfo", employeeID);
        }
        
        public override IDataReader EmployeeTransferTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableList");
        }
        public override IDataReader EmployeeTransferTableNewList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableNewList");
        }

        public override IDataReader EmployeeTransferTableApprovalNameList(int PrevWorkLocation, int DesireLocation)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableApprovalNameList", PrevWorkLocation, DesireLocation);
        }

        public override IDataReader EmployeeTransferTableApprovalNameNewList(int PreviousDept, int PrevWorkLocation, int DesireLocation)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableApprovalNameNewList", PreviousDept,  PrevWorkLocation, DesireLocation);
        }
        //public override IDataReader EmployeeTransferTableApprovalNameNewList(int newDept, int PrevWorkLocation, int DesireLocation)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableApprovalNameNewList",  newDept, PrevWorkLocation, DesireLocation);
        //}
        
        public override IDataReader EmployeeTransferTableNewApprovalList(int PreviousDept, int PrevWorkLocation, int DesireLocation)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableNewApprovalList", PreviousDept, PrevWorkLocation, DesireLocation);
        }
        public override IDataReader EmployeeTransferTableApprovalList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableApprovalList");
        }
        
        public override IDataReader EmployeeTransferTableGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader EmployeeTransferTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeTransferTableGetByEmployeeWorkLocations(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByEmployeeWorkLocations", workLocationID);
        }

        public override IDataReader EmployeeTransferTableGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableGetByUsers", userID);
        }

        public override int EmployeeTransferTableAdd(int previousDept, int newDept, int prevWorkLocation,int desireLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableAdd", GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation),GetNull(desireLocation), GetNull(newWorkLcation), GetNull(transferType), GetNull(transferReason), GetNull(requestDate), GetNull(approvalStatus), GetNull(approveDate), GetNull(transferDate), GetNull(employeeID_FK), GetNull(transferedBy)).ToString());
        }
        public override int EmployeeTransferTableRequestAdd(int previousDept, int newDept, int prevWorkLocation, int desireLocation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableRequestAdd", GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(desireLocation), GetNull(transferType), GetNull(transferReason), GetNull(requestDate), GetNull(approvalStatus), GetNull(approveDate), GetNull(transferDate), GetNull(employeeID_FK)).ToString());
        }
        
        public override void EmployeeTransferTableUpdate(int transferID, int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableUpdate", transferID, GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(newWorkLcation), GetNull(transferType), GetNull(transferReason), GetNull(requestDate), GetNull(approvalStatus), GetNull(approveDate), GetNull(transferDate), GetNull(employeeID_FK), GetNull(transferedBy));
        }
        public override void EmployeeTransferTableUpdateTransferRequest(int transferID, int previousDept, int newDept, int prevWorkLocation, int desireLocation, string transferType, string transferReason, string requestDate, int employeeID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableUpdateTransferRequest", transferID, GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(desireLocation), GetNull(transferType), GetNull(transferReason), GetNull(requestDate), GetNull(employeeID_FK));
        }
        
        public override void EmployeeTransferTableApprovalUpdate(int transferID,  int newDept, int newWorkLcation, string approvalStatus, string approveDate, string transferDate, int transferedBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableApprovalUpdate", transferID,  GetNull(newDept),  GetNull(newWorkLcation),  GetNull(approvalStatus), GetNull(approveDate), GetNull(transferDate), GetNull(transferedBy));
        }
        
        public override void EmployeeTransferTableDelete(int transferID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableDelete", transferID);
        }
        #endregion

    

        //EmployeeTransferTableLog

        #region "EmployeeTransferTableLog Methods"
        public override IDataReader EmployeeTransferTableLogGet(int transferLogID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogGet", transferLogID);
        }
          public override IDataReader EmployeeTransferTableLogGetByEmployeeTransferTableForInfo(int transferID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogGetByEmployeeTransferTableForInfo", transferID);
        }
          public override IDataReader EmployeeTransferTableLogListEmployeeTransferRecords(int employeeID_FK, int PreviousDept, int NewDept, int PrevWorkLocation, int DesireLocation, int NewWorkLcation)
          {
              return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogListEmployeeTransferRecords", employeeID_FK, PreviousDept, NewDept, PrevWorkLocation, DesireLocation, NewWorkLcation);
          }
        public override IDataReader EmployeeTransferTableLogList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogList");
        }
        public override IDataReader EmployeeTransferTableLogListByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogListByEmployeeDetails", employeeID);
        }
        
      
        //public override IDataReader EmployeeTransferTableLogApprovalNameList(int PrevWorkLocation, int DesireLocation)
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogApprovalNameList", PrevWorkLocation, DesireLocation);
        //}
        ////public override IDataReader EmployeeTransferTableApprovalNameList(int PreviousDept, int NewDept, int PrevWorkLocation, int DesireLocation, int NewWorkLcation)
        ////{
        ////    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableApprovalNameList", PreviousDept, NewDept, PrevWorkLocation, DesireLocation, NewWorkLcation);
        ////}
        //public override IDataReader EmployeeTransferTableLogApprovalList()
        //{
        //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogApprovalList");
        //}
        public override IDataReader EmployeeTransferTableLogGetByEmployeeDepartmentTable(int deptID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogGetByEmployeeDepartmentTable", deptID);
        }

        public override IDataReader EmployeeTransferTableLogGetByEmployeeTransferTable(int transferID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogGetByEmployeeTransferTable", transferID);
        }
   
        public override IDataReader EmployeeTransferTableLogGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeTransferTableLogGetByEmployeeWorkLocations(int workLocationID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogGetByEmployeeWorkLocations", workLocationID);
        }

        public override IDataReader EmployeeTransferTableLogGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogGetByUsers", userID);
        }

        public override int EmployeeTransferTableLogAdd(int previousDept, int newDept, int prevWorkLocation, int desireLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy, int transferID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogAdd", GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(desireLocation), GetNull(newWorkLcation), GetNull(transferType), GetNull(transferReason), GetNull(requestDate), GetNull(approvalStatus), GetNull(approveDate), GetNull(transferDate), GetNull(employeeID_FK), GetNull(transferedBy), GetNull(transferID_FK)).ToString());
        }
        public override int EmployeeTransferTableLogRequestAdd(int previousDept, int newDept, int prevWorkLocation, int desireLocation, string transferType, string transferReason, string requestDate, int employeeID_FK, int transferID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogRequestAdd", GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(desireLocation), GetNull(transferType), GetNull(transferReason), GetNull(requestDate), GetNull(employeeID_FK), GetNull(transferID_FK)).ToString());
        }
        
        public override void EmployeeTransferTableLogUpdate(int transferLogID, int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy, int transferID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogUpdate", transferLogID, GetNull(previousDept), GetNull(newDept), GetNull(prevWorkLocation), GetNull(newWorkLcation), GetNull(transferType), GetNull(transferReason), GetNull(requestDate), GetNull(approvalStatus), GetNull(approveDate), GetNull(transferDate), GetNull(employeeID_FK), GetNull(transferedBy), GetNull(transferID_FK));
        }
        public override void EmployeeTransferTableLogApprovalUpdate(int transferLogID,  int newDept, int newWorkLcation, string approvalStatus, string approveDate, string transferDate, int transferedBy, int transferID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogApprovalUpdate", transferLogID, GetNull(newDept), GetNull(newWorkLcation),  GetNull(approvalStatus), GetNull(approveDate), GetNull(transferDate),  GetNull(transferedBy), GetNull(transferID_FK));
        }
        
        public override void EmployeeTransferTableLogDelete(int transferLogID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTransferTableLogDelete", transferLogID);
        }
        #endregion


      
        //Appraisal Module

        #region

        //EmployeeAppraisalTableRatingKey

        #region "EmployeeAppraisalTableRatingKey Methods"

        public override IDataReader EmployeeAppraisalTableRatingKeyGet(int ratingKeyID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableRatingKeyGet", ratingKeyID);
        }
        public override IDataReader EmployeeAppraisalTableRatingKeyGetByCompetent(int ratingKeyID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableRatingKeyGetByCompetent", ratingKeyID);
        }
        
        public override IDataReader EmployeeAppraisalTableRatingKeyList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableRatingKeyList");
        }

        public override int EmployeeAppraisalTableRatingKeyAdd(string ratingDesc, int ratingPoint)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableRatingKeyAdd", GetNull(ratingDesc), GetNull(ratingPoint)).ToString());
        }

        public override void EmployeeAppraisalTableRatingKeyUpdate(int ratingKeyID, string ratingDesc, int ratingPoint)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableRatingKeyUpdate", ratingKeyID, GetNull(ratingDesc), GetNull(ratingPoint));
        }

        public override void EmployeeAppraisalTableRatingKeyDelete(int ratingKeyID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableRatingKeyDelete", ratingKeyID);
        }
        #endregion



        //EmployeeAppraisalCompetencyTable

        #region "EmployeeAppraisalCompetencyTable Methods"

        public override IDataReader EmployeeAppraisalCompetencyTableGet(int competencyID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableGet", competencyID);
        }
        public override IDataReader EmployeeAppraisalCompetencyTableGetByEmpID(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableGetByEmpID", employeeID);
        }
        
        public override IDataReader EmployeeAppraisalCompetencyTableList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableList");
        }

        public override IDataReader EmployeeAppraisalCompetencyTableGetByEmployeeAppraisalTable(int appraisalID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableGetByEmployeeAppraisalTable", appraisalID);
        }

        public override IDataReader EmployeeAppraisalCompetencyTableGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableGetByEmployeeDetails", employeeID);
        }

        public override IDataReader EmployeeAppraisalCompetencyTableGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableGetByUsers", userID);
        }

        public override int EmployeeAppraisalCompetencyTableAdd(int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int puntPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableAdd", GetNull(quality), GetNull(quaPoint), GetNull(productivity), GetNull(prodPoint), GetNull(knoweldge), GetNull(knowPoint), GetNull(dependability), GetNull(dependPoint), GetNull(initiative), GetNull(initPoint), GetNull(judgement), GetNull(judPoint), GetNull(adaptability), GetNull(adaPoint), GetNull(interterpersonalRelationship), GetNull(interPoint), GetNull(puntuality), GetNull(puntPoint), GetNull(communicationSkills), GetNull(comPoint), GetNull(planning), GetNull(planPoint), GetNull(leadership), GetNull(leadPoint), GetNull(team), GetNull(teamPoint), GetNull(development), GetNull(devPoint), GetNull(overallPoint), GetNull(excelArea), GetNull(areaThatNeedsImprovement), GetNull(stepsToTake), GetNull(areaThatNeedsAssistance), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK)).ToString());
        }

        public override void EmployeeAppraisalCompetencyTableUpdate(int competencyID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int puntPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableUpdate", competencyID, GetNull(quality), GetNull(quaPoint), GetNull(productivity), GetNull(prodPoint), GetNull(knoweldge), GetNull(knowPoint), GetNull(dependability), GetNull(dependPoint), GetNull(initiative), GetNull(initPoint), GetNull(judgement), GetNull(judPoint), GetNull(adaptability), GetNull(adaPoint), GetNull(interterpersonalRelationship), GetNull(interPoint), GetNull(puntuality), GetNull(puntPoint), GetNull(communicationSkills), GetNull(comPoint), GetNull(planning), GetNull(planPoint), GetNull(leadership), GetNull(leadPoint), GetNull(team), GetNull(teamPoint), GetNull(development), GetNull(devPoint), GetNull(overallPoint), GetNull(excelArea), GetNull(areaThatNeedsImprovement), GetNull(stepsToTake), GetNull(areaThatNeedsAssistance), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK));
        }
        public override void EmployeeAppraisalCompetencyTableSupFirstUpdate(int competencyID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int puntPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int appraisalID_FK)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableSupFirstUpdate", competencyID, GetNull(quality), GetNull(quaPoint), GetNull(productivity), GetNull(prodPoint), GetNull(knoweldge), GetNull(knowPoint), GetNull(dependability), GetNull(dependPoint), GetNull(initiative), GetNull(initPoint), GetNull(judgement), GetNull(judPoint), GetNull(adaptability), GetNull(adaPoint), GetNull(interterpersonalRelationship), GetNull(interPoint), GetNull(puntuality), GetNull(puntPoint), GetNull(communicationSkills), GetNull(comPoint), GetNull(planning), GetNull(planPoint), GetNull(leadership), GetNull(leadPoint), GetNull(team), GetNull(teamPoint), GetNull(development), GetNull(devPoint), GetNull(overallPoint), GetNull(excelArea), GetNull(areaThatNeedsImprovement), GetNull(stepsToTake), GetNull(areaThatNeedsAssistance), GetNull(appraisalID_FK));
        }
        
        public override void EmployeeAppraisalCompetencyTableDelete(int competencyID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableDelete", competencyID);
        }
        #endregion


        #region "EmployeeAppraisalCompetencyTableLog Methods"
        public override IDataReader EmployeeAppraisalCompetencyTableLogGet(int competencyLogID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogGet", competencyLogID);
        }
        public override IDataReader EmployeeAppraisalCompetencyTableLogGetByEmpID(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogGetByEmpID", employeeID);
        }
        
        public override IDataReader EmployeeAppraisalCompetencyTableLogList()
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogList");
        }

        public override IDataReader EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalCompetencyTable(int competencyID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalCompetencyTable", competencyID);
        }

        public override IDataReader EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalTable(int appraisalID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalTable", appraisalID);
        }

        public override IDataReader EmployeeAppraisalCompetencyTableLogGetByEmployeeDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogGetByEmployeeDetails", employeeID);
        }
        public override IDataReader EmployeeAppraisalCompetencyTableLogGetByEmpDetails(int employeeID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogGetByEmpDetails", employeeID);
        }
        
        public override IDataReader EmployeeAppraisalCompetencyTableLogGetByUsers(int userID)
        {
            return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogGetByUsers", userID);
        }

        public override int EmployeeAppraisalCompetencyTableLogAdd(int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int punPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int competencyID_FK, int sentBy)
        {
            return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogAdd", GetNull(quality), GetNull(quaPoint), GetNull(productivity), GetNull(prodPoint), GetNull(knoweldge), GetNull(knowPoint), GetNull(dependability), GetNull(dependPoint), GetNull(initiative), GetNull(initPoint), GetNull(judgement), GetNull(judPoint), GetNull(adaptability), GetNull(adaPoint), GetNull(interterpersonalRelationship), GetNull(interPoint), GetNull(puntuality), GetNull(punPoint), GetNull(communicationSkills), GetNull(comPoint), GetNull(planning), GetNull(planPoint), GetNull(leadership), GetNull(leadPoint), GetNull(team), GetNull(teamPoint), GetNull(development), GetNull(devPoint), GetNull(overallPoint), GetNull(excelArea), GetNull(areaThatNeedsImprovement), GetNull(stepsToTake), GetNull(areaThatNeedsAssistance), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(competencyID_FK), GetNull(sentBy)).ToString());
        }

        public override void EmployeeAppraisalCompetencyTableLogUpdate(int competencyLogID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int punPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int competencyID_FK, int sentBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogUpdate", competencyLogID, GetNull(quality), GetNull(quaPoint), GetNull(productivity), GetNull(prodPoint), GetNull(knoweldge), GetNull(knowPoint), GetNull(dependability), GetNull(dependPoint), GetNull(initiative), GetNull(initPoint), GetNull(judgement), GetNull(judPoint), GetNull(adaptability), GetNull(adaPoint), GetNull(interterpersonalRelationship), GetNull(interPoint), GetNull(puntuality), GetNull(punPoint), GetNull(communicationSkills), GetNull(comPoint), GetNull(planning), GetNull(planPoint), GetNull(leadership), GetNull(leadPoint), GetNull(team), GetNull(teamPoint), GetNull(development), GetNull(devPoint), GetNull(overallPoint), GetNull(excelArea), GetNull(areaThatNeedsImprovement), GetNull(stepsToTake), GetNull(areaThatNeedsAssistance), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(competencyID_FK), GetNull(sentBy));
        }
        public override void EmployeeAppraisalCompetencyTableLogSupFirstUpdate(int competencyLogID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int punPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance,  int competencyID_FK, int sentBy)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogSupFirstUpdate", competencyLogID, GetNull(quality), GetNull(quaPoint), GetNull(productivity), GetNull(prodPoint), GetNull(knoweldge), GetNull(knowPoint), GetNull(dependability), GetNull(dependPoint), GetNull(initiative), GetNull(initPoint), GetNull(judgement), GetNull(judPoint), GetNull(adaptability), GetNull(adaPoint), GetNull(interterpersonalRelationship), GetNull(interPoint), GetNull(puntuality), GetNull(punPoint), GetNull(communicationSkills), GetNull(comPoint), GetNull(planning), GetNull(planPoint), GetNull(leadership), GetNull(leadPoint), GetNull(team), GetNull(teamPoint), GetNull(development), GetNull(devPoint), GetNull(overallPoint), GetNull(excelArea), GetNull(areaThatNeedsImprovement), GetNull(stepsToTake), GetNull(areaThatNeedsAssistance), GetNull(competencyID_FK), GetNull(sentBy));
        }
        
        public override void EmployeeAppraisalCompetencyTableLogDelete(int competencyLogID)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalCompetencyTableLogDelete", competencyLogID);
        }
        #endregion

        #region "EmployeeApprasalTableGoal Methods"
	public override IDataReader EmployeeApprasalTableGoalGet(int goalID)
	{
		return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalGet", goalID);
	}
    public override IDataReader EmployeeApprasalTableGoalGetByEmpDetails(int employeeID)
	{
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalGetByEmpDetails", employeeID);
	}
        

	public override IDataReader EmployeeApprasalTableGoalList()
	{
		return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalList");
	}

    public override IDataReader EmployeeApprasalTableGoalGetByArray(int goalID)
	{
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalGetByArray", goalID);
	}
	public override IDataReader EmployeeApprasalTableGoalGetByEmployeeAppraisalTable(int appraisalID )
	{
		return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalGetByEmployeeAppraisalTable", appraisalID);
	}
		
	public override IDataReader EmployeeApprasalTableGoalGetByEmployeeDetails(int employeeID )
	{
		return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalGetByEmployeeDetails", employeeID);
	}
		
	public override IDataReader EmployeeApprasalTableGoalGetByUsers(int userID )
	{
		return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalGetByUsers", userID);
	}
		
	public override int EmployeeApprasalTableGoalAdd(string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK)
	{
		return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalAdd", GetNull(goalDesc), GetNull(goalObjectives), GetNull(goalEvaPoint), GetNull(goalCompletetiondate), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK)).ToString());
	}
	
	public override void EmployeeApprasalTableGoalUpdate(int goalID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK)
	{
		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalUpdate", goalID, GetNull(goalDesc), GetNull(goalObjectives), GetNull(goalEvaPoint), GetNull(goalCompletetiondate), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK));
	}
    public override void EmployeeApprasalTableGoalSupUpdate(int goalID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate,  int appraisalID_FK)
	{
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalSupUpdate", goalID, GetNull(goalDesc), GetNull(goalObjectives), GetNull(goalEvaPoint), GetNull(goalCompletetiondate), GetNull(appraisalID_FK));
	}
        
	public override void EmployeeApprasalTableGoalDelete(int goalID)
	{
		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalDelete", goalID);
	}
	#endregion

    //EmployeeApprasalTableGoalLog

    #region "EmployeeApprasalTableGoalLog Methods"
    public override IDataReader EmployeeApprasalTableGoalLogGet(int goalLogID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogGet", goalLogID);
    }

    public override IDataReader EmployeeApprasalTableGoalLogList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogList");
    }

    public override IDataReader EmployeeApprasalTableGoalLogGetByEmployeeAppraisalTable(int appraisalID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogGetByEmployeeAppraisalTable", appraisalID);
    }

    public override IDataReader EmployeeApprasalTableGoalLogGetByEmployeeApprasalTableGoal(int goalID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogGetByEmployeeApprasalTableGoal", goalID);
    }

    public override IDataReader EmployeeApprasalTableGoalLogGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogGetByEmployeeDetails", employeeID);
    }
    public override IDataReader EmployeeApprasalTableGoalLogEmpGetByEmpID(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogEmpGetByEmpID", employeeID);
    }
         public override IDataReader EmployeeApprasalTableGoalLogSupGetByEmpID(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogSupGetByEmpID", employeeID);
    }
        
    public override IDataReader EmployeeApprasalTableGoalLogGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogGetByUsers", userID);
    }

    public override int EmployeeApprasalTableGoalLogAdd(string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogAdd", GetNull(goalDesc), GetNull(goalObjectives), GetNull(goalEvaPoint), GetNull(goalCompletetiondate), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(sentBy)).ToString());
    }

    public override void EmployeeApprasalTableGoalLogUpdate(int goalLogID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int goalID_FK, int sentBy)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogUpdate", goalLogID, GetNull(goalDesc), GetNull(goalObjectives), GetNull(goalEvaPoint), GetNull(goalCompletetiondate), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(goalID_FK), GetNull(sentBy));
    }
    public override void EmployeeApprasalTableGoalLogGoalIDUpdate(int goalLogID, int goalID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogGoalIDUpdate", goalLogID, GetNull(goalID_FK));
    }
        
    public override void EmployeeApprasalTableGoalLogDelete(int goalLogID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeApprasalTableGoalLogDelete", goalLogID);
    }
    #endregion


    //EmployeeAppraisalTable

    #region "EmployeeAppraisalTable Methods"
    public override IDataReader EmployeeAppraisalTableGet(int appraisalID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableGet", appraisalID);
    }

    public override IDataReader EmployeeAppraisalTableListInfo(int appraisalID, string EmployeeNum, int AppraisalScore, int PromoExamScore, int TotalAppraisalScore)
          {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableListInfo", appraisalID, EmployeeNum, AppraisalScore,  PromoExamScore, TotalAppraisalScore);
    }

    public override IDataReader EmployeeAppraisalTableGetByEmpID(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableGetByEmpID", employeeID);
    }
        
    public override IDataReader EmployeeAppraisalTableList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableList");
    }
    public override IDataReader EmployeeAppraisalTableListForChart()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableListForChart");
    }
    public override IDataReader EmployeeAppraisalTableListForGoogleChart()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableListForGoogleChart");
    }
    public override IDataReader EmployeeAppraisalTableListForColumnChart()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableListForColumnChart");
    }
        
    public override IDataReader EmployeeAppraisalTableManagementApprovalList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableManagementApprovalList");
    }
        
    public override IDataReader EmployeeAppraisalTableGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableGetByEmployeeDetails", employeeID);
    }

    public override IDataReader EmployeeAppraisalTableGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableGetByUsers", userID);
    }

    public override int EmployeeAppraisalTableAdd(string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableAdd", GetNull(employeeNum), GetNull(appraisalScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(promoRecommendation), GetNull(empAppraisalDate), GetNull(supAppraisalDate), GetNull(hrAppraisalDate), GetNull(supComment), GetNull(hRComment), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK)).ToString());
    }
    public override int EmployeeAppraisalTableEmpAdd(string employeeNum, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string empAppraisalDate,  int employeeID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableEmpAdd", GetNull(employeeNum), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(empAppraisalDate), GetNull(employeeID_FK)).ToString());
    }
        
    public override void EmployeeAppraisalTableUpdate(int appraisalID, string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableUpdate", appraisalID, GetNull(employeeNum), GetNull(appraisalScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(promoRecommendation), GetNull(empAppraisalDate), GetNull(supAppraisalDate), GetNull(hrAppraisalDate), GetNull(supComment), GetNull(hRComment), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK));
    }
    public override void EmployeeAppraisalTableAppraisalScoreUpdate(int appraisalID, int appraisalScore)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableAppraisalScoreUpdate", appraisalID, GetNull(appraisalScore));
    }
    public override void EmployeeAppraisalTableSupAppraisalScoreUpdate(int appraisalID, int appraisalScore, string supComment, string promoRecommendation, int supervisorID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableSupAppraisalScoreUpdate", appraisalID, GetNull(appraisalScore), GetNull(supComment), GetNull(promoRecommendation), GetNull(supervisorID_FK));
    }
    public override void EmployeeAppraisalTableHRAppraisalScoreUpdate(int appraisalID, int promoExamScore, int totalAppraisalScore, string appraisalStatus, string hrAppraisalDate, string hRPromoRecommendation, string hRComment, int employeeID_FK, int hRID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableHRAppraisalScoreUpdate", appraisalID, GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(appraisalStatus), GetNull(hrAppraisalDate), GetNull(hRPromoRecommendation), GetNull(hRComment), GetNull(employeeID_FK), GetNull(hRID_FK));
    }
        
    public override void EmployeeAppraisalTableSupFirstUpdate(int appraisalID, string totalPoint, string appraisalStatus, string supAppraisalDate)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableSupFirstUpdate", appraisalID, GetNull(totalPoint), GetNull(appraisalStatus), GetNull(supAppraisalDate));
    }
    public override void EmployeeAppraisalTableSupAppraiseUpdate(int appraisalID,  int promoExamScore, int totalAppraisalScore,string promoRecommendation,  string supComment)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableSupAppraiseUpdate", appraisalID, GetNull(promoExamScore), GetNull(totalAppraisalScore),  GetNull(promoRecommendation),  GetNull(supComment));
    }
    public override void EmployeeAppraisalTableManagementDecisionUpdate(int appraisalID, string managementDecision, string managementDecisionDate)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableManagementDecisionUpdate", appraisalID, GetNull(managementDecision), GetNull(managementDecisionDate));
    }
        
    public override void EmployeeAppraisalTableDelete(int appraisalID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableDelete", appraisalID);
    }
    #endregion


    //EmployeeAppraisalTableLog

    #region "EmployeeAppraisalTableLog Methods"
    public override IDataReader EmployeeAppraisalTableLogGet(int appraisalLogID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGet", appraisalLogID);
    }
    public override IDataReader EmployeeAppraisalTableLogGetByEmpID(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGetByEmpID", employeeID);
    }
    //public override IDataReader EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID(int employeeID)
    //{
    //    return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID", employeeID);
    //}
        
    public override IDataReader EmployeeAppraisalTableLogList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogList");
    }
    public override IDataReader EmployeeAppraisalTableLogGetByEmployeeAppraisalTable(int appraisalID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGetByEmployeeAppraisalTable", appraisalID);
    }
    public override IDataReader EmployeeAppraisalTableLogGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGetByEmployeeDetails", employeeID);
    }
   
    public override IDataReader EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID", employeeID);
    }
    public override IDataReader EmployeeAppraisalTableLogGetSupAppraisalDetailsByEmpID(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGetSupAppraisalDetailsByEmpID", employeeID);
    }
        
    public override IDataReader EmployeeAppraisalTableLogGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogGetByUsers", userID);
    }

    public override int EmployeeAppraisalTableLogAdd(string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogAdd", GetNull(employeeNum), GetNull(appraisalScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(promoRecommendation), GetNull(empAppraisalDate), GetNull(supAppraisalDate), GetNull(hrAppraisalDate), GetNull(supComment), GetNull(hRComment), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(sentBy)).ToString());
    }
    public override int EmployeeAppraisalTableLogEmpAdd(string employeeNum, int appraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string empAppraisalDate,int employeeID_FK, int appraisalID_FK, int sentBy)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogEmpAdd", GetNull(employeeNum), GetNull(appraisalScore),  GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(empAppraisalDate), GetNull(employeeID_FK),  GetNull(appraisalID_FK), GetNull(sentBy)).ToString());
    }
    public override int EmployeeAppraisalTableLogSupEmpAdd(string employeeNum, int appraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string supComment, int employeeID_FK, int supervisorID_FK, int appraisalID_FK, int sentBy)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogSupEmpAdd", GetNull(employeeNum), GetNull(appraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(promoRecommendation), GetNull(empAppraisalDate), GetNull(supAppraisalDate), GetNull(supComment), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(appraisalID_FK), GetNull(sentBy)).ToString());
    }
   public override int EmployeeAppraisalTableLogHREmpAdd(string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRPromoRecommendation, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogHREmpAdd", GetNull(employeeNum), GetNull(appraisalScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(promoRecommendation), GetNull(empAppraisalDate), GetNull(supAppraisalDate), GetNull(hrAppraisalDate), GetNull(supComment),GetNull(hRPromoRecommendation), GetNull(hRComment),GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(sentBy)).ToString());
    }
        
    //public override int EmployeeAppraisalTableLogEmpAdd(string employeeNum, int appraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string empAppraisalDate, string SupAppraisalDate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy)
    //{
    //    return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogEmpAdd", GetNull(employeeNum), GetNull(appraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear),  GetNull(appraisalStatus), GetNull(empAppraisalDate), GetNull(SupAppraisalDate), GetNull(supComment), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(sentBy)).ToString());
    //}

    public override void EmployeeAppraisalTableLogUpdate(int appraisalLogID, string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogUpdate", appraisalLogID, GetNull(employeeNum), GetNull(appraisalScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(promoRecommendation), GetNull(empAppraisalDate), GetNull(supAppraisalDate), GetNull(hrAppraisalDate), GetNull(supComment), GetNull(hRComment), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(sentBy));
    }
    public override void EmployeeAppraisalTableLogAppraisalScoreUpdate(int appraisalLogID, int appraisalScore)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogAppraisalScoreUpdate", appraisalLogID, GetNull(appraisalScore));
    }
    public override void EmployeeAppraisalTableLogSupFirstUpdate(int appraisalLogID, string employeeNum, int appraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string empAppraisalDate, string supAppraisalDate, string supComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogSupFirstUpdate", appraisalLogID, GetNull(employeeNum), GetNull(appraisalScore), GetNull(totalPoint), GetNull(evaPeriod), GetNull(aprpraisalStartYear), GetNull(appraisalStatus), GetNull(empAppraisalDate), GetNull(supAppraisalDate), GetNull(supComment), GetNull(employeeID_FK), GetNull(supervisorID_FK), GetNull(hRID_FK), GetNull(appraisalID_FK), GetNull(sentBy));
    }
    public override void EmployeeAppraisalTableLogSupAppraiseUpdate(int appraisalID_FK, int promoExamScore, int totalAppraisalScore, string promoRecommendation, string supComment)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogSupAppraiseUpdate", GetNull(appraisalID_FK), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(promoRecommendation), GetNull(supComment));
    }
    public override void EmployeeAppraisalTableLogManagementDecisionUpdate( int appraisalLogID, int appraisalID_FK,  string managementDecision, string managementDecisionDate)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogManagementDecisionUpdate", appraisalLogID, GetNull(appraisalID_FK), GetNull(managementDecisionDate), GetNull(managementDecisionDate));
    }
       
    public override void EmployeeAppraisalTableLogDelete(int appraisalLogID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeAppraisalTableLogDelete", appraisalLogID);
    }
    #endregion

#endregion


        //EmployeePromotionTable

    #region "EmployeePromotionTable Methods"
    public override IDataReader EmployeePromotionTableGet(int promotionID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableGet", promotionID);
    }

    public override IDataReader EmployeePromotionTableList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableList");
    }
    public override IDataReader EmployeePromotionTableListByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableListByEmployeeDetails", employeeID);
    }
        
    public override IDataReader EmployeePromotionTablePromoHistList(int PreDept, int NewDept, int PreviousPosition, int NewPosition, int PreviousLevel, int NewLevel)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTablePromoHistList", PreDept, NewDept, PreviousPosition, NewPosition, PreviousLevel, NewLevel);
    }
      
    public override IDataReader EmployeePromotionTableGetByEmployeeAppraisalTable(int appraisalID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableGetByEmployeeAppraisalTable", appraisalID);
    }

    public override IDataReader EmployeePromotionTableGetByEmployeeDepartmentTable(int deptID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableGetByEmployeeDepartmentTable", deptID);
    }

    public override IDataReader EmployeePromotionTableGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableGetByEmployeeDetails", employeeID);
    }

    public override IDataReader EmployeePromotionTableGetByEmployeeLevel(int levelID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableGetByEmployeeLevel", levelID);
    }

    public override IDataReader EmployeePromotionTableGetByEmployeePositionTable(int positionID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableGetByEmployeePositionTable", positionID);
    }

    public override IDataReader EmployeePromotionTableGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableGetByUsers", userID);
    }

    public override int EmployeePromotionTableAdd(int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableAdd", GetNull(previousLevel), GetNull(newLevel), GetNull(preDept), GetNull(previousPosition), GetNull(newDept), GetNull(newPosition), GetNull(apprasialScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(promotedDate), GetNull(promotedBy), GetNull(employeeID_FK), GetNull(apprasialID_FK)).ToString());
    }

    public override void EmployeePromotionTableUpdate(int promotionID, int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableUpdate", promotionID, GetNull(previousLevel), GetNull(newLevel), GetNull(preDept), GetNull(previousPosition), GetNull(newDept), GetNull(newPosition), GetNull(apprasialScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(promotedDate), GetNull(promotedBy), GetNull(employeeID_FK), GetNull(apprasialID_FK));
    }

    public override void EmployeePromotionTableDelete(int promotionID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableDelete", promotionID);
    }
    #endregion


  

    #region "EmployeePromotionTableLog Methods"
    public override IDataReader EmployeePromotionTableLogGet(int promotionLogID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGet", promotionLogID);
    }

    public override IDataReader EmployeePromotionTableLogList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogList");
    }

    public override IDataReader EmployeePromotionTableLogGetByEmployeeAppraisalTable(int appraisalID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGetByEmployeeAppraisalTable", appraisalID);
    }

    public override IDataReader EmployeePromotionTableLogGetByEmployeeDepartmentTable(int deptID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGetByEmployeeDepartmentTable", deptID);
    }

    public override IDataReader EmployeePromotionTableLogGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGetByEmployeeDetails", employeeID);
    }

    public override IDataReader EmployeePromotionTableLogGetByEmployeeLevel(int levelID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGetByEmployeeLevel", levelID);
    }

    public override IDataReader EmployeePromotionTableLogGetByEmployeePositionTable(int positionID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGetByEmployeePositionTable", positionID);
    }

    public override IDataReader EmployeePromotionTableLogGetByEmployeePromotionTable(int promotionID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGetByEmployeePromotionTable", promotionID);
    }

    public override IDataReader EmployeePromotionTableLogGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogGetByUsers", userID);
    }

    public override int EmployeePromotionTableLogAdd(int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK, int promotionID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogAdd", GetNull(previousLevel), GetNull(newLevel), GetNull(preDept), GetNull(previousPosition), GetNull(newDept), GetNull(newPosition), GetNull(apprasialScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(promotedDate), GetNull(promotedBy), GetNull(employeeID_FK), GetNull(apprasialID_FK), GetNull(promotionID_FK)).ToString());
    }

    public override void EmployeePromotionTableLogUpdate(int promotionLogID, int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK, int promotionID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogUpdate", promotionLogID, GetNull(previousLevel), GetNull(newLevel), GetNull(preDept), GetNull(previousPosition), GetNull(newDept), GetNull(newPosition), GetNull(apprasialScore), GetNull(promoExamScore), GetNull(totalAppraisalScore), GetNull(promotedDate), GetNull(promotedBy), GetNull(employeeID_FK), GetNull(apprasialID_FK), GetNull(promotionID_FK));
    }

    public override void EmployeePromotionTableLogDelete(int promotionLogID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeePromotionTableLogDelete", promotionLogID);
    }
    #endregion



    //EmployeeTypeOfLeaveTable

    #region "EmployeeTypeOfLeaveTable Methods"
    public override IDataReader EmployeeTypeOfLeaveTableGet(int leaveTypeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableGet", leaveTypeID);
    }

    public override IDataReader EmployeeTypeOfLeaveTableList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableList");
    }

    public override int EmployeeTypeOfLeaveTableAdd(string leaveTypeName)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableAdd", GetNull(leaveTypeName)).ToString());
    }

    public override void EmployeeTypeOfLeaveTableUpdate(int leaveTypeID, string leaveTypeName)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableUpdate", leaveTypeID, GetNull(leaveTypeName));
    }

    public override void EmployeeTypeOfLeaveTableDelete(int leaveTypeID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeTypeOfLeaveTableDelete", leaveTypeID);
    }
    #endregion


    //EmployeeLeaveTable  

    #region "EmployeeLeaveTable Methods"
    public override IDataReader EmployeeLeaveTableGet(int leaveID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGet", leaveID);
    }
    // get leave details for an employee EmployeeLeaveTableGetForAnEmployee
    public override IDataReader EmployeeLeaveTableGetForAnEmployee(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetForAnEmployee", employeeID);
    }
    public override IDataReader EmployeeLeaveTableList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableList");
    }

    public override IDataReader EmployeeLeaveTableGetByEmployeeDepartmentTable(int deptID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeDepartmentTable", deptID);
    }

    public override IDataReader EmployeeLeaveTableGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeDetails", employeeID);
    }

    public override IDataReader EmployeeLeaveTableGetByEmployeeLevel(int levelID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeLevel", levelID);
    }

    public override IDataReader EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable(int leaveTypeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable", leaveTypeID);
    }

    public override IDataReader EmployeeLeaveTableGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableGetByUsers", userID);
    }

    public override int EmployeeLeaveTableAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableAdd", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(levelID_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), employeeID_FK).ToString());
    }


    // saving employee leave application   EmployeeLeaveTableAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied,  int dept_FK, int employeeID_FK);
    public override int EmployeeLeaveTableAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThresholdBeforeApplication, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableAddLeaveApplication", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(levelID_FK), GetNull(leaveThresholdBeforeApplication), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(dept_FK), GetNull(employeeID_FK)).ToString());
    }
    public override void EmployeeLeaveTableUpdate(int leaveID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableUpdate", leaveID, GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(levelID_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), employeeID_FK);
    }

    //update employee leave application
    public override void EmployeeLeaveTableUpdateLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThresholdBeforeApplication, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableUpdateLeaveApplication", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(levelID_FK),GetNull(leaveThresholdBeforeApplication), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(dept_FK), employeeID_FK);
    }
    public override void EmployeeLeaveTableUpdateLeaveApprovalORDisapproval(int leaveID, string leaveStatus, int leaveGrantedBy, string dateGranted, string leaveThresholdBeforeApplication, string leaveThreshold, string reasonForDisapproval, int employeeID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableUpdateLeaveApprovalORDisapproval", leaveID, GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(leaveThresholdBeforeApplication), GetNull(leaveThreshold), GetNull(reasonForDisapproval), employeeID_FK);
    } 
    public override void EmployeeLeaveTableDelete(int leaveID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableDelete", leaveID);
    }
    #endregion



    // EmployeeLeaveTableLog

    #region "EmployeeLeaveTableLog Methods"
    public override IDataReader EmployeeLeaveTableLogGet(int leaveLogID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGet", leaveLogID);
    }

    public override IDataReader EmployeeLeaveTableLogList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogList");
    }

    public override IDataReader EmployeeLeaveTableLogGetByEmployeeDepartmentTable(int deptID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeDepartmentTable", deptID);
    }

    public override IDataReader EmployeeLeaveTableLogGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeDetails", employeeID);
    }

    public override IDataReader EmployeeLeaveTableLogGetByEmployeeLeaveTable(int leaveID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeLeaveTable", leaveID);
    }

    public override IDataReader EmployeeLeaveTableLogGetByEmployeeLevel(int levelID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeLevel", levelID);
    }

    public override IDataReader EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(int leaveTypeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable", leaveTypeID);
    }

    public override IDataReader EmployeeLeaveTableLogGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogGetByUsers", userID);
    }

    public override int EmployeeLeaveTableLogAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK, int leaveID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogAdd", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(dept_FK), GetNull(employeeID_FK), GetNull(leaveID_FK)).ToString());
    }

    // saving employee leave application   in log table
    public override int EmployeeLeaveTableLogAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThresholdBeforeApplication, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK, int leaveID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogAddLeaveApplication", GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThresholdBeforeApplication), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(dept_FK), GetNull(employeeID_FK), GetNull(leaveID_FK)).ToString());
    }
    public override void EmployeeLeaveTableLogUpdate(int leaveLogID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, string reasonForDisapproval, int dept_FK, int employeeID_FK, int leaveID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogUpdate", leaveLogID, GetNull(leaveType_FK), GetNull(leaveDescription), GetNull(startDate), GetNull(endDate), GetNull(duration), GetNull(level_FK), GetNull(leaveThreshold), GetNull(dateApplied), GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(approveOrDisapproveReason), GetNull(reasonForDisapproval), GetNull(dept_FK), GetNull(employeeID_FK), GetNull(leaveID_FK));
    }
    public override void EmployeeLeaveTableLogUpdateLeaveApprovalORDisapproval(int leaveLogID, string leaveStatus, int leaveGrantedBy, string dateGranted, string leaveThresholdBeforeApplication, string leaveThreshold, string reasonForDisapproval, int employeeID_FK, int leaveID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogUpdateLeaveApprovalORDisapproval", leaveLogID, GetNull(leaveStatus), GetNull(leaveGrantedBy), GetNull(dateGranted), GetNull(leaveThresholdBeforeApplication), GetNull(leaveThreshold), GetNull(reasonForDisapproval), GetNull(employeeID_FK), GetNull(leaveID_FK));
    }
        
    public override void EmployeeLeaveTableLogDelete(int leaveLogID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeLeaveTableLogDelete", leaveLogID);
    }
    #endregion


    //EmployeeDisciplineTable

    #region "EmployeeDisciplineTable Methods"
    public override IDataReader EmployeeDisciplineTableGet(int disciplineID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableGet", disciplineID);
    }

    public override IDataReader EmployeeDisciplineTableList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableList");
    }

    public override int EmployeeDisciplineTableAdd(string discplineDescription)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableAdd", GetNull(discplineDescription)).ToString());
    }

    public override void EmployeeDisciplineTableUpdate(int disciplineID, string discplineDescription)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableUpdate", disciplineID, GetNull(discplineDescription));
    }

    public override void EmployeeDisciplineTableDelete(int disciplineID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeDisciplineTableDelete", disciplineID);
    }
    #endregion


    //EmployeeQueryTable

    #region "EmployeeQueryTable Methods"
    public override IDataReader EmployeeQueryTableGet(int queryID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableGet", queryID);
    }

    public override IDataReader EmployeeQueryTableList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableList");
    }

    public override IDataReader EmployeeQueryTableGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableGetByEmployeeDetails", employeeID);
    }

    public override IDataReader EmployeeQueryTableGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableGetByUsers", userID);
    }

    public override int EmployeeQueryTableAdd(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableAdd", GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter), GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter), GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy)).ToString());
    }

    // sending query         public abstract int EmployeeQueryTableAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter);
    public override int EmployeeQueryTableAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableAddQuery", GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter)).ToString());
    }
    public override void EmployeeQueryTableUpdate(int queryID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableUpdate", queryID, GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter), GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter), GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy));
    }

    // update response to query EmployeeQueryTableUpdateQueryResponse(int queryID,  string employeeResponse, string responseDate, string empResponseLetter);
    public override void EmployeeQueryTableUpdateQueryResponse(int queryID, string employeeResponse, string responseDate, string empResponseLetter)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableUpdateQueryResponse", queryID, GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter));
    }

    // update query Discipline (int queryID,  int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);
    public override void EmployeeQueryTableUpdateQueryDiscipline(int queryID, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableUpdateQueryDiscipline", queryID, GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy));
    }
    public override void EmployeeQueryTableUpdateQueryDisciplineSuspention(int queryID, int discipliineType_FK, string suspentionStartDate, string suspentionEndDate, string suspentionDuration, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableUpdateQueryDisciplineSuspention", queryID, GetNull(discipliineType_FK), GetNull(suspentionStartDate), GetNull(suspentionEndDate), GetNull(suspentionDuration), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy));
    }
        
    public override void EmployeeQueryTableDelete(int queryID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableDelete", queryID);
    }
    #endregion



    //EmployeeQueryTableLog

    #region "EmployeeQueryTableLog Methods"
    public override IDataReader EmployeeQueryTableLogGet(int queryLogID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogGet", queryLogID);
    }
    public override IDataReader EmployeeQueryTableLogGetByEmpQuery(int queryID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogGetByEmpQuery", queryID);
    }
        
    public override IDataReader EmployeeQueryTableLogList()
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogList");
    }

    public override IDataReader EmployeeQueryTableLogGetByEmployeeDetails(int employeeID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogGetByEmployeeDetails", employeeID);
    }

    public override IDataReader EmployeeQueryTableLogGetByEmployeeQueryTable(int queryID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogGetByEmployeeQueryTable", queryID);
    }

    public override IDataReader EmployeeQueryTableLogGetByUsers(int userID)
    {
        return (IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogGetByUsers", userID);
    }

    public override int EmployeeQueryTableLogAdd(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogAdd", GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter), GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter), GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy), GetNull(queryID_FK)).ToString());
    }
    // sending query         public abstract int EmployeeQueryTableAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter);
    public override int EmployeeQueryTableLogAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, int queryID_FK)
    {
        return int.Parse(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogAddQuery", GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter), GetNull(queryID_FK)).ToString());
    }
    public override void EmployeeQueryTableLogUpdate(int queryLogID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogUpdate", queryLogID, GetNull(queryTitle), GetNull(description), GetNull(queryReceivedBy), GetNull(issueDate), GetNull(queryIssuedBy), GetNull(queryLetter), GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter), GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy), GetNull(queryID_FK));
    }

    // update response to query EmployeeQueryTableUpdateQueryResponse(int queryID,  string employeeResponse, string responseDate, string empResponseLetter);
    public override void EmployeeQueryTableLogUpdateQueryResponse(int queryLogID, string employeeResponse, string responseDate, string empResponseLetter, int queryID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogUpdateQueryResponse", queryLogID, GetNull(employeeResponse), GetNull(responseDate), GetNull(empResponseLetter), GetNull(queryID_FK));
    }

    // update query Discipline (int queryID,  int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);
    public override void EmployeeQueryTableLogUpdateQueryDiscipline(int queryLogID, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogUpdateQueryDiscipline", queryLogID, GetNull(discipliineType_FK), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy), GetNull(queryID_FK));
    }
    public override void EmployeeQueryTableLogUpdateQueryDisciplineSuspention(int queryLogID, int discipliineType_FK, string suspentionStartDate, string suspentionEndDate, string suspentionDuration, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogUpdateQueryDisciplineSuspention", queryLogID, GetNull(discipliineType_FK), GetNull(suspentionStartDate), GetNull(suspentionEndDate), GetNull(suspentionDuration), GetNull(disciplineDetails), GetNull(disciplineLetter), GetNull(disciplineDate), GetNull(disciplinedBy), GetNull(queryID_FK));
    }
        
    public override void EmployeeQueryTableLogDelete(int queryLogID)
    {
        SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "EmployeeQueryTableLogDelete", queryLogID);
    }
    #endregion


   

    }

}