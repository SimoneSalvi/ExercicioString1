using System.Runtime.CompilerServices;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe uma string: ");
        string palavra = Console.ReadLine().ToLower();

        // quantidade de caracteres

        Console.WriteLine($"Quantidade de caracteres: {palavra.Length}");

        // a quantidade de vogais

        ContarVogais(palavra);

        void ContarVogais(string x)
        {
            int contVogais = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if ((x[i] == 'a') || (x[i] == 'e') || (x[i] == 'i') || (x[i] == 'o') || (x[i] == 'u'))
                {
                    contVogais++;
                }
            }
            Console.WriteLine($"A quantidade de vogais no texto {palavra} é igual a {contVogais}");
        }

        // a quantidade de consoantes

        ContarConsoantes(palavra);

        void ContarConsoantes(string x)
        {
            int contConsoantes = 0;

            for (int i = 0; i < x.Length; i++)
            {

                if ((x[i] == 'a') || (x[i] == 'e') || (x[i] == 'i') || (x[i] == 'o') || (x[i] == 'u'))
                {
                    continue;
                }
                else
                {
                    contConsoantes++;
                }

            }
            Console.WriteLine($"A quantidade de consoantes no texto {palavra} é igual a {contConsoantes}");
        }

        // alterna a string, uma maiuscula e outra minuscula

        AlternaMaiusculaMinuscula(palavra);

        void AlternaMaiusculaMinuscula(string x)
        {
            string novaString = "\0";
            char a = '\0';
            for(int i = 0; i < x.Length; i++)
            {
                string textoMinusculo = x.ToLower();
                string textoMaiusculo = x.ToUpper();

                if (i%2 == 0)
                {
                    novaString += textoMinusculo[i];
                }
                else
                novaString += textoMaiusculo[i];
            }  
            Console.WriteLine($"Impressao alternada: {novaString}" );
        }

        // gere uma nova string espelhando a original

        EspelhaTexto(palavra);

        void EspelhaTexto(string x)
        {
            string espelho = "\0";

            for(int i = x.Length-1; i >= 0 ; i--)
            {
                espelho += x[i]; 
            }

            Console.WriteLine($"o espelho da strin {x} é {espelho}");
        }
    }
}