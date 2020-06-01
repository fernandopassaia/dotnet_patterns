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

**Now we go to the MAIN commands**:

docker --version
docker --help (list all commands)
docker images (show the imagens available on system)

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

-----------------------------------------------------------------------------------------------------------------------------------------

**Moving to the Exercixes and some more RealWorlds usages**

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