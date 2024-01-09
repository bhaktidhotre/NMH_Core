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
    public class CommanDDLRepository : ICommanDDLRepository
    {
        private readonly DapperContext context;
        public CommanDDLRepository(DapperContext context)
        {
            this.context = context;
        }

        public async Task<List<DDLAriaType>> DDL_M_AreaType(int M_UserID, string Flag)
        {
            var sp = "DDL_M_AreaType";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDLAriaType>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag,

                    }, commandType: CommandType.StoredProcedure);


                return result.ToList();
            }
        }

        public async Task<List<DDLAria>> DDL_M_Area(int M_AreaTypeID, int M_UserID, string Flag)
        {
            var sp = "DDL_M_Area";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDLAria>(sp,
                    new
                    {
                        M_AreaTypeID = M_AreaTypeID,
                        M_UserID = M_UserID,
                        Flag = Flag,

                    }, commandType: CommandType.StoredProcedure);


                return result.ToList();
            }
        }

        public async Task<List<DDL_M_Role>> DDL_M_Role(int M_UserID, string Flag)
        {
            var sp = "DDL_M_Role";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_Role>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<List<DDL_M_Designation>> DDL_M_Designation(int M_RoleID, int M_UserID, string Flag)
        {
            var sp = "DDL_M_Designation";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_Designation>(sp,
                    new
                    {
                        M_RoleID= M_RoleID,
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<List<DDL_M_UserStatus_Indicator>> DDL_M_UserStatus_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_M_UserStatus_Indicator";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_UserStatus_Indicator>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<List<DDL_M_Equipments>> DDL_M_Equipments(int M_UserID, string Flag)
        {
            var sp = "DDL_M_Equipments";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_Equipments>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        } public async Task<List<DDL_SpecialtyName>> DDL_SpecialtyName(int M_UserID, string Flag)
        {
            var sp = "DDL_M_SpecialtyName";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_SpecialtyName>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<List<DDL_M_SubInstitutionsType>> DDL_M_SubInstitutionsType(int M_InstitutionsTypeID, int M_UserID, string Flag)
        {
            var sp = "DDL_M_SubInstitutionsType";
            using(var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_SubInstitutionsType>(sp,
                    new
                    {
                        M_InstitutionsTypeID = M_InstitutionsTypeID,
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }
        public async Task<List<DDL_M_Qualification>> DDL_M_Qualification(int M_UserID, string Flag)
        {
            var sp = "DDL_M_Qualification";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_Qualification>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }
        public async Task<List<DDL_M_Signing_Designation>> DDL_M_Signing_Designation(int M_UserID, string Flag)
        {
            var sp = "DDL_M_Signing_Designation";
            using (var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_Signing_Designation>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);

                return result.ToList();
            }
        }

        public async Task<List<DDL_M_Specialization>> DDL_M_Specialization(int M_SpecialtyNameID, int M_UserID, string Flag)
        {
            var sp = "DDL_M_Specialization";
            using(var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_Specialization>(sp,
                    new
                    {
                        M_SpecialtyNameID = M_SpecialtyNameID,
                        M_UserID= M_UserID,
                        Flag= Flag

                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<DDL_M_State_Model>> DDL_M_State(int M_UserID, string Flag)
        {
            var sp = "DDL_M_State";
            using(var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_State_Model>(sp, new
                {
                    M_UserID = M_UserID,
                    Flag = Flag
                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<DDL_M_InstitutionsType_Model>> DDL_M_InstitutionsType(int M_UserID, string Flag)
        {
            var sp = "DDL_M_InstitutionsType";
            using( var connection = context.CreateConnection)
            {
                var result = await connection.QueryAsync<DDL_M_InstitutionsType_Model>(sp, new
                {
                    M_UserID = M_UserID,
                    Flag = Flag
                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<DDL_M_District_Model>> DDL_M_District(int M_StateID, int M_UserID, string Flag)
        {
            var sp = "DDL_M_District";
            using(var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_District_Model>(sp, new
                {
                    M_StateID = M_StateID,
                    M_UserID = M_UserID,
                    Flag = Flag
                }, commandType: CommandType.StoredProcedure);
                return result.ToList(); 
            }
        }

        public async Task<List<DDL_M_Taluka_model>> DDL_M_Taluka(int M_DistrictID, int M_UserID, string Flag)
        {
            var sp = "DDL_M_Taluka";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_Taluka_model>(sp, new
                {
                    M_DistrictID = M_DistrictID,
                    M_UserID = M_UserID,
                    Flag = Flag
                }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<DDL_M_TypeofApplicant_Indicator_Model>> DDL_M_TypeofApplicant_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_M_TypeofApplicant_Indicator";
            using(var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_TypeofApplicant_Indicator_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public async Task<List<DDL_M_Nationality_Indicator_Model>> DDL_M_Nationality_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_M_Nationality_Indicator";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_Nationality_Indicator_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        } 
        public async Task<List<DDL_M_Country_Model>> DDL_M_Country(int M_UserID, string Flag)
        {
            var sp = "DDL_M_Country";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_Country_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        } 
        public async Task<List<DDL_M_BusinessType_Model>> DDL_M_BusinessType(int M_UserID, string Flag)
        {
            var sp = "DDL_M_BusinessType_Indicator";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_BusinessType_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<DDL_RoomsType_Indicator_Model>> DDL_RoomsType_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_RoomsType_Indicator";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_RoomsType_Indicator_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<DDL_SanitaryArrangementforPatients_Indicator_Model>> DDL_SanitaryArrangementforPatients_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_SanitaryArrangementforPatients_Indicator";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_SanitaryArrangementforPatients_Indicator_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<DDL_SanitaryArrangementforEmployees_Indicator_Model>> DDL_SanitaryArrangementforEmployees_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_SanitaryArrangementforEmployees_Indicator";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_SanitaryArrangementforEmployees_Indicator_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<DDL_M_ServiceFood_Indicator_Model>> DDL_M_ServiceFood_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_M_ServiceFood_Indicator";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_ServiceFood_Indicator_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<DDL_M_StorageFood_Indicator_Model>> DDL_M_StorageFood_Indicator(int M_UserID, string Flag)
        {
            var sp = "DDL_M_StorageFood_Indicator";
            using (var connections = context.CreateConnection)
            {
                var result = await connections.QueryAsync<DDL_M_StorageFood_Indicator_Model>(sp,
                    new
                    {
                        M_UserID = M_UserID,
                        Flag = Flag
                    }, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

       
    }
}
