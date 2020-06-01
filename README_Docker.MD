### Docker Review and Documentations

**What is Docker**:
It's a "kind" of Virtualization for Systems, but with a lot of benefits, once Docker don't uses HyperV (or another virtualization layer) and can have access right to the Processor and Memory of the Hosts. So once you don't need a whole operational system and hyperV managing it, you have less maintanence (to keep a second operational system) and better performance once you have access right to the CPU/Memory.

**Important and Oficial Links**:
Main page of Documentation: https://docs.docker.com/
Main page of DockerHub: https://hub.docker.com/


**How to install Docker on my Ubuntu 20.04**:
Here is the Official Guide: https://docs.docker.com/engine/install/ubuntu/
Here is how to use docker without the "sudo" always:
(1) sudo groupadd docker
(2) sudo gpasswd -a fernandopassaia docker
(3) sudo service docker restart
(4) newgrp docker

**CTOP:**
Ctop is a tool to administrate containers and have a real-time metrics for multiple containers.
https://github.com/bcicen/ctop

To install it:
(1) sudo wget https://github.com/bcicen/ctop/releases/download/v0.7.3/ctop-0.7.3-linux-amd64 -O /usr/local/bin/ctop
(2) sudo chmod +x /usr/local/bin/ctop
(3) docker run --rm -ti \
  --name=ctop \
  --volume /var/run/docker.sock:/var/run/docker.sock:ro \
  quay.io/vektorlab/ctop:latest

To RUN ctop you just need to call it from terminal: ctop

Shortcuts:
-a 	show active containers only
-f <string> 	set an initial filter string
-h 	display help dialog
-i 	invert default colors
-r 	reverse container sort order
-s 	select initial container sort field
-scale-cpu 	show cpu as % of system total
-v 	output version information and exit
-shell 	specify shell (default: sh)

Keybindings
<enter> 	Open container menu
a 	Toggle display of all (running and non-running) containers
f 	Filter displayed containers (esc to clear when open)
H 	Toggle ctop header
h 	Open help dialog
s 	Select container sort field
r 	Reverse container sort order
o 	Open single view
l 	View container logs (t to toggle timestamp when open)
e 	Exec Shell
S 	Save current configuration to file
q 	Quit ctop

-----------------------------------------------------------------------------------------------------------------------------------------
**Now we go to the MAIN commands**:

docker --version
docker --help (list all commands)
docker images (show the imagens available on system)

If you want to **Remove** a Image:
docker image rmi f09f (the first 4 digits or the name of the image)

To **list** the Containers:
docker container ps
docker container ps -a (list all the containers, including not in execution)

