using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
        [StringLength(50)]
        public string School { get; set; }
        public string LinkedIn { get; set; }


        public ICollection<Movement> Movements { get; set; }
        public ICollection<Penalty> Penalties { get; set; }
    }
}

