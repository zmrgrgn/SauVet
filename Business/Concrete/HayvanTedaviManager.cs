using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HayvanTedaviManager : IHayvanTedaviService
    {
        IHayvanTedaviDal _hayvanTedaviDal;

        public HayvanTedaviManager(IHayvanTedaviDal hayvanTedaviDal)
        {
            _hayvanTedaviDal = hayvanTedaviDal;
        }

        public List<HayvanTedavi> GetAll()
        {
            return _hayvanTedaviDal.GetAll();

            //public Category GetById(int categoryId)
            //{
            //    return _hayvanTedaviDal.GetAll(c=>c.categoryId==categoryId);
            //}
        }
    }
}
