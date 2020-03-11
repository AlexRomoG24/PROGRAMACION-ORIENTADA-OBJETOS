using System;
using System.Collections.Generic;
namespace Lista_De_Actores
{
    public class Peliculas 
{
    private string Titulo;

    private string Director;

    private string Pais;

    private short Año;

    public Peliculas(string Titulo, short Año, string Director, string Pais)
    {
        this.Titulo = Titulo;
        this.Año = Año;
        this.Director = Director;
        this.Pais = Pais;
    }

    public void Imprimir()
    {
        Console.WriteLine("Titulo de la pelicula: {0} Año de estreno: {1} Director: {2} Pais de estreno: {3}", this.Titulo, this.Año, this.Director, this.Pais);
        Console.WriteLine("Los participantes de la pelicula son:");
    }
}
    public class Actores
    {
        private string NomAct;
        private short Nacimiento;

        public Actores(string NomAct, short Nacimiento)
        {
            this.NomAct = NomAct;
            this.Nacimiento = Nacimiento;
        }
    public void ImprimirAct() => Console.WriteLine(NomAct + ", " + Nacimiento);
    }
    class Program
    {
        static void Main(string[] args)
        {
        Peliculas P1 = new Peliculas("Naruto la película: ¡Batalla ninja en la tierra de la nieve!", 2009, "Arturo Macías", "MEXICO");
        P1.Imprimir();
        List<Actores> Actors = new List<Actores>();
        Actors.Add(new Actores("María Isabel Martiñón Fernández", 1961));
        Actors.Add(new Actores("Víctor Ugarte Fonseca", 1976));
        Actors.Add(new Actores("Christine Edith Byrd Prado", 1982));
        Actors.Add(new Actores("Alfonso Obregón Inclán", 1960));
        foreach (Actores a in Actors)
        {
        a.ImprimirAct();
        }
        }
    }
}
