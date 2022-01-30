# Install Electron npm package
$SolutionName = "Powershell"
$ProjectName = "$($SolutionName)Frontend"



# Changing index.htm
$ImportElements = "  <base href=`"./`">"
$SelectedLineContent = ((Get-Content -Path ".\$($SolutionName)\$($projectName)\src\index.html") | Select-String "  <base href=`"/`">").LineNumber
$FileContent = Get-Content -Path ".\$($SolutionName)\$($ProjectName)\src\index.html" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -contains $SelectedLineContent) { 
        $_ -replace $_, $ImportElements
        Write-Host "\index.html is changed"
    }
    else {
        $_
    }
} | Set-Content .\$($SolutionName)\$($ProjectName)\src\index.html

dir



# Create main.js in project folder, not in src
New-Item -Path .\$($SolutionName)\$($ProjectName)\ -Name "main.js" -ItemType "file" -Value "const { app, BrowserWindow } = require('electron')

let win;

function createWindow () {
  // Create the browser window.
  win = new BrowserWindow({
    width: 800, 
    height: 600,
    backgroundColor: '#ffffff',
    icon: ``file://${__dirname}/dist/assets/logo.png``
  })


  win.loadURL(``file://${__dirname}/dist/index.html``)




  //// uncomment below to open the DevTools.
  // win.webContents.openDevTools()

  // Event when the window is closed.
  win.on('closed', function () {
    win = null
  })
}

// Create window on electron intialization
app.on('ready', createWindow)

// Quit when all windows are closed.
app.on('window-all-closed', function () {

  // On macOS specific close process
  if (process.platform !== 'darwin') {
    app.quit()
  }
})

app.on('activate', function () {
  // macOS specific close process
  if (win === null) {
    createWindow()
  }
})
"


# Add to package.json 
$ImportElements = "  `"version`": `"0.0.0`",", "  `"main`": `"main.js`","
$ImportElementsJoined = $ImportElements -join "`n"
$Import = "    `"test`": `"ng test`",", "    `"electron`": `"electron .`",", "    `"electron-build`": `"ng build --prod && electron .`""
$ImportJoined = $Import -join "`n"
$SelectedLineContent = ((Get-Content -Path ".\$($SolutionName)\$($ProjectName)\package.json") | Select-String "  `"version`": `"0.0.0`",").LineNumber
$SelectedLineContent2 = ((Get-Content -Path ".\$($SolutionName)\$($ProjectName)\package.json") | Select-String "    `"test`": `"ng test`"").LineNumber #"test": "ng test"
$FileContent = Get-Content -Path ".\$($SolutionName)\$($ProjectName)\package.json" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -eq $SelectedLineContent) { 
        $_ -replace $_, $ImportElementsJoined
        Write-Host "Imported Main.js in root in package.json"
    }
    elseif ($_.ReadCount -eq $SelectedLineContent2) { 
        $_ -replace $_, $ImportJoined
        Write-Host "Imported electron: electron . AND electron-build: ng build --prod in package.json"
    }
    else {
        $_
    }
} | Set-Content .\$($SolutionName)\$($ProjectName)\package.json

# To start the program from development: npm run electron-build

$ImportElements = "            `"outputPath`": `"dist`","
$SelectedLineContent = ((Get-Content -Path ".\$($SolutionName)\$($ProjectName)\angular.json") | Select-String "outputPath").LineNumber
$FileContent = Get-Content -Path ".\$($SolutionName)\$($ProjectName)\angular.json" 
$FileContent | ForEach-Object { 
    if ($_.ReadCount -contains $SelectedLineContent) { 
        $_ -replace $_, $ImportElements
        Write-Host "angular.json outputPath is changed"
    }
    else {
        $_
    }
} | Set-Content .\$($SolutionName)\$($ProjectName)\angular.json

cd $SolutionName
cd $ProjectName
npm install electron --save-dev
cd.. cd..


pause
### POWERSHELL TRIALS ###
# npm install jquery -S
# for powershell support: 
# npm install node-powershell -S
# npm i -S node-bash
# import { Bash } from 'node-bash/dist/index';
# import { PowerShell } from 'node-powershell/dist/index';