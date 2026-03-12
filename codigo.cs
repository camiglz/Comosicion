hola profe 
// Camila Gonzalez Mota
// Inicio de còdigo

using System;

public class Computadora
{
  //método para que encienda 
  public void Encender()
  {
     Console.WriteLine("La computadora está encendida");
     procesador.MostrarMarca();
  }
  //composicion
  private Procesador procesador;
  
  //constrcutor
  public Computadora()
  {
      procesador = new Procesador(); 
      procesador.Marca="Intel";
  }
  
}
public class Procesador
{
    //creaciòn de atrbiuto con operadores de acceso
    public string Marca {get; set;}
   
    //Metodo 
    public void MostrarMarca()
     {
     
     Console.WriteLine($"Procesador es de la marca {Marca}");
     }
}
class Program
{
 //programa principal
    static void Main()
    {
        Computadora mac= new Computadora();
        mac.Encender();
    }
}
