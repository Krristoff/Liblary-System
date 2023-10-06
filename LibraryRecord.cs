using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class LibraryRecord // jeden wiersz w bazie danych - sztuczna klasy
    {
        //pola z malej
        int userId;
        int itemId;
        DateTime borrowDate;
        DateTime returnDate;

        //z duzej
        public LibraryRecord(int userId, int itemId, DateTime borrowDate)
        {
            UserId = userId;
            ItemId = itemId;
            BorrowDate = borrowDate;
        }

        public LibraryRecord(User user1, Item item1, DateTime borrowDate)
        {
            UserId = user1.Id;
            ItemId = item1.Id;
            BorrowDate = borrowDate;
        }

        //wlasciwosci z duzej
        public int UserId { get => userId; set => userId = value; }
        public int ItemId { get => itemId; set => itemId = value; }
        public DateTime BorrowDate { get => borrowDate; set => borrowDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }

        //z duzej
        public override string ToString()
        {
            string doWypisania;
            if (ReturnDate == default(DateTime))
            {
                doWypisania = "Nie zwrócono";
            }
            else
            {
                doWypisania = ReturnDate.ToShortDateString();
            }

            return $"{UserId}, {ItemId}, {BorrowDate.ToShortDateString()}, {doWypisania}";
        }
    }
}
