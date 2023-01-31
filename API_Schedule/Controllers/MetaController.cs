using API_Schedule.Application.Receiver;
using Microsoft.AspNetCore.Mvc;

namespace API_Schedule.Controllers
{
    [ApiController]
    [Route("Meta/")]
    public class MetaController : ControllerBase
    {
        private MetaReceiver _reciver;

        public MetaController(MetaReceiver reciver)
        {
            _reciver = reciver;
        }

        [HttpGet("GetAll")]
        public bool Getall()
        {
            return _reciver.GetAll();
        }

        [HttpGet("GetById")]
        public bool GetById()
        {
            return _reciver.GetById();
        }

        [HttpPost("Post")]
        public bool Save()
        {
            return _reciver.Save();
        }

        [HttpDelete("Delete")]
        public bool Delete()
        {
            return _reciver.Delete();
        }

        [HttpPut("Delete")]
        public bool Put()
        {
            return _reciver.Put();
        }
    }
}
