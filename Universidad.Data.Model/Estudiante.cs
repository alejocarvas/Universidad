using System;
using System.Collections.Generic;
using System.Text;

namespace Universidad.Data.Model
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
