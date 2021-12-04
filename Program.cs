using System;

namespace S01_ListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de la clase lista
            Lista l = new Lista();
            int opcionMenu = 0;
            do
            {
                Console.WriteLine("\n|------------------------------------------------ |");
                Console.WriteLine("\n|                   LISTA SIMPLE                  |");
                Console.WriteLine("\n|------------------------------------------------ |");
                Console.WriteLine("\n| 1. Insertar             |         4. Eliminar   |");
                Console.WriteLine("\n| 2. Buscar               |         5. Desplegar  |");
                Console.WriteLine("\n| 3. Modificar            |         6. Vaciar     |");
                Console.WriteLine("\n| 7. Ordenar              |         8. Salir      |");
                Console.WriteLine("\n|------------------------------------------------ |");
                Console.Write("Escoja una opción : ");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n\n Inserta nodo en la lista \n");
                        l.insertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n\n Buscar nodo en la lista \n");
                        l.buscarNodo();
                        break;
                    case 3:
                        Console.WriteLine("\n\n Modificar nodo en la lista \n");
                        l.modificarNodo();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Eliminar nodo en la lista \n");
                        l.eliminarNodo();
                        break;
                    case 5:
                        Console.WriteLine("\n\n Desplegar nodo en la lista \n");
                        l.desplegarLista();
                        break;
                    case 6:
                        Console.WriteLine("\n\n Vaciar Lista \n");
                        l.vaciarLista();
                        break;
                    case 7:
                        Console.WriteLine("\n\n Ordenar Lista \n");
                        l.ordenarLista();
                        break;
                    default:
                        Console.WriteLine("\n\n Fin del programa \n");
                        break;
                }
            } while (opcionMenu != 8);
            Console.Read();
        }
    }
}
