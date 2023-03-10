# chain-of-responsibility
Projeto utilizando o padrão chain of responsibility

Nesse projeto foram implementadas algumas classes de requests, que apenas retorna uma string de acordo com o tipo.
Definimos então uma interface IRequisicao, que vai conter uma propriedade com o tipo próprio de Requisição, chamada próximo, e o método comum a todas as classes.
Ao chamar o método RealizaRequisicao no program, criamos as instâncias das classes e passamos por parâmetro a instância da classe anterior pelo construtor. Como as classes implementam a interface IRequisicao, poderá ser qualquer uma das classes. A classe que fará a última verificação não terá, não precisará receber o próximo, pois a cadeia finaliza nela.
No caso a RequisicaoPorcentagem é criada sem passar o parâmetro próximo, pois será a última a ser chamada.
