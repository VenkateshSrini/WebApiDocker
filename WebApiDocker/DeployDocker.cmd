REM Creating script file for docker
docker build -t webapidocker-img .
docker swarm init
docker service create --publish 5000:5000 --name webapidocker webapidocker-img
docker service scale webapidocker=3