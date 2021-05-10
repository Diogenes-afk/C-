using System;
using System.Collections.Generic;
using System.Text;

namespace LigaDasLendas
{
    public class LeBlanc : Campeao
    {
        public override void Ultimate()
        {
            Console.WriteLine("MÍMICA - Leblanc conjura uma versão copiada de uma de suas habilidades.");
        }
        public void imprimir()
        {

            base.imprimir();
            Console.WriteLine("\n");
            Console.WriteLine("\n Q - SIGILO DE MALÍCIA LeBlanc projeta um Sigilo, causando dano e marcando o alvo por 3, 5s.");
            Console.WriteLine("\n W - DISTORÇÃO LeBlanc avança até um local, causando dano aos inimigos próximos de seu destino");
            Console.WriteLine("\n E - CORRENTES ETÉREAS LeBlanc lança uma corrente que prende a primeira unidade atingida.Se o alvo permanecer preso por 1, 5s, ele é enraizado e sofre dano adicional.");
        }
    }
}
