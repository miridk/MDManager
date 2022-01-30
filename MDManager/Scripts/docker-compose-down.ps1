$SolutionFolder = $args[0]
$SolutionInstallPath = $args[1]

cd $SolutionInstallPath\$SolutionFolder

docker-compose down