using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBelediyeBilgiService
    {
        IDataResult<List<BelediyeBilgi>> GetAll();
        IResult Add(BelediyeBilgi belediyeBilgi);
        IResult Update(BelediyeBilgi belediyeBilgi);
        IResult Delete(BelediyeBilgi belediyeBilgi);

    }
}
