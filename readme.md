# Pi Api

My first app with .Net Core and Raspberry PI.

# Scripts

* **Build**: builds source code, creates the docker image and pushes to Docker Hub.
* **Install**: connects to the Raspberry PI, pulls the image, stops and removes the older container and runs the new one.
* **Deploy**: executes `build` and `install` scripts.

# References

* https://www.filipeflop.com/blog/programacao-raspberry-pi-com-net-core/
* https://blog.alexellis.io/dotnetcore-on-raspberrypi/
* https://github.com/dotnet/core/blob/master/samples/RaspberryPiInstructions.md