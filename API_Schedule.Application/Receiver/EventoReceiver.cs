using API_Schedule.Application.Interface;
using API_Schedule.Infrastucture.Repository;

namespace API_Schedule.Application.Receiver
{
    public class EventoReceiver : IEndPointsReceiver
    {
        EventoRepository _metaRepository;

        public EventoReceiver(EventoRepository metaRepository)
        {
            _metaRepository = metaRepository;
        }

        public bool GetAll()
        {
            return _metaRepository.GetAll();
        }

        public bool GetById()
        {
            return _metaRepository.GetById();
        }

        public bool Put()
        {
            return _metaRepository.Update();
        }

        public bool Save()
        {
            return _metaRepository.Save();
        }

        public bool Delete()
        {
            return _metaRepository.Delete();
        }
    }
}
