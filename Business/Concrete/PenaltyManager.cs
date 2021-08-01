using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PenaltyManager : IPenaltyService
    {
        IPenaltyDal _penaltyDal;

        public PenaltyManager(IPenaltyDal penaltyDal)
        {
            _penaltyDal = penaltyDal;
        }

        public void Add(Penalty penalty)
        {
            _penaltyDal.Add(penalty);
        }

        public void Delete(Penalty penalty)
        {
            _penaltyDal.Delete(penalty);
        }

        public List<Penalty> GetAll()
        {
            return _penaltyDal.GetAll();
        }

        public Penalty GetById(int id)
        {
            return _penaltyDal.Get(x => x.PenaltyId == id);
        }

        public void Update(Penalty penalty)
        {
            _penaltyDal.Update(penalty);
        }
    }
}
