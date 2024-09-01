using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

/* 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;*/
namespace desafio_codigo_estagio
{
    public class FaturamentoDiario
    {
        public string Dia { get; set; }
        public decimal Valor { get; set; }
    }

    public class Questao03
    {
        private string jsonFilePath;

        // Construtor que recebe o caminho do arquivo JSON
        public Questao03(string caminhoJson)
        {
            jsonFilePath = caminhoJson;
        }

        // Método para calcular e exibir os resultados
        public void CalcularFaturamento()
        {
            try
            {
                // Ler o arquivo JSON
                string jsonData = File.ReadAllText(jsonFilePath);

                // Desserializar o JSON para uma lista de objetos FaturamentoDiario
                List<FaturamentoDiario> faturamentos = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(jsonData);

                // Filtrar os dias com faturamento (não zero)
                var diasComFaturamento = faturamentos.Where(f => f.Valor > 0).ToList();

                if (diasComFaturamento.Count == 0)
                {
                    Console.WriteLine("Nenhum faturamento registrado.");
                    return;
                }

                // Calcular o menor e maior valor de faturamento
                decimal menorFaturamento = diasComFaturamento.Min(f => f.Valor);
                decimal maiorFaturamento = diasComFaturamento.Max(f => f.Valor);

                // Calcular a média mensal de faturamento
                decimal mediaFaturamento = diasComFaturamento.Average(f => f.Valor);

                // Contar o número de dias com faturamento superior à média
                int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaFaturamento);

                // Exibir os resultados
                Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
                Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");
                Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
