using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Model
{
    public class Infrastructure_Model
    {
        public int M_ApplicantRegisterID { get; set; }
        public int TotalBeds_NoMaternityBeds { get; set; }
        public int TotalBeds_ICUBeds_Adult { get; set; }

        public int TotalBeds_ICU_Beds_Paed { get; set; }
        public int TotalBeds_Other_Beds { get; set; }
        public int ArrangeImmunizationEmp_M_IndicatorID { get; set; }
        public string? ImmunizationEmp_M_Indicator { get; set; }
        public int MedicalCheckUp_M_IndicatorID { get; set; }
        public string? MedicalCheckUp_M_Indicator { get; set; }
        public string? MedicalCheckUp_InMonth { get; set; }
        public int NursingHomeLand_M_IndicatorID { get; set; }
        public string? NursingHomeLand_M_Indicator { get; set; }
        public string? NursingHome_Purposes { get; set; }
        public int M_Food_StoreID { get; set; }
        public string? M_Food_Store { get; set; }
        public int M_Food_ServiceID { get; set; }
        public string? M_Food_Service { get; set; }
        public int M_UserID { get; set; }
    }
    public class Equipments_Model
    {
        public int M_Equipments_DetailsID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public int M_EquipmentsID { get; set; }
        public string? EquipmentName { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int EquipmentQuantity { get; set; }
        public int M_UserID { get; set; }
    }
    public class Equipments_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The M_Equipments ID field is required")]
        public int M_EquipmentsID { get; set; }
        [Required(ErrorMessage = "The Make field is required")]
        public string? Make { get; set; }
        [Required(ErrorMessage = "The Model field is required")]
        public string? Model { get; set; }
        [Required(ErrorMessage = "The Equipment Quantity field is required")]
        public int EquipmentQuantity { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Equipments_Delete_Model
    {
        [Required(ErrorMessage = "The M_Equipments Details ID field is required")]
        public int M_Equipments_DetailsID { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Patients_Model
    {
        public int PatientsID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public int SanitaryPatients_M_IndicatorID { get; set; }
        public string? SanitaryPatients_M_Indicator { get; set; }
        public string? Quantity { get; set; }
        public string? Remarks { get; set; }
        public int M_UserID { get; set; }
    }
    public class Patients_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }

        [Required(ErrorMessage = "The SanitaryPatients_M_IndicatorID ID field is required")]
        public int SanitaryPatients_M_IndicatorID { get; set; }

        [Required(ErrorMessage = "The SanitaryArrangementQuantity field is required")]
        public string? SanitaryArrangementQuantity { get; set; }

        
        public string? Remarks { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Patients_Delete_Model
    {
        [Required(ErrorMessage = "The SanitaryArrangementPatientsID field is required")]
        public int SanitaryArrangementPatientsID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Employees_Model
    {
        public int EmployeesID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public int SanitaryEmployees_M_IndicatorID { get; set; }
        public string? SanitaryEmployees_M_Indicator { get; set; }
        public string? Quantity { get; set; }
        public string? Remarks { get; set; }
        public int M_UserID { get; set; }
    }
    public class Employees_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }

        [Required(ErrorMessage = "The SanitaryEmployees_M_IndicatorID ID field is required")]
        public int SanitaryEmployees_M_IndicatorID { get; set; }

        [Required(ErrorMessage = "The EmployeesQuantity field is required")]
        public int EmployeesQuantity { get; set; }

        
        public string? Remarks { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Employees_Delete_Model
    {
        [Required(ErrorMessage = "The SanitaryArrangementEmployeesID field is required")]
        public int SanitaryArrangementEmployeesID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class RoomsForEmployees_Model
    {
        public int EmployeesID { get; set; }
        public int M_ApplicantRegisterID { get; set; }
        public int RoomsTypes_M_IndicatorID { get; set; }
        public string? RoomsTypes_M_Indicator { get; set; }
        public string? FloorSpaceArea { get; set; }
        public int NumberOfRooms { get; set; }
        public string? Remarks { get; set; }
        public int M_UserID { get; set; }
    }
    public class RoomsForEmployees_Insert_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }

        [Required(ErrorMessage = "The RoomsTypes_M_IndicatorID ID field is required")]
        public int RoomsTypes_M_IndicatorID { get; set; }

        [Required(ErrorMessage = "The FloorSpaceArea field is required")]
        public decimal FloorSpaceArea { get; set; }

        [Required(ErrorMessage = "The NumberOfRooms field is required")]
        public int NumberOfRooms { get; set; }

        
        public string? Remarks { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }

    }
    public class RoomsForEmployees_Delete_Model
    {
        [Required(ErrorMessage = "The RoomsForEmployeesID field is required")]
        public int RoomsForEmployeesID { get; set; }

        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }
    public class Infrastructure_Details_Update_Model
    {
        [Required(ErrorMessage = "The M_ApplicantRegisterID field is required")]
        public int M_ApplicantRegisterID { get; set; }
        [Required(ErrorMessage = "The TotalBeds_NoMaternityBeds field is required")]
        public int TotalBeds_NoMaternityBeds { get; set; }
        [Required(ErrorMessage = "The TotalBeds_ICUBeds_Adult field is required")]
        public int TotalBeds_ICUBeds_Adult { get; set; }
        [Required(ErrorMessage = "The TotalBeds_ICU_Beds_Paed field is required")]
        public int TotalBeds_ICU_Beds_Paed { get; set; }
        [Required(ErrorMessage = "The TotalBeds_Other_Beds field is required")]
        public int TotalBeds_Other_Beds { get; set; }
        [Required(ErrorMessage = "The ArrangeImmunizationEmp_M_IndicatorID field is required")]
        public int ArrangeImmunizationEmp_M_IndicatorID { get; set; }
        [Required(ErrorMessage = "The ArrangeMedicalCheckUp_M_IndicatorID field is required")]
        public int ArrangeMedicalCheckUp_M_IndicatorID { get; set; }
      
        public string? MedicalCheckUp_InMonth { get; set; }
        [Required(ErrorMessage = "The NursingHomeLandDetails_M_IndicatorID field is required")]
        public int NursingHomeLandDetails_M_IndicatorID { get; set; }      
        public string? NursingHome_Purposes { get; set; }
        [Required(ErrorMessage = "The M_Food_StoreID field is required")]
        public int M_Food_StoreID { get; set; }
        [Required(ErrorMessage = "The M_Food_ServiceID field is required")]
        public int M_Food_ServiceID { get; set; }
        [Required(ErrorMessage = "The M_UserID field is required")]
        public int M_UserID { get; set; }
    }

    

}
