using System;
using System.Collections.Generic;
using System.Text;
using universidad.Data.Repository.Intefaces;

namespace Universidad.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEstudanteRespository Estudiantes { get; }
        IMateriaRepository Materias { get; }
        ISemestreRepository Semestre { get; }
    }
}
