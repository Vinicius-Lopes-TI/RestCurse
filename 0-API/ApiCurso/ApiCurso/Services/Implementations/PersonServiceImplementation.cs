using ApiCurso.Model;
using ApiCurso.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCurso.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySqlContext _context;
        public PersonServiceImplementation(MySqlContext context)
        {
            _context = context;
        }

        List<Person> IPersonService.FindAll()
        {
            return _context.Persons.ToList();
        }
        Person IPersonService.FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }
        Person IPersonService.Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }
        Person IPersonService.Update(Person person)
        {
            if (!Exists(person.Id))
                return new Person();

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return person;
        }
        void IPersonService.Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        private bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
