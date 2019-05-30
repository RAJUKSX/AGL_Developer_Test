using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGL_Developer_Test.Models
{
    public interface IPetRepository
    {
        List<Pet> GetPets();
    }
}
