using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Publisher.Console.Repository;
using RabbitMQ.Client;
using System.IO;
using System.Linq;
using System.Text;

namespace Publisher.Console
{
    class Program
    {
        private static IConfiguration _configuration;
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            _configuration = builder.Build();

            //get the data of JK database
            var itemOrcData = new ItemOrcRepository(_configuration.GetConnectionString("JkDataBase")).Get();

            // configure the RabbitMQ on Docker (check appsettings). To create the image on RabbitMQ:
            // docker run -d --hostname rabbit-local --name testes-rabbitmq -p 6672:5672 -p 15672:15672 -e RABBITMQ_DEFAULT_USER=passaia -e RABBITMQ_DEFAULT_PASS=PASSAIA2020! rabbitmq:3.8.5-management-alpine

            var rabbitMQConfigurations = new RabbitMQConfigurations();
            new ConfigureFromConfigurationOptions<RabbitMQConfigurations>(
                _configuration.GetSection("RabbitMQConfigurations"))
                    .Configure(rabbitMQConfigurations);

            var factory = new ConnectionFactory()
            {
                HostName = rabbitMQConfigurations.HostName,
                Port = rabbitMQConfigurations.Port,
                UserName = rabbitMQConfigurations.UserName,
                Password = rabbitMQConfigurations.Password
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "HalfMillionQueue",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);
                int indice = 1;
                itemOrcData.ToList().ForEach(itemOrc =>
                {
                    string body = Newtonsoft.Json.JsonConvert.SerializeObject(itemOrc);                    
                    channel.BasicPublish(exchange: "",
                                     routingKey: "HalfMillionQueue",
                                     basicProperties: null,
                                     body: Encoding.UTF8.GetBytes(body));
                    System.Console.WriteLine("Publicado " + indice.ToString() + ":", Newtonsoft.Json.JsonConvert.DeserializeObject(body));
                    System.Console.WriteLine(" ");
                    indice++;
                });
                
                System.Console.WriteLine("Processamento Finalizado");
                System.Console.ReadKey();
            }
        }
    }
}
