﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGL_Developer_Test.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public List<Pet> Pets { get; set; }
    }
}
