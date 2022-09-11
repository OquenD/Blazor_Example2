namespace ENTREGABLE2.Classes;
using ENTREGABLE2.Interface;
using System.Collections.Generic;

public class Pastel : IPastelInterface{

    public string nombre="";
    public int size=0;
    private float total =0;

    //Inicializamos la lista de ingredientes
    List<Ingrediente> ListaIngredientes = new List<Ingrediente>();

    
    public float CalcularCosto(){
        foreach (Ingrediente ingrediente in ListaIngredientes){
                 total= total + ingrediente.price;
        }
    return total;
   }

   
    //Recorrer la lista, cada item es una instancia de la clase Ingrediente
    public void ListarIngredientes(){
       for(int i= 0; i < ListaIngredientes.Count; i++){
            Console.WriteLine(ListaIngredientes[i]);
        }

        foreach (Ingrediente ingrediente in ListaIngredientes){
            Console.WriteLine(ingrediente);
        }
    }

    //Devuelve cuantos items tiene la lista
    public int CantidadIngredientes(){
        int count = ListaIngredientes.Count;
        return count;
    }


    //Agregando un ingrediente a la lista
    public void AgregarIngrediente(string nombre, int cantidad, float precio){
        ListaIngredientes.Add(new Ingrediente( nombre.ToUpper(),  cantidad, precio));
    }

    //Eliminar elemento
     public void ElimarIngrediente(string nombre){
        int pos=0;
          for(int i= 0; i < ListaIngredientes.Count; i++){
            if (ListaIngredientes[i].name==nombre.ToUpper()){
                pos = i;
                ListaIngredientes.RemoveAt(pos);
                break;
            }
        
        }
    }

}
