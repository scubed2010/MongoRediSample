﻿using MongoRedi.Attributes;
using MongoRedi.Models;

namespace Core.Models
{
    [CollectionName("students")]
    [Cache]
    public class Student : BaseCollection
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
