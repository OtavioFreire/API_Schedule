using System.Data.SqlClient;

namespace API_Schedule.Infrastucture.Structure
{
    public interface IConnectionDB
    {
        SqlConnection GetConnection();
    }
}
