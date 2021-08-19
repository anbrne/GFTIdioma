using System;

namespace GFTIdiomas2
{
    public abstract class Idioma
    {
        public string nomeDoIdioma { get; set; }

        public abstract string saudacao();
    }
    class Portugues: Idioma
    {
        
        public Portugues()
        {
            this.nomeDoIdioma = "Português";
        }
        public override string saudacao()
        {
            return "Olá Mundo";
        }
    }
    class Ingles : Idioma
    {

        public Ingles()
        {
            this.nomeDoIdioma = "Inglês";
        }
        public override string saudacao()
        {
            return "Hello Word";
        }
    }
    class Hungaro : Idioma
    {

        public Hungaro()
        {
            this.nomeDoIdioma = "Húmgaro";
        }
        public override string saudacao()
        {
            return "Helló Villág";
        }
    }
    class Tcheco : Idioma
    {

        public Tcheco()
        {
            this.nomeDoIdioma = "Tcheco";
        }
        public override string saudacao()
        {
            return "Ahoj Svete";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var portugues = new Portugues();
            var ingles = new Ingles();
            var humgaro = new Hungaro();
            var tcheco = new Tcheco();

            Console.WriteLine($"{portugues.nomeDoIdioma} | {portugues.saudacao()}");
            Console.WriteLine($"{ingles.nomeDoIdioma} | {ingles.saudacao()}");
            Console.WriteLine($"{humgaro.nomeDoIdioma} | {humgaro.saudacao()}");
            Console.WriteLine($"{tcheco.nomeDoIdioma} | {tcheco.saudacao()}");
        }
    }
}
