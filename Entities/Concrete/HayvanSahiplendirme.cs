using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HayvanSahiplendirme: IEntity
    {
        public int Id { get; set; }
        public string HayvanId { get; set; }
        public DateTime Tarih { get; set; }
        public int VatandasId { get; set; }
        public int BelediyeId { get; set; }

    }
}
