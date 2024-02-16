// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tipo DateTime tratando data e hora");
Console.WriteLine();

DateTime dataAtual = DateTime.Now;  // pegando a data e a hora de agora


// pegando uma data especifica: ano/mes/dia

DateTime dataHoje = new DateTime(2024, 02, 16);

// definindo hora

DateTime dataHoraHoje = new DateTime(2024, 02, 16, 12, 08, 00);


Console.WriteLine(dataAtual);
Console.WriteLine();
Console.WriteLine(dataHoje);
Console.WriteLine();
Console.WriteLine(dataHoraHoje);
Console.WriteLine();

// extraindo informações da variavel dataAtual
Console.WriteLine(dataAtual.Year); // somente o ano
Console.WriteLine(dataAtual.Day); // somente o dia
Console.WriteLine(dataAtual.Hour); // somente a hora
Console.WriteLine(dataAtual.Month); // somente o mes
Console.WriteLine(dataAtual.DayOfWeek); // dia da semana
Console.WriteLine(dataAtual.DayOfYear); // dia do ano

// data e horas no formato mais longo e mais curto
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());




