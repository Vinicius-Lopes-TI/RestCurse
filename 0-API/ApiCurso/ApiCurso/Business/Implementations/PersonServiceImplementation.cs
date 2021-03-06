﻿using ApiCurso.Model;
using ApiCurso.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCurso.Business;
using ApiCurso.Repository;

namespace ApiCurso.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);            
        }

        public Person FindById(long id)
        {
             return _repository.FindById(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
