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
using Dokun.neetbeet;


namespace Dokun.neetbeet
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




    public class DashBoardNotificationsController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"
        public DashBoardNotificationsInfo Get(int msgId)
        {
            return (DashBoardNotificationsInfo)DotNetNuke.Common.Utilities.CBO.FillObject(DataProvider.Instance().DashBoardNotificationsGet(msgId), typeof(DashBoardNotificationsInfo));
        }


        public ArrayList List()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().DashBoardNotificationsList(), typeof(DashBoardNotificationsInfo));
        }

        public ArrayList List(int msgTo)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection(DataProvider.Instance().DashBoardNotificationsList(msgTo), typeof(DashBoardNotificationsInfo));
        }


        public int Add(DashBoardNotificationsInfo objInfo)
        {
            return (int)DataProvider.Instance().DashBoardNotificationsAdd(objInfo.msgTo , objInfo.msgFrom , objInfo.msgLink ,objInfo.msgText,objInfo.msgStatus ,objInfo.msgTime);
        }

        public void Update(DashBoardNotificationsInfo objInfo)
        {
            DataProvider.Instance().DashBoardNotificationsUpdate(objInfo.msgId, objInfo.msgTo, objInfo.msgFrom, objInfo.msgLink, objInfo.msgText, objInfo.msgStatus, objInfo.msgTime);
        }

        public void Delete(int msgId)
        {
            DataProvider.Instance().DashBoardNotificationsDelete(msgId);
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

    public class AuditTrailController : DotNetNuke.Entities.Modules.ISearchable, DotNetNuke.Entities.Modules.IPortable
    {
        #region "Public Methods"

        public int Add(AuditTrailInfo objInfo)
        {
            return (int)DataProvider.Instance().AuditTrailAdd(objInfo.logUserId, objInfo.logTable , objInfo.logAction , objInfo.logDesc, objInfo.logOldVal , objInfo.logNewVal , objInfo.logTime);
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

   
}