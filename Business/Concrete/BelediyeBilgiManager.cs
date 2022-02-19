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
    public class BelediyeBilgiManager : IBelediyeBilgiService
    {
        IBelediyeBilgiDal _belediyeBilgiDal;

        public BelediyeBilgiManager(IBelediyeBilgiDal belediyeBilgiDal)
        {
            _belediyeBilgiDal = belediyeBilgiDal;
        }
        [ValidationAspect(typeof(BelediyeBilgiValidator))]
        public IResult Add(BelediyeBilgi belediyeBilgi)
        {
            IResult result = BusinessRules.Run(CheckIfBelediyeBilgiIdExists(belediyeBilgi.Id));
            if (result != null)
            {
                return result;
            }
            _belediyeBilgiDal.Add(belediyeBilgi);

            return new SuccessResult(Messages.BelediyeBilgiAdded);
        }
        public IResult Update(BelediyeBilgi belediyeBilgi)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _belediyeBilgiDal.Update(belediyeBilgi);

            return new SuccessResult(Messages.BelediyeBilgiUpdated);
        }

        public IDataResult<List<BelediyeBilgi>> GetAll()
        {
            return new SuccessDataResult<List<BelediyeBilgi>>(_belediyeBilgiDal.GetAll(),Messages.BelediyeBilgiListed);
        }
        private IResult CheckIfBelediyeBilgiIdExists(int id)
        {
            var result = _belediyeBilgiDal.GetAll(b => b.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }

        public IResult Delete(BelediyeBilgi belediyeBilgi)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _belediyeBilgiDal.Delete(belediyeBilgi);

            return new SuccessResult(Messages.BelediyeBilgiDeleted);
        }
    }
}
