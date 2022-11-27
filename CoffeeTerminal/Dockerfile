FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CoffeeTerminal/CoffeeTerminal.csproj", "CoffeeTerminal/"]
RUN dotnet restore "CoffeeTerminal/CoffeeTerminal.csproj"
COPY . .
WORKDIR "/src/CoffeeTerminal"
RUN dotnet build "CoffeeTerminal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoffeeTerminal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeTerminal.dll"]