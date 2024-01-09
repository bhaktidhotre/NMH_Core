using DAL.Repository;
using DAL.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NHM_API.Responses;
using System.Net;

namespace NHM_API.Controllers
{
    [Route("CommonDLLData")]
    [ApiController]
    public class CommanDDLController : Controller
    {
        private IConfiguration config;
        private readonly ICommanDDLRepository commanDDLRepository;

        RequestResponse res;
        public CommanDDLController(IConfiguration _config, ICommanDDLRepository _commanDDLRepository)
        {
            res = new RequestResponse();
            this.commanDDLRepository = _commanDDLRepository;
            this.config = _config;
            config = _config;
        }

        [HttpGet("Get_DDL_M_AreaType")]
        public async Task<IActionResult> Get_DDL_M_AreaType(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_AreaType(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }
        
        [Authorize]
        [HttpGet("Get_DDL_M_Area")]
        public async Task<IActionResult> Get_DDL_M_Area(int M_AreaTypeID, int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Area(M_AreaTypeID,M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_Role")]
        public async Task<IActionResult> Get_DDL_M_Role(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Role(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_Designation")]
        public async Task<IActionResult> Get_DDL_M_Designation(int M_RoleID, int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Designation(M_RoleID, M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_UserStatus_Indicator")]
        public async Task<IActionResult> Get_DDL_M_UserStatus_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_UserStatus_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_SpecialtyName")]
        public async Task<IActionResult> Get_DDL_M_SpecialtyName(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_SpecialtyName(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }
        [Authorize]
        [HttpGet("Get_DDL_M_Equipments")]
        public async Task<IActionResult> Get_DDL_M_Equipments(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Equipments(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_SubInstitutionsType")]
        public async Task<IActionResult> Get_DDL_M_SubInstitutionsType(int M_InstitutionsTypeID ,int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_SubInstitutionsType(M_InstitutionsTypeID,M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }
       
        [Authorize]
        [HttpGet("Get_DDL_M_Qualification")]
        public async Task<IActionResult> Get_DDL_M_Qualification(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Qualification(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_Signing_Designation")]
        public async Task<IActionResult> Get_DDL_M_Signing_Designation(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Signing_Designation(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }

            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);   
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_Specialization")]
        public async Task<IActionResult> Get_DDL_M_Specialization(int M_SpecialtyNameID, int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Specialization(M_SpecialtyNameID, M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_State")]
        public async Task<IActionResult> Get_DDL_M_State(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_State(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_InstitutionsType")]
        public async Task<IActionResult> Get_DDL_M_InstitutionsType(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_InstitutionsType(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_District")]
        public async Task<IActionResult> Get_DDL_M_District(int M_StateID, int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_District(M_StateID, M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_Taluka")]
        public async Task<IActionResult> Get_DDL_M_Taluka(int M_DistrictID, int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Taluka(M_DistrictID, M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_TypeofApplicant_Indicator")]
        public async Task<IActionResult> Get_DDL_M_TypeofApplicant_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_TypeofApplicant_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_Nationality_Indicator")]
        public async Task<IActionResult> Get_DDL_M_Nationality_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Nationality_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_Country")]
        public async Task<IActionResult> Get_DDL_M_Country(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_Country(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }
        
        [Authorize]
        [HttpGet("Get_DDL_M_BusinessType")]
        public async Task<IActionResult> Get_DDL_M_BusinessType(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_BusinessType(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_RoomsType_Indicator")]
        public async Task<IActionResult> Get_DDL_RoomsType_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_RoomsType_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_SanitaryArrangementforEmployees_Indicator")]
        public async Task<IActionResult> Get_DDL_SanitaryArrangementforEmployees_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_SanitaryArrangementforEmployees_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_SanitaryArrangementforPatients_Indicator")]
        public async Task<IActionResult> Get_DDL_SanitaryArrangementforPatients_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_SanitaryArrangementforPatients_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }
        
        [Authorize]
        [HttpGet("Get_DDL_M_ServiceFood_Indicator")]
        public async Task<IActionResult> Get_DDL_M_ServiceFood_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_ServiceFood_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }

        [Authorize]
        [HttpGet("Get_DDL_M_StorageFood_Indicator")]
        public async Task<IActionResult> Get_DDL_M_StorageFood_Indicator(int M_UserID, string Flag)
        {
            try
            {
                var result = await commanDDLRepository.DDL_M_StorageFood_Indicator(M_UserID, Flag);
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
                    res.Status = true;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(ex);
            }
        }
    }
}