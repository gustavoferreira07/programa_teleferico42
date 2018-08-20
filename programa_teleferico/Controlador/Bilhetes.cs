using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teleferico.Controlador
{
    class Bilhetes
    {
       public string Tipo_bilhetes {get;set;}
       public int Qtde_bilhetes { get; set; }

       public Bilhetes(string tipo_bilhetes, int qtde_bilhetes)
        {
            this.Tipo_bilhetes = tipo_bilhetes;
            this.Qtde_bilhetes = qtde_bilhetes;
  
           }

       public Bilhetes()
       {

       }
    }
}
