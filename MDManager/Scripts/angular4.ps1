$FrontendName = $args[0]
$SolutionFolder = $args[1]
$SolutionInstallPath = $args[2]

cd $SolutionInstallPath\$SolutionFolder\$FrontendName

$ImportElements3 = "              `"src/styles.scss`",", "              `"node_modules/primeicons/primeicons.css`",", "              `"node_modules/primeng/resources/themes/lara-light-indigo/theme.css`",", "              `"node_modules/primeng/resources/primeng.min.css`""
$ImportElementsJoined3 = $ImportElements3 -join "`n"
$SelectedLineContent3 = ((Get-Content -Path ".\angular.json") | Select-String "              `"src/styles.css`"").LineNumber
$FileContent = Get-Content -Path ".\angular.json" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -contains $($SelectedLineContent3[0])) { 
        $_ -replace $_, $ImportElementsJoined3
        Write-Host "SCSS styles are imported to angular.json"
    }
    else {
        $_
    }
} | Set-Content .\angular.json