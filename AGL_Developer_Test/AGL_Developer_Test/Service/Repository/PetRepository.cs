using AGL_Developer_Test.Common;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AGL_Developer_Test.Models
{
    public class PetRepository : IPetRepository
    {
        #region Constructor
        public PetRepository()
        {
            
        }
        #endregion
        
        #region Public Methods
        public List<Pet> GetPets()
        {
            List<Pet> pets = new List<Pet>();
            using (WebClient wc = new WebClient())
            {
                //Read the JSON data from the service and deserialize it
                var json = wc.DownloadString("http://agl-developer-test.azurewebsites.net/people.json");
                dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(json);

                foreach (var person in jsonData)
                {
                    if(person.pets != null)
                    {
                        foreach (var pet in person.pets)
                        {
                            //Read only cats
                            if (pet.type == Constant.PET_TYPE_CAT)
                            {
                                var petDetails = new Pet() { Name = pet.name, Type = pet.type, OwnerGender = person.gender };
                                pets.Add(petDetails);
                            }
                        }
                    }
                    
                }
            }
            //Sort the result by ascending order
            pets = pets.OrderBy(o => o.Name).ToList();
            
            return pets;
        }
        #endregion
    }
}
