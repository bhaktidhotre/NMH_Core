using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using BOL.Model;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using NHM_API.Responses;
using DAL.Repository.Interface;
using System.Net;

namespace NHM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration config;
        private readonly ILoginRepository loginRepository;
        private readonly RequestResponse res;
         public LoginController(IConfiguration _config, ILoginRepository _loginRepository)
        {
            this.res = new RequestResponse();
            this.loginRepository = _loginRepository;
            config = _config;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/Token")]
        public async Task<IActionResult> Login(Login_Model login_Model)
        {
            try
            {
              List<LoginResult> obj = new List<LoginResult>();
                //var user = Authenticate(login_Model);
                var result =  await loginRepository.LoginToken(login_Model.Username, login_Model.Password, login_Model.ApplicationType);
                    if (result.Count > 0)
                    {
                        var token = GenerateToken(login_Model);
                        for (int i = 0;i < result.Count; i++)
                         {
                            if (result[i].Responsecode != 1)
                            {
                             token = null;
                            }
                            obj.Add(new LoginResult
                            {
                               
                                access_token = token,
                                expires_in = DateTime.Now.AddMinutes(15),
                                token_type = "bearer",
                                M_UserID = result[i].M_UserID,
                                M_RoleID = result[i].M_RoleID,
                                M_AreaTypeID = result[i].M_AreaTypeID,
                                M_AreaID = result[i].M_AreaID,
                                M_DesignationID = result[i].M_DesignationID,
                                EmployeeName = result[i].EmployeeName,
                                AndroidDeviceID = result[i].AndroidDeviceID,
                                M_ApplicantRegisterID = result[i].M_ApplicantRegisterID,
                                Loginmessage = result[i].Loginmessage,
                                Responsecode = result[i].Responsecode,
                            });
                        }
                    var response  = (obj, new { token });
                        return Ok(obj);                        
                    }
                    else
                    {

                        res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                        res.Message = "Record Not Found";
                        res.Data = result;
                        res.Status = true;
                        return Ok();
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                    res.Message = "Something went to wrong";
                    res.Data = result;
                    res.Status = true;
                    return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        // To generate token
        private string GenerateToken(Login_Model login_Model)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,login_Model.Username),
                new Claim(ClaimTypes.Role,login_Model.Password),
            };
           

            var token = new JwtSecurityToken(config["Jwt:Issuer"],
                                    config["Jwt:Audience"],
                                    claims,
                                    expires: DateTime.Now.AddMinutes(15),
                                    signingCredentials: credentials);
            
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        //To authenticate user
        private Login_Model Authenticate(Login_Model login_Model)
        {
            var currentUser = UserConstants.Users.FirstOrDefault(x => x.Username ==
                             login_Model.Username && x.Password == login_Model.Password);
            if (currentUser != null)
            {
                return currentUser;
            }
            return null;
        }

        List<Login_Model> lisMembers = new List<Login_Model>
        {
            new Login_Model{Username="Kirtesh", Password="Shah" },
            new Login_Model{Username="Nitya", Password="Shah"},
            new Login_Model{Username="Dilip", Password="Shah"},
            new Login_Model{Username="Atul", Password="Shah"},
            new Login_Model{Username="Swati", Password="Shah"},
            new Login_Model{Username="Rashmi", Password="Shah"},
        };
        [Authorize]
        [HttpGet]
        [Route("GetLogin")]
        public List<Login_Model> GetLogin()
        {
            try
            {
                return lisMembers;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
