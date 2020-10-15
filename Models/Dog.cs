using System;
using System.ComponentModel.DataAnnotations;

namespace catlady.Models
{
  public class Dog
  {
    public Dog(string name, string description)
    {
      Name = name;
      Description = description;
    }
    public Dog()
    {

    }

    [Required]
    [MinLength(5)]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();
  }
}