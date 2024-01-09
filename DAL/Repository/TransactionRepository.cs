using BOL.Model;
using DAL.Context;
using DAL.Repository.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DapperContext context;
        public TransactionRepository(DapperContext _context)
        {
            this.context = _context;
        }

        // Applicant Register //
        public async Task<List<ResponsesCode_Validation>> M_ApplicantRegister_Insert(ApplicantRegister_Insert_Model objRegister_Insert_Model)
        {
            var SP = "M_ApplicantRegister_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(SP, objRegister_Insert_Model
                   , commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> M_ApplicantRegister_Update(ApplicantRegister_Update_Model objRegister_Update_Model)
        {
            var sp = "M_ApplicantRegister_Update";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objRegister_Update_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ApplicantRegister_Model>> M_ApplicantRegister_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ApplicantRegister_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
       
        // Nursing Home //
        public async Task<List<ResponsesCode_Validation>> M_NursingHome_Update(NursingHome_Update_Model objNursingHome_Update_Model)
        {
            var sp = "M_ApplicantRegister_NursingHome_Update";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objNursingHome_Update_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<NursingHome_SubInstitutionsType>> SubInstitutionsType_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID)
        {
            var SP = "M_ApplicantRegister_SubInstitutionsType_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<NursingHome_SubInstitutionsType>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    M_UserID = M_UserID,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<NursingHome_Model>> M_NursingHome_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<NursingHome_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> CollectionCenter_Delete(CollectionCenter_Delete_Model objCollectionCenter_Delete_Model)
        {
            var sp = "M_ApplicantRegister_CollectionCenter_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objCollectionCenter_Delete_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> CollectionCenter_Insert(CollectionCenter_Insert_Model objCollectionCenter_Insert_Model)
        {
            var sp = "M_ApplicantRegister_CollectionCenter_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objCollectionCenter_Insert_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<CollectionCenter_Model>> CollectionCenter_Model_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<CollectionCenter_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> ProcedureDetails_Insert(ProcedureDetails_Insert_Model objProcedureDetails_Insert_Model)
        {
            var sp = "M_ApplicantRegister_ProcedureDetails_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objProcedureDetails_Insert_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> ProcedureDetails_Delete(ProcedureDetails_Delete_Model objProcedureDetails_Delete_Model)
        {
            var sp = "M_ApplicantRegister_ProcedureDetails_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objProcedureDetails_Delete_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ProcedureDetails_Model>> ProcedureDetails_Model_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ProcedureDetails_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        #region Infrastructure
        public async Task<List<ResponsesCode_Validation>> Equipments_Details_Insert(Equipments_Insert_Model objEquipments_Insert_Model)
        {
            var sp = "M_ApplicantRegister_Equipments_Details_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objEquipments_Insert_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> Equipments_Details_Delete(Equipments_Delete_Model objEquipments_Delete_Model)
        {
            var sp = "M_ApplicantRegister_Equipments_Details_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objEquipments_Delete_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<Equipments_Model>> Equipments_Details_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<Equipments_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> SanitaryArrangementPatients_Insert(Patients_Insert_Model objPatients_Insert_Model)
        {
            var sp = "M_ApplicantRegister_SanitaryArrangementPatients_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objPatients_Insert_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> SanitaryArrangementPatients_Delete(Patients_Delete_Model objPatients_Delete_Model)
        {
            var sp = "M_ApplicantRegister_SanitaryArrangementPatients_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objPatients_Delete_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<Patients_Model>> Patients_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<Patients_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> SanitaryArrangementEmployees_Insert(Employees_Insert_Model objEmployees_Insert_Model)
        {
            var sp = "M_ApplicantRegister_SanitaryArrangementEmployees_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objEmployees_Insert_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> SanitaryArrangementEmployees_Delete(Employees_Delete_Model objEmployees_Delete_Model)
        {
            var sp = "M_ApplicantRegister_SanitaryArrangementEmployees_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objEmployees_Delete_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<Employees_Model>> Employees_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<Employees_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> RoomsForEmployees_Insert(RoomsForEmployees_Insert_Model objRooms_Insert_Model)
        {
            var sp = "M_ApplicantRegister_RoomsForEmployees_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objRooms_Insert_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> RoomsForEmployees_Delete(RoomsForEmployees_Delete_Model objRooms_Delete_Model)
        {
            var sp = "M_ApplicantRegister_RoomsForEmployees_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objRooms_Delete_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<RoomsForEmployees_Model>> RoomsForEmployees(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<RoomsForEmployees_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> Infrastructure_Update(Infrastructure_Details_Update_Model objInfrastructureUpdate_Model)
        {
            var SP = "M_ApplicantRegister_Infrastructure_Details_Update";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(SP, objInfrastructureUpdate_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<Infrastructure_Model>> Infrastructure_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<Infrastructure_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        #endregion

        #region StaffDetails
        public async Task<List<ResponsesCode_Validation>> StaffDetails_Update(Staff_Update_Model objStaff_Update_Model)
        {
            var sp = "M_ApplicantRegister_StaffDetails_Update";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objStaff_Update_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<Staff_Model>> Staff_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<Staff_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> EmployeeStaffDetails_Insert(EmployeeStaffDetails_Insert_Model objStaffDetails_Insert_Model)
        {
            var sp = "M_ApplicantRegister_EmployeeStaffDetails_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objStaffDetails_Insert_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> EmployeeStaffDetails_Delete(EmployeeStaffDetails_Delete_Model objStaffDetails_Delete)
        {
            var sp = "M_ApplicantRegister_EmployeeStaffDetails_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objStaffDetails_Delete
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<EmployeeStaffDetails_Model>> EmployeeStaffDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<EmployeeStaffDetails_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> PhysiciansSurgeonsDetails_Insert(PhysiciansSurgeonsDetails_Insert_Model objPhysiciansSurgeonsDetails)
        {
            var sp = "M_ApplicantRegister_Physicians_Surgeons_Details_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objPhysiciansSurgeonsDetails
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> PhysiciansSurgeonsDetails_Delete(PhysiciansSurgeonsDetails_Delete_Model objPhysiciansSurgeonsDetails)
        {
            var sp = "M_ApplicantRegister_Physicians_Surgeons_Details_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objPhysiciansSurgeonsDetails
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<PhysiciansSurgeonsDetails_Model>> PhysiciansSurgeonsDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<PhysiciansSurgeonsDetails_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> QualifiedNurseDetails_Insert(QualifiedNurseDetails_Insert_Model objQualifiedNurseDetails)
        {
            var sp = "M_ApplicantRegister_QualifiedNurse_Details_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objQualifiedNurseDetails
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> QualifiedNurseDetails_Delete(QualifiedNurseDetails_Delete_Model objQualifiedNurseDetails)
        {
            var sp = "M_ApplicantRegister_QualifiedNurse_Details_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objQualifiedNurseDetails
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<QualifiedNurseDetails_Model>> QualifiedNurseDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<QualifiedNurseDetails_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> QualifiedNurse_Midwife_Insert(QualifiedNurse_Midwife_Insert objQualifiedNurseMidwife)
        {
            var sp = "M_ApplicantRegister_QualifiedNurse_Midwife_Details_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objQualifiedNurseMidwife
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> QualifiedNurse_Midwife_Delete(QualifiedNurse_Midwife_Delete objQualifiedNurseMidwife)
        {
            var sp = "M_ApplicantRegister_QualifiedNurse_Midwife_Details_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objQualifiedNurseMidwife
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<QualifiedNurse_Midwife_Model>> QualifiedNurse_Midwife_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<QualifiedNurse_Midwife_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> Foreign_Staff_Insert(ForeignStaff_Insert_Model objForeign_Staff_Insert)
        {
            var sp = "M_ApplicantRegister_ForeignNationalityStaffDetails_Insert";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objForeign_Staff_Insert
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ResponsesCode_Validation>> Foreign_Staff_Delete(ForeignStaff_Delete_Model objForeign_Staff_Delete)
        {
            var sp = "M_ApplicantRegister_ForeignNationalityStaffDetails_Delete";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objForeign_Staff_Delete
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ForeignStaff_Model>> Foreign_Staff_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ForeignStaff_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        #endregion

        #region Declaration
        public async Task<List<ResponsesCode_Validation>> Declaration_Update(Declaration_Model objDeclaration_Model)
        {
            var sp = "M_ApplicantRegister_Declaration_Update";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objDeclaration_Model
                    , commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        #endregion

        #region Document
        public async Task<List<ResponsesCode_Validation>> Document_Insert(Documents_Insert_Model objDocuments_Insert_Model)
           {
                var sp = "M_ApplicantRegister_Document_Insert";
                using (var connection = context.CreateConnection)
                {
                    var result = await connection.QueryAsync<ResponsesCode_Validation>(sp, objDocuments_Insert_Model
                        , commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
        public async Task<List<Documents_Model>> Documents_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID, string Flag)
        {
            var SP = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<Documents_Model>(SP,
                new
                {
                    M_FinancialYearID = M_FinancialYearID,
                    M_MonthID = M_MonthID,
                    M_ApplicantRegisterID = M_ApplicantRegisterID,
                    RootPath = RootPath,
                    M_UserID = M_UserID,
                    Flag = Flag,

                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        #endregion
    }
}
