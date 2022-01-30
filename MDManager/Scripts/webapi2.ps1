$SolutionFolder = $args[0]
$WebApiName = $args[1]
$SolutionInstallPath = $args[2]

cd $SolutionInstallPath\$SolutionFolder\$WebApiName
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore -v 5.0.8
dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.8
dotnet add package Microsoft.EntityFrameworkCore.InMemory -v 5.0.8
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.8