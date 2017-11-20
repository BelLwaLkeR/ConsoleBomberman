using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBomberMan.Extends
{
    public static class ExtendMath
    {
        public static int Round(this float value) {
            return (value-(int)value >=0.5)?(int)value+1:(int)value;
        }
    }
}
