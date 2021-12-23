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
    public class HayvanKayitManager : IHayvanKayitService
    {
        IHayvanKayitDal _hayvanKayitDal;
        public HayvanKayitManager(IHayvanKayitDal hayvanKayitDal)
        {
            _hayvanKayitDal = hayvanKayitDal;
        }
        public List<HayvanKayit> GetAll()
        {
            return _hayvanKayitDal.GetAll();
        }

        public List<HayvanKayit> GetAllVatandasId(int VatandasId)
        {
            return _hayvanKayitDal.GetAll(h=>h.VatandasId==VatandasId);
        }//vatandaş idsini girince o kişiyi bulduran kısım
    }
}
