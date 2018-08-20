using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teleferico.Controlador
{
    class Classep1
    {
       public string Codigo { get; set; }
       public string Data { get; set; }
       public string Nome_operador { get; set; }
       public int Troco { get; set; }
       public int BilheteIdaIni1 { get; set; }
       public int BilheteIdaFin1 { get; set; }
       public int BilheteIdaIni2 { get; set; }
       public int BilheteIdaFin2 { get; set; }
       public int BilheteIdaIni3 { get; set; }
       public int BilheteIdaFin3 { get; set; }
       public int BilheteVoltaIni1 { get; set; }
       public int BilheteVoltaFin1 { get; set; }
       public int BilheteVoltaIni2 { get; set; }
       public int BilheteVoltaFin2 { get; set; }
       public int BilheteVoltaIni3 { get; set; }
       public int BilheteVoltaFin3 { get; set; }
       public int BilhetePUIni1 { get; set; }
       public int BilhetePUfin1 { get; set; }
       public int BilhetePUIni2 { get; set; }
       public int BilhetePUfin2 { get; set; }
       public int TotalVendaIda { get; set; }
       public int TotalDinheiroIda { get; set; }
       public int TotalVendaVolta { get; set; }
       public int TotalDinheiroVolta { get; set; }
       public int TotalVendaPU { get; set; }
       public int TotalDebito { get; set; }
       public int TotalCredito { get; set; }
       public int TotalCartao { get; set; }
       public int TotalDinheiroVendas { get; set; }
       public int Trouxe { get; set; }
       public int Sangria { get; set; }
       public int TotalCaixa { get; set; }
       public string Verificap1 { get; set; }
       public string TotalTrazer { get; set; }
       public string TotalTrouxe { get; set; }

       public Classep1(string codigo, string data, string nome_operador, int troco, int bilheteIdaIni1, int bilheteIdaFin1,
            int bilheteIdaIni2, int bilheteIdafin2,int bilheteIdaIni3, int bilheteIdafin3, int bilheteVoltaIni1,  int bilheteVoltaFin1, int bilheteVoltaIni2,  int bilheteVoltaFin2,
            int bilheteVoltaIni3, int bilheteVoltaFin3, int bilhetePUIni1, int bilhetePUFin1, int bilhetePUIni2, int bilhetePUFin2, int totalVendaIda, int totalDinheiroIda,
            int totalVendaVolta, int totalDinheiroVolta, int totalVendaPU, int totalDebito, int totalCredito, int totalCartao,
            int totalDinheiroVendas, int trouxe, int sangria, int totalCaixa, string verificap1, string totalTrazer, string totalTrouxe)
    {
            this.Codigo= codigo;
            this.Data = data;
            this.Nome_operador=nome_operador;
            this.Troco = troco;
            this.BilheteIdaIni1 = bilheteIdaIni1;
            this.BilheteIdaFin1 = bilheteIdaFin1;
            this.BilheteIdaIni2 = bilheteIdaIni2;
            this.BilheteIdaFin2 = bilheteIdafin2;
            this.BilheteIdaIni3 = bilheteIdaIni3;
            this.BilheteIdaFin3 = bilheteIdafin3;
            this.BilheteVoltaIni1 = bilheteVoltaIni1;
            this.BilheteVoltaFin1 = bilheteVoltaFin1;
            this.BilheteVoltaIni2 = bilheteVoltaIni2;
            this.BilheteVoltaFin2 = bilheteVoltaFin2;
            this.BilheteVoltaIni3 = bilheteVoltaIni3;
            this.BilheteVoltaFin3 = bilheteVoltaFin3;
            this.BilhetePUIni1 = bilhetePUIni1;
            this.BilhetePUfin1 = bilhetePUFin1;
            this.BilhetePUIni2 = bilhetePUIni2;
            this.BilhetePUfin2 = bilhetePUFin2;
            this.TotalVendaIda = totalVendaIda;
            this.TotalDinheiroIda = totalDinheiroIda;
            this.TotalVendaVolta = totalVendaVolta;
            this.TotalDinheiroVolta = totalDinheiroVolta;
            this.TotalVendaPU = totalVendaPU;
            this.TotalDebito = totalDebito;
            this.TotalCredito = totalCredito;
            this.TotalCartao = totalCartao;
            this.Sangria = sangria;
            this.TotalDinheiroVendas = totalDinheiroVendas;
            this.Verificap1 = verificap1;
            this.TotalTrazer = totalTrazer;
            this.TotalTrouxe = totalTrouxe;
            
            

    }
        public  Classep1(){

        }

    }
}
