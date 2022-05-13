
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
    public class HayvanTurManager : IHayvanTurService
    {
        IHayvanTurDal _hayvanTurDal;
        public HayvanTurManager(IHayvanTurDal hayvanTurDal)
        {
            _hayvanTurDal = hayvanTurDal;
        }
        [ValidationAspect(typeof(HayvanTurValidator))]
        public IResult Add(HayvanTur hayvanTur)
        {
            IResult result = BusinessRules.Run(CheckIfHayvanTurIdExists(hayvanTur.Id));
            if (result != null)
            {
                return result;
            }
            _hayvanTurDal.Add(hayvanTur);

            return new SuccessResult(Messages.HayvanTurAdded);
        }

        public IResult Delete(HayvanTur hayvanTur)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanTurDal.Delete(hayvanTur);

            return new SuccessResult(Messages.HayvanTurDeleted);
        }

        public IDataResult<List<HayvanTur>> GetAll()
        {
            return new SuccessDataResult<List<HayvanTur>>(_hayvanTurDal.GetAll(), Messages.HayvanTurListed);
        }

        public IResult Update(HayvanTur hayvanTur)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanTurDal.Update(hayvanTur);

            return new SuccessResult(Messages.HayvanTurUpdated);
        }
        private IResult CheckIfHayvanTurIdExists(int id)
        {
            var result = _hayvanTurDal.GetAll(h => h.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
