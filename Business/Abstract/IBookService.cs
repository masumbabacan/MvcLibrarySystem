using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();

        List<Book> GetAllDepositBook();

        Book GetById(int id);

        void Add(Book book);

        void Delete(Book book);

        void Update(Book book);
    }
}
