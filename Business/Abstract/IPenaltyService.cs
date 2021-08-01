using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IPenaltyService
    {
        List<Penalty> GetAll();

        Penalty GetById(int id);

        void Add(Penalty penalty);

        void Delete(Penalty penalty);

        void Update(Penalty penalty);
    }
}
