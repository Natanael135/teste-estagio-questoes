
using desafio_codigo_estagio;

Console.WriteLine("---------------Questao01-----------------------");
Questao01 questao01 = new Questao01();

Console.WriteLine("\n---------------Questao02----------------------");
Questao02 questao02 = new Questao02(21);

Console.WriteLine("\n---------------Questao03----------------------");
Questao03 questao03 = new Questao03("leitura.json");
questao03.CalcularFaturamento();

Console.WriteLine("\n---------------Questao04----------------------");
Questao04 questao04 = new Questao04();
questao04.CalcularPercentuais();

Console.WriteLine("\n---------------Questao05----------------------");
Questao05 questao05 = new Questao05("esse eh o exemplo, desafio estagio concluido");


Console.WriteLine("\nObrigado pela Oportunidade!!!");

