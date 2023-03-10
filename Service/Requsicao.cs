using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility.Service
{
    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }


        public void RealizaRequisicao(Conta conta)
        {
            var verificaRequestPorcentagem = new RequisicaoPorcentagem();
            var verificarRequestCsv = new RequisicaoCsv(verificaRequestPorcentagem);
            var verificaRequestXml = new RequisicaoXml(verificarRequestCsv);

            verificaRequestXml.VerificaTipoRequesicao(Formato, conta);
        }
    }
}
