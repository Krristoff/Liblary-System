using System;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Book ksiazka1 = new Book("Pan Tadeusz", 500, TypKsiazkiEnum.novel);
            Book ksiazka2 = new Book("Dziady", 600, TypKsiazkiEnum.novel);
            Book ksiazka3 = new Book("Lalka", 700, TypKsiazkiEnum.encyclopedia);

            CD cd1 = new CD("soma", 10);
            CD cd2 = new CD("szprycer", 11);
            CD cd3 = new CD("wosk", 9);

            Student student1 = new Student("Natalia");
            Student student2 = new Student("Mikołaj");
            Student student3 = new Student("Adam");
            Resident resident1 = new Resident("Krzysiek");
            Resident resident2 = new Resident("Maria");
            Resident resident3 = new Resident("Paweł");

            LibrarySystem ls = new LibrarySystem();

            ls.BorrowItem(cd1, resident1);
            ls.BorrowItem(cd2, resident1);
            ls.BorrowItem(cd3, resident1);
            ls.BorrowItem(ksiazka1, resident2);
            ls.BorrowItem(ksiazka2, resident2);

            Console.WriteLine(ls);

            LibraryRecord r = new LibraryRecord(student1, ksiazka3, new DateTime(2023, 12, 23));
            LibraryRecord r1 = new LibraryRecord(student1.Id, ksiazka3.Id, new DateTime(2023, 12, 23));

        }
    }
}
