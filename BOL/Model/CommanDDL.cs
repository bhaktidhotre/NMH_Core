using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class CommanDDL
    {
        public int M_UserID { get; set; }
        public string? Flag { get; set; }
    }
    public class DDLAriaType
    {
        public int AreaTypeNameID { get; set; }
        public string? AreaTypeName { get; set; }
    }
    public class DDLAria
    {
        public int M_AreaID { get; set; }
        public string? AreaName { get; set; }
    }
    public class DDL_M_Role
    {
        public int M_RoleNameID { get; set; }
        public string? RoleName { get; set; }
    }

    public class DDL_M_Designation
    {
        public int M_DesignationID { get; set; }
        public string? Designation { get; set; }
    }

    public class DDL_M_UserStatus_Indicator
    {
        public int M_IndicatorID { get; set; }
        public string? IndicatorName { get; set; }
    }
    public class DDL_SpecialtyName
    {
        public int M_SpecialtyNameID { get; set; }
        public string? SpecialtyName { get; set; }
    }
    public class DDL_M_Equipments
    {
        public int M_EquipmentsID { get; set; }
        public string? EquipmentName { get; set; }
    }

    public class DDL_M_SubInstitutionsType
    {
        public int M_SubInstitutionsTypeID { get; set; }
        public string? SubInstitutionsName { get; set; }
    } 
    public class DDL_M_Qualification
    {
        public int M_QualificationID { get; set; }
        public string? Qualification { get; set; }
    }
    public class DDL_M_Signing_Designation
    {
        public int M_Signing_Authority_DesignationID { get; set; }
        public string? Designation { get; set; }
    }
    public class DDL_M_Specialization
    {
        public int M_SpecializationID { get; set; }
        public string? Specialization { get; set; }
    }
    public class DDL_M_State_Model
    {
        public int StateNameID { get; set; }
        public string? StateName { get; set; }
    }
    public class DDL_M_InstitutionsType_Model
    {
        public int M_InstitutionsTypeID { get; set; }
        public string? InstitutionsType { get; set; }
    }

    public class DDL_M_District_Model
    {
        public int DistrictNameID { get; set; }
        public string? DistrictName { get; set; }
    }

    public class DDL_M_Taluka_model
    {
        public int M_TalukaNameID { get; set; }
        public string? TalukaName { get; set; }
    }

    public class DDL_M_TypeofApplicant_Indicator_Model
    {
        public int TypeofApplicantID { get; set; }
        public string? TypeofApplicantName { get; set; }
    }

    public class DDL_M_Nationality_Indicator_Model
    {
        public int M_NationalityID { get; set; }
        public string? M_NationalityName { get; set; }
    }
    public class DDL_M_Country_Model
    {
        public int CountryID { get; set; }
        public string? CountryName { get; set; }
    }
    public class DDL_M_BusinessType_Model
    {
        public int BusinessTypeID { get; set; }
        public string? BusinessTypeName { get; set; }
    }

    public class DDL_RoomsType_Indicator_Model
    {
        public int RoomsforEmployeesID { get; set; }
        public string? RoomsforEmployees { get; set; }
    }

    public class DDL_SanitaryArrangementforEmployees_Indicator_Model
    {
        public int SanitaryArrangementforEmployeesID { get; set; }
        public string? SanitaryArrangementforEmployees { get; set; }
    }

    public class DDL_SanitaryArrangementforPatients_Indicator_Model
    {
        public int SanitaryArrangementforPatientsID { get; set; }
        public string? SanitaryArrangementforPatients { get; set; }
    }
    public class DDL_M_ServiceFood_Indicator_Model
    {
        public int ServiceFoodID { get; set; }
        public string? ServiceFoodName { get; set; }
    }
    public class DDL_M_StorageFood_Indicator_Model
    {
        public int StorageFoodID { get; set; }
        public string? StorageFoodName { get; set; }
    }
}
