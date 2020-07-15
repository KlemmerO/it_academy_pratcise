using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    public class Neighbour
    {
        public string FullName;
        public int FlatNumber;
        public int PhoneNumber;
        public Neighbour (string Name, int Flat, int Number)
        {
            FullName = Name;
            FlatNumber = Flat;
            PhoneNumber = Number;
        }
    }
}
