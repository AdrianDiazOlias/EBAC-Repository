using UnityEngine;

public class CiclosyArreglos : MonoBehaviour
{
    void Start()
    {
        int tamaño = 10;

        int[] arr1 = new int[tamaño];
        int[] arr2 = new int[tamaño];
        int[] arr3 = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
        {
            arr1[i] = Random.Range(0, 100);
            arr2[i] = Random.Range(0, 100);
        }

        for (int i = 0; i < tamaño; i++)
        {
            arr3[i] = arr1[i] + arr2[i];
        }

        for (int i = 0; i < tamaño; i++)
        {
            Debug.Log($"arr1[{i}] = {arr1[i]}, arr2[{i}] = {arr2[i]}, arr3[{i}] = {arr3[i]}");
        }


        string oracion = "Oración de ejemplo para dividir en palabras";
        string[] palabras = oracion.Split(' ');
        string oraRecons = "";

        foreach (string palabra in palabras)
        {
            Debug.Log("Palabra: " + palabra);
            oraRecons += palabra + " ";
        }
        Debug.Log("Oración completa: " + oraRecons);


        int[,] A = new int[2, 2]
        {
            { 2, 3 },
            { 4, 5 }
        };

        int[] B = new int[2] { 1, 2 };

        int[] R = new int[2];


        R[0] = A[0, 0] * B[0] + A[0, 1] * B[1];
        R[1] = A[1, 0] * B[0] + A[1, 1] * B[1];

        Debug.Log($"[R0{R[0]}, R1:{R[1]}]");
    }
}
