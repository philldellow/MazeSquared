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
        // GET api/GetStart
        [Route("api/GetStart")]
        [AcceptVerbs("GET")]
        public int GetStart()
        {
            var startSquare = GameEngine.randomStart();
            return startSquare;
        }

        // GET api/<controller>
        [Route("api/GetActiveSquare")]
        [AcceptVerbs("GET")]
        public int GetActiveSquare()
        {
            var activatedSquare = GameEngine.activeSquare();
            return activatedSquare;
        }

        //GET api/<controller>
        [Route("api/WhereWeAtNow")]
        [AcceptVerbs("GET")]
        public int WhereWeIsUpTo()
        {
            var whereIsWeUpToNow = GameEngine.weIsUpToHere;
            return whereIsWeUpToNow;
        }

        // GET api/<controller>
        [Route("api/GetNextSquare")]
        [AcceptVerbs("GET")]
        public int GetNextSquare()
        {
            var getNextedSquare = GameEngine.nextSquare();
            return getNextedSquare;
        }


        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}