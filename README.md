# README.md - Sistema de Gerenciamento CRUD 
 
Este é um sistema de gerenciamento CRUD (Create, Read, Update, Delete) desenvolvido em ASP.NET Core para operações de um banco de dados de produtos. 
 
## Funcionalidades 
 
### Operações CRUD 
 
Este projeto oferece operações CRUD para gerenciar produtos, incluindo: 
 
- **Create (Criar):** Adicionar novos produtos ao banco de dados. 
- **Read (Ler):** Visualizar a lista de produtos existentes. 
- **Update (Atualizar):** Editar informações de produtos existentes. 
- **Delete (Excluir):** Remover produtos do banco de dados. 
 
 
## Configuração 
 
Antes de executar o sistema, certifique-se de ter configurado o ambiente corretamente: 
 
### Requisitos 
 
- [.NET Core SDK](https://dotnet.microsoft.com/download) 
- [Visual Studio](https://visualstudio.microsoft.com/) ou outro ambiente de desenvolvimento ASP.NET Core. 
 
### Passos de Configuração 
 

Navegue até a pasta do projeto: 

cd CRUD 
 

Configure a conexão com o banco de dados no arquivo appsettings.json, se necessário. 

Execute as migrações do banco de dados: 

dotnet ef database update 
 

Inicie o aplicativo: 

dotnet run 
 
Abra o navegador para usar o aplicativo. 

