using API_Schedule.Application.Receiver;
using Microsoft.AspNetCore.Mvc;

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
        public bool Getall()
        {
            return _receiver.GetAll();
        }

        [HttpGet("GetById")]
        public bool GetById()
        {
            return _receiver.GetById();
        }

        [HttpPost("Post")]
        public bool Save()
        {
            return _receiver.Save();
        }

        [HttpDelete("Delete")]
        public bool Delete()
        {
            return _receiver.Delete();
        }

        [HttpPut("Delete")]
        public bool Put()
        {
            return _receiver.Put();
        }
    }
}
