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
    public class HayvanSahiplendirmeManager : IHayvanSahiplendirmeService
    {
        IHayvanSahiplendirmeDal _hayvanSahiplendirmeDal;

        public HayvanSahiplendirmeManager(IHayvanSahiplendirmeDal hayvanSahiplendirmeDal)
        {
            _hayvanSahiplendirmeDal = hayvanSahiplendirmeDal;
        }

        [ValidationAspect(typeof(HayvanSahiplendirmeValidator))]
        public IResult Add(HayvanSahiplendirme hayvanSahiplendirme)
        {
            IResult result = BusinessRules.Run(CheckIfHayvanSahiplendirmeIdExists(hayvanSahiplendirme.Id));
            if (result != null)
            {
                return result;
            }
            _hayvanSahiplendirmeDal.Add(hayvanSahiplendirme);

            return new SuccessResult(Messages.HayvanSahiplendirmeAdded);
        }
        public IResult Update(HayvanSahiplendirme hayvanSahiplendirme)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanSahiplendirmeDal.Update(hayvanSahiplendirme);

            return new SuccessResult(Messages.HayvanSahiplendirmeUpdated);
        }
        public IResult Delete(HayvanSahiplendirme hayvanSahiplendirme)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hayvanSahiplendirmeDal.Delete(hayvanSahiplendirme);

            return new SuccessResult(Messages.HayvanSahiplendirmeDeleted);
        }

        public IDataResult<List<HayvanSahiplendirme>> GetAll()
        {
            return new SuccessDataResult<List<HayvanSahiplendirme>>(_hayvanSahiplendirmeDal.GetAll(),Messages.HayvanSahiplendirmeListed);
        }
        private IResult CheckIfHayvanSahiplendirmeIdExists(int id)
        {
            var result = _hayvanSahiplendirmeDal.GetAll(h => h.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
