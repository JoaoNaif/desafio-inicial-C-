namespace Desafio1;

class Program
{
    static void Main()
    {
        Desafio desafio = new Desafio();

        // Primeiro desafio e segundo desafio
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        
        // Terceiro desafio
        Console.WriteLine("Primeiro número: ");
        double primeiroNumero = double.Parse(Console.ReadLine());
        Console.WriteLine("Segundo número: ");
        double segundoNumero = double.Parse(Console.ReadLine());
        
        // Quarto desafio
        Console.WriteLine("Digite sua palavra: ");
        string palavra = Console.ReadLine();
        
        desafio.ExibirNome(nome, sobrenome);
        desafio.Matematica(primeiroNumero, segundoNumero);
        desafio.ContarPalavras(palavra);
        
        
        
        // Quinto desafio
        Console.WriteLine("Digite sua placa (Ex: SFD-4325): ");
        string placa = Console.ReadLine();
        bool verificacao = desafio.VerificarPlaca(placa);
        
        Console.WriteLine(verificacao ? "Aprovado" : "Reprovado");

        // Sexto desafio
        DateTime data = DateTime.Now;
        Console.WriteLine(data.ToString("dd/MM/yyyy"));
        Console.WriteLine(data.ToString("HH:mm:ss"));
        Console.WriteLine(data.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}

