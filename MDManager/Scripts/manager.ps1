
# Setup Naming vars
[string]$SolutionInstallPath = $args[0]
[string]$SolutionFolder = "test"; # Enter the name of the solution
[string]$ProjectName = "$($SolutionFolder)Api" # P
[string]$WebApiName = "$($ProjectName)Service";
[string]$ApiPortNo = $args[1]
[string]$HostName = "http://localhost"
[string]$DevelopmentApi = "$($HostName):$($ApiPortNo)/api/$($ProjectName)/"
[string]$ProductionApi = ""
###### LOGGING ######
$dir = dir
$LogFile = "C:\temp\log"+ $LogTime + ".txt"
" dir = $dir" >>$logfile

###### LOGGING ######
$LogFile = "C:\temp\log"+ $LogTime + ".txt"
"SolutionInstallPath = $SolutionInstallPath and ApiPortNo = $ApiPortNo" >>$logfile



# Frontend setup
[string]$FrontendName = "$($SolutionFolder)Frontend"

# Properties vars
$props = 'Id', 'FirstName', 'LastName', 'PhoneNo', 'Email'
$types = 'int', 'string', 'string', 'string', 'string'
$required = '[Required]', '[Required]', '[Required]', '[Required]', '[Required]'
$key = '[Key]', '//', '//', '//', '//'

# Managing
[bool]$generatingApi = 0
[bool]$addingPackagesToApi = 0
[bool]$addingProperties = 0
[bool]$addingFrontend = 1

# Run Services
[bool]$runDotnetWhenFinished = 0
[bool]$runSwaggerWhenFinished = 0
[bool]$runFrontendWhenFinished = 0

# --------------------------------------------- #

mkdir $SolutionInstallPath\$SolutionFolder

if ($generatingApi) {

    [string]$propsJoined = $props -join "-"
    [string]$typesJoined = $types -join "-"
    [string]$requiredJoined = $required -join "-"
    [string]$keysJoined = $key -join "-"
    Start-Process powerShell.exe "& '.\webapi.ps1' $SolutionFolder $WebApiName $addingPackagesToApi $addingProperties $propsJoined $typesJoined $requiredJoined $keysJoined $runDotnetWhenFinished $runSwaggerWhenFinished $HostName $ApiPortNo $ProjectName; pause"
}

###### LOGGING ######
$dir = dir
$LogFile = "C:\temp\log"+ $LogTime + ".txt"
" dir = $dir" >>$logfile



if ($addingFrontend) {
    Start-Process powerShell.exe "& '.\angular.ps1' $FrontendName $SolutionFolder $runFrontendWhenFinished $SolutionInstallPath; pause"
}
dir
pause