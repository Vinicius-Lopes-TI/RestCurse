using Curso_API_2.Data.Converter.Implementations;
using Curso_API_2.Data.VO;
using Curso_API_2.Model;
using Curso_API_2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_API_2.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;
        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }
        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }
        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }
        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }
        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
