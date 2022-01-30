$SolutionFolder = $args[0]
$WebApiName = $args[1]
$HostName = $args[2]
$ApiPortNo = $args[3]
$ProjectName = $args[4]
$SolutionInstallPath = $args[5]

cd $SolutionInstallPath\$SolutionFolder\$WebApiName

invoke-expression 'cmd /c start powershell -Command { dotnet run; set-location "C:\Udv\TestingMDManager\testing\dow8\dow8Api"; get-childitem ; sleep 3;}'


# if ($runSwaggerWhenFinished -eq "true") {
#     Start-Process "$($HostName):$($ApiPortNo)/swagger"
# }
