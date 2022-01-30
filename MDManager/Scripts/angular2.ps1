$FrontendName = $args[0]
$SolutionFolder = $args[1]
$SolutionInstallPath = $args[2]

cd $SolutionInstallPath\$SolutionFolder\$FrontendName

# Implementing Prime NG
npm install primeng --save
npm install primeicons --save
npm install @angular/animations --save

cd $SolutionInstallPath\$SolutionFolder\$FrontendName\src\app

$ImportElements = "import { AppComponent } from `'./app.component`';", "import { AccordionModule } from `'primeng/accordion`';", "import { MenuItem } from `'primeng/api`';", "import { BrowserAnimationsModule } from `'@angular/platform-browser/animations`';"
$ImportElementsJoined = $ImportElements -join "`n"
$SelectedLineContent = ((Get-Content -Path ".\app.module.ts") | Select-String "import { AppComponent } from './app.component';").LineNumber
$FileContent = Get-Content -Path ".\app.module.ts" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -eq $SelectedLineContent) { 
        $_ -replace $_, $ImportElementsJoined
        Write-Host "Import elements are added to app.module"
    }
    else {
        $_
    }
} | Set-Content .\app.module.ts