
using ModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ModeloDDD.Infra.Data.EntityConfig 
{
    class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(c => c.Nome)
               .IsRequired()
               .HasMaxLength(250);

            Property(c => c.Valor)
              .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
