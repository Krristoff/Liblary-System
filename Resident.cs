using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Resident : User
    {
        public Resident(string name) : base(name)
        {
            BorrowLimit = 3;
            BorrowDuration = 7;
        }
        public override string ToString()
        {
            return $"resident: {base.ToString()}";
        }
    }
}
