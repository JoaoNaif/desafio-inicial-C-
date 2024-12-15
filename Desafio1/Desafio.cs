namespace Desafio1;

public class Desafio
{
    public void ExibirNome(string nome, string sobrenome)
    {
        Console.WriteLine($"Olá, {nome + " " + sobrenome}! Seja muito bem vindo!");
    }

    public void Matematica(double num1, double num2)
    {
        Console.WriteLine($"A soma dos dois é {num1 + num2}");
        Console.WriteLine($"A subtração dos dois é {num1 - num2}");
        Console.WriteLine($"A multiplicação dos dois é {num1 * num2}");
        Console.WriteLine($"{(num2 == 0 ? "Não é possível divisão por zero" : $"A divisão dos dois é {num1 / num2}")}");
        Console.WriteLine($"A média dos dois {(num1 + num2) / 2}");
    }

    public void ContarPalavras(string palavra)
    {
        string palavraSemEspacos = palavra.Replace(" ", "");
        Console.WriteLine($"{palavra} tem {palavraSemEspacos.Length} caracteres!");
    }

    public bool VerificarPlaca(string placa)
    {
        bool resultado = true;
        
        string[] dividirNumeroELetra = placa.Split('-');
        string letras = dividirNumeroELetra[0].ToUpper();
        
        string[] resultadoLetras = letras.Select(c => c.ToString()).ToArray();
        
        resultado = VerificarLetras(resultadoLetras);
        
        int[] numerais = dividirNumeroELetra[1].Select(c =>
        {
            if (int.TryParse(c.ToString(), out int number))
            {
                return number;
            }
            else
            {
                resultado = false;
                return 0;
            }
        }).ToArray();

        if (resultado)
        {
            resultado = VerificarNumeros(numerais);
        }

        return resultado;
    }

    public bool VerificarLetras(string[] resultadoLetras)
    {
        string[] alfabeto = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
        
        bool resultado = resultadoLetras.Length == 3;
        
        foreach (var item in resultadoLetras)
        {
            if (!alfabeto.Contains(item))
            {
                resultado = false;    
            }
        }

        return resultado;
    }

    public bool VerificarNumeros(int[] numeros)
    {
        int[] numerais = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        
        bool resultado = numeros.Length == 4;

        foreach (var item in numeros)
        {
            if (!numerais.Contains(item))
            {
                resultado = false;
            }
        }
        
        return resultado;
    }
}