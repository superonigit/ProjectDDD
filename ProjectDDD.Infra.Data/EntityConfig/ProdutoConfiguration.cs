using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration: EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("id_produto")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasColumnName("ds_nmproduto")
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Descricao)
                .HasColumnName("ds_descricao")
                .IsRequired()
                .HasMaxLength(120);

            Property(x => x.Preco)
                .HasColumnName("vl_preco")
                .IsRequired()
                .HasColumnType("decimal")
                .HasPrecision(10, 2);

            Property(x => x.Disponivel)
                .HasColumnName("is_disponivel")
                .IsRequired();

            Property(c => c.Inclusao)
                .HasColumnName("dt_inclusao")
                .IsRequired();

            HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.ClienteId);

            ToTable("Produto");
        }

    }
}
