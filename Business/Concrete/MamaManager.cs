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
    public class MamaManager : IMamaService
    {

        IMamaDal _mamaDal;

        public MamaManager(IMamaDal mamaDal)
        {
            _mamaDal = mamaDal;
        }
        [ValidationAspect(typeof(MamaValidator))]
        public IResult Add(Mama mama)
        {
            IResult result = BusinessRules.Run(CheckIfMamaIdExists(mama.Id));
            if (result != null)
            {
                return result;
            }
            _mamaDal.Add(mama);

            return new SuccessResult(Messages.MamaAdded);
        }
        public IResult Update(Mama mama)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _mamaDal.Update(mama);

            return new SuccessResult(Messages.MamaAdded);
        }

        public IResult Delete(Mama mama)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _mamaDal.Delete(mama);

            return new SuccessResult(Messages.MamaDeleted);
        }

        public IDataResult<List<Mama>> GetAll()
        {
            return new SuccessDataResult<List<Mama>>(_mamaDal.GetAll(),Messages.MamaListed);
        }
        private IResult CheckIfMamaIdExists(int id)
        {
            var result = _mamaDal.GetAll(m => m.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
