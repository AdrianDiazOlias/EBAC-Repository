using Unity.VisualScripting;
using UnityEngine;

public class Ob4_Cilindro : MonoBehaviour
{
    GameObject cilindro;
    public bool isWhite;

    public Ob1_Cubo cubo;
    public Ob2_Esfera esfera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cilindro = gameObject;
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

        if (cubo.isWhite || esfera.isWhite)
        {
            cilindro.GetComponent<Renderer>().material.color = Color.white;
            isWhite = true;
            Debug.Log($"Color cambiado de {cilindro.name} a blanco.");
        }
        else
        {
            cilindro.GetComponent<Renderer>().material.color = Color.black;
            isWhite = false;
            Debug.Log($"Color cambiado de {cilindro.name} a negro.");
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
