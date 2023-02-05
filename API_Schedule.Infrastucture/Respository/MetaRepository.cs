using API_Schedule.Infrastucture.Interface;
using System;
using System.Data.SqlClient;


namespace API_Schedule.Infrastucture.Repository
{
    public class MetaRepository : IEndPointsRepository
    {

        public bool Delete()
        {
            return true;
        }

        public bool GetAll()
        {
            return true;
        }

        public bool GetById()
        {
            throw new System.NotImplementedException();
        }

        public bool Update()
        {
            return true;
        }

        public bool Save()
        {
            return true;
        }
    }
}
