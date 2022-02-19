using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHayvanSahiplendirmeService
    {
        IDataResult<List<HayvanSahiplendirme>> GetAll();
        IResult Add(HayvanSahiplendirme hayvanSahiplendirme);
        IResult Update(HayvanSahiplendirme hayvanSahiplendirme);
        IResult Delete(HayvanSahiplendirme hayvanSahiplendirme);
    }
}
