$SolutionFolder = $args[0]
$SolutionInstallPath = $args[1]
$FrontendName = $args[2]

cd $SolutionInstallPath\$SolutionFolder
mkdir $FrontendName
cd $FrontendName

npm install -g @angular/cli