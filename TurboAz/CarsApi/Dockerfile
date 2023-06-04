FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY *.csproj .
RUN dotnet restore 
COPY . .
WORKDIR "/src/CarsApi"
RUN dotnet build "../CarsApi.csproj" -c Release 

FROM build AS publish
RUN dotnet publish "../CarsApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 3000

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarsApi.dll"]
