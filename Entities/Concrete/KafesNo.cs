using System;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class KafesNo:IEntity
    {
        public int Id { get; set; }
        public string KafesAdi { get; set; }
    }
}
