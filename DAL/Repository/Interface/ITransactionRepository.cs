using BOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface ITransactionRepository
    {
        // Register //
        Task<List<ResponsesCode_Validation>> M_ApplicantRegister_Insert(ApplicantRegister_Insert_Model objRegister_Insert_Model);
        Task<List<ResponsesCode_Validation>> M_ApplicantRegister_Update(ApplicantRegister_Update_Model objRegister_Update_Model);
        Task<List<ApplicantRegister_Model>> M_ApplicantRegister_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);

        // NursingHome //
        Task<List<ResponsesCode_Validation>> M_NursingHome_Update(NursingHome_Update_Model objNursingHome_Update_Model);
        Task<List<NursingHome_Model>> M_NursingHome_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<NursingHome_SubInstitutionsType>> SubInstitutionsType_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID);
        Task<List<ResponsesCode_Validation>> CollectionCenter_Insert(CollectionCenter_Insert_Model objCollectionCenter_Insert_Model);
        Task<List<ResponsesCode_Validation>> CollectionCenter_Delete(CollectionCenter_Delete_Model objCollectionCenter_Delete_Model);
        Task<List<CollectionCenter_Model>> CollectionCenter_Model_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> ProcedureDetails_Insert(ProcedureDetails_Insert_Model objProcedureDetails_Insert_Model);
        Task<List<ResponsesCode_Validation>> ProcedureDetails_Delete(ProcedureDetails_Delete_Model objProcedureDetails_Delete_Model);
        Task<List<ProcedureDetails_Model>> ProcedureDetails_Model_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);

        #region Infrastructure
        // Infrastructure //
        Task<List<ResponsesCode_Validation>> Infrastructure_Update(Infrastructure_Details_Update_Model objInfrastructureUpdate_Model);
        Task<List<Infrastructure_Model>> Infrastructure_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> Equipments_Details_Insert(Equipments_Insert_Model objEquipments_Insert_Model);
        Task<List<ResponsesCode_Validation>> Equipments_Details_Delete(Equipments_Delete_Model objEquipments_Delete_Model);
        Task<List<Equipments_Model>> Equipments_Details_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> SanitaryArrangementPatients_Insert(Patients_Insert_Model objPatients_Insert_Model);
        Task<List<ResponsesCode_Validation>> SanitaryArrangementPatients_Delete(Patients_Delete_Model objPatients_Delete_Model);
        Task<List<Patients_Model>> Patients_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> SanitaryArrangementEmployees_Insert(Employees_Insert_Model objEmployees_Insert_Model);
        Task<List<ResponsesCode_Validation>> SanitaryArrangementEmployees_Delete(Employees_Delete_Model objEmployees_Delete_Model);
        Task<List<Employees_Model>> Employees_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> RoomsForEmployees_Insert(RoomsForEmployees_Insert_Model objRooms_Insert_Model);
        Task<List<ResponsesCode_Validation>> RoomsForEmployees_Delete(RoomsForEmployees_Delete_Model objRooms_Delete_Model);
        Task<List<RoomsForEmployees_Model>> RoomsForEmployees(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        #endregion

        #region StaffDetails
        Task<List<ResponsesCode_Validation>> EmployeeStaffDetails_Insert(EmployeeStaffDetails_Insert_Model objStaffDetails_Insert_Model);
        Task<List<ResponsesCode_Validation>> EmployeeStaffDetails_Delete(EmployeeStaffDetails_Delete_Model objStaffDetails_Delete_Model);
        Task<List<EmployeeStaffDetails_Model>> EmployeeStaffDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> PhysiciansSurgeonsDetails_Insert(PhysiciansSurgeonsDetails_Insert_Model objPhysiciansSurgeonsDetails);
        Task<List<ResponsesCode_Validation>> PhysiciansSurgeonsDetails_Delete(PhysiciansSurgeonsDetails_Delete_Model objPhysiciansSurgeonsDetails);
        Task<List<PhysiciansSurgeonsDetails_Model>> PhysiciansSurgeonsDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> QualifiedNurseDetails_Insert(QualifiedNurseDetails_Insert_Model objQualifiedNurseDetails);
        Task<List<ResponsesCode_Validation>> QualifiedNurseDetails_Delete(QualifiedNurseDetails_Delete_Model objQualifiedNurseDetails);
        Task<List<QualifiedNurseDetails_Model>> QualifiedNurseDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> QualifiedNurse_Midwife_Insert(QualifiedNurse_Midwife_Insert objQualifiedNurseMidwife);
        Task<List<ResponsesCode_Validation>> QualifiedNurse_Midwife_Delete(QualifiedNurse_Midwife_Delete objQualifiedNurseMidwife);
        Task<List<QualifiedNurse_Midwife_Model>> QualifiedNurse_Midwife_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> Foreign_Staff_Insert(ForeignStaff_Insert_Model objForeign_Staff_Insert);
        Task<List<ResponsesCode_Validation>> Foreign_Staff_Delete(ForeignStaff_Delete_Model objForeign_Staff_Delete);
        Task<List<ForeignStaff_Model>> Foreign_Staff_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        Task<List<ResponsesCode_Validation>> StaffDetails_Update(Staff_Update_Model objStaff_Update_Model);
        Task<List<Staff_Model>> Staff_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
      
        #endregion

        #region Declaration
        Task<List<ResponsesCode_Validation>> Declaration_Update(Declaration_Model objDeclaration_Model);
        #endregion

        #region Document
        Task<List<ResponsesCode_Validation>> Document_Insert(Documents_Insert_Model objDocuments_Insert_Model);
        Task<List<Documents_Model>> Documents_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag);
        #endregion
    }
}
