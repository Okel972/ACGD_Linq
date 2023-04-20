using System;

namespace MyApp
{
    public class Fruit
    {
        public string Nom;
        public int Quantite { get; set; }

        public Fruit(string name, int qt)
        {
            this.Nom = name;
            this.Quantite = qt;
        }

        public void AfficherFruit()
        {
            Console.WriteLine($"Le fruit est {Nom}");
            Console.WriteLine($"Avec une quantité de {Quantite}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fruits = new()
            {
                new Fruit("Pomme", 5),
                new Fruit("Banane", 15),
                new Fruit("Cerise", 3),
                new Fruit("Ananas", 12),
                new Fruit("Orange", 8),
            };

            var test = from a in fruits
                       where a.Quantite > 10
                       select a;
            foreach(Fruit f in test)
            {
                f.AfficherFruit();
            }
            Console.WriteLine("");

            var test2 = from b in fruits
                        orderby b.Nom
                        select b;
            foreach(Fruit f in test2)
            {
                f.AfficherFruit();
            }
        }
    }
}