using BOL.Model;
using DAL.Context;
using DAL.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NHM_API.Responses;
using System.Globalization;
using System.Net;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace NHM_API.Controllers
{
    [Route("Transaction")]
    [ApiController]
    public class TransactionController : Controller
    {
        private readonly string RootDir = "wwwroot\\Upload\\";
        private readonly string NationalityProof = "wwwroot\\Upload\\NationalityProof\\";
        private readonly string SigningAuthorityLetter = "wwwroot\\Upload\\SigningAuthorityLetter\\";
        private readonly string Documents = "wwwroot\\Upload\\Document_"+ DateTime.Now.Year.ToString() + "\\";
        private IConfiguration config;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ITransactionRepository transactionRepository;
        private readonly string WebRootPath;
        RequestResponse res;
        CultureInfo provider = CultureInfo.InvariantCulture;

         public TransactionController(IConfiguration _config, ITransactionRepository _transactionRepository, IHostingEnvironment _hostingEnvironment)
        {
            res = new RequestResponse();
            this.transactionRepository = _transactionRepository;
            this.hostingEnvironment = _hostingEnvironment;
            this.config = _config;
            WebRootPath = _hostingEnvironment.WebRootPath;
        }

        #region Applicant Details
        [HttpPost("Post_M_ApplicantRegister_Insert")]
        public async Task<IActionResult> Post_M_ApplicantRegister_Insert([FromForm] ApplicantRegister_Insert_Model objRegister_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.M_ApplicantRegister_Insert(objRegister_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Your Registration Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Mobile Already in Used";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpPatch("Patch_M_ApplicantRegister_Update")]
        public async Task<IActionResult> Patch_M_ApplicantRegister_Update([FromForm] ApplicantRegister_Update_Model objRegister_Insert_Model)
        {
            try
            {
                string? DateOfBirth = null;
                DateOfBirth = objRegister_Insert_Model.DateOfBirth.ToString();
                DateTime Format;
                if (DateTime.TryParseExact(DateOfBirth, "yyyy-MM-dd", null, DateTimeStyles.None, out Format) == true)
                    objRegister_Insert_Model.DateOfBirth = DateTime.ParseExact(DateOfBirth, "yyyy-MM-dd", provider);

                var result = await transactionRepository.M_ApplicantRegister_Update(objRegister_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {

                            if (objRegister_Insert_Model.NationalityProof != null)
                            {
                                if (!Directory.Exists(RootDir))
                                {
                                    Directory.CreateDirectory(RootDir);
                                }
                                if (!Directory.Exists(NationalityProof))
                                {
                                    Directory.CreateDirectory(NationalityProof);
                                }

                                // Convert base64 string to byte array
                                byte[] NationalityProofDocBytes = Convert.FromBase64String(objRegister_Insert_Model.NationalityProof);
                                var fileName = $"{item.ReturnID}.pdf";
                                var filePath = Path.Combine(Directory.GetCurrentDirectory(), NationalityProof, fileName);
                                System.IO.File.WriteAllBytes(filePath, NationalityProofDocBytes);
                            }
                            else
                            {
                                objRegister_Insert_Model.NationalityProof = null;
                            }

                            if (objRegister_Insert_Model.SigningAuthorityLetter != null)
                            {
                                if (!Directory.Exists(RootDir))
                                {
                                    Directory.CreateDirectory(RootDir);
                                }
                                if (!Directory.Exists(SigningAuthorityLetter))
                                {
                                    Directory.CreateDirectory(SigningAuthorityLetter);
                                }

                                // Convert base64 string to byte array
                                byte[] SigningAuthorityLetterDocBytes = Convert.FromBase64String(objRegister_Insert_Model.SigningAuthorityLetter);

                                var fileName = $"{item.ReturnID}.pdf";
                                var filePath = Path.Combine(Directory.GetCurrentDirectory(), SigningAuthorityLetter, fileName);
                                System.IO.File.WriteAllBytes(filePath, SigningAuthorityLetterDocBytes);
                            }
                            else
                            {
                                objRegister_Insert_Model.SigningAuthorityLetter = null;
                            }

                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Applicant Details Save Successfull";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Mobile Already in Used";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_M_ApplicantRegister_Select")]
        public async Task<IActionResult> Get_M_ApplicantRegister_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.M_ApplicantRegister_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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

        #endregion

        #region Nursing Home
        [Authorize]
        [HttpPatch("Patch_M_NursingHome_Update")]
        public async Task<IActionResult> Patch_M_NursingHome_Update([FromForm] NursingHome_Update_Model objNursingHome_Update_Model)
        {
            try
            {
                string? DateofEstablishment = null;
                DateTime Format;
                if (DateTime.TryParseExact(DateofEstablishment, "yyyy-MM-dd", null, DateTimeStyles.None, out Format) == true)
                    objNursingHome_Update_Model.DateofEstablishment = DateTime.ParseExact(DateofEstablishment, "yyyy-MM-dd", provider);

                var result = await transactionRepository.M_NursingHome_Update(objNursingHome_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Nursing Details Save Successfull";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(res);
            }
        }
        [Authorize]
        [HttpGet("Get_SubInstitutionsType_Select")]
        public async Task<IActionResult> Get_SubInstitutionsType_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.SubInstitutionsType_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, M_UserID);
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
        [HttpGet("Get_M_NursingHome_Select")]
        public async Task<IActionResult> Get_M_NursingHome_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.M_NursingHome_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_CollectionCenter_Insert")]
        public async Task<IActionResult> Post_CollectionCenter_Insert([FromForm] CollectionCenter_Insert_Model objCollectionCenter_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.CollectionCenter_Insert(objCollectionCenter_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Collection Center Insert Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Collection Center Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("CollectionCenter_Delete")]
        public async Task<IActionResult> CollectionCenter_Delete([FromForm] CollectionCenter_Delete_Model objCollectionCenter_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.CollectionCenter_Delete(objCollectionCenter_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Collection Center Delete Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Collection Center Already in Used";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_CollectionCenter_Select")]
        public async Task<IActionResult> Get_CollectionCenter_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.CollectionCenter_Model_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_ProcedureDetails_Insert")]
        public async Task<IActionResult> Post_ProcedureDetails_Insert([FromForm] ProcedureDetails_Insert_Model objProcedureDetails_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.ProcedureDetails_Insert(objProcedureDetails_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Procedure Details Inserted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Procedure Already Exit";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("ProcedureDetails_Delete")]
        public async Task<IActionResult> ProcedureDetails_Delete([FromForm] ProcedureDetails_Delete_Model objProcedureDetails_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.ProcedureDetails_Delete(objProcedureDetails_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Procedure Details Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record not Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_ProcedureDetails_Select")]
        public async Task<IActionResult> Get_ProcedureDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.ProcedureDetails_Model_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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

        #endregion

        #region Infrastructure
        [Authorize]
        [HttpPatch("Patch_Infrastructure_Update")]
        public async Task<IActionResult> Patch_Infrastructure_Update([FromForm] Infrastructure_Details_Update_Model objNursingHome_Update_Model)
        {
            try
            {

                var result = await transactionRepository.Infrastructure_Update(objNursingHome_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Infrastructure Details Save Successfull";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                res.Code = Convert.ToInt32(HttpStatusCode.NotFound);
                res.Message = "System Error";
                res.Data = ex;
                res.Status = true;
                return Ok(res);
            }
        }

        [Authorize]
        [HttpGet("Get_Infrastructure_Select")]
        public async Task<IActionResult> Get_Infrastructure_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.Infrastructure_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_Equipments_Details_Insert")]
        public async Task<IActionResult> Post_Equipments_Details_Insert([FromForm] Equipments_Insert_Model objEquipments_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.Equipments_Details_Insert(objEquipments_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Details Insert Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("Equipments_Details_Delete")]
        public async Task<IActionResult> Equipments_Details_Delete([FromForm] Equipments_Delete_Model objEquipments_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.Equipments_Details_Delete(objEquipments_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Details Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_Equipments_Details_Select")]
        public async Task<IActionResult> Get_Equipments_Details_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.Equipments_Details_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_SanitaryArrangementPatients_Insert")]
        public async Task<IActionResult> Post_SanitaryArrangementPatients_Insert([FromForm] Patients_Insert_Model objPatients_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.SanitaryArrangementPatients_Insert(objPatients_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Patients Insert Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Patients Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("SanitaryArrangementPatients_Delete")]
        public async Task<IActionResult> SanitaryArrangementPatients_Delete([FromForm] Patients_Delete_Model objPatients_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.SanitaryArrangementPatients_Delete(objPatients_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Patients Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Patients Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_SanitaryArrangementPatients_Select")]
        public async Task<IActionResult> Get_SanitaryArrangementPatients_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.Patients_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_SanitaryArrangementEmployees_Insert")]
        public async Task<IActionResult> Post_SanitaryArrangementEmployees_Insert([FromForm] Employees_Insert_Model objEmployees_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.SanitaryArrangementEmployees_Insert(objEmployees_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Employees Insert Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Employees Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("SanitaryArrangementEmployees_Delete")]
        public async Task<IActionResult> SanitaryArrangementEmployees_Delete([FromForm] Employees_Delete_Model objEmployees_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.SanitaryArrangementEmployees_Delete(objEmployees_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Employees Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Sanitary Arrangement Employees Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_SanitaryArrangementEmployees_Select")]
        public async Task<IActionResult> Get_SanitaryArrangementEmployees_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.Employees_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_RoomsForEmployees_Insert")]
        public async Task<IActionResult> Post_RoomsForEmployees_Insert([FromForm] RoomsForEmployees_Insert_Model objRooms_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.RoomsForEmployees_Insert(objRooms_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Rooms For Employees Insert Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Rooms For Employees Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("RoomsForEmployees_Delete")]
        public async Task<IActionResult> RoomsForEmployees_Delete([FromForm] RoomsForEmployees_Delete_Model objRooms_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.RoomsForEmployees_Delete(objRooms_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Rooms For Employees Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Rooms For Employees Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_RoomsForEmployees_Select")]
        public async Task<IActionResult> Get_RoomsForEmployees_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.RoomsForEmployees(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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

        #endregion

        #region Staff
        [Authorize]
        [HttpPatch("Patch_StaffDetails_Update")]
        public async Task<IActionResult> Patch_StaffDetails_Update([FromForm] Staff_Update_Model objStaff_Update_Model)
        {
            try
            {
                var result = await transactionRepository.StaffDetails_Update(objStaff_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Staff Details Save Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Staff Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_Staff_Select")]
        public async Task<IActionResult> Get_Staff_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.Staff_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_EmployeeStaffDetails_Insert")]
        public async Task<IActionResult> Post_EmployeeStaffDetails_Insert([FromForm] EmployeeStaffDetails_Insert_Model objStaffDetails_Insert_Model)
        {
            try
            {
                var result = await transactionRepository.EmployeeStaffDetails_Insert(objStaffDetails_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Employee Staff Details Save Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Rooms For Employees Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("EmployeeStaffDetails_Delete")]
        public async Task<IActionResult> EmployeeStaffDetails_Delete([FromForm] EmployeeStaffDetails_Delete_Model objStaffDetails_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.EmployeeStaffDetails_Delete(objStaffDetails_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Employee Staff Details Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Employee Staff Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_EmployeeStaffDetails_Select")]
        public async Task<IActionResult> Get_EmployeeStaffDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.EmployeeStaffDetails_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_PhysiciansSurgeonsDetails_Insert")]
        public async Task<IActionResult> Post_PhysiciansSurgeonsDetails_Insert([FromForm] PhysiciansSurgeonsDetails_Insert_Model objPhysiciansSurgeonsDetails_Model)
        {
            try
            {
                var result = await transactionRepository.PhysiciansSurgeonsDetails_Insert(objPhysiciansSurgeonsDetails_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Physicians Surgeons Details Save Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Physicians Surgeons Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("PhysiciansSurgeonsDetails_Delete")]
        public async Task<IActionResult> PhysiciansSurgeonsDetails_Delete([FromForm] PhysiciansSurgeonsDetails_Delete_Model objSurgeonsDetails_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.PhysiciansSurgeonsDetails_Delete(objSurgeonsDetails_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Physicians Surgeons Details Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Physicians Surgeons Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_PhysiciansSurgeonsDetails_Select")]
        public async Task<IActionResult> Get_PhysiciansSurgeonsDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.PhysiciansSurgeonsDetails_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_QualifiedNurseDetails_Insert")]
        public async Task<IActionResult> Post_QualifiedNurseDetails_Insert([FromForm] QualifiedNurseDetails_Insert_Model objQualifiedNurseDetails_Model)
        {
            try
            {
                var result = await transactionRepository.QualifiedNurseDetails_Insert(objQualifiedNurseDetails_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse Details Save Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("QualifiedNurseDetails_Delete")]
        public async Task<IActionResult> QualifiedNurseDetails_Delete([FromForm] QualifiedNurseDetails_Delete_Model objQualifiedNurseDetails_Delete_Model)
        {
            try
            {
                var result = await transactionRepository.QualifiedNurseDetails_Delete(objQualifiedNurseDetails_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse Details Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_QualifiedNurseDetails_Select")]
        public async Task<IActionResult> Get_QualifiedNurseDetails_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID,  int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.QualifiedNurseDetails_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_QualifiedNurse_Midwife_Insert")]
        public async Task<IActionResult> Post_QualifiedNurse_Midwife_Insert([FromForm] QualifiedNurse_Midwife_Insert objQualifiedNurseMidwife)
        {
            try
            {
                var result = await transactionRepository.QualifiedNurse_Midwife_Insert(objQualifiedNurseMidwife);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse or Midwife Details Save Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse or Midwife Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("QualifiedNurse_Midwife_Delete")]
        public async Task<IActionResult> QualifiedNurse_Midwife_Delete([FromForm] QualifiedNurse_Midwife_Delete objQualifiedNurseMidwife)
        {
            try
            {
                var result = await transactionRepository.QualifiedNurse_Midwife_Delete(objQualifiedNurseMidwife);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse or Midwife Details Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualified Nurse or Midwife Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_QualifiedNurse_Midwife_Select")]
        public async Task<IActionResult> Get_QualifiedNurse_Midwife_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.QualifiedNurse_Midwife_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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
        [HttpPost("Post_Foreign_Staff_Insert")]
        public async Task<IActionResult> Post_Foreign_Staff_Insert([FromForm] ForeignStaff_Insert_Model objForeign_Staff_Insert)
        {
            try
            {
                var result = await transactionRepository.Foreign_Staff_Insert(objForeign_Staff_Insert);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Foreign Staff Details Save Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Foreign Staff Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("Foreign_Staff_Delete")]
        public async Task<IActionResult> Foreign_Staff_Delete([FromForm] ForeignStaff_Delete_Model objForeign_Staff_Delete)
        {
            try
            {
                var result = await transactionRepository.Foreign_Staff_Delete(objForeign_Staff_Delete);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Foreign Staff Details Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Foreign Staff Details Already Exit";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_Foreign_Staff_Select")]
        public async Task<IActionResult> Get_Foreign_Staff_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.Foreign_Staff_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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

        #endregion      

        #region Declaration
        [Authorize]
        [HttpPatch("Patch_Declaration_Update")]
        public async Task<IActionResult> Patch_Declaration_Update([FromForm] Declaration_Model objDeclaration_Model)
        {
            try
            {
                var result = await transactionRepository.Declaration_Update(objDeclaration_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Declaration Save Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please fill the all details";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please fill the Applicant Details";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 4)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please fill the Nursing Home Details";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 5)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please fill the Infrastructure Details";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 6)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please fill the Staff Details";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }

                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        #endregion

        #region Document
        [Authorize]
        [HttpPost("Post_M_ApplicantRegister_Document_Insert")]
        public async Task<IActionResult> Post_M_ApplicantRegister_Document_Insert([FromForm] Documents_Insert_Model objDocuments_Insert_Model)
        {
            try
            {                
                var result = await transactionRepository.Document_Insert(objDocuments_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            if (objDocuments_Insert_Model.DocumentPath != null)
                            {
                                if (!Directory.Exists(RootDir))
                                {
                                    Directory.CreateDirectory(RootDir);
                                }
                                if (!Directory.Exists(Documents))
                                {
                                    Directory.CreateDirectory(Documents);
                                }
                                if (!Directory.Exists( Documents+Convert.ToString(objDocuments_Insert_Model.M_ApplicantRegisterID)))
                                {
                                    Directory.CreateDirectory( Documents + Convert.ToString(objDocuments_Insert_Model.M_ApplicantRegisterID));
                                }
                                // Convert base64 string to byte array
                                byte[] NationalityProofDocBytes = Convert.FromBase64String(objDocuments_Insert_Model.DocumentPath);
                                var fileName = $"{objDocuments_Insert_Model.M_DocumentID}.pdf";
                                var filePath = Path.Combine(Directory.GetCurrentDirectory(), Documents+ Convert.ToString(objDocuments_Insert_Model.M_ApplicantRegisterID), fileName);
                                System.IO.File.WriteAllBytes(filePath, NationalityProofDocBytes);
                            }      
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Document Save Successfull";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Mobile Already in Used";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = false;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = false;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_M_ApplicantRegister_Document_Select")]
        public async Task<IActionResult> Get_M_ApplicantRegister_Document_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, int M_UserID, string Flag)
        {
            try
            {
                var result = await transactionRepository.Documents_Select(M_FinancialYearID, M_MonthID, M_ApplicantRegisterID, WebRootPath + "Upload/", M_UserID, Flag);
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

        #endregion
    }
}
