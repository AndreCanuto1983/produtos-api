FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80;https://+:443;

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Produtos.Api/Produtos.Api.csproj", "Produtos.Api/"]
RUN dotnet restore "./Produtos.Api/Produtos.Api.csproj"
COPY . .
WORKDIR "/src/Produtos.Api"
RUN dotnet build "./Produtos.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Produtos.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Produtos.Api.dll"]