REM Need to run to de scale the docker and remove the service set from Swarm
docker service scale webapidocker=0
docker service rm webapidocker
