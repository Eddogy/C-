using System;

namespace Postas_Uzduotis.Models
{
    public class Reaction
    {
        public Reaction()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }
        public ReactionType ReactionType { get; set; }
    }
}