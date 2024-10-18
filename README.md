# Desafio - Web API com Criptografia de Dados Sensíveis

Este projeto faz parte de uma série de desafios propostos pelo repositório [backend-br/desafios](https://github.com/backend-br/desafios).

## Descrição

Neste desafio, foi desenvolvida uma Web API que implementa criptografia de dados sensíveis. A API foi construída utilizando **Entity Framework** para gerenciar o banco de dados em memória, **LINQ** para consultas, e o algoritmo de **SHA-512** para a criptografia dos dados sensíveis, como documentos de usuários e tokens de cartão de crédito.

### Funcionalidades:
- **Criação de usuários** com criptografia aplicada aos campos sensíveis antes do armazenamento.
- **Consultas de usuários** que retornam os dados já criptografados.
- **Atualização** e **deleção** de usuários no banco de dados em memória.
- **Criptografia** transparente dos campos `UserDocument` e `CreditCardToken` usando SHA-512.

## Tecnologias Utilizadas:
- **ASP.NET Core** para construção da Web API.
- **Entity Framework** com banco de dados em memória.
- **LINQ** para manipulação de dados.
- **SHA-512** para criptografia de dados sensíveis.

## Como Rodar o Projeto:
1. ## Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-projeto.git

2. ## Compile e rode o projeto:
   ```bash
   dotnet run
  
3. ## A API estará disponível no endereço:
   ```bash
   https://localhost:{porta}/api/controller
   
## Endpoints:

### POST /api/controller - Adiciona um novo usuário com dados criptografados.
### GET /api/controller/{id} - Retorna os dados de um usuário específico (criptografados).
### GET /api/controller - Retorna todos os usuários (criptografados).
### PUT /api/controller/{id} - Atualiza os dados de um usuário.
### DELETE /api/controller/{id} - Remove um usuário.


## Como Contribuir:
Sinta-se à vontade para contribuir com melhorias ou novas funcionalidades! Basta abrir um pull request ou relatar issues.



