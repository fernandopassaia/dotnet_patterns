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

**Important Note2**: I can also use "docker login" and "docker push DockerFile" to push to my own container on the Docker Hub WebSite =)

**Second Exercise**
We will now make a contanerization of a **Asp.Net Core MVC App**. We will use base-images of Microsoft to create our own images using Dockerfile. This image will be available on Docker > DeployAspNetCoreMvc folder.

Here is the link oficial from Microsoft: https://hub.docker.com/_/microsoft-dotnet-core
    dotnet/core/sdk: .NET Core SDK
    dotnet/core/aspnet: ASP.NET Core Runtime
    dotnet/core/runtime: .NET Core Runtime
    dotnet/core/runtime-deps: .NET Core Runtime Dependencies
    dotnet/core/samples: .NET Core Samples

The Image I'll use is the Microsoft Asp.Net Core Runtime 3.1 that is smaller than the images with SDK.
docker pull mcr.microsoft.com/dotnet/core/aspnet:3.1

Now we have the following steps:
(1) Create and Deploy an Asp.Net Core MVC.
(2) Create a Dockerfile to create a custom image with base on Microsoft's image.
(3) Create a Containner with base on the custom image.

cd DeployAspNetCoreMvc
mkdir src
cd src
dotnet new mvc
dotnet build
dotnet restore
dotnet publish -o ./dist (the publish will be made on a folder called "dist" inside the mainfolder)

**Importante note:** I can **run** the App by entering the Dist folder and running **"dotnet src.dll".**. Open your browser on localhost:5000/ =)

**Content of the Dockerfile for this app:**

FROM mcr.microsoft.com/dotnet/core/samples:aspnetapp
LABEL version="1.0" maintainer="Passaia"
WORKDIR /app
COPY ./dist .
ENTRYPOINT ["dotnet", "src.dll"]

**How to Build this Image:**
docker build -t aspmvc1-passaia:1.0 .

Now if i listen my images with "docker images" I'll see the "aspmvc1-passaia" image.

**How to RUN my App**:
docker container run -p 5000:80 --name appmvc aspmvc1-passaia:1.0

Now if you open your browser on you LocalHost Ubuntu 20.04: http://localhost:5000 - here there is =)

-----------------------------------------------------------------------------------------------------------------------------------------

**Intermediate: VOLUMES of Docker**

When you remove a Container, Docker will remove the "Write" layers, and keep the read-only layers (images) on the system. So for example:
If i remove my Container "aspmvc1-passaia" created on the steps before, Docker will remove my information, but the "aspnet runtime" image
will still stay in the system. That's OK. But what about my information inside the container? My Logs, Files, where are they now?

This is the questions Volumes comes to solve. Volumes separates the DATA that are generate by apps or databases from the rest of the
containers data. They allow that data exists outsite of containner, what means that you can replace a container without losing it data.

When you create a volume and define the MAP, all the information that will be stored on container will be not made on container, but on
the Folder mapped on Docker Host (my Ubuntu 20.04 in this case). So what's the main reason for Volumes:

(1) Keep the data when a container is removed.
(2) Share data between the host files and the container.
(3) To share data with another containers of docker.

**You have TWO WAYS to Create Volumes and to Keep data after you remove the container. FIRST ONE:**

**The systax of the command is:**

docker container run -v <folder_host>:<folder_container> image
where -v : $(pwd)/teste:/usr/share (pwd gets the folder where i am)

So let's make a sample. I'll create a container of alpine, and map the folder share to my local/maptest folder.

docker container run -it --name alp1 -v $(pwd)/maptest:/usr/share alpine

(it is interative, it will create a new container)

Note that now, you are on the Terminal of the NEW Container. If you ENTER on **usr/share** folder, you'll see that all the changes you made
here are reflected on your **local folder** on Ubuntu "maptest" (this folder is inside the Docker folder of the project). Cool not? =)

If i do "docker container inspect alp1" I'll see the in MOUNTS section the maps i did. =)

**SECOND WAY to Keep data after REMOVE the Container, is to Creating a Volume in fact**:

**docker volume create <name_volume>**
This command will create a new volume that containers can consume and where can store data. If a name is not specified, docker will generate a random name.

