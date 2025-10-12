﻿using Catalog.Application.Responses;
using Catalog.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Queries
{
    public class GetProductByIdQuery : IRequest<ProductResponseDto>
    {
        public string Id { get; set; }
        public GetProductByIdQuery( string id)
        {
            Id = id;
        }
    }
}
