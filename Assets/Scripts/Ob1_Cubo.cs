using System;
using UnityEngine;

public class Ob1_Cubo : MonoBehaviour
{
    GameObject cubo;
    public float vRotacion;

    void Awake()
    {
        cubo = gameObject;
        Color NuevoColor = new Color
        (
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f)
        );
        cubo.GetComponent<Renderer>().material.color = NuevoColor;
        Debug.Log($"Color inicial de {cubo.name}");
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
