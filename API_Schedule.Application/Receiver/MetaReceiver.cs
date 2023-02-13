using API_Schedule.Application.Interface;
using API_Schedule.Infrastucture.Entities;
using API_Schedule.Infrastucture.Interface;
using API_Schedule.Infrastucture.Repository;
using System.Collections.Generic;

namespace API_Schedule.Application.Receiver
{
    public class MetaReceiver : IEndPointsReceiver<ClassMeta>
    {
        private readonly MetaRepository _getAllRepository;

        public MetaReceiver(MetaRepository repository)
        {
            _getAllRepository = repository;
        }

        public List<ClassMeta> GetAll()
        {
            List<ClassMeta> ListMeta = _getAllRepository.GetAll();

            return ListMeta;
        }

        public ClassMeta GetById()
        {
            ClassMeta meta = new ClassMeta();

            return meta;
        }

        public bool Put()
        {
            return _getAllRepository.Update();
        }

        public bool Save()
        {
            return _getAllRepository.Save();
        }

        public bool Delete(int Id)
        {
            return _getAllRepository.Delete();
        }
    }
}
