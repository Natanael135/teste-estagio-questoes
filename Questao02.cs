using System;
/*  
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/
namespace desafio_codigo_estagio
{
    public class Questao02
    {
        private int numeroParaVerificar;

        public Questao02(int numero)
        {
            numeroParaVerificar = numero;
            VerificaNumeroNaSequencia();
        }

        private void VerificaNumeroNaSequencia()
        {
            int a = 0, b = 1;
            var sequencia = new System.Text.StringBuilder();

            sequencia.Append($"{a}");
            if (numeroParaVerificar == a)
            {
                ExibirResultado(true, sequencia.ToString());
                return;
            }

            sequencia.Append($", {b}");
            if (numeroParaVerificar == b)
            {
                ExibirResultado(true, sequencia.ToString());
                return;
            }

            while (true)
            {
                int proximo = a + b;
                a = b;
                b = proximo;

                sequencia.Append($", {proximo}");

                if (proximo == numeroParaVerificar)
                {
                    ExibirResultado(true, sequencia.ToString());
                    return;
                }

                if (proximo > numeroParaVerificar)
                {
                    ExibirResultado(false, sequencia.ToString());
                    return;
                }
            }
        }

        private void ExibirResultado(bool pertence, string sequencia)
        {
            if (pertence)
            {
                Console.WriteLine($"\nO número {numeroParaVerificar} pertence à sequência de Fibonacci.");
                Console.WriteLine($"Sequência de Fibonacci até o número recebido: {sequencia}");
            }
            else
            {
                Console.WriteLine($"\nO número {numeroParaVerificar} NÃO pertence à sequência de Fibonacci.");
            }

        }
    }
}
