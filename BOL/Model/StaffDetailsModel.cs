using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class EmployeeStaffDetails_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The FullName field is required")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "The Designation field is required")]
        public string? Designation { get; set; }
        [Required(ErrorMessage = "The Qualification field is required")]
        public string? Qualification { get; set; }
        [Required(ErrorMessage = "The RegistrationNumber field is required")]
        public string? RegistrationNumber { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class EmployeeStaffDetails_Delete_Model
    {
        [Required(ErrorMessage = "The EmployeeStaffDetailsID field is required")]
        public int EmployeeStaffDetailsID { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class EmployeeStaffDetails_Model
    {
        public int EmployeeStaffID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? FullName { get; set; }
        public string? Designation { get; set; }
        public string? Qualification { get; set; }
        public string? MedicalCouncilRegistrationNumber { get; set; }
        public int M_UserID { get; set; }
    }
    public class PhysiciansSurgeonsDetails_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The FullName field is required")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "The Designation field is required")]
        public string? Designation { get; set; }
        [Required(ErrorMessage = "The Qualification field is required")]
        public string? Qualification { get; set; }
        [Required(ErrorMessage = "The RegistrationNumber field is required")]
        public string? RegistrationNumber { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class PhysiciansSurgeonsDetails_Delete_Model
    {
        [Required(ErrorMessage = "The PhysiciansSurgeonsID field is required")]
        public int PhysiciansSurgeonsID { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }

    }
    public class PhysiciansSurgeonsDetails_Model
    {
        public int PhysiciansSurgeonsID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? FullName { get; set; }
        public string? Designation { get; set; }
        public string? Qualification { get; set; }
        public string? RegistrationNumber { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
    public class QualifiedNurseDetails_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The FullName field is required")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "The Designation field is required")]
        public string? Designation { get; set; }
        [Required(ErrorMessage = "The M_QualificationID field is required")]
        public int M_QualificationID { get; set; }
        [Required(ErrorMessage = "The RegistrationNumber field is required")]
        public string? RegistrationNumber { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class QualifiedNurseDetails_Delete_Model
    {
        [Required(ErrorMessage = "The QualifiedNurseID field is required")]
        public int QualifiedNurseID { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class QualifiedNurseDetails_Model
    {
        public int QualifiedNurseID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? FullName { get; set; }
        public string? Designation { get; set; }
        public int M_QualificationID { get; set; }
        public string? Qualification { get; set; }
        public string? RegistrationNumber { get; set; }
        public int M_UserID { get; set; }
    }
    public class QualifiedNurse_Midwife_Insert
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The FullName field is required")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "The Designation field is required")]
        public string? Designation { get; set; }
        [Required(ErrorMessage = "The Qualification field is required")]
        public string? Qualification { get; set; }
        [Required(ErrorMessage = "The RegistrationNumber field is required")]
        public string? RegistrationNumber { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class QualifiedNurse_Midwife_Delete
    {
        [Required(ErrorMessage = "The Qualified_Nurse_MidwifeID field is required")]
        public int Qualified_Nurse_MidwifeID { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class QualifiedNurse_Midwife_Model
    {
        public int QualifiedNurse_MidwifeID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? FullName { get; set; }
        public string? Designation { get; set; }
        public string? Qualification { get; set; }
        public string? RegistrationNumber { get; set; }
        public int M_UserID { get; set; }
    }
    public class ForeignStaff_Model
    {
        public int ForeignStaffID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? FullName { get; set; }
        public string? Designation { get; set; }
        public string? Qualification { get; set; }
        public string? RegistrationNumber { get; set; }
        public int M_UserID { get; set; }
    }
    public class ForeignStaff_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The FullName field is required")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "The Designation field is required")]
        public string? Designation { get; set; }

        [Required(ErrorMessage = "The Qualification field is required")]
        public string? Qualification { get; set; }

        [Required(ErrorMessage = "The Foreign_CouncilRegistrationNumber field is required")]
        public string? Foreign_CouncilRegistrationNumber { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class ForeignStaff_Delete_Model
    {
        [Required(ErrorMessage = "The ForeignStaffID field is required")]
        public int ForeignStaffID { get; set; }
        
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    } 
    public class Staff_Update_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }       
        public string PlaceNursingStaff { get; set; }
        [Required(ErrorMessage = "The TotalQualifiedStaff field is required")]
        public int QualifiedNurseStaff_M_IndicatorID { get; set; }
        [Required(ErrorMessage = "The TotalQualifiedStaff field is required")]
        public int TotalQualifiedStaff { get; set; }
        [Required(ErrorMessage = "The TotalNonQualifiedStaff field is required")]
        public int TotalNonQualifiedStaff { get; set; }
        [Required(ErrorMessage = "The TotalGNMQualifiedStaff field is required")]
        public int TotalGNMQualifiedStaff { get; set; }
        [Required(ErrorMessage = "The TotalANMQualifiedStaff field is required")]
        public int TotalANMQualifiedStaff { get; set; }
        [Required(ErrorMessage = "The QualifiedNurse_Midwife_M_IndicatorID field is required")]
        public int QualifiedNurse_Midwife_M_IndicatorID { get; set; }
        [Required(ErrorMessage = "The UnqualifiedNurse_Midwife_M_IndicatorID field is required")]
        public int UnqualifiedNurse_Midwife_M_IndicatorID { get; set; }

        public int Unregistered_Midwife_M_IndicatorID { get; set; }

        [Required(ErrorMessage = "The Foreign_Staff_M_IndiatorID field is required")]
        public int Foreign_Staff_M_IndiatorID { get; set; }
        [Required(ErrorMessage = "The Campus_Chemist_Shop_M_IndicatorID field is required")]
        public int Campus_Chemist_Shop_M_IndicatorID { get; set; }       
        public string? ChemistShopName { get; set; }      
        public string? LicenseNoof_Chemist_Shop { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Staff_Model
    {
        public int M_ApplicantRegisterID { get; set; }
        public string? PlaceNursingStaff { get; set; }
        public int QualifiedNurseStaff_M_IndicatorID { get; set; }
        public string? QualifiedNurseStaff { get; set; }
        public int TotalQualifiedStaff { get; set; }
        public int TotalNonQualifiedStaff { get; set; }
        public int TotalGNMQualifiedStaff { get; set; }
        public int TotalANMQualifiedStaff { get; set; }
        public int QualifiedNurse_Midwife_M_IndicatorID { get; set; }
        public string? QualifiedNurseMidwife { get; set; }
        public int UnqualifiedNurse_Midwife_M_IndicatorID { get; set; }
        public string? UnqualifiedNurseMidwife { get; set; }
        public int Unregistered_Midwife_M_IndicatorID { get; set; }
        public string? Unregistered_Midwife_M_Indicator { get; set; }
        public int Foreign_Staff_M_IndiatorID { get; set; }
        public string? ForeignStaff { get; set; }
        public int Campus_Chemist_Shop_M_IndicatorID { get; set; }
        public string? Campus_Chemist_Shop_M_Indicator { get; set; }
        public string? ChemistShopName { get; set; }
        public string? LicenseNoof_Chemist_Shop { get; set; }
        public int M_UserID { get; set; }
    }
}
