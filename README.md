# ProgramacaoVisual
Repositório de códigos de Programação Visual_02 semestre


// clona o projeto do GitHub
git clone https://github.com/nessaniro/ProgramacaoVisual

// cria pasta ProgramacaoVisual
cd ProgramacaoVisual/

// cria pasta source
mkdir source
cd source

// acessa a pasta de ProgramacaoVisual
mkdir ProgramacaoVisual
cd ProgramacaoVisual/

// cria solution
dotnet new sln 

// criar e acessar WebMvc
mkdir WebMvc
cd WebMvc

// cria mvc 
dotnet new mvc

cd ..

dotnet sln ProgramacaoVisual.sln add WebMvc/WebMvc.csproj

// para adicionar no GitHub
git add .

// para ver se salvou no GitHub
git status 

git config --global user.email "vanessa.nirom@gmail.com""
git config --global user.name "Vanessa Niro Machado""

git add *

git commit -m "Initial commit""
git push origin master
. . . 