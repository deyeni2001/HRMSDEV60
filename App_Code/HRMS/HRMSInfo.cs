using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dokun.neetbeet;

namespace Dokun.neetbeet


{

    public class HRMSInfo
    {
        public HRMSInfo()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }


    

      public class AuditTrailInfo
    {
        #region "Private Members"

        int _logId;
        int _logUserId;
        String _logTable;
        int _logAction;
        String _logDesc;
        String _logOldVal;
        String  _logNewVal;
        DateTime _logTime;

        #endregion

        #region "Constructors"
        public AuditTrailInfo()
        {
        }

        public AuditTrailInfo(int logUserId, string logTable, int logAction, string logDesc, string logOldVal, string logNewVal, DateTime logTime)
        {
            this.logUserId = logUserId;
            this.logTable = logTable;
            this.logAction = logAction;
            this.logDesc = logDesc;
            this.logOldVal = logOldVal;
            this.logNewVal = logNewVal;
            this.logTime = logTime;

        }
        public AuditTrailInfo(int logId, int logUserId, string logTable, int logAction, string logDesc, string logOldVal, string logNewVal, DateTime logTime)
        {
            this.logId = logId;
            this.logUserId = logUserId;
            this.logTable = logTable;
            this.logAction = logAction;
            this.logDesc = logDesc;
            this.logOldVal = logOldVal;
            this.logNewVal = logNewVal;
            this.logTime = logTime;
        }


        #endregion

        #region "Public Properties"
        public int logId
        {
            get { return _logId; }
            set { _logId = value; }
        }

        public int logUserId
        {
            get { return _logUserId; }
            set { _logUserId = value; }
        }

        public String logTable
        {
            get { return _logTable; }
            set { _logTable = value; }
        }

        public int logAction
        {
            get { return _logAction; }
            set { _logAction = value; }
        }

        public string logDesc
        {
            get { return _logDesc; }
            set { _logDesc = value; }
        }


        public string logOldVal
        {
            get { return _logOldVal; }
            set { _logOldVal = value; }
        }
        public string logNewVal
        {
            get { return _logNewVal; }
            set { _logNewVal = value; }
        }
        public DateTime logTime
        {
            get { return _logTime; }
            set { _logTime = value; }
        }

        #endregion
    }


    public class DashBoardNotificationsInfo
    {
        #region "Private Members"

        int _msgId;
        int _msgTo;
        String _msgFrom;
        String _msgLink;
        String _msgText;
        int _msgStatus;
        DateTime _msgTime;

        #endregion

        #region "Constructors"
        public DashBoardNotificationsInfo()
        {
        }

        public DashBoardNotificationsInfo(int msgTo, string msgFrom, string msgLink, string msgText,int msgStatus, DateTime  msgTime )
        {
            this.msgTo = msgTo;
            this.msgFrom = msgFrom;
            this.msgLink = msgLink;
            this.msgText = msgText;
            this.msgStatus = msgStatus;
            this.msgTime = msgTime;

        }
        public DashBoardNotificationsInfo(int msgId, int msgTo, string msgFrom, string msgLink, string msgText, int msgStatus, DateTime  msgTime)
        {
            this.msgId = msgId;
            this.msgTo = msgTo;
            this.msgFrom = msgFrom;
            this.msgLink = msgLink;
            this.msgText = msgText;
            this.msgStatus = msgStatus;
            this.msgTime = msgTime;
        }


        #endregion

        #region "Public Properties"
        public int msgId
        {
            get { return _msgId; }
            set { _msgId = value; }
        }

        public int msgTo
        {
            get { return _msgTo; }
            set { _msgTo = value; }
        }

        public String msgFrom
        {
            get { return _msgFrom; }
            set { _msgFrom = value; }
        }
        public string msgLink
        {
            get { return _msgLink; }
            set { _msgLink = value; }
        }

        public string msgText
        {
            get { return _msgText; }
            set { _msgText = value; }
        }

        public int  msgStatus
        {
            get { return _msgStatus; }
            set { _msgStatus = value; }
        }
        public DateTime msgTime
        {
            get { return _msgTime; }
            set { _msgTime = value; }
        }

        #endregion
    }

    public class EmployeeGradeInfo
    {
        #region "Private Members"
        int _GradeId;
        String _GradeName;
        String _GradeCode;
        String _GradeDescription;
        #endregion

        #region "Constructors"
        public EmployeeGradeInfo()
        {
        }

        public EmployeeGradeInfo(String GradeName, String GradeCode, string GradeDescription)
        {
            this.GradeName = GradeName;
            this.GradeCode = GradeCode;
            this.GradeDescription = GradeDescription;
        }
        public EmployeeGradeInfo(int GradeId, String GradeName, String GradeCode, string GradeDescription)
        {
            this.GradeId = GradeId;
            this.GradeName = GradeName;
            this.GradeCode = GradeCode;
            this.GradeDescription = GradeDescription;
        }


        #endregion

        #region "Public Properties"
        public int GradeId
        {
            get { return _GradeId; }
            set { _GradeId = value; }
        }

        public String  GradeName
        {
            get { return _GradeName; }
            set { _GradeName = value; }
        }
        public string GradeCode
        {
            get { return _GradeCode; }
            set { _GradeCode = value; }
        }

        public string GradeDescription
        {
            get { return _GradeDescription; }
            set { _GradeDescription = value; }
        }

        #endregion
    }


    public class DepartmentHeadInfo
    {
        #region "Private Members"
        int _RecId;
        int _DeptId;
        int _DeptHead;
        DateTime _StartDate;
        DateTime _EndDate;
        #endregion

