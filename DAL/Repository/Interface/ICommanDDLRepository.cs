using BOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ICommanDDLRepository
    {
        Task<List<DDLAriaType>> DDL_M_AreaType(int M_UserID, string Flag);
        Task<List<DDLAria>> DDL_M_Area(int M_AreaTypeID,int M_UserID, string Flag);
        Task<List<DDL_M_Role>> DDL_M_Role(int M_UserID, string Flag);
        Task<List<DDL_M_Designation>> DDL_M_Designation(int M_RoleID, int M_UserID, string Flag);
        Task<List<DDL_M_UserStatus_Indicator>> DDL_M_UserStatus_Indicator(int M_UserID, string Flag);
        Task<List<DDL_SpecialtyName>> DDL_SpecialtyName(int M_UserID, string Flag);
        Task<List<DDL_M_Equipments>> DDL_M_Equipments(int M_UserID, string Flag);
        Task<List<DDL_M_SubInstitutionsType>> DDL_M_SubInstitutionsType(int M_InstitutionsTypeID, int M_UserID, string Flag);
        Task<List<DDL_M_Qualification>> DDL_M_Qualification(int M_UserID, string Flag);
        Task<List<DDL_M_Signing_Designation>> DDL_M_Signing_Designation(int M_UserID, string Flag);
        Task<List<DDL_M_Specialization>> DDL_M_Specialization(int M_SpecialtyNameID, int M_UserID, string Flag);
        Task<List<DDL_M_State_Model>> DDL_M_State(int M_UserID, string Flag);
        Task<List<DDL_M_InstitutionsType_Model>> DDL_M_InstitutionsType(int M_UserID, string Flag);
        Task<List<DDL_M_District_Model>> DDL_M_District(int M_StateID, int M_UserID, string Flag);
        Task<List<DDL_M_Taluka_model>> DDL_M_Taluka(int M_DistrictID, int M_UserID, string Flag);
        Task<List<DDL_M_TypeofApplicant_Indicator_Model>> DDL_M_TypeofApplicant_Indicator(int M_UserID, string Flag);
        Task<List<DDL_M_Nationality_Indicator_Model>> DDL_M_Nationality_Indicator(int M_UserID, string Flag);
        Task<List<DDL_M_Country_Model>> DDL_M_Country(int M_UserID, string Flag); 
        Task<List<DDL_M_BusinessType_Model>> DDL_M_BusinessType(int M_UserID, string Flag);
        Task<List<DDL_RoomsType_Indicator_Model>> DDL_RoomsType_Indicator(int M_UserID, string Flag);
        Task<List<DDL_SanitaryArrangementforEmployees_Indicator_Model>> DDL_SanitaryArrangementforEmployees_Indicator(int M_UserID, string Flag);
        Task<List<DDL_SanitaryArrangementforPatients_Indicator_Model>> DDL_SanitaryArrangementforPatients_Indicator(int M_UserID, string Flag);
        Task<List<DDL_M_ServiceFood_Indicator_Model>> DDL_M_ServiceFood_Indicator(int M_UserID, string Flag);
        Task<List<DDL_M_StorageFood_Indicator_Model>> DDL_M_StorageFood_Indicator(int M_UserID, string Flag);
    }
}
