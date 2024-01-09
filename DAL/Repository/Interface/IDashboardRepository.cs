using BOL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IDashboardRepository
    {
        Task<List<Track_View_Grid_Model>> Track_Select(int M_FinancialYearID,int M_MonthID,int M_ApplicantRegisterID, string Flag, int M_UserID);
        Task<List<MainForm_Model>> MainForm_Select(int M_FinancialYearID,int M_MonthID,int M_ApplicantRegisterID,string RootPath,int M_UserID);
        Task<List<MainForm_Document_Model>> MainForm_Document_Select(int M_FinancialYearID, int M_MonthID, int M_ApplicantRegisterID, string RootPath, int M_UserID);
        Task<List<ApplicationSubmit_Responce_model>> M_Application_Submit_Responce(int M_ApplicantRegisterID,int M_UserID);
       
    }
}
