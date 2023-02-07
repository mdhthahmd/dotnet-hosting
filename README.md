### Dotnet Core Hosting

This is a sample project to host a aspnet core app (that has a vue spa intergrated) in linux

### Prerequisite
- dotnet SDK 6
- nodejs 18 

### Installation
- clone the repo `git clone https://github.com/mdhthahmd/dotnet-hosting`
- go to  Web folder under src `cd src/Web`
- restore packages `dotnet restore`
- publish `dotnet publish -o out`
- go to src/Web/out `cd out`
- run `dotnet Web.dll`

### Notes
Installation steps can be repeated on a server and its up to you on how to expose the app to internet such as in-built aspnercore server, nginx or containers 