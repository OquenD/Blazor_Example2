namespace ENTREGABLE2.Interface;

public interface IPastelInterface
{
public float CalcularCosto();
public void ListarIngredientes();
public int CantidadIngredientes(); 
public void AgregarIngrediente(string nombre, int cantidad, float precio);
public void ElimarIngrediente(string nombre);

}

