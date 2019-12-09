using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApiMongo.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class UserMin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonElement("nick")]
        public string Nick { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
    }

    public class User : UserMin
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("createDate")]
        public DateTime CreateDate { get; set; }
    }
}
