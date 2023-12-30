using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FlightManager : IFlightService
    {
        IFlightDal _flightDal;

        public FlightManager(IFlightDal flightDal)
        {
            _flightDal = flightDal;
        }

        public void TAdd(Flight t)
        {
            _flightDal.Insert(t);
        }

        public void TDelete(Flight t)
        {
            _flightDal.Delete(t);
        }

        public Flight TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Flight> TGetList()
        {
           return _flightDal.GetList();
        }

        public void TUpdate(Flight t)
        {
            _flightDal.Update(t);
        }
    }
}
