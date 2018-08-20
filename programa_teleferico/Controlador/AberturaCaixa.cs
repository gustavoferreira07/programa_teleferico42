using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teleferico.Controlador
{
    class AberturaCaixa
    {
        public string CodigoAbertura { get; set; }
        public string DataAbertura { get; set; }
        public string Nome_operadorAbertura { get; set; }
        public int TrocoAbertura { get; set; }
        public int BilheteIdaIni1Abertura { get; set; }
        public int BilheteIdaFin1Abertura { get; set; }
        public int BilheteIdaIni2Abertura { get; set; }
        public int BilheteIdaFin2Abertura { get; set; }
        public int BilheteIdaIni3Abertura { get; set; }
        public int BilheteIdaFin3Abertura { get; set; }
        public int BilheteVoltaIni1Abertura { get; set; }
        public int BilheteVoltaFin1Abertura { get; set; }
        public int BilheteVoltaIni2Abertura { get; set; }
        public int BilheteVoltaFin2Abertura { get; set; }
        public int BilheteVoltaIni3Abertura { get; set; }
        public int BilheteVoltaFin3Abertura { get; set; }
        public int BilhetePUIni1Abertura { get; set; }
        public int BilhetePUfin1Abertura { get; set; }
        public int BilhetePUIni2Abertura { get; set; }
        public int BilhetePUfin2Abertura { get; set; }

        public AberturaCaixa(string codigoAbertura, string dataAbertura, string nome_operadorAbertura, int trocoAbertura, int bilheteIdaIni1Abertura, int bilheteIdaFin1Abertura,
            int bilheteIdaIni2Abertura, int bilheteIdafin2Abertura, int bilheteIdaIni3Abertura, int bilheteIdafin3Abertura, int bilheteVoltaIni1Abertura, int bilheteVoltaFin1Abertura, int bilheteVoltaIni2Abertura, int bilheteVoltaFin2Abertura,
            int bilheteVoltaIni3Abertura, int bilheteVoltaFin3Abertura, int bilhetePUIni1Abertura, int bilhetePUFin1Abertura, int bilhetePUIni2Abertura, int bilhetePUFin2Abertura)
    {
        this.CodigoAbertura = codigoAbertura;
        this.DataAbertura = dataAbertura;
        this.Nome_operadorAbertura = nome_operadorAbertura;
        this.TrocoAbertura = trocoAbertura;
        this.BilheteIdaIni1Abertura = bilheteIdaIni1Abertura;
        this.BilheteIdaFin1Abertura = bilheteIdaFin1Abertura;
        this.BilheteIdaIni2Abertura = bilheteIdaIni2Abertura;
        this.BilheteIdaFin2Abertura = bilheteIdafin2Abertura;
        this.BilheteIdaIni3Abertura = bilheteIdaIni3Abertura;
        this.BilheteIdaFin3Abertura = bilheteIdafin3Abertura;
        this.BilheteVoltaIni1Abertura = bilheteVoltaIni1Abertura;
        this.BilheteVoltaFin1Abertura = bilheteVoltaFin1Abertura;
        this.BilheteVoltaIni2Abertura = bilheteVoltaIni2Abertura;
        this.BilheteVoltaFin2Abertura = bilheteVoltaFin2Abertura;
        this.BilheteVoltaIni3Abertura = bilheteVoltaIni3Abertura;
        this.BilheteVoltaFin3Abertura = bilheteVoltaFin3Abertura;
        this.BilhetePUIni1Abertura = bilhetePUIni1Abertura;
        this.BilhetePUfin1Abertura = bilhetePUFin1Abertura;
        this.BilhetePUIni2Abertura = bilhetePUIni2Abertura;
        this.BilhetePUfin2Abertura = bilhetePUFin2Abertura;
       
    }

        public AberturaCaixa()
        {
            // TODO: Complete member initialization
        }
       
    }
}
