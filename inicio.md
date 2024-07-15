# Guia de Instalação das Ferramentas Necessárias

Este guia passo a passo foi criado para auxiliá-lo na instalação de todas as ferramentas necessárias para começar a desenvolver sua API CRUD utilizando o .NET.

## Pré-requisitos

Antes de prosseguir, é essencial verificar se o .NET SDK está instalado em sua máquina. Para isso, abra o terminal e execute o seguinte comando:

```bash
dotnet --version
```

Caso o .NET SDK não esteja instalado, siga as instruções disponíveis no [site oficial do .NET](https://dotnet.microsoft.com/download) para realizar a instalação.

## Configuração Inicial

Para criar um novo projeto de API CRUD com configurações mínimas, execute o comando abaixo no terminal:

```bash
dotnet new webapi --name ApiCrud --minimal
```

## Instalação das Ferramentas e Pacotes Necessários

### 1. Entity Framework Core Tools

O Entity Framework Core Tools é uma ferramenta indispensável para o desenvolvimento de aplicações que utilizam banco de dados com o Entity Framework. Para instalá-lo, execute:

```bash
dotnet tool install --global dotnet-ef
```

### 2. Adicionando o Entity Framework Core

Para adicionar o Entity Framework Core ao seu projeto, utilize o comando:

```bash
dotnet add package Microsoft.EntityFrameworkCore
```

### 3. Adicionando o Suporte ao SQLite

Para utilizar o SQLite como banco de dados, adicione o pacote correspondente com o comando:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

### 4. Habilitando o Design do Entity Framework

Para criar e aplicar migrations, é necessário adicionar o pacote de design do Entity Framework:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### 5. Criando Migrations

Para criar uma nova migration, utilize o comando abaixo, substituindo `<NomeMigration>` pelo nome desejado para a migration:

```bash
dotnet ef migrations add <NomeMigration>
```

Isso resultará na criação de uma pasta `Migrations` no seu projeto.

### 6. Aplicando as Migrations ao Banco de Dados

Para aplicar as migrations e atualizar o banco de dados, execute:

```bash
dotnet ef database update
```

Após seguir estes passos, seu ambiente estará configurado e pronto para o desenvolvimento da API CRUD.
