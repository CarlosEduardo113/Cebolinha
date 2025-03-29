        // Cebolinha - Exercício 2 da Lista 2

        Console.Write("Digite uma frase qualquer: ");
        string frase = Console.ReadLine();

        string falaCebolinha = frase.Replace("r", "l").Replace("R", "L");

        Console.WriteLine("\nCebolinha falando: " + falaCebolinha);