using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IEarningService
    {
        List<Earning> GetAll();

        Earning GetById(int id);

        void Add(Earning earning);

        void Delete(Earning earning);

        void Update(Earning earning);
    }
}
