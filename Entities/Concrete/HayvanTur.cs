using System;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HayvanTur:IEntity
    {
        public int Id { get; set; }
        public string HayvanTurAd { get; set; }
    }
}
