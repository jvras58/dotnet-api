<h1 align="center">
  <a href="">Estudos com API C# dotnet</a>
</h1>

<p align="center">
  <a href="#memo-requisitos">Requisitos</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#rocket-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#information_source-como-usar">Como Usar</a>
</p>

## :memo: Requisitos

Para executar este projeto, você precisará das seguintes ferramentas:

| Ferramenta                                         | Versão  | Descrição                                   |
| -------------------------------------------------- | ------- | ------------------------------------------- |
| [.NET](https://dotnet.microsoft.com/pt-br/download)| 8.0.0   | uma plataforma de desenvolvedor composta    |
| [C#](https://dotnet.microsoft.com/en-us/download)  | ~~~~    | Linguagem de programação                    |
| [ENTITY](https://learn.microsoft.com/en-us/ef/)    | ~~~~    | kit de CSHARP (ORM)                         |
| [Git](https://git-scm.com)                         | -       | Sistema de controle de versões              |
| [SQLite](https://sqlite.org/)                      | -       | Sistema de gerenciamento de banco de dados  |


## :rocket: Tecnologias

Este projeto utiliza as seguintes tecnologias:

- **Gerenciador de dependências:** [NuGet](https://www.nuget.org/)
- **Linguagem e ambiente de desenvolvimento:** [C#](https://dotnet.microsoft.com)
- **ORM (Object-Relational Mapper):** [ENTITY](https://learn.microsoft.com/en-us/ef/)
- **Banco de dados:** [SQLite](https://sqlite.org/)



### Organização do projeto
```
/

├─📁 ApiCrud             ->  [Implementação da API]
│   ├─©️ Program.cs    ->  [Entrypoint da aplicação]
│   ├─📁 data            ->  [Implementação da sessão do database]
│   │ ├─📁 Estudante
│   │ │ ├─©️ AddEstudanteRequest.cs
│   │ │ ├─©️ Estudante.cs
│   │ │ ├─©️ EstudanteDto.cs
│   │ │ ├─©️ EstudanteRotas.cs
│   │   ...
│                     
├─📄 .gitignore
├─📄 README.md
```

## :information_source: Como Usar

Siga as instruções abaixo para configurar e executar o projeto:

```bash
# Clone este repositório
git clone https://github.com/jvras58/dotnet-api.git

# Navegue até o diretório do projeto
cd ApiCrud

# compilar o código-fonte do projeto em binários executáveis
dotnet build

# Para instalar as dependências de um projeto C# caso o comando anterior não tenha feito
dotnet restore

# Aplique as migrations
dotnet ef database update
```
- Caso ocorra um erro na aplicação das migrations e necessario seguir o [guia de inicio](inicio.md) 

# Inicie a API
```bash
dotnet run
```

- A API estará disponível localmente em: [http://localhost:5204](http://localhost:5204/swagger/index.html)


## :handshake: Contribuições

Contribuições são bem-vindas! Se você encontrar algum problema ou tiver alguma sugestão, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Guia:: 👩‍💻
Caso queira ver o passo a passo que utilizei para criar e configurar esse projeto, siga as seguintes instruções que são feitas e detalhadas no [guia de inicio](inicio.md).

<p align="center">Desenvolvido com :heart: por jvras</p>
