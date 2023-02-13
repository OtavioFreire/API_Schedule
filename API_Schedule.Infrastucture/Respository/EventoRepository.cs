using API_Schedule.Infrastucture.Context;
using API_Schedule.Infrastucture.Entities;
using API_Schedule.Infrastucture.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Schedule.Infrastucture.Repository
{
    public class EventoRepository : IEndPointsRepository<ClassEvento>
    {
        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public List<ClassEvento> GetAll()
        {
            List<ClassEvento> list = new List<ClassEvento>();

            using (DbApiContext contexto = new DbApiContext())
            {
                list = contexto.DBEvento.ToList();
            }

            return list;
        }

        public ClassEvento GetById()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
