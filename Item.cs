using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Item
    {
        //pola
        String name;
        static int currentId = 1;
        bool isBorrowed; // to będzie przechowywać informacje o tym czy książka jest obecnie wypożyczona - wartości t/f
        int id;

        //konstruktor
        public Item(string name)
        {
            Name = name;
            Id = currentId;
            currentId++;
        }

        //właściwości / properties / getery, setery
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public bool IsBorrowed { get => isBorrowed; set => isBorrowed = value; }

        //to string
        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}
