using Curso_API_2.Data.Converter.Contract;
using Curso_API_2.Data.VO;
using Curso_API_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_API_2.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                author = origin.author,
                launch_date = origin.launch_date,
                price = origin.price,
                title = origin.title
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                author = origin.author,
                launch_date = origin.launch_date,
                price = origin.price,
                title = origin.title
            };
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
