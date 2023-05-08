using AM.Core.Domain;
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class PlaneService:Service<Plane> , IPlaneService
    {
        //IRepository<Plane> repository;
        //public PlaneService(IRepository<Plane> repository)
        //{
        //    this.repository = repository;
        //}
     // readonly  IUnitOfWork unitOfWork;
        public PlaneService(IUnitOfWork unitOfWork):base(unitOfWork) 
        {
            //this.unitOfWork = unitOfWork;
            //repository = unitOfWork.GetRepository<Plane>();
        }
        //public void Add(Plane plane)
        //{
        //    repository.Add(plane);
        //    // repository.Commit();
        //    unitOfWork.Save();
        //}

        //public void Delete(Plane plane)
        //{
        //    repository.Delete(plane);
        //    // repository.Commit();
        //    unitOfWork.Save();
        //}

        //public IList<Plane> GetAll()
        //{
        //    return repository.GetAll();
        //}
        public IList<Flight> GetFlight(int n)
        {
            return GetAll()
                .OrderByDescending(P=>P.ManufactureDate)
                .Take(n)
                .SelectMany(p=>p.Flights)
                .OrderBy(f=>f.FlightDate)
                .ToList();
        }
        public IList<Passenger> GetPassengers(Plane p) 
        { return Get(p.PlaneId).Flights.SelectMany(f=>f.Reservations) 
                .Select(r=>r.MyPassenger)
                .Distinct().ToList();
        }
    }
}
