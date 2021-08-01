using DataAccess.Abstract.Repository;
using DataAccess.Concrete.Repository;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfEarningDal : GenericRepository<Earning>, IEarningDal
    {
    }
}
