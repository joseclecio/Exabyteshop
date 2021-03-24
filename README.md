
# Exabyteshop 

## Loja Virtual e-commerce

### RESUMO/JUSTIFICATIVA

Visto a crescente demanda de vendas de artigos tecnológicos na pandemia, esse sistema propõe uma loja virtual bastante agradável e robusta. Pois um site (sistema) é a principal forma para se estabelecer um bom relacionamento com o consumidor e também é uma forma bastante simples de manter o cliente conectado com o que há de novo, sem as frustrações e incômodos corriqueiros do espaço físico, principalmente em um período de e pós-pandemia.

"Uma das formas que o varejo encontrou para continuar lucrando em meio à crise do novo coronavírus foi o e-commerce. Em março – mês de início do isolamento social em grande parte do Brasil –, de acordo com a ABComm (Associação Brasileira de Comércio Eletrônico), foram criadas 80 mil novas lojas virtuais. Em abril, as vendas online cresceram 47%, com mais de 25 milhões de pedidos em 4 mil e-commerces em todo o país." [Information Management](https://docmanagement.com.br/)

### OBJETIVOS

- Desenvolver uma loja virtual capaz de controlar os estoques, gerenciar perfis, intregação com redes sociais, logs e outras.

## FUNCIONALIDADES

- [ ] Telas de Cadastro e manutenção de usuários 
- [ ] Telas de Cadastro e manutenção de produtos
- [ ] Controle de estoque
  - [ ] Listar produtos com o Estoque
- [ ] Controle de vendas
- [ ] Funcionalidade para adicionar produtos no carrinho
- [ ] Gerenciar Carrinho de compras
- [ ] Telas de finalização de compra
- [ ] Formas de pagamentos (Nessa fase o módulo pode não ser completo)


### DER DO SISTEMA

![DER DO SISTEMA](https://firebasestorage.googleapis.com/v0/b/lojavirtual-c6a7d.appspot.com/o/DER2.0.PNG?alt=media&token=8d008b07-d88c-46de-97ab-375f0db47926)

- Tabela "Usuario":
  - Contém dados básicos genéricos de usuário como ("UsuarioId", "CPF", "Idade", "Nome", "Cep", "Endereco", "EnderecoComplemento" e "Celular".
  - Coluna "Estado": Consta o estado em que a conta do usuário se encontra. Ex: Inativa.
  - Coluna "Tipo": Diferencia o usuário do administrador.
- Tabela "Produto":
  - Contém dados básicos genéricos de produto como ("ProdutoId", "Nome", "Descricao", "Observacao", "Valor", "QtdEstoque", "DataCadastro", "DataAlteracao").
  - Coluna "Estado": Consta o estado em que o determinado produto se encontra. Ex: Ativo.
  - Coluna "UsuarioId": FK da tabela "Usuario".
- Tabela "CompraUsuario":
  - Coluna "ProdutoId" e "UsuarioId": FKs das tabelas "Usuario" e "Product".
  - Coluna "CompraUsuarioId": PK.
  - Coluna "Estado": Esta coluna de número inteiro onde cada número representa um estado do produto em relação a aquele usuário. Ex: 1 - No Carrinho, 2 - Comprado, 3 - Preparação, 4 - Cancelado e etc.

### REQUISITOS NÃO FUNCIONAIS

- Utilizar .NET CORE 3.1+
- Utilizar [EF Core](https://docs.microsoft.com/pt-br/ef/core/) para manipução de dados
- Possuir, pelo menos um, relacionamento 1:1 (um para um)
- Possuir, pelo menos um, relacionamento 1:N (um para muitos)
- Possuir, pelo menos um, relacionamento M:N (muito para muitos)
- Fazer um programa, em C# com Entity Framework, para realizar carga inicial dos dados
- Identity Microsoft: Gerenciamento de usuários
- Framework Front-End: (Ainda não definido)

## Membros da equipe

- [Akeu Andrade](https://github.com/Akeu-Andrade) (líder)
- [Joseclecio](https://github.com/joseclecio)
- [William Fraga](https://github.com/WilliamFraga)

## Dicas, repositórios e materiais úteis

- https://github.com/CBSIIFSLagarto/2021_1_web2
- Documentação sobre [Diretrizes de design de estrutura] 
- [A collection of awesome **.NET CORE** libraries, tools, frameworks, and software](https://github.com/thangchung/awesome-dotnet-core)
- [A collection of awesome **.NET** libraries, tools, frameworks, and software](https://github.com/quozd/awesome-dotnet) - Referência, pois é para .NET e não .NET CORE

### Dicas do GitHub

O github contém várias ferramentas que permitem o gerenciamento projeto, promovendo entre outros recursos a rastreabilidade e o gerenciamento das atividades. Saiba mais nos links abaixo.

- [Gerenciar seu trabalho no GitHub](https://docs.github.com/pt/free-pro-team@latest/github/managing-your-work-on-github)
- [Fechando problemas usando palavras-chave](https://docs.github.com/en/enterprise/2.16/user/github/managing-your-work-on-github/closing-issues-using-keywords)
- [Vinculando uma pull request a um problema](https://docs.github.com/pt/free-pro-team@latest/github/managing-your-work-on-github/linking-a-pull-request-to-an-issue)
- [GitHub: Como posso fechar os dois problemas com a mensagem de confirmação?](https://stackoverflow.com/questions/60027222/github-how-can-i-close-the-two-issues-with-commit-message) 

## Prazo

Data | Descrição
:---:|:---
14/01/2021 | Definição do projeto a ser executado
??/02/2020 | Modelo implementado no EF Core
??/02/2020 | Aplicação que permite a carga incial/teste do modelo implementado com EF Core
??/03/2020 | Entrega de [protótipos](prototipos/prototipos.md) das principais telas do sistema proposto (e que atendam aos itens descritos no REQUISITOS NÃO FUNCIONAIS)

## Project status
Este projeto é uma avaliação da disciplina programação web 2, do período de 2020.2(aulas remotas), do IFS


[Diretrizes de design de estrutura]: https://docs.microsoft.com/pt-br/dotnet/standard/design-guidelines/

## Referências  

https://onlinesites.com.br/blog/5-motivos-para-sua-empresa-ter-um-site/#:~:text=Al%C3%A9m%20de%20credibilidade%2C%20um%20site,de%20valores%2C%20seja%20ele%20como
https://docmanagement.com.br/08/10/2020/5-tecnologias-essenciais-para-o-periodo-pos-pandemia/
