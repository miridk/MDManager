$SolutionFolder = $args[0]
$WebApiName = $args[1]
$SolutionInstallPath = $args[2]

cd $SolutionInstallPath\$SolutionFolder 

dotnet new webapi -f net5.0 -n $WebApiName