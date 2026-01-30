# =========================
# BUILD
# =========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
 
# Copiamos el csproj y restauramos
COPY ["Api.BootCamp.csproj", "./"]
RUN dotnet restore "Api.BootCamp.csproj"
 
# Copiamos el resto del código
COPY . .
RUN dotnet build "Api.BootCamp.csproj" -c Release -o /app/build
 
# =========================
# PUBLISH
# =========================
FROM build AS publish
RUN dotnet publish "Api.BootCamp.csproj" -c Release -o /app/publish /p:UseAppHost=false
 
# =========================
# RUNTIME
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
 
EXPOSE 8080
 
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.BootCamp.dll"]