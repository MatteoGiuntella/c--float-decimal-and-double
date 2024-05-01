// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Inserisci il raggio del cerchio:");
        string input = Console.ReadLine();

        // Converto l'input in un numero con il float
        float raggioFloat = float.Parse(input);
        // Calcolo l'area utilizzando il float
        float areaFloat = (float)(Math.PI * Math.Pow(raggioFloat, 2));
        // Math.Pow è un metodo nella classe Math di C# che restituisce un numero elevato a una potenza specificata. La sua firma è la seguente:double risultato = Math.Pow(2, 3); // Calcola 2 elevato alla 3 (2^3)
         // Ora, risultato conterrà 8
      
        Console.WriteLine($"Area calcolata con float: {areaFloat}");

        // Converto l'input in un numero a virgola mobile doppia con il double
        double raggioDouble = double.Parse(input);
        // Calcolo l'area utilizzando double
        double areaDouble = Math.PI * Math.Pow(raggioDouble, 2);
        Console.WriteLine($"Area calcolata con double: {areaDouble}");

        // Converto l'input in un numero decimale con decimal
        decimal raggioDecimal = decimal.Parse(input);
        // Calcolo l'area utilizzando decimal
        decimal areaDecimal = (decimal)(Math.PI * (double)Math.Pow((double)raggioDecimal, 2));
 
        Console.WriteLine($"Area calcolata con decimal: {areaDecimal}");
