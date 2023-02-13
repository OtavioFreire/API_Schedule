using API_Schedule.Application.Receiver;
using API_Schedule.Infrastucture.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public List<ClassMeta> Getall()
        {
            return _reciver.GetAll();
        }

        [HttpGet("GetById")]
        public ClassMeta GetById()
        {
            return _reciver.GetById();
        }

        [HttpPost("Post")]
        public bool Save()
        {
            return _reciver.Save();
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return _reciver.Delete(Id);
        }

        [HttpPut("Delete")]
        public bool Put()
        {
            return _reciver.Put();
        }
    }
}
