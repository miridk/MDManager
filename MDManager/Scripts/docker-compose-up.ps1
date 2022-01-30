$SolutionFolder = $args[0]
$SolutionInstallPath = $args[1]

cd $SolutionInstallPath\$SolutionFolder

docker-compose up -d --build