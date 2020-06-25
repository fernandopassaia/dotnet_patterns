**Sample of RabbitMQ and My Goals here**:
I'll use the Database of JK (witch is inside the folder Database > JkBackup_062020) that has a table with Half Million of Items (ItemOrcamento - 555,793). My Goal here is:

**Publisher**
The app Publisher will take product by product of these Half Million, generate the data (ITO, ORC, CLI) and pass to the RabbitMQ Queue in a JSON format. So yes, it will generate a long list, more than half million of JSONs will be published to the RabbitMQ.

**Consumer**:
The Consumer API will take this data, and save into a Brand New DataBase called "HalfMillionQueue". So this consumer will take the data from the Queue, and insert it into a brand new database. Nice Isn't it?
So we will have 2 databases: The JK (that will be used by Publisher) - Publisher will extract the data from here and send in JSON format to Queue. The consumer will take these JSONS, convert them to DTO, and Save into the New DB.

**Technology**:
Instead of using EntityFramework as I almost always do, I'll use Dapper. So this will also contains a new technology, once Dapper is better for do selects and I'll have a cool select into publisher. On this project I'll also use a package called "Dapper.Contrib" that maps automatically to the Entity, so I'll not need to mount it on hands, it will auto mount.
RabbitMQ will run with Dashboard in a container.
