using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(HayvanKayit hayvanKayit)
        {
            if (hayvanKayit.Ad.Length<2)
            {
                return new ErrorResult(Messages.HayvanNameInvalid);
            }
            _hayvanKayitDal.Add(hayvanKayit);

            return new SuccessResult(Messages.HayvanAdded);
        }

        public IDataResult<List<HayvanKayit>> GetAll()
        {
            if (DateTime.Now.Hour==15)
            {
                return new ErrorDataResult<List<HayvanKayit>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<HayvanKayit>>(_hayvanKayitDal.GetAll(),Messages.HayvanListed);
        }

        public IDataResult<List<HayvanKayit>> GetAllVatandasId(int VatandasId)
        {
            return new SuccessDataResult<List<HayvanKayit>>(_hayvanKayitDal.GetAll(h=>h.VatandasId==VatandasId));
        }//vatandaş idsini girince o kişiyi bulduran kısım

        public IDataResult<HayvanKayit> GetById(string hayvanKayitId)
        {
            return new SuccessDataResult<HayvanKayit>(_hayvanKayitDal.Get(h=>h.Id==hayvanKayitId));
        }
    }
}
