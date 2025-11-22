using System.Collections;
using UnityEngine;

public class Ob2_Esfera : MonoBehaviour
{
    GameObject esfera;

    public bool isWhite;
    bool canSwap = true;

    void Awake()
    {
        esfera = gameObject;
    }

    void Update()
    {
        // Color NuevoColor = new Color
        // (
        //     UnityEngine.Random.Range(0f, 1f),
        //     UnityEngine.Random.Range(0f, 1f),
        //     UnityEngine.Random.Range(0f, 1f)
        // );
        // esfera.GetComponent<Renderer>().material.color = NuevoColor;
        // Debug.Log($"Color cambiado de {esfera.name}");
    }

    void FixedUpdate()
    {
        if (canSwap)
        {
            if (isWhite)
            {
                esfera.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Color cambiado de {esfera.name} a blanco.");
                isWhite = false;

            }
            else
            {
                esfera.GetComponent<Renderer>().material.color = Color.black;
                Debug.Log($"Color cambiado de {esfera.name} a negro.");
                isWhite = true;
            }
            StartCoroutine(waitToSwap(2f));
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
