using System;
using System.Collections.Generic;
using System.Text;
using universidad.Data.Repository.Base;
using universidad.Data.Repository.Intefaces;
using Universidad.Data.Model;

namespace universidad.Data.Repository.Implement
{
    public class EstudianteRepository : Repository<Estudiante>, IEstudanteRespository
    {
        public EstudianteRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
