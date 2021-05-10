using System;
using System.Collections.Generic;
using System.Text;

namespace LigaDasLendas
{
    public class Fizz : Campeao
    {
        public override void Ultimate()
        {
            Console.WriteLine("LANÇAR ISCA  -Fizz arremessa um peixe em determinada direção, que se prende a qualquer Campeão que tocar, reduzindo a velocidade do alvo.");
        }
        public void imprimir()
        {

            base.imprimir();
            Console.WriteLine("\n");
            Console.WriteLine("\n Q - Fizz avança em direção ao alvo, causando Dano Mágico e aplicando efeitos de contato.");
            Console.WriteLine("\n W - Os ataques de Fizz fazem seus inimigos sangrarem, causando Dano Mágico por vários segundos.");
            Console.WriteLine("\n E - Fizz faz acrobacias no ar, aterrissando graciosamente sobre seu tridente e ficando inalvejável.");

        }
    }
}