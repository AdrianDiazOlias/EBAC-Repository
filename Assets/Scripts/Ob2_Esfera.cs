using System.Collections;
using UnityEngine;

public class Ob2_Esfera : MonoBehaviour
{
    GameObject esfera;
    public float SwapDelay = 1f;

    private bool canSwap = true;

    void Awake()
    {
        esfera = gameObject;
    }

    void Update()
    {
        Color NuevoColor = new Color
        (
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f)
        );
        esfera.GetComponent<Renderer>().material.color = NuevoColor;
        Debug.Log($"Color cambiado de {esfera.name}");
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
