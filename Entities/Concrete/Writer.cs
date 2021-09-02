using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class Writer : IEntity
    {
        [Key]
        public int WriterId { get; set; }

        public ICollection<Book> Books { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="Yazar Adını Boş Geçemezsiniz")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Yazar Soyadını Boş Geçemezsiniz")]
        [StringLength(50)]
        public string LastName { get; set; }



    }
}

