using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NapsApi.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string  Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string NextOfKin { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
