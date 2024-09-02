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

        public Questao05(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
            {
                throw new ArgumentException("A string fornecida não pode ser nula ou vazia.", nameof(entrada));
            }

            stringParaInverter = entrada;
            InverterString();
        }

        private void InverterString()
        {

            char[] caracteresInvertidos = new char[stringParaInverter.Length];


            for (int i = 0; i < stringParaInverter.Length; i++)
            {
                caracteresInvertidos[stringParaInverter.Length - 1 - i] = stringParaInverter[i];
            }

            string stringInvertida = new string(caracteresInvertidos);

            Console.WriteLine($"String invertida: {stringInvertida}");
        }
    }
}
