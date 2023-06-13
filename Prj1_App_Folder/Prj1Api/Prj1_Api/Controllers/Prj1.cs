using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prj1_Business;
using Prj1_Models;

namespace Prj1Api.Controllers;

[ApiController]
[Route("[controller]")]
public class Prj1Controller : ControllerBase
{
    private readonly ILogger<Prj1Controller> _logger;

    public Prj1Controller(ILogger<Prj1Controller> logger)
    {
        _logger = logger;
    }

    // we will add another method
    // This method will take register information from the user and create a new user in the database.
    [HttpPost("Register")]// define what verb this action method requires
    public ActionResult<Person> GetMyInt([FromBody] RegisterDto x)// get a json string object from the body and match it to the defined class.
    {

        if (ModelState.IsValid)
        {
            BusinessLayerClassLibrary prj1 = new BusinessLayerClassLibrary();
            // i'll call a method on the business layer that will do the appropriate thing with the Customer object.
            // I will return the  unputted customer back to the user along with the URI to GET the person entity so it can be used, if the FE wants to use it.
            Person ret = prj1.Register(x);
            if (ret != null) return Created("http://localhost:5202", ret);

            // string ret = String.Concat(x.Fname, " ", x.Lname, "is", x.age, "years old. His email is ", x.Email, ".");
            // string ret1 = $"{x.Fname} {x.Lname} is {x.age} years old. His email is {x.Email}.";

            // // return the URI for this resource, and a copy of the resource.
            // return Created("http://www.mysite.com/path/to/this/resource/on/the/web", ret1);
        }
        // if something failed, return a message detailing the failure.
        return BadRequest(new { message = "There was a problem with the new registration" });
    }

    /// <summary>
    /// This method  gets Customer username and password
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    [HttpGet("login")]
    public ActionResult<Person> Login(string username, string password = "no password sent. :(")
    {
        //create an instance of the business layer
        BusinessLayerClassLibrary prj1 = new BusinessLayerClassLibrary();
        // send the loginDto to the business layer to do whatever it does.
        Person p = prj1.Login(username, password);
        if (p == null)
        {
            return BadRequest(new { message = "There is not yet a user with that login/password combo." });
        }
        else return Ok(p);
    }

    // This method will return a list of stores.
    [HttpGet("stores")]
    public ActionResult<List<Store>> Stores()
    {
        // create an instance of the business layer
        BusinessLayerClassLibrary prj1 = new BusinessLayerClassLibrary();
        // call the business layer method to get the stores.
        List<Store> stores = prj1.GetStores();
        // return the stores
        if (stores != null) return Ok(stores);
        else return StatusCode(422, new { message = "There was a problem getting the stores." });
    }

    //Show customer all store addresses
    [HttpGet("available store addresses")]
    public ActionResult<List<string>> StoreAddresses()
    {
        BusinessLayerClassLibrary prj1 = new BusinessLayerClassLibrary();
        List<string> locations = prj1.GetStoreAdress();

        if (locations != null && locations.Count > 0)
        {
            return Ok(locations);
        }
        else
        {
            return NotFound();
        }
    }

    // Registered user can select a store by its address
    [HttpGet("select store by address")]
    public ActionResult<Store> StoreByAddress(string address)
    {
        BusinessLayerClassLibrary prj1 = new BusinessLayerClassLibrary();
        Store store = prj1.GetStoreByAddress(address);

        if (store != null)
        {
            return Ok(store);
        }
        else
        {
            return NotFound();
        }
    }


}
