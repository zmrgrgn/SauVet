using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKafesNoService
    {
        IDataResult<List<KafesNo>> GetAll();
        IResult Add(KafesNo kafesNo);
        IResult Update(KafesNo kafesNo);
        IResult Delete(KafesNo kafesNo);
    }
}
