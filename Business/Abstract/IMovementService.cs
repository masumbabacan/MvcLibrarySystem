using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IMovementService
    {
        List<Movement> GetAll();

        List<Movement> GetAllProcessFalse();

        Movement GetById(int id);

        void Add(Movement movement);

        void Delete(Movement movement);

        void Update(Movement movement);
    }
}
