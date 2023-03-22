using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NapsApi.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public virtual int PatientId { get; set; }
        public virtual int DoctorId { get; set; }

        [ForeignKey("PatientId")]
        public virtual Patient Patients { get; set; }

        [ForeignKey("DoctorId")]
        public virtual Doctor Doctors { get; set; }

        public string Reason{ get; set; }
        public string Venue { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string status  { get; set; }
        


    }
}
