using Business.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonalService : IPersonalService
    {
        private IPersonalDal _personalDal;
        public PersonalService() 
        {
            _personalDal = new PersonalDal();
        }
        public Personal CreatePersonal(Personal personal)
        {
            
           return _personalDal.CreatePersonal(personal);
        }

        public void DeletePersonal(int id)
        {
            _personalDal.DeletePersonal(id);
        }

        public List<Personal> GetAllPassivePersonals()
        {
            return _personalDal.GetAllPassivePersonals();
        }

        public List<Personal> GetAllPersonals()
        {
            return _personalDal.GetAllPersonals();
        }

        public Personal GetPersonalById(int id)
        {
            return _personalDal.GetPersonalById(id);
        }

        public List<Personal> GetPersonalByTitle(string title)
        {
            return _personalDal.GetPersonalByTitle(title);
        }

        public Personal UpdatePersonal(Personal personal)
        {
            return _personalDal.UpdatePersonal(personal);
        }
    }
}
