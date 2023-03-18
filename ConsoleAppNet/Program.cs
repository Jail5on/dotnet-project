
Console.WriteLine("=============\r\nPar ou Ímpar?\r\n=============");
Console.Write("Informe um número qualquer: ");
int numero = int.Parse(Console.ReadLine()!);

string parImpar = numero % 2 == 0 ? "Par" : "Ímpar"; // operador ternário
Console.WriteLine($"O número {numero} é {parImpar}");
