using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services.Communication
{
    public class CompanionResponse : BaseResponse
    {        
        Companion Companion { get; set; }
        public CompanionResponse(bool success, string message, Companion companion) : base(success, message)
        {
            Companion = companion;
        }
        public CompanionResponse(Companion companion) : this(true, string.Empty, companion) { }
        public CompanionResponse(string message) : this(false, message, null) { }

    }
}
