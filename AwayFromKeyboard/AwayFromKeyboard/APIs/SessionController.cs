using AwayFromKeyboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AwayFromKeyboard.APIs
{
    public class SessionController : ApiController
    {
        //Get api/values/ list of all Sessions
        public IEnumerable<Session> Get()
        {
            return new List<Session>()
            {
                new Session() {Session_Id = 1},
                new Session() {Session_Id = 2},
                new Session() {Session_Id = 3},
                new Session() {Session_Id = 4},
                new Session() {Session_Id = 5},
            };
        }

        //get api/values/ get selected session
        public Session Get(int id)
        {

                if (id == 1)
                {
                    return new Session() { Session_Id = 1 };
                }
                if (id == 2)
                {
                    return new Session() { Session_Id = 2 };

                }
                if (id == 3)
                {
                    return new Session() { Session_Id = 3 };

                }
                if (id == 4)
                {
                    return new Session() { Session_Id = 4, };

                }
               if (id == 5)
                {
                    return new Session() { Session_Id = 5, };

                }
            return null;
        }
    }
}
