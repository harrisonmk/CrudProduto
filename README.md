# CrudProduto

Se você estiver usando o Visual Studio, normalmente não é necessário compilar manualmente, pois o Visual Studio faz isso automaticamente.
Se você estiver usando um editor de código simples (por exemplo, Visual Studio Code), você pode compilar manualmente usando o terminal. 
Vá para a pasta do seu projeto e execute o seguinte comando (substitua NomeDoArquivo.cs pelo nome do seu arquivo de código-fonte):

csc NomeDoArquivo.cs

Se você estiver usando o Visual Studio, basta pressionar F5 ou clicar no botão "Iniciar" na barra de ferramentas.
Se você estiver usando um editor de código simples, vá para a pasta onde o executável foi gerado (geralmente dentro da pasta bin/Debug ou bin/Release) e 
execute-o usando o comando dotnet (se estiver usando .NET Core) ou apenas o nome do arquivo executável:

dotnet NomeDoArquivo.dll   # Para .NET Core
NomeDoArquivo.exe          # Para .NET Framework
