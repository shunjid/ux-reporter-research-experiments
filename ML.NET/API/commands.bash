shunjid@shunjid-B150M-HD3:~/Desktop/UxAbility/API$ heroku container:login
WARNING! Using --password via the CLI is insecure. Use --password-stdin.


shunjid@shunjid-B150M-HD3:~/Desktop/UxAbility/API$ docker build -t uxability-api /home/shunjid/Desktop/UxAbility/API/bin/Release/netcoreapp3.1/publish
Sending build context to Docker daemon  11.14MB
Step 1/4 : FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
 ---> cef7866e800b
Step 2/4 : WORKDIR /app
 ---> Running in 0dac5a248c02
Removing intermediate container 0dac5a248c02
 ---> 3ff8942a3a05
Step 3/4 : COPY . .
 ---> da74c16d4aef
Step 4/4 : CMD ASPNETCORE_URLS=http://*:$PORT dotnet API.dll
 ---> Running in 5516903c129c
Removing intermediate container 5516903c129c
 ---> 6822b50413b8
Successfully built 6822b50413b8
Successfully tagged uxability-api:latest


shunjid@shunjid-B150M-HD3:~/Desktop/UxAbility/API$ docker tag uxability-api registry.heroku.com/uxability-api/web


shunjid@shunjid-B150M-HD3:~/Desktop/UxAbility/API$ docker push registry.heroku.com/uxability-api/web
The push refers to repository [registry.heroku.com/uxability-api/web]
76d3c88311c4: Pushed 
3182746258f7: Pushed 
282f5dd89a70: Layer already exists 
21de04972fd8: Layer already exists 
21c174588bf3: Layer already exists 
e6d60910d056: Layer already exists 
b52c1c103fae: Layer already exists 
6f1c84e6ec59: Layer already exists 
dd5242c2dc8a: Layer already exists 
latest: digest: sha256:3ad0e11bc8e0fdb93d41aad3c997f2d564668a8749fa30f1e025e2c88df9fa30 size: 2218


shunjid@shunjid-B150M-HD3:~/Desktop/UxAbility/API$ heroku container:release web --app uxability-api
Releasing images web to uxability-api... done


shunjid@shunjid-B150M-HD3:~/Desktop/UxAbility/API$ docker images
REPOSITORY                              TAG                 IMAGE ID            CREATED             SIZE
uxability-api                           latest              6822b50413b8        2 minutes ago       700MB
registry.heroku.com/uxability-api/web   latest              6822b50413b8        2 minutes ago       700MB
mcr.microsoft.com/dotnet/core/sdk       3.1                 cef7866e800b        12 months ago       689MB
shunjid@shunjid-B150M-HD3:~/Desktop/UxAbility/API$ 
