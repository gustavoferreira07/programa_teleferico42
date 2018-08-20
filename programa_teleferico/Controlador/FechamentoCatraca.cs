using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teleferico.Controlador
{
    class FechamentoCatraca
    {
         public string CodigoCatraca { get; set; }
        public string NomeCatraca { get; set; }
        public string Data { get; set; }
        public int InicialCatraca { get; set; }
        public int FinalCatraca { get; set; }
        public int TotalCatraca { get; set; }
        public int TotalIda { get; set; }
        public int TotalVolta { get; set; }
        public int TotalPU { get; set; }
        public int TotalCortesia { get; set; }
        public string Relatorio { get; set; }

        public FechamentoCatraca(string codigoCatraca, string nomeCatraca, string data, int inicialCatraca,int finalCatraca, int totalCatraca,int totalIda, int totalVolta, int totalPU, int totalCortesia, string relatorio)

        {
            this.CodigoCatraca = codigoCatraca;
            this.NomeCatraca = nomeCatraca;
            this.Data = data;
            this.InicialCatraca = inicialCatraca;
            this.FinalCatraca = finalCatraca;
            this.TotalCatraca = totalCatraca;
            this.TotalIda = totalIda;
            this.TotalVolta = totalVolta;
            this.TotalPU = totalPU;
            this.TotalCortesia = totalCortesia;
            this.Relatorio = relatorio;
        }

        public FechamentoCatraca()
        {
            // TODO: Complete member initialization
        }
    }
}
