﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MovieApp/MovieApp.csproj", "MovieApp/"]
RUN dotnet restore "MovieApp/MovieApp.csproj"
COPY . .
WORKDIR "/src/MovieApp"
RUN dotnet build "MovieApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieApp.dll"]
