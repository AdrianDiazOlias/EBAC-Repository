using UnityEngine;

public class Ob3_Cilindro : MonoBehaviour
{
    public float vCrecimiento;

    private Transform trans;
    private float maxHeight = 2f;
    private float minHeight = 0.25f;
    private bool isGrowing = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // modify a copy of the Vector3 and assign it back to avoid modifying the return value of localScale
        Vector3 scale = trans.localScale;

        if (isGrowing)
        {
            scale.y += 0.01f * vCrecimiento;
            if (scale.y >= maxHeight)
                isGrowing = false;
        }
        else
        {
            scale.y -= 0.01f * vCrecimiento;
            if (scale.y <= minHeight)
                isGrowing = true;
        }

        trans.localScale = scale;
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
