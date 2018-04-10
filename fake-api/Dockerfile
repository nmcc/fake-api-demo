FROM microsoft/aspnetcore-build:2.1.300-preview1
WORKDIR /app

EXPOSE 80

# Copy csproj and restore as distinct layers
COPY ./MovieRatingApi.Fake/*.csproj ./MovieRatingApi.Fake/
COPY ./*.sln ./
RUN dotnet restore

# Copy everything else and build
COPY * ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "MovieRatingApi.Fake.dll"]