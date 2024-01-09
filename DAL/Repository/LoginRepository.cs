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
    public class LoginRepository : ILoginRepository
    {
        private readonly DapperContext context;
        public LoginRepository(DapperContext context)
        {
            this.context = context;
        }

        public async Task<List<LoginResult>> LoginToken(string UserName , string Password , string ApplicationType)
        {

            var Responsecode = new DynamicParameters();

            Responsecode.Add("@Responsecode", 0, dbType: DbType.Int32, ParameterDirection.Output);
           // Responsecode.Add("@Responsecode", dbType: DbType.Int32, direction: ParameterDirection.Output);
          //  p.Add("@c", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);  

            var SP = "A_ValidateUser";
            using (var connection = context.CreateConnection)
            {
                //  var loginUser = await connection.ExecuteAsync(SP, Responsecode, commandType: CommandType.StoredProcedure);

                var loginUser = await connection.QueryAsync<LoginResult>(SP,
                    new
                    {
                        UserName = UserName,
                        Password = Password,
                        ApplicationType = ApplicationType

                    }, commandType: CommandType.StoredProcedure);
               
                return loginUser.ToList();
            }
        }

        
    }
}
