namespace API_Schedule.Infrastucture.Interface
{
    public interface IEndPointsRepository
    {
        bool GetAll();

        bool GetById();

        bool Save();

        bool Delete();

        bool Put();
    }
}
