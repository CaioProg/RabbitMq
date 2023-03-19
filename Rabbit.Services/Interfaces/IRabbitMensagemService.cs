using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rabbit.Models.Entities;

namespace Rabbit.Services.Interfaces
{
    public interface IRabbitMensagemService
    {
        void SendMensagem(RabbitMensagem mensagem);
            
    }
}
