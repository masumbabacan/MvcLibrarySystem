using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class Movement : IEntity
    {
        [Key]
        public int MovementId { get; set; }
       // public int BookId { get; set; }
       // public int UserId { get; set; }
       // public int EmployeeId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime ReturnDate { get; set; }


        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }


        public ICollection<Penalty> Penalties { get; set; }


    }
}
