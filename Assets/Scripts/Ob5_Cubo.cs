using Unity.VisualScripting;
using UnityEngine;

public class Ob5_cubo : MonoBehaviour
{
    GameObject cubo;

    public Ob3_Cilindro cilindro3;
    public Ob4_Cilindro cilindro4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = gameObject;
    }

    void FixedUpdate()
    {
        // Color NuevoColor = new Color
        //     (
        //         UnityEngine.Random.Range(0f, 1f),
        //         UnityEngine.Random.Range(0f, 1f),
        //         UnityEngine.Random.Range(0f, 1f)
        //     );
        // cilindro.GetComponent<Renderer>().material.color = NuevoColor;
        // Debug.Log($"Color cambiado de {cilindro.name}");

        if (!cilindro3.isWhite && !cilindro4.isWhite)
        {
            cubo.GetComponent<Renderer>().material.color = Color.white;
            Debug.Log($"Color cambiado de {cubo.name} a blanco.");
        }
        else
        {
            cubo.GetComponent<Renderer>().material.color = Color.black;
            Debug.Log($"Color cambiado de {cubo.name} a negro.");
        }
    }

    void OnEnable()
    {
        string GoName = gameObject.name;
        Debug.LogWarning($"El script {GoName} ha sido habilitado.");
    }

    void OnDisable()
    {
        string GoName = gameObject.name;
        Debug.LogWarning($"El script {GoName} ha sido deshabilitado.");
    }
}
