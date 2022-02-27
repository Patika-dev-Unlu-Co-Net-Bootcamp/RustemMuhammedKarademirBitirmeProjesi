using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.BitirmeProjesi.Services
{
    public interface IMailSenderService
    {
        void SendEmail(string message,string email);
    }
}
