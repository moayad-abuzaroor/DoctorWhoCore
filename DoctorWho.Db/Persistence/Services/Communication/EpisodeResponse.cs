using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services.Communication
{
    public class EpisodeResponse : BaseResponse
    {
        public Episode Episode { get; set; }
        public EpisodeResponse(bool success, string message, Episode episode) : base(success, message)
        {
            Episode = episode;
        }
        public EpisodeResponse(Episode episode) : this(true, string.Empty, episode) { }
        public EpisodeResponse(string message) : this(false, message, null) { }
    }
}
