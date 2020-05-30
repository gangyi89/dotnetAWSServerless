using System;
using System.Collections.Generic;
using System.Text.Json;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IDynamoDBContext _dbContext;
        public BlogController(IDynamoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET api/values
       [HttpGet("{id}")]
        public Blog Get(string id)
        {
            var blog = _dbContext.LoadAsync<Blog>(id).Result;

            return blog;
        }
    }
}
