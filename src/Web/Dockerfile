ARG VARIANT=6.0-bullseye
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:0-${VARIANT} as build

ARG NODE_VERSION="18"
RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o artifacts

FROM mcr.microsoft.com/dotnet/aspnet:6.0.13-bullseye-slim-amd64
LABEL org.opencontainers.image.source https://github.com/mdhthahmd/dotnet-hosting
WORKDIR /app
COPY --from=build /app/artifacts .


ENTRYPOINT ["dotnet", "Web.dll"]