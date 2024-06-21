Console.Clear();

int numero = -1;

Console.WriteLine("--- Entrada Válida ---\n");


while (numero < 0 || numero > 9)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\nDigite um número entre 1 e 9 (ou 0 para cancelar): ");
    numero = Convert.ToInt32(Console.ReadLine()!);
     Console.ResetColor();
}

if(numero == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("\nOperação cancelada.");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("\nVolte sempre.");
    Console.ResetColor();
}
else
{
    
    Console.Write("\nNúmero selecionado = ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{numero}\n");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Volte sempre.");
    Console.ResetColor();
}