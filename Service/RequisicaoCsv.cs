using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility.Service
{
    class RequisicaoCsv : IRequisicao
    {
        public IRequisicao Proximo { get; set; }

        public RequisicaoCsv (IRequisicao proximaReq)
        {
            this.Proximo = proximaReq;
        }
        public void VerificaTipoRequesicao(Formato formato, Conta conta)
        {
            if (formato == Formato.CSV)
            {

                Console.WriteLine(conta.NomeTitular + ";" + conta.Saldo);
                return;
            }

            Proximo.VerificaTipoRequesicao(formato, conta);
        }
    }
}
