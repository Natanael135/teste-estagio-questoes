using System;

/* 5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
*/

namespace desafio_codigo_estagio
{
    public class Questao05
    {
        private string stringParaInverter;

        // Construtor que recebe uma string obrigatória
        public Questao05(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
            {
                throw new ArgumentException("A string fornecida não pode ser nula ou vazia.", nameof(entrada));
            }

            stringParaInverter = entrada;
            InverterString();
        }

        // Método para inverter a string e exibir o resultado
        private void InverterString()
        {
            // Cria um array de caracteres para armazenar a string invertida
            char[] caracteresInvertidos = new char[stringParaInverter.Length];

            // Preenche o array com os caracteres da string original em ordem inversa
            for (int i = 0; i < stringParaInverter.Length; i++)
            {
                caracteresInvertidos[stringParaInverter.Length - 1 - i] = stringParaInverter[i];
            }

            // Converte o array de volta para uma string
            string stringInvertida = new string(caracteresInvertidos);

            // Exibe a string invertida
            Console.WriteLine($"String invertida: {stringInvertida}");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Cria uma instância da classe Questao05 com uma string
                Questao05 questao05 = new Questao05("Exemplo de string");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
