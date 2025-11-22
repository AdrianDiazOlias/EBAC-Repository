using System;
using System.Collections;
using UnityEngine;

public class Ob1_Cubo : MonoBehaviour
{
    GameObject cubo;

    public bool isWhite;
    bool canSwap = true;

    void Awake()
    {
        cubo = gameObject;
        // Color NuevoColor = new Color
        // (
        //     UnityEngine.Random.Range(0f, 1f),
        //     UnityEngine.Random.Range(0f, 1f),
        //     UnityEngine.Random.Range(0f, 1f)
        // );
        // cubo.GetComponent<Renderer>().material.color = NuevoColor;
        // Debug.Log($"Color inicial de {cubo.name}");
    }

    void FixedUpdate()
    {
        if (canSwap)
        {
            if (isWhite)
            {
                cubo.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Color cambiado de {cubo.name} a blanco.");
                isWhite = false;

            }
            else
            {
                cubo.GetComponent<Renderer>().material.color = Color.black;
                Debug.Log($"Color cambiado de {cubo.name} a negro.");
                isWhite = true;
            }
            StartCoroutine(waitToSwap(1f));
        }
    }

    private IEnumerator waitToSwap(float seconds)
    {
        canSwap = false;
        yield return new WaitForSeconds(seconds);
        canSwap = true;
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
