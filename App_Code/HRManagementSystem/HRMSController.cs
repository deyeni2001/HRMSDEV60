using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Xml;
using System.Web;
using DotNetNuke.Framework;
using DotNetNuke;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using ola.HRMangmntSyst;


namespace ola.HRMangmntSyst
{
    public class HRMSController
    {
        public HRMSController()
        {
            //
            // TODO: Add constructor logic here
            //



        }
    }



    
    public class EmployeeGradesController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeGradeInfo Get(int GradeId)
        {
            return (EmployeeGradeInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeGradesGet(GradeId ), typeof(EmployeeGradeInfo));
        }


        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeGradesList(), typeof(EmployeeGradeInfo));
        }


        public int Add(EmployeeGradeInfo objInfo)
        {
            return (int)DataProvider.Instance().EmployeeGradesAdd( objInfo.GradeName , objInfo.GradeCode, objInfo.GradeDescription);
        }

        public void Update(EmployeeGradeInfo objInfo)
        {
            DataProvider.Instance().EmployeeGradesUpdate(objInfo.GradeId  ,objInfo.GradeName , objInfo.GradeCode, objInfo.GradeDescription);
        }

        public void Delete(int GradeId)
        {
            DataProvider.Instance().EmployeeGradesDelete(GradeId );
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    public class DepartmentHeadsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public DepartmentHeadInfo Get(int RecId)
        {
            return (DepartmentHeadInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().DepartmentHeadsGet(RecId), typeof(DepartmentHeadInfo));
        }


        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().DepartmentHeadsList(), typeof(DepartmentHeadInfo));
        }


        public int Add(DepartmentHeadInfo objInfo)
        {
            return (int)DataProvider.Instance().DepartmentHeadsAdd( objInfo.DeptId , objInfo.DeptHead, objInfo.StartDate , objInfo.EndDate );
        }

        public void Update(DepartmentHeadInfo objInfo)
        {
            DataProvider.Instance().DepartmentHeadsUpdate(objInfo.RecId ,objInfo.RecId, objInfo.DeptHead, objInfo.StartDate, objInfo.EndDate);
        }

        public void Delete(int RecId)
        {
            DataProvider.Instance().DepartmentHeadsDelete(RecId);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }












    public class DepartmentEmployeesController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public DepartmentEmployeesInfo Get(int DeptEmpCode)
        {
            return (DepartmentEmployeesInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().DepartmentEmployeesGet(DeptEmpCode), typeof(DepartmentEmployeesInfo));
        }

        public DepartmentEmployeesInfo GetByUserId(String UserId)
        {
            return (DepartmentEmployeesInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().DepartmentEmployeesGetByUserId(UserId ), typeof(DepartmentEmployeesInfo));
        }


        public ArrayList ListSearch(String searchString)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().DepartmentEmployeesListSearch(searchString), typeof(DepartmentEmployeesInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().DepartmentEmployeesList(), typeof(DepartmentEmployeesInfo));
        }


        public int Add(DepartmentEmployeesInfo objDepartmentEmployeesInfo)
        {
            return (int)DataProvider.Instance().DepartmentEmployeesAdd(objDepartmentEmployeesInfo.EmpStatus, objDepartmentEmployeesInfo.DeptId , objDepartmentEmployeesInfo.JobTitle , objDepartmentEmployeesInfo.Ptitle , objDepartmentEmployeesInfo.Fname , objDepartmentEmployeesInfo.Middlename , objDepartmentEmployeesInfo.Lastname , objDepartmentEmployeesInfo.Email , objDepartmentEmployeesInfo.PhoneExt , objDepartmentEmployeesInfo.MobileNo , objDepartmentEmployeesInfo.OfficeRoom , objDepartmentEmployeesInfo.EmpType , objDepartmentEmployeesInfo.Passport , objDepartmentEmployeesInfo.UserId );
        }

        public void Update(DepartmentEmployeesInfo objDepartmentEmployeesInfo)
        {
            DataProvider.Instance().DepartmentEmployeesUpdate(objDepartmentEmployeesInfo.DeptEmpCode , objDepartmentEmployeesInfo.EmpStatus, objDepartmentEmployeesInfo.DeptId, objDepartmentEmployeesInfo.JobTitle, objDepartmentEmployeesInfo.Ptitle, objDepartmentEmployeesInfo.Fname, objDepartmentEmployeesInfo.Middlename, objDepartmentEmployeesInfo.Lastname, objDepartmentEmployeesInfo.Email, objDepartmentEmployeesInfo.PhoneExt, objDepartmentEmployeesInfo.MobileNo, objDepartmentEmployeesInfo.OfficeRoom, objDepartmentEmployeesInfo.EmpType, objDepartmentEmployeesInfo.Passport, objDepartmentEmployeesInfo.UserId);
        }

        public void Delete(int DeptEmpCode)
        {
            DataProvider.Instance().DepartmentEmployeesDelete(DeptEmpCode);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }





    public class DepartmentTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public DepartmentTableInfo Get(int DeptId)
        {
            return (DepartmentTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().DepartmentTableGet(DeptId), typeof(DepartmentTableInfo));
        }


        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().DepartmentTableList(), typeof(DepartmentTableInfo));
        }


        public int Add(DepartmentTableInfo objDepartmentTable)
        {
            return (int)DataProvider.Instance().DepartmentTableAdd(objDepartmentTable.DeptName, objDepartmentTable.DeptCode, objDepartmentTable.SuperDept, objDepartmentTable.DeptRole);
        }

        public void Update(DepartmentTableInfo objDepartmentTable)
        {
            DataProvider.Instance().DepartmentTableUpdate(objDepartmentTable.DeptId , objDepartmentTable.DeptName,objDepartmentTable.DeptCode ,objDepartmentTable.SuperDept ,objDepartmentTable.DeptRole  );
        }

        public void Delete(int DeptId)
        {
            DataProvider.Instance().DepartmentTableDelete(DeptId );
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }








    public class CountryTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public CountryTableInfo Get(int countryID)
        {
            return (CountryTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().CountryTableGet(countryID), typeof(CountryTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().CountryTableList(), typeof(CountryTableInfo));
        }


        public int Add(CountryTableInfo objCountryTable)
        {
            return (int)DataProvider.Instance().CountryTableAdd(objCountryTable.CountryName);
        }

        public void Update(CountryTableInfo objCountryTable)
        {
            DataProvider.Instance().CountryTableUpdate(objCountryTable.CountryID, objCountryTable.CountryName);
        }

        public void Delete(int countryID)
        {
            DataProvider.Instance().CountryTableDelete(countryID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    public class StateTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public StateTableInfo Get(int stateID)
        {
            return (StateTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().StateTableGet(stateID), typeof(StateTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().StateTableList(), typeof(StateTableInfo));
        }

        public ArrayList GetByCountryTable(int countryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().StateTableGetByCountryTable(countryID), typeof(StateTableInfo));
        }

        public int Add(StateTableInfo objStateTable)
        {
            return (int)DataProvider.Instance().StateTableAdd(objStateTable.StateName, objStateTable.StateCode, objStateTable.CountryID);
        }

        public void Update(StateTableInfo objStateTable)
        {
            DataProvider.Instance().StateTableUpdate(objStateTable.StateID, objStateTable.StateName, objStateTable.StateCode, objStateTable.CountryID);
        }

        public void Delete(int stateID)
        {
            DataProvider.Instance().StateTableDelete(stateID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    public class SenatorialTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public SenatorialTableInfo Get(int senID)
        {
            return (SenatorialTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().SenatorialTableGet(senID), typeof(SenatorialTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().SenatorialTableList(), typeof(SenatorialTableInfo));
        }

        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().SenatorialTableGetByStateTable(stateID), typeof(SenatorialTableInfo));
        }

        public int Add(SenatorialTableInfo objSenatorialTable)
        {
            return (int)DataProvider.Instance().SenatorialTableAdd(objSenatorialTable.senCode, objSenatorialTable.senName, objSenatorialTable.senStateID_FK);
        }

        public void Update(SenatorialTableInfo objSenatorialTable)
        {
            DataProvider.Instance().SenatorialTableUpdate(objSenatorialTable.senID, objSenatorialTable.senCode, objSenatorialTable.senName, objSenatorialTable.senStateID_FK);
        }

        public void Delete(int senID)
        {
            DataProvider.Instance().SenatorialTableDelete(senID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }
    public class LGATableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public LGATableInfo Get(int lgaID)
        {
            return (LGATableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().LGATableGet(lgaID), typeof(LGATableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().LGATableList(), typeof(LGATableInfo));
        }

        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().LGATableGetByStateTable(stateID), typeof(LGATableInfo));
        }

        public int Add(LGATableInfo objLGATable)
        {
            return (int)DataProvider.Instance().LGATableAdd(objLGATable.LgaName, objLGATable.StateID);
        }

        public void Update(LGATableInfo objLGATable)
        {
            DataProvider.Instance().LGATableUpdate(objLGATable.LgaID, objLGATable.LgaName, objLGATable.StateID);
        }

        public void Delete(int lgaID)
        {
            DataProvider.Instance().LGATableDelete(lgaID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    public class QualificationsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public QualificationsInfo Get(int qualifID)
        {
            return (QualificationsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().QualificationsGet(qualifID), typeof(QualificationsInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().QualificationsList(), typeof(QualificationsInfo));
        }


        public int Add(QualificationsInfo objQualifications)
        {
            return (int)DataProvider.Instance().QualificationsAdd(objQualifications.qualifName);
        }

        public void Update(QualificationsInfo objQualifications)
        {
            DataProvider.Instance().QualificationsUpdate(objQualifications.qualifID, objQualifications.qualifName);
        }

        public void Delete(int qualifID)
        {
            DataProvider.Instance().QualificationsDelete(qualifID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    public class GradeTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public GradeTableInfo Get(int gradeID)
        {
            return (GradeTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().GradeTableGet(gradeID), typeof(GradeTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().GradeTableList(), typeof(GradeTableInfo));
        }

        public ArrayList GetByQualifications(int qualifID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().GradeTableGetByQualifications(qualifID), typeof(GradeTableInfo));
        }

        public int Add(GradeTableInfo objGradeTable)
        {
            return (int)DataProvider.Instance().GradeTableAdd(objGradeTable.gradeName, objGradeTable.qaulifID_FK);
        }

        public void Update(GradeTableInfo objGradeTable)
        {
            DataProvider.Instance().GradeTableUpdate(objGradeTable.gradeID, objGradeTable.gradeName, objGradeTable.qaulifID_FK);
        }

        public void Delete(int gradeID)
        {
            DataProvider.Instance().GradeTableDelete(gradeID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //ApplicantDepartmentTableController

    public class ApplicantDepartmentTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantDepartmentTableInfo Get(int deptID)
        {
            return (ApplicantDepartmentTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantDepartmentTableGet(deptID), typeof(ApplicantDepartmentTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantDepartmentTableList(), typeof(ApplicantDepartmentTableInfo));
        }


        public int Add(ApplicantDepartmentTableInfo objApplicantDepartmentTable)
        {
            return (int)DataProvider.Instance().ApplicantDepartmentTableAdd(objApplicantDepartmentTable.DeptName);
        }

        public void Update(ApplicantDepartmentTableInfo objApplicantDepartmentTable)
        {
            DataProvider.Instance().ApplicantDepartmentTableUpdate(objApplicantDepartmentTable.DeptID, objApplicantDepartmentTable.DeptName);
        }

        public void Delete(int deptID)
        {
            DataProvider.Instance().ApplicantDepartmentTableDelete(deptID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //ApplicantAvailablePositiontableController

    public class ApplicantAvailablePositiontableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantAvailablePositiontableInfo Get(int positionAppliedforID)
        {
            return (ApplicantAvailablePositiontableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantAvailablePositiontableGet(positionAppliedforID), typeof(ApplicantAvailablePositiontableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantAvailablePositiontableList(), typeof(ApplicantAvailablePositiontableInfo));
        }

        public ArrayList GetByApplicantDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantAvailablePositiontableGetByApplicantDepartmentTable(deptID), typeof(ApplicantAvailablePositiontableInfo));
        }

        public int Add(ApplicantAvailablePositiontableInfo objApplicantAvailablePositiontable)
        {
            return (int)DataProvider.Instance().ApplicantAvailablePositiontableAdd(objApplicantAvailablePositiontable.PositionAppliedForName, objApplicantAvailablePositiontable.DeptID_FK);
        }

        public void Update(ApplicantAvailablePositiontableInfo objApplicantAvailablePositiontable)
        {
            DataProvider.Instance().ApplicantAvailablePositiontableUpdate(objApplicantAvailablePositiontable.PositionAppliedforID, objApplicantAvailablePositiontable.PositionAppliedForName, objApplicantAvailablePositiontable.DeptID_FK);
        }

        public void Delete(int positionAppliedforID)
        {
            DataProvider.Instance().ApplicantAvailablePositiontableDelete(positionAppliedforID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }
  
    

    public class ApplicantPersonalDetailsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantPersonalDetailsInfo Get(int applicantID)
        {
            return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGet(applicantID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ApplicantPersonalDetailsInfo GetByApplicantNum(string applicantNum)
        {
            return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGetByApplicantNum(applicantNum), typeof(ApplicantPersonalDetailsInfo));
        }
        // get offer details 
        public ApplicantPersonalDetailsInfo GetOfferDetails(int applicantID)
        {
            return (ApplicantPersonalDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantPersonalDetailsGetOfferDetails(applicantID), typeof(ApplicantPersonalDetailsInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsList(), typeof(ApplicantPersonalDetailsInfo));
        }

        // list by position applied for and application status is null (notshortlisted)
        public ArrayList ListByPositionNotShortlisted(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionNotShortlisted(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }

        //list by position applied for and application Status is shortlisted but interviewer decision is null
        public ArrayList ListByPositionShortlisted(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionShortlisted(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }
        // list by position applied for both shortlist and not shortlisted
        public ArrayList ListByPositionAppliedForAll(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionAppliedForAll(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }

        // /list by position applied for, shortlisted and interviewer decision is hire or not hire(is null)
        public ArrayList ListByPositionHireOrNot(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionHireAndNot(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }
        // /list by position applied for  and application Status is shortlisted and interviewer decision is hire
        public ArrayList ListByPositionHire(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionHire(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }

        // /list by position applied for  and management approved
        public ArrayList ListByPositionApprove(string positionAppliedFor)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsListByPositionApprove(positionAppliedFor), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList ManagementApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantManagementApprovedList(), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList AcceptanceAppList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsAcceptanceAppList(), typeof(ApplicantPersonalDetailsInfo));
        }
        
        public ArrayList GetByCountryTable(int countryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByCountryTable(countryID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeeDepartmentTable(deptID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeeLevel(levelID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeePositionTable(positionID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByEmployeeWorkLocations(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByEmployeeWorkLocations(workLocationID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByLGATable(int lgaID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByLGATable(lgaID), typeof(ApplicantPersonalDetailsInfo));
        }
        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantPersonalDetailsGetByStateTable(stateID), typeof(ApplicantPersonalDetailsInfo));
        }

        public int Add(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            return (int)DataProvider.Instance().ApplicantPersonalDetailsAdd(objApplicantPersonalDetails.ApplicantNum,objApplicantPersonalDetails.DeptAppliedTo, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.InterviwerDecision, objApplicantPersonalDetails.ManagementDecition, objApplicantPersonalDetails.senID_FK);
        }

        //public int Add(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        //{
        //    return (int)DataProvider.Instance().ApplicantPersonalDetailsAdd(objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.WorkLocationID_FK, objApplicantPersonalDetails.InterviwerDecision, objApplicantPersonalDetails.ManagementDecition);
        //}

        public void Update(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsUpdate(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.WorkLocationID_FK, objApplicantPersonalDetails.InterviwerDecision, objApplicantPersonalDetails.ManagementDecition);
        }
         public void UpdateApplicantNum(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
       {
           DataProvider.Instance().ApplicantPersonalDetailsUpdateApplicantNum(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum);
       }
         // update application Using ApplicantNum
         public void UpdateUsingApplicantNum(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
         {
             DataProvider.Instance().ApplicantPersonalDetailsUpdateUpdateUsingApplicantNum(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicantNum, objApplicantPersonalDetails.PositionAppliedFor, objApplicantPersonalDetails.Title, objApplicantPersonalDetails.FirstName, objApplicantPersonalDetails.MiiddleName, objApplicantPersonalDetails.LastName, objApplicantPersonalDetails.Gender, objApplicantPersonalDetails.DateOfBirth, objApplicantPersonalDetails.Age, objApplicantPersonalDetails.MaritalStatus, objApplicantPersonalDetails.Nationality_FK, objApplicantPersonalDetails.StateOfOrigin_FK, objApplicantPersonalDetails.LGA_FK, objApplicantPersonalDetails.HomeTown, objApplicantPersonalDetails.PhoneNo, objApplicantPersonalDetails.Email, objApplicantPersonalDetails.ContactAddress, objApplicantPersonalDetails.Religion, objApplicantPersonalDetails.Passport, objApplicantPersonalDetails.ApplicationStatus, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.WorkLocationID_FK, objApplicantPersonalDetails.ResumptionDate, objApplicantPersonalDetails.InterviwerDecision, objApplicantPersonalDetails.ManagementDecition);
         }

         // update application status(shortlisted)
         public void UpdateApplicationStatus(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
         {
             DataProvider.Instance().ApplicantPersonalDetailsUpdateApplicationStatus(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ApplicationStatus);

         }
         // update interviewer decision (hire)
         public void UpdateInterviewerDecision(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
         {
             DataProvider.Instance().ApplicantPersonalDetailsUpdateInterviewerDecision(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.WorkLocationID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.ResumptionDate, objApplicantPersonalDetails.InterviwerDecision);

         }
         //ApplicantPersonalDetailsUpdateManagementDecision
         public void UpdateManagementDecision(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
         {
             DataProvider.Instance().ApplicantPersonalDetailsUpdateManagementDecision(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.ManagementDecition);

         }
        
         public void SendingOfferUpdate(ApplicantPersonalDetailsInfo objApplicantPersonalDetails)
        {
            DataProvider.Instance().ApplicantPersonalDetailsSendingOfferUpdate(objApplicantPersonalDetails.ApplicantID, objApplicantPersonalDetails.PositionApproved_FK, objApplicantPersonalDetails.DepartmentID_FK, objApplicantPersonalDetails.LevelID_FK, objApplicantPersonalDetails.WorkLocationID_FK);
        }
        
        public void Delete(int applicantID)
        {
            DataProvider.Instance().ApplicantPersonalDetailsDelete(applicantID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

   
    public class ApplicantQualificationController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantQualificationInfo Get(int qualificationID)
        {
            return (ApplicantQualificationInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantQualificationGet(qualificationID), typeof(ApplicantQualificationInfo));
        }

        //public ApplicantQualificationInfo AppQualificationList()
        //{
        //    //return (ApplicantQualificationInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantQualificationGet(qualificationID), typeof(ApplicantQualificationInfo));

        //    return (ApplicantQualificationInfo)DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppQualificationList(), typeof(ApplicantQualificationInfo)); 
        
        //}

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantQualificationList(), typeof(ApplicantQualificationInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantQualificationGetByApplicantPersonalDetails(applicantID), typeof(ApplicantQualificationInfo));
        }

        public int Add(ApplicantQualificationInfo objApplicantQualification)
        {
            return (int)DataProvider.Instance().ApplicantQualificationAdd(objApplicantQualification.InstitutionName, objApplicantQualification.QualificationType, objApplicantQualification.Course, objApplicantQualification.Grade, objApplicantQualification.StartYear, objApplicantQualification.EndYear, objApplicantQualification.ApplicantID_FK);
        }

        public void Update(ApplicantQualificationInfo objApplicantQualification)
        {
            DataProvider.Instance().ApplicantQualificationUpdate(objApplicantQualification.QualificationID, objApplicantQualification.InstitutionName, objApplicantQualification.QualificationType, objApplicantQualification.Course, objApplicantQualification.Grade, objApplicantQualification.StartYear, objApplicantQualification.EndYear, objApplicantQualification.ApplicantID_FK);
        }

        public void Delete(int qualificationID)
        {
            DataProvider.Instance().ApplicantQualificationDelete(qualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    public class ApplicantProfQualificationController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantProfQualificationInfo Get(int profQualificationID)
        {
            return (ApplicantProfQualificationInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantProfQualificationGet(profQualificationID), typeof(ApplicantProfQualificationInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantProfQualificationList(), typeof(ApplicantProfQualificationInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantProfQualificationGetByApplicantPersonalDetails(applicantID), typeof(ApplicantProfQualificationInfo));
        }

        public int Add(ApplicantProfQualificationInfo objApplicantProfQualification)
        {
            return (int)DataProvider.Instance().ApplicantProfQualificationAdd(objApplicantProfQualification.CertificationName, objApplicantProfQualification.CertificateNo, objApplicantProfQualification.Stage, objApplicantProfQualification.CertYear, objApplicantProfQualification.ApplicantID_FK);
        }

        public void Update(ApplicantProfQualificationInfo objApplicantProfQualification)
        {
            DataProvider.Instance().ApplicantProfQualificationUpdate(objApplicantProfQualification.ProfQualificationID, objApplicantProfQualification.CertificationName, objApplicantProfQualification.CertificateNo, objApplicantProfQualification.Stage, objApplicantProfQualification.CertYear, objApplicantProfQualification.ApplicantID_FK);
        }

        public void Delete(int profQualificationID)
        {
            DataProvider.Instance().ApplicantProfQualificationDelete(profQualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    public class ApplicantWorkExperienceController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantWorkExperienceInfo Get(int workExperienceID)
        {
            return (ApplicantWorkExperienceInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantWorkExperienceGet(workExperienceID), typeof(ApplicantWorkExperienceInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantWorkExperienceList(), typeof(ApplicantWorkExperienceInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantWorkExperienceGetByApplicantPersonalDetails(applicantID), typeof(ApplicantWorkExperienceInfo));
        }

        public int Add(ApplicantWorkExperienceInfo objApplicantWorkExperience)
        {
            return (int)DataProvider.Instance().ApplicantWorkExperienceAdd(objApplicantWorkExperience.CompanyName, objApplicantWorkExperience.PositionHeld, objApplicantWorkExperience.JobDescriprtion, objApplicantWorkExperience.SalaryReceived, objApplicantWorkExperience.StartYear, objApplicantWorkExperience.EndYear, objApplicantWorkExperience.ApplicantID_FK);
        }

        public void Update(ApplicantWorkExperienceInfo objApplicantWorkExperience)
        {
            DataProvider.Instance().ApplicantWorkExperienceUpdate(objApplicantWorkExperience.WorkExperienceID, objApplicantWorkExperience.CompanyName, objApplicantWorkExperience.PositionHeld, objApplicantWorkExperience.JobDescriprtion, objApplicantWorkExperience.SalaryReceived, objApplicantWorkExperience.StartYear, objApplicantWorkExperience.EndYear, objApplicantWorkExperience.ApplicantID_FK);
        }

        public void Delete(int workExperienceID)
        {
            DataProvider.Instance().ApplicantWorkExperienceDelete(workExperienceID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    public class ApplicantDocumentController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public ApplicantDocumentInfo Get(int documentID)
        {
            return (ApplicantDocumentInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantDocumentGet(documentID), typeof(ApplicantDocumentInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantDocumentList(), typeof(ApplicantDocumentInfo));
        }

        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantDocumentGetByApplicantPersonalDetails(applicantID), typeof(ApplicantDocumentInfo));
        }

        public int Add(ApplicantDocumentInfo objApplicantDocument)
        {
            return (int)DataProvider.Instance().ApplicantDocumentAdd(objApplicantDocument.DocumentType, objApplicantDocument.DocumentPath, objApplicantDocument.ApplicantID_FK);
        }

        public void Update(ApplicantDocumentInfo objApplicantDocument)
        {
            DataProvider.Instance().ApplicantDocumentUpdate(objApplicantDocument.DocumentID, objApplicantDocument.DocumentType, objApplicantDocument.DocumentPath, objApplicantDocument.ApplicantID_FK);
        }

        public void Delete(int documentID)
        {
            DataProvider.Instance().ApplicantDocumentDelete(documentID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    public class EmployeeDepartmentTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDepartmentTableInfo Get(int deptID)
        {
            return (EmployeeDepartmentTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDepartmentTableGet(deptID), typeof(EmployeeDepartmentTableInfo));
        }
        public ArrayList GetAll()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDepartmentTableGetAll(), typeof(EmployeeDepartmentTableInfo));
        }
       
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDepartmentTableList(), typeof(EmployeeDepartmentTableInfo));
        }


        public int Add(EmployeeDepartmentTableInfo objEmployeeDepartmentTable)
        {
            return (int)DataProvider.Instance().EmployeeDepartmentTableAdd(objEmployeeDepartmentTable.DeptName);
        }

        public void Update(EmployeeDepartmentTableInfo objEmployeeDepartmentTable)
        {
            DataProvider.Instance().EmployeeDepartmentTableUpdate(objEmployeeDepartmentTable.DeptID, objEmployeeDepartmentTable.DeptName);
        }

        public void Delete(int deptID)
        {
            DataProvider.Instance().EmployeeDepartmentTableDelete(deptID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //EmployeePositionTableController

    public class EmployeePositionTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeePositionTableInfo Get(int positionID)
        {
            return (EmployeePositionTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeePositionTableGet(positionID), typeof(EmployeePositionTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePositionTableList(), typeof(EmployeePositionTableInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePositionTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeePositionTableInfo));
        }

        public int Add(EmployeePositionTableInfo objEmployeePositionTable)
        {
            return (int)DataProvider.Instance().EmployeePositionTableAdd(objEmployeePositionTable.PositionName, objEmployeePositionTable.DeptID_FK);
        }

        public void Update(EmployeePositionTableInfo objEmployeePositionTable)
        {
            DataProvider.Instance().EmployeePositionTableUpdate(objEmployeePositionTable.PositionID, objEmployeePositionTable.PositionName, objEmployeePositionTable.DeptID_FK);
        }

        public void Delete(int positionID)
        {
            DataProvider.Instance().EmployeePositionTableDelete(positionID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeLevelController
    public class EmployeeLevelController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeLevelInfo Get(int levelID)
        {
            return (EmployeeLevelInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLevelGet(levelID), typeof(EmployeeLevelInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLevelList(), typeof(EmployeeLevelInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLevelGetByEmployeeDepartmentTable(deptID), typeof(EmployeeLevelInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLevelGetByEmployeePositionTable(positionID), typeof(EmployeeLevelInfo));
        }

        public int Add(EmployeeLevelInfo objEmployeeLevel)
        {
            return (int)DataProvider.Instance().EmployeeLevelAdd(objEmployeeLevel.LevelName, objEmployeeLevel.Salary, objEmployeeLevel.SalaryDetails, objEmployeeLevel.DeptID_FK, objEmployeeLevel.PositionID_FK, objEmployeeLevel.LeaveEntitle, objEmployeeLevel.EmployeeCadre);
        }

        public void Update(EmployeeLevelInfo objEmployeeLevel)
        {
            DataProvider.Instance().EmployeeLevelUpdate(objEmployeeLevel.LevelID, objEmployeeLevel.LevelName, objEmployeeLevel.Salary, objEmployeeLevel.SalaryDetails, objEmployeeLevel.DeptID_FK, objEmployeeLevel.PositionID_FK, objEmployeeLevel.LeaveEntitle, objEmployeeLevel.EmployeeCadre);
        }

        public void Delete(int levelID)
        {
            DataProvider.Instance().EmployeeLevelDelete(levelID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

   

    public class EmployeeWorkLocationsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeWorkLocationsInfo Get(int workLocationID)
        {
            return (EmployeeWorkLocationsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeWorkLocationsGet(workLocationID), typeof(EmployeeWorkLocationsInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeWorkLocationsList(), typeof(EmployeeWorkLocationsInfo));
        }


        public int Add(EmployeeWorkLocationsInfo objEmployeeWorkLocations)
        {
            return (int)DataProvider.Instance().EmployeeWorkLocationsAdd(objEmployeeWorkLocations.LocationName, objEmployeeWorkLocations.LocationAddress);
        }

        public void Update(EmployeeWorkLocationsInfo objEmployeeWorkLocations)
        {
            DataProvider.Instance().EmployeeWorkLocationsUpdate(objEmployeeWorkLocations.WorkLocationID, objEmployeeWorkLocations.LocationName, objEmployeeWorkLocations.LocationAddress);
        }

        public void Delete(int workLocationID)
        {
            DataProvider.Instance().EmployeeWorkLocationsDelete(workLocationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


   // ApplicantInterviewController

    public class ApplicantInterviewController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
	{
		#region "Public Methods"		
		public ApplicantInterviewInfo Get(int interviewID)
		{
			return (ApplicantInterviewInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().ApplicantInterviewGet(interviewID), typeof(ApplicantInterviewInfo));
		}

		public ArrayList List()
		{
			return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantInterviewList(), typeof(ApplicantInterviewInfo));
		}
        public ArrayList InterviewApprovedApplicantList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().InterviewApprovedApplicantList(), typeof(ApplicantInterviewInfo));
        }

		public ArrayList GetByApplicantRatingKey(int ratingKeyID )
		{
			return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().ApplicantInterviewGetByApplicantRatingKey(ratingKeyID), typeof(ApplicantInterviewInfo));
		}
	
		public int Add(ApplicantInterviewInfo objApplicantInterview)
		{
			return (int)DataProvider.Instance().ApplicantInterviewAdd(objApplicantInterview.Interviewer, objApplicantInterview.InterviewDate, objApplicantInterview.ApplicantID_FK, objApplicantInterview.ApplicantNum, objApplicantInterview.Experience, objApplicantInterview.Education, objApplicantInterview.PositionInterest, objApplicantInterview.Presentation, objApplicantInterview.ProblemSolvingSkill, objApplicantInterview.ComputerSkill, objApplicantInterview.JobStability, objApplicantInterview.OtherCriteria, objApplicantInterview.KnowledgeLevel, objApplicantInterview.PositionExcitement, objApplicantInterview.ExperienceLevel, objApplicantInterview.EffectiveParticipation, objApplicantInterview.CommunicationLevel, objApplicantInterview.FinalListInclusion, objApplicantInterview.Strength, objApplicantInterview.Weakness, objApplicantInterview.AdditionalComment, objApplicantInterview.Recommendation, objApplicantInterview.HODName, objApplicantInterview.HODRecommendation, objApplicantInterview.ManagementRecommendation, objApplicantInterview.RatingKeyID_FK);
		}
	
		public void Update(ApplicantInterviewInfo objApplicantInterview)
		{
			DataProvider.Instance().ApplicantInterviewUpdate(objApplicantInterview.InterviewID, objApplicantInterview.Interviewer, objApplicantInterview.InterviewDate, objApplicantInterview.ApplicantID_FK, objApplicantInterview.ApplicantNum, objApplicantInterview.Experience, objApplicantInterview.Education, objApplicantInterview.PositionInterest, objApplicantInterview.Presentation, objApplicantInterview.ProblemSolvingSkill, objApplicantInterview.ComputerSkill, objApplicantInterview.JobStability, objApplicantInterview.OtherCriteria, objApplicantInterview.KnowledgeLevel, objApplicantInterview.PositionExcitement, objApplicantInterview.ExperienceLevel, objApplicantInterview.EffectiveParticipation, objApplicantInterview.CommunicationLevel, objApplicantInterview.FinalListInclusion, objApplicantInterview.Strength, objApplicantInterview.Weakness, objApplicantInterview.AdditionalComment, objApplicantInterview.Recommendation, objApplicantInterview.HODName, objApplicantInterview.HODRecommendation, objApplicantInterview.ManagementRecommendation, objApplicantInterview.RatingKeyID_FK);
		}
		
		public void Delete(int interviewID)
		{
			DataProvider.Instance().ApplicantInterviewDelete(interviewID);
		}
		#endregion

		#region "Optional Interfaces"		
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
		{
			return null;
		}
	
        public string ExportModule(int ModuleID)
		{
			return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
		{
		}
		#endregion
	}

    //EmployeeDetailsControl

    public class EmployeeDetailsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDetailsInfo Get(int employeeID)
        {
            return (EmployeeDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsGet(employeeID), typeof(EmployeeDetailsInfo));
        }
        public EmployeeDetailsInfo GetByEmployeeLevelForLeave(int employeeLevel_FK)
        {
            return (EmployeeDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsGetByEmployeeLevelForLeave(employeeLevel_FK), typeof(EmployeeDetailsInfo));
        }

        //For printing Employee List       

      
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList ListOrderByDeptAndLocation()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsListOrderByDeptAndLocation(), typeof(EmployeeDetailsInfo));
        }
       
        public ArrayList ListByDeptAndLocation(int deptID, int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsListByDeptAndLocation(deptID, workLocationID), typeof(EmployeeDetailsInfo));
        }
  
         
        public ArrayList SupAppraisalList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsSupAppraisalList(), typeof(EmployeeDetailsInfo));
        }

       
        public ArrayList HRAppraisalList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsHRAppraisalList(), typeof(EmployeeDetailsInfo));
        }
        
       
        public ArrayList HiredList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsHiredList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList UnconfirmedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsUnconfirmedList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList ConfirmedEmployeeList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsConfirmedEmployeeList(), typeof(EmployeeDetailsInfo));
        }
        
        public ArrayList QualifUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsQualifUnApprovedList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList ProfQualifUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsProfQualifUnApprovedList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList DocUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsDocUnApprovedList(), typeof(EmployeeDetailsInfo));
        }
        public ArrayList PromotionList(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsPromotionList(deptID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList SelfAppraisalList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsSelfAppraisalList(), typeof(EmployeeDetailsInfo));
        }
         public ArrayList SupEmpList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsSupEmpList(), typeof(EmployeeDetailsInfo));
        }

         public ArrayList GetBySupervisor(int supervisorID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetBySupervisor(supervisorID), typeof(EmployeeDetailsInfo));
        }
         public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByApplicantPersonalDetails(applicantID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByCountryTable(int countryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByCountryTable(countryID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeDepartmentTable(deptID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeeDepartmentTableForPromoHist(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeDepartmentTableForPromoHist(deptID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmpDeptAndLocation(int deptID, int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmpDeptAndLocation(deptID, workLocationID), typeof(EmployeeDetailsInfo));
        }
        
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeDetails(employeeID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeLevel(levelID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeePositionTable(positionID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByEmployeeWorkLocations(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByEmployeeWorkLocations(workLocationID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByLGATable(int lgaID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByLGATable(lgaID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByStateTable(stateID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsGetByUsers(userID), typeof(EmployeeDetailsInfo));
        }

        public EmployeeDetailsInfo GetByUserID(int userID)
        {
            return (EmployeeDetailsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsGetByUserID(userID), typeof(EmployeeDetailsInfo));
        }

       
        public int Add(EmployeeDetailsInfo objEmployeeDetails)
        {
            return (int)DataProvider.Instance().EmployeeDetailsAdd(objEmployeeDetails.EmployeeNum, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.Gender, objEmployeeDetails.DateOfBirth, objEmployeeDetails.Age, objEmployeeDetails.MaritalStatus, objEmployeeDetails.Nationality_FK, objEmployeeDetails.StateOfOrigin_FK, objEmployeeDetails.LGA_FK, objEmployeeDetails.HomeTown, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion, objEmployeeDetails.Passport, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName, objEmployeeDetails.Department_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy, objEmployeeDetails.EmployeeStatus, objEmployeeDetails.StartDate, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.ApplicantID_FK, objEmployeeDetails.HRID, objEmployeeDetails.senID_FK);
        }
        //public int Add(EmployeeDetailsInfo objEmployeeDetails)
        //{
        //    return (int)DataProvider.Instance().EmployeeDetailsAdd(objEmployeeDetails.EmployeeNum, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.Gender, objEmployeeDetails.DateOfBirth, objEmployeeDetails.Age, objEmployeeDetails.MaritalStatus, objEmployeeDetails.Nationality_FK, objEmployeeDetails.StateOfOrigin_FK, objEmployeeDetails.LGA_FK, objEmployeeDetails.HomeTown, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion, objEmployeeDetails.Passport, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName, objEmployeeDetails.Department_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy, objEmployeeDetails.EmployeeStatus, objEmployeeDetails.StartDate, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.ApplicantID_FK, objEmployeeDetails.EmployeeUserID_FK);
        //}
        public void Update(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeNum, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.Gender, objEmployeeDetails.DateOfBirth, objEmployeeDetails.Age, objEmployeeDetails.MaritalStatus, objEmployeeDetails.Nationality_FK, objEmployeeDetails.StateOfOrigin_FK, objEmployeeDetails.LGA_FK, objEmployeeDetails.HomeTown, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion, objEmployeeDetails.Passport, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName, objEmployeeDetails.Department_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy, objEmployeeDetails.EmployeeStatus, objEmployeeDetails.StartDate, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.ApplicantID_FK, objEmployeeDetails.EmployeeUserID_FK);
        }
        
        public void EditBasicInfoUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsEditBasicInfoUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.Title, objEmployeeDetails.FirstName, objEmployeeDetails.MiiddleName, objEmployeeDetails.LastName, objEmployeeDetails.MaritalStatus, objEmployeeDetails.PhoneNo, objEmployeeDetails.Email, objEmployeeDetails.ContactAddress, objEmployeeDetails.Religion,  objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.BankName);
        }
        

           public void UpdateEmployeeNum(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateEmployeeNum(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeNum);
        }

           public void UpdateEmployeeUserID(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateEmployeeUserID(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeUserID_FK);
        }

        
        public void NextOfKinUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsNextOfKinUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship, objEmployeeDetails.EmployeeUserID_FK);
        }
        public void EditNOKUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsEditNOKUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.NxtOfKinFName, objEmployeeDetails.NxtOfKinMidName, objEmployeeDetails.NxtOfKinLName, objEmployeeDetails.NxtOfKinAddress, objEmployeeDetails.NxtOfKinPhoneNo, objEmployeeDetails.NxtOfKinEmail, objEmployeeDetails.NxtOfKinOccupation, objEmployeeDetails.NxtOfKinRelationship);
        }
        

        public void SpouseUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsSpouseUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames, objEmployeeDetails.EmployeeUserID_FK);
        }
        public void EditSpouseDetailsUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsEditSpouseDetailsUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.SpouseNames, objEmployeeDetails.SpouseAddress, objEmployeeDetails.SpousePhoneNo, objEmployeeDetails.SpouseEmail, objEmployeeDetails.SpouseOccupation, objEmployeeDetails.SpouseEmployerNames);
        }
        

        public void RefereeUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsRefereeUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.Refree1Names, objEmployeeDetails.Refree1Occupation, objEmployeeDetails.Refree1PhoneNum, objEmployeeDetails.Refree1Email, objEmployeeDetails.Refree1ContactAddr, objEmployeeDetails.Refree2Names, objEmployeeDetails.Refree2Occupation, objEmployeeDetails.Refree2PhoneNum, objEmployeeDetails.Refree2Email, objEmployeeDetails.Refree2ContactAddr, objEmployeeDetails.EmployeeUserID_FK);
        }

        public void BankInfoUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsBankInfoUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.BankName, objEmployeeDetails.AccountName, objEmployeeDetails.AccountNo, objEmployeeDetails.EmployeeUserID_FK);
        }

        public void GuarantorUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsGuarantorUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.GuarrantorNames, objEmployeeDetails.GuarrantorFormPath, objEmployeeDetails.EmployeeUserID_FK);
        }
        public void UpdateConfirmation(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateConfirmation(objEmployeeDetails.EmployeeID, objEmployeeDetails.ConfirmationDate, objEmployeeDetails.ConfirmedBy);
        }
        public void TransferUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsTransferUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.Department_FK, objEmployeeDetails.WorkLocation_FK, objEmployeeDetails.TransferDate, objEmployeeDetails.TransferedBy);
        }
        public void PromoUpdate(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsPromoUpdate(objEmployeeDetails.EmployeeID, objEmployeeDetails.EmployeeLevel_FK, objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.PromotionDate, objEmployeeDetails.PromotedBy, objEmployeeDetails.EmployeeStatus);
        }
        public void UpdateEmpHOD(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateEmpHOD(objEmployeeDetails.EmployeeID, objEmployeeDetails.HODID);
        }
        public void UpdateHODNewPositionAsHOD(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateHODNewPositionAsHOD(objEmployeeDetails.EmployeeID,  objEmployeeDetails.PositionHeld_FK, objEmployeeDetails.HODID);
        }
        public void UpdateEmpSupervisor(EmployeeDetailsInfo objEmployeeDetails)
        {
            DataProvider.Instance().EmployeeDetailsUpdateEmpSupervisor(objEmployeeDetails.EmployeeID, objEmployeeDetails.SupervisorID);
        }
        
        public void Delete(int employeeID)
        {
            DataProvider.Instance().EmployeeDetailsDelete(employeeID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //EmployeeDetailsLogController

    public class EmployeeDetailsLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDetailsLogInfo LogGet(int employeeLogID)
        {
            return (EmployeeDetailsLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsLogGet(employeeLogID), typeof(EmployeeDetailsLogInfo));
        }
        public EmployeeDetailsLogInfo LogGetByEmployeeDetails(int employeeID)
        {
            return (EmployeeDetailsLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsLogGetByEmployeeDetails(employeeID), typeof(EmployeeDetailsLogInfo));
        }
        public ArrayList LogList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogList(), typeof(EmployeeDetailsLogInfo));
        }
        
        
        public ArrayList LogGetBySupervisor(int supervisorID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetBySupervisor(supervisorID), typeof(EmployeeDetailsLogInfo));
        }
      
        public ArrayList LogGetByCountryTable(int countryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByCountryTable(countryID), typeof(EmployeeDetailsLogInfo));
        }
        public ArrayList LogGetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByEmployeeDepartmentTable(deptID), typeof(EmployeeDetailsLogInfo));
        }      
        public ArrayList LogGetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByEmployeeLevel(levelID), typeof(EmployeeDetailsInfo));
        }
        public ArrayList LogGetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByEmployeePositionTable(positionID), typeof(EmployeeDetailsLogInfo));
        }
        public ArrayList LogGetByEmployeeWorkLocations(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByEmployeeWorkLocations(workLocationID), typeof(EmployeeDetailsLogInfo));
        }
        public ArrayList LogGetByLGATable(int lgaID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByLGATable(lgaID), typeof(EmployeeDetailsLogInfo));
        }
        public ArrayList GetByStateTable(int stateID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByStateTable(stateID), typeof(EmployeeDetailsLogInfo));
        }
        public ArrayList LogGetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsLogGetByUsers(userID), typeof(EmployeeDetailsLogInfo));
        }

        public EmployeeDetailsLogInfo LogGetByUserID(int userID)
        {
            return (EmployeeDetailsLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDetailsLogGetByUserID(userID), typeof(EmployeeDetailsLogInfo));
        }
        public int LogAdd(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            return (int)DataProvider.Instance().EmployeeDetailsLogAdd(objEmployeeDetailsLog.EmployeeNum, objEmployeeDetailsLog.Title, objEmployeeDetailsLog.FirstName, objEmployeeDetailsLog.MiiddleName, objEmployeeDetailsLog.LastName, objEmployeeDetailsLog.Gender, objEmployeeDetailsLog.DateOfBirth, objEmployeeDetailsLog.Age, objEmployeeDetailsLog.MaritalStatus, objEmployeeDetailsLog.Nationality_FK, objEmployeeDetailsLog.StateOfOrigin_FK, objEmployeeDetailsLog.LGA_FK, objEmployeeDetailsLog.HomeTown, objEmployeeDetailsLog.PhoneNo, objEmployeeDetailsLog.Email, objEmployeeDetailsLog.ContactAddress, objEmployeeDetailsLog.Religion, objEmployeeDetailsLog.Passport,objEmployeeDetailsLog.Department_FK, objEmployeeDetailsLog.PositionHeld_FK, objEmployeeDetailsLog.EmployeeLevel_FK, objEmployeeDetailsLog.WorkLocation_FK,  objEmployeeDetailsLog.StartDate, objEmployeeDetailsLog.ApplicantID_FK, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK, objEmployeeDetailsLog.HRID, objEmployeeDetailsLog.senID_FK);
        }

    
        public void LogUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.EmployeeNum, objEmployeeDetailsLog.Title, objEmployeeDetailsLog.FirstName, objEmployeeDetailsLog.MiiddleName, objEmployeeDetailsLog.LastName, objEmployeeDetailsLog.Gender, objEmployeeDetailsLog.DateOfBirth, objEmployeeDetailsLog.Age, objEmployeeDetailsLog.MaritalStatus, objEmployeeDetailsLog.Nationality_FK, objEmployeeDetailsLog.StateOfOrigin_FK, objEmployeeDetailsLog.LGA_FK, objEmployeeDetailsLog.HomeTown, objEmployeeDetailsLog.PhoneNo, objEmployeeDetailsLog.Email, objEmployeeDetailsLog.ContactAddress, objEmployeeDetailsLog.Religion, objEmployeeDetailsLog.Passport, objEmployeeDetailsLog.AccountName, objEmployeeDetailsLog.AccountNo, objEmployeeDetailsLog.BankName, objEmployeeDetailsLog.Department_FK, objEmployeeDetailsLog.PositionHeld_FK, objEmployeeDetailsLog.EmployeeLevel_FK, objEmployeeDetailsLog.WorkLocation_FK, objEmployeeDetailsLog.ConfirmationDate, objEmployeeDetailsLog.ConfirmedBy, objEmployeeDetailsLog.EmployeeStatus, objEmployeeDetailsLog.StartDate, objEmployeeDetailsLog.NxtOfKinFName, objEmployeeDetailsLog.NxtOfKinMidName, objEmployeeDetailsLog.NxtOfKinLName, objEmployeeDetailsLog.NxtOfKinAddress, objEmployeeDetailsLog.NxtOfKinPhoneNo, objEmployeeDetailsLog.NxtOfKinEmail, objEmployeeDetailsLog.NxtOfKinOccupation, objEmployeeDetailsLog.NxtOfKinRelationship, objEmployeeDetailsLog.SpouseNames, objEmployeeDetailsLog.SpouseAddress, objEmployeeDetailsLog.SpousePhoneNo, objEmployeeDetailsLog.SpouseEmail, objEmployeeDetailsLog.SpouseOccupation, objEmployeeDetailsLog.SpouseEmployerNames, objEmployeeDetailsLog.Refree1Names, objEmployeeDetailsLog.Refree1Occupation, objEmployeeDetailsLog.Refree1PhoneNum, objEmployeeDetailsLog.Refree1Email, objEmployeeDetailsLog.Refree1ContactAddr, objEmployeeDetailsLog.Refree2Names, objEmployeeDetailsLog.Refree2Occupation, objEmployeeDetailsLog.Refree2PhoneNum, objEmployeeDetailsLog.Refree2Email, objEmployeeDetailsLog.Refree2ContactAddr, objEmployeeDetailsLog.GuarrantorNames, objEmployeeDetailsLog.GuarrantorFormPath, objEmployeeDetailsLog.ApplicantID_FK, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK);
        }

        public void LogEditBasicInfoUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogEditBasicInfoUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.Title, objEmployeeDetailsLog.FirstName, objEmployeeDetailsLog.MiiddleName, objEmployeeDetailsLog.LastName, objEmployeeDetailsLog.MaritalStatus, objEmployeeDetailsLog.PhoneNo, objEmployeeDetailsLog.Email, objEmployeeDetailsLog.ContactAddress, objEmployeeDetailsLog.Religion, objEmployeeDetailsLog.AccountName, objEmployeeDetailsLog.AccountNo, objEmployeeDetailsLog.BankName, objEmployeeDetailsLog.EmployeeID_FK);
        }

        public void LogUpdateEmployeeNum(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogUpdateEmployeeNum(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.EmployeeNum, objEmployeeDetailsLog.EmployeeID_FK);
        }

        public void LogUpdateEmployeeUserID(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogUpdateEmployeeUserID(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK);
        }

        public void LogNextOfKinUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogNextOfKinUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.NxtOfKinFName, objEmployeeDetailsLog.NxtOfKinMidName, objEmployeeDetailsLog.NxtOfKinLName, objEmployeeDetailsLog.NxtOfKinAddress, objEmployeeDetailsLog.NxtOfKinPhoneNo, objEmployeeDetailsLog.NxtOfKinEmail, objEmployeeDetailsLog.NxtOfKinOccupation, objEmployeeDetailsLog.NxtOfKinRelationship, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogEditNOKUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogEditNOKUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.NxtOfKinFName, objEmployeeDetailsLog.NxtOfKinMidName, objEmployeeDetailsLog.NxtOfKinLName, objEmployeeDetailsLog.NxtOfKinAddress, objEmployeeDetailsLog.NxtOfKinPhoneNo, objEmployeeDetailsLog.NxtOfKinEmail, objEmployeeDetailsLog.NxtOfKinOccupation, objEmployeeDetailsLog.NxtOfKinRelationship, objEmployeeDetailsLog.EmployeeID_FK);
        }


        public void LogSpouseUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogSpouseUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.SpouseNames, objEmployeeDetailsLog.SpouseAddress, objEmployeeDetailsLog.SpousePhoneNo, objEmployeeDetailsLog.SpouseEmail, objEmployeeDetailsLog.SpouseOccupation, objEmployeeDetailsLog.SpouseEmployerNames, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogEditSpouseDetailsUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogEditSpouseDetailsUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.SpouseNames, objEmployeeDetailsLog.SpouseAddress, objEmployeeDetailsLog.SpousePhoneNo, objEmployeeDetailsLog.SpouseEmail, objEmployeeDetailsLog.SpouseOccupation, objEmployeeDetailsLog.SpouseEmployerNames, objEmployeeDetailsLog.EmployeeID_FK);
        }


        public void LogRefereeUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogRefereeUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.Refree1Names, objEmployeeDetailsLog.Refree1Occupation, objEmployeeDetailsLog.Refree1PhoneNum, objEmployeeDetailsLog.Refree1Email, objEmployeeDetailsLog.Refree1ContactAddr, objEmployeeDetailsLog.Refree2Names, objEmployeeDetailsLog.Refree2Occupation, objEmployeeDetailsLog.Refree2PhoneNum, objEmployeeDetailsLog.Refree2Email, objEmployeeDetailsLog.Refree2ContactAddr, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK);
        }

        public void LogBankInfoUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogBankInfoUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.BankName, objEmployeeDetailsLog.AccountName, objEmployeeDetailsLog.AccountNo, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK);
        }

        public void LogGuarantorUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogGuarantorUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.GuarrantorNames, objEmployeeDetailsLog.GuarrantorFormPath, objEmployeeDetailsLog.EmployeeUserID_FK, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogUpdateConfirmation(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogUpdateConfirmation(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.ConfirmationDate, objEmployeeDetailsLog.ConfirmedBy, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogTransferUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogTransferUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.Department_FK, objEmployeeDetailsLog.WorkLocation_FK, objEmployeeDetailsLog.TransferDate, objEmployeeDetailsLog.TransferedBy, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogPromoUpdate(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogPromoUpdate(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.EmployeeLevel_FK, objEmployeeDetailsLog.PositionHeld_FK, objEmployeeDetailsLog.PromotionDate, objEmployeeDetailsLog.PromotedBy, objEmployeeDetailsLog.EmployeeStatus, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogUpdateEmpHOD(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogUpdateEmpHOD(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.HODID, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogUpdateHODNewPositionAsHOD(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogUpdateHODNewPositionAsHOD(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.PositionHeld_FK, objEmployeeDetailsLog.HODID, objEmployeeDetailsLog.EmployeeID_FK);
        }
        public void LogUpdateEmpSupervisor(EmployeeDetailsLogInfo objEmployeeDetailsLog)
        {
            DataProvider.Instance().EmployeeDetailsLogUpdateEmpSupervisor(objEmployeeDetailsLog.EmployeeLogID, objEmployeeDetailsLog.SupervisorID, objEmployeeDetailsLog.EmployeeID_FK);
        }




        public void Delete(int employeeLogID)
        {
            DataProvider.Instance().EmployeeDetailsLogDelete(employeeLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeQualificationTableController

    public class EmployeeQualificationTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeQualificationTableInfo Get(int qualificationID)
        {
            return (EmployeeQualificationTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeQualificationTableGet(qualificationID), typeof(EmployeeQualificationTableInfo));
        }
        public EmployeeQualificationTableInfo GetByEmployeeDetailsForInfo(int employeeID)
        {
            return (EmployeeQualificationTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeQualificationTableGetByEmployeeDetailsForInfo(employeeID), typeof(EmployeeQualificationTableInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableList(), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList QualificationUnApprovedList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableUnApprovedList(), typeof(EmployeeQualificationTableInfo));
        }

        
        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableGetByApplicantPersonalDetails(applicantID), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableGetByEmployeeDetails(employeeID), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList QualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationUnApprovedGetByEmployeeDetails(employeeID), typeof(EmployeeQualificationTableInfo));
        }
        public ArrayList ApprovedQualifGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQualificationTableApprovedQualifGetByEmployeeDetails(employeeID), typeof(EmployeeQualificationTableInfo));
        }
        
        public int Add(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeQualificationTableAdd(objEmployeeQualificationTable.InstitutionName, objEmployeeQualificationTable.QualificationType, objEmployeeQualificationTable.Course, objEmployeeQualificationTable.Grade, objEmployeeQualificationTable.StartYear, objEmployeeQualificationTable.EndYear, objEmployeeQualificationTable.ApplicantID_FK);
        }

        public int NewAdd(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeQualificationTableNewAdd(objEmployeeQualificationTable.InstitutionName, objEmployeeQualificationTable.QualificationType, objEmployeeQualificationTable.Course, objEmployeeQualificationTable.Grade, objEmployeeQualificationTable.StartYear, objEmployeeQualificationTable.EndYear, objEmployeeQualificationTable.ApplicantID_FK, objEmployeeQualificationTable.EmployeeID_FK, objEmployeeQualificationTable.EmployeeLogID_FK);
        }

        public void Update(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            DataProvider.Instance().EmployeeQualificationTableUpdate(objEmployeeQualificationTable.QualificationID, objEmployeeQualificationTable.InstitutionName, objEmployeeQualificationTable.QualificationType, objEmployeeQualificationTable.Course, objEmployeeQualificationTable.Grade, objEmployeeQualificationTable.StartYear, objEmployeeQualificationTable.EndYear, objEmployeeQualificationTable.ApplicantID_FK, objEmployeeQualificationTable.EmployeeID_FK, objEmployeeQualificationTable.EmployeeLogID_FK);
        }
        public void QualificationTableEmpIDUpdate(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            DataProvider.Instance().EmployeeQualificationTableEmpIDUpdate(objEmployeeQualificationTable.HrApproval, objEmployeeQualificationTable.ApplicantID_FK, objEmployeeQualificationTable.EmployeeID_FK, objEmployeeQualificationTable.EmployeeLogID_FK);
        }
        public void HrApprovalUpdate(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            DataProvider.Instance().EmployeeQualificationTableHrApprovalUpdate(objEmployeeQualificationTable.EmployeeID_FK, objEmployeeQualificationTable.HrApproval);
        }
        public void AcceptanceApprovalUpdate(EmployeeQualificationTableInfo objEmployeeQualificationTable)
        {
            DataProvider.Instance().EmployeeQualificationTableAcceptanceApprovalUpdate(objEmployeeQualificationTable.QualificationID, objEmployeeQualificationTable.HrApproval, objEmployeeQualificationTable.ApplicantID_FK, objEmployeeQualificationTable.EmployeeID_FK, objEmployeeQualificationTable.EmployeeLogID_FK);
        }
        
        
        public void Delete(int qualificationID)
        {
            DataProvider.Instance().EmployeeQualificationTableDelete(qualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeProfQualificationTableController

    public class EmployeeProfQualificationTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeProfQualificationTableInfo Get(int profQualificationID)
        {
            return (EmployeeProfQualificationTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeProfQualificationTableGet(profQualificationID), typeof(EmployeeProfQualificationTableInfo));
        }
        public EmployeeProfQualificationTableInfo GetByEmployeeDetailsForInfo(int employeeID)
        {
            return (EmployeeProfQualificationTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeProfQualificationTableGetByEmployeeDetailsForInfo(employeeID), typeof(EmployeeProfQualificationTableInfo));
        }
      
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableList(), typeof(EmployeeProfQualificationTableInfo));
        }     

        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableGetByEmployeeDetails(employeeID), typeof(EmployeeProfQualificationTableInfo));
        }
        public ArrayList ApprovedProfQualifGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails(employeeID), typeof(EmployeeProfQualificationTableInfo));
        }
        
        public ArrayList ProfQualificationUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationUnApprovedGetByEmployeeDetails(employeeID), typeof(EmployeeProfQualificationTableInfo));
        }
        
        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeProfQualificationTableGetByApplicantPersonalDetails(applicantID), typeof(EmployeeProfQualificationTableInfo));
        }

        public int Add(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeProfQualificationTableAdd(objEmployeeProfQualificationTable.CertificationName, objEmployeeProfQualificationTable.CertificateNo, objEmployeeProfQualificationTable.Stage, objEmployeeProfQualificationTable.CertYear, objEmployeeProfQualificationTable.ApplicantID_FK);
        }
        public int NewAdd(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            return (int)DataProvider.Instance().EmployeeProfQualificationTableNewAdd(objEmployeeProfQualificationTable.CertificationName, objEmployeeProfQualificationTable.CertificateNo, objEmployeeProfQualificationTable.Stage, objEmployeeProfQualificationTable.CertYear, objEmployeeProfQualificationTable.ApplicantID_FK, objEmployeeProfQualificationTable.employeeID_FK, objEmployeeProfQualificationTable.EmployeeLogID_FK);
        }
        public void Update(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            DataProvider.Instance().EmployeeProfQualificationTableUpdate(objEmployeeProfQualificationTable.ProfQualificationID, objEmployeeProfQualificationTable.CertificationName, objEmployeeProfQualificationTable.CertificateNo, objEmployeeProfQualificationTable.Stage, objEmployeeProfQualificationTable.CertYear, objEmployeeProfQualificationTable.ApplicantID_FK, objEmployeeProfQualificationTable.employeeID_FK, objEmployeeProfQualificationTable.EmployeeLogID_FK);
        }
        public void ProfQualificationTableEmpIDUpdate(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            DataProvider.Instance().EmployeeProfQualificationTableEmpIDUpdate(objEmployeeProfQualificationTable.HrApproval, objEmployeeProfQualificationTable.ApplicantID_FK, objEmployeeProfQualificationTable.employeeID_FK, objEmployeeProfQualificationTable.EmployeeLogID_FK );
        }
        public void HrApprovalUpdate(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            DataProvider.Instance().EmployeeProfQualificationTableHrApprovalUpdate(objEmployeeProfQualificationTable.employeeID_FK, objEmployeeProfQualificationTable.HrApproval);
        }
        public void AcceptanceApprovalUpdate(EmployeeProfQualificationTableInfo objEmployeeProfQualificationTable)
        {
            DataProvider.Instance().EmployeeProfQualificationTableAcceptanceApprovalUpdate(objEmployeeProfQualificationTable.ProfQualificationID, objEmployeeProfQualificationTable.HrApproval, objEmployeeProfQualificationTable.ApplicantID_FK, objEmployeeProfQualificationTable.employeeID_FK, objEmployeeProfQualificationTable.EmployeeLogID_FK);
        }
        
        public void Delete(int profQualificationID)
        {
            DataProvider.Instance().EmployeeProfQualificationTableDelete(profQualificationID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeDocumentTableController

    public class EmployeeDocumentTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDocumentTableInfo Get(int documentID)
        {
            return (EmployeeDocumentTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDocumentTableGet(documentID), typeof(EmployeeDocumentTableInfo));
        }
        public EmployeeDocumentTableInfo GetByEmployeeDetailsForInfo(int employeeID)
        {
            return (EmployeeDocumentTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDocumentTableGetByEmployeeDetailsForInfo(employeeID), typeof(EmployeeDocumentTableInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableList(), typeof(EmployeeDocumentTableInfo));
        }
        //public ArrayList DocUnApprovedList()
        //{
        //    return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDetailsDocUnApprovedList(), typeof(EmployeeDocumentTableInfo));
        //}
        
        public ArrayList GetByApplicantPersonalDetails(int applicantID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableGetByApplicantPersonalDetails(applicantID), typeof(EmployeeDocumentTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableGetByEmployeeDetails(employeeID), typeof(EmployeeDocumentTableInfo));
        }
        public ArrayList ApprovedDocGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentTableApprovedDocGetByEmployeeDetails(employeeID), typeof(EmployeeDocumentTableInfo));
        }
        
        public ArrayList DocumentUnApprovedGetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDocumentUnApprovedGetByEmployeeDetails(employeeID), typeof(EmployeeDocumentTableInfo));
        }
        
        public int Add(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            return (int)DataProvider.Instance().EmployeeDocumentTableAdd(objEmployeeDocumentTable.DocumentType, objEmployeeDocumentTable.DocumentPath, objEmployeeDocumentTable.ApplicantID_FK);
        }
        public int NewAdd(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            return (int)DataProvider.Instance().EmployeeDocumentTableNewAdd(objEmployeeDocumentTable.DocumentType, objEmployeeDocumentTable.DocumentPath, objEmployeeDocumentTable.ApplicantID_FK, objEmployeeDocumentTable.EmployeeID_Fk, objEmployeeDocumentTable.EmployeeLogID_FK);
        }
        
        public void Update(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            DataProvider.Instance().EmployeeDocumentTableUpdate(objEmployeeDocumentTable.DocumentID, objEmployeeDocumentTable.DocumentType, objEmployeeDocumentTable.DocumentPath, objEmployeeDocumentTable.ApplicantID_FK, objEmployeeDocumentTable.EmployeeID_Fk, objEmployeeDocumentTable.EmployeeLogID_FK);
        }
        public void DocumentTableEmpIDUpdate(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            DataProvider.Instance().EmployeeDocumentTableEmpIDUpdate(objEmployeeDocumentTable.HrApproval, objEmployeeDocumentTable.ApplicantID_FK, objEmployeeDocumentTable.EmployeeID_Fk, objEmployeeDocumentTable.EmployeeLogID_FK);
        }
        public void HrApprovalUpdate(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            DataProvider.Instance().EmployeeDocumentTableHrApprovalUpdate(objEmployeeDocumentTable.EmployeeID_Fk, objEmployeeDocumentTable.HrApproval);
        }
        public void AcceptanceApprovalUpdate(EmployeeDocumentTableInfo objEmployeeDocumentTable)
        {
            DataProvider.Instance().EmployeeDocumentTableAcceptanceApprovalUpdate(objEmployeeDocumentTable.DocumentID, objEmployeeDocumentTable.HrApproval, objEmployeeDocumentTable.ApplicantID_FK, objEmployeeDocumentTable.EmployeeID_Fk, objEmployeeDocumentTable.EmployeeLogID_FK);
        }
        
        public void Delete(int documentID)
        {
            DataProvider.Instance().EmployeeDocumentTableDelete(documentID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeTrainingTableController

    public class EmployeeTrainingTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeTrainingTableInfo Get(int trainingID)
        {
            return (EmployeeTrainingTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTrainingTableGet(trainingID), typeof(EmployeeTrainingTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTrainingTableList(), typeof(EmployeeTrainingTableInfo));
        }
        public ArrayList HRAprovalList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTrainingTableHRAprovalList(), typeof(EmployeeTrainingTableInfo));
        }
        
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTrainingTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeeTrainingTableInfo));
        }
        public ArrayList HRAprovalGetByEmployeeDeptTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTrainingTableHRAprovalGetByEmployeeDeptTable(deptID), typeof(EmployeeTrainingTableInfo));
        }
        
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTrainingTableGetByEmployeeDetails(employeeID), typeof(EmployeeTrainingTableInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTrainingTableGetByEmployeePositionTable(positionID), typeof(EmployeeTrainingTableInfo));
        }

        public int Add(EmployeeTrainingTableInfo objEmployeeTrainingTable)
        {
            return (int)DataProvider.Instance().EmployeeTrainingTableAdd(objEmployeeTrainingTable.TrainingName, objEmployeeTrainingTable.TrainingLocation, objEmployeeTrainingTable.StartDate, objEmployeeTrainingTable.EndDate, objEmployeeTrainingTable.DepartmentID_FK, objEmployeeTrainingTable.PositionID_FK, objEmployeeTrainingTable.EmployeeID_FK, objEmployeeTrainingTable.TrainingSentBy, objEmployeeTrainingTable.TrainingStatus, objEmployeeTrainingTable.TrainingApprovedBy);
        }

        public void Update(EmployeeTrainingTableInfo objEmployeeTrainingTable)
        {
            DataProvider.Instance().EmployeeTrainingTableUpdate(objEmployeeTrainingTable.TrainingID, objEmployeeTrainingTable.TrainingName, objEmployeeTrainingTable.TrainingLocation, objEmployeeTrainingTable.StartDate, objEmployeeTrainingTable.EndDate, objEmployeeTrainingTable.DepartmentID_FK, objEmployeeTrainingTable.PositionID_FK, objEmployeeTrainingTable.EmployeeID_FK, objEmployeeTrainingTable.TrainingSentBy, objEmployeeTrainingTable.TrainingStatus, objEmployeeTrainingTable.TrainingApprovedBy);
        }
        public void HRApprovalUpdate(EmployeeTrainingTableInfo objEmployeeTrainingTable)
        {
            DataProvider.Instance().EmployeeTrainingTableHRApprovalUpdate(objEmployeeTrainingTable.TrainingID, objEmployeeTrainingTable.TrainingStatus, objEmployeeTrainingTable.TrainingApprovedBy);
        }

        public void Delete(int trainingID)
        {
            DataProvider.Instance().EmployeeTrainingTableDelete(trainingID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //EmployeeTransferTableController

    public class EmployeeTransferTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeTransferTableInfo Get(int transferID)
        {
            return (EmployeeTransferTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableGet(transferID), typeof(EmployeeTransferTableInfo));
        }
        public EmployeeTransferTableInfo GetByEmployeeDetailsForInfo(int employeeID)
        {
            return (EmployeeTransferTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableGetByEmployeeDetailsForInfo(employeeID), typeof(EmployeeTransferTableInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableList(), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList NewList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableNewList(), typeof(EmployeeTransferTableInfo));
        }
        public EmployeeTransferTableInfo ApprovalNameList(EmployeeTransferTableInfo objTransfer)
        {
            return (EmployeeTransferTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableApprovalNameList(objTransfer.PrevWorkLocation, objTransfer.DesireLocation), typeof(EmployeeTransferTableInfo));
        }
        public EmployeeTransferTableInfo ApprovalNameNewList(EmployeeTransferTableInfo objTransfer)
        {
            return (EmployeeTransferTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableApprovalNameNewList(objTransfer.PreviousDept, objTransfer.PrevWorkLocation, objTransfer.DesireLocation), typeof(EmployeeTransferTableInfo));
        }
        //public EmployeeTransferTableInfo ApprovalNameNewList(EmployeeTransferTableInfo objTransfer)
        //{
        //    return (EmployeeTransferTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableApprovalNameNewList(objTransfer.PrevWorkLocation, objTransfer.DesireLocation), typeof(EmployeeTransferTableInfo));
        //}
        
        public EmployeeTransferTableInfo NewApprovalList(EmployeeTransferTableInfo objTransfer)
        {
            return (EmployeeTransferTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableNewApprovalList(objTransfer.PreviousDept, objTransfer.PrevWorkLocation, objTransfer.DesireLocation), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList ApprovalList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableApprovalList(), typeof(EmployeeTransferTableInfo));
        }
        
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByEmployeeDetails(employeeID), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList GetByEmployeeWorkLocations(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByEmployeeWorkLocations(workLocationID), typeof(EmployeeTransferTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableGetByUsers(userID), typeof(EmployeeTransferTableInfo));
        }

        public int Add(EmployeeTransferTableInfo objEmployeeTransferTable)
        {
            return (int)DataProvider.Instance().EmployeeTransferTableAdd(objEmployeeTransferTable.PreviousDept, objEmployeeTransferTable.NewDept, objEmployeeTransferTable.PrevWorkLocation,objEmployeeTransferTable.DesireLocation, objEmployeeTransferTable.NewWorkLcation, objEmployeeTransferTable.TransferType, objEmployeeTransferTable.TransferReason, objEmployeeTransferTable.RequestDate, objEmployeeTransferTable.ApprovalStatus, objEmployeeTransferTable.ApproveDate, objEmployeeTransferTable.TransferDate, objEmployeeTransferTable.EmployeeID_FK, objEmployeeTransferTable.TransferedBy);
        }
        public int RequestAdd(EmployeeTransferTableInfo objEmployeeTransferTable)
        {
            return (int)DataProvider.Instance().EmployeeTransferTableRequestAdd(objEmployeeTransferTable.PreviousDept,objEmployeeTransferTable.NewDept, objEmployeeTransferTable.PrevWorkLocation, objEmployeeTransferTable.DesireLocation, objEmployeeTransferTable.TransferType, objEmployeeTransferTable.TransferReason, objEmployeeTransferTable.RequestDate, objEmployeeTransferTable.ApprovalStatus, objEmployeeTransferTable.ApproveDate, objEmployeeTransferTable.TransferDate, objEmployeeTransferTable.EmployeeID_FK);
        }
        
        public void Update(EmployeeTransferTableInfo objEmployeeTransferTable)
        {
            DataProvider.Instance().EmployeeTransferTableUpdate(objEmployeeTransferTable.TransferID, objEmployeeTransferTable.PreviousDept, objEmployeeTransferTable.NewDept, objEmployeeTransferTable.PrevWorkLocation, objEmployeeTransferTable.NewWorkLcation, objEmployeeTransferTable.TransferType, objEmployeeTransferTable.TransferReason, objEmployeeTransferTable.RequestDate, objEmployeeTransferTable.ApprovalStatus, objEmployeeTransferTable.ApproveDate, objEmployeeTransferTable.TransferDate, objEmployeeTransferTable.EmployeeID_FK, objEmployeeTransferTable.TransferedBy);
        }
        public void UpdateTransferRequest(EmployeeTransferTableInfo objEmployeeTransferTable)
        {
            DataProvider.Instance().EmployeeTransferTableUpdateTransferRequest(objEmployeeTransferTable.TransferID, objEmployeeTransferTable.PreviousDept, objEmployeeTransferTable.NewDept, objEmployeeTransferTable.PrevWorkLocation, objEmployeeTransferTable.DesireLocation, objEmployeeTransferTable.TransferType, objEmployeeTransferTable.TransferReason, objEmployeeTransferTable.RequestDate, objEmployeeTransferTable.EmployeeID_FK);
        }
        
        public void ApprovalUpdate(EmployeeTransferTableInfo objEmployeeTransferTable)
        {
            DataProvider.Instance().EmployeeTransferTableApprovalUpdate(objEmployeeTransferTable.TransferID, objEmployeeTransferTable.NewDept, objEmployeeTransferTable.NewWorkLcation, objEmployeeTransferTable.ApprovalStatus, objEmployeeTransferTable.ApproveDate, objEmployeeTransferTable.TransferDate, objEmployeeTransferTable.TransferedBy);
        }
        
        public void Delete(int transferID)
        {
            DataProvider.Instance().EmployeeTransferTableDelete(transferID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }
    //EmployeeTransferTableLogController

    public class EmployeeTransferTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeTransferTableLogInfo Get(int transferLogID)
        {
            return (EmployeeTransferTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableLogGet(transferLogID), typeof(EmployeeTransferTableLogInfo));
        }
        public EmployeeTransferTableLogInfo GetByEmployeeTransferTableForInfo(int transferID)
        {
            return (EmployeeTransferTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableLogGetByEmployeeTransferTableForInfo(transferID), typeof(EmployeeTransferTableLogInfo));
        }
       
        public EmployeeTransferTableLogInfo LogListEmployeeTransferRecords(EmployeeTransferTableLogInfo objTransferLog)
        {
            return (EmployeeTransferTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTransferTableLogListEmployeeTransferRecords(objTransferLog.EmployeeID_FK, objTransferLog.PreviousDept, objTransferLog.NewDept, objTransferLog.PrevWorkLocation, objTransferLog.DesireLocation, objTransferLog.NewWorkLcation), typeof(EmployeeTransferTableLogInfo));
        }
         
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableLogList(), typeof(EmployeeTransferTableLogInfo));
        }
        public ArrayList LogListByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableLogListByEmployeeDetails(employeeID), typeof(EmployeeTransferTableLogInfo));
        }
      
        
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableLogGetByEmployeeDepartmentTable(deptID), typeof(EmployeeTransferTableLogInfo));
        }
        public ArrayList GetByEmployeeTransferTable(int transferID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableLogGetByEmployeeTransferTable(transferID), typeof(EmployeeTransferTableLogInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableLogGetByEmployeeDetails(employeeID), typeof(EmployeeTransferTableLogInfo));
        }
        public ArrayList GetByEmployeeWorkLocations(int workLocationID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableLogGetByEmployeeWorkLocations(workLocationID), typeof(EmployeeTransferTableLogInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTransferTableLogGetByUsers(userID), typeof(EmployeeTransferTableLogInfo));
        }

        public int Add(EmployeeTransferTableLogInfo objEmployeeTransferTableLog)
        {
            return (int)DataProvider.Instance().EmployeeTransferTableLogAdd(objEmployeeTransferTableLog.PreviousDept, objEmployeeTransferTableLog.NewDept, objEmployeeTransferTableLog.PrevWorkLocation, objEmployeeTransferTableLog.DesireLocation, objEmployeeTransferTableLog.NewWorkLcation, objEmployeeTransferTableLog.TransferType, objEmployeeTransferTableLog.TransferReason, objEmployeeTransferTableLog.RequestDate, objEmployeeTransferTableLog.ApprovalStatus, objEmployeeTransferTableLog.ApproveDate, objEmployeeTransferTableLog.TransferDate, objEmployeeTransferTableLog.EmployeeID_FK, objEmployeeTransferTableLog.TransferedBy, objEmployeeTransferTableLog.TransferID_FK);
        }
        public int LogRequestAdd(EmployeeTransferTableLogInfo objEmployeeTransferTableLog)
        {
            return (int)DataProvider.Instance().EmployeeTransferTableLogRequestAdd(objEmployeeTransferTableLog.PreviousDept,objEmployeeTransferTableLog.NewDept, objEmployeeTransferTableLog.PrevWorkLocation, objEmployeeTransferTableLog.DesireLocation, objEmployeeTransferTableLog.TransferType, objEmployeeTransferTableLog.TransferReason, objEmployeeTransferTableLog.RequestDate,  objEmployeeTransferTableLog.EmployeeID_FK, objEmployeeTransferTableLog.TransferID_FK);
        }
        
        public void Update(EmployeeTransferTableLogInfo objEmployeeTransferTableLog)
        {
            DataProvider.Instance().EmployeeTransferTableLogUpdate(objEmployeeTransferTableLog.TransferLogID, objEmployeeTransferTableLog.PreviousDept, objEmployeeTransferTableLog.NewDept, objEmployeeTransferTableLog.PrevWorkLocation, objEmployeeTransferTableLog.NewWorkLcation, objEmployeeTransferTableLog.TransferType, objEmployeeTransferTableLog.TransferReason, objEmployeeTransferTableLog.RequestDate, objEmployeeTransferTableLog.ApprovalStatus, objEmployeeTransferTableLog.ApproveDate, objEmployeeTransferTableLog.TransferDate, objEmployeeTransferTableLog.EmployeeID_FK, objEmployeeTransferTableLog.TransferedBy, objEmployeeTransferTableLog.TransferID_FK);
        }
        public void LogApprovalUpdate(EmployeeTransferTableLogInfo objEmployeeTransferTableLog)
        {
            DataProvider.Instance().EmployeeTransferTableLogApprovalUpdate(objEmployeeTransferTableLog.TransferLogID, objEmployeeTransferTableLog.NewDept,  objEmployeeTransferTableLog.NewWorkLcation, objEmployeeTransferTableLog.ApprovalStatus, objEmployeeTransferTableLog.ApproveDate, objEmployeeTransferTableLog.TransferDate, objEmployeeTransferTableLog.TransferedBy, objEmployeeTransferTableLog.TransferID_FK);
        }
        
        public void Delete(int transferLogID)
        {
            DataProvider.Instance().EmployeeTransferTableLogDelete(transferLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }
    //Appraisal Module

    #region

    //EmployeeAppraisalTableRatingKeyController

    public class EmployeeAppraisalTableRatingKeyController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeAppraisalTableRatingKeyInfo Get(int ratingKeyID)
        {
            return (EmployeeAppraisalTableRatingKeyInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableRatingKeyGet(ratingKeyID), typeof(EmployeeAppraisalTableRatingKeyInfo));
        }
        public EmployeeAppraisalTableRatingKeyInfo GetByCompetent(int ratingKeyID)
        {
            return (EmployeeAppraisalTableRatingKeyInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableRatingKeyGetByCompetent(ratingKeyID), typeof(EmployeeAppraisalTableRatingKeyInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableRatingKeyList(), typeof(EmployeeAppraisalTableRatingKeyInfo));
        }


        public int Add(EmployeeAppraisalTableRatingKeyInfo objEmployeeAppraisalTableRatingKey)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalTableRatingKeyAdd(objEmployeeAppraisalTableRatingKey.RatingDesc, objEmployeeAppraisalTableRatingKey.RatingPoint);
        }

        public void Update(EmployeeAppraisalTableRatingKeyInfo objEmployeeAppraisalTableRatingKey)
        {
            DataProvider.Instance().EmployeeAppraisalTableRatingKeyUpdate(objEmployeeAppraisalTableRatingKey.RatingKeyID, objEmployeeAppraisalTableRatingKey.RatingDesc, objEmployeeAppraisalTableRatingKey.RatingPoint);
        }

        public void Delete(int ratingKeyID)
        {
            DataProvider.Instance().EmployeeAppraisalTableRatingKeyDelete(ratingKeyID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeAppraisalCompetencyTableController

    public class EmployeeAppraisalCompetencyTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeAppraisalCompetencyTableInfo Get(int competencyID)
        {
            return (EmployeeAppraisalCompetencyTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalCompetencyTableGet(competencyID), typeof(EmployeeAppraisalCompetencyTableInfo));
        }
        public EmployeeAppraisalCompetencyTableInfo GetByEmpID(int employeeID)
        {
            return (EmployeeAppraisalCompetencyTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalCompetencyTableGetByEmpID(employeeID), typeof(EmployeeAppraisalCompetencyTableInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableList(), typeof(EmployeeAppraisalCompetencyTableInfo));
        }

        public ArrayList GetByEmployeeAppraisalTable(int appraisalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeeAppraisalCompetencyTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableGetByEmployeeDetails(employeeID), typeof(EmployeeAppraisalCompetencyTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableGetByUsers(userID), typeof(EmployeeAppraisalCompetencyTableInfo));
        }

        public int Add(EmployeeAppraisalCompetencyTableInfo objEmployeeAppraisalCompetencyTable)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalCompetencyTableAdd(objEmployeeAppraisalCompetencyTable.Quality, objEmployeeAppraisalCompetencyTable.QuaPoint, objEmployeeAppraisalCompetencyTable.Productivity, objEmployeeAppraisalCompetencyTable.ProdPoint, objEmployeeAppraisalCompetencyTable.Knoweldge, objEmployeeAppraisalCompetencyTable.KnowPoint, objEmployeeAppraisalCompetencyTable.Dependability, objEmployeeAppraisalCompetencyTable.DependPoint, objEmployeeAppraisalCompetencyTable.Initiative, objEmployeeAppraisalCompetencyTable.InitPoint, objEmployeeAppraisalCompetencyTable.Judgement, objEmployeeAppraisalCompetencyTable.JudPoint, objEmployeeAppraisalCompetencyTable.Adaptability, objEmployeeAppraisalCompetencyTable.AdaPoint, objEmployeeAppraisalCompetencyTable.InterterpersonalRelationship, objEmployeeAppraisalCompetencyTable.InterPoint, objEmployeeAppraisalCompetencyTable.Puntuality, objEmployeeAppraisalCompetencyTable.PuntPoint, objEmployeeAppraisalCompetencyTable.CommunicationSkills, objEmployeeAppraisalCompetencyTable.ComPoint, objEmployeeAppraisalCompetencyTable.Planning, objEmployeeAppraisalCompetencyTable.PlanPoint, objEmployeeAppraisalCompetencyTable.Leadership, objEmployeeAppraisalCompetencyTable.LeadPoint, objEmployeeAppraisalCompetencyTable.Team, objEmployeeAppraisalCompetencyTable.TeamPoint, objEmployeeAppraisalCompetencyTable.Development, objEmployeeAppraisalCompetencyTable.DevPoint, objEmployeeAppraisalCompetencyTable.OverallPoint, objEmployeeAppraisalCompetencyTable.ExcelArea, objEmployeeAppraisalCompetencyTable.AreaThatNeedsImprovement, objEmployeeAppraisalCompetencyTable.StepsToTake, objEmployeeAppraisalCompetencyTable.AreaThatNeedsAssistance, objEmployeeAppraisalCompetencyTable.EmployeeID_FK, objEmployeeAppraisalCompetencyTable.SupervisorID_FK, objEmployeeAppraisalCompetencyTable.HRID_FK, objEmployeeAppraisalCompetencyTable.AppraisalID_FK);
        }

        public void Update(EmployeeAppraisalCompetencyTableInfo objEmployeeAppraisalCompetencyTable)
        {
            DataProvider.Instance().EmployeeAppraisalCompetencyTableUpdate(objEmployeeAppraisalCompetencyTable.CompetencyID, objEmployeeAppraisalCompetencyTable.Quality, objEmployeeAppraisalCompetencyTable.QuaPoint, objEmployeeAppraisalCompetencyTable.Productivity, objEmployeeAppraisalCompetencyTable.ProdPoint, objEmployeeAppraisalCompetencyTable.Knoweldge, objEmployeeAppraisalCompetencyTable.KnowPoint, objEmployeeAppraisalCompetencyTable.Dependability, objEmployeeAppraisalCompetencyTable.DependPoint, objEmployeeAppraisalCompetencyTable.Initiative, objEmployeeAppraisalCompetencyTable.InitPoint, objEmployeeAppraisalCompetencyTable.Judgement, objEmployeeAppraisalCompetencyTable.JudPoint, objEmployeeAppraisalCompetencyTable.Adaptability, objEmployeeAppraisalCompetencyTable.AdaPoint, objEmployeeAppraisalCompetencyTable.InterterpersonalRelationship, objEmployeeAppraisalCompetencyTable.InterPoint, objEmployeeAppraisalCompetencyTable.Puntuality, objEmployeeAppraisalCompetencyTable.PuntPoint, objEmployeeAppraisalCompetencyTable.CommunicationSkills, objEmployeeAppraisalCompetencyTable.ComPoint, objEmployeeAppraisalCompetencyTable.Planning, objEmployeeAppraisalCompetencyTable.PlanPoint, objEmployeeAppraisalCompetencyTable.Leadership, objEmployeeAppraisalCompetencyTable.LeadPoint, objEmployeeAppraisalCompetencyTable.Team, objEmployeeAppraisalCompetencyTable.TeamPoint, objEmployeeAppraisalCompetencyTable.Development, objEmployeeAppraisalCompetencyTable.DevPoint, objEmployeeAppraisalCompetencyTable.OverallPoint, objEmployeeAppraisalCompetencyTable.ExcelArea, objEmployeeAppraisalCompetencyTable.AreaThatNeedsImprovement, objEmployeeAppraisalCompetencyTable.StepsToTake, objEmployeeAppraisalCompetencyTable.AreaThatNeedsAssistance, objEmployeeAppraisalCompetencyTable.EmployeeID_FK, objEmployeeAppraisalCompetencyTable.SupervisorID_FK, objEmployeeAppraisalCompetencyTable.HRID_FK, objEmployeeAppraisalCompetencyTable.AppraisalID_FK);
        }
        public void SupFirstUpdate(EmployeeAppraisalCompetencyTableInfo objEmployeeAppraisalCompetencyTable)
        {
            DataProvider.Instance().EmployeeAppraisalCompetencyTableSupFirstUpdate(objEmployeeAppraisalCompetencyTable.CompetencyID, objEmployeeAppraisalCompetencyTable.Quality, objEmployeeAppraisalCompetencyTable.QuaPoint, objEmployeeAppraisalCompetencyTable.Productivity, objEmployeeAppraisalCompetencyTable.ProdPoint, objEmployeeAppraisalCompetencyTable.Knoweldge, objEmployeeAppraisalCompetencyTable.KnowPoint, objEmployeeAppraisalCompetencyTable.Dependability, objEmployeeAppraisalCompetencyTable.DependPoint, objEmployeeAppraisalCompetencyTable.Initiative, objEmployeeAppraisalCompetencyTable.InitPoint, objEmployeeAppraisalCompetencyTable.Judgement, objEmployeeAppraisalCompetencyTable.JudPoint, objEmployeeAppraisalCompetencyTable.Adaptability, objEmployeeAppraisalCompetencyTable.AdaPoint, objEmployeeAppraisalCompetencyTable.InterterpersonalRelationship, objEmployeeAppraisalCompetencyTable.InterPoint, objEmployeeAppraisalCompetencyTable.Puntuality, objEmployeeAppraisalCompetencyTable.PuntPoint, objEmployeeAppraisalCompetencyTable.CommunicationSkills, objEmployeeAppraisalCompetencyTable.ComPoint, objEmployeeAppraisalCompetencyTable.Planning, objEmployeeAppraisalCompetencyTable.PlanPoint, objEmployeeAppraisalCompetencyTable.Leadership, objEmployeeAppraisalCompetencyTable.LeadPoint, objEmployeeAppraisalCompetencyTable.Team, objEmployeeAppraisalCompetencyTable.TeamPoint, objEmployeeAppraisalCompetencyTable.Development, objEmployeeAppraisalCompetencyTable.DevPoint, objEmployeeAppraisalCompetencyTable.OverallPoint, objEmployeeAppraisalCompetencyTable.ExcelArea, objEmployeeAppraisalCompetencyTable.AreaThatNeedsImprovement, objEmployeeAppraisalCompetencyTable.StepsToTake, objEmployeeAppraisalCompetencyTable.AreaThatNeedsAssistance, objEmployeeAppraisalCompetencyTable.AppraisalID_FK);
        }
        
        public void Delete(int competencyID)
        {
            DataProvider.Instance().EmployeeAppraisalCompetencyTableDelete(competencyID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

  

    public class EmployeeAppraisalCompetencyTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeAppraisalCompetencyTableLogInfo Get(int competencyLogID)
        {
            return (EmployeeAppraisalCompetencyTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogGet(competencyLogID), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }
        public EmployeeAppraisalCompetencyTableLogInfo EmployeeAppraisalCompetencyTableLogGetByEmpID(int employeeID)
        {
            return (EmployeeAppraisalCompetencyTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogGetByEmpID(employeeID), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogList(), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }

        public ArrayList GetByEmployeeAppraisalCompetencyTable(int competencyID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalCompetencyTable(competencyID), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }
        public ArrayList GetByEmployeeAppraisalTable(int appraisalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogGetByEmployeeDetails(employeeID), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }
        public ArrayList LogGetByEmpDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogGetByEmpDetails(employeeID), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }
        
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalCompetencyTableLogGetByUsers(userID), typeof(EmployeeAppraisalCompetencyTableLogInfo));
        }

        public int Add(EmployeeAppraisalCompetencyTableLogInfo objEmployeeAppraisalCompetencyTableLog)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalCompetencyTableLogAdd(objEmployeeAppraisalCompetencyTableLog.Quality, objEmployeeAppraisalCompetencyTableLog.QuaPoint, objEmployeeAppraisalCompetencyTableLog.Productivity, objEmployeeAppraisalCompetencyTableLog.ProdPoint, objEmployeeAppraisalCompetencyTableLog.Knoweldge, objEmployeeAppraisalCompetencyTableLog.KnowPoint, objEmployeeAppraisalCompetencyTableLog.Dependability, objEmployeeAppraisalCompetencyTableLog.DependPoint, objEmployeeAppraisalCompetencyTableLog.Initiative, objEmployeeAppraisalCompetencyTableLog.InitPoint, objEmployeeAppraisalCompetencyTableLog.Judgement, objEmployeeAppraisalCompetencyTableLog.JudPoint, objEmployeeAppraisalCompetencyTableLog.Adaptability, objEmployeeAppraisalCompetencyTableLog.AdaPoint, objEmployeeAppraisalCompetencyTableLog.InterterpersonalRelationship, objEmployeeAppraisalCompetencyTableLog.InterPoint, objEmployeeAppraisalCompetencyTableLog.Puntuality, objEmployeeAppraisalCompetencyTableLog.PunPoint, objEmployeeAppraisalCompetencyTableLog.CommunicationSkills, objEmployeeAppraisalCompetencyTableLog.ComPoint, objEmployeeAppraisalCompetencyTableLog.Planning, objEmployeeAppraisalCompetencyTableLog.PlanPoint, objEmployeeAppraisalCompetencyTableLog.Leadership, objEmployeeAppraisalCompetencyTableLog.LeadPoint, objEmployeeAppraisalCompetencyTableLog.Team, objEmployeeAppraisalCompetencyTableLog.TeamPoint, objEmployeeAppraisalCompetencyTableLog.Development, objEmployeeAppraisalCompetencyTableLog.DevPoint, objEmployeeAppraisalCompetencyTableLog.OverallPoint, objEmployeeAppraisalCompetencyTableLog.ExcelArea, objEmployeeAppraisalCompetencyTableLog.AreaThatNeedsImprovement, objEmployeeAppraisalCompetencyTableLog.StepsToTake, objEmployeeAppraisalCompetencyTableLog.AreaThatNeedsAssistance, objEmployeeAppraisalCompetencyTableLog.EmployeeID_FK, objEmployeeAppraisalCompetencyTableLog.SupervisorID_FK, objEmployeeAppraisalCompetencyTableLog.HRID_FK, objEmployeeAppraisalCompetencyTableLog.AppraisalID_FK, objEmployeeAppraisalCompetencyTableLog.CompetencyID_FK, objEmployeeAppraisalCompetencyTableLog.SentBy);
        }

        public void Update(EmployeeAppraisalCompetencyTableLogInfo objEmployeeAppraisalCompetencyTableLog)
        {
            DataProvider.Instance().EmployeeAppraisalCompetencyTableLogUpdate(objEmployeeAppraisalCompetencyTableLog.CompetencyLogID, objEmployeeAppraisalCompetencyTableLog.Quality, objEmployeeAppraisalCompetencyTableLog.QuaPoint, objEmployeeAppraisalCompetencyTableLog.Productivity, objEmployeeAppraisalCompetencyTableLog.ProdPoint, objEmployeeAppraisalCompetencyTableLog.Knoweldge, objEmployeeAppraisalCompetencyTableLog.KnowPoint, objEmployeeAppraisalCompetencyTableLog.Dependability, objEmployeeAppraisalCompetencyTableLog.DependPoint, objEmployeeAppraisalCompetencyTableLog.Initiative, objEmployeeAppraisalCompetencyTableLog.InitPoint, objEmployeeAppraisalCompetencyTableLog.Judgement, objEmployeeAppraisalCompetencyTableLog.JudPoint, objEmployeeAppraisalCompetencyTableLog.Adaptability, objEmployeeAppraisalCompetencyTableLog.AdaPoint, objEmployeeAppraisalCompetencyTableLog.InterterpersonalRelationship, objEmployeeAppraisalCompetencyTableLog.InterPoint, objEmployeeAppraisalCompetencyTableLog.Puntuality, objEmployeeAppraisalCompetencyTableLog.PunPoint, objEmployeeAppraisalCompetencyTableLog.CommunicationSkills, objEmployeeAppraisalCompetencyTableLog.ComPoint, objEmployeeAppraisalCompetencyTableLog.Planning, objEmployeeAppraisalCompetencyTableLog.PlanPoint, objEmployeeAppraisalCompetencyTableLog.Leadership, objEmployeeAppraisalCompetencyTableLog.LeadPoint, objEmployeeAppraisalCompetencyTableLog.Team, objEmployeeAppraisalCompetencyTableLog.TeamPoint, objEmployeeAppraisalCompetencyTableLog.Development, objEmployeeAppraisalCompetencyTableLog.DevPoint, objEmployeeAppraisalCompetencyTableLog.OverallPoint, objEmployeeAppraisalCompetencyTableLog.ExcelArea, objEmployeeAppraisalCompetencyTableLog.AreaThatNeedsImprovement, objEmployeeAppraisalCompetencyTableLog.StepsToTake, objEmployeeAppraisalCompetencyTableLog.AreaThatNeedsAssistance, objEmployeeAppraisalCompetencyTableLog.EmployeeID_FK, objEmployeeAppraisalCompetencyTableLog.SupervisorID_FK, objEmployeeAppraisalCompetencyTableLog.HRID_FK, objEmployeeAppraisalCompetencyTableLog.AppraisalID_FK, objEmployeeAppraisalCompetencyTableLog.CompetencyID_FK, objEmployeeAppraisalCompetencyTableLog.SentBy);
        }
        public void LogSupFirstUpdate(EmployeeAppraisalCompetencyTableLogInfo objEmployeeAppraisalCompetencyTableLog)
        {
            DataProvider.Instance().EmployeeAppraisalCompetencyTableLogSupFirstUpdate(objEmployeeAppraisalCompetencyTableLog.CompetencyLogID, objEmployeeAppraisalCompetencyTableLog.Quality, objEmployeeAppraisalCompetencyTableLog.QuaPoint, objEmployeeAppraisalCompetencyTableLog.Productivity, objEmployeeAppraisalCompetencyTableLog.ProdPoint, objEmployeeAppraisalCompetencyTableLog.Knoweldge, objEmployeeAppraisalCompetencyTableLog.KnowPoint, objEmployeeAppraisalCompetencyTableLog.Dependability, objEmployeeAppraisalCompetencyTableLog.DependPoint, objEmployeeAppraisalCompetencyTableLog.Initiative, objEmployeeAppraisalCompetencyTableLog.InitPoint, objEmployeeAppraisalCompetencyTableLog.Judgement, objEmployeeAppraisalCompetencyTableLog.JudPoint, objEmployeeAppraisalCompetencyTableLog.Adaptability, objEmployeeAppraisalCompetencyTableLog.AdaPoint, objEmployeeAppraisalCompetencyTableLog.InterterpersonalRelationship, objEmployeeAppraisalCompetencyTableLog.InterPoint, objEmployeeAppraisalCompetencyTableLog.Puntuality, objEmployeeAppraisalCompetencyTableLog.PunPoint, objEmployeeAppraisalCompetencyTableLog.CommunicationSkills, objEmployeeAppraisalCompetencyTableLog.ComPoint, objEmployeeAppraisalCompetencyTableLog.Planning, objEmployeeAppraisalCompetencyTableLog.PlanPoint, objEmployeeAppraisalCompetencyTableLog.Leadership, objEmployeeAppraisalCompetencyTableLog.LeadPoint, objEmployeeAppraisalCompetencyTableLog.Team, objEmployeeAppraisalCompetencyTableLog.TeamPoint, objEmployeeAppraisalCompetencyTableLog.Development, objEmployeeAppraisalCompetencyTableLog.DevPoint, objEmployeeAppraisalCompetencyTableLog.OverallPoint, objEmployeeAppraisalCompetencyTableLog.ExcelArea, objEmployeeAppraisalCompetencyTableLog.AreaThatNeedsImprovement, objEmployeeAppraisalCompetencyTableLog.StepsToTake, objEmployeeAppraisalCompetencyTableLog.AreaThatNeedsAssistance, objEmployeeAppraisalCompetencyTableLog.CompetencyID_FK, objEmployeeAppraisalCompetencyTableLog.SentBy);
        }
        
        public void Delete(int competencyLogID)
        {
            DataProvider.Instance().EmployeeAppraisalCompetencyTableLogDelete(competencyLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    public class EmployeeApprasalTableGoalController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeApprasalTableGoalInfo Get(int goalID)
        {
            return (EmployeeApprasalTableGoalInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeApprasalTableGoalGet(goalID), typeof(EmployeeApprasalTableGoalInfo));
        }
        public EmployeeApprasalTableGoalInfo GetByEmpDetails(int employeeID)
        {
            return (EmployeeApprasalTableGoalInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeApprasalTableGoalGetByEmpDetails(employeeID), typeof(EmployeeApprasalTableGoalInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalList(), typeof(EmployeeApprasalTableGoalInfo));
        }

        public ArrayList GoalGetByArray(int goalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalGetByArray(goalID), typeof(EmployeeApprasalTableGoalInfo));
        }
        public ArrayList GetByEmployeeAppraisalTable(int appraisalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeeApprasalTableGoalInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalGetByEmployeeDetails(employeeID), typeof(EmployeeApprasalTableGoalInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalGetByUsers(userID), typeof(EmployeeApprasalTableGoalInfo));
        }

        public int Add(EmployeeApprasalTableGoalInfo objEmployeeApprasalTableGoal)
        {
            return (int)DataProvider.Instance().EmployeeApprasalTableGoalAdd(objEmployeeApprasalTableGoal.GoalDesc, objEmployeeApprasalTableGoal.GoalObjectives, objEmployeeApprasalTableGoal.GoalEvaPoint, objEmployeeApprasalTableGoal.GoalCompletetiondate, objEmployeeApprasalTableGoal.EmployeeID_FK, objEmployeeApprasalTableGoal.SupervisorID_FK, objEmployeeApprasalTableGoal.HRID_FK, objEmployeeApprasalTableGoal.AppraisalID_FK);
        }

        public void Update(EmployeeApprasalTableGoalInfo objEmployeeApprasalTableGoal)
        {
            DataProvider.Instance().EmployeeApprasalTableGoalUpdate(objEmployeeApprasalTableGoal.GoalID, objEmployeeApprasalTableGoal.GoalDesc, objEmployeeApprasalTableGoal.GoalObjectives, objEmployeeApprasalTableGoal.GoalEvaPoint, objEmployeeApprasalTableGoal.GoalCompletetiondate, objEmployeeApprasalTableGoal.EmployeeID_FK, objEmployeeApprasalTableGoal.SupervisorID_FK, objEmployeeApprasalTableGoal.HRID_FK, objEmployeeApprasalTableGoal.AppraisalID_FK);
        }
        public void GoalSupUpdate(EmployeeApprasalTableGoalInfo objEmployeeApprasalTableGoal)
        {
            DataProvider.Instance().EmployeeApprasalTableGoalSupUpdate(objEmployeeApprasalTableGoal.GoalID, objEmployeeApprasalTableGoal.GoalDesc, objEmployeeApprasalTableGoal.GoalObjectives, objEmployeeApprasalTableGoal.GoalEvaPoint, objEmployeeApprasalTableGoal.GoalCompletetiondate, objEmployeeApprasalTableGoal.AppraisalID_FK);
        }
        
        public void Delete(int goalID)
        {
            DataProvider.Instance().EmployeeApprasalTableGoalDelete(goalID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    //EmployeeApprasalTableGoalLogController

    public class EmployeeApprasalTableGoalLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeApprasalTableGoalLogInfo Get(int goalLogID)
        {
            return (EmployeeApprasalTableGoalLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeApprasalTableGoalLogGet(goalLogID), typeof(EmployeeApprasalTableGoalLogInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalLogList(), typeof(EmployeeApprasalTableGoalLogInfo));
        }

        public ArrayList GetByEmployeeAppraisalTable(int appraisalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalLogGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeeApprasalTableGoalLogInfo));
        }
        public ArrayList GetByEmployeeApprasalTableGoal(int goalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalLogGetByEmployeeApprasalTableGoal(goalID), typeof(EmployeeApprasalTableGoalLogInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalLogGetByEmployeeDetails(employeeID), typeof(EmployeeApprasalTableGoalLogInfo));
        }
        public ArrayList GoalLogEmpGetByEmpID(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalLogEmpGetByEmpID(employeeID), typeof(EmployeeApprasalTableGoalLogInfo));
        }
          public ArrayList GoalLogSupGetByEmpID(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalLogSupGetByEmpID(employeeID), typeof(EmployeeApprasalTableGoalLogInfo));
        }
        
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeApprasalTableGoalLogGetByUsers(userID), typeof(EmployeeApprasalTableGoalLogInfo));
        }

        public int Add(EmployeeApprasalTableGoalLogInfo objEmployeeApprasalTableGoalLog)
        {
            return (int)DataProvider.Instance().EmployeeApprasalTableGoalLogAdd(objEmployeeApprasalTableGoalLog.GoalDesc, objEmployeeApprasalTableGoalLog.GoalObjectives, objEmployeeApprasalTableGoalLog.GoalEvaPoint, objEmployeeApprasalTableGoalLog.GoalCompletetiondate, objEmployeeApprasalTableGoalLog.EmployeeID_FK, objEmployeeApprasalTableGoalLog.SupervisorID_FK, objEmployeeApprasalTableGoalLog.HRID_FK, objEmployeeApprasalTableGoalLog.AppraisalID_FK, objEmployeeApprasalTableGoalLog.SentBy);
        }

        public void Update(EmployeeApprasalTableGoalLogInfo objEmployeeApprasalTableGoalLog)
        {
            DataProvider.Instance().EmployeeApprasalTableGoalLogUpdate(objEmployeeApprasalTableGoalLog.GoalLogID, objEmployeeApprasalTableGoalLog.GoalDesc, objEmployeeApprasalTableGoalLog.GoalObjectives, objEmployeeApprasalTableGoalLog.GoalEvaPoint, objEmployeeApprasalTableGoalLog.GoalCompletetiondate, objEmployeeApprasalTableGoalLog.EmployeeID_FK, objEmployeeApprasalTableGoalLog.SupervisorID_FK, objEmployeeApprasalTableGoalLog.HRID_FK, objEmployeeApprasalTableGoalLog.AppraisalID_FK, objEmployeeApprasalTableGoalLog.GoalID_FK, objEmployeeApprasalTableGoalLog.SentBy);
        }
        public void GoalIDUpdate(EmployeeApprasalTableGoalLogInfo objEmployeeApprasalTableGoalLog)
        {
            DataProvider.Instance().EmployeeApprasalTableGoalLogGoalIDUpdate(objEmployeeApprasalTableGoalLog.GoalLogID, objEmployeeApprasalTableGoalLog.GoalID_FK);
        }
       
        public void Delete(int goalLogID)
        {
            DataProvider.Instance().EmployeeApprasalTableGoalLogDelete(goalLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeAppraisalTableController

    public class EmployeeAppraisalTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeAppraisalTableInfo Get(int appraisalID)
        {
            return (EmployeeAppraisalTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableGet(appraisalID), typeof(EmployeeAppraisalTableInfo));
        }
        public EmployeeAppraisalTableInfo ListInfo(EmployeeAppraisalTableInfo objEmployeeAppraisal)
      {
          return (EmployeeAppraisalTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableListInfo(objEmployeeAppraisal.AppraisalID, objEmployeeAppraisal.EmployeeNum, objEmployeeAppraisal.AppraisalScore, objEmployeeAppraisal.PromoExamScore, objEmployeeAppraisal.TotalAppraisalScore), typeof(EmployeeAppraisalTableInfo));
    }
        
        public EmployeeAppraisalTableInfo GetByEmpID(int employeeID)
        {
            return (EmployeeAppraisalTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableGetByEmpID(employeeID), typeof(EmployeeAppraisalTableInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableList(), typeof(EmployeeAppraisalTableInfo));
        }
        public ArrayList ListForChart()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableListForChart(), typeof(EmployeeAppraisalTableInfo));
        }
        public ArrayList ListForGoogleChart()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableListForGoogleChart(), typeof(AppraisalChartInfo));
        }
        public ArrayList ListForColumnChart()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableListForColumnChart(), typeof(AppraisalChartInfo));
        }
        
        
        public ArrayList ManagementApprovalList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableManagementApprovalList(), typeof(EmployeeAppraisalTableInfo));
        }
        

        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableGetByEmployeeDetails(employeeID), typeof(EmployeeAppraisalTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableGetByUsers(userID), typeof(EmployeeAppraisalTableInfo));
        }

        public int Add(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalTableAdd(objEmployeeAppraisalTable.EmployeeNum, objEmployeeAppraisalTable.AppraisalScore, objEmployeeAppraisalTable.PromoExamScore, objEmployeeAppraisalTable.TotalAppraisalScore, objEmployeeAppraisalTable.TotalPoint, objEmployeeAppraisalTable.EvaPeriod, objEmployeeAppraisalTable.AprpraisalStartYear, objEmployeeAppraisalTable.AppraisalStatus, objEmployeeAppraisalTable.PromoRecommendation, objEmployeeAppraisalTable.EmpAppraisalDate, objEmployeeAppraisalTable.SupAppraisalDate, objEmployeeAppraisalTable.HrAppraisalDate, objEmployeeAppraisalTable.SupComment, objEmployeeAppraisalTable.HRComment, objEmployeeAppraisalTable.EmployeeID_FK, objEmployeeAppraisalTable.SupervisorID_FK, objEmployeeAppraisalTable.HRID_FK);
        }
        public int EmpAdd(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalTableEmpAdd(objEmployeeAppraisalTable.EmployeeNum, objEmployeeAppraisalTable.TotalPoint, objEmployeeAppraisalTable.EvaPeriod, objEmployeeAppraisalTable.AprpraisalStartYear, objEmployeeAppraisalTable.AppraisalStatus, objEmployeeAppraisalTable.EmpAppraisalDate, objEmployeeAppraisalTable.EmployeeID_FK);
        }
        
        public void Update(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            DataProvider.Instance().EmployeeAppraisalTableUpdate(objEmployeeAppraisalTable.AppraisalID, objEmployeeAppraisalTable.EmployeeNum, objEmployeeAppraisalTable.AppraisalScore, objEmployeeAppraisalTable.PromoExamScore, objEmployeeAppraisalTable.TotalAppraisalScore, objEmployeeAppraisalTable.TotalPoint, objEmployeeAppraisalTable.EvaPeriod, objEmployeeAppraisalTable.AprpraisalStartYear, objEmployeeAppraisalTable.AppraisalStatus, objEmployeeAppraisalTable.PromoRecommendation, objEmployeeAppraisalTable.EmpAppraisalDate, objEmployeeAppraisalTable.SupAppraisalDate, objEmployeeAppraisalTable.HrAppraisalDate, objEmployeeAppraisalTable.SupComment, objEmployeeAppraisalTable.HRComment, objEmployeeAppraisalTable.EmployeeID_FK, objEmployeeAppraisalTable.SupervisorID_FK, objEmployeeAppraisalTable.HRID_FK);
        }
        
        public void AppraisalScoreUpdate(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            DataProvider.Instance().EmployeeAppraisalTableAppraisalScoreUpdate(objEmployeeAppraisalTable.AppraisalID, objEmployeeAppraisalTable.AppraisalScore); 
                    
        }
        public void SupAppraisalScoreUpdate(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            DataProvider.Instance().EmployeeAppraisalTableSupAppraisalScoreUpdate(objEmployeeAppraisalTable.AppraisalID, objEmployeeAppraisalTable.AppraisalScore, objEmployeeAppraisalTable.SupComment, objEmployeeAppraisalTable.PromoRecommendation, objEmployeeAppraisalTable.SupervisorID_FK); 
                    
        }
        public void HRAppraisalScoreUpdate(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            DataProvider.Instance().EmployeeAppraisalTableHRAppraisalScoreUpdate(objEmployeeAppraisalTable.AppraisalID, objEmployeeAppraisalTable.PromoExamScore, objEmployeeAppraisalTable.TotalAppraisalScore, objEmployeeAppraisalTable.AppraisalStatus, objEmployeeAppraisalTable.HrAppraisalDate, objEmployeeAppraisalTable.HRPromoRecommendation, objEmployeeAppraisalTable.HRComment, objEmployeeAppraisalTable.EmployeeID_FK, objEmployeeAppraisalTable.HRID_FK);

        }
        
        public void SupFirstUpdate(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            DataProvider.Instance().EmployeeAppraisalTableSupFirstUpdate(objEmployeeAppraisalTable.AppraisalID, objEmployeeAppraisalTable.TotalPoint, objEmployeeAppraisalTable.AppraisalStatus, objEmployeeAppraisalTable.SupAppraisalDate);
        }
        public void SupAppraiseUpdate(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            DataProvider.Instance().EmployeeAppraisalTableSupAppraiseUpdate(objEmployeeAppraisalTable.AppraisalID, objEmployeeAppraisalTable.PromoExamScore, objEmployeeAppraisalTable.TotalAppraisalScore, objEmployeeAppraisalTable.PromoRecommendation, objEmployeeAppraisalTable.SupComment);
        }
        public void ManagementDecisionUpdate(EmployeeAppraisalTableInfo objEmployeeAppraisalTable)
        {
            DataProvider.Instance().EmployeeAppraisalTableManagementDecisionUpdate(objEmployeeAppraisalTable.AppraisalID, objEmployeeAppraisalTable.ManagementDecision, objEmployeeAppraisalTable.ManagementDecisionDate);
        }
        
        public void Delete(int appraisalID)
        {
            DataProvider.Instance().EmployeeAppraisalTableDelete(appraisalID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeAppraisalTableLogController

    public class EmployeeAppraisalTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeAppraisalTableLogInfo Get(int appraisalLogID)
        {
            return (EmployeeAppraisalTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableLogGet(appraisalLogID), typeof(EmployeeAppraisalTableLogInfo));
        }

        public EmployeeAppraisalTableLogInfo LogGetByEmpID(int employeeID)
        {
            return (EmployeeAppraisalTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableLogGetByEmpID(employeeID), typeof(EmployeeAppraisalTableLogInfo));
        }
        //public EmployeeAppraisalTableLogInfo LogGetEmpAppraisalDetailsByEmpID(int employeeID)
        //{
        //    return (EmployeeAppraisalTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID(employeeID), typeof(EmployeeAppraisalTableLogInfo));
        //}
        
      
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableLogList(), typeof(EmployeeAppraisalTableLogInfo));
        }

        public EmployeeAppraisalTableLogInfo GetByEmployeeAppraisalTable(int appraisalID)
        {
            return (EmployeeAppraisalTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeAppraisalTableLogGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeeAppraisalTableLogInfo));
   
           // return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableLogGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeeAppraisalTableLogInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableLogGetByEmployeeDetails(employeeID), typeof(EmployeeAppraisalTableLogInfo));
        }
        public ArrayList LogGetEmpAppraisalDetailsByEmpID(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID(employeeID), typeof(EmployeeAppraisalTableLogInfo));
        }
        public ArrayList LogGetSupAppraisalDetailsByEmpID(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableLogGetSupAppraisalDetailsByEmpID(employeeID), typeof(EmployeeAppraisalTableLogInfo));
        }
               
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeAppraisalTableLogGetByUsers(userID), typeof(EmployeeAppraisalTableLogInfo));
        }

        public int Add(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalTableLogAdd(objEmployeeAppraisalTableLog.EmployeeNum, objEmployeeAppraisalTableLog.AppraisalScore, objEmployeeAppraisalTableLog.PromoExamScore, objEmployeeAppraisalTableLog.TotalAppraisalScore, objEmployeeAppraisalTableLog.TotalPoint, objEmployeeAppraisalTableLog.EvaPeriod, objEmployeeAppraisalTableLog.AprpraisalStartYear, objEmployeeAppraisalTableLog.AppraisalStatus, objEmployeeAppraisalTableLog.PromoRecommendation, objEmployeeAppraisalTableLog.EmpAppraisalDate, objEmployeeAppraisalTableLog.SupAppraisalDate, objEmployeeAppraisalTableLog.HrAppraisalDate, objEmployeeAppraisalTableLog.SupComment, objEmployeeAppraisalTableLog.HRComment, objEmployeeAppraisalTableLog.EmployeeID_FK, objEmployeeAppraisalTableLog.SupervisorID_FK, objEmployeeAppraisalTableLog.HRID_FK, objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.SentBy);
        }
        public int LogEmpAdd(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalTableLogEmpAdd(objEmployeeAppraisalTableLog.EmployeeNum, objEmployeeAppraisalTableLog.AppraisalScore, objEmployeeAppraisalTableLog.TotalPoint, objEmployeeAppraisalTableLog.EvaPeriod, objEmployeeAppraisalTableLog.AprpraisalStartYear, objEmployeeAppraisalTableLog.AppraisalStatus, objEmployeeAppraisalTableLog.EmpAppraisalDate, objEmployeeAppraisalTableLog.EmployeeID_FK, objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.SentBy);
        }
        public int LogSupEmpAdd(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalTableLogSupEmpAdd(objEmployeeAppraisalTableLog.EmployeeNum, objEmployeeAppraisalTableLog.AppraisalScore, objEmployeeAppraisalTableLog.TotalPoint, objEmployeeAppraisalTableLog.EvaPeriod, objEmployeeAppraisalTableLog.AprpraisalStartYear, objEmployeeAppraisalTableLog.AppraisalStatus, objEmployeeAppraisalTableLog.PromoRecommendation, objEmployeeAppraisalTableLog.EmpAppraisalDate, objEmployeeAppraisalTableLog.SupAppraisalDate, objEmployeeAppraisalTableLog.SupComment, objEmployeeAppraisalTableLog.EmployeeID_FK, objEmployeeAppraisalTableLog.SupervisorID_FK, objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.SentBy);
        }
        public int LogHREmpAdd(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            return (int)DataProvider.Instance().EmployeeAppraisalTableLogHREmpAdd(objEmployeeAppraisalTableLog.EmployeeNum, objEmployeeAppraisalTableLog.AppraisalScore, objEmployeeAppraisalTableLog.PromoExamScore, objEmployeeAppraisalTableLog.TotalAppraisalScore, objEmployeeAppraisalTableLog.TotalPoint, objEmployeeAppraisalTableLog.EvaPeriod, objEmployeeAppraisalTableLog.AprpraisalStartYear, objEmployeeAppraisalTableLog.AppraisalStatus, objEmployeeAppraisalTableLog.PromoRecommendation, objEmployeeAppraisalTableLog.EmpAppraisalDate, objEmployeeAppraisalTableLog.SupAppraisalDate, objEmployeeAppraisalTableLog.HrAppraisalDate, objEmployeeAppraisalTableLog.SupComment, objEmployeeAppraisalTableLog.HRPromoRecommendation, objEmployeeAppraisalTableLog.HRComment, objEmployeeAppraisalTableLog.EmployeeID_FK, objEmployeeAppraisalTableLog.SupervisorID_FK, objEmployeeAppraisalTableLog.HRID_FK, objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.SentBy);
        }
        
        public void Update(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            DataProvider.Instance().EmployeeAppraisalTableLogUpdate(objEmployeeAppraisalTableLog.AppraisalLogID, objEmployeeAppraisalTableLog.EmployeeNum, objEmployeeAppraisalTableLog.AppraisalScore, objEmployeeAppraisalTableLog.PromoExamScore, objEmployeeAppraisalTableLog.TotalAppraisalScore, objEmployeeAppraisalTableLog.TotalPoint, objEmployeeAppraisalTableLog.EvaPeriod, objEmployeeAppraisalTableLog.AprpraisalStartYear, objEmployeeAppraisalTableLog.AppraisalStatus, objEmployeeAppraisalTableLog.PromoRecommendation, objEmployeeAppraisalTableLog.EmpAppraisalDate, objEmployeeAppraisalTableLog.SupAppraisalDate, objEmployeeAppraisalTableLog.HrAppraisalDate, objEmployeeAppraisalTableLog.SupComment, objEmployeeAppraisalTableLog.HRComment, objEmployeeAppraisalTableLog.EmployeeID_FK, objEmployeeAppraisalTableLog.SupervisorID_FK, objEmployeeAppraisalTableLog.HRID_FK, objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.SentBy);
        }
        public void LogAppraisalScoreUpdate(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            DataProvider.Instance().EmployeeAppraisalTableLogAppraisalScoreUpdate(objEmployeeAppraisalTableLog.AppraisalLogID, objEmployeeAppraisalTableLog.AppraisalScore); 
                 }
        public void LogSupFirstUpdate(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            DataProvider.Instance().EmployeeAppraisalTableLogSupFirstUpdate(objEmployeeAppraisalTableLog.AppraisalLogID, objEmployeeAppraisalTableLog.EmployeeNum, objEmployeeAppraisalTableLog.AppraisalScore, objEmployeeAppraisalTableLog.TotalPoint, objEmployeeAppraisalTableLog.EvaPeriod, objEmployeeAppraisalTableLog.AprpraisalStartYear, objEmployeeAppraisalTableLog.AppraisalStatus, objEmployeeAppraisalTableLog.EmpAppraisalDate, objEmployeeAppraisalTableLog.SupAppraisalDate, objEmployeeAppraisalTableLog.SupComment, objEmployeeAppraisalTableLog.EmployeeID_FK, objEmployeeAppraisalTableLog.SupervisorID_FK, objEmployeeAppraisalTableLog.HRID_FK, objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.SentBy);
        }
        public void LogSupAppraiseUpdate(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            DataProvider.Instance().EmployeeAppraisalTableLogSupAppraiseUpdate(objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.PromoExamScore, objEmployeeAppraisalTableLog.TotalAppraisalScore, objEmployeeAppraisalTableLog.PromoRecommendation, objEmployeeAppraisalTableLog.SupComment);
        }
        public void LogManagementDecisionUpdate(EmployeeAppraisalTableLogInfo objEmployeeAppraisalTableLog)
        {
            DataProvider.Instance().EmployeeAppraisalTableLogManagementDecisionUpdate(objEmployeeAppraisalTableLog.AppraisalLogID, objEmployeeAppraisalTableLog.AppraisalID_FK, objEmployeeAppraisalTableLog.ManagementDecision, objEmployeeAppraisalTableLog.ManagementDecisionDate);
        }
        
        
        public void Delete(int appraisalLogID)
        {
            DataProvider.Instance().EmployeeAppraisalTableLogDelete(appraisalLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

    #endregion



    //EmployeePromotionTableController

    public class EmployeePromotionTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeePromotionTableInfo Get(int promotionID)
        {
            return (EmployeePromotionTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeePromotionTableGet(promotionID), typeof(EmployeePromotionTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableList(), typeof(EmployeePromotionTableInfo));
        }
        public ArrayList ListByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableListByEmployeeDetails(employeeID), typeof(EmployeePromotionTableInfo));
        }
        
        public EmployeePromotionTableInfo PromoHistList(EmployeePromotionTableInfo objPromotion)
        {
            return (EmployeePromotionTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeePromotionTablePromoHistList(objPromotion.PreDept, objPromotion.NewDept, objPromotion.PreviousPosition, objPromotion.NewPosition, objPromotion.PreviousLevel, objPromotion.NewLevel), typeof(EmployeePromotionTableInfo));
        }

        public ArrayList GetByEmployeeAppraisalTable(int appraisalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeePromotionTableInfo));
        }
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeePromotionTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableGetByEmployeeDetails(employeeID), typeof(EmployeePromotionTableInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableGetByEmployeeLevel(levelID), typeof(EmployeePromotionTableInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableGetByEmployeePositionTable(positionID), typeof(EmployeePromotionTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableGetByUsers(userID), typeof(EmployeePromotionTableInfo));
        }

        public int Add(EmployeePromotionTableInfo objEmployeePromotionTable)
        {
            return (int)DataProvider.Instance().EmployeePromotionTableAdd(objEmployeePromotionTable.PreviousLevel, objEmployeePromotionTable.NewLevel, objEmployeePromotionTable.PreDept, objEmployeePromotionTable.PreviousPosition, objEmployeePromotionTable.NewDept, objEmployeePromotionTable.NewPosition, objEmployeePromotionTable.ApprasialScore, objEmployeePromotionTable.PromoExamScore, objEmployeePromotionTable.TotalAppraisalScore, objEmployeePromotionTable.PromotedDate, objEmployeePromotionTable.PromotedBy, objEmployeePromotionTable.EmployeeID_FK, objEmployeePromotionTable.ApprasialID_FK);
        }

        public void Update(EmployeePromotionTableInfo objEmployeePromotionTable)
        {
            DataProvider.Instance().EmployeePromotionTableUpdate(objEmployeePromotionTable.PromotionID, objEmployeePromotionTable.PreviousLevel, objEmployeePromotionTable.NewLevel, objEmployeePromotionTable.PreDept, objEmployeePromotionTable.PreviousPosition, objEmployeePromotionTable.NewDept, objEmployeePromotionTable.NewPosition, objEmployeePromotionTable.ApprasialScore, objEmployeePromotionTable.PromoExamScore, objEmployeePromotionTable.TotalAppraisalScore, objEmployeePromotionTable.PromotedDate, objEmployeePromotionTable.PromotedBy, objEmployeePromotionTable.EmployeeID_FK, objEmployeePromotionTable.ApprasialID_FK);
        }

        public void Delete(int promotionID)
        {
            DataProvider.Instance().EmployeePromotionTableDelete(promotionID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

  
    public class EmployeePromotionTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeePromotionTableLogInfo Get(int promotionLogID)
        {
            return (EmployeePromotionTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeePromotionTableLogGet(promotionLogID), typeof(EmployeePromotionTableLogInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogList(), typeof(EmployeePromotionTableLogInfo));
        }

        public ArrayList GetByEmployeeAppraisalTable(int appraisalID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogGetByEmployeeAppraisalTable(appraisalID), typeof(EmployeePromotionTableLogInfo));
        }
        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogGetByEmployeeDepartmentTable(deptID), typeof(EmployeePromotionTableLogInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogGetByEmployeeDetails(employeeID), typeof(EmployeePromotionTableLogInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogGetByEmployeeLevel(levelID), typeof(EmployeePromotionTableLogInfo));
        }
        public ArrayList GetByEmployeePositionTable(int positionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogGetByEmployeePositionTable(positionID), typeof(EmployeePromotionTableLogInfo));
        }
        public ArrayList GetByEmployeePromotionTable(int promotionID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogGetByEmployeePromotionTable(promotionID), typeof(EmployeePromotionTableLogInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeePromotionTableLogGetByUsers(userID), typeof(EmployeePromotionTableLogInfo));
        }

        public int Add(EmployeePromotionTableLogInfo objEmployeePromotionTableLog)
        {
            return (int)DataProvider.Instance().EmployeePromotionTableLogAdd(objEmployeePromotionTableLog.PreviousLevel, objEmployeePromotionTableLog.NewLevel, objEmployeePromotionTableLog.PreDept, objEmployeePromotionTableLog.PreviousPosition, objEmployeePromotionTableLog.NewDept, objEmployeePromotionTableLog.NewPosition, objEmployeePromotionTableLog.ApprasialScore, objEmployeePromotionTableLog.PromoExamScore, objEmployeePromotionTableLog.TotalAppraisalScore, objEmployeePromotionTableLog.PromotedDate, objEmployeePromotionTableLog.PromotedBy, objEmployeePromotionTableLog.EmployeeID_FK, objEmployeePromotionTableLog.ApprasialID_FK, objEmployeePromotionTableLog.PromotionID_FK);
        }

        public void Update(EmployeePromotionTableLogInfo objEmployeePromotionTableLog)
        {
            DataProvider.Instance().EmployeePromotionTableLogUpdate(objEmployeePromotionTableLog.PromotionLogID, objEmployeePromotionTableLog.PreviousLevel, objEmployeePromotionTableLog.NewLevel, objEmployeePromotionTableLog.PreDept, objEmployeePromotionTableLog.PreviousPosition, objEmployeePromotionTableLog.NewDept, objEmployeePromotionTableLog.NewPosition, objEmployeePromotionTableLog.ApprasialScore, objEmployeePromotionTableLog.PromoExamScore, objEmployeePromotionTableLog.TotalAppraisalScore, objEmployeePromotionTableLog.PromotedDate, objEmployeePromotionTableLog.PromotedBy, objEmployeePromotionTableLog.EmployeeID_FK, objEmployeePromotionTableLog.ApprasialID_FK, objEmployeePromotionTableLog.PromotionID_FK);
        }

        public void Delete(int promotionLogID)
        {
            DataProvider.Instance().EmployeePromotionTableLogDelete(promotionLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeTypeOfLeaveTableController
    public class EmployeeTypeOfLeaveTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeTypeOfLeaveTableInfo Get(int leaveTypeID)
        {
            return (EmployeeTypeOfLeaveTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeTypeOfLeaveTableGet(leaveTypeID), typeof(EmployeeTypeOfLeaveTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeTypeOfLeaveTableList(), typeof(EmployeeTypeOfLeaveTableInfo));
        }


        public int Add(EmployeeTypeOfLeaveTableInfo objEmployeeTypeOfLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeTypeOfLeaveTableAdd(objEmployeeTypeOfLeaveTable.LeaveTypeName);
        }

        public void Update(EmployeeTypeOfLeaveTableInfo objEmployeeTypeOfLeaveTable)
        {
            DataProvider.Instance().EmployeeTypeOfLeaveTableUpdate(objEmployeeTypeOfLeaveTable.LeaveTypeID, objEmployeeTypeOfLeaveTable.LeaveTypeName);
        }

        public void Delete(int leaveTypeID)
        {
            DataProvider.Instance().EmployeeTypeOfLeaveTableDelete(leaveTypeID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    //EmployeeLeaveTableController


    public class EmployeeLeaveTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeLeaveTableInfo Get(int leaveID)
        {
            return (EmployeeLeaveTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLeaveTableGet(leaveID), typeof(EmployeeLeaveTableInfo));
        }

        // get leave details for an employee EmployeeLeaveTableGetForAnEmployee
        public EmployeeLeaveTableInfo GetForAnEmployee(int employeeID)
        {
            return (EmployeeLeaveTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLeaveTableGetForAnEmployee(employeeID), typeof(EmployeeLeaveTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableList(), typeof(EmployeeLeaveTableInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeDepartmentTable(deptID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeDetails(employeeID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeLevel(levelID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByEmployeeTypeOfLeaveTable(int leaveTypeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable(leaveTypeID), typeof(EmployeeLeaveTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableGetByUsers(userID), typeof(EmployeeLeaveTableInfo));
        }

        public int Add(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableAdd(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.LevelID_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.LeaveStatus, objEmployeeLeaveTable.LeaveGrantedBy, objEmployeeLeaveTable.DateGranted, objEmployeeLeaveTable.ApproveOrDisapproveReason, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }

        // Saving employee leave application  
        public int AddLeaveApplication(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableAddLeaveApplication(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.LevelID_FK, objEmployeeLeaveTable.LeaveThresholdBeforeApplication, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }
        public void Update(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            DataProvider.Instance().EmployeeLeaveTableUpdate(objEmployeeLeaveTable.LeaveID, objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.LevelID_FK, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.LeaveStatus, objEmployeeLeaveTable.LeaveGrantedBy, objEmployeeLeaveTable.DateGranted, objEmployeeLeaveTable.ApproveOrDisapproveReason, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }
        //upade employee application EmployeeLeaveTableUpdateLeaveApplication
        public void UpdateLeaveApplication(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            DataProvider.Instance().EmployeeLeaveTableUpdateLeaveApplication(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.LevelID_FK, objEmployeeLeaveTable.LeaveThresholdBeforeApplication, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK);
        }
        public void UpdateLeaveApprovalORDisapproval(EmployeeLeaveTableInfo objEmployeeLeaveTable)
        {
            DataProvider.Instance().EmployeeLeaveTableUpdateLeaveApprovalORDisapproval(objEmployeeLeaveTable.LeaveID, objEmployeeLeaveTable.LeaveStatus, objEmployeeLeaveTable.LeaveGrantedBy, objEmployeeLeaveTable.DateGranted, objEmployeeLeaveTable.LeaveThresholdBeforeApplication, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.ReasonForDisapproval, objEmployeeLeaveTable.EmployeeID_FK);
        }
        
        public void Delete(int leaveID)
        {
            DataProvider.Instance().EmployeeLeaveTableDelete(leaveID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    // EmployeeLeaveTableLog  Controller
    public class EmployeeLeaveTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeLeaveTableLogInfo Get(int leaveLogID)
        {
            return (EmployeeLeaveTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeLeaveTableLogGet(leaveLogID), typeof(EmployeeLeaveTableLogInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogList(), typeof(EmployeeLeaveTableLogInfo));
        }

        public ArrayList GetByEmployeeDepartmentTable(int deptID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeDepartmentTable(deptID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeDetails(employeeID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeLeaveTable(int leaveID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeLeaveTable(leaveID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeLevel(int levelID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeLevel(levelID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByEmployeeTypeOfLeaveTable(int leaveTypeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(leaveTypeID), typeof(EmployeeLeaveTableLogInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeLeaveTableLogGetByUsers(userID), typeof(EmployeeLeaveTableLogInfo));
        }

        public int Add(EmployeeLeaveTableLogInfo objEmployeeLeaveTableLog)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableLogAdd(objEmployeeLeaveTableLog.LeaveType_FK, objEmployeeLeaveTableLog.LeaveDescription, objEmployeeLeaveTableLog.StartDate, objEmployeeLeaveTableLog.EndDate, objEmployeeLeaveTableLog.Duration, objEmployeeLeaveTableLog.Level_FK, objEmployeeLeaveTableLog.LeaveThreshold, objEmployeeLeaveTableLog.DateApplied, objEmployeeLeaveTableLog.LeaveStatus, objEmployeeLeaveTableLog.LeaveGrantedBy, objEmployeeLeaveTableLog.DateGranted, objEmployeeLeaveTableLog.ApproveOrDisapproveReason, objEmployeeLeaveTableLog.Dept_FK, objEmployeeLeaveTableLog.EmployeeID_FK, objEmployeeLeaveTableLog.LeaveID_FK);
        }


        // Saving employee leave application  in log table
        public int AddLeaveApplication(EmployeeLeaveTableLogInfo objEmployeeLeaveTable)
        {
            return (int)DataProvider.Instance().EmployeeLeaveTableLogAddLeaveApplication(objEmployeeLeaveTable.LeaveType_FK, objEmployeeLeaveTable.LeaveDescription, objEmployeeLeaveTable.StartDate, objEmployeeLeaveTable.EndDate, objEmployeeLeaveTable.Duration, objEmployeeLeaveTable.Level_FK, objEmployeeLeaveTable.LeaveThresholdBeforeApplication, objEmployeeLeaveTable.LeaveThreshold, objEmployeeLeaveTable.DateApplied, objEmployeeLeaveTable.Dept_FK, objEmployeeLeaveTable.EmployeeID_FK, objEmployeeLeaveTable.LeaveID_FK);
        }
        public void Update(EmployeeLeaveTableLogInfo objEmployeeLeaveTableLog)
        {
            DataProvider.Instance().EmployeeLeaveTableLogUpdate(objEmployeeLeaveTableLog.LeaveLogID, objEmployeeLeaveTableLog.LeaveType_FK, objEmployeeLeaveTableLog.LeaveDescription, objEmployeeLeaveTableLog.StartDate, objEmployeeLeaveTableLog.EndDate, objEmployeeLeaveTableLog.Duration, objEmployeeLeaveTableLog.Level_FK, objEmployeeLeaveTableLog.LeaveThreshold, objEmployeeLeaveTableLog.DateApplied, objEmployeeLeaveTableLog.LeaveStatus, objEmployeeLeaveTableLog.LeaveGrantedBy, objEmployeeLeaveTableLog.DateGranted, objEmployeeLeaveTableLog.ApproveOrDisapproveReason, objEmployeeLeaveTableLog.ReasonForDisapproval, objEmployeeLeaveTableLog.Dept_FK, objEmployeeLeaveTableLog.EmployeeID_FK, objEmployeeLeaveTableLog.LeaveID_FK);
        }
        public void LogUpdateLeaveApprovalORDisapproval(EmployeeLeaveTableLogInfo objEmployeeLeaveTableLog)
        {
            DataProvider.Instance().EmployeeLeaveTableLogUpdateLeaveApprovalORDisapproval(objEmployeeLeaveTableLog.LeaveLogID, objEmployeeLeaveTableLog.LeaveStatus, objEmployeeLeaveTableLog.LeaveGrantedBy, objEmployeeLeaveTableLog.DateGranted, objEmployeeLeaveTableLog.LeaveThresholdBeforeApplication, objEmployeeLeaveTableLog.LeaveThreshold, objEmployeeLeaveTableLog.ReasonForDisapproval, objEmployeeLeaveTableLog.EmployeeID_FK, objEmployeeLeaveTableLog.LeaveID_FK);
        }
        

        public void Delete(int leaveLogID)
        {
            DataProvider.Instance().EmployeeLeaveTableLogDelete(leaveLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //EmployeeDisciplineTableController
    public class EmployeeDisciplineTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeDisciplineTableInfo Get(int disciplineID)
        {
            return (EmployeeDisciplineTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeDisciplineTableGet(disciplineID), typeof(EmployeeDisciplineTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeDisciplineTableList(), typeof(EmployeeDisciplineTableInfo));
        }


        public int Add(EmployeeDisciplineTableInfo objEmployeeDisciplineTable)
        {
            return (int)DataProvider.Instance().EmployeeDisciplineTableAdd(objEmployeeDisciplineTable.DiscplineDescription);
        }

        public void Update(EmployeeDisciplineTableInfo objEmployeeDisciplineTable)
        {
            DataProvider.Instance().EmployeeDisciplineTableUpdate(objEmployeeDisciplineTable.DisciplineID, objEmployeeDisciplineTable.DiscplineDescription);
        }

        public void Delete(int disciplineID)
        {
            DataProvider.Instance().EmployeeDisciplineTableDelete(disciplineID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }



    //EmployeeQueryTable  Controller
    public class EmployeeQueryTableController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeQueryTableInfo Get(int queryID)
        {
            return (EmployeeQueryTableInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeQueryTableGet(queryID), typeof(EmployeeQueryTableInfo));
        }

        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableList(), typeof(EmployeeQueryTableInfo));
        }

        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableGetByEmployeeDetails(employeeID), typeof(EmployeeQueryTableInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableGetByUsers(userID), typeof(EmployeeQueryTableInfo));
        }

        public int Add(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            return (int)DataProvider.Instance().EmployeeQueryTableAdd(objEmployeeQueryTable.QueryTitle, objEmployeeQueryTable.Description, objEmployeeQueryTable.QueryReceivedBy, objEmployeeQueryTable.IssueDate, objEmployeeQueryTable.QueryIssuedBy, objEmployeeQueryTable.QueryLetter, objEmployeeQueryTable.EmployeeResponse, objEmployeeQueryTable.ResponseDate, objEmployeeQueryTable.EmpResponseLetter, objEmployeeQueryTable.DiscipliineType_FK, objEmployeeQueryTable.DisciplineDetails, objEmployeeQueryTable.DisciplineLetter, objEmployeeQueryTable.DisciplineDate, objEmployeeQueryTable.DisciplinedBy);
        }
        // sending query  (string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter)
        public int AddQuery(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            return (int)DataProvider.Instance().EmployeeQueryTableAddQuery(objEmployeeQueryTable.QueryTitle, objEmployeeQueryTable.Description, objEmployeeQueryTable.QueryReceivedBy, objEmployeeQueryTable.IssueDate, objEmployeeQueryTable.QueryIssuedBy, objEmployeeQueryTable.QueryLetter);
        }


        public void Update(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            DataProvider.Instance().EmployeeQueryTableUpdate(objEmployeeQueryTable.QueryID, objEmployeeQueryTable.QueryTitle, objEmployeeQueryTable.Description, objEmployeeQueryTable.QueryReceivedBy, objEmployeeQueryTable.IssueDate, objEmployeeQueryTable.QueryIssuedBy, objEmployeeQueryTable.QueryLetter, objEmployeeQueryTable.EmployeeResponse, objEmployeeQueryTable.ResponseDate, objEmployeeQueryTable.EmpResponseLetter, objEmployeeQueryTable.DiscipliineType_FK, objEmployeeQueryTable.DisciplineDetails, objEmployeeQueryTable.DisciplineLetter, objEmployeeQueryTable.DisciplineDate, objEmployeeQueryTable.DisciplinedBy);
        }

        // update Query  Response 

        public void UpdateQueryResponse(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            DataProvider.Instance().EmployeeQueryTableUpdateQueryResponse(objEmployeeQueryTable.QueryID, objEmployeeQueryTable.EmployeeResponse, objEmployeeQueryTable.ResponseDate, objEmployeeQueryTable.EmpResponseLetter);
        }

        // update query discipline EmployeeQueryTableUpdateQueryDiscipline
        public void UpdateQueryDiscipline(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            DataProvider.Instance().EmployeeQueryTableUpdateQueryDiscipline(objEmployeeQueryTable.QueryID, objEmployeeQueryTable.DiscipliineType_FK, objEmployeeQueryTable.DisciplineDetails, objEmployeeQueryTable.DisciplineLetter, objEmployeeQueryTable.DisciplineDate, objEmployeeQueryTable.DisciplinedBy);
        }
        public void UpdateQueryDisciplineSuspention(EmployeeQueryTableInfo objEmployeeQueryTable)
        {
            DataProvider.Instance().EmployeeQueryTableUpdateQueryDisciplineSuspention(objEmployeeQueryTable.QueryID, objEmployeeQueryTable.DiscipliineType_FK, objEmployeeQueryTable.SuspentionStartDate, objEmployeeQueryTable.SuspentionEndDate, objEmployeeQueryTable.SuspentionDuration, objEmployeeQueryTable.DisciplineDetails, objEmployeeQueryTable.DisciplineLetter, objEmployeeQueryTable.DisciplineDate, objEmployeeQueryTable.DisciplinedBy);
        }
        
        public void Delete(int queryID)
        {
            DataProvider.Instance().EmployeeQueryTableDelete(queryID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }


    //

    public class EmployeeQueryTableLogController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public EmployeeQueryTableLogInfo Get(int queryLogID)
        {
            return (EmployeeQueryTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeQueryTableLogGet(queryLogID), typeof(EmployeeQueryTableLogInfo));
        }
        public EmployeeQueryTableLogInfo LogGetByEmpQuery(int queryID)
        {
            return (EmployeeQueryTableLogInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().EmployeeQueryTableLogGetByEmpQuery(queryID), typeof(EmployeeQueryTableLogInfo));
        }
        
        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableLogList(), typeof(EmployeeQueryTableLogInfo));
        }

        public ArrayList GetByEmployeeDetails(int employeeID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableLogGetByEmployeeDetails(employeeID), typeof(EmployeeQueryTableLogInfo));
        }
        public ArrayList GetByEmployeeQueryTable(int queryID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableLogGetByEmployeeQueryTable(queryID), typeof(EmployeeQueryTableLogInfo));
        }
        public ArrayList GetByUsers(int userID)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().EmployeeQueryTableLogGetByUsers(userID), typeof(EmployeeQueryTableLogInfo));
        }

        public int Add(EmployeeQueryTableLogInfo objEmployeeQueryTableLog)
        {
            return (int)DataProvider.Instance().EmployeeQueryTableLogAdd(objEmployeeQueryTableLog.QueryTitle, objEmployeeQueryTableLog.Description, objEmployeeQueryTableLog.QueryReceivedBy, objEmployeeQueryTableLog.IssueDate, objEmployeeQueryTableLog.QueryIssuedBy, objEmployeeQueryTableLog.QueryLetter, objEmployeeQueryTableLog.EmployeeResponse, objEmployeeQueryTableLog.ResponseDate, objEmployeeQueryTableLog.EmpResponseLetter, objEmployeeQueryTableLog.DiscipliineType_FK, objEmployeeQueryTableLog.DisciplineDetails, objEmployeeQueryTableLog.DisciplineLetter, objEmployeeQueryTableLog.DisciplineDate, objEmployeeQueryTableLog.DisciplinedBy, objEmployeeQueryTableLog.QueryID_FK);
        }

        // sending query  (string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter)
        public int LogAddQuery(EmployeeQueryTableLogInfo objEmployeeQueryTableLog)
        {
            return (int)DataProvider.Instance().EmployeeQueryTableLogAddQuery(objEmployeeQueryTableLog.QueryTitle, objEmployeeQueryTableLog.Description, objEmployeeQueryTableLog.QueryReceivedBy, objEmployeeQueryTableLog.IssueDate, objEmployeeQueryTableLog.QueryIssuedBy, objEmployeeQueryTableLog.QueryLetter, objEmployeeQueryTableLog.QueryID_FK);
        }

        public void Update(EmployeeQueryTableLogInfo objEmployeeQueryTableLog)
        {
            DataProvider.Instance().EmployeeQueryTableLogUpdate(objEmployeeQueryTableLog.QueryLogID, objEmployeeQueryTableLog.QueryTitle, objEmployeeQueryTableLog.Description, objEmployeeQueryTableLog.QueryReceivedBy, objEmployeeQueryTableLog.IssueDate, objEmployeeQueryTableLog.QueryIssuedBy, objEmployeeQueryTableLog.QueryLetter, objEmployeeQueryTableLog.EmployeeResponse, objEmployeeQueryTableLog.ResponseDate, objEmployeeQueryTableLog.EmpResponseLetter, objEmployeeQueryTableLog.DiscipliineType_FK, objEmployeeQueryTableLog.DisciplineDetails, objEmployeeQueryTableLog.DisciplineLetter, objEmployeeQueryTableLog.DisciplineDate, objEmployeeQueryTableLog.DisciplinedBy, objEmployeeQueryTableLog.QueryID_FK);
        }
        // update Query  Response 

        public void LogUpdateQueryResponse(EmployeeQueryTableLogInfo objEmployeeQueryTableLog)
        {
            DataProvider.Instance().EmployeeQueryTableLogUpdateQueryResponse(objEmployeeQueryTableLog.QueryLogID, objEmployeeQueryTableLog.EmployeeResponse, objEmployeeQueryTableLog.ResponseDate, objEmployeeQueryTableLog.EmpResponseLetter, objEmployeeQueryTableLog.QueryID_FK);
        }

        // update query discipline EmployeeQueryTableUpdateQueryDiscipline
        public void LogUpdateQueryDiscipline(EmployeeQueryTableLogInfo objEmployeeQueryTableLog)
        {
            DataProvider.Instance().EmployeeQueryTableLogUpdateQueryDiscipline(objEmployeeQueryTableLog.QueryLogID, objEmployeeQueryTableLog.DiscipliineType_FK, objEmployeeQueryTableLog.DisciplineDetails, objEmployeeQueryTableLog.DisciplineLetter, objEmployeeQueryTableLog.DisciplineDate, objEmployeeQueryTableLog.DisciplinedBy, objEmployeeQueryTableLog.QueryID_FK);
        }
        public void LogUpdateQueryDisciplineSuspention(EmployeeQueryTableLogInfo objEmployeeQueryTableLog)
        {
            DataProvider.Instance().EmployeeQueryTableLogUpdateQueryDisciplineSuspention(objEmployeeQueryTableLog.QueryLogID, objEmployeeQueryTableLog.DiscipliineType_FK, objEmployeeQueryTableLog.SuspentionStartDate, objEmployeeQueryTableLog.SuspentionEndDate, objEmployeeQueryTableLog.SuspentionDuration, objEmployeeQueryTableLog.DisciplineDetails, objEmployeeQueryTableLog.DisciplineLetter, objEmployeeQueryTableLog.DisciplineDate, objEmployeeQueryTableLog.DisciplinedBy, objEmployeeQueryTableLog.QueryID_FK);
        }
        
        public void Delete(int queryLogID)
        {
            DataProvider.Instance().EmployeeQueryTableLogDelete(queryLogID);
        }
        #endregion

        #region "Optional Interfaces"
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            return null;
        }

        public string ExportModule(int ModuleID)
        {
            return "";
        }

        public void ImportModule(int ModuleID, string Content, string Version, int UserId)
        {
        }
        #endregion
    }

   
}