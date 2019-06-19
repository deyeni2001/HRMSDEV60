using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DotNetNuke;
using DotNetNuke.Framework;
using ola.HRMangmntSyst;


namespace ola.HRMangmntSyst
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
            objProvider = (DataProvider)Reflection.CreateObject("data", "ola.HRMangmntSyst", "");
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




        #region "CountryTable Abstract Methods"
        public abstract IDataReader CountryTableGet(int countryID);
        public abstract IDataReader CountryTableList();
        public abstract int CountryTableAdd(string countryName);
        public abstract void CountryTableUpdate(int countryID, string countryName);
        public abstract void CountryTableDelete(int countryID);
        #endregion



        #region "StateTable Abstract Methods"
        public abstract IDataReader StateTableGet(int stateID);
        public abstract IDataReader StateTableList();
        public abstract IDataReader StateTableGetByCountryTable(int countryID);
        public abstract int StateTableAdd(string stateName, string stateCode, int countryID);
        public abstract void StateTableUpdate(int stateID, string stateName, string stateCode, int countryID);
        public abstract void StateTableDelete(int stateID);
        #endregion


        #region "SenatorialTable Abstract Methods"
        public abstract IDataReader SenatorialTableGet(int senID);
        public abstract IDataReader SenatorialTableList();
        public abstract IDataReader SenatorialTableGetByStateTable(int stateID);
        public abstract int SenatorialTableAdd(string senCode, string senName, int senStateID_FK);
        public abstract void SenatorialTableUpdate(int senID, string senCode, string senName, int senStateID_FK);
        public abstract void SenatorialTableDelete(int senID);
        #endregion



        #region "LGATable Abstract Methods"
        public abstract IDataReader LGATableGet(int lgaID);
        public abstract IDataReader LGATableList();
        public abstract IDataReader LGATableGetByStateTable(int stateID);
        public abstract int LGATableAdd(string lgaName, int stateID);
        public abstract void LGATableUpdate(int lgaID, string lgaName, int stateID);
        public abstract void LGATableDelete(int lgaID);
        #endregion


        #region "Qualifications Abstract Methods"
        public abstract IDataReader QualificationsGet(int qualifID);
        public abstract IDataReader QualificationsList();
        public abstract int QualificationsAdd(string qualifName);
        public abstract void QualificationsUpdate(int qualifID, string qualifName);
        public abstract void QualificationsDelete(int qualifID);
        #endregion


        #region "GradeTable Abstract Methods"
        public abstract IDataReader GradeTableGet(int gradeID);
        public abstract IDataReader GradeTableList();
        public abstract IDataReader GradeTableGetByQualifications(int qualifID);
        public abstract int GradeTableAdd(string gradeName, int qaulifID_FK);
        public abstract void GradeTableUpdate(int gradeID, string gradeName, int qaulifID_FK);
        public abstract void GradeTableDelete(int gradeID);
        #endregion

        //ApplicantDepartmentTable

        #region "ApplicantDepartmentTable Abstract Methods"
        public abstract IDataReader ApplicantDepartmentTableGet(int deptID);
        public abstract IDataReader ApplicantDepartmentTableList();
        public abstract int ApplicantDepartmentTableAdd(string deptName);
        public abstract void ApplicantDepartmentTableUpdate(int deptID, string deptName);
        public abstract void ApplicantDepartmentTableDelete(int deptID);
        #endregion


        //ApplicantAvailablePositiontable

        #region "ApplicantAvailablePositiontable Abstract Methods"
        public abstract IDataReader ApplicantAvailablePositiontableGet(int positionAppliedforID);
        public abstract IDataReader ApplicantAvailablePositiontableList();
        public abstract IDataReader ApplicantAvailablePositiontableGetByApplicantDepartmentTable(int deptID);
        public abstract int ApplicantAvailablePositiontableAdd(string positionAppliedForName, int deptID_FK);
        public abstract void ApplicantAvailablePositiontableUpdate(int positionAppliedforID, string positionAppliedForName, int deptID_FK);
        public abstract void ApplicantAvailablePositiontableDelete(int positionAppliedforID);
        #endregion

        //ApplicantPersonalDetails

        #region "ApplicantPersonalDetails Abstract Methods"
        public abstract IDataReader ApplicantPersonalDetailsGet(int applicantID);
        public abstract IDataReader ApplicantPersonalDetailsGetByApplicantNum(string applicantNum);

        // get offer details
        public abstract IDataReader ApplicantPersonalDetailsGetOfferDetails(int applicantID);

        public abstract IDataReader ApplicantPersonalDetailsList();

        // list by postion applied for and application status is null(not shortlisted)
        public abstract IDataReader ApplicantPersonalDetailsListByPositionNotShortlisted(string positionAppliedFor);

        //// list by position applied for and Application Status is shortlisted but interviewer decision is null
        public abstract IDataReader ApplicantPersonalDetailsListByPositionShortlisted(string positionAppliedFor);

        // list by postion applied for and both shortlisted and not shortlisted
        public abstract IDataReader ApplicantPersonalDetailsListByPositionAppliedForAll(string positionAppliedFor);

        // /list by position applied for, shortlisted and interviewer decision is hire and not hire(is null)
        public abstract IDataReader ApplicantPersonalDetailsListByPositionHireAndNot(string positionAppliedFor);

        //list by postion applied for and  interviewer decision is hire 
        public abstract IDataReader ApplicantPersonalDetailsListByPositionHire(string positionAppliedFor);

         //list by position applied for and management approved
        public abstract IDataReader ApplicantPersonalDetailsListByPositionApprove(string positionAppliedFor);

        public abstract IDataReader ApplicantManagementApprovedList();
        public abstract IDataReader ApplicantPersonalDetailsAcceptanceAppList();        
        public abstract IDataReader ApplicantPersonalDetailsGetByCountryTable(int countryID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeeLevel(int levelID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeePositionTable(int positionID);
        public abstract IDataReader ApplicantPersonalDetailsGetByEmployeeWorkLocations(int workLocationID);
        public abstract IDataReader ApplicantPersonalDetailsGetByLGATable(int lgaID);
        public abstract IDataReader ApplicantPersonalDetailsGetByStateTable(int stateID);
        public abstract int ApplicantPersonalDetailsAdd(string applicantNum, string DeptAppliedTo, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, string interviwerDecision, string managementDecition, int senID_FK);

        //public abstract int ApplicantPersonalDetailsAdd(string applicantNum, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK, string interviwerDecision, string managementDecition);
        
        public abstract void ApplicantPersonalDetailsUpdate(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK, string interviwerDecision, string managementDecition);
       
        public abstract void ApplicantPersonalDetailsUpdateApplicantNum(int applicantID, string appilcantNum);
        public abstract void ApplicantPersonalDetailsUpdateUpdateUsingApplicantNum(int applicantID, string applicantNum, string positionAppliedFor, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string applicationStatus, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK, string resumptionDate, string interviwerDecision, string managementDecition);
      
        // update application status
        public abstract void ApplicantPersonalDetailsUpdateApplicationStatus(int applicantID, string applicantionStatus);

        // update interviewer decision 
        public abstract void ApplicantPersonalDetailsUpdateInterviewerDecision(int applicantID, int positionApproved_FK, int departmentID_FK, int workLocationID_FK, int levelID_FK, string resumptionDate, string interviewerDecision);
       
        // update management decision
        public abstract void ApplicantPersonalDetailsUpdateManagementDecision(int applicantID, string managementDecision);

         public abstract void ApplicantPersonalDetailsSendingOfferUpdate(int applicantID, int positionApproved_FK, int departmentID_FK, int levelID_FK, int workLocationID_FK);
 
        public abstract void ApplicantPersonalDetailsDelete(int applicantID);
        #endregion


        //ApplicantQualification

        #region "ApplicantQualification Abstract Methods"
        public abstract IDataReader ApplicantQualificationGet(int qualificationID);
        public abstract IDataReader ApplicantQualificationList();
        //public abstract IDataReader EmployeeAppQualificationList();
        public abstract IDataReader ApplicantQualificationGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantQualificationAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantQualificationUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantQualificationDelete(int qualificationID);
        #endregion

        //ApplicantProfQualification


        #region "ApplicantProfQualification Abstract Methods"
        public abstract IDataReader ApplicantProfQualificationGet(int profQualificationID);
        public abstract IDataReader ApplicantProfQualificationList();
        public abstract IDataReader ApplicantProfQualificationGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantProfQualificationAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK);
        public abstract void ApplicantProfQualificationUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK);
        public abstract void ApplicantProfQualificationDelete(int profQualificationID);
        #endregion


        #region "ApplicantWorkExperience Abstract Methods"
        public abstract IDataReader ApplicantWorkExperienceGet(int workExperienceID);
        public abstract IDataReader ApplicantWorkExperienceList();
        public abstract IDataReader ApplicantWorkExperienceGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantWorkExperienceAdd(string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantWorkExperienceUpdate(int workExperienceID, string companyName, string positionHeld, string jobDescriprtion, string salaryReceived, string startYear, string endYear, int applicantID_FK);
        public abstract void ApplicantWorkExperienceDelete(int workExperienceID);
        #endregion



        #region "ApplicantDocument Abstract Methods"
        public abstract IDataReader ApplicantDocumentGet(int documentID);
        public abstract IDataReader ApplicantDocumentList();
        public abstract IDataReader ApplicantDocumentGetByApplicantPersonalDetails(int applicantID);
        public abstract int ApplicantDocumentAdd(string documentType, string documentPath, int applicantID_FK);
        public abstract void ApplicantDocumentUpdate(int documentID, string documentType, string documentPath, int applicantID_FK);
        public abstract void ApplicantDocumentDelete(int documentID);
        #endregion


        #region "EmployeeDepartmentTable Abstract Methods"
        public abstract IDataReader EmployeeDepartmentTableGet(int deptID);
        public abstract IDataReader EmployeeDepartmentTableGetAll();
            
        public abstract IDataReader EmployeeDepartmentTableList();
        public abstract int EmployeeDepartmentTableAdd(string deptName);
        public abstract void EmployeeDepartmentTableUpdate(int deptID, string deptName);
        public abstract void EmployeeDepartmentTableDelete(int deptID);
        #endregion


        //EmployeePositionTable 

        #region "EmployeePositionTable Abstract Methods"
        public abstract IDataReader EmployeePositionTableGet(int positionID);
        public abstract IDataReader EmployeePositionTableList();
        public abstract IDataReader EmployeePositionTableGetByEmployeeDepartmentTable(int deptID);
        public abstract int EmployeePositionTableAdd(string positionName, int deptID_FK);
        public abstract void EmployeePositionTableUpdate(int positionID, string positionName, int deptID_FK);
        public abstract void EmployeePositionTableDelete(int positionID);
        #endregion

        //EmployeeLevel


        #region "EmployeeLevel Abstract Methods"
        public abstract IDataReader EmployeeLevelGet(int levelID);
        public abstract IDataReader EmployeeLevelList();
        public abstract IDataReader EmployeeLevelGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeLevelGetByEmployeePositionTable(int positionID);
        public abstract int EmployeeLevelAdd(string levelName, string salary, string salaryDetails, int deptID_FK, int positionID_FK, string leaveEntitle, string employeeCadre);
        public abstract void EmployeeLevelUpdate(int levelID, string levelName, string salary, string salaryDetails, int deptID_FK, int positionID_FK, string leaveEntitle, string employeeCadre);
        public abstract void EmployeeLevelDelete(int levelID);
        #endregion


        #region "EmployeeWorkLocations Abstract Methods"
        public abstract IDataReader EmployeeWorkLocationsGet(int workLocationID);
        public abstract IDataReader EmployeeWorkLocationsList();
        public abstract int EmployeeWorkLocationsAdd(string locationName, string locationAddress);
        public abstract void EmployeeWorkLocationsUpdate(int workLocationID, string locationName, string locationAddress);
        public abstract void EmployeeWorkLocationsDelete(int workLocationID);
        #endregion


        //ApplicantInterview

        #region "ApplicantInterview Abstract Methods"
        public abstract IDataReader ApplicantInterviewGet(int interviewID);
        public abstract IDataReader ApplicantInterviewList();
        public abstract IDataReader InterviewApprovedApplicantList();
        public abstract IDataReader ApplicantInterviewGetByApplicantRatingKey(int ratingKeyID);
        public abstract int ApplicantInterviewAdd(string interviewer, string interviewDate, int applicantID_FK, string applicantNum, int experience, int education, int positionInterest, int presentation, int problemSolvingSkill, int computerSkill, int jobStability, int otherCriteria, int knowledgeLevel, int positionExcitement, int experienceLevel, int effectiveParticipation, int communicationLevel, int finalListInclusion, string strength, string weakness, string additionalComment, string recommendation, string hODName, string hODRecommendation, string managementRecommendation, int ratingKeyID_FK);
        public abstract void ApplicantInterviewUpdate(int interviewID, string interviewer, string interviewDate, int applicantID_FK, string applicantNum, int experience, int education, int positionInterest, int presentation, int problemSolvingSkill, int computerSkill, int jobStability, int otherCriteria, int knowledgeLevel, int positionExcitement, int experienceLevel, int effectiveParticipation, int communicationLevel, int finalListInclusion, string strength, string weakness, string additionalComment, string recommendation, string hODName, string hODRecommendation, string managementRecommendation, int ratingKeyID_FK);
        public abstract void ApplicantInterviewDelete(int interviewID);
        #endregion

        //EmployeeDetails


        #region "EmployeeDetails Abstract Methods"
        public abstract IDataReader EmployeeDetailsGet(int employeeID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeLevelForLeave(int employeeLevel_FK);
       
        //For printing Employee List

        public abstract IDataReader EmployeeDetailsList();
        public abstract IDataReader EmployeeDetailsListOrderByDeptAndLocation();
        public abstract IDataReader EmployeeDetailsListByDeptAndLocation(int deptID, int workLocationID);
        
        public abstract IDataReader EmployeeDetailsSupAppraisalList();
         public abstract IDataReader EmployeeDetailsHRAppraisalList();
        
        public abstract IDataReader EmployeeDetailsHiredList();
        public abstract IDataReader EmployeeDetailsUnconfirmedList();
        public abstract IDataReader EmployeeDetailsConfirmedEmployeeList();        
        public abstract IDataReader EmployeeDetailsQualifUnApprovedList();
        public abstract IDataReader EmployeeDetailsProfQualifUnApprovedList();
        public abstract IDataReader EmployeeDetailsDocUnApprovedList();
        public abstract IDataReader EmployeeDetailsPromotionList(int deptID);
        public abstract IDataReader EmployeeDetailsSelfAppraisalList();
        
        public abstract IDataReader EmployeeDetailsSupEmpList();

        public abstract IDataReader EmployeeDetailsGetBySupervisor(int supervisorID);
        public abstract IDataReader EmployeeDetailsGetByApplicantPersonalDetails(int applicantID );
        public abstract IDataReader EmployeeDetailsGetByCountryTable(int countryID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeDepartmentTableForPromoHist(int deptID);
        public abstract IDataReader EmployeeDetailsGetByEmpDeptAndLocation(int deptID, int workLocation);        
        public abstract IDataReader EmployeeDetailsGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeLevel(int levelID);
        public abstract IDataReader EmployeeDetailsGetByEmployeePositionTable(int positionID);
        public abstract IDataReader EmployeeDetailsGetByEmployeeWorkLocations(int workLocationID);
        public abstract IDataReader EmployeeDetailsGetByLGATable(int lgaID);
        public abstract IDataReader EmployeeDetailsGetByStateTable(int stateID);
        public abstract IDataReader EmployeeDetailsGetByUsers(int userID);
        public abstract IDataReader EmployeeDetailsGetByUserID(int userID);
        public abstract int EmployeeDetailsAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int hRID, int senID_FK);
         public abstract void EmployeeDetailsUpdate(int employeeID, string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK);
         public abstract void EmployeeDetailsEditBasicInfoUpdate(int employeeID, string title, string firstName, string miiddleName, string lastName, string maritalStatus, string phoneNo, string email, string contactAddress, string religion, string accountName, string accountNo, string bankName);
       public abstract void EmployeeDetailsUpdateEmployeeNum(int employeeID, string employeeNum);
        public abstract void EmployeeDetailsUpdateEmployeeUserID(int employeeID, int employeeUserID_FK);
        public abstract void EmployeeDetailsNextOfKinUpdate(int employeeID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeUserID_FK);
        public abstract void EmployeeDetailsEditNOKUpdate(int employeeID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship);
         public abstract void EmployeeDetailsSpouseUpdate(int employeeID, string spouseNames, string spouseAddress, string spousePhoneNo,string spouseEmail, string spouseOccupation, string spouseEmployerNames, int employeeUserID_FK);

        public abstract void EmployeeDetailsEditSpouseDetailsUpdate(int employeeID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames);
       
         public abstract void EmployeeDetailsRefereeUpdate(int employeeID, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, int employeeUserID_FK);
        public abstract void EmployeeDetailsBankInfoUpdate(int employeeID, string bankName, string accountName, string accountNo, int employeeUserID_FK);
       public abstract void EmployeeDetailsGuarantorUpdate(int employeeID, string guarrantorNames, string guarrantorFormPath, int employeeUserID_FK);
       public abstract void EmployeeDetailsUpdateConfirmation(int employeeID, string confirmationDate, int confirmedBy);
       public abstract void EmployeeDetailsTransferUpdate(int employeeID, int departmentID_FK, int workLocationID_FK, string transferDate, int transferedBy);
       public abstract void EmployeeDetailsPromoUpdate(int employeeID, int employeeLevel_FK, int positionHeld_FK, string promotionDate, int promotedBy, string employeeStatus);
       public abstract void EmployeeDetailsUpdateEmpHOD(int employeeID, int hODID);
       public abstract void EmployeeDetailsUpdateHODNewPositionAsHOD(int employeeID, int positionHeld_FK, int hODID);
       public abstract void EmployeeDetailsUpdateEmpSupervisor(int employeeID, int supervisorID);
        
      public abstract void EmployeeDetailsDelete(int employeeID);

        #endregion


      //EmployeeDetailsLog


      #region "EmployeeDetailsLog Abstract Methods"
      public abstract IDataReader EmployeeDetailsLogGet(int employeeLogID);
      public abstract IDataReader EmployeeDetailsLogGetByEmployeeDetails(int employeeID);

      public abstract IDataReader EmployeeDetailsLogList();
      //public abstract IDataReader EmployeeDetailsListByDeptAndLocation(int deptID, int workLocationID);

      //public abstract IDataReader EmployeeDetailsSupAppraisalList();
      //public abstract IDataReader EmployeeDetailsHRAppraisalList();

      //public abstract IDataReader EmployeeDetailsHiredList();
      //public abstract IDataReader EmployeeDetailsUnconfirmedList();
      //public abstract IDataReader EmployeeDetailsConfirmedEmployeeList();
      //public abstract IDataReader EmployeeDetailsQualifUnApprovedList();
      //public abstract IDataReader EmployeeDetailsProfQualifUnApprovedList();
      //public abstract IDataReader EmployeeDetailsDocUnApprovedList();
      //public abstract IDataReader EmployeeDetailsPromotionList();
      //public abstract IDataReader EmployeeDetailsSelfAppraisalList();

      //public abstract IDataReader EmployeeDetailsSupEmpList();

      public abstract IDataReader EmployeeDetailsLogGetBySupervisor(int supervisorID);
     // public abstract IDataReader EmployeeDetailsLogGetByEmployeeDetails(int employeeID);
      //public abstract IDataReader EmployeeDetailsGetByApplicantPersonalDetails(int supervisorID);
      public abstract IDataReader EmployeeDetailsLogGetByCountryTable(int countryID);
      public abstract IDataReader EmployeeDetailsLogGetByEmployeeDepartmentTable(int deptID);
      //public abstract IDataReader EmployeeDetailsGetByEmpDeptAndLocation(int deptID, int workLocation);
      public abstract IDataReader EmployeeDetailsLogGetByEmployeeDetailsLog(int employeeIDLogID);
      public abstract IDataReader EmployeeDetailsLogGetByEmployeeLevel(int levelID);
      public abstract IDataReader EmployeeDetailsLogGetByEmployeePositionTable(int positionID);
      public abstract IDataReader EmployeeDetailsLogGetByEmployeeWorkLocations(int workLocationID);
      public abstract IDataReader EmployeeDetailsLogGetByLGATable(int lgaID);
      public abstract IDataReader EmployeeDetailsLogGetByStateTable(int stateID);
      public abstract IDataReader EmployeeDetailsLogGetByUsers(int userID);
      public abstract IDataReader EmployeeDetailsLogGetByUserID(int userID);
      public abstract int EmployeeDetailsLogAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string startDate, int applicantID_FK, int employeeUserID_FK, int employeeID_FK, int hRID, int senID_FK);

      //public abstract int EmployeeDetailsLogAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK, string promotionDate, int promotedBy, string transferDate, int transferedBy, int supervisorID, int hRID, int hODID, int empOfficialPosition, int employeeID_FK);

     // public abstract int EmployeeDetailsLogAdd(string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK, int employeeID_FK);
      public abstract void EmployeeDetailsLogUpdate(int employeeLogID, string employeeNum, string title, string firstName, string miiddleName, string lastName, string gender, string dateOfBirth, string age, string maritalStatus, int nationality_FK, int stateOfOrigin_FK, int lGA_FK, string homeTown, string phoneNo, string email, string contactAddress, string religion, string passport, string accountName, string accountNo, string bankName, int department_FK, int positionHeld_FK, int employeeLevel_FK, int workLocation_FK, string confirmationDate, int confirmedBy, string employeeStatus, string startDate, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, string guarrantorNames, string guarrantorFormPath, int applicantID_FK, int employeeUserID_FK, int employeeID_FK);
      public abstract void EmployeeDetailsLogEditBasicInfoUpdate(int employeeLogID, string title, string firstName, string miiddleName, string lastName, string maritalStatus, string phoneNo, string email, string contactAddress, string religion, string accountName, string accountNo, string bankName, int employeeID_FK);
      public abstract void EmployeeDetailsLogUpdateEmployeeNum(int employeeLogID, string employeeNum, int employeeID_FK);
      public abstract void EmployeeDetailsLogUpdateEmployeeUserID(int employeeLogID, int employeeUserID_FK, int employeeID_FK);
      public abstract void EmployeeDetailsLogNextOfKinUpdate(int employeeLogID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeUserID_FK, int employeeID_FK);
      public abstract void EmployeeDetailsLogEditNOKUpdate(int employeeLogID, string nxtOfKinFName, string nxtOfKinMidName, string nxtOfKinLName, string nxtOfKinAddress, string nxtOfKinPhoneNo, string nxtOfKinEmail, string nxtOfKinOccupation, string nxtOfKinRelationship, int employeeID_FK);
      public abstract void EmployeeDetailsLogSpouseUpdate(int employeeLogID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, int employeeUserID_FK, int employeeID_FK);

      public abstract void EmployeeDetailsLogEditSpouseDetailsUpdate(int employeeLogID, string spouseNames, string spouseAddress, string spousePhoneNo, string spouseEmail, string spouseOccupation, string spouseEmployerNames, int employeeID_FK);

      public abstract void EmployeeDetailsLogRefereeUpdate(int employeeLogID, string refree1Names, string refree1Occupation, string refree1PhoneNum, string refree1Email, string refree1ContactAddr, string refree2Names, string refree2Occupation, string refree2PhoneNum, string refree2Email, string refree2ContactAddr, int employeeUserID_FK, int employeeID_FK);
      public abstract void EmployeeDetailsLogBankInfoUpdate(int employeeLogID, string bankName, string accountName, string accountNo, int employeeUserID_FK, int employeeID_FK);
      public abstract void EmployeeDetailsLogGuarantorUpdate(int employeeLogID, string guarrantorNames, string guarrantorFormPath, int employeeUserID_FK, int employeeID_FK);
      public abstract void EmployeeDetailsLogUpdateConfirmation(int employeeID, string confirmationDate, int confirmedBy, int employeeID_FK);
      public abstract void EmployeeDetailsLogTransferUpdate(int employeeLogID, int departmentID_FK, int workLocationID_FK, string transferDate, int transferedBy, int employeeID_FK);
      public abstract void EmployeeDetailsLogPromoUpdate(int employeeLogID, int employeeLevel_FK, int positionHeld_FK, string promotionDate, int promotedBy, string employeeStatus, int employeeID_FK);
      public abstract void EmployeeDetailsLogUpdateEmpHOD(int employeeLogID, int hODID, int employeeID_FK);
      public abstract void EmployeeDetailsLogUpdateHODNewPositionAsHOD(int employeeLogID, int positionHeld_FK, int hODID, int employeeID_FK);
      public abstract void EmployeeDetailsLogUpdateEmpSupervisor(int employeeLogID, int supervisorID, int employeeID_FK);
      public abstract void EmployeeDetailsLogDelete(int employeeLogID);

      #endregion


        //EmployeeQualificationTable

        #region "EmployeeQualificationTable Abstract Methods"
        public abstract IDataReader EmployeeQualificationTableGet(int qualificationID);
        public abstract IDataReader EmployeeQualificationTableGetByEmployeeDetailsForInfo(int employeeID);
        
        public abstract IDataReader EmployeeQualificationTableList();
        public abstract IDataReader EmployeeQualificationTableUnApprovedList();        
        public abstract IDataReader EmployeeQualificationTableGetByApplicantPersonalDetails(int applicantID);
        public abstract IDataReader EmployeeQualificationTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeQualificationUnApprovedGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeQualificationTableApprovedQualifGetByEmployeeDetails(int employeeID);           
        public abstract int EmployeeQualificationTableAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK);
        public abstract int EmployeeQualificationTableNewAdd(string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);
        public abstract void EmployeeQualificationTableUpdate(int qualificationID, string institutionName, string qualificationType, string course, string grade, string startYear, string endYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);
        public abstract void EmployeeQualificationTableEmpIDUpdate(string hrApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);
        public abstract void EmployeeQualificationTableHrApprovalUpdate(int employeeID_FK, string hrApproval);
        public abstract void EmployeeQualificationTableAcceptanceApprovalUpdate(int qualificationID, string hrApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);   
       
        public abstract void EmployeeQualificationTableDelete(int qualificationID);
        #endregion


        //EmployeeProfQualificationTable

        #region "EmployeeProfQualificationTable Abstract Methods"
        public abstract IDataReader EmployeeProfQualificationTableGet(int profQualificationID);
        public abstract IDataReader EmployeeProfQualificationTableGetByEmployeeDetailsForInfo(int profQualificationID);
        
        public abstract IDataReader EmployeeProfQualificationTableList();

       // public abstract IDataReader EmployeeDetailsProfQualifUnApprovedList();          
       public abstract IDataReader EmployeeProfQualificationTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeProfQualificationTableApprovedProfQualifGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeProfQualificationUnApprovedGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeProfQualificationTableGetByApplicantPersonalDetails(int applicantID);
        public abstract int EmployeeProfQualificationTableAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK);
        public abstract int EmployeeProfQualificationTableNewAdd(string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);
        public abstract void EmployeeProfQualificationTableUpdate(int profQualificationID, string certificationName, string certificateNo, string stage, string certYear, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);
        public abstract void EmployeeProfQualificationTableEmpIDUpdate(string hrApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);

        public abstract void EmployeeProfQualificationTableHrApprovalUpdate(int employeeID_FK, string hrApproval);
        public abstract void EmployeeProfQualificationTableAcceptanceApprovalUpdate(int profQualificationID, string hRApproval, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);
        
        public abstract void EmployeeProfQualificationTableDelete(int profQualificationID);
        #endregion

        //EmployeeDocumentTable

        #region "EmployeeDocumentTable Abstract Methods"
        public abstract IDataReader EmployeeDocumentTableGet(int documentID);
        public abstract IDataReader EmployeeDocumentTableGetByEmployeeDetailsForInfo(int employeeID);
        
        public abstract IDataReader EmployeeDocumentTableList();
       // public abstract IDataReader EmployeeDetailsDocUnApprovedList();        
        public abstract IDataReader EmployeeDocumentTableGetByApplicantPersonalDetails(int applicantID);
        public abstract IDataReader EmployeeDocumentTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeDocumentTableApprovedDocGetByEmployeeDetails(int employeeID); 
        public abstract IDataReader EmployeeDocumentUnApprovedGetByEmployeeDetails(int employeeID);
       public abstract int EmployeeDocumentTableAdd(string documentType, string documentPath, int applicantID_FK);
       public abstract int EmployeeDocumentTableNewAdd(string documentType, string documentPath, int applicantID_FK, int employeeID_FK, int employeeLogID_FK);
       public abstract void EmployeeDocumentTableUpdate(int documentID, string documentType, string documentPath, int applicantID_FK, int employeeID_Fk, int employeeLogID_FK);
        public abstract void EmployeeDocumentTableEmpIDUpdate(string hrApproval, int applicantID_FK, int employeeID_Fk, int employeeLogID_FK);
        public abstract void EmployeeDocumentTableHrApprovalUpdate(int employeeID_Fk, string hrApproval);
        public abstract void EmployeeDocumentTableAcceptanceApprovalUpdate(int documentID, string hrApproval, int applicantID_FK, int employeeID_Fk, int employeeLogID_FK);
        
        public abstract void EmployeeDocumentTableDelete(int documentID);
        #endregion


        //EmployeeTrainingTable

        #region "EmployeeTrainingTable Abstract Methods"
        public abstract IDataReader EmployeeTrainingTableGet(int trainingID);
        public abstract IDataReader EmployeeTrainingTableList();
        public abstract IDataReader EmployeeTrainingTableHRAprovalList();        
        public abstract IDataReader EmployeeTrainingTableGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeTrainingTableHRAprovalGetByEmployeeDeptTable(int deptID);        
        public abstract IDataReader EmployeeTrainingTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeTrainingTableGetByEmployeePositionTable(int positionID);
        public abstract int EmployeeTrainingTableAdd(string trainingName, string trainingLocation, string startDate, string endDate, int departmentID_FK, int positionID_FK, int employeeID_FK, int trainingSentBy, string trainingStatus, int trainingApprovedBy);
        public abstract void EmployeeTrainingTableUpdate(int trainingID, string trainingName, string trainingLocation, string startDate, string endDate, int departmentID_FK, int positionID_FK, int employeeID_FK, int trainingSentBy, string trainingStatus, int trainingApprovedBy);
        public abstract void EmployeeTrainingTableHRApprovalUpdate(int trainingID, string trainingStatus, int trainingApprovedBy);
      
        
        public abstract void EmployeeTrainingTableDelete(int trainingID);
        #endregion

        //EmployeeTransferTable


        #region "EmployeeTransferTable Abstract Methods"
        public abstract IDataReader EmployeeTransferTableGet(int transferID);
        public abstract IDataReader EmployeeTransferTableGetByEmployeeDetailsForInfo(int employeeID);
        public abstract IDataReader EmployeeTransferTableList();
        public abstract IDataReader EmployeeTransferTableNewList();
        
        public abstract IDataReader EmployeeTransferTableApprovalNameList(int PrevWorkLocation, int DesireLocation);
        public abstract IDataReader EmployeeTransferTableApprovalNameNewList(int PreviousDept, int PrevWorkLocation, int DesireLocation);
        
        public abstract IDataReader EmployeeTransferTableNewApprovalList(int PreviousDept, int PrevWorkLocation, int DesireLocation);
        
        public abstract IDataReader EmployeeTransferTableApprovalList();
        
        public abstract IDataReader EmployeeTransferTableGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeTransferTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeTransferTableGetByEmployeeWorkLocations(int workLocationID);
        public abstract IDataReader EmployeeTransferTableGetByUsers(int userID);
        public abstract int EmployeeTransferTableAdd(int previousDept, int newDept, int prevWorkLocation, int desireLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy);
        public abstract int EmployeeTransferTableRequestAdd(int previousDept, int newDept, int prevWorkLocation, int DesireLocation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK);
       public abstract void EmployeeTransferTableUpdate(int transferID, int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy);
       public abstract void EmployeeTransferTableUpdateTransferRequest(int transferID, int previousDept, int newDept, int prevWorkLocation, int DesireLocation, string transferType, string transferReason, string requestDate,  int employeeID_FK);
         public abstract void EmployeeTransferTableApprovalUpdate(int transferID,  int newDept, int newWorkLcation,  string approvalStatus, string approveDate, string transferDate, int transferedBy);
       public abstract void EmployeeTransferTableDelete(int transferID);
        #endregion




        //EmployeeTransferTableLog

        #region "EmployeeTransferTableLog Abstract Methods"
        public abstract IDataReader EmployeeTransferTableLogGet(int transferLogID);
        public abstract IDataReader EmployeeTransferTableLogGetByEmployeeTransferTableForInfo(int transferID);
        public abstract IDataReader EmployeeTransferTableLogListEmployeeTransferRecords(int employeeID_FK, int PreviousDept, int NewDept, int PrevWorkLocation, int DesireLocation, int NewWorkLcation);
        public abstract IDataReader EmployeeTransferTableLogList();
        public abstract IDataReader EmployeeTransferTableLogListByEmployeeDetails(int employeeID);
       
        public abstract IDataReader EmployeeTransferTableLogGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeTransferTableLogGetByEmployeeTransferTable(int transferID);
       
        public abstract IDataReader EmployeeTransferTableLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeTransferTableLogGetByEmployeeWorkLocations(int workLocationID);
        public abstract IDataReader EmployeeTransferTableLogGetByUsers(int userID);
        public abstract int EmployeeTransferTableLogAdd(int previousDept, int newDept, int prevWorkLocation, int desireLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy, int transferID_FK);
        public abstract int EmployeeTransferTableLogRequestAdd(int previousDept, int newDept, int prevWorkLocation, int desireLocation, string transferType, string transferReason, string requestDate, int employeeID_FK, int transferID_FK);
        
        public abstract void EmployeeTransferTableLogUpdate(int transferLogID, int previousDept, int newDept, int prevWorkLocation, int newWorkLcation, string transferType, string transferReason, string requestDate, string approvalStatus, string approveDate, string transferDate, int employeeID_FK, int transferedBy, int transferID_FK);
        public abstract void EmployeeTransferTableLogApprovalUpdate(int transferLogID,  int newDept, int newWorkLcation, string approvalStatus, string approveDate, string transferDate, int transferedBy, int transferID_FK);
    
        public abstract void EmployeeTransferTableLogDelete(int transferLogID);
        #endregion



        //Appraisal Module

        #region

        //EmployeeAppraisalTableRatingKey

        #region "EmployeeAppraisalTableRatingKey Abstract Methods"
        public abstract IDataReader EmployeeAppraisalTableRatingKeyGet(int ratingKeyID);
        public abstract IDataReader EmployeeAppraisalTableRatingKeyGetByCompetent(int ratingKeyID);        
        public abstract IDataReader EmployeeAppraisalTableRatingKeyList();
        public abstract int EmployeeAppraisalTableRatingKeyAdd(string ratingDesc, int ratingPoint);
        public abstract void EmployeeAppraisalTableRatingKeyUpdate(int ratingKeyID, string ratingDesc, int ratingPoint);
        public abstract void EmployeeAppraisalTableRatingKeyDelete(int ratingKeyID);
        #endregion

        //EmployeeAppraisalCompetencyTable


        #region "EmployeeAppraisalCompetencyTable Abstract Methods"
        public abstract IDataReader EmployeeAppraisalCompetencyTableGet(int competencyID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableGetByEmpID(int employeeID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableList();
        public abstract IDataReader EmployeeAppraisalCompetencyTableGetByEmployeeAppraisalTable(int appraisalID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableGetByUsers(int userID);
        public abstract int EmployeeAppraisalCompetencyTableAdd(int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int puntPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK);
        public abstract void EmployeeAppraisalCompetencyTableUpdate(int competencyID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int puntPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK);
        public abstract void EmployeeAppraisalCompetencyTableSupFirstUpdate(int competencyID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int puntPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int appraisalID_FK);
       
        public abstract void EmployeeAppraisalCompetencyTableDelete(int competencyID);
        #endregion


        //EmployeeAppraisalCompetencyTableLog


        #region "EmployeeAppraisalCompetencyTableLog Abstract Methods"
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogGet(int competencyLogID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogGetByEmpID(int employeeID);        
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogList();
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalCompetencyTable(int competencyID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogGetByEmployeeAppraisalTable(int appraisalID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogGetByEmpDetails(int employeeID);
     
        
        public abstract IDataReader EmployeeAppraisalCompetencyTableLogGetByUsers(int userID);
        public abstract int EmployeeAppraisalCompetencyTableLogAdd(int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int punPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int competencyID_FK, int sentBy);
        public abstract void EmployeeAppraisalCompetencyTableLogUpdate(int competencyLogID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int punPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int competencyID_FK, int sentBy);
        public abstract void EmployeeAppraisalCompetencyTableLogSupFirstUpdate(int competencyLogID, int quality, int quaPoint, int productivity, int prodPoint, int knoweldge, int knowPoint, int dependability, int dependPoint, int initiative, int initPoint, int judgement, int judPoint, int adaptability, int adaPoint, int interterpersonalRelationship, int interPoint, int puntuality, int punPoint, int communicationSkills, int comPoint, int planning, int planPoint, int leadership, int leadPoint, int team, int teamPoint, int development, int devPoint, int overallPoint, string excelArea, string areaThatNeedsImprovement, string stepsToTake, string areaThatNeedsAssistance, int competencyID_FK, int sentBy);
       
        public abstract void EmployeeAppraisalCompetencyTableLogDelete(int competencyLogID);
        #endregion


        //EmployeeApprasalTableGoal
        

        #region "EmployeeApprasalTableGoal Abstract Methods"

       public abstract IDataReader EmployeeApprasalTableGoalGet(int goalID);
       public abstract IDataReader EmployeeApprasalTableGoalGetByEmpDetails(int employeeID);
        
        public abstract IDataReader EmployeeApprasalTableGoalList();

        public abstract IDataReader EmployeeApprasalTableGoalGetByArray(int goalID);
        public abstract IDataReader EmployeeApprasalTableGoalGetByEmployeeAppraisalTable(int appraisalID);
        public abstract IDataReader EmployeeApprasalTableGoalGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeApprasalTableGoalGetByUsers(int userID);
        public abstract int EmployeeApprasalTableGoalAdd(string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK);
        public abstract void EmployeeApprasalTableGoalUpdate(int goalID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK);
        public abstract void EmployeeApprasalTableGoalSupUpdate(int goalID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int appraisalID_FK);
      
        public abstract void EmployeeApprasalTableGoalDelete(int goalID);
        #endregion


        //EmployeeApprasalTableGoalLog
       
        #region "EmployeeApprasalTableGoalLog Abstract Methods"
        public abstract IDataReader EmployeeApprasalTableGoalLogGet(int goalLogID);
        public abstract IDataReader EmployeeApprasalTableGoalLogList();
        public abstract IDataReader EmployeeApprasalTableGoalLogGetByEmployeeAppraisalTable(int appraisalID);
        public abstract IDataReader EmployeeApprasalTableGoalLogGetByEmployeeApprasalTableGoal(int goalID);
        public abstract IDataReader EmployeeApprasalTableGoalLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeApprasalTableGoalLogEmpGetByEmpID(int employeeID);
         public abstract IDataReader EmployeeApprasalTableGoalLogSupGetByEmpID(int employeeID);        
        public abstract IDataReader EmployeeApprasalTableGoalLogGetByUsers(int userID);
        public abstract int EmployeeApprasalTableGoalLogAdd(string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy);
        public abstract void EmployeeApprasalTableGoalLogUpdate(int goalLogID, string goalDesc, string goalObjectives, int goalEvaPoint, string goalCompletetiondate, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int goalID_FK, int sentBy);
        public abstract void EmployeeApprasalTableGoalLogGoalIDUpdate(int goalLogID, int goalID_FK);
       public abstract void EmployeeApprasalTableGoalLogDelete(int goalLogID);
        #endregion


        //EmployeeAppraisalTable


        #region "EmployeeAppraisalTable Abstract Methods"
        public abstract IDataReader EmployeeAppraisalTableGet(int appraisalID);
        public abstract IDataReader EmployeeAppraisalTableListInfo(int appraisalID, string EmployeeNum, int AppraisalScore, int PromoExamScore, int TotalAppraisalScore);
        
        public abstract IDataReader EmployeeAppraisalTableGetByEmpID(int employeeID);        
        public abstract IDataReader EmployeeAppraisalTableList();
        public abstract IDataReader EmployeeAppraisalTableListForChart();
        public abstract IDataReader EmployeeAppraisalTableListForGoogleChart();
        public abstract IDataReader EmployeeAppraisalTableListForColumnChart();
        
        public abstract IDataReader EmployeeAppraisalTableManagementApprovalList();        
        public abstract IDataReader EmployeeAppraisalTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeAppraisalTableGetByUsers(int userID);
        public abstract int EmployeeAppraisalTableAdd(string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK);
        public abstract int EmployeeAppraisalTableEmpAdd(string employeeNum, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string empAppraisalDate, int employeeID_FK);
        public abstract void EmployeeAppraisalTableUpdate(int appraisalID, string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK);
       
       public abstract void EmployeeAppraisalTableAppraisalScoreUpdate(int appraisalID, int appraisalScore);
       public abstract void EmployeeAppraisalTableSupAppraisalScoreUpdate(int appraisalID, int appraisalScore, string supComment, string promoRecommendation, int supervisorID_FK);

       public abstract void EmployeeAppraisalTableHRAppraisalScoreUpdate(int appraisalID, int promoExamScore, int totalAppraisalScore, string appraisalStatus, string hRAppraisalDate, string hRromoRecommendation, string hRComment, int employeeID_FK, int hRID_FK);
       
        public abstract void EmployeeAppraisalTableSupFirstUpdate(int appraisalID, string totalPoint,  string appraisalStatus, string supAppraisalDate);
         public abstract void EmployeeAppraisalTableSupAppraiseUpdate(int appraisalID, int promoExamScore, int totalAppraisalScore, string promoRecommendation, string supComment);
         public abstract void EmployeeAppraisalTableManagementDecisionUpdate(int appraisalID, string managementDecision, string managementDecisionDate);
         
       public abstract void EmployeeAppraisalTableDelete(int appraisalID);
        #endregion


        //EmployeeAppraisalTableLog

        #region "EmployeeAppraisalTableLog Abstract Methods"
        public abstract IDataReader EmployeeAppraisalTableLogGet(int appraisalLogID);
        public abstract IDataReader EmployeeAppraisalTableLogGetByEmpID(int employeeID);
       // public abstract IDataReader EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID(int employeeID);         
        public abstract IDataReader EmployeeAppraisalTableLogList();
        public abstract IDataReader EmployeeAppraisalTableLogGetByEmployeeAppraisalTable(int appraisalID);
        public abstract IDataReader EmployeeAppraisalTableLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeAppraisalTableLogGetEmpAppraisalDetailsByEmpID(int employeeID);
        public abstract IDataReader EmployeeAppraisalTableLogGetSupAppraisalDetailsByEmpID(int employeeID);      
        public abstract IDataReader EmployeeAppraisalTableLogGetByUsers(int userID);
        public abstract int EmployeeAppraisalTableLogAdd(string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy);
        public abstract int EmployeeAppraisalTableLogEmpAdd(string employeeNum, int appraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string empAppraisalDate, int employeeID_FK, int appraisalID_FK, int sentBy);
        public abstract int EmployeeAppraisalTableLogSupEmpAdd(string employeeNum, int appraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string SupAppraisalDate, string supComment, int employeeID_FK, int supervisorID_FK, int appraisalID_FK, int sentBy);
        public abstract int EmployeeAppraisalTableLogHREmpAdd(string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRPromoRecommendation, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy);

        public abstract void EmployeeAppraisalTableLogUpdate(int appraisalLogID, string employeeNum, int appraisalScore, int promoExamScore, int totalAppraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string promoRecommendation, string empAppraisalDate, string supAppraisalDate, string hrAppraisalDate, string supComment, string hRComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy);
        public abstract void EmployeeAppraisalTableLogAppraisalScoreUpdate(int appraisalLogID, int appraisalScore);
        public abstract void EmployeeAppraisalTableLogSupFirstUpdate(int appraisalLogID, string employeeNum, int appraisalScore, string totalPoint, string evaPeriod, string aprpraisalStartYear, string appraisalStatus, string empAppraisalDate, string supAppraisalDate, string supComment, int employeeID_FK, int supervisorID_FK, int hRID_FK, int appraisalID_FK, int sentBy);
        public abstract void EmployeeAppraisalTableLogSupAppraiseUpdate( int appraisalID_FK, int promoExamScore, int totalAppraisalScore, string promoRecommendation, string supComment);
        public abstract void EmployeeAppraisalTableLogManagementDecisionUpdate(int appraisalLogID, int appraisalID_FK, string managementDecision, string managementDecsionDate);
      
        
        public abstract void EmployeeAppraisalTableLogDelete(int appraisalLogID);
        #endregion

#endregion



        //EmployeePromotionTable


        #region "EmployeePromotionTable Abstract Methods"
        public abstract IDataReader EmployeePromotionTableGet(int promotionID);
        public abstract IDataReader EmployeePromotionTableList();
        public abstract IDataReader EmployeePromotionTableListByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeePromotionTablePromoHistList(int PreDept, int NewDept, int PreviousPosition, int NewPosition, int PreviousLevel, int NewLevel);
        
        public abstract IDataReader EmployeePromotionTableGetByEmployeeAppraisalTable(int appraisalID);
        public abstract IDataReader EmployeePromotionTableGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeePromotionTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeePromotionTableGetByEmployeeLevel(int levelID);
        public abstract IDataReader EmployeePromotionTableGetByEmployeePositionTable(int positionID);
        public abstract IDataReader EmployeePromotionTableGetByUsers(int userID);
        public abstract int EmployeePromotionTableAdd(int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK);
        public abstract void EmployeePromotionTableUpdate(int promotionID, int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK);
        public abstract void EmployeePromotionTableDelete(int promotionID);
        #endregion



        //EmployeePromotionTableLog

        #region "EmployeePromotionTableLog Abstract Methods"
        public abstract IDataReader EmployeePromotionTableLogGet(int promotionLogID);
        public abstract IDataReader EmployeePromotionTableLogList();
        public abstract IDataReader EmployeePromotionTableLogGetByEmployeeAppraisalTable(int appraisalID);
        public abstract IDataReader EmployeePromotionTableLogGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeePromotionTableLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeePromotionTableLogGetByEmployeeLevel(int levelID);
        public abstract IDataReader EmployeePromotionTableLogGetByEmployeePositionTable(int positionID);
        public abstract IDataReader EmployeePromotionTableLogGetByEmployeePromotionTable(int promotionID);
        public abstract IDataReader EmployeePromotionTableLogGetByUsers(int userID);
        public abstract int EmployeePromotionTableLogAdd(int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK, int promotionID_FK);
        public abstract void EmployeePromotionTableLogUpdate(int promotionLogID, int previousLevel, int newLevel, int preDept, int previousPosition, int newDept, int newPosition, int apprasialScore, int promoExamScore, int totalAppraisalScore, string promotedDate, int promotedBy, int employeeID_FK, int apprasialID_FK, int promotionID_FK);
        public abstract void EmployeePromotionTableLogDelete(int promotionLogID);
        #endregion

        

        //EmployeeTypeOfLeaveTable
        #region "EmployeeTypeOfLeaveTable Abstract Methods"
        public abstract IDataReader EmployeeTypeOfLeaveTableGet(int leaveTypeID);
        public abstract IDataReader EmployeeTypeOfLeaveTableList();
        public abstract int EmployeeTypeOfLeaveTableAdd(string leaveTypeName);
        public abstract void EmployeeTypeOfLeaveTableUpdate(int leaveTypeID, string leaveTypeName);
        public abstract void EmployeeTypeOfLeaveTableDelete(int leaveTypeID);
        #endregion

        
        //EmployeeLeaveTable


        #region "EmployeeLeaveTable Abstract Methods"
        public abstract IDataReader EmployeeLeaveTableGet(int leaveID);

        // Get leave details of an employee
        public abstract IDataReader EmployeeLeaveTableGetForAnEmployee(int employeeID);
        public abstract IDataReader EmployeeLeaveTableList();
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeLevel(int levelID);
        public abstract IDataReader EmployeeLeaveTableGetByEmployeeTypeOfLeaveTable(int leaveTypeID);
        public abstract IDataReader EmployeeLeaveTableGetByUsers(int userID);
        public abstract int EmployeeLeaveTableAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK);


        // Saving employee leave application 
        public abstract int EmployeeLeaveTableAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThresholdBeforeApplication, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK);

        public abstract void EmployeeLeaveTableUpdate(int leaveID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason,  int dept_FK, int employeeID_FK);

        // update employee application
        public abstract void EmployeeLeaveTableUpdateLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int levelID_FK, string leaveThresholdBeforeApplication, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK);

        public abstract void EmployeeLeaveTableUpdateLeaveApprovalORDisapproval(int leaveID, string leaveStatus, int leaveGrantedBy, string dateGranted, string leaveThresholdBeforeApplication, string leaveThreshold, string reasonForDisapproval, int employeeID_FK);
                
        public abstract void EmployeeLeaveTableDelete(int leaveID);
        #endregion



        //EmployeeLeaveTableLog
        #region "EmployeeLeaveTableLog Abstract Methods"
        public abstract IDataReader EmployeeLeaveTableLogGet(int leaveLogID);
        public abstract IDataReader EmployeeLeaveTableLogList();
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeDepartmentTable(int deptID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeLeaveTable(int leaveID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeLevel(int levelID);
        public abstract IDataReader EmployeeLeaveTableLogGetByEmployeeTypeOfLeaveTable(int leaveTypeID);
        public abstract IDataReader EmployeeLeaveTableLogGetByUsers(int userID);
        public abstract int EmployeeLeaveTableLogAdd(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, int dept_FK, int employeeID_FK, int leaveID_FK);

        // Saving employee leave application  in log table
        public abstract int EmployeeLeaveTableLogAddLeaveApplication(int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThresholdBeforeApplication, string leaveThreshold, string dateApplied, int dept_FK, int employeeID_FK, int leaveID_FK);
        public abstract void EmployeeLeaveTableLogUpdate(int leaveLogID, int leaveType_FK, string leaveDescription, string startDate, string endDate, string duration, int level_FK, string leaveThreshold, string dateApplied, string leaveStatus, int leaveGrantedBy, string dateGranted, string approveOrDisapproveReason, string reasonForDisapproval, int dept_FK, int employeeID_FK, int leaveID_FK);

        public abstract void EmployeeLeaveTableLogUpdateLeaveApprovalORDisapproval(int leaveLogID, string leaveStatus, int leaveGrantedBy, string dateGranted, string leaveThresholdBeforeApplication, string leaveThreshold, string reasonForDisapproval, int employeeID_FK, int leaveID_FK);
        public abstract void EmployeeLeaveTableLogDelete(int leaveLogID);
        #endregion

        //EmployeeDisciplineTable

        #region "EmployeeDisciplineTable Abstract Methods"
        public abstract IDataReader EmployeeDisciplineTableGet(int disciplineID);
        public abstract IDataReader EmployeeDisciplineTableList();
        public abstract int EmployeeDisciplineTableAdd(string discplineDescription);
        public abstract void EmployeeDisciplineTableUpdate(int disciplineID, string discplineDescription);
        public abstract void EmployeeDisciplineTableDelete(int disciplineID);
        #endregion


        // EmployeeQueryTable

        #region "EmployeeQueryTable Abstract Methods"
        public abstract IDataReader EmployeeQueryTableGet(int queryID);
        public abstract IDataReader EmployeeQueryTableList();
        public abstract IDataReader EmployeeQueryTableGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeQueryTableGetByUsers(int userID);
        public abstract int EmployeeQueryTableAdd(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);

        // sending query
        public abstract int EmployeeQueryTableAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter);

        public abstract void EmployeeQueryTableUpdate(int queryID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);

        // update query response
        public abstract void EmployeeQueryTableUpdateQueryResponse(int queryID, string employeeResponse, string responseDate, string empResponseLetter);

        //update query discipline
        public abstract void EmployeeQueryTableUpdateQueryDiscipline(int queryID, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);
        public abstract void EmployeeQueryTableUpdateQueryDisciplineSuspention(int queryID, int discipliineType_FK, string suspentionStartDate, string suspentionEndDate, string suspentionDuration, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy);
        public abstract void EmployeeQueryTableDelete(int queryID);
        #endregion


        //EmployeeQueryTableLog


        #region "EmployeeQueryTableLog Abstract Methods"
        public abstract IDataReader EmployeeQueryTableLogGet(int queryLogID);
        public abstract IDataReader EmployeeQueryTableLogGetByEmpQuery(int queryID);        
        public abstract IDataReader EmployeeQueryTableLogList();
        public abstract IDataReader EmployeeQueryTableLogGetByEmployeeDetails(int employeeID);
        public abstract IDataReader EmployeeQueryTableLogGetByEmployeeQueryTable(int queryID);
        public abstract IDataReader EmployeeQueryTableLogGetByUsers(int userID);
        public abstract int EmployeeQueryTableLogAdd(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK);
        // sending query
        public abstract int EmployeeQueryTableLogAddQuery(string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, int queryID_FK);
        
        public abstract void EmployeeQueryTableLogUpdate(int queryLogID, string queryTitle, string description, int queryReceivedBy, string issueDate, int queryIssuedBy, string queryLetter, string employeeResponse, string responseDate, string empResponseLetter, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK);
        // update query response
        public abstract void EmployeeQueryTableLogUpdateQueryResponse(int queryLogID, string employeeResponse, string responseDate, string empResponseLetter, int queryID_FK);

        //update query discipline
        public abstract void EmployeeQueryTableLogUpdateQueryDiscipline(int queryLogID, int discipliineType_FK, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK);
        public abstract void EmployeeQueryTableLogUpdateQueryDisciplineSuspention(int queryLogID, int discipliineType_FK, string suspentionStartDate, string suspentionEndDate, string suspentionDuration, string disciplineDetails, string disciplineLetter, string disciplineDate, int disciplinedBy, int queryID_FK);
        
        
        public abstract void EmployeeQueryTableLogDelete(int queryLogID);
        #endregion





       
    }
}