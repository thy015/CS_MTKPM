FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["OOP_MTKPM/OOP_MTKPM.csproj", "OOP_MTKPM/"]
RUN dotnet restore "OOP_MTKPM/OOP_MTKPM.csproj"
COPY . .
WORKDIR "/src/OOP_MTKPM"
RUN dotnet build "OOP_MTKPM.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "OOP_MTKPM.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOP_MTKPM.dll"]
