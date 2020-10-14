using System;
using System.Collections.Generic;
using System.Text;

namespace Postas_Uzduotis.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comment>();
            Reactions = new List<Reaction>();
            Shares = new List<Share>();      
            ID = Guid.NewGuid();
            
    }

        public Guid ID { get; set; }
        public Author Author{ get; set; }
        public List <Comment> Comments { get; set; }
        public DateTime PostDate { get; set; }
        public List <Reaction> Reactions { get; set; }
        public PostStatus PostStatus { get; set; }
        public PostVisibility PostVisibility { get; set; }
        public int ViewCount { get; set; }
        public bool IsReported { get; set; }                    
        public List<Share> Shares{ get; set; }

        public void AddReaction(Reaction react)
        {
            this.Reactions.Add(react);
        }
    }
}
