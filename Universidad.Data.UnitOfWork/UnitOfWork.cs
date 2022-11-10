using System;
using System.Collections.Generic;
using System.Text;
using universidad.Data.Repository.Implement;
using universidad.Data.Repository.Intefaces;

namespace Universidad.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(string connectionString)
        {
            Semestre = new SemestreRepository(connectionString);
            Materias = new MateriaRepository(connectionString);
            Estudiantes = new EstudianteRepository(connectionString);
        }

        public IMateriaRepository Materias { get; private set; }
        public IEstudanteRespository Estudiantes { get; private set; }
        public ISemestreRepository Semestre { get; private set; }
    }
}
