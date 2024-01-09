using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class Dashboard_Model
    {
    }
    public class Track_View_Grid_Model
    {
        public int RowNum { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public int M_FinancialYearID { get; set; }
        public int M_MonthID { get; set; }
        public DateTime AppliedDate { get; set; }
        public int ApplicationType_M_IndicatorID { get; set; }
        public string? ApplicationType_M_Indicator { get; set; }
        public string? ApplicantCode { get; set; }
        public string? ApplicantName { get; set; }
        public int M_AreaTypeID { get; set; }
        public string? AreaTypeName { get; set; }
        public int M_Area_Wise_DistrictID { get; set; }
        public string? AreaName { get; set; }
        public int To_M_StatusID { get; set; }
        public string? M_StatusName { get; set; }
        public int Payment_M_StatusID { get; set; }
        public string? Payment_M_StatusName { get; set; }
        public int M_UserID { get; set; }
    }
    public class MainForm_Model
    {
        public int M_ApplicantRegisterID { get; set; }
        public int M_FinancialYearID { get; set; }
        public int M_MonthID { get; set; }
        public int ApplicantType_M_IndicatorID { get; set; }
        public string? ApplicantType_M_Indicator { get; set; }
        public string? ApplicantCode { get; set; }
        public string? ApplicantName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? ApplicantQualification { get; set; }
        public int M_AreaTypeID { get; set; }
        public string? M_AreaTypeName { get; set; }
        public int Nationality_M_IndicatorID { get; set; }
        public string? Nationality_M_Indicator { get; set; }
        public string? FullAddress { get; set; }
        public string? SigningName { get; set; }
        public int M_Signing_Authority_DesignationID { get; set; }
        public string? M_Signing_Authority_Designation { get; set; }
        public string? AadhaarCardNo { get; set; }
        public string? NursingHomeWithSpeciality { get; set; }
        public int M_InstitutionsTypeID { get; set; }
        public string? M_InstitutionsType { get; set; }
        public int CollectionCenterAvailable_M_IndicatorID { get; set; }
        public string? CollectionCenterAvailable_M_Indicator { get; set; }
        public string? NursingHome_Establishment { get; set; }
        public string? FirmCompany { get; set; }
        public string? Website { get; set; }
        public DateTime DateofEstablishment { get; set; }
        public int Specialty_M_IndicatorID { get; set; }
        public string? Specialty_M_Indicator { get; set; }
        public string? Nursing_HouseNo { get; set; }
        public string? Nursing_Area { get; set; }
        public string? Nursing_City { get; set; }
        public string? Nursing_Pinecode { get; set; }
        public int Nursing_M_DistrictID { get; set; }
        public string? Nursing_M_DistrictName { get; set; }
        public int Nursing_M_TalukaID { get; set; }
        public string? Nursing_M_TalukaName { get; set; }
        public string? NursingHome_Description { get; set; }
        public int NursingHome_M_IndicatorID { get; set; }
        public string? NursingHome_M_Indicator { get; set; }
        public int TotalBeds_NoMaternityBeds { get; set; }
        public int TotalBeds_ICUBeds_Adult { get; set; }
        public int TotalBeds_ICU_Beds_Paed { get; set; }
        public int TotalBeds_Other_Beds { get; set; }
        public int ArrangeImmunizationEmp_M_IndicatorID { get; set; }
        public string? ImmunizationEmp_M_Indicator { get; set; }
        public int MedicalCheckUp_M_IndicatorID { get; set; }
        public string? MedicalCheckUp_M_Indicator { get; set; }
        public string? MedicalCheckUp_InMonth { get; set; }
        public int NursingHomeLandDetails_M_IndicatorID { get; set; }
        public string? NursingHomeLandDetails_M_Indicator { get; set; }
        public string? NursingHome_Purposes { get; set; }
        public int M_Food_StoreID { get; set; }
        public string? M_Food_Store { get; set; }
        public int M_Food_ServiceID { get; set; }
        public string? M_Food_Service { get; set; }
        public int TotalQualifiedStaff { get; set; }
        public int TotalNonQualifiedStaff { get; set; }
        public int TotalGNMQualifiedStaff { get; set; }
        public int TotalANMQualifiedStaff { get; set; }
        public string? NursingStaffAccomodated { get; set; }
        public int QualifiedNurseStaff_M_IndicatorID { get; set; }
        public string? QualifiedNurseStaff { get; set; }
        public int QualifiedNurse_Midwife_M_IndicatorID { get; set; }
        public string? QualifiedNurseMidwife { get; set; }
        public int Unregistered_Midwife_M_IndicatorID { get; set; }
        public string? Unregistered_Midwife_M_Indicator { get; set; }
        public int Foreign_Staff_M_IndiatorID { get; set; }
        public string? ForeignStaff { get; set; }
        public int Campus_Chemist_Shop_M_IndicatorID { get; set; }
        public string? Campus_Chemist_Shop_M_Indicator { get; set; }
        public string? ChemistShopName { get; set; }
        public string? LicenseNoof_Chemist_Shop { get; set; }
        public int M_StatusID { get; set; }
        public string? M_StatusName { get; set; }
        public int M_UserID { get; set; }
    }
    public class ApplicationSubmit_Responce_model
    {
        public string? ApplicantCode { get; set; }

        public string? ApplicantResponse { get; set; }
    }

    public class MainForm_Document_Model
    {
        public int M_ApplicantRegisterID { get; set; }
        public int M_ApplicantRegister_DocumentID { get; set; }
        public int M_DocumentID { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentPath { get; set; }
        public int M_UserID { get; set; }
    }
}
