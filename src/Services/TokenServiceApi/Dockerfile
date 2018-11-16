FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /build

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./

RUN dotnet publish -c Release -o output

# build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /build/output .
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "TokenServiceApi.dll"]