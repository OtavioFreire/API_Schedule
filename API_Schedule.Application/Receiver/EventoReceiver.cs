using API_Schedule.Application.Interface;
using API_Schedule.Infrastucture.Entities;
using API_Schedule.Infrastucture.Repository;
using System.Collections.Generic;

namespace API_Schedule.Application.Receiver
{
    public class EventoReceiver : IEndPointsReceiver<ClassEvento>
    {
        EventoRepository _metaRepository;

        public EventoReceiver(EventoRepository metaRepository)
        {
            _metaRepository = metaRepository;
        }

        public List<ClassEvento> GetAll()
        {
            var ListEvento = new List<ClassEvento>();

            return ListEvento;
        }

        public ClassEvento GetById()
        {
            var Evento = new ClassEvento();
            return Evento;
        }

        public bool Put()
        {
            return _metaRepository.Update();
        }

        public bool Save()
        {
            return _metaRepository.Save();
        }

        public bool Delete(int Id)
        {
            return _metaRepository.Delete();
        }
    }
}
