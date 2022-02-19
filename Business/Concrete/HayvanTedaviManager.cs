using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
    public class HayvanTedaviManager : IHayvanTedaviService
    {
        IHayvanTedaviDal _hayvanTedaviDal;

        public HayvanTedaviManager(IHayvanTedaviDal hayvanTedaviDal)
        {
            _hayvanTedaviDal = hayvanTedaviDal;
        }

        [ValidationAspect(typeof(HayvanTedaviValidator))]
        public IResult Add(HayvanTedavi hayvanTedavi)
        {
            IResult result = BusinessRules.Run(CheckIfHayvanTedaviIdExists(hayvanTedavi.Id));
            if (result != null)
            {
                return result;
            }
            _hayvanTedaviDal.Add(hayvanTedavi);

            return new SuccessResult(Messages.HayvanTedaviAdded);
        }
        public IResult Update(HayvanTedavi hayvanTedavi)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanTedaviDal.Update(hayvanTedavi);

            return new SuccessResult(Messages.HayvanTedaviUpdated);
        }
        public IResult Delete(HayvanTedavi hayvanTedavi)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanTedaviDal.Delete(hayvanTedavi);

            return new SuccessResult(Messages.HayvanTedaviDeleted);
        }


        public IDataResult<List<HayvanTedavi>> GetAll()
        {
            return new SuccessDataResult<List<HayvanTedavi>>(_hayvanTedaviDal.GetAll(),Messages.HayvanTedaviListed);

            //public Category GetById(int categoryId)
            //{
            //    return _hayvanTedaviDal.GetAll(c=>c.categoryId==categoryId);
            //}
        }
        private IResult CheckIfHayvanTedaviIdExists(int id)
        {
            var result = _hayvanTedaviDal.GetAll(h => h.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
