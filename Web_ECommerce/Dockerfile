#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Web_ECommerce/Web_ECommerce.csproj", "Web_ECommerce/"]
COPY ["ApplicationApp/ApplicationApp.csproj", "ApplicationApp/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Entities/Entities.csproj", "Entities/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
RUN dotnet restore "Web_ECommerce/Web_ECommerce.csproj"
COPY . .
WORKDIR "/src/Web_ECommerce"
RUN dotnet build "Web_ECommerce.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web_ECommerce.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web_ECommerce.dll"]