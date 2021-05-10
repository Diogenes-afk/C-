using System;

namespace LigaDasLendas
{
    class Program
    {
        static void Main(string[] args)
        {
            LeBlanc lb = new LeBlanc();
            Console.WriteLine("\n************************************************");
            Console.WriteLine("\n*********************LeBlanc************************");
            lb.nome = "LeBlanc";
                lb.vida = 1500;
                lb.danoAtaque = 60;
                lb.velocidadeAtaque = 1.7f;
                lb.velocidadeMovimento = 335;
                lb.regeneracaoVida = 6.5f;
                lb.armadura = 12;
                lb.resistenciaMagica = 30;
                lb.imprimir();
            Console.WriteLine("\n****************Ultimate************************");
                lb.Ultimate();


            
            Fizz fz = new Fizz();
            Console.WriteLine("\n*********************Fizz************************");
            fz.nome = "Fizz";
            fz.vida = 1000;
            fz.danoAtaque = 70;
            fz.velocidadeAtaque = 1.7f;
            fz.velocidadeMovimento = 320;
            fz.regeneracaoVida = 3.5f;
            fz.armadura = 15;
            fz.resistenciaMagica = 35;
            Console.WriteLine("\n*********************************************");
            fz.imprimir();
            Console.WriteLine("\n****************Ultimate*********************");
            fz.Ultimate();

            Gwenn gw = new Gwenn();
            Console.WriteLine("****************************************************");
            Console.WriteLine("\n*********************Gwenn************************");
            gw.nome = "Gwenn";
            gw.vida = 1000;
            gw.danoAtaque = 70;
            gw.velocidadeAtaque = 1.7f;
            gw.velocidadeMovimento = 320;
            gw.regeneracaoVida = 3.5f;
            gw.armadura = 15;
            gw.resistenciaMagica = 35;
           
            gw.imprimir();
            Console.WriteLine("****************Ultimate*********************");
            gw.Ultimate();
        }
    }
}
