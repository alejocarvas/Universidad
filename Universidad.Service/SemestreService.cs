using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Data.Model;
using Universidad.Data.UnitOfWork;

namespace Universidad.Service
{
    public class SemestreService : ISemestreService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SemestreService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public Task<bool> Delete(Semestre semestre)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Semestre>> Get()
        {
            var estudiantes = await _unitOfWork.Semestre.Get();
            return estudiantes.ToList();
        }

        public async Task<Semestre> GetById(int id)
        {
            var estudiante = await _unitOfWork.Semestre.GetById(id);
            return estudiante;
        }

        public async Task<int> Post(Semestre semestre)
        {
            var id = await _unitOfWork.Semestre.Insert(semestre);
            return id;
        }

        public Task<Semestre> Put(Semestre semestre)
        {
            throw new NotImplementedException();
        }
    }
}
