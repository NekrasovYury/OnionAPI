using Domain.Interface;
using OnionAPI.Mapper;
using OnionAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnionAPI.Controllers
{
    
    public class DataController : ApiController
    {
        // GET: api/Data
        public readonly IDataInterface _dataInterface;
       // public DataController() { }
        public DataController(IDataInterface dataInterface)
        {
            _dataInterface = dataInterface;
        }
        [HttpGet]
        public List<CardModel> Get()
        {


            var card = _dataInterface.GetCard();

            return card.Select(_=>_.ToData()).ToList();
        }

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Data/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Data
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Data/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Data/5
        public void Delete(int id)
        {
        }
    }
}
