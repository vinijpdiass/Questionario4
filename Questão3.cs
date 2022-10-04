using System;
class questão3 {
  static void Main() {
    int conjunto, numero, i,  menornumero = 1000000;
      
    Console.WriteLine("diga o tamanho do seu conjunto");
    conjunto = int.Parse(Console.ReadLine());

    for(i = 1; i <= conjunto; i++){
        Console.WriteLine("escreva um numero inteiro");
        numero = int.Parse(Console.ReadLine());
        
        if(numero < menornumero){
            menornumero = numero;
        }
    }   
    Console.WriteLine($"o menor numero do conjunto é {menornumero}"); 
      
  }
}
