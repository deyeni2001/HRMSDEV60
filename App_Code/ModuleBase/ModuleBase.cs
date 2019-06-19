using System;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.UI;
using DotNetNuke.Entities.Modules;
using ola.HRMangmntSyst;


namespace ola.ModuleBase
{
    /// <summary>
    /// Summary description for ModuleBase
    /// </summary>
    public class ModuleBase : PortalModuleBase
    {
        EmployeeDetailsInfo empInfo = new EmployeeDetailsInfo();

        EmployeeDetailsInfo empDetailsNOK = new EmployeeDetailsInfo();

        EmployeeDetailsInfo empDetailsReferee = new EmployeeDetailsInfo();
        EmployeeDetailsInfo empDetailsBankInfo = new EmployeeDetailsInfo();
        EmployeeDetailsInfo empDetailsGuarrantor = new EmployeeDetailsInfo();


        EmployeeDetailsLogInfo empLogInfo = new EmployeeDetailsLogInfo();
        // Get EmpDetails

        #region

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EmployeeDetailsInfo CurrentEmployeeDetail
        {
            get
            {
                try
                {
                    return (new EmployeeDetailsController()).GetByUserID(UserId);
                }
                catch (Exception ex)
                {
                    return null;
                }
                return null;
            }
        }
        #endregion

        //#region "EmployeeDetailsLog"

        //[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public EmployeeDetailsLogInfo CurrentEmployeeDetailLog
        //{
        //    get
        //    {
        //        try
        //        {
        //            return (new EmployeeDetailsLogController()).GetByUserID(UserId);
        //        }
        //        catch (Exception ex)
        //        {
        //            return null;
        //        }
        //        return null;
        //    }
        //}
        //#endregion


        //Update Spouse

        #region

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public void CurrentEmployeeDetail2(EmployeeDetailsInfo eminfo)
        {
            try
            {
                (new EmployeeDetailsController()).SpouseUpdate(eminfo);
                return;
            }



            catch (Exception ex)
            {

            }
            return;

        }

        #endregion

        //Update NOK

        #region

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public void CurrentEmployeeDetailNOK(EmployeeDetailsInfo empDetailsNOK)
        {
            try
            {
                (new EmployeeDetailsController()).NextOfKinUpdate(empDetailsNOK);
                return;
            }

            catch (Exception ex)
            {

            }
            return;

        }

        #endregion


        //Update Referee

        #region

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public void CurrentEmployeeDetailReferee(EmployeeDetailsInfo empDetailsReferee)
        {
            try
            {
                (new EmployeeDetailsController()).RefereeUpdate(empDetailsReferee);
                return;
            }

            catch (Exception ex)
            {

            }
            return;

        }

        #endregion

        #region

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public void CurrentEmployeeDetailBankInfo(EmployeeDetailsInfo empDetailsBankInfo)
        {
            try
            {
                (new EmployeeDetailsController()).BankInfoUpdate(empDetailsBankInfo);
                return;
            }

            catch (Exception ex)
            {

            }
            return;

        }

        #endregion


        #region

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public void CurrentEmployeeDetailGuarrantor(EmployeeDetailsInfo empDetailsGuarrantor)
        {
            try
            {
                (new EmployeeDetailsController()).GuarantorUpdate(empDetailsGuarrantor);

                return;
            }

            catch (Exception ex)
            {

            }
            return;

        }

        #endregion

        //Update Qualifications

      //  #region

        //[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public void CurrentEmployeeDetailQualification(EmployeeProfQualificationTableInfo empDetailsQualif)
        //{
        //    try
        //    {
        //        (new EmployeeQualificationTableController()).EmpIDUpdate(empDetailsQualif);

        //        return;
        //    }

        //    catch (Exception ex)
        //    {

        //    }
        //    return;

        //}

        //#endregion


    }
}
