using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Functions {
    public class fnCompanionClass {
        public fnCompanionClass(string companionName) { 
            CompanionName = companionName;
        }

        public string CompanionName { get; set; }
    }
}