        #region "Constructors"
        public DepartmentHeadInfo()
        {
        }

        public DepartmentHeadInfo(int DeptId, int DeptHead, DateTime  StartDate, DateTime  EndDate)
        {
            this.DeptId = DeptId;
            this.DeptHead = DeptHead;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        public DepartmentHeadInfo(int rec_Id, int DeptId, int DeptHead, DateTime StartDate, DateTime EndDate)
        {
            this.RecId = RecId;
            this.DeptId = DeptId;
            this.DeptHead = DeptHead;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }


        #endregion

        #region "Public Properties"
        public int DeptId
        {
            get { return _DeptId; }
            set { _DeptId = value; }
        }

        public int DeptHead
        {
            get { return _DeptHead; }
            set { _DeptHead = value; }
        }
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
    
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        public int RecId
        {
            get { return _RecId; }
            set { _RecId = value; }
        }

        #endregion
    }


    public class DepartmentEmployeesInfo
    {
        #region "Private Members"
       
        int _DeptEmpCode;
        int _EmpStatus;
        int _DeptId;
        String _JobTitle;
        String _Ptitle;
        String _Fname;
        String _Middlename;
        String _Lastname;
        String _Email;
        String _PhoneExt;
        String _MobileNo;
        String _OfficeRoom;
        String _EmpType;
        String _Passport;
        String _UserId;



     
        #endregion

        #region "Constructors"
        public DepartmentEmployeesInfo()
        {
        }

        public DepartmentEmployeesInfo(int EmpStatus,int DeptId,string JobTitle,string Ptitle,string Fname, string Middlename,string Lastname,string Email,string PhoneExt,string  MobileNo, string OfficeRoom, string EmpType,string Passport, string UserId)
        {
            this.EmpStatus = EmpStatus;
            this.DeptId = DeptId;
            this.JobTitle = JobTitle;
            this.Ptitle = Ptitle;
            this.Fname = Fname;
            this.Middlename = Middlename;
            this.Lastname = Lastname;
            this.Email = Email;
            this.PhoneExt = PhoneExt;
            this.MobileNo = MobileNo; 
            this.OfficeRoom = OfficeRoom;
            this.EmpType = EmpType;
            this.Passport = Passport;
            this.UserId = UserId;

        }
        public DepartmentEmployeesInfo(int DeptEmpCode, int EmpStatus, int DeptId, string JobTitle, string Ptitle, string Fname, string Middlename, string Lastname, string Email, string PhoneExt, string MobileNo, string OfficeRoom, string EmpType, string Passport, string UserId)
        {
            this.DeptEmpCode = DeptEmpCode;
            this.EmpStatus = EmpStatus;
            this.DeptId = DeptId;
            this.JobTitle = JobTitle;
            this.Ptitle = Ptitle;
            this.Fname = Fname;
            this.Middlename = Middlename;
            this.Lastname = Lastname;
            this.Email = Email;
            this.PhoneExt = PhoneExt;
            this.MobileNo = MobileNo;
            this.OfficeRoom = OfficeRoom;
            this.EmpType = EmpType;
            this.Passport = Passport;
            this.UserId = UserId;

        }

        #endregion

        #region "Public Properties"

       
        public int DeptEmpCode
        {
            get { return _DeptEmpCode; }
            set { _DeptEmpCode = value; }
        }
        public int EmpStatus
        {
            get { return _EmpStatus; }
            set { _EmpStatus = value; }
        }
        public int DeptId
        {
            get { return _DeptId; }
            set { _DeptId = value; }
        }
        public string JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }
        public string Ptitle
        {
            get { return _Ptitle; }
            set { _Ptitle = value; }
        }
        public string Fname
        {
            get { return _Fname; }
            set { _Fname = value; }
        }
        public string Middlename
        {
            get { return _Middlename; }
            set { _Middlename = value; }
        }
        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string PhoneExt
        {
            get { return _PhoneExt; }
            set { _PhoneExt = value; }
        }
        public string MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }
        public string OfficeRoom
        {
            get { return _OfficeRoom; }
            set { _OfficeRoom = value; }
        }
        public string EmpType
        {
            get { return _EmpType; }
            set { _EmpType = value; }
        }

        public string Passport
        {
            get { return _Passport; }
            set { _Passport = value; }
        }

        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        #endregion
    }

    public class DepartmentTableInfo
    {
        #region "Private Members"
        int _DeptId;
        String _DeptName;
        String _DeptCode;
        int _SuperDept;
        String _DeptRole;
        #endregion

        #region "Constructors"
        public DepartmentTableInfo()
        {
        }

        public DepartmentTableInfo(String DeptName, String DeptCode, int SuperDept, String DeptRole)
        {
            this.DeptName = DeptName;
            this.DeptCode = DeptCode;
            this.SuperDept = SuperDept;
            this.DeptRole = DeptRole;
        }
        public DepartmentTableInfo(int DeptId, string DeptName, String DeptCode, int SuperDept, String DeptRole)
        {
            this.DeptId = DeptId;
            this.DeptName = DeptName;
            this.DeptCode = DeptCode;
            this.SuperDept = SuperDept;
            this.DeptRole = DeptRole;
        }


        #endregion

        #region "Public Properties"
        public int DeptId
        {
            get { return _DeptId; }
            set { _DeptId = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }
        public string DeptCode
        {
            get { return _DeptCode; }
            set { _DeptCode = value; }
        }
        public int SuperDept
        {
            get { return _SuperDept; }
            set { _SuperDept = value; }
        }
        public string DeptRole
        {
            get { return _DeptRole; }
            set { _DeptRole = value; }
        }

        #endregion
    }



}



    
