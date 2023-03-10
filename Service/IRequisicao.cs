using Chain_of_Responsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility.Service
{
   public interface IRequisicao
    {
         IRequisicao Proximo { get; set; }
         void VerificaTipoRequesicao(Formato formato, Conta conta);
    }
}
