# Get the build image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy the project file and restore packages
COPY *.csproj ./
RUN dotnet restore

# Copy the rest and build a release version
COPY ./* ./
RUN dotnet publish -c Release -o publish

# Copy the release version into a new image for hosting
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/publish .

# Environmental setup
#ENV ASPNETCORE_URLS http://+:80
#EXPOSE 80

# Set the entrypoint
ENTRYPOINT ["dotnet", "ExampleService.dll"]