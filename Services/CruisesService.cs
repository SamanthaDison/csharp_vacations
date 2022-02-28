
using System;
using csharp_vacations.Models;
using csharp_vacations.Repositories;

namespace csharp_vacations.Services
{
    public class CruisesService
    {
        private readonly CruisesRepository _repo;
        internal CruisesService(CruisesRepository repo)
        {
            _repo = repo;
        }
        internal object GetAll()
        {
            return _repo.GetAll();
        }

        internal Cruise GetById(int id)
        {
            Cruise foundCruise = _repo.GetById(id);
            if (foundCruise == null)
            {
                throw new Exception("Unable to find cruise");
            }
            return foundCruise;
        }

        internal Cruise Create(Cruise newData)
        {
            return _repo.Create(newData);
        }

        internal object Edit(Cruise cruise, string id)
        {
            throw new NotImplementedException();
        }

        internal void Delete(int id1, string id2)
        {
            throw new NotImplementedException();
        }
    }
}