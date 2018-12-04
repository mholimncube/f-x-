using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwayFromKeyboard.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Employee_ID { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        //foreign keys
        public int StatusId { get; set; }
        public int SessionId { get; set; }
        //navigation property
        public Session Session { get; set; }
        public Status Status { get; set; }
    }
}