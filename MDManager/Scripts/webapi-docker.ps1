$SolutionFolder = $args[0]
$WebApiName = $args[1]
$SolutionInstallPath = $args[2]
$ApiPortNo = $args[3]
$WebApiNameToLower = $WebApiName.ToLower()


cd $SolutionInstallPath\$SolutionFolder

New-Item -Path . -Name "docker-compose.yml" -ItemType "file" -Value "version: '3.4'

services:
  $($WebApiNameToLower):
    image: $($WebApiNameToLower)
    ports:
     - `"$($ApiPortNo):80`"
    container_name: $($WebApiName)
    build:
      context: ./$($WebApiName)/
      dockerfile: Dockerfile
    depends_on:
      - db

  db:
    image: mcr.microsoft.com/mssql/server:2019-latest
    restart: always
    ports:
    - 12433:1433
    container_name: SQL_Server
    environment:
      SA_PASSWORD: Your_password123
      ACCEPT_EULA: Y"

New-Item -Path . -Name ".\$($WebApiName)\Dockerfile" -ItemType "file" -Value "FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY [`"$($WebApiName).csproj`", `".`"]
RUN dotnet restore `"$($WebApiName).csproj`"
COPY . .
WORKDIR `"/src/`"
RUN dotnet build `"$($WebApiName).csproj`" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish `"$($WebApiName).csproj`" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [`"dotnet`", `"$($WebApiName).dll`"]"

# docker-compose up -d --build