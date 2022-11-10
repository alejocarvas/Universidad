using System;
using System.Collections.Generic;
using System.Text;
using universidad.Data.Repository.Base;
using universidad.Data.Repository.Intefaces;
using Universidad.Data.Model;

namespace universidad.Data.Repository.Implement
{
    public class SemestreRepository : Repository<Semestre>, ISemestreRepository
    {
        public SemestreRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
