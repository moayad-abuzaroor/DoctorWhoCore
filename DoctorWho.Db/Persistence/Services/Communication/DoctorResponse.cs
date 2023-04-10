using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services.Communication
{
    public class DoctorResponse : BaseResponse
    {
        public Doctor Doctor { get; set; }
        public DoctorResponse(bool success, string message, Doctor doctor) : base(success, message)
        {
            Doctor = doctor;
        }
        public DoctorResponse(Doctor doctor) : this(true, string.Empty, doctor) { }
        public DoctorResponse(string message) : this(false, message, null) { }
        
    }
}
