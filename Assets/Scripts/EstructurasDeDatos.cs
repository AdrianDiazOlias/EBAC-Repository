using UnityEngine;
using System;
using
System.Linq;
using
 System.Collections.Generic;
public class EstructurasDeDatos : MonoBehaviour
{
    System.Random random = new System.Random();
    public List<int> lista1;
    void Start()
    {
        lista1 = ListaAleatoria(10, 1, 100);
        Debug.Log("Lista de 10 numeros aleatoria" + string.Join(", ", lista1));

        int[] arrayDesordenado = { 5, 3, 8, 1, 2 }; int[] arrayOrdenado = OrdenarDescendente(arrayDesordenado);
        Debug.Log("Array desordenado:" + string.Join(", ", arrayDesordenado));
        Debug.Log("Array ordenado descendiente:" + string.Join(", ", arrayOrdenado));

        List<int> listaConDuplicados = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 6, 7, 7, 8, 9, 9, 10, 10 };
        HashSet<int> listaSinDuplicados = QuitarDuplicados(listaConDuplicados);
        Debug.Log("Lista con duplicados" + string.Join(", ", listaConDuplicados));
        Debug.Log("Lista sin duplicados" + string.Join(", ", listaSinDuplicados));

        Stack<string> pila = new Stack<string>();
        pila.Push("Elemento 1");
        pila.Push("Elemento 2");
        pila.Push("Elemento 3");
        pila.Push("Elemento 4");
        pila.Push("Elemento 5");
        PilaYCola(pila);
    }

    public List<int> ListaAleatoria(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> List = new List<int>(tamaño);
        for (int i = 0; i < tamaño; i++)
        {
            int numeroAleatorio = random.Next(rangoInferior, rangoSuperior + 1);
            List.Add(numeroAleatorio);
        }
        return List;
    }

    public int[] OrdenarDescendente(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        return array;
    }

    public HashSet<T> QuitarDuplicados<T>(List<T> lista)
    {
        return new HashSet<T>(lista.Distinct());
    }

    public void PilaYCola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();
        Debug.Log("Contenido de la PILA (LIFO):");
        while (pila.Count > 0)
        {
            string valor = pila.Peek();
            Debug.Log("Peek: " + valor);
            cola.Enqueue(valor);
            pila.Pop();
        }


        Debug.Log("Contenido de la COLA (FIFO):");
        while (cola.Count > 0)
        {
            string valor = cola.Peek();
            Debug.Log("Peek: " + valor);
            cola.Dequeue();
        }
    }
}