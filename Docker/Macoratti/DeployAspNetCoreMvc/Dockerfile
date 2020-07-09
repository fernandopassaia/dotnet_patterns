FROM mcr.microsoft.com/dotnet/core/samples:aspnetapp
LABEL version="1.0" maintainer="Passaia"
WORKDIR /app
COPY ./dist .
ENTRYPOINT ["dotnet", "src.dll"]