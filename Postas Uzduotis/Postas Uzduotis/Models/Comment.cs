using System;
using System.Collections.Generic;

namespace Postas_Uzduotis.Models
{
    public class Comment
    {
        public Comment()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }
        public string CommentText { get; set; }
        public List <Reaction> Reactions { get; set; }
        public DateTime CommentDate { get; set; }
    }
}