using System;


/* 1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?*/
namespace desafio_codigo_estagio
{
    public class Questao01
    {
        // Construtor da classe
        public Questao01()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k += 1;
                soma += k;
            }

            Console.WriteLine($"O número no final da soma é {soma}");

        }
    }
}
