using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teleferico.Controlador
{
   public  class AberturaCatraca
    {
        public string CodigoCatraca { get; set; }
        public string NomeCatraca { get; set; }
        public int InicialCatraca { get; set; }
        public string Data { get; set; }
        public AberturaCatraca(string codigoCatraca, string nomeCatraca, int inicialCatraca, string data)
        {
            this.CodigoCatraca = codigoCatraca;
            this.NomeCatraca = nomeCatraca;
            this.InicialCatraca = inicialCatraca;
            this.Data = data;
        }

        public AberturaCatraca()
        {
            // TODO: Complete member initialization
        }

    }
}
