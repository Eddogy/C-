using System;

namespace Postas_Uzduotis.Models
{
    public class Share
    {
        public Share()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
    }
}