**First Hello-World**:
docker container run hello-world (i can see this image going to DockerHub and searching for HelloWorld - https://hub.docker.com/_/hello-world)

Note about the command **RUN** (command run runs 4 operations):
docker image pull
docker container create
docker container start
docker container exec

Note: If you use RUN a second time, it will creates ANOTHER new container. Docker RUN always create a new container.

**Downloading an Image and Creating a Container**:
docker image pull alpine (alpine is a small linux distribution with just 5MB) (to choose the version i can use "alpine:3.7")
docker container run alpine ls -l (I will run the image and execute inside the container linux the command "ls -l")

docker container run -it alpine /bin/sh (i = interative t = terminal, it will open the terminal inside the container)
echo 'ola alpine!' > teste.txt (With the Terminal Open, i can run a command (to create a txt with a text))

**Note**:
If i do not specify a name to my container, docker will choose some random strange name. To choose a name:
docker container run --name linuxFerTest alpine

To **REMOVE** containers:
docker container rm linuxFerTest
docker container rm 9f03

To see **DETAILS** of a container:
docker inspect ws1 (name or the keyof the container)

**Running a Created Containner**:
As said before, docker container RUN will always create new containers. To Run a existing container you should first:
docker container ps -a (then get the container ID - the first 4 letters is enought)
docker container start 9f03 (this is my alpine container ID 5f07d3aef571)
docker container ps (if you want to check, it should be running now)
docker container exec 9f03 ls -l (it will run again the same command ls-l on the containnner create before)

**To STOP a Containner**
docker container stop affectionate_wescoff (this is the "random" name docker choose) OR docker container stop 9f03

### Moving to the Exercixes and some more RealWorlds usages

**First Exercise:**
I want to install a image called nginx - a proxy reverse opensource to protocols http, https, smtp, pop3 and imap. This app by default
open the ports 80 and 443 on the Container (inside docker). So inside docker I'll have the port 80 running. Then I want to MAP this
port to my local machine (my real linux ubuntu 20.04) to open on my browser on 8080 (so I'll expose this container-app to the host).

(1) docker container run --name ws1 nginx (after this command the Terminal will stop, because container is running. So if i open another
terminal and do "docker container ps" I'll see the container running on port 80 inside the container)

Cool. But now i want to do two things: Map the Port to my Ubuntu Host (localhost) and avoid TERMINAL to be freeze:

docker container run --name ws1 -p -d nginx
(-p will map the port 80 of container to a random port on realworld (my ubuntu host 20.04))
(-d is for "detached" - will run in parallel process and not freeze the terminal)

Cool. But there's a **BETTER way to do it**, by setting the Local Port on Container (80) to a RealWorld Port on my Ubuntu Host 20.04:
docker container run --name ws1 -p 8080:80 -d nginx

Now open yourbrowser (yeah on your Ubuntu LocalHost 20.04):
http://localhost:8080/

You'll see the First Page of Nginx: Running on your REAL Host, accessing the Nginx inside the containner. Cool.
You can see this containner running using "docker container ps" or the "ctop" app. NICE!

**Second Exercise:**
I want to Map the Folders from my container (nginx) to be accessible on my Real Host. First thing to understand: When i did the first
exercise, when i call the "localhost:8080", nginx goes inside the container on the folder "/usr/share/nginx/html" and opened the "index.html"
file. So basically what i need to do is to see this folders on my LocalHost (Ubuntu) in a way i can change this files inside the container.

(on the folder /home/fernandopassaia)
mkdir html (important, stay on the folder fernandopassaia)
docker container run -d --name ws1 -p 8080:80 -v $(pwd)/html:/usr/share/nginx/html nginx (pwd is my actual folder - home/fernandopassaia)

Note that if you access the Nginx server (8080), you will see an error, because index.html don't exists on my LocalHost html folder.
This folder is empty, so let's create the "index.html" file.

<html>
<head>
<title>Course of Docker</title>
</head>
<body>
Hello Docker!
</body>
</html>

So just Refresh it and yupi! It's working again but now with my Index.html. MAP is done! You have a cool command to see it.

**docker inspect ws1**

With this command you have details of the container, on "Mounts" section you can see the details of the map.

-----------------------------------------------------------------------------------------------------------------------------------------

**Intermediate: IMAGES of Docker**

**What's an image**: It's a binary that contains all requisites to the creating and execution of a container on Docker, metadata that
describes it's requirements and capacities, including the code of app inside the container, all dependencies and configurations of
runtime. If we can do a parallel with OO: Image is a CLASS meanwhile containners is a objects of this class.

**Layers**: One thing important to understand is that a Image of Docker contains 1-N layers. So for example, if you remove "nginx" image
(docker image rmi nginx) and download again (docker image pull nginx) you will see that docker download 3 different files, so the 
nginx image contains 3 different layers. To inspect the layers of a image use:

docker image inspect nginx

In your result you'll find:

RootFS": {
            "Type": "layers",
            "Layers": [
                "sha256:ffc9b21953f4cd7956cdf532a5db04ff0a2daa7475ad796f1bad58cfbaf77a07",
                "sha256:2f4accd375d93db49e5a47c9bebe4e0dd3cef35f765f5cd36840a986435affc9",
                "sha256:6c7de695ede33d90077f01d60ec29e6a51552a3e350757018ff1b1ecd6cee0bf"
            ]
        },

For what: You have Read/Write layers and you have shared layers. So for example: Some containers can use same layers, for example, the
layer "6c7de695ede33d90077f01d60ec29e6a51552a3e350757018ff1b1ecd6cee0bf" could be used for "Microsoft .Net Core SDK 3 Image" and at the
same time for other images. If i already have it in my system, docker will NOT download again, and more than that, will not aloccate space
storing 2 times (or 3, 4, 5) the same layer. So let's imagine that the 3th layer on this Microsoft image is the NGINX image, the web-server.

If you already have it on your system, it will not be downloaded again, and will be shared for all the images you take that uses nginx. So shared layers will be shared between images. More than it: You have READ/Write Layers, so for example, in this container just the 2 firsts layers are write, and the other is shared. So in a "suppose" case: Docker will mount the 2 layers (write) under the existing Ngnix image.

So it's importante to understand: If i have two or more Containers based on the same image, they also can share the images and the "Read-only"
layers. By this way I'll be saving space and increasing performance on my system.

**How to Create Images**:

(1) **DockerFile**: is a text file with instructions, commands and steps that are executed throught the build command to generate an image.
(2) Commit: But this is not a good practice, because don't store how did you make to build a image. So let's skip and ignore it.

**Creating a Container and Building it using DockerFile:**
So sometimes you need to build your own images, because you don't have ready images with everything you want. So basically Docker can construct images based on the DockerFile. So here it is what docker does:

DockerFile > Build > Docker Image > Run > Docker Container

So basically DockerFile constains in ORDER, all commands necessary to build a image. In this file we define all the rules, informations and instructions of the image.

### Moving to the Exercixes for Images
Note: I'm saving all my Files inside the "Docker" folder, so you'll find them there by number of Exercises.

**First Exercise:**
Create a image based on Debian 8 that installs and starts the server nginx. Look on Docker > 1 > DockerFile to see the result.
So first of all we need to define the steps i need to create a image:

(1) Define a base-image. (FROM)
(2) Define the informations for image. (LABEL)
(3) Execute the commands to install and start nginx. (RUN)
(4) Expose witch PORT the server will attempt on containner (for default is 80, but we will change it) (EXPOSE)
(5) Define the start point for the application (where the command of step6 will be executed). (ENTRYPOINT)
(6) Define the execution of a command to start the server nginx. (CMD)

So this is our DockerFile:
FROM debian:8
LABEL version="1.0" description="Debian/Nginx"
RUN apt-get update && apt-get install -y nginx && apt-get clean
EXPOSE 80
ENTRYPOINT [ "/usr/sbin/nginx" ]
CMD [ "-g", "daemon off;" ]

Note to the 5 and 6 points: What docker will do is run the command: /usr/sbin/nginx -g daemon off;
So Now I Basically needs to build the image, so i enter on the folder where the docker image is and:

**Command to Build the image:** docker build -t passaia/img:1.0 .

This command means:
docker build > construct the image
-t > inform that this image belongs to my user
passaia/img:1.0 > name of image and tag attributed to it
. > means the actual directory (where dockerfile is)

Now that image is build, you can run "docker images" and you will see it there. Now i can create containers based on that:

docker container run -d -p 8080:80 --name=ws1 passaia/img:1.0

If you do "docker container ps" you will see the container in execution.
Now you can open your browser on Localhost:8080 and you will see your nginx running inside your OWN docker container.

**Important Note:** As we said Docker Images works in Layers. So if you take a look to your "docker images", not just the "passaia/img"
will exists, but also the Debian 8 image. So your image of Debian could be SHARED between other images and containners you have. =)

-----------------------------------------------------------------------------------------------------------------------------------------