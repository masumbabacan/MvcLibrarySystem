using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract.Repository;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EarningManager : IEarningService
    {
        IEarningDal _earningDal;

        public EarningManager(IEarningDal earningDal)
        {
            _earningDal = earningDal;
        }

        public void Add(Earning earning)
        {
            _earningDal.Add(earning);
        }

        public void Delete(Earning earning)
        {
            _earningDal.Delete(earning);
        }

        public List<Earning> GetAll()
        {
           return _earningDal.GetAll();
        }

        public Earning GetById(int id)
        {
            return _earningDal.Get(x=>x.EarningId==id);
        }

        public void Update(Earning earning)
        {
            _earningDal.Update(earning);
        }
    }
}
