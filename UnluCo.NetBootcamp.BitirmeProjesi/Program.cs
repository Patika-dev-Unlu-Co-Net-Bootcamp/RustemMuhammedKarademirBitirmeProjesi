using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;
using UnluCo.NetBootcamp.BitirmeProjesi.Services;

namespace UnluCo.NetBootcamp.BitirmeProjesi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
            };

            using (IConnection connection = factory.CreateConnection())
            using (RabbitMQ.Client.IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "EmailQuee",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += (model, mq) =>
                {
                    var message = Encoding.UTF8.GetString(mq.Body.ToArray());
                    var result = JsonConvert.DeserializeObject<EmailModel>(message);
                    MailSenderService mailSender = new MailSenderService();
                    mailSender.SendEmail(result.Body,result.Email);               
                };

                channel.BasicConsume(queue: "EmailQuee",
                                     autoAck: true,//true ise mesaj otomatik olarak kuyruktan silinir
                                     consumer: consumer);

                CreateHostBuilder(args).Build().Run();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
