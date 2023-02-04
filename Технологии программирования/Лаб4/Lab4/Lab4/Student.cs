using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    struct Student : ICloneable
    {
        public DateTime dateOfBithday;
        public string fio;
        public string address;
        public string phone;

        public object Clone() => MemberwiseClone();
    }
}
