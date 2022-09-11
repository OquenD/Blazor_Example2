using ENTREGABLE2.Classes;

bool condicion = true;
string nameIngrediente;
int cantIngrediente;
float precioIngrediente;

Pastel pastel = new Pastel();

while (condicion)
{
    Console.WriteLine("\nIngrese el nombre del Pastel (1)"); 
    Console.WriteLine("Ingrese un ingrediente (2)"); 
    Console.WriteLine("Listar Ingredientes (3)");
    Console.WriteLine("Calcular Cantidad de Ingredientes(4)");
    Console.WriteLine("Calcular Costo(5)");
    Console.WriteLine("Exit (0)");

    int menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Console.WriteLine("\nNOMBRE: ");      
            pastel.nombre = (Console.ReadLine()).ToUpper();
            break;

        case 2:
        
            Console.WriteLine("\nIngrese el nombre del ingrediente"); 
            nameIngrediente= (Console.ReadLine()).ToUpper();
            Console.WriteLine("\nIngrese la Cantidad"); 
            cantIngrediente = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese el precio del ingrediente"); 
            precioIngrediente= float.Parse(Console.ReadLine());
            pastel.AgregarIngrediente(nameIngrediente,cantIngrediente,precioIngrediente);
            break; 

        case 3:
            Console.WriteLine($"\n{pastel.nombre} ");     
            Console.WriteLine("INGREDIENTES: ");         
            pastel.ListarIngredientes();
            break; 

        case 4:
            Console.WriteLine($"\n{pastel.nombre} ");     
            Console.WriteLine("CANTIDAD DE INGREDIENTES: "); 
            Console.WriteLine(pastel.CantidadIngredientes());
            break; 

        case 5:
            Console.WriteLine($"\n{pastel.nombre} ");     
            Console.WriteLine("COSTO DEL PASTEL: "); 
            Console.WriteLine(pastel.CalcularCosto()); 
            break; 

        case 0:
        default: 
            condicion = false;
            break;
    }
}

