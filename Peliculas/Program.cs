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
            p1.Titulo="Spiderman-2";
            p1.Año=2004;
            p1.Director="alex";
            Console.WriteLine(p1.Titulo);
            Console.WriteLine(p1.Año);
            Console.WriteLine(p1.Director);
        }
    }
}
