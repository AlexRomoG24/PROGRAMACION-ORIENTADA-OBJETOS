using System;
using System.Collections.Generic;
namespace Lista_de_Peliculas
{
     class ListPeliculas
    {
        private string Nom;
        private short Año;
        public ListPeliculas(string Nom, short Año)
        { 
            this.Nom = Nom;
            this.Año = Año;
        }
    
    public void Imprimir() => Console.WriteLine(Nom + ", " + Año);
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ListPeliculas> Peliculas = new List<ListPeliculas>();
            Peliculas.Add(new ListPeliculas("Naruto Shippuden the Movie: Blood Prison", 2011));
            Peliculas.Add(new ListPeliculas("Naruto Shippūden 2: Kizuna(Lazos)", 2008));
            Peliculas.Add(new ListPeliculas("The Last: Naruto the Movie", 2014));
            Peliculas.Add(new ListPeliculas("Boruto: Naruto the Movie", 2015));
            foreach (ListPeliculas a in Peliculas)
            {
                a.Imprimir();
            }
        }
    }
}
