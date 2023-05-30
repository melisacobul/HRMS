﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonalService
    {
        List<Personal> GetAllPersonals();
        List<Personal> GetAllPassivePersonals();
        List<Personal> GetPersonalByTitle(string title);
        Personal GetPersonalById(int id);
        Personal CreatePersonal(Personal personal);
        Personal UpdatePersonal(Personal personal);
        void DeletePersonal(int id);
    }
}
