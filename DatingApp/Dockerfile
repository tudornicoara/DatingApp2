﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DatingApp/DatingApp.csproj", "DatingApp/"]
RUN dotnet restore "DatingApp/DatingApp.csproj"
COPY . .
WORKDIR "/src/DatingApp"
RUN dotnet build "DatingApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DatingApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DatingApp.dll"]
