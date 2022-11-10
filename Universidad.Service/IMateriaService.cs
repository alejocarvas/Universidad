using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Universidad.Data.Model;

namespace Universidad.Service
{
    public interface IMateriaService
    {
        Task<List<Materia>> Get();
        Task<Materia> GetById(int id);
        Task<int> Post(Materia materia);
        Task<Materia> Put(Materia materia);
        Task<bool> Delete(Materia materia);
    }
}