**docker volume ls**
Docker will show names of volumes and drivers where they are (usually your local driver).

**docker voume rm teste** to remove volumes or **docker volume prune** to remove all.


**First Exercise:**
Wow, that will be good: I want to create a volume called "sqldata". Then I'll download the image from MYSQL, and yeah, wow, I want MySql to store it data (dbs) inside this Volume called "sqldata". That's impressing no? Let's move ahead. https://hub.docker.com/_/mysql

Note: I'll use MySQL 5.7 image, and MySQL contains some options to include a configuration file or also to pass some parameters (environment variables). In this case my command line will include a parameter to change root password.

docker image pull mysql:5.7
docker image inspect mysql:5.7

On the first inspect, I'll see that this image uses the VOLUME (volumes) directory "/var/lib/mysql" where SQL Server store it's data. Now that i know the volume where SQL store it's data, and i want to change it to my "sqldata" volume instead. So your command is:

**docker container run -d --name mysql -v sqldata:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=@1234Fd# mysql:5.7**

Now if i RUN "docker container inspect mysql" and check the mounts, I'll see that this container is mapping the folder of it's data (/var/lib/mysql) to my Ubuntu Host 20.04 on (/var/lib/docker/volumes/sqldata/_data)

Now that it's create what i need to do. I'll connect interactively on container and connect to bash. Yeah, wow. My point now is to create a new DataBase on MySQL and then I'll see it reflecting on my Ubuntu host.

docker container exec -it mysql /bin/bash

Now I'm on bash of container, I'll open MySql Command Line:
mysql -u root -p (you need to enter your pass)
show databases; (will list all databases)
create database testedb;
show databases; (will list all databases, testedb should appears)

Now this database "testedb" is inside my volume called sqldata. If i remove the "mysql" container, data will be still there, and even if i create a NEW container using this volume, data will still be there. So let's try it, ugye?

