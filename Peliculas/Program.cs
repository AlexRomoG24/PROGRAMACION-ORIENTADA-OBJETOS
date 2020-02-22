using System;

namespace Peliculas
{ 
    class Peliculas
{
    private string Titulo;
    private Int16 Año;
    private string Pais;
    private string Director;
    
    public Peliculas(string Titulo,Int16 Año)
    {
        this.Titulo=Titulo;
        this.Año=Año;
    }
    public void imprime()
    {
        Console.WriteLine(Titulo, Año);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas p1 = new Peliculas("Toy Story 4",2020);
            p1.imprime();
            Peliculas p2 = new Peliculas("Joker",2020);
            p2.imprime();
            
        }
    }
}
