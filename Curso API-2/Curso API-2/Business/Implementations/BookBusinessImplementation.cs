﻿using Curso_API_2.Model;
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
        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }
        public Book Create(Book book)
        {
            return _repository.Create(book);
        }
        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
