using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    [Serializable]
    public class cell
    {
        public bool left = false;
        public bool right = false;
        public bool top = false;
        public bool bottom = false;
        public int value;
    }

}
