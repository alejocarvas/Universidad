using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Data.Model;
using Universidad.Data.UnitOfWork;

namespace Universidad.Service
{
    public class MateriaService : IMateriaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MateriaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> Delete(Materia materia)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Materia>> Get()
        {
            var estudiantes = await _unitOfWork.Materias.Get();
            return estudiantes.ToList();
        }

        public async Task<Materia> GetById(int id)
        {
            var estudiante = await _unitOfWork.Materias.GetById(id);
            return estudiante;
        }

        public async Task<int> Post(Materia materia)
        {
            var id = await _unitOfWork.Materias.Insert(materia);
            return id;
        }

        public async Task<Materia> Put(Materia materia)
        {
            var materiaToUpdate = await _unitOfWork.Materias.GetById(materia.Id);

            materiaToUpdate.Nombre = materia.Nombre;
            materiaToUpdate.Codigo = materia.Codigo;

            await _unitOfWork.Materias.Update(materiaToUpdate);

            return materiaToUpdate;
        }
    }
}
