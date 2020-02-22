using System;

namespace Peliculas
{ 
    class Peliculas
{
    private string Titulo;
    private Int16 Año;
    private string Pais;
    private string Director;

    public string getTitulo()
    {
        return Titulo;
    }
    public void setTitulo(string T)
    {
        Titulo=T;
    }
    public Int16 getAño()
    {
        return Año;
    }
    public void setAño(Int16 T)
    {
        Año=T;
    }
    public string getPais()
    {
        return Pais;
    }
    public void setPais(string T)
    {
        Pais=T;
    }
    public string getDirector()
    {
        return Director;
    }
    public void setDirector(string T)
    {
        Director=T;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
         Peliculas p1 = new Peliculas();
         p1.setTitulo("Toy Story 4");
         p1.setAño(2020); 
         Console.WriteLine("{0} ({1})", p1.getTitulo(), p1.getAño());

         Peliculas p2 = new Peliculas();
         p2.setTitulo("Joker");
         p2.setAño(2020); 
         Console.WriteLine("{0} ({1})", p2.getTitulo(), p2.getAño());
        }
    }
}
