ARG VARIANT=6.0-bullseye
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:0-${VARIANT} as build

# [Choice] Node.js version: none, lts/*, 18, 16, 14
ARG NODE_VERSION="18"
RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi

WORKDIR /app

COPY ./src/Web .

RUN dotnet restore
RUN dotnet publish -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0.13-bullseye-slim-amd64
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 5001
ENTRYPOINT ["dotnet", "Web.dll"]