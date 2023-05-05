FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ProvaGithubActions.Src/ProvaGithubActions.Src.csproj", "ProvaGithubActions.Src/"]
RUN dotnet restore "ProvaGithubActions.Src/ProvaGithubActions.Src.csproj"
COPY . .
WORKDIR "/src/ProvaGithubActions.Src"
RUN dotnet build "ProvaGithubActions.Src.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProvaGithubActions.Src.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProvaGithubActions.Src.dll"]
