using GOL.DataAcess.EntityConfiguration;
using GOL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Text;

namespace GOL.DataAcess
{
    public class Conexao:DbContext
    {
        //METODO OVERIDABLE PARA DEFINIR TIPO DE CONEXAO
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(RetornaConexaoEntity());
        }

        //MAPEAMENTO DA TABELA AIRPLANE
        public DbSet<Airplane> airplane { get; set; }

        //METODO OVERIDABLE PARA DEFINIR MAPEAMENTO DA TABELA AIRPLANE PARA O ENTITY
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AirplaneConfiguration());
        }

        //METODO RETORNA CONEXAO
        private static string RetornaConexaoEntity()
        {
            return "Data Source=localhost; Initial Catalog=GOL; User ID=sa; Password=Pa$$w0rd";
        }
    }
}
