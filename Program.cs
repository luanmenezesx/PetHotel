Console.Clear();

string especie, raca, nome, idade, cor;

Console.WriteLine("Qual é a espécie do seu pet?");
especie = Console.ReadLine()!;

Console.WriteLine("Qual é a raça do seu pet?");
raca = Console.ReadLine()!;

Console.WriteLine("Qual é o nome do seu pet?");
nome = Console.ReadLine()!;

Console.WriteLine("Qual é a idade do seu pet?");
idade = Console.ReadLine()!;

Console.WriteLine("Qual é a cor do seu pet?");
cor = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("|                    ");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("Pet Hotel \"PetLuxo\"");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("                  |");
Console.WriteLine("+=========================================================+");
Console.Write("| ");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Espécie: ");
Console.Write(especie.ToUpper().PadLeft(19, '.').Substring(0, 19));

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" | ");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Raça: ");
Console.Write(raca.ToUpper().PadLeft(19, '.').Substring(0, 19));

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("|");
Console.WriteLine("+=========================================================+");
Console.Write("| ");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Atende pela alcunha de: ");
Console.Write(especie.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" |");
Console.Write("| ");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Idade: ");
Console.Write(idade.ToUpper().PadLeft(2, '0').Substring(0, 2));
Console.Write(" ano(s) ");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("| ");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Pelagem/cor: ");
Console.Write(cor.ToUpper().PadLeft(23, '.').Substring(0, 23));

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");

Console.ResetColor();