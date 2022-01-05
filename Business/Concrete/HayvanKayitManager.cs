using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
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
        [ValidationAspect(typeof(HayvanKayitValidator))]
        public IResult Add(HayvanKayit hayvanKayit)
        {
            //if(CheckIfHayvanKayitCountOfKafesCorrect(hayvanKayit.KafesNo).Success)
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

        public IResult Update(HayvanKayit hayvanKayit)
        {
            
            throw new NotImplementedException();
        }
        //private IResult CheckIfHayvanKayitCountOfKafesCorrect(int kafesNo)
        //{
        //    var result = _hayvanKayitDal.GetAll(h => h.KafesNo==kafesNo).Count;
        //    if (result >= 10)
        //    {
        //        return new ErrorResult(Messages.OfKafesError);
        //    }
        //    return new SuccessResult();
        //}
    }
}
