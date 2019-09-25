# LivrariaApi
Atividade Aula 3

1. A API está distribuida em recursos separados. Um relacionado a pedidos(Carrinho e Pedido) e o outro aos livros.
1. As rotas estão padronizadas em "v1/public/..." com seu substantivo relacionado complementando
1. Cada entidade tem suas operações necessárias mapeadas
1. As rotas estão organizadas de acordo com sua entidade no formato colecao e colecao/item
1. è possivel apagar os comentario em lote passando os id dos livros desejados
1. As Datas estão sendo retornadas no formato ISO 8601
1. A API está documentada com a ajuda do Swagger
1. A API roda em uma conexão HTTPS
1. A primeira parte da rota é referente a versão da API, assim se necessário criar outra versão é preciso apenas trocar o prefixo v1
1. Ao listar é possivel informa a quantidade de registros desejados e qual registro iniciar a busca
1. Erros diferentes são retornados de acordo com a situação encontrada na requisição. Dados não informados, por exemplo, retornam Bad request