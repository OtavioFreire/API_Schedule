using System.Collections.Generic;

namespace API_Schedule.Infrastucture.Interface
{
    public interface IEndPointsRepository<T>
    {
        List<T> GetAll();

        T GetById();

    }
}
