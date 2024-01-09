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
    public class DashboardRepository : IDashboardRepository
    {
        private readonly DapperContext context;
        public DashboardRepository(DapperContext _context)
        {
            this.context = _context;
        }
        public async Task<List<Track_View_Grid_Model>> Track_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID,string Flag, int M_UserID)
        {
            var SP = "M_ApplicantRegister_Track_View_Grid_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<Track_View_Grid_Model>(SP,
                    new
                    {
                        M_FinancialYearID = M_FinancialYearID,
                        M_MonthID = M_MonthID,
                        M_ApplicantRegisterID = M_ApplicantRegisterID,
                        Flag = Flag,
                        M_UserID = M_UserID,

                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }
        public async Task<List<MainForm_Model>> MainForm_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID)
        {
            var SP = "DB_M_ApplicantRegister_MainForm_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<MainForm_Model>(SP,
                    new
                    {
                        M_FinancialYearID = M_FinancialYearID,
                        M_MonthID = M_MonthID,
                        M_ApplicantRegisterID = M_ApplicantRegisterID,
                        RootPath = RootPath,
                        M_UserID = M_UserID,

                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }
        public async Task<List<MainForm_Document_Model>> MainForm_Document_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID)
        {
            var sp = "M_ApplicantRegister_Select";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<MainForm_Document_Model>(sp,
                    new
                    {
                        M_ApplicantRegisterID = M_ApplicantRegisterID,
                        M_UserID = M_UserID
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<ApplicationSubmit_Responce_model>> M_Application_Submit_Responce(int M_ApplicantRegisterID, int M_UserID)
        {
            var sp = "M_Application_Submit_Responce_Select";
            using(var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<ApplicationSubmit_Responce_model>(sp,
                    new
                    {
                        M_ApplicantRegisterID = M_ApplicantRegisterID,
                        M_UserID = M_UserID
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }

        }
    }
}
