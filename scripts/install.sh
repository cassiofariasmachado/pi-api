#!/bin/bash

DOCKER_TAG='cassiofariasmachado/pi-api:latest'
CONTAINER_NAME='pi-api'
RASPBERRY_IP=$(sudo nmap -sP 192.168.1.0/24 | awk '/^Nmap/{ip=$NF}/B8:27:EB/{print ip}')

echo 'Step 1: Connect Raspberry PI'
ssh -l pi $RASPBERRY_IP "echo 'Step 2: Pull image'
                         sudo docker pull $DOCKER_TAG
                         
                         echo 'Step 3: Stop container'
                         sudo docker stop $CONTAINER_NAME
                         
                         echo 'Step 4: Remove container'
                         sudo docker rm $CONTAINER_NAME
     
                         echo 'Step 5: Run container'
                         sudo docker run --name $CONTAINER_NAME -p 5000:80 -d --privileged $DOCKER_TAG
                         
                         exit"