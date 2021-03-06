﻿using MongoDB.Bson.Serialization.Attributes;
using SevenTiny.Bantina.AutoMapper;
using SevenTiny.Bantina.Bankinate;
using SevenTiny.Bantina.Bankinate.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Model
{
    [Table("test")]
    public class Grade
    {
        public object _id { get; set; }
        public int GradeId { get; set; }
        [Mapper("GradeName")]
        public string Name { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
