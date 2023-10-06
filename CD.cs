using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class CD : Item
    {
        int numTrucks;

        public CD(string name, int numTrucks) : base(name)
        {
            NumTrucks = numTrucks;
        }

        public int NumTrucks {get => numTrucks; set => numTrucks = value;}

        public override string ToString()
        {
            return $"{base.ToString()}, ilość utworów: {NumTrucks}";
        }
    }
}
