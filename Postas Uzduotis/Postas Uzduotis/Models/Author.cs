using System;
using System.Collections.Generic;

namespace Postas_Uzduotis.Models
{
    public class Author
    {
        public Author()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public List <Post> Posts{ get; set; }
    }
}