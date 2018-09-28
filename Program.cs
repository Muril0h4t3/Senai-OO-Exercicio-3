using System;
using senai.OO.exercicio3.Classes;

namespace senai.OO.exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            Produto produto1 = new Produto();

            Console.WriteLine("Insira o nome do produto1");
            produto1.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço de {produto1.Nome}.");
            produto1.preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de {produto1.Nome}.");
            produto1.quantidade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine($"O preço total de {produto1.Nome} é R${produto1.total =  produto1.preco * produto1.quantidade}");
             #endregion

             #region 
            Produto produto2 = new Produto();

            Console.WriteLine("Insira o nome do produto 2");
            produto2.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço de {produto2.Nome}.");
            produto2.preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de {produto2.Nome}.");
            produto2.quantidade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine($"O preço total de {produto2.Nome} é R${produto2.total =  produto2.preco * produto2.quantidade}");
             #endregion

             #region 
            Produto produto3 = new Produto();

            Console.WriteLine("Insira o nome do produto 3");
            produto3.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço de {produto3.Nome}.");
            produto3.preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de {produto3.Nome}.");
            produto3.quantidade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine($"O preço total de {produto3.Nome} é R${produto3.total =  produto3.preco * produto3.quantidade}");
             #endregion

             #region 
            Produto produto4 = new Produto();

            Console.WriteLine("Insira o nome do produto 4");
            produto4.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço de {produto4.Nome}.");
            produto4.preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de {produto4.Nome}.");
            produto4.quantidade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine($"O preço total de {produto4.Nome} é R${produto4.total =  produto4.preco * produto4.quantidade}");
             #endregion

             #region 
            Produto produto5 = new Produto();

            Console.WriteLine("Insira o nome do produto 5");
            produto5.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço de {produto5.Nome}.");
            produto5.preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de {produto5.Nome}.");
            produto5.quantidade = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine($"O preço total de {produto5.Nome} é R${produto5.total = produto5.preco * produto5.quantidade}");
             #endregion

             Console.WriteLine($"O total de produtos é {produto1.quantidade + produto2.quantidade + produto3.quantidade + produto4.quantidade + produto5.quantidade}");
             Console.WriteLine($"O preço total da compra é R${produto1.total + produto2.total + produto3.total + produto4.total + produto5.total}");
        }
    }
}
