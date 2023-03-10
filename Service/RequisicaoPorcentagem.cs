using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Chain_of_Responsibility.Service
{
    class RequisicaoPorcentagem : IRequisicao
    {
        public IRequisicao Proximo { get; set; }

      public void VerificaTipoRequesicao(Formato formato, Conta conta)
        {

           Console.WriteLine(conta.NomeTitular + conta.Saldo + "%");
          
        }
    }
    }

