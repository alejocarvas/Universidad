using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Data.Model;
using Universidad.Data.UnitOfWork;

namespace Universidad.Service
{
    public class EstudianteService : IEstudianteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EstudianteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> Delete(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Estudiante>> Get()
        {
            var estudiantes = await _unitOfWork.Estudiantes.Get();
            return estudiantes.ToList();
        }

        public async Task<Estudiante> GetById(int id)
        {
            var estudiante = await _unitOfWork.Estudiantes.GetById(id);
            return estudiante;
        }

        public async Task<int> Post(Estudiante estudiante)
        {
            var id = await _unitOfWork.Estudiantes.Insert(estudiante);
            return id;
        }

        public async Task<Estudiante> Put(Estudiante estudiante)
        {
            var estudianteToUpdate = await _unitOfWork.Estudiantes.GetById(estudiante.Id);

            estudianteToUpdate.Correo = estudiante.Correo;
            estudianteToUpdate.Telefono = estudiante.Telefono;
            estudianteToUpdate.Documento = estudiante.Documento;
            estudianteToUpdate.TipoDocumento = estudiante.TipoDocumento;

            await _unitOfWork.Estudiantes.Update(estudianteToUpdate);

            return estudianteToUpdate;
        }
    }
}
