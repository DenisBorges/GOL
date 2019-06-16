using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Domain
{
    public interface IAirplaneRepository : IBaseRepository<Airplane>
    {

        Airplane PesquisarPorCodigo(int codigo_do_aviao);
    }
}
