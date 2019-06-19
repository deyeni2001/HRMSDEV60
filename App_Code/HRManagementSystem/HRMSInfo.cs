using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ola.HRMangmntSyst;

namespace ola.HRMangmntSyst


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

    public class CountryTableInfo
    {
        #region "Private Members"
        int _countryID;
        string _countryName;
        #endregion

        #region "Constructors"
        public CountryTableInfo()
        {
        }

        public CountryTableInfo(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }
        #endregion

        #region "Public Properties"
        public int CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
        #endregion
    }

    public class StateTableInfo
    {
        #region "Private Members"
        int _stateID;
        string _stateName;
        string _stateCode;
        int _countryID;
        #endregion

        #region "Constructors"
        public StateTableInfo()
        {
        }

        public StateTableInfo(int stateID, string stateName, string stateCode, int countryID)
        {
            this.StateID = stateID;
            this.StateName = stateName;
            this.StateCode = stateCode;
            this.CountryID = countryID;
        }
        #endregion

        #region "Public Properties"
        public int StateID
        {
            get { return _stateID; }
            set { _stateID = value; }
        }

        public string StateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        public string StateCode
        {
            get { return _stateCode; }
            set { _stateCode = value; }
        }

        public int CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }
        #endregion
    }

    public class SenatorialTableInfo
    {
        #region "Private Members"
        int _senID;
        string _senCode;
        string _senName;
        int _senStateID_FK;
        #endregion

        #region "Constructors"
        public SenatorialTableInfo()
        {
        }

        public SenatorialTableInfo(int senID, string senCode, string senName, int senStateID_FK)
        {
            this.senID = senID;
            this.senCode = senCode;
            this.senName = senName;
            this.senStateID_FK = senStateID_FK;
        }
        #endregion

        #region "Public Properties"
        public int senID
        {
            get { return _senID; }
            set { _senID = value; }
        }

        public string senCode
        {
            get { return _senCode; }
            set { _senCode = value; }
        }

        public string senName
        {
            get { return _senName; }
            set { _senName = value; }
        }

        public int senStateID_FK
        {
            get { return _senStateID_FK; }
            set { _senStateID_FK = value; }
        }
        #endregion
    }

    public class LGATableInfo
    {
        #region "Private Members"
        int _lgaID;
        string _lgaName;
        int _stateID;
        #endregion

        #region "Constructors"
        public LGATableInfo()
        {
        }

        public LGATableInfo(int lgaID, string lgaName, int stateID)
        {
            this.LgaID = lgaID;
            this.LgaName = lgaName;
            this.StateID = stateID;
        }
        #endregion

        #region "Public Properties"
        public int LgaID
        {
            get { return _lgaID; }
            set { _lgaID = value; }
        }

        public string LgaName
        {
            get { return _lgaName; }
            set { _lgaName = value; }
        }

        public int StateID
        {
            get { return _stateID; }
            set { _stateID = value; }
        }
        #endregion
    }

    public class QualificationsInfo
    {
        #region "Private Members"
        int _qualifID;
        string _qualifName;
        #endregion

        #region "Constructors"
        public QualificationsInfo()
        {
        }

        public QualificationsInfo(int qualifID, string qualifName)
        {
            this.qualifID = qualifID;
            this.qualifName = qualifName;
        }
        #endregion

        #region "Public Properties"
        public int qualifID
        {
            get { return _qualifID; }
            set { _qualifID = value; }
        }

        public string qualifName
        {
            get { return _qualifName; }
            set { _qualifName = value; }
        }
        #endregion
    }

    public class GradeTableInfo
    {
        #region "Private Members"
        int _gradeID;
        string _gradeName;
        int _qaulifID_FK;
        #endregion

        #region "Constructors"
        public GradeTableInfo()
        {
        }

        public GradeTableInfo(int gradeID, string gradeName, int qaulifID_FK)
        {
            this.gradeID = gradeID;
            this.gradeName = gradeName;
            this.qaulifID_FK = qaulifID_FK;
        }
        #endregion

        #region "Public Properties"
        public int gradeID
        {
            get { return _gradeID; }
            set { _gradeID = value; }
        }

        public string gradeName
        {
            get { return _gradeName; }
            set { _gradeName = value; }
        }

        public int qaulifID_FK
        {
            get { return _qaulifID_FK; }
            set { _qaulifID_FK = value; }
        }
        #endregion
    }

    //ApplicantDepartmentTableInfo
    public class ApplicantDepartmentTableInfo
    {
        #region "Private Members"
        int _deptID;
        string _deptName;
        #endregion

        #region "Constructors"
        public ApplicantDepartmentTableInfo()
        {
        }

        public ApplicantDepartmentTableInfo(int deptID, string deptName)
        {
            this.DeptID = deptID;
            this.DeptName = deptName;
        }
        #endregion

        #region "Public Properties"
        public int DeptID
        {
            get { return _deptID; }
            set { _deptID = value; }
        }

        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
        #endregion
    }

    //ApplicantAvailablePositiontableInfo
    public class ApplicantAvailablePositiontableInfo
    {
        #region "Private Members"
        int _positionAppliedforID;
        string _positionAppliedForName;
        int _deptID_FK;
        #endregion

        #region "Constructors"
        public ApplicantAvailablePositiontableInfo()
        {
        }

        public ApplicantAvailablePositiontableInfo(int positionAppliedforID, string positionAppliedForName, int deptID_FK)
        {
            this.PositionAppliedforID = positionAppliedforID;
            this.PositionAppliedForName = positionAppliedForName;
            this.DeptID_FK = deptID_FK;
        }
        #endregion

        #region "Public Properties"
        public int PositionAppliedforID
        {
            get { return _positionAppliedforID; }
            set { _positionAppliedforID = value; }
        }

        public string PositionAppliedForName
        {
            get { return _positionAppliedForName; }
            set { _positionAppliedForName = value; }
        }

        public int DeptID_FK
        {
            get { return _deptID_FK; }
            set { _deptID_FK = value; }
        }
        #endregion
    }

    //public class ApplicantAvailablePositiontableInfo
    //{
    //    #region "Private Members"
    //    int _positionAppliedforID;
    //    string _positionAppliedForName;
    //    #endregion

    //    #region "Constructors"
    //    public ApplicantAvailablePositiontableInfo()
    //    {
    //    }

    //    public ApplicantAvailablePositiontableInfo(int positionAppliedforID, string positionAppliedForName)
    //    {
    //        this.PositionAppliedforID = positionAppliedforID;
    //        this.PositionAppliedForName = positionAppliedForName;
    //    }
    //    #endregion

    //    #region "Public Properties"
    //    public int PositionAppliedforID
    //    {
    //        get { return _positionAppliedforID; }
    //        set { _positionAppliedforID = value; }
    //    }

    //    public string PositionAppliedForName
    //    {
    //        get { return _positionAppliedForName; }
    //        set { _positionAppliedForName = value; }
    //    }
    //    #endregion
    //}

    public class ApplicantPersonalDetailsInfo
    {
        #region "Private Members"
        int _applicantID;
        string _applicantNum;
        string _DeptAppliedTo;
        string _positionAppliedFor;
        string _title;
        string _firstName;
        string _miiddleName;
        string _lastName;
        string _gender;
        string _dateOfBirth;
        string _age;
        string _maritalStatus;
        int _nationality_FK;
        int _stateOfOrigin_FK;
        int _lGA_FK;
        string _homeTown;
        string _phoneNo;
        string _email;
        string _contactAddress;
        string _religion;
        string _passport;
        string _applicationStatus;
        int _positionApproved_FK;
        int _departmentID_FK;
        int _levelID_FK;
        int _workLocationID_FK;
        string _resumptionDate;
        string _interviwerDecision;
        string _managementDecition;
        int _senID_FK;



        string _countryName;
        string _stateName;
        string _LgaName;
        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _nationality;
        string _stateOfOrigin;
        string _lga;
        string _approvedPositionName;
        string _senName;
  
        #endregion

        #region "Constructors"
        public ApplicantPersonalDetailsInfo()
        {
        }

        public ApplicantPersonalDetailsInfo(int applicantID, string applicantNum , string DeptAppliedTo, string positionAppliedFor ,
            string title , string firstName , string miiddleName , string lastName , string gender , string dateOfBirth ,
            string age , string maritalStatus , int nationality_FK , int stateOfOrigin_FK , int lGA_FK , string homeTown , 
            string phoneNo , string email , string contactAddress , string religion , string passport , string applicationStatus , 
            int positionApproved_FK , int departmentID_FK , int levelID_FK , int workLocationID_FK , string resumptionDate ,
            string interviwerDecision, string managementDecition, int senID_FK, 
            string countryName, string stateName, string LgaName,
            string DeptName, string PositionName, string LevelName, string Salary, string LocationName,
            string stateOfOrigin, string nationality, string lga, string approvedPositionName,string senName
            )
        {

            this.ApplicantID = applicantID;
            this.ApplicantNum = applicantNum;
            this.DeptAppliedTo = DeptAppliedTo;
            this.PositionAppliedFor = positionAppliedFor;
            this.Title = title;
            this.FirstName = firstName;
            this.MiiddleName = miiddleName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.MaritalStatus = maritalStatus;
            this.Nationality_FK = nationality_FK;
            this.StateOfOrigin_FK = stateOfOrigin_FK;
            this.LGA_FK = lGA_FK;
            this.HomeTown = homeTown;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.ContactAddress = contactAddress;
            this.Religion = religion;
            this.Passport = passport;
            this.ApplicationStatus = applicationStatus;
            this.PositionApproved_FK = positionApproved_FK;
            this.DepartmentID_FK = departmentID_FK;
            this.LevelID_FK = levelID_FK;
            this.WorkLocationID_FK = workLocationID_FK;
            this.ResumptionDate = resumptionDate;
            this.InterviwerDecision = interviwerDecision;
            this.ManagementDecition = managementDecition;
            this.senID_FK = senID_FK;



            this.countryName = countryName;
            this.stateName = stateName;
            this.LgaName = LgaName;
            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.Nationality = nationality;
            this.StateOfOrigin = stateOfOrigin;
            this.LGA = lga;
            this.ApprovedPositionName = approvedPositionName;
            this.senName = senName;
        }
        #endregion

        #region "Public Properties"
        public int ApplicantID
        {
            get { return _applicantID; }
            set { _applicantID = value; }
        }

        public string ApplicantNum
        {
            get { return _applicantNum; }
            set { _applicantNum = value; }
        }
        public string DeptAppliedTo
        {
            get { return _DeptAppliedTo; }
            set { _DeptAppliedTo = value; }
        }
        
        public string PositionAppliedFor
        {
            get { return _positionAppliedFor; }
            set { _positionAppliedFor = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiiddleName
        {
            get { return _miiddleName; }
            set { _miiddleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        public int Nationality_FK
        {
            get { return _nationality_FK; }
            set { _nationality_FK = value; }
        }

        public int StateOfOrigin_FK
        {
            get { return _stateOfOrigin_FK; }
            set { _stateOfOrigin_FK = value; }
        }

        public int LGA_FK
        {
            get { return _lGA_FK; }
            set { _lGA_FK = value; }
        }

        public string HomeTown
        {
            get { return _homeTown; }
            set { _homeTown = value; }
        }

        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string ContactAddress
        {
            get { return _contactAddress; }
            set { _contactAddress = value; }
        }

        public string Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }

        public string Passport
        {
            get { return _passport; }
            set { _passport = value; }
        }

        public string ApplicationStatus
        {
            get { return _applicationStatus; }
            set { _applicationStatus = value; }
        }

        public int PositionApproved_FK
        {
            get { return _positionApproved_FK; }
            set { _positionApproved_FK = value; }
        }

        public int DepartmentID_FK
        {
            get { return _departmentID_FK; }
            set { _departmentID_FK = value; }
        }

        public int LevelID_FK
        {
            get { return _levelID_FK; }
            set { _levelID_FK = value; }
        }

        public int WorkLocationID_FK
        {
            get { return _workLocationID_FK; }
            set { _workLocationID_FK = value; }
        }

        public string ResumptionDate
        {
            get { return _resumptionDate; }
            set { _resumptionDate = value; }
        }

        public string InterviwerDecision
        {
            get { return _interviwerDecision; }
            set { _interviwerDecision = value; }
        }

        public string ManagementDecition
        {
            get { return _managementDecition; }
            set { _managementDecition = value; }
        }
        public int senID_FK
        {
            get { return _senID_FK; }
            set { _senID_FK = value; }
        }
        

        public string countryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        public string stateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        public string LgaName
        {
            get { return _LgaName; }
            set { _LgaName = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }


        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }

        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }

        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }
        public string StateOfOrigin
        {
            get { return _stateOfOrigin; }
            set { _stateOfOrigin = value; }
        }

        public string LGA
        {
            get { return _lga; }
            set { _lga = value; }

        }

        public string ApprovedPositionName
        {
            get { return _approvedPositionName; }
            set { _approvedPositionName = value; }

        }

        public string senName
        {
            get { return _senName; }
            set { _senName = value; }

        }
        
        #endregion
    }
    

    public class ApplicantQualificationInfo
    {
        #region "Private Members"
        int _qualificationID;
        string _institutionName;
        string _qualificationType;
        string _course;
        string _grade;
        string _startYear;
        string _endYear;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantQualificationInfo()
        {
        }

        public ApplicantQualificationInfo(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK)
        {
            this.QualificationID = qualificationID;
            this.InstitutionName = institutionName;
            this.QualificationType = qualificationType;
            this.Course = course;
            this.Grade = grade;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int QualificationID
        {
            get { return _qualificationID; }
            set { _qualificationID = value; }
        }

        public string InstitutionName
        {
            get { return _institutionName; }
            set { _institutionName = value; }
        }

        public string QualificationType
        {
            get { return _qualificationType; }
            set { _qualificationType = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        public string EndYear
        {
            get { return _endYear; }
            set { _endYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }

    public class ApplicantProfQualificationInfo
    {
        #region "Private Members"
        int _profQualificationID;
        string _certificationName;
        string _certificateNo;
        string _stage;
        string _certYear;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantProfQualificationInfo()
        {
        }

        public ApplicantProfQualificationInfo(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK)
        {
            this.ProfQualificationID = profQualificationID;
            this.CertificationName = certificationName;
            this.CertificateNo = certificateNo;
            this.Stage = stage;
            this.CertYear = certYear;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int ProfQualificationID
        {
            get { return _profQualificationID; }
            set { _profQualificationID = value; }
        }

        public string CertificationName
        {
            get { return _certificationName; }
            set { _certificationName = value; }
        }

        public string CertificateNo
        {
            get { return _certificateNo; }
            set { _certificateNo = value; }
        }

        public string Stage
        {
            get { return _stage; }
            set { _stage = value; }
        }

        public string CertYear
        {
            get { return _certYear; }
            set { _certYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }

    public class ApplicantWorkExperienceInfo
    {
        #region "Private Members"
        int _workExperienceID;
        string _companyName;
        string _positionHeld;
        string _jobDescriprtion;
        string _salaryReceived;
        string _startYear;
        string _endYear;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantWorkExperienceInfo()
        {
        }

        public ApplicantWorkExperienceInfo(int workExperienceID, string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK)
        {
            this.WorkExperienceID = workExperienceID;
            this.CompanyName = companyName;
            this.PositionHeld = positionHeld;
            this.JobDescriprtion = jobDescriprtion;
            this.SalaryReceived = salaryReceived;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int WorkExperienceID
        {
            get { return _workExperienceID; }
            set { _workExperienceID = value; }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string PositionHeld
        {
            get { return _positionHeld; }
            set { _positionHeld = value; }
        }

        public string JobDescriprtion
        {
            get { return _jobDescriprtion; }
            set { _jobDescriprtion = value; }
        }

        public string SalaryReceived
        {
            get { return _salaryReceived; }
            set { _salaryReceived = value; }
        }

        public string StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        public string EndYear
        {
            get { return _endYear; }
            set { _endYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }

    public class ApplicantDocumentInfo
    {
        #region "Private Members"
        int _documentID;
        string _documentType;
        string _documentPath;
        int _applicantID_FK;
        #endregion

        #region "Constructors"
        public ApplicantDocumentInfo()
        {
        }

        public ApplicantDocumentInfo(int documentID, string documentType, string documentPath, int applicantID_FK)
        {
            this.DocumentID = documentID;
            this.DocumentType = documentType;
            this.DocumentPath = documentPath;
            this.ApplicantID_FK = applicantID_FK;
        }
        #endregion

        #region "Public Properties"
        public int DocumentID
        {
            get { return _documentID; }
            set { _documentID = value; }
        }

        public string DocumentType
        {
            get { return _documentType; }
            set { _documentType = value; }
        }

        public string DocumentPath
        {
            get { return _documentPath; }
            set { _documentPath = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }
        #endregion
    }

    public class EmployeeDepartmentTableInfo
        {
            #region "Private Members"
            int _deptID;
            string _deptName;
            #endregion

            #region "Constructors"
            public EmployeeDepartmentTableInfo()
            {
            }

            public EmployeeDepartmentTableInfo(int deptID, string deptName)
            {
                this.DeptID = deptID;
                this.DeptName = deptName;
            }
            #endregion

            #region "Public Properties"
            public int DeptID
            {
                get { return _deptID; }
                set { _deptID = value; }
            }

            public string DeptName
            {
                get { return _deptName; }
                set { _deptName = value; }
            }
            #endregion
        }

        //EmployeePositionTableInfo
        public class EmployeePositionTableInfo
        {
            #region "Private Members"
            int _positionID;
            string _positionName;
            int _deptID_FK;
            #endregion

            #region "Constructors"
            public EmployeePositionTableInfo()
            {
            }

            public EmployeePositionTableInfo(int positionID, string positionName, int deptID_FK)
            {
                this.PositionID = positionID;
                this.PositionName = positionName;
                this.DeptID_FK = deptID_FK;
            }
            #endregion

            #region "Public Properties"
            public int PositionID
            {
                get { return _positionID; }
                set { _positionID = value; }
            }

            public string PositionName
            {
                get { return _positionName; }
                set { _positionName = value; }
            }

            public int DeptID_FK
            {
                get { return _deptID_FK; }
                set { _deptID_FK = value; }
            }
            #endregion
        }

        //EmployeeLevelInfo


        public class EmployeeLevelInfo
        {
            #region "Private Members"
            int _levelID;
            string _levelName;
            string _salary;
            string _salaryDetails;
            int _deptID_FK;
            int _positionID_FK;
            string _leaveEntitle;
            string _employeeCadre;
            #endregion

            #region "Constructors"
            public EmployeeLevelInfo()
            {
            }

            public EmployeeLevelInfo(int levelID, string levelName, string salary, string salaryDetails, int deptID_FK, int positionID_FK, string leaveEntitle, string employeeCadre)
            {
                this.LevelID = levelID;
                this.LevelName = levelName;
                this.Salary = salary;
                this.SalaryDetails = salaryDetails;
                this.DeptID_FK = deptID_FK;
                this.PositionID_FK = positionID_FK;
                this.LeaveEntitle = leaveEntitle;
                this.EmployeeCadre = employeeCadre;
            }
            #endregion

            #region "Public Properties"
            public int LevelID
            {
                get { return _levelID; }
                set { _levelID = value; }
            }

            public string LevelName
            {
                get { return _levelName; }
                set { _levelName = value; }
            }

            public string Salary
            {
                get { return _salary; }
                set { _salary = value; }
            }

            public string SalaryDetails
            {
                get { return _salaryDetails; }
                set { _salaryDetails = value; }
            }

            public int DeptID_FK
            {
                get { return _deptID_FK; }
                set { _deptID_FK = value; }
            }

            public int PositionID_FK
            {
                get { return _positionID_FK; }
                set { _positionID_FK = value; }
            }

            public string LeaveEntitle
            {
                get { return _leaveEntitle; }
                set { _leaveEntitle = value; }
            }
            public string EmployeeCadre
            {
                get { return _employeeCadre; }
                set { _employeeCadre = value; }
            }
            
            #endregion
        }
        //

        //EmployeeWorkLocationsInfo
        public class EmployeeWorkLocationsInfo
        {
            #region "Private Members"
            int _workLocationID;
            string _locationName;
            string _locationAddress;
            int _departmentID_FK;
            #endregion

            #region "Constructors"
            public EmployeeWorkLocationsInfo()
            {
            }

            public EmployeeWorkLocationsInfo(int workLocationID, string locationName, string locationAddress, int departmentID_FK)
            {
                this.WorkLocationID = workLocationID;
                this.LocationName = locationName;
                this.LocationAddress = locationAddress;
                this.DepartmentID_FK = departmentID_FK;
            }
            #endregion

            #region "Public Properties"
            public int WorkLocationID
            {
                get { return _workLocationID; }
                set { _workLocationID = value; }
            }

            public string LocationName
            {
                get { return _locationName; }
                set { _locationName = value; }
            }

            public string LocationAddress
            {
                get { return _locationAddress; }
                set { _locationAddress = value; }
            }

            public int DepartmentID_FK
            {
                get { return _departmentID_FK; }
                set { _departmentID_FK = value; }
            }
            #endregion
        }
  
        public class ApplicantInterviewInfo
        {
            #region "Private Members"
            int _interviewID;
            string _interviewer;
            string _interviewDate;
            int _applicantID_FK;
            string _applicantNum;
            int _experience;
            int _education;
            int _positionInterest;
            int _presentation;
            int _problemSolvingSkill;
            int _computerSkill;
            int _jobStability;
            int _otherCriteria;
            int _knowledgeLevel;
            int _positionExcitement;
            int _experienceLevel;
            int _effectiveParticipation;
            int _communicationLevel;
            int _finalListInclusion;
            string _strength;
            string _weakness;
            string _additionalComment;
            string _recommendation;
            string _hODName;
            string _hODRecommendation;
            string _managementRecommendation;
            int _ratingKeyID_FK;
            #endregion

            #region "Constructors"
            public ApplicantInterviewInfo()
            {
            }

            public ApplicantInterviewInfo(int interviewID, string interviewer, string interviewDate, int applicantID_FK, string applicantNum, int experience, int education, int positionInterest, int presentation, int problemSolvingSkill, int computerSkill, int jobStability, int otherCriteria, int knowledgeLevel, int positionExcitement, int experienceLevel, int effectiveParticipation, int communicationLevel, int finalListInclusion, string strength, string weakness, string additionalComment, string recommendation, string hODName, string hODRecommendation, string managementRecommendation, int ratingKeyID_FK)
            {
                this.InterviewID = interviewID;
                this.Interviewer = interviewer;
                this.InterviewDate = interviewDate;
                this.ApplicantID_FK = applicantID_FK;
                this.ApplicantNum = applicantNum;
                this.Experience = experience;
                this.Education = education;
                this.PositionInterest = positionInterest;
                this.Presentation = presentation;
                this.ProblemSolvingSkill = problemSolvingSkill;
                this.ComputerSkill = computerSkill;
                this.JobStability = jobStability;
                this.OtherCriteria = otherCriteria;
                this.KnowledgeLevel = knowledgeLevel;
                this.PositionExcitement = positionExcitement;
                this.ExperienceLevel = experienceLevel;
                this.EffectiveParticipation = effectiveParticipation;
                this.CommunicationLevel = communicationLevel;
                this.FinalListInclusion = finalListInclusion;
                this.Strength = strength;
                this.Weakness = weakness;
                this.AdditionalComment = additionalComment;
                this.Recommendation = recommendation;
                this.HODName = hODName;
                this.HODRecommendation = hODRecommendation;
                this.ManagementRecommendation = managementRecommendation;
                this.RatingKeyID_FK = ratingKeyID_FK;
            }
            #endregion

            #region "Public Properties"
            public int InterviewID
            {
                get { return _interviewID; }
                set { _interviewID = value; }
            }

            public string Interviewer
            {
                get { return _interviewer; }
                set { _interviewer = value; }
            }

            public string InterviewDate
            {
                get { return _interviewDate; }
                set { _interviewDate = value; }
            }

            public int ApplicantID_FK
            {
                get { return _applicantID_FK; }
                set { _applicantID_FK = value; }
            }

            public string ApplicantNum
            {
                get { return _applicantNum; }
                set { _applicantNum = value; }
            }

            public int Experience
            {
                get { return _experience; }
                set { _experience = value; }
            }

            public int Education
            {
                get { return _education; }
                set { _education = value; }
            }

            public int PositionInterest
            {
                get { return _positionInterest; }
                set { _positionInterest = value; }
            }

            public int Presentation
            {
                get { return _presentation; }
                set { _presentation = value; }
            }

            public int ProblemSolvingSkill
            {
                get { return _problemSolvingSkill; }
                set { _problemSolvingSkill = value; }
            }

            public int ComputerSkill
            {
                get { return _computerSkill; }
                set { _computerSkill = value; }
            }

            public int JobStability
            {
                get { return _jobStability; }
                set { _jobStability = value; }
            }

            public int OtherCriteria
            {
                get { return _otherCriteria; }
                set { _otherCriteria = value; }
            }

            public int KnowledgeLevel
            {
                get { return _knowledgeLevel; }
                set { _knowledgeLevel = value; }
            }

            public int PositionExcitement
            {
                get { return _positionExcitement; }
                set { _positionExcitement = value; }
            }

            public int ExperienceLevel
            {
                get { return _experienceLevel; }
                set { _experienceLevel = value; }
            }

            public int EffectiveParticipation
            {
                get { return _effectiveParticipation; }
                set { _effectiveParticipation = value; }
            }

            public int CommunicationLevel
            {
                get { return _communicationLevel; }
                set { _communicationLevel = value; }
            }

            public int FinalListInclusion
            {
                get { return _finalListInclusion; }
                set { _finalListInclusion = value; }
            }

            public string Strength
            {
                get { return _strength; }
                set { _strength = value; }
            }

            public string Weakness
            {
                get { return _weakness; }
                set { _weakness = value; }
            }

            public string AdditionalComment
            {
                get { return _additionalComment; }
                set { _additionalComment = value; }
            }

            public string Recommendation
            {
                get { return _recommendation; }
                set { _recommendation = value; }
            }

            public string HODName
            {
                get { return _hODName; }
                set { _hODName = value; }
            }

            public string HODRecommendation
            {
                get { return _hODRecommendation; }
                set { _hODRecommendation = value; }
            }

            public string ManagementRecommendation
            {
                get { return _managementRecommendation; }
                set { _managementRecommendation = value; }
            }

            public int RatingKeyID_FK
            {
                get { return _ratingKeyID_FK; }
                set { _ratingKeyID_FK = value; }
            }
            #endregion
        }


        //EmployeeDetailsInfo

       
	public class EmployeeDetailsInfo
	{
        #region "Private Members"
        int _employeeID;
        string _employeeNum;
        string _title;
        string _firstName;
        string _miiddleName;
        string _lastName;
        string _gender;
        string _dateOfBirth;
        string _age;
        string _maritalStatus;
        int _nationality_FK;
        int _stateOfOrigin_FK;
        int _lGA_FK;
        string _homeTown;
        string _phoneNo;
        string _email;
        string _contactAddress;
        string _religion;
        string _passport;
        string _accountName;
        string _accountNo;
        string _bankName;
        int _department_FK;
        int _positionHeld_FK;
        int _employeeLevel_FK;
        int _workLocation_FK;
        string _confirmationDate;
        int _confirmedBy;
        string _employeeStatus;
        string _startDate;
        string _nxtOfKinFName;
        string _nxtOfKinMidName;
        string _nxtOfKinLName;
        string _nxtOfKinAddress;
        string _nxtOfKinPhoneNo;
        string _nxtOfKinEmail;
        string _nxtOfKinOccupation;
        string _nxtOfKinRelationship;
        string _spouseNames;
        string _spouseAddress;
        string _spousePhoneNo;
        string _spouseEmail;
        string _spouseOccupation;
        string _spouseEmployerNames;
        string _refree1Names;
        string _refree1Occupation;
        string _refree1PhoneNum;
        string _refree1Email;
        string _refree1ContactAddr;
        string _refree2Names;
        string _refree2Occupation;
        string _refree2PhoneNum;
        string _refree2Email;
        string _refree2ContactAddr;
        string _guarrantorNames;
        string _guarrantorFormPath;
        int _applicantID_FK;
        int _employeeUserID_FK;
        string _promotionDate;
        int _promotedBy;
        string _transferDate;
        int _transferedBy;
        int _supervisorID;
        int _hRID;
        int _hODID;
        int _empOfficialPosition;
        string _employeeCadre;
        int _senID_FK;


        string _countryName;
        string _stateName;
        string _LgaName;
        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _LocationAddress;
        string _Username;
        string _ConfirmByName;
        string _leaveEntitle;
        string _senName;
        string _EmpNames;
        string _promoByName;
        string _TransferByName;
       
        
            #endregion

            #region "Constructors"
            public EmployeeDetailsInfo()
            {
            }

            public EmployeeDetailsInfo(int employeeID, string employeeNum , string title , string firstName , string miiddleName ,
                string lastName , string gender , string dateOfBirth , string age , string maritalStatus , int nationality_FK , 
                int stateOfOrigin_FK , int lGA_FK , string homeTown , string phoneNo , string email , string contactAddress , 
                string religion , string passport , string accountName , string accountNo , string bankName , int department_FK ,
                int positionHeld_FK , int employeeLevel_FK , int workLocation_FK , string confirmationDate , int confirmedBy ,
                string employeeStatus , string startDate , string nxtOfKinFName , string nxtOfKinMidName , string nxtOfKinLName ,
                string nxtOfKinAddress , string nxtOfKinPhoneNo , string nxtOfKinEmail , string nxtOfKinOccupation , 
                string nxtOfKinRelationship , string spouseNames , string spouseAddress , string spousePhoneNo, string spouseEmail,
                string spouseOccupation , string spouseEmployerNames , string refree1Names , string refree1Occupation , 
                string refree1PhoneNum , string refree1Email , string refree1ContactAddr , string refree2Names ,
                string refree2Occupation , string refree2PhoneNum , string refree2Email , string refree2ContactAddr, 
                string guarrantorNames , string guarrantorFormPath , int applicantID_FK , int employeeUserID_FK,     
                string promotionDate, int promotedBy, string transferDate, int transferedBy, int supervisorID, 
                int hRID,int hODID , int empOfficialPosition, string employeeCadre, int senID_FK,

                string countryName, string stateName, string LgaName, string DeptName, string PositionName, string LevelName,
                string Salary, string LocationName, string LocationAddress, string username, string ConfirmByName,
                string leaveEntitle, string senName, string EmpNames, string promoByName, string TransferByName)
                
            {
                this.EmployeeID = employeeID;
                this.EmployeeNum = employeeNum;
                this.Title = title;
                this.FirstName = firstName;
                this.MiiddleName = miiddleName;
                this.LastName = lastName;
                this.Gender = gender;
                this.DateOfBirth = dateOfBirth;
                this.Age = age;
                this.MaritalStatus = maritalStatus;
                this.Nationality_FK = nationality_FK;
                this.StateOfOrigin_FK = stateOfOrigin_FK;
                this.LGA_FK = lGA_FK;
                this.HomeTown = homeTown;
                this.PhoneNo = phoneNo;
                this.Email = email;
                this.ContactAddress = contactAddress;
                this.Religion = religion;
                this.Passport = passport;
                this.AccountName = accountName;
                this.AccountNo = accountNo;
                this.BankName = bankName;
                this.Department_FK = department_FK;
                this.PositionHeld_FK = positionHeld_FK;
                this.EmployeeLevel_FK = employeeLevel_FK;
                this.WorkLocation_FK = workLocation_FK;
                this.ConfirmationDate = confirmationDate;
                this.ConfirmedBy = confirmedBy;
                this.EmployeeStatus = employeeStatus;
                this.StartDate = startDate;
                this.NxtOfKinFName = nxtOfKinFName;
                this.NxtOfKinMidName = nxtOfKinMidName;
                this.NxtOfKinLName = nxtOfKinLName;
                this.NxtOfKinAddress = nxtOfKinAddress;
                this.NxtOfKinPhoneNo = nxtOfKinPhoneNo;
                this.NxtOfKinEmail = nxtOfKinEmail;
                this.NxtOfKinOccupation = nxtOfKinOccupation;
                this.NxtOfKinRelationship = nxtOfKinRelationship;
                this.SpouseNames = spouseNames;
                this.SpouseAddress = spouseAddress;
                this.SpousePhoneNo = spousePhoneNo;
                this.SpouseEmail = spouseEmail;
                this.SpouseOccupation = spouseOccupation;
                this.SpouseEmployerNames = spouseEmployerNames;
                this.Refree1Names = refree1Names;
                this.Refree1Occupation = refree1Occupation;
                this.Refree1PhoneNum = refree1PhoneNum;
                this.Refree1Email = refree1Email;
                this.Refree1ContactAddr = refree1ContactAddr;
                this.Refree2Names = refree2Names;
                this.Refree2Occupation = refree2Occupation;
                this.Refree2PhoneNum = refree2PhoneNum;
                this.Refree2Email = refree2Email;
                this.Refree2ContactAddr = refree2ContactAddr;
                this.GuarrantorNames = guarrantorNames;
                this.GuarrantorFormPath = guarrantorFormPath;
                this.ApplicantID_FK = applicantID_FK;
                this.EmployeeUserID_FK = employeeUserID_FK;
                this.PromotionDate = PromotionDate;
                this.PromotedBy = promotedBy;
                this.TransferDate = transferDate;
                this.SupervisorID = supervisorID;
                this.HRID = hRID;
                this.HODID = hODID;
                this.EmpOfficialPosition = empOfficialPosition;
                this.EmployeeCadre = employeeCadre;
                this.senID_FK = senID_FK;
               

           this.countryName = countryName;
           this.stateName = stateName;
            this.LgaName = LgaName;
           this.DeptName = DeptName;
           this.PositionName = PositionName;
           this.LevelName = LevelName;
           this.Salary = Salary;
           this.LocationName = LocationName;
           this.LocationAddress = LocationAddress;
           this.Username = Username;
           this.ConfirmByName = ConfirmByName;
           this.LeaveEntitle = leaveEntitle;
           this.senName = senName;
           this.EmpNames = EmpNames;
           this.promoByName = promoByName;
           this.TransferByName = TransferByName;
               
            }
            #endregion

           #region "Public Properties"
            public int EmployeeID
            {
                get { return _employeeID; }
                set { _employeeID = value; }
            }

            public string EmployeeNum
            {
                get { return _employeeNum; }
                set { _employeeNum = value; }
            }

            public string Title
            {
                get { return _title; }
                set { _title = value; }
            }

            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            public string MiiddleName
            {
                get { return _miiddleName; }
                set { _miiddleName = value; }
            }

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }

            public string Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }

            public string DateOfBirth
            {
                get { return _dateOfBirth; }
                set { _dateOfBirth = value; }
            }

            public string Age
            {
                get { return _age; }
                set { _age = value; }
            }

            public string MaritalStatus
            {
                get { return _maritalStatus; }
                set { _maritalStatus = value; }
            }

            public int Nationality_FK
            {
                get { return _nationality_FK; }
                set { _nationality_FK = value; }
            }

            public int StateOfOrigin_FK
            {
                get { return _stateOfOrigin_FK; }
                set { _stateOfOrigin_FK = value; }
            }

            public int LGA_FK
            {
                get { return _lGA_FK; }
                set { _lGA_FK = value; }
            }

            public string HomeTown
            {
                get { return _homeTown; }
                set { _homeTown = value; }
            }

            public string PhoneNo
            {
                get { return _phoneNo; }
                set { _phoneNo = value; }
            }

            public string Email
            {
                get { return _email; }
                set { _email = value; }
            }

            public string ContactAddress
            {
                get { return _contactAddress; }
                set { _contactAddress = value; }
            }

            public string Religion
            {
                get { return _religion; }
                set { _religion = value; }
            }

            public string Passport
            {
                get { return _passport; }
                set { _passport = value; }
            }

            public string AccountName
            {
                get { return _accountName; }
                set { _accountName = value; }
            }

            public string AccountNo
            {
                get { return _accountNo; }
                set { _accountNo = value; }
            }

            public string BankName
            {
                get { return _bankName; }
                set { _bankName = value; }
            }

            public int Department_FK
            {
                get { return _department_FK; }
                set { _department_FK = value; }
            }

            public int PositionHeld_FK
            {
                get { return _positionHeld_FK; }
                set { _positionHeld_FK = value; }
            }

            public int EmployeeLevel_FK
            {
                get { return _employeeLevel_FK; }
                set { _employeeLevel_FK = value; }
            }

            public int WorkLocation_FK
            {
                get { return _workLocation_FK; }
                set { _workLocation_FK = value; }
            }

            public string ConfirmationDate
            {
                get { return _confirmationDate; }
                set { _confirmationDate = value; }
            }

            public int ConfirmedBy
            {
                get { return _confirmedBy; }
                set { _confirmedBy = value; }
            }

            public string EmployeeStatus
            {
                get { return _employeeStatus; }
                set { _employeeStatus = value; }
            }

            public string StartDate
            {
                get { return _startDate; }
                set { _startDate = value; }
            }

            public string NxtOfKinFName
            {
                get { return _nxtOfKinFName; }
                set { _nxtOfKinFName = value; }
            }

            public string NxtOfKinMidName
            {
                get { return _nxtOfKinMidName; }
                set { _nxtOfKinMidName = value; }
            }

            public string NxtOfKinLName
            {
                get { return _nxtOfKinLName; }
                set { _nxtOfKinLName = value; }
            }

            public string NxtOfKinAddress
            {
                get { return _nxtOfKinAddress; }
                set { _nxtOfKinAddress = value; }
            }

            public string NxtOfKinPhoneNo
            {
                get { return _nxtOfKinPhoneNo; }
                set { _nxtOfKinPhoneNo = value; }
            }

            public string NxtOfKinEmail
            {
                get { return _nxtOfKinEmail; }
                set { _nxtOfKinEmail = value; }
            }

            public string NxtOfKinOccupation
            {
                get { return _nxtOfKinOccupation; }
                set { _nxtOfKinOccupation = value; }
            }

            public string NxtOfKinRelationship
            {
                get { return _nxtOfKinRelationship; }
                set { _nxtOfKinRelationship = value; }
            }

            public string SpouseNames
            {
                get { return _spouseNames; }
                set { _spouseNames = value; }
            }

            public string SpouseAddress
            {
                get { return _spouseAddress; }
                set { _spouseAddress = value; }
            }

            public string SpousePhoneNo
            {
                get { return _spousePhoneNo; }
                set { _spousePhoneNo = value; }
            }

            public string SpouseEmail
            {
                get { return _spouseEmail; }
                set { _spouseEmail = value; }
            }
        
            public string SpouseOccupation
            {
                get { return _spouseOccupation; }
                set { _spouseOccupation = value; }
            }

            public string SpouseEmployerNames
            {
                get { return _spouseEmployerNames; }
                set { _spouseEmployerNames = value; }
            }

            public string Refree1Names
            {
                get { return _refree1Names; }
                set { _refree1Names = value; }
            }

            public string Refree1Occupation
            {
                get { return _refree1Occupation; }
                set { _refree1Occupation = value; }
            }

            public string Refree1PhoneNum
            {
                get { return _refree1PhoneNum; }
                set { _refree1PhoneNum = value; }
            }

            public string Refree1Email
            {
                get { return _refree1Email; }
                set { _refree1Email = value; }
            }

            public string Refree1ContactAddr
            {
                get { return _refree1ContactAddr; }
                set { _refree1ContactAddr = value; }
            }

            public string Refree2Names
            {
                get { return _refree2Names; }
                set { _refree2Names = value; }
            }

            public string Refree2Occupation
            {
                get { return _refree2Occupation; }
                set { _refree2Occupation = value; }
            }

            public string Refree2PhoneNum
            {
                get { return _refree2PhoneNum; }
                set { _refree2PhoneNum = value; }
            }

            public string Refree2Email
            {
                get { return _refree2Email; }
                set { _refree2Email = value; }
            }

            public string Refree2ContactAddr
            {
                get { return _refree2ContactAddr; }
                set { _refree2ContactAddr = value; }
            }

            public string GuarrantorNames
            {
                get { return _guarrantorNames; }
                set { _guarrantorNames = value; }
            }

            public string GuarrantorFormPath
            {
                get { return _guarrantorFormPath; }
                set { _guarrantorFormPath = value; }
            }

            public int ApplicantID_FK
            {
                get { return _applicantID_FK; }
                set { _applicantID_FK = value; }
            }

            public int EmployeeUserID_FK
            {
                get { return _employeeUserID_FK; }
                set { _employeeUserID_FK = value; }
            }

            public string PromotionDate
            {
                get { return _promotionDate; }
                set { _promotionDate = value; }
            }
            public int PromotedBy
            {
                get { return _promotedBy; }
                set { _promotedBy = value; }
            }

            public string TransferDate
            {
                get { return _transferDate; }
                set { _transferDate = value; }
            }
            public int TransferedBy
            {
                get { return _transferedBy; }
                set { _transferedBy = value; }
            }
            public int SupervisorID
            {
                get { return _supervisorID; }
                set { _supervisorID = value; }
            }
            public int HRID
            {
                get { return _hRID; }
                set { _hRID = value; }
            }

            public int HODID
            {
                get { return _hODID; }
                set { _hODID = value; }
            }

            public int EmpOfficialPosition
            {
                get { return _empOfficialPosition; }
                set { _empOfficialPosition = value; }
            }
            public string EmployeeCadre
            {
                get { return _employeeCadre; }
                set { _employeeCadre = value; }
            }
            public int senID_FK
            {
                get { return _senID_FK; }
                set { _senID_FK = value; }
            }
            public string countryName
            {
                get { return _countryName; }
                set { _countryName = value; }
            }

            public string stateName
            {
                get { return _stateName; }
                set { _stateName = value; }
            }

            public string LgaName
            {
                get { return _LgaName; }
                set { _LgaName = value; }
            }

            public string DeptName
            {
                get { return _DeptName; }
                set { _DeptName = value; }
            }

            public string PositionName
            {
                get { return _PositionName; }
                set { _PositionName = value; }
            }

            public string LevelName
            {
                get { return _LevelName; }
                set { _LevelName = value; }
            }
            public string Salary
            {
                get { return _Salary; }
                set { _Salary = value; }
            }
            public string LocationName
            {
                get { return _LocationName; }
                set { _LocationName = value; }
            }
            public string LocationAddress
            {
                get { return _LocationAddress; }
                set { _LocationAddress = value; }
            }
        
            public string Username
            {
                get { return _Username; }
                set { _Username = value; }
            }
         public string ConfirmByName
            {
                get { return _ConfirmByName; }
                set { _ConfirmByName = value; }
            }

         public string LeaveEntitle
         {
             get { return _leaveEntitle; }
             set { _leaveEntitle = value; }
         }

         public string senName
         {
             get { return _senName; }
             set { _senName = value; }
         }
         public string EmpNames
         {
             get { return _EmpNames; }
             set { _EmpNames = value; }
         }

         public string promoByName
         {
             get { return _promoByName; }
             set { _promoByName = value; }
         }

         public string TransferByName
         {
             get { return _TransferByName; }
             set { _TransferByName = value; }
         }


        
            #endregion
        }

    //EmployeeDetailsLogInfo

    public class EmployeeDetailsLogInfo
    {
        #region "Private Members"
        int _employeeLogID;
        string _employeeNum;
        string _title;
        string _firstName;
        string _miiddleName;
        string _lastName;
        string _gender;
        string _dateOfBirth;
        string _age;
        string _maritalStatus;
        int _nationality_FK;
        int _stateOfOrigin_FK;
        int _lGA_FK;
        string _homeTown;
        string _phoneNo;
        string _email;
        string _contactAddress;
        string _religion;
        string _passport;
        string _accountName;
        string _accountNo;
        string _bankName;
        int _department_FK;
        int _positionHeld_FK;
        int _employeeLevel_FK;
        int _workLocation_FK;
        string _confirmationDate;
        int _confirmedBy;
        string _employeeStatus;
        string _startDate;
        string _nxtOfKinFName;
        string _nxtOfKinMidName;
        string _nxtOfKinLName;
        string _nxtOfKinAddress;
        string _nxtOfKinPhoneNo;
        string _nxtOfKinEmail;
        string _nxtOfKinOccupation;
        string _nxtOfKinRelationship;
        string _spouseNames;
        string _spouseAddress;
        string _spousePhoneNo;
        string _spouseEmail;
        string _spouseOccupation;
        string _spouseEmployerNames;
        string _refree1Names;
        string _refree1Occupation;
        string _refree1PhoneNum;
        string _refree1Email;
        string _refree1ContactAddr;
        string _refree2Names;
        string _refree2Occupation;
        string _refree2PhoneNum;
        string _refree2Email;
        string _refree2ContactAddr;
        string _guarrantorNames;
        string _guarrantorFormPath;
        int _applicantID_FK;
        int _employeeUserID_FK;
        string _promotionDate;
        int _promotedBy;
        string _transferDate;
        int _transferedBy;
        int _supervisorID;
        int _hRID;
        int _hODID;
        int _empOfficialPosition;
        int _employeeID_FK;
        int _senID_FK;


        string _countryName;
        string _stateName;
        string _LgaName;
        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _LocationAddress;
        string _Username;
        string _confirmedByName;
        string _leaveEntitle;
        string _employeeCadre;
        string _senName;

        #endregion

        #region "Constructors"
        public EmployeeDetailsLogInfo()
        {
        }

        public EmployeeDetailsLogInfo(int employeeLogID, string employeeNum, string title, string firstName, string miiddleName,
            string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK,
            int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress,
            string religion, string passport, string accountName, string accountNo, string bankName, int department_FK,
            int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy,
            string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName,
            string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation,
            string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail,
            string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation,
            string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names,
            string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr,
            string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK,
            string promotionDate, int promotedBy, string transferDate, int transferedBy, int supervisorID,
            int hRID, int hODID, int empOfficialPosition, int employeeID_FK,int senID_FK ,

            string countryName, string stateName, string LgaName, string DeptName, string PositionName, string LevelName,
            string Salary, string LocationName, string LocationAddress, string username, string confirmedByName,
            string leaveEntitle, string employeeCadre, string senName)
        {
            this.EmployeeLogID = employeeLogID;
            this.EmployeeNum = employeeNum;
            this.Title = title;
            this.FirstName = firstName;
            this.MiiddleName = miiddleName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.MaritalStatus = maritalStatus;
            this.Nationality_FK = nationality_FK;
            this.StateOfOrigin_FK = stateOfOrigin_FK;
            this.LGA_FK = lGA_FK;
            this.HomeTown = homeTown;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.ContactAddress = contactAddress;
            this.Religion = religion;
            this.Passport = passport;
            this.AccountName = accountName;
            this.AccountNo = accountNo;
            this.BankName = bankName;
            this.Department_FK = department_FK;
            this.PositionHeld_FK = positionHeld_FK;
            this.EmployeeLevel_FK = employeeLevel_FK;
            this.WorkLocation_FK = workLocation_FK;
            this.ConfirmationDate = confirmationDate;
            this.ConfirmedBy = confirmedBy;
            this.EmployeeStatus = employeeStatus;
            this.StartDate = startDate;
            this.NxtOfKinFName = nxtOfKinFName;
            this.NxtOfKinMidName = nxtOfKinMidName;
            this.NxtOfKinLName = nxtOfKinLName;
            this.NxtOfKinAddress = nxtOfKinAddress;
            this.NxtOfKinPhoneNo = nxtOfKinPhoneNo;
            this.NxtOfKinEmail = nxtOfKinEmail;
            this.NxtOfKinOccupation = nxtOfKinOccupation;
            this.NxtOfKinRelationship = nxtOfKinRelationship;
            this.SpouseNames = spouseNames;
            this.SpouseAddress = spouseAddress;
            this.SpousePhoneNo = spousePhoneNo;
            this.SpouseEmail = spouseEmail;
            this.SpouseOccupation = spouseOccupation;
            this.SpouseEmployerNames = spouseEmployerNames;
            this.Refree1Names = refree1Names;
            this.Refree1Occupation = refree1Occupation;
            this.Refree1PhoneNum = refree1PhoneNum;
            this.Refree1Email = refree1Email;
            this.Refree1ContactAddr = refree1ContactAddr;
            this.Refree2Names = refree2Names;
            this.Refree2Occupation = refree2Occupation;
            this.Refree2PhoneNum = refree2PhoneNum;
            this.Refree2Email = refree2Email;
            this.Refree2ContactAddr = refree2ContactAddr;
            this.GuarrantorNames = guarrantorNames;
            this.GuarrantorFormPath = guarrantorFormPath;
            this.ApplicantID_FK = applicantID_FK;
            this.EmployeeUserID_FK = employeeUserID_FK;
            this.PromotionDate = PromotionDate;
            this.PromotedBy = promotedBy;
            this.TransferDate = transferDate;
            this.SupervisorID = supervisorID;
            this.HRID = hRID;
            this.HODID = hODID;
            this.EmpOfficialPosition = empOfficialPosition;
            this.EmployeeID_FK = employeeID_FK;
            this.senID_FK = senID_FK;

            this.countryName = countryName;
            this.stateName = stateName;
            this.LgaName = LgaName;
            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.LocationAddress = _LocationAddress;
            this.Username = Username;
            this.ConfirmedByName = ConfirmedByName;
            this.LeaveEntitle = leaveEntitle;
            this.EmployeeCadre = employeeCadre;
            this.senName = senName;

        }
        #endregion

        #region "Public Properties"
        public int EmployeeLogID
        {
            get { return _employeeLogID; }
            set { _employeeLogID = value; }
        }

        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiiddleName
        {
            get { return _miiddleName; }
            set { _miiddleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        public int Nationality_FK
        {
            get { return _nationality_FK; }
            set { _nationality_FK = value; }
        }

        public int StateOfOrigin_FK
        {
            get { return _stateOfOrigin_FK; }
            set { _stateOfOrigin_FK = value; }
        }

        public int LGA_FK
        {
            get { return _lGA_FK; }
            set { _lGA_FK = value; }
        }

        public string HomeTown
        {
            get { return _homeTown; }
            set { _homeTown = value; }
        }

        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string ContactAddress
        {
            get { return _contactAddress; }
            set { _contactAddress = value; }
        }

        public string Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }

        public string Passport
        {
            get { return _passport; }
            set { _passport = value; }
        }

        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        public string AccountNo
        {
            get { return _accountNo; }
            set { _accountNo = value; }
        }

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        public int Department_FK
        {
            get { return _department_FK; }
            set { _department_FK = value; }
        }

        public int PositionHeld_FK
        {
            get { return _positionHeld_FK; }
            set { _positionHeld_FK = value; }
        }

        public int EmployeeLevel_FK
        {
            get { return _employeeLevel_FK; }
            set { _employeeLevel_FK = value; }
        }

        public int WorkLocation_FK
        {
            get { return _workLocation_FK; }
            set { _workLocation_FK = value; }
        }

        public string ConfirmationDate
        {
            get { return _confirmationDate; }
            set { _confirmationDate = value; }
        }

        public int ConfirmedBy
        {
            get { return _confirmedBy; }
            set { _confirmedBy = value; }
        }

        public string EmployeeStatus
        {
            get { return _employeeStatus; }
            set { _employeeStatus = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string NxtOfKinFName
        {
            get { return _nxtOfKinFName; }
            set { _nxtOfKinFName = value; }
        }

        public string NxtOfKinMidName
        {
            get { return _nxtOfKinMidName; }
            set { _nxtOfKinMidName = value; }
        }

        public string NxtOfKinLName
        {
            get { return _nxtOfKinLName; }
            set { _nxtOfKinLName = value; }
        }

        public string NxtOfKinAddress
        {
            get { return _nxtOfKinAddress; }
            set { _nxtOfKinAddress = value; }
        }

        public string NxtOfKinPhoneNo
        {
            get { return _nxtOfKinPhoneNo; }
            set { _nxtOfKinPhoneNo = value; }
        }

        public string NxtOfKinEmail
        {
            get { return _nxtOfKinEmail; }
            set { _nxtOfKinEmail = value; }
        }

        public string NxtOfKinOccupation
        {
            get { return _nxtOfKinOccupation; }
            set { _nxtOfKinOccupation = value; }
        }

        public string NxtOfKinRelationship
        {
            get { return _nxtOfKinRelationship; }
            set { _nxtOfKinRelationship = value; }
        }

        public string SpouseNames
        {
            get { return _spouseNames; }
            set { _spouseNames = value; }
        }

        public string SpouseAddress
        {
            get { return _spouseAddress; }
            set { _spouseAddress = value; }
        }

        public string SpousePhoneNo
        {
            get { return _spousePhoneNo; }
            set { _spousePhoneNo = value; }
        }

        public string SpouseEmail
        {
            get { return _spouseEmail; }
            set { _spouseEmail = value; }
        }

        public string SpouseOccupation
        {
            get { return _spouseOccupation; }
            set { _spouseOccupation = value; }
        }

        public string SpouseEmployerNames
        {
            get { return _spouseEmployerNames; }
            set { _spouseEmployerNames = value; }
        }

        public string Refree1Names
        {
            get { return _refree1Names; }
            set { _refree1Names = value; }
        }

        public string Refree1Occupation
        {
            get { return _refree1Occupation; }
            set { _refree1Occupation = value; }
        }

        public string Refree1PhoneNum
        {
            get { return _refree1PhoneNum; }
            set { _refree1PhoneNum = value; }
        }

        public string Refree1Email
        {
            get { return _refree1Email; }
            set { _refree1Email = value; }
        }

        public string Refree1ContactAddr
        {
            get { return _refree1ContactAddr; }
            set { _refree1ContactAddr = value; }
        }

        public string Refree2Names
        {
            get { return _refree2Names; }
            set { _refree2Names = value; }
        }

        public string Refree2Occupation
        {
            get { return _refree2Occupation; }
            set { _refree2Occupation = value; }
        }

        public string Refree2PhoneNum
        {
            get { return _refree2PhoneNum; }
            set { _refree2PhoneNum = value; }
        }

        public string Refree2Email
        {
            get { return _refree2Email; }
            set { _refree2Email = value; }
        }

        public string Refree2ContactAddr
        {
            get { return _refree2ContactAddr; }
            set { _refree2ContactAddr = value; }
        }

        public string GuarrantorNames
        {
            get { return _guarrantorNames; }
            set { _guarrantorNames = value; }
        }

        public string GuarrantorFormPath
        {
            get { return _guarrantorFormPath; }
            set { _guarrantorFormPath = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }

        public int EmployeeUserID_FK
        {
            get { return _employeeUserID_FK; }
            set { _employeeUserID_FK = value; }
        }

        public string PromotionDate
        {
            get { return _promotionDate; }
            set { _promotionDate = value; }
        }
        public int PromotedBy
        {
            get { return _promotedBy; }
            set { _promotedBy = value; }
        }

        public string TransferDate
        {
            get { return _transferDate; }
            set { _transferDate = value; }
        }
        public int TransferedBy
        {
            get { return _transferedBy; }
            set { _transferedBy = value; }
        }
        public int SupervisorID
        {
            get { return _supervisorID; }
            set { _supervisorID = value; }
        }
        public int HRID
        {
            get { return _hRID; }
            set { _hRID = value; }
        }

        public int HODID
        {
            get { return _hODID; }
            set { _hODID = value; }
        }

        public int EmpOfficialPosition
        {
            get { return _empOfficialPosition; }
            set { _empOfficialPosition = value; }
        }
    
        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }
        public int senID_FK
        {
            get { return _senID_FK; }
            set { _senID_FK = value; }
        }
        public string countryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        public string stateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        public string LgaName
        {
            get { return _LgaName; }
            set { _LgaName = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
        public string LocationAddress
        {
            get { return _LocationAddress; }
            set { _LocationAddress = value; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string ConfirmedByName
        {
            get { return _confirmedByName; }
            set { _confirmedByName = value; }
        }

        public string LeaveEntitle
        {
            get { return _leaveEntitle; }
            set { _leaveEntitle = value; }
        }
        public string EmployeeCadre
        {
            get { return _employeeCadre; }
            set { _employeeCadre = value; }
        }
        public string senName
        {
            get { return _senName; }
            set { _senName = value; }
        }
        
        #endregion
    }


    //EmployeeQualificationTableInfo

    public class EmployeeQualificationTableInfo
    {
        #region "Private Members"
        int _qualificationID;
        string _institutionName;
        string _qualificationType;
        string _course;
        string _grade;
        string _startYear;
        string _endYear;
        int _applicantID_FK;
        int _employeeID_FK;
        string _hrApproval;
        int _employeeLogID_FK;
        string _employeeNum;

        #endregion

        #region "Constructors"
        public EmployeeQualificationTableInfo()
        {
        }

        public EmployeeQualificationTableInfo(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK, string hrApproval, int employeeLogID_FK, string employeeNum)
        {
            this.QualificationID = qualificationID;
            this.InstitutionName = institutionName;
            this.QualificationType = qualificationType;
            this.Course = course;
            this.Grade = grade;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.ApplicantID_FK = applicantID_FK;
            this.EmployeeID_FK = employeeID_FK;
            this.HrApproval = hrApproval;
            this.EmployeeLogID_FK = employeeLogID_FK;
            this.EmployeeNum = employeeNum;
        }
        #endregion

        #region "Public Properties"
        public int QualificationID
        {
            get { return _qualificationID; }
            set { _qualificationID = value; }
        }

        public string InstitutionName
        {
            get { return _institutionName; }
            set { _institutionName = value; }
        }

        public string QualificationType
        {
            get { return _qualificationType; }
            set { _qualificationType = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string StartYear
        {
            get { return _startYear; }
            set { _startYear = value; }
        }

        public string EndYear
        {
            get { return _endYear; }
            set { _endYear = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public string HrApproval
        {
            get { return _hrApproval; }
            set { _hrApproval = value; }
        }
        public int EmployeeLogID_FK
        {
            get { return _employeeLogID_FK; }
            set { _employeeLogID_FK = value; }
        }
        
         public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }
        #endregion
    }

    //EmployeeProfQualificationTableInfo
    
	public class EmployeeProfQualificationTableInfo
	{
		#region "Private Members"
		int _profQualificationID;
		string _certificationName;
		string _certificateNo;
		string _stage;
		string _certYear;
		int _applicantID_FK;
		int _employeeID_FK;
        string _hrApproval;
        int _employeeLogID_FK;
		#endregion
		
		#region "Constructors"
        public EmployeeProfQualificationTableInfo()
        {
		}

        public EmployeeProfQualificationTableInfo(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK, string hrApproval, int employeeLogID_FK)
		{
            this.ProfQualificationID = profQualificationID;
            this.CertificationName = certificationName;
            this.CertificateNo = certificateNo;
            this.Stage = stage;
            this.CertYear = certYear;
            this.ApplicantID_FK = applicantID_FK;
            this.employeeID_FK = employeeID_FK;
            this._hrApproval = hrApproval;
            this.EmployeeLogID_FK = employeeLogID_FK;
        }
		#endregion
		
		#region "Public Properties"
		public int ProfQualificationID
		{
			get{return _profQualificationID;}
			set{_profQualificationID = value;}
		}
		
		public string CertificationName
		{
			get{return _certificationName;}
			set{_certificationName = value;}
		}

		public string CertificateNo
		{
			get{return _certificateNo;}
			set{_certificateNo = value;}
		}

		public string Stage
		{
			get{return _stage;}
			set{_stage = value;}
		}

		public string CertYear
		{
			get{return _certYear;}
			set{_certYear = value;}
		}

		public int ApplicantID_FK
		{
			get{return _applicantID_FK;}
			set{_applicantID_FK = value;}
		}

		public int employeeID_FK
		{
			get{return _employeeID_FK;}
			set{_employeeID_FK = value;}
		}
        public string HrApproval
        {
            get { return _hrApproval; }
            set { _hrApproval = value; }
        }
        public int EmployeeLogID_FK
        {
            get { return _employeeLogID_FK; }
            set { _employeeLogID_FK = value; }
        }

		#endregion
	}
    


    //EmployeeDocumentTableInfo
    public class EmployeeDocumentTableInfo
    {
        #region "Private Members"
        int _documentID;
        string _documentType;
        string _documentPath;
        int _applicantID_FK;
        int _employeeID_Fk;
        string _hrApproval;
        int _employeeLogID_FK;
        #endregion

        #region "Constructors"
        public EmployeeDocumentTableInfo()
        {
        }

        public EmployeeDocumentTableInfo(int documentID, string documentType, string documentPath, int applicantID_FK, int employeeID_Fk, string hrApproval, int employeeLogID_FK)
        {
            this.DocumentID = documentID;
            this.DocumentType = documentType;
            this.DocumentPath = documentPath;
            this.ApplicantID_FK = applicantID_FK;
            this.EmployeeID_Fk = employeeID_Fk;
            this._hrApproval = hrApproval;
            this.EmployeeLogID_FK = employeeLogID_FK;
        }
        #endregion

        #region "Public Properties"
        public int DocumentID
        {
            get { return _documentID; }
            set { _documentID = value; }
        }

        public string DocumentType
        {
            get { return _documentType; }
            set { _documentType = value; }
        }

        public string DocumentPath
        {
            get { return _documentPath; }
            set { _documentPath = value; }
        }

        public int ApplicantID_FK
        {
            get { return _applicantID_FK; }
            set { _applicantID_FK = value; }
        }

        public int EmployeeID_Fk
        {
            get { return _employeeID_Fk; }
            set { _employeeID_Fk = value; }
        }
        public string HrApproval
        {
            get { return _hrApproval; }
            set { _hrApproval = value; }
        }
        public int EmployeeLogID_FK
        {
            get { return _employeeLogID_FK; }
            set { _employeeLogID_FK = value; }
        }
        #endregion
    }

    public class EmployeeTrainingTableInfo
    {
        #region "Private Members"
        int _trainingID;
        string _trainingName;
        string _trainingLocation;
        string _startDate;
        string _endDate;
        int _departmentID_FK;
        int _positionID_FK;
        int _employeeID_FK;
        int _trainingSentBy;
        string _trainingStatus;
        int _trainingApprovedBy;
        string _employeeNum;
        string _deptName;
        string _positionName;
        string _hODName;
        string _hRName;
        string _email;
        string _phoneNo;

        #endregion

        #region "Constructors"
        public EmployeeTrainingTableInfo()
        {
        }

        public EmployeeTrainingTableInfo(int trainingID, string trainingName, string trainingLocation, string startDate, string endDate, int departmentID_FK, int positionID_FK, int employeeID_FK, int trainingSentBy, string trainingStatus, int trainingApprovedBy, string employeeNum, string deptName, string positionName, string hODName, string hRName, string email, string phoneNo)
        {
            this.TrainingID = trainingID;
            this.TrainingName = trainingName;
            this.TrainingLocation = trainingLocation;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.DepartmentID_FK = departmentID_FK;
            this.PositionID_FK = positionID_FK;
            this.EmployeeID_FK = employeeID_FK;
            this.TrainingSentBy = trainingSentBy;
            this.TrainingStatus = trainingStatus;
            this.TrainingApprovedBy = trainingApprovedBy;
            this.EmployeeNum = employeeNum;
            this.DeptName = deptName;
            this.PositionName = positionName;
            this.HODName = hODName;
            this.HRName = hRName;
            this.Email = email;
            this.PhoneNo = phoneNo;
        }
        #endregion

        #region "Public Properties"
        public int TrainingID
        {
            get { return _trainingID; }
            set { _trainingID = value; }
        }

        public string TrainingName
        {
            get { return _trainingName; }
            set { _trainingName = value; }
        }

        public string TrainingLocation
        {
            get { return _trainingLocation; }
            set { _trainingLocation = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public int DepartmentID_FK
        {
            get { return _departmentID_FK; }
            set { _departmentID_FK = value; }
        }

        public int PositionID_FK
        {
            get { return _positionID_FK; }
            set { _positionID_FK = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int TrainingSentBy
        {
            get { return _trainingSentBy; }
            set { _trainingSentBy = value; }
        }

        public string TrainingStatus
        {
            get { return _trainingStatus; }
            set { _trainingStatus = value; }
        }

        public int TrainingApprovedBy
        {
            get { return _trainingApprovedBy; }
            set { _trainingApprovedBy = value; }
        }

        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }

        public string PositionName
        {
            get { return _positionName; }
            set { _positionName = value; }
        }

        public string HODName
        {
            get { return _hODName; }
            set { _hODName = value; }
        }

        public string HRName
        {
            get { return _hRName; }
            set { _hRName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        #endregion
    }

    //EmployeeTransferTableInfo
    public class EmployeeTransferTableInfo
    {
        #region "Private Members"
        int _transferID;
        int _previousDept;
        int _newDept;
        int _prevWorkLocation;
        int _desireLocation;
        int _newWorkLcation;
        string _transferType;
        string _transferReason;
        string _requestDate;
        string _approvalStatus;
        string _approveDate;
        string _transferDate;
        int _employeeID_FK;
        int _transferedBy;
      

        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _employeeNum;
        string _displayName;
        int _transferID_FK;
        int _transferLogID;
        string _PreDept;
        string _NewDeptName;
        string _CurrentLocation;
        string _DesLocation;
        #endregion

        #region "Constructors"
        public EmployeeTransferTableInfo()
        {
        }


        public EmployeeTransferTableInfo(int transferID, int previousDept, int newDept, int prevWorkLocation, int desireLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, 
            string approveDate, string transferDate, int employeeID_FK, int transferedBy,string DeptName, string PositionName, string LevelName, string Salary, string LocationName, string employeeNum, string displayName, int transferID_FK,
            int transferLogID, string preDept, string NewDeptName, string CurrentLocation, string DesLocation)
		{

            this.TransferID = transferID;
            this.PreviousDept = previousDept;
            this.NewDept = newDept;
            this.PrevWorkLocation = prevWorkLocation;
            this.DesireLocation = desireLocation;
            this.NewWorkLcation = newWorkLcation;
            this.TransferType = transferType;
            this.TransferReason = transferReason;
            this.RequestDate = requestDate;
            this.ApprovalStatus = approvalStatus;
            this.ApproveDate = approveDate;
            this.TransferDate = transferDate;
            this.EmployeeID_FK = employeeID_FK;
            this.TransferedBy = transferedBy;

            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.EmployeeNum = employeeNum;
            this.DeptName = displayName;
            this.TransferID_FK = transferID_FK;
            this.TransferLogID = transferLogID;
            this.PreDept = preDept;
            this.NewDeptName = NewDeptName;
            this.CurrentLocation = CurrentLocation;
            this.DesLocation = DesLocation;
        }
        #endregion

        #region "Public Properties"
        public int TransferID
        {
            get { return _transferID; }
            set { _transferID = value; }
        }

        public int PreviousDept
        {
            get { return _previousDept; }
            set { _previousDept = value; }
        }

      
        public int NewDept
        {
            get { return _newDept; }
            set { _newDept = value; }
        }

        public int PrevWorkLocation
        {
            get { return _prevWorkLocation; }
            set { _prevWorkLocation = value; }
        }

        public int DesireLocation
        {
            get { return _desireLocation; }
            set { _desireLocation = value; }
        }
        public int NewWorkLcation
        {
            get { return _newWorkLcation; }
            set { _newWorkLcation = value; }
        }

        public string TransferType
        {
            get { return _transferType; }
            set { _transferType = value; }
        }

        public string TransferReason
        {
            get { return _transferReason; }
            set { _transferReason = value; }
        }

        public string RequestDate
        {
            get { return _requestDate; }
            set { _requestDate = value; }
        }

        public string ApprovalStatus
        {
            get { return _approvalStatus; }
            set { _approvalStatus = value; }
        }

        public string ApproveDate
        {
            get { return _approveDate; }
            set { _approveDate = value; }
        }

        public string TransferDate
        {
            get { return _transferDate; }
            set { _transferDate = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int TransferedBy
        {
            get { return _transferedBy; }
            set { _transferedBy = value; }
        }
        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }
        public int TransferID_FK
        {
            get { return _transferID_FK; }
            set { _transferID_FK = value; }
        }
        public int TransferLogID
        {
            get { return _transferLogID; }
            set { _transferLogID = value; }
        }
        public string PreDept
        {
            get { return _PreDept; }
            set { _PreDept = value; }
        }
        public string NewDeptName
        {
            get { return _NewDeptName; }
            set { _NewDeptName = value; }
        }
      
        public string CurrentLocation
        {
            get { return _CurrentLocation; }
            set { _CurrentLocation = value; }
        }
        public string DesLocation
        {
            get { return _DesLocation; }
            set { _DesLocation = value; }
        }
        
        #endregion
      
    }

    //EmployeeTransferTableLogInfo
    public class EmployeeTransferTableLogInfo
    {
        #region "Private Members"
        int _transferLogID;
        int _previousDept;
        int _newDept;
        int _prevWorkLocation;
        int _desireLocation;
        int _newWorkLcation;
        string _transferType;
        string _transferReason;
        string _requestDate;
        string _approvalStatus;
        string _approveDate;
        string _transferDate;
        int _employeeID_FK;
        int _transferedBy;
        int _transferID_FK;

        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _PreDept;
        string _NewDeptName;
        string _CurrentLocation;
        string _DesLocation;
        string _EmployeeNum;
        string _ApprovedLocation;
        string _DisplayName;
        #endregion

        #region "Constructors"
        public EmployeeTransferTableLogInfo()
        {
        }

        public EmployeeTransferTableLogInfo(int transferLogID, int previousDept , int newDept ,  int prevWorkLocation ,int desireLocation, int newWorkLcation ,
            string transferType , string transferReason , string requestDate , string approvalStatus , string approveDate , string transferDate , int employeeID_FK ,
            int transferedBy , int transferID_FK, string DeptName, string PositionName, string LevelName, string Salary, string LocationName, string preDept,
            string NewDeptName, string CurrentLocation, string DesLocation, string EmployeeNum, string ApprovedLocation, string DisplayName)
		
        {
            this.TransferLogID = transferLogID;
            this.PreviousDept = previousDept;
            this.NewDept = newDept;
            this.PrevWorkLocation = prevWorkLocation;
            this.DesireLocation = desireLocation;
            this.NewWorkLcation = newWorkLcation;
            this.TransferType = transferType;
            this.TransferReason = transferReason;
            this.RequestDate = requestDate;
            this.ApprovalStatus = approvalStatus;
            this.ApproveDate = approveDate;
            this.TransferDate = transferDate;
            this.EmployeeID_FK = employeeID_FK;
            this.TransferedBy = transferedBy;
            this.TransferID_FK = transferID_FK;

            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.PreDept = preDept;
            this.NewDeptName = NewDeptName;
            this.CurrentLocation = CurrentLocation;
            this.DesLocation = DesLocation;
            this.EmployeeNum = EmployeeNum;
            this.ApprovedLocation = ApprovedLocation;
            this.DeptName = DisplayName;
        }
        #endregion

        #region "Public Properties"
        public int TransferLogID
        {
            get { return _transferLogID; }
            set { _transferLogID = value; }
        }

        public int PreviousDept
        {
            get { return _previousDept; }
            set { _previousDept = value; }
        }

        public int NewDept
        {
            get { return _newDept; }
            set { _newDept = value; }
        }

        public int DesireLocation
        {
            get { return _desireLocation; }
            set { _desireLocation = value; }
        }
        public int PrevWorkLocation
        {
            get { return _prevWorkLocation; }
            set { _prevWorkLocation = value; }
        }

        public int NewWorkLcation
        {
            get { return _newWorkLcation; }
            set { _newWorkLcation = value; }
        }

        public string TransferType
        {
            get { return _transferType; }
            set { _transferType = value; }
        }

        public string TransferReason
        {
            get { return _transferReason; }
            set { _transferReason = value; }
        }

        public string RequestDate
        {
            get { return _requestDate; }
            set { _requestDate = value; }
        }

        public string ApprovalStatus
        {
            get { return _approvalStatus; }
            set { _approvalStatus = value; }
        }

        public string ApproveDate
        {
            get { return _approveDate; }
            set { _approveDate = value; }
        }

        public string TransferDate
        {
            get { return _transferDate; }
            set { _transferDate = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int TransferedBy
        {
            get { return _transferedBy; }
            set { _transferedBy = value; }
        }

        public int TransferID_FK
        {
            get { return _transferID_FK; }
            set { _transferID_FK = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
        public string PreDept
        {
            get { return _PreDept; }
            set { _PreDept = value; }
        }
        public string NewDeptName
        {
            get { return _NewDeptName; }
            set { _NewDeptName = value; }
        }

        public string CurrentLocation
        {
            get { return _CurrentLocation; }
            set { _CurrentLocation = value; }
        }
        public string DesLocation
        {
            get { return _DesLocation; }
            set { _DesLocation = value; }
        }

        public string EmployeeNum
        {
            get { return _EmployeeNum; }
            set { _EmployeeNum = value; }
        }
        public string ApprovedLocation
        {
            get { return _ApprovedLocation; }
            set { _ApprovedLocation = value; }
        }
        public string DisplayName
        {
            get { return _DisplayName; }
            set { _DisplayName = value; }
        }
        
        
        #endregion
    }


    //Appraisal Module

    #region


    //EmployeeAppraisalTableRatingKeyInfo
    public class EmployeeAppraisalTableRatingKeyInfo
    {
        #region "Private Members"
        int _ratingKeyID;
        string _ratingDesc;
        int _ratingPoint;
        #endregion

        #region "Constructors"
        public EmployeeAppraisalTableRatingKeyInfo()
        {
        }

        public EmployeeAppraisalTableRatingKeyInfo(int ratingKeyID, string ratingDesc, int ratingPoint)
        {
            this.RatingKeyID = ratingKeyID;
            this.RatingDesc = ratingDesc;
            this.RatingPoint = ratingPoint;
        }
        #endregion

        #region "Public Properties"
        public int RatingKeyID
        {
            get { return _ratingKeyID; }
            set { _ratingKeyID = value; }
        }

        public string RatingDesc
        {
            get { return _ratingDesc; }
            set { _ratingDesc = value; }
        }

        public int RatingPoint
        {
            get { return _ratingPoint; }
            set { _ratingPoint = value; }
        }
        #endregion
    }

    //EmployeeAppraisalCompetencyTableInfo

    public class EmployeeAppraisalCompetencyTableInfo
    {
        #region "Private Members"
        int _competencyID;
        int _quality;
        int _quaPoint;
        int _productivity;
        int _prodPoint;
        int _knoweldge;
        int _knowPoint;
        int _dependability;
        int _dependPoint;
        int _initiative;
        int _initPoint;
        int _judgement;
        int _judPoint;
        int _adaptability;
        int _adaPoint;
        int _interterpersonalRelationship;
        int _interPoint;
        int _puntuality;
        int _puntPoint;
        int _communicationSkills;
        int _comPoint;
        int _planning;
        int _planPoint;
        int _leadership;
        int _leadPoint;
        int _team;
        int _teamPoint;
        int _development;
        int _devPoint;
        int _overallPoint;
        string _excelArea;
        string _areaThatNeedsImprovement;
        string _stepsToTake;
        string _areaThatNeedsAssistance;
        int _employeeID_FK;
        int _supervisorID_FK;
        int _hRID_FK;
        int _appraisalID_FK;
        #endregion

        #region "Constructors"
        public EmployeeAppraisalCompetencyTableInfo()
        {
        }

        public EmployeeAppraisalCompetencyTableInfo(int competencyID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int puntPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK)
        {
            this.CompetencyID = competencyID;
            this.Quality = quality;
            this.QuaPoint = quaPoint;
            this.Productivity = productivity;
            this.ProdPoint = prodPoint;
            this.Knoweldge = knoweldge;
            this.KnowPoint = knowPoint;
            this.Dependability = dependability;
            this.DependPoint = dependPoint;
            this.Initiative = initiative;
            this.InitPoint = initPoint;
            this.Judgement = judgement;
            this.JudPoint = judPoint;
            this.Adaptability = adaptability;
            this.AdaPoint = adaPoint;
            this.InterterpersonalRelationship = interterpersonalRelationship;
            this.InterPoint = interPoint;
            this.Puntuality = puntuality;
            this.PuntPoint = puntPoint;
            this.CommunicationSkills = communicationSkills;
            this.ComPoint = comPoint;
            this.Planning = planning;
            this.PlanPoint = planPoint;
            this.Leadership = leadership;
            this.LeadPoint = leadPoint;
            this.Team = team;
            this.TeamPoint = teamPoint;
            this.Development = development;
            this.DevPoint = devPoint;
            this.OverallPoint = overallPoint;
            this.ExcelArea = excelArea;
            this.AreaThatNeedsImprovement = areaThatNeedsImprovement;
            this.StepsToTake = stepsToTake;
            this.AreaThatNeedsAssistance = areaThatNeedsAssistance;
            this.EmployeeID_FK = employeeID_FK;
            this.SupervisorID_FK = supervisorID_FK;
            this.HRID_FK = hRID_FK;
            this.AppraisalID_FK = appraisalID_FK;
        }
        #endregion

        #region "Public Properties"
        public int CompetencyID
        {
            get { return _competencyID; }
            set { _competencyID = value; }
        }

        public int Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public int QuaPoint
        {
            get { return _quaPoint; }
            set { _quaPoint = value; }
        }

        public int Productivity
        {
            get { return _productivity; }
            set { _productivity = value; }
        }

        public int ProdPoint
        {
            get { return _prodPoint; }
            set { _prodPoint = value; }
        }

        public int Knoweldge
        {
            get { return _knoweldge; }
            set { _knoweldge = value; }
        }

        public int KnowPoint
        {
            get { return _knowPoint; }
            set { _knowPoint = value; }
        }

        public int Dependability
        {
            get { return _dependability; }
            set { _dependability = value; }
        }

        public int DependPoint
        {
            get { return _dependPoint; }
            set { _dependPoint = value; }
        }

        public int Initiative
        {
            get { return _initiative; }
            set { _initiative = value; }
        }

        public int InitPoint
        {
            get { return _initPoint; }
            set { _initPoint = value; }
        }

        public int Judgement
        {
            get { return _judgement; }
            set { _judgement = value; }
        }

        public int JudPoint
        {
            get { return _judPoint; }
            set { _judPoint = value; }
        }

        public int Adaptability
        {
            get { return _adaptability; }
            set { _adaptability = value; }
        }

        public int AdaPoint
        {
            get { return _adaPoint; }
            set { _adaPoint = value; }
        }

        public int InterterpersonalRelationship
        {
            get { return _interterpersonalRelationship; }
            set { _interterpersonalRelationship = value; }
        }

        public int InterPoint
        {
            get { return _interPoint; }
            set { _interPoint = value; }
        }

        public int Puntuality
        {
            get { return _puntuality; }
            set { _puntuality = value; }
        }

        public int PuntPoint
        {
            get { return _puntPoint; }
            set { _puntPoint = value; }
        }

        public int CommunicationSkills
        {
            get { return _communicationSkills; }
            set { _communicationSkills = value; }
        }

        public int ComPoint
        {
            get { return _comPoint; }
            set { _comPoint = value; }
        }

        public int Planning
        {
            get { return _planning; }
            set { _planning = value; }
        }

        public int PlanPoint
        {
            get { return _planPoint; }
            set { _planPoint = value; }
        }

        public int Leadership
        {
            get { return _leadership; }
            set { _leadership = value; }
        }

        public int LeadPoint
        {
            get { return _leadPoint; }
            set { _leadPoint = value; }
        }

        public int Team
        {
            get { return _team; }
            set { _team = value; }
        }

        public int TeamPoint
        {
            get { return _teamPoint; }
            set { _teamPoint = value; }
        }

        public int Development
        {
            get { return _development; }
            set { _development = value; }
        }

        public int DevPoint
        {
            get { return _devPoint; }
            set { _devPoint = value; }
        }

        public int OverallPoint
        {
            get { return _overallPoint; }
            set { _overallPoint = value; }
        }

        public string ExcelArea
        {
            get { return _excelArea; }
            set { _excelArea = value; }
        }

        public string AreaThatNeedsImprovement
        {
            get { return _areaThatNeedsImprovement; }
            set { _areaThatNeedsImprovement = value; }
        }

        public string StepsToTake
        {
            get { return _stepsToTake; }
            set { _stepsToTake = value; }
        }

        public string AreaThatNeedsAssistance
        {
            get { return _areaThatNeedsAssistance; }
            set { _areaThatNeedsAssistance = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int SupervisorID_FK
        {
            get { return _supervisorID_FK; }
            set { _supervisorID_FK = value; }
        }

        public int HRID_FK
        {
            get { return _hRID_FK; }
            set { _hRID_FK = value; }
        }

        public int AppraisalID_FK
        {
            get { return _appraisalID_FK; }
            set { _appraisalID_FK = value; }
        }
        #endregion
    }
  
    public class EmployeeAppraisalCompetencyTableLogInfo
    {
        #region "Private Members"
        int _competencyLogID;
        int _quality;
        int _quaPoint;
        int _productivity;
        int _prodPoint;
        int _knoweldge;
        int _knowPoint;
        int _dependability;
        int _dependPoint;
        int _initiative;
        int _initPoint;
        int _judgement;
        int _judPoint;
        int _adaptability;
        int _adaPoint;
        int _interterpersonalRelationship;
        int _interPoint;
        int _puntuality;
        int _punPoint;
        int _communicationSkills;
        int _comPoint;
        int _planning;
        int _planPoint;
        int _leadership;
        int _leadPoint;
        int _team;
        int _teamPoint;
        int _development;
        int _devPoint;
        int _overallPoint;
        string _excelArea;
        string _areaThatNeedsImprovement;
        string _stepsToTake;
        string _areaThatNeedsAssistance;
        int _employeeID_FK;
        int _supervisorID_FK;
        int _hRID_FK;
        int _appraisalID_FK;
        int _competencyID_FK;
        int _sentBy;
        #endregion

        #region "Constructors"
        public EmployeeAppraisalCompetencyTableLogInfo()
        {
        }

        public EmployeeAppraisalCompetencyTableLogInfo(int competencyLogID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int punPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int competencyID_FK, int sentBy)
        {
            this.CompetencyLogID = competencyLogID;
            this.Quality = quality;
            this.QuaPoint = quaPoint;
            this.Productivity = productivity;
            this.ProdPoint = prodPoint;
            this.Knoweldge = knoweldge;
            this.KnowPoint = knowPoint;
            this.Dependability = dependability;
            this.DependPoint = dependPoint;
            this.Initiative = initiative;
            this.InitPoint = initPoint;
            this.Judgement = judgement;
            this.JudPoint = judPoint;
            this.Adaptability = adaptability;
            this.AdaPoint = adaPoint;
            this.InterterpersonalRelationship = interterpersonalRelationship;
            this.InterPoint = interPoint;
            this.Puntuality = puntuality;
            this.PunPoint = punPoint;
            this.CommunicationSkills = communicationSkills;
            this.ComPoint = comPoint;
            this.Planning = planning;
            this.PlanPoint = planPoint;
            this.Leadership = leadership;
            this.LeadPoint = leadPoint;
            this.Team = team;
            this.TeamPoint = teamPoint;
            this.Development = development;
            this.DevPoint = devPoint;
            this.OverallPoint = overallPoint;
            this.ExcelArea = excelArea;
            this.AreaThatNeedsImprovement = areaThatNeedsImprovement;
            this.StepsToTake = stepsToTake;
            this.AreaThatNeedsAssistance = areaThatNeedsAssistance;
            this.EmployeeID_FK = employeeID_FK;
            this.SupervisorID_FK = supervisorID_FK;
            this.HRID_FK = hRID_FK;
            this.AppraisalID_FK = appraisalID_FK;
            this.CompetencyID_FK = competencyID_FK;
            this.SentBy = sentBy;
        }
        #endregion

        #region "Public Properties"
        public int CompetencyLogID
        {
            get { return _competencyLogID; }
            set { _competencyLogID = value; }
        }

        public int Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public int QuaPoint
        {
            get { return _quaPoint; }
            set { _quaPoint = value; }
        }

        public int Productivity
        {
            get { return _productivity; }
            set { _productivity = value; }
        }

        public int ProdPoint
        {
            get { return _prodPoint; }
            set { _prodPoint = value; }
        }

        public int Knoweldge
        {
            get { return _knoweldge; }
            set { _knoweldge = value; }
        }

        public int KnowPoint
        {
            get { return _knowPoint; }
            set { _knowPoint = value; }
        }

        public int Dependability
        {
            get { return _dependability; }
            set { _dependability = value; }
        }

        public int DependPoint
        {
            get { return _dependPoint; }
            set { _dependPoint = value; }
        }

        public int Initiative
        {
            get { return _initiative; }
            set { _initiative = value; }
        }

        public int InitPoint
        {
            get { return _initPoint; }
            set { _initPoint = value; }
        }

        public int Judgement
        {
            get { return _judgement; }
            set { _judgement = value; }
        }

        public int JudPoint
        {
            get { return _judPoint; }
            set { _judPoint = value; }
        }

        public int Adaptability
        {
            get { return _adaptability; }
            set { _adaptability = value; }
        }

        public int AdaPoint
        {
            get { return _adaPoint; }
            set { _adaPoint = value; }
        }

        public int InterterpersonalRelationship
        {
            get { return _interterpersonalRelationship; }
            set { _interterpersonalRelationship = value; }
        }

        public int InterPoint
        {
            get { return _interPoint; }
            set { _interPoint = value; }
        }

        public int Puntuality
        {
            get { return _puntuality; }
            set { _puntuality = value; }
        }

        public int PunPoint
        {
            get { return _punPoint; }
            set { _punPoint = value; }
        }

        public int CommunicationSkills
        {
            get { return _communicationSkills; }
            set { _communicationSkills = value; }
        }

        public int ComPoint
        {
            get { return _comPoint; }
            set { _comPoint = value; }
        }

        public int Planning
        {
            get { return _planning; }
            set { _planning = value; }
        }

        public int PlanPoint
        {
            get { return _planPoint; }
            set { _planPoint = value; }
        }

        public int Leadership
        {
            get { return _leadership; }
            set { _leadership = value; }
        }

        public int LeadPoint
        {
            get { return _leadPoint; }
            set { _leadPoint = value; }
        }

        public int Team
        {
            get { return _team; }
            set { _team = value; }
        }

        public int TeamPoint
        {
            get { return _teamPoint; }
            set { _teamPoint = value; }
        }

        public int Development
        {
            get { return _development; }
            set { _development = value; }
        }

        public int DevPoint
        {
            get { return _devPoint; }
            set { _devPoint = value; }
        }

        public int OverallPoint
        {
            get { return _overallPoint; }
            set { _overallPoint = value; }
        }

        public string ExcelArea
        {
            get { return _excelArea; }
            set { _excelArea = value; }
        }

        public string AreaThatNeedsImprovement
        {
            get { return _areaThatNeedsImprovement; }
            set { _areaThatNeedsImprovement = value; }
        }

        public string StepsToTake
        {
            get { return _stepsToTake; }
            set { _stepsToTake = value; }
        }

        public string AreaThatNeedsAssistance
        {
            get { return _areaThatNeedsAssistance; }
            set { _areaThatNeedsAssistance = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int SupervisorID_FK
        {
            get { return _supervisorID_FK; }
            set { _supervisorID_FK = value; }
        }

        public int HRID_FK
        {
            get { return _hRID_FK; }
            set { _hRID_FK = value; }
        }

        public int AppraisalID_FK
        {
            get { return _appraisalID_FK; }
            set { _appraisalID_FK = value; }
        }

        public int CompetencyID_FK
        {
            get { return _competencyID_FK; }
            set { _competencyID_FK = value; }
        }

        public int SentBy
        {
            get { return _sentBy; }
            set { _sentBy = value; }
        }
        #endregion
    }
 
    public class EmployeeApprasalTableGoalInfo
    {
        #region "Private Members"
        int _goalID;
        string _goalDesc;
        string _goalObjectives;
        int _goalEvaPoint;
        string _goalCompletetiondate;
        int _employeeID_FK;
        int _supervisorID_FK;
        int _hRID_FK;
        int _appraisalID_FK;
        #endregion

        #region "Constructors"
        public EmployeeApprasalTableGoalInfo()
        {
        }

        public EmployeeApprasalTableGoalInfo(int goalID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK)
        {
            this.GoalID = goalID;
            this.GoalDesc = goalDesc;
            this.GoalObjectives = goalObjectives;
            this.GoalEvaPoint = goalEvaPoint;
            this.GoalCompletetiondate = goalCompletetiondate;
            this.EmployeeID_FK = employeeID_FK;
            this.SupervisorID_FK = supervisorID_FK;
            this.HRID_FK = hRID_FK;
            this.AppraisalID_FK = appraisalID_FK;
        }
        #endregion

        #region "Public Properties"
        public int GoalID
        {
            get { return _goalID; }
            set { _goalID = value; }
        }

        public string GoalDesc
        {
            get { return _goalDesc; }
            set { _goalDesc = value; }
        }

        public string GoalObjectives
        {
            get { return _goalObjectives; }
            set { _goalObjectives = value; }
        }

        public int GoalEvaPoint
        {
            get { return _goalEvaPoint; }
            set { _goalEvaPoint = value; }
        }

        public string GoalCompletetiondate
        {
            get { return _goalCompletetiondate; }
            set { _goalCompletetiondate = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int SupervisorID_FK
        {
            get { return _supervisorID_FK; }
            set { _supervisorID_FK = value; }
        }

        public int HRID_FK
        {
            get { return _hRID_FK; }
            set { _hRID_FK = value; }
        }

        public int AppraisalID_FK
        {
            get { return _appraisalID_FK; }
            set { _appraisalID_FK = value; }
        }
        #endregion
    }

    //EmployeeApprasalTableGoalLogInfo
    public class EmployeeApprasalTableGoalLogInfo
    {
        #region "Private Members"
        int _goalLogID;
        string _goalDesc;
        string _goalObjectives;
        int _goalEvaPoint;
        string _goalCompletetiondate;
        int _employeeID_FK;
        int _supervisorID_FK;
        int _hRID_FK;
        int _appraisalID_FK;
        int _goalID_FK;
        int _sentBy;

        string _employeeNum;
        string _employee;
        string _displayName;
        #endregion

        #region "Constructors"
        public EmployeeApprasalTableGoalLogInfo()
        {
        }

        public EmployeeApprasalTableGoalLogInfo(int goalLogID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int goalID_FK, int sentBy, string employeeNum, string employee, string displayName)
        {
            this.GoalLogID = goalLogID;
            this.GoalDesc = goalDesc;
            this.GoalObjectives = goalObjectives;
            this.GoalEvaPoint = goalEvaPoint;
            this.GoalCompletetiondate = goalCompletetiondate;
            this.EmployeeID_FK = employeeID_FK;
            this.SupervisorID_FK = supervisorID_FK;
            this.HRID_FK = hRID_FK;
            this.AppraisalID_FK = appraisalID_FK;
            this.GoalID_FK = goalID_FK;
            this.SentBy = sentBy;
            this.EmployeeNum = employeeNum;
            this.Employee = employee;
            this.DisplayName = displayName;
        }
        #endregion

        #region "Public Properties"
        public int GoalLogID
        {
            get { return _goalLogID; }
            set { _goalLogID = value; }
        }

        public string GoalDesc
        {
            get { return _goalDesc; }
            set { _goalDesc = value; }
        }

        public string GoalObjectives
        {
            get { return _goalObjectives; }
            set { _goalObjectives = value; }
        }

        public int GoalEvaPoint
        {
            get { return _goalEvaPoint; }
            set { _goalEvaPoint = value; }
        }

        public string GoalCompletetiondate
        {
            get { return _goalCompletetiondate; }
            set { _goalCompletetiondate = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int SupervisorID_FK
        {
            get { return _supervisorID_FK; }
            set { _supervisorID_FK = value; }
        }

        public int HRID_FK
        {
            get { return _hRID_FK; }
            set { _hRID_FK = value; }
        }

        public int AppraisalID_FK
        {
            get { return _appraisalID_FK; }
            set { _appraisalID_FK = value; }
        }

        public int GoalID_FK
        {
            get { return _goalID_FK; }
            set { _goalID_FK = value; }
        }

        public int SentBy
        {
            get { return _sentBy; }
            set { _sentBy = value; }
        }

        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        public string Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }
        #endregion
    }

    //EmployeeAppraisalTableChartInfo

   
    public class AppraisalChartInfo

    {

    #region "Private Member"

        string _LastName;
        int _AppraisalScore;
        int _PromoExamScore;
        int _TotalAppraisalScore;
    
         #endregion

    #region "Constructor" 
    public AppraisalChartInfo()
{

}
   public AppraisalChartInfo(string LastName,int AppraisalScore, int PromoExamScore, int TotalAppraisalScore )
{
    this.LastName = LastName;
    this.AppraisalScore = AppraisalScore;
    this.PromoExamScore = PromoExamScore;
    this.TotalAppraisalScore =TotalAppraisalScore;
}
#endregion

    #region "Public Preoperties
    public string LastName
{
    get{return _LastName;}
    set{_LastName = value;}
    }

    public int AppraisalScore
    {
        get { return _AppraisalScore; }
        set { _AppraisalScore = value; }
    }
    public int PromoExamScore
    {
        get { return _PromoExamScore; }
        set { _PromoExamScore = value; }
    }
  public int TotalAppraisalScore
        {
    get {return _TotalAppraisalScore;}
    set {_TotalAppraisalScore = value;}
        }

    #endregion 

    }

    //EmployeeAppraisalTableInfo
    public class EmployeeAppraisalTableInfo
    {
        #region "Private Members"
        int _appraisalID;
        string _employeeNum;
        int _appraisalScore;
        int _promoExamScore;
        int _totalAppraisalScore;
        string _totalPoint;
        string _evaPeriod;
        string _aprpraisalStartYear;
        string _appraisalStatus;
        string _promoRecommendation;
        string _empAppraisalDate;
        string _supAppraisalDate;
        string _hrAppraisalDate;
        string _supComment;
        string _hRPromoRecommendation;
        string _hRComment;
        int _employeeID_FK;
        int _supervisorID_FK;
        int _hRID_FK;
        string _managementDecision;
        string _managementDecisionDate;


        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _displayName;

        #endregion

        #region "Constructors"
        public EmployeeAppraisalTableInfo()
        {
        }

        public EmployeeAppraisalTableInfo(int appraisalID, string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRPromoRecommendation, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK,   string managementDecision,
        string managementDecisionDate, string DeptName, string PositionName, string LevelName, string Salary, string LocationName, string displayName)
        {
            this.AppraisalID = appraisalID;
            this.EmployeeNum = employeeNum;
            this.AppraisalScore = appraisalScore;
            this.PromoExamScore = promoExamScore;
            this.TotalAppraisalScore = totalAppraisalScore;
            this.TotalPoint = totalPoint;
            this.EvaPeriod = evaPeriod;
            this.AprpraisalStartYear = aprpraisalStartYear;
            this.AppraisalStatus = appraisalStatus;
            this.PromoRecommendation = promoRecommendation;
            this.EmpAppraisalDate = empAppraisalDate;
            this.SupAppraisalDate = supAppraisalDate;
            this.HrAppraisalDate = hrAppraisalDate;
            this.SupComment = supComment;
            this.HRPromoRecommendation = hRPromoRecommendation;
            this.HRComment = hRComment;
            this.EmployeeID_FK = employeeID_FK;
            this.SupervisorID_FK = supervisorID_FK;
            this.HRID_FK = hRID_FK;
            this.ManagementDecision = managementDecision;
            this.ManagementDecisionDate = managementDecisionDate;

            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.DisplayName = displayName;
        }
        #endregion

        #region "Public Properties"
        public int AppraisalID
        {
            get { return _appraisalID; }
            set { _appraisalID = value; }
        }

        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        public int AppraisalScore
        {
            get { return _appraisalScore; }
            set { _appraisalScore = value; }
        }

        public int PromoExamScore
        {
            get { return _promoExamScore; }
            set { _promoExamScore = value; }
        }

        public int TotalAppraisalScore
        {
            get { return _totalAppraisalScore; }
            set { _totalAppraisalScore = value; }
        }

        public string TotalPoint
        {
            get { return _totalPoint; }
            set { _totalPoint = value; }
        }

        public string EvaPeriod
        {
            get { return _evaPeriod; }
            set { _evaPeriod = value; }
        }

        public string AprpraisalStartYear
        {
            get { return _aprpraisalStartYear; }
            set { _aprpraisalStartYear = value; }
        }

        public string AppraisalStatus
        {
            get { return _appraisalStatus; }
            set { _appraisalStatus = value; }
        }

        public string PromoRecommendation
        {
            get { return _promoRecommendation; }
            set { _promoRecommendation = value; }
        }

        public string EmpAppraisalDate
        {
            get { return _empAppraisalDate; }
            set { _empAppraisalDate = value; }
        }

        public string SupAppraisalDate
        {
            get { return _supAppraisalDate; }
            set { _supAppraisalDate = value; }
        }

        public string HrAppraisalDate
        {
            get { return _hrAppraisalDate; }
            set { _hrAppraisalDate = value; }
        }

        public string SupComment
        {
            get { return _supComment; }
            set { _supComment = value; }
        }
        public string HRPromoRecommendation
        {
            get { return _hRPromoRecommendation; }
            set { _hRPromoRecommendation = value; }
        }
        
        public string HRComment
        {
            get { return _hRComment; }
            set { _hRComment = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int SupervisorID_FK
        {
            get { return _supervisorID_FK; }
            set { _supervisorID_FK = value; }
        }

        public int HRID_FK
        {
            get { return _hRID_FK; }
            set { _hRID_FK = value; }
        }


        public string ManagementDecision
        {
            get { return _managementDecision; }
            set { _managementDecision = value; }
        }

        public string ManagementDecisionDate
        {
            get { return _managementDecisionDate; }
            set { _managementDecisionDate = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }
        #endregion
    }

    //EmployeeAppraisalTableLogInfo
    
    public class EmployeeAppraisalTableLogInfo
	{
		#region "Private Members"
		int _appraisalLogID;
		string _employeeNum;
		int _appraisalScore;
		int _promoExamScore;
		int _totalAppraisalScore;
		string _totalPoint;
		string _evaPeriod;
		string _aprpraisalStartYear;
		string _appraisalStatus;
		string _promoRecommendation;
		string _empAppraisalDate;
		string _supAppraisalDate;
		string _hrAppraisalDate;
		string _supComment;
        string _hRPromoRecommendation;
		string _hRComment;
		int _employeeID_FK;
		int _supervisorID_FK;
		int _hRID_FK;
		int _appraisalID_FK;
		int _sentBy;
        string _managementDecision;
        string _managementDecisionDate;

        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _displayName;
        string _employee;

        string _excelArea;
        string _areaThatNeedsImprovement;
        string _stepsToTake;
        string _areaThatNeedsAssistance;

		#endregion
		
		#region "Constructors"
        public EmployeeAppraisalTableLogInfo()
        {
		}

        public EmployeeAppraisalTableLogInfo(int appraisalLogID, string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRPromoRecommendation, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy,  string managementDecision, string managementDecisionDate, string DeptName, string PositionName, string LevelName, string Salary, string LocationName, string displayName, string employee, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance)
		{
            this.AppraisalLogID = appraisalLogID;
            this.EmployeeNum = employeeNum;
            this.AppraisalScore = appraisalScore;
            this.PromoExamScore = promoExamScore;
            this.TotalAppraisalScore = totalAppraisalScore;
            this.TotalPoint = totalPoint;
            this.EvaPeriod = evaPeriod;
            this.AprpraisalStartYear = aprpraisalStartYear;
            this.AppraisalStatus = appraisalStatus;
            this.PromoRecommendation = promoRecommendation;
            this.EmpAppraisalDate = empAppraisalDate;
            this.SupAppraisalDate = supAppraisalDate;
            this.HrAppraisalDate = hrAppraisalDate;
            this.SupComment = supComment;
            this.HRPromoRecommendation = hRPromoRecommendation;
            this.HRComment = hRComment;
            this.EmployeeID_FK = employeeID_FK;
            this.SupervisorID_FK = supervisorID_FK;
            this.HRID_FK = hRID_FK;
            this.AppraisalID_FK = appraisalID_FK;
            this.SentBy = sentBy;
            this.ManagementDecision = managementDecision;
            this.ManagementDecisionDate = managementDecisionDate;
           

            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.DisplayName = displayName;
            this.Employee = employee;
            this.ExcelArea = excelArea;
            this.AreaThatNeedsImprovement = areaThatNeedsImprovement;
            this.StepsToTake = stepsToTake;
            this.AreaThatNeedsAssistance = areaThatNeedsAssistance;
        }
		#endregion
		
		#region "Public Properties"
		public int AppraisalLogID
		{
			get{return _appraisalLogID;}
			set{_appraisalLogID = value;}
		}
		
		public string EmployeeNum
		{
			get{return _employeeNum;}
			set{_employeeNum = value;}
		}

		public int AppraisalScore
		{
			get{return _appraisalScore;}
			set{_appraisalScore = value;}
		}

		public int PromoExamScore
		{
			get{return _promoExamScore;}
			set{_promoExamScore = value;}
		}

		public int TotalAppraisalScore
		{
			get{return _totalAppraisalScore;}
			set{_totalAppraisalScore = value;}
		}

		public string TotalPoint
		{
			get{return _totalPoint;}
			set{_totalPoint = value;}
		}

		public string EvaPeriod
		{
			get{return _evaPeriod;}
			set{_evaPeriod = value;}
		}

		public string AprpraisalStartYear
		{
			get{return _aprpraisalStartYear;}
			set{_aprpraisalStartYear = value;}
		}

		public string AppraisalStatus
		{
			get{return _appraisalStatus;}
			set{_appraisalStatus = value;}
		}

		public string PromoRecommendation
		{
			get{return _promoRecommendation;}
			set{_promoRecommendation = value;}
		}

		public string EmpAppraisalDate
		{
			get{return _empAppraisalDate;}
			set{_empAppraisalDate = value;}
		}

		public string SupAppraisalDate
		{
			get{return _supAppraisalDate;}
			set{_supAppraisalDate = value;}
		}

		public string HrAppraisalDate
		{
			get{return _hrAppraisalDate;}
			set{_hrAppraisalDate = value;}
		}

		public string SupComment
		{
			get{return _supComment;}
			set{_supComment = value;}
		}

        public string HRPromoRecommendation
        {
            get { return _hRPromoRecommendation; }
            set { _hRPromoRecommendation = value; }
        }

		public string HRComment
		{
			get{return _hRComment;}
			set{_hRComment = value;}
		}

		public int EmployeeID_FK
		{
			get{return _employeeID_FK;}
			set{_employeeID_FK = value;}
		}

		public int SupervisorID_FK
		{
			get{return _supervisorID_FK;}
			set{_supervisorID_FK = value;}
		}

		public int HRID_FK
		{
			get{return _hRID_FK;}
			set{_hRID_FK = value;}
		}

		public int AppraisalID_FK
		{
			get{return _appraisalID_FK;}
			set{_appraisalID_FK = value;}
		}

		public int SentBy
		{
			get{return _sentBy;}
			set{_sentBy = value;}
		}

        public string ManagementDecision
        {
            get { return _managementDecision; }
            set { _managementDecision = value; }
        }

        public string ManagementDecisionDate
        {
            get { return _managementDecisionDate; }
            set { _managementDecisionDate = value; }
        }

        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        public string Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public string ExcelArea
        {
            get { return _excelArea; }
            set { _excelArea = value; }
        }

        public string AreaThatNeedsImprovement
        {
            get { return _areaThatNeedsImprovement; }
            set { _areaThatNeedsImprovement = value; }
        }

        public string StepsToTake
        {
            get { return _stepsToTake; }
            set { _stepsToTake = value; }
        }

        public string AreaThatNeedsAssistance
        {
            get { return _areaThatNeedsAssistance; }
            set { _areaThatNeedsAssistance = value; }
        }

        
		#endregion
	}

    #endregion


    //EmployeePromotionTableInfo

    public class EmployeePromotionTableInfo
    {
        #region "Private Members"
        int _promotionID;
        int _previousLevel;
        int _newLevel;
        int _preDept;
        int _previousPosition;
        int _newDept;
        int _newPosition;
        int _apprasialScore;
        int _promoExamScore;
        int _totalAppraisalScore;
        string _promotedDate;
        int _promotedBy;
        int _employeeID_FK;
        int _apprasialID_FK;

        string _employeeNum;
        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        string _EmpPreDept;
        string _EmpNewDept;
        string _EmpPrePosition;
        string _EmpNewPosition;
        string  _EmpPreLevel;
        string _EmpNewLevel;
        string _Email;
        string _DisplayName;
        #endregion

        #region "Constructors"
        public EmployeePromotionTableInfo()
        {
        }

        public EmployeePromotionTableInfo(int promotionID, int previousLevel , int newLevel , int preDept , int previousPosition , int newDept , int newPosition , int apprasialScore , int promoExamScore , int totalAppraisalScore , string promotedDate , int promotedBy , int employeeID_FK , int apprasialID_FK,
            string employeeNum, string DeptName, string PositionName, string LevelName, string Salary, string LocationName, string EmpPreDept, string EmpNewDept, string EmpPrePosition, string EmpNewPosition, string EmpPreLevel, string EmpNewLevel, string Email, string DisplayName)
        {

            this.PromotionID = promotionID;
            this.PreviousLevel = previousLevel;
            this.NewLevel = newLevel;
            this.PreDept = preDept;
            this.PreviousPosition = previousPosition;
            this.NewDept = newDept;
            this.NewPosition = newPosition;
            this.ApprasialScore = apprasialScore;
            this.PromoExamScore = promoExamScore;
            this.TotalAppraisalScore = totalAppraisalScore;
            this.PromotedDate = promotedDate;
            this.PromotedBy = promotedBy;
            this.EmployeeID_FK = employeeID_FK;
            this.ApprasialID_FK = apprasialID_FK;

            this.EmployeeNum = employeeNum;
            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
            this.EmpPreDept = EmpPreDept;
            this.EmpNewDept = EmpNewDept;
            this.EmpPrePosition = EmpPrePosition;
            this.EmpNewPosition = EmpNewPosition;
            this.EmpPreLevel = EmpPreLevel;
            this.EmpNewLevel = EmpNewLevel;
            this.Email = Email;
            this.Email = DisplayName;

        }
        #endregion

       
        #region "Public Properties"
        public int PromotionID
        {
            get { return _promotionID; }
            set { _promotionID = value; }
        }

        public int PreviousLevel
        {
            get { return _previousLevel; }
            set { _previousLevel = value; }
        }

        public int NewLevel
        {
            get { return _newLevel; }
            set { _newLevel = value; }
        }

        public int PreDept
        {
            get { return _preDept; }
            set { _preDept = value; }
        }

        public int PreviousPosition
        {
            get { return _previousPosition; }
            set { _previousPosition = value; }
        }

        public int NewDept
        {
            get { return _newDept; }
            set { _newDept = value; }
        }

        public int NewPosition
        {
            get { return _newPosition; }
            set { _newPosition = value; }
        }

        public int ApprasialScore
        {
            get { return _apprasialScore; }
            set { _apprasialScore = value; }
        }

        public int PromoExamScore
        {
            get { return _promoExamScore; }
            set { _promoExamScore = value; }
        }

        public int TotalAppraisalScore
        {
            get { return _totalAppraisalScore; }
            set { _totalAppraisalScore = value; }
        }

        public string PromotedDate
        {
            get { return _promotedDate; }
            set { _promotedDate = value; }
        }

        public int PromotedBy
        {
            get { return _promotedBy; }
            set { _promotedBy = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int ApprasialID_FK
        {
            get { return _apprasialID_FK; }
            set { _apprasialID_FK = value; }
        }

        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }
        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
          public string EmpPreDept
        {
            get { return _EmpPreDept; }
            set { _EmpPreDept = value; }
        }
          public string EmpNewDept
        {
            get { return _EmpNewDept; }
            set { _EmpNewDept = value; }
        }
          public string EmpPrePosition
        {
            get { return _EmpPrePosition; }
            set { _EmpPrePosition = value; }
        }
          public string EmpNewPosition
        {
            get { return _EmpNewPosition; }
            set { _EmpNewPosition = value; }
        }
            public string EmpPreLevel
        {
            get { return _EmpPreLevel; }
            set { _EmpPreLevel = value; }
        }
          public string EmpNewLevel
        {
            get { return _EmpNewLevel; }
            set { _EmpNewLevel = value; }
        }
          public string Email
          {
              get { return _Email; }
              set { _Email = value; }
          }
          public string DisplayName
          {
              get { return _DisplayName; }
              set { _DisplayName = value; }
          }

       
      
        #endregion
    }


    public class EmployeePromotionTableLogInfo
    {
        #region "Private Members"
        int _promotionLogID;
        int _previousLevel;
        int _newLevel;
        int _preDept;
        int _previousPosition;
        int _newDept;
        int _newPosition;
        int _apprasialScore;
        int _promoExamScore;
        int _totalAppraisalScore;
        string _promotedDate;
        int _promotedBy;
        int _employeeID_FK;
        int _apprasialID_FK;
        int _promotionID_FK;


        string _employeeNum;
        string _DeptName;
        string _PositionName;
        string _LevelName;
        string _Salary;
        string _LocationName;
        #endregion

        #region "Constructors"
        public EmployeePromotionTableLogInfo()
        {
        }

        public EmployeePromotionTableLogInfo(int promotionLogID, int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK, int promotionID_FK,
            string employeeNum, string DeptName, string PositionName, string LevelName, string Salary, string LocationName)
      
        {
            this.PromotionLogID = promotionLogID;
            this.PreviousLevel = previousLevel;
            this.NewLevel = newLevel;
            this.PreDept = preDept;
            this.PreviousPosition = previousPosition;
            this.NewDept = newDept;
            this.NewPosition = newPosition;
            this.ApprasialScore = apprasialScore;
            this.PromoExamScore = promoExamScore;
            this.TotalAppraisalScore = totalAppraisalScore;
            this.PromotedDate = promotedDate;
            this.PromotedBy = promotedBy;
            this.EmployeeID_FK = employeeID_FK;
            this.ApprasialID_FK = apprasialID_FK;
            this.PromotionID_FK = promotionID_FK;

            this.EmployeeNum = employeeNum;
            this.DeptName = DeptName;
            this.PositionName = PositionName;
            this.LevelName = LevelName;
            this.Salary = Salary;
            this.LocationName = LocationName;
        }
        #endregion

        #region "Public Properties"
        public int PromotionLogID
        {
            get { return _promotionLogID; }
            set { _promotionLogID = value; }
        }

        public int PreviousLevel
        {
            get { return _previousLevel; }
            set { _previousLevel = value; }
        }

        public int NewLevel
        {
            get { return _newLevel; }
            set { _newLevel = value; }
        }

        public int PreDept
        {
            get { return _preDept; }
            set { _preDept = value; }
        }

        public int PreviousPosition
        {
            get { return _previousPosition; }
            set { _previousPosition = value; }
        }

        public int NewDept
        {
            get { return _newDept; }
            set { _newDept = value; }
        }

        public int NewPosition
        {
            get { return _newPosition; }
            set { _newPosition = value; }
        }

        public int ApprasialScore
        {
            get { return _apprasialScore; }
            set { _apprasialScore = value; }
        }

        public int PromoExamScore
        {
            get { return _promoExamScore; }
            set { _promoExamScore = value; }
        }

        public int TotalAppraisalScore
        {
            get { return _totalAppraisalScore; }
            set { _totalAppraisalScore = value; }
        }

        public string PromotedDate
        {
            get { return _promotedDate; }
            set { _promotedDate = value; }
        }

        public int PromotedBy
        {
            get { return _promotedBy; }
            set { _promotedBy = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int ApprasialID_FK
        {
            get { return _apprasialID_FK; }
            set { _apprasialID_FK = value; }
        }

        public int PromotionID_FK
        {
            get { return _promotionID_FK; }
            set { _promotionID_FK = value; }
        }


        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }
        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }

        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }
        public string Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }
        #endregion
    }


    //EmployeeTypeOfLeaveTableInfo
    public class EmployeeTypeOfLeaveTableInfo
    {
        #region "Private Members"
        int _leaveTypeID;
        string _leaveTypeName;
        #endregion

        #region "Constructors"
        public EmployeeTypeOfLeaveTableInfo()
        {
        }

        public EmployeeTypeOfLeaveTableInfo(int leaveTypeID, string leaveTypeName)
        {
            this.LeaveTypeID = leaveTypeID;
            this.LeaveTypeName = leaveTypeName;
        }
        #endregion

        #region "Public Properties"
        public int LeaveTypeID
        {
            get { return _leaveTypeID; }
            set { _leaveTypeID = value; }
        }

        public string LeaveTypeName
        {
            get { return _leaveTypeName; }
            set { _leaveTypeName = value; }
        }
        #endregion
    }

    //EmployeeLeaveTableInfo
    public class EmployeeLeaveTableInfo
    {
        #region "Private Members"
        int _leaveID;
        int _leaveType_FK;
        string _leaveDescription;
        string _startDate;
        string _endDate;
        string _duration;
        int _levelID_FK;
        string _leaveThresholdBeforeApplication;
        string _leaveThreshold;
        string _dateApplied;
        string _leaveStatus;
        int _leaveGrantedBy;
        string _dateGranted;
        string _approveOrDisapproveReason;
        string _reasonForDisapproval;       
        int _dept_FK;
        int _employeeID_FK;
        int _leaveLogID;
        string _employeeNum;
        string _employeeName;
        string _deptName;
        string _leaveTypeName;
        string _displayName;
        string _leaveEntitle;
        #endregion

        #region "Constructors"
        public EmployeeLeaveTableInfo()
        {
        }

        public EmployeeLeaveTableInfo(int leaveID, int leaveType_FK, string leaveDescription, string startDate,
            string endDate, string duration, int levelID_FK, string leaveThresholdBeforeApplication, string leaveThreshold,
            string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, 
            string reasonForDisapproval, int dept_FK, int employeeID_FK, int leaveLogID, string employeeNum,
            string employeeName, string deptName, string leaveTypeName, string displayName, string leaveEntitle)
        {
            this.LeaveID = leaveID;
            this.LeaveType_FK = leaveType_FK;
            this.LeaveDescription = leaveDescription;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.LevelID_FK = levelID_FK;
            this.LeaveThresholdBeforeApplication = leaveThresholdBeforeApplication;
            this.LeaveThreshold = leaveThreshold;
            this.DateApplied = dateApplied;
            this.LeaveStatus = leaveStatus;
            this.LeaveGrantedBy = leaveGrantedBy;
            this.DateGranted = dateGranted;
            this.ApproveOrDisapproveReason = approveOrDisapproveReason;
            this.ReasonForDisapproval = reasonForDisapproval;
            this.Dept_FK = dept_FK;
            this.EmployeeID_FK = employeeID_FK;
            this.LeaveLogID = leaveLogID;
            this.EmployeeNum = employeeNum;
            this.EmployeeName = employeeName;
            this.DeptName = deptName;
            this.LeaveTypeName = leaveTypeName;
            this.DisplayName = displayName;
            this.LeaveEntitle = leaveEntitle;
        }
        #endregion

        #region "Public Properties"
        public int LeaveID
        {
            get { return _leaveID; }
            set { _leaveID = value; }
        }

        public int LeaveType_FK
        {
            get { return _leaveType_FK; }
            set { _leaveType_FK = value; }
        }

        public string LeaveDescription
        {
            get { return _leaveDescription; }
            set { _leaveDescription = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int LevelID_FK
        {
            get { return _levelID_FK; }
            set { _levelID_FK = value; }
        }

        public string LeaveThresholdBeforeApplication
        {
            get { return _leaveThresholdBeforeApplication; }
            set { _leaveThresholdBeforeApplication = value; }
        }
        public string LeaveThreshold
        {
            get { return _leaveThreshold; }
            set { _leaveThreshold = value; }
        }

        public string DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; }
        }

        public string LeaveStatus
        {
            get { return _leaveStatus; }
            set { _leaveStatus = value; }
        }

        public int LeaveGrantedBy
        {
            get { return _leaveGrantedBy; }
            set { _leaveGrantedBy = value; }
        }

        public string DateGranted
        {
            get { return _dateGranted; }
            set { _dateGranted = value; }
        }

        public string ApproveOrDisapproveReason
        {
            get { return _approveOrDisapproveReason; }
            set { _approveOrDisapproveReason = value; }
        }
        public string ReasonForDisapproval
        {
            get { return _reasonForDisapproval; }
            set { _reasonForDisapproval = value; }
        }
        
        public int Dept_FK
        {
            get { return _dept_FK; }
            set { _dept_FK = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }
        public int LeaveLogID
        {
            get { return _leaveLogID; }
            set { _leaveLogID = value; }
        }
        
        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
        public string LeaveTypeName
        {
            get { return _leaveTypeName; }
            set { _leaveTypeName = value; }
        }
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }
          public string LeaveEntitle
        {
            get { return _leaveEntitle; }
            set { _leaveEntitle = value; }
        }
        
        //EmployeeNum
        #endregion
    }

    //EmployeeLeaveTableLog Info 
    public class EmployeeLeaveTableLogInfo
    {
        #region "Private Members"
        int _leaveLogID;
        int _leaveType_FK;
        string _leaveDescription;
        string _startDate;
        string _endDate;
        string _duration;
        int _level_FK;
        string _leaveThresholdBeforeApplication;
        string _leaveThreshold;
        string _dateApplied;
        string _leaveStatus;
        int _leaveGrantedBy;
        string _dateGranted;
      
        string _approveOrDisapproveReason;
        string _reasonForDisapproval;
        int _dept_FK;
        int _employeeID_FK;
        int _leaveID_FK;
        #endregion

        #region "Constructors"
        public EmployeeLeaveTableLogInfo()
        {
        }

        public EmployeeLeaveTableLogInfo(int leaveLogID, int leaveType_FK, string leaveDescription, string startDate, 
            string endDate, string duration, int level_FK, string leaveThresholdBeforeApplication, string leaveThreshold,
            string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, 
            string reasonForDisapproval, int dept_FK, int employeeID_FK, int leaveID_FK)
        {
            this.LeaveLogID = leaveLogID;
            this.LeaveType_FK = leaveType_FK;
            this.LeaveDescription = leaveDescription;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.Level_FK = level_FK;
            this.LeaveThresholdBeforeApplication = leaveThresholdBeforeApplication;
            this.LeaveThreshold = leaveThreshold;
            this.DateApplied = dateApplied;
            this.LeaveStatus = leaveStatus;
            this.LeaveGrantedBy = leaveGrantedBy;
            this.DateGranted = dateGranted;
            this.ApproveOrDisapproveReason = approveOrDisapproveReason;
            this.ReasonForDisapproval = reasonForDisapproval;
            this.Dept_FK = dept_FK;
            this.EmployeeID_FK = employeeID_FK;
            this.LeaveID_FK = leaveID_FK;
        }
        #endregion

        #region "Public Properties"
        public int LeaveLogID
        {
            get { return _leaveLogID; }
            set { _leaveLogID = value; }
        }

        public int LeaveType_FK
        {
            get { return _leaveType_FK; }
            set { _leaveType_FK = value; }
        }

        public string LeaveDescription
        {
            get { return _leaveDescription; }
            set { _leaveDescription = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int Level_FK
        {
            get { return _level_FK; }
            set { _level_FK = value; }
        }

        public string LeaveThresholdBeforeApplication
        {
            get { return _leaveThresholdBeforeApplication; }
            set { _leaveThresholdBeforeApplication = value; }
        }
           public string LeaveThreshold
        {
            get { return _leaveThreshold; }
            set { _leaveThreshold = value; }
        }

        public string DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; }
        }

        public string LeaveStatus
        {
            get { return _leaveStatus; }
            set { _leaveStatus = value; }
        }

        public int LeaveGrantedBy
        {
            get { return _leaveGrantedBy; }
            set { _leaveGrantedBy = value; }
        }

        public string DateGranted
        {
            get { return _dateGranted; }
            set { _dateGranted = value; }
        }

        public string ApproveOrDisapproveReason
        {
            get { return _approveOrDisapproveReason; }
            set { _approveOrDisapproveReason = value; }
        }
        public string ReasonForDisapproval
        {
            get { return _reasonForDisapproval; }
            set { _reasonForDisapproval = value; }
        }
        public int Dept_FK
        {
            get { return _dept_FK; }
            set { _dept_FK = value; }
        }

        public int EmployeeID_FK
        {
            get { return _employeeID_FK; }
            set { _employeeID_FK = value; }
        }

        public int LeaveID_FK
        {
            get { return _leaveID_FK; }
            set { _leaveID_FK = value; }
        }
        #endregion
    }


    //EmployeeDisciplineTableInfo
    public class EmployeeDisciplineTableInfo
    {
        #region "Private Members"
        int _disciplineID;
        string _discplineDescription;
        #endregion

        #region "Constructors"
        public EmployeeDisciplineTableInfo()
        {
        }

        public EmployeeDisciplineTableInfo(int disciplineID, string discplineDescription)
        {
            this.DisciplineID = disciplineID;
            this.DiscplineDescription = discplineDescription;
        }
        #endregion

        #region "Public Properties"
        public int DisciplineID
        {
            get { return _disciplineID; }
            set { _disciplineID = value; }
        }

        public string DiscplineDescription
        {
            get { return _discplineDescription; }
            set { _discplineDescription = value; }
        }
        #endregion
    }



    //EmployeeQueryTableInfo
    public class EmployeeQueryTableInfo
    {
        #region "Private Members"
        int _queryID;
        string _queryTitle;
        string _description;
        int _queryReceivedBy;
        string _issueDate;
        int _queryIssuedBy;
        string _queryLetter;
        string _employeeResponse;
        string _responseDate;
        string _empResponseLetter;
        int _discipliineType_FK;
        string _suspentionStartDate;
        string _suspentionEndDate;
        string _suspentionDuration;
        string _disciplineDetails;
        string _disciplineLetter;
        string _disciplineDate;
        int _disciplinedBy;

        string _queryIssueByName;
        string _employeeNum;
        string _queryReceivedByName;
        #endregion

        #region "Constructors"
        public EmployeeQueryTableInfo()
        {
        }

        public EmployeeQueryTableInfo(int queryID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, 
        string suspentionStartDate,  string suspentionEndDate, string suspentionDuration, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, string queryIssueByName, string employeeNum, string queryReceivedByName)
        {
            this.QueryID = queryID;
            this.QueryTitle = queryTitle;
            this.Description = description;
            this.QueryReceivedBy = queryReceivedBy;
            this.IssueDate = issueDate;
            this.QueryIssuedBy = queryIssuedBy;
            this.QueryLetter = queryLetter;
            this.EmployeeResponse = employeeResponse;
            this.ResponseDate = responseDate;
            this.EmpResponseLetter = empResponseLetter;
            this.DiscipliineType_FK = discipliineType_FK;
            this.SuspentionStartDate = suspentionStartDate;
            this.SuspentionEndDate = suspentionEndDate;
            this.SuspentionDuration = suspentionDuration;
            this.DisciplineDetails = disciplineDetails;
            this.DisciplineLetter = disciplineLetter;
            this.DisciplineDate = disciplineDate;
            this.DisciplinedBy = disciplinedBy;
            this.QueryIssueByName = queryIssueByName;
            this.EmployeeNum = employeeNum;
            this.QueryReceivedByName = queryReceivedByName;
        }
        #endregion

        #region "Public Properties"
        public int QueryID
        {
            get { return _queryID; }
            set { _queryID = value; }
        }

        public string QueryTitle
        {
            get { return _queryTitle; }
            set { _queryTitle = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int QueryReceivedBy
        {
            get { return _queryReceivedBy; }
            set { _queryReceivedBy = value; }
        }

        public string IssueDate
        {
            get { return _issueDate; }
            set { _issueDate = value; }
        }

        public int QueryIssuedBy
        {
            get { return _queryIssuedBy; }
            set { _queryIssuedBy = value; }
        }

        public string QueryLetter
        {
            get { return _queryLetter; }
            set { _queryLetter = value; }
        }

        public string EmployeeResponse
        {
            get { return _employeeResponse; }
            set { _employeeResponse = value; }
        }

        public string ResponseDate
        {
            get { return _responseDate; }
            set { _responseDate = value; }
        }

        public string EmpResponseLetter
        {
            get { return _empResponseLetter; }
            set { _empResponseLetter = value; }
        }

        public int DiscipliineType_FK
        {
            get { return _discipliineType_FK; }
            set { _discipliineType_FK = value; }
        }
       
        public string SuspentionStartDate
        {
            get { return _suspentionStartDate; }
            set { _suspentionStartDate = value; }
        }
         public string SuspentionEndDate
        {
            get { return _suspentionEndDate; }
            set { _suspentionEndDate = value; }
        }
         public string SuspentionDuration
        {
            get { return _suspentionDuration; }
            set { _suspentionDuration = value; }
        }

        public string DisciplineDetails
        {
            get { return _disciplineDetails; }
            set { _disciplineDetails = value; }
        }

        public string DisciplineLetter
        {
            get { return _disciplineLetter; }
            set { _disciplineLetter = value; }
        }

        public string DisciplineDate
        {
            get { return _disciplineDate; }
            set { _disciplineDate = value; }
        }

        public int DisciplinedBy
        {
            get { return _disciplinedBy; }
            set { _disciplinedBy = value; }
        }


        public string QueryIssueByName
        {
            get { return _queryIssueByName; }
            set { _queryIssueByName = value; }
        }
        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        //QueryReceivedByName
        public string QueryReceivedByName
        {
            get { return _queryReceivedByName; }
            set { _queryReceivedByName = value; }
        }
        #endregion
    }



    public class EmployeeQueryTableLogInfo
    {
        #region "Private Members"
        int _queryLogID;
        string _queryTitle;
        string _description;
        int _queryReceivedBy;
        string _issueDate;
        int _queryIssuedBy;
        string _queryLetter;
        string _employeeResponse;
        string _responseDate;
        string _empResponseLetter;
        int _discipliineType_FK;
        string _suspentionStartDate;
        string _suspentionEndDate;
        string _suspentionDuration;
        string _disciplineDetails;
        string _disciplineLetter;
        string _disciplineDate;
        int _disciplinedBy;
        int _queryID_FK;


        string _queryIssueByName;
        string _employeeNum;
        string _queryReceivedByName;
        #endregion

        #region "Constructors"
        public EmployeeQueryTableLogInfo()
        {
        }

        public EmployeeQueryTableLogInfo(int queryLogID, string queryTitle, string description, int queryReceivedBy, string issueDate
            , int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter,
            int discipliineType_FK, string suspentionStartDate, string suspentionEndDate, string suspentionDuration, 
            string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK, 
            string queryIssueByName, string employeeNum, string queryReceivedByName)
        {
            this.QueryLogID = queryLogID;
            this.QueryTitle = queryTitle;
            this.Description = description;
            this.QueryReceivedBy = queryReceivedBy;
            this.IssueDate = issueDate;
            this.QueryIssuedBy = queryIssuedBy;
            this.QueryLetter = queryLetter;
            this.EmployeeResponse = employeeResponse;
            this.ResponseDate = responseDate;
            this.EmpResponseLetter = empResponseLetter;
            this.DiscipliineType_FK = discipliineType_FK;
            this.SuspentionStartDate = suspentionStartDate;
            this.SuspentionEndDate = suspentionEndDate;
            this.SuspentionDuration = suspentionDuration;
            this.DisciplineDetails = disciplineDetails;
            this.DisciplineLetter = disciplineLetter;
            this.DisciplineDate = disciplineDate;
            this.DisciplinedBy = disciplinedBy;
            this.QueryID_FK = queryID_FK;
            this.QueryIssueByName = queryIssueByName;
            this.EmployeeNum = employeeNum;
            this.QueryReceivedByName = queryReceivedByName;
        }
        #endregion

        #region "Public Properties"
        public int QueryLogID
        {
            get { return _queryLogID; }
            set { _queryLogID = value; }
        }

        public string QueryTitle
        {
            get { return _queryTitle; }
            set { _queryTitle = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int QueryReceivedBy
        {
            get { return _queryReceivedBy; }
            set { _queryReceivedBy = value; }
        }

        public string IssueDate
        {
            get { return _issueDate; }
            set { _issueDate = value; }
        }

        public int QueryIssuedBy
        {
            get { return _queryIssuedBy; }
            set { _queryIssuedBy = value; }
        }

        public string QueryLetter
        {
            get { return _queryLetter; }
            set { _queryLetter = value; }
        }

        public string EmployeeResponse
        {
            get { return _employeeResponse; }
            set { _employeeResponse = value; }
        }

        public string ResponseDate
        {
            get { return _responseDate; }
            set { _responseDate = value; }
        }

        public string EmpResponseLetter
        {
            get { return _empResponseLetter; }
            set { _empResponseLetter = value; }
        }

        public int DiscipliineType_FK
        {
            get { return _discipliineType_FK; }
            set { _discipliineType_FK = value; }
        }
        public string SuspentionStartDate
        {
            get { return _suspentionStartDate; }
            set { _suspentionStartDate = value; }
        }
        public string SuspentionEndDate
        {
            get { return _suspentionEndDate; }
            set { _suspentionEndDate = value; }
        }
        public string SuspentionDuration
        {
            get { return _suspentionDuration; }
            set { _suspentionDuration = value; }
        }
        public string DisciplineDetails
        {
            get { return _disciplineDetails; }
            set { _disciplineDetails = value; }
        }

        public string DisciplineLetter
        {
            get { return _disciplineLetter; }
            set { _disciplineLetter = value; }
        }

        public string DisciplineDate
        {
            get { return _disciplineDate; }
            set { _disciplineDate = value; }
        }

        public int DisciplinedBy
        {
            get { return _disciplinedBy; }
            set { _disciplinedBy = value; }
        }

        public int QueryID_FK
        {
            get { return _queryID_FK; }
            set { _queryID_FK = value; }

        }


        public string QueryIssueByName
        {
            get { return _queryIssueByName; }
            set { _queryIssueByName = value; }
        }
        public string EmployeeNum
        {
            get { return _employeeNum; }
            set { _employeeNum = value; }
        }

        //QueryReceivedByName
        public string QueryReceivedByName
        {
            get { return _queryReceivedByName; }
            set { _queryReceivedByName = value; }
        }
        #endregion
    }

        }


    
