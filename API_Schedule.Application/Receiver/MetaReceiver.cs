using API_Schedule.Application.Interface;
using API_Schedule.Infrastucture.Interface;
using API_Schedule.Infrastucture.Repository;

namespace API_Schedule.Application.Receiver
{
    public class MetaReceiver : IEndPointsReceiver
    {
        private readonly MetaRepository _getAllRepository;

        public MetaReceiver(MetaRepository repository)
        {
            _getAllRepository = repository;
        }

        public bool GetAll()
        {
            return _getAllRepository.GetAll();
        }

        public bool GetById()
        {
            return _getAllRepository.GetById();
        }

        public bool Put()
        {
            return _getAllRepository.Put();
        }

        public bool Save()
        {
            return _getAllRepository.Save();
        }

        public bool Delete()
        {
            return _getAllRepository.Delete();
        }
    }
}
