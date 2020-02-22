using System;

namespace Peliculas
{ 
    class Peliculas
{
    public string Titulo;

    public Int16 Año;

    public string Pais;

    public string Director;
}
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas p1=new Peliculas();
            p1.Titulo="Toy Story 4";
            p1.Año=2020;
            p1.Director="Josh Cooley";
            p1.Pais="EE.UU";
            Console.WriteLine(p1.Titulo);
            Console.WriteLine(p1.Año);

            Peliculas p2=new Peliculas();
            p2.Titulo="Joker";
            p2.Año=2020;
            p2.Director="Todd Phillips";
            p2.Pais="EE.UU";
            Console.WriteLine(p2.Titulo);
            Console.WriteLine(p2.Año);
        }
    }
}
