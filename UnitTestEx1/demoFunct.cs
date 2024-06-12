using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestEx1
{
    public class demoFunct
    {
        public string ReturnsPIKifzero(int num)
        {
            if (num == 0)
            {
                return "PIK";
            }
            else
            {
                return "POK";
            }
        }
    }
}
