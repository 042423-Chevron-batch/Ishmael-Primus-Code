FROM mcr.microsoft.com/dotnet/aspnet:7.0

# Dockerfile is an instruction sheet to create docker image
WORKDIR /app
COPY Program.cs Program.cs
COPY HangMan-Prj.csproj HangMan-Prj.csproj

# Build the app
RUN  dotnet publish -c Release -o dist

WORKDIR /app


# When you do docker run, run this executable 
# Equivalent to going "dotnet dist/HelloWorld.dll" on terminal
CMD ["dotnet", "HangMan-Prj.dll"]
