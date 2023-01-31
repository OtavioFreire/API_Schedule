namespace API_Schedule.Application.Interface
{
    public interface IEndPointsReceiver
    {
        bool GetAll();

        bool GetById();

        bool Save();

        bool Delete();

        bool Put();
    }
}
