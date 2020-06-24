**Sample of RabbitMQ and My Goals here**:
I'll use the Database of JK (witch is inside the folder Database > JkBackup_062020) that has a table with Half Million of Items (ItemOrcamento - 555,793). My Goal here is:

**Publisher**
The app Publisher will take product by product of these Half Million, generate the data (ITO, ORC, CLI) and pass to the RabbitMQ Queue. So yes, it will generate a long list, more than half million of JSONs will be published to the RabbitMQ.

**Consumer**:
The Consumer API will take this data, and save into a new DataBase called "HalfMillionQueue". So this consumer will take the data from the Queue, and create a register into a new database. This New DataBase will contains a new Structure for Client, Orc, and ItemOrc. Nice isn't it?

So we will have 2 databases: The JK (that will be used by Publisher) and the HalfMillionQueue, used by the Consumer.

**HalfMillionQueueApi**: This project will have just one endpoint basically to GET the data from the new database HalfMillionQueue and display data on a JSON (yeah, will be a big one).

**Technology**:
Instead of using EntityFramework as I almost always do, I'll use Dapper. On "Publisher" I'll read the data using a classic approach of read and convert it indo a DTO, manually. The "Domain" classes of this project (Entities) will be isolated into it, so this project will NOT reference the "Domain" project, or use it repositories. On other projects because they are two (Consumer and API), I'll create a Domain and Infra projects to share code. On this project I'll also use a package called "Dapper.Contrib" that maps automatically to the Entity, so I'll not need to mount it on hands, it will auto mount.

Those 3 projects (Publisher, Consumer and API) will run inside Containers on Docker. So we will have RabbitMQ + Dashboard for it, Consumer and Publisher running, everything orquestrated by a "compose" file. On the "compose up" project the projects will start working, everyone, doing their jobs. That's it folks! =) cool not?
