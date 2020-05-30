using System;
using Amazon.DynamoDBv2.DataModel;

namespace WebApi.Domain
{

    [DynamoDBTable("web_blogs")]
    public class Blog
    {
        [DynamoDBHashKey]
        public string Id { get; set; }

        public string Name { get; set; }
       
        public string Content { get; set; }
       
        public DateTime CreatedTimestamp { get; set; }
    }
}
