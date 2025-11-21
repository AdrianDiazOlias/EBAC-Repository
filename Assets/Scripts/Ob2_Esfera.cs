using System.Collections;
using UnityEngine;

public class Ob2_Esfera : MonoBehaviour
{
    public Material goldMaterial;
    public Material silverMaterial;

    public float SwapDelay = 1f;

    private bool canSwap = true;
    private Renderer obMat;

    void Awake()
    {
        obMat = GetComponent<Renderer>();
    }

    void Update()
    {
        if (canSwap)
            StartCoroutine(SwapMat());
    }

    private IEnumerator SwapMat()
    {
        canSwap = false;

        yield return new WaitForSeconds(SwapDelay);

        if (obMat.sharedMaterial == goldMaterial)
        {
            obMat.sharedMaterial = silverMaterial;
            Debug.Log("Cambiado a plata");
        }
        else
        {
            obMat.sharedMaterial = goldMaterial;
            Debug.Log("Cambiado a oro");
        }

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
