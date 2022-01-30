$FrontendName = $args[0]
$SolutionFolder = $args[1]
$SolutionInstallPath = $args[2]

cd $SolutionInstallPath\$SolutionFolder\$FrontendName\src\app

$Import = "    BrowserModule,", "    BrowserAnimationsModule,", "    AccordionModule,"
$ImportJoined = $Import -join "`n"
$SelectedLineContent2 = ((Get-Content -Path ".\app.module.ts") | Select-String "    BrowserModule").LineNumber
$FileContent = Get-Content -Path ".\app.module.ts" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -eq $SelectedLineContent2) { 
        $_ -replace $_, $ImportJoined
        Write-Host "Import is added to app.module"
    }
    else {
        $_
    }
    
} | Set-Content .\app.module.ts