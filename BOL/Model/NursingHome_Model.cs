using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class NursingHome_Model
    {
        public int M_ApplicantRegisterID { get; set; }
        public string? NursingHomeWithSpeciality { get; set; }
        public int GovernmentSchema_M_IndicatorID { get; set; }
        public string? GovernmentSchema { get; set; }
        public int M_InstitutionsTypeID { get; set; }
        public string? M_SubInstitutionsTypeID { get; set; }
        public int CollectionCenterAvailable_M_IndicatorID { get; set; }
        public string? FirmCompany { get; set; }
        public string? Website { get; set; }
        public DateTime DateofEstablishment { get; set; }
        public int Specialty_M_IndicatorID { get; set; }
        public string? Nursing_HouseNo { get; set; }
        public string? Nursing_Area { get; set; }
        public string? Nursing_City { get; set; }
        public int Nursing_M_DistrictID { get; set; }
        public string? DistrictName { get; set; }
        public int Nursing_M_TalukaID { get; set; }
        public string? TalukaName { get; set; }
        public string? Nursing_Pinecode { get; set; }
        public string? NursingHome_Description { get; set; }
        public int NursingHome_M_IndicatorID { get; set; }
        public int OtherBusinessType_M_IndicatorID { get; set; }
        public string? OtherBusinessType_M_Indicator { get; set; }
        public string? OtherBusiness_Details { get; set; }
        public string? OtherBusiness_HouseNo { get; set; }
        public string? OtherBusiness_Area { get; set; }
        public string? OtherBusiness_City { get; set; }
        public int OtherBusiness_M_DistrictID { get; set; }
        public string? OtherBusiness_M_District { get; set; }
        public int OtherBusiness_M_TalukaID { get; set; }
        public string? OtherBusiness_M_Taluka { get; set; }
        public string? OtherBusiness_Pincode { get; set; }
        public int M_UserID { get; set; }
    }
    public class NursingHome_Update_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The NursingHomeWithSpeciality field is required")]
        public string? NursingHomeWithSpeciality { get; set; }
        [Required(ErrorMessage = "The GovernmentSchema_M_IndicatorID field is required")]
        public int GovernmentSchema_M_IndicatorID { get; set; }
        public string? GovernmentSchema { get; set; }
        [Required(ErrorMessage = "The M_InstitutionsTypeID field is required")]
        public int M_InstitutionsTypeID { get; set; }
        public string? M_SubInstitutionsTypeID { get; set; }
        [Required(ErrorMessage = "The CollectionCenterAvailable_M_IndicatorID field is required")]
        public int CollectionCenterAvailable_M_IndicatorID { get; set; }
        public string? FirmCompany { get; set; }
        
        public string? Website { get; set; }
        
        public DateTime DateofEstablishment { get; set; }

        [Required(ErrorMessage = "The Specialty_M_IndicatorID field is required")]
        public int Specialty_M_IndicatorID { get; set; }
        
        public string? Nursing_HouseNo { get; set; }
        
        public string? Nursing_Area { get; set; }
        
        public string? Nursing_City { get; set; }
        [Required(ErrorMessage = "The Nursing_M_DistrictID field is required")]
        public int? Nursing_M_DistrictID { get; set; }
        [Required(ErrorMessage = "The Nursing_M_TalukaID field is required")]
        public int? Nursing_M_TalukaID { get; set; }
        [Required(ErrorMessage = "The Nursing_Pinecode field is required")]
        public string? Nursing_Pinecode { get; set; }
        [Required(ErrorMessage = "The NursingHome_Description field is required")]
        public string? NursingHome_Description { get; set; }
        [Required(ErrorMessage = "The NursingHome_M_IndicatorID field is required")]
        public int? NursingHome_M_IndicatorID { get; set; }       
        public int? OtherBusinessType_M_IndicatorID { get; set; }
        public string? OtherBusiness_Details { get; set; }
        public string? OtherBusiness_HouseNo { get; set; }
        public string? OtherBusiness_Area { get; set; }
        public string? OtherBusiness_City { get; set; }
        public int? OtherBusiness_M_DistrictID { get; set; }
        public int? OtherBusiness_M_TalukaID { get; set; }
        public string? OtherBusiness_Pincode { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class CollectionCenter_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegister ID field is required")]
        public int M_ApplicantRegisterID { get; set; }

        [Required(ErrorMessage = "The Name of Collection Center field is required")]
        public string? NameofCollectionCenter { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public string? TechnicianName { get; set; }
        public string? Qualification { get; set; }
        public string? RegNo { get; set; }

        [Required(ErrorMessage = "The M_User ID field is required")]
        public int M_UserID { get; set; }
    }
    public class CollectionCenter_Delete_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegister ID field is required")]
        public int M_ApplicantRegister_CollectionCenterID { get; set; }
        public int M_UserID { get; set; }
    }
    public class CollectionCenter_Model
    {
        public int M_ApplicantRegister_CollectionCenterID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? NameofCollectionCenter { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public string? TechnicianName { get; set; }
        public string? Qualification { get; set; }
        public string? RegNo { get; set; }
        public int M_UserID { get; set; }
    }
    public class ProcedureDetails_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegister ID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The ProcedureServices field is required")]
        public string? ProcedureServices { get; set; }
        [Required(ErrorMessage = "The Details field is required")]
        public string? Details { get; set; }
        [Required(ErrorMessage = "The Remarks field is required")]
        public string? Remarks { get; set; }
        [Required(ErrorMessage = "The UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class ProcedureDetails_Delete_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegister_ProcedureDetailsID ID field is required")]
        public int M_ApplicantRegister_ProcedureDetailsID { get; set; }
           
        [Required(ErrorMessage = "The UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class ProcedureDetails_Model
    {
        public int M_ApplicantRegister_ProcedureDetailsID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? ProcedureServices { get; set; }
        public string? Details { get; set; }
        public string? Remarks { get; set; }
        public int M_UserID { get; set; }
    }
    public class NursingHome_SubInstitutionsType
    {
        public int M_SubInstitutionsTypeID { get; set; }
        public string? SubInstitutionsName { get; set; }
    }
}
