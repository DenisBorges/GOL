using GOL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.DataAcess.EntityConfiguration
{
    public class AirplaneConfiguration : IEntityTypeConfiguration<Airplane>
    {
        public void Configure(EntityTypeBuilder<Airplane> builder)
        {
            //DEFINE NOME DA TABELA
            builder.ToTable("AIRPLANE");

            //DEFINE CHAVES PRIMARIAS E IDENTITY
            builder.HasKey(x =>  x.id );
            builder.Property(x => x.id).ValueGeneratedOnAdd();

            //DEFINE TIPAGEM E TAMANHO DOS CAMPOS TEXT
            builder.Property(x => x.modelo).HasColumnType("NVARCHAR").HasMaxLength(50);
        }
    }
}
