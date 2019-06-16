using GOL.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.DataAcess
{
    public class AirplaneRepository:IAirplaneRepository
    {
        private readonly Conexao _conexao;

        public void Apagar(Airplane registro)
        {
            using(var _conexao = new Conexao())
            {
                _conexao.airplane.Remove(registro);
                _conexao.SaveChanges();
                
            }
        }

        public void Atualizar(Airplane registro)
        {
            using (var _conexao = new Conexao())
            {
                //var item = _conexao.airplane.FirstOrDefault(x => x.id == registro.id);
                //if(item != null)
                //{
                //    _conexao.Entry(item).State = EntityState.Detached;
                //}
                //_conexao.Entry(registro).State = EntityState.Detached;
                //_conexao.Attach(registro);
                _conexao.Entry(registro).State = EntityState.Modified;
                _conexao.SaveChanges();
            }
        }

        public void Inserir(Airplane registro)
        {
            using (var _conexao = new Conexao())
            {
                _conexao.airplane.Add(registro);
                _conexao.SaveChanges();
            }
        }

        public IEnumerable<Airplane> Listar()
        {
            IEnumerable<Airplane> lista = null;

            using (var _conexao = new Conexao())
            {
                lista = _conexao.airplane.ToList();
            }

            return lista;
        }

        public Airplane PesquisarPorCodigo(int codigo_do_aviao)
        {
            Airplane item = null;

            using (var _conexao = new Conexao())
            {
                item = _conexao.airplane.FirstOrDefault(x => x.codigo_do_aviao == codigo_do_aviao);
            }

            return item;
        }

        public Airplane PesquisarPorId(int registro)
        {
            Airplane item = null;

            using (var _conexao = new Conexao())
            {
                item = _conexao.airplane.FirstOrDefault(x => x.id == registro);
            }

            return item;
        }
    }
}
