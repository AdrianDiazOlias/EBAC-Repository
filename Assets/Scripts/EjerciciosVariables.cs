using UnityEngine;

public class EjerciciosVariables : MonoBehaviour
{
    GameObject objeto;
    Renderer render;

    public string colorPar = "rojo";
    public string colorImpar = "azul";

    public int Entero = 0;
    public float Decimal = 1f;

    public float float1 = 5.75f;
    public float float2 = 3.25f;
    int sumFloats;

    float floatToString;
    string floatAsString;

    string nombreCompleto = "Adrian Diaz Olias";

    string strNumero1 = "1490";
    string strNumero2 = "8238";
    int numero1;
    int numero2;

    void Awake()
    {
        objeto = gameObject;
        if (objeto != null)
            Debug.Log("El objeto " + objeto.name + " ha sido asignado correctamente.");

        render = objeto.GetComponent<Renderer>();
        if (render != null)
            Debug.Log("El componente Renderer ha sido obtenido correctamente.");
    }

    void Start()
    {
        floatToString = Random.Range(0.000000000f, 1.000000000f);
        floatAsString = floatToString.ToString("F4");
        Debug.Log("El valor de floatToString como cadena (floatAsString) es: " + floatAsString);

        string nombre = nombreCompleto.Substring(0, 6);
        string apellido1 = nombreCompleto.Substring(7, 4);
        string apellido2 = nombreCompleto.Substring(12, 5);

        Debug.Log("Nombre: " + nombre);
        Debug.Log("Segundo Nombre: " + apellido1);
        Debug.Log("Apellido: " + apellido2);

        bool exito1 = int.TryParse(strNumero1, out numero1);
        bool exito2 = int.TryParse(strNumero2, out numero2);

        if (exito1 && exito2)
        {
            int sumaNumeros = numero1 + numero2;
            Debug.Log("La suma de " + numero1 + " y " + numero2 + " es: " + sumaNumeros);
        }

        string oracion = "Hola Mundo";
        string resultado = "";

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                resultado += oracion[i];
            }
        }
        Debug.Log("Caracteres en índices pares: " + resultado);


        string OraRem = oracion.Remove(0, 6);
        Debug.Log("Resultado usando Remove: " + OraRem);
    }

    void Update()
    {
        Entero++;
        Debug.Log("Valor de Entero: " + Entero);
    }

    void FixedUpdate()
    {
        Decimal *= 1.5f;
        Debug.Log("Valor de Decimal: " + Decimal);

        sumFloats = (int)(float1 + float2);
        Debug.Log("Suma de float1 y float2 convertida a entero: " + sumFloats);

        if (sumFloats % 2 == 0)
        {
            CambiarColorPar();
            Debug.Log("sumFloats es un número par.");
        }
        else
        {
            CambiarColorImpar();
            Debug.Log("sumFloats es un número impar.");
        }
    }

    void CambiarColorPar()
    {
        switch (colorPar)
        {
            case "rojo": render.material.color = Color.red; break;
            case "verde": render.material.color = Color.green; break;
            case "azul": render.material.color = Color.blue; break;
            case "amarillo": render.material.color = Color.yellow; break;
            case "blanco": render.material.color = Color.white; break;
            case "negro": render.material.color = Color.black; break;
            default: render.material.color = Color.magenta; break;
        }
    }

    void CambiarColorImpar()
    {
        switch (colorImpar)
        {
            case "rojo": render.material.color = Color.red; break;
            case "verde": render.material.color = Color.green; break;
            case "azul": render.material.color = Color.blue; break;
            case "amarillo": render.material.color = Color.yellow; break;
            case "blanco": render.material.color = Color.white; break;
            case "negro": render.material.color = Color.black; break;
            default: render.material.color = Color.magenta; break;
        }
    }
}
