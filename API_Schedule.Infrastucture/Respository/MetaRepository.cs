using API_Schedule.Infrastucture.Context;
using API_Schedule.Infrastucture.Entities;
using API_Schedule.Infrastucture.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace API_Schedule.Infrastucture.Repository
{
    public class MetaRepository : IEndPointsRepository<ClassMeta>
    {

        public bool Delete()
        {
            return true;
        }

        public List<ClassMeta> GetAll()
        {
            List<ClassMeta> list = new List<ClassMeta>();

            using (DbApiContext contexto = new DbApiContext()) 
            {
                list = contexto.DBMeta.ToList();
            }

            return list;
        }

        public ClassMeta GetById()
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
