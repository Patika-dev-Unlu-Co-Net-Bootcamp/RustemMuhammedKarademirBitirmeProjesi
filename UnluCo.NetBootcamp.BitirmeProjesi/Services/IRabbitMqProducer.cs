using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.BitirmeProjesi.Entities;
using UnluCo.NetBootcamp.BitirmeProjesi.Models;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Services
{
    public interface IRabbitMqProducer
    {
        void QueueDeclare(EmailModel model);
    }
}
