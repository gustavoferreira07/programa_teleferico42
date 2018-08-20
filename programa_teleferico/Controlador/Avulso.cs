using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_teleferico.Controlador
{
    class Avulso
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Endereço { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Tipo { get; set; }

        public Avulso(string nome, string cpf, string celular, string endereço, string banco, string agencia, string conta, string tipo)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Celular = celular;
            this.Endereço = endereço;
            this.Banco = banco;
            this.Agencia = agencia;
            this.Conta = conta;
            this.Tipo = tipo;
        }
        public Avulso() { }
    }
}
