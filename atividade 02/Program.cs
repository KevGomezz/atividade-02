//Questão 01
/**
using System;
class Circulo
{
    private double raio;

    
    public Circulo(double raio)
    {
        this.raio = raio;
    }

    
    public double CalcularArea()
    {
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }

    
    public double CalcularPerimetro()
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}

class Program
{
    static void Main()
    {
        
        double raioCirculo = 5.0;
        Circulo meuCirculo = new Circulo(raioCirculo);

        double areaCirculo = meuCirculo.CalcularArea();
        double perimetroCirculo = meuCirculo.CalcularPerimetro();

        Console.WriteLine($"Raio do círculo: {raioCirculo}");
        Console.WriteLine($"Área do círculo: {areaCirculo:F2}");
        Console.WriteLine($"Perímetro do círculo: {perimetroCirculo:F2}");
    }
}

//Questão 02

using System;

class Retangulo
{
    private double largura;

    public Retangulo(double largura)
    {
        this.largura = largura;
    }

    public double CalcularArea()
    {
        double area = Math.PI * Math.Pow(largura, 2);
        return area;
    }

    public double CalcularPerimetro()
    {
        double perimetro = 2 * Math.PI * largura;
        return perimetro;
    }
}

class Program
{
    static void Main()
    {
        double larguraRetangulo = 5.0;
        Retangulo meuRetangulo = new Retangulo(larguraRetangulo);

        double areaRetangulo = meuRetangulo.CalcularArea();
        double perimetroRetangulo = meuRetangulo.CalcularPerimetro();

        Console.WriteLine($"Largura do Retângulo: {larguraRetangulo}");
        Console.WriteLine($"Área do Retângulo: {areaRetangulo:F2}");
        Console.WriteLine($"Perímetro do Retângulo: {perimetroRetangulo:F2}");

        
        Console.ReadLine();
    }
}

//Questão 03
class Aluno
{
    private string nome;
    private string matricula;
    private double[] notas;

    public Aluno(string nome, string matricula, double[] notas)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.notas = notas;
    }

 
    public double CalcularMedia()
    {
        if (notas.Length == 0)
        {
            return 0; 
        }

        double somaNotas = 0;
        foreach (double nota in notas)
        {
            somaNotas += nota;
        }

        return somaNotas / notas.Length;
    }

    
    public string VerificarSituacao()
    {
        double media = CalcularMedia();

        if (media >= 6.0)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprovado";
        }
    }
}
class Program
{
    static void Main()
    {
        // Exemplo de uso da classe Aluno
        string nomeAluno = "Kevin";
        string matriculaAluno = "123456";
        double[] notasAluno = { 7.5, 8.0, 6.5 };

        Aluno meuAluno = new Aluno(nomeAluno, matriculaAluno, notasAluno);

        double mediaAluno = meuAluno.CalcularMedia();
        string situacaoAluno = meuAluno.VerificarSituacao();

        Console.WriteLine($"Nome do Aluno: {nomeAluno}");
        Console.WriteLine($"Matrícula do Aluno: {matriculaAluno}");
        Console.WriteLine($"Média do Aluno: {mediaAluno:F2}");
        Console.WriteLine($"Situação do Aluno: {situacaoAluno}");

        Console.ReadLine();
    }
}


//Questão 04

using System;

class CalculadoraFatorial
{
    // Atributo para armazenar o número
    private int numero;

    // Propriedade para acessar e definir o valor do número
    public int Numero
    {
        get { return numero; }
        set
        {
            if (value >= 0)
            {
                numero = value;
            }
            else
            {
                Console.WriteLine("O número não pode ser negativo. Definindo o número como zero.");
                numero = 0;
            }
        }
    }

    // Método para calcular o fatorial do número
    public long CalcularFatorial()
    {
        if (numero == 0 || numero == 1)
        {
            return 1; // O fatorial de 0 e 1 é 1
        }

        long resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}

class Program
{
    static void Main()
    {
        // Criando uma instância da classe CalculadoraFatorial
        CalculadoraFatorial calculadora = new CalculadoraFatorial();

        // Definindo o número para calcular o fatorial
        Console.Write("Digite um número para calcular o fatorial: ");
        string inputNumero = Console.ReadLine();

        // Convertendo a entrada para um número e definindo o número
        if (int.TryParse(inputNumero, out int numero))
        {
            calculadora.Numero = numero;

            // Calculando e exibindo o fatorial
            Console.WriteLine($"O fatorial de {numero} é: {calculadora.CalcularFatorial()}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro válido.");
        }
    }
}
**/

//Questão 05

using System;

class Sorteio
{
    private int numeroSorteado;
    private int tentativas;

    public Sorteio()
    {
        // Inicializando a classe Random para gerar números aleatórios
        Random random = new Random();

        // Gerando um número aleatório entre 0 e 10 (inclusive)
        numeroSorteado = random.Next(11);

        tentativas = 0;
    }

    public int NumeroSorteado
    {
        get { return numeroSorteado; }
    }

    public void RealizarSorteio(int numeroUsuario)
    {
        tentativas++;

        if (numeroUsuario == numeroSorteado)
        {
            Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativas} tentativa(s).");
        }
        else
        {
            Console.WriteLine($"Você errou. Tente novamente.");
        }
    }
}

class Program
{
    static void Main()
    {
        Sorteio sorteio = new Sorteio();
        int numeroUsuario;

        do
        {
            Console.Write("Digite um número de 0 a 10: ");
            string inputNumero = Console.ReadLine();

            if (int.TryParse(inputNumero, out numeroUsuario) && numeroUsuario >= 0 && numeroUsuario <= 10)
            {
                sorteio.RealizarSorteio(numeroUsuario);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido entre 0 e 10.");
            }

        } while (numeroUsuario != sorteio.NumeroSorteado);
    }
}








