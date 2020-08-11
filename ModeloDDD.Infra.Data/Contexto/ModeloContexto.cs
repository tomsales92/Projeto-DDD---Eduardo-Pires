using ModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDDD.Infra.Data.Contexto
{
    public class ModeloContexto : DbContext
    {
        public ModeloContexto()
            :base("ModeloDDD")
        {
               
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
