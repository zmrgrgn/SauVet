using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHayvanTedaviService
    {
        IDataResult<List<HayvanTedavi>> GetAll();
        IResult Add(HayvanTedavi hayvanTedavi);
        IResult Update(HayvanTedavi hayvanTedavi);
        IResult Delete(HayvanTedavi hayvanTedavi);
    }
}
