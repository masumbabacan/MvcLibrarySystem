using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        [Key]
        public int BookId { get; set; }
       // public int CategoryId { get; set; }
       // public int WriterId { get; set; }
       [StringLength(50)]
        public string BookName { get; set; }
        [StringLength(50)]
        public string PrintingYear { get; set; }
        [StringLength(50)]
        public string Publisher { get; set; }
        [StringLength(50)]
        public string NumberPage { get; set; }
        public bool Status { get; set; }


        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }


        public ICollection<Movement> Movements { get; set; }
    }
}


