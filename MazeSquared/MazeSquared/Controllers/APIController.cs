using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MazeSquared.Models;

namespace MazeSquared.Controllers
{
    public class APIController : ApiController
    {
        // GET api/<controller>
        public int GetStart()
        {
            var startSquare = GameEngine.randomStart();
            return startSquare;
        }

        // GET api/<controller>
        public int GetActiveSquare()
        {
            var activatedSquare = GameEngine.activeSquare();
            return activatedSquare;
        }

        // GET api/<controller>
        public int GetNextSquare()
        {
            var getNextedSquare = GameEngine.nextSquare();
            return getNextedSquare;
        }


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}