double notaUm, notaDois, notaTres, notaQuatro, media;
string resultado;
ConsoleColor corResultado;

Console.Clear();
Console.WriteLine("-- Média --");
Console.WriteLine();
Console.WriteLine("Digite as suas notas abaixo.");

Console.Write("Nota 1: ");
notaUm = Convert.ToDouble(Console.ReadLine());
Console.Write("Nota 2: ");
notaDois = Convert.ToDouble(Console.ReadLine());
Console.Write("Nota 3: ");
notaTres = Convert.ToDouble(Console.ReadLine());
Console.Write("Nota 4: ");
notaQuatro = Convert.ToDouble(Console.ReadLine());

if (notaUm < 0.0 || notaUm > 10.0
   || notaDois < 0.0 || notaDois > 10.0
   || notaTres < 0.0 || notaTres > 10.0
   || notaQuatro < 0.0 || notaQuatro > 10.0)
{
    Console.WriteLine("Digite somente notas entre 0.0 e 10.0.");
}
else
{
    media = (notaUm + notaDois + notaTres + notaQuatro) / 4;
    
    if (media < 5.0)
    {
        corResultado = ConsoleColor.Red;
        resultado = "Reprovado";
    }
    else if (media < 6.0)
    {
        corResultado = ConsoleColor.Yellow;
        resultado = "Em recuperação";
    }
    else
    {
        corResultado = ConsoleColor.Green;
        resultado = "Aprovado";
    }

    Console.Write($"\nVocê ficou com média {media:N1}. Resultado: ");
    Console.ForegroundColor = corResultado;
    Console.WriteLine($"{resultado}");
    Console.ResetColor();
}
