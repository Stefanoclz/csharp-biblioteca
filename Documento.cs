﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        public string title = "";
        public int year;
        public string genre = "";
        public string author = "";
        public string position = "";
        public bool rent = false;

        public List<Libro> listaLibri = new List<Libro>();

        public List<Dvd> listaDvd = new List<Dvd>();

        public Documento(string title, int year, string genre, string author, string position, bool rent)
        {
            this.title = title;
            this.year = year;
            this.genre = genre;
            this.author = author;
            this.position = position;
            this.rent = rent;

            listaLibri.Add(new Libro("5241859632", 257, "Neuromante", 1984, "cyberpunk", "William Gibson", "k3", false));
            listaLibri.Add(new Libro("7741528963", 332, "La matrice spezzata", 1985, "fantascienza", "Bruce Sterling", "k1", false));
            listaLibri.Add(new Libro("0256584745", 452, "Il signore del anelli", 1954, "fantasy", "J R. R. Tolkien", "d6", false));
            listaLibri.Add(new Libro("9585623417", 311, "Ma gli androidi sognano pecore elettriche?", 1968, "fantascienza", "Philip K. Dick", "j8", false));


            listaDvd.Add(new Dvd(52412548, 2, "The mask", 1994, "commedia", "Chuck Russell", "c3", false));
            listaDvd.Add(new Dvd(00025142, 3, "Il signore degli anelli", 2001, "fantasy", "Peter Jackson", "f1", false));
            listaDvd.Add(new Dvd(85858965, 2, "Blade Runner 2049", 2017, "cyberpunk", "Ridley Scott", "h3", false));
            listaDvd.Add(new Dvd(74185254, 2, "The Matrix", 1999, "fantascienza", "Wachowsky", "b7", false));
        }
    }
}
