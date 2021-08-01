using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class Penalty : IEntity
    {
        [Key]
        public int PenaltyId { get; set; }
       // public int UserId { get; set; }
       // public int MovementId { get; set; }
        public DateTime BeginningDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal Money { get; set; }



        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int MovementId { get; set; }
        public virtual Movement Movement { get; set; }
    }
}
