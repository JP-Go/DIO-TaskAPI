# DIO-TaskAPI

API como solução do desafio do módulo de APIs com C# do bootcamp WEX
Desenvolvimento .NET e QA
([https://web.dio.me/track/bootcamp-wex-desenvolvimento-net-e-qa](https://web.dio.me/track/bootcamp-wex-desenvolvimento-net-e-qa))

## Mudanças
1. Usando Postgress em vez de SQL Server
2. funções em ingles

## Rodando. 

### Requisitos

.NET 7
Docker + docker-compose
.NET EF

1. Clone este projeto e abra a pasta
2. Copie o arquivo .env.example para .env, adicionando as informações do seu banco de dados
3. No terminal, na raiz do projeto, execute `docker-compose up -d`
4. No terminal, execute `dotnet-ef dabase update --project src`
5. No terminal, execute `dotnet watch run` para iniciar

Seu navegador abrirá na documentação da API do projeto

