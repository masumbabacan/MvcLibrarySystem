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
    public class MovementManager : IMovementService
    {
        IMovementDal _movementDal;

        public MovementManager(IMovementDal movementDal)
        {
            _movementDal = movementDal;
        }

        public void Add(Movement movement)
        {
                movement.ProcessStatus = false;
                _movementDal.Add(movement);
        }

        public void Delete(Movement movement)
        {
            _movementDal.Delete(movement);
        }

        public List<Movement> GetAll()
        {
            return _movementDal.GetAll();
        }

        public List<Movement> GetAllProcessFalse()
        {
            return _movementDal.List(x=>x.ProcessStatus == false);
        }

        public List<Movement> GetAllProcessTrue()
        {
            return _movementDal.List(x => x.ProcessStatus == true);
        }

        public Movement GetById(int id)
        {
            return _movementDal.Get(x => x.MovementId == id);
        }

        public void Update(Movement movement)
        {
            _movementDal.Update(movement);
        }
    }
}
