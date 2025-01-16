# Aplicativo de Agendamento de Tarefas

## Descrição
Este projeto é um Agendador de Tarefas desenvolvido com **C#**, **ASP.NET MVC**, **Entity Framework** e **SQL Server**. Ele oferece uma maneira intuitiva e eficiente de gerenciar e organizar tarefas. O aplicativo permite que os usuários criem, leiam, atualizem e excluam tarefas, além de possibilitar o agendamento e acompanhamento de prazos.

## Funcionalidades
- Operações CRUD para tarefas (Criar, Ler, Atualizar, Excluir).

## Tecnologias Utilizadas
- **C#**: Linguagem de programação principal do aplicativo.
- **ASP.NET MVC**: Framework para desenvolvimento da aplicação web.
- **Entity Framework**: ORM (Mapeamento Objeto-Relacional) para interações com o banco de dados.
- **SQL Server**: Banco de dados para armazenamento dos dados da aplicação.
- **Bootstrap**: Para design responsivo da interface.

## Pré-requisitos
Antes de executar este projeto, certifique-se de ter os seguintes itens instalados:

- **Visual Studio 2022** (ou mais recente)
- **.NET 9 SDK**
- **SQL Server** (instância local ou remota)
- **Git** (para controle de versão)

## Instruções de Configuração

1. **Clone o Repositório**:
   ```bash
   git clone https://github.com/seu-usuario/agendador-de-tarefas.git
   cd agendador-de-tarefas
   ```

2. **Restaure os Pacotes NuGet**:
   Abra o projeto no Visual Studio e restaure os pacotes NuGet utilizando:
   ```bash
   dotnet restore
   ```

3. **Configure o Banco de Dados**:
   - Configure sua string de conexão com o SQL Server no arquivo `appsettings.json`:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=AgendadorTarefasDB;Trusted_Connection=True;"
     }
     ```
   - Execute as migrações do Entity Framework para configurar o esquema do banco de dados:
     ```bash
     dotnet ef database update
     ```

4. **Execute a Aplicação**:
   Inicie a aplicação usando o Visual Studio ou o seguinte comando:
   ```bash
   dotnet run
   ```

5. **Acesse a Aplicação**:
   Abra o navegador e acesse `http://localhost:5000` (ou a porta especificada).

## Estrutura de Pastas
```
AgendadorTarefas/
├── Controllers/      # Gerencia requisições HTTP e a lógica da aplicação
├── Models/           # Contém os modelos de dados e configurações do Entity Framework
├── Views/            # Contém as views Razor para renderização da interface
├── wwwroot/          # Arquivos estáticos (CSS, JavaScript, imagens, etc.)
├── Migrations/       # Arquivos de migração do Entity Framework
├── appsettings.json  # Arquivo de configuração da aplicação
└── Program.cs        # Ponto de entrada da aplicação
```

## Contribuições
Contribuições são bem-vindas! Siga os passos abaixo:
1. Faça um fork deste repositório.
2. Crie uma branch para sua funcionalidade: `git checkout -b feature/sua-funcionalidade`.
3. Faça commit das suas alterações: `git commit -m 'Adicione sua funcionalidade'`.
4. Faça push para a branch: `git push origin feature/sua-funcionalidade`.
5. Abra um pull request.

## Licença
Este projeto está licenciado sob a [Licença MIT](LICENSE).


---
Obrigado por usar o Aplicativo de Agendamento de Tarefas!

