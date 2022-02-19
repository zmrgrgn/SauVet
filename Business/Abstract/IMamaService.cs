using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMamaService
    {
        IDataResult<List<Mama>> GetAll();
        IResult Add(Mama mama);
        IResult Update(Mama mama);
        IResult Delete(Mama mama);
    }
}
