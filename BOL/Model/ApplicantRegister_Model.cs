using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class ApplicantRegister_Model
    {
        public int M_ApplicantRegisterID { get; set; }
        public int ApplicantType_M_IndicatorID { get; set; }
        public string? ApplicantType_M_Indicator { get; set; }
        public string? OrganizationName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddelName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? ApplicantQualification { get; set; }      
        public int M_AreaTypeID { get; set; }
        public string? AreaTypeName { get; set; }
        public int M_SpecialtyNameID { get; set; }
        public string? SpecialtyName { get; set; }
        public int M_SpecializationID { get; set; }
        public string? Specialization { get; set; }
        public int Nationality_M_IndicatorID { get; set; }
        public string? Nationality_M_Indicator { get; set; }
        public string? NationalityProof { get; set; }
        public string? LandlineNumber { get; set; }
        public int M_CountryID { get; set; }
        public string? CountryName { get; set; }
        public string? HouseNo { get; set; }
        public string? ColonyArea { get; set; }
        public string? City { get; set; }
        public int M_Area_Wise_DistrictID { get; set; }
        public string? AreaName { get; set; }
        public int M_Area_Wise_TalukaID { get; set; }

        public string? TalukaName { get; set; }
        public string? Pincode { get; set; }
        public string? SigningName { get; set; }
        public string? SigningAuthorityLetter { get; set; }
        public int M_Signing_Authority_DesignationID { get; set; }
        public string? AadhaarCardNo { get; set; }
        public string? M_Signing_Authority_Designation { get; set; }
        public int M_UserID { get; set; }
    }
    public class ApplicantRegister_Insert_Model
    {
        [Required(ErrorMessage = "The FirstName field is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "The MiddelName field is required")]
        public string? MiddelName { get; set; }
        [Required(ErrorMessage = "The LastName field is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "The DateOfBirth field is required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "The EmailID field is required")]
        public string? EmailID { get; set; }
        [Required(ErrorMessage = "The Mobile field is required")]
        public string? Mobile { get; set; }
        [Required(ErrorMessage = "The M_AreaTypeID field is required")]
        public int M_AreaTypeID { get; set; }
        [Required(ErrorMessage = "The UserName field is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "The Password field is required")]
        public string? Password { get; set; }   
        public int M_UserID { get; set; }
    }
    public class ApplicantRegister_Update_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int? M_ApplicantRegisterID { get; set; }

        [Required(ErrorMessage = "The ApplicantType_M_IndicatorID field is required")]
        public int? ApplicantType_M_IndicatorID { get; set; }

        public string? OrganizationName { get; set; }

        [Required(ErrorMessage = "The First Name field is required")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "The Middel Name field is required")]
        public string? MiddelName { get; set; }

        [Required(ErrorMessage = "The Last Name field is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "The DateOfBirth field is required")]
        //[DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "The Mobile field is required")]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "The Email field is required")]
      
        public string? Email { get; set; }

        [Required(ErrorMessage = "The ApplicantQualification field is required")]
        public string? ApplicantQualification { get; set; }

        [Required(ErrorMessage = "The M_AreaTypeID field is required")]
        public int? M_AreaTypeID { get; set; }

        [Required(ErrorMessage = "The M_SpecializationID field is required")]
        public int? M_SpecializationID { get; set; }
        public int? Nationality_M_IndicatorID { get; set; }
        public string? NationalityProof { get; set; }
        public string? LandlineNumber { get; set; }
        public int? M_CountryID { get; set; } = null;
        public string? HouseNo { get; set; }
        public string? ColonyArea { get; set; }
        public string? City { get; set; }
        public int? M_Area_Wise_DistrictID { get; set; }
        public int M_Area_Wise_TalukaID { get; set; }
        public string? Pincode { get; set; }
        public string? SigningName { get; set; }
        public string?SigningAuthorityLetter { get; set; }
        public int? M_Signing_Authority_DesignationID { get; set; }
        public string?AadhaarCardNo { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int? M_UserID { get; set; }
    }

    public class Declaration_Model
    {
        [Required(ErrorMessage = "The IsDeclaration field is required")]
        public int M_ApplicantRegisterID { get; set; }

        [Required(ErrorMessage = "The M_User ID field is required")]
        public int M_UserID { get; set; }
    }
    public class Documents_Model
    {
        public int M_ApplicantRegisterID { get; set; }
        public int M_ApplicantRegister_DocumentID { get; set; }
        public int M_DocumentID { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentPath { get; set; }
        public int M_UserID { get; set; }
    }
    public class Documents_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegister ID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The M_Document ID field is required")]
        public int M_DocumentID { get; set; }
        [Required(ErrorMessage = "The DocumentPath field is required")]
        public string? DocumentPath { get; set; }
        [Required(ErrorMessage = "The M_User ID field is required")]
        public int M_UserID { get; set; }
    }
}
