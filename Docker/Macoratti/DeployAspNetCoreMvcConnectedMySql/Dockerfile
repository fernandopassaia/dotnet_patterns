FROM mcr.microsoft.com/dotnet/core/samples:aspnetapp
LABEL version="1.0" maintainer="Passaia"
COPY dist /app
WORKDIR /app
ENTRYPOINT ["dotnet", "src.dll"]