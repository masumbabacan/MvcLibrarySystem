using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class Earning : IEntity
    {
        [Key]
        public int EarningId { get; set; }
        [StringLength(50)]
        public string Moon { get; set; }
        public decimal Total { get; set; }
    }
}
