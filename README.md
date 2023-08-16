# Documentação da API de CRUD de Usuários

Esta documentação apresenta os passos básicos para executar e utilizar a API de CRUD de Usuários, desenvolvida em C# utilizando o Entity Framework.

## Pré-requisitos

Antes de iniciar, certifique-se de que você tenha as seguintes ferramentas instaladas em seu ambiente de desenvolvimento:

- .NET Core SDK - versão 3.1 ou superior
- Visual Studio ou Visual Studio Code (opcional)

## Passos para Execução

Siga as etapas abaixo para executar a API em seu ambiente local:

1. Clone o repositório:

   Abra o terminal de sua preferência e navegue até o diretório em que você deseja clonar o projeto. Execute o seguinte comando para clonar o repositório:
   ```sh
   git clone <URL_DO_SEU_REPOSITORIO>
   ```
2. Configure a conexão com o banco de dados:

Abra o arquivo `appsettings.json` localizado na raiz do projeto. No campo `ConnectionStrings`, configure a conexão com o banco de dados SQL Server. Certifique-se de substituir os valores de `<seu_servidor>`, `<seu_banco_de_dados>`, `<seu_usuario>` e `<sua_senha>` pelos valores corretos:
```json
"ConnectionStrings": {
"DefaultConnection": "Server=<seu_servidor>;Database=<seu_banco_de_dados>;User Id=<seu_usuario>;Password=<sua_senha>;"
}
```

3. Execute as migrações:

Abra o terminal na pasta raiz do projeto e execute os seguintes comandos para criar o banco de dados e aplicar as migrações:
```sh
dotnet ef database update
```

4. Execute a aplicação:

Abra o terminal na pasta raiz do projeto e execute o seguinte comando para iniciar a aplicação:
```sh
dotnet run
```

A API estará acessível através do seguinte URL: `https://localhost:5001`.

## Uso da API

A API oferece endpoints para realizar operações de CRUD em usuários:

- GET /api/users: Retorna a lista de todos os usuários cadastrados.
- GET /api/users/{id}: Retorna as informações de um usuário específico com base no ID fornecido.
- POST /api/users: Cria um novo usuário. Envie um JSON com os dados do usuário no corpo da requisição.
- PUT /api/users/{id}: Atualiza as informações de um usuário específico com base no ID fornecido. Envie um JSON com os dados atualizados no corpo da requisição.
- DELETE /api/users/{id}: Deleta um usuário específico com base no ID fornecido.

Certifique-se de fazer requisições HTTP adequadas para interagir com a API usando ferramentas como Postman ou curl.

## Considerações Finais

Esta é uma documentação básica para rodar e utilizar a API de CRUD de Usuários desenvolvida em C# e Entity Framework. Você pode expandir esta documentação para incluir mais detalhes sobre cada endpoint, adicionar exemplos de requisições e respostas, e implementar recursos de autenticação e autorização conforme necessário para sua aplicação.