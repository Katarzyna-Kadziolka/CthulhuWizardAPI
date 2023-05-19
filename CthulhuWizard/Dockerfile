FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CthulhuWizard.API/CthulhuWizard.API.csproj", "CthulhuWizard.API/"]
COPY ["CthulhuWizard.Persistence/CthulhuWizard.Persistence.csproj", "CthulhuWizard.Persistence/"]
COPY ["CthulhuWizard.Application/CthulhuWizard.Application.csproj", "CthulhuWizard.Application/"]
RUN dotnet restore "CthulhuWizard.API/CthulhuWizard.API.csproj"
COPY . .
WORKDIR "/src/CthulhuWizard.API"
RUN dotnet build "CthulhuWizard.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CthulhuWizard.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# ENTRYPOINT [ "dotnet", "CthulhuWizard.API.dll" ]
# HEROKU SPECIAL ENTRYPOINT
CMD ASPNETCORE_URLS=http://*:$PORT dotnet CthulhuWizard.API.dll