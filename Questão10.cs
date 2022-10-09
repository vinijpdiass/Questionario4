using System;
class relogio {
  static void Main() {
    int horas = 0, minutos = 0, segundos = 0, i = 0;  
    
    while(i == 0){
        segundos++;
        if (segundos == 60){
            minutos++;
            segundos = 0;
        }
        if (minutos == 60){
            horas++;
            minutos = 0;
            segundos = 0;
        }
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
        if(horas == 24){
            break;
        }
    }
  }
}
