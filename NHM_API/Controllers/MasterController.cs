using BOL.Model;
using DAL.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NHM_API.Responses;
using System.Net;

namespace NHM_API.Controllers
{
    [Route("Master")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private IConfiguration config;
        private readonly IMasterRepository masterRepository;
     
        RequestResponse res;
        public MasterController(IConfiguration _config, IMasterRepository _masterRepository)
        {
            res = new RequestResponse();
            this.masterRepository = _masterRepository;
            this.config = _config;
        }

        
        #region User
        [Authorize]
        [HttpPost("Post_M_User_Insert")]
        public async Task<IActionResult> Post_M_User_Insert([FromForm] User_Insert_Model userInsert)
        {
            try
            {
                var result = await masterRepository.M_User_Insert(userInsert);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "User Created Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "User Name Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }
        
        [Authorize]
        [HttpPatch("Patch_M_User_Update")]
        public async Task<IActionResult> Patch_M_User_Update([FromForm] User_Update_Model userUpdate)
        {
            try
            {
                var result = await masterRepository.M_User_Update(userUpdate);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "User Updated Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "User Name Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("M_User_Delete")]
        public async Task<IActionResult> M_User_Delete([FromForm] User_Delete_Model userDelete)
        {
            try
            {
                var result = await masterRepository.M_User_Delete(userDelete);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "User Deleted successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record Not Exists For Delete";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpGet("Get_M_User_Select")]
        public async Task<IActionResult> Get_M_User_Select(int M_AreaID, int M_RoleID, string? UserName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_User_Select(M_AreaID, M_RoleID, UserName, M_UserID, FromTop, ToTop, Flag);
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
        #endregion

        #region SpecialtyName
        [Authorize]
        [HttpPost("Post_M_SpecialtyName_Insert")]
        public async Task<IActionResult> Post_M_SpecialtyName_Insert([FromForm] SpecialtyName_Insert_Model specialtyInsert)
        {
            try
            {
                var result = await masterRepository.M_SpecialtyName_Insert(specialtyInsert);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialty Name Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialty Name Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_SpecialtyName_Update")]
        public async Task<IActionResult> Patch_M_SpecialtyName_Update([FromForm] SpecialtyName_Update_Model specialtyUpdate)
        {
            try
            {
                var result = await masterRepository.M_SpecialtyName_Update(specialtyUpdate);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialty Name Updated Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialty Name Already Present";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record not Exits";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("M_SpecialtyName_Delete")]
        public async Task<IActionResult> M_SpecialtyName_Delete([FromForm] SpecialtyName_Delete_Model specialtyDelete)
        {
            try
            {
                var result = await masterRepository.M_SpecialtyName_Delete(specialtyDelete);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialty Name Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record not Exits";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = result;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
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
        [HttpGet("Get_M_SpecialtyName_Select")]
        public async Task<IActionResult> Get_M_SpecialtyName_Select(int M_SpecialtyNameID, string? SpecialtyName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_SpecialtyName_Select(M_SpecialtyNameID, SpecialtyName, M_UserID, FromTop, ToTop, Flag);
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
        #endregion

        #region Specialization
        [Authorize]
        [HttpPost("Post_M_Specialization_Insert")]
        public async Task<IActionResult> Post_M_Specialization_Insert([FromForm] Specialization_Insert_Model specializationInsert)
        {
            try
            {
                var result = await masterRepository.M_Specialization_Insert(specializationInsert);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialization Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialization Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_Specialization_Update")]
        public async Task<IActionResult> Patch_M_Specialization_Update([FromForm] Specialization_Update_Model specializationUpdate)
        {
            try
            {
                var result = await masterRepository.M_Specialization_Update(specializationUpdate);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialization Updated Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialization Already Present";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record not Exits";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
        [HttpDelete("M_Specialization_Delete")]
        public async Task<IActionResult> M_Specialization_Delete([FromForm] Specialization_Delete_Model specializationDelete)
        {
            try
            {
                var result = await masterRepository.M_Specialization_Delete(specializationDelete);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Specialization Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record not Exits";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = result;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
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
        [HttpGet("Get_M_Specialization_Select")]
        public async Task<IActionResult> Get_M_Specialization_Select(int M_SpecializationID, int M_SpecialtyNameID, string? SpecializationName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_Specialization_Select(M_SpecializationID, M_SpecialtyNameID, SpecializationName, M_UserID, FromTop, ToTop, Flag);
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
        #endregion

        #region M_Equipments

        [Authorize]
        [HttpPost("Post_M_Equipments_Insert")]
        public async Task<IActionResult> Post_M_Equipments_Insert([FromForm] M_Equipments_Insert_Model equipmentsInsert)
        {
            try
            {
                var result = await masterRepository.M_Equipments_Insert(equipmentsInsert);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }
        
        [Authorize]
        [HttpPatch("Patch_M_Equipments_Update")]
        public async Task<IActionResult> Patch_M_Equipments_Update([FromForm] M_Equipments_Update_Model equipmentsUpdate)
        {
            try
            {
                var result = await masterRepository.M_Equipments_Update(equipmentsUpdate);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Updated Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_Equipments_Delete")]
        public async Task<IActionResult> M_Equipments_Delete([FromForm] M_Equipments_Delete_Model equipmentsDelete)
        {
            try
            {
                var result = await masterRepository.M_Equipments_Delete(equipmentsDelete);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Equipments Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record not Exit";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                       
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_Equipments_Select")]
        public async Task<IActionResult> Get_M_Equipments_Select(int M_EquipmentsID, string? EquipmentName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_Equipments_Select(M_EquipmentsID,  EquipmentName, M_UserID, FromTop, ToTop, Flag);
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
        #endregion

        #region M_InstitutionsType

        [Authorize]
        [HttpPost("Post_M_InstitutionsType_Insert")]
        public async Task<IActionResult> Post_M_InstitutionsType_Insert([FromForm] M_InstitutionsType_Insert_Model institutionsTypeInsert)
        {
            try
            {
                var result = await masterRepository.M_InstitutionsType_Insert(institutionsTypeInsert);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "InstitutionsType Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "InstitutionsType Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_InstitutionsType_Update")]
        public async Task<IActionResult> Patch_M_InstitutionsType_Update([FromForm] M_InstitutionsType_Update_Model institutionsTypeUpdate)
        {
            try
            {
                var result = await masterRepository.M_InstitutionsType_Update(institutionsTypeUpdate);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "InstitutionsType Updated Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "EquipmenInstitutionsTypets Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_InstitutionsType_Delete")]
        public async Task<IActionResult> M_InstitutionsType_Delete([FromForm] M_InstitutionsType_Delete_Model institutionsTypeDelete)
        {
            try
            {
                var result = await masterRepository.M_InstitutionsType_Delete(institutionsTypeDelete);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "InstitutionsType Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Record not Exit";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }

                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_InstitutionsType_Select")]
        public async Task<IActionResult> Get_M_InstitutionsType_Select(int M_InstitutionsTypeID, string? InstitutionsType, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_InstitutionsType_Select(M_InstitutionsTypeID, InstitutionsType, M_UserID, FromTop, ToTop, Flag);
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
        #endregion

        #region M_SubInstitutionsType
        [Authorize]
        [HttpPost("Post_M_SubInstitutionsType_Insert")]
        public async Task<IActionResult> Post_M_SubInstitutionsType_Insert([FromForm] M_SubInstitutionsType_Insert_Model SubInstitutionsTypeInsert)
        {
            try
            {
                var result = await masterRepository.M_SubInstitutionsType_Insert(SubInstitutionsTypeInsert);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "SubInstitutionsType Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "SubInstitutionsType Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_SubInstitutionsType_Update")]
        public async Task<IActionResult> Patch_M_SubInstitutionsType_Update([FromForm] M_SubInstitutionsType_Update_Model SubInstitutionsTypeUpdate)
        {
            try
            {
                var result = await masterRepository.M_SubInstitutionsType_Update(SubInstitutionsTypeUpdate);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "SubInstitutionsType Update Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "SubInstitutionsType Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_SubInstitutionsType_Delete")]
        public async Task<IActionResult> M_SubInstitutionsType_Delete([FromForm] M_SubInstitutionsType_Delete_Model SubInstitutionsTypeDelete)
        {
            try
            {
                var result = await masterRepository.M_SubInstitutionsType_Delete(SubInstitutionsTypeDelete);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "SubInstitutionsType Delete Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "SubInstitutionsType Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_SubInstitutionsType_Select")]
        public async Task<IActionResult> Get_M_SubInstitutionsType_Select(int M_SubInstitutionsType, int M_InstitutionsTypeID, string? SubInstitutionsName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_SubInstitutionsType_Select(M_SubInstitutionsType, M_InstitutionsTypeID, SubInstitutionsName, M_UserID, FromTop, ToTop, Flag);
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
                return Ok(res);
            }

        }
        #endregion

        #region Area
        [Authorize]
        [HttpPost("Post_M_Area_Insert")]
        public async Task<IActionResult> Post_M_Area_Insert([FromForm] M_Area_Insert_Model area_Insert_Model)
        {
            try
            {
                var result = await masterRepository.M_Area_Insert(area_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Area Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Area Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_Area_Update")]
        public async Task<IActionResult> Patch_M_Area_Update([FromForm] M_Area_Update_Model area_Update_Model)
        {
            try
            {
                var result = await masterRepository.M_Area_Update(area_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Area Update Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Area Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_Area_Delete")]
        public async Task<IActionResult> M_Area_Delete([FromForm] M_Area_Delete_Model area_Delete_Model)
        {
            try
            {
                var result = await masterRepository.M_Area_Delete(area_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Area Deleted Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Area Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_Area_Select")]
        public async Task<IActionResult> Get_M_Area_Select(int M_AreaID, int M_AreaTypeID, string? AreaName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_Area_Select(M_AreaID, M_AreaTypeID, AreaName, M_UserID, FromTop, ToTop, Flag);
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
                return Ok(res);
            }

        }
        #endregion

        #region Qualification
        [Authorize]
        [HttpPost("Post_M_Qualification_Insert")]
        public async Task<IActionResult> Post_M_Qualification_Insert([FromForm] M_Qualification_Insert_Model qualification_Insert_Model)
        {
            try
            {
                var result = await masterRepository.M_Qualification_Insert(qualification_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualification Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualification Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_Qualification_Update")]
        public async Task<IActionResult> Patch_M_Qualification_Update([FromForm] M_Qualification_Update_Model qualification_Update_Model)
        {
            try
            {
                var result = await masterRepository.M_Qualification_Update(qualification_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualification Update Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualification Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_Qualification_Delete")]
        public async Task<IActionResult> M_Qualification_Delete([FromForm] M_Qualification_Delete_Model qualification_Delete_Model)
        {
            try
            {
                var result = await masterRepository.M_Qualification_Delete(qualification_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualification Delete Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Qualification Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_Qualification_Select")]
        public async Task<IActionResult> Get_M_Qualification_Select(int M_QualificationID,  string? Qualification, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_Qualification_Select(M_QualificationID,  Qualification, M_UserID, FromTop, ToTop, Flag);
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
                return Ok(res);
            }

        }
        #endregion

        #region Signing_Designation
        [Authorize]
        [HttpPost("Post_M_Signing_Designation_Insert")]
        public async Task<IActionResult> Post_M_Signing_Designation_Insert([FromForm] M_SigningDesign_Insert_Model design_Insert_Model)
        {
            try
            {
                var result = await masterRepository.M_Signing_Designation_Insert(design_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Designation Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Designation Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_Signing_Designation_Update")]
        public async Task<IActionResult> Patch_M_Signing_Designation_Update([FromForm] M_SigningDesign_Update_Model design_Update_Model)
        {
            try
            {
                var result = await masterRepository.M_Signing_Designation_Update(design_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Designation Update Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Designation Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_Signing_Designation_Delete")]
        public async Task<IActionResult> M_Signing_Designation_Delete([FromForm] M_SigningDesign_Delete_Model design_Delete_Model)
        {
            try
            {
                var result = await masterRepository.M_Signing_Designation_Delete(design_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Designation Delete Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Designation Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_Signing_Designation_Select")]
        public async Task<IActionResult> Get_M_Signing_Designation_Select(int M_Signing_DesignationID, string? DesignationName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_Signing_Designation_Select(M_Signing_DesignationID, DesignationName, M_UserID, FromTop, ToTop, Flag);
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
                return Ok(res);
            }

        }
        #endregion

        #region
        [Authorize]
        [HttpPost("Post_M_District_Insert")]
        public async Task<IActionResult> Post_M_District_Insert([FromForm] M_District_Insert_Model District_Insert_Model)
        {
            try
            {
                var result = await masterRepository.M_District_Insert(District_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "District Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "District Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_District_Update")]
        public async Task<IActionResult> Patch_M_District_Update([FromForm] M_District_Update_Model District_Update_Model)
        {
            try
            {
                var result = await masterRepository.M_District_Update(District_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "District Update Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "District Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }
        
        [Authorize]
        [HttpDelete("M_District_Delete")]
        public async Task<IActionResult> M_District_Delete([FromForm] M_District_Delete_Model District_Delete_Model)
        {
            try
            {
                var result = await masterRepository.M_District_Delete(District_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "District Delete Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "District Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        } 
        
        [Authorize]
        [HttpGet("Get_M_District_Select")]
        public async Task<IActionResult> Get_M_District_Select(int M_DistrictID, int M_StateID,string? DistrictName, int M_UserID,int FromTop,int ToTop,string Flag)
        {
            try
            {
                var result = await masterRepository.M_District_Select(M_DistrictID, M_StateID, DistrictName, M_UserID, FromTop, ToTop, Flag);
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
                return Ok(res);
            }

        }
        #endregion

        #region M_Taluka_Insert

        [Authorize]
        [HttpPost("Post_M_Taluka_Insert")]
        public async Task<IActionResult> Post_M_Taluka_Insert([FromForm] M_Taluka_Insert_Model Taluka_Insert_Model)
        {
            try
            {
                var result = await masterRepository.M_Taluka_Insert(Taluka_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Taluka Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Taluka Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpPatch("Patch_M_Taluka_Update")]
        public async Task<IActionResult> Patch_M_Taluka_Update([FromForm] M_Taluka_Update_Model Taluka_Update_Model)
        {
            try
            {
                var result = await masterRepository.M_Taluka_Update(Taluka_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Taluka Update Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Taluka Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_Taluka_Delete")]
        public async Task<IActionResult> M_Taluka_Delete([FromForm] M_Taluka_Delete_model Taluka_Delete_Model)
        {
            try
            {
                var result = await masterRepository.M_Taluka_Delete(Taluka_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Taluka Delete Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Taluka Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_Taluka_Select")]
        public async Task<IActionResult> Get_M_Taluka_Select(int M_AreaTypeID, int M_TalukaID, int M_DistrictID, string? TalukaName, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_Taluka_Select(M_AreaTypeID,M_TalukaID, M_DistrictID, TalukaName, M_UserID, FromTop, ToTop, Flag);
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
                return Ok(res);
            }

        }

        #endregion

        #region M_Taluka_Insert

        [Authorize]
        [HttpPost("Post_M_Fees_Insert")]
        public async Task<IActionResult> Post_M_Fees_Insert([FromForm] M_Fees_Insert_Model Fees_Insert_Model)
        {
            try
            {
                var result = await masterRepository.M_Fees_Insert(Fees_Insert_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Insert Added Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Insert Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }
        }

        [Authorize]
        [HttpPatch("Patch_M_Fees_Update")]
        public async Task<IActionResult> Patch_M_Fees_Update([FromForm] M_Fees_Update_Model Fees_Update_Model)
        {
            try
            {
                var result = await masterRepository.M_Fees_Update(Fees_Update_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Fees Update Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Fees Already in Used";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpDelete("M_Fees_Delete")]
        public async Task<IActionResult> M_Fees_Delete([FromForm] M_Fees_Delete_Model Fees_Delete_Model)
        {
            try
            {
                var result = await masterRepository.M_Fees_Delete(Fees_Delete_Model);
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        if (item.Responsecode == 1)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Fees Delete Successfully";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 2)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Fees Not Exists";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                        else if (item.Responsecode == 3)
                        {
                            res.Code = Convert.ToInt32(HttpStatusCode.OK);
                            res.Message = "Please Provided Proper Data";
                            res.Data = result;
                            res.Status = true;
                            return Ok(res);
                        }
                    }
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
                    res.Status = true;
                    return Ok(res);
                }
                else
                {
                    res.Code = Convert.ToInt32(HttpStatusCode.NotModified);
                    res.Message = "Something went to wrong";
                    res.Data = null;
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
                return Ok(res);
            }

        }

        [Authorize]
        [HttpGet("Get_M_Fees_Select")]
        public async Task<IActionResult> Get_M_Fees_Select(int M_FeesID, string? Charges, int M_UserID, int FromTop, int ToTop, string Flag)
        {
            try
            {
                var result = await masterRepository.M_Fees_Select(M_FeesID, Charges, M_UserID, FromTop, ToTop, Flag);
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
                return Ok(res);
            }

        }

        #endregion
    }
}
