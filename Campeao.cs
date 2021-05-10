using System;
using System.Collections.Generic;
using System.Text;

namespace LigaDasLendas
{
    public abstract class  Campeao
    {
        public string nome { get; set; }
        public int vida { get; set; }
        public int danoAtaque { get; set; }
        public float velocidadeAtaque { get; set; }
        public float velocidadeMovimento { get; set; }
        public float regeneracaoVida { get; set; }
        public int armadura { get; set; }
        public int resistenciaMagica { get; set; }


        public virtual void imprimir()
        {
            Console.WriteLine("Seu campeao " + this.nome + " e possui " + this.vida);
            Console.WriteLine("De dano ele possui " + this.danoAtaque + " e velocidade de ataque " + this.velocidadeAtaque);
            Console.WriteLine("Falando de movimento de movimento " + this.velocidadeMovimento + " e renera " + this.regeneracaoVida + " de vida");
            Console.WriteLine("Sua resistencia em questão de armadura é de " + this.armadura + " e de dano magico ele aguenta " +this.resistenciaMagica);
        }

        public abstract void Ultimate();

    }
}
