using Unity.VisualScripting;
using UnityEngine;

public class Ob3_Cilindro : MonoBehaviour
{
    GameObject cilindro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cilindro = gameObject;
    }

    void FixedUpdate()
    {
        Color NuevoColor = new Color
            (
                UnityEngine.Random.Range(0f, 1f),
                UnityEngine.Random.Range(0f, 1f),
                UnityEngine.Random.Range(0f, 1f)
            );
        cilindro.GetComponent<Renderer>().material.color = NuevoColor;
        Debug.Log($"Color cambiado de {cilindro.name}");
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
