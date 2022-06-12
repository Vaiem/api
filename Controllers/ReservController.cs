using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using ReservateAPI.Models;



namespace ReservateAPI.Controllers
{
    [Route("api/[controller]")]
    public class ReservController : Controller
    {
        IRepository repository;
        public ReservController(IRepository repos)
        {
            repository = repos;
        }

        [HttpGet]
        public IEnumerable<Resrvation> Get()
        {
            return repository.GetResrvations;
        }
        [HttpGet("{id}")]
        public Resrvation GetId(int id) => repository[id];
       
        [HttpPost]
        public Resrvation Post([FromBody] Resrvation resrvation)
        {
            return repository.AddReservation(resrvation);
        }

        [HttpPut]
        public Resrvation Put([FromBody]Resrvation resrvation)
        {
           return repository.UpdeteReservation(resrvation);
        }

        [HttpDelete("{id}")]
        public void Delet(int id) => repository.Delet(id);
       
    }
}