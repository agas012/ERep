using ERep.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ERep.Data
{
    public interface IPatientService
    {
        List<Patient> Patients { get; set; }
        List<State> States { get; set; }
        List<CSR> CSRs { get; set; }
        List<PartosInfo> PartosInfos { get; set; }
        //List<CesareaMotivo> CesareaMotivos { get; set; }
        Task LoadPatients();
        Task<Patient> GetSinglePatient(int id);
        Task CreatePatient(Patient patient);
        Task UpdatePatient(Patient patient, int id);
        Task DeletePatient(int id);
        Task LoadStates();

        Task<CSR> GetSingleCSR(int id, int idc);
        Task UpdateCSR(CSR csr, int id, int idc);
        Task DeleteCSR(CSR csr, int id, int idc);
        Task CreateCSR(CSR csr, int id);

        //Task SaveCaseQuestions(IEnumerable<ERep.Models.CaseQuestion> caseQuestions);
        //Task UpdateCaseQuestions(IEnumerable<ERep.Models.CaseQuestion> caseQuestions, int id);
    }
}
