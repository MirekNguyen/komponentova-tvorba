FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY . .

RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish/
RUN cp -r app.db* publish/

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .


EXPOSE 8080

ENTRYPOINT ["dotnet", "komponentova-tvorba.dll"]