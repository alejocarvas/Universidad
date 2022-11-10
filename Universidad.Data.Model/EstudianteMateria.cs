using System;
using System.Collections.Generic;
using System.Text;

namespace Universidad.Data.Model
{
    public class EstudianteMateria
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
    }
}
