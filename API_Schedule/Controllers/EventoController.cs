using API_Schedule.Application.Receiver;
using API_Schedule.Infrastucture.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Schedule.Controllers
{
    [ApiController]
    [Route("Evento")]
    public class EventoController : ControllerBase
    {

        EventoReceiver _receiver;

        public EventoController(EventoReceiver receiver)
        {
            _receiver = receiver;
        }

        [HttpGet("GetAll")]
        public List<ClassEvento> Getall()
        {
            return _receiver.GetAll();
        }

        [HttpGet("GetById")]
        public ClassEvento GetById()
        {
            return _receiver.GetById();
        }

        [HttpPost("Post")]
        public bool Save()
        {
            return _receiver.Save();
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return _receiver.Delete(Id);
        }

        [HttpPut("Delete")]
        public bool Put()
        {
            return _receiver.Put();
        }
    }
}
