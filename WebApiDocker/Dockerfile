FROM microsoft/aspnetcore:1.1
# Set Environment variables
ENV ASPNETCORE_URLS="http://*:5000"
ENV ASPNETCORE_ENVIRONMENT="Development"
#It is assumed that the dockerfile is in published dirctory and henc 
# we just need to copy the current directory content to docker
COPY . /app
#Set the working directory to /app
WORKDIR /app
# Expose the TCP port  5000. Generally we can jsust leave the protocol
#In this case we will use 
EXPOSE 5000/tcp

ENTRYPOINT ["dotnet", "WebApiDocker.dll"]
