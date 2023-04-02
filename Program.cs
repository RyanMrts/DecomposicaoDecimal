int n1, unidade, dezena, centena, Nalterado;

Console.WriteLine("Digite um numero inteiro: ");
n1 = Convert.ToInt32(Console.ReadLine());

Nalterado=n1;

unidade = Nalterado % 10;
Nalterado /= 10;

dezena = Nalterado % 10;
Nalterado/= 10;

centena = Nalterado;

Console.WriteLine($"O numero {n1} possui: ");
Console.WriteLine($"{unidade} unidade(s) ");
Console.WriteLine($"{dezena} dezena(s)");
Console.WriteLine($"{centena} centena(s)");
