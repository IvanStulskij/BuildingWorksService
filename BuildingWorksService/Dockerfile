#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BuildingWorksService/BuildingWorksService.csproj", "BuildingWorksService/"]
COPY ["BuildingWorks.Databasable/BuildingWorks.Databasable.csproj", "BuildingWorks.Databasable/"]
COPY ["BuildingWorks.Interfaces/BuildingWorks.Common.csproj", "BuildingWorks.Interfaces/"]
COPY ["Models/BuildingWorks.Models.csproj", "Models/"]
COPY ["BuildingWorks.Profilers/BuildingWorks.Profilers.csproj", "BuildingWorks.Profilers/"]
COPY ["BuildingWorks.Services/BuildingWorks.Services.csproj", "BuildingWorks.Services/"]
COPY ["BuildingWorks.Repositories/BuildingWorks.Repositories.csproj", "BuildingWorks.Repositories/"]
RUN dotnet restore "BuildingWorksService/BuildingWorksService.csproj"
COPY . .
WORKDIR "/src/BuildingWorksService"
RUN dotnet build "BuildingWorksService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BuildingWorksService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BuildingWorksService.dll"]