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
    public class HekimManager : IHekimService
    {

        IHekimDal _hekimDal;

        public HekimManager(IHekimDal hekimDal)
        {
            _hekimDal = hekimDal;
        }
        [ValidationAspect(typeof(HekimValidator))]
        public IResult Add(Hekim hekim)
        {
            IResult result = BusinessRules.Run(CheckIfHekimIdExists(hekim.Id));
            if (result != null)
            {
                return result;
            }
            _hekimDal.Add(hekim);

            return new SuccessResult(Messages.HekimAdded);
        }
        public IResult Update(Hekim hekim)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hekimDal.Update(hekim);

            return new SuccessResult(Messages.HekimUpdated);
        }

        public IResult Delete(Hekim hekim)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _hekimDal.Delete(hekim);

            return new SuccessResult(Messages.HekimDeleted);
        }

        public IDataResult<List<Hekim>> GetAll()
        {
            return new SuccessDataResult<List<Hekim>>(_hekimDal.GetAll(),Messages.HekimListed);
        }
        private IResult CheckIfHekimIdExists(int id)
        {
            var result = _hekimDal.GetAll(h => h.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
