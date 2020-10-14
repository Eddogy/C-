using System;
using System.Collections.Generic;
using System.Text;

namespace Postas_Uzduotis
{
    public interface IVipUser
    {
         bool HasGoldCard { get; set; }
         int PrivilegesCount { get; set; }

        public void DoesItHaveCards();
    }
}
