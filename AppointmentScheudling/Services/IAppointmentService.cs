
using AppointmentScheudling.Models.ViewModels;
using System.Collections.Generic;


namespace AppointmentScheudling.Services
{
    public interface IAppointmentService
    {
        public List<DoctorVM> GetDoctorList();
        public List<PatientVM> GetPatientList();
    }
}
