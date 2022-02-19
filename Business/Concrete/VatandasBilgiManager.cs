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
    public class VatandasBilgiManager : IVatandasBilgiService
    {
        IVatandasBilgiDal _vatandasBilgiDal;

        public VatandasBilgiManager(IVatandasBilgiDal vatandasBilgiDal)
        {
            _vatandasBilgiDal = vatandasBilgiDal;
        }

        [ValidationAspect(typeof(VatandasBilgiValidator))]
        public IResult Add(VatandasBilgi vatandasBilgi)
        {
            IResult result = BusinessRules.Run(CheckIfVatandasBilgiIdExists(vatandasBilgi.Id));
            if (result != null)
            {
                return result;
            }
            _vatandasBilgiDal.Add(vatandasBilgi);

            return new SuccessResult(Messages.VatandasBilgiAdded);
        }
        public IResult Update(VatandasBilgi vatandasBilgi)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _vatandasBilgiDal.Update(vatandasBilgi);

            return new SuccessResult(Messages.VatandasBilgiAdded);
        }
        public IResult Delete(VatandasBilgi vatandasBilgi)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _vatandasBilgiDal.Delete(vatandasBilgi);

            return new SuccessResult(Messages.VatandasBilgiDeleted);
        }
        public IDataResult<List<VatandasBilgi>> GetAll()
        {
            return new SuccessDataResult<List<VatandasBilgi>>(_vatandasBilgiDal.GetAll(),Messages.VatandasBilgiListed);
        }
        private IResult CheckIfVatandasBilgiIdExists(int id)
        {
            var result = _vatandasBilgiDal.GetAll(v => v.Id == id).Any();
            if (result)
            {
                return new ErrorResult(Messages.IdAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
