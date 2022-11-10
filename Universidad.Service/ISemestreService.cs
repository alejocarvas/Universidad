using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Universidad.Data.Model;

namespace Universidad.Service
{
    public interface ISemestreService
    {
        Task<List<Semestre>> Get();
        Task<Semestre> GetById(int id);
        Task<int> Post(Semestre semestre);
        Task<Semestre> Put(Semestre semestre);
        Task<bool> Delete(Semestre semestre);
    }
}
