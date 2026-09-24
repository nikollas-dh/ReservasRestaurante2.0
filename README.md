# 🍽️ Reservas de Restaurantes

Aplicação desktop desenvolvida em **C# com Windows Forms**, utilizando **Entity Framework** e **SQL Server** para gerenciamento de usuários e reservas de restaurantes.

O sistema permite que usuários realizem seu cadastro, façam login e efetuem reservas em restaurantes previamente cadastrados no banco de dados.

## 📌 Sobre o projeto

O **Reservas de Restaurantes** é uma aplicação desktop desenvolvida para facilitar o processo de realização e gerenciamento de reservas em restaurantes.

O sistema possui autenticação de usuários e permite que usuários cadastrados realizem reservas de acordo com os restaurantes e horários disponíveis.

Os restaurantes são previamente cadastrados no banco de dados, não sendo possível realizar seu cadastro ou alteração através da aplicação.

O projeto utiliza a abordagem **Database First**, com as entidades e o contexto gerados a partir de um banco de dados SQL Server existente por meio do **Scaffold** do Entity Framework.

## 🚀 Funcionalidades

### 👤 Usuários

* Cadastro de novos usuários
* Login
* Validação das credenciais
* Acesso às funcionalidades do sistema após autenticação

### 🍽️ Reservas

* Visualização dos restaurantes disponíveis
* Consulta de opções de reserva
* Seleção de restaurante
* Seleção de data e horário
* Realização de reservas
* Consulta das reservas realizadas pelo usuário

## 🛠️ Tecnologias utilizadas

* **C#**
* **.NET**
* **Windows Forms**
* **Entity Framework**
* **SQL Server**
* **Visual Studio**

## 🗄️ Banco de dados

O banco de dados utilizado pela aplicação é o **SQL Server**.

O projeto utiliza a abordagem **Database First**, portanto a estrutura das entidades é baseada no banco de dados já existente.

O Entity Framework é utilizado para realizar o mapeamento entre as tabelas do banco de dados e as classes utilizadas pela aplicação.

### Scaffold

As classes de modelo e o contexto do Entity Framework foram gerados a partir do banco de dados utilizando **Scaffold**.

De forma simplificada, o fluxo utilizado é:

```text
SQL Server
    │
    │ Scaffold
    ▼
Entity Framework
    │
    ├── Models
    └── DbContext
          │
          ▼
    Windows Forms
```

## 🏗️ Estrutura do projeto

A estrutura pode variar de acordo com a organização utilizada no projeto, mas segue uma estrutura semelhante:

```text
ReservasRestaurantes/
│
├── Forms/
│   ├── FrmLogin.cs
│   ├── FrmCadastroUsuario.cs
│   ├── FrmPrincipal.cs
│   └── FrmReservas.cs
│
├── Models/
│   ├── Usuario.cs
│   ├── Restaurante.cs
│   └── Reserva.cs
│
├── Data/
│   └── BancoContext.cs
│
└── Program.cs
```

As classes `Models` e o `DbContext` são gerados a partir da estrutura existente no SQL Server através do Scaffold.

## 🔐 Autenticação

O sistema possui uma tela de login onde o usuário informa suas credenciais para acessar a aplicação.

Caso ainda não possua uma conta, o usuário pode realizar seu cadastro.

O fluxo de acesso é:

```text
┌─────────────────┐
│     Login       │
└────────┬────────┘
         │
    ┌────┴────┐
    │         │
    ▼         ▼
 Login      Cadastro
 válido       │
    │         │
    │         ▼
    │      Usuário
    │     cadastrado
    │         │
    └────┬────┘
         ▼
   Tela principal
```

## 📅 Processo de reserva

Após realizar o login, o usuário pode acessar a área de reservas.

O processo consiste em:

1. Selecionar um restaurante disponível.
2. Escolher a data da reserva.
3. Selecionar um horário disponível.
4. Informar os dados necessários para a reserva.
5. Confirmar a reserva.
6. O sistema registra a reserva no banco de dados.

Os restaurantes disponíveis são obtidos diretamente do banco de dados.

## 🗃️ Responsabilidade do sistema

A aplicação é responsável principalmente por:

* Autenticação dos usuários;
* Cadastro de usuários;
* Consulta dos restaurantes disponíveis;
* Realização de reservas;
* Consulta das reservas realizadas;
* Comunicação com o banco de dados SQL Server.

O cadastro e gerenciamento dos restaurantes **não fazem parte das funcionalidades da aplicação**.

## 🧩 Entity Framework

O **Entity Framework** é utilizado como camada de acesso aos dados.

Como o projeto utiliza **Database First**, as classes são geradas com base na estrutura existente no banco de dados.

Exemplo simplificado:

```csharp
public partial class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}
```

O contexto permite acessar as tabelas do banco através das entidades:

```csharp
public virtual DbSet<Usuario> Usuarios { get; set; }
public virtual DbSet<Restaurante> Restaurantes { get; set; }
public virtual DbSet<Reserva> Reservas { get; set; }
```

## ⚙️ Configuração

### Pré-requisitos

Para executar o projeto, é necessário possuir:

* Windows
* Visual Studio
* .NET compatível com o projeto
* SQL Server
* Banco de dados configurado
* Executar Query SQL

### Conexão com o banco

A aplicação utiliza uma **connection string** para estabelecer a conexão com o SQL Server.

A configuração deve apontar para o banco de dados utilizado pelo projeto.

Exemplo:

```text
Server=localhost;
Database=ReservasRestaurantes;
Trusted_Connection=True;
TrustServerCertificate=True;
```

A configuração deve ser ajustada de acordo com o ambiente em que o projeto será executado.

## ▶️ Executando o projeto

1. Instale os pré-requisitos.
2. Configure o SQL Server.
3. Disponibilize o banco de dados utilizado pelo projeto.
4. Configure a connection string da aplicação.
5. Abra a solução no Visual Studio.
6. Compile o projeto.
7. Execute a aplicação.
8. Cadastre um usuário ou utilize um usuário existente.
9. Faça login.
10. Realize uma reserva.

## 📋 Observações

* O projeto **não possui API**.
* O sistema é uma aplicação **desktop Windows Forms**.
* O banco de dados utilizado é o **SQL Server**.
* O acesso aos dados é realizado através do **Entity Framework**.
* O projeto utiliza **Database First/Scaffold**.
* Não são utilizadas **Entity Framework Migrations**.
* Restaurantes são previamente cadastrados no banco de dados.
* O usuário da aplicação pode se cadastrar, fazer login e realizar reservas.
* O cadastro de restaurantes não está disponível na aplicação.

## 🎯 Objetivo

O projeto tem como objetivo aplicar conhecimentos de:

* Programação em C#
* Windows Forms
* Programação Orientada a Objetos
* Entity Framework
* Database First
* Scaffold
* SQL Server
* Operações CRUD
* Autenticação de usuários
* Relacionamento entre entidades
* Manipulação e persistência de dados

## 👨‍💻 Autor

Desenvolvido por **Nikollas Dheyvis**.

## 📄 Licença

Este projeto foi desenvolvido para fins **educacionais**.
