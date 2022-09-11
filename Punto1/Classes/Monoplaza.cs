namespace ENTREGABLE2.Classes;
using ENTREGABLE2.Interface;

public abstract class Monoplaza : IMonoplazaInterface {


    public string scuderia="";
    protected bool movimiento;
    protected bool encendido;
    protected Random random;
     protected int valor;

    public Monoplaza(){
        random = new Random();
    }

 

   
    //Encender, solo se puede encender si el vehículo se encuentra apagado. 
    //Y además debe mostrar un mensaje indicando que está encendido.
    public bool Encender(){
        if(encendido && movimiento){
            Console.WriteLine("Vehiculo ya esta encendido \n");
            return true;
        }
          Console.WriteLine("Vehiculo encendido!");
          encendido=true;
          return false;
       
    }


    //Apagar, solo se puede apagar si el vehículo se encuentra encendido y está detenido.
    // Y además debe mostrar un mensaje indicando que está apagado.
    public bool Apagar(){
          if(encendido && movimiento==false){
            Console.WriteLine("Apagando vehiculo!");
            encendido = false;
            return true;
        }
        Console.WriteLine("Detenga el vehiculo para apagar! \n");
        return false;

    }


    //Detener: solo se puede detener si el vehículo está encendido y en movimiento 
    //Y además debe mostrar un mensaje indicando que está detenido.
    public bool Detener(){
          if(encendido && movimiento){
            Console.WriteLine("\nDeteniendo Vehiculo");
            movimiento = false;
            return true;
        }
       Console.WriteLine("El vehiculo no esta en movimiento \n");
       return false;

    }


    //Movimiento: solo se puede mover si el vehículo está encendido y detenido.
    // Y además debe mostrar un mensaje indicando que está en movimiento
    public bool Mover(){
          if(encendido && movimiento==false){
            Console.WriteLine("Vehiculo se esta moviendo");    
            movimiento=true;
            return true;
        }
        Console.WriteLine("vehiculo ya esta en movimiento\n");
        return false;

    }

    public void Lanzar(){
        valor = random.Next(100000, 9999999); 

    }

    public int MostrarNumero(){

        return valor;

    }


}