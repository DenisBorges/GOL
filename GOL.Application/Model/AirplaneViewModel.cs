using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Application
{
    public class AirplaneViewModel
    {
        public int id { get; set; }
        public Int64 codigo_do_aviao { get; set; }
        public string modelo { get; set; }
        public int qtd_passageiros { get; set; }
        public DateTime? dt_criacao_registro { get; set; }
    }
}
