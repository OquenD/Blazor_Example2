namespace ENTREGABLE2.Classes;
using ENTREGABLE2.Interface;

public class Circuito{

    private IMonoplazaInterface Mono;


    public string nombre="";
    protected bool monoPresente;
    protected Random random;
    protected int vueltas;
    protected int []tiempo;
    
    protected int i=0;

    public Circuito(IMonoplazaInterface M){
        Mono = M;
    }
     public Circuito(){
        random = new Random();
    }

    public bool Evaluar(){
        if (monoPresente)
        {
            return true;
        }
        return false;
    }
    
    //Este solo va asignar un monoplaza al circuito siempre y 
    //cuando no haya un monoplaza en el circuito y no emite ningún mensaje.
    public void AgregarMonoplaza (){
        if(Evaluar()==false)
        {  
           monoPresente = true;
        }
       
    }

    //Este solo va sacar el monoplaza del circuito siempre y
    // cuando haya un monoplaza en el circuito y no emite ningún mensaje
    public void SacarMonoplaza (){
         if(Evaluar())
        {  monoPresente = false;
        }

    }
    

    //Esta acción es donde el monoplaza dará N cantidades de vueltas al circuito, 
    // La forma de calcular el tiempo será en un número aleatorio de 6 cifras, 
    // en cada vuelta se debe imprimir el tiempo de vuelta y al final se entregará el mejor tiempo.
    public string Realizarprueba(int vueltas){
        if(Evaluar())
        {  
            while (i>vueltas)
             tiempo[i] = random.Next(1000000, 999999);
             i++;
            
            return"Prueba Finalizada";
        }
        return "El mono plaza no se encuentra en el circuito";
    }



}