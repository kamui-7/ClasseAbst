using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbst.Animais
{
    public class Animal
    {
        string Nome { get; set; }

        int Patas { get; set; }

        Categoria Tipo { get; set; }

        int Quantidade { get; set; }

        public Animal(string nome, int patas, Categoria tipo, int quantidade)
        {
            Nome = nome;
            Patas = patas;
            Tipo = tipo;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return
                $"\n Nome do animal: {Nome}" +
                $"\n Quantas patas esse animal tem: {Patas}" +
                $"\n Qual é a classificação desse animal: {Tipo}" +
                $"\n Quantos animais deste temos em casa: {Quantidade}";
        }
    }
    public enum Categoria
    {
        MAMIFERO,
        REPTIL,
        ANFIBIO,
        AVE,

    }
        

}
