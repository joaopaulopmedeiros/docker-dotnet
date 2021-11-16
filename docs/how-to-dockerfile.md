# How to dockerize a .NET app?

1. Create Dockerfile on the same directory as your .csproj file

```Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:5.0

COPY bin/Release/net5.0/publish/ App/

WORKDIR /App

ENTRYPOINT ["dotnet", "App.dll"]
```

2. Build image from Dockerfile on terminal

```
docker build -t <image-name> -f Dockerfile .
```

3. Create a container from your image

```
docker create --name <container-name> <image-name>
```

4. Start your container

```
 docker start <container-name>
```

5. In case you want to see its output, you should type

```
 docker attach --sig-proxy=false <container-name>
```

6. At the end, stop your container

```
docker stop <container-name>
```

## References

- [Microsoft Tutorial](https://docs.microsoft.com/pt-br/dotnet/core/docker/build-container?tabs=windows)
