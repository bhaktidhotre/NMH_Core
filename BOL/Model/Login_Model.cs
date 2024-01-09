using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class Login_Model
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? ApplicationType { get; set; }  
        
    }
    public class LoginResult
    {
        public string? access_token { get; set; }
        public string? token_type { get; set; }
        public DateTime expires_in { get; set; }       
        public int M_UserID { get; set; }
        public int M_RoleID { get; set; }
        public int M_AreaTypeID { get; set; }
        public int M_AreaID { get; set; }
        public int M_DesignationID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public string? EmployeeName { get; set; }
        public string? AndroidDeviceID { get; set; }
        public string? Loginmessage { get; set; }
        public int Responsecode { get; set; }
    }
}
