using System;
using System.Collections.Generic;
using catlady.db;
using catlady.Models;

namespace catlady.Services
{
  public class DogsService
  {
    public IEnumerable<Dog> GetDogs()
    {
      return FAKEDB.Dogs;
    }

    public Dog GetDogById(string id)
    {
      Dog foundDog = FAKEDB.Dogs.Find(d => d.Id == id);
      if (foundDog != null)
      {
        return foundDog;
      }
      throw new Exception("No dogs like that here homie");
    }
  }

}