using AwayFromKeyboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AwayFromKeyboard.APIs
{
    public class StatusController : ApiController
    {

        public IEnumerable<Status> GetAllStatus(){

            return new List<Status>(){
               new Status(){Status_ID = 1},
               new Status(){Status_ID = 2},
               new Status(){Status_ID = 3},
               new Status(){Status_ID = 4},
               new Status(){Status_ID = 5}
            };
    }
        public Status GetStatus(int id)
        {
                if (id == 1)
                {
                    return new Status() { Status_ID = 1 };
                }
                 if (id == 2)
                {
                    return new Status() { Status_ID = 2 };

                }
                 if (id == 3)
                {
                    return new Status() { Status_ID = 3 };

                }
                 if (id == 4)
                {
                    return new Status() { Status_ID = 4, };

                }
                 if (id == 5)
                {
                    return new Status() { Status_ID = 5, };

                }
            return null;
        }
    }
}
