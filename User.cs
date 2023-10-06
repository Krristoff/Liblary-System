using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class User
    {
        int id;
        String name;
        bool isblocked;
        int borrowedItems;
        int borrowLimit;
        int borrowDuration;
        static int currentId = 1; //statyczne pole takie samo dla każdej instancji

        public User() { }
        public User(string name)
        {
            Id = currentId;
            Name = name;
            Isblocked = false;
            BorrowedItems = 0;
            currentId++;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int BorrowedItems { get => borrowedItems; set => borrowedItems = value; }
        public bool Isblocked { get => isblocked; set => isblocked = value; }
        public int BorrowLimit { get => borrowLimit; set => borrowLimit = value; }
        public int BorrowDuration { get => borrowDuration; set => borrowDuration = value; }

        public void Block1()
        {
            if (BorrowedItems >= BorrowLimit)
            {
                Isblocked = true;
            }
            else
            {
                Isblocked = false;
            }
        }
        public void Block2(double time)
        {
            if (time >= BorrowDuration)
            {
                Isblocked = true;
            }
        }

        
        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}
