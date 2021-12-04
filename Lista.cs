using System;
using System.Collections.Generic;
using System.Text;

namespace S01_ListaEnlazada
{
    class Lista
    {
        //Punteros
        private Nodo Primero = new Nodo();//Cabeza
        private Nodo Ultimo = new Nodo();

        //Constructor
        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        //Insertar datos en la lista enlazada
        public void insertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("Inserte el dato que contendrá el nuevo nodo : ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            //DEfinir primer elemento (Cabeza)
            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;//15
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            Console.WriteLine("\nNodo Ingresado\n");
        }
        public void buscarNodo()
        {
            //Primer nodo
            Nodo Actual = new Nodo();
            Actual = Primero;
            //Romper el ciclo una vez que se encuentre el nodo
            bool Encontrado = false;
            //Asignar valor a buscar
            Console.Write("Ingrese el dato del nodo a buscar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());

            if(Primero != null)
            {
                //Hay nodos en la lista
                while (Actual != null && Encontrado != true)
                {
                    //Comparar los datos de la lista  de nodos con el nodo buscado
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\nEl nodo con el dato ( {0} ) encontrado", nodoBuscado);
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo no ha sido encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\nLa lista enlazada está vacia\n");
            }
        }
        public void modificarNodo()
        {
            //PRimer nodo
            Nodo Actual = new Nodo();
            Actual = Primero;
            //Romper ciclo una vez que se encuentre el nodo
            bool Encontrado = false;
            Console.WriteLine("Ingrese dato del nodo a buscar para reemplazar");
            int nodoBuscado = int.Parse(Console.ReadLine());

            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\nEl nodo con el dato {0} ) encontrado", nodoBuscado);
                        Console.Write("Ingrese un nuevo dato para este nodo : ");
                        Actual.Dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Nodo modificado \n");
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\nNodo no encontrado\n");
                }
            }
            else 
            {
                Console.WriteLine("\nLa lista se encuentra vacia \n");
            }
        }
        public void eliminarNodo()
        {
            //Primer nodo
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;
            bool Encontrado = false;
            Console.Write("Ingrese el dato del nodo a buscar para eliminar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());

            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\nEl nodo con el dato ( {0} ) encontrado", nodoBuscado);

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Console.WriteLine("\nNodo eliminado\n");
                        Encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Nodo no encontrado\n");
                }
            }
            else
            {
                Console.WriteLine("\n Lista vacia \n");
            }

        }
        public void vaciarLista()
        {
            Primero = null;
        }

        public void ordenarLista()
        {
            int aux;
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Siguiente = new Nodo();
            Siguiente = Ultimo;
            if (Actual != null)
            {
                Actual = Primero;
                while (Actual.Siguiente != null)
                {
                    Siguiente = Actual.Siguiente;
                    while(Siguiente != null)
                    {
                        if (Siguiente.Dato < Actual.Dato){
                            aux = Actual.Dato;
                            Actual.Dato = Siguiente.Dato;
                            Siguiente.Dato = aux;
                        }
                        Siguiente = Siguiente.Siguiente;
                    }
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La Lista se encuentra vacia \n");
            }
        }
        public void desplegarLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            //Verificar si el primer nodo no esta vacio
            if(Primero != null)
            {
                //Hay nodos(datos) en la lista
                while (Actual != null)
                {
                    Console.WriteLine("{0} ", Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }else
            {
                Console.WriteLine("\nLa lista esta vacia\n");
            }
        }
    }
}
