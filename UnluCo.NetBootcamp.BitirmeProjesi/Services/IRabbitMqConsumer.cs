using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Services
{
    public interface IRabbitMqConsumer
    {
        void QueueDeclare();
    }
}
