FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY . /app
WORKDIR /app/backend/DaraAds.API/

RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS runtime
WORKDIR /app
COPY --from=build /app/backend/DaraAds.API/out ./
ENTRYPOINT ["dotnet", "DaraAds.API.dll"]