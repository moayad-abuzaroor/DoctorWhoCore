using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IRepositories
{
    public interface IUnitOfWork
    {
        Task Complete();
    }
}
