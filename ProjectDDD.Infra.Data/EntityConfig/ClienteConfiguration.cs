using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasColumnName("id_cliente")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnName("ds_nome")
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Sobrenome)
                .HasColumnName("ds_sobrenome")
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .HasColumnName("ds_email")
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Inclusao)
                .HasColumnName("dt_inclusao")
                .IsRequired();

            Property(c => c.Ativo)
                .HasColumnName("is_ativo")
                .IsRequired();

            ToTable("Cliente");
        }
    }
}
