using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class Master_Validation
    {

    }
    public class User_Insert_Model
    {
        [Required(ErrorMessage = "The M_RoleID field is required")]
        public int M_RoleID { get; set; }
        [Required(ErrorMessage = "The M_DesignationID field is required")]
        public int M_DesignationID { get; set; }

        [Required(ErrorMessage = "The M_AreaID field is required")]
        public int M_AreaID { get; set; }

        [Required(ErrorMessage = "The EmployeeName field is required")]
        public string? EmployeeName { get; set; }
        public string? EmailID { get; set; }
        public string? Mobile { get; set; }
        [Required(ErrorMessage = "The UserName field is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "The Password field is required")]
        public string? Password { get; set; }
        [Required]
        public int IsActive { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class User_Update_Model
    {
        [Required(ErrorMessage = "The M_TableUserID field is required")]
        public int M_TableUserID { get; set; }
        [Required(ErrorMessage = "The M_RoleID field is required")]
        public int M_RoleID { get; set; }
        [Required(ErrorMessage = "The M_DesignationID field is required")]
        public int M_DesignationID { get; set; }
        [Required(ErrorMessage = "The M_AreaID field is required")]
        public int M_AreaID { get; set; }
        [Required(ErrorMessage = "The EmployeeName field is required")]
        public string? EmployeeName { get; set; }
        public string? EmailID { get; set; }
        public string? Mobile { get; set; }
        [Required(ErrorMessage = "The UserName field is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "The Password field is required")]
        public string? Password { get; set; }
        [Required]
        public int IsActive { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }

    }
    public class User_Delete_Model
    {
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }

    }
    public class User_Result_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_UserID { get; set; }
        public int M_RoleID { get; set; }
        public string? RoleName { get; set; }
        public int M_AreaTypeID { get; set; }
        public string? M_AreaTypeName { get; set; }
        public int M_AreaID { get; set; }
        public string? AreaName { get; set; }
        public int M_DesignationID { get; set; }
        public string? Designation { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmailID { get; set; }
        public string? Mobile { get; set; }
        public string? UserName { get; set; }
        public string? AndroidDeviceID { get; set; }
        public int IsActiveStatusID { get; set; }
        public string? IsActiveStatus { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class SpecialtyName_Insert_Model
    {
        [Required(ErrorMessage = "The SpecialtyName field is required")]
        public string? SpecialtyName { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class SpecialtyName_Update_Model
    {
        [Required(ErrorMessage = "The M_SpecialtyNameID field is required")]
        public int M_SpecialtyNameID { get; set; }

        [Required(ErrorMessage = "The SpecialtyName field is required")]
        public string? SpecialtyName { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class SpecialtyName_Delete_Model
    {
        [Required(ErrorMessage = "The M_SpecialtyNameID field is required")]
        public int M_SpecialtyNameID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class SpecialtyName_Result_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_SpecialtyNameID { get; set; }
        public string? SpecialtyName { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class Specialization_Insert_Model
    {
        [Required(ErrorMessage = "The M_SpecialtyNameID field is required")]
        public int M_SpecialtyNameID { get; set; }

        [Required(ErrorMessage = "The SpecializationName field is required")]
        public string? Specialization { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Specialization_Update_Model
    {
        [Required(ErrorMessage = "The M_SpecializationID field is required")]
        public int M_SpecializationID { get; set; }

        [Required(ErrorMessage = "The M_SpecialtyNameID field is required")]
        public int M_SpecialtyNameID { get; set; }

        [Required(ErrorMessage = "The SpecializationName field is required")]
        public string? Specialization { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Specialization_Delete_Model
    {
        [Required(ErrorMessage = "The M_SpecializationID field is required")]
        public int M_SpecializationID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Specialization_Result_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_SpecialtyNameID { get; set; }
        public string? SpecialtyName { get; set; }
        public int M_SpecializationID { get; set; }
        public string? SpecializationName { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class M_Equipments_Insert_Model
    {
        [Required(ErrorMessage = "The EquipmentName field is required")]
        public string? EquipmentName { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Equipments_Update_Model
    {
        [Required(ErrorMessage = "The M_EquipmentsNameID field is required")]
        public int M_EquipmentsID { get; set; }
        [Required(ErrorMessage = "The EquipmentName field is required")]
        public string? EquipmentName { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Equipments_Delete_Model
    {
        [Required(ErrorMessage = "The M_EquipmentsNameID field is required")]
        public int M_EquipmentsID { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Equipments_Result_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int EquipmentNameID { get; set; }
        public string? EquipmentName { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class M_InstitutionsType_Insert_Model
    {
        [Required(ErrorMessage = "The InstitutionsType field is required")]
        public string? InstitutionsType { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_InstitutionsType_Update_Model
    {
        public int M_InstitutionsTypeID { get; set; }
        public string? InstitutionsType { get; set; }
        public int M_UserID { get; set; }
    }
    public class M_InstitutionsType_Delete_Model
    {
        public int M_InstitutionsTypeID { get; set; }
        public int M_UserID { get; set; }
    }
    public class M_InstitutionsType_Result_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_InstitutionsTypeID { get; set; }
        public string? InstitutionsType { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class M_SubInstitutionsType_Insert_Model
    {
        [Required(ErrorMessage = "The M_InstitutionsTypeID field is required")]
        public int M_InstitutionsTypeID { get; set; }

        [Required(ErrorMessage = "The SubInstitutionsName field is required")]
        public string? SubInstitutionsName { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_SubInstitutionsType_Update_Model
    {
        [Required(ErrorMessage = "The M_SubInstitutionsTypeID field is required")]
        public int M_SubInstitutionsTypeID { get; set; }
        public int M_InstitutionsTypeID { get; set; }

        [Required(ErrorMessage = "The SubInstitutionsName field is required")]
        public string? SubInstitutionsName { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_SubInstitutionsType_Delete_Model
    {
        public int M_SubInstitutionsTypeID { get; set; }
    }
    public class M_SubInstitutionsType_Select_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_InstitutionsTypeID { get; set; }

        public string? InstitutionsType { get; set; }

        public int M_SubInstitutionsTypeID { get; set; }

        public string? SubInstitutionsName { get; set; }
    }

    public class M_Area_Insert_Model
    {
        [Required(ErrorMessage = "The M_AreaTypeID field is required")]
        public int M_AreaTypeID { get; set; }

        [Required(ErrorMessage = "The AreaName field is required")]
        public string? AreaName { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Area_Update_Model
    {
        [Required(ErrorMessage = "The M_AreaID field is required")]
        public int M_AreaID { get; set; }

        [Required(ErrorMessage = "The M_AreaTypeID field is required")]
        public int M_AreaTypeID { get; set; }

        [Required(ErrorMessage = "The AreaName field is required")]
        public string? AreaName { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Area_Delete_Model
    {
        [Required(ErrorMessage = "The M_AreaID field is required")]
        public int M_AreaID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Area_Result_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_AreaTypeID { get; set; }
        public string? AreaTypeName { get; set; }
        public int M_AreaID { get; set; }
        public string? AreaName { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class M_Qualification_Insert_Model
    {
        [Required(ErrorMessage = "The Qualification field is required")]
        public string? Qualification { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Qualification_Update_Model
    {
        [Required(ErrorMessage = "The M_QualificationID field is required")]
        public int M_QualificationID { get; set; }
        [Required(ErrorMessage = "The Qualification field is required")]
        public string? Qualification { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Qualification_Delete_Model
    {
        [Required(ErrorMessage = "The M_QualificationID field is required")]
        public int M_QualificationID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_Qualification_Result_Model
    {
        public int RowNum { get; set; }
        public int Totalcount { get; set; }
        public int M_QualificationID { get; set; }
        public string? Qualification { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class M_SigningDesign_Insert_Model
    {
        [Required(ErrorMessage = "The Designation field is required")]
        public string? Designation { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_SigningDesign_Update_Model
    {
        [Required(ErrorMessage = "The Authority_DesignationID field is required")]
        public int Authority_DesignationID { get; set; }

        [Required(ErrorMessage = "The Designation field is required")]
        public string? Designation { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_SigningDesign_Delete_Model
    {
        [Required(ErrorMessage = "The Authority_DesignationID field is required")]
        public int Authority_DesignationID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_SigningDesign_Result_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_Signing_Authority_DesignationID { get; set; }
        public string? Designation { get; set; }
        public int M_UserID { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }

    public class M_District_Insert_Model
    {
        [Required(ErrorMessage = "The State ID field is required")]
        public int M_StateID { get; set; }
        [Required(ErrorMessage = "The District Name field is required")]
        public string? DistrictName { get; set; }

        [Required(ErrorMessage = "The User ID field is required")]
        public int M_UserID { get; set; }
    }

    public class M_District_Update_Model
    {
        [Required(ErrorMessage = "The District ID field is required")]
        public int M_DistrictID { get; set; }

        [Required(ErrorMessage = "The State ID field is required")]
        public int M_StateID { get; set; }

        [Required(ErrorMessage = "The District Name field is required")]
        public string? DistrictName { get; set; }

        [Required(ErrorMessage = "The User ID field is required")]
        public int M_UserID { get; set; }
    }
    public class M_District_Delete_Model
    {
        [Required(ErrorMessage = "The District ID field is required")]
        public int M_DistrictID { get; set; }
    }
    public class M_District_Select_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_DistrictID { get; set; }
        public int M_StateID { get; set; }
        public string? StateName { get; set; }
        public string? DistrictName { get; set; }
    }

    public class M_Taluka_Insert_Model
    {
        [Required(ErrorMessage = "The M_AreaType ID field is required")]
        public int M_AreaTypeID { get; set; }
        [Required(ErrorMessage = "The District ID field is required")]
        public int M_DistrictID { get; set; }

        [Required(ErrorMessage = "The Taluka Name field is required")]
        public string? TalukaName { get; set; }

        [Required(ErrorMessage = "The User ID field is required")]
        public int M_UserID { get; set; }
    }

    public class M_Taluka_Update_Model
    {
        [Required(ErrorMessage = "The Taluka ID field is required")]
        public int M_TalukaID { get; set; }

        [Required(ErrorMessage = "The M_AreaType ID field is required")]
        public int M_AreaTypeID { get; set; }

        [Required(ErrorMessage = "The District ID field is required")]
        public int M_DistrictID { get; set; }

        [Required(ErrorMessage = "The Taluka Name field is required")]
        public string? TalukaName { get; set; }

        [Required(ErrorMessage = "The User ID field is required")]
        public int M_UserID { get; set; }

    }
    public class M_Taluka_Delete_model
    {
        [Required(ErrorMessage = "The Taluka ID field is required")]
        public int M_TalukaID { get; set; }
    }

    public class M_Taluka_Select_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_AreaTypeID { get; set; }
        public string? AreaTypeName { get; set; }
        public int M_TalukaID { get; set; }
        public int M_DistrictID { get; set; }
        public string? DistrictName { get; set; }
        public string? TalukaName { get; set; }
    }

    public class M_Fees_Insert_Model
    {
        public string? Charges { get; set; }
        public int M_UserID { get; set; }
    }
    public class M_Fees_Update_Model
    {
        public int M_FeesID { get; set; }
        public string? Charges { get; set; }
        public int M_UserID { get; set; }
    }
    public class M_Fees_Delete_Model
    {
        public int M_FeesID { get; set; }
    }
    public class M_Fees_Select_Model
    {
        public int RowNum { get; set; }
        public int TotalCount { get; set; }
        public int M_FeesID { get; set; }
        public string? Charges { get; set; }
    }
}
