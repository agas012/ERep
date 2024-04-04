using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using ERep.Models;
using System.Linq;
using ERep.Pages.Patient;

namespace ERep.Data
{
    public class PatientService : IPatientService
    {
        private readonly DataContext _context;
        private readonly NavigationManager _navigationManager;
        public PatientService(DataContext context, NavigationManager navigationManager)
        {
            _context = context;
            _navigationManager = navigationManager;
        }

        public List<ERep.Models.Patient> Patients { get ; set ; } = new List<ERep.Models.Patient>();
        public List<State> States { get ; set ; } = new List<State>();
        public List<ERep.Models.CSR> CSRs { get; set; } = new List<ERep.Models.CSR>();
        public List<ERep.Models.PartosInfo> PartosInfos { get; set; } = new List<ERep.Models.PartosInfo>();
        //public List<ERep.Models.CesareaMotivo> CesareaMotivos { get; set; } = new List<ERep.Models.CesareaMotivo>();


        public async Task CreatePatient(ERep.Models.Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("patients");
        }
        public async Task LoadPatients()
        {
            Patients = await _context.Patients
                .Include(sh => sh.State)
                .ToListAsync();
        }
        public async Task UpdatePatient(ERep.Models.Patient patient, int id)
        {
            var dbPatient = await _context.Patients.FindAsync(id);
            if (dbPatient == null)
                throw new Exception("Paciente no encontrado. :/");

            _context.Entry(patient).State = EntityState.Modified;
            foreach (var csr in patient.CSRs)
            {
                if (csr.Id != 0)
                {
                    _context.Entry(csr).State = EntityState.Modified;
                }
                else
                {
                    _context.Entry(csr).State = EntityState.Added;
                }
            }
            var idsofcsr = patient.CSRs.Select(x => x.Id).ToList();
            var csrToDelete = await _context
                .CSRs
                .Where(x => !idsofcsr.Contains(x.Id) && x.PatientId == patient.Id)
                .ToListAsync();
            _context.RemoveRange(csrToDelete);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("patients");
        }
        public async Task DeletePatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
                throw new Exception("Patient not found. :/");
            var dbpatient = await _context.Patients
                .Include(sh => sh.State)
                .Include(sh => sh.CSRs)
                .FirstOrDefaultAsync(sh => sh.Id == id);
            var idsOfAddresses = dbpatient.CSRs.Select(x => x.Id).ToList();
            var addressesToDelete = await _context
                .CSRs
                .Where(x => x.PatientId == dbpatient.Id)
                .ToListAsync();
            _context.RemoveRange(addressesToDelete);

            _context.Patients.Remove(dbpatient);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("patients");
        }
        public async Task<ERep.Models.Patient> GetSinglePatient(int id)
        {
            var patient = await _context.Patients
                .Include(h => h.State)
                .Include(c => c.CSRs)
                .FirstOrDefaultAsync(h => h.Id == id);
            if (patient == null)
                throw new Exception("Paciente no encontrado. :/");
            return patient;
        }
        public async Task LoadStates()
        {
            States = await _context.States
                .ToListAsync();
        }


        public async Task CreateCSR(ERep.Models.CSR csr, int id)
        {
            _context.CSRs.Add(csr);
            _context.Entry(csr).State = EntityState.Added;
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo($"/csr/{id}");
        }
        public async Task UpdateCSR(ERep.Models.CSR csr, int id, int idc)
        {
            var dbPatient = await _context.Patients.FindAsync(id);
            if (dbPatient == null)
                throw new Exception("Paciente no encontrado. :/");
            if (csr.Id != 0)
            {
                _context.Entry(csr).State = EntityState.Modified;
            }
            else
            {
                _context.Entry(csr).State = EntityState.Added;
            }
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo($"/csr/{id}");
        }
        public async Task DeleteCSR(ERep.Models.CSR csr, int id, int idc)
        {
            _context.Entry(csr).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo($"/csr/{id}");
        }
        public async Task<ERep.Models.CSR> GetSingleCSR(int id, int idc)
        {
            var patient = await _context.Patients
                .Include(c => c.CSRs)
                .FirstOrDefaultAsync(h => h.Id == id);
            var idsofesclerosis = patient.CSRs.Select(x => x.Id).ToList();
            var csr = await _context.CSRs
                .Include(p => p.PartosInfos)
                //.Include(c => c.CesareaMotivos)
                .FirstOrDefaultAsync(h => h.Id == idc);
            if (csr == null)
                throw new Exception("Cita no encontrado. :/");
            return csr;
        }
    }
}
