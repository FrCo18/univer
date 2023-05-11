using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    struct Student : ICloneable
    {
        public string fio;
        public string group;
        public double avgMark;
        public double schoolarship;

        public object Clone() => MemberwiseClone();
    }
}
