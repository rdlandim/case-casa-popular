# Casa popular

Projeto técnico para avaliação DIGIX

## Instação e Tecnologias utilizadas

Para a implementação do projeto foi utilizado a linguagem C# e o .Net 6 como framework escolhido.

https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.401-windows-x64-installer

## Como rodar

```bash
cd api/Casa.Popular.API
dotnet watch run
```

## Estrutura de pastas
O projeto consiste da pasta API, contendo o projeto backend e seu projeto de teste.

### asdasd
```
.
├── API                                 # Contém os arquivos do projeto backend
│   ├── Casa.Popular.API                # API e ponto de entrada do projeto
│   ├── Casa.Popular.Dominio            # ClassLib contendo os modelos do negócio
│   ├── Casa.Popular.Implementacoes     # Implementações concretas das interfaces do projeto
│   ├── Casa.Popular.Interfaces         # Interfaces das regras e modelos do projeto
│   ├── Casa.Popular.Testes             # Testes de Unidades
│   ├── gitignore                       
│   └── Casa.Popular.sln                # Arquivo de solução do .NET 6
└── README.md
```

Eventualmente e se necessário uma pasta APP será criada para conter o frontend e seus testes.


## Patterns utilizados 
Para a implementação deste case técnico foram adotados os padrões Builder e Strategy.
O padrão Builder foi utilizado para instanciar as Famílias de acordo com os requisitos descritos no case para não precisar utilizar uma base de dados.
O padrão Strategy foi utilizado para atender o princípio aberto/fechado. Podemos introduzir novas estratégias sem mudar o contexto da aplicação e sem precisar alterar códigos e estratégias já escritas.
