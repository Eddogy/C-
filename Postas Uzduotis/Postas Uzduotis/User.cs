using System;
using System.Collections.Generic;
using System.Text;

namespace Postas_Uzduotis
{
    public class User : IUser, IVipUser
    {
        public bool HasGoldCard { get; set; }
        public int PrivilegesCount { get; set; }

        public void DoesItHaveCards()
        {
            throw new NotImplementedException();
        }
    }
}
