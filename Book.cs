using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public enum TypKsiazkiEnum { novel, textbook, encyclopedia }
    class Book : Item
    {
        int numPage;
        TypKsiazkiEnum typKsiazki;

        public Book(string name, int numPage, TypKsiazkiEnum typKsiazki) : base(name)
        {
            this.NumPage = numPage;
            this.TypKsiazki = typKsiazki;
        }

        public int NumPage { get => numPage; set => numPage = value; }
        public TypKsiazkiEnum TypKsiazki { get => typKsiazki; set => typKsiazki = value; }

        public override string ToString()
        {
            return $"{base.ToString()}, typ: {TypKsiazki}, ilość stron: {NumPage}";
        }
    }
}
