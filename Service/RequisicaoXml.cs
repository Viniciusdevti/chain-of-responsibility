using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Chain_of_Responsibility.Service
{
    class RequisicaoXml : IRequisicao
    {
        public IRequisicao Proximo { get; set; }

        public RequisicaoXml (IRequisicao proximaReq)
        {
            this.Proximo = proximaReq;
        }
        public void VerificaTipoRequesicao(Formato formato, Conta conta)
        {
            if (formato == Formato.XML)
            {

                Console.WriteLine("<conta><titular>" + conta.NomeTitular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
                return;
            }

            Proximo.VerificaTipoRequesicao(formato, conta);

        }
    }
}
