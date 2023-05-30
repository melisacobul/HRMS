using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete
{
    public class PersonalDal : IPersonalDal
    {
        PersonalDbContext db = new PersonalDbContext();
        public Personal CreatePersonal(Personal personal)
        {
            db.Personals.Add(personal);
            db.SaveChanges();
            return personal;
        }

        public void DeletePersonal(int id)
        {
            var delete = GetPersonalById(id);
            db.Personals.Remove(delete);
            db.SaveChanges();
        }

        public List<Personal> GetAllPersonals()
        {
            using (var db = new PersonalDbContext())
            {
                var personals = db.Personals
                    .Where(p => p.IsActive == 1).ToList();
                return personals;
            }
        }

        public List<Personal> GetAllPassivePersonals()
        {
            using (var db = new PersonalDbContext())
            {
                var personals = db.Personals
                    .Where(p => p.IsActive == 0).ToList();
                return personals;
            }
        }

        public Personal GetPersonalById(int id)
        {
            using (var db = new PersonalDbContext())
            {
                return db.Personals.Find(id);
            }
        }

        public List<Personal> GetPersonalByTitle(string title)
        {
            using (var db = new PersonalDbContext())
            {
                var personals = db.Personals.Where(p => p.PersonalTitle == title).ToList();
                return personals;
            }
        }

        public Personal UpdatePersonal(Personal personal)
        {
            using (var db = new PersonalDbContext())
            {
                db.Personals.Update(personal);
                db.SaveChanges();
                return personal;
            }
        }
    }
}
