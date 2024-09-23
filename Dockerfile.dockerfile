# Stage 1 Build the application
FROM mcr.microsoft.comdotnetsdk6.0 AS build
WORKDIR src

# Copy the project file and restore dependencies
COPY [NikeStore.csproj, .]
RUN dotnet restore

# Copy the rest of the application and build it
COPY . .
RUN dotnet build -c Release -o appbuild

# Publish the app
RUN dotnet publish -c Release -o apppublish

# Stage 2 Serve the application
FROM mcr.microsoft.comdotnetaspnet6.0 AS base
WORKDIR app

# Copy the published app from the build stage
COPY --from=build apppublish .

# Expose port 80
EXPOSE 80

# Set the entry point for the container
ENTRYPOINT [dotnet, NikeStore.dll]
