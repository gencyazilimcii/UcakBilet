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
    public class KampanyaManager : IKampanyaService
    {
        IKampanyaDal _kampanyaDal;

        public KampanyaManager(IKampanyaDal kampanyaDal)
        {
            _kampanyaDal = kampanyaDal;
        }

        public void TAdd(Kampanya t)
        {
            _kampanyaDal.Insert(t);
        }

        public void TDelete(Kampanya t)
        {
            _kampanyaDal.Delete(t);
        }

        public Kampanya TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kampanya> TGetList()
        {
            return _kampanyaDal.GetList();

        }

        public void TUpdate(Kampanya t)
        {
            _kampanyaDal.Update(t);
        }
    }
}
