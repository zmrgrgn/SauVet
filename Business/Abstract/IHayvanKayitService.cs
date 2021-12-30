using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHayvanKayitService
    {
        IDataResult<List<HayvanKayit>> GetAll();
        IDataResult<List<HayvanKayit>> GetAllVatandasId(int VatandasId);
        IResult Add(HayvanKayit hayvanKayit);
        IDataResult<HayvanKayit> GetById(string hayvanKayitId);
    }
}
