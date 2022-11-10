using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Universidad.Data.Model;

namespace Universidad.Service
{
    public interface IEstudianteService
    {
        Task<List<Estudiante>> Get();
        Task<Estudiante> GetById(int id);
        Task<int> Post(Estudiante estudiante);
        Task<Estudiante> Put(Estudiante estudiante);
        Task<bool> Delete(Estudiante estudiante);
    }
}
