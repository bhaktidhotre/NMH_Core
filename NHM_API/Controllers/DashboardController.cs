using DAL.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHM_API.Responses;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace NHM_API.Controllers
{
    [Route("Dashboard")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly string WebRootPath;
        private IConfiguration config;
        private readonly IDashboardRepository dashboardRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly RequestResponse res;
        public DashboardController(IConfiguration _config, IDashboardRepository _dashboardRepository, IHostingEnvironment _hostingEnvironment)
        {
            this.res = new RequestResponse();
            this.dashboardRepository = _dashboardRepository;
            this.hostingEnvironment = _hostingEnvironment;
            WebRootPath = _hostingEnvironment.WebRootPath;
            config = _config;
        }


        [Authorize]
        [HttpGet("Get_M_ApplicantRegister_Track_View_Grid_Select")]
        public async Task<IActionResult> Get_M_ApplicantRegister_Track_View_Grid_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string Flag, int M_UserID)
        {
            try
            {
                var result = await dashboardRepository.Track_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, Flag, M_UserID);
                if (result.Count() > 0)
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.OK);
                    res.Message = "Successful";
                    res.Data = result;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                    res.Message = "Record Not Found";
                    res.Data = result;
                    res.Status = false;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = false;
                return Ok(res);
            }
        }

        [Authorize]
        [HttpGet("Get_DB_M_ApplicantRegister_MainForm_Select")]
        public async Task<IActionResult> Get_DB_M_ApplicantRegister_MainForm_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID)
        {
            try
            {
                var result = await dashboardRepository.MainForm_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID);
                if (result.Count() > 0)
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.OK);
                    res.Message = "Successful";
                    res.Data = result;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                    res.Message = "Record Not Found";
                    res.Data = result;
                    res.Status = false;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = false;
                return Ok(res);
            }
        }

        [Authorize]
        [HttpGet("Get_M_Application_Submit_Responce")]
        public async Task<IActionResult> Get_M_Application_Submit_Responce(int M_ApplicantRegisterID, int M_UserID)
        {
            try
            {
                var result = await dashboardRepository.M_Application_Submit_Responce(M_ApplicantRegisterID, M_UserID);
                if (result.Count() > 0)
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.OK);
                    res.Message = "Successful";
                    res.Data = result;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                    res.Message = "Record Not Found";
                    res.Data = result;
                    res.Status = false;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = false;
                return Ok(res);
            }
        }

        [Authorize]
        [HttpGet("Get_DB_M_ApplicantRegister_MainForm_Document_Select")]
        public async Task<IActionResult> Get_DB_M_ApplicantRegister_MainForm_Document_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID)
        {
            try
            {
                var result = await dashboardRepository.MainForm_Document_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID);
                if (result.Count() > 0)
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.OK);
                    res.Message = "Successful";
                    res.Data = result;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                    res.Message = "Record Not Found";
                    res.Data = result;
                    res.Status = false;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = false;
                return Ok(res);
            }
        }

    }
}
