using System;

class Pimentao 
{  
    public static void Main() 
    {
      
      int a,b,t,x;
      int opcao;


      Console.WriteLine ("1 - Pimentão vermelho:");
      Console.WriteLine ("2 - Pimentão amarelo:");
      Console.WriteLine ("3 - Total:");
      Console.WriteLine ("4 - Sair");

      
      while
      {
        double notaEntradaConsole = double.Parse(Console.ReadLine());
        
        if (notaEntradaConsole < 0 || notaEntradaConsole > 10)
        {
          Console.WriteLine("nota invalida");
        } 
        else 
        {
          contador++;
          
          somaDasNotas += notaEntradaConsole; 
        }    
      } 
      while (contador < 2);
      
      Console.WriteLine("media = " + (somaDasNotas / 2).ToString("N2"));
    }
}
