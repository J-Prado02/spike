using System;
using System.Diagnostics.CodeAnalysis;

class Lutador
{
    private string nome;
    private string nacionalidade;
    private int idade;
    private double altura;
    private double peso;
    private string categoria;
    private int vitorias, derrotas, empates;

    //Métodos Publicos

   public void Apresentar()
   {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("==============================================");
        Console.WriteLine("            CHEGOU A HORA!");
        Console.WriteLine("==============================================");

        Console.ResetColor();

        Console.WriteLine($"Lutador: {getNome()}");
        Console.WriteLine($"Nacionalidade: {getNacionalidade()}");
        Console.WriteLine($"Idade: {getIdade()} anos");
        Console.WriteLine($"Altura: {getAltura()} m");
        Console.WriteLine($"Peso: {getPeso()} kg");

        Console.WriteLine("----------------------------------------------");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Vitórias : {getVitorias()}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Derrotas : {getDerrotas()}");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Empates  : {getEmpates()}");

        Console.ResetColor();

        Console.WriteLine("==============================================");
    }

    public void Status()
    {
        Console.WriteLine();
        Console.WriteLine("=========== STATUS DO LUTADOR ===========");

        Console.WriteLine($"Nome      : {getNome()}");
        Console.WriteLine($"Categoria : {getCategoria()}");

        Console.WriteLine("-----------------------------------------");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Vitórias  : {getVitorias()}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Derrotas  : {getDerrotas()}");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Empates   : {getEmpates()}");

        Console.ResetColor();

        Console.WriteLine("=========================================");
    }

    public void ganharLuta()
    {
        this.setVitorias(getVitorias() + 1);

    }

    public void perderLuta()
    {
        this.setDerrotas(getDerrotas() + 1);
    }

    public void empatarLuta()
    {
        this.setEmpates(getEmpates() + 1);
    }

    //Métodos Especiais

    public Lutador(string nome, string nacionalidade, int idade, double altura, double peso, int vitorias, int derrotas, int empates)
    {
        this.nome = nome;
        this.nacionalidade = nacionalidade;
        this.idade = idade;
        this.altura = altura;
        this.setPeso(peso);
        this.vitorias = vitorias;
        this.derrotas = derrotas;
        this.empates = empates;
    }

    public string getNome()
    {
        return this.nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNacionalidade()
    {
        return this.nacionalidade;
    }

    public void setNacionalidade(string nacionalidade)
    {
        this.nacionalidade = nacionalidade;
    }

    public int getIdade()
    {
        return this.idade;
    }

    public void setIdade(int idade)
    {
        this.idade = idade;
    }

    public double getAltura()
    {
        return this.altura;
    }

    public void setAltura(double altura)
    {
        this.altura = altura;
    }

    public double getPeso()
    {
        return this.peso;
    }

    public void setPeso(double peso)
    {
        this.peso = peso;
        this.setCategoria();
    }

    public string getCategoria()
    {
        return this.categoria;
    }

    private void setCategoria()
    {
        if(this.peso < 52.2)
        {
            this.categoria = "Inválido";
        }
        else if(this.peso <= 70.3)
        {
            this.categoria = "Leve";
        }
        else if(this.peso <= 83.9)
        {
            this.categoria = "Médio";
        }
        else if(this.peso <= 120.2)
        {
            this.categoria = "Pesado";
        }
        else
        {
            this.categoria = "Inválido";
        }
        
    }

    public int getVitorias()
    {
        return this.vitorias;
    }

    public void setVitorias(int vitorias)
    {
        this.vitorias = vitorias;
    }

    public int getDerrotas()
    {
        return this.derrotas;
    }

    public void setDerrotas(int derrotas)
    {
        this.derrotas = derrotas;
    }

    public int getEmpates()
    {
        return this.empates;
    }

    public void setEmpates(int empates)
    {
        this.empates = empates;
    }

}