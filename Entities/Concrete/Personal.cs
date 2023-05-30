﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personal : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PersonalTitle { get; set; }
        public string Department { get; set; }
        public string PersonalComment { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int IsActive { get; set; }
    }
}
