using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class LibrarySystem
    {
        List<LibraryRecord> records;

        public LibrarySystem()
        {
            records = new List<LibraryRecord>(); //inicjalizacja
        }

        public void BorrowItem(Item item1, User user1)
        {
            if(item1.IsBorrowed == false && user1.Isblocked == false)
            {
                item1.IsBorrowed = true;
                user1.BorrowedItems++;
                user1.Block1();
                LibraryRecord record = new LibraryRecord(user1.Id, item1.Id, DateTime.Now);
                records.Add(record);
                
            }
            else if(item1.IsBorrowed == true)
            {
                Console.WriteLine($"{item1.Name} is borrowed");
            }
            else if(user1.Isblocked == true)
            {
                Console.WriteLine($"{user1.Name} is blocked");
            }
        }

        public void ReturnItem(Item item1, User user1, DateTime data)
        {
            TimeSpan borrowDuration = new TimeSpan(0); //inicjalizacja
            foreach (LibraryRecord r in records)
            {
                if(r.ItemId == item1.Id && r.UserId == user1.Id)
                {
                    r.ReturnDate = data;
                    borrowDuration = data - r.BorrowDate;
                    item1.IsBorrowed = false;
                    user1.BorrowedItems--;
                    user1.Block1();
                    user1.Block2(borrowDuration.TotalDays);
                }
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("wszystkie wypożyczenia");
            foreach(LibraryRecord r in records)
            {
                sb.AppendLine(r.ToString());
            }
            return sb.ToString();
        }
    }
}
