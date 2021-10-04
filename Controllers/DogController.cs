using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace web
{
  [ApiController]
  [Route("dogs")]
  public class DogController : ControllerBase
  {
    private Database _db;

    public DogController(Database db)
    {
      _db = db;
    }

    [HttpPost]
    public IActionResult CreateDog(Dog dog)
    {
      _db.Add(dog);
      _db.SaveChanges();
      return Ok(dog);
    }

    [HttpGet]
    public IActionResult GetAllDogs()
    {
      var dogs = _db.Dogs.ToList();
      return Ok(dogs);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteDogById(int id)
    {
      var dog = _db.Dogs.Where(d => d.Id == id).SingleOrDefault();
      if (dog is null) return NotFound();

      _db.Remove(dog);
      _db.SaveChanges();
      return Ok();
    }

    [HttpPatch("{id}/{age}")]
    public IActionResult UpdateDogAge(int id, int age)
    {
      var dog = _db.Dogs.Where(d => d.Id == id).SingleOrDefault();
      if (dog is null) return NotFound();

      dog.Age = age;
      _db.SaveChanges();
      return Ok(dog);
    }
  }
}
