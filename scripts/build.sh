#!/bin/bash

DOCKER_TAG='cassiofariasmachado/pi-api:latest'

echo 'Step 1: Starting build'

dotnet publish -c release -o bin/publish -r linux-arm

echo 'Step 2: Build docker image'

docker build -t $DOCKER_TAG .

echo 'Step 3: Push docker image'

docker push $DOCKER_TAG
