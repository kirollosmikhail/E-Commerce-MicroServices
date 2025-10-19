﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Responses
{
    public class TypeResponseDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
