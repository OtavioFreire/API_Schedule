using System.Collections.Generic;

namespace API_Schedule.Application.Interface
{
    public interface IEndPointsReceiver<T>
    {
        List<T> GetAll();

        T GetById();

        bool Save();

        bool Delete(int Id);

        bool Put();
    }
}
