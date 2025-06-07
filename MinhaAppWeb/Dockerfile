# Usar a imagem oficial do SDK para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copiar csproj e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar todo o restante do código
COPY . ./

# Buildar a aplicação em modo Release
RUN dotnet publish -c Release -o out

# Imagem runtime para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=build /app/out ./

# Expor a porta que o app usa (padrão 5000)
EXPOSE 5000

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "MinhaAppWeb.dll"]