docker container stop mysql
docker container rm mysql
docker container run -d --name mysql2 -v sqldata:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=@1234Fd# mysql:5.7
docker container exec -it mysql2 /bin/bash
mysql -u root -p
show databases; (you'll see that database testedb is still alive, because the volume)

-----------------------------------------------------------------------------------------------------------------------------------------

**ADVANCED: NetWork on Docker and Connecting Two Containners**:
Now we want to Connect Two Containners: I have a Containner called "aspmvc1-passaia:1.0" that contains my App Deployed in Asp.Net Core. And i Have a Containner called "mysql" that i have a DataBase that stores it's data on My Host Machine (the DataBase itself on a Volume called sqldata). What I want to Do is Connect this Two Containers, so the AspNet Core App can use the DataBase on the MySQL Container over network. I Have a Image explaining it on Docker > img folder called "1 - Architecture of Apps".

My **AspNetMvc** container is called "appmvc" and have in mind that you need to create and have it:
docker container run -d --name mysql -v sqldata:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=@1234Fd# mysql:5.7

My **MySql** container is called "mysql" and also ahve in mind that you need to create it before go ahead.
docker container run -d --name mysql -v sqldata:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=@1234Fd# mysql:5.7
docker container exec -it mysql /bin/bash
mysql -u root -p
create database testedb;
show databases;

Networks Defined by Software (SDN) or virtual networks.
When you start a container, docker connects to a virtual internal network and gave a IP Address, by this way the container can communicate with the Host and with other Containers on same network. To the Container MVC communicate with the Container MySQL, we need to know what's the IP of the MySQL Container. Yeah, cool =)

**docker network inspect bridge**

The answer of this command will show how Docker configurates the virtual network and will show a section "containers" that show containers connected to network and the IP address of them. So based on my containers, when i run the command what i could check is:

appmvc: 172.17.0.2
mysql: 172.17.0.3

Now we have to connect this two networks, to make appmvc talk with mysql. Docker create virtual networks (managed by an internal software) to manage data-traffic. You can see those networks by running the command **docker network ls**.

(1) Host: Is the Network of the Server Host.
(2) None: Is a Network without connectivity and can be used to isolate the containers.
(3) Bridge: This is the one that we want, because docker adds all containers to this network when we create a new container (by default). So all the containers will be added to "Bridge", except if we explicity change it while creation. So by Default, my two containers are on this Bridge Network. So by Default: The containers on this network (Bridge) could communicate between them using TCP/IP. So if i add new containers, basically docker will give IP 172.17.0.4, 172.17.0.5 ... and they can communicate between then.

Now that we have all Theory, let's go to the **EXERCISE**:
### NOTE: This exercise is a kind of REVIEW of Everything that we learned until now. So it's one of the most important...

This Exercise is entirely stored on the folder DeployAspNetCoreMvcConnectedMySql.

I need to create a Container to my MySql, mapping the storage to my LocalHost to save the database on my host. Then I'll create a Database "Studentsdb" and inside this database I'll populate some data on a table called "students". Then I'll create an AspNet Core MVC app using DockerFile, based on my image, and then this container will communicate with MySql - inside the mvc app I'll create a variable "DbHost" where I'll store the IP of my MySql App. Details of this Exercise on "2 - Exercise using Network". So here are our steps (before that, REMOVE all containers and all the images will be used is just "mysql 5.7" and "aspnetcore_runtime"):

MySql:
(1) Create a Volume called alunosdata.
(2) Create a container using the image mysql5.7
(3) Create a Database called Studentsdb.
(4) Create a Table Students and add some data.
(5) Discover the IP address of this container.

Let's go:
docker volume create --name studentsdata
docker container run -d --name mysql -v studentsdata:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=@1234Fd# -e bind-address=0.0.0.0 mysql:5.7
(note: -v make the container runs on background, bin-address makes mysql accepts connections from everywhere)

After create, i need to run **"docker logs -f mysql"** and check if "mysqld: ready for connections" is printed, so mysql is working and ready!
If everything OK, now you need to open the terminal on this container, to create the database.

docker container exec -it mysql /bin/bash (note: "i" is for interative, "t" is for terminal)
mysql -u root -p (enter the password)
create database Studentsdb;
use Studentsdb;
Create Table Students(StudentId smallint unsigned not null auto_increment, Name varchar(50) not null, Email varchar(80) not null, constraint pk_student primary key (StudentId));
insert into Students(Name, Email) Values ('Fernando Passaia', 'fernandopassaia@futuradata.com.br');
insert into Students(Name, Email) Values ('Jaqueline Guimaraes', 'jaque@futuradata.com.br');
insert into Students(Name, Email) Values ('Hubinha Guimaraes Passaia', 'hubinha@ossinho.com');
select * from Students;
exit
exit


Now you need to Check if your container is still running OK and what's the IP:
docker container ps -a (ok, Up for 11 minutes)
docker network inspect bridge (now i know that my IP is 172.17.0.2 - this is the IP I'll use on .Net Core App)

=) MySQL Part is over. Now let's move ahead to AspNet Core App =)

AspNet Core Mvc App:
(1) Create a application AspNet Core MVC using EF Core to access the DataBases.
(2) Do The Deploy of the App: dotnet publish --configuration Release --output dist
(3) Create a image: docker build -t mvcstudents/app:1.0 .
(4) Create a container using this custom image and made the connection to MySql:
docker container run -d --name mvc1 -p 5000:80 -e DBHOST=17.17.0.2 mvcstudents/app:1.0

So here we go again:
mkdir DeployAspNetCoreMvcConnectedMySql
cd DeployAspNetCoreMvcConnectedMySql
mkdir src
cd src
dotnet new mvc
code .

(note: this app has some models, api controllers and EF Core configurations, check inside the project to see the code...)

To Deploy the App (on src folder):
dotnet publish --configuration Release --output ../dist

Yeah, now the App is inside the dist folder, so i need to go back to VS Code and Create my Dockerfile.

FROM mcr.microsoft.com/dotnet/core/samples:aspnetapp
LABEL version="1.0" maintainer="Passaia"
COPY dist /app
WORKDIR /app
ENTRYPOINT ["dotnet", "src.dll"]

And Run the command to build the image (surrely):
docker build -t mvcstudents/app:1.0 .

Anow now that i have the image, let's create the container pointing to my MySQL:
docker container run -d --name mvc1 -p 5000:80 -e DBHOST=172.17.0.2 mvcstudents/app:1.0 (don't forget your MySql image should be running UP)
docker container ps (both containers should be running here =)


Now Let's **TEST it**:
On your console RUN: docker logs -f mvc1 (to watch the mvc app)

If you Access your browser on localhost:5000 you'll see the app.
If you Access your **http://localhost:5000/students** - Whoala: Your data. Nice! No HTML code and Layout, but there! =)

-----------------------------------------------------------------------------------------------------------------------------------------

**LAST Level Advanced: Docker Compose**:

Docker Compose comes to solve a complexity problemas, let's suppose that i have 3 containners: An Application Asp.Net MVC Razor, an containner with an Application WebApi and a 3th containner with MySQL Database. Let's imagine that this 3 containners depends on each other: Razor is calling the API, and API is calling the DataBase, this is an entire application and they work together.

The combination between containners, volumes and networks in a creation where each step is made manually (so i create the 3 containners separately) is a process that can contain errors. All commands should be inserted correctly and the steps should be executed in the right order to works.

To Solve it: Docker componse is a tool used to describe applications and manage containers, networks and volumes that this applications needs to work. Compose simplify the process of configuration and execution of apps in a way you don't need to input complex commands that could take you to errors of config.

Compose is used to describe complex applications in consistent form using a composition file (extension .yml) that contains all the details of all volumes, networks and containers that compound an application and all information of relationship between then. Docker Compose will agilize the process of deploy of your envoirnment in a simple and patternized way =)
 
On Linux, first of all i need to INSTALL Docker Compose: https://docs.docker.com/compose/install/
sudo curl -L "https://github.com/docker/compose/releases/download/1.25.5/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose
docker-compose --version

Nothing better than an **EXERCISE** right?
My point here is simple: We will get the exercise made on last class, the complex exercise of integration between an AspNet Mvc Core App and MySQL Container, and now I'm gonna do it using a DockerCompose strategy.

First thing I'm gonna do is to create a **CUSTOM NETWORK** for this Containers. I can addopt the strategy of connect them using the Bridge and IP adress like i did, but here I'll do something better that is connect then using a Private Network specially created for them - by this way i don't need to know IP Addresses or if they change or something like this:

**docker create network backend**

**So instead of create networks, volumes, containers in a manual form, I'll use DOCKER COMPOSE now. =)**
So here are my steps brou:

(1) Defne the envoirnment necessary to make my app works using Dockerfile.
(2) Create the composition file "Docker-compose.yml" (or .yaml) and define witch networks, volumes and services are essentials to your app works and the relationship between them.
(3) Process the file .yml by execution the command docker-compose making your envoirnment and configuring it.

Yml or Yaml is a format used to create config files of easy read and organizing the file into sections using space-formating to express the structure of file. So My Composition file is composed of 4 principal sessions:

version: "3" (specify the version of schema for dockercompose, acctualy 3 is the most newer)
volumes: studentsdata (used to configure the volumes that will be used by containers to compose the file. We define this studentsdata)
networks: backend (used to configure the networks that will be used by the containers on file - we define the backend network)
services: (define the containers that will be used - images, contexts, etc)

References:
https://docs.docker.com/compose/compose-file
https://yaml.org/spec/1.2/spec.html

Let's move ahead:
Note: You need to be on the folder of PROJECT, so in our case, DeployAspNetCoreMvcConnectedMySql. Let's create our yml file - take care - identation in this file is important.

version: "3"
volumes:
    studentsdata:
networks:
    backend:

services:
    mysql:
        image: "mysql:5.7"
        volumes:
            - studentsdata:/var/lib/mysql
        networks:
            - backend
        environment: 
            - MYSQL_ROOT_PASSWORD=@1234Fd#
            - bind-address=0.0.0.0


services: descibe services used to create the container.
mysql - indicates start of description for a service that will creates a container mysql.
image - define the image docker will uses to create this container.
volumes - specify the volumes used by container and directories envolved.
networks - specify the networks witch container will be connected on.
environment - define envoirnment variables that will be used when container is created.


Note that basically this container will do the SAME that i did in commands/terminal, but in a compose file. So now i have 3 commands that i can run using this compose file, let's move ahead:

docker-compose build (process the file and check sintaxe)
docker-compose up -d (process the file and start app)
docker-compose ps (will show me containers created)
docker-compose down -v (remove the containers, networks and volumes described on composition file)

So after run the command UP let's check what this compose command did to my system (note: the NAME docker takes from my FOLDER of project - but yeah, i can also specify the name for all those):
docker volume ls (I'll see my "deployaspnetcoremvconnectedtomysql_studentsdata volume)
docker network ls (I'll see my "deployaspnetcoremvconnectedtomysql_backend network)

Note: You'll see that this container is working, and this **compose file is right**! But, **we need to Create the Tables and Populate Data**, yet, and we also need to Insert the **AspNet Core MVC App**. So let's move ahead:

First Drawback all changes you made: docker-compose down -v

First Step: Inside folder MySQL_Init_Script I'll add a Script to Create and Populate My Database:

create database Studentsdb;
use Studentsdb;
DROP TABLE IF EXISTS `Students`;
Create Table `Students`
(
    `StudentId` INT AUTO_INCREMENT,
    `Name` varchar(80) NOT NULL,
    `Email` varchar(100) NOT NULL,
    PRIMARY KEY (`StudentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
    
LOCK TABLES `Students` WRITE;
    insert into `Students` Values ('Fernando Passaia', 'fernandopassaia@futuradata.com.br');
    insert into `Students` Values ('Jaqueline Guimaraes', 'jaque@futuradata.com.br');
    insert into `Students` Values ('Hubinha Guimaraes Passaia', 'hubinha@ossinho.com');
UNLOCK TABLES;


**And Here there is my final docker-compose now calling my Script SQL and also my AspNet Core Mvc Project**:

version: "3"
volumes:
    studentsdata:
networks:
    backend:

services:
    mysql:
        image: "mysql:5.7"
        volumes:
            - studentsdata:/var/lib/mysql
            - ./MySqlInitScript:/docker-entrypoint-initdb.d
        networks:
            - backend
        environment: 
            - MYSQL_ROOT_PASSWORD=@1234Fd#
            - bind-address=0.0.0.0

**Note:** I know that all this docker-entrypoint sound stranges, because do not point right to the ".sql" file, but if you look for the oficial image of MySql on DockerHub, this information is available on "Initializing a fresh instance" part. This command will process the files on the folder (in this case the init.sql on folder).

Now let's move ahead and **create again**:
docker-compose build
docker-compose up -d --build 
docker-compose ps (check if the container is running UP on 3306)
docker-compose logs (check if ready for connections)

Now Let's **test** the container again to see if the SQL Script works on...

docker container exec -it deployaspnetcoremvcconnectedmysql_mysql_1 /bin/bash
mysql -u root -p (password)
show databases;
use Studentsdb;
select * from Students;


**NICE!** Now I see that i have my database with data. This is cool not? =). Now I need my Service that will start my container of AspNetCore MVC. Note that now I'll add to DockerCompose my DOCKERFILE archive of the AspNetMVC Project, passing my network (to communicate with MySql), and asking it to build the file. Look that the lines pass all the parameters that i use before on the TERMINAL command line, but now on the compose file:

version: "3"
volumes:
    studentsdata:
networks:
    backend:

services:
    mysql:
        image: "mysql:5.7"
        volumes:
            - studentsdata:/var/lib/mysql
            - ./MySqlInitScript:/docker-entrypoint-initdb.d
        networks:
            - backend
        environment: 
            - MYSQL_ROOT_PASSWORD=@1234Fd#
            - bind-address=0.0.0.0
    
    mvc:
        build :
            context: .
            dockerfile: Dockerfile
        networks :
            - backend            
        ports :
            - 5000:80
        environment :
            - DBHOST=mysql
            - ASPNETCORE_ENVIRONMENT=Development
        depends_on :
            - mysql

mvc - name of my service
build - indicates the start of section build that tells Docker how to create the image to the container of this service.
context - define the directory of context used to create the image. Because the . it will take the actual directory.
dockerfile - define the file used to create the image.
ports - define the mapping of ports.
DBHOST - name of host
depends_on - Tells docker the order to witch the containers will be created. Here "mysql" container will be created before mvc.


Now we have our final docker-compose. Let's Run:
docker-compose down -v
docker-compose down -v --remove
docker-compose build
docker-compose up -d
docker-compose ps (check if both containers are executing, mvc and mysql are running)
docker-compose logs (check log, if both aspnet core mvc and mysql are running)

Now, just go ahead:
localhost:5000/
localhost:5000/students

IT's Working. WELL DONE! =) . Macoratti course is OVER.

-----------------------------------------------------------------------------------------------------------------------------------------

**Level Supreme - I'll containarize my AppFullStackDemo - An AspNet API + SQL Server Express + Angular App**:

First of All, let's pull the **SQL Server Image** using Ubuntu 16.04: https://hub.docker.com/_/microsoft-mssql-server

docker pull mcr.microsoft.com/mssql/server:2017-CU20-ubuntu-16.04

You can for test create a container and see if it's running:
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=@1234Fd#' -e 'MSSQL_PID=Express' --name sqlserver -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-CU20-ubuntu-16.04


To connect to this instance of SQL Server you can use Azure Data Studio and: localhost, 1433 as SERVER, sa as user, as @1234Fd# as password. Yeah it works! =)
But yeah, I'll not install it using Terminal, so here are my Dockerfile and Docker-Compse file. Both of Them are in BackEnd Folder with .sln Files. Here we go:



**docker-compose**:
version: "3.6"

networks:
    appfullstackdemo:
        driver: bridge

services:
    appfullstackdemo.database:
        image: mcr.microsoft.com/mssql/server:2017-CU20-ubuntu-16.04
        networks:
        - appfullstackdemo
        environment:
            SA_PASSWORD: "@1234Fd#"
            ACCEPT_EULA: "Y"
        ports:
            - "1433:1433"
    
    appfullstackdemo.backend:
        build :
            context: .
            dockerfile: Dockerfile
        networks :
            - appfullstackdemo
        ports :
            - 4001:4001
        environment :            
            - ASPNETCORE_ENVIRONMENT=Development
        depends_on :
            - appfullstackdemo.database

**Dockerfile:**
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
LABEL version="1.0" maintainer="AppFullStackDemoBackEnd"
EXPOSE 4001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
ADD / ./
RUN dotnet restore
COPY . .
WORKDIR /src/AppFullStackDemo.Api
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AppFullStackDemo.Api.dll"]


**Annottations:**
Workdir /src (here I'm creating a folder called /src inside the container)
ADD / ./ (here I'm copy ALL my actual folder (backEnd) to this folder src inside the container - so my entire solution will be copied to the container)

Note: Because the DataBase will run in a separated container, we cannot run the MIGRATION process while building the APP. Yeah, but we found a way to solve it,
inside the backend I've Updated the Startup class adding on Configure the constructor (injecting context) and updating the method to call the migraiton on RUN:

Constructor: public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppFullStackDemoContext context)
Inside the Method: context.Database.Migrate();

**NETWORK PRoblem:**
For some reason, .NET CORE app cannot RUN because during migration, localhost,1433 was not found. So I've changed the approach (to test) changing my connection
string to the CONTAINER SQL SERVER IP Address. So First of All, run:

docker network ls
docker inspect 9acd (where this 4 digits is the start of backend_appfullstackdemo)

Then i see that my connection string is 172.19.0.2, so i've changed it on my backend SOURCE on appsettings.json AND AppFullStackDemoContext.cs:
Data Source=172.19.0.2,1433;Initial Catalog=AppFullStackDemo;Persist Security Info=True;User ID=sa;Password=@1234Fd#

Don't forget to save everything, REMOVE the containers and images, and build it and UP again. =)

**How to RUN my compose and create everything:**
docker-compose build
docker-compose up -d
docker-compose ps (will check if the two containers are running)

**How to REMOVE my compose and delete everything:**
docker-compose down -v --remove (remove will force the stop the containers running)
docker images (will list the images)
docker image rmi 80c9 (there are two images - one for SQL and other for backend) (*80c9 is the first 4 digits of the IMAGE ID)


-----------------------------------------------------------------------------------------------------------------------------------------