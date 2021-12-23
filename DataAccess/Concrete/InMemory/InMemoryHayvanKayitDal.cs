using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryHayvanKayitDal : IHayvanKayitDal
    {
        List<HayvanKayit> _hayvanKayits;
        public InMemoryHayvanKayitDal()
        {
            _hayvanKayits = new List<HayvanKayit>
            { new HayvanKayit{Ad="deneme",Id="1" },
            new HayvanKayit{Ad="pamuk",Id="2" }
            };
        }
        public void Add(HayvanKayit hayvanKayit)
        {
            _hayvanKayits.Add(hayvanKayit);
        }

        public void Delete(HayvanKayit hayvanKayit)
        {
            HayvanKayit hayvanKayitToDelete = _hayvanKayits.SingleOrDefault(h=>h.Id==hayvanKayit.Id);
            _hayvanKayits.Remove(hayvanKayitToDelete);
        }

        public HayvanKayit Get(Expression<Func<HayvanKayit, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<HayvanKayit> GetAll()
        {
            return _hayvanKayits;
        }

        public List<HayvanKayit> GetAll(Expression<Func<HayvanKayit, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(HayvanKayit hayvanKayit)
        {
            HayvanKayit hayvanKayitToUpdate = _hayvanKayits.SingleOrDefault(h => h.Id == hayvanKayit.Id);
            hayvanKayitToUpdate.Ad = hayvanKayit.Ad;
        }
    }
}
