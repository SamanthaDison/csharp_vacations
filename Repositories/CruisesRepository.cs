
using System.Collections.Generic;
using System.Data;
using csharp_vacations.Interfaces;
using csharp_vacations.Models;

namespace csharp_vacations.Repositories
{
    public class CruisesRepository : BaseRepository, IRepository<Cruise, int>
    {
        public CruisesRepository(IDbConnection db) : base(db)
        { }

        public Cruise Create(Cruise newData)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int objectId, string userId)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(Cruise update)
        {
            throw new System.NotImplementedException();
        }

        public List<Cruise> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Cruise GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}