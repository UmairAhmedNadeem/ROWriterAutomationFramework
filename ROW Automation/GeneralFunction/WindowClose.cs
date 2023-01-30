using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROWriter.GeneralFunction
{
    class WindowClose : Core
    {
        public void Close()
        {
           driver.Close();
        }
    }
}
