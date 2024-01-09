using BOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IMasterRepository
    {
        // M_User (Insert, Update, Delete, Select) //
        #region User
        Task<List<ResponsesCode_Validation>> M_User_Insert(User_Insert_Model userInsert);
        Task<List<ResponsesCode_Validation>> M_User_Update(User_Update_Model userUpdate);
        Task<List<ResponsesCode_Validation>> M_User_Delete(User_Delete_Model userDelete);
        Task<List<User_Result_Model>> M_User_Select(int M_AreaID,int M_RoleID,string? UserName,int M_UserID,int FromTop,int ToTop,string Flag);
        #endregion

        // SpecialtyName (Insert, Update, Delete, Select) //
        #region SpecialtyName
        Task<List<ResponsesCode_Validation>> M_SpecialtyName_Insert(SpecialtyName_Insert_Model specialtyInsert);
        Task<List<ResponsesCode_Validation>> M_SpecialtyName_Update(SpecialtyName_Update_Model specialtyUpdate);
        Task<List<ResponsesCode_Validation>> M_SpecialtyName_Delete(SpecialtyName_Delete_Model specialtyDelete);
        Task<List<SpecialtyName_Result_Model>> M_SpecialtyName_Select(int M_SpecialtyNameID, string? SpecialtyName, int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion

        // Specialization (Insert, Update, Delete, Select) //
        #region Specialization
        Task<List<ResponsesCode_Validation>> M_Specialization_Insert(Specialization_Insert_Model specializationInsert);
        Task<List<ResponsesCode_Validation>> M_Specialization_Update(Specialization_Update_Model specializationUpdate);
        Task<List<ResponsesCode_Validation>> M_Specialization_Delete(Specialization_Delete_Model specializationDelete);
        Task<List<Specialization_Result_Model>> M_Specialization_Select(int M_SpecializationID,int M_SpecialtyNameID, string? SpecializationName, int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion
        
        // Equipments (Insert, Update, Delete, Select) //
        #region Equipments
        Task<List<ResponsesCode_Validation>> M_Equipments_Insert(M_Equipments_Insert_Model equipmentsInsert);
        Task<List<ResponsesCode_Validation>> M_Equipments_Update(M_Equipments_Update_Model equipmentsUpdate);
        Task<List<ResponsesCode_Validation>> M_Equipments_Delete(M_Equipments_Delete_Model equipmentsDelete);
        Task<List<M_Equipments_Result_Model>> M_Equipments_Select(int M_EquipmentsID,  string? EquipmentName, int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion

        // InstitutionsType (Insert, Update, Delete, Select) //
        #region InstitutionsType
        Task<List<ResponsesCode_Validation>> M_InstitutionsType_Insert(M_InstitutionsType_Insert_Model institutionsTypeInsert);
        Task<List<ResponsesCode_Validation>> M_InstitutionsType_Update(M_InstitutionsType_Update_Model institutionsUpdate);
        Task<List<ResponsesCode_Validation>> M_InstitutionsType_Delete(M_InstitutionsType_Delete_Model institutionsDelete);
        Task<List<M_InstitutionsType_Result_Model>> M_InstitutionsType_Select(int M_EquipmentsID, string? EquipmentName, int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion

        // SubInstitutionsType (Insert, Update, Delete, Select) //
        #region M_SubInstitutionsType

        Task<List<ResponsesCode_Validation>> M_SubInstitutionsType_Insert(M_SubInstitutionsType_Insert_Model subInstitutionsType_Insert);

        Task<List<ResponsesCode_Validation>> M_SubInstitutionsType_Update(M_SubInstitutionsType_Update_Model subInstitutionsType_Update);

        Task<List<ResponsesCode_Validation>> M_SubInstitutionsType_Delete(M_SubInstitutionsType_Delete_Model subInstitutionsType_Delete);
        Task<List<M_SubInstitutionsType_Select_Model>> M_SubInstitutionsType_Select(int M_SubInstitutionsType, int M_InstitutionsTypeID,string? SubInstitutionsName,int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion

        // Area (Insert, Update, Delete, Select) //
        #region
        Task<List<ResponsesCode_Validation>> M_Area_Insert(M_Area_Insert_Model area_Insert_Model);
        Task<List<ResponsesCode_Validation>> M_Area_Update(M_Area_Update_Model area_Update_Model);
        Task<List<ResponsesCode_Validation>> M_Area_Delete(M_Area_Delete_Model area_Delete_Model);
        Task<List<M_Area_Result_Model>> M_Area_Select(int M_AreaID, int M_AreaTypeID, string? AreaName, int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion


        // Area (Insert, Update, Delete, Select) //
        #region
        Task<List<ResponsesCode_Validation>> M_Qualification_Insert(M_Qualification_Insert_Model qualification_Insert_Model);
        Task<List<ResponsesCode_Validation>> M_Qualification_Update(M_Qualification_Update_Model qualification_Update_Model);
        Task<List<ResponsesCode_Validation>> M_Qualification_Delete(M_Qualification_Delete_Model qualification_Delete_Model);
        Task<List<M_Qualification_Result_Model>> M_Qualification_Select(int M_QualificationID, string? Qualification, int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion

        // Signing_Designation (Insert, Update, Delete, Select) //
        #region
        Task<List<ResponsesCode_Validation>> M_Signing_Designation_Insert(M_SigningDesign_Insert_Model design_Insert_Model);
        Task<List<ResponsesCode_Validation>> M_Signing_Designation_Update(M_SigningDesign_Update_Model design_Update_Model);
        Task<List<ResponsesCode_Validation>> M_Signing_Designation_Delete(M_SigningDesign_Delete_Model design_Delete_Model);
        Task<List<M_SigningDesign_Result_Model>> M_Signing_Designation_Select(int M_Signing_DesignationID, string? DesignationName, int M_UserID, int FromTop, int ToTop, string Flag);
        #endregion

        #region M_District_Insert
        Task<List<ResponsesCode_Validation>> M_District_Insert(M_District_Insert_Model Obj_M_District_Model);
        Task<List<ResponsesCode_Validation>> M_District_Update(M_District_Update_Model Obj_M_District_Model);
        Task<List<ResponsesCode_Validation>> M_District_Delete(M_District_Delete_Model Obj_M_District_Model);
        Task<List<M_District_Select_Model>> M_District_Select(int M_DistrictID, int M_StateID,string? DistrictName,int M_UserID,int FromTop,int ToTop,string Flag);
        #endregion

        #region M_Taluka_Insert
        Task<List<ResponsesCode_Validation>> M_Taluka_Insert(M_Taluka_Insert_Model Obj_M_Taluka_Model);
        Task<List<ResponsesCode_Validation>> M_Taluka_Update(M_Taluka_Update_Model Obj_M_Taluka_Model);
        Task<List<ResponsesCode_Validation>> M_Taluka_Delete(M_Taluka_Delete_model obj_M_Taluka_Model);
        Task<List<M_Taluka_Select_Model>> M_Taluka_Select(int M_AreaTypeID, int M_TalukaID,int M_DistrictID,string? TalukaName,int M_UserID,int FromTop,int ToTop,string Flag);

        #endregion

        #region M_Fees_Insert
        Task<List<ResponsesCode_Validation>> M_Fees_Insert(M_Fees_Insert_Model Obj_Fees_Model);
        Task<List<ResponsesCode_Validation>> M_Fees_Update(M_Fees_Update_Model Obj_Fees_Model);
        Task<List<ResponsesCode_Validation>> M_Fees_Delete(M_Fees_Delete_Model Obj_Fees_Model);
        Task<List<M_Fees_Select_Model>> M_Fees_Select(int M_FeesID, string? Charges,int M_UserID,int FromTop,int ToTop,string Flag);
        #endregion
    }
}
