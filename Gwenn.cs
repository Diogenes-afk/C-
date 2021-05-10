using System;
using System.Collections.Generic;
using System.Text;

namespace LigaDasLendas
{
    public class Gwenn : Campeao
    {
        public override void Ultimate()
        {
            Console.WriteLine("PONTO-CRUZ - Gwen arremessa uma agulha que causa Dano Mágico e Lentidão, aplicando Mil Retalhos aos Campeões atingidos");
        }
        public void imprimir()
        {

            base.imprimir();
            Console.WriteLine("\n ");
            Console.WriteLine("\n Q - Gwen corta uma área em cone até seis vezes com a tesoura, causando Dano Mágico. ");
            Console.WriteLine("\n W - Gwen invoca uma Névoa que a protege dos inimigos que estiverem do lado de fora. ");
            Console.WriteLine("\n E - Gwen avança por uma curta distância e ganha Velocidade de Ataque, Alcance de Ataque e Dano Mágico ao contato por alguns segundos.");

        }
    }
}