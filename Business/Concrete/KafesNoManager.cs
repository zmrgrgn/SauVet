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
    public class KafesNoManager : IKafesNoService
    {
        IKafesNoDal _kafesNoDal;
        public KafesNoManager(IKafesNoDal kafesNoDal)
        {
            _kafesNoDal = kafesNoDal;
        }
        [ValidationAspect(typeof(KafesNoValidator))]
        public IResult Add(KafesNo kafesNo)
        {
            IResult result = BusinessRules.Run(CheckIfKafesNoIdExists(kafesNo.Id));
            if (result != null)
            {
                return result;
            }
            _kafesNoDal.Add(kafesNo);

            return new SuccessResult(Messages.KafesNoAdded);
        }

        public IResult Delete(KafesNo kafesNo)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _kafesNoDal.Delete(kafesNo);

            return new SuccessResult(Messages.KafesNoDeleted);
        }

        public IDataResult<List<KafesNo>> GetAll()
        {
            return new SuccessDataResult<List<KafesNo>>(_kafesNoDal.GetAll(), Messages.KafesNoListed);
        }

        public IResult Update(KafesNo kafesNo)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _kafesNoDal.Update(kafesNo);

            return new SuccessResult(Messages.KafesNoUpdated);
        }
        private IResult CheckIfKafesNoIdExists(int id)
        {
            var result = _kafesNoDal.GetAll(h => h.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }

       
    }
}
