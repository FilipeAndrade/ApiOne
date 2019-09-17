#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-nanoserver-1903 AS base
WORKDIR /app/apiOne
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["ApiOne/ApiOne.csproj", "ApiOne/"]
RUN dotnet restore "ApiOne/ApiOne.csproj"
COPY . .
WORKDIR "/src/ApiOne"
RUN dotnet build "ApiOne.csproj" -c Release -o /app/apiOne

FROM build AS publish
RUN dotnet publish "ApiOne.csproj" -c Release -o /app/apiOne

FROM base AS final
WORKDIR /app/apiOne
COPY --from=publish /app/apiOne .
ENTRYPOINT ["dotnet", "ApiOne.dll"]