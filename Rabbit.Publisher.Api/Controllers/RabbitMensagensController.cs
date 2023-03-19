using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rabbit.Services.Interfaces;
using Rabbit.Models.Entities;

namespace Rabbit.Publisher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitMensagensController : ControllerBase
    {
        private readonly IRabbitMensagemService _service;

        public RabbitMensagensController(IRabbitMensagemService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddMensagem(RabbitMensagem mensagem)
        {
            _service.SendMensagem(mensagem);
        }
    }
}
