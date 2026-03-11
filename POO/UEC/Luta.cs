using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

class Luta
{
    private Lutador desafiado;
    private Lutador desafiante;
    private int rounds;
    private bool aprovada;

    //Métodos da Classe

    public void marcarLuta(Lutador lutador1, Lutador lutador2)
    {
        if(lutador1.getCategoria().Equals(lutador2.getCategoria()) && lutador1 != lutador2)
        {
            this.aprovada = true;
            this.desafiado = lutador1;
            this.desafiante = lutador2;
        }
        else
        {
            this.aprovada = false;
            this.desafiado = null;
            this.desafiante = null;
        }
    }

    public void lutar()
    {
        if (this.aprovada)
        {
            Console.Write("###DESAFIADO###");
            this.desafiado.Apresentar();
            Console.Write("###DESAFIANTE###");
            this.desafiante.Apresentar();

            Random aleatorio = new Random();
            int vencedor = aleatorio.Next(3);

            switch (vencedor)
            {
                case 0: //Empate
                    Console.Write("\nEmpatou\n");
                    this.desafiado.empatarLuta();
                    this.desafiante.empatarLuta();
                break;

                case 1: //Desafiado Vence
                    Console.Write($"\nVitória de {desafiado.getNome()}\n");
                    this.desafiado.ganharLuta();
                    this.desafiante.perderLuta();
                break;
                
                case 2: //Desafiante Vence
                    Console.Write($"\nVitória de {desafiante.getNome}\n");
                    this.desafiante.ganharLuta();
                    this.desafiado.perderLuta();
                break;
            }
        }
        else
        {
            Console.WriteLine("A Luta não pode acontecer !");
        }
    }

    //Métodos Especiais

    public Lutador getDesafiado()
    {
        return this.desafiado;
    }

    public void setDesafiado(Lutador desafiado)
    {
        this.desafiado = desafiado;
    }

    public Lutador getDesafiante()
    {
        return this.desafiante;
    }

    public void setDesafiante(Lutador desafiante)
    {
        this.desafiante = desafiante;
    }
}