﻿using Consumer.Console.Dto;
using Consumer.Console.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.IO;
using System.Text;

namespace Consumer.Console
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
                channel.QueueDeclare(queue: "CarregarCotacoes",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += Consumer_Received;
                channel.BasicConsume(queue: "HalfMillionQueue",
                     autoAck: true,
                     consumer: consumer);
            }            
        }

        private static void Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var body = e.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var jsonMessage = JObject.Parse(message);
            ItemOrcResult orcItem = JsonConvert.DeserializeObject<ItemOrcResult>(jsonMessage.ToString());            
            ItemOrcRepository itemRepo = new ItemOrcRepository(_configuration.GetConnectionString("JkDataBase"));
            itemRepo.Create(orcItem);
            System.Console.WriteLine("Nova Mensagem Recebida - gravando no banco: " + orcItem.ItoPk);
        }
    }
}
