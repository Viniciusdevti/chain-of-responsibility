using Chain_of_Responsibility.Model;
using Chain_of_Responsibility.Service;
using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta("3000", "Vinicius Alexandre");

            var request = new Requisicao(Formato.PORCENTO);
             request.RealizaRequisicao(conta);

            Console.ReadLine();
        }
    }
}
