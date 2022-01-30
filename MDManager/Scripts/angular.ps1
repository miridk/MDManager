$FrontendName = $args[0]
$SolutionFolder = $args[1]
$runFrontendWhenFinished = $args[2]
$SolutionInstallPath = $args[3]


$LogFile = "C:\Udv\log" + $LogTime + ".txt"
" ARGUMENTS = $args" >>$logfile

cd $SolutionInstallPath
mkdir $SolutionFolder
cd $SolutionFolder
$LogFile = "C:\Udv\log" + $LogTime + ".txt"
" ARGUMENTS = $args" >>$logfile


$dir = dir
$LogFile = "C:\Udv\log" + $LogTime + ".txt"
" dir = $dir" >>$logfile

npm install -g @angular/cli
dotnet new angular -o my-new-app
ng new $FrontendName --style=scss --routing=true
cd $FrontendName

$dir = dir
$LogFile = "C:\Udv\log" + $LogTime + ".txt"
" dir after angular install = $dir" >>$logfile

# Implementing Prime NG
npm install primeng --save
npm install primeicons --save
npm install @angular/animations --save

$LogFile = "C:\Udv\log" + $LogTime + ".txt"
"angular installed" >>$logfile

if ($runFrontendWhenFinished -eq "true") {
    invoke-expression 'cmd /c start powershell -Command { ng serve --open; set-location ".\"; get-childitem ; sleep 3;}'
}

cd src
cd app

$ImportElements = "import { AppComponent } from `'./app.component`';", "import { AccordionModule } from `'primeng/accordion`';", "import { MenuItem } from `'primeng/api`';", "import { BrowserAnimationsModule } from `'@angular/platform-browser/animations`';"
$ImportElementsJoined = $ImportElements -join "`n"
$Import = "    BrowserModule,", "    BrowserAnimationsModule,", "    AccordionModule,"
$ImportJoined = $Import -join "`n"
$SelectedLineContent = ((Get-Content -Path ".\app.module.ts") | Select-String "import { AppComponent } from './app.component';").LineNumber
$SelectedLineContent2 = ((Get-Content -Path ".\app.module.ts") | Select-String "    BrowserModule,").LineNumber
$FileContent = Get-Content -Path ".\app.module.ts" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -eq $SelectedLineContent) { 
        $_ -replace $_, $ImportElementsJoined
        Write-Host "Import elements are added to app.module"
    }
    elseif ($_.ReadCount -eq $SelectedLineContent2) { 
        $_ -replace $_, $ImportJoined
        Write-Host "Import is added to app.module"
    }
    else {
        $_
    }
    
} | Set-Content .\app.module.ts

cd..
cd..
dir

$ImportElements3 = "              `"src/styles.scss`",", "              `"node_modules/primeicons/primeicons.css`",", "              `"node_modules/primeng/resources/themes/lara-light-indigo/theme.css`",", "              `"node_modules/primeng/resources/primeng.min.css`""
$ImportElementsJoined3 = $ImportElements3 -join "`n"

Write-Host $ImportElementsJoined3

$SelectedLineContent3 = ((Get-Content -Path ".\angular.json") | Select-String "              `"src/styles.scss`"").LineNumber
$FileContent = Get-Content -Path ".\angular.json" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -contains $SelectedLineContent3[0]) { 
        $_ -replace $_, $ImportElementsJoined3
        Write-Host "SCSS styles are imported to angular.json"
    }
    else {
        $_
    }
} | Set-Content .\angular.json

cd..
cd..

