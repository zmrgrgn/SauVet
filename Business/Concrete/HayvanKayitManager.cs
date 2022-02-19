using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
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
        IHayvanTedaviService _hayvanTedaviService;
        public HayvanKayitManager(IHayvanKayitDal hayvanKayitDal, IHayvanTedaviService hayvanTedaviService)
        {
            _hayvanKayitDal = hayvanKayitDal;
            _hayvanTedaviService = hayvanTedaviService;
        }
        [ValidationAspect(typeof(HayvanKayitValidator))]
        public IResult Add(HayvanKayit hayvanKayit)
        {
            IResult result=BusinessRules.Run(CheckIfHayvanKayitIdExists(hayvanKayit.Id));
            //CheckIfHayvanKayitCountOfKafesCorrect(hayvanKayit.KafesNo)
            if (result!=null)
            {
                return result;
            }
            _hayvanKayitDal.Add(hayvanKayit);

            return new SuccessResult(Messages.HayvanKayitAdded);
            //CheckIfHayvanKayitCountOfKafesCorrect(hayvanKayit.KafesNo)

        }
        public IResult Update(HayvanKayit hayvanKayit)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanKayitDal.Update(hayvanKayit);

            return new SuccessResult(Messages.HayvanKayitAdded);
        }
        public IResult Delete(HayvanKayit hayvanKayit)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanKayitDal.Delete(hayvanKayit);

            return new SuccessResult(Messages.HayvanKayitDeleted);
        }

        public IDataResult<List<HayvanKayit>> GetAll()
        {
            if (DateTime.Now.Hour==1)
            {
                return new ErrorDataResult<List<HayvanKayit>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<HayvanKayit>>(_hayvanKayitDal.GetAll(),Messages.HayvanKayitListed);
        }

        public IDataResult<List<HayvanKayit>> GetAllVatandasId(int VatandasId)
        {
            return new SuccessDataResult<List<HayvanKayit>>(_hayvanKayitDal.GetAll(h=>h.VatandasId==VatandasId));
        }//vatandaş idsini girince o kişiyi bulduran kısım

        public IDataResult<HayvanKayit> GetById(string hayvanKayitId)
        {
            return new SuccessDataResult<HayvanKayit>(_hayvanKayitDal.Get(h=>h.Id==hayvanKayitId));
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
        private IResult CheckIfHayvanKayitIdExists(string id)
        {
            var result = _hayvanKayitDal.GetAll(h => h.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
