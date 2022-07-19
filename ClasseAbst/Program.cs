using ClasseAbst.Animais;
using System;

namespace ClasseAbst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Cachorro = new Animal("Cachorro", 4, Categoria.MAMIFERO, 4);
            Animal Gato = new Animal("Gato", 4, Categoria.MAMIFERO, 3);
            Animal Papagaio = new Animal("Papagaio", 2, Categoria.AVE, 2);
            Animal Cobra = new Animal("Cobra", 0, Categoria.REPTIL, 0);

            Console.WriteLine(Cachorro.ToString());
            Console.WriteLine(Gato.ToString());
            Console.WriteLine(Papagaio.ToString());
            Console.WriteLine(Cobra.ToString());


        }
    }
}
