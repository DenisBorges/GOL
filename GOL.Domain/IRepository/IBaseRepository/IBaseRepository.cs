using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Domain
{
    public interface IBaseRepository<T>
    {
        void Inserir(T registro);
        void Atualizar(T registro);
        void Apagar(T registro);
        IEnumerable<T> Listar();
        T PesquisarPorId(int registro);
    }

}
