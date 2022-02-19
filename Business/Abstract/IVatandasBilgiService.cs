using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public interface IVatandasBilgiService
    {
        IDataResult<List<VatandasBilgi>> GetAll();
        IResult Add(VatandasBilgi vatandasBilgi);
        IResult Update(VatandasBilgi vatandasBilgi);
        IResult Delete(VatandasBilgi vatandasBilgi);
    }
}
