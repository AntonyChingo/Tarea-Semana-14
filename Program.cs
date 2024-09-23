using System;

public class Nodo
{
    public int Valor;
    public Nodo Izquierdo;
    public Nodo Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}

public class ArbolBinario
{
    private Nodo raiz;

    // Método para insertar un nuevo valor en el árbol
    public void Insertar(int valor)
    {
        raiz = InsertarRec(raiz, valor);
    }

    private Nodo InsertarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
        {
            nodo = new Nodo(valor);
            return nodo;
        }

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRec(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRec(nodo.Derecho, valor);

        return nodo;
    }

    // Recorrido en inorden
    public void RecorridoInorden()
    {
        RecorridoInordenRec(raiz);
        Console.WriteLine();
    }

    private void RecorridoInordenRec(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorridoInordenRec(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            RecorridoInordenRec(nodo.Derecho);
        }
    }

    // Recorrido en preorden
    public void RecorridoPreorden()
    {
        RecorridoPreordenRec(raiz);
        Console.WriteLine();
    }

    private void RecorridoPreordenRec(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            RecorridoPreordenRec(nodo.Izquierdo);
            RecorridoPreordenRec(nodo.Derecho);
        }
    }

    // Recorrido en postorden
    public void RecorridoPostorden()
    {
        RecorridoPostordenRec(raiz);
        Console.WriteLine();
    }

    private void RecorridoPostordenRec(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorridoPostordenRec(nodo.Izquierdo);
            RecorridoPostordenRec(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArbolBinario arbol = new ArbolBinario();
        int opcion;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Recorrer en inorden");
            Console.WriteLine("3. Recorrer en preorden");
            Console.WriteLine("4. Recorrer en postorden");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor a insertar: ");
                    int valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;
                case 2:
                    Console.WriteLine("Recorrido en inorden:");
                    arbol.RecorridoInorden();
                    break;
                case 3:
                    Console.WriteLine("Recorrido en preorden:");
                    arbol.RecorridoPreorden();
                    break;
                case 4:
                    Console.WriteLine("Recorrido en postorden:");
                    arbol.RecorridoPostorden();
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 5);
    }
}
