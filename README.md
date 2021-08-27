Comandos iniciais:

  mkdir ProjetoAEC
  cd ProjetoAEC
  dotnet new webapi
====================================================================================
Comandos git:

  git init
  git add .
  git commit -m "Iniciando projeto"
  code .gitignore # gerei o conte�do para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: https://www.toptal.com/developers/gitignore
  Criei o repositório e rodei os comandos
  git remote add origin git@github.com:TelesMilton/ProjetoAEC.git
  git branch -M main
  git push -u origin main
=====================================================================================
Componentes instalados:

  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
=====================================================================================
Comandos para migração:

dotnet tool install --global dotnet-ef
dotnet ef migrations add CandidatoAdd
dotnet ef database update
=====================================================================================
Instalação do code generator

dotnet tool install -g dotnet-aspnet-codegenerator
=====================================================================================
Gerando o scaffold de Candidatos

dotnet aspnet-codegenerator controller -name CandidatosController -m Candidato -dc DbContexto --relativeFolderPath Controllers
dotnet aspnet-codegenerator controller -name ProfissoesController -m Profissao -dc DbContexto --relativeFolderPath Controllers