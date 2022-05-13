using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHayvanTurService
    {
        IDataResult<List<HayvanTur>> GetAll();
        IResult Add(HayvanTur hayvanTur);
        IResult Update(HayvanTur hayvanTur);
        IResult Delete(HayvanTur hayvanTur);
    }
}
