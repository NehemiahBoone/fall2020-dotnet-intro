using System;
using System.Collections.Generic;
using catlady.Models;
using catlady.Services;
using Microsoft.AspNetCore.Mvc;

namespace catlady.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DogsController : ControllerBase
  {
    //CONNECTING SERVICE
    private readonly DogsService _dogsService;
    public DogsController(DogsService dogsService)
    {
      _dogsService = dogsService;
    }

    //API REQUESTS
    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get()
    {
      try
      {
        return Ok(_dogsService.GetDogs());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Dog> GetById(string id)
    {
      try
      {
        return Ok(_dogsService.GetDogById(id));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}