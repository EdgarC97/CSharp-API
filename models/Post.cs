using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json_test.models
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string? title { get; set; }
        public string? body { get; set; }
    }
}