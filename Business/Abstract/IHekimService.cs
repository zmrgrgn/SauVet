using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHekimService
    {
        IDataResult<List<Hekim>> GetAll();
        IResult Add(Hekim hekim);
        IResult Update(Hekim hekim);
        IResult Delete(Hekim hekim);
    }
}
