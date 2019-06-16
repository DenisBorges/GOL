using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Application.IApplication
{
    public interface IBaseApplication<T>
    {
        IEnumerable<T> Listar();
        void Inserir(T registro);
        void Atualizar(T registro);
        void Apagar(T registro);
        T PesquisarPorId(int id);
    }
}
