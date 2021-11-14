using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S.Domain.Logic
{
    public static class Info
    {

        public static string GetHardwareID()
        {
            return IntelliLock.Licensing.HardwareID.GetHardwareID(true, true, true, true, true, true);
        }
    }
}
