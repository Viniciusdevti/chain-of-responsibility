using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility.Model
{
    public class Conta
    {

       public Conta (string saldo, string nomeTitular)
        {
            this.Saldo = saldo;
            this.NomeTitular = nomeTitular;
        }

        public string Saldo { get; set; }
        public string NomeTitular{ get; set; }
    }
}